#Requires -Version 7.6
<#
.SYNOPSIS
DE: Isolierter Build-/Negativvertragsnachweis. EN: Isolated build/negative contract proof.
.DESCRIPTION
DE: Baut gesperrte Abhängigkeiten ohne GUI-Start. Fremde Buildausgaben werden nicht
überschrieben. BuildRoot bleibt außerhalb des Quellbestands. Keine Abnahme.
EN: Builds locked dependencies without UI entry. Existing foreign outputs are
preserved. BuildRoot stays outside source. This does not grant acceptance.
.PARAMETER CaseId
DE: B01 oder N01–N07. EN: Build or negative contract case identifier.
.PARAMETER BuildRoot
DE: Isolierter Buildpfad. EN: Isolated build output root.
.EXAMPLE
pwsh -NoProfile -File ./tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1 -CaseId N01 -BuildRoot /tmp/lh01-build-new
#>
[CmdletBinding()]
param([Parameter(Mandatory)][ValidateSet('B01','N01','N02','N03','N04','N05','N06','N07')][string]$CaseId,[Parameter(Mandatory)][string]$BuildRoot)
Set-StrictMode -Version Latest
$ErrorActionPreference='Stop'
$root=(Resolve-Path (Join-Path $PSScriptRoot '../../..')).Path
$build=[IO.Path]::GetFullPath($BuildRoot)
if($build -eq $root -or $build.StartsWith($root+[IO.Path]::DirectorySeparatorChar,[StringComparison]::OrdinalIgnoreCase)){throw 'BuildRoot must stay outside source'}
$parent=$build
while($parent){if(Test-Path -LiteralPath $parent){$item=Get-Item -LiteralPath $parent -Force;if($item.LinkType -or ($item.Attributes -band [IO.FileAttributes]::ReparsePoint)){throw 'Symlink/reparse build parent'}};$next=Split-Path -Parent $parent;if($next -eq $parent){break};$parent=$next}
$marker=Join-Path $build 'lh01-build-owner.json'
$head=(& git -C $root rev-parse HEAD).Trim()
if(Test-Path -LiteralPath $build){
    if(-not(Test-Path -LiteralPath $marker)){throw 'Foreign build output root'}
    $owned=Get-Content -LiteralPath $marker -Raw|ConvertFrom-Json
    if($owned.productCommit -cne $head){throw 'Build root belongs to another revision'}
}else{[void](New-Item -ItemType Directory -Path $build);@{productCommit=$head}|ConvertTo-Json|Set-Content -LiteralPath $marker}
Push-Location $root
try {
    & dotnet build tests/ShowCommandTui400.Tests/ShowCommandTui400.Tests.csproj -p:RestoreLockedMode=true "-p:RestoreConfigFile=$(Join-Path $root 'src/ShowCommandTui400/NuGet.Config')" "-p:LH01PowerShellHome=$PSHOME" "-p:LH01BuildRoot=$build" | Out-Host
    if($LASTEXITCODE -ne 0){throw 'Locked build failed'}
    Import-Module (Join-Path $build 'ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1')
    Add-Type -Path (Join-Path $build 'ShowCommandTui400.Tests/bin/net10.0/ShowCommandTui400.Tests.dll')
    $checks=@([ShowCommandTui400.Tests.EntryBoundaryTests]::Run())
    if($CaseId -eq 'B01'){$checks+=@([ShowCommandTui400.Tests.TerminalLifecycleTests]::Run())}
    if($CaseId -ne 'B01' -and $CaseId -notin $checks){throw 'Requested negative contract not observed'}
    $outcome=switch($CaseId){'B01'{'LockedBuildAndContractTestsPass'} 'N05'{'RejectedWithoutDomainEffect'} 'N06'{'RejectedBeforeInit'} 'N07'{'SafeDisplayWithoutControlInjection'} default{'RejectedWithoutStateChange'}}
    if(Test-Path (Join-Path $build 'ShowCommandTui400/bin/net10.0/System.Management.Automation.dll')){throw 'Host assembly copied unexpectedly'}
    @{caseId=$CaseId;result='Pass';outcome=$outcome;scope='model/native doubles only; no GUI or foreign-platform proof';checks=$checks;hostAssembliesRedistributed=(Test-Path (Join-Path $build 'ShowCommandTui400/bin/net10.0/System.Management.Automation.dll'))}|ConvertTo-Json -Depth 8 -Compress
}finally{Pop-Location}
