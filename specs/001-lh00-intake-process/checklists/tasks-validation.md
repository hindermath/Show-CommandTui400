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

## Vorbereitung IAD011 am 2026-10-05 / IAD011 preparation

Der Erzeugungs-/Korrekturstand vom 2026-10-01 oben bleibt historische Evidence.
Aktuelle Quellen, Receipt/Review, Werkzeugversionen, Git-Zustand und Startgrenzen
stehen im [Preflight-Nachweis](preflight-20261005.md). Spec, Plan, Tasks und
betroffene Governance-/Collection-Verträge wurden gezielt an die gelieferten
fünf Preset-Versionen und Security-/Architecture-Regeln angepasst. Vorhandene
B-01-Releases/Pins/Installation werden wiederverwendet; fehlende Lifecycle-/Review-/
Owner-Nachweise bleiben ausdrücklich offen. Die ursprünglichen 65 offenen
Task-IDs, 17 Parallelmarker und gestufte Abnahme sind erhalten. Keine neue
Tasks-Generierung, Implementierung, Commit oder Remote-Schreibaktion.

The 2026-10-01 records above remain historical. Current receipt/review, versions,
Git state and start boundaries are in the linked preflight. Reconcile existing
spec/plan/tasks and affected contracts with delivered versions and governance;
reuse B-01 adoption while retaining missing lifecycle/review/owner evidence.
All 65 open task IDs, 17 parallel markers and staged acceptance remain intact.
No task regeneration, implementation, commit or remote write occurred.

Aktuelle Analyze-Eigenprüfung: 24 FR + neun SC mit 100 % geplanter Task-Abdeckung;
keine offenen Befunde, kein nicht zugeordneter Task. Prerequisites, Verweise und
Diff bestanden. Aktueller unabhängiger Intake-Prüfer steht im separaten Ergebnis;
Analyze bleibt Eigenprüfung der technischen Artefakte, keine Owner-Abnahme.
Preflight bleibt wegen Routing-/Statistikbefund Blocked für Implementierung.

Current Analyze self-check: full planning coverage for 24 FR and nine SC,
no findings or unmapped task. Prerequisites, links and diff pass. The separate
result names the independent intake reviewer; Analyze remains a technical
self-check rather than owner acceptance. Routing/statistics keep implementation
preflight Blocked.

## Quellenabgleich IAD012 / Source reconciliation IAD012

Die obigen datierten Prüfungen und Anwendbarkeitszeilen behalten ihren Kontext.
Authoring 0.3.7 ist nach PR #26 aktuell; [neuer Preflight](preflight-20261005-v037.md)
führt heutiges Receipt, anderes Review, gezielte Analyse und Startchecks. Dieser
Abgleich ändert keine Anforderungen, geplante Abdeckung, Tasks oder Abnahmegates.
Alle Umsetzungstasks bleiben offen; die Lieferung gilt nur für Vorbereitung.

Preserve the context of earlier dated checks and applicability rows. Authoring
0.3.7 is current after PR #26. The fresh preflight records receipt, independent
review, targeted analysis and start checks. Reconciliation changes no requirements,
planned coverage, tasks or acceptance gates. Delivery covers preparation only.

## Erneute Startvorbereitung am 2026-10-06 / Renewed start preparation

**Basis / Base:** `be0d590e7ec9321f1eb0ea52f14a7dacfffa1ccd`, gemergter PR #27.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex-Hauptagent / main agent.

Der Owner beauftragte den aktualisierten Vorbereitungsplan: betroffene Startchecks
erneuern, nur bei neuer Quellenabweichung Intake und anderes Review aktualisieren,
nur bei fachlicher Auswirkung technische Artefakte abgleichen und diesen Nachweis
fortschreiben. Schreibumfang ist diese Aufgabenvalidierung. Kein Commit, Push,
Remote-Schreibzugriff, Routing-Refresh, Installation oder Implementierungsstart.
Die folgenden Ergebnisse ergänzen die datierten Vorgänger; deren Aussagen bleiben
historisch. T001–T065 werden durch diese Vorbereitung nicht als erledigt markiert.

The owner commissioned the updated preparation plan: refresh affected start checks,
update intake and independent review only after new source drift, reconcile technical
artefacts only after a relevant change, and append this evidence. Writes are limited
to this task-validation record. No commit, push, remote write, routing refresh,
installation or implementation starts. Preserve dated predecessor evidence and keep
all implementation tasks open.

### Tatsächlich geprüfter Stand / Observed state

Die folgenden Basischecks liefen vor dieser Nachweiserweiterung. Danach wurden
alle 59 Bindungen, drei lokale Verweise, Whitespace und der exakte Schreibumfang
erneut geprüft: PASS, nur diese Datei verändert. Der neue Dokumentationsumfang
geht beim nächsten autorisierten Renderlauf zusätzlich in die Statistik ein.

Base checks below ran before this evidence append. Afterwards, all fifty-nine
bindings, three local links, whitespace and the exact one-file write scope passed
revalidation. The next authorized render also includes this new documentation.

| Prüfung / Check | Ergebnis / Outcome | Nachweis und Grenze / Evidence and boundary |
|---|---|---|
| Git / Git | PASS | Vor Nachweiserweiterung sauberer `main`, Upstream `0/0`; `git ls-remote` bestätigt denselben Remote-Head. Danach nur dieser beauftragte Dokumentationsdiff. / Clean synchronized main before this evidence append; only the commissioned documentation diff afterwards. |
| Intake / Receipt | PASS, Exit 0 | Bash-Validator: Receipt `c515439e-cd09-4e44-8fe2-ac6135e21e3f`, ReadyForReview, 15 Quellen. / Current receipt, fifteen sources. |
| Unabhängiges Review / Independent review | PASS, Exit 0 | Bash-Validator: Single, `45881080-479a-47f9-9a62-e728b3d70244`, Ready; keine Befunde, Fragen oder akzeptierten Risiken. / No findings, questions or accepted risks. |
| Rekursive Bindungen / Recursive bindings | PASS | Alle 59 Ziel-/Quellen-/Governance-/Request-/Reviewbindungen aktuell, keine Abweichung. / All fifty-nine bindings current, no drift. |
| Guidance und Constitution / Guidance and constitution | PASS | Fünf Guidance-Flächen bytegleich, beide Constitution-Kopien bytegleich. / Exact byte parity across both sets. |
| Aufgaben und Checklisten / Tasks and checklists | PASS | 65 offene, eindeutige Tasks; 17 Parallelmarker erhalten. Die abgeschlossenen Planungschecklisten bleiben keine praktische Abnahme. / Open task identities and parallel markers preserved; planning checks are not process acceptance. |
| Codex-Routing / Codex routing | Aligned, Exit 0 | Lesender Status: Codex CLI 0.160.0, Enumerate, sieben verfügbare Modelle, vier Rollen gültig. Kein Refresh; acht Modelle im Bericht vom 5. Oktober bleiben historisch. / Read-only status, seven available models and four valid roles; earlier inventory remains historical. |
| Preset-Matrix / Preset matrix | PASS, Exit 0 | Check-only: genau 14 installierte Presets entsprechen der Projektmatrix. / Exact installed project matrix. |
| Agentenflächen / Agent surfaces | PASS, Exit 0 | Bestehender Paritätstest: vier Tests erfolgreich. / Four existing parity tests pass. |
| Secret-Scan / Secret scan | PASS, Exit 0 | High 0, Medium 0; fünf bekannte Low-Hinweise zu Agentenverzeichnissen. Kein Secret-Befund im Git-Diff. / No high or medium findings; known directory notices only. |
| Statistik, aktuelles Datum / Statistics, current date | DRIFT, Exit 1 | Unveränderter Quellstand, aber Renderer erwartet den 6. statt 5. Oktober in Europe/Berlin. Dry-run zeigt ausschließlich Tagesfenster, Dienstagzelle und zugehörige Textalternativen verändert. / Date rollover only in the initial clean-tree preview. |
| Statistik, damaliges Datum / Statistics, historical date | CURRENT, Exit 0 | Separater lesender Check mit SOURCE_DATE_EPOCH des Quellcommits `cb0167ea3286` reproduziert den früheren Stand. Dieser historische PASS ersetzt den heutigen DRIFT nicht. / Reproduces the former date without treating it as current readiness. |
| Homogenität / Homogeneity | FAIL, Exit 1 | Genau ein Fehler: aktueller Statistikdrift; zusätzlicher bekannter lokaler STATS.md-Sprachhinweis. / One failure from statistics drift plus the existing local language warning. |
| CI auf main / Main CI | PASS | Alle drei Workflows am Basiscommit bestanden; Links unten. Wiederverwendung der unveränderten technischen Evidence, keine Produktabnahme. / Reuse successful unchanged tooling evidence, without product acceptance. |

CI: [PowerShell-Analyse / analysis](https://github.com/hindermath/Show-CommandTui400/actions/runs/37374096518),
[Level-2-Einrichtung / setup](https://github.com/hindermath/Show-CommandTui400/actions/runs/37374096521),
[Maintenance-TUI](https://github.com/hindermath/Show-CommandTui400/actions/runs/37374096663).

Werkzeuge tatsächlich verfügbar: Git 2.54.0, Bash 5.3.20, Python 3.14.8,
PowerShell 7.6.6, Spec Kit CLI 0.12.8 (eigene Python-Laufzeit 3.11.14),
PSScriptAnalyzer 1.25.0, Pandoc 3.11, Typst 0.15.1 und VS-Code-Erweiterung
myriad-dreamin.tinymist 0.15.8. Host: macOS 27.0.1. Dies definiert keine
Produkt-Mindestversion und keine Mac-A/B-Abnahme.

The listed tools and versions are locally available on macOS 27.0.1. Spec Kit's
own Python runtime differs from the python3 executable used by validators.
These observations set no product minimum and prove no Mac A/B acceptance.

### Auswirkungen und nächste Grenze / Impact and next boundary

Keine neue gebundene Quellenabweichung: kein erneutes Intake-Update oder Review
erforderlich. Fachlicher Umfang, Spec, Plan und Tasks bleiben unverändert; der
gültige Analyze-Nachweis aus PR #27 wird wiederverwendet. Kein weiterer Analyze-Lauf
für den reinen Prüfbericht. Die heutige Vorbereitung bleibt wegen des aktuellen
Statistik-/Homogenitätsfehlers für den Implementierungsstart **Blocked**.

Zum Schließen dieses Befunds braucht es einen passenden lokalen Commit-/Renderer-
Auftrag: zuerst den Nachweis committen, dann auf sauberem Arbeitsbaum mit dem
bestehenden Renderer die Statistik erzeugen, Check-only und Homogenität prüfen
und die generierte Statistik committen. Keine handgemachten Zahlen oder Änderung
der Methodik. Diese Schritte sind in diesem Vorbereitungsauftrag nicht ausgeführt.
Anschließend kann ein eigener LH-00-Implementierungsauftrag folgen. Die vier
vollständigen Plattformnachweise, A11Y, Übersetzungen, Registry-/Seriennachweise,
LH-01-/LH-02-Piloten und vollständige Abnahme nach LH-02 vor LH-03 bleiben offen.

No newly changed bound source requires another intake update or review. Scope,
specification, plan and tasks are unchanged; reuse PR #27's valid analysis instead
of rerunning it for this check report. Implementation preflight remains **Blocked**
by current statistics and homogeneity failure. Closure needs matching local
commit/renderer authority: commit this source record, render on a clean tree,
verify check-only and homogeneity, then commit generated statistics. Do not edit
numbers or methodology manually. These actions were not performed here. A separate
LH-00 implementation request may follow; full platform, accessibility, translation,
registry/series, pilot and final acceptance evidence remains open.

**Dokumentationsauswirkung / Documentation impact:** UpdateRequired; sourceOnly;
DE zuerst/EN danach, etwa B2; Owner Thorsten. Leserpfad / reader path:
Tasks → dieser Startnachweis / this start record → aktueller Receipt und Review / current receipt and review.
Wiedervorlage / reassessment: nach Statistikabschluss und vor eigenem Implementierungsstart / after statistics closure and before separate implementation.

### Nachfolgender Lieferauftrag / Subsequent delivery authority

Der Owner beauftragte nach Sichtung dieses Nachweises ausdrücklich: Prüfbericht
committen, Statistik rendern und prüfen, generierte Statistik committen sowie
Push, PR, MergeAndSync mit Admin-Bypass. Der ursprüngliche lesende Auftrag und
sein Blocked-Befund oben behalten ihren damaligen Kontext. Die Lieferung umfasst
nur diesen Nachweis, den chronologischen Ledger und dessen generierten Block.
Admin-Bypass ersetzt keine technische Prüfung. Keine Implementierung, reale
Serienaktivierung, weiteren Intakes, Installation oder Flottenänderung.

Prüfreihenfolge: exakten Quelländerungssatz validieren und committen; auf sauberem
Arbeitsbaum Renderer-Vorschau und Schreiblauf ausführen; Check-only und Homogenität
mit dem aktuellen Datum prüfen; exakt die generierte Statistik committen. Der
zugehörige PR dokumentiert tatsächliche Ergebnisse und bindet die finale CI an
seinen Head. Erst erfolgreicher aktueller Check-only und fehlerfreie Homogenität
schließen den Statistikbefund; der historische Reproduzierbarkeitscheck genügt nicht.
Ein eigener LH-00-Implementierungsauftrag und dessen T001-Startprüfung bleiben nötig.

After reading this evidence, the owner explicitly commissioned source commit,
statistics rendering/verification, generated-statistics commit, push, PR and
MergeAndSync with admin bypass. Preserve the earlier read-only authority and
Blocked result as historical. Deliver only this record, its chronological ledger
and generated block. Admin bypass replaces no technical check. No implementation,
live series activation, other intakes, installation or fleet change is authorized.

Validate and commit the exact source set, preview and render on a clean tree,
verify current-date check-only and homogeneity, then commit only generated output.
The associated PR records observed results and binds final CI to its head. Only
current successful checks close the statistics finding; historical reproducibility
is insufficient. Separate LH-00 implementation authority and a fresh T001 remain required.
