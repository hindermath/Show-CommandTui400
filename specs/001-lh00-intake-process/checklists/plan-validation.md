# Lokale Planprüfung / Local plan validation

Historischer Nachweis des unten datierten Laufs. Die damaligen Input-Hashes
bleiben erhalten; das Update vom 2026-10-01 und sein unabhängiges Review stehen
im aktuellen [Receipt](../../intake-authoring-receipts/lh-00.json) und
[Reviewbericht](../../intake-review-report.md).

Historical evidence of the dated run below. Its input hashes are preserved;
the 2026-10-01 update and independent review are recorded in the current receipt
and review report linked above.


Datum / Date: 2026-09-30. Basis / Base:
`88517c13815cf06a9b60d3a5b9c85e1e52f0649f`, Git-Branch `main`.
Autor und Selbstprüfung: ausführender Codex-Agent. Kein unabhängiges Review
dieses Plans und keine Prozessabnahme. Die Prüfung ist auf den Dokumententwurf
begrenzt; auf Wunsch des Owners keine ausgedehnte Wiederholungsprüfung.

The executing Codex agent authored and self-checked the plan. This is neither
independent plan review nor process acceptance. Checks are limited to the document
design, without broad repeated testing, as requested by the owner.

| Prüfung / Check | Ergebnis / Result | Grenze / Boundary |
|---|---|---|
| Setup-Plan | PASS, Exit 0 | Aktives Feature korrekt aufgelöst; kein Git-Branchwechsel / Active feature resolved, no branch change. |
| Komponierte Vorlage / Composed template | PASS | Kern plus acht Append-Layer aufgelöst und berücksichtigt; keine Upstream-Vorlage geändert / Core plus eight append layers resolved and applied, no template changes. |
| Authoring-Receipt | PASS, Exit 0 | `a627d004-b189-43df-b061-27e30a0e6a37`, current, ReadyForReview, neun Quellen / nine sources. |
| Intake-Review | PASS, Exit 0 | `c22c0fcd-610a-4a77-8f8d-59e504efc113`, current, Single, Ready; keine neue Intake-Prüfung behauptet / No new intake review claimed. |
| Dokumentstruktur und Links / Document structure and links | PASS | Lokale Markdown-Dateilinks vorhanden, Codeblöcke beschriftet, keine Vorlagenmarker; geplante Pfade sind Klartext / Local file links exist, tagged code fences, no placeholders; future paths are plain text. |
| Coverage | PASS | Plan enthält alle 24 Spec-FR, zwölf Quell-FR und neun Quell-AC / Plan references every required ID. Keine fachliche Abnahme / Not domain acceptance. |
| Eingabe-/Guidance-Erhalt / Input and guidance preservation | PASS | Spec, Intake, Receipt/Review, Policy/Profile und fünf Guidance-Dateien unverändert / Bound inputs and guidance unchanged. |
| `git diff --check` und neue Dokumente / and new documents | PASS | Keine Whitespace-Fehler im begrenzten Änderungssatz / No whitespace errors in scoped changes. |
| Vor-/Nach-Hooks / Pre/post hooks | N/A | `.specify/extensions.yml` fehlt; keine Hooks registriert / No extension hook file. |
| Historischer Kontext-Skriptlauf / Historical context script run | PASS, Exit 0 | Damalige Ausgabe geprüft; Verweisdatei später auf Owner-Auftrag entfernt. Keine automatisch geladene Guidance entstanden / Output verified at the time; reference file later removed at the owner's request. No automatically loaded guidance resulted. |

Receipt- und Review-Prüfung verwendeten die Bash-Kommandos aus
[Quickstart](../quickstart.md), Abschnitt 1. Produkt-, Vier-Host-, Hilfsmittel-
und vollständige Prozessprüfungen wurden nicht ausgeführt. Es gibt keine neue
aktive Collection, Serie, Intake-Datei, Implementierung oder Remote-Änderung.
Statistik bleibt für das nächste autorisierte Lieferpaket offen.

Receipt/review validation used the Bash commands in quickstart section 1. Product,
four-host, assistive and full process tests were not run. No active collection,
series, intake, implementation or remote change was created. Statistics remain
pending for the next authorized delivery.

## Historischer Kontext-Skriptlauf / Historical context script run

Am 2026-09-30 wurde das gebündelte Bash-Skript der Extension `agent-context` 1.0.0
aus Spec Kit 0.12.8 in einer temporären Minimalwurzel ausgeführt. Nach einem
ergebnislosen ersten Versuch erzeugte der Lauf mit vollständiger Konfiguration
einen Planverweis (Exit 0, Ausgabe geprüft). Die daraus übernommene
`agent-context.md` wurde anschließend auf Owner-Auftrag ersatzlos entfernt.
Automatisch geladene Agent-Guidance entstand dabei nicht; die fünf gemeinsamen
Guidance-Dateien blieben unverändert. Keine erneute Generierung oder Installation.

On 2026-09-30, the bundled agent-context 1.0.0 Bash script from Spec Kit 0.12.8 ran
in a temporary minimal root. After an initial attempt produced no file, the fully
configured run generated a plan reference (exit 0, output verified). The resulting
agent-context.md was later removed without replacement at the owner's request.
It never became automatically loaded agent guidance; the five shared guidance
files remained unchanged. No regeneration or installation followed.

Skript / Script: `specify_cli/core_pack/extensions/agent-context/scripts/bash/update-agent-context.sh`.
SHA-256: `53067ad0c978e96a10f9e77bc599ab1a90216df94b4fb70ec0238f9b98cd3f1b`.

Die Collection-Kompatibilitätsprobe ist unter [D-03](../research.md#d-03-bootstrap-und-kompatibilität--bootstrap-and-compatibility)
als Recherchebeleg dokumentiert. B-01 bleibt ein konkreter Umsetzungsvorgänger,
kein stillschweigend akzeptiertes Risiko oder bestandenes Lifecycle-Gate.

The collection probe is research evidence under D-03. B-01 remains an implementation
prerequisite, not an accepted risk or a passed lifecycle gate.

## Lokales Update vom 2026-10-01 / Local update on 2026-10-01

IAD010 setzt die Quellenkorrektur B-01 und die gestufte Abnahme um. Lokale
Prüfplattform: Darwin 27.0.0 (macOS), Bash 5.3.20, PowerShell 7.6.6,
Python 3.14.7. Dieser Host wird für den Werkzeugtest nicht als Mac A oder B
zugeordnet; die spätere praktische Kernprozessabnahme muss den Mac benennen.

IAD010 implements the B-01 source correction and staged acceptance. Local tool
test platform: Darwin 27.0.0 (macOS), Bash 5.3.20, PowerShell 7.6.6, Python 3.14.7.
This tool test does not classify the host as Mac A or Mac B; later practical
core-process acceptance must identify its Mac.

| Quellrepository / Source repository | Basis-Commit / Base commit | Test / Result |
|---|---|---|
| intake-authoring-governance | `f90e707444237d768623f457f85d15a707c3476e` + lokale Änderungen / local changes | `pwsh -NoProfile -File tests/test-intake-governance-config.ps1`: PASS, Exit 0; Bash zuerst, danach PowerShell / Bash first, then PowerShell. |
| intake-review-governance | `91462b4f47e64b9585c0f7d440a80449d7eb64c0` + lokale Änderungen / local changes | `pwsh -NoProfile -File tests/test-intake-governance-config.ps1`: PASS, Exit 0; Bash zuerst, danach PowerShell / Bash first, then PowerShell. |
| intake-sequencing-governance | `8aa137fcc95faf4e145ee408a1ee3790cac1873a` + lokale Änderungen / local changes | `pwsh -NoProfile -File tests/test-intake-governance-config.ps1`: PASS, Exit 0; Bash zuerst, danach PowerShell / Bash first, then PowerShell. |

Alle drei Suiten prüfen identische JSON-Ausgabe beider Wrapper und unveränderte
Fixture-Dateien. Neuer Einzelprozess: Ready/Eligible → Active/Active (N/A) →
Completed/Archiv (N/A). Ready ohne Eligible, Active ohne Active und ohne Eligible,
mehrere Eligible, falsche Hashes, fehlende Dateien, Pfadausbrüche und ungültige
Abhängigkeiten werden abgewiesen. Ein Active plus ein Eligible sowie bisherige
Mehrmitglied-/Archivfälle bleiben gültig. Schema und Ausgabeformat unverändert.
Die erste Testfassung erwartete bei fehlender Datei irrtümlich RIG015; auf den
bestehenden korrekten Fehler RIG014 berichtigt, danach alle drei Suiten bestanden.
Kein Validatorverhalten wurde dafür gelockert.

All three suites check identical JSON from both wrappers and unchanged fixture
files. New single lifecycle: Ready/Eligible → Active/Active (N/A) → Completed/archive
(N/A). Ready without Eligible, Active with neither Active nor Eligible, multiple
Eligible members, invalid hashes, missing files, path escapes and invalid
dependencies are rejected. One Active plus one Eligible and existing multi-member
and archive cases remain valid. Schema and output format are unchanged. The
initial missing-file fixture incorrectly expected RIG015; corrected to the existing
proper RIG014, then all three suites passed. No validator rule was relaxed for it.

### Geprüfte Quelldateien / Tested source files

SHA-256 bindet die lokale korrigierte Fassung, nicht ein veröffentlichtes Release.
SHA-256 binds the corrected local file, not a published release.

| Repository | Datei / File | SHA-256 |
|---|---|---|
| authoring | `scripts/validate-intake-governance-config.py` | `f01a8c48a6dd7c87ab1246b0a6d7df41c68e6b0b67bd87e7ceb18e78b1fc3d71` |
| authoring | `tests/test-intake-governance-config.ps1` | `affd3b2560ce880b447a2037b69486ffce75efadaf9c418761b9318b35e50891` |
| review | `scripts/validate-intake-governance-config.py` | `f01a8c48a6dd7c87ab1246b0a6d7df41c68e6b0b67bd87e7ceb18e78b1fc3d71` |
| review | `tests/test-intake-governance-config.ps1` | `affd3b2560ce880b447a2037b69486ffce75efadaf9c418761b9318b35e50891` |
| sequencing | `scripts/validate-intake-governance-config.py` | `e139287ce32c9f3301aa700715e44318ef8ddb2b6d4c815fbfe0d6d3ceec66c4` |
| sequencing | `tests/test-intake-governance-config.ps1` | `3cfd727f7c199418b393c20cbc33081762a268128ea4c8416d676f7917269486` |

**Grenzen:** Native Linux-/Windows-CI für diesen Patch bleibt offen. Die vorhandenen
Workflow-Matrizen sind vorbereitet, aber hier nicht ausgelöst. Patch-Releases,
zentrale Pins und gezielte Projektinstallation benötigen separate Autorität.
B-01 ist lokal in den Quellen korrigiert; die installierten Projektkopien sind
unverändert und blockieren weiterhin die tatsächliche Serienaktivierung.
Leeres Idle bleibt ausgeschlossen. Keine praktische Prozess-, A11Y- oder
Feature-Abnahme; LH-00 bleibt offen. Keine Commits oder Remote-Schreibzugriffe.

**Boundaries:** Native Linux/Windows CI for this patch remains pending. Existing
workflow matrices are ready but were not triggered here. Patch releases, central
pins and targeted project installation require separate authority. B-01 is fixed
locally in source; installed project copies remain unchanged and still block actual
series activation. Empty Idle remains excluded. No practical process, accessibility
or feature acceptance; LH-00 stays open. No commits or remote writes.

Der aktuelle [Receipt](../../intake-authoring-receipts/lh-00.json) und das neue
[unabhängige Review](../../intake-review-report.md) binden den aktualisierten
Intake. Alte Checklistenwerte oben bleiben historische Ergebnisse.

The current receipt and new independent review linked above bind the updated
intake. Earlier checklist values above remain historical results.
