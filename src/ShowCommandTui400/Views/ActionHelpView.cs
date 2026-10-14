using ShowCommandTui400.Actions;
using ShowCommandTui400.Resources;
namespace ShowCommandTui400.Views;

public static class ActionHelpView
{
    public static string Render(ViewContext context, KeyBindingMap map) =>
        $"{Messages.Both(context.ToString())}: {Messages.Both("HelpTitle")}\n" + Messages.Both("Navigation") + "\n" +
        string.Join("\n", ActionAvailability.All.Where(a => a.Id != ActionId.Confirm).Select(a => $"{map.KeysFor(a.Id)} {a.GermanName} / {a.EnglishName}: {Messages.Both(ActionAvailability.IsAvailable(a.Id, context) ? "Available" : "Unavailable")}"));
}
