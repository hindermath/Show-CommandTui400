using System.Management.Automation;
using System.Management.Automation.Runspaces;
namespace ShowCommandTui400.Session;

internal static class CallerSessionAdapter
{
    public static SessionContext Capture(PSCmdlet command)
    {
        var runspace = Runspace.DefaultRunspace ?? throw new EntryRejectedException("InvalidContext", "Keine Aufrufersitzung. / No caller runspace.");
        return new(Environment.ProcessId, runspace.InstanceId, command.SessionState.Path.CurrentLocation.Path, command.Host.Name);
    }
}
