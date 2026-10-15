using Terminal.Gui.App;
using Terminal.Gui.Drawing;
using Terminal.Gui.Input;
using Terminal.Gui.ViewBase;
using Terminal.Gui.Views;
using ShowCommandTui400.Actions;
using ShowCommandTui400.State;
using ShowCommandTui400.Views;
using ShowCommandTui400.Presentation;
using ShowCommandTui400.Resources;
namespace ShowCommandTui400.Terminal;

internal interface ITerminalApplication : IDisposable { void Run(IReadOnlyDictionary<string, ActionId> bindings); void Stop(); }
internal sealed class TerminalApplication : ITerminalApplication
{
    internal sealed record InputObservation(string Key, string? Action, string Context, string Focus, string? FrameworkFocus, bool Accepted, bool ExitRequested, int ScrollTop);
    internal static Action<InputObservation>? InputObserver { get; set; }
    internal sealed record RenderObservation(int Width, int Height, bool Small, string Focus, string Context, bool Busy, string Text);
    internal static Action<RenderObservation>? RenderObserver { get; set; }
    internal static Action<ViewState>? StateInitializer { get; set; }
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
        var state = new ViewState();
        StateInitializer?.Invoke(state);
        var resize = new ResizeCoordinator(state);
        resize.Update(app.Screen.Width, app.Screen.Height);
        var dispatcher = new ActionDispatcher(state);
        var navigation = new NavigationAdapter(state);
        var map = new KeyBindingMap(bindings);
        TextView text = new() { X = 1, Y = 5, Width = Dim.Fill(1), Height = Dim.Fill(1), ReadOnly = true, WordWrap = true, CanFocus = false };
        var controls = NavigationAdapter.FocusOrder.Select((name, index) => new Button
        {
            X = 1, Y = 1 + index, Text = Messages.Both(name), CanFocus = true, Id = name
        }).ToArray();
        // Activation is owned by the action adapter; Enter never runs a target command.
        foreach (var control in controls) window.Add(control);
        window.Add(text);
        // The inherited ReadOnly role can collapse to equal colors. Keep the
        // window's readable text colors without adding a keyboard focus target.
        text.SetScheme(new Scheme(text.GetScheme()) { ReadOnly = window.GetScheme().Normal });
        void Render()
        {
            foreach (var control in controls) control.Visible = !resize.IsSmall;
            text.X = resize.IsSmall ? 0 : 1; text.Y = resize.IsSmall ? 0 : 5;
            text.Text = resize.IsSmall ? SmallTerminalView.Render(state, dispatcher.Context == ViewContext.Help) : AccessibleStatePresenter.Render(state, dispatcher.Context, map);
            int index = NavigationAdapter.FocusOrder.ToList().IndexOf(state.Focus);
            if (!resize.IsSmall && index >= 0) controls[index].SetFocus();
            RenderObserver?.Invoke(new(state.Width, state.Height, resize.IsSmall, state.Focus, dispatcher.Context.ToString(), state.Busy, text.Text));
        }
        foreach (var pair in controls.Select((control, index) => (control, index)))
        {
            pair.control.Accepting += (_, args) =>
            {
                args.Handled = true;
                state.Focus = NavigationAdapter.FocusOrder[pair.index];
                var action = pair.index switch { 0 => ActionId.Help, 1 => ActionId.ActionsMenu, _ => ActionId.Refresh };
                if (action == ActionId.Refresh) state.Error = null;
                dispatcher.Dispatch(action, dispatcher.Context); Render();
            };
        }
        Render();
        var keys = map.Keys.Select(k => (Key: Parse(k), Name: k)).ToArray();
        app.Keyboard.KeyDown += (_, key) =>
        {
            if (key == Key.C.WithCtrl) { key.Handled = true; app.RequestStop(); return; }
            string? name = keys.Where(p => key == p.Key).Select(p => p.Name).FirstOrDefault();
            string? navigationKey = key == Key.Tab ? "Tab" : key == Key.Tab.WithShift ? "Shift+Tab" :
                key == Key.CursorUp ? "Up" : key == Key.CursorDown ? "Down" : key == Key.CursorLeft ? "Left" :
                key == Key.CursorRight ? "Right" : key == Key.PageUp ? "PageUp" : key == Key.PageDown ? "PageDown" : null;
            ActionId? action = name == null ? null : map.Resolve(name);
            if (key == Key.Enter) action = navigation.ActivationAction;
            // Unmapped input has no effect; framework defaults must not bypass the action whitelist.
            if (action == null && navigationKey == null)
            {
                key.Handled = true;
                return;
            }
            key.Handled = true;
            bool accepted;
            if (resize.IsSmall && action is not (ActionId.Help or ActionId.Back or ActionId.Exit))
            {
                accepted = false;
            }
            else if (navigationKey is "PageUp" or "PageDown" && dispatcher.Context != ViewContext.Root)
            {
                text.ScrollVertical(navigationKey == "PageDown" ? Math.Max(1, text.Viewport.Height - 1) : -Math.Max(1, text.Viewport.Height - 1));
                accepted = true;
            }
            else if (navigationKey != null) accepted = navigation.Move(navigationKey);
            else
            {
                var result = dispatcher.Dispatch(action!.Value, dispatcher.Context);
                accepted = result.Accepted;
                if (!accepted) state.Error = result.Message;
                else if (action == ActionId.Refresh) state.Error = null;
            }
            if (navigationKey is not ("PageUp" or "PageDown") || dispatcher.Context == ViewContext.Root || resize.IsSmall) Render();
            InputObserver?.Invoke(new(name ?? navigationKey ?? "Enter", action?.ToString(), dispatcher.Context.ToString(), state.Focus, controls.Select((c, i) => (c, i)).Where(p => p.c.HasFocus).Select(p => NavigationAdapter.FocusOrder[p.i]).FirstOrDefault(), accepted, dispatcher.ExitRequested, text.Viewport.Y));
            if (dispatcher.ExitRequested) app.RequestStop();
        };
        app.Iteration += (_, _) =>
        {
            if (state.Width != app.Screen.Width || state.Height != app.Screen.Height)
            {
                resize.Update(app.Screen.Width, app.Screen.Height); Render();
            }
            lock (gate) { if (stopRequested) app.RequestStop(); }
        };
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
        _ => throw new InvalidOperationException(ShowCommandTui400.Resources.Messages.Both("UnvalidatedBinding"))
    };
    public void Dispose() { Stop(); }
}
