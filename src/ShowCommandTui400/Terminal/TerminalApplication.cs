using Terminal.Gui.App;
using Terminal.Gui.Input;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using ShowCommandTui400.Actions;
namespace ShowCommandTui400.Terminal;

internal interface ITerminalApplication : IDisposable { void Run(IReadOnlyDictionary<string, ActionId> bindings); void Stop(); }
internal sealed class TerminalApplication : ITerminalApplication
{
    private readonly object gate = new();
    private IApplication? active;
    private bool stopRequested;
    public void Stop()
    {
        lock (gate)
        {
            stopRequested = true;
            if (active != null) try { active.Invoke(() => active?.RequestStop()); } catch (ObjectDisposedException) { }
        }
    }
    public void Run(IReadOnlyDictionary<string, ActionId> bindings)
    {
        using IApplication app = Application.Create();
        app.Init("dotnet");
        using Window window = new() { Title = "Show-CommandTui400 — LH-01" };
        Label text = new() { X = 1, Y = 1, Width = Dim.Fill(1), Height = Dim.Fill(1), Text = "Bereit / Ready. Alt+H Hilfe/Help; Alt+X Ende/Exit. Keine Zielausführung / No target execution." };
        window.Add(text);
        var keys = bindings.Select(p => (Key: Parse(p.Key), Action: p.Value)).ToArray();
        app.Keyboard.KeyDown += (_, key) =>
        {
            if (key == Key.C.WithCtrl) { key.Handled = true; app.RequestStop(); return; }
            var match = keys.FirstOrDefault(p => key == p.Key);
            if (!keys.Any(p => key == p.Key)) return;
            key.Handled = true;
            if (match.Action == ActionId.Exit) app.RequestStop();
            else if (match.Action == ActionId.Help) text.Text = "Hilfe / Help: Alt+X Ende/Exit; Alt+B Zurück/Back. Dieser Einstieg führt keine Befehle aus / This entry executes no commands.";
            else text.Text = "Bereit / Ready; Alt+H Hilfe/Help; Alt+X Ende/Exit.";
        };
        app.Iteration += (_, _) => { lock (gate) { if (stopRequested) app.RequestStop(); } };
        lock (gate) { active = app; }
        try { app.Run(window); }
        finally { lock (gate) { active = null; } }
    }
    private static Key Parse(string value) => value switch
    {
        "Esc" => Key.Esc,
        "Alt+H" => Key.H.WithAlt,
        "Alt+B" => Key.B.WithAlt,
        "Alt+X" => Key.X.WithAlt,
        "Alt+M" => Key.M.WithAlt,
        "F1" => Key.F1,
        "F2" => Key.F2,
        "F3" => Key.F3,
        "F4" => Key.F4,
        "F5" => Key.F5,
        "F6" => Key.F6,
        "F7" => Key.F7,
        "F8" => Key.F8,
        "F9" => Key.F9,
        "F10" => Key.F10,
        "F11" => Key.F11,
        "F12" => Key.F12,
        _ => throw new InvalidOperationException("Binding was not validated")
    };
    public void Dispose() { Stop(); }
}
