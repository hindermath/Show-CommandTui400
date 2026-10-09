namespace ShowCommandTui400.Terminal;

public interface ITerminalLease : IDisposable
{
    void Activate();
    TerminalRestoreObservation? Observation { get; }
}
public sealed record TerminalRestoreObservation(string Platform, string Before, string After, bool RawEqual, bool ConfiguredEqual, string Boundary);
