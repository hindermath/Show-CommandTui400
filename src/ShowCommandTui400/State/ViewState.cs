namespace ShowCommandTui400.State;

public sealed class ViewState
{
    public string Focus { get; set; } = "Help";
    public Dictionary<string, string> Values { get; } = new(StringComparer.Ordinal);
    public string Status { get; set; } = ShowCommandTui400.Resources.Messages.Both("Ready");
    public bool Busy { get; set; }
    public string? Error { get; set; }
    public string? PreviousView { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
}
