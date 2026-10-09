using System.Runtime.InteropServices;
namespace ShowCommandTui400.Terminal;

public sealed class MacTerminalLease : NativeTerminalLease
{
    public MacTerminalLease() : base(new DarwinTerminal()) { }
    internal MacTerminalLease(INativeTerminal native) : base(native) { }
    internal sealed class DarwinTerminal : INativeTerminal
    {
        // Darwin arm64 termios: four ulong flags, twenty cc bytes, aligned speeds.
        [StructLayout(LayoutKind.Sequential)]
        internal struct Termios
        {
            public ulong Input, Output, Control, Local;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] public byte[] Characters;
            public ulong InputSpeed, OutputSpeed;
        }
        [DllImport("/usr/lib/libSystem.B.dylib", SetLastError = true)] static extern int isatty(int fd);
        [DllImport("/usr/lib/libSystem.B.dylib", SetLastError = true)] static extern int tcgetattr(int fd, out Termios value);
        [DllImport("/usr/lib/libSystem.B.dylib", SetLastError = true)] static extern int tcsetattr(int fd, int action, ref Termios value);
        public string Platform => "macOS-arm64";
        public string Boundary => "Only independently reproduced Darwin PENDIN (0x20000000) excluded from configured comparison; raw bytes retained";
        public byte[] Read()
        {
            if (!OperatingSystem.IsMacOS() || RuntimeInformation.ProcessArchitecture != Architecture.Arm64 || Marshal.SizeOf<Termios>() != 72 || Marshal.OffsetOf<Termios>(nameof(Termios.InputSpeed)).ToInt32() != 56 || isatty(0) != 1 || tcgetattr(0, out var value) != 0) throw new IOException("Unsupported Darwin terminal/ABI");
            return NativeBytes.Serialize(value);
        }
        public void Write(byte[] bytes) { var value = NativeBytes.Deserialize<Termios>(bytes); if (tcsetattr(0, 0, ref value) != 0) throw new IOException("Darwin tcsetattr failed"); }
        public bool ConfiguredEquals(byte[] a, byte[] b)
        {
            var x = NativeBytes.Deserialize<Termios>(a); var y = NativeBytes.Deserialize<Termios>(b);
            x.Local &= ~0x20000000UL; y.Local &= ~0x20000000UL;
            return NativeBytes.Serialize(x).SequenceEqual(NativeBytes.Serialize(y));
        }
    }
}
internal static class NativeBytes
{
    public static byte[] Serialize<T>(T value) where T : struct
    {
        var size = Marshal.SizeOf<T>(); var ptr = Marshal.AllocHGlobal(size);
        try { Marshal.Copy(new byte[size], 0, ptr, size); Marshal.StructureToPtr(value, ptr, false); var bytes = new byte[size]; Marshal.Copy(ptr, bytes, 0, size); return bytes; }
        finally { Marshal.FreeHGlobal(ptr); }
    }
    public static T Deserialize<T>(byte[] bytes) where T : struct
    {
        if (bytes.Length != Marshal.SizeOf<T>()) throw new ArgumentException("Invalid native snapshot length");
        var ptr = Marshal.AllocHGlobal(bytes.Length);
        try { Marshal.Copy(bytes, 0, ptr, bytes.Length); return Marshal.PtrToStructure<T>(ptr); }
        finally { Marshal.FreeHGlobal(ptr); }
    }
}
