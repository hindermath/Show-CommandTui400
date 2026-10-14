namespace ShowCommandTui400.Actions;

public static class ActionAvailability
{
    // These are local shell actions only. Later domain features have no handler.
    public static IReadOnlyList<ActionDescriptor> All { get; } = Array.AsReadOnly(new[]
    {
        Describe(ActionId.Help, true), Describe(ActionId.Exit, true),
        Describe(ActionId.Back, true), Describe(ActionId.Refresh, true),
        Describe(ActionId.Confirm, true), Describe(ActionId.ActionsMenu, true),
        Describe(ActionId.Context, false),
        Describe(ActionId.AllParameters, false),
        Describe(ActionId.MoreParameters, false),
        Describe(ActionId.Details, false), Describe(ActionId.Select, false),
        Describe(ActionId.Edit, false), Describe(ActionId.Execute, false)
    });
    private static ActionDescriptor Describe(ActionId id, bool available) =>
        new(id, ShowCommandTui400.Resources.Messages.InLanguage(id.ToString(), "de"), ShowCommandTui400.Resources.Messages.InLanguage(id.ToString(), "en"), System.Collections.Frozen.FrozenSet.ToFrozenSet(new[] { ViewContext.Root, ViewContext.Help, ViewContext.ActionsMenu }), available);
    public static bool IsAvailable(ActionId id, ViewContext context) =>
        All.Any(a => a.Id == id && a.Available && a.Contexts.Contains(context));
}
