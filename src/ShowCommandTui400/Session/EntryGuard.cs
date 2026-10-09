using ShowCommandTui400.Actions;
namespace ShowCommandTui400.Session;

public sealed record EntryCapabilities(Version PowerShellVersion, bool InputRedirected, bool OutputRedirected, bool RawUiAvailable, string HostName, bool NativeSupported, bool VirtualTerminalSupported = true);
public sealed class EntryRejectedException(string errorId, string message) : Exception(message) { public string ErrorId { get; } = errorId; }
public static class EntryGuard
{
    public static IReadOnlyDictionary<string, ActionId> Validate(EntryCapabilities capability, IDictionary<string, string>? remap)
    {
        if (capability.PowerShellVersion < new Version(7, 6, 4) || capability.InputRedirected || capability.OutputRedirected || !capability.RawUiAvailable || capability.HostName != "ConsoleHost" || !capability.NativeSupported || !capability.VirtualTerminalSupported)
            throw new EntryRejectedException("CapabilityRejected", "Interaktive ConsoleHost-Sitzung ab PowerShell 7.6.4 mit unterstütztem Terminal erforderlich. / An interactive supported ConsoleHost terminal on PowerShell 7.6.4+ is required.");
        return KeyBindingValidator.Validate(remap);
    }
}
