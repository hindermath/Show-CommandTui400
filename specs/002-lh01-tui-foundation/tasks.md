# Aufgaben: LH-01 — TUI-Grundlage / Tasks: LH-01 — TUI foundation

**Datum / Date:** 2026-10-09. **Feature:** `002-lh01-tui-foundation`.
**Profil / Profile:** `show-commandtui400-de-en`. **Owner:** Thorsten Hindermann.
**Status:** Aufgabenplanung; alle Aufgaben offen / task planning; every task open.

## Grundlage und Arbeitsgrenzen / Inputs and work boundaries

Technische Quellen sind [Plan](plan.md), [Spezifikation](spec.md),
[Datenmodell](data-model.md), [Recherche](research.md), die
[Verträge](contracts/cmdlet-session.md), [Prüfanleitung](quickstart.md),
[Entscheidungen](feasibility/decisions.md) und das
[unabhängige technische Review](feasibility/independent-review.md).
Fachlicher Input bleibt ausschließlich [LH-01](../../intakes/LH-01.md) mit
[Receipt](../intake-authoring-receipts/lh-01.json) und
[anderem Intake-Review](../intake-reviews/lh-01/report.md).
D01–D07 und der erste Restoreversuch sind historische Quellen; die korrigierte
Auswahl D08 gilt. Die 13 synthetischen PTY-Fälle und 67 geprüften Bedingungen
belegen die Fixture, keine noch nicht vorhandene Produktimplementierung.

Use the linked design documents and corrected D08 selection. LH-01 is the only
domain input. Historical research and failed restoration retain their context.
The 13 synthetic PTY cases and 67 observed assertions prove the fixture, not a
future product implementation. Intake review and technical review are distinct.

Dieser Auftrag erzeugt nur diese Aufgabenliste. Er startet keine Aufgabe,
Implementierung, Serienmutation, Installation, Veröffentlichung oder Lieferung.
Ein späterer Auftrag muss den Aufgabenbereich und Schreibumfang nennen. Aufgaben
für zentrale Register oder native CI benötigen passende Autorität für das andere
Repository beziehungsweise Remote-Ziel. Eine offene Voraussetzung darf nicht als
erledigt angekreuzt werden, nur weil ein Vorschlag erstellt wurde.

This request creates the task list only. A later request must authorize execution
and its write scope. Central registry work and native CI need authority for their
repository or remote target. A proposal does not complete an applied prerequisite.
No installation, release or automatic follow-up is implied.

LH-01 bleibt Einzelpilot außerhalb automatischer Serienauswahl. T045 aus LH-00
ist eine begrenzte Ownerfreigabe, kein abgeschlossener LH-00-Prozess.
LH-02 braucht eigenen Auftrag, gültiges Intake/anderes Review und fachlichen
LH-01-Abschluss. Vollständige LH-00-Abnahme folgt nach LH-02, vor LH-03.
Keine Suche, Modulauflösung, Parameterformulare, Completion, Aufrufvorschau,
Zielausführung, Persistenz oder Geräteadapter aus LH-02–LH-07 ergänzen.

Preserve the standalone pilot, open LH-00 and separate LH-02 authority. Full
LH-00 acceptance remains after LH-02 and before LH-03. Later feature functions
are excluded; contextual actions remain visibly unavailable.

## Begriffe, Format und Pfade / Terms, format and paths

Ein Gate ist eine Voraussetzung; Evidence ist ein nachvollziehbarer Prüfnachweis.
MSL bedeutet speichersichere Sprache für eigenen Code. ADR ist ein begründetes
Architekturprotokoll, S-ADR dessen Sicherheitsvariante. A11Y bedeutet
Barrierefreiheit. FR/AC/QG/OD sind die bestehenden Anforderungs-, Abnahme-,
Qualitäts- und Entscheidungskennungen. `[US1]`–`[US3]` entsprechen US-01–US-03.
`[P]` kennzeichnet nur konfliktfreie Aufgaben mit bereits erfüllten Voraussetzungen;
die Kennzeichnung ist kein Auftrag zur Agentendelegation.

A gate is a prerequisite; evidence records an attributable check. MSL describes
memory safety of own code. ADR/S-ADR record architecture/security decisions.
FR/AC/QG/OD retain existing requirement IDs. Story labels map to the three user
stories. `[P]` allows parallel work only after prerequisites, in different files;
it does not authorize delegation.

Die fünf Guidance-Flächen sind `AGENTS.md`, `CLAUDE.md`, `GEMINI.md`,
`.github/copilot-instructions.md` und `.github/agents/copilot-instructions.md`.
Zentrale Projektzeile und private operative Registry getrennt nachweisen; keine
privaten Registrydaten oder Rechnerpfade veröffentlichen. / Verify all five shared
guidance surfaces and distinguish the central row from the private local registry.

Alle Pfade sind relativ zur Repository-Wurzel. Genannte neue Produktdateien sind
geplante Zielpfade und werden jetzt nicht erzeugt. `docs/validation/lh01/` sammelt
spätere Nachweise, `docs/security/` und `docs/architecture/` deren kanonische
Fachnachweise. DE steht in jeder Aufgabe vor EN; jede ID erscheint genau einmal.
Tests sind aufgenommen, weil Spec E01-01–07 und Plan ausdrücklich prüfbare
Verträge und Negativfälle verlangen. Keine beliebigen Leistungsgrenzen hinzufügen.

Paths are repository-relative planned targets. Evidence remains at its canonical
security/architecture location and is linked by validation records. Each task has
German first and English second, with one checklist ID. Tests implement explicit
specification evidence cases, without invented performance thresholds.

## Phase 1 — Startvoraussetzungen / Start prerequisites

**Ziel:** Entscheidungen in Governance überführen, Herkunft erneuern und sichere
Architektur vor Produktcode prüfen. **Prüfung:** T017 ist nur bestanden, wenn alle
vorgelagerten startrelevanten Bedingungen belegt sind.

**Goal:** Align governance and provenance and review secure architecture before
product code. T017 passes only with evidenced prerequisite completion.

- [ ] T001 Aktuellen Git-Stand, LH-00-Receipt/Ready-Review/T045, LH-01-Receipt/Ready-Review, Modell-Routingstatus, Werkzeuge, exakte 14-Preset-Matrix und beauftragten Schreibumfang in `docs/validation/lh01/start-readiness.md` erfassen; Drift zuerst bewerten, Refresh nur mit passender Autorität. / Record current Git, provenance, T045, routing, tools, fourteen presets and authorized writes; assess drift before changes and refresh only with authority.
- [ ] T002 Die bereits gewählte Sprache C#14 und MSL-Begründung aus OD-01-002/F01–07 samt Alternativen und Grenzen des eigenen managed Codes in `docs/architecture/decisions/002-lh01-language-msl.md` festhalten; keine erneute freie Kandidatenwahl. / Record the selected language and own-code memory safety, alternatives and native limits from existing proof.
- [ ] T003 [P] Host-.NET10/net10.0 und nicht mitverteiltes Host-SMA in `docs/architecture/decisions/003-lh01-runtime.md` begründen; keine zweite Runtime oder PowerShell-Sitzung laden. / Record host runtime and non-distributed host SMA, without a second runtime or session.
- [ ] T004 [P] Terminal.Gui2.5.0 mit explizitem dotnet-Treiber, ausgeschlossenen ANSI-Fallback und nativen Vertrauensgrenzen in `docs/architecture/decisions/004-lh01-framework.md` begründen; Onigwrap-Inventar nicht als Aktivierung ausgeben. / Record explicit driver selection, excluded fallback and native boundaries; inventory does not prove native execution.
- [ ] T005 [P] Gewählte Mindestversion PowerShell7.6.4 und belegte Patch-/Hostgrenzen in `docs/architecture/decisions/005-lh01-powershell-minimum.md` festhalten; Container-Scope und Mac-UI7.6.6 getrennt darstellen. / Record the selected minimum and separate container scope from Mac UI patch evidence.
- [ ] T006 [P] In-process PSCmdlet, sichtbare Scopegrenzen, Capabilityprüfung vor Änderungen, Terminal-Lease, StopProcessing und externe Killgrenzen in `docs/architecture/decisions/006-lh01-session-terminal.md` begründen; Darwin-ABI nicht auf andere OS übertragen. / Record session and terminal boundaries, lease/cancellation and external termination limits, without copying Darwin ABI to other systems.
- [ ] T007 Nach T002–T006 Kontext-, Baustein-, Laufzeit- und Deployment-Sicht, Schnittstellen, Qualitätsszenarien, Risiken und technische Schulden in `docs/architecture/lh01-tui-foundation.md` sowie prüfbare Sicherheitsszenarien in `docs/security/security-quality-scenarios-lh01.md` erstellen; Aktionsmodell vom Framework trennen. / After the ADRs, document views, interfaces, quality scenarios and risks with framework-independent actions.
- [ ] T008 Nach T002–T006 `docs/security/msl-applicability.md`, `docs/security/secure-coding-language-rules.md` und `docs/security/security-checklist.md` um LH-01 erweitern; eigene managed Sicherheit, Eingaben, Interop/OS/Runtime und sichere Fehler getrennt bewerten, LH-00-Historie erhalten. / Extend existing security evidence for LH-01 with separate managed/native and safe input/error rules, preserving history.
- [ ] T009 Datenflüsse ohne private Dumps/Persistenz, Entwicklungs-KI, Logs und regulatorische Rollen in `docs/security/regulatory-applicability.md` konkretisieren; DS-GVO/KI-VO/CRA/NIS2/DORA je Produkt/Werkzeuge/Organisation führen, Unknown als Open mit Thorsten, Aktion und Frist belassen. / Update the existing regulatory index by scope, with privacy flows and attributable Open items; no blanket private-project exemption or duplicate legal decision.
- [ ] T010 Nach T007–T009 STRIDE/CIA-Bedrohungsmodell, maßgebliche CWE-/CAPEC-Fälle und zwei getrennte Schutzschichten Aktions-Whitelist/Kontextprüfung in `docs/security/threat-model.md` ergänzen; Risiken und sichere Rückkehr konkret verifizieren. / Extend the threat model with independent action/context protection, relevant weakness/attack references and explicit restoration risks.
- [ ] T011 Nach T010 Sicherheitskonzepte in `docs/security/arc42-section-8-lh01.md` und S-ADR in `docs/security/adr/s-adr-lh01-session-display.md` erstellen; Steuerzeichen, private Kontextdaten, Capabilitygrenze, Fehler und Abhängigkeiten behandeln. / Record cross-cutting security and its ADR at the required security ADR path.
- [ ] T012 Nach T004 Abhängigkeiten/Lockfiles/Registries/Lizenzen/native Assets in `docs/security/dependency-audit.md` und `docs/security/supply-chain-evidence.md` scopebezogen bewerten; SAMM in `docs/security/samm-assessment.md`, OpenSSF in `docs/security/openssf-assessment.md` und ASVS/AI-SBOM/ZeroTrust/C3A/C5 in den zugeordneten Evidenzdateien bewerten. Onigwrap-Buildprovenienz vor künftiger Highlightingnutzung offen führen; keine neue Automation einrichten. / Assess supply chain and applicability with scoped evidence, follow-ups and native-use gates; no new services or automation.
- [ ] T013 Nach T007–T012 Secure-Development-Startbaseline und Architekturprüfung in `docs/security/secure-development/2026-10-09-lh01-tui-foundation/evidence-matrix.md`, deren `baseline.json` nach installierter Policy und `docs/validation/lh01/architecture-start-review.md` durch passenden Auftrag herstellen; unabhängigen Prüfer, exakte Quellenbindung und offene Befunde nachweisen. / Establish policy-conforming security baseline and distinct architecture review; planning Ready does not substitute for these start checks.
- [ ] T014 Nach T013 Sprache/MSL/Runtime und Statistikreferenz125 begründet in `constitution.md`, `.specify/memory/constitution.md`, allen fünf identischen Guidance-Dateien, betroffenen lokalen Templates, `docs/project-statistics.config.json`, `docs/security/README.md`, `docs/Entwicklungsumgebung.md` und `docs/intake-governance.md` ausrichten; zentrale Registerzeile mit passender separater Autorität tatsächlich anwenden und in `docs/validation/lh01/registry-alignment.md` belegen. Kein Flottenrollout; Vorschlag allein schließt das Gate nicht. / Align local sources and the applied central row under matching authority, with atomic parity and justified statistics reference; preserve histories and avoid fleet rollout.
- [ ] T015 Erst nach allen gebundenen Quellenänderungen aus T008/T009/T014 ein gewöhnliches Intake-Update für `intakes/LH-01.md` mit Vorgängerarchiven/Vorgangs-IDs/`specs/intake-authoring-receipts/lh-01.json` durchführen; FR/AC/QG/OD und Pilotgrenzen erhalten. LH-00-Bindungen ebenfalls prüfen und bei Drift `intakes/LH-00.md` samt `specs/intake-authoring-receipts/lh-00.json` regulär aktualisieren; keine bloße Hashersetzung. / Update provenance through normal lineage-preserving intake operations after bound source changes; refresh affected LH-00 as well, preserving domain IDs.
- [ ] T016 Nach T015 beide betroffenen Intakes vollständig durch einen anderen Prüfer reviewen, aktuelle LH-01-Evidence in `specs/intake-reviews/lh-01/report.md`/`result.json` und LH-00 gemäß dessen aktuellem Reviewpfad liefern; Receipt/Review in Bash und PowerShell prüfen. Auswirkungen gezielt in `specs/002-lh01-tui-foundation/spec.md`, `plan.md` und `tasks.md` abgleichen und speckit-analyze durchführen; geänderte technische Reviewbindungen gezielt erneuern. / Obtain distinct complete intake reviews and paired validation, reconcile only affected design statements and refresh changed technical review bindings.
- [ ] T017 Nach T001–T016 Quellenfrische, Modell-Routing Aligned, passende Werkzeuge/14-Preset-Matrix, angewendete Registerausrichtung, Security-/Architecture-Gates und fehlende startrelevante Analysebefunde in `docs/validation/lh01/start-readiness.md` erneut belegen; konkreten Implementierungsauftrag verlangen. Spätere praktische Abnahme nicht mit Startfreigabe verwechseln. / Recheck all start gates and authority; only then allow product work, keeping deferred practical acceptance separate.

**Checkpoint:** Vor T017 keine Produktdateien oder Produkt-Builds erzeugen.
Nicht startrelevante spätere Prüfgrenzen werden mit Owner/Trigger erhalten.

**Checkpoint:** Product files and builds wait for T017. Record later evidence
limits with owner and trigger rather than falsely passing them.

## Phase 2 — Gemeinsame Produktgrundlagen / Shared product foundation

**Ziel:** Kleiner, sicherer Cmdlet-/Adapterkern. Nur nach T017 und eigenem
Implementierungsauftrag. **Prüfung:** Ungeeignete Eingaben ändern weder Terminal
noch Sitzung; Modelle sind unabhängig vom Framework prüfbar.

**Goal:** Establish safe cmdlet/adapters after authorized readiness. Invalid entry
changes neither terminal nor session; domain models are framework-independent.

- [ ] T018 Öffentliche Signatur für `Show-CommandTui400`, zulässige Remap-Konfiguration, Hilfe, Modulmanifest-Export und stabile Fehlerkategorien in `specs/002-lh01-tui-foundation/contracts/cmdlet-session.md` und `contracts/actions-terminal.md` konkretisieren; Approved Verb Show nachweisen, keine Fixtureparameter oder neuen Produktfunktionen übernehmen. / Define the public cmdlet/remapping/error contract before code; verify the approved verb without importing test-only APIs.
- [ ] T019 Nach T018 C#14/net10.0-Projekt in `src/ShowCommandTui400/ShowCommandTui400.csproj` und `src/ShowCommandTui400/ShowCommandTui400.psd1` mit Terminal.Gui2.5.0, Host-SMA ohne Private-Copy, öffentlicher Registry und `packages.lock.json` erstellen; keinen eigenen PS-Host oder unsafe-Code einführen. / Create the locked managed project and manifest without redistributing the host runtime.
- [ ] T020 Nach T019 Tests in `tests/ShowCommandTui400.Tests/ShowCommandTui400.Tests.csproj` und synthetischen Integrationsaufbau in `tests/feasibility/lh01/README.md` einrichten; frameworkfreie Einheiten, Lifecycle-Testdoubles und echte in-process Prüfungen trennen. / Set up isolated model/lifecycle/session tests with synthetic data and clear proof scopes.
- [ ] T021 Nach T020 Negativverträge für Mindestversion, Streams/Hostfähigkeiten, Remapkonflikte, unbekannte ActionIds in der Startkonfiguration und sichere Steuerzeichenanzeige in `tests/ShowCommandTui400.Tests/EntryBoundaryTests.cs` vor positiven Starts anlegen und fehlende Schutzwirkung nachweisen. / Establish negative entry contracts before valid starts and demonstrate missing protection first.
- [ ] T022 [P] Nach T021 `ActionDescriptor`, stabile `ActionId` und zulässige Kontexte in `src/ShowCommandTui400/Actions/ActionDescriptor.cs` modellieren; Auswahl/Bearbeiten/Bestätigen/Refresh/Zurück/Ausführung getrennt, ohne ausführenden Zieladapter. / Model separate domain actions and contexts without a target executor.
- [ ] T023 [P] Nach T021 lokalen `ViewState` mit Fokus, Werten, Status/Fehler, vorheriger Ansicht und Größe in `src/ShowCommandTui400/State/ViewState.cs` modellieren; keine Persistenz oder LH-03-Formularsemantik. / Model local state without persistence or later parameter forms.
- [ ] T024 [P] Nach T021 sichere Anzeige von Steuerzeichen/unvertrauenswürdigen Texten in `src/ShowCommandTui400/Presentation/SafeDisplayText.cs` umsetzen; erlaubte Renderer-Steuerung getrennt halten, keine Codeauswertung/privaten Dumps. / Sanitize untrusted display data separately from renderer control sequences, without evaluation or private dumps.
- [ ] T025 Nach T018/T021/T022 Capability-/Versionsprüfung in `src/ShowCommandTui400/Session/EntryGuard.cs` und konflikt-/Whitelist-/Escape-Validierung der Startbelegung in `src/ShowCommandTui400/Actions/KeyBindingValidator.cs` umsetzen; umgeleitete Streams/ungeeignete Hosts vor jeder schreibenden Lease/GUI-Init verständlich abweisen, kein Ersatzhost/Fallback. / Implement fail-safe entry before state mutation, without a substitute host.
- [ ] T026 Nach T022–T025 Negativverträge aus T021 ausführen und Null-Terminal-/Sitzungsänderung sowie keine Import-/Netz-/Zielwirkung in `docs/validation/lh01/negative-entry.md` belegen; erst danach positive Produktläufe zulassen. / Prove rejection and zero unintended effects before positive entry runs.
- [ ] T027 Nach T026 Terminaladapter-/Lease- und SessionContext-Schnittstellen in `src/ShowCommandTui400/Terminal/ITerminalLease.cs` und `src/ShowCommandTui400/Session/SessionContext.cs` definieren; Zustände Created/CapabilityCheck/Rejected/Running/Restoring/Closed und plattformspezifische Grenzen abbilden. / Define platform-neutral interfaces and lifecycle states, without assuming universal native ABI.

## Phase 3 — US1: Dieselbe Sitzung, sichere Rückkehr / Same session and safe return (P1)

**Ziel:** Öffnen und Schließen ohne Sitzungstausch, mit sicherer Wiederherstellung.
**Unabhängige Prüfung:** E01-01/E01-04 mit synthetischer Variable/Funktion,
Arbeitsort/Präferenz und globalem/Funktions-/Modulscope; normale Rückkehr,
Ctrl+C/StopProcessing, behandelbarer Fehler und wiederholtes Öffnen. Kein anderer
Story-Abschluss nötig; noch einfache textliche Ansicht mit Hilfe/Beenden verwenden.

**Goal and independent test:** Prove session and restoration contracts with a
minimal view, synthetic caller scopes, all supported exits and repeated entry.
No search/form/other completed story is needed.

- [ ] T028 [P] [US1] Nach T027 Lifecycleverträge und negative Restore-/Doppelfehlerfälle in `tests/ShowCommandTui400.Tests/TerminalLifecycleTests.cs` anlegen; gültigen Ablauf erst nach Ablehnungsfällen aus T026 prüfen. / Add lifecycle and restoration failure contracts after negative entry evidence.
- [ ] T029 [P] [US1] Nach T027 gemeinsamen Prüfdriver `tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1` mit Plan/Target/OutputDirectory/CheckOnly gemäß `docs/validation/lh01/platform-handoff.md` samt lokaler Schema-/semantischer Prüfung von `docs/validation/lh01/approved-commands.schema.json`, E01-Nachweiszuordnung und getrenntem Fail-Lauf für S07 sowie Produkt-Sitzungsharness in `tests/feasibility/lh01/session-contract.ps1` für synthetische globale/Funktions-/Modulkontexte, wiederholtes Öffnen und tatsächliches StopProcessing erstellen; separaten Test-Runspace als Testaufbau benennen. / Implement the shared manifest-bound proof driver with local command-schema/semantic validation, E01 evidence mapping and separate S07 failure run, and genuine synthetic in-process harness, including clearly labelled StopProcessing setup; missing prerequisite yields Blocked, not inferred Pass.
- [ ] T030 [US1] Nach T028/T029 Aufrufersitzungsadapter in `src/ShowCommandTui400/Session/CallerSessionAdapter.cs` implementieren; zulässigen Kontext, Identität und Scopegrenzen erhalten, keine versteckte Session oder Auflösung/Import fachlicher Zielmodule. / Implement caller session access within evidenced visibility limits, without hidden sessions or target discovery.
- [ ] T031 [US1] Nach T028 Mac-Lease in `src/ShowCommandTui400/Terminal/MacTerminalLease.cs` mit verifizierter Darwin-ABI, Snapshot vor erster Änderung, Control-C-Vertrag und Wiederherstellung nach Dispose implementieren; nur unabhängig reproduziertes PENDIN getrennt bewerten und Rohwerte erhalten. / Implement the verified Mac lease without general drift tolerance or loss of raw evidence.
- [ ] T032 [US1] Nach T028 Linux-/Windows-Adapter in `src/ShowCommandTui400/Terminal/LinuxTerminalLease.cs` und `WindowsTerminalLease.cs` mit jeweiligen OS-/Console-Verträgen implementieren und durch Testdoubles prüfen; unbekannte Fähigkeit sicher ablehnen, Darwinwerte nicht kopieren. / Implement platform-specific adapters with safe rejection and own ABI/contracts; test doubles do not prove native support.
- [ ] T033 [US1] Nach T030–T032 synchronen UI-Lifecycle in `src/ShowCommandTui400/Terminal/TerminalApplication.cs` implementieren; dotnet-Treiber erzwingen, Snapshot/Lease freigeben, Cancel/StopProcessing/Fehler in Restore führen und primären Fehler plus Restorefehler erhalten. / Implement deterministic lifecycle and combined error preservation, with no ANSI fallback.
- [ ] T034 [US1] Nach T033/T018 öffentliches PSCmdlet in `src/ShowCommandTui400/Commands/ShowCommandTui400Command.cs` an EntryGuard, Sessionadapter und minimale Ansicht anbinden; keine Probe-Modi im Export, keine Zielausführung, Nutzerfehler verständlich ausgeben. / Wire the public command to guards/session/minimal view without exporting fixture APIs or target execution.
- [ ] T035 [US1] Nach T034 E01-01/E01-04 gegen Produktcode ausführen und in `docs/validation/lh01/session-terminal.md` Identität/Kontext, Modi/Cursor, Shell-Eingaberückgabe, Wiederöffnung, Cancel/Fehler/Restorefehler sowie externe Killgrenzen belegen; GUI-Harness ist keine physische Terminalabnahme. / Execute product lifecycle proofs and document actual outcome/limits, not borrowed fixture results.
- [ ] T036 [US1] Nach T035 öffentliche Cmdlet-Rückkehr, Scopegrenzen, Mindestpatch und Fehlerverhalten in `docs/lh01/session-and-terminal.md` DE/EN erklären; MVP nur begrenzt lokal bewerten, vollständige Plattform-/A11Y-Abnahme offen lassen. / Explain actual session limits and assess only the bounded local MVP.

## Phase 4 — US2: Tastaturaktionen / Keyboard actions (P1)

**Ziel:** Gemeinsame Aktionen unabhängig von Tastencodes, mit erreichbaren
Alternativen und erhaltenem Bearbeitungsstand. **Unabhängige Prüfung:** E01-02
mit synthetischer Liste/Feldansicht, allen Tasten/Remaps und negativem Kontext;
Session/Terminaladapter dürfen durch Testdoubles ersetzt werden. Integration mit
US1 erfolgt erst im letzten Storynachweis.

**Goal and independent test:** Test action/state contracts independently using
synthetic controls and adapter doubles; then integrate with US1.

- [ ] T037 [P] [US2] Nach T027 Tests für Whitelist, gültigen/ungültigen Kontext, Nichtverfügbarkeit, Enter ohne Ausführung und Root-Zurück in `tests/ShowCommandTui400.Tests/ActionContractTests.cs` schreiben; kein unbekannter Input hat eine Wirkung. / Test action/context boundaries and state-preserving confirmation/back before implementation.
- [ ] T038 [P] [US2] Nach T027 Tests für F1/F3/F4/F5/F9/F10/F11/F12/Esc, Alt+H/B/X/M, echtes F1→F2-Remap und Konflikt-/unerreichbare Escape-Belegung in `tests/ShowCommandTui400.Tests/KeyBindingTests.cs` erstellen; Negativfälle zuerst. / Test all defined keys, alternatives, valid remapping and rejected conflicts/escape loss first.
- [ ] T039 [US2] Nach T037 `src/ShowCommandTui400/Actions/ActionDispatcher.cs` mit getrennten Effekten, Whitelist und zweiter Kontextkontrolle implementieren; Refresh/Bestätigen/Zurück ändern keinen Zielbefehl und verlieren keine Werte. / Implement independent allow-list/context controls and state-preserving actions without execution.
- [ ] T040 [US2] Nach T038 Tastenbelegungen und Alternativen in `src/ShowCommandTui400/Actions/KeyBindingMap.cs` mit dem bestehenden KeyBindingValidator aus T025 umsetzen; Hilfe/Zurück/Beenden erreichbar, Menüaktion textuell, Konflikte vor UI-Init abweisen. / Implement validated bindings and reachable alternatives with pre-init conflict rejection.
- [ ] T041 [US2] Nach T039/T040 Frameworkadapter für Tab/Umschalt+Tab, Pfeil-/Bildnavigation, Enter und Zurück in `src/ShowCommandTui400/Views/NavigationAdapter.cs` implementieren; Fokusfolge und getrennte Aktionen ohne Geräteadapter erhalten. / Implement predictable navigation through action IDs, without device adapters or target effects.
- [ ] T042 [US2] Nach T040/T041 Hilfe, kontextbezogene Legende und textuelle Aktionsübersicht in `src/ShowCommandTui400/Views/ActionHelpView.cs` mit sichtbaren Alternativen erzeugen; lokaler Helptext ohne Netzabfrage. / Show local help, legend and alternatives without network access.
- [ ] T043 [US2] Nach T039/T042 F4/F9/F10/F11 ohne bestehende Folgefunktion ausdrücklich nicht verfügbar darstellen und in `src/ShowCommandTui400/Actions/ActionAvailability.cs` absichern; kein Formular-/Details-/Completionfeature implementieren. / Keep later contextual actions visibly unavailable and effect-free.
- [ ] T044 [US2] Nach T035/T041–T043 vollständigen E01-02-Produktnachweis einschließlich abgefangener Funktionstasten, Remap, Root-Zurück, Refresh und null Zielwirkungen in `docs/validation/lh01/keyboard-actions.md` liefern; synthetische Erzeugung nicht als reale Hosttastenübertragung ausgeben. / Prove all product action contracts and limits after US1 integration.

## Phase 5 — US3: Zugänglicher Zustand und Größe / Accessible state and size (P1)

**Ziel:** Hilfe, Fokus, Status/Fehler und Größenlimits textuell erklären.
**Unabhängige Prüfung:** E01-03/E01-05 über Text-/Statevertrag mit Testdoubles,
ohne Farbbedeutung; Resize erhält lokale Werte/Fokus, kleine Größe erlaubt Ende.
Keine realen Screenreader-/Terminal-/Brailleläufe in diesem Stadium durchführen.

**Goal and independent test:** Prove text/state/resize behavior with doubles,
then bounded product automation. Practical assistive proof is not implied.

- [ ] T045 [P] [US3] Nach T027 Textverträge für Name, Verfügbarkeit, Fokus, Busy, Fehler und Legende ohne reine Farb-/Positionsbedeutung in `tests/ShowCommandTui400.Tests/AccessibleStateTests.cs` erstellen. / Test complete textual state independent of colour or position.
- [ ] T046 [P] [US3] Nach T027 Resize-/Kleinstgrößenfälle mit lokalen Werten, Fokus und anschließender Navigation in `tests/ShowCommandTui400.Tests/ResizeStateTests.cs` anlegen; Grenzwerte an tatsächlicher Bedienbarkeit begründen statt Intake-Schwellen zu erfinden. / Test size changes against usable rendering without invented requirement thresholds.
- [ ] T047 [US3] Nach T045 Textzustand und sichere Fehlerdarstellung in `src/ShowCommandTui400/Presentation/AccessibleStatePresenter.cs` implementieren; Rollen/Zustände soweit Host unterstützt benennen, keine künstlichen Hilfsmittel-PASS-Aussagen. / Implement textual state/error presentation within host capabilities, without conformance claims.
- [ ] T048 [US3] Nach T046 Resizekoordination in `src/ShowCommandTui400/Views/ResizeCoordinator.cs` implementieren; ViewState/Fokus erhalten und anschließende Navigation ermöglichen. / Preserve state and focus through resize and subsequent navigation.
- [ ] T049 [US3] Nach T047/T048 begründete Größenwarnung und sichere Tastaturrückkehr in `src/ShowCommandTui400/Views/SmallTerminalView.cs` implementieren; Hilfe/Beenden auch bei unbedienbarer Normalansicht erreichbar. / Explain unusable dimensions and keep help/exit reachable.
- [ ] T050 [US3] Nach T042/T047–T049 Benutzertexte, Aktionsnamen und Help-/Fehlertexte in `src/ShowCommandTui400/Resources/Messages.de.resx` und `Messages.en.resx` gleichwertig auf etwa B2 führen; technische Begriffe erklären und keine privaten Werte veröffentlichen. / Provide equivalent readable bilingual resources with safe data handling.
- [ ] T051 [US3] Nach T044/T050 E01-03/E01-05 automatisiert gegen Produktcode prüfen und in `docs/accessibility/lh01-text-state.md` Fokus, Fehler, Resize, kleinen Bildschirm und Shellrückkehr samt Grenzen belegen; WCAG-Oberflächenmatrix aus Spec übernehmen, praktische Hilfsmittelprüfung Deferred/Excluded belassen. / Evidence product text/state behavior and applicable WCAG criteria without substituting automation for assistive acceptance.

## Phase 6 — Übergreifende Prüfung und begrenzter Abschluss / Cross-cutting validation and bounded closeout

**Ziel:** Produktnachweise zusammenführen, offene praktische Prüfungen ehrlich
führen und fachlichen Abschluss von technischer Lieferung trennen.

**Goal:** Consolidate evidence and distinguish technical delivery, bounded pilot
results and still-open practical/domain acceptance.

- [ ] T052 Nach T035/T044/T051 E01-06 mit synthetischen Steuerzeichen, unbekannten Aktionen, ungültigem Kontext, ungültigem Remap, Redirects und Fehlern in `tests/ShowCommandTui400.Tests/SecurityBoundaryTests.cs` ergänzen und zuerst negativ ausführen; `docs/validation/lh01/security-negative.md` belegt null Ziel-/Netz-/Import-/Persistenzwirkung und keine privaten Dumps. / Run cross-cutting negative product security cases with actual zero-effect proof.
- [ ] T053 Nach T052 auf Mac A (MacBook Air M2 2023) den automatisierten Produkt-Sitzungs-/PTY-Ablauf in `tests/feasibility/lh01/` ausführen und `docs/validation/lh01/platform-matrix.md` mit Versionen, 7.6.4-/7.6.6-Grenzen, Payload-/Entscheidungshashes, Kommando, Prüfer, Exitcode und Schreibumfang aktualisieren; Feasibility-Fixturebelege nicht zum Produkt-PASS umbenennen. Mac-A-Produktnachweis aus dem eigenen Harness herstellen; danach im separat autorisierten Prüfplan `docs/validation/lh01/platform-handoff.json` den unveränderlichen Produktcommit, Entscheidung, Driverhash und freigegebene Kommandos binden. / Produce fresh bounded Mac A product proof first, then bind the separately authorized target manifest to exact revision, driver/decision hashes and approved commands.
- [ ] T054 Nach T053 die drei verknüpften Agenten-Hand-offs aus `docs/validation/lh01/platform-handoff.json` mit dem gemeinsamen Prüfdriver verwenden und native automatisierte Build-/Vertragstests für Linux/Windows sowie verfügbare Mac-B-/Ubuntu24.04-/WSL2-Hostfälle in `docs/validation/lh01/platform-matrix.md` ergänzen; fehlende Hosts offen lassen. Native CI nur mit passender Autorität und begrenzten Jobs in `.github/workflows/lh01-product-validation.yml` vorsehen/ausführen, Container/CI nicht als interaktive Plattformabnahme ausgeben. / Run the linked target hand-offs through the shared driver under explicit authority, automatically producing JSON and DE/EN evidence plus distinct review; retain missing-host gaps and strict CI/container limits.
- [ ] T055 Nach T051/T054 praktische Prüfplanung in `docs/accessibility/lh01-evidence-boundaries.md` mit Verweis auf Ownerentscheid vom 08.10.2026 dokumentieren: reale Terminals/Screenreader Deferred, Braille-Hardware Excluded mangels Gerät im privaten Projekt; AC-01-004/QG-01-003 ohne praktisches PASS. Owner Thorsten, Wiedervorlage bei Hardware-/Scopeänderung oder eigenem Prüfauftrag; keine Gerätebeschaffung/testweise Behauptung. / Preserve owner-defined practical evidence limits with reassessment triggers and no assistive conformance claim.
- [ ] T056 Nach T036/T050 öffentlichen Modulhelp in `src/ShowCommandTui400/Help/de-DE/ShowCommandTui400.dll-Help.xml`, `Help/en-US/ShowCommandTui400.dll-Help.xml` und Hilfe-Leserpfad in `docs/lh01/README.md` vervollständigen; Einstieg, Remap, Fehler/Scope, Minimum und Wiederherstellungsgrenzen erklären, keine Probeparameter. / Complete bilingual public cmdlet help and reader paths with actual public API only.
- [ ] T057 Nach T055/T056 E01-07 als DE/EN-B2-, ID-, Link-/Textbrowser- und Textalternativenreview in `docs/validation/lh01/documentation-review.md` durchführen; sinnvoller Mermaid-Ablauf mit gleichwertigem Text, sonst begründetes N/A. Genau eine Documentation-Impact-Entscheidung und Owner/Quelle/Leserpfad/Distributionsgrenze festhalten. / Review equivalent language, IDs, text access and one documentation impact record without assuming Spec Kit knowledge.
- [ ] T058 Nach T052–T057 MSL/secure coding, Threat Model/S-ADR/arc42, Abhängigkeiten und Architekturqualität erneut in `docs/security/secure-development/2026-10-09-lh01-tui-foundation/evidence-matrix.md` und `docs/validation/lh01/architecture-start-review.md` durch unabhängiges Review bewerten; geänderte Pfade nach installierter Assurance-Policy in `deltas/lh01-product.json` neu binden, alle startrelevanten Befunde korrigieren. / Review actual changed product/security architecture independently, retaining exact policy evidence and outstanding practical limits.
- [ ] T059 Nach T058 bei tatsächlich erzeugtem verteilbarem Modul SBOM, Lizenz-/Notices und Buildherkunft in `docs/security/supply-chain-evidence.md` sowie `docs/security/sbom/lh01.cdx.json` liefern; VEX bei konkreter Schwachstelle erstellen, SLSA-Provenance scopebezogen belegen. Kein Release/Publishing ohne eigenen Auftrag; N/A jeweils begründen. / Inventory distributable components and attributable provenance, with conditional VEX and no automatic release.
- [ ] T060 Nach T059 `docs/validation/lh01/final-checks.md` mit Secret-, Homogenitäts-, Diff-, PowerShell-/Produktanalyse, exakter 14-Preset-Matrix, Agent-/Constitutionparität und aktuellen Receipt-/Review-/Analyseprüfungen führen; weitere gebundene Quellenänderung erneut über T015/T016 schließen, keine Installationen. Erwarteten Statistik-/Homogenitätsdrift vor Lieferung ausdrücklich offen führen; abschließenden PASS erst nach T061 prüfen. / Verify technical controls and freshness; explicitly retain expected pre-delivery statistics/homogeneity drift and verify final PASS only after T061.
- [ ] T061 Erst nach den Abschlussartefakten aus T062 und gegebenenfalls T063, nur beim eigens autorisierten Lieferpaket `docs/project-statistics.md` aus sauberem Arbeitsbaum mit Renderer fortschreiben und Check-only belegen; Alle Quellen einschließlich Abschlussartefakten zuerst committen, dann rendern/prüfen/Statistik committen; anschließend Statistik-Check-only und Homogenität am endgültigen Stand erneut prüfen. `docs/validation/lh01/final-checks.md` führt Befund und Liefergrenze; keine handgemachten Zahlen oder aktuelle Commitautorität aus dieser Aufgabe ableiten. / After T062 and any applicable T063 artefacts, commit all sources under delivery authority, render/check/commit statistics, then repeat final statistics and homogeneity checks; no manual figures.
- [ ] T062 Nach T055/T060, vor T061 begrenzten technischen Pilotstand, FR/AC/QG-Abdeckung, offene praktische Plattform-/A11Y-Abnahme und Ownerentscheidung in `docs/validation/lh01/acceptance.md` festhalten. Die getrennten menschlichen Entscheide außerdem in `docs/security/secure-development/2026-10-09-lh01-tui-foundation/closure.json` sowie Image-Impact (kein Imageprodukt, begründetes N/A) in dessen `image-impact.json` gemäß Policy führen; keine Ready-Aussage bei offenen Pflichtpunkten. Bei offenen Abnahmekriterien kein vollständiges LH-01-Completed/Archiv und keine daraus abgeleitete LH-02-Freigabe behaupten; Intake nicht pauschal umbenennen. / Record bounded outcome and genuine outstanding acceptance; no premature completion/archive or inferred LH-02 permission.
- [ ] T063 Nach T062 und vor T061 nur bei tatsächlich vollständig abgeschlossenem Spec-Kit-Featurelauf `specs/002-lh01-tui-foundation/completion-report.md` nach Vorlage erstellen und im Chat vollständig berichten; sonst Zwischenstand in `docs/validation/lh01/acceptance.md` erhalten. Keine vollständige Abnahme durch bloßes Abarbeiten der technischen Aufgaben behaupten. / Produce the completion report only for an actually completed feature run; otherwise keep an honest interim outcome.

## Abhängigkeiten und Arbeitsfolge / Dependencies and execution order

| Abschnitt / Section | Voraussetzung und Bedeutung / Prerequisite and meaning |
|---|---|
| T001–T017 | Governance-/Herkunfts-/Startarbeit; T017 sperrt nur unbelegte Produktvoraussetzungen, nicht Tasksplanung / prerequisites before product work, not a block on task planning |
| T018–T027 | T017 plus eigener Auftrag; öffentliche Verträge vor Projekt, Negativfälle vor positiven Starts / authority and readiness, public contract before scaffold, negative checks first |
| US1 T028–T036 | T027; Mac-Lease und fremde OS-Adapter besitzen eigene Belege / independent product lifecycle and native boundaries |
| US2 T037–T044 | Modelltests nach T027 unabhängig; Integration T044 braucht T035 und eigene Implementierung / independent models, final integration requires US1 |
| US3 T045–T051 | Text-/Resizetests nach T027 unabhängig; T050 benötigt T042, T051 benötigt T044 / independent contracts, final text/resources/integration depend on earlier views |
| T052–T063 | Storynachweise vor Gesamtprüfung; praktische Deferred/Excluded nicht in PASS umdeuten / consolidated proof after stories, with honest practical gaps |

Zusätzliche gemeinsame Dateisperren: T008 vor T009 vor T010 (Securitybestand);
T012 nach T011, damit Evidence-Verweise und Anwendbarkeit konsistent bleiben.
T025 benötigt T018/T021/T022; die Whitelist/ActionIds aus T022 müssen vorliegen.
T014 erst nach T013; T015 erst nach T014; T016 erst nach T015; T017 zuletzt.
Sämtliche Änderungen gebundener Quellen vor Start lösen erneut T015/T016 aus.
T058 kann Security-/Registerkorrekturen auslösen und muss dann diese Schleife
vor T060 schließen. Danach gilt T060 → T062 → T063 (nur falls anwendbar) → T061.
T061 ist ein bedingter Lieferauftrag, keine Pflicht zu unerlaubten Commits.
T062 dokumentiert auch einen begrenzten Zwischenstand, ohne vollständige Abnahme;
T063 bleibt ohne echten Featureabschluss offen und verhindert keine begrenzte
Lieferung. Ohne Lieferauftrag bleiben Render/Commit und finaler Drift-PASS offen.
Neue Quellen nach dem abschließenden Render verlangen eine erneute Render-/Prüffolge.

Serialize shared security files; apply provenance after all bound source edits
and review it before product readiness. Later bound-source corrections repeat
the same loop. T025 explicitly waits for T022. Prepare bounded acceptance and any
applicable completion artefacts before the final source commit/statistics render.
An inapplicable full completion report does not block bounded delivery. Without
delivery authority, rendering/commits and final drift clearance stay open. Later
source edits require another render/check cycle; full acceptance stays separate.

**Textlicher Abhängigkeitsgraph:** T001 → T002–T006 → T007–T013 → T014 → T015 →
T016 → T017 → T018–T027 → US1. US2- und US3-Vertragstests können nach T027
unabhängig beginnen; Produktintegration folgt US1 → US2 → US3 → T052–T060.
Danach folgen begrenzte Ownerbewertung/Abschlussartefakte und erst dann bedingte
Statistiklieferung mit abschließender Prüfung; offene
praktische Abnahme erlaubt kein automatisches Completed. Kein zusätzliches
Diagramm erforderlich, weil Tabelle und vollständiger Text dieselben Kanten erklären.

**Text dependency graph:** Preconditions, applied alignment, provenance and
reviews precede the product foundation. Story model tests can start independently
from that foundation, while final integration proceeds US1 → US2 → US3 → checks.
Owner assessment/closure artefacts precede conditional statistics delivery and
final checks; open practical acceptance does
not permit automatic completion. The table and text fully describe dependencies.

## Parallelbeispiele je Szenario / Parallel examples per story

- **Start:** Nach T002 können T003/T004/T005/T006 an getrennten ADR-Dateien parallel
  arbeiten; anschließend T007. Keine parallelen Änderungen der fünf Guidance-Dateien
  oder des Receipt-/Review-Verbunds. / Independent ADR files may proceed together;
  shared guidance/provenance mutations remain atomic and sequential.
- **US1:** Nach T027 können T028 und T029 unterschiedliche Testdateien vorbereiten.
  Tatsächliche Terminal-Läufe T035 bleiben seriell auf demselben Host. / Separate
  lifecycle and session harness files can proceed together; host runs stay serial.
- **US2:** Nach T027 können T037 und T038 getrennte Aktions-/Tastentests vorbereiten.
  Dispatcher/Belegung werden erst danach umgesetzt. / Action and binding tests can
  proceed together before implementation.
- **US3:** Nach T027 können T045 und T046 Textzustands-/Resizetests vorbereiten.
  Gemeinsame Ressourcenintegration T050 folgt den Views. / Text and resize tests
  can proceed together; shared resource integration follows views.

## Abdeckung und Nachweisstatus / Coverage and evidence status

| Kennungen / IDs | Aufgaben / Tasks | Grenze / Limit |
|---|---|---|
| FR-01-001; AC-01-002 | T005/T006/T032/T035/T053/T054/T055 | Native automatische Tests und reale Oberflächen unterscheiden / distinguish native automation and real surfaces |
| FR-01-002; FR-01-009 | T022/T037/T039/T043/T052 | Gemeinsame Aktionen, keine Geräteadapter/Zielausführung / shared model, no device adapters or executor |
| FR-01-003; FR-01-004; FR-01-007; AC-01-001 | T018/T038/T040–T044 | Jede Taste/Alternative/Remap; spätere Kontextaktionen ohne Wirkung / complete keys with unavailable later actions |
| FR-01-005; FR-01-006; FR-01-011; AC-01-003 | T006/T025–T036/T053 | Identität allein ist kein Scope-/Restorebeleg / identity alone proves neither visibility nor restore |
| FR-01-008; FR-01-010; AC-01-004 | T023/T045–T051/T055 | Praktische Hilfsmittel-Evidence bleibt Deferred/Excluded / assistive evidence retains owner limits |
| AC-01-005; QG-01-001; QG-01-005 | T050/T056/T057/T060/T062/T063 | DE/EN, Textalternative, ehrliche Abschlussgrenzen / equivalent language and honest closeout |
| QG-01-002; QG-01-004 | T007–T017/T052–T060 | Anwendbarkeit/prüfbare Risiken und unverfälschte Evidence / scoped controls and attributable proof |
| QG-01-003 | T045–T051/T055/T057 | Keine WCAG-Konformitätsbehauptung ohne Belege / no unsupported conformance claim |
| OD-01-001 | T003–T006/T018/T025/T027/T032/T034 | Bereits entschieden; Entscheidungen dokumentieren und Produkte verifizieren / record choices, verify product |
| OD-01-002 | T002/T008/T014/T058 | Managed C# schützt nicht sämtliche nativen Vertrauensgrenzen / managed code does not make native boundaries safe |
| E01-01/04 | T028–T036/T053/T054 | Frische Produktnachweise, keine Fixture-Umdeutung / fresh product proofs |
| E01-02 | T037–T044 | Kontext-/Negativfälle zuerst / negative context cases first |
| E01-03/05 | T045–T051/T055 | Automatische Text-/Resizeprüfung getrennt von praktischer A11Y / distinguish automated and assistive proof |
| E01-06/07 | T052/T057/T058/T060 | Sicherheits-/Sprachreview und Quellenfrische / security/language review and freshness |
| G01–G12 | T001/T008–T017/T051–T063 | Alle Governance-Zeilen erfasst, keine automatische Serien-/Folgefreigabe / all rows, no implied series or next feature authority |

**Anwendbarkeit:** NIST SSDF und CWE Top25 sind Applicable, nie N/A. Sichere
Sprachregeln/STRIDE/CIA/arc42/ADRs gelten über T008–T013/T058. CAPEC/SAMM/OpenSSF
haben konkrete Arbeit in T010/T012; Überprüfung von Abhängigkeiten mindestens
monatlich und vor Release mit Owner/Termin in `docs/security/dependency-audit.md`.
SBOM gilt bei verteilbarem Modul, VEX bei konkreter Schwachstelle, Buildprovenienz
bei tatsächlichem Build/Lieferung (T059). Lockfile/Audit ist kein Zertifikat.

**Applicability:** Required security methods and attributable architecture evidence
are explicit. Dependency audits retain monthly/pre-release cadence. Conditional
SBOM/VEX/provenance does not authorize distribution or claim certification.

ASVS/Produkt-AI-SBOM/ZeroTrust/C3A/C5 bleiben für den lokalen nicht-web-/nicht-KI-
Produktumfang begründet N/A; Werkzeuge/Organisation separat bewerten. Bei Cloud-
oder Providerabhängigkeit C3A/C5 anhand installierter Detailvorlagen neu bewerten;
C5 ersetzt C3A nicht. Rechtliche Unknown bleiben Open mit Grund, Owner, Aktion,
Frist und Wiedervorlage, keine neue Rechtsentscheidung in Architecture (T009/T012).
Für API/Auth/SQL/Krypto ohne entsprechenden Produktumfang N/A statt Zusatzfeature.

ASVS, product AI-SBOM and remote/cloud controls are scoped N/A, with reassessment
triggers; tooling and organisation stay separate. Legal unknowns remain Open, and
architecture refers to the security applicability decision rather than duplicating it.

Cross-Platform-Skriptpaar/man-Page/WhatIf-Parität sind für das Binärcmdlet N/A,
weil kein neues kritisches Wartungswerkzeug entsteht. Produkt-Cmdlet-/Hilfedoku
und native Verträge bleiben Applicable (T018/T032/T054/T056). Isolierte Testharnesses
sind keine portable Betriebsoberfläche. Wird später ein Betriebs-/Wartungsskript
benötigt, müssen Bash/PS7, Hilfe/man-Page, sicherer Modus und Paritätsprüfung im
selben Arbeitspaket ergänzt werden; dies erteilt heute keinen solchen Auftrag.

Script-pair/man-page/WhatIf work is N/A for this binary cmdlet, without dropping
public help or platform contracts. Test harnesses are not an operational tool.
New maintenance tooling would require paired safe-mode/help/parity work.

Agent-Parität gilt für T014/T060 mit allen fünf Flächen und beiden Constitution-
Kopien. Model Routing wird in T001/T017 gelesen; lokale Refreshs brauchen passende
Autorität. Autonomous/Parallel Autonomous/Serienauswahl sind N/A für diesen
Einzelpilot; alle 14 Presets behalten die versionierte Projektmatrix. Kein Ersatz-
`agent-context.md`, keine neue Installation und kein ungefragter Home-Sync.

Apply atomic parity at shared source edits; routing checks grant no refresh authority.
Autonomous orchestration/series selection remain N/A, versions unchanged. No redundant
context file, reinstall or automatic Home synchronization.

## Umsetzungsvorschlag und Abschlussbedingungen / Implementation strategy and completion conditions

1. **Vorbereitung zuerst:** T001–T017 als eigenes begrenztes Paket. Quellenänderungen
   und frisches unabhängiges Review gehören zusammen; Produktcode wartet. / Complete
   readiness as a bounded package with aligned provenance before product code.
2. **Lokaler technischer MVP:** T018–T036 auf Mac A. Minimale sichere Ansicht,
   Hilfe/Ende und echte Sitzungs-/Restoreverträge. Keine vollständige Feature-/
   Plattform-/A11Y-Abnahme ableiten. / Establish the smallest safe session MVP,
   without claiming full feature/platform/accessibility acceptance.
3. **Inkremente US2 und US3:** T037–T051 für vollständige Tastatur-/Text-/Resize-
   Verträge; unabhängige Modelltests vor Integration. / Add keyboard and text/resize
   contracts with independent tests before integration.
4. **Nachweise und Ownerentscheid:** T052–T063 unter ihren Bedingungen. Reale
   Terminals/Screenreader bleiben aktuell zurückgestellt, Braillehardware-Nachweis
   ausgeschlossen. LH-01-Abschluss und Folgepilot sind gesonderte Entscheidungen;
   praktische Lücken dürfen weder Aufgabenhäkchen noch Completed verdecken. / Apply
   each final task's genuine conditions and preserve practical evidence gaps and
   separate feature/next-pilot decisions.

Diese Liste enthält 63 offene Aufgaben: 17 Startvoraussetzungen, 10 Grundlagen,
9 US1-, 8 US2-, 7 US3- und 12 Abschlussaufgaben. 13 Aufgaben sind unter den genannten
Voraussetzungen parallelisierbar. Format: Checkbox, fortlaufende ID, optionale
Parallelmarke, Storymarke ausschließlich in Storyphasen, konkreter Zielpfad.

This list contains 63 open tasks: 17 readiness, 10 foundation, 9 US1, 8 US2,
7 US3 and 12 final tasks. Thirteen tasks allow scoped parallel work. No task has
been executed or marked complete by this planning command.

## Historische Prüfung der Tasks-Erstellung / Historical task-generation validation

Am 09.10.2026 löste `setup-tasks.sh --json` das beauftragte Feature und die
installierte Tasks-Vorlage auf. Es gibt keine `.specify/extensions.yml` und
daher keine Before-/After-Tasks-Hooks. Receipt59f3e085 (31 Quellen) und
Intake-Reviewdd62a398 wurden lesend mit den vorhandenen Bash-Validatoren als
aktuell bestätigt. Zum Zeitpunkt der ursprünglichen Erstellung band das technische Ready-Review
nur die vorherigen Machbarkeits-/Planungsdateien. Das fokussierte Re-review vom
09.10.2026 ergänzte anschließend die Tasks-Bindung; spätere Änderungen brauchen
eine erneute unabhängige Prüfung.

On 9 October 2026, setup resolved the requested feature/template. No extensions
file or task hooks exist. Existing Bash validators confirmed current provenance
and intake review. At initial task creation, the earlier technical review did not cover the new list.
The focused 9 October review subsequently bound it; later edits require distinct review.

Formatprüfung: 63 eindeutige fortlaufende offene IDs, richtige Storylabels,
13 konfliktfreie Parallelmarken, konkrete Zielpfade, DE/EN je Aufgabe sowie
gültige Links zu vorhandenen Quellen. Die Abdeckungsmatrix nennt alle
23 FR-/AC-/QG-/OD-Kennungen. Neue Zielpfade sind geplant und kein Link-PASS
für noch nicht existierende Produktdateien. Nur `tasks.md` wurde geschrieben;
Intake/Receipt/Review, Guidance, Registry und Produkt bleiben unverändert.
Keine Implementierung, Statistikrender, Commits oder Remote-Writes ausgeführt.

Format validation covers unique open IDs, story placement, parallel prerequisites,
concrete paths, bilingual task text, source links and all 23 preserved IDs. Planned
product paths do not imply existing files. Only tasks.md was written; sources,
provenance and product files were preserved. No implementation or delivery ran.

Nächster eigener Auftrag: `speckit-analyze` für Spec/Plan/Tasks. Kein automatischer
Folgelauf und kein `completion-report.md` für dieses einzelne Planungskommando.

Next separate request: analyse specification, plan and tasks. This planning command
does not automatically execute analysis or create a completed-feature report.

## Plattform-Hand-off-Ergänzung / Platform hand-off addition

Ownerauftrag vom 09.10.2026: Vier koordinierende GitHub-Issues und gemeinsamer
[Prüfvertrag](../../docs/validation/lh01/platform-handoff.md) mit maschinenlesbarem
Startplan. T029 plant den Driver, T053 bindet den späteren Produktprüfstand nach
echtem Mac-A-Proof, T054 führt die separat beauftragten Zielprüfungen aus.
Prepared ist keine Startfreigabe. Dieses Dokumentationspaket implementiert weder
Driver noch Produkt und schließt keine der 63 Aufgaben ab.

The owner commissions issue-based coordination and an agent-readable contract.
Driver implementation, Mac A product proof and separate target execution remain
future tasks. Preparation grants no execution authority or completed checkbox.
