#Requires -Version 7
<#
.SYNOPSIS
    Prueft getrackte PowerShell-Dateien. / Analyzes tracked PowerShell files.

.DESCRIPTION
    Ermittelt repo-eigene PowerShell-Dateien mit git ls-files, importiert die
    in der Modul-Registry festgelegte PSScriptAnalyzer-Version und beendet den
    Lauf bei jedem Error- oder Warning-Befund mit Exitcode 1. Explizit in der
    Registry aufgefuehrte generierte Upstream-Pfade werden nicht analysiert.

    Discovers repository-owned PowerShell files through git ls-files, imports
    the PSScriptAnalyzer version pinned in the module registry, and exits with
    code 1 for every Error or Warning finding. Generated upstream paths listed
    explicitly in the registry are not analyzed.

.PARAMETER RepositoryRoot
    Repository-Wurzel. Standard ist das Elternverzeichnis von scripts/.
    Repository root. Defaults to the parent of scripts/.

.PARAMETER Registry
    Alternative Modul-Registry. / Alternative module registry.

.PARAMETER Settings
    Alternative PSScriptAnalyzer-Konfiguration. / Alternative analyzer settings.

.EXAMPLE
    pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
#>
[CmdletBinding()]
param(
    [string] $RepositoryRoot = '',
    [string] $Registry = '',
    [string] $Settings = ''
)

Set-StrictMode -Version Latest
$ErrorActionPreference = 'Stop'

$defaultRoot = Split-Path -Parent $PSScriptRoot
if (-not $RepositoryRoot) { $RepositoryRoot = $defaultRoot }
if (-not $Registry) { $Registry = Join-Path $defaultRoot 'scripts/config/powershell-modules-registry.json' }
if (-not $Settings) { $Settings = Join-Path $defaultRoot 'scripts/config/PSScriptAnalyzerSettings.psd1' }

$RepositoryRoot = (Resolve-Path -LiteralPath $RepositoryRoot).Path
foreach ($requiredPath in @($Registry, $Settings)) {
    if (-not (Test-Path -LiteralPath $requiredPath -PathType Leaf)) {
        throw "Erforderliche Datei fehlt / Required file missing: ${requiredPath}"
    }
}

$registryData = Get-Content -LiteralPath $Registry -Raw | ConvertFrom-Json
$analyzer = $registryData.modules |
    Where-Object { $_.name -eq 'PSScriptAnalyzer' } |
    Select-Object -First 1
if (-not $analyzer) {
    throw 'PSScriptAnalyzer fehlt in der Modul-Registry / is missing from the module registry.'
}

$requiredVersion = [version][string]$analyzer.version
Import-Module PSScriptAnalyzer -RequiredVersion $requiredVersion -Force -ErrorAction Stop

$excludedPathPrefixes = @(
    if ($registryData.PSObject.Properties.Name -contains 'analysis') {
        foreach ($prefix in @($registryData.analysis.excludedPathPrefixes)) {
            ([string]$prefix).Replace('\', '/').TrimStart('/')
        }
    }
)

function Test-HBExcludedAnalysisPath {
    param(
        [Parameter(Mandatory)]
        [string] $RelativePath,
        [string[]] $Prefixes = @()
    )

    $normalizedPath = $RelativePath.Replace('\', '/')
    foreach ($prefix in $Prefixes) {
        if ($prefix -and $normalizedPath.StartsWith($prefix, [StringComparison]::OrdinalIgnoreCase)) {
            return $true
        }
    }
    return $false
}

$trackedPowerShellFiles = @(
    & git -C $RepositoryRoot ls-files -- '*.ps1' '*.psm1' '*.psd1' |
        Where-Object { $_ }
)
if ($LASTEXITCODE -ne 0) {
    throw 'git ls-files fehlgeschlagen / failed.'
}
$relativeFiles = @(
    $trackedPowerShellFiles |
        Where-Object { -not (Test-HBExcludedAnalysisPath -RelativePath $_ -Prefixes $excludedPathPrefixes) }
)
$excludedFiles = @(
    $trackedPowerShellFiles |
        Where-Object { Test-HBExcludedAnalysisPath -RelativePath $_ -Prefixes $excludedPathPrefixes }
)

# DE: Nur die absichtliche globale Testvariable des isolierten LH-01-Proofs
# ausnehmen. Das historische Skript bleibt als hashgebundener Nachweis erhalten.
# EN: Exempt only the deliberate global probe variable in these two fixtures.
# Preserve archived evidence; every other global variable still fails analysis.
$lh01ProbePaths = @(
    'specs/002-lh01-tui-foundation/feasibility/src/probe-session.ps1',
    'specs/002-lh01-tui-foundation/feasibility/archive/20261008-before-fv01-fix/src/probe-session.ps1'
)
$acceptedProbeFindings = 0
$findings = @(
    foreach ($relativeFile in $relativeFiles) {
        $path = Join-Path $RepositoryRoot $relativeFile
        foreach ($finding in @(Invoke-ScriptAnalyzer -Path $path -Settings $Settings)) {
            if ($relativeFile.Replace('\', '/') -cin $lh01ProbePaths -and
                $finding.RuleName -ceq 'PSAvoidGlobalVars' -and
                $finding.Extent.Text -ceq '$global:Lh01Synthetic') {
                $acceptedProbeFindings++
                continue
            }
            $finding
        }
    }
)

Write-Host "PSScriptAnalyzer ${requiredVersion}: $($relativeFiles.Count) Dateien / files"
if ($acceptedProbeFindings -gt 0) {
    Write-Host "LH-01: $acceptedProbeFindings explizite synthetische Testvariablen-Befunde / explicit synthetic probe findings"
}
if ($excludedFiles.Count -gt 0) {
    Write-Host "Ausgenommen / excluded generated upstream files: $($excludedFiles.Count)"
}
if ($findings.Count -eq 0) {
    Write-Host 'OK: keine Error-/Warning-Befunde / no Error or Warning findings'
    exit 0
}

foreach ($finding in $findings | Sort-Object ScriptPath, Line, Column, RuleName) {
    $relativePath = [IO.Path]::GetRelativePath($RepositoryRoot, $finding.ScriptPath)
    Write-Host "${relativePath}:$($finding.Line):$($finding.Column): $($finding.Severity) $($finding.RuleName): $($finding.Message)"
}
Write-Error "$($findings.Count) PSScriptAnalyzer-Befund(e) / finding(s)." -ErrorAction Continue
exit 1
