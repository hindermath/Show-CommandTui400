using ShowCommandTui400.Actions;
using ShowCommandTui400.Session;
using ShowCommandTui400.Presentation;
namespace ShowCommandTui400.Tests;

public static class EntryBoundaryTests
{
    public static string[] Run()
    {
        var passed = new List<string>();
        void Reject(string id, Action action)
        {
            try { action(); } catch (EntryRejectedException) { passed.Add(id); return; }
            throw new Exception("Expected rejection: " + id);
        }
        var valid = new EntryCapabilities(new Version(7, 6, 4), false, false, true, "ConsoleHost", true);
        Reject("N01", () => EntryGuard.Validate(valid with { PowerShellVersion = new Version(7, 6, 3) }, null));
        Reject("N02", () => EntryGuard.Validate(valid with { InputRedirected = true }, null));
        Reject("N03", () => EntryGuard.Validate(valid with { OutputRedirected = true }, null));
        Reject("N04", () => EntryGuard.Validate(valid with { RawUiAvailable = false }, null));
        Reject("N04-host", () => EntryGuard.Validate(valid with { HostName = "Unknown" }, null));
        Reject("N04-VT", () => EntryGuard.Validate(valid with { VirtualTerminalSupported = false }, null));
        Reject("N04-native", () => EntryGuard.Validate(valid with { NativeSupported = false }, null));
        Reject("N05", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "Unknown", "F2" } }));
        Reject("N06", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "Help", "F3" } }));
        Reject("N06-escape", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "Exit", "Esc" } }));
        Reject("N06-case", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "Help", "alt+h" } }));
        Reject("N06-numeric-action", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "0", "F2" } }));
        Reject("N06-syntax", () => EntryGuard.Validate(valid, new Dictionary<string, string> { { "Help", "$(bad)" } }));
        if (SafeDisplayText.Format("a\u001bb\u0007c\u202ed") != "a?b?c?d") throw new Exception("N07 control text");
        passed.Add("N07");
        return passed.ToArray();
    }
}
