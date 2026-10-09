using ShowCommandTui400.Terminal;
namespace ShowCommandTui400.Tests;

public static class TerminalLifecycleTests
{
    private sealed class Lease(bool fail) : ITerminalLease
    {
        public int Activations, Disposals;
        public TerminalRestoreObservation? Observation => null;
        public void Activate() { Activations++; }
        public void Dispose() { Disposals++; if (fail) throw new IOException("synthetic restore failure"); }
    }
    public static string[] Run()
    {
        var passed = new List<string>();
        foreach (var primary in new[] { false, true }) foreach (var restore in new[] { false, true })
        {
            var lease = new Lease(restore); Exception? actual = null;
            try { TerminalLifecycle.Run(lease, () => { if (primary) throw new InvalidOperationException("synthetic primary failure"); }); }
            catch (Exception e) { actual = e; }
            if (lease.Activations != 1 || lease.Disposals != 1) throw new Exception("lease count");
            if (primary && restore && (actual is not AggregateException a || a.InnerExceptions.Count != 2 || a.InnerExceptions[0].Message != "synthetic primary failure" || a.InnerExceptions[1].Message != "synthetic restore failure")) throw new Exception("lost double error");
            if (!primary && !restore && actual != null) throw actual;
            if (primary != restore && actual == null) throw new Exception("lost single error");
            passed.Add($"primary={primary};restore={restore}");
        }
        try { TerminalLifecycle.Run(new Lease(false), () => throw new AggregateException("app only")); throw new Exception("missing app error"); }
        catch (AggregateException e) { if (e is TerminalCombinedFailureException) throw new Exception("app error misclassified"); }
        passed.Add("aggregate-primary-with-successful-restore");
        // Platform restoration uses the same injected native contract, without borrowing a foreign ABI.
        var native = new FakeNative();
        using (var linux = new LinuxTerminalLease(native)) { }
        if (native.Writes != 1 || native.Reads != 2) throw new Exception("Linux native contract");
        native = new FakeNative(); using (var mac = new MacTerminalLease(native)) { }
        if (native.Writes != 1 || native.Reads != 2) throw new Exception("Mac native contract");
        var windows=new FakeWindows();using(var lease=new WindowsTerminalLease(windows)){}
        if(windows.Writes!=1 || windows.Reads!=2)throw new Exception("Windows native contract");
        var mismatch=new FakeNative {Mismatch=true};
        try{new LinuxTerminalLease(mismatch).Dispose();throw new Exception("missing mismatch error");}catch(AggregateException e){if(!e.ToString().Contains("modes differ"))throw;}
        passed.Add("platform-native-doubles");
        return passed.ToArray();
    }
    private sealed class FakeWindows : IWindowsConsole {
        public int Reads,Writes;
        public WindowsSnapshot Read(){Reads++;return new(7,3,25,true);}
        public void Write(WindowsSnapshot value){Writes++;}
    }
    private sealed class FakeNative : INativeTerminal
    {
        public int Reads, Writes;
        public bool Mismatch;
        public string Platform => "Synthetic";
        public byte[] Read() { Reads++; return new byte[] { (byte)(Mismatch && Reads>1?9:1), 2, 3 }; }
        public void Write(byte[] bytes) { Writes++; }
        public bool ConfiguredEquals(byte[] a, byte[] b) => a.SequenceEqual(b);
        public string Boundary => "Synthetic native double, no host proof";
    }
}
