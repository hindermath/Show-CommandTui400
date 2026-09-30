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
| NIS2 / CRA / EU AI Act / DORA | Open | Not Assessed | Bestehende Projektbewertung nicht durch Plan schließen. `docs/security/regulatory-applicability.md`; spätestens vor Distribution/Markt/Kunden/Cloud/KI-Laufzeit / Preserve open assessment; revisit before distribution, market, customers, cloud or runtime AI. |
| Secure-development assurance | Applicable | Partly Fulfilled | Kontext `docs/security/secure-development/<date>-lh00-process/`: baseline vor Implementierung; deltas und evidence-matrix mit Änderungen, image-impact beim zugehörigen Gate, closure erst zum Abschluss nach Presetvertrag. Baseline/CL-IDs binden; menschliche Freigaben getrennt / Baseline before implementation; deltas and matrix with changes, image-impact at its gate, closure at closeout. Bind baseline/CL IDs and separate human decisions. Kein formales Gate jetzt behauptet / No formal gate claimed now. |
| A11Y / WCAG 2.2 AA | Applicable | Partly Fulfilled | DE/EN-Text vorhanden. `docs/accessibility/lh00-process.md`: 1.3.1/1.3.2, 1.4.1, 2.4.4/2.4.6, 3.1.1/3.1.2 soweit anwendbar; Tastatur/Fokus/Hilfsmittel praktisch prüfen / Test semantics, no color-only meaning, links/headings, language and actual keyboard/focus/assistive access. |
| Sprache / Language | Applicable | Partly Fulfilled | Neue Entwürfe DE/EN B2; anderes Äquivalenzreview und FU-Bestandsübersetzungen vor Abnahme / Independent equivalence review and existing translation follow-ups before acceptance. |
| Plattform-/Shell-Parität / Platform and shell parity | Applicable | Not Fulfilled | Quickstart M-01–M-04; `docs/cross-platform/lh00-parity.md`; vier vollständige Abläufe, nicht vier Smokes / Four full flows, not four smokes. |
| Collection-Lebenszyklus / Collection lifecycle | Applicable | Not Fulfilled | B-01 vor Active; alle drei Validatoren und beide Shells nach versionierter Korrektur / All copies/shells after versioned correction. |
| Agent-Parität / Agent parity | Applicable | Partly Fulfilled | Fünf Guidance-Dateien unverändert; Plan als technische Informationsquelle. Später gemeinsame Regeln atomar samt betroffenen Templates/Constitutions; `docs/agent-parity/lh00-parity.md` / Preserve current guidance; the plan is the technical source of information. Update shared rules, affected templates and constitutions atomically later. |
| Model routing | N/A | Not Assessed | Keine Routingänderung; keine Provider-Modellnamen im Entwurf. Neubewertung bei Routingauftrag / No routing change or provider model names; reassess on request. |
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
