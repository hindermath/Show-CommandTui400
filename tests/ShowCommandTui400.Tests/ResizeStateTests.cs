using ShowCommandTui400.State;
using ShowCommandTui400.Views;
namespace ShowCommandTui400.Tests;
public static class ResizeStateTests
{
    public static string[] Run()
    {
        var state = new ViewState { Focus="ActionsMenu" };state.Values["synthetic"]="retained";
        var resize = new ResizeCoordinator(state);
        foreach (var size in new[] { (0,0),(-1,1),(1,1),(20,5),(100,30),(50,20),(100,24) })
        {
            resize.Update(size.Item1,size.Item2);
            if (state.Values["synthetic"]!="retained" || state.Focus!="ActionsMenu") throw new Exception("Resize lost state");
            if (size.Item1<=1 && !resize.IsSmall) throw new Exception("Tiny size accepted");
        }
        resize.Update(ResizeCoordinator.MinimumWidth-1,ResizeCoordinator.MinimumHeight);
        if (!resize.IsSmall || !SmallTerminalView.Render(state,false).Contains("Alt+X")) throw new Exception("Small exit missing");
        resize.Update(ResizeCoordinator.MinimumWidth,ResizeCoordinator.MinimumHeight);
        if (resize.IsSmall) throw new Exception("Minimum boundary");
        var nav=new NavigationAdapter(state);nav.Move("Tab");
        if(state.Focus!="Refresh" || state.Values["synthetic"]!="retained") throw new Exception("Post-resize navigation");
        return ["R01-invalid-tiny-size", "R02-resize-preserves-values-focus", "R03-measured-layout-boundary", "R04-post-resize-navigation"];
    }
}
