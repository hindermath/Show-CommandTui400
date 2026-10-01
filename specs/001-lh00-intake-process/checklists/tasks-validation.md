# Aufgabenplanung prüfen / Validate task planning

**Stand / Date:** 2026-10-01. **Basis / Base:** `b2e1008`.
**Umfang / Scope:** lokale Erzeugung von [tasks.md](../tasks.md), keine Umsetzung.
Local generation of the task list, without implementation.

Dieser Bericht dokumentiert die Eigenprüfung des Tasks-Befehls. Er ist weder
ein unabhängiges Intake-Review noch eine praktische Prozessabnahme. Alle 65
Umsetzungsaufgaben bleiben offen. Bei späterer Ausführung neue Ergebnisse mit
Datum und aktuellem Commit ergänzen; diesen Erzeugungsstand erhalten.

This report records the task command's self-check. It is neither an independent
intake review nor practical process acceptance. All 65 implementation tasks remain
open. Append dated results with current commits during execution, preserving this record.

## Eingaben und Herkunft / Inputs and provenance

- [x] Projektlokales `speckit-tasks` angewandt; Pre-Hook-Konfiguration geprüft.
  `.specify/extensions.yml` fehlt: kein Pre-Hook auszuführen.
  / Applied the project task skill; no extension file means no pre-hook.
- [x] `bash .specify/scripts/bash/setup-tasks.sh --json` erfolgreich ausgeführt.
  Featureverzeichnis `specs/001-lh00-intake-process`; vorhandene Recherche,
  Datenmodell, Verträge und Quickstart zusätzlich zu Spec und Plan gelesen.
  Vorlage `.specify/templates/tasks-template.md` verwendet.
  / Setup succeeded; read required and available design inputs and used the task template.
- [x] Aktuellen fachlichen Intake und seinen Receipt mit den vorhandenen
  Bash-Validatoren geprüft: Receipt und Review jeweils PASS, Exitcode 0.
  / Existing Bash validators passed both the current receipt and review with exit code zero.

| Bindung / Binding | Wert / Value |
|---|---|
| Intake | `intakes/LH-00.md` |
| Intake-ID | `2296d99d-f099-4c4d-88f7-789581693eb0` |
| Receipt | `specs/intake-authoring-receipts/lh-00.json` |
| Receipt-ID / Authoring-Status | `db6043c8-2ddc-477c-a045-1c3621762660` / `ReadyForReview` |
| Review | `specs/intake-review-result.json` |
| Review-ID / Ergebnis / Outcome | `5eaad379-04dc-49e1-8060-86ad662611f0` / `Ready` |
| Zielhash / Target hash | `ab17634eda4fbb8e739b7b2807e3ebfa5cc10b700249072b395ef863e7ca0e6e` |

`Ready` bestätigt den geprüften fachlichen Stand; es beauftragt keine Umsetzung.
Ready confirms reviewed requirements; it does not commission implementation.

## Struktur und Abdeckung / Structure and coverage

- [x] 65 eindeutige, lückenlose IDs T001–T065; sämtliche Aufgaben offen.
  Checkboxformat, Story-Labels `[US1]`–`[US7]`, optionale `[P]`-Markierung,
  konkreter Dateipfad und DE/EN-Beschreibung pro Aufgabe geprüft.
  / Verified contiguous IDs, open checkboxes, story labels, parallel markers,
  concrete file paths and bilingual task descriptions.
- [x] Anzahl je Story US1–US7: 6, 4, 6, 5, 9, 8, 10; weitere 17 Aufgaben
  für Vorbereitung, Grundlagen und Abschluss. Bei Erstellung 18, nach der unten
  dokumentierten Korrektur 17 `[P]`-Aufgaben markieren
  unabhängige Arbeit nach ihren Vorgängern; gemeinsame Publikation bleibt seriell.
  / Verified story counts and shared tasks: eighteen parallel markers at creation,
  seventeen after the correction below, each conditional on its prerequisites.
- [x] Jede Story besitzt ein eigenes Prüfziel, konkrete Durchführung und
  Abschlussgrenze. Vorhandene Validatoren und isolierte Beispiele werden genutzt;
  kein zusätzlicher Testframework-Aufbau.
  / Each story has an independent test and checkpoint using existing validators and fixtures.
- [x] Zwölf Quell-FR sind auf alle 24 Spec-FR sowie AC-00-001–009,
  SC-001–009 und die Prozessfälle abgebildet. Foundation und Abschluss
  ordnen die übergreifenden Governance-Anforderungen zu.
  / Source requirements map to specification requirements, acceptance criteria,
  success criteria and process cases, with shared governance work assigned.
- [x] Mindestinkrement ist Vorbereitung + Grundlagen + US1. Die begrenzte
  Pilotentscheidung verlangt zusätzlich den Kernprozess US1–US5 und den
  tatsächlichen Nachweis auf dem benannten primären Mac.
  / The MVP is setup, foundation and US1; pilot permission requires the proven core flow.
- [x] Gestufte Abnahme aus IAD010 erhalten: LH-01 und danach LH-02 bleiben
  separat beauftragte Einzelpiloten außerhalb automatischer Serienauswahl.
  Volle Vier-Umgebungs-/A11Y-Abnahme folgt nach LH-02 und vor LH-03.
  / Preserved individually commissioned pilots and full acceptance after LH-02, before LH-03.
- [x] B-01-Quellenfix und neun native CI-Erfolge als vorhandene Evidence
  eingeordnet. Releases, zentrale Versionsübernahme und gezielte Installation
  stehen vor Serienaktivierung; Einzelprozess-Arbeit kann unabhängig fortschreiten.
  / Reused delivered source/CI evidence; release adoption and installation gate series activation.
- [x] Keine LH-01–LH-07-Funktion, Produkttechnikentscheidung, Release-Automation,
  Schemaänderung oder Abschwächung bestehender Abnahmekriterien eingeführt.
  / Added no downstream product scope, technical selection, release automation,
  schema change or weaker acceptance criteria.
- [x] Lokale Markdown-Verweise, verbleibende Vorlagenmarker und Whitespace geprüft.
  Bestehende Eingaben unverändert; ausschließlich die zwei neuen Planungsdateien.
  / Checked local links, template markers and whitespace; only two new planning files.
- [x] Post-Hook-Konfiguration erneut geprüft: `.specify/extensions.yml` fehlt;
  kein Post-Hook, Commit oder Remote-Schreibzugriff ausgeführt.
  / Rechecked hooks; no extension file, post-hook, commit or remote write.

## Nachprüfung von C1, I1 und I2 / Recheck of C1, I1 and I2

**Datum / Date:** 2026-10-01. **Basis / Base:** `f910e12`.
Der Owner beauftragte ausdrücklich die Korrektur der drei Analyze-Befunde.
Die folgende lokale Eigenprüfung ergänzt den ursprünglichen Erzeugungsnachweis.
The owner explicitly commissioned these three corrections. This local self-check
supplements the original generation record.

- [x] C1: Plan und T008 verwenden `docs/security/adr/s-adr-lh00-authority.md`;
  der bisherige abweichende Pfad ist in beiden Dateien entfernt.
  / Plan and T008 use the constitution's security-ADR directory consistently.
- [x] I1: T017 verlangt T018, T024 verlangt T025. Abhängigkeitstabelle und
  Parallelbeispiele stimmen überein; T024 trägt kein `[P]` mehr.
  / Explicit prerequisites, dependency table and parallel examples agree;
  T024 no longer has a parallel marker.
- [x] I2: D-09 kennzeichnet den ursprünglichen offenen CI-Stand als historisch.
  Der ergänzte Lieferstand enthält die erneut mit `gh pr view` geprüften drei
  gemergten PRs, exakten Heads/Merge-Commits und neun erfolgreichen nativen Jobs.
  / D-09 preserves history and adds reverified PR, commit and native-CI evidence.
- [x] Gezielte Struktur-, Verweis- und Diff-Prüfung bestanden: 65 offene,
  eindeutige IDs, unveränderte Story-Anzahlen, 17 Parallelmarker, vorhandene lokale
  Linkziele und `git diff --check`. Keine erneute vollständige Prozessabnahme.
  / Bounded structure, link and diff checks passed; no full process acceptance rerun.

## Dokumentationsauswirkung / Documentation impact

**Entscheidung / Decision:** `UpdateRequired`. **Owner:** Thorsten Hindermann.
**Klasse / Class:** Level-2-Aufgabenplanung. **Leser / Readers:** beauftragte
Autoren, Prüfer und Owner. **Sprache / Language:** DE zuerst/EN danach, etwa B2.
**Verteilung / Distribution:** `sourceOnly`, kein Home-Sync / no Home sync.
**Geänderte Quellen / Changed sources:** `tasks.md`, `plan.md`, `research.md`
und diese Prüfliste / this checklist.
**Leserpfad / Reader path:** Spec/Plan → Tasks → Verträge/Quickstart → Evidence.
**Wiedervorlage / Reassessment:** vor Umsetzung sowie bei Änderungen an Input,
Tooling, Autorität oder Abnahmegrenzen / before execution and after changed inputs,
tooling, authority or acceptance boundaries.

Die Prüfung bestätigt ausschließlich Konsistenz und Struktur der Aufgabenplanung.
Praktische Tests, unabhängige Reviews, Releases, Installation, Pilotläufe und volle
Abnahme sind zukünftige Arbeit. Ein Feature-Abschlussbericht wird jetzt nicht erzeugt.

Validation confirms task-plan consistency and structure only. Practical tests,
independent reviews, releases, installation, pilots and full acceptance remain
future work. No feature completion report is produced now.
