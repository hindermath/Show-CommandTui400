namespace ShowCommandTui400.Actions;

public sealed class KeyBindingMap
{
    private readonly IReadOnlyDictionary<string, ActionId> bindings;
    public KeyBindingMap(IReadOnlyDictionary<string, ActionId> validatedBindings) => bindings = new Dictionary<string,ActionId>(validatedBindings, StringComparer.Ordinal).AsReadOnly();
    public ActionId? Resolve(string key) => bindings.TryGetValue(key, out var action) ? action : null;
    public string KeysFor(ActionId action) => string.Join(", ", bindings.Where(p => p.Value == action).Select(p => p.Key));
    public IEnumerable<string> Keys => bindings.Keys;
}
