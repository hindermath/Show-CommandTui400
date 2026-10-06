# LH00-PROCESS(1)

## NAME / NAME

lh00-process — vorhandene Spec-Kit-Dateiskripte sicher aufrufen / safely invoke existing file scripts

## SYNOPSIS / SYNOPSIS

```sh
bash .specify/scripts/bash/check-prerequisites.sh --help
bash .specify/scripts/bash/check-prerequisites.sh --json --paths-only
bash .specify/scripts/bash/create-new-feature.sh --json --dry-run --short-name fixture --number 2 'Local fixture'
```

```powershell
Get-Help ./.specify/scripts/powershell/check-prerequisites.ps1 -Full
pwsh -NoProfile -File .specify/scripts/powershell/check-prerequisites.ps1 -Help
pwsh -NoProfile -File .specify/scripts/powershell/check-prerequisites.ps1 -Json -PathsOnly
pwsh -NoProfile -File .specify/scripts/powershell/create-new-feature.ps1 -Json -DryRun -ShortName fixture -Number 2 'Local fixture'
```

## BESCHREIBUNG / DESCRIPTION

Diese Wege bedienen die vorhandenen Dateiverträge. `SPECIFY_INIT_DIR` nennt die
Wurzel mit `.specify/`. `SPECIFY_FEATURE_DIRECTORY` oder `.specify/feature.json`
legt den Featurepfad fest; keine Produkttechnik wird gewählt. Lesen zuerst, nur
im beauftragten Bestand schreiben. Die dargestellten Previews erzeugen keine Dateien.
These routes use existing file contracts. Explicit root and feature state select
the assigned file scope. Read first; mutate only within the current request.
The shown previews create no files and select no product technology.

## CMDLETS / CMDLETS

```powershell
# In PowerShell 7 mit -NoProfile starten / start PowerShell 7 with -NoProfile
. ./.specify/scripts/powershell/common.ps1
Get-Help Test-SpecKitPrerequisites -Full
Test-SpecKitPrerequisites -Json -PathsOnly
New-SpecKitFeature -Json -DryRun -ShortName fixture -Number 2 'Local fixture'
```

`Initialize-SpecKitPlan -Json` und `Initialize-SpecKitTasks -Json` entsprechen
setup-plan/setup-tasks. Sie besitzen keinen Preview-Schalter und werden deshalb
nur im ausdrücklich freigegebenen isolierten Bestand geprüft. Setup-Plan bewahrt
vorhandenen Planinhalt; Setup-Tasks liefert Daten, keine generierte Aufgabenliste.
The initialization functions invoke their setup scripts. They have no preview
switch, so write tests require an assigned isolated fixture. Existing plan content
is preserved; task setup returns inputs without authoring the task list.

## AUTHORING / AUTHORING

`$speckit-intake-create` ist ein Agenten-Skill, kein erfundener Shellbefehl.
Ein Auftrag nennt genau ein freies Ziel, Profil und geordnete Quellen. Der Agent
wendet Policy/Profil an, klärt Konflikte, erstellt Intake/Receipt und validiert
beide Shells. Status ReadyForReview erlaubt ausschließlich einen gesondert
beauftragten Review-Handoff; die zwei Folgeprompts sind inaktive Vorlagen.
Intake-create is an agent skill, not a shell command. It reads the named sources,
applies governance, creates one intake/receipt and runs both validators. Neither
readiness nor stored follow-up prompts automatically starts a downstream run.

## EXIT-STATUS / EXIT STATUS

0 bedeutet Erfolg des benannten Skripts; ungleich 0 bedeutet Fehler. Cmdlet-
Aufrufwege übernehmen Fehler als Ausnahme. Ein Exitcode bestätigt keine
Produkt-, A11Y-, Plattform- oder Owner-Abnahme.
Zero means the named script succeeded; nonzero means failure. Function routes
surface failure as an exception. Exit status grants no acceptance or authorization.

## SIEHE AUCH / SEE ALSO

[Paritätsnachweis / Parity](../cross-platform/lh00-parity.md),
[Fixture-Grenze / Fixture boundary](../validation/lh00/fixture-plan.md),
[Create-Nachweis / Create evidence](../validation/lh00/create.md).

## OPTIONEN / OPTIONS

Prerequisites: --json/-Json, --paths-only/-PathsOnly, --require-tasks/-RequireTasks,
--include-tasks/-IncludeTasks. Feature-Create: --dry-run/-DryRun, --short-name/
-ShortName und --number/-Number. Setup unterstützt -Json, keinen Preview-Schalter.
Je Skript --help/-Help vor Nutzung lesen. Die Skill-Namen sind Agentenverfahren,
keine zusätzlich installierten ausführbaren Programme.
Prerequisite and creation options above preserve shell-specific spelling. Read
the actual help first; setup has no preview switch and writes only in authorized
fixtures. Agent skills are procedures, not extra executable CLI commands.

## UMGEBUNG / ENVIRONMENT

SPECIFY_INIT_DIR legt die ausdrücklich gewählte Repositorywurzel fest;
SPECIFY_FEATURE_DIRECTORY oder .specify/feature.json bestimmt das Feature.
SPECIFY_FEATURE liefert die vorhandene alternative Auswahl. Kein fremder Inhalt
wird als Code ausgewertet. Windows-HOME darf fehlen; die isolierte Prüfung
entfernt HOME nur aus der gestarteten Prozessumgebung. Diese Variablen dürfen
keine Befugnis erteilen. Mac-/Linux-Tooling verwendet Bash, PS immer -NoProfile.
Explicit root/feature selection follows those environment variables and state
files. Missing HOME is tested in child environments; no source is evaluated as
code. Root selection does not grant authority. Use the documented local shell
contract, not an inferred product minimum.

## BEISPIELE / EXAMPLES

Die SYNOPSIS zeigt lesende Prerequisites und Feature-Preview. Setup-Plan mit
vorhandenem Plan liefert dessen Pfad; erstmaliges Schreiben ausschließlich in
einer eigens freigegebenen Kopie. Update/Delete/Review des Test-Intakes stehen
in docs/validation/lh00 mit echten Validatorausgaben. Kein Beispiel ist ein
Auftrag zur Ausführung seiner Folgeprompts.
The synopsis supplies read-only/preview examples. First-time setup writes need
an assigned isolated copy. Lifecycle evidence records actual validation; examples
and stored prompts never commission downstream execution.
