"""DE: Synthetischer Unix-PTY-Produkttest. EN: Synthetic Unix PTY product test."""
import argparse, fcntl, hashlib, json, os, pty, select, struct, subprocess, termios, time
from pathlib import Path
from terminal_probes import TerminalProbes
parser = argparse.ArgumentParser()
parser.add_argument('--scenario', choices=['Normal','Cancel','Repeat','Stop','HandledFailure','RestorationFailure','Redirect','HiddenCursor','InputRedirect','AggregateFailure','Keyboard','Remap','FunctionExit','BindingConflict'], required=True)
parser.add_argument('--output', required=True)
parser.add_argument('--build-root')
parser.add_argument('--case-id', choices=['N02','N03','S01','S02','S03','S04','S05','S06','S07'])
args=parser.parse_args()
root=Path(__file__).resolve().parents[3]
output=Path(args.output).resolve()
if output.exists(): raise SystemExit('Output must be new')
master,slave=pty.openpty()
fcntl.ioctl(slave,termios.TIOCSWINSZ,struct.pack('HHHH',24,100,0,0))
before=termios.tcgetattr(slave)
def setup():
    os.setsid(); fcntl.ioctl(2,termios.TIOCSCTTY,0)
command=['pwsh','-NoLogo','-NoProfile','-File','tests/feasibility/lh01/session-contract.ps1','-Scenario',args.scenario,'-Module','src/ShowCommandTui400/bin/Debug/net10.0/ShowCommandTui400.psd1','-TestAssembly','tests/ShowCommandTui400.Tests/bin/Debug/net10.0/ShowCommandTui400.Tests.dll']
if args.build_root:
    build=Path(args.build_root).resolve()
    command[command.index('-Module')+1]=str(build/'ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1')
    command[command.index('-TestAssembly')+1]=str(build/'ShowCommandTui400.Tests/bin/net10.0/ShowCommandTui400.Tests.dll')
env=os.environ.copy();env['TERM']='xterm-256color';env['LC_ALL']='en_US.UTF-8'
redirect=args.scenario=='Redirect'
process=subprocess.Popen(command,cwd=root,stdin=subprocess.PIPE if args.scenario=='InputRedirect' else slave,stdout=subprocess.PIPE if redirect else slave,stderr=slave,env=env,preexec_fn=setup)
fds=[master]+([process.stdout.fileno()] if redirect else [])
for fd in fds:os.set_blocking(fd,False)
probes=TerminalProbes()
raw=bytearray();start=time.monotonic();ui_at=None;phase=0;ack=False;sample=None;steps=[]
sequences = {
    'Keyboard': [('Unknown',b'z'),('Esc',b'\x1b'),('F12',b'\x1b[24~'),('F4',b'\x1bOS'),('F9',b'\x1b[20~'),('F10',b'\x1b[21~'),('F11',b'\x1b[23~'),('Tab',b'\t'),('Enter',b'\r'),('Alt+B',b'\x1bb'),('Shift+Tab',b'\x1b[Z'),('Down',b'\x1b[B'),('Up',b'\x1b[A'),('Right',b'\x1b[C'),('Left',b'\x1b[D'),('PageDown',b'\x1b[6~'),('Enter',b'\r'),('PageUp',b'\x1b[5~'),('Enter',b'\r'),('F5',b'\x1b[15~'),('F1',b'\x1bOP'),('Alt+B',b'\x1bb'),('Alt+M',b'\x1bm'),('Alt+H',b'\x1bh'),('F12',b'\x1b[24~'),('Esc',b'\x1b'),('Alt+X',b'\x1bx')],
    'Remap': [('F1-unbound',b'\x1bOP'),('F5-unbound',b'\x1b[15~'),('F6',b'\x1b[17~'),('F2',b'\x1bOQ'),('Alt+B',b'\x1bb'),('Alt+H',b'\x1bh'),('Esc',b'\x1b'),('Alt+X',b'\x1bx')],
    'FunctionExit': [('F3',b'\x1bOR')]
}
sequence = sequences.get(args.scenario, [('Ctrl+C',b'\x03')] if args.scenario=='Cancel' else [('Alt+X',b'\x1bx')] * (3 if args.scenario=='Repeat' else 1))
try:
    while time.monotonic()-start<45:
        for fd in select.select(fds,[],[],.05)[0]:
            try: chunk=os.read(fd,65536)
            except OSError: continue
            raw.extend(chunk)
            for response in probes.feed(fd,chunk):os.write(master,response)
        if ui_at is None and b'Show-CommandTui400' in raw and args.scenario in ('Normal','Cancel','Repeat','HiddenCursor','Keyboard','Remap','FunctionExit'):ui_at=time.monotonic()
        if ui_at is not None:
            elapsed=time.monotonic()-ui_at
            if phase<len(sequence) and elapsed>.8+phase*.65:
                label,data=sequence[phase];os.write(master,data);phase+=1;steps.append(label)
        if not ack and b'LH01_SHELL_INPUT_READY' in raw:os.write(master,b'LH01_ACK\r');ack=True;steps.append('synthetic-shell-readback')
        if sample is None and b'LH01_RESTORE_READY' in raw:sample=termios.tcgetattr(slave)
        if process.poll() is not None:break
    timeout=process.poll() is None
    if timeout:
        process.terminate()
        try:process.wait(timeout=3)
        except subprocess.TimeoutExpired:process.kill();process.wait()
    for fd in fds:
        while select.select([fd],[],[],0)[0]:
            try:chunk=os.read(fd,65536)
            except OSError:break
            if not chunk:break
            raw.extend(chunk)
    parsed=None
    for line in raw.decode('utf-8','replace').splitlines():
        if line.startswith('{"Scenario"'):
            try:parsed=json.loads(line)
            except json.JSONDecodeError:pass
    expected_exit=1 if args.scenario=='RestorationFailure' else 0
    expected_failure=args.scenario=='RestorationFailure'
    ok=not timeout and process.returncode==expected_exit and parsed is not None and parsed['ContextUnchanged']
    if args.scenario not in ('Redirect','InputRedirect','BindingConflict'):
        ok=ok and parsed['ShellReadback']=='LH01_ACK' and parsed['NativeRestore']['ConfiguredEqual']
    if args.scenario in ('Normal','Repeat','Cancel'):
        ok=ok and b'\x1b[?25h' in raw
    if args.scenario=='Repeat':
        observations=parsed['ScopeObservations'];ok=ok and len(observations)==3 and [v['Synthetic'] for v in observations]==[710,711,712] and all(v['ProcessId']==parsed['Before']['Pid'] and v['RunspaceId']==parsed['Before']['Runspace'] for v in observations)
    if args.scenario=='Stop':ok=ok and parsed['StopCalls']>0 and parsed['PipelineState']=='Stopped'
    if args.scenario in ('Keyboard','Remap','FunctionExit'):
        observations=parsed.get('InputObservations',[]) if parsed else []
        expected=[v[0] for v in sequence if v[0] not in ('Unknown','F1-unbound','F5-unbound')]
        ok=ok and phase==len(sequence) and parsed['ModuleSetUnchanged'] and observations[-1:]==[v for v in observations[-1:] if v['ExitRequested']]
        ok=ok and all(not v['ExitRequested'] for v in observations[:-1])
        ok=ok and [v['Key'] for v in observations]==expected and all(v['Focus']==v['FrameworkFocus'] for v in observations)
        if args.scenario=='Keyboard':
            ok=ok and all(not v['Accepted'] for v in observations[2:6]) and all(not v['ExitRequested'] for v in observations[:-1])
            ok=ok and observations[0]['Context']=='Root' and observations[1]['Context']=='Root'
            ok=ok and [v['Action'] for v in observations if v['Key']=='Enter']==['ActionsMenu','Refresh','Help']
            contexts=['Root']*7+['ActionsMenu']+['Root']*9+['Help']*3+['Root','ActionsMenu','Help','ActionsMenu','Root','Root']
            focuses=['Help']*6+['ActionsMenu']*3+['Help','ActionsMenu','Help','ActionsMenu','Help','Refresh','Refresh']+['Help']*10
            actions=['Back','Back','Context','AllParameters','MoreParameters','Details',None,'ActionsMenu','Back',None,None,None,None,None,None,'Refresh',None,'Help','Refresh','Help','Back','ActionsMenu','Help','Back','Back','Exit']
            ok=ok and [v['Context'] for v in observations]==contexts and [v['Focus'] for v in observations]==focuses
            ok=ok and [v['Action'] for v in observations]==actions and [v['Accepted'] for v in observations]==[i not in (2,3,4,5) for i in range(26)]

        if args.scenario=='Remap':ok=ok and observations[0]['Key']=='F6' and observations[0]['Action']=='Refresh' and observations[1]['Key']=='F2' and observations[1]['Context']=='Help'
    if args.scenario=='BindingConflict':ok=ok and parsed['LeaseAcquisitions']==0 and parsed['UiCreations']==0 and parsed['ModuleSetUnchanged'] and parsed['Failure']['ErrorId'].startswith('InvalidConfiguration')
    boundary=bytes(raw).split(b'LH01_SHELL_INPUT_READY')[0]
    import re
    cursor_visible=True; saved_cursor=None; restore_observed=False
    for match in re.finditer(rb'\x1b\[\?25([hlsr])',boundary):
        operation=match[1]
        if operation==b'h':cursor_visible=True
        elif operation==b'l':cursor_visible=False
        elif operation==b's':saved_cursor=cursor_visible
        elif operation==b'r' and saved_cursor is not None:cursor_visible=saved_cursor;restore_observed=True
    final_cursor_visible=cursor_visible
    if args.scenario in ('Normal','Cancel','Repeat','HiddenCursor','Keyboard','Remap','FunctionExit'):ok=ok and restore_observed and cursor_visible==(args.scenario!='HiddenCursor')
    binary=Path(command[command.index('-Module')+1]).with_suffix('.dll')
    if not binary.is_absolute():binary=root/binary
    sanitized=raw.decode('utf-8','replace').replace(str(root),'<checkout>')
    if args.build_root:sanitized=sanitized.replace(str(Path(args.build_root).resolve()),'<build>')
    record={'sanitizedTranscript':sanitized,'sanitizedTranscriptSha256':hashlib.sha256(sanitized.encode()).hexdigest(),'assemblySha256':hashlib.sha256(binary.read_bytes()).hexdigest(),'finalCursorVisibleAtReturn':final_cursor_visible,'cursorModeRestoreObserved':restore_observed,'initialCursorBoundary':'synthetic xterm mode-25 protocol emulation; hidden and visible cases; no physical terminal proof','scenario':args.scenario,'environment':'synthetic Unix PTY; no physical terminal/assistive acceptance','command':[v.replace(str(root),'<checkout>').replace(str(Path(args.build_root).resolve()),'<build>') if args.build_root else v.replace(str(root),'<checkout>') for v in command],'exitCode':process.returncode,'expectedExitCode':expected_exit,'result':'Pass' if ok and not expected_failure else 'Fail','diagnosticContractSatisfied':bool(ok),'failureScope':'injected restoration failure after successful real restore; not actual host restore failure' if expected_failure else None,'timeout':timeout,'steps':steps,'cursorShowObserved':b'\x1b[?25h' in raw,'transcriptSha256':hashlib.sha256(raw).hexdigest(),'termiosBefore':before,'termiosAfter':sample,'observation':parsed}
    output.parent.mkdir(parents=True,exist_ok=True)
    output.write_text(json.dumps(record,ensure_ascii=False,indent=2,default=lambda v:v.hex() if isinstance(v,bytes) else str(v))+'\n')
    outcomes={'N02':'RejectedWithoutStateChange','N03':'RejectedWithoutStateChange','S01':'CallerContextRetained','S02':'RestoredAndShellUsable','S03':'RestoredAndShellUsable','S04':'StoppedAndRestored','S05':'RestoredAndErrorPreserved','S06':'NoLeakedState','S07':'FailWithPrimaryAndRestorationErrorsPreserved'}
    print(json.dumps({'caseId':args.case_id,'outcome':outcomes.get(args.case_id),'scenario':args.scenario,'result':record['result'],'diagnosticContractSatisfied':bool(ok),'exitCode':process.returncode}))
    if not ok:
        # Test output is synthetic; scrub the checkout prefix before diagnostics.
        print(raw.decode('utf-8','replace').replace(str(root),'<checkout>')[-2500:])
    raise SystemExit(expected_exit if ok else 2)
finally:
    os.close(master);os.close(slave)
