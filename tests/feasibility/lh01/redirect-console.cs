// DE: Nur Testtransport; echte einzelne Standardstream-Umleitung unter ConPTY.
// EN: Test transport only; actual one-axis standard-stream redirection in ConPTY.
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

public static class Lh01RedirectConsole
{
    [StructLayout(LayoutKind.Sequential)] struct Security { public int Size; public IntPtr Descriptor; [MarshalAs(UnmanagedType.Bool)] public bool Inherit; }
    [StructLayout(LayoutKind.Sequential, CharSet=CharSet.Unicode)] struct Startup
    {
        public int Size; public string Reserved, Desktop, Title;
        public uint X,Y,Width,Height,CharsX,CharsY,Fill,Flags;
        public ushort Show,ReservedSize; public IntPtr ReservedBytes,Input,Output,Error;
    }
    [StructLayout(LayoutKind.Sequential)] struct ProcessInfo { public IntPtr Process,Thread; public uint Pid,Tid; }
    [DllImport("kernel32.dll",SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)] static extern bool CreatePipe(out IntPtr read,out IntPtr write,ref Security security,uint size);
    [DllImport("kernel32.dll",SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)] static extern bool SetHandleInformation(IntPtr handle,uint mask,uint flags);
    [DllImport("kernel32.dll",CharSet=CharSet.Unicode,SetLastError=true)] static extern IntPtr CreateFileW(string name,uint access,uint share,ref Security security,uint creation,uint flags,IntPtr template);
    [DllImport("kernel32.dll",CharSet=CharSet.Unicode,SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)] static extern bool CreateProcessW(string application,StringBuilder command,IntPtr ps,IntPtr ts,bool inherit,uint flags,IntPtr env,string cwd,ref Startup startup,out ProcessInfo process);
    [DllImport("kernel32.dll",SetLastError=true)] static extern uint WaitForSingleObject(IntPtr handle,uint timeout);
    [DllImport("kernel32.dll",SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)] static extern bool GetExitCodeProcess(IntPtr handle,out uint code);
    [DllImport("kernel32.dll",SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)] static extern bool TerminateProcess(IntPtr handle,uint code);
    [DllImport("kernel32.dll")] [return:MarshalAs(UnmanagedType.Bool)] static extern bool CloseHandle(IntPtr handle);
    public static string Output { get; private set; }
    static void Check(bool value) { if(!value) throw new Win32Exception(Marshal.GetLastWin32Error()); }
    static string Quote(string value)
    {
        var b=new StringBuilder("\""); int slashes=0;
        foreach(char ch in value) {
            if(ch=='\\') { slashes++; continue; }
            b.Append('\\',ch=='"'?slashes*2+1:slashes); b.Append(ch); slashes=0;
        }
        b.Append('\\',slashes*2); return b.Append('"').ToString();
    }
    public static int Run(string executable,string[] arguments,string mode)
    {
        if(!OperatingSystem.IsWindows()) throw new PlatformNotSupportedException();
        bool redirectInput=mode=="InputRedirect", redirectOutput=mode=="Redirect";
        var security=new Security { Size=Marshal.SizeOf<Security>(), Inherit=true };
        IntPtr cin=IntPtr.Zero,cout=IntPtr.Zero,read=IntPtr.Zero,write=IntPtr.Zero;
        ProcessInfo process=default; Task<string> pending=null; StreamReader reader=null;
        try {
            cin=CreateFileW("CONIN$",0xC0000000u,3,ref security,3,0,IntPtr.Zero);
            cout=CreateFileW("CONOUT$",0xC0000000u,3,ref security,3,0,IntPtr.Zero);
            Check(cin!=new IntPtr(-1) && cout!=new IntPtr(-1));
            if(redirectInput || redirectOutput) {
                Check(CreatePipe(out read,out write,ref security,0));
                Check(SetHandleInformation(redirectInput?write:read,1,0));
            }
            var startup=new Startup { Size=Marshal.SizeOf<Startup>(), Flags=0x100,
                Input=redirectInput?read:cin, Output=redirectOutput?write:cout, Error=cout };
            var command=new StringBuilder(Quote(executable));
            foreach(var arg in arguments) command.Append(' ').Append(Quote(arg));
            // Explicit Win32 handles avoid cached Console streams in the parent
            // PowerShell host. Only the requested child stream receives a pipe.
            Check(CreateProcessW(executable,command,IntPtr.Zero,IntPtr.Zero,true,0,IntPtr.Zero,null,ref startup,out process));
            if(redirectInput) { CloseHandle(write);write=IntPtr.Zero; }
            else if(redirectOutput) {
                CloseHandle(write);write=IntPtr.Zero;
                reader=new StreamReader(new FileStream(new SafeFileHandle(read,true),FileAccess.Read),Encoding.UTF8);
                read=IntPtr.Zero;pending=reader.ReadToEndAsync();
            }
            if(WaitForSingleObject(process.Process,30000)!=0) {
                TerminateProcess(process.Process,2);WaitForSingleObject(process.Process,3000);
                throw new TimeoutException("Redirect child timeout; stop further cases");
            }
            Check(GetExitCodeProcess(process.Process,out var code));
            Output=pending==null?"":pending.GetAwaiter().GetResult();
            if(Output.Length>0) {
                using var forward=new StreamWriter(new FileStream(new SafeFileHandle(cout,false),FileAccess.Write),new UTF8Encoding(false));
                forward.Write(Output);forward.Flush();
            }
            return checked((int)code);
        } finally {
            reader?.Dispose();
            foreach(var handle in new[]{process.Thread,process.Process,read,write,cin,cout})
                if(handle!=IntPtr.Zero && handle!=new IntPtr(-1)) CloseHandle(handle);
        }
    }
}
