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
    private IApplication? active;
    private readonly object appLock = new();
    private readonly List<object> uiEvents = new();
    protected override void StopProcessing()
    {
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
        if (Mode == "Contract") { WriteObject(JsonSerializer.Serialize(CheckContract())); return; }
        if (Mode == "Ui")
        {
            // Prüfen vor jeder Terminaländerung. / Reject before terminal mutation.
            if (Console.IsInputRedirected || Console.IsOutputRedirected || Host.UI.RawUI == null)
            {
                ThrowTerminatingError(new ErrorRecord(new InvalidOperationException("Nichtinteraktiv / Non-interactive"), "CapabilityRejected", ErrorCategory.InvalidOperation, null));
                return;
            }
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
        var state = new ActionState();
        using IApplication app = Application.Create();
        lock (appLock) active = app;
        try
        {
            app.Init();
            using Window window = new() { Title = "LH-01 FIXTURE — F3 exit / Ende, F8 injected error / Testfehler" };
            TextField input = new() { Text = ActionState.SafeText("synthetic-value"), X = 1, Y = 1, Width = Dim.Fill(1) };
            Label status = new() { Text = "F1 Help/Hilfe; F5 Refresh; F12/Esc Back/Zurueck; Alt+X Exit; F4/9/10/11 unavailable", X = 1, Y = 3, Width = Dim.Fill(1) };
            window.Add(input, status);
            app.ScreenChanged += (_, _) => {
                bool small = app.Screen.Width < 40 || app.Screen.Height < 8;
                status.Text = small ? "Alt+X Ende/Exit" : "Bereit / Ready; F3/Alt+X exit";
                uiEvents.Add(new { Kind = "Resize", Width = app.Screen.Width, Height = app.Screen.Height, Small = small, Value = input.Text.ToString(), Focus = input.HasFocus });
            };
            app.Keyboard.KeyDown += (_, key) => {
                string action = key == Key.F1 ? "Help" : key == Key.F3 || key == Key.X.WithAlt ? "Exit" : key == Key.F5 ? "Refresh" : key == Key.F12 || key == Key.Esc ? "Back" : key == Key.C.WithCtrl ? "Cancel" : key == Key.F8 ? "InjectedError" : key == Key.F4 || key == Key.F9 || key == Key.F10 || key == Key.F11 ? "Unavailable" : "Unknown";
                if (action == "Unknown") return;
                key.Handled = true;
                state.Value = ActionState.SafeText(input.Text.ToString());
                uiEvents.Add(new { Kind = "Action", Action = action, Value = state.Value, Focus = input.HasFocus });
                if (action == "InjectedError") { injected = true; app.RequestStop(); return; }
                state.Dispatch(action, true);
                status.Text = $"{action}; Value/Wert={state.Value}; Focus/Fokus={input.HasFocus}; no execution / keine Ausfuehrung";
                if (action is "Exit" or "Cancel") app.RequestStop();
            };
            app.Run(window);
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
