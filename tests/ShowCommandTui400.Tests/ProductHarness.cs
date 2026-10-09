using System.Management.Automation;
using ShowCommandTui400.Commands;
using ShowCommandTui400.Terminal;
namespace ShowCommandTui400.Tests;
// Public only in the test assembly; never exported through the product module.
public static class ProductHarness
{
    public static readonly ManualResetEventSlim Ready = new(false);
    public static int StopCalls;
    public static int LeaseAcquisitions, UiCreations;
    public static string? ObservedContext;
    public static TerminalRestoreObservation? LastRestore;
    private static string mode = "Real";
    public static void Configure(string requested)
    {
        if (!new[] { "Real", "HandledFailure", "RestorationFailure", "AggregateFailure" }.Contains(requested)) throw new ArgumentException("Test scenario");
        mode = requested; Ready.Reset(); StopCalls = 0; LeaseAcquisitions=0; UiCreations=0; ObservedContext = null; LastRestore = null;
        ShowCommandTui400Command.StopObserver = () => Interlocked.Increment(ref StopCalls);
        ShowCommandTui400Command.ContextObserver = (context, state) =>
        {
            // Record synthetic probe value only, never enumerate the user's session.
            ObservedContext = System.Text.Json.JsonSerializer.Serialize(new { context.ProcessId, context.RunspaceId, Location = "synthetic-working-directory", Synthetic = state.PSVariable.GetValue("Lh01Synthetic") });
        };
        ShowCommandTui400Command.LeaseFactory = () => {Interlocked.Increment(ref LeaseAcquisitions);return new ObservedLease(ShowCommandTui400Command.CreateLease());};
        ShowCommandTui400Command.ApplicationFactory = () => {Interlocked.Increment(ref UiCreations);return mode == "Real" ? new ObservedApplication(new TerminalApplication()) : new FaultApplication();};
    }
    public static void Reset()
    {
        ShowCommandTui400Command.LeaseFactory = ShowCommandTui400Command.CreateLease;
        ShowCommandTui400Command.ApplicationFactory = () => new TerminalApplication();
        ShowCommandTui400Command.ContextObserver = null; ShowCommandTui400Command.StopObserver = null;
    }
    private sealed class ObservedLease(ITerminalLease real) : ITerminalLease
    {
        public TerminalRestoreObservation? Observation => real.Observation;
        public void Activate() => real.Activate();
        public void Dispose() { try { real.Dispose(); } finally { LastRestore = real.Observation; } if (mode == "RestorationFailure") throw new IOException("synthetic restoration failure after real restoration; not an actual host restoration failure"); }
    }
    private sealed class ObservedApplication(ITerminalApplication real) : ITerminalApplication
    {
        public void Run(IReadOnlyDictionary<string, ShowCommandTui400.Actions.ActionId> bindings) { Ready.Set(); real.Run(bindings); }
        public void Stop() => real.Stop();
        public void Dispose() => real.Dispose();
    }
    private sealed class FaultApplication : ITerminalApplication
    {
        public void Run(IReadOnlyDictionary<string, ShowCommandTui400.Actions.ActionId> bindings) => throw (mode=="AggregateFailure" ? new AggregateException("synthetic primary aggregate failure") : new InvalidOperationException("synthetic primary failure"));
        public void Stop() { }
        public void Dispose() { }
    }
}
