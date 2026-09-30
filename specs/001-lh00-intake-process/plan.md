# Implementierungsplan: LH-00-Prozess / Implementation Plan: LH-00 process

**Feature**: `001-lh00-intake-process` · **Datum / Date**: 2026-09-30
**Git-Branch / Git branch**: `main` · **Basis / Base**: `88517c13815cf06a9b60d3a5b9c85e1e52f0649f`
**Eingabe / Input**: [Spezifikation / Specification](spec.md), fachlich ausschließlich
[LH-00](../../intakes/LH-00.md), Profil `show-commandtui400-de-en`.

## Zusammenfassung / Summary

Der Prozess verwendet die installierten Werkzeuge für Lastenheft-Erstellung,
unabhängiges Review und Serienverwaltung. Markdown enthält lesbare Regeln; JSON
enthält maschinenlesbare Herkunfts-, Zustands- und Abhängigkeitsnachweise. Ein
Receipt ist ein Herkunftsnachweis mit Prüfsummen. Eine Collection ordnet
Dokumentrollen und Ablagen zu; eine Serie benennt ihre Mitglieder ausdrücklich.
Geplant ist `SeriesManifest`, zunächst nur mit dem bestehenden LH-00.

The process reuses installed authoring, independent-review and sequencing tools.
Markdown holds readable rules; JSON holds provenance, state and dependency
evidence. A receipt records provenance and content hashes. A collection maps
document roles and storage; a series names its members explicitly. The selected
mode is SeriesManifest, initially containing only the existing LH-00.

Dieser Auftrag erstellt Entwurfsdokumente. Umsetzung, aktive Collection-/Seriendateien
und weitere Lastenhefte werden nicht gestartet. Vor Serienaktivierung muss **B-01**,
der belegte Validatorwiderspruch beim einzigen aktiven Mitglied, behoben und erneut
geprüft sein. Vier Plattformnachweise, Hilfsmittelprüfungen, Übersetzungen und
angewendete zentrale Registerausrichtung bleiben Voraussetzungen der Prozessabnahme.

This request creates design documents. It does not start implementation, create
active collection/series files or author further intakes. Before series activation,
resolve and retest **B-01**, the demonstrated validator conflict for a single active
member. Four-platform evidence, assistive checks, translations and applied central
registry alignment remain conditions of process acceptance.

## Technischer Kontext / Technical Context

| Aspekt / Aspect | Entscheidung / Decision |
|---|---|
| Language/Version | Markdown, JSON, vorhandenes Bash 3.2 und PowerShell 7, Python 3 für Validatoren. Produktsprache, Framework, MSL und Mindest-PowerShell bleiben außerhalb dieses Plans offen. / Existing Bash 3.2 and PowerShell 7, Python 3 for validators; product language, framework, MSL and minimum PowerShell remain undecided outside this plan. |
| Primary Dependencies | Spec Kit 0.12.8, Authoring 0.3.5, Review 0.2.3, Sequencing 0.2.6; explizite 14-Preset-Matrix / explicit fourteen-preset matrix. |
| Storage | UTF-8-Dateien, normalisierte SHA-256-Bindungen, Versionsarchive und getrenntes fachliches Archiv; keine Datenbank / UTF-8 files, normalized hashes, version archives and separate domain archive; no database. |
| Testing | Beide Shell-Validatoren, isolierte positive/negative Prozessfälle, anderes Review, vier Umgebungsprotokolle / Paired validators, isolated positive/negative process cases, another reviewer, four environment reports. |
| Target Platform | Mac A, Mac B, Windows 11 nativ, Ubuntu 24.04 unter WSL2; jeweils konkrete Versionen erfassen / Capture actual versions per environment. |
| Project Type | Repositorybasierter Dokumentationsprozess; kein TUI-Produktgerüst / Repository-based documentation process; no product scaffold. |
| Performance Goals | Keine Zeit-/Durchsatzvorgabe in LH-00; messbar sind 24 FR, neun Quell-AC und 4/4 erfolgreiche Prozessumgebungen / No latency/throughput target; measure requirement coverage and 4/4 process environments. |
| Constraints | Kein Create-Overwrite, nur beauftragtes Update/Delete, Pfade im Repo, keine Geheimnisse, DE/EN, Textzugang, keine automatische Folgeaktion / No Create overwrite; authorized update/delete, contained paths, no secrets, bilingual text access, no automatic next action. |
| Scale/Scope | Ein vorhandenes Intake; acht Planeinträge, sieben davon noch keine Intakes oder Serienmitglieder / One existing intake; eight order entries, seven not yet intakes or series members. |

Im Planungslauf am 2026-09-30 lokal erfasst: macOS 27.0.0, PowerShell 7.6.6 Core,
Python 3.14.7, Bash 3.2.57.
Das ist kein Produktminimum und keine Zuordnung zu Mac A/B. `python3` muss auch
unter Windows tatsächlich funktionieren; die vorhandenen PowerShell-Validatoren
rufen genau diesen Namen auf. `py -3` allein genügt nicht.

The planning run on 2026-09-30 observed macOS 27.0.0, PowerShell 7.6.6 Core,
Python 3.14.7 and Bash 3.2.57. These versions neither define product minimums
nor identify Mac A/B.
Windows must expose a working python3 executable because installed PowerShell
validators call that name. Having only py -3 is insufficient.

## Verfassungsprüfung / Constitution Check

Vor Recherche: gültiger Intake, Receipt und Review, ausdrücklicher Plan-Auftrag
und begrenzter Scope. Nach Entwurf: alle technischen Planungsfragen entschieden,
keine ungerechtfertigte Abweichung. **Planung bestanden; Umsetzung und
Prozessabnahme bleiben offen.** Das ist keine Umsetzungsfreigabe.

Before research: current intake, receipt and review, explicit planning authority
and bounded scope. After design: all technical planning questions have decisions
and there is no unjustified deviation. **Planning passes; implementation and
process acceptance remain open.** This does not authorize implementation.

Maßgeblich ist die Zeile `RiderProjects/Show-CommandTui400` im
[Level-2-Register](../../constitution.md#level-2-project-environment-registry--level-2-projektumgebungsregister):
Konzeptphase, PowerShell 7 auf macOS/Linux/Windows, Produkttechnik/MSL offen;
Setup-Prüfungen statt Produkt-Build; DE/EN B2, A11Y, Statistik 80/100, fünf
Guidance-Flächen, 14 Presets. Generische Vorlagenannahmen zu einem Ausbildungsjahr
führen keine zusätzliche Zielgruppenanforderung ein.

The matching Level-2 registry row governs concept-stage PowerShell 7 across three
OS families, undecided product technology/MSL, setup checks instead of product
builds, DE/EN B2, accessibility, statistics 80/100, five guidance files and fourteen
presets. Generic template wording about a training year adds no audience requirement.

| Gate | Vorher / Before | Nachher / After | Nachweis / Evidence |
|---|---|---|---|
| Quelle und Autorität / Source and authority | PASS | PASS | LH-00/Spec unverändert; keine Folgeautorität / unchanged intake/spec; no downstream authority. |
| Receipt/Review | PASS | PASS | Erneute Validatorläufe in [Planprüfung](checklists/plan-validation.md) / revalidation recorded. |
| Entwurf / Design | Applicable | Fulfilled for design | Recherche, Datenmodell, Verträge / Research, model, contracts. |
| DE/EN, A11Y | Applicable | Partly Fulfilled | Textentwurf vorhanden, praktische Hilfsmittelprüfung offen / text design present; assistive checks outstanding. |
| Collection-Lebenszyklus / Lifecycle | Applicable | Open | B-01 vor Active schließen / resolve B-01 before Active. |
| Plattformen / Platforms | Applicable | Open | M-01–M-04 in Quickstart; lokale Smokes sind keine Abnahme / local smokes are not acceptance. |
| Security/Architektur / Architecture | Applicable | Partly Fulfilled | [Governance-Matrix](checklists/plan-governance.md), Umsetzungsnachweise geplant / implementation evidence planned. |
| Parität, Docs, Statistik / Parity, docs, statistics | Applicable | Partly Fulfilled | Guidance erhalten; Navigation ergänzt; Statistik beim Lieferpaket / guidance preserved; navigation updated; statistics with delivery. |

## Projektstruktur / Project Structure

| Artefakt / Artifact | Zweck / Purpose |
|---|---|
| [research.md](research.md) | Entscheidungen, Alternativen, Toolgrenzen / Decisions, alternatives, tool limits. |
| [data-model.md](data-model.md) | Identitäten, Beziehungen, Zustände / Identities, relations, states. |
| [contracts/collection.md](contracts/collection.md) | Vier Rollen, sechs Pfade, Serie und Migration / Four roles, six paths, series and migration. |
| [contracts/process.md](contracts/process.md) | Nutzerkommandos, Autorität, Hashes, Fehler / User commands, authority, hashes, failures. |
| [quickstart.md](quickstart.md) | Lesende Prüfungen und später autorisierte Prozessfälle / Read-only checks and later authorized process cases. |
| [checklists/plan-governance.md](checklists/plan-governance.md) | Anwendbarkeit, Owner, Reviewer, Nachweise / Applicability, owner, reviewer, evidence. |
| [checklists/plan-validation.md](checklists/plan-validation.md) | Tatsächlich ausgeführte Prüfungen / Checks actually executed. |
| [checklists/process-quality.md](checklists/process-quality.md) | Dokumentprüfung mit Durchführungshinweisen, Korrekturen und Fundstellen / Requirements review with instructions, corrections and references. |

Spätere Umsetzungsorte: `requirements/`, `specs/intake-series/lh00-process/`,
vorhandene Policy und Profilzuordnung, Prozessdokumentation und fünf gezielt
übernommene `.specify/scripts/powershell/`-Basisskripte. Bash bleibt erhalten.
Keine neuen Produktquellen, Datenbank, Server, Generatoren oder Ersatzvalidatoren.
`tasks.md` entsteht erst durch einen gesonderten Tasks-Auftrag.

Later implementation touches requirements/, one series, existing policy/profile
mapping, process documentation and five narrowly imported PowerShell base scripts,
preserving Bash. It adds no product source, database, server, generator or
replacement validator. A separate Tasks request creates tasks.md.

## Phase 0 und Phase 1 / Research and design

Die [Recherche](research.md) entscheidet D-01–D-08. Die Umsetzung wird so zerlegt:

1. **Kompatibilität:** Ready/Eligible, Active/Active, Idle/leer und Completed/Archiv
   in allen drei Collection-Validatoren und beiden Shells prüfen. B-01 vor
   Aktivierung schließen; versionierte Korrekturen gehören in die Preset-Quellen.
2. **Werkzeugparität:** PowerShell-Basis derselben Version isoliert vergleichen
   und kontrolliert übernehmen; Herkunft, Hilfe und man-Seite gemeinsam liefern.
3. **Repräsentativer Ablauf:** zunächst vollständige vorhandene Skriptfläche
   prüfen; dann im isolierten Fixture benanntes Beispiel-Issue → Create → Receipt
   → anderes Review → Auswahl. Erst negative Fälle belegen, danach den gültigen
   Ablauf; erwartete Fehler getrennt protokollieren. LH-00 nicht als Testziel ändern.
4. **Migration:** Index, Konfiguration, Baseline-Verweis, Manifest, Receipt und
   Journal gemeinsam vorbereiten und validieren. Gebundene Policy-/Profil-/Guidance-
   Änderungen benötigen autorisierte Aktualisierung und frisches Intake-Review.
5. **Abnahme:** Übersetzungen und zentrale Ausrichtung belegen; gesamte Strecke
   separat auf vier Umgebungen ausführen. Danach bewertet der Owner alle neun AC.

Research resolves D-01–D-08. Implementation proceeds through compatibility testing
and a versioned B-01 fix; narrow same-version PowerShell integration with provenance
and help; a representative isolated issue-to-selection flow after checking the full
existing script surface; explicit negative cases before the valid path; staged
collection migration with fresh review after bound-input changes; and translations,
central alignment plus complete four-environment acceptance. Never mutate LH-00
as a test target. The owner assesses all nine AC only after evidence exists.

## Anforderungsabdeckung / Requirements coverage

Owner aller Zeilen: Thorsten Hindermann. Autor je Vorgang dokumentieren; Reviewer
ist ein anderer, namentlich zu protokollierender Mensch oder Agent. Seine konkrete
Beauftragung erfolgt vor dem jeweiligen Review. Diese Zuordnung belegt Planung.

Thorsten Hindermann owns all rows. Record each operation's author and a different
named human or agent as reviewer, commissioned before that review. This mapping
proves planning coverage only.

| Quelle / Source | Spec-FR | Umsetzung / Implementation | AC / Evidence |
|---|---|---|---|
| FR-00-001 | FR-001, FR-002 | Werkzeugliste, begrenzter Aufruf / Tool inventory, bounded invocation | AC-00-001; E01 |
| FR-00-002 | FR-003, FR-004 | Profil und Rollen / Profile and roles | AC-00-001, AC-00-002, AC-00-007; E01/E02 |
| FR-00-003 | FR-005, FR-006 | Baseline und Pflichtinhalt / Baseline and required content | AC-00-002, AC-00-003; E02 |
| FR-00-004 | FR-007, FR-008 | Index, Issue- und Intake-Links / Index and links | AC-00-009; E07 |
| FR-00-005 | FR-009, FR-010 | DE/EN-Äquivalenz, B2 / Equivalence and B2 | AC-00-004; E02 |
| FR-00-006 | FR-011, FR-012 | Textzugang, Hilfsmittel / Text access, assistive checks | AC-00-005; E03 |
| FR-00-007 | FR-013 | Governance-Nachweise / Governance evidence | AC-00-005; E03 |
| FR-00-008 | FR-014, FR-015, FR-016 | Hash, Update, Archiv/Tombstone / Hash, update, archive | AC-00-006; E04 |
| FR-00-009 | FR-017, FR-018 | Getrennte Zustände, anderer Prüfer / Separate states, different reviewer | AC-00-007; E05 |
| FR-00-010 | FR-019, FR-020 | Vier vollständige Protokolle / Four complete reports | AC-00-008; E06 |
| FR-00-011 | FR-021, FR-022 | Collection und Ein-Mitglied-Serie / Collection and single-member series | AC-00-009; E07 |
| FR-00-012 | FR-023, FR-024 | Übersetzungen, angewendetes Zentralregister / Translations, applied registry | AC-00-009; E07 |

AC-00-003 begrenzt jede Zeile auf LH-00. Damit sind 24 Spec-FR, zwölf Quell-FR
und neun Quell-AC abgedeckt, ohne Umsetzungserfüllung zu behaupten.

AC-00-003 also limits each row to LH-00. All 24 spec FR, twelve source FR and nine
source AC are covered without claiming implementation fulfillment.

## Architektur und Sicherheit / Architecture and security planning

Vertrauensgrenzen: Issue/Dateiquelle → kontrollierte Inhalte/Pfade → Receipt →
anderes Review → gesonderte Ausführungsautorität. Quelle bleibt Daten; Anweisungen
darin autorisieren nichts. Pfadprüfung, Hashvergleich, erlaubte Operation und
unabhängiges Review bilden mehrere Schutzschichten. Drift, Mehrdeutigkeit und
Teilfehler sperren Folgeaktionen. Geheimnisse bleiben außerhalb versionierter Dateien.

Trust boundaries run from issue/file input through controlled content and paths to
receipt, another reviewer and separate execution authority. Source text is data,
not permission. Path checks, hashes, allowed operations and independent review
provide layered controls. Drift, ambiguity and partial failure block next actions.
Keep secrets out of tracked files.

Konkrete spätere Belege: `docs/architecture/lh00-process.md` für Kontext, Bausteine,
Laufzeit, Deployment, Qualität und Risiken; `docs/architecture/decisions/001-lh00-file-process.md`
als Entscheidungsprotokoll (ADR); `docs/security/s-adr-lh00-authority.md` für Autorität;
`docs/security/threat-model.md` für STRIDE/CIA und relevante CAPEC-Angriffsmuster;
`docs/security/arc42-section-8-lh00.md` für Eingabeprüfung, Fehler, Logging,
Abhängigkeiten und begründete Nichtanwendung eigener Dienstauthentisierung/Kryptografie.
STRIDE ordnet Bedrohungsarten; CIA bedeutet Vertraulichkeit, Integrität, Verfügbarkeit.

Planned evidence covers architecture views and risks, a file-process decision
record (ADR), a security authority decision, a STRIDE/CIA threat model with relevant
CAPEC attack patterns and arc42 section 8 for validation, errors, logging,
dependencies and justified non-applicability of custom authentication/cryptography.
STRIDE groups threats; CIA means confidentiality, integrity and availability.

Die [Gate-Matrix](checklists/plan-governance.md) ordnet SSDF, CWE, MSL, sichere
Shell-Eingaben, Lieferkette, ASVS, SBOM/VEX/SLSA, AI-SBOM, OpenSSF, SAMM,
Zero Trust, C3A/C5 und Regulatorik mit Owner, Reviewer und Wiedervorlage zu.
KI bleibt Entwicklungswerkzeug; es gibt keine Produkt-Security-Abnahme.

The gate matrix assigns standards, ownership, review and reassessment. AI remains
development tooling; no product-security acceptance is claimed.

## Plattform-, A11Y- und Agentenparität / Platform, accessibility and agent parity

Die fünf PowerShell-Basisskripte und ihre Bash-Gegenstücke bilden eine Einheit.
Upstream-Herkunft und Hashes erhalten; beide Aufrufarten in
`docs/man/lh00-process.1.md` mit DE/EN-Hilfe dokumentieren. Bestehende lesende
Validatoren benötigen keinen Mutationsmodus. Falls eine belegte Lücke einen
Projektwrapper erfordert, ist `Test-Lh00Process` vorgesehen: `Get-Verb Test`
prüfen; `.sh`/`.ps1`, `--dry-run`/`-WhatIf`, man-Seite und bilinguale PowerShell-
Kommentarhilfe gemeinsam planen. Bash: Quoting, `set -euo pipefail`, Bash 3.2;
PowerShell: StrictMode, `-NoProfile`, leeres HOME unter Windows behandeln.
Kein `eval`/`Invoke-Expression` auf unvertraute Inhalte. Beide Varianten manuell
prüfen, Bash auf macOS/Linux und PowerShell auch nativ auf Windows.

Treat five PowerShell base scripts and their Bash counterparts as one unit,
preserving provenance and hashes and documenting both invocation paths with
bilingual help. Existing read-only validators need no mutation mode. Only a
demonstrated gap justifies a Test-Lh00Process wrapper, with approved-verb check,
paired scripts, dry-run/WhatIf, man page, bilingual comment help, safe quoting,
strict modes, NoProfile, Windows HOME handling and manual tests on both shells,
including native Windows. Never evaluate untrusted content.

Nachweise: `docs/cross-platform/lh00-parity.md`,
`docs/accessibility/lh00-process.md`, `docs/agent-parity/lh00-parity.md`.
A11Y umfasst Tastatur, Screenreader, Braille, Textbrowser für Dokumentation, verständliche
Überschriften/Links, Status ohne Farbe, DE/EN B2 und Begriffserklärung.
Markdown-Strukturprüfung ersetzt keine praktische Hilfsmittelprüfung.

Evidence covers shell and agent parity, keyboard, screen reader, Braille, text-browser
access to documentation, clear headings/links, non-color-only state, DE/EN B2 and explained terms.
Markdown structure checks do not replace assistive-technology testing.

Später geänderte gemeinsame Regeln atomar in `AGENTS.md`, `CLAUDE.md`, `GEMINI.md`,
`.github/copilot-instructions.md` und `.github/agents/copilot-instructions.md`
pflegen. Bei Prinzipänderungen auch beide Constitutions und betroffene Projektvorlagen
angleichen. Alle fünf Integrationen erhalten. Jetzt bleibt gebundene Guidance
unverändert; dieser Plan ist die technische Informationsquelle.

Later shared-rule changes update all five guidance files atomically, plus both
constitutions and affected project templates for principle changes. Preserve all
five integrations. Bound guidance remains unchanged now; this plan is the technical
source of information.

## Presets, Dokumentation und Statistik / Presets, documentation and statistics

Die [Versionsmatrix](../../scripts/config/spec-kit-project-statistics-governance-presets.json)
bleibt maßgeblich: security 0.6.2; secure-development-assurance 0.1.3;
architecture 0.5.2; isaqb-architecture 0.2.2; a11y 0.4.3; cross-platform 0.2.2;
agent-parity 0.4.2; model-routing 0.1.4; intake-authoring 0.3.5; intake-review 0.2.3;
intake-sequencing 0.2.6; autonomous-run 0.4.4; parallel-autonomous-run 0.2.6;
project-statistics 0.1.0. Alle Kurznamen tragen den Zusatz `-governance`.

The linked fourteen-preset matrix governs; all short names above end in -governance.
This explicit project profile overrides the generic eight-preset default and grants
no execution authority. The plan performs no preset upgrade.

**Documentation Impact: `UpdateRequired`.** Owner: Thorsten Hindermann.
Klasse: Level-2-Prozessentwurf; Verteilung `sourceOnly`, kein Home-Sync.
Zielgruppe: Owner, Autoren, andere Reviewer und Implementierende ohne Spec-Kit-
Vorkenntnisse. Leserpfad: README → Spec → Plan → Recherche/Daten/Verträge →
Quickstart → spätere Tasks. LH-00 bleibt fachliche Quelle; technische Entscheidungen
stehen hier. DE/EN jeweils in derselben Datei. Links und Struktur lokal prüfen;
Plattformbeispiele später nachweisen. Historischen Kontext erhalten; FU01–FU07
aus der Governance-Zuordnung vor Abnahme schließen bzw. ihren Status belegen.
Reevaluation bei Input-, Tool-, Umfangs-, Liefer- oder Nachweisänderung.

Documentation impact is UpdateRequired, owned by Thorsten Hindermann. Source-only
Level-2 designs serve owners, authors, other reviewers and implementers without
assumed Spec Kit knowledge. Navigation runs from README through specification and
plan to design, quickstart and later tasks. LH-00 remains the domain source; this
package owns technical decisions. Each file has both languages. Check links and
structure locally, prove platform examples later, preserve history and resolve or
evidence the existing FU01–FU07 items before acceptance. Reassess for changed inputs,
tools, scope, delivery or evidence.

Statistikprofil 2: 80 konservativ, vorläufig 100 Thorsten-Solo für Konzept/Scripting;
125 nur bei späterer C#/.NET-Entscheidung neu bewerten. Das Planpaket im nächsten
autorisierten Lieferpaket seriell im Ledger erfassen und den vorhandenen Renderer
nutzen. Keine manuell erfundenen Zahlen. Git-Lieferdichte ist weder Zeit- noch
Qualitätsmessung. Reinen Datumsdrift bei Read-only-Prüfung getrennt ausweisen.

Keep Profile 2 at 80/100, reassessing 125 only if C#/.NET is selected. Record this
plan package serially in the next authorized delivery ledger and use the existing
renderer. Invent no metrics. Git delivery density measures neither effort nor
quality. Report date-only drift separately during read-only checks.

## Phase 2: Übergabe und sichere Grenze / Handoff and safe boundary

Nächster beauftragbarer Schritt: `speckit-tasks`. Vor Umsetzung offene Gates,
aktuelle Hashes und benannten Schreibumfang erneut prüfen. Gemeinsame Dateien,
Nachweise, Versionen und Statistik haben jeweils einen Writer. Bei Abbruch zuerst
laufende Operation und Journal prüfen; Fortsetzung benötigt ausdrücklichen Auftrag.

The next separately requestable step is speckit-tasks. Recheck gates, hashes and
the named write set before implementation. Shared files, evidence, versions and
statistics each have one writer. Inspect in-flight operations/journals after
interruption and resume only under explicit authority.

Autonome Lieferung/Kampagnen sind **N/A**. Falls später beauftragt, vor
Implementierung reviewed Gate-Requirements, Run-State-Index und Phasennachweise
erstellen; lokale Prüfung, Remote-Review, PreMerge/PostMerge getrennt binden.
Kommandos und Runner aus tatsächlichen Workflows/-Logs gewinnen. Commit, Push,
PR, Merge, Admin-Bypass und zentrale Änderungen brauchen passende Autorität.

Autonomous delivery/campaigns are N/A. If commissioned later, prepare reviewed
gate requirements, run-state index and phase evidence before implementation;
separate local, remote-review and pre/post-merge evidence. Derive commands and
runners from actual workflows/logs. Commit, push, PR, merge, bypass and central
changes require matching authority.

## Komplexität und Abschluss / Complexity and completion

Keine zusätzliche Anwendungsschicht und keine gerechtfertigte Verfassungsverletzung.
B-01 bleibt offen. Das Spec-Diagramm mit Textalternative reicht aus; Tabellen
erklären den Dateivertrag. Ein einzelner Plan-Befehl erzeugt keinen
Feature-`completion-report.md`.

No extra application layer or justified constitution violation is needed. B-01
remains open. The specification's diagram with text alternative suffices; tables
explain the file contract. An individual Plan command creates no feature
completion-report.md.
