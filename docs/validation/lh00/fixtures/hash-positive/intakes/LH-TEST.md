<!-- intake-authoring:begin -->
# Test-Lastenheft FIX-LH00-01 / Test intake FIX-LH00-01

**Intake-ID:** `b719969f-f174-423f-baf7-212102bbbafd`. **Stand / Date:** 2026-10-06.
**Status:** ReadyForReview. **Profil / Profile:** show-commandtui400-de-en.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Testdaten / Test data:** Isoliert und inaktiv; kein zusätzliches Projekt-Lastenheft.
Isolated inactive data; not an additional active project intake.

## Identität und Zielgruppe / Identity and audience

Ein Intake ist ein fachliches Lastenheft; ein Receipt ist sein maschinenlesbarer
Herkunftsnachweis mit Prüfsummen (Hashes). Zielgruppe sind beauftragte Autoren
mit Grundkenntnissen von Dateien und Terminal; Spec-Kit-Erfahrung ist nicht nötig.
Dieses Beispiel gehört allein zum isolierten LH-00-Prüfbestand E01/E02.
An intake records requirements; a receipt records machine-readable provenance
and content hashes. Authors need basic file/terminal knowledge, not prior Spec
Kit experience. This example belongs only to isolated LH-00 evidence E01/E02.

## Zweck / Purpose

Die Erstellung eines vollständigen Lastenhefts samt Herkunftsnachweis soll
an einem synthetischen Beispiel nachvollziehbar geprüft werden.
Demonstrate traceable creation of one complete intake and its provenance receipt
using a synthetic example.

## Ist- und Zielzustand / Current and target state

Ist: Zwei benannte Quellen beschreiben das Beispiel. Ziel: genau ein DE/EN-
Test-Intake mit Schema-2.0-Receipt und überprüfbaren Quellen-/Zielhashes.
Current: two named sources describe the example. Target: one bilingual test
intake with a schema-2.0 receipt and verifiable source/target hashes.

## Umfang und Nicht-Ziele / Scope and non-goals

Scope sind lokale Textdateien in der freigegebenen isolierten Kopie. Nicht-Ziele
sind Produktfunktionen, Implementierung, Reviews, Remote-Lieferung und reale
Serienverwaltung. Das gültige Projekt-LH-00 wird nicht geändert.
Scope is local text files within the assigned isolated copy. Product functions,
implementation, review, remote delivery and real series management are excluded.
The active project LH-00 is unchanged.

## Anforderungen / Requirements

- FR-FIX-001: Das Beispiel muss genau ein DE/EN-Lastenheft erzeugen.
- FR-FIX-002: Der Receipt muss die zwei benannten Quellen in ihrer Reihenfolge binden.
- FR-FIX-003: Die Folgeprompts müssen inaktive Vorlagen bleiben.

- FR-FIX-001: The example must create exactly one DE/EN intake.
- FR-FIX-002: The receipt must bind the two named sources in supplied order.
- FR-FIX-003: Follow-up prompts must remain inactive templates.

## Qualität und Governance / Quality and governance

Deutsch zuerst, äquivalentes Englisch danach, etwa CEFR B2. Begriffe werden bei
Erstgebrauch erklärt. Zustände, Abhängigkeiten und nächste Aktion stehen vollständig
in Text; Farbe und Diagramme sind für dieses lineare Beispiel unnötig. WCAG 2.2 AA
wird soweit passend berücksichtigt, einschließlich Tastatur, Screenreader,
Braille und Textbrowser. Praktische Hilfsmitteltests sind durch Textstruktur nicht
bewiesen. NIST SSDF und CWE Top 25 gelten. Profile, sichere Quellen, striktes UTF-8,
Hashbindung und Überschreibschutz bleiben verbindlich. Keine eigene Produkttechnik
oder Mindestversion wird festgelegt. Regulatorische Produkt-/Werkzeug-/Organisations-
rollen bleiben im Projekt Open und sind keine rechtliche Ausnahme.
German comes first with equivalent B2 English. Explain terms and express every
state, dependency and next action in text. No diagram/color is needed for this
linear example. Apply relevant WCAG 2.2 AA, considering keyboard, screen readers,
Braille and text browsers. Text structure does not prove assistive field testing.
SSDF/CWE, strict UTF-8, safe sources, hash binding and overwrite protection remain
binding. Product technology and minimum versions remain undecided. Open project
regulatory roles are not legal exemptions.

Thorsten beauftragt und entscheidet fachlich, Codex erstellt, ein anderer Agent
oder Mensch prüft später unabhängig. ReadyForReview bedeutet nur bereit für ein
separates Review, kein Ready und keine Ausführungsfreigabe. Collection bezeichnet
eine verwaltete Sammlung; das Beispiel bleibt eigenständig außerhalb einer Serie.
The owner commissions and decides; Codex authors; a different agent or person
reviews later. ReadyForReview is authoring readiness, not review readiness or
execution authority. A collection is a managed set; this example has no series.

## Abhängigkeiten / Dependencies

Vorhandene sichere Quellen, gültiges Profil und zwei installierte Receipt-
Validatoren sind erforderlich. Die Quellenreihenfolge verleiht keinen Vorrang.
Dieses Beispiel ist keine neue LH-01–LH-07-Anforderung.
Safe named sources, a valid profile and both installed receipt validators are
required. Source order does not grant precedence. No LH-01–LH-07 requirement is added.

## Risiken / Risks

R-FIX-001: Leser könnten Authoring-Bereitschaft als Ausführungsfreigabe verstehen.
Gegenmaßnahme: Status und nächsten getrennten Auftrag nennen. Owner Thorsten;
Trigger neuer Folgeauftrag oder 2026-10-12. Kein akzeptiertes Restrisiko behauptet.
R-FIX-001: Readers may mistake authoring readiness for execution authority.
Mitigation: state the separate status and next request. Owner Thorsten;
reassess on a new downstream request or 2026-10-12. No risk acceptance is claimed.

## Artefakte und Nachweise / Artifacts and evidence

Erwartet sind `intakes/LH-TEST.md` und
`specs/intake-authoring-receipts/lh-test.json` innerhalb der isolierten Kopie.
Nachweis E01: ein Ziel/Receipt, geordnete Quellen, Zielhash und beide Validatoren.
E02: negative separate Kopien blockieren fehlenden Inhalt, Konflikte, unlesbare
Quellen oder unvollständiges Profil vor dem positiven Fall. Beides wird im
bestehenden Projektbericht `docs/validation/lh00/create.md` belegt.
Expected artifacts are the exact test target and receipt inside the isolated
copy. E01 records counts, ordered sources, target hash and both validators.
E02 records blocked negative copies before the positive case. The project report
records both; neither artifact is published as a second active project intake.

## Messbare Abnahme / Measurable acceptance

- AC-FIX-001: Genau ein Ziel und Receipt bestehen mit allen Pflichtabschnitten.
- AC-FIX-002: Bash und PowerShell akzeptieren den Receipt mit aktuellen Bindungen.
- AC-FIX-003: Keine Review-/Specify-/Autonomous- oder Remote-Aktion wird ausgeführt.

- AC-FIX-001: Exactly one target and receipt contain every required section.
- AC-FIX-002: Both Bash and PowerShell accept the receipt's current bindings.
- AC-FIX-003: No review, specification, autonomous or remote action is executed.

## Annahmen, Entscheidungen und offene Fragen / Assumptions, decisions and questions

Annahmen: synthetische sichere Daten, genau diese freie Root und gültige Governance.
OD-FIX-001: Der T001–T018-Auftrag autorisiert den isolierten Test und keine Folgeaktion.
OD-FIX-002: Beide Sprachen teilen eine Identität; die zwei Quellen widersprechen sich nicht.
Es bestehen keine offenen fachlichen Entscheidungen im positiven Beispiel.
Assume synthetic safe data, this free root and valid governance.
OD-FIX-001: T001–T018 authorizes this isolated creation and no downstream action.
OD-FIX-002: Both languages share one identity; the two sources do not conflict.
No material decision is open in this positive example.

## Quellen / Sources

1. `sources/issue.md`: synthetisches FIX-LH00-01 / synthetic sample issue.
2. `sources/constraints.md`: begrenzte Governance-/Nachweisregeln / bounded controls.

<!-- intake-authoring:prompts -->
<!-- spec-kit-command-id: speckit.specify -->
## Folgeprompt Specify / Follow-up Specify prompt

Vorlage für einen späteren gesonderten Auftrag, heute nicht ausführen.
Template for a separate future request; do not execute now.

```text
$speckit-specify intakes/LH-TEST.md
Nutze ausschließlich dieses isolierte Test-Intake mit Profil show-commandtui400-de-en.
Prüfe zuvor ein aktuelles unabhängiges Review und den Receipt.
Erzeuge nur eine technische Spezifikation, DE zuerst/EN danach.
Keine Implementierung, Commits, Remote-Writes oder Produktanforderungen ergänzen.
Use only this isolated test intake and profile; require a current independent
review and receipt first. Specify only; no implementation, commits, remote writes
or additional product requirements. German first, then equivalent English.
```

<!-- spec-kit-command-id: speckit.autonomous -->
## Folgeprompt Autonomous / Follow-up Autonomous prompt

Vorlage, kein aktueller Auftrag; gültiges anderes Review und neue Autorität nötig.
Template, not a current request; requires fresh independent review and new authority.

```text
$speckit-autonomous intakes/LH-TEST.md
Profil show-commandtui400-de-en; DeliveryMode LocalImplementation.
Nur bei gesondertem ausdrücklichem Auftrag und aktuellen Receipt-/Review-Nachweisen.
Begrenze die Arbeit auf dieses isolierte Beispiel. Keine Commits, Pushes,
Remote-Writes, Produktfeatures oder reale Serienaktivierung.
Use only this isolated example under a separate explicit request and current
receipt/review evidence. No commits, pushes, remote writes, product features or
real series activation. LocalImplementation only; German first, then English.
```

## Nächste Aktion / Next action

`$speckit-intake-review intakes/LH-TEST.md` in derselben isolierten Kopie nach
neuem Auftrag. Heute lediglich berichten; nicht ausführen.
A separate commissioned intake review in the same isolated copy is next.
Report the command only; do not execute it now.

<!-- intake-authoring:end -->
