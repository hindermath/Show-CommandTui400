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
}finally{$process.Dispose()}
exit $code
