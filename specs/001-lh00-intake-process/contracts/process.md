# Prozess- und Kommandoschnittstelle / Process and command interface

Dieser Vertrag gilt für die bestehenden Agentenkommandos und Datei-Validatoren,
nicht für ein neues Produkt-Cmdlet. Folgeprompts im Intake sind Vorlagen für einen
späteren Auftrag, keine ausführbaren Berechtigungen.

This contract covers existing agent commands and file validators, not a new
product cmdlet. Intake follow-up prompts are templates for later requests, not
executable permissions.

| Aktion / Action | Eingabe und Vorbedingung / Input and prerequisite | Ergebnis und Grenze / Result and boundary |
|---|---|---|
| `speckit-intake-create` | Benannte Quelle, genau ein Ziel, Profil und ausdrücklicher Erstellauftrag / Named source, one target, profile and explicit creation request. | Neues Intake + Receipt; vorhandenes Ziel unverändert ablehnen. Kein Review oder Folge-LH starten / Create intake/receipt; reject existing target unchanged; no automatic review or next intake. |
| `speckit-intake-update` / `speckit-intake-repair` | Passende Änderungs-/Reparaturautorität, aktueller Vorgänger und benannte Änderung / Matching authority, current predecessor, named change. | Intake-ID erhalten, neue Receipt-/Operations-ID, Vorgänger archivieren, Review veralten lassen / Preserve intake identity, new receipt/operation, archive predecessor, invalidate downstream review use. |
| `speckit-intake-review` | Genau beauftragter Zielstand, gültige Bindungen, anderer Prüfer / Named target state, valid bindings, different reviewer. | Vollständiges Review mit Befunden; akzeptierte Risiken nur mit belegter menschlicher Entscheidung / Complete review and findings; risk acceptance requires human evidence. |
| Read-/Status-Kommandos / Read/status commands | Vorhandene Dateien und passenden Scope lesen / Read existing files and matching scope. | Keine Writes, Hashreparaturen oder Lieferung; veraltete Nachweise sichtbar / No writes, hash repairs or delivery; expose stale evidence. |
| Series-Create/Update | Explizite Serienautorität, bestehende Mitglieder, gültige Konfiguration / Explicit series authority, existing members, valid configuration. | Versionierte Serie mit Receipt/Operation; keine Intake-Erstellung ableiten / Versioned series with evidence; no inferred intake creation. |
| Series-Next | Aktuelle Konfiguration, Manifest und Gates / Current configuration, manifest and gates. | Alle zulässigen Ziele oder genaue Blocker anzeigen; keinen Lauf starten / List eligible targets or exact blockers; never execute. |
| Intake-/Series-Delete | Expliziter Löschumfang, aktueller Vorgänger / Explicit deletion scope, current predecessor. | Archiv und Tombstone erhalten; Series-Delete löscht keine Intake-Dateien / Preserve archive/tombstone; deleting a series does not delete its intakes. |

Jede neue Datei enthält DE zuerst/EN danach, Zweck, Scope/Nicht-Ziele,
Anforderungen, Qualitäts-/Governance-Zuordnung, Risiken/Abhängigkeiten, Nachweise,
AC, Entscheidungen und beide Folgeprompts. Begriffe bei Erstnennung erklären.
Status, Links, Fehler und nächste Aktion müssen ohne Farbe oder Diagramm lesbar
sein. Sprachäquivalenz, B2-Verständlichkeit und Hilfsmittelzugang separat prüfen.

Each new intake contains both language tracks, purpose, scope/non-goals,
requirements, quality/governance mapping, risks/dependencies, evidence, AC,
decisions and both follow-up prompts. Define terms at first use. States, links,
errors and next actions must remain understandable without color or diagrams.
Check language equivalence, B2 readability and assistive access separately.

## Validatorverträge / Validator contracts

Alle Pfade beginnen bei `.specify/presets/`. Die Tabelle beschreibt vorhandene
Argumente, keine neue CLI. Bash benötigt `bash`, PowerShell `pwsh -NoProfile -File`.
Ein Prozess-Exitcode 0 reicht allein nicht: die Ausgabe muss tatsächliche
Validierung statt No-op anzeigen. Nicht-Null und Fehlermeldung sind ein Fehlschlag;
erwartete negative Tests separat markieren und niemals als positiven PASS zählen.

Paths start at .specify/presets/. These are existing arguments, not a new CLI.
Exit 0 alone is insufficient: output must confirm real validation, not a no-op.
Nonzero exits/errors fail; label expected negative cases separately.

| Datei im jeweiligen Preset / File within preset | Bash | PowerShell |
|---|---|---|
| Authoring: `scripts/validate-intake-authoring-receipt` | `.sh --receipt FILE --repo ROOT` | `.ps1 -Receipt FILE -Repo ROOT` |
| Authoring: `scripts/validate-intake-authoring-artifact` | `.sh --artifact FILE --repo ROOT` | `.ps1 -Artifact FILE -Repo ROOT` |
| Review: `scripts/validate-intake-review-result` | `.sh --result FILE --repo ROOT` | `.ps1 -Result FILE -Repo ROOT` |
| Authoring/Review/Sequencing: `scripts/validate-intake-governance-config` | `.sh --config FILE --repo ROOT --json` | `.ps1 -Config FILE -Repo ROOT -Json` |
| Sequencing: `scripts/validate-intake-series-manifest` | `.sh --file FILE --repo ROOT --json` | `.ps1 -File FILE -Repo ROOT -Json` |
| Sequencing: `scripts/validate-intake-series-receipt` | `.sh --file FILE --repo ROOT --json` | `.ps1 -File FILE -Repo ROOT -Json` |

Quell- und Zielprüfsummen aus echten Dateien neu berechnen. Inhalte/Quellen
ändern kein Receipt automatisch. Create-existing, Hashdrift, Pfadausbruch,
mehrdeutiger Bestand und Zyklus müssen ohne aktive Mutation abbrechen.
Vorhandene externe Quellenlimits der Authoring-Policy bleiben bestehen; dieser
Plan fügt weder Crawling noch Netzwerkdienste hinzu.

Recompute source/target hashes from actual files. Content/source changes never
silently repair receipts. Existing-target creation, hash drift, escaping paths,
ambiguous inventory and cycles must fail without active mutation. Preserve current
external-source limits; this plan adds no crawling or network service.

## Abnahmeprotokoll / Acceptance record

Pro Fall dokumentieren: ID E01–E07, Anforderung/AC, benannten Autor und anderen
Reviewer, Auftrag, Plattform/Hostrolle, Toolversionen, Repositorycommit und
Kandidatenhashes, exakten Befehl bzw. Agentenauftrag, Exitcode oder klar `N/A`
für menschliche Beurteilung, Ergebnis, Grenzen, Belegpfade und nächste Aktion.
Technische Befunde, menschliche Risikoannahme und Projektabnahme getrennt halten.

For each case record E01–E07, requirement/AC, named author and different reviewer,
authority, platform/host role, tool versions, commit and candidate hashes, exact
command/agent request, exit or explicit N/A for human judgment, outcome, limits,
evidence paths and next action. Separate technical results, human risk acceptance
and project acceptance.
