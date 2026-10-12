using ShowCommandTui400.Actions;
using ShowCommandTui400.State;
using ShowCommandTui400.Views;
namespace ShowCommandTui400.Tests;
public static class ActionContractTests
{
    public static string[] Run()
    {
        static void Check(bool ok, string name) { if (!ok) throw new Exception(name); }
        var state = new ViewState(); state.Values["synthetic"] = "retained";
        var dispatcher = new ActionDispatcher(state);
        Check(!dispatcher.Dispatch((ActionId)999, ViewContext.Root).Accepted, "unknown action");
        Check(!dispatcher.Dispatch(ActionId.Help, ViewContext.Help).Accepted, "forged context");
        foreach (var action in new[] { ActionId.Context, ActionId.AllParameters, ActionId.MoreParameters, ActionId.Details, ActionId.Execute, ActionId.Edit, ActionId.Select })
            Check(!dispatcher.Dispatch(action, ViewContext.Root).Accepted, "unavailable " + action);
        Check(state.Values["synthetic"] == "retained" && dispatcher.Context == ViewContext.Root, "negative side effects");
        Check(dispatcher.Dispatch(ActionId.Back, ViewContext.Root).Accepted && !dispatcher.ExitRequested, "root back is not exit");
        var nav = new NavigationAdapter(state);
        nav.Move("Tab"); var focus = state.Focus;
        dispatcher.Dispatch(ActionId.Help, ViewContext.Root);
        Check(dispatcher.Context == ViewContext.Help, "help context");
        dispatcher.Dispatch(ActionId.Back, ViewContext.Help);
        Check(state.Focus == focus && dispatcher.Context == ViewContext.Root, "back restores focus");
        dispatcher.Dispatch(ActionId.Refresh, ViewContext.Root);
        dispatcher.Dispatch(ActionId.Confirm, ViewContext.Root);
        Check(state.Focus == focus && state.Values["synthetic"] == "retained" && !dispatcher.ExitRequested, "refresh/confirm preserve values");
        nav.Move("Shift+Tab"); Check(state.Focus == "Help" && nav.ActivationAction == ActionId.Help, "reverse focus/help activation");
        nav.Move("PageDown"); Check(state.Focus == "Refresh" && nav.ActivationAction == ActionId.Refresh, "page end/refresh activation");
        nav.Move("PageUp"); Check(state.Focus == "Help", "page start");
        nav.Move("Down"); Check(state.Focus == "ActionsMenu" && nav.ActivationAction == ActionId.ActionsMenu, "arrow/menu activation");
        Check(!nav.Move("unknown") && state.Focus == "ActionsMenu", "unknown navigation");
        dispatcher.Dispatch(ActionId.ActionsMenu, ViewContext.Root);
        Check(dispatcher.Context == ViewContext.ActionsMenu, "text menu");
        dispatcher.Dispatch(ActionId.Help, ViewContext.ActionsMenu);
        dispatcher.Dispatch(ActionId.Back, ViewContext.Help);
        Check(dispatcher.Context == ViewContext.ActionsMenu, "nested return");
        dispatcher.Dispatch(ActionId.Exit, ViewContext.ActionsMenu);
        Check(dispatcher.ExitRequested, "explicit exit");
        return ["K01-whitelist-context-negative", "K02-unavailable-no-effects", "K03-root-back", "K04-state-preservation", "K05-focus-navigation", "K06-nested-help-menu", "K07-explicit-exit"];
    }
}
