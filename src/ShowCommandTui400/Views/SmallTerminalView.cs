using ShowCommandTui400.Resources;
using ShowCommandTui400.State;
namespace ShowCommandTui400.Views;

public static class SmallTerminalView
{
    // Put recovery keys first: at 20x5 the client has only three short text rows.
    public static string Render(ViewState state, bool help) =>
        "Alt+X " + Messages.InLanguage("ShortExit", "de") + "/" + Messages.InLanguage("ShortExit", "en") + "\n" +
        "Alt+H " + Messages.InLanguage("Help", "de") + "/" + Messages.InLanguage("Help", "en") + "\n" +
        Messages.InLanguage("SmallTitle", "de") + "/" + Messages.InLanguage("SmallTitle", "en") + "\n" +
        Messages.Both(help ? "SmallHelp" : "Small") + "\n" + Messages.Both("SmallKeys") +
        $"\n{state.Width}x{state.Height}; {ResizeCoordinator.MinimumWidth}x{ResizeCoordinator.MinimumHeight}";
}
