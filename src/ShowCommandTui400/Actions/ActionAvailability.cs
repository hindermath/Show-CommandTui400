namespace ShowCommandTui400.Actions;

public static class ActionAvailability
{
    // These are local shell actions only. Later domain features have no handler.
    public static IReadOnlyList<ActionDescriptor> All { get; } = Array.AsReadOnly(new[]
    {
        Describe(ActionId.Help, "Hilfe", "Help", true), Describe(ActionId.Exit, "Beenden", "Exit", true),
        Describe(ActionId.Back, "Zurück", "Back", true), Describe(ActionId.Refresh, "Aktualisieren", "Refresh", true),
        Describe(ActionId.Confirm, "Bestätigen", "Confirm", true), Describe(ActionId.ActionsMenu, "Aktionen", "Actions", true),
        Describe(ActionId.Context, "Kontextauswahl", "Context selection", false),
        Describe(ActionId.AllParameters, "Alle Parameter", "All parameters", false),
        Describe(ActionId.MoreParameters, "Weitere Parameter", "More parameters", false),
        Describe(ActionId.Details, "Details", "Details", false), Describe(ActionId.Select, "Auswählen", "Select", false),
        Describe(ActionId.Edit, "Bearbeiten", "Edit", false), Describe(ActionId.Execute, "Ausführen", "Execute", false)
    });
    private static ActionDescriptor Describe(ActionId id, string de, string en, bool available) =>
        new(id, de, en, System.Collections.Frozen.FrozenSet.ToFrozenSet(new[] { ViewContext.Root, ViewContext.Help, ViewContext.ActionsMenu }), available);
    public static bool IsAvailable(ActionId id, ViewContext context) =>
        All.Any(a => a.Id == id && a.Available && a.Contexts.Contains(context));
}
