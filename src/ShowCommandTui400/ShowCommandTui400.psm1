# DE: Host-PowerShell bleibt gemeinsam; die Modulbibliotheken werden getrennt geladen.
# EN: Host PowerShell stays shared; module libraries load in a separate context.
Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'
if (-not ('Hindermath.ShowCommandTui400.Bootstrap.DependencyLoader' -as [type])) {
    Add-Type -Path (Join-Path $PSScriptRoot 'Bootstrap/DependencyLoader.cs')
}
$assembly = [Hindermath.ShowCommandTui400.Bootstrap.DependencyLoader]::LoadModule(
    (Join-Path $PSScriptRoot 'ShowCommandTui400.dll'))
Import-Module -Assembly $assembly -Scope Local
Export-ModuleMember -Cmdlet 'Show-CommandTui400'
