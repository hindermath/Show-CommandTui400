using ShowCommandTui400.State;
using ShowCommandTui400.Actions;
namespace ShowCommandTui400.Views;

public sealed class NavigationAdapter(ViewState state)
{
    public static IReadOnlyList<string> FocusOrder { get; } = Array.AsReadOnly(new[] { "Help", "ActionsMenu", "Refresh" });
    public ActionId ActivationAction => state.Focus switch { "Help" => ActionId.Help, "ActionsMenu" => ActionId.ActionsMenu, "Refresh" => ActionId.Refresh, _ => ActionId.Confirm };
    public bool Move(string key)
    {
        int index = FocusOrder.ToList().IndexOf(state.Focus);
        if (index < 0) index = 0;
        int next = key switch
        {
            "Tab" or "Down" or "Right" => (index + 1) % FocusOrder.Count,
            "Shift+Tab" or "Up" or "Left" => (index + FocusOrder.Count - 1) % FocusOrder.Count,
            "PageUp" => 0, "PageDown" => FocusOrder.Count - 1, _ => -1
        };
        if (next < 0) return false;
        state.Focus = FocusOrder[next]; return true;
    }
}
