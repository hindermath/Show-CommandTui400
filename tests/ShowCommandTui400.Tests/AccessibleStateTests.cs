using ShowCommandTui400.Actions;
using ShowCommandTui400.Presentation;
using ShowCommandTui400.Resources;
using ShowCommandTui400.State;
namespace ShowCommandTui400.Tests;
public static class AccessibleStateTests
{
    public static string[] Run()
    {
        var state = new ViewState { Busy = true, Error = "synthetic\u001b[2J\u202eerror", Status = "safe\u0007status" };
        var map = new KeyBindingMap(KeyBindingValidator.Validate(null));
        var text = AccessibleStatePresenter.Render(state, ViewContext.Root, map);
        if (text.Contains('\u001b') || text.Contains('\u0007') || text.Contains('\u202e')) throw new Exception("Unsafe state text");
        foreach (var part in new[] { "Fokus", "Focus", "Beschäftigt", "Busy", "Fehler", "Error", "Alt+H", "Alt+X", "nicht verfügbar", "unavailable" })
            if (!text.Contains(part)) throw new Exception("Missing accessible text: " + part);
        state.Busy = false; state.Error = null;
        if (!AccessibleStatePresenter.Render(state, ViewContext.Help, map).Contains(Messages.Both("NoError"))) throw new Exception("Missing clear error state");
        foreach (var key in Messages.Keys)
            if (string.IsNullOrWhiteSpace(Messages.InLanguage(key,"de")) || string.IsNullOrWhiteSpace(Messages.InLanguage(key,"en"))) throw new Exception("Missing translation " + key);
        return ["A01-safe-text-negative", "A02-names-availability-focus-busy-error-legend", "A03-idle-no-error", "A04-resource-language-parity"];
    }
}
