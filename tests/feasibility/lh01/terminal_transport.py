"""DE: Isolierte PTY-/ConPTY-Transportgrenze. EN: Isolated PTY/ConPTY transport.

ConPTY follows Microsoft's synchronous-pipe example, with independent reader and
writer threads. No shell evaluation, installation or physical-terminal claim.
https://learn.microsoft.com/en-us/windows/console/creating-a-pseudoconsole-session
"""
import os
import subprocess


class UnixTerminal:
    def __init__(self, command, cwd, env, scenario):
        import fcntl, pty, struct, termios
        self.fcntl, self.struct, self.termios = fcntl, struct, termios
        self.master, self.slave = pty.openpty()
        self.resize(100, 24, signal_child=False)
        self.before = termios.tcgetattr(self.slave)
        def setup():
            os.setsid()
            fcntl.ioctl(2, termios.TIOCSCTTY, 0)
        self.process = subprocess.Popen(command, cwd=cwd, env=env,
            stdin=subprocess.PIPE if scenario == 'InputRedirect' else self.slave,
            stdout=subprocess.PIPE if scenario == 'Redirect' else self.slave,
            stderr=self.slave, preexec_fn=setup)
        self.fds = [self.master] + ([self.process.stdout.fileno()] if scenario == 'Redirect' else [])
        for fd in self.fds:
            os.set_blocking(fd, False)

    def read(self, wait=.05):
        import select
        chunks = []
        for fd in select.select(self.fds, [], [], wait)[0]:
            try:
                chunk = os.read(fd, 65536)
            except OSError:
                continue
            if chunk:
                chunks.append((fd, chunk))
        return chunks

    def write(self, data):
        os.write(self.master, data)

    def resize(self, width, height, signal_child=True):
        import signal
        self.fcntl.ioctl(self.slave, self.termios.TIOCSWINSZ,
                        self.struct.pack('HHHH', height, width, 0, 0))
        if signal_child:
            os.killpg(self.process.pid, signal.SIGWINCH)

    def sample(self):
        return self.termios.tcgetattr(self.slave)

    def poll(self):
        return self.process.poll()

    def terminate(self):
        import signal
        os.killpg(self.process.pid, signal.SIGTERM)
        try:
            self.process.wait(timeout=3)
        except subprocess.TimeoutExpired:
            os.killpg(self.process.pid, signal.SIGKILL)
            self.process.wait()

    def close(self):
        os.close(self.master)
        os.close(self.slave)


class WindowsTerminal:
    """ConPTY is available only on native Windows; never emulate a Unix proof."""
    def __init__(self, command, cwd, env, scenario):
        import ctypes as c
        from ctypes import wintypes as w
        import queue, threading
        if os.name != 'nt':
            raise RuntimeError('Native Windows required for ConPTY')
        # Redirection cases exercise the public capability guard using real pipes.
        # Both streams are redirected here; isolated stdin/stdout guards also have
        # their own model contracts. This is not a single-axis ConPTY assertion.
        self.redirect = scenario in ('InputRedirect', 'Redirect')
        self.before = None
        self.native = None
        if self.redirect:
            self.process = subprocess.Popen(command, cwd=cwd, env=env,
                stdin=subprocess.DEVNULL, stdout=subprocess.PIPE, stderr=subprocess.STDOUT)
            self.chunks = queue.Queue()
            self.reader = threading.Thread(target=self._read_redirect, daemon=True)
            self.reader.start()
            return
        self.c, self.w = c, w
        self.k = c.WinDLL('kernel32', use_last_error=True)
        class Coord(c.Structure):
            _fields_ = [('X', c.c_short), ('Y', c.c_short)]
        class Startup(c.Structure):
            _fields_ = [('cb', w.DWORD), ('lpReserved', w.LPWSTR), ('lpDesktop', w.LPWSTR),
                ('lpTitle', w.LPWSTR), ('dwX', w.DWORD), ('dwY', w.DWORD),
                ('dwXSize', w.DWORD), ('dwYSize', w.DWORD), ('dwXCountChars', w.DWORD),
                ('dwYCountChars', w.DWORD), ('dwFillAttribute', w.DWORD), ('dwFlags', w.DWORD),
                ('wShowWindow', w.WORD), ('cbReserved2', w.WORD), ('lpReserved2', c.c_void_p),
                ('hStdInput', w.HANDLE), ('hStdOutput', w.HANDLE), ('hStdError', w.HANDLE)]
        class StartupEx(c.Structure):
            _fields_ = [('StartupInfo', Startup), ('lpAttributeList', c.c_void_p)]
        class ProcessInfo(c.Structure):
            _fields_ = [('hProcess', w.HANDLE), ('hThread', w.HANDLE),
                        ('dwProcessId', w.DWORD), ('dwThreadId', w.DWORD)]
        self.Coord = Coord
        signatures = {
            'CreatePipe': ([c.POINTER(w.HANDLE), c.POINTER(w.HANDLE), c.c_void_p, w.DWORD], w.BOOL),
            'CreatePseudoConsole': ([Coord, w.HANDLE, w.HANDLE, w.DWORD, c.POINTER(w.HANDLE)], c.c_long),
            'ResizePseudoConsole': ([w.HANDLE, Coord], c.c_long),
            'ClosePseudoConsole': ([w.HANDLE], None),
            'InitializeProcThreadAttributeList': ([c.c_void_p, w.DWORD, w.DWORD, c.POINTER(c.c_size_t)], w.BOOL),
            'UpdateProcThreadAttribute': ([c.c_void_p, w.DWORD, c.c_size_t, c.c_void_p, c.c_size_t, c.c_void_p, c.c_void_p], w.BOOL),
            'DeleteProcThreadAttributeList': ([c.c_void_p], None),
            'CreateProcessW': ([w.LPCWSTR, w.LPWSTR, c.c_void_p, c.c_void_p, w.BOOL, w.DWORD, c.c_void_p, w.LPCWSTR, c.POINTER(StartupEx), c.POINTER(ProcessInfo)], w.BOOL),
            'ReadFile': ([w.HANDLE, c.c_void_p, w.DWORD, c.POINTER(w.DWORD), c.c_void_p], w.BOOL),
            'WriteFile': ([w.HANDLE, c.c_void_p, w.DWORD, c.POINTER(w.DWORD), c.c_void_p], w.BOOL),
            'GetExitCodeProcess': ([w.HANDLE, c.POINTER(w.DWORD)], w.BOOL),
            'TerminateProcess': ([w.HANDLE, w.UINT], w.BOOL),
            'WaitForSingleObject': ([w.HANDLE, w.DWORD], w.DWORD),
            'CloseHandle': ([w.HANDLE], w.BOOL),
        }
        for name, (parameters, result) in signatures.items():
            fn = getattr(self.k, name)
            fn.argtypes, fn.restype = parameters, result
        self.handles, self.pc, self.attributes = [], w.HANDLE(), None
        self.chunks, self.inputs = queue.Queue(), queue.Queue()
        self.errors = []
        self.pi = ProcessInfo()
        self.reader = self.writer = None
        try:
            ir, iw, outr, outw = w.HANDLE(), w.HANDLE(), w.HANDLE(), w.HANDLE()
            self._check(self.k.CreatePipe(c.byref(ir), c.byref(iw), None, 0))
            self.handles.extend([ir, iw])
            self._check(self.k.CreatePipe(c.byref(outr), c.byref(outw), None, 0))
            self.handles.extend([outr, outw])
            if self.k.CreatePseudoConsole(Coord(100, 24), ir, outw, 0, c.byref(self.pc)) < 0:
                raise RuntimeError('CreatePseudoConsole failed')
            size = c.c_size_t()
            self.k.InitializeProcThreadAttributeList(None, 1, 0, c.byref(size))
            self.attributes = c.create_string_buffer(size.value)
            self._check(self.k.InitializeProcThreadAttributeList(self.attributes, 1, 0, c.byref(size)))
            self._check(self.k.UpdateProcThreadAttribute(self.attributes, 0, 0x00020016,
                self.pc, c.sizeof(w.HANDLE), None, None))
            si = StartupEx()
            si.StartupInfo.cb = c.sizeof(StartupEx)
            si.lpAttributeList = c.cast(self.attributes, c.c_void_p)
            # list2cmdline implements Windows argv quoting; no shell is involved.
            import shutil
            executable = shutil.which(command[0])
            if not executable:
                raise RuntimeError('PowerShell executable missing')
            argv = [executable] + command[1:]
            self._check(self.k.CreateProcessW(executable, c.create_unicode_buffer(subprocess.list2cmdline(argv)),
                None, None, False, 0x00080000, None, str(cwd), c.byref(si), c.byref(self.pi)))
            self.handles.extend([self.pi.hProcess, self.pi.hThread])
            self.k.CloseHandle(ir); self.handles.remove(ir)
            self.k.CloseHandle(outw); self.handles.remove(outw)
            self.input, self.output = iw, outr
            self.reader = threading.Thread(target=self._reader, daemon=True)
            self.writer = threading.Thread(target=self._writer, daemon=True)
            self.reader.start(); self.writer.start()
        except BaseException:
            self.close()
            raise

    def _check(self, success):
        if not success:
            raise self.c.WinError(self.c.get_last_error())

    def _read_redirect(self):
        while chunk := self.process.stdout.read(65536):
            self.chunks.put((0, chunk))

    def _reader(self):
        c, w = self.c, self.w
        buffer, count = c.create_string_buffer(65536), w.DWORD()
        while self.k.ReadFile(self.output, buffer, len(buffer), c.byref(count), None) and count.value:
            self.chunks.put((0, buffer.raw[:count.value]))

    def _writer(self):
        c, w = self.c, self.w
        while (data := self.inputs.get()) is not None:
            offset = 0
            while offset < len(data):
                count = w.DWORD()
                chunk = data[offset:]
                if not self.k.WriteFile(self.input, chunk, len(chunk), c.byref(count), None) or not count.value:
                    self.errors.append('ConPTY input write failed')
                    return
                offset += count.value

    def read(self, wait=.05):
        import queue
        chunks = []
        try:
            chunks.append(self.chunks.get(timeout=wait))
        except queue.Empty:
            pass
        while not self.chunks.empty():
            chunks.append(self.chunks.get_nowait())
        return chunks

    def write(self, data):
        if not self.redirect:
            self.inputs.put(data)

    def resize(self, width, height, signal_child=True):
        if self.k.ResizePseudoConsole(self.pc, self.Coord(width, height)) < 0:
            raise RuntimeError('ResizePseudoConsole failed')

    def sample(self):
        return None

    def poll(self):
        if self.redirect:
            return self.process.poll()
        code = self.w.DWORD()
        self._check(self.k.GetExitCodeProcess(self.pi.hProcess, self.c.byref(code)))
        return None if code.value == 259 else code.value

    def terminate(self):
        if self.redirect:
            self.process.kill(); self.process.wait()
        elif self.pi.hProcess:
            self._check(self.k.TerminateProcess(self.pi.hProcess, 2))
            self.k.WaitForSingleObject(self.pi.hProcess, 3000)

    def close(self):
        if self.redirect:
            if self.process.poll() is None:
                self.terminate()
            self.reader.join(timeout=3)
            self.process.stdout.close()
            return
        if self.pi.hProcess and self.poll() is None:
            self.terminate()
        if self.writer:
            self.inputs.put(None)
        # Keep draining while ClosePseudoConsole sends its final frame.
        if self.pc:
            self.k.ClosePseudoConsole(self.pc)
            self.pc = self.w.HANDLE()
        if self.reader:
            self.reader.join(timeout=3)
        if self.writer:
            self.writer.join(timeout=3)
        if self.attributes:
            self.k.DeleteProcThreadAttributeList(self.attributes)
        for handle in reversed(self.handles):
            self.k.CloseHandle(handle)
        self.handles.clear()
