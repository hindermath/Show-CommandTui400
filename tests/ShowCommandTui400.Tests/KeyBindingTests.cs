using ShowCommandTui400.Actions;
using ShowCommandTui400.Session;
using ShowCommandTui400.Views;
namespace ShowCommandTui400.Tests;
public static class KeyBindingTests
{
    public static string[] Run()
    {
        foreach (var key in new[] { "F3", "F4", "F5", "F9", "F10", "F11", "Esc", "Alt+X", "Alt+M" })
        {
            try { KeyBindingValidator.Validate(new Dictionary<string,string> { ["Help"] = key }); }
            catch (EntryRejectedException) { continue; }
            throw new Exception("Conflict accepted: " + key);
        }
        var map = new KeyBindingMap(KeyBindingValidator.Validate(null));
        var expected = new Dictionary<string,ActionId> { ["F1"]=ActionId.Help,["F3"]=ActionId.Exit,["F4"]=ActionId.Context,["F5"]=ActionId.Refresh,["F9"]=ActionId.AllParameters,["F10"]=ActionId.MoreParameters,["F11"]=ActionId.Details,["F12"]=ActionId.Back,["Esc"]=ActionId.Back,["Alt+H"]=ActionId.Help,["Alt+B"]=ActionId.Back,["Alt+X"]=ActionId.Exit,["Alt+M"]=ActionId.ActionsMenu };
        foreach (var pair in expected) if (map.Resolve(pair.Key) != pair.Value) throw new Exception("Wrong binding: " + pair.Key);
        var remapped = new KeyBindingMap(KeyBindingValidator.Validate(new Dictionary<string,string> { ["Help"]="F2", ["Refresh"]="F6" }));
        if (remapped.Resolve("F1") != null || remapped.Resolve("F2") != ActionId.Help || remapped.Resolve("Alt+H") != ActionId.Help || remapped.Resolve("unknown") != null || remapped.Resolve("F5") != null || remapped.Resolve("F6") != ActionId.Refresh) throw new Exception("Remap/unknown");
        foreach (var action in new[] { ActionId.Context, ActionId.AllParameters, ActionId.MoreParameters, ActionId.Details })
        {
            var changed = new KeyBindingMap(KeyBindingValidator.Validate(new Dictionary<string,string> { [action.ToString()]="F8" }));
            if (changed.Resolve("F8") != action) throw new Exception("Contextual remap " + action);
        }
        var help = ActionHelpView.Render(ViewContext.Root, remapped);
        if (!help.Contains("F2") || !help.Contains("Alt+H") || !help.Contains("nicht verfügbar / unavailable")) throw new Exception("Effective legend");
        return ["K08-conflicts-before-init", "K09-complete-bindings", "K10-real-remap-map", "K11-effective-help"];
    }
}
