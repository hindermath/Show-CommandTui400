# LH-00-Kernprozess: Lieferung / Core process delivery

Stand: 2026-10-06. Owner Thorsten Hindermann; Codex liefert das vorhandene lokale
T001–T045-Paket auf ausdrücklichen Auftrag mit DeliveryMode MergeAndSync und
Admin-Bypass. B-01 ist menschlich als behoben abgenommen; T036 abgeschlossen.
Historische lokale Prüf-/Mac-Assessments behalten ihre ursprünglichen Hashes
und Ergebnisse. Statistik-/Homogenitätsbereinigung erfolgt ausschließlich mit
dem bestehenden Renderer aus sauberem Arbeitsbaum, nach dem Quellencommit.
Aktuelle technische Lieferchecks und der endgültige PR-Stand folgen unten.

Dated 2026-10-06: explicit owner authority delivers the existing local T001–T045
package through MergeAndSync. Human B-01 acceptance completes T036. Preserve
the exact historical local assessments; render statistics from a clean committed
tree with the existing engine. Current delivery checks and the final PR head
are recorded below once observed.

Begrenzte Pilotfreigabe T045 bleibt menschlich offen. Keine reale Serienaktivierung,
LH-01-/LH-02-Piloten oder vollständige LH-00-Abnahme werden durch Lieferung erteilt.
Limited pilot permission remains a human decision. Delivery itself grants no real
series activation, feature pilot or full process acceptance.

Leserpfad / Reader path: [B-01-Entscheid](b01-owner-decision.json) →
[historisches unabhängiges Mac-Assessment](acceptance.md) →
[Aufgabenstand](../../../specs/001-lh00-intake-process/tasks.md).

## Lieferfähige Quelldaten / Deliverable source data

Das Git-Whitelist-Modell erlaubt nun die benannte requirements-Collection und
.gitleaks.toml. Attribute erhalten bytegenaue Quellen, Vorgängerarchive und
Testdaten; der gezielte BOM/CRLF-Fall behält seine tatsächlichen Rohbytes im
Git-Index. Bestehende Import-Whitespace und absichtliche Markdown-Zeilenumbrüche
werden als Provenienz/Darstellung erhalten; keine Parser-/Analysegates entfallen.
Die drei unabhängig bestätigten öffentlichen Secret-Scan-Fehlalarme werden nur
im betreffenden Detektor bei exakt passendem Pfad UND vollständigem Matchtext
ausgenommen. Alle Defaultregeln bleiben aktiv. Echte Scanner-Negativtests an
denselben Pfaden erkennen geänderte synthetische PAT-/Private-Key-Beispiele.
Ein anfänglich zu breiter globaler Allowlist-Versuch wurde vor Commit verworfen
und durch regelbezogene targetRules ersetzt; keine Pfadausnahme bleibt bestehen.

Tracking rules admit the named collection and exact scan configuration. Git
attributes preserve frozen raw bytes, including CRLF/BOM fixtures, upstream
import whitespace and intentional Markdown breaks. Parser and analysis gates
remain required. Three public false positives require both exact path and full
match within the specific detector; default rules remain enabled. Actual changed
same-path secret canaries are detected. An unsafe global-allowlist experiment was
rejected before commit and corrected with rule-specific targeting.

[Scan-Policy und Herkunft / Scan policy and provenance](delivery-secret-scan-policy.json),
[tatsächliche Negativprüfungen / actual negative checks](delivery-secret-scan-results.json).
Konfiguration gemäß [Gitleaks-Dokumentation](https://github.com/gitleaks/gitleaks/blob/master/README.md#configuration).

Vor Quellencommit: Secret-Scan high=0; kompletter gestagter Gitleaks-Scan ohne
Befund; PSScriptAnalyzer 1.25.0 analysiert 73 Dateien ohne Error/Warning und
überspringt die fünf generierten Imports gemäß bestehenden Regeln. Deren frühere
direkte Analyse und Rohhashbelege bleiben unverändert. Staged Diff-Check besteht.
Before the source commit, secret scans and staged Gitleaks pass. Repository
analysis checks 73 files and retains its existing five-import exclusion; unchanged
direct-import evidence remains available. Staged whitespace checks pass.
