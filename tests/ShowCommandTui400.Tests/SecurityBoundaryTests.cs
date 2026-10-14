using System.Diagnostics.Tracing;
using ShowCommandTui400.Actions;
using ShowCommandTui400.Presentation;
using ShowCommandTui400.Session;
using ShowCommandTui400.State;
namespace ShowCommandTui400.Tests;

public static class SecurityBoundaryTests
{
    public static string[] Run()
    {
        var state = new ViewState(); state.Values["synthetic"] = "retained";
        var dispatcher = new ActionDispatcher(state);
        foreach (var pair in new[] { ((ActionId)(-1),ViewContext.Root), (ActionId.Help,(ViewContext)999), (ActionId.Execute,ViewContext.Root), (ActionId.Edit,ViewContext.Root) })
            if (dispatcher.Dispatch(pair.Item1,pair.Item2).Accepted) throw new Exception("Security context accepted");
        foreach (var input in new[] { "Invoke-Lh01SyntheticTarget", "$(Invoke-Lh01SyntheticTarget)", "Help;Invoke-Lh01SyntheticTarget", "0" })
        {
            try { KeyBindingValidator.Validate(new Dictionary<string,string> { [input]="F2" }); }
            catch (EntryRejectedException) { continue; }
            throw new Exception("Action text evaluated/accepted");
        }
        foreach (var key in new[] { "$(Invoke-Lh01SyntheticTarget)", "\u001b[2J", "F3" })
        {
            try { KeyBindingValidator.Validate(new Dictionary<string,string> { ["Help"]=key }); }
            catch (EntryRejectedException) { continue; }
            throw new Exception("Unsafe key accepted");
        }
        if (SafeDisplayText.Format("synthetic\u001b[2J\u0007\u202evalue") != "synthetic?[2J??value") throw new Exception("Unsafe display");
        if (state.Values["synthetic"]!="retained" || dispatcher.Context!=ViewContext.Root || dispatcher.ExitRequested) throw new Exception("Negative effect");
        return ["SEC01-unknown-context-unavailable-no-effect", "SEC02-action-text-never-evaluated", "SEC03-key-injection-conflict-rejected", "SEC04-control-format-display-sanitized"];
    }
}
// Observe event counts only, never URLs, addresses or private event payloads.
public sealed class NetworkObservation : EventListener
{
    private int events;
    public int ConnectionAttempts => Volatile.Read(ref events);
    protected override void OnEventSourceCreated(EventSource source)
    {
        if (source.Name is "System.Net.Http" or "System.Net.Sockets" or "System.Net.NameResolution") EnableEvents(source, EventLevel.Informational);
    }
    protected override void OnEventWritten(EventWrittenEventArgs data)
    {
        if (data.EventName is "RequestStart" or "ConnectStart" or "ResolutionStart") Interlocked.Increment(ref events);
    }
}
