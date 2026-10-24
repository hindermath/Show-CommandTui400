# Implementierungsplan LH-01 / Implementation plan LH-01

**Datum / Date:** 2026-10-08. **Feature:** `002-lh01-tui-foundation`.
**Git-Branch / Git branch:** `main`; Setup-BRANCH ist Feature-ID, kein neuer Git-Branch / setup identity does not create a branch.
**Input:** [spec.md](spec.md), ausschließlich LH-01 / LH-01 only.
**Status:** T018–T052 ausdrücklich beauftragt und begrenzt auf Mac A umgesetzt;
praktische Abnahme und T053–T063 offen. / T018–T052 explicitly commissioned and
implemented on Mac A; practical acceptance and T053–T063 remain open.
Aktueller Nachweis / Current proof: [Sitzung und Terminal](../../docs/validation/lh01/session-terminal.md),
[Tastaturaktionen](../../docs/validation/lh01/keyboard-actions.md),
[Textzustand/Größe](../../docs/accessibility/lh01-text-state.md),
[Negativgrenzen](../../docs/validation/lh01/security-negative.md).

DE: Build-Ergänzung 2026-10-15: SMA7.6.4 als private compile-only NuGet-Referenz;
Engine weiter ausschließlich vom Host. [Einrichtung](../../docs/lh01/development-setup.md).
Keine Änderung der Mindestversion oder Sitzungsintegration.

EN: Build amendment 2026-10-15: private compile-only SMA7.6.4 NuGet reference;
the host still supplies the engine. No minimum-version or session change.

## Zusammenfassung / Summary

Die technische Auswahl ist in [Entscheidungen](feasibility/decisions.md) begründet:
C#14-Binärcmdlet, Host-.NET10, Mindest-PowerShell7.6.4, Terminal.Gui2.5.0 mit
explizitem dotnet-Treiber und eigener Terminal-Lease. OD-01-001/002 sind als
Auswahlfragen entschieden. Reale Terminal-/Screenreadernachweise sind auf
Ownerauftrag zurückgestellt, Braillehardware-Nachweis wegen fehlender Hardware
im privaten persönlichen Projekt ausgeschlossen. Keine behauptete A11Y-Konformität.
[Nachweisgrenzen](feasibility/owner-validation-boundaries.md) und vollständige
Produkt-/Plattformabnahme bleiben getrennt. Isolierte Prüfungen sind ausgeführt;
beim damaligen Planlauf wurden kein Produktcode, Commit, Push oder Serienlauf gestartet.

Select C#14 in-process cmdlet, host .NET10, minimum PS7.6.4, Terminal.Gui2.5.0 with
explicit dotnet driver and terminal lease. ODs are resolved choices. Owner defers
physical terminal/screen-reader tests and excludes Braille hardware proof; do not
claim conformance. The original planning run recorded isolated evidence without product or delivery work.

## Technischer Kontext / Technical context

| Aspekt / Aspect | Planungsbaseline und Grenze / Baseline and limit |
|---|---|
| Sprache/MSL / language | C#14 managed gewählt; native Grenzen separat; T014 lokal C#/msl angewendet / selected managed C#, native boundaries separate, T014 applied locally |
| Runtime | .NET10 im laufenden PS-Prozess; kein eigener Host / caller runtime, no custom host |
| Mindest-PowerShell / minimum | 7.6.4 gewählt; tatsächliche Hostpatch-/Plattformprüfung separat / selected minimum; actual host/platform verification separate |
| Abhängigkeiten / dependencies | Terminal.Gui2.5.0 dotnet-Treiber; kein ansi-Fallback, Host-SMA nicht mitverteilen; native Bewertung / explicit dotnet, no ansi fallback, host SMA excluded |
| Speicherung / storage | Keine Sitzungs-/Bearbeitungsdaten persistent; nur lokaler Laufzustand / no persisted session/editing data |
| Tests / tests | C#/PowerShell-/Python-Fixture, C-ABI-Kontrolle, 67 beobachtete Vertragsassertionen / actual fixture/native control and 67 observed assertions |
| Plattform / platform | Mac A zuerst; Mac B, Windows11 nativ, Ubuntu24.04/WSL2 getrennt / separate environment proof |
| Typ / type | In-process PowerShell-Cmdlet mit Terminal-UI; keine eigene Shell / session cmdlet, no replacement shell |
| Leistung/Skalierung / performance | Ein lokaler interaktiver Lauf; keine erfundenen Zeit-/Lastschwellen / local session, no invented latency/load thresholds |
| Umfang / scope | FR-01-001–011, AC-01-001–005, QG-01-001–005, OD-01-001/002; keine LH-02–07-Funktion / no later features |

## Constitution-Prüfung / Constitution check

Die Projektzeile ist durch den freigegebenen T014 lokal ausgerichtet: managed
C#14, eigener MSL-Status `msl`, Host-.NET10, Terminal.Gui2.5.0/dotnet und PS7.6.4.
macOS-first, 14er-Profil und DE/EN B2 bleiben erhalten; Statistik80/125 ist begründet,
keine Zeitmessung. Native/Interop-Grenzen und spätere Plattform-/A11Y-Abnahmen
bleiben getrennt. [Anwendungsnachweis](../../docs/validation/lh01/registry-alignment.md).
Der T014-Anwendungsnachweis beschreibt den damaligen lokalen Stand vor Lieferung;
den autorisierten Lieferabschluss dokumentiert [Liefernachweis](../../docs/validation/lh01/readiness-delivery.md).

T014 applies the approved row locally: managed C#14, own-code `msl`, host.NET10,
Terminal.Gui2.5.0/dotnet and PS7.6.4. Keep macOS-first, fourteen presets and bilingual
readability. References80/125 are justified parameters, not time measurements.
Native boundaries and practical acceptance remain separate. Central source changes
describe the historical local state before delivery; the linked delivery record
tracks authorized publication and its closeout.

| Gate | Vor Recherche / Before research | Nach Entwurf / After design | Evidence, Aktion und Fälligkeit / Evidence, action and due gate |
|---|---|---|---|
| P01 Eingang / input | PASS historischer Planlauf / historical | T016 erneuert / refreshed | Historischer Eingang59f3e085/dd62a398; aktuelle Quellen und Reviews im T017-Nachweis / current provenance in readiness record |
| P02 Scope/Pilot | PASS | PASS | Spec/Verträge erhalten Einzelpilot, LH-00 offen, keine Folgefeatures / preserved boundaries |
| P03 Sprache/Runtime/Framework | Open historisch / historical | Auswahl entschieden / selection resolved | OD-01-001/002, D01–03, F01–07, getrennte ADRs und anderes Review vor Produktcode / before product code |
| P04 Sicherheit / security | Applicable | Applicable/Open | Eingabevalidierung + Kontextprüfung, sichere Anzeige + keine Codeauswertung; Threat Model/S-ADR/arc42 vor Umsetzung / explicit security gates |
| P05 A11Y/Plattform | Applicable | Praktische Evidence deferred/excluded by owner | Ownergrenzen dokumentiert; kein praktisches PASS und kein CI-Ersatz / evidence limits, no acceptance claim |
| P06 Sprache/Doku / language/docs | PASS Entwurf / draft | PASS Entwurf / draft | DE/EN, definierte Begriffe, Leserpfad, Textalternative / matching text access |
| P07 Guidance/Statistik | N/A historischer Planlauf / historical | T014 lokal angewendet / applied locally | Guidance/Register/Referenz80–125 ausgerichtet; Statistikrender bei autorisierter Lieferung offen / render pending authorized delivery |
| P08 Produktimplementierung / product implementation | Kein Auftrag im Planlauf / no authority during planning | T018–T052 eigener Auftrag / separately commissioned | Eigener Implementierungsauftrag, technische Startchecks/Sicherheitsartefakte und Quellenfrische; praktische Abnahme separat / separate implementation authority and start checks |

**Gate-Ergebnis:** Technische Auswahl und automatisierte begrenzte Machbarkeit
liegen vor; anderes Review bewertet die korrigierte Baseline. Vollständige
Plattform-/A11Y-/Featureabnahme bleibt offen. Ownergrenzen verschieben praktische
Nachweise, sie verwandeln sie nicht in PASS. Vor Produktstart Quellenausrichtung,
aktueller Herkunftsnachweis und Sicherheits-/Architekturstartchecks; ein eigener
Implementierungsauftrag bleibt erforderlich.

**Gate result:** technical choices and bounded automated proof are present; distinct
review evaluates the corrected baseline. Full practical acceptance remains open.
Owner limits defer evidence, never relabel it PASS. Before product start align
sources/provenance and perform security/architecture checks under separate authority.

## Projektstruktur / Project structure

Historischer Planungsstand — damals erzeugt / Historical planning output:
- `plan.md`, `research.md`, `data-model.md`, `quickstart.md`.
- `contracts/cmdlet-session.md`, `contracts/actions-terminal.md`.
- `checklists/plan-validation.md`.

Für spätere Produktumsetzung vorgesehen / Proposed for later product work:
- `src/ShowCommandTui400/`: Cmdlet, Aktions-/Ansichtszustand, Renderer/Terminaladapter.
- `tests/ShowCommandTui400.Tests/`: Verträge, State- und negative Sicherheitsfälle.
- `tests/feasibility/lh01/`: isolierte in-process Plattform-/Hilfsmittelnachweise.
- `docs/architecture/`: getrennte Sprache/MSL-, Runtime-, Framework-, Session-/Terminal-ADRs.
- `docs/security/adr/`: S-ADR für Eingabe/Anzeige/Sitzungsgrenzen.

Beim ursprünglichen Planlauf wurden weder Produktgerüst noch tasks.md erzeugt. Die vorgeschlagene Struktur
kann nach F01–07 revidiert werden; klare Adaptergrenzen verhindern Frameworklogik
im fachlichen Aktionsmodell. / The original planning run created no scaffold/tasks; refine layout
after proof. Adapter boundaries isolate UI framework from domain actions.

## Reihenfolge der späteren Arbeit / Subsequent work order

1. Isolierte technische Reparaturen/Bedien-/Restore-/Remap-/StopProcessing-Prüfungen
   geliefert; native Grenzen und technische Entscheidungen festhalten, anderes Review.
2. Anschließend Tasks ableiten und konsistent analysieren. Kein automatischer Folgelauf.
3. Vor eigener LH-01-Implementierung Quellen-/Governanceausrichtung und Startchecks.
4. Fachliche Plattform-/A11Y-/Featureabnahme separat mit den dokumentierten Ownergrenzen.
   LH-02 bleibt eigener Auftrag; volle LH-00-Abnahme nach LH-02, vor LH-03.

1. Record delivered technical proof, native assessment and choices with distinct review.
2. Generate tasks and analyse consistency under a separate request, never automatically.
3. Align sources and check readiness before separately commissioned implementation.
4. Keep practical/domain acceptance separate; preserve LH-02/LH-00 authority and order.

## Sicherheits- und Governance-Arbeit / Security and governance work

Applicable: NIST SSDF/CWE Top25, OWASP sichere Entwicklungsregeln, STRIDE/CIA-
Bedrohungsmodell (Angriffskategorien/Vertraulichkeit/Integrität/Verfügbarkeit),
CAPEC-Angriffsmuster, arc42-Querschnitt, S-ADRs, SAMM-Prozessverbesserung,
OpenSSF-Abhängigkeits-/Repositorybewertung. Aktions-Whitelist und Kontextvalidierung
sind getrennte Schutzschichten; Anzeige entkräftet Steuerzeichen und wertet nie Code aus.
Keine Secrets, privaten Variablen, Agentzustände oder Logs zur Veröffentlichung.

Applicable secure-development and threat/architecture evidence includes SSDF/CWE,
OWASP rules, STRIDE/CIA, CAPEC, arc42, security ADRs, SAMM and OpenSSF assessment.
Action allow-list plus context validation are separate controls; safe display never
evaluates code. Publish no secrets, private session values or local agent state.

Geplante Nachweise in `docs/security/`: MSL-Anwendbarkeit, Checkliste, Sprachregeln,
Threat Model, arc42, dependency-audit, supply-chain-evidence und S-ADRs im adr/-Ordner.
SBOM (Komponentenliste), VEX (Schwachstellenbetroffenheit) und SLSA/Provenance
(Buildherkunft) werden bei tatsächlichen Abhängigkeiten/Build/Lieferung belegt.
Lockfile/Hashes/Lizenz und transitive native Pfade prüfen; automatisches Dependency-
Monitoring samt SBOM-Verwendung planen, ohne heute Dienste oder Automation einzurichten.

Plan security evidence at the standard docs/security locations; audit dependencies,
locks/hashes/license/native transitive paths. SBOM/VEX/provenance and build-integrity
proof applies when components/build/distribution exist. Plan automated dependency
monitoring/SBOM use without configuring new services today.

N/A für Produkt-ASVS (kein Web-/API-/Authdienst), Produkt-AI-SBOM (keine KI-Runtime),
ZeroTrust und C3A/C5 für lokalen Betrieb ohne Remote-/Cloud-Dienst. Jeweils erneut
bewerten bei Scopeänderung; Tool-/Organisationscloud getrennt. Gesetzliche Anwendbarkeit
DS-GVO/KI-VO/CRA/NIS2/DORA bleibt Open in bestehendem regulatory-applicability:
Owner Thorsten, geeigneter Prüfer, Rollen/Land/direkt vs. vertraglich klären vor
betroffener Nutzung/Lieferung. Keine zweite Rechtsentscheidung oder Bildungs-Ausnahme.

Product ASVS/AI-SBOM/remote-cloud controls are N/A for this local non-web/non-AI UI;
revisit changed scope and assess tooling/organisation separately. Regulatory scope
remains Open in the existing record with qualified assessment before affected use
or delivery. Do not invent another legal decision or an educational exemption.

A11Y: Spec-Matrix und textuelle Zustände im Design erhalten. Tastatur automatisiert
geprüft; reale Terminal-/Screenreaderprüfung auf Ownerauftrag jetzt zurückgestellt,
Braillehardware-Nachweis wegen fehlender Hardware im privaten persönlichen Projekt
ausgeschlossen. Fehlende praktische Belege bleiben erkennbar, keine Konformitäts-
behauptung. Ownergrenzen sind verbindlich für die aktuelle Nachweisplanung.
Cross-Platform: Produkt-Cmdlet, heute keine neuen Wartungsskripte; Bash-/PS-Paar,
man-Page und WhatIf-Parität N/A mit Neubewertung bei neuen Skriptwerkzeugen. Falls
später solche Werkzeuge erforderlich, beide Varianten inkl. Strict Mode, Quoting,
DE/EN-Hilfe und sicherem Prüfmodus gemeinsam planen und prüfen.

Retain the accessibility matrix/design; automated keyboard proof is recorded.
Owner defers physical terminal/screen-reader tests and excludes Braille hardware
proof for lack of hardware. Do not claim conformance. Product cmdlet adds no maintenance scripts now, so script-pair/man-page/
WhatIf work is N/A. New script tools require paired safe-mode, quoting, strict-mode,
bilingual-help and parity proof.

Alle 14 Presets gelten gemäß Spec-Zuordnung; keine Installation oder Versionänderung.
Agent-Parität im ursprünglichen Planlauf: keine Änderung der fünf gemeinsamen Guidance-Dateien oder
Vorlagen/Constitution; bei späterer Regeländerung atomar synchronisieren. Kontext-
Skript fehlt in Installation; kein Ersatz-Verweisdokument (research D06).

The fourteen presets retain spec applicability and versions. In the original plan
run shared guidance/templates/constitution stayed unchanged; later changes require atomic
parity. Context script is absent; no redundant pointer artifact is created.

## Komplexität / Complexity tracking

Keine begründungslose Constitution-Abweichung. Bedingte Kandidaten sind keine
Genehmigung einer Abweichung; native/unsafe Pfade erhalten eigene Sicherheitsprüfung.
Keine unnötige zweite Runtime, Netzwerkdienste oder Datenbank.

No unjustified constitution deviation or waiver. Conditional candidates do not
approve unsafe boundaries; audit those independently. No extra runtime/service/database.

## Historische Dokumentationsauswirkung des Planlaufs / Historical planning documentation impact

**UpdateRequired:** Feature-Plan, Recherche, Datenmodell, Verträge und Prüfanleitung
DE zuerst/EN danach, ungefähr B2; technische Quelle dieser Plan, fachlicher Input LH-01,
Owner Thorsten. Leserpfad Spec → Plan → Research/Contracts/Quickstart → eigener
Machbarkeits-/Tasksauftrag. sourceOnly, kein Home-Sync. Gemeinsamer Bestands-Follow-up
FU-LH01-001 und Intake/Receipt/Review bleiben unverändert. Statistik80/100 beim
nächsten autorisierten Lieferpaket fortschreiben; kein Render/Commit jetzt.

UpdateRequired covers the bilingual feature design documents at B2. This plan is
the technical source, LH-01 domain source, Thorsten owner. Navigate spec→plan→research/
contracts/quickstart→separate proof/tasks authority. Source-only, no Home sync.
Preserve existing inventory follow-up and provenance; statistics await authorized delivery.

Einzelplan ist kein abgeschlossener Feature-Lauf; kein completion-report.md.
Ein Diagramm ist hier N/A, weil State-/Gate-Tabellen und vollständige Textabläufe
alle Beziehungen erklären; der Spec enthält bereits Mermaid mit Textalternative.

This partial design phase is not a completed feature run. No completion report;
text/state/gate tables fully explain relationships, so no additional diagram.

## Ausgeführtes Machbarkeitsinkrement / Executed feasibility increment

[Ergebnisse](feasibility/README.md), [Entscheidungen](feasibility/decisions.md),
[native Bewertung](feasibility/native-dependency-assessment.md),
[Ownergrenzen](feasibility/owner-validation-boundaries.md) und
[anderes Review](feasibility/independent-review.md) bilden den aktuellen Nachweis.
Der erste fehlgeschlagene Restorelauf bleibt im Archive historisch erhalten;
die korrigierte Baseline ist getrennt gehasht. / Linked evidence is current; initial
failed restoration remains historical with separate current payload hashes.

## Ausgeführte Startvorbereitung T001–T017 / Completed readiness preparation

DE: Lokale ADR-/Security-/Architekturarbeit, angewendete zentrale Projektzeile
und operative C#/msl-Zuordnung sind belegt. Herkunft beider Intakes regulär erneuert;
aktuelle vollständige unabhängige Reviews Ready. T016 gleicht nur geänderte
Herkunfts-/Governanceaussagen ab; technische Entscheidungen bleiben erhalten.
Aktuelle IDs, Validatoren und Grenzen stehen im
[Startnachweis](../../docs/validation/lh01/start-readiness.md). Statistik-/Homogenitätsdrift
bleibt bis zum autorisierten Commit-/Renderpaket offen (T061), kein falscher PASS.
Produktaufgaben ab T018 brauchen einen eigenen Auftrag; keine praktische Abnahme.

EN: Local ADR/security/architecture work, applied central row and operative C#/msl
are evidenced. Normal updates renewed both intakes; distinct complete reviews are
Ready. T016 reconciles only changed provenance/governance statements, preserving
technical choices. The readiness record contains current identities, validators and
limits. Statistics/homogeneity drift remains open until authorized commit/render
work (T061), never labelled Pass. Product tasks from T018 need a separate request;
this preparation grants no practical acceptance.

## Quellenabgleich 2026-10-21 / Source alignment

DE: Der vorherige Text behält seinen datierten Entwurfs-/Lieferkontext. Maßgeblich für die neue Quellenbewertung sind das aktualisierte LH-01, dessen Receipt und das eigene neue unabhängige Review. [GSDB3.4.4-Zuordnung](../../docs/planning/lh00-lh01-gsdb344-assessment.md) konkretisiert QG-01-002/004, AC-01-005, E01-06/07: 50 geänderte Kontrollpassagen sind einzeln auf Produkt-/Werkzeug-/Organisationsscope, Anwendbarkeit, Nachweise und offene Maßnahmen abgebildet. Assurance0.1.5 prüft Bindungen, keine Produktkonformität. Die tatsächlichen Versionen stehen in der aktuellen 14-Preset-Matrix; ältere Versionsangaben im Entwurf sind historisch.

Offene Rechts-/Rollen-/Providerentscheidungen bleiben Open, nicht belegte Umsetzung Not Assessed. N/A wird mit begrenztem Scope, Grund, Quelle, Owner, Gegenprüfung und Wiedervorlage geführt. SSDF-/CWE-/OWASP-Ausgaben, Sprachprofile, positive/negative Pfad-/Quellen-/Argumentprüfungen sowie gemessene Sicherheitsabdeckung sind vor dem jeweils betroffenen Gate nachzuweisen. CL-08-12 verlangt mindestens 85% Branch Coverage kritischer Module und 80% Schnittstellen-/kritische UI-Flow-Abdeckung; Fallzahlen oder grüne CI ersetzen keine Messung. Eine Ausnahme braucht einen menschlichen Entscheid. Quartals-/Anlassreview und Jahresprüfung am 3. Oktober bleiben getrennt. Nächste Kontextwiedervorlage spätestens 2027-01-10, früher bei geändertem Scope/Quelle oder betroffenem Abschluss-/Releasegate.

Technik bleibt managed C#14/MSL, Host-.NET10, Terminal.Gui2.5.0/dotnet, PS>=7.6.4 und in-process PSCmdlet für LH-01. NuGet System.Management.Automation7.6.4 liefert nur Kompilierassets; die laufende Sitzung liefert die Engine. Für LH-00 ist dies Kontext, keine neue Produktfunktion. Bestehende Tasks/Entscheidungen bleiben historisch; die neuen Folgeaufgaben sind offen. Keine Produktimplementierung oder neue Pilotfreigabe durch diesen Abgleich.

EN: Preserve prior dated design/delivery statements as history. The updated intake, receipt and its own new distinct review govern this source alignment. The linked assessment maps all 50 changed GSDB3.4.4 controls to separate product/tooling/organisation scopes, applicability, evidence and owned open actions. Assurance0.1.5 checks binding, not product compliance; use the current fourteen-preset matrix rather than historical version claims.

Unknown legal/role/provider facts stay Open and unproven implementation Not Assessed. Scoped N/A needs rationale, source, owner, distinct check and review trigger. Prove named SSDF/CWE/OWASP editions, language profiles, positive/negative boundary tests and measured coverage before the affected gate. CL-08-12 requires at least 85% critical-module branch coverage and 80% documented public-interface/critical-UI-flow coverage; case counts or green CI are not measurements. Human authority is required for exceptions. Preserve quarterly/event review plus annual 3 October deep review; next context review by 2027-01-10 or earlier on changes/affected closure.

Preserve the separate LH-01 technical choices and compile-only NuGet/host runtime boundary. These are context for LH-00, not a product feature. Existing tasks/decisions stay historical; new follow-up tasks remain open. No new implementation or pilot authority follows.

DE: Die exakten Produkt-/Genehmigungs-/Kommandobindungen in Issues #37–#39 und im Plattformmanifest bleiben unverändert. Neue Governance-Evidence ist kein rückwirkender Nachweis für diesen eingefrorenen Produktstand. Praktische Terminals/Screenreader Deferred, Braillehardware Excluded. Volle LH-00-Abnahme nach LH-02/vor LH-03.
EN: Keep the existing exact platform issue/manifest bindings. New governance evidence is not retroactive product proof. Retain practical evidence and full acceptance boundaries.

## Abgleich Dokumentationsrollout 24.10.2026 / Documentation rollout alignment

DE: Aktueller Quellenstand ist das erneut aktualisierte Intake mit eigenem Receipt und frischem unabhängigem Review. [Bewertung und Leserpfade](../../docs/planning/lh00-lh01-preset-doc-rollout-20261024-decisions.md) binden die veröffentlichte14er-Kohorte. Frühere datierte Versions-/Nachweisaussagen bleiben historisch. Authoring0.3.10, Review0.2.7, Sequencing0.2.11 und Assurance0.1.8 liefern Leserhilfen und aktuelle Paketidentitäten; sie ändern weder Produktumfang, Status-/Receipt-Schemas noch Ausführungsrechte. Die zusätzliche Legacy-Generatorannahme in den Authoringvalidatoren lockert keine Hash-/Pfad-/Statusprüfung.

Für bestehende FR-00-001/002/005/007/008/009 beziehungsweise QG-01-001/002/004 und AC-01-005 gelten: Starter ausfüllen, nicht als Nachweis übernehmen; Prompts als Agenteneingabe statt Shell-Kommandos lesen; Beispiele begründen keinen fremden Umfang oder zusätzliche Genehmigungsrunde bei bereits passender Autorität. Nutzerleitfäden, tatsächliche Paketversion und Test-/Freigabenachweis sind getrennte Quellen. DE/EN-B2- und Strukturtests ergeben keine praktische A11Y-Konformität.

Stabile Rollen folgen model-routing.json, nicht Installationspriorität oder beliebigen coding-review-Beispielen. Der aktuelle Chat wird durch die Installation nicht umgestellt. Automatische Profile sind nur für Codex/Antigravity implementiert; Claude/Copilot/OpenCode haben Policy-Bezeichnungen ohne automatische Adapter. Ein Routing-Refresh prüft Discovery-Metadaten (verfügbare Modellangaben), nicht den Modellzugang. Ein modellaufrufender Preflight (Vorprüfung) kann Kontingent verbrauchen und braucht passende Laufautorität. Aligned ist deshalb keine Behauptung eines ausgeführten Zugangs-/Qualitätstests.

GSDB3.4.4, die bestehende50-Kontroll-Zuordnung und alle offenen Umsetzungs-/Rechtsnachweise bleiben unverändert. Vorhandene passende Nachweise werden mit genauem Scope wiederverwendet, keine neue Erfüllung abgeleitet. C#14/MSL, Host-.NET10, Terminal.Gui2.5.0/dotnet, PS>=7.6.4, in-process PSCmdlet und Compile-only-NuGet/Host-Runtime-Trennung bleiben technische Entscheidungen. Die Plattformbindungen #37–#39 und Ready/Eligible-Serienstruktur bleiben exakt erhalten. Kein Produktlauf, Folgefeature, Adapterbau, Installation, Release oder neue Risiko-/Pilotabnahme. Praktische Terminals/Screenreader Deferred, Braillehardware Excluded; vollständige LH-00-Abnahme nach LH-02/vor LH-03.

EN: The updated intake, its receipt and fresh distinct review govern current provenance. The linked assessment binds the published fourteen-package documentation cohort; older dated versions/evidence remain historical. Current reader-help/package identities do not change product scope, receipt/state schemas or execution authority; legacy-generator recognition preserves strict validation.

Existing governance requirements cover completed templates versus proof, prompts versus shell commands, bounded examples and reuse of sufficient current authority. A guide, released package identity and actual field-test/approval evidence are separate. Readable bilingual structures do not prove practical accessibility. Use model-routing.json roles independently of installation priority; generic coding-review examples cannot weaken stronger command roles. Installation does not switch the current chat. Automatic profiles are implemented only for Codex/Antigravity; other integrations retain policy labels without automatic adapters. Refresh enumerates discovery metadata, not model access. A model-calling preflight may consume quota and requires matching run authority; Aligned does not claim access or quality proof.

Reuse unchanged GSDB/control evidence with open implementation/legal work and all technical, frozen-platform, series, pilot and practical acceptance limits. No new product run, adapter, future feature, installation, release or human risk/pilot acceptance follows.
