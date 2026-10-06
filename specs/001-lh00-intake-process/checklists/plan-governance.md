# Governance des Plans / Plan governance

Stand / Date: 2026-09-30. Owner aller Zeilen: Thorsten Hindermann. Autor dieses
Plans: ausführender Codex-Agent. Reviewer der heutigen Strukturprüfung: derselbe
Agent, ausdrücklich keine unabhängige Abnahme. Für Umsetzung/Abnahme ist ein
anderer benannter Mensch oder Agent erforderlich. `Applicable`, `N/A`, `Open`
beschreiben Anwendbarkeit; Erfüllung ist eine getrennte Bewertung.

Thorsten Hindermann owns all rows. The executing Codex agent authored and
self-checked this plan; this is not independent acceptance. Implementation and
acceptance require another named reviewer. Applicability and fulfillment are separate.

Die genannten Zielpfade sind geplante Umsetzungsbelege, noch keine vorhandenen
Nachweise. Für alle offenen Punkte: Owner Thorsten, nächster Schritt passende
Umsetzung/Prüfung beauftragen, fällig vor genanntem Gate; Wiedervorlage spätestens
2026-10-12 oder früher bei Scope-/Tool-/Quellenänderung. Kein Risiko ist hier
menschlich akzeptiert. Bestehende FU01–FU07 behalten ihre ursprünglichen Owner,
Fristen und Grenzen.

Target paths below are planned evidence, not existing proof. For open items,
Thorsten commissions matching implementation/review before the named gate;
reassess by 2026-10-12 or earlier on changed scope/tools/sources. This plan accepts
no risk on behalf of a human. Existing FU01–FU07 retain their ownership/deadlines.

| Checkpoint | Anwendbarkeit / Applicability | Umsetzung / Fulfillment | Begründung, Nachweis und Trigger / Rationale, evidence and trigger |
|---|---|---|---|
| Umfang und Authority / Scope and authority | Applicable | Fulfilled | Plan beschränkt auf LH-00; keine aktiven Konfigurationen, Umsetzung oder Lieferung / Plan only, no active setup, implementation or delivery. |
| Input-Frische / Input freshness | Applicable | Fulfilled | Receipt/Review validiert; plan-validation.md. Bei Quelländerung neu prüfen / Revalidate on source change. |
| Architektur / Architecture | Applicable | Partly Fulfilled | Dateimodell/Verträge vorhanden; später `docs/architecture/lh00-process.md` und ADR; vor Implementierung / Model/contracts present; architecture views and ADR before implementation. |
| NIST SSDF, CWE Top 25 | Applicable | Partly Fulfilled | Pfad-/Eingabevalidierung, Berechtigungen, Herkunft, sichere Fehler geplant. `docs/security/security-checklist.md`, `docs/security/threat-model.md`; vor Mutation / Validation, authority, provenance and safe failures planned; evidence before mutation. |
| CWE-Zuordnung / CWE mapping | Applicable | Partly Fulfilled | Relevante Klassen CWE-22/78/94/862: Pfadausbruch, Shell-/Code-Injektion, fehlende Autorisierung; enthaltene Pfade, Daten statt Code, ausdrückliche Befugnis / Path traversal, command/code injection and missing authorization; containment, data-only inputs, explicit authority. Aktuelle Top-25-Zugehörigkeit bei Security-Review prüfen / Check current ranking during security review. |
| MSL / Product language | Open | Not Assessed | Produkttechnik bleibt unknown. `docs/security/msl-applicability.md` bei Technikentscheidung; Shellprozess bestimmt keine Produktsprache / Assess at product technology decision, not from process shells. |
| Sichere Shellregeln / Secure shell rules | Applicable | Not Fulfilled | `docs/security/secure-coding-language-rules.md`: Quoting, StrictMode, no eval, NoProfile, sichere Pfade; vor Skriptübernahme / Before script integration. |
| STRIDE/CIA, CAPEC, S-ADR, arc42 §8 | Applicable | Partly Fulfilled | Plan benennt Grenzen, Schutzschichten und konkrete Dateien; Bedrohungsreview vor Migration / Plan names boundaries, layers and evidence; threat review before migration. |
| OWASP Cheat Sheets / Proactive Controls | Applicable | Partly Fulfilled | Eingabeprüfung, Least Privilege, sichere Fehler für Prozess auswählen; keine Webanforderungen importieren / Apply input, least-privilege and safe-failure guidance without importing web scope. |
| ASVS | N/A | Not Assessed | Kein Web-/API-/Authentifizierungsdienst. `docs/security/asvs-verification.md` mit Begründung; Neubewertung bei solchem Dienst / No such service; reassess if added. |
| SBOM, VEX, SLSA | N/A | Not Assessed | Kein auslieferbares Produktartefakt in Plan. Toolherkunft bleibt anwendbar; `docs/security/supply-chain-evidence.md`, vor Distribution neu prüfen / No distributable product; tool provenance still applies; reassess before distribution. |
| AI-SBOM | N/A | Not Assessed | KI nur Entwicklungswerkzeug; keine KI-Produktlaufzeit. Bei Änderung sieben G7/BSI-Cluster bewerten / Development tooling only; assess seven clusters if runtime AI is introduced. |
| Abhängigkeiten, OpenSSF / Dependencies, OpenSSF | Applicable | Not Fulfilled | `docs/security/dependency-audit.md` und Supply-chain-Datei: Pins/Hashes vor Übernahme. Vorhandene Update-Automation erheben, fehlende als Open; keine wirksame Renovate/Dependabot-Konfiguration behauptet / Inspect actual update automation; do not assume it exists. Dependency-Track/SBOM-Ingestion bei künftigem Build prüfen / Assess ingestion with future builds. |
| Zero Trust | N/A | Not Assessed | Kein neuer entfernter Dienst; `docs/security/zero-trust-applicability.md`. Bei neuer Remote-Integration prüfen / No new remote service; reassess remote integration. |
| BSI C3A / C5 | N/A | Not Assessed | Keine Cloudwahl/-bereitstellung. `docs/security/cloud-autonomy-applicability.md`, `docs/security/cloud-compliance-assurance.md`; bei Providerentscheidung prüfen / No cloud deployment/selection; reassess provider choices. |
| OWASP SAMM | Applicable | Not Fulfilled | `docs/security/samm-assessment.md`: Owner, unabhängiges Review, wiederholbarer Prozess; vor Prozessabnahme / Ownership, review and repeatable process before acceptance. |
| DS-GVO / KI-VO / NIS2 / CRA / DORA | Open | Not Assessed | Produkt, Entwicklungswerkzeuge und Organisation getrennt mit Jurisdiktion, Rolle, direkten/vertraglichen Pflichten, offizieller Quelle, Owner, anderem Reviewer, Evidence und Follow-up erfassen. Ausbildung/AI-SBOM N/A sind keine Ausnahme. `docs/security/regulatory-applicability.md`; vor Foundation-Abschluss, erneut bei Distribution/Markt/Kunden/Cloud/KI-Laufzeit / Separate product, tooling and organisation; retain unknown scope as Open and reassess on relevant changes. |
| Secure-development assurance | Applicable | Partly Fulfilled | Kontext `docs/security/secure-development/<date>-lh00-process/`: baseline vor Implementierung; deltas und evidence-matrix mit Änderungen, image-impact beim zugehörigen Gate, closure erst zum Abschluss nach Presetvertrag. Baseline/CL-IDs binden; menschliche Freigaben getrennt / Baseline before implementation; deltas and matrix with changes, image-impact at its gate, closure at closeout. Bind baseline/CL IDs and separate human decisions. Kein formales Gate jetzt behauptet / No formal gate claimed now. |
| A11Y / WCAG 2.2 AA | Applicable | Partly Fulfilled | DE/EN-Text vorhanden. `docs/accessibility/lh00-process.md`: 1.3.1/1.3.2, 1.4.1, 2.4.4/2.4.6, 3.1.1/3.1.2 soweit anwendbar; Tastatur/Fokus/Hilfsmittel praktisch prüfen / Test semantics, no color-only meaning, links/headings, language and actual keyboard/focus/assistive access. |
| Sprache / Language | Applicable | Partly Fulfilled | Neue Entwürfe DE/EN B2; anderes Äquivalenzreview und FU-Bestandsübersetzungen vor Abnahme / Independent equivalence review and existing translation follow-ups before acceptance. |
| Plattform-/Shell-Parität / Platform and shell parity | Applicable | Not Fulfilled | Quickstart M-01–M-04; `docs/cross-platform/lh00-parity.md`; vier vollständige Abläufe, nicht vier Smokes / Four full flows, not four smokes. |
| Collection-Lebenszyklus / Collection lifecycle | Applicable | Not Fulfilled | B-01 vor Active; alle drei Validatoren und beide Shells nach versionierter Korrektur / All copies/shells after versioned correction. |
| Agent-Parität / Agent parity | Applicable | Partly Fulfilled | Fünf Guidance-Dateien unverändert; Plan als technische Informationsquelle. Später gemeinsame Regeln atomar samt betroffenen Templates/Constitutions; `docs/agent-parity/lh00-parity.md` / Preserve current guidance; the plan is the technical source of information. Update shared rules, affected templates and constitutions atomically later. |
| Model routing | Applicable for status; N/A for mutation | Not Assessed | Vor Implementierung aktuellen Status lesen; RefreshRequired blockiert bis gesondertem Refresh und erfolgreicher Statusprüfung. Keine Routingänderung in diesem Auftrag / Read current status before implementation; refresh needs separate authority and successful recheck. |
| Statistik / Statistics | Applicable | Not Fulfilled | Planpaket bei nächster autorisierter Lieferung im Ledger/Renderer berücksichtigen; 80/100, keine Zeitbehauptung / Update ledger/renderer with authorized delivery; no effort claim. |
| Dokumentationswirkung / Documentation impact | Applicable | Fulfilled for plan | Genau `UpdateRequired`, sourceOnly, Owner und README-Leserpfad im Plan; spätere Prozessbelege separat / Single impact decision and navigation; later evidence separate. |
| Autonomer Lauf, Kampagne, Remote-Lieferung / Autonomous run, campaign, remote delivery | N/A | Not Assessed | Kein Auftrag; erneute Gates bei späterer ausdrücklicher Autorität. Keine Run-State-/Gate-JSONs zur Vortäuschung eines Laufs / No authority; reassess later, no fabricated run artifacts. |

Restgrenze: Planung und lokale Selbstprüfung beweisen weder Umsetzung noch
unabhängige Abnahme, 4/4 Plattformen, Hilfsmittelzugang oder angewendete zentrale
Registeränderungen. Ein passender nächster Auftrag kann Tasks erzeugen; B-01 und
die übrigen Gates müssen als echte Vorgänger erhalten bleiben.

Limit: planning and self-checks do not prove implementation, independent acceptance,
four environments, assistive access or applied central changes. A later Tasks
request must preserve B-01 and other gates as real prerequisites.

## Abgleich 2026-10-05 / Reconciliation 2026-10-05

Die Tabelle bleibt eine Entwurfs-/Umsetzungszuordnung, keine aktuelle Startfreigabe.
Historische Input-PASS-Zeilen beziehen sich auf die ursprüngliche Planprüfung;
aktuelle Bindungen stehen im Preflight-Nachweis. T005/T010/T012 ergänzen die neuen
Security-/Architecture-Regeln; bei anwendbarem C5 Type 1/Type 2/Unknown unterscheiden,
bei C3A genaue C/AC-IDs und SI-Auslegung erhalten. Jahresreview und Lieferstufen
folgen der Constitution. B-01-Releases/Pins/Installation sind geliefert; reale
Collection- und Prozessnachweise einschließlich Owner-Abnahme bleiben offen.

This table maps design and implementation evidence rather than granting a current
start. Historical input PASS rows belong to original planning; the preflight holds
current bindings. T005/T010/T012 cover new rules, applicable C5 assurance types and
exact C3A control IDs/SI interpretation. Annual review and rollout boundaries follow
the constitution. B-01 delivery is complete; real collection/process proof and
owner acceptance remain open.

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

## Ausführungszuordnung T001–T018, 2026-10-06 / Execution mapping

Owner Thorsten Hindermann; Autor Codex `/root`; anderer Reviewer für Foundation
T012: separat beauftragter Agent (Identität im folgenden Review). AC-00-001–003
und E01/E02 binden Create; AC-00-005 bindet die Governance-Grundlagen. Vollständige
Prozessabnahme, Risikoakzeptanz und Pilotfreigabe bleiben menschliche Entscheidungen.
The owner and author are named above; T012 uses a separate agent. Create maps to
AC-00-001–003/E01/E02, foundation to AC-00-005. No human acceptance is inferred.

Offene Aktionen: T032 aktive Kandidatenmigration, T019+ weitere Sprach-/Lifecycle-
und Plattformnachweise, Regulatorik-/Produkttechnik-Einordnung durch Thorsten.
Wiedervorlage 2026-10-12; Trigger geänderter Scope, Tooling oder Quellen.
Open actions retain their later gates and owner, with the existing reassessment date.
Keine Restrisiken sind akzeptiert. / No residual risks are accepted.


## Unabhängiges Foundation-Review T012, 2026-10-06 / Independent foundation review

**Prüfer / Reviewer:** Codex-Agent `/root/lh00_t012_foundation_review`, getrennt
vom Autor `/root`. **Owner:** Thorsten Hindermann. **Zeit / Time:** 2026-10-06T17:56:47.696833+00:00.
**Umfang / Scope:** T005–T011 und ihre vier inaktiven Governance-Kandidaten;
Foundation vor gezielter Integration T013/T014 und isolierten Create-Prüfungen.

**Ergebnis: für den beauftragten nächsten lokalen Schritt geeignet.** Die
Sicherheitsgrenzen sind für die gezielte Skriptübernahme und synthetische Kopien
hinreichend bestimmt. Keine offene mutationrelevante Foundation-Lücke gefunden.
Dies ist weder Intake-Ready noch Pilotfreigabe, Produktabnahme oder
Risikoakzeptanz; weitere Prozess-/Plattformgates bleiben offen.

**Result: suitable for the next commissioned local step.** A distinct agent
reviewed the foundation and inactive candidates. Safeguards adequately bound
same-version script integration and synthetic isolated tests. No unresolved
mutation-relevant foundation gap was found. This is no intake readiness, pilot
permission, product acceptance or human risk acceptance.

| Prüfung / Check | Ergebnis und Grenze / Result and boundary |
|---|---|
| Architektur, Autorität und Schutzmaßnahmen / Architecture, authority and safeguards | Dateiverträge, STRIDE/CIA, CWE-/CAPEC-/SSDF-Zuordnung, minimale Befugnis, Shellregeln und Fehlerschutz geprüft. Skriptparität und konkrete Create-Abweisungen müssen nun T013–T018 nachweisen. / Reviewed file contracts, threat/control mapping, least privilege and secure shell/error rules; actual parity and rejection evidence remain the next tasks. |
| Herkunft / Provenance | Paket-METADATA bestätigt Spec Kit 0.12.8; die fünf vorgesehenen PowerShell-Dateien existieren; Bash-common ist bytegleich zur Paketquelle. / Installed package metadata confirms version 0.12.8; all five planned files exist and Bash common matches the package bytes. |
| Echte Baseline / Real baseline | 37 Snapshot-Dateien bytegleich zur benannten zentralen Quelle; 157 eindeutige CL-IDs. Baseline-Validator `Review -Gate baseline -ContextId lh00-process -Mode development`: Exit 0, `Ready`. / Exact snapshot and unique checkpoint IDs verified; baseline integrity review passed. |
| Nachweisgrenzen / Evidence boundaries | Baseline-Ready gilt nur für Dokumentbindung. 21 Foundation-Punkte konkret zugeordnet; übrige Bewertungen bleiben offen. Delta `NeedsRemediation`, Closure/Image-Impact fehlen bewusst bis zum passenden Gate. / Baseline readiness covers binding only; partial mappings and later assurance gates remain explicit. |
| Aktiver Bestand / Active evidence | Reales LH-00, Receipt, Review und vier gebundene Quellen unverändert; sämtliche Vorgänger-/Kandidatenhashes geprüft. Veröffentlichung bleibt T032. / Active artifacts remain unchanged; all four candidate bindings verified, publication deferred to T032. |
| Sprache und Regulatorik / Language and regulation | Neue Foundation-Aussagen DE zuerst/EN danach sinngleich; ASVS/C3A/C5 mit Gründen/Triggern. DS-GVO/KI-VO/CRA/NIS2/DORA je Produkt/Werkzeugen/Organisation ausdrücklich Open; keine rechtliche Ausnahme oder Konformität behauptet. / Equivalent bilingual foundation statements; non-applicability has reasons/triggers and all regulatory scopes remain Open without exemption/conformity claims. |

Drei Nachweisbefunde wurden vor dem begrenzten Wiedercheck korrigiert:

1. Architektur unterscheidet die nächste separate Review-Aktion von den zwei
   gespeicherten, inaktiven Specify-/Autonomous-Promptvorlagen.
2. Security-README-Kandidat verwendet Links relativ zum späteren aktiven Ziel,
   einschließlich S-ADR, Architektur und Baseline; alle 15 neuen Ziele existieren.
3. Matrix führt 21 tatsächliche Foundation-Zuordnungen mit Dokumenten und
   Restaktionen statt ausschließlich pauschaler Open-Zeilen. Keine vollständige
   157-Punkte-Erfüllung wird dadurch behauptet.

Three evidence findings were corrected and independently rechecked: distinguish
separate review from the two inactive prompts; use correct future README-relative
links (all 15 new targets exist); map 21 concrete foundation checkpoints while
retaining incomplete assessments and later gates. No full checklist completion
is inferred.

Verbindliche nächste Schutzschritte: nur belegte 0.12.8-Dateien gezielt übernehmen,
Skriptproben in zugewiesenen isolierten Kopien halten, keine Issue-Inhalte
interpretieren, keine aktiven Quellen überschreiben. T018 vor T017; E01/E02 sind
noch nicht ausgeführt. Thorsten bleibt Owner offener Regulatorik-/Produkttechnik-
und späterer Abnahmefragen, Wiedervorlage 2026-10-12 oder bei geänderten Quellen,
Werkzeugen, Scope oder Mutation. Es ist kein Restrisiko menschlich akzeptiert.

Next safeguards are mandatory: import only verified same-version scripts, keep
script runs isolated, never evaluate source text or overwrite active evidence.
T018 precedes T017; creation cases are not yet executed. Open regulatory,
product-technology and later acceptance questions stay with Thorsten; reassess
on 2026-10-12 or changed sources, tools, scope or mutation. No human risk acceptance
has been recorded.

### Bindung des geprüften Standes / Reviewed-state binding

Rohbyte-SHA-256 der zentralen Review-Artefakte; weitere Foundation-Dokumente wurden
inhaltlich geprüft, diese Tabelle ist kein neues Receipt-Schema.
Raw-byte SHA-256 anchors the main review artifacts; remaining foundation files
were reviewed semantically. This table introduces no receipt schema.

| Artefakt / Artifact | SHA-256 |
|---|---|
| `docs/architecture/lh00-process.md` | `2af563117dfb632231f0fb321609c16d863edc80e9bc776b48b19e057137a905` |
| `docs/security/threat-model.md` | `ec156f7d80183adbc4a0bf075576fc31617acda7cedd1c62fef5e44832a87191` |
| `docs/security/security-checklist.md` | `66819ccf6408163a4b5bca8bcaa3c2b6c4cedc96e1c2ee6a2522683bd5b99b01` |
| `docs/security/adr/s-adr-lh00-authority.md` | `6a273dbd64dca1896bb0cf65874c69c2a151aaede471984df56989b0da4810cc` |
| `docs/security/secure-coding-language-rules.md` | `2ce7f7c9ab5a106eaeed04abfa506bc81b250d88959a8e92474d291bf3c469db` |
| `docs/security/secure-development/2026-10-06-lh00-process/baseline.json` | `033c5c1ceeb046e811cf101582d168868b78992272e1985f782b677c6c34be0f` |
| `docs/security/secure-development/2026-10-06-lh00-process/deltas/t001-t018.json` | `b411a653bf32f187c46cfcbd8f5c1a99d609bc4a015a8fafd72dde9519fd7373` |
| `docs/security/secure-development/2026-10-06-lh00-process/evidence-matrix.md` | `022537941cb0f18efdef65e9dc79b16eb21476cc929f3f9c1b52a4c70962c00e` |
| `specs/001-lh00-intake-process/candidates/t001-t018/bindings.json` | `8b17dae5e4b033498ad3a6cebe47a052497f2c6c83bf1bc52472e2175c0367e0` |


## Begrenztes T012-Nachreview, 2026-10-06 / Bounded T012 follow-up review

**Prüfer / Reviewer:** `/root/lh00_t012_foundation_review`, weiterhin getrennt
vom Autor `/root`; **Zeit / Time:** 2026-10-06T18:10:38.193854+00:00. Nur Secret-Scan-Klassifikation,
gezielte Skriptdeltas und aktuelle Kandidatenbindung geprüft.

Der vollständige Directory-Scan hatte Exit 2 und drei Meldungen. Dieser
historische Rohbefund bleibt erhalten. Unabhängige Quellprüfung bestätigt die
Klassifikation aller drei exakt gebundenen Fundstellen in
`docs/validation/lh00/secret-scan-review.json`: öffentliche Keychain-/CryptoKit-
Prosa in `Leitlinie_Sichere-Programmierung.md:38`; illustrative verbotene
Schlüsselmarker ohne Schlüsselbody in `CL_09_KI-Codeerzeugung.md:694–742` und dem
identischen Sammelbandabschnitt `10081–10129`. Die drei Dateien sind bytegleich
zum kontrollierten zentralen Snapshot; ihre Metadatenhashes stimmen. Keine
Schlüsselwerte oder Marker werden hier ausgegeben. **Die drei konkreten Meldungen
sind False Positives, kein allgemeiner Scan-PASS und keine Pfad-/Regelausnahme.**
Bei geänderten Bytes, Fundstellen oder neuen Meldungen erneut prüfen. Ein eng
begrenzter temporärer Vergleichsbestand ersetzt weder Policy noch Scan weiterer
Dateien.

The raw directory scan returned exit 2 with three findings, preserved as history.
Independent inspection confirms all three exact findings are public prose or
illustrative forbidden markers with no real key body. Source bytes and metadata
hashes match the controlled snapshot; the two checklist spans are identical.
No key material is reproduced here. **These exact findings are false positives;
this grants neither an unconditional scan PASS nor a rule/path exclusion.**
Reassess changed bytes, spans and new findings. A temporary exact comparison
baseline does not replace policy or scanning of other files.

Der Vergleich von `common.ps1` mit der installierten 0.12.8-Quelle bestätigt neben
Kommentarhilfe/Aufrufwegen genau zwei Codekorrekturen: automatische schreibgeschützte
PID-Variable durch `templatePresetId` ersetzen und eine sichere konstante
Verbose-Meldung im bestehenden Recovery-Catch ergänzen. Die vier neuen typisierten
Advanced Functions reichen Parameter an feste lokale Skriptpfade weiter;
Dot-Sourcing startet keinen Lauf, kein Issue-Text wird ausgewertet. Beide Fixes
ändern keine fachlichen Anforderungen. Alle fünf finalen Importhashes stimmen
mit dem aktuellen Herkunftsinventar.

Comparing common.ps1 with the installed 0.12.8 source confirms exactly two narrow
code fixes beyond help and invocation additions: avoid assigning the read-only
PID variable and add a constant safe verbose message to existing recovery. Four
typed advanced functions forward parameters to fixed local script paths, with
no automatic run or source-text evaluation. All five integrated hashes match the
current provenance inventory; no product requirement changes.

Direkter PSScriptAnalyzer-Wiedercheck der fünf Imports **mit der vorhandenen
Repository-Konfiguration** `scripts/config/PSScriptAnalyzerSettings.psd1`:
Exit 0, null Findings. Dies behauptet keinen ungefilterten Standardregelsatz-PASS.
Die 19 dokumentierten isolierten Basis-/Cmdlet-Aufrufe und zwei zusätzlichen
No-Python-/Recovery-Fälle wurden als vorhandene Ausführungsbelege gelesen und auf
Scope, erwartete Abweisungen, Exitcodes und Schreibgrenzen geprüft; nicht vom
Reviewer erneut als Produktläufe ausgeführt. Der Review bestätigt nur diesen
macOS-/Fixture-Scope, keine native Windows-/Linux-/Mac-B- oder Prozessabnahme.

An independent direct analyzer recheck passed with zero findings **under the
existing repository settings**, not the unfiltered default rule set. The 19
recorded isolated calls and two targeted fallback/recovery cases were reviewed
as existing execution evidence for expected outcomes and write boundaries;
they were not rerun as product flows. This confirms only the Mac A fixture scope,
not native platform or complete process acceptance.

T016 konkretisierte nach dem initialen Review drei Governance-Kandidaten. Die
frühere Hash-Tabelle ist damit historisch, kein unveränderter aktueller Nachweis.
Die vier heutigen Vorgänger-/Kandidatenbindungen wurden separat erneut geprüft;
aktive Quellen bleiben für T032 erhalten. Die Audit-Zusammenfassung muss die
beiden Codekorrekturen neben Hilfe/Aufrufwegen ausdrücklich benennen.

T016 refined three candidates after the initial review. Its earlier hash table
remains historical and does not claim unchanged current candidates. All four
current predecessor/candidate bindings were separately rechecked; active source
publication remains deferred to T032. The dependency-audit summary must explicitly
acknowledge the two code fixes alongside help/invocation additions.

**Nachreview-Ergebnis:** Keine neue mutationrelevante Sicherheitslücke im geprüften
lokalen Delta. Frühere Scope-Grenzen, offene spätere Gates, Owner Thorsten und
Wiedervorlage 2026-10-12 gelten weiter; keine menschliche Risikoakzeptanz.
**Follow-up result:** No new mutation-relevant security gap in the reviewed local
delta. Preserve scope, later open gates, ownership and reassessment date; no human
risk acceptance is inferred.

| Aktueller Nachreview-Anker / Current follow-up anchor | Rohbyte-SHA-256 / Raw-byte SHA-256 |
|---|---|
| `docs/validation/lh00/secret-scan-review.json` | `7b4f0c69ba507de6f4810af3907714622beb0734d048218882b108d83c8b2276` |
| `.specify/scripts/powershell/common.ps1` | `e339fd276073e7bfe2e4a32cb519063744bfe7995429cbf0cdf0c36bea99ee8a` |
| `docs/cross-platform/lh00-script-provenance.json` | `94eaa344b05fd04ba1a9cade61378b5a2565ed67782191a1dce8a300ed565f36` |
| `docs/validation/lh00/parity-results.json` | `2036eae3655561422aed214d0a17f600f0cc9c057daca6376cad0f52e76374cd` |
| `docs/validation/lh00/import-fix-results.json` | `262051a619c1b60c143bcb0cc19c5f2c333d21f96ac531874cb2010ea8bdc500` |
| `specs/001-lh00-intake-process/candidates/t001-t018/bindings.json` | `efc69ec0d3dea6b9b900098f9b3e9dfbe79d4686e6042332ac23bad3d5a11bf9` |

Nachtrag desselben Wiederchecks: `dependency-audit.md` benennt beide Importkorrekturen
bereits ausdrücklich in DE und EN; die oben verlangte Konsistenz ist erfüllt.
Addendum to the same recheck: dependency-audit.md already names both import fixes
in German and English; the required summary consistency is fulfilled.
