using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text.Json;
using Terminal.Gui.App;
using Terminal.Gui.Input;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;

namespace Lh01Feasibility;

// Isoliertes Wegwerfbeispiel, kein Produkt-Cmdlet. / Isolated fixture, not product code.
[Cmdlet(VerbsDiagnostic.Test, "Lh01Fixture")]
public sealed class Fixture : PSCmdlet
{
    [Parameter][ValidateSet("Scope", "Contract", "Ui")]
    public string Mode { get; set; } = "Scope";
    [Parameter][ValidateSet("dotnet")] public string Driver { get; set; } = "dotnet";
    [Parameter][ValidateSet("F1", "F2")] public string HelpKey { get; set; } = "F1";
    [Parameter] public SwitchParameter InvalidContext { get; set; }
    public static ManualResetEventSlim UiReady { get; } = new(false);
    public static int StopCount;
    public static object? LastTerminalRestore => DarwinTerminalSnapshot.LastObservation;
    private IApplication? active;
    private readonly object appLock = new();
    private readonly List<object> uiEvents = new();
    protected override void StopProcessing()
    {
        Interlocked.Increment(ref StopCount);
        lock (appLock)
        {
            var app = active;
            if (app is null) return;
            // Cancellation races disposal; only an already disposed loop is ignorable.
            try { app.Invoke(() => app.RequestStop()); } catch (ObjectDisposedException) { }
        }
    }
    protected override void ProcessRecord()
    {
        var terminalSnapshot = Mode == "Ui" ? DarwinTerminalSnapshot.CaptureIfTerminal() : null;
        Exception? primaryError = null;
        try { ProcessRecordCore(terminalSnapshot); }
        catch (Exception error) { primaryError = error; throw; }
        finally
        {
            try { terminalSnapshot?.Dispose(); }
            catch (Exception restoreError) when (primaryError is not null)
            { throw new AggregateException("UI and restoration failed / UI und Wiederherstellung fehlgeschlagen", primaryError, restoreError); }
        }
    }
    private void ProcessRecordCore(DarwinTerminalSnapshot? terminalSnapshot)
    {
        if (Mode == "Contract") { WriteObject(JsonSerializer.Serialize(CheckContract())); return; }
        if (Mode == "Ui")
        {
            // Prüfen vor jeder Terminaländerung. / Reject before terminal mutation.
            if (Console.IsInputRedirected || Console.IsOutputRedirected || Host.UI.RawUI == null)
            {
                ThrowTerminatingError(new ErrorRecord(new InvalidOperationException("Nichtinteraktiv / Non-interactive"), "CapabilityRejected", ErrorCategory.InvalidOperation, null));
                return;
            }
            terminalSnapshot?.ActivateConsoleLease();
            RunUi();
        }
        WriteObject(JsonSerializer.Serialize(new {
            Pid = Environment.ProcessId, Runspace = Runspace.DefaultRunspace?.InstanceId,
            Synthetic = SessionState.PSVariable.GetValue("Lh01Synthetic"),
            Location = SessionState.Path.CurrentLocation.Path,
            FunctionVisible = SessionState.InvokeCommand.GetCommand("Get-Lh01Synthetic", CommandTypes.Function) != null,
            Framework = typeof(Application).Assembly.GetName().Version?.ToString(), UiEvents = uiEvents
        }));
    }
    private void RunUi()
    {
        bool injected = false;
        UiReady.Reset();
        var state = new ActionState();
        using IApplication app = Application.Create();
        lock (appLock) active = app;
        try
        {
            // Explicit .NET console driver avoids the unverified macOS termios ABI path.
            app.Init(Driver);
            using Window window = new() { Title = "LH-01 FIXTURE — F3 exit / Ende, F8 injected error / Testfehler" };
            TextField input = new() { Text = ActionState.SafeText("synthetic-value"), X = 1, Y = 1, Width = Dim.Fill(1) };
            Label status = new() { Text = "F1 Help/Hilfe; F5 Refresh; F12/Esc Back/Zurueck; Alt+X Exit; F4/9/10/11 unavailable", X = 1, Y = 3, Width = Dim.Fill(1) };
            TextField second = new() { Text = "second-value", X = 1, Y = 2, Width = Dim.Fill(1) };
            ListView list = new() { X = 1, Y = 4, Width = Dim.Fill(1), Height = 5 };
            list.SetSource(new System.Collections.ObjectModel.ObservableCollection<string>(Enumerable.Range(0,20).Select(i => $"synthetic-item-{i}")));
            window.Add(input, second, list, status);
            status.Text = $"{HelpKey} Hilfe/Help; Alt+H Hilfe; Alt+M Aktionen/Actions; Alt+X Ende/Exit";
            app.Iteration += (_, _) => UiReady.Set();
            app.ScreenChanged += (_, _) => {
                bool small = app.Screen.Width < 40 || app.Screen.Height < 8;
                status.Text = small ? "Alt+X Ende/Exit" : "Bereit / Ready; F3/Alt+X exit";
                uiEvents.Add(new { Kind = "Resize", Width = app.Screen.Width, Height = app.Screen.Height, Small = small, Value = input.Text.ToString(), Focus = input.HasFocus });
            };
            app.Keyboard.KeyDown += (_, key) => {
                uiEvents.Add(new { Kind = "Input", Key = key.ToString(), FocusName = input.HasFocus ? "first" : second.HasFocus ? "second" : list.HasFocus ? "list" : "other", Selected = list.SelectedItem, Value = input.Text.ToString() });
                if (list.HasFocus && (key == Key.CursorDown || key == Key.CursorUp || key == Key.PageDown || key == Key.PageUp))
                {
                    key.Handled = true;
                    if (key == Key.CursorDown) list.MoveDown(false);
                    else if (key == Key.CursorUp) list.MoveUp(false);
                    else if (key == Key.PageDown) list.MovePageDown(false);
                    else list.MovePageUp(false);
                    return;
                }
                string action = key == (HelpKey == "F2" ? Key.F2 : Key.F1) || key == Key.H.WithAlt ? "Help" : key == Key.F3 || key == Key.X.WithAlt ? "Exit" : key == Key.F5 ? "Refresh" : key == Key.F12 || key == Key.Esc || key == Key.B.WithAlt ? "Back" : key == Key.M.WithAlt ? "ActionsMenu" : key == Key.Enter ? (InvalidContext ? "Unavailable" : "Confirm") : key == Key.C.WithCtrl ? "Cancel" : key == Key.F8 ? "InjectedError" : key == Key.F4 || key == Key.F9 || key == Key.F10 || key == Key.F11 ? "Unavailable" : "Unknown";
                if (action == "Unknown") return;
                key.Handled = true;
                state.Value = ActionState.SafeText(input.Text.ToString());
                uiEvents.Add(new { Kind = "Action", Action = action, Value = state.Value, Focus = input.HasFocus });
                if (action == "InjectedError") { injected = true; app.RequestStop(); return; }
                state.Dispatch(action, true);
                status.Text = $"{action}; Value/Wert={state.Value}; Focus/Fokus={input.HasFocus}; no execution / keine Ausfuehrung";
                if (action == "ActionsMenu") status.Text = "Aktionen/Actions: Alt+H Hilfe/Help; Alt+B Zurueck/Back; Alt+X Ende/Exit";
                if (action is "Exit" or "Cancel") app.RequestStop();
            };
            app.Run(window);
            uiEvents.Add(new { Kind = "FinalState", First = input.Text.ToString(), Second = second.Text.ToString(), Selected = list.SelectedItem });
        }
        finally { lock (appLock) active = null; }
        // using garantiert Dispose auch beim Testfehler. / Dispose also runs on injected error.
        if (injected) throw new InvalidOperationException("Isolierter Testfehler / isolated test failure");
    }
    private static object CheckContract()
    {
        var checks = new List<string>();
        void Assert(bool condition, string name) { if (!condition) throw new InvalidOperationException(name); checks.Add(name); }
        var state = new ActionState();
        foreach (string a in new[] { "Unknown", "Unavailable", "Execute", "$(bad)", "Import", "Network" })
        { var before = state.Value; state.Dispatch(a, true); Assert(state.Value == before && !state.Exited, "unknown-or-unavailable:" + a); }
        state.Dispatch("Exit", false); Assert(!state.Exited, "invalid-context");
        foreach (string a in new[] { "Help", "Refresh", "Back", "Confirm", "Next", "Previous" })
        { state.Dispatch(a, true); Assert(state.Value == "synthetic-value" && !state.Exited, "preserve-value:" + a); }
        Assert(!ActionState.ValidRemap(new[] { "Help", "Exit", "Exit" }), "duplicate-remap-rejected");
        Assert(!ActionState.ValidRemap(new[] { "Help", "Back" }), "missing-exit-rejected");
        Assert(ActionState.ValidRemap(new[] { "Help", "Back", "Exit" }), "escape-paths-preserved");
        Assert(ActionState.SafeText("a\u001bb\u0007c") == "a?b?c", "control-display-sanitized");
        state.Dispatch("Exit", true); Assert(state.Exited, "explicit-exit-only");
        return new { Checks = checks, TargetExecutorPresent = false, Scope = "fixture model only; not terminal key proof" };
    }
}
internal sealed class ActionState
{
    public string Value { get; set; } = "synthetic-value";
    public bool Exited { get; private set; }
    public void Dispatch(string action, bool validContext)
    {
        if (!validContext) return;
        if (action == "Exit") Exited = true;
        // Other fixture actions intentionally preserve data; no target executor exists.
    }
    public static bool ValidRemap(string[] actions) => actions.Distinct().Count() == actions.Length && new[] { "Help", "Back", "Exit" }.All(actions.Contains);
    public static string SafeText(string text) => new(text.Select(c => char.IsControl(c) ? '?' : c).ToArray());
}
