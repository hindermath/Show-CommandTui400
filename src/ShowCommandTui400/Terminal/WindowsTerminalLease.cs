using System.Runtime.InteropServices;
namespace ShowCommandTui400.Terminal;

public sealed class WindowsTerminalLease : ITerminalLease
{
    private readonly IWindowsConsole native;
    private readonly WindowsSnapshot saved;
    private bool disposed, active, savedControl, controlChanged;
    public TerminalRestoreObservation? Observation { get; private set; }
    public WindowsTerminalLease() : this(new WindowsConsole()) { }
    internal WindowsTerminalLease(IWindowsConsole native) { this.native = native; saved = native.Read(); }
    public void Activate()
    {
        ObjectDisposedException.ThrowIf(disposed, this);
        if (active) throw new InvalidOperationException("Lease already active");
        savedControl = Console.TreatControlCAsInput; controlChanged = true;
        Console.TreatControlCAsInput = true; active = true;
    }
    public void Dispose()
    {
        if (disposed) return; disposed = true;
        var errors = new List<Exception>();
        if (controlChanged) try { Console.TreatControlCAsInput = savedControl; } catch (Exception e) { errors.Add(e); }
        try { native.Write(saved); var after = native.Read(); Observation = new("Windows", saved.ToString(), after.ToString(), saved == after, saved == after, "Windows console modes/cursor; native target proof outstanding"); if (saved != after) throw new IOException("Windows restoration mismatch"); } catch (Exception e) { errors.Add(e); }
        if (errors.Count > 0) throw new AggregateException(errors);
    }
}
internal readonly record struct WindowsSnapshot(uint InputMode, uint OutputMode, uint CursorSize, bool CursorVisible);
internal interface IWindowsConsole { WindowsSnapshot Read(); void Write(WindowsSnapshot value); }
internal sealed class WindowsConsole : IWindowsConsole
{
    [StructLayout(LayoutKind.Sequential)] struct Cursor { public uint Size; [MarshalAs(UnmanagedType.Bool)] public bool Visible; }
    [DllImport("kernel32.dll", SetLastError = true)] static extern nint GetStdHandle(int id);
    [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] static extern bool GetConsoleMode(nint handle, out uint mode);
    [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] static extern bool SetConsoleMode(nint handle, uint mode);
    [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] static extern bool GetConsoleCursorInfo(nint handle, out Cursor value);
    [DllImport("kernel32.dll", SetLastError = true)][return: MarshalAs(UnmanagedType.Bool)] static extern bool SetConsoleCursorInfo(nint handle, ref Cursor value);
    public WindowsSnapshot Read()
    {
        if (!OperatingSystem.IsWindows() || !GetConsoleMode(GetStdHandle(-10), out var input) || !GetConsoleMode(GetStdHandle(-11), out var output) || !GetConsoleCursorInfo(GetStdHandle(-11), out var cursor)) throw new IOException("Unsupported Windows console");
        return new(input, output, cursor.Size, cursor.Visible);
    }
    public void Write(WindowsSnapshot value)
    {
        var errors = new List<Exception>(); var cursor = new Cursor { Size = value.CursorSize, Visible = value.CursorVisible };
        if (!SetConsoleMode(GetStdHandle(-10), value.InputMode)) errors.Add(new IOException("Input restore failed"));
        if (!SetConsoleMode(GetStdHandle(-11), value.OutputMode)) errors.Add(new IOException("Output restore failed"));
        if (!SetConsoleCursorInfo(GetStdHandle(-11), ref cursor)) errors.Add(new IOException("Cursor restore failed"));
        if (errors.Count > 0) throw new AggregateException(errors);
    }
}
