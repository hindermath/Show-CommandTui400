namespace ShowCommandTui400.Session;

public enum SessionPhase { Created, CapabilityCheck, Rejected, Running, Restoring, Closed }
public sealed record SessionContext(int ProcessId, Guid RunspaceId, string Location, string HostName);
