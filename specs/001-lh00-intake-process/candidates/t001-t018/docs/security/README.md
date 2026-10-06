# Sicherheitsnachweise — Einrichtungsstand

Owner: Thorsten Hindermann. Stand: 03.10.2026.

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
Parameterverarbeitung. Nächster fachlicher Schritt bleibt LH-00.

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

Links sind relativ zur künftigen aktiven README; im Kandidaten ist der Bestand noch nicht veröffentlicht. / Links are relative to the future active README; candidate storage is not publication.

- [S-ADR](adr/s-adr-lh00-authority.md)
- [Architektur / Architecture](../architecture/lh00-process.md)
- [Baseline-Matrix / Baseline matrix](secure-development/2026-10-06-lh00-process/evidence-matrix.md)
