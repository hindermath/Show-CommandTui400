namespace ShowCommandTui400.State;

public sealed class ViewState
{
    public string Focus { get; set; } = "Root";
    public Dictionary<string, string> Values { get; } = new(StringComparer.Ordinal);
    public string Status { get; set; } = "Bereit / Ready";
    public string? Error { get; set; }
    public string? PreviousView { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}
