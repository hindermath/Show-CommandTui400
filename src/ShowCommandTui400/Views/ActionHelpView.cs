using ShowCommandTui400.Actions;
namespace ShowCommandTui400.Views;

public static class ActionHelpView
{
    public static string Render(ViewContext context, KeyBindingMap map) =>
        $"{context}: Hilfe und Aktionen / Help and actions\n" +
        "Tab / Shift+Tab; Pfeile / arrows; PageUp / PageDown. Enter betätigt den fokussierten Knopf / activates the focused control. Keine Zielausführung / No target execution.\n" +
        string.Join("\n", ActionAvailability.All.Where(a => a.Id != ActionId.Confirm).Select(a => $"{map.KeysFor(a.Id)} {a.GermanName} / {a.EnglishName}: {(ActionAvailability.IsAvailable(a.Id, context) ? "verfügbar / available" : "nicht verfügbar / unavailable")}"));
}
