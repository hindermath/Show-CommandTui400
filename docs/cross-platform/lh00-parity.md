# LH-00-Skriptparität / LH-00 script parity

**Stand / Date:** 2026-10-06. **Basis:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Host:** Mac A, MacBook Air M2 (2023), vom Owner benannt / named by the owner.
**Foundation-Reviewer:** `/root/lh00_t012_foundation_review`, siehe Plan-Governance.

## Herkunft und Änderungen / Provenance and changes

Die fünf PowerShell-Dateien wurden gezielt aus dem installierten
`specify-cli 0.12.8/core_pack/scripts/powershell/` übernommen. Die Rohbyte-Hashes
von Quelle und integriertem Stand stehen in [lh00-script-provenance.json](lh00-script-provenance.json).
`common.sh` ist bytegleich zum Paket. Andere Bash-Pendants unterscheiden
Whitespace und das historische projektlokale Kommandorendering. Die Semantik
von Root-Auflösung, JSON-Daten und Dateierstellung bleibt erhalten.
Imported the five PowerShell files from the installed same-version core pack.
The linked inventory records exact source/integrated hashes. Existing Bash
behavior is preserved, including its historical local invocation spelling.

Ergänzt wurden DE/EN-Kommentarhilfe, zwei unten begründete Importkorrekturen
und in `common.ps1` vier typisierte Advanced
Functions (Cmdlets), die ausschließlich das bestehende Skript weiteraufrufen:
`Test-SpecKitPrerequisites`, `New-SpecKitFeature`, `Initialize-SpecKitPlan`,
`Initialize-SpecKitTasks`. Sie übernehmen Parameter und Fehlerstatus; keine
zusätzliche Testlogik. Dot-Sourcing von common lädt nur Funktionen.
Bilingual help, two narrow fixes described below and four typed advanced functions expose the existing
scripts. They forward parameters and failures; no additional test engine is added.
Dot-sourcing common only loads functions.

## Prüfaufbau und Ergebnisse / Test setup and results

Vor Übernahme wurden die Paket-PowerShell-Dateien gegen die vorhandenen
Bash-Skripte in einer temporären, getrennten .specify-Root geprüft. Danach wurde
soweit relevant derselbe Prüfbestand gegen die integrierten Dateien wiederholt.
[parity-results.json](../validation/lh00/parity-results.json) enthält tatsächliche
Argumente, Exitcodes, Ausgabe und Anzahl geänderter Dateien für 19 Basis-/Cmdlet-Aufrufe.
The isolated fixture compared installed PowerShell with existing Bash, then
rechecked the integrated files. The result file records arguments, exits, output
and changed-file counts. No real feature was used as a write test.

- Gültige Prerequisites, Feature-DryRun sowie Setup mit bestehendem Plan/Tasks:
  vier gleiche JSON-Payload-Paare, keine Änderungen.
- Ungültige explizite Root: beide Shells weisen ab, kein Fallback/Schreiben.
- Setup mit neuem Plan: nur isolierte Dateierstellung; Setup-Tasks liefert
  Eingabepfade und erzeugt selbst keine fachliche Aufgabenliste.

Valid prerequisites, feature previews and existing setup inputs produced four
matching JSON pairs without writes. Invalid explicit roots were rejected.
Fresh plan creation was confined to fixtures. Setup-tasks resolves inputs; it
does not author tasks.md. An initial fixture error reused a removed tasks.md;
resetting each shell's fixture corrected the test setup, not the script.

Ein neues `test-lh00-process`-Wrapperpaar ist **N/A**: kein belegter Funktionsmangel.
Vorhandene Create-DryRun- und Prerequisites-PathsOnly-Wege erlauben den Preview;
Setup ohne Preview läuft ausschließlich isoliert. Der dokumentierte Cmdlet-Weg
ersetzt kein neues Testframework. Trigger: später belegte gemeinsame Prüflücke;
Owner Thorsten, Wiedervorlage 2026-10-12.
A new test-wrapper pair is N/A because no functional gap was found. Existing
previews and isolated setup meet this scope. Reassess only on a demonstrated gap.

## Grenzen / Limits

PowerShell wurde hier auf macOS ausgeführt, nicht auf Windows. Leeres HOME wird
als portable Eingabe lokal geprüft; das ist kein nativer Windows-Nachweis.
Native Linux-/Windows-/Mac-B-Prozessabnahme folgt an ihrem eigenen Gate. Init-
Optionen, fünf Integrationen, Baseline und aktive LH-00-Hashbindungen bleiben gleich.
This is macOS evidence only. Local empty-HOME resolution does not prove native
Windows operation. Native platforms, full acceptance and later lifecycle tests
remain open. Initialization choices, integrations and active evidence are preserved.

## Gezielt korrigierte Importbefunde / Narrow import corrections

Die zusätzliche direkte Analyse der fünf Imports fand zwei bereits im Paket
vorhandene Befunde in common.ps1. Die Schleifenvariable `$pid` wurde umbenannt,
weil PowerShells automatische PID-Variable schreibgeschützt ist. Der bestehende
Catch zur Reparatur expliziten Featurezustands enthält nun eine sichere Verbose-
Meldung ohne Quellinhalte. Diese beiden Änderungen erweitern keinen fachlichen
Scope; Herkunfts- und Endhashes sowie begrenzte Fallprüfungen sind dokumentiert.
Direct analysis found two pre-existing package findings. Rename the loop variable
that collided with read-only PID; add a safe verbose diagnostic to existing
feature-state recovery. These narrow fixes add no product scope and are bound
by source/final hashes and targeted checks.

Die gezielten zwei Fallprüfungen stehen in
[import-fix-results.json](../validation/lh00/import-fix-results.json); der genaue
isolierte Testtext wird als `.ps1.txt`-Nachweis aufbewahrt, nicht als neuer
installierter Testwrapper. Beide Fälle PASS/Exit 0.
The two targeted cases passed and are recorded with the exact inactive fixture
source. It is evidence, not a new installed test wrapper.

## T043: vollständige Vorlagenzuordnung / Full template mapping

Feature 001-lh00-intake-process; Phase implement T019–T045, Datum 2026-10-06,
main e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd plus lokaler Arbeitsstand, kein PR.
Owner Thorsten, Autor Codex /root. Grundlage ist das installierte
script-parity-checklist-template.md; Scope sind die fünf Basisskriptpaare.
Applicable: Parität, Hilfe, genehmigte Verben, Preview-Nullschreiben und sichere
Eingaben. Native zweite Plattform und vollständige Abnahme bleiben Open.
Re-evaluation: geänderte Skriptbytes, Host/Initoptionen, Toolversionen oder T047–T049.
This record applies the installed template to all five script pairs in this local
implementation run. Existing dated hashes/results remain current where bytes
match. It proves macOS tooling checks, not product certification or native Windows.

| Paar / Pair | Veränderung / Change | Ausführungsnachweis / Execution evidence | Ergebnis / Result |
|---|---|---|---|
| common | PS übernommen; Bash erhalten / import PS, preserve Bash | provenance, Get-Help/Get-Verb und import-fix-results | funktionale Root-/HOME-/Recovery-Grenzen geprüft / scoped boundaries checked |
| check-prerequisites | PS übernommen / imported | parity-results: JSON, ungültige Root, PathsOnly, Cmdlet | JSON/Exit gleich, null Writes / equivalent, zero writes |
| create-new-feature | PS übernommen / imported | parity-results: DryRun, Cmdlet | kein echter Featurelauf; DryRun, kein WhatIf / preview only, no actual feature |
| setup-plan | PS übernommen / imported | parity-results: bestehend/isoliert neu / existing/isolated new | gleicher Payload, nur isoliertes Schreiben / matching scoped writes |
| setup-tasks | PS übernommen / imported | parity-results: Pfade/AdvancedFunction | erzeugt keine fachliche Taskliste / resolves inputs only |

Gemeinsame Defaults/Argumente sind nach bestehendem Upstreamvertrag erhalten;
Bash/PowerShell-Schreibweise unterscheidet sich. Vier echte JSON-Payloadpaare
stimmen überein, Fehler-Exitcodes sind geprüft; Fehlermeldungen behalten jeweils
die vorhandene Shellform. Read-only/Preview-Nullschreiben gilt für tatsächlich
verfügbare Wege, keine globale WhatIf-Unterstützung wird behauptet. Setup schreibt
ohne Preview ausschließlich in isolierten Testwurzeln. Keine Netzwerk-, Registry-
oder Keychainzugriffe werden neu eingeführt. Roots mit/ohne explizitem ./ und
entferntem HOME wurden im vorhandenen getrennten Testbestand berücksichtigt.
Arguments/defaults preserve the upstream contract; spellings and shell-specific
errors differ. Four actual JSON pairs match. Real preview paths show zero writes;
setup-only mutations are confined to isolated roots. No global WhatIf guarantee
or newly introduced network/registry/keychain access is claimed.

Unix-Hilfe: docs/man/lh00-process.1.md mit NAME/SYNOPSIS/DESCRIPTION/OPTIONS/
ENVIRONMENT/EXIT STATUS/EXAMPLES/SEE ALSO. Alle fünf PS-Dateien haben bilinguale
Kommentarhilfe; Get-Help für vier AdvancedFunctions wurde erneut wirklich
ausgeführt. Test/New/Initialize sind in Get-Verb enthalten, Parameter typisiert.
Die importierten Upstreambasisskripte besitzen teilweise nur set -e und kein
StrictMode: bewusst erhaltene Upstreamkompatibilität, kein pauschaler neuer
Sicherheitsmodus ohne verhaltensbezogenen Nachweis. Keine eval-/Invoke-Expression-
Auswertung fremder Inhalte; PS-Aufrufe hier stets -NoProfile. Upstreamoptionen
bieten -DryRun statt SupportsShouldProcess/WhatIf; eine zusätzliche Wrapper-
Engine bleibt begründet N/A. Die produktbezogene Sandbox-/Containerpolitik
wird durch diese lokalen isolierten Dateitests nicht gelockert.
The man source has the required sections. Bilingual help/Get-Help and approved
verbs are evidenced. Preserve upstream partial set -e/no-StrictMode behavior
rather than asserting strict modes that do not exist. Use actual -DryRun paths;
WhatIf/Confirm and an extra wrapper remain N/A under that unchanged contract.
No foreign expression evaluation or broader sandbox exception is introduced.

Aktuelle Gates: Secret-Scan Exit0/high0, Analyzer1.25.0 Exit0/73 Dateien/0 Befunde,
14er-Matrix Exit0. Homogenität Exit1 (Statistikdrift + historische STATS-Warnung),
Statistik Check-only Exit1/DRIFT. Das ist kein PASS. Renderer benötigt sauberen
Arbeitsbaum; Commit/Render/Lieferung sind in diesem lokalen Auftrag nicht enthalten.
Vor einer Liefer-/Pilotbewertung bleibt diese konkrete Prüflücke sichtbar. Owner
Thorsten; Trigger später ausdrücklich beauftragtes Commit-/Statistikpaket.
Current secret/analyzer/preset checks pass. Homogeneity and statistics fail due
to generated-statistics drift; do not relabel them. Rendering needs a clean tree
and a separately authorized delivery package. Keep this gate visible before
final pilot/delivery assessment. Native Mac B/Windows/WSL2 proof stays open.
