using ShowCommandTui400.Resources;
using ShowCommandTui400.State;
namespace ShowCommandTui400.Views;

public sealed class ResizeCoordinator(ViewState state)
{
    // Three vertically stacked controls, four state rows, two help rows and four layout/border rows.
    public const int MinimumHeight = 13;
    // Current fixed resource labels use single-cell Latin characters; six cells cover button/window margins.
    public static int MinimumWidth => NavigationAdapter.FocusOrder.Max(key => Messages.Both(key).Length) + 6;
    public bool IsSmall => state.Width < MinimumWidth || state.Height < MinimumHeight;
    public void Update(int width, int height) { state.Width = Math.Max(0, width); state.Height = Math.Max(0, height); }
}
