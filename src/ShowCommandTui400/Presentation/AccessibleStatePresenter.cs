using ShowCommandTui400.Actions;
using ShowCommandTui400.Resources;
using ShowCommandTui400.State;
using ShowCommandTui400.Views;
namespace ShowCommandTui400.Presentation;

public static class AccessibleStatePresenter
{
    public static string Render(ViewState state, ViewContext context, KeyBindingMap bindings) =>
        $"{Messages.Both("Focus")}: {FocusName(state.Focus)}\n" +
        $"{Messages.Both("Busy")}: {Messages.Both(state.Busy ? "Yes" : "No")}\n" +
        $"{Messages.Both("Status")}: {SafeDisplayText.Format(state.Status)}\n" +
        $"{Messages.Both("Error")}: {(state.Error == null ? Messages.Both("NoError") : SafeDisplayText.Format(state.Error))}\n" +
        Messages.Both("Role") + "\n" + ActionHelpView.Render(context, bindings);
    private static string FocusName(string id) => ActionAvailability.All.FirstOrDefault(a => a.Id.ToString() == id) is { } focus
        ? focus.GermanName + " / " + focus.EnglishName : SafeDisplayText.Format(id);
}
