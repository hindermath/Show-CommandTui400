using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lh01Feasibility;

// DE: Nur macOS-Arm64-Proof; ABI separat mit SDK/C-Probe gebunden.
// EN: macOS Arm64 proof only; ABI bound to SDK and independent C size probe.
internal sealed class DarwinTerminalSnapshot : IDisposable
{
    [StructLayout(LayoutKind.Sequential)]
    private struct DarwinTermios
    {
        public ulong Input, Output, Control, Local;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)] public byte[] Characters;
        public ulong InputSpeed, OutputSpeed;
    }
    private readonly DarwinTermios saved;
    public static object? LastObservation { get; private set; }
    private bool disposed;
    private bool originalControlC;
    private bool activeLease;
    public static DarwinTerminalSnapshot? CaptureIfTerminal()
    {
        if (!OperatingSystem.IsMacOS()) return null;
        return isatty(0) == 1 ? new DarwinTerminalSnapshot() : null;
    }
    private DarwinTerminalSnapshot()
    {
        if (!OperatingSystem.IsMacOS() || RuntimeInformation.ProcessArchitecture != Architecture.Arm64)
            throw new PlatformNotSupportedException("Isolierter Mac-A-Proof / isolated Mac A proof");
        if (Marshal.SizeOf<DarwinTermios>() != 72 || Marshal.OffsetOf<DarwinTermios>(nameof(DarwinTermios.InputSpeed)).ToInt32() != 56)
            throw new InvalidOperationException("ABI mismatch");
        if (tcgetattr(0, out saved) != 0) throw new Win32Exception(Marshal.GetLastPInvokeError(), "tcgetattr");

    }
    public void ActivateConsoleLease()
    {
        originalControlC = Console.TreatControlCAsInput;
        activeLease = true;
    }
    public void Dispose()
    {
        if (disposed || !activeLease) return;
        Console.TreatControlCAsInput = originalControlC;
        var copy = saved;
        if (tcsetattr(0, 0, ref copy) != 0) throw new Win32Exception(Marshal.GetLastPInvokeError(), "tcsetattr");
        if (tcgetattr(0, out var observed) != 0) throw new Win32Exception(Marshal.GetLastPInvokeError());
        LastObservation = new { SavedLocal = saved.Local, RestoredLocal = observed.Local, SavedSpeed = saved.InputSpeed, RestoredSpeed = observed.InputSpeed };
        disposed = true;
    }
    // Fixed libc entry points, fd=stdin after capability guard; no unchecked pointer arithmetic.
    [DllImport("/usr/lib/libSystem.B.dylib")]
    private static extern int isatty(int fd);
    [DllImport("/usr/lib/libSystem.B.dylib", SetLastError = true)]
    private static extern int tcgetattr(int fd, out DarwinTermios value);
    [DllImport("/usr/lib/libSystem.B.dylib", SetLastError = true)]
    private static extern int tcsetattr(int fd, int action, ref DarwinTermios value);
}
