# LH-01 getrennte technische Entscheidungen / Separate technical decisions

## DE — Entscheidungsstand

Datum: 2026-10-08. Beauftragter technischer Bearbeiter: Codex `/root`;
Projektowner: Thorsten. Grundlage: [Ergebnisse](README.md), gebundene Rohdaten
und [anderes technisches Review](independent-review.md). Die folgende Auswahl
ist verbindlich für den **isolierten Prüfaufbau**, keine endgültige
Produktentscheidung. Fehlgeschlagene F04- und ausstehende A11Y-Nachweise lassen
OD-01-001/002 offen. Eine Freigabe trotz dieser Lücken wäre nicht evidenzgestützt.

| Entscheidung | Ergebnis und Begründung | Grenze / Wiederaufnahme |
|---|---|---|
| Sprache — OD-01-002 | C# bleibt der bevorzugte Prüf-Kandidat: kompiliertes PSCmdlet liest tatsächlich den aktuellen Runspace, ohne zusätzliche PowerShell-Runtime. | Endgültiger Produktsprachentscheid nach tragfähigem UI-/Plattform-/A11Y-Nachweis; gemeinsame Guidance/Registry bleiben unknown. |
| MSL — OD-01-002 | Managed C# allein begründet keine vollständige Speichersicherheit. Terminaltreiber/native Interop und TextMateSharp → Onigwrap werden getrennt behandelt. | Native Nutzungsgrenzen, Artefakte und Lieferkette bewerten, bevor MSL-Klassifikation und Restrisiken final festgelegt werden. |
| Runtime | net10.0/C#14 als ausgeführte Prüfbaseline; im Host laufen .NET10.0.12 (Mac) bzw. 10.0.11 (Container). SMA wird aus dem Host referenziert, nicht mitverteilt. | Keine zusätzliche Runtime im laufenden Host; endgültige Runtime-/Supportmatrix mit PowerShell-Minimum getrennt entscheiden. |
| TUI-Framework | Terminal.Gui2.5.0 ist für diesen Produktstart **nicht freigegeben**. Direkte Keys/Resize funktionieren teilweise, Restore scheitert. | Ursache ohne pauschale Frameworkzuweisung isolieren; korrigierten Adapter/Renderer erneut prüfen. Spectre/eigene ANSI-Lösung bleiben begründete Alternativen aus D03, nicht bereits validierte Ersatzwahl. |
| PowerShell-Minimum — OD-01-001 | 7.6 ist Prüfbaseline; tatsächlich getestete Versionen 7.6.6/7.6.4. | Daraus folgt keine bewiesene Untergrenze für 7.6.0 oder ältere Versionen. Support-/Machbarkeitsmatrix vor finaler Mindestversion. |
| Sitzung/Terminal — OD-01-001 | In-process PSCmdlet statt Out-of-process-Sitzungskopie ist lokal tragfähig für geprüfte synthetische Scopes. Nichtinteraktivität wird vor Init abgewiesen. | Vollständige Host-/Capability-/Wiederöffnungs-/StopProcessing- und Restore-Matrix offen; private Scopes nicht pauschal zugesagt. |

Bei Korrektur, Paket-/Hostwechsel oder verändertem Beweisumfang diese Entscheidungen
gezielt erneut prüfen. Die Pilotgrenze bleibt unverändert: LH-01 außerhalb
automatischer Serienauswahl, LH-00 offen, vollständige LH-00-Abnahme nach LH-02
vor LH-03. Keine neue Feature- oder Ausführungsautorität folgt aus diesem Dokument.

## EN — Decision state

Date: 2026-10-08. Commissioned technical contributor: Codex `/root`; project owner:
Thorsten. Evidence and independent review are linked above. Choices are binding
for the **isolated test setup**, not final product selection. Failed F04 and missing
assistive evidence keep OD-01-001/002 open.

Language: C# remains the preferred proof candidate; actual in-process PSCmdlet
access works without a second PowerShell runtime. Final product selection awaits
a viable UI/platform/assistive proof; shared language/MSL records stay unknown.
Memory safety: managed C# does not cover native drivers/interop or Onigwrap;
assess boundaries, artefacts and supply chain before final classification.
Runtime: net10.0/C#14 is the executed baseline; reference host SMA without copying
it. Decide final support separately. Framework: Terminal.Gui2.5.0 is **not approved
for product start** because restoration fails. Isolate the cause and retest a
corrected adapter/renderer; documented alternatives are not validated replacements.
PowerShell minimum: 7.6 is a proof baseline, with 7.6.6/7.6.4 actually tested;
this establishes no lower-bound claim for 7.6.0 or earlier releases. Session:
in-process PSCmdlet is viable in the tested synthetic scopes; complete host,
capability, repeated-entry, StopProcessing and restore coverage remains open.

Revisit affected choices on corrections/package/host/proof changes. Preserve the
standalone pilot and LH-00 acceptance order; no new execution authority is granted.
