using ShowCommandTui400.State;
namespace ShowCommandTui400.Actions;

public sealed record ActionResult(bool Accepted, string Message);
public sealed class ActionDispatcher(ViewState state)
{
    private readonly Stack<(ViewContext Context, string Focus)> history = new();
    public ViewContext Context { get; private set; } = ViewContext.Root;
    public bool ExitRequested { get; private set; }
    public ActionResult Dispatch(ActionId action, ViewContext expectedContext)
    {
        // Check the live context again at dispatch, even when a UI adapter checked it.
        if (expectedContext != Context || !ActionAvailability.IsAvailable(action, Context))
            return new(false, ShowCommandTui400.Resources.Messages.Both("ActionRejected"));
        switch (action)
        {
            case ActionId.Exit: ExitRequested = true; break;
            case ActionId.Help: Open(ViewContext.Help); break;
            case ActionId.ActionsMenu: Open(ViewContext.ActionsMenu); break;
            case ActionId.Back:
                if (history.TryPop(out var prior)) { Context = prior.Context; state.Focus = prior.Focus; }
                break;
            case ActionId.Refresh: state.Status = ShowCommandTui400.Resources.Messages.Both("Refreshed"); break;
            case ActionId.Confirm: state.Status = ShowCommandTui400.Resources.Messages.Both("Confirmed"); break;
        }
        return new(true, state.Status);
    }
    private void Open(ViewContext next)
    {
        if (Context == next) return;
        history.Push((Context, state.Focus)); Context = next;
    }
}
