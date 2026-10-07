# Quellenaktualisierung vor LH-01 / Source refresh before LH-01

Stand / Date: 2026-10-07. IAD019. Owner: Thorsten Hindermann. Autor / Author: Codex `/root`.

## Auftrag und Entscheidung / Request and decision

Thorsten beauftragt: „Implement the proposed plan.“ Der bestätigte Plan umfasst
Issue #2 und die dort benannten Quellen, gewöhnliches LH-00-Update, kohärente
Serienbindungen, vollständiges Review durch einen anderen Agenten, gezielten
Spec-/Plan-/Tasks-Abgleich und Analyze sowie MergeAndSync mit Admin-Bypass.
Nach Repository-Lieferung wird das vorbereitete Issue veröffentlicht und erst
danach ein verbesserter LH-01-Authoring-Prompt angeboten. Dieser Auftrag erstellt
kein LH-01 und startet keinen Produktlauf, Release oder Flotten-Rollout.

Sprachfrage: „Soll C# jetzt als verbindliche primäre Implementierungssprache
festgelegt werden oder zunächst eine zu prüfende Option in LH-01 bleiben?“
Owner-Antwort: **„In LH-01 entscheiden.“** C# bleibt eine Prüfoption.
Primärsprache und MSL-Status bleiben unknown; MSL bedeutet speichersichere Sprache.
OD-01-002 verlangt in LH-01 einen dokumentierten Sprach-/MSL-Entscheid im technischen
Plan mit Architekturentscheidung und Machbarkeitsnachweis vor Produktimplementierung.
.NET-Version, TUI-Framework, PowerShell-Mindestversion und Sitzungsintegration
bleiben getrennte technische Entscheidungen. Keine Workspace-/Tooling-Ableitung.

Thorsten commissions the approved source-refresh plan, ordinary LH-00 update,
coherent series evidence, complete distinct-agent review, targeted technical
reconciliation/Analyze and MergeAndSync with Admin-Bypass. Publish the prepared
issue after repository delivery; only then offer the improved authoring request.
No LH-01, product run, release or fleet rollout is started. The owner's language
answer is **“Decide in LH-01.”** C# is a candidate; primary language/MSL remain
unknown. MSL means memory-safe language. OD-01-002 requires a documented language
and memory-safety decision in the technical LH-01 plan, supported by an architecture
decision and feasibility evidence before implementation. Decide runtime/framework,
minimum PowerShell and session integration separately.

## Nachweis- und Änderungsgrenzen / Evidence and change boundaries

Basis: main `9e3c63851c820800955129015260e0d58d4e8a2b`, sauber und synchronisiert.
Alle 101 vorhandenen Receipt-/Request-/Review-Bindungen waren vor Änderung aktuell.
T001–T045 sind abgeschlossen (45/65); T046–T065 bleiben offen.
T045 ist die begrenzte Owner-Pilotfreigabe, keine Durchführung von LH-01/LH-02.
Die volle LH-00-Abnahme folgt nach deren gesondertem Abschluss, vor LH-03.

Der bisherige Intake ist erste Update-Quelle. Geänderte Guidance/Übersichten
und diese Entscheidung folgen als konkret benannte Quellen; weitere bisherige
Quellen bleiben gebunden. Intake-ID und normative FR-/AC-Anforderungen erhalten.
Vorgängerziel, Receipt, Quellen-Snapshots und Reviewtriplet bytegenau archivieren;
neue Receipt-/Vorgangs-IDs, nachvollziehbare Supersession und anderes Vollreview.
Die Serie erhält nur neue Hash-/Quellenbindungen, keine Mitglieder-/Kanten-/Rollen-
oder Statusänderung: Ready, LH-00 Eligible. Aktuelle Quelle und Review werden
nicht aus historischen Prüfungen abgeleitet; Mac-/T045-Nachweise behalten ihren
Gitstand. Keine technischen Schutzgates abschwächen und keine Risiken annehmen.

The clean synchronized base had 101 current bindings. Preserve completed T001–T045,
open T046–T065 and the existing limited owner permission. Full acceptance remains
after the separately completed pilots and before LH-03. Use the predecessor intake
first, then the named changed sources and this decision; retain unchanged inputs.
Archive predecessor bytes and review evidence, retain identity and all normative
FR/AC, and obtain a fresh complete distinct review. Renew series bindings only:
Ready/Eligible, unchanged members/edges/roles. Historical Mac/owner evidence remains
bound to its recorded Git state; no risk acceptance or weakened safeguards.

## Dokumentationsprüfung / Documentation audit

Alle Quellen des früheren Prompts sind geprüft. Unverändert und richtig bleiben
beide Constitution-Kopien, Authoring-Policy, 14er-Versionsmatrix, regulatorische
Anwendbarkeit und T045-Ownerrecord. Governance/Profil/Guidance/Umgebung/Bedienkonzept/
Reihenfolge/Sicherheitsübersicht erhalten gezielte aktuelle Einordnungen.
Bestehende Übersetzungsrestarbeiten bleiben offen; neue Abschnitte sind DE/EN B2.
Security-MSL-Einordnung nennt den nun vereinbarten Entscheidungsort LH-01.
Historische Issue-Entwürfe, Quellenmetadaten und eingefrorene Tests bleiben erhalten.
Die zentrale Registrierungsübernahme ist durch gemergten Home-Baseline-PR #320
belegt, Merge `2fa9414b20a0bd735fca6bfc67b0a1572ca17ba3`; spätere angewendete
Register-/Plattformabnahme bleibt offen. Keine zentralen Änderungen.

All earlier prompt sources were inspected. Both constitutions, authoring policy,
14-version matrix, regulatory applicability and T045 owner record remain correct
and unchanged. Targeted current introductions are updated; translation follow-ups
stay open and new sections are bilingual. The MSL note names LH-01 as the decision
stage. Historical issue drafts, source metadata and frozen tests are preserved.
Merged Home Baseline PR #320 proves central registration adoption; later applied
registry/platform acceptance stays open. No central changes are made.

UpdateRequired; sourceOnly. Leserpfad / Reader path: aktuelle Projektübersichten →
LH-00/Receipt/anderes Review → T045-Nachweis → aktualisiertes Issue #2 → eigener LH-01-Auftrag.
Wiedervorlage / Reassessment: Quellen-/Scope-/Technikänderung; offene Abnahmen bleiben offen.
