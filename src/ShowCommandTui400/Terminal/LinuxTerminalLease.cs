using System.Runtime.InteropServices;
namespace ShowCommandTui400.Terminal;

public sealed class LinuxTerminalLease : NativeTerminalLease
{
    public LinuxTerminalLease() : base(new LinuxTerminal()) { }
    [DllImport("libc", EntryPoint = "gnu_get_libc_version")] private static extern nint GlibcVersion();
    internal static bool IsSupportedPlatform()
    {
        if (!OperatingSystem.IsLinux() || RuntimeInformation.ProcessArchitecture != Architecture.X64) return false;
        try { return GlibcVersion() != 0; } catch (DllNotFoundException) { return false; } catch (EntryPointNotFoundException) { return false; }
    }
    internal LinuxTerminalLease(INativeTerminal native) : base(native) { }
    internal sealed class LinuxTerminal : INativeTerminal
    {
        // Linux glibc x64 termios, distinct from Darwin; other ABIs are rejected.
        [StructLayout(LayoutKind.Sequential)]
        internal struct Termios
        {
            public uint Input, Output, Control, Local;
            public byte Line;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)] public byte[] Characters;
            public uint InputSpeed, OutputSpeed;
        }
        [DllImport("libc", SetLastError = true)] static extern int isatty(int fd);
        [DllImport("libc", SetLastError = true)] static extern int tcgetattr(int fd, out Termios value);
        [DllImport("libc", SetLastError = true)] static extern int tcsetattr(int fd, int action, ref Termios value);
        public string Platform => "Linux-glibc-x64";
        public string Boundary => "Own Linux glibc x64 ABI; native target proof outstanding; no Darwin masks";
        public byte[] Read()
        {
            if (!IsSupportedPlatform() || Marshal.SizeOf<Termios>() != 60 || Marshal.OffsetOf<Termios>(nameof(Termios.InputSpeed)).ToInt32() != 52 || isatty(0) != 1 || tcgetattr(0, out var value) != 0) throw new IOException("Unsupported Linux terminal/ABI");
            return NativeBytes.Serialize(value);
        }
        public void Write(byte[] bytes) { var value = NativeBytes.Deserialize<Termios>(bytes); if (tcsetattr(0, 0, ref value) != 0) throw new IOException("Linux tcsetattr failed"); }
        public bool ConfiguredEquals(byte[] a, byte[] b) => a.SequenceEqual(b);
    }
}
