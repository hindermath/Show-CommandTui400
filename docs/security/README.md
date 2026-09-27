# Sicherheitsnachweise — Einrichtungsstand

Owner: Thorsten Hindermann. Stand: 27.09.2026.

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
| Regulatorik NIS2 / CRA / EU AI Act / DORA | Open | Keine regulatorische Bewertung durch Einrichtung; vor Marktbereitstellung, regulierten Kunden oder KI-Produktfunktionen gesondert prüfen. |
| SAMM, CAPEC und OpenSSF Scorecard | Open | Ergänzende Bewertung bei konkreter Architektur beziehungsweise erster Releaseplanung. |

Vor jeder Produktimplementierung die Anwendbarkeit aktualisieren. Vorlagen
stehen in den installierten Governance-Presets. Offene Punkte sind keine
bestandenen Gates. Restrisiko dieses Auftrags: installierte Werkzeuge und
Regeln ersetzen keine Prüfung der zukünftigen Befehlsausführung oder
Parameterverarbeitung. Nächster fachlicher Schritt bleibt LH-00.
