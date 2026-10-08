<#
.SYNOPSIS
DE: Isolierter synthetischer LH-01-Sitzungsnachweis, kein Produktlauf.
EN: Isolated synthetic LH-01 session proof, not a product run.
#>
[CmdletBinding()]
param([Parameter(Mandatory)][string]$Assembly, [ValidateSet('Scope','Ui','Control')][string]$Mode='Scope', [switch]$RestoreSnapshotWindow)
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
    } elseif($Mode -eq 'Ui') {
        Write-Host 'LH01_BEGIN_UI'
        $results+=@(Test-Lh01Fixture -Mode Ui | ConvertFrom-Json)
        $results+=@(Test-Lh01Fixture -Mode Scope | ConvertFrom-Json)
    } else {
        Write-Host 'LH01_CONTROL_NO_GUI'
        $results+=@(Test-Lh01Fixture -Mode Scope | ConvertFrom-Json)
    }
} catch {$failure=[ordered]@{ErrorId=$_.FullyQualifiedErrorId;Message=$_.Exception.Message}}
$terminalAfter=$null
if($Mode -ne 'Scope'){$terminalAfter=(& /bin/sh -c 'stty -g </dev/tty')}
$after=Get-Snapshot
$same=($before | ConvertTo-Json -Compress) -ceq ($after | ConvertTo-Json -Compress)
Write-Host 'LH01_RESULT'
[ordered]@{Mode=$Mode;TerminalBefore=$terminalBefore;TerminalAfter=$terminalAfter;TerminalRestored=$(if($Mode -ne 'Scope'){$terminalBefore -ceq $terminalAfter}else{$null});Before=$before;After=$after;ContextUnchanged=$same;Results=$results;Failure=$failure} | ConvertTo-Json -Depth 12 -Compress
if($RestoreSnapshotWindow){Write-Host 'LH01_RESTORE_READY'; Start-Sleep -Milliseconds 500}
if(-not $same){exit 2}
if($failure){exit 3}

exit 0
