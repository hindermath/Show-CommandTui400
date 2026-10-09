using System.Runtime.ExceptionServices;
using ShowCommandTui400.Session;
namespace ShowCommandTui400.Terminal;

public static class TerminalLifecycle
{
    public static void Run(ITerminalLease lease, Action body, Action<SessionPhase>? transition = null)
    {
        Exception? primary = null, restore = null;
        try { lease.Activate(); transition?.Invoke(SessionPhase.Running); body(); }
        catch (Exception e) { primary = e; }
        finally { transition?.Invoke(SessionPhase.Restoring); try { lease.Dispose(); } catch (Exception e) { restore = e; } finally { transition?.Invoke(SessionPhase.Closed); } }
        if (primary != null && restore != null) throw new TerminalCombinedFailureException(primary, restore);
        if (restore != null) throw new TerminalRestorationException(restore);
        if (primary != null) ExceptionDispatchInfo.Capture(primary).Throw();
    }
}
public sealed class TerminalRestorationException(Exception inner) : Exception("Terminal konnte nicht vollständig wiederhergestellt werden. / Terminal restoration failed.", inner);

public sealed class TerminalCombinedFailureException(Exception primary, Exception restore) : AggregateException("Ablauf- und Wiederherstellungsfehler / Operation and restoration failed", primary, restore);
