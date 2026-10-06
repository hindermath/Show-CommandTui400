# Create-Prüfung E01/E02 / Creation checks E01/E02

**Stand / Date:** 2026-10-06. **Basis:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Host:** Mac A, MacBook Air M2 (2023), Owner-Zuordnung / owner confirmation.
**Foundation-Review:** anderer Agent `/root/lh00_t012_foundation_review`, T012.
**Mapping:** FR-001–006, AC-00-001–003, SC-001, E01/E02.

## Auftrag und tatsächlich angewandter Weg / Request and actual skill application

Im vom T003/T017/T018-Auftrag freigegebenen synthetischen FIX-LH00-01-Bestand
wurde der installierte Agenten-Skill `speckit-intake-create` 0.3.7 tatsächlich
angewandt: Guidance/Policy/Profil gelesen, genau zwei geordnete Quellen gelesen,
striktes UTF-8 geprüft, Konflikte/Pflichtinhalt bewertet, ein Intake synthetisiert,
Schema-2.0-Receipt serialisiert und beide installierten Validatoren ausgeführt.
Die verwendeten Python-Aufrufe legen isolierte Kopien an und schreiben bereits
vom Agenten bewertete Texte/Receipts; sie sind kein Ersatz-Create-Kommando.
The installed agent skill was applied to the assigned synthetic sample: read
specified sources and governance, reject unsafe/incomplete input, synthesize one
intake and serialize its receipt, then run both installed validators. File-writing
helpers serialize the agent's decisions; they do not replace the authoring skill.

T018 wurde vor T017 ausgeführt. Bewusst unvollständige Negativfälle wurden
abgewiesen, keine Inhalte erfunden und keine Bereitschaft behauptet. Im positiven
Fall waren die fachlichen Entscheidungen geklärt; zusätzliche Fragen: 0,
protokollierte bestätigte Entscheidung: 1. Das ist kein automatischer semantischer
Validator-Test: Entscheidungen wurden vom Authoring-Agenten getroffen.
Negative authoring decisions preceded the positive case. Incomplete inputs were
rejected, not filled with invented decisions. The positive case needed no new
questions and records one confirmed scope decision. This is agent-applied
semantic authoring evidence, not an automated semantic-validation claim.

## T018: Einzelne Abweisungen / Separate rejections

| Fall / Case | Konkreter Blocker / Blocker | Ergebnis, Ziel/Receipt / Outcome | Owner Thorsten: nächste Aktion / Next action |
|---|---|---|---|
| missing-fields / IAD001 | Fachlicher Zweck, Scope und messbare Abnahme fehlen. / Purpose, scope and measurable acceptance are absent. | Blocked; 0/0 | Owner ergänzt Zweck, Scope und AC; dann eigener neuer Create-Auftrag. / Owner supplies purpose, scope and acceptance before new creation. |
| conflicting-sources / IAD002 | Quelle 2 fordert produktive TUI/Remote-Lieferung entgegen Quelle 1 und Testauftrag. / Source 2 conflicts with the local-only goal. | Blocked; 0/0 | Owner löst fachlichen Widerspruch; Reihenfolge hat keinen Vorrang. / Owner resolves the conflict; source order gives no precedence. |
| unreadable-source / IAD003 | Benannte sources/issue.md fehlt, FileNotFoundError. / Named source is absent. | Blocked; 0/0 | Owner stellt genau die fehlende Quelle bereit; kein zusätzlicher Scan. / Supply the exact named source without scanning for substitutes. |
| invalid-utf8 / IAD004 | Benannte Quelle enthält ungültiges UTF-8 und NUL; strikt abgewiesen. / Invalid UTF-8 and NUL are rejected. | Blocked; 0/0 | Owner liefert sichere vollständige UTF-8-Textquelle. / Supply a safe complete UTF-8 text source. |
| incomplete-profile / IAD005 | Profil enthält keine verbindliche Identität, Sprach-/Ablageregel oder Pflichtabschnitte. / Profile lacks identity, language, storage and required sections. | Blocked; 0/0 | Owner stellt vollständiges ausgewähltes Profil bereit; keinen Fallback erfinden. / Supply the selected complete profile; do not invent fallback rules. |

[negative-results.json](negative-results.json) bindet Eingangshashes und Zeitpunkt.
Keine negative Kopie schrieb ein Ziel, Receipt oder Folgeartefakt.
The result file binds input hashes and timestamps. Each negative copy produced
zero targets, receipts and downstream artifacts.

## T017: Gültige Einzel-Erstellung / Valid single creation

| Bindung / Binding | Wert / Value |
|---|---|
| Intake-ID | `b719969f-f174-423f-baf7-212102bbbafd` |
| Receipt-ID | `0e4bfa02-7b60-434b-9036-b76ed7589bd3` |
| Create-Vorgang / Operation | `b6127853-84a9-4b7b-9376-3eaa2168a181` |
| Ziel / Target | `intakes/LH-TEST.md`, exakt einmal / exactly one |
| Receipt | `specs/intake-authoring-receipts/lh-test.json`, exakt einmal / exactly one |
| Quellen / Sources | `sources/issue.md`, danach / then `sources/constraints.md` |
| Zielhash / Target hash | `388473bd27949e9d23831663c3e5d4462c3cc16d393893fbe5e81176bf3cc0cb` |
| Ergebnis / Outcome | ReadyForReview / Enabled; New; keine Update-Autorität / no update authority |
| Validatoren / Validators | Bash und PowerShell: Exit 0 / both passed |
| Folgeläufe / Downstream | 0 |

Beim noch unvollständigen Create-Kandidaten meldete der erste Bash-Check fehlende
Preset-Marker und N/A-Archivfelder. Diese Schemafehler wurden vor Abschluss
korrigiert; PowerShell nutzte anschließend die vorhandenen Parameter `-Receipt`
und `-Repo`. Kein vorhandenes aktives Ziel wurde durch Create überschrieben.
The unfinished candidate's first validation found missing schema markers and
N/A archive fields. They were corrected before completion. The installed PowerShell
Receipt/Repo interface was used; no pre-existing active intake was overwritten.

[create-results.json](create-results.json) enthält Befehle und Exitcodes.
Die gesamte [inaktive Fixture-Root](fixtures/create/intakes/LH-TEST.md) bleibt
mit benannten Quellen/Governance/Receipt reproduzierbar aufbewahrt. Sie ist kein
aktives Projekt-Lastenheft; die echte LH-00-Datei bleibt unverändert.
Commands/exits are recorded; the retained fixture root is inactive and reproducible.
The real project still has exactly one active intake, LH-00.

## Genau eine nächste Aktion / Exactly one next action

`$speckit-intake-review intakes/LH-TEST.md` wäre nach gesondertem Auftrag in der
isolierten Root auszuführen; hier wurde der Befehl nur berichtet. Ein Review
oder Spec/Autonomous-Lauf ist nicht Teil T017. T019–T045 brauchen den nächsten
Inkrementauftrag; volle Plattform-/Prozessabnahme bleibt später.
A separately commissioned fixture review would be next. It has only been reported,
not run. The second increment and full platform/process acceptance remain separate.
