# LH-01 technische Entscheidungen / Technical decisions

## DE — Auswahl für die technische Planung

Datum: 2026-10-08. Owner: Thorsten; technischer Bearbeiter: Codex `/root`.
Grundlagen: [Ergebnisse](README.md), [native Bewertung](native-dependency-assessment.md),
[Owner-Nachweisgrenzen](owner-validation-boundaries.md) und
[anderes technisches Review](independent-review.md).

Die folgenden Entscheidungen schließen die technischen Auswahlfragen
**OD-01-001/002**. Sie sind keine vollständige Plattform-/A11Y-Abnahme und kein
Implementierungsauftrag. Die späteren praktischen Nachweise werden separat
geführt; die dokumentierten Ownergrenzen lassen sich nicht als PASS umdeuten.

| Entscheidung | Gewählte Baseline und Begründung | Verbleibende Grenze |
|---|---|---|
| Sprache — OD-01-002 | **C#14**, als Binärcmdlet im laufenden PowerShell-Prozess. Tatsächlicher Scopezugriff und unveränderte Sitzungsidentität auf Mac A, ergänzende Linux-Scopeprüfung. | Keine Ableitung aus RiderProjects. Produktcode noch nicht erstellt; direkte private Aufruferscopes nicht allgemein zugesagt. |
| MSL — OD-01-002 | Eigener Code **managed C#**, ohne unsafe-Blöcke/Pointerarithmetik. MSL bezeichnet die eigenen Sprachgarantien. | Runtime, OS, P/Invoke und native Pakete bleiben gesonderte Vertrauensgrenzen. Der nachgewiesene macOS-ABI-Fehler wird durch explizite Treiberwahl vermieden; native Grenzen sind dokumentiert. |
| Runtime | **.NET10**, target net10.0, Host-SMA referenzieren, nicht mitverteilen. Kein zweiter PowerShell-Host und keine zusätzliche Runtime im laufenden Prozess. | Tatsächlich Mac .NET10.0.12 und Container10.0.11; unterstützte Hostpatches bei Produktprüfung konkret erfassen. |
| Framework | **Terminal.Gui2.5.0, expliziter `dotnet`-Treiber**, hinter eigenem Aktions-/Terminaladapter. | `ansi`-Fallback ausgeschlossen. macOS-Snapshot und Console-Control-C-Lease erforderlich; andere Plattformadapter müssen bei Umsetzung ihre eigenen ABI/Modi prüfen. Nicht aus Darwin kopieren. |
| PowerShell-Minimum — OD-01-001 | **7.6.4** als gewählte Mindestversion, Mindestminor7.6; unterstützte Sicherheits-/Wartungspatches verwenden. Versionsprüfung vor Produkt-UI-Init. | 7.6.4 Scope/Modell im Ubuntu-Container, 7.6.6 interaktiver synthetischer Mac-Host. Keine Unterstützung für frühere Minor-/Patchversionen aus diesen Daten behaupten. Vollständige Runtimeplattformmatrix bleibt ausstehend. |
| Sitzung — OD-01-001 | **PSCmdlet in-process**, aktuelle SessionState/Runspace, synchroner UI-Lauf; keine kopierte Ersatzsitzung. Umgeleiteter Input oder Output wird vor GUI-Init sicher abgewiesen. | StopProcessing im separaten Test-Runspace tatsächlich ausgelöst; das ist ein Testaufbau und kein Ersatzhost des Produkt-Einstiegs. Wiederöffnen im eigentlichen Host zusätzlich geprüft. |
| Tasten/Terminal — OD-01-001 | Kontextaktionen über Adapter; **Alt+H Hilfe, Alt+B Zurück, Alt+X Ende, Alt+M textuelle Aktionsübersicht**. Hilfe im Proof F1→F2 umgelegt; Konflikt mit F3 vor Init abgewiesen. Enter bestätigt, führt nichts aus; Root-Zurück erhält Werte und beendet nicht. | Aktionsübersicht im Proof textuell, keine spätere Featurefunktion. Produktremapping bleibt eine vollständige validierte Zuordnung mit erreichbaren Hilfe/Zurück/Ende. |
| Plattformmatrix | Ziel: macOS/Apple Terminal bzw. kompatibler VT-Host, Ubuntu24.04-Terminal, Windows11/Windows Terminal und WSL2 getrennt. **Heute belegt: Mac-A-xterm-256color-PTY; Linux nur Scope/Modell.** | Geplante Terminalnamen sind keine ausgeführten Oberflächenbelege. Reale Terminal-/Screenreadertests jetzt zurückgestellt; Braillehardware-Nachweis ausgeschlossen, Grund siehe Ownerdatei. |

PENDIN ist ausschließlich ein im nativen Kontrolllauf reproduzierter macOS-
Kernelzustand. Rohe Gleichheit bleibt gespeichert; alle konfigurierbaren Modi,
Controlbytes und beide Baudraten sind im korrigierten Mac-Proof gleich. Zusätzlich
bestehen Shell-Eingaberückgabe, Abbruch, Fehler, Wiederöffnen, Resize und Remapping.
Keine allgemeine Ausnahme für weitere Zustandsänderungen.

Gemeinsame Guidance/Umgebungsregister sind hashgebundene vorgelagerte Quellen mit
ihrem bisherigen unknown-/Kandidatenstand; dieser Lauf schreibt sie nicht um.
Vor Produktstart ist deren gezielte Ausrichtung einschließlich Statistikreferenz-
Reevaluation125 und bei Quellenänderung aktueller Intake-Herkunft erforderlich.
Die technische Auswahl ist hier versioniert vorgesehen, nicht als erfolgtes
Governance-Update oder Lieferung ausgegeben. Kein weiterer Flottenrollout.

Wiedervorlage bei Paket-/Runtime-/Treiberwechsel, neuer nativer Nutzung,
Scopeänderung oder widersprüchlichem Plattformnachweis. Pilot bleibt außerhalb
automatischer Serienauswahl; LH-00 bleibt offen, vollständige Abnahme nach LH-02
vor LH-03. Kein Produkt-, Feature- oder Owner-Abnahmeclaim.

## EN — Technical planning selection

These separate selections resolve **OD-01-001/002**, not practical acceptance or
implementation authority. Evidence, owner limits and distinct review are linked
above. Select C#14 managed in-process PSCmdlet code, .NET10/net10.0 using host SMA
without a second runtime, and Terminal.Gui2.5.0 with **explicit `dotnet` driver**.
No `ansi` fallback. Own code avoids unsafe/pointer arithmetic; runtime/OS/PInvoke/
native packages remain separate trust boundaries. The verified Darwin lease
restores configured modes and control-C handling; other platforms need their own
adapters and evidence, never copied Darwin ABI values.

Select minimum PowerShell **7.6.4**, with supported maintenance/security patches.
Actual evidence is 7.6.4 container scope/model and 7.6.6 synthetic Mac UI. This
claims no earlier-version compatibility or completed platform matrix. Current
session access remains in-process; reject redirected input/output before UI init.
Actual StopProcessing uses a separate test runspace; actual repeated UI entry also
retains the original host context. Alt+H/B/X provide help/back/exit, Alt+M a textual
action overview. Actual F1→F2 help remap and conflict rejection were observed;
root back retains values and Enter never executes targets.

Target physical surfaces remain macOS, Ubuntu24.04, Windows11/Windows Terminal
and WSL2, with no actual-surface claim today. Owner defers physical terminal/screen-
reader tests and excludes Braille hardware proof for lack of hardware in this
personal project. Keep practical acceptance open. Only independently reproduced
PENDIN kernel state is excluded from configured-mode equality; raw data remains.

Hash-bound shared guidance/registry retain their earlier unknown/candidate state.
Before product start, align these sources and reevaluate the C# statistics reference
125; refresh intake provenance if those sources change. This task performs no such
governance delivery or fleet rollout. Revisit changed dependencies/native use/scope/
platform evidence. Preserve standalone pilot and LH-00 acceptance order.
