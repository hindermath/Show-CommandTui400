#Requires -Version 7.6
<#
.SYNOPSIS
DE: Einzelne Windows-Umleitung prüfen. EN: Probe one redirected Windows stream.
.DESCRIPTION
DE: Test-only Kindprozess im ConPTY-Host. Genau ein Standardstream wird umgeleitet;
der andere bleibt eine Konsole. Keine Produkt-Sitzungsintegration oder Installation.
EN: Test-only child of the ConPTY host. Exactly one stream is redirected while
its counterpart inherits the console. No product session integration or install.
.PARAMETER Scenario
DE: InputRedirect oder Redirect. EN: Input or output redirection case.
.PARAMETER Module
DE: Gebautes Produktmanifest. EN: Built product manifest.
.PARAMETER TestAssembly
DE: Interne Testbibliothek. EN: Friend test assembly.
.PARAMETER ObservationFile
DE: Neue externe Ergebnisdatei. EN: New external result file.
.EXAMPLE
./redirect-session.ps1 -Scenario InputRedirect -Module ./module.psd1 -TestAssembly ./tests.dll -ObservationFile ./new.json
#>
[CmdletBinding()]
param([Parameter(Mandatory)][ValidateSet('InputRedirect','Redirect')][string]$Scenario,
    [Parameter(Mandatory)][string]$Module,[Parameter(Mandatory)][string]$TestAssembly,
    [Parameter(Mandatory)][string]$ObservationFile)
Set-StrictMode -Version Latest
$ErrorActionPreference='Stop'
if(-not $IsWindows){throw 'Native Windows ConPTY host required'}
# ProcessStartInfo duplicates the parent's standard handles. Reopen explicit
# console handles before starting the one-axis redirect child: a caller's
# captured PowerShell pipeline is not an inherited terminal handle.
Add-Type -TypeDefinition @'
using System;
using System.Runtime.InteropServices;
public static class Lh01RedirectConsole {
    [DllImport("kernel32.dll")] public static extern IntPtr GetStdHandle(int id);
    [DllImport("kernel32.dll", SetLastError=true)] [return:MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetStdHandle(int id, IntPtr handle);
    [DllImport("kernel32.dll", CharSet=CharSet.Unicode, SetLastError=true)]
    public static extern IntPtr CreateFileW(string name, uint access, uint share, IntPtr security, uint creation, uint flags, IntPtr template);
    [DllImport("kernel32.dll")] [return:MarshalAs(UnmanagedType.Bool)]
    public static extern bool CloseHandle(IntPtr handle);
}
'@
$originalInput=[Lh01RedirectConsole]::GetStdHandle(-10)
$originalOutput=[Lh01RedirectConsole]::GetStdHandle(-11)
$consoleInput=[Lh01RedirectConsole]::CreateFileW('CONIN$',[uint32]3221225472,3,[IntPtr]::Zero,3,0,[IntPtr]::Zero)
$consoleOutput=[Lh01RedirectConsole]::CreateFileW('CONOUT$',[uint32]3221225472,3,[IntPtr]::Zero,3,0,[IntPtr]::Zero)
if($consoleInput -eq [IntPtr]::new(-1) -or $consoleOutput -eq [IntPtr]::new(-1)){throw 'ConPTY console handles unavailable'}
if(-not [Lh01RedirectConsole]::SetStdHandle(-10,$consoleInput) -or -not [Lh01RedirectConsole]::SetStdHandle(-11,$consoleOutput)){throw 'Unable to bind parent console handles'}
$info=[Diagnostics.ProcessStartInfo]::new()
$info.FileName=Join-Path $PSHOME 'pwsh.exe'
$info.UseShellExecute=$false
$info.RedirectStandardInput=$Scenario -eq 'InputRedirect'
$info.RedirectStandardOutput=$Scenario -eq 'Redirect'
foreach($argument in @('-NoLogo','-NoProfile','-File',(Join-Path $PSScriptRoot 'session-contract.ps1'),'-Scenario',$Scenario,'-Module',$Module,'-TestAssembly',$TestAssembly,'-ObservationFile',$ObservationFile)){$info.ArgumentList.Add($argument)}
$process=[Diagnostics.Process]::new();$process.StartInfo=$info
try{
    [void]$process.Start()
    if($info.RedirectStandardInput){$process.StandardInput.Close()}
    $stdout=if($info.RedirectStandardOutput){$process.StandardOutput.ReadToEndAsync()}else{$null}
    if(-not $process.WaitForExit(30000)){$process.Kill($true);$process.WaitForExit();throw 'Redirect child timeout'}
    if($stdout){[Console]::Out.Write($stdout.GetAwaiter().GetResult())}
    $code=$process.ExitCode
}finally{
    $process.Dispose()
    [void][Lh01RedirectConsole]::SetStdHandle(-10,$originalInput)
    [void][Lh01RedirectConsole]::SetStdHandle(-11,$originalOutput)
    [void][Lh01RedirectConsole]::CloseHandle($consoleInput)
    [void][Lh01RedirectConsole]::CloseHandle($consoleOutput)
}
exit $code
