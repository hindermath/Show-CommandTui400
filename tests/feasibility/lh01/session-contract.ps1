#Requires -Version 7.6
<#
.SYNOPSIS
DE: Synthetischer Produktsitzungsnachweis. EN: Synthetic product session proof.
.DESCRIPTION
DE: Läuft im aktuellen Host; separater Runspace ausschließlich für StopProcessing.
Nur künstliche Werte werden erfasst. Keine praktische Terminalabnahme.
EN: Uses the current host, with a separate test runspace only for StopProcessing.
Only synthetic values are recorded. This is not practical terminal acceptance.
.PARAMETER Scenario
DE: Automatisierter Prüfpfad. EN: Automated test scenario, never a product parameter.
.PARAMETER Module
DE: Gebautes Modulmanifest. EN: Built product module manifest.
.PARAMETER TestAssembly
DE: Bibliothek mit internen Testdoubles. EN: Friend test assembly with internal seams.
.EXAMPLE
pwsh -NoProfile -File ./session-contract.ps1 -Scenario Normal -Module ./ShowCommandTui400.psd1 -TestAssembly ./ShowCommandTui400.Tests.dll
#>
[CmdletBinding()]
param(
    [ValidateSet('Normal','Cancel','Repeat','Stop','HandledFailure','RestorationFailure','Redirect','HiddenCursor','InputRedirect','AggregateFailure')][string]$Scenario='Normal',
    [Parameter(Mandatory)][string]$Module,
    [Parameter(Mandatory)][string]$TestAssembly
)
Set-StrictMode -Version Latest
$ErrorActionPreference='Stop'
Import-Module (Resolve-Path -LiteralPath $Module).Path
Add-Type -Path (Resolve-Path -LiteralPath $TestAssembly).Path
[ShowCommandTui400.Tests.ProductHarness]::Configure($(if($Scenario -in @('HandledFailure','RestorationFailure','AggregateFailure')){$Scenario}else{'Real'}))
Set-Variable -Name Lh01Synthetic -Scope Global -Value 710
function global:Get-Lh01Synthetic {710}
function Get-Snapshot {
    [ordered]@{Pid=$PID;Runspace=[runspace]::DefaultRunspace.InstanceId.ToString();Location='synthetic-working-directory';Synthetic=(Get-Variable -Name Lh01Synthetic -Scope Global -ValueOnly);Preference=$ErrorActionPreference;FunctionResult=(Get-Lh01Synthetic)}
}
$actualLocationBefore=(Get-Location).ProviderPath
$modulesBefore=@(Get-Module|ForEach-Object Name|Sort-Object) -join ";"
$before=Get-Snapshot
$scopes=[System.Collections.Generic.List[object]]::new()
$failure=$null
$state=$null
$readback=$null
try {
    if($Scenario -eq 'Stop') {
        $initial=[System.Management.Automation.Runspaces.InitialSessionState]::CreateDefault()
        $initial.ImportPSModule(@((Resolve-Path $Module).Path))
        $testRunspace=[runspacefactory]::CreateRunspace($Host,$initial)
        $pipeline=[powershell]::Create()
        try {
            $testRunspace.Open();$pipeline.Runspace=$testRunspace
            [void]$pipeline.AddCommand('Show-CommandTui400')
            $pending=$pipeline.BeginInvoke()
            if(-not [ShowCommandTui400.Tests.ProductHarness]::Ready.Wait(10000)){throw 'Product readiness timeout'}
            # The test seam signals at UI entry; StopProcessing must handle a stop before Init finishes too.
            $pipeline.Stop()
            try {[void]$pipeline.EndInvoke($pending)} catch {if($_.Exception.ToString() -notmatch 'PipelineStopped'){throw}}
            $state=$pipeline.InvocationStateInfo.State.ToString()
            if([ShowCommandTui400.Tests.ProductHarness]::StopCalls -lt 1 -or $state -ne 'Stopped'){throw 'StopProcessing not observed'}
        } finally {$pipeline.Dispose();$testRunspace.Dispose()}
    } elseif($Scenario -in @('Normal','Repeat','HiddenCursor')) {
        if($Scenario -eq 'HiddenCursor'){[Console]::Out.Write("`e[?25l");[Console]::Out.Flush()}
        Show-CommandTui400
        $scopes.Add(([ShowCommandTui400.Tests.ProductHarness]::ObservedContext | ConvertFrom-Json))
        if($Scenario -eq 'Repeat') {
            function Invoke-FunctionProof {$Lh01Synthetic=711;Show-CommandTui400}
            Invoke-FunctionProof
            $scopes.Add(([ShowCommandTui400.Tests.ProductHarness]::ObservedContext | ConvertFrom-Json))
            $syntheticModule=New-Module -Name Lh01SyntheticModule -ScriptBlock {
                $script:Lh01Synthetic=712
                function Invoke-ModuleProof {Show-CommandTui400}
                Export-ModuleMember -Function Invoke-ModuleProof
            }
            try {Import-Module $syntheticModule;Invoke-ModuleProof;$scopes.Add(([ShowCommandTui400.Tests.ProductHarness]::ObservedContext | ConvertFrom-Json))}
            finally {Remove-Module $syntheticModule}
        }
    } else {Show-CommandTui400}
} catch {$failure=[ordered]@{ErrorId=$_.FullyQualifiedErrorId;Message=$_.Exception.Message}}
$moduleSetUnchanged=$modulesBefore -ceq (@(Get-Module|ForEach-Object Name|Sort-Object) -join ";")
$native=[ShowCommandTui400.Tests.ProductHarness]::LastRestore
$after=Get-Snapshot
$locationUnchanged=$actualLocationBefore -ceq (Get-Location).ProviderPath
$unchanged=$locationUnchanged -and (($before|ConvertTo-Json -Compress) -ceq ($after|ConvertTo-Json -Compress))
if($Scenario -notin @('Redirect','InputRedirect')){Write-Host 'LH01_SHELL_INPUT_READY';$readback=Read-Host 'Synthetic return check'}
[ShowCommandTui400.Tests.ProductHarness]::Reset()
$record=[ordered]@{Scenario=$Scenario;Before=$before;After=$after;ContextUnchanged=$unchanged;LocationUnchanged=$locationUnchanged;ModuleSetUnchanged=$moduleSetUnchanged;LeaseAcquisitions=[ShowCommandTui400.Tests.ProductHarness]::LeaseAcquisitions;UiCreations=[ShowCommandTui400.Tests.ProductHarness]::UiCreations;ScopeObservations=@($scopes);NativeRestore=$native;StopCalls=[ShowCommandTui400.Tests.ProductHarness]::StopCalls;PipelineState=$state;IsolatedTestRunspace=($Scenario -eq 'Stop');ShellReadback=$readback;Failure=$failure}
Write-Host 'LH01_RESULT'
$record|ConvertTo-Json -Depth 12 -Compress
Write-Host 'LH01_RESTORE_READY'
Start-Sleep -Milliseconds 500
if(-not $unchanged){exit 1}
if($Scenario -in @('Redirect','InputRedirect')){if([ShowCommandTui400.Tests.ProductHarness]::LeaseAcquisitions -ne 0 -or [ShowCommandTui400.Tests.ProductHarness]::UiCreations -ne 0 -or -not $moduleSetUnchanged){exit 1};if($failure -and $failure.ErrorId -like 'CapabilityRejected*'){exit 0};exit 1}
if($readback -cne 'LH01_ACK'){exit 1}
if($Scenario -in @('HandledFailure','AggregateFailure')){if($failure -and $failure.ErrorId -like 'HandledFailure*'){exit 0};exit 1}
if($Scenario -eq 'RestorationFailure'){if($failure -and $failure.ErrorId -like 'RestorationFailure*' -and $failure.Message -match 'synthetic primary failure' -and $failure.Message -match 'synthetic restoration failure'){exit 1};exit 2}
if($failure){exit 1}
if($null -eq $native -or -not $native.ConfiguredEqual){exit 1}
exit 0
