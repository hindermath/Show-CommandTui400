#Requires -Version 7.6
<#
.SYNOPSIS
DE: Gebundene LH-01-Plattformprüfung. EN: Bound LH-01 platform proof.
.DESCRIPTION
DE: Prüft lokale Freigabe, Schema, Commit, Hashes und Zielhost. CheckOnly schreibt
nichts. Nicht ausführbare oder unvollständige Pläne liefern Blocked (Exit2).
Nur freigegebene Argumentarrays werden ohne Shellauswertung ausgeführt.
EN: Verifies approval, schema, revision, hashes and target. CheckOnly writes
nothing. Missing prerequisites return Blocked (exit2). Executes argument arrays
without shell evaluation. No installation, repair, publishing or acceptance.
.PARAMETER Plan
DE: Expliziter lokaler Prüfplan. EN: Explicit local test manifest.
.PARAMETER ExpectedPlanSha256
DE: SHA-256 aus dem ausdrücklichen Prüfauftrag. EN: SHA-256 pinned by the target execution order.
.PARAMETER Target
DE: macb, windows oder ubuntu-wsl2. EN: Explicit approved target identifier.
.PARAMETER OutputDirectory
DE: Neue isolierte Ausgabewurzel, niemals bestehende Läufe ersetzen.
EN: New isolated output root; existing evidence is never replaced.
.PARAMETER CheckOnly
DE: Nur Voraussetzungen prüfen. EN: Inspect prerequisites without running tests.
.EXAMPLE
pwsh -NoProfile -File ./tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1 -Plan ./docs/validation/lh01/platform-handoff.json -Target macb -OutputDirectory /tmp/lh01-proof-new -CheckOnly
#>
[CmdletBinding()]
param([Parameter(Mandatory)][string]$Plan,[string]$ExpectedPlanSha256,
    [Parameter(Mandatory)][ValidateSet('macb','windows','ubuntu-wsl2')][string]$Target,
    [Parameter(Mandatory)][string]$OutputDirectory,[switch]$CheckOnly)
Set-StrictMode -Version Latest
$ErrorActionPreference='Stop'
$root=(Resolve-Path (Join-Path $PSScriptRoot '../../..')).Path
$blockers=[System.Collections.Generic.List[string]]::new()
function Get-Sha([string]$Path){(Get-FileHash -LiteralPath $Path -Algorithm SHA256).Hash.ToLowerInvariant()}
function Resolve-BoundPath([string]$Relative) {
    if([string]::IsNullOrWhiteSpace($Relative) -or [IO.Path]::IsPathRooted($Relative) -or $Relative -match '(^|[/\\])\.\.([/\\]|$)' -or $Relative.Contains('\')){throw 'Invalid checkout-relative path'}
    $full=[IO.Path]::GetFullPath((Join-Path $root $Relative))
    if($full -ne $root -and -not $full.StartsWith($root+[IO.Path]::DirectorySeparatorChar,[StringComparison]::Ordinal)){throw 'Path escapes checkout'}
    $current=$root
    foreach($part in $Relative.Split('/')) {
        if($part -eq '.' -or $part -eq ''){continue}
        $current=Join-Path $current $part
        if(Test-Path -LiteralPath $current){$item=Get-Item -LiteralPath $current -Force;if($item.LinkType){throw 'Symlink in bound path'}}
    }
    if(-not(Test-Path -LiteralPath $full)){throw 'Bound file/directory missing'}
    return $full
}
try {
    $planPath=(Resolve-Path -LiteralPath $Plan).Path
    $raw=Get-Content -LiteralPath $planPath -Raw
    $manifest=$raw|ConvertFrom-Json -AsHashtable
    $schema=Resolve-BoundPath 'docs/validation/lh01/approved-commands.schema.json'
    $commandsJson=ConvertTo-Json -InputObject @($manifest.approvedCommands) -Depth 30
    if(-not(Test-Json -Json $commandsJson -SchemaFile $schema -ErrorAction Stop)){throw 'Invalid approvedCommands schema'}
    if($manifest.state -ceq 'Executable' -and ($ExpectedPlanSha256 -cnotmatch '^[0-9a-f]{64}$' -or (Get-Sha $planPath) -cne $ExpectedPlanSha256)){$blockers.Add('Execution order must pin the exact approval manifest hash')}
    if($manifest.schemaVersion -ne 1){throw 'Unsupported proof plan schema'}
    if($manifest.executionAuthorized -isnot [bool]){throw 'executionAuthorized must be boolean'}
    foreach($case in $manifest.cases){if($case.enabled -isnot [bool]){throw 'Case enabled must be boolean'}}
    if($manifest.state -cne 'Executable' -or $manifest.executionAuthorized -ne $true){$blockers.Add('Prepared plan grants no execution authority')}
    if($manifest.productCommit -notmatch '^[0-9a-f]{40}$'){$blockers.Add('Exact product commit missing')}
    if($manifest.driver.sha256 -notmatch '^[0-9a-f]{64}$' -or (Get-Sha (Resolve-BoundPath $manifest.driver.path)) -cne $manifest.driver.sha256){$blockers.Add('Driver hash missing or mismatched')}
    if($manifest.decisionSha256 -notmatch '^[0-9a-f]{64}$' -or (Get-Sha (Resolve-BoundPath 'specs/002-lh01-tui-foundation/feasibility/decisions.md')) -cne $manifest.decisionSha256){$blockers.Add('Decision hash missing or mismatched')}
    if(-not $manifest.macAProofReference){$blockers.Add('Mac A product proof missing')}else{
        # Approval evidence can follow the immutable product commit. Resolve only
        # within the approval manifest directory, never relative to the product.
        $proofRelative=[string]$manifest.macAProofReference
        if([IO.Path]::IsPathRooted($proofRelative) -or $proofRelative -match '(^|[/\\])\.\.([/\\]|$)' -or $proofRelative.Contains('\')){throw 'Invalid approval proof path'}
        $proofRoot=Split-Path -Parent $planPath
        $proofPath=[IO.Path]::GetFullPath((Join-Path $proofRoot $proofRelative))
        if(-not $proofPath.StartsWith($proofRoot+[IO.Path]::DirectorySeparatorChar,[StringComparison]::OrdinalIgnoreCase)){throw 'Proof escapes approval directory'}
        $ancestor=$proofPath
        while($ancestor){if(Test-Path -LiteralPath $ancestor){$item=Get-Item -LiteralPath $ancestor -Force;if($item.LinkType -or ($item.Attributes -band [IO.FileAttributes]::ReparsePoint)){throw 'Symlink/reparse in approval proof'}};$ancestor=Split-Path -Parent $ancestor}
        if(-not $manifest.ContainsKey('macAProofSha256') -or $manifest.macAProofSha256 -notmatch '^[0-9a-f]{64}$' -or (Get-Sha $proofPath) -cne $manifest.macAProofSha256){throw 'Mac A proof hash missing or mismatched'}
        $proof=Get-Content -LiteralPath $proofPath -Raw|ConvertFrom-Json -AsHashtable
        if($proof.productCommit -cne $manifest.productCommit -or $proof.mainStatus -cne 'Pass' -or $proof.scope -cne 'maca' -or $proof.diagnosticStatus -cne 'Fail' -or $proof.diagnosticExpectationSatisfied -ne $true){throw 'Mac A proof does not cover approved product revision'}
        if($proof.environment.hardware.machine_name -notmatch 'MacBook Air' -or $proof.environment.hardware.chip_type -cne 'Apple M2'){throw 'Mac A proof hardware mismatch'}
        $proofCases=@($proof.cases)
        $proofIds=@($proofCases|ForEach-Object caseId|Sort-Object)
        $planIds=@($manifest.cases|ForEach-Object id|Sort-Object)
        if($proofCases.Count -ne 20 -or ($proofIds|ConvertTo-Json -Compress) -cne ($planIds|ConvertTo-Json -Compress) -or @($proofCases|Where-Object {$_.expectationSatisfied -ne $true}).Count){throw 'Mac A proof inventory incomplete'}
        foreach($caseProof in $proofCases){
            $caseDefinition=@($manifest.cases|Where-Object id -CEQ $caseProof.caseId)[0]
            if($caseProof.result -cne $caseDefinition.requiredResult -or $caseProof.exitCode -ne $(if($caseProof.caseId -eq 'S07'){1}else{0})){throw 'Mac A proof result mismatch'}
        }
        foreach($bound in $proof.files){
            $relative=[string]$bound.path
            if([IO.Path]::IsPathRooted($relative) -or $relative.Contains('\') -or $relative -match '(^|/)\.\.(/|$)'){throw 'Invalid raw evidence path'}
            $file=Join-Path (Split-Path -Parent $proofPath) $relative
            $current=$file
            while($current){if(Test-Path -LiteralPath $current){$item=Get-Item -LiteralPath $current -Force;if($item.LinkType -or ($item.Attributes -band [IO.FileAttributes]::ReparsePoint)){throw 'Symlink/reparse raw evidence'}};$current=Split-Path -Parent $current}
            if($bound.sha256 -notmatch '^[0-9a-f]{64}$' -or (Get-Sha $file) -cne $bound.sha256){throw 'Mac A raw evidence hash mismatch'}
        }
    }
    if($manifest.state -ceq 'Executable'){
        if(-not $manifest.ContainsKey('fileBindings') -or @($manifest.fileBindings).Count -lt 8){throw 'Execution file bindings missing'}
        foreach($bound in $manifest.fileBindings){if($bound.sha256 -notmatch '^[0-9a-f]{64}$' -or (Get-Sha (Resolve-BoundPath $bound.path)) -cne $bound.sha256){throw 'Execution file binding mismatch'}}
    }
    if(-not $manifest.ContainsKey('approval') -or $manifest.approval.owner -cne 'Thorsten Hindermann' -or -not $manifest.approval.requestReference -or -not $manifest.approval.approvedAt){$blockers.Add('Separate target execution approval missing')}
    $head=(& git -C $root rev-parse HEAD).Trim()
    $status=@(& git -C $root status --porcelain --untracked-files=all)
    if($head -cne $manifest.productCommit -or $status.Count -ne 0){$blockers.Add('Checkout differs from clean approved product commit')}
    foreach($requiredFile in @('src/ShowCommandTui400/ShowCommandTui400.csproj','src/ShowCommandTui400/packages.lock.json','tests/ShowCommandTui400.Tests/ShowCommandTui400.Tests.csproj','tests/ShowCommandTui400.Tests/packages.lock.json','tests/feasibility/lh01/session-contract.ps1')){[void](Resolve-BoundPath $requiredFile)}
    if($PSVersionTable.PSVersion -lt [semver]'7.6.4'){$blockers.Add('PowerShell 7.6.4+ required')}
    $sdk=Get-Command dotnet -CommandType Application -ErrorAction SilentlyContinue|Select-Object -First 1
    if(-not $sdk){$blockers.Add('NET10 SDK missing')}else{
        $sdks=& $sdk.Source --list-sdks
        if($LASTEXITCODE -ne 0 -or -not @($sdks|Where-Object {$_ -match '^10\.0\.'}).Count){$blockers.Add('NET10 SDK required')}
    }
    $python=Get-Command python3 -CommandType Application -ErrorAction SilentlyContinue|Select-Object -First 1
    if(-not $python){$blockers.Add('Python3 missing')}else{
        $pythonVersion=& $python.Source --version
        if($LASTEXITCODE -ne 0 -or $pythonVersion -notmatch '^Python (3\.(9|[1-9][0-9])|[4-9]\.)'){$blockers.Add('Python3.9+ required')}
    }
    $targetEntry=@($manifest.targets|Where-Object id -CEQ $Target)
    if($targetEntry.Count -ne 1){$blockers.Add('Target missing or duplicated')}
    if($Target -eq 'macb'){
        if(-not $IsMacOS){$blockers.Add('Mac B requires native macOS')}else{
            $hardware=(& system_profiler SPHardwareDataType -json)|ConvertFrom-Json
            $machine=$hardware.SPHardwareDataType[0]
            if($machine.machine_name -notmatch 'Mac mini' -or $machine.chip_type -notmatch 'M4 Pro'){$blockers.Add('Mac B hardware must be Mac mini M4 Pro')}
        }
    }
    if($Target -eq 'windows' -and (-not $IsWindows -or [Environment]::OSVersion.Version.Build -lt 22000)){$blockers.Add('Native Windows 11 required')}
    if($Target -eq 'ubuntu-wsl2'){
        if(-not $IsLinux){$blockers.Add('Linux PowerShell required')}else{
            $osRelease=Get-Content /etc/os-release -Raw
            $kernel=Get-Content /proc/sys/kernel/osrelease -Raw
            if($osRelease -notmatch '(?m)^ID=ubuntu$' -or $osRelease -notmatch 'VERSION_ID="24.04"' -or $kernel -notmatch 'WSL2'){$blockers.Add('Ubuntu 24.04 / WSL2 required')}
        }
    }
    $requiredIds=@('PF01','N01','N02','N03','N04','N05','N06','N07','B01','S01','S02','S03','S04','S05','S06','K01','V01','V02','S07','EV01')
    $requiredMapping=@{PF01=@('E01-06','E01-07');N01=@('E01-01','E01-06');N02=@('E01-01','E01-06');N03=@('E01-01','E01-06');N04=@('E01-01','E01-06');N05=@('E01-02','E01-06');N06=@('E01-02','E01-06');N07=@('E01-03','E01-06');B01=@('E01-06');S01=@('E01-01');S02=@('E01-04');S03=@('E01-04');S04=@('E01-04');S05=@('E01-04','E01-06');S06=@('E01-01','E01-04');K01=@('E01-02');V01=@('E01-05');V02=@('E01-03','E01-05');S07=@('E01-04','E01-06');EV01=@('E01-07')}
    $ids=@($manifest.cases|ForEach-Object id)
    if(($ids|Sort-Object|ConvertTo-Json -Compress) -cne ($requiredIds|Sort-Object|ConvertTo-Json -Compress)){throw 'Canonical case inventory incomplete or changed'}
    $canonical=(Get-Content -LiteralPath (Resolve-BoundPath 'docs/validation/lh01/platform-handoff.json') -Raw|ConvertFrom-Json -AsHashtable).cases
    if(@($manifest.cases|Where-Object enabled).Count -eq 0){throw 'No enabled proof cases'}
    foreach($case in $manifest.cases){
        $definition=@($canonical|Where-Object id -CEQ $case.id)[0]
        foreach($field in @('group','expectedOutcome','requiredResult','executionPhase')){if($case[$field] -cne $definition[$field]){throw "Canonical case field changed: $($case.id)/$field"}}
    }
    $commandIds=@($manifest.approvedCommands|ForEach-Object commandId)
    if(@($commandIds|Select-Object -Unique).Count -ne $commandIds.Count){throw 'Duplicate command IDs'}
    foreach($case in $manifest.cases){if(($case.evidenceIds|Sort-Object|ConvertTo-Json -Compress) -cne ($requiredMapping[$case.id]|Sort-Object|ConvertTo-Json -Compress)){throw 'Canonical E01 mapping mismatch'}}
    if(@($ids|Select-Object -Unique).Count -ne $ids.Count){throw 'Duplicate case IDs'}
    $targetCommands=@($manifest.approvedCommands|Where-Object targetId -CEQ $Target)
    foreach($case in $manifest.cases){
        if(-not $case.evidenceIds -or @($case.evidenceIds|Where-Object {$_ -notmatch '^E01-0[1-7]$'}).Count){throw 'Missing/invalid E01 evidence mapping'}
        if(-not $case.enabled){
            if(-not $case.reason -or -not $case.owner -or -not $case.trigger){throw 'Disabled case needs coordinator reason, owner and trigger'}
            continue
        }
        $matching=@($targetCommands|Where-Object caseId -CEQ $case.id)
        if($matching.Count -ne 1){$blockers.Add("Missing/duplicate command for $($case.id)");continue}
        $command=$matching[0]
        if($command.expectedCaseResult -cne $case.requiredResult -or $command.expectedOutcome -cne $case.expectedOutcome){throw 'Command/case expectation mismatch'}
        if(($case.id -eq 'S07') -ne ($case.executionPhase -ceq 'SeparateFailureRun')){throw 'S07 failure phase must be isolated'}
        foreach($argument in $command.arguments){if($argument -match '[{}]' -and $argument -cnotin @('{buildRoot}','{caseRoot}','{productCommit}')){throw 'Unknown or embedded command token'}}
        $working=Resolve-BoundPath $command.workingDirectory
        if(-not(Test-Path -LiteralPath $working -PathType Container)){throw 'Working directory is not a directory'}
        $toolPath=if($command.executable -in @('pwsh','dotnet','python3','python')){$command.executable}else{Resolve-BoundPath $command.executable}
        $tool=Get-Command $toolPath -CommandType Application -ErrorAction SilentlyContinue
        if(-not $tool){$blockers.Add("Executable unavailable: $($command.executable)")}
    }
    if($targetCommands.Count -ne @($manifest.cases|Where-Object enabled).Count){$blockers.Add('Command inventory does not match enabled cases')}
$out=[IO.Path]::GetFullPath($OutputDirectory)
if(Test-Path -LiteralPath $out){throw 'Output root already exists'}
$ancestor=Split-Path -Parent $out
while($ancestor){
    if(Test-Path -LiteralPath $ancestor){$item=Get-Item -LiteralPath $ancestor -Force;if(-not $item.PSIsContainer){throw 'Output ancestor is not a directory'};if($item.LinkType -or ($item.Attributes -band [IO.FileAttributes]::ReparsePoint)){throw 'Symlink/reparse parent in output root'}}
    $parent=Split-Path -Parent $ancestor
    if($parent -eq $ancestor){break};$ancestor=$parent
}
if($out -eq $root -or $out.StartsWith($root+[IO.Path]::DirectorySeparatorChar,[StringComparison]::OrdinalIgnoreCase)){throw 'Use isolated output outside the source checkout'}
} catch {$blockers.Add($_.Exception.Message)}
if($blockers.Count){[ordered]@{status='Blocked';target=$Target;blockers=@($blockers);nextAction='Provide a separately approved complete plan and matching target checkout; no automatic repair'}|ConvertTo-Json -Depth 8;exit 2}
if($CheckOnly){[ordered]@{status='Ready';target=$Target;productCommit=$head;execution='NotRun'}|ConvertTo-Json;exit 0}
[void](New-Item -ItemType Directory -Path $out)
$records=[System.Collections.Generic.List[object]]::new()
$overall='Pass'
# S07 is a diagnostic failure run and follows all successful cases; its Fail never becomes Pass.
$ordered=@($manifest.cases|Where-Object enabled|Sort-Object @{Expression={if($_.id -eq 'S07'){9}elseif($_.group -eq 'Preflight'){0}elseif($_.group -eq 'Negative'){1}elseif($_.id -eq 'EV01'){3}else{2}}})
foreach($case in $ordered){
    $command=@($targetCommands|Where-Object caseId -CEQ $case.id)[0]
    $working=Resolve-BoundPath $command.workingDirectory
    $toolPath=if($command.executable -in @('pwsh','dotnet','python3','python')){$command.executable}else{Resolve-BoundPath $command.executable}
    $executable=(Get-Command $toolPath -CommandType Application|Select-Object -First 1).Source
    $arguments=[string[]]@($command.arguments|ForEach-Object {
        switch -CaseSensitive ($_){
            '{buildRoot}'{Join-Path $out 'build'}
            '{caseRoot}'{Join-Path $out 'cases'}
            '{productCommit}'{$head}
            default{$_}
        }
    })
    $watch=[Diagnostics.Stopwatch]::StartNew()
    $info=[Diagnostics.ProcessStartInfo]::new()
    $info.FileName=$executable;$info.WorkingDirectory=$working;$info.UseShellExecute=$false
    $info.RedirectStandardOutput=$true;$info.RedirectStandardError=$true
    foreach($argument in $arguments){$info.ArgumentList.Add($argument)}
    $process=[Diagnostics.Process]::new();$process.StartInfo=$info
    $timedOut=$false
    try{
        [void]$process.Start()
        $stdout=$process.StandardOutput.ReadToEndAsync();$stderr=$process.StandardError.ReadToEndAsync()
        if(-not $process.WaitForExit(120000)){$timedOut=$true;$process.Kill($true);$process.WaitForExit()}
        $lines=@($stdout.GetAwaiter().GetResult() -split "`r?`n")+@($stderr.GetAwaiter().GetResult() -split "`r?`n" | Where-Object {$_})
        $lines=@($lines|Where-Object {$_ -ne ''})
        $code=$process.ExitCode
    }finally{$process.Dispose()}
    $watch.Stop()
    $text=($lines|Out-String).Replace($root,'<checkout>').Replace([Environment]::GetFolderPath('UserProfile'),'<user>')
    $caseOutput=$out
    if($case.id -eq 'S07'){$caseOutput=Join-Path $out 'S07-diagnostic';[void](New-Item -ItemType Directory -Path $caseOutput)}
    $rawPath=Join-Path $caseOutput ($case.id+'.txt');Set-Content -LiteralPath $rawPath -Value $text
    $observation=$null
    try{$observation=(@($text -split "`r?`n"|Where-Object {$_})|Select-Object -Last 1)|ConvertFrom-Json -AsHashtable}catch{$observation=$null}
    $match=-not $timedOut -and $null -ne $observation -and $observation.caseId -ceq $case.id -and $observation.outcome -ceq $case.expectedOutcome -and $observation.result -ceq $case.requiredResult -and $code -in $command.expectedExitCodes
    $result=if($match){$case.requiredResult}else{'Fail'}
    $records.Add([ordered]@{caseId=$case.id;commandId=$command.commandId;command=@{executable=$command.executable;arguments=@($arguments|ForEach-Object {$_.Replace($root,'<checkout>').Replace($out,'<output>')});workingDirectory=$command.workingDirectory};evidenceIds=$case.evidenceIds;expectedExitCodes=$command.expectedExitCodes;expectedOutcome=$case.expectedOutcome;actual=$observation;exitCode=$code;result=$result;expectationSatisfied=$match;durationMs=$watch.ElapsedMilliseconds;timedOut=$timedOut;restoreBoundary=$(if($timedOut){'External process kill: restoration not guaranteed; stop further tests'}else{'See bound case observation'});outputSha256=(Get-Sha $rawPath)})
    if($case.id -eq 'S07'){
        @{status='Fail';caseId='S07';executionPhase='SeparateFailureRun';expectationSatisfied=$match;record=$records[$records.Count-1];review='Open'}|ConvertTo-Json -Depth 20|Set-Content (Join-Path $caseOutput 'result.json')
        "# Getrennter Fehlerlauf / Separate failure run`n`nDE: S07 bleibt Fail; beide Fehler müssen erhalten sein. Keine bestandene Wiederherstellung behaupten.`n`nEN: S07 remains Fail and must retain both errors. Never claim successful restoration."|Set-Content (Join-Path $caseOutput 'report.md')
    }
    if(-not $match -or $result -eq 'Fail'){$overall='Fail';break}
}
foreach($case in $manifest.cases){if($case.id -notin @($records|ForEach-Object caseId)){$records.Add([ordered]@{caseId=$case.id;evidenceIds=$case.evidenceIds;result='NotRun';enabled=$case.enabled})}}
$afterStatus=@(& git -C $root status --porcelain --untracked-files=all)
if(($afterStatus|ConvertTo-Json -Compress) -cne ($status|ConvertTo-Json -Compress)){$overall='Fail'}
$environment=[ordered]@{powershell=$PSVersionTable.PSVersion.ToString();runtime=[Environment]::Version.ToString();os=[Runtime.InteropServices.RuntimeInformation]::OSDescription;architecture=[Runtime.InteropServices.RuntimeInformation]::ProcessArchitecture.ToString();terminalType=$env:TERM}
if($Target -eq 'macb'){$environment.hardware=@{model=$machine.machine_name;chip=$machine.chip_type}}
if($Target -eq 'ubuntu-wsl2'){$environment.distro=$osRelease;$environment.kernel=$kernel;$environment.windowsHostVersion=(& cmd.exe /c ver|Out-String).Trim();$environment.wslVersion=(& wsl.exe --version|Out-String).Trim()}
$record=[ordered]@{status=$overall;target=$Target;runId=[guid]::NewGuid().ToString();utc=[datetime]::UtcNow.ToString('o');productCommit=$head;manifestSha256=(Get-Sha $planPath);decisionSha256=$manifest.decisionSha256;driverSha256=$manifest.driver.sha256;environment=$environment;allowedWrites='<authorized isolated output root>';sourceStatusBefore='Clean';sourceStatusAfter=$(if($afterStatus.Count -eq 0){'Clean'}else{'Changed'});sourceUnchanged=($afterStatus.Count -eq 0);mainStatus=$(if(@($records|Where-Object { $_.caseId -ne 'S07' -and (-not $_.Contains('enabled') -or $_.enabled -ne $false) -and $_.result -ne 'Pass' }).Count){'Fail'}else{'Pass'});diagnosticRunReference=$(if(Test-Path (Join-Path $out 'S07-diagnostic/result.json')){'S07-diagnostic/result.json'}else{$null});cases=@($records);review='Open';physicalTerminal='Deferred';screenReader='Deferred';brailleHardware='Excluded'}
$record|ConvertTo-Json -Depth 30|Set-Content (Join-Path $out 'result.json')
"# Plattformprüfung / Platform proof`n`nDE: Ergebnis $overall. Anderes Review und Owner-Abnahme offen. S07 bleibt ein separater Fehlerlauf.`n`nEN: Result $overall. Independent review and owner acceptance remain open. S07 remains a separate failure run.`n`nSiehe / See result.json."|Set-Content (Join-Path $out 'report.md')
if($overall -eq 'Pass'){exit 0};exit 1
