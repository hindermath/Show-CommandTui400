# Sicherheitsnachweise / Security evidence

Owner: Thorsten Hindermann. Stand / Date: 09.10.2026.

## Aktueller LH-01-Startentwurf / Current LH-01 readiness design

Managed C#14 ist eigener MSL-Code; Runtime/OS/PInvoke/native Pakete bleiben
separat. Host-.NET10, Terminal.Gui2.5.0/dotnet und MinimumPS7.6.4 sind ausgewählt,
keine Produktimplementierung. Architektur-/Sicherheitsentwurf und Baseline sind
geprüft; Produktkontrollen und praktische Plattform-/A11Y-Abnahme bleiben offen.

Own managed C#14 code is memory-safe; native/runtime/interop boundaries remain
separate. Host .NET10, explicit Terminal.Gui2.5.0/dotnet and minimumPS7.6.4 are
selected, with no product implementation. Reviewed design/baseline does not pass
product controls or practical platform/assistive acceptance.

- [Architektur / Architecture](../architecture/lh01-tui-foundation.md)
- [S-ADR](adr/s-adr-lh01-session-display.md)
- [Startreview / Readiness review](../validation/lh01/architecture-start-review.md)
- [Baseline](secure-development/2026-10-09-lh01-tui-foundation/evidence-matrix.md)
- [Herkunft und Startprüfung / Provenance and readiness](../validation/lh01/start-readiness.md)

Documentation impact UpdateRequired, sourceOnly DE/EN, Thorsten; no Home sync.
Reevaluate changes to scope, dependencies or native use.

## Historische Einrichtung 07.10.2026 / Historical setup


Diese Übersicht beschreibt die Einrichtung, keine abgeschlossene
Produktsicherheitsprüfung. NIST SSDF und CWE Top 25 gelten für die Arbeit.
Eingesetzte Kontrollen: versionierte Governance, Secret-Scanning und
Pre-Push-Hook, PR-Regeln, Codeowner und statische PowerShell-Analyse.

| Bereich | Status im aktuellen Scope | Begründung / nächster Nachweis |
|---|---|---|
| Sichere Entwicklung, Eingaben und Datei-/Prozess-I/O | Applicable | Sichere Tooling-Konfiguration prüfen; Produktprüfungen vor Implementierung konkretisieren. |
| Bedrohungsmodell, S-ADRs, arc42-Sicherheitskonzepte und Reviewcheckliste | Open | Sprache und Sitzungsmodell sind offen; projektspezifische Nachweise mit LH-01 und späteren Features erstellen. |
| OWASP ASVS | N/A | Kein Web-/HTTP-/API-Dienst im Einrichtungsscope. |
| Produkt-SBOM, VEX und Release-Provenance | N/A | Kein veröffentlichbares Produktartefakt und kein Release in diesem Auftrag; bei erster Auslieferung reevaluieren. |
| AI-SBOM | N/A | KI dient als Entwicklungswerkzeug; keine KI-Produktkomponente beschlossen. |
| BSI C3A / C5 und Zero Trust | N/A | GitHub/Agenten sind Entwicklungsinfrastruktur; kein Cloud-Produktbetrieb eingerichtet. |
| DS-GVO / KI-VO / CRA / NIS2 / DORA | Open | Beispielprodukt, Entwicklungswerkzeuge und Organisation getrennt bewerten; Rolle, Jurisdiktion, direkte/vertragliche Pflichten, Quelle und Owner dokumentieren. Ausbildungszweck und AI-SBOM N/A sind keine pauschale Befreiung. |
| SAMM, CAPEC und OpenSSF Scorecard | Open | Ergänzende Bewertung bei konkreter Architektur beziehungsweise erster Releaseplanung. |

Vor jeder Produktimplementierung die Anwendbarkeit aktualisieren. Vorlagen
stehen in den installierten Governance-Presets. Offene Punkte sind keine
bestandenen Gates. Restrisiko dieses Auftrags: installierte Werkzeuge und
Regeln ersetzen keine Prüfung der zukünftigen Befehlsausführung oder
Parameterverarbeitung. Der LH-00-Kernprozess ist geliefert und T045 begrenzt
freigegeben; nächster eigener fachlicher Auftrag ist LH-01-Authoring samt anderem
Review. Volle LH-00-Prozess-/Produktabnahme bleibt offen. C# wird in LH-01 als
Prüfoption bewertet; Primärsprache und MSL-Status bleiben unknown.

The regulatory screen covers GDPR, the EU AI Act, CRA, NIS2 and DORA. Assess
the sample product, development tooling and operating organisation separately,
including jurisdiction, role, direct/contractual duties, official source,
owner and evidence. Education and product AI-SBOM N/A are no blanket exemption.
Unknown remains Open. Governance installation is no legal or product approval.

Pilot integration: [coordinated governance evidence](../maintenance/coordinated-governance-oct03.md).

## LH-00-Grundlagen / LH-00 foundation

Neue lokale Grundlagen, keine vollständige Abnahme. / New local foundation, no full acceptance.

- [arc42-section-8-lh00](arc42-section-8-lh00.md)
- [asvs-verification](asvs-verification.md)
- [cloud-autonomy-applicability](cloud-autonomy-applicability.md)
- [cloud-compliance-assurance](cloud-compliance-assurance.md)
- [dependency-audit](dependency-audit.md)
- [msl-applicability](msl-applicability.md)
- [regulatory-applicability](regulatory-applicability.md)
- [secure-coding-language-rules](secure-coding-language-rules.md)
- [security-checklist](security-checklist.md)
- [supply-chain-evidence](supply-chain-evidence.md)
- [threat-model](threat-model.md)
- [zero-trust-applicability](zero-trust-applicability.md)

Diese Leserpfade sind durch T032 lokal publiziert; ursprüngliches Staging bleibt
historisch. / These reader paths are locally published through T032; original
staging remains historical.

- [S-ADR](adr/s-adr-lh00-authority.md)
- [Architektur / Architecture](../architecture/lh00-process.md)
- [Baseline-Matrix / Baseline matrix](secure-development/2026-10-06-lh00-process/evidence-matrix.md)

## Historische Nachweisgrenze 07.10.2026 / Historical evidence boundary

Die vorhandenen LH-00-Grundlagen und isolierten Mac-A-/B-01-Prüfungen sind
Prozess-/Toolingnachweise, keine Sicherheitsabnahme der zukünftigen TUI.
Die Sprache wird in LH-01 vor Produktimplementierung entschieden; C# ist eine
Prüfoption. Regulatorische Rollen/Pflichten bleiben Open; keine neue Rechtsprüfung
oder Produkt-Ausnahme wird behauptet. FU03 (vollständiger englischer Sprachpartner
der historischen Übersicht) bleibt offen.

Existing LH-00 foundations and isolated Mac A/B-01 checks prove process/tooling,
not the future TUI's security. The core is delivered and T045 grants limited owner
permission; the next separate request authors LH-01 and obtains distinct review.
Decide product language before implementation; C# is a candidate and primary
language/MSL stay unknown. Regulatory roles/duties remain Open. No new legal
assessment or product exemption is asserted. Full historical translation FU03
remains outstanding.
