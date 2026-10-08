<#
.SYNOPSIS
DE: Isolierter synthetischer LH-01-Sitzungsnachweis, kein Produktlauf.
EN: Isolated synthetic LH-01 session proof, not a product run.
#>
[CmdletBinding()]
param([Parameter(Mandatory)][string]$Assembly, [ValidateSet('Scope','Ui','Control','Stop','Redirect')][string]$Mode='Scope', [switch]$RestoreSnapshotWindow, [string]$HelpKey="F1", [switch]$Repeat, [switch]$InvalidContext)
Set-StrictMode -Version Latest
$ErrorActionPreference='Stop'
Import-Module $Assembly -ErrorAction Stop
$global:Lh01Synthetic=710
function global:Get-Lh01Synthetic {710}
function Get-Snapshot {
    [ordered]@{Pid=$PID;Runspace=[runspace]::DefaultRunspace.InstanceId.ToString();Location=(Get-Location).Path;Synthetic=$global:Lh01Synthetic;Preference=$ErrorActionPreference;FunctionResult=(Get-Lh01Synthetic)}
}
$terminalBefore=$null
if($Mode -ne 'Scope'){$terminalBefore=(& /bin/sh -c 'stty -g </dev/tty')}
$before=Get-Snapshot
$results=@()
$failure=$null
try {
    if($Mode -eq 'Scope') {
        $results+=@(Test-Lh01Fixture -Mode Contract | ConvertFrom-Json)
        $results+=@(Test-Lh01Fixture -Mode Scope | ConvertFrom-Json)
        function Invoke-FunctionProbe {$Lh01Synthetic=711; Test-Lh01Fixture -Mode Scope}
        $results+=@(Invoke-FunctionProbe | ConvertFrom-Json)
        $m=New-Module -Name Lh01SyntheticModule -ScriptBlock {
            $script:Lh01Synthetic=712
            function Invoke-ModuleProbe {Test-Lh01Fixture -Mode Scope}
            Export-ModuleMember -Function Invoke-ModuleProbe
        }
        Import-Module $m
        $results+=@(Invoke-ModuleProbe | ConvertFrom-Json)
        try {Test-Lh01Fixture -Mode Ui; throw 'Expected noninteractive rejection'} catch {
            if($_.FullyQualifiedErrorId -notlike 'CapabilityRejected*'){throw}
            $results+=@([ordered]@{Case='RedirectedUi';ErrorId=$_.FullyQualifiedErrorId})
        }
        Remove-Module $m
    } elseif($Mode -in @('Ui','Redirect')) {
        Write-Host 'LH01_BEGIN_UI'
        $results+=@(Test-Lh01Fixture -Mode Ui -HelpKey $HelpKey -InvalidContext:$InvalidContext | ConvertFrom-Json)
        if($Repeat){$results+=@(Test-Lh01Fixture -Mode Ui -HelpKey $HelpKey | ConvertFrom-Json)}
        $results+=@(Test-Lh01Fixture -Mode Scope | ConvertFrom-Json)
    } elseif($Mode -eq 'Stop') {
        $initial=[System.Management.Automation.Runspaces.InitialSessionState]::CreateDefault()
        $initial.ImportPSModule(@($Assembly))
        $stopRunspace=[runspacefactory]::CreateRunspace($Host,$initial)
        $stopPipeline=[powershell]::Create()
        try {
            $stopRunspace.Open(); $stopPipeline.Runspace=$stopRunspace
            [void]$stopPipeline.AddCommand('Test-Lh01Fixture').AddParameter('Mode','Ui')
            [Lh01Feasibility.Fixture]::StopCount=0
            [Lh01Feasibility.Fixture]::UiReady.Reset()
            $pending=$stopPipeline.BeginInvoke()
            if(-not [Lh01Feasibility.Fixture]::UiReady.Wait(10000)){throw 'UI readiness timeout'}
            $stopPipeline.Stop()
            try {[void]$stopPipeline.EndInvoke($pending)} catch {
                if($_.Exception.ToString() -notmatch 'PipelineStopped'){throw}
            }
            $results+=@([ordered]@{Case='StopProcessing';Calls=[Lh01Feasibility.Fixture]::StopCount;State=$stopPipeline.InvocationStateInfo.State.ToString();IsolatedTestRunspace=$stopRunspace.InstanceId.ToString()})
        } finally {$stopPipeline.Dispose();$stopRunspace.Dispose()}
    } else {
        Write-Host 'LH01_CONTROL_NO_GUI'
        $results+=@(Test-Lh01Fixture -Mode Scope | ConvertFrom-Json)
    }
} catch {$failure=[ordered]@{ErrorId=$_.FullyQualifiedErrorId;Message=$_.Exception.Message}}
$terminalImmediate=$null
$shellReadback=$null
if($Mode -ne 'Scope'){
    $terminalImmediate=(& /bin/sh -c 'stty -g </dev/tty')
    if($Mode -ne 'Redirect'){Write-Host 'LH01_SHELL_INPUT_READY'; $shellReadback=Read-Host 'Synthetic return check'}
}
$terminalAfter=$null
if($Mode -ne 'Scope'){$terminalAfter=(& /bin/sh -c 'stty -g </dev/tty')}
function Normalize-TerminalModes([string]$snapshot) {
    if(-not $snapshot){return $null}
    $m=[regex]::Match($snapshot,'lflag=([0-9a-f]+)')
    if(-not $m.Success){throw 'Unexpected stty format'}
    $flags=[Convert]::ToUInt64($m.Groups[1].Value,16)
    $normalized=($flags -band ([uint64]::MaxValue -bxor [uint64]536870912)).ToString('x')
    [regex]::Replace($snapshot,'lflag=[0-9a-f]+',"lflag=$normalized")
}
$configuredRestored=$null
if($Mode -ne 'Scope'){$configuredRestored=(Normalize-TerminalModes $terminalBefore) -ceq (Normalize-TerminalModes $terminalAfter)}
$after=Get-Snapshot
$same=($before | ConvertTo-Json -Compress) -ceq ($after | ConvertTo-Json -Compress)
Write-Host 'LH01_RESULT'
[ordered]@{Mode=$Mode;ConfiguredTerminalModesRestored=$configuredRestored;NativeRestore=[Lh01Feasibility.Fixture]::LastTerminalRestore;TerminalImmediate=$terminalImmediate;ShellReadback=$shellReadback;TerminalBefore=$terminalBefore;TerminalAfter=$terminalAfter;TerminalRestored=$(if($Mode -ne 'Scope'){$terminalBefore -ceq $terminalAfter}else{$null});Before=$before;After=$after;ContextUnchanged=$same;Results=$results;Failure=$failure} | ConvertTo-Json -Depth 12 -Compress
if($RestoreSnapshotWindow){Write-Host 'LH01_RESTORE_READY'; Start-Sleep -Milliseconds 500}
if(-not $same){exit 2}
if($failure){exit 3}

exit 0
