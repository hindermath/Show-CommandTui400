# Tastaturaktionen T037–T044 / Keyboard actions T037–T044

## DE — Ergebnis, Auftrag und Wiederholung

**T037–T044 auf Mac A (MacBook Air M2 2023) abgeschlossen.** Dieser Nachweis
gehört zum ausdrücklich beauftragten Einzelpilot-Inkrement mit MergeAndSync und
Admin-Bypass. T045–T063 und die vollständigen Abnahmen bleiben offen.
Basis vor den Änderungen: `d5212bde1e0955adf5634c0ad59864a485173157`.
Der [Manifestnachweis](keyboard-actions-maca/manifest.json) bindet den tatsächlich
geprüften Arbeitsstand durch Datei- und Assemblyhashes; die Basis ist kein
freigegebener Produktcommit für fremde Hand-offs.

Die neuen Tests schlugen zunächst mit fehlenden Implementierungsklassen fehl
([Test-zuerst](keyboard-actions-maca/test-first.json)). Danach bestand der locked
Build ohne Warnungen/Fehler, mit **31 Modell-/Lifecycle-Prüfgruppen** und ohne
mitkopierte Host-SMA. Sieben negative Driver-Planverträge und vier
Werkzeug-Regressionsgruppen bestehen ebenfalls. Das getrennte
[technische Review](keyboard-actions-review.md) prüft Quellen und Belege.

| Umfang | Konkreter Nachweis | Ergebnis und Grenze |
|---|---|---|
| Whitelist/Kontext/Verfügbarkeit | ActionContractTests; K01–K07 | Unbekannte IDs, gefälschter Kontext und spätere Aktionen ohne Wirkung; Modellwerte erhalten |
| Belegungen/Remap/Kollisionen | KeyBindingTests; K08–K11 | Alle definierten Tasten/Alternativen; alle acht Funktionstastenaktionen remappbar; feste Rückwege |
| Konflikt im öffentlichen Cmdlet | BindingConflict.json | InvalidConfiguration vor Lease/UI; kein Modulwechsel |
| E01-02 Tastaturintegration | Keyboard.json | 26 feste Ereignisse, genaue Aktionen/Kontexte/Accepted-Werte und tatsächlicher Framework-Fokus; Enter auf allen drei Knöpfen |
| E01-02 echtes Remapping | Remap.json | F1/F5 ohne alte Wirkung; F2 Hilfe, F6 Refresh, Alt+H/B/X und Esc bleiben erreichbar |
| E01-02 getrenntes Beenden | FunctionExit.json | F3 beendet; Root-Esc/F12 beendet im Keyboard-Fall nicht |
| E01-01/E01-04 Regression | Zehn weitere PTY-Szenarien | Neun Pass; injizierte RestorationFailure bleibt Fail/Exit1 mit erfülltem Diagnosevertrag |

Alle **14** synthetischen Produktszenarien liefen seriell gegen dieselbe gebaute
Assembly: **13 Pass**, ein absichtlich fehlgeschlagener Restore-Injektionsfall.
Die Injektion erfolgte nach erfolgreichem realem Restore; kein defekter Hostrestore
wird behauptet. Jeder Fall besitzt Exitcode, Eingaben, Umgebung, Assemblyhash und
bereinigten Protokollhash. Keine privaten Sitzungswerte werden aufgezeichnet.
Die Beobachtungsseams sind intern und nur über die Friend-Testassembly erreichbar;
öffentliche Cmdletparameter, Export und Ausgabeobjekte bleiben unverändert.

Wiederholen: zuerst `Invoke-Lh01ContractProof.ps1 -CaseId B01 -BuildRoot <neuer
absoluter isolierter Pfad>`, dann `python3 tests/feasibility/lh01/pty-product.py
--scenario <Fallname> --build-root <derselbe Pfad> --output <neue Datei>`.
Die Skripte liegen in `tests/feasibility/lh01/`; unter macOS `/private/tmp/`
verwenden, da Symlink-/Reparse-Eltern abgewiesen werden. Erwartet wird Exit0;
RestorationFailure erwartet Exit1/Fail und diagnosticContractSatisfied=true.
Bestehende Nachweise werden nicht überschrieben. Native Windows-Ausführung
benötigt weiterhin den separaten Terminaladapter.

## DE — Verhalten, Herkunft und Grenzen

Die [Nutzeranleitung](../../lh01/session-and-terminal.md) beschreibt Hilfe,
Aktionen, Fokus, Rückkehr und wirksame Alternativen. F4/F9/F10/F11 sind sichtbar
nicht verfügbar, auch nach Remap. Refresh/Confirm/Back bewahren Modellwerte;
keine Suche, Formulare, Completion, Zielausführung, Geräteanbindung oder Persistenz.
Der Produktprozess prüft dieselbe Session und unveränderte Module. Modellwerte
sind synthetische Zustandsverträge; daraus entsteht kein bereits geliefertes Formular.

Vor UI-Integration wurden wegen PR #45 gewöhnliche Intake-Updates mit exakten
Vorgängerarchiven und vollständigen unabhängigen Ready-Reviews durchgeführt.
LH-00 und LH-01 blieben bytegleich; IDs und Serienbytes blieben erhalten.
Aktuelle Receipts/Reviews sind die maßgebliche Herkunft. Alte T017-/T036-Berichte
und Hashmanifeste bleiben historische Nachweise ihrer damaligen Generation.
Routing ist nach ausdrücklich genehmigtem lokalem Refresh Aligned; keine Installation.
Die fünf Guidance-Flächen bleiben die gebundene Vorbereitungsbaseline, deren
Konzept-/Produktcode-Aussagen vor dem ersten Produktinkrement entstanden.

Unix-PTY und xterm-Abfrageemulation zeigen Produktverarbeitung synthetischer
Tastenbytes. Sie beweisen weder physische Hosttastenübertragung noch native
Mac-B-/Windows-/WSL2-Unterstützung. Praktische Terminals/Screenreader bleiben
Deferred; Braillehardware Excluded mangels Gerät im privaten persönlichen Projekt.
Keine Konformitätsbehauptung. Die drei Hand-offs bleiben Prepared, nicht ausführbar:
exakte freigegebene Commit-/Kommandobindung und Windows-Terminaladapter fehlen.
LH-00 bleibt offen; LH-02 erfordert eigenen Auftrag, vollständige LH-00-Abnahme
folgt nach LH-02/vor LH-03. Das Assurance-Delta bleibt NeedsRemediation für die
spätere Gesamtprüfung; dieses Inkrement erteilt keine vollständige Abnahme.

## EN — Result, reproducibility and boundaries

**T037–T044 completed on Mac A (MacBook Air M2 2023)** under the explicit bounded
implementation and MergeAndSync/Admin-Bypass request. T045–T063 and full acceptance
remain open. The manifest binds the tested working sources and assembly hashes;
the baseline commit above is not an approved foreign-host product test revision.
New tests failed on missing implementation types first. The locked build then
passed without warnings/errors, with31 model/lifecycle groups and no copied host
SMA. Seven negative driver contracts and four tooling regression groups pass.
The distinct technical review evaluates sources and evidence.

The table maps E01-02 to real product processing: complete26-event keyboard
sequence, exact actions/context/availability, framework focus, Enter on all three
local controls, actual F1→F2 and F5→F6 remaps, pre-Init conflict rejection, root back
and separate F3/Alt+X exit. All eight function-key actions are configurable. Fixed
Alt+H/B/X/M and Esc remain reachable. Later F4/F9/F10/F11 functions stay unavailable
and effect-free after remapping. Synthetic model values survive refresh/confirm/back.
No domain discovery, forms, completion, invocation, device adapter or persistence.
Only the friend test assembly accesses internal observation seams.

Fourteen product PTY scenarios were run serially against one assembly:13 Pass and
one deliberately Fail/exit1 restoration injection, with its diagnostic contract
satisfied. The real native restore succeeded before that injection. Every record
includes exit status, inputs, environment, binary hash and sanitized transcript hash.
The scripts and repeat instructions above require a new isolated build/output;
Windows still needs its separate adapter. No private session data are collected.

Ordinary updates and distinct full Ready reviews refreshed LH-00/LH-01 provenance
before UI integration after PR45. Both intake bytes/IDs and series bytes remain
unchanged. Earlier T017/T036 evidence is historical. Routing is Aligned after the
explicitly authorized local refresh, with no installation. Shared guidance remains
the bound preparation baseline predating product implementation.

Synthetic Unix PTY/xterm protocol emulation does not prove physical host keys,
native Mac B/Windows/WSL2 support or assistive acceptance. Physical terminals and
screen readers stay Deferred; Braille hardware stays Excluded for lack of hardware
in this personal project. All three hand-offs remain Prepared, missing an explicitly
approved exact commit/command binding and Windows terminal adapter. No conformance,
full feature/process acceptance, series activation or next pilot is granted.
