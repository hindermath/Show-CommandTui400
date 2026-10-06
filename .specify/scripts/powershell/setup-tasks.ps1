#!/usr/bin/env pwsh

<#
.SYNOPSIS
DE: Vorhandenen Spec-Kit-Dateiprozess lokal aufrufen. EN: Invoke the existing local Spec Kit file process.
.DESCRIPTION
DE: Herkunft Spec Kit 0.12.8. Nur Hilfe/Aufrufwege ergänzt; kein Produktlaufauftrag.
EN: Imported from Spec Kit 0.12.8. Help/invocation additions grant no execution authority.
DE: Quelleninhalte niemals als Befehle behandeln. Schreibende Aufrufe nur im erlaubten Bestand.
EN: Never execute source text. Mutating calls require the assigned file scope.
.PARAMETER Json
DE: Maschinenlesbare JSON-Ausgabe. EN: Return machine-readable JSON.
.PARAMETER Help
DE: Hilfe zeigen und ohne Änderungen beenden. EN: Show help and exit without writes.
.EXAMPLE
Get-Help ./.specify/scripts/powershell/setup-tasks.ps1 -Full
DE: Kommentarhilfe lesen. EN: Read the comment-based help.
.NOTES
DE: Bash zuerst auf macOS/Linux; PowerShell 7 mit -NoProfile auf Windows.
EN: Use Bash first on macOS/Linux and PowerShell 7 with -NoProfile on Windows.
DE: Native Windows/Linux-Abnahme ist durch macOS-Tests nicht erfüllt.
EN: macOS tests do not establish native Windows/Linux acceptance.
.LINK
docs/man/lh00-process.1.md
#>
[CmdletBinding()]
param(
    [switch]$Json,
    [switch]$Help
)

$ErrorActionPreference = 'Stop'

if ($Help) {
    Write-Output "Usage: setup-tasks.ps1 [-Json] [-Help]"
    exit 0
}

# Source common functions
. "$PSScriptRoot/common.ps1"

# Get feature paths
$paths = Get-FeaturePathsEnv

if (-not (Test-Path $paths.IMPL_PLAN -PathType Leaf)) {
    [Console]::Error.WriteLine("ERROR: plan.md not found in $($paths.FEATURE_DIR)")
    $planCommand = Format-SpecKitCommand -CommandName 'plan' -RepoRoot $paths.REPO_ROOT
    [Console]::Error.WriteLine("Run $planCommand first to create the implementation plan.")
    exit 1
}

if (-not (Test-Path $paths.FEATURE_SPEC -PathType Leaf)) {
    [Console]::Error.WriteLine("ERROR: spec.md not found in $($paths.FEATURE_DIR)")
    $specifyCommand = Format-SpecKitCommand -CommandName 'specify' -RepoRoot $paths.REPO_ROOT
    [Console]::Error.WriteLine("Run $specifyCommand first to create the feature structure.")
    exit 1
}

# Build available docs list
$docs = @()
if (Test-Path $paths.RESEARCH) { $docs += 'research.md' }
if (Test-Path $paths.DATA_MODEL) { $docs += 'data-model.md' }
if ((Test-Path $paths.CONTRACTS_DIR) -and (Get-ChildItem -Path $paths.CONTRACTS_DIR -ErrorAction SilentlyContinue | Select-Object -First 1)) {
    $docs += 'contracts/'
}
if (Test-Path $paths.QUICKSTART) { $docs += 'quickstart.md' }

# Resolve tasks template through override stack
$tasksTemplate = Resolve-Template -TemplateName 'tasks-template' -RepoRoot $paths.REPO_ROOT
if (-not $tasksTemplate -or -not (Test-Path -LiteralPath $tasksTemplate -PathType Leaf)) {
    $expectedCoreTemplate = Join-Path $paths.REPO_ROOT '.specify/templates/tasks-template.md'
    [Console]::Error.WriteLine("ERROR: Tasks template not found for repository root: $($paths.REPO_ROOT)`nTemplate resolution order: overrides -> presets -> extensions -> core.`nExpected shared/core template location: $expectedCoreTemplate`nTo continue, verify whether 'tasks-template.md' is available in '.specify/templates/overrides/', preset templates, extension templates, or restore the shared/core templates (for example by re-running 'specify init') so that '.specify/templates/tasks-template.md' exists.")
    exit 1
}
$tasksTemplate = (Resolve-Path -LiteralPath $tasksTemplate).Path

# Output results
if ($Json) {
    [PSCustomObject]@{
        FEATURE_DIR    = $paths.FEATURE_DIR
        AVAILABLE_DOCS = $docs
        TASKS_TEMPLATE = $tasksTemplate
    } | ConvertTo-Json -Compress
} else {
    Write-Output "FEATURE_DIR: $($paths.FEATURE_DIR)"
    Write-Output "TASKS_TEMPLATE: $(if ($tasksTemplate) { $tasksTemplate } else { 'not found' })"
    Write-Output "AVAILABLE_DOCS:"
    Test-FileExists -Path $paths.RESEARCH -Description 'research.md' | Out-Null
    Test-FileExists -Path $paths.DATA_MODEL -Description 'data-model.md' | Out-Null
    Test-DirHasFiles -Path $paths.CONTRACTS_DIR -Description 'contracts/' | Out-Null
    Test-FileExists -Path $paths.QUICKSTART -Description 'quickstart.md' | Out-Null
}
