#!/usr/bin/env pwsh

# Consolidated prerequisite checking script (PowerShell)
#
# This script provides unified prerequisite checking for Spec-Driven Development workflow.
# It replaces the functionality previously spread across multiple scripts.
#
# Usage: ./check-prerequisites.ps1 [OPTIONS]
#
# OPTIONS:
#   -Json               Output in JSON format
#   -RequireTasks       Require tasks.md to exist (for implementation phase)
#   -IncludeTasks       Include tasks.md in AVAILABLE_DOCS list
#   -PathsOnly          Only output path variables (no validation)
#   -Help, -h           Show help message

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
.PARAMETER RequireTasks
DE: Vorhandene Aufgabenliste verlangen. EN: Require an existing task list.
.PARAMETER IncludeTasks
DE: Aufgabenliste in Ausgabe einschließen. EN: Include tasks in output.
.PARAMETER PathsOnly
DE: Pfade ausschließlich lesen. EN: Resolve paths read-only.
.PARAMETER Help
DE: Hilfe zeigen und ohne Änderungen beenden. EN: Show help and exit without writes.
.EXAMPLE
Get-Help ./.specify/scripts/powershell/check-prerequisites.ps1 -Full
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
    [switch]$RequireTasks,
    [switch]$IncludeTasks,
    [switch]$PathsOnly,
    [switch]$Help
)

$ErrorActionPreference = 'Stop'

# Show help if requested
if ($Help) {
    Write-Output @"
Usage: check-prerequisites.ps1 [OPTIONS]

Consolidated prerequisite checking for Spec-Driven Development workflow.

OPTIONS:
  -Json               Output in JSON format
  -RequireTasks       Require tasks.md to exist (for implementation phase)
  -IncludeTasks       Include tasks.md in AVAILABLE_DOCS list
  -PathsOnly          Only output path variables (no prerequisite validation)
  -Help, -h           Show this help message

EXAMPLES:
  # Check task prerequisites (plan.md required)
  .\check-prerequisites.ps1 -Json
  
  # Check implementation prerequisites (plan.md + tasks.md required)
  .\check-prerequisites.ps1 -Json -RequireTasks -IncludeTasks
  
  # Get feature paths only (no validation)
  .\check-prerequisites.ps1 -PathsOnly

"@
    exit 0
}

# Source common functions
. "$PSScriptRoot/common.ps1"

# Get feature paths.
# In -PathsOnly mode this is pure resolution, so pass -NoPersist to opt out of
# the feature.json write side effect (issue #3025).
if ($PathsOnly) {
    $paths = Get-FeaturePathsEnv -NoPersist
} else {
    $paths = Get-FeaturePathsEnv
}

# If paths-only mode, output paths and exit (no validation)
if ($PathsOnly) {
    if ($Json) {
        [PSCustomObject]@{
            REPO_ROOT    = $paths.REPO_ROOT
            BRANCH       = $paths.CURRENT_BRANCH
            FEATURE_DIR  = $paths.FEATURE_DIR
            FEATURE_SPEC = $paths.FEATURE_SPEC
            IMPL_PLAN    = $paths.IMPL_PLAN
            TASKS        = $paths.TASKS
        } | ConvertTo-Json -Compress
    } else {
        Write-Output "REPO_ROOT: $($paths.REPO_ROOT)"
        Write-Output "BRANCH: $($paths.CURRENT_BRANCH)"
        Write-Output "FEATURE_DIR: $($paths.FEATURE_DIR)"
        Write-Output "FEATURE_SPEC: $($paths.FEATURE_SPEC)"
        Write-Output "IMPL_PLAN: $($paths.IMPL_PLAN)"
        Write-Output "TASKS: $($paths.TASKS)"
    }
    exit 0
}

# Validate required directories and files
if (-not (Test-Path $paths.FEATURE_DIR -PathType Container)) {
    [Console]::Error.WriteLine("ERROR: Feature directory not found: $($paths.FEATURE_DIR)")
    $specifyCommand = Format-SpecKitCommand -CommandName 'specify' -RepoRoot $paths.REPO_ROOT
    [Console]::Error.WriteLine("Run $specifyCommand first to create the feature structure.")
    exit 1
}

if (-not (Test-Path $paths.IMPL_PLAN -PathType Leaf)) {
    [Console]::Error.WriteLine("ERROR: plan.md not found in $($paths.FEATURE_DIR)")
    $planCommand = Format-SpecKitCommand -CommandName 'plan' -RepoRoot $paths.REPO_ROOT
    [Console]::Error.WriteLine("Run $planCommand first to create the implementation plan.")
    exit 1
}

# Check for tasks.md if required
if ($RequireTasks -and -not (Test-Path $paths.TASKS -PathType Leaf)) {
    [Console]::Error.WriteLine("ERROR: tasks.md not found in $($paths.FEATURE_DIR)")
    $tasksCommand = Format-SpecKitCommand -CommandName 'tasks' -RepoRoot $paths.REPO_ROOT
    [Console]::Error.WriteLine("Run $tasksCommand first to create the task list.")
    exit 1
}

# Build list of available documents
$docs = @()

# Always check these optional docs
if (Test-Path $paths.RESEARCH) { $docs += 'research.md' }
if (Test-Path $paths.DATA_MODEL) { $docs += 'data-model.md' }

# Check contracts directory (only if it exists and has files)
if ((Test-Path $paths.CONTRACTS_DIR) -and (Get-ChildItem -Path $paths.CONTRACTS_DIR -ErrorAction SilentlyContinue | Select-Object -First 1)) { 
    $docs += 'contracts/' 
}

if (Test-Path $paths.QUICKSTART) { $docs += 'quickstart.md' }

# Include tasks.md if requested and it exists
if ($IncludeTasks -and (Test-Path $paths.TASKS)) { 
    $docs += 'tasks.md' 
}

# Output results
if ($Json) {
    # JSON output
    [PSCustomObject]@{ 
        FEATURE_DIR = $paths.FEATURE_DIR
        AVAILABLE_DOCS = $docs 
    } | ConvertTo-Json -Compress
} else {
    # Text output
    Write-Output "FEATURE_DIR:$($paths.FEATURE_DIR)"
    Write-Output "AVAILABLE_DOCS:"
    
    # Show status of each potential document
    Test-FileExists -Path $paths.RESEARCH -Description 'research.md' | Out-Null
    Test-FileExists -Path $paths.DATA_MODEL -Description 'data-model.md' | Out-Null
    Test-DirHasFiles -Path $paths.CONTRACTS_DIR -Description 'contracts/' | Out-Null
    Test-FileExists -Path $paths.QUICKSTART -Description 'quickstart.md' | Out-Null
    
    if ($IncludeTasks) {
        Test-FileExists -Path $paths.TASKS -Description 'tasks.md' | Out-Null
    }
}
