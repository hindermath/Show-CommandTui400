namespace ShowCommandTui400.Terminal;

internal interface INativeTerminal
{
    string Platform { get; }
    string Boundary { get; }
    byte[] Read();
    void Write(byte[] value);
    bool ConfiguredEquals(byte[] a, byte[] b);
}
public abstract class NativeTerminalLease : ITerminalLease
{
    private readonly INativeTerminal native;
    private readonly byte[] saved;
    private bool activated, disposed, controlChanged, cursorSaved;
    private bool savedControl;
    public TerminalRestoreObservation? Observation { get; private set; }
    internal NativeTerminalLease(INativeTerminal native) { this.native = native; saved = native.Read(); }
    public void Activate()
    {
        ObjectDisposedException.ThrowIf(disposed, this);
        if (activated) throw new InvalidOperationException("Lease already active");
        savedControl = Console.TreatControlCAsInput;
        controlChanged = true;
        Console.TreatControlCAsInput = true;
        // Xterm mode 25 has an independent one-level save slot; no ANSI driver fallback.
        cursorSaved = true;
        Console.Out.Write("\u001b[?25s"); Console.Out.Flush();
        activated = true;
    }
    public void Dispose()
    {
        if (disposed) return;
        disposed = true;
        var errors = new List<Exception>();
        if (controlChanged) try { Console.TreatControlCAsInput = savedControl; } catch (Exception e) { errors.Add(e); }
        // Native restoration is attempted even if managed console restoration fails.
        try
        {
            native.Write(saved); var actual = native.Read();
            Observation = new(native.Platform, Convert.ToHexString(saved), Convert.ToHexString(actual), saved.SequenceEqual(actual), native.ConfiguredEquals(saved, actual), native.Boundary);
            if (!Observation.ConfiguredEqual) throw new IOException("Native terminal modes differ after restoration");
        }
        catch (Exception e) { errors.Add(e); }
        if (cursorSaved) try { Console.Out.Write("\u001b[?25r"); Console.Out.Flush(); } catch (Exception e) { errors.Add(e); }
        if (errors.Count > 0) throw new AggregateException("Terminal restore errors", errors);
    }
}
