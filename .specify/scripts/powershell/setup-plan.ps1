#!/usr/bin/env pwsh
# Setup implementation plan for a feature

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
Get-Help ./.specify/scripts/powershell/setup-plan.ps1 -Full
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

# Show help if requested
if ($Help) {
    Write-Output "Usage: ./setup-plan.ps1 [-Json] [-Help]"
    Write-Output "  -Json     Output results in JSON format"
    Write-Output "  -Help     Show this help message"
    exit 0
}

# Load common functions
. "$PSScriptRoot/common.ps1"

# Get all paths and variables from common functions
$paths = Get-FeaturePathsEnv

# Ensure the feature directory exists
New-Item -ItemType Directory -Path $paths.FEATURE_DIR -Force | Out-Null

# Copy plan template if plan doesn't already exist
if (Test-Path $paths.IMPL_PLAN -PathType Leaf) {
    if ($Json) {
        [Console]::Error.WriteLine("Plan already exists at $($paths.IMPL_PLAN), skipping template copy")
    } else {
        Write-Output "Plan already exists at $($paths.IMPL_PLAN), skipping template copy"
    }
} else {
    $template = Resolve-Template -TemplateName 'plan-template' -RepoRoot $paths.REPO_ROOT
    if ($template -and (Test-Path $template)) {
        # Read the template content and write it to the implementation plan file with UTF-8 encoding without BOM
        $content = [System.IO.File]::ReadAllText($template)
        $utf8NoBom = New-Object System.Text.UTF8Encoding($false)
        [System.IO.File]::WriteAllText($paths.IMPL_PLAN, $content, $utf8NoBom)
        # Emit the copy status like the bash twin (setup-plan.sh); route to stderr
        # in -Json mode so stdout stays pure JSON, matching the sibling messages.
        if ($Json) {
            [Console]::Error.WriteLine("Copied plan template to $($paths.IMPL_PLAN)")
        } else {
            Write-Output "Copied plan template to $($paths.IMPL_PLAN)"
        }
    } else {
        # Match the bash twin's wording and stream routing (stderr in -Json so
        # stdout stays pure JSON, stdout otherwise), consistent with the sibling
        # "Copied plan template" message above.
        if ($Json) {
            [Console]::Error.WriteLine("Warning: Plan template not found")
        } else {
            Write-Output "Warning: Plan template not found"
        }
        # Create a basic plan file if template doesn't exist
        New-Item -ItemType File -Path $paths.IMPL_PLAN -Force | Out-Null
    }
}

# Output results
if ($Json) {
    $result = [PSCustomObject]@{ 
        FEATURE_SPEC = $paths.FEATURE_SPEC
        IMPL_PLAN = $paths.IMPL_PLAN
        SPECS_DIR = $paths.FEATURE_DIR
        BRANCH = $paths.CURRENT_BRANCH
    }
    $result | ConvertTo-Json -Compress
} else {
    Write-Output "FEATURE_SPEC: $($paths.FEATURE_SPEC)"
    Write-Output "IMPL_PLAN: $($paths.IMPL_PLAN)"
    Write-Output "SPECS_DIR: $($paths.FEATURE_DIR)"
    Write-Output "BRANCH: $($paths.CURRENT_BRANCH)"
}
