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
# Use explicit native child handles rather than cached parent Console streams.
Add-Type -Path (Join-Path $PSScriptRoot 'redirect-console.cs')
$arguments=[string[]]@('-NoLogo','-NoProfile','-File',(Join-Path $PSScriptRoot 'session-contract.ps1'),'-Scenario',$Scenario,'-Module',$Module,'-TestAssembly',$TestAssembly,'-ObservationFile',$ObservationFile)
$code=[Lh01RedirectConsole]::Run((Join-Path $PSHOME 'pwsh.exe'),$arguments,($Scenario -eq 'InputRedirect'))
[Console]::Out.Write([Lh01RedirectConsole]::Output)
exit $code
