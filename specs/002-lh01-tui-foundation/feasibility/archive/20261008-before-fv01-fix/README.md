# LH-01 Machbarkeitsergebnisse / Feasibility results

## DE — Ergebnis vom 8. Oktober 2026

Die beauftragten isolierten Prüfungen liefern reale Teilnachweise und einen
fehlgeschlagenen Wiederherstellungsnachweis. **F01–F07 sind nicht insgesamt
bestanden. OD-01-001/002 und das Produktstart-Gate bleiben offen.** Der aktuelle
Entscheidungsstand steht in [decisions.md](decisions.md), das andere technische
Review in [independent-review.md](independent-review.md).

Ausführung: Codex `/root`, Mac A, MacBook Air M2 (2023), Arm64; PowerShell 7.6.6,
.NET 10.0.12, SDK 10.0.401; Terminal.Gui 2.5.0. Zweite Umgebung: vorhandenes
SDK-Containerimage auf der lokalen Podman-Linux-VM, Ubuntu 24.04.4 Arm64,
PowerShell 7.6.4 / .NET 10.0.11. Imageidentität und Laufzeit sind gespeichert.
Das ist kein nativer Windows-, Mac-B-, WSL2- oder physischer Terminalnachweis.

| Fall | Beobachtung | Status und verbleibender Nachweis |
|---|---|---|
| F01 | Umgeleitete UI wird vor Init abgewiesen; 18 synthetische Modellprüfungen bestehen auf Mac A und Linux, einschließlich Kontext-, Remap- und Steuerzeichenfällen. | Teilnachweis; keine umfassende reale Capability-/Bindingmatrix. Kein Zielausführer vorhanden. |
| F02 | Identischer Prozess/Runspace; synthetische Werte 710/711/712 im globalen, Funktions- und Modulscope gelesen. Aufruferkontext unverändert. Mac-UI kehrt im gleichen Kontext zurück. | Teilnachweis; keine allgemeine Zusage zu privaten Aufruferscopes, Hosttypen oder mehrfacher UI-Öffnung. |
| F03 | Reale PTY-Tasten F1, F5, Alt+X; Wert und tatsächlicher Fokus bleiben erhalten. | Teilnachweis; übrige definierte Tasten/Alternativen, reales Remapping und alle Kontexte offen. Modelltests ersetzen diese nicht. |
| F04 | Cursor-/Alternate-Screen-Endesequenzen beobachtet; `stty -g` nach normalem Ende, Testfehler, Ctrl+C und Resize weicht ab. Kontrolllauf ohne UI bleibt unverändert. | Fehlgeschlagen; Ursache zwischen Fixture/Framework/Host/native Messgrenze isolieren. StopProcessing zusätzlich separat offen. |
| F05 | 100×24 → 30×6 → 100×24 erhält Wert/Fokus; kurze Anleitung „Alt+X Ende/Exit“ und tatsächliches Ende direkt bei 30×6 geprüft. | Lokaler Größen-/Escape-Teilnachweis bestanden; F04 und übrige Plattformen bleiben offen. |
| F06 | Tastatur-Teilbeobachtung; keine farbabhängige Aktionsbedeutung im Fixture. | Offen: keine benannte reale Screenreader-/Braillehardware getestet, keine vollständige A11Y-Matrix. |
| F07 | Gepinnte Paketversion, Lockfile, öffentlicher NuGet-Audit, native Onigwrap-Grenze und getrennte Entscheidungen; anderes Review. | Review durchgeführt; Gesamtgate wegen F03/F04/F06 und offener nativer Lieferkettenbewertung nicht bestanden. |

### Messung und Fehlversuche

`src/` enthält ausschließlich das Wegwerf-Cmdlet `Test-Lh01Fixture` und seine
Testtreiber. Kein Produkt-Cmdlet oder LH-02–07-Code. Die Fixture liest nur
synthetische Sitzungswerte und führt keine Zielbefehle aus. Paketdownload und
Containerkopien gehören zum isolierten Testaufbau, nicht zum Cmdlet.

`evidence/maca-pty-*.json` enthält escaped Rohtranscripts, Schritte, Prozess-
Exitcode, Quell-/Assemblyhashes der abschließenden Läufe sowie `stty` vor/nach UI.
Ein PTY ist ein Pseudoterminal; ANSI-Abfragen werden synthetisch beantwortet.
Cursor-Endesequenzen beweisen kein tatsächlich sichtbares Cursorbild.
`InitialPtySettingsMatch` vergleicht mit dem PTY vor PowerShell-Start;
**`Result.TerminalRestored`** vergleicht den relevanten Zustand im laufenden Host.
Ein `timeout-terminated` bleibt ein Fehler, auch bei Exitcode 0 und gespeichertem
Result. Der Harness wartet höchstens 25 Sekunden plus 3 Sekunden zum Beenden.
Die halbe Sekunde nach dem Restore-Marker erlaubt eine Messung vor dem Schließen
des macOS-PTY; sie ist kein Akzeptanz-Timeout für das Produkt.

Der ursprüngliche Ctrl+C-Timeout bleibt als `maca-pty-cancel-before-keymap.json`
erhalten. Abfangen über die Anwendungstastatur statt erst am Textfeld behebt den
lokalen Tastaturabbruch. Das ist kein experimenteller StopProcessing-Nachweis.
Die anfänglichen Harnessfehler (leeres Lesen, macOS-PTY nach Sessionende nicht
messbar, Bytes in JSON) wurden im Testtreiber korrigiert, nicht als UI-PASS gezählt.
Auffällige Baudraten und lflag werden als Beobachtung gespeichert; eine bestimmte
Frameworkursache wird daraus nicht behauptet.

Scope-/Build-/Restore-/NuGet-Rohdaten stehen ebenfalls unter `evidence/`.
Der öffentliche NuGet-Feed meldete keine bekannten Schwachstellen für die
aufgelösten Pakete; das ist kein vollständiges Sicherheits- oder Lizenzreview.
Onigwrap bleibt eine native MSL-/Lieferkettengrenze. Keine private Feedkonfiguration
wird veröffentlicht. Ein lokaler unversionierter Payload ist kein Commitnachweis;
[manifest.json](evidence/manifest.json) bindet die Dateien an SHA-256.

### Grenzen und nächste Korrektur

Vor endgültiger Auswahl: F04 gezielt diagnostizieren und denselben normalen,
Fehler- und Abbruchpfad erneut messen; Renderer/Adapter bei Bedarf revidieren.
Danach fehlende reale Tasten-/Remap-, Wiederöffnungs- und StopProcessing-Fälle,
Mac B, native Windows-11- sowie Ubuntu/WSL2-Oberflächen und die benannten
Screenreader-/Braillekombinationen prüfen. Erneutes anderes Review nach Korrektur.
Keine Standards oder Abnahmekriterien wurden abgeschwächt.

Der erlaubte Schreibumfang war Feature-Testquellen, lokale temporäre Builds und
Feature-Evidence/Planungsdokumentation sowie ausdrücklich genehmigtes lokales
Routingprofil. Routing ist Aligned. Intake, Receipt, Intake-Review, globale
Guidance, Registry, Constitution und Statistik bleiben unverändert. Keine
Implementierung, Serienaktivierung, Commits, Pushes oder Remote-Writes.

## EN — Outcome on 8 October 2026

The commissioned isolated tests provide actual partial evidence and a failed
restoration proof. **F01–F07 have not passed as a whole. OD-01-001/002 and the
product-start gate remain open.** See the separate decisions and independent
technical review linked above.

Mac A is the MacBook Air M2 (2023), Arm64, with PowerShell 7.6.6, .NET 10.0.12,
SDK 10.0.401 and Terminal.Gui 2.5.0. Supplemental scope/model tests ran in an
existing local Podman image: Ubuntu 24.04.4 Arm64, PowerShell 7.6.4/.NET 10.0.11.
This proves no native Windows, Mac B, WSL2 or physical/assistive terminal surface.

F01: redirected UI rejection before Init and 18 synthetic model assertions passed
on Mac and Linux. Actual capability/key-binding coverage is incomplete. F02:
global/function/module synthetic values and unchanged caller context passed;
private scopes, host types and repeated UI entry are not generally proven. F03:
actual F1/F5/Alt+X retain value/focus; complete keys/alternatives/remapping remain
open. F04: cursor/alternate-screen leave sequences are observed, but actual stty
settings differ after normal/error/keyboard-cancel/resize. The no-UI control does
not change them. Restoration failed; exact cause and StopProcessing remain open.
F05: actual resizing and exit directly at 30×6 retain value/focus; this closes only
the local size/escape issue. F06: real screenreader/Braille and complete keyboard
coverage are missing. F07: dependency/native assessment, separate decisions and
independent review exist, but the overall gate cannot pass with these findings.

The disposable fixture has no product/target executor or later-intake features.
PTY records contain escaped raw transcripts, source/assembly hashes and measured
host stty state. ANSI replies emulate only a terminal channel. Exit sequences do
not establish physical cursor appearance. `InitialPtySettingsMatch` concerns the
PTY before host start; `Result.TerminalRestored` is the relevant host comparison.
Any timeout termination remains a failure even with exit 0 or a saved result.
The half-second post-result window permits measurement before macOS closes the
PTY; it is no product acceptance timeout. Original cancellation failure remains
historical. Application-level keyboard interception fixes that local issue without
proving StopProcessing. Harness defects were corrected, never counted as UI passes.

Public NuGet vulnerability data reports no known vulnerable resolved package; this
is no complete security/licence audit. Native Onigwrap/drivers remain separate
memory-safety/supply-chain risks. Evidence is an uncommitted payload, not a commit.
Before final selection, isolate and fix restoration, rerun affected cases, complete
real action/re-entry/cancellation/platform/assistive proof and obtain distinct
re-review. No acceptance criterion was weakened. Writes remain local proof/design
and explicitly approved unversioned routing refresh (Aligned). Intake provenance,
shared rules and statistics are unchanged; no product/delivery/series action ran.
