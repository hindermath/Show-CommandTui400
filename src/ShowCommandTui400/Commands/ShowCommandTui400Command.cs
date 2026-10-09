using System.Collections;
using System.Management.Automation;
using System.Runtime.InteropServices;
using ShowCommandTui400.Session;
using ShowCommandTui400.Terminal;
namespace ShowCommandTui400.Commands;

[Cmdlet(VerbsCommon.Show, "CommandTui400")]
public sealed class ShowCommandTui400Command : PSCmdlet
{
    [Parameter] public Hashtable? KeyBinding { get; set; }
    private readonly object gate = new();
    private ITerminalApplication? active;
    private bool stopping;
    internal SessionPhase Phase { get; private set; } = SessionPhase.Created;
    private static readonly SemaphoreSlim SessionLease = new(1, 1);
    // Internal dependency seams are not exported parameters; only the friend test assembly replaces them.
    internal static Func<ITerminalLease> LeaseFactory = CreateLease;
    internal static Func<ITerminalApplication> ApplicationFactory = () => new TerminalApplication();
    internal static Action<SessionContext, SessionState>? ContextObserver;
    internal static Action? StopObserver;
    protected override void ProcessRecord()
    {
        bool acquired = false;
        Phase = SessionPhase.CapabilityCheck;
        try
        {
            var versionTable = SessionState.PSVariable.GetValue("PSVersionTable") as IDictionary;
            var version = versionTable?["PSVersion"] as System.Management.Automation.SemanticVersion;
            bool raw = false; try { raw = Host.UI?.RawUI != null; } catch (NotImplementedException) { }
            var terminalType = Environment.GetEnvironmentVariable("TERM");
            bool vt = Host.UI?.SupportsVirtualTerminal == true && (OperatingSystem.IsWindows() || terminalType is "xterm" or "xterm-256color");
            var capability = new EntryCapabilities(version == null ? new Version(0, 0) : new Version(version.Major, version.Minor, version.Patch), Console.IsInputRedirected, Console.IsOutputRedirected, raw, Host.Name, NativeSupported(), vt);
            Dictionary<string, string>? remap = null;
            if (KeyBinding != null) { remap = new(StringComparer.Ordinal); foreach (DictionaryEntry item in KeyBinding) { if (item.Key is not string k || item.Value is not string v) throw new EntryRejectedException("InvalidConfiguration", "Tastenbelegung erwartet Textpaare. / Key bindings require string pairs."); remap.Add(k, v); } }
            var bindings = EntryGuard.Validate(capability, remap);
            var context = CallerSessionAdapter.Capture(this);
            acquired = SessionLease.Wait(0);
            if (!acquired) throw new EntryRejectedException("InvalidContext", "Terminal ist bereits belegt. / Terminal is already in use.");
            ContextObserver?.Invoke(context, SessionState);
            var lease = LeaseFactory();
            TerminalLifecycle.Run(lease, () =>
            {
                using var app = ApplicationFactory();
                lock (gate) { active = app; if (stopping) app.Stop(); }
                try { app.Run(bindings); } finally { lock (gate) { active = null; } }
            }, phase => Phase = phase);
        }
        catch (EntryRejectedException e) { Phase = SessionPhase.Rejected; ThrowTerminatingError(new ErrorRecord(e, e.ErrorId, ErrorCategory.InvalidArgument, null)); }
        catch (Exception e)
        {
            string id = e is TerminalRestorationException || e is TerminalCombinedFailureException ? "RestorationFailure" : "HandledFailure";
            ThrowTerminatingError(new ErrorRecord(e, id, ErrorCategory.OperationStopped, null));
        }
        finally { if (acquired) SessionLease.Release(); }
    }
    protected override void StopProcessing() { lock (gate) { stopping = true; StopObserver?.Invoke(); active?.Stop(); } }
    internal static bool NativeSupported() => OperatingSystem.IsWindows() || (OperatingSystem.IsMacOS() && RuntimeInformation.ProcessArchitecture == Architecture.Arm64) || LinuxTerminalLease.IsSupportedPlatform();
    internal static ITerminalLease CreateLease() => OperatingSystem.IsMacOS() ? new MacTerminalLease() : OperatingSystem.IsLinux() ? new LinuxTerminalLease() : OperatingSystem.IsWindows() ? new WindowsTerminalLease() : throw new EntryRejectedException("CapabilityRejected", "Nicht unterstütztes Betriebssystem. / Unsupported operating system.");
}
