using ShowCommandTui400.Session;
namespace ShowCommandTui400.Actions;

public static class KeyBindingValidator
{
    private static readonly Dictionary<string, ActionId> Fixed = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Alt+H"] = ActionId.Help,
        ["Alt+B"] = ActionId.Back,
        ["Alt+X"] = ActionId.Exit,
        ["Esc"] = ActionId.Back
    };
    public static IReadOnlyDictionary<string, ActionId> Validate(IDictionary<string, string>? remap)
    {
        var primary = new Dictionary<ActionId, string> { [ActionId.Help] = "F1", [ActionId.Exit] = "F3", [ActionId.Back] = "F12" };
        var seen = new HashSet<ActionId>();
        foreach (var pair in remap ?? new Dictionary<string, string>())
        {
            if (!Enum.TryParse<ActionId>(pair.Key, false, out var action) || pair.Key != action.ToString() || !primary.ContainsKey(action) || !seen.Add(action) || pair.Value is null || !ValidKey(pair.Value)) Invalid();
            primary[action] = pair.Value!;
        }
        var result = new Dictionary<string, ActionId>(Fixed, StringComparer.OrdinalIgnoreCase);
        foreach (var pair in primary)
        {
            if (result.TryGetValue(pair.Value, out var other) && other != pair.Key) Invalid();
            if (primary.Any(p => p.Key != pair.Key && string.Equals(p.Value, pair.Value, StringComparison.OrdinalIgnoreCase))) Invalid();
            result[pair.Value] = pair.Key;
        }
        return result.AsReadOnly();
    }
    private static bool ValidKey(string value) => Fixed.Keys.Contains(value, StringComparer.Ordinal) || value == "Alt+M" || (value.StartsWith('F') && int.TryParse(value.AsSpan(1), out var n) && n is >= 1 and <= 12 && value == "F" + n);
    private static void Invalid() => throw new EntryRejectedException("InvalidConfiguration", "Ungültige oder kollidierende Tastenbelegung. / Invalid or conflicting key binding.");
}
