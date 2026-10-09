namespace ShowCommandTui400.Actions;

public enum ActionId { Help, Exit, Back, Select, Edit, Confirm, Refresh, Execute, Context, AllParameters, MoreParameters, Details, ActionsMenu }
public enum ViewContext { Root, Help }
public sealed record ActionDescriptor(ActionId Id, string GermanName, string EnglishName, IReadOnlySet<ViewContext> Contexts, bool Available);
