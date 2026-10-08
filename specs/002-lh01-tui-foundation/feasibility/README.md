# LH-01 korrigierte Machbarkeit / Corrected feasibility

## DE — Aktueller Stand, 8. Oktober 2026

Die automatisierte begrenzte Machbarkeit auf Mac A ist nach Korrektur belegt.
**OD-01-001/002 sind technische Auswahlentscheidungen; vollständige praktische
Plattform-/A11Y-/Featureabnahme bleibt offen.** Keine Produktimplementierung.
[Entscheidungen](decisions.md), [native Bewertung](native-dependency-assessment.md),
[Ownergrenzen](owner-validation-boundaries.md),
[unabhängiges technisches Review](independent-review.md).

Mac A: MacBook Air M2 (2023), Arm64, PowerShell7.6.6, .NET10.0.12,
SDK10.0.401. Terminal.Gui2.5.0, expliziter dotnet-Treiber. Ergänzend Scope/Modell
im vorhandenen lokalen Podman-Container: Ubuntu24.04.4 Arm64, PS7.6.4/.NET10.0.11.
Keine reale Terminaloberfläche, Mac B, Windows-11-/WSL2-Oberfläche, Screenreader
oder Braillehardware wurde geprüft. Reale Terminal-/Screenreadertests sind auf
Ownerauftrag jetzt zurückgestellt; Braillehardware-Nachweis ist im privaten
persönlichen Projekt wegen fehlender Hardware ausgeschlossen. Kein Konformitätsclaim.

| Fall | Aktuelle Beobachtung | Grenze |
|---|---|---|
| F01 | Umgeleitete Streams abgewiesen; stdin-TTY/stdout-Redirect bleibt vollständig unverändert; F3-Remapkonflikt vor Init abgewiesen, ungültiges Enter ohne Bestätigungswirkung. | Kein Targetexecutor; synthetische Negativfälle, keine universelle Host-Capabilityzusage. |
| F02 | Scope710/711/712 global/Funktion/Modul; Prozess/Runspace/Arbeitsort/Präferenz/Funktion erhalten; zweimalige UI-Öffnung im selben Host. | Kein allgemeiner privater Scopezugriff. Linux Scope/Modell, keine Linux-UI. |
| F03 | F1/F3/F4/F5/F9/F10/F11/F12/Esc, Tab/Shift+Tab, Pfeil/Bild, Enter, Alt+H/B/M/X; reale F1→F2-Umlegung mit textueller Legende. Root-Zurück erhält Zustand; Kontextaktionen ohne Folgefeature unavailable. | Synthetische Werte/Liste, keine LH-02–07-Funktion; praktische Oberflächen zurückgestellt. |
| F04 | Normales Ende, Testfehler, Ctrl+C und tatsächlich ausgelöstes StopProcessing stellen konfigurierbare Modi, Controlbytes und beide Baudraten wieder her. Caller Read-Host bestätigt LH01_ACK. | Rohvergleich bleibt wegen separat reproduziertem Kernelbit PENDIN verschieden. Externes Kill/Hostausfall keine Wiederherstellungsgarantie. |
| F05 | Resize100×24→30×6→100×24 sowie Exit direkt bei30×6 erhalten Werte/Fokus und bieten kurze Anleitung. | Kein physischer Cursor-/Fokus-/Hilfsmittelnachweis. |
| F06 | Automatisierte Tastatur-/Textzustandsnachweise. | Reale Terminal/Screenreader deferred; Braillehardware excluded by owner, kein PASS. |
| F07 | 24 Paket-Contenthashbindungen geprüft, native ABI/Onigwrap-Grenzen bewertet, separate Entscheidungen und anderes Review. | Keine vollständige Quell→Binary-Attestation; neue native Nutzung braucht Bewertung. |

[67 beobachtete Vertragsassertionen](evidence/contract-assessment.json) bestehen.
13 automatisierte PTY-Fälle haben ein Result und keinen Timeout. Exit3 bei
injiziertem Fehler, ungültigem Remap und umgeleitetem Output ist erwartet und
nur mit dem jeweiligen ErrorId als erfolgreicher Negativnachweis gewertet.
StopProcessing wurde durch PowerShell.Stop tatsächlich einmal ausgelöst; der
Test-Runspace meldet Stopped. Das ist ausdrücklich ein separater Testaufbau;
der normale Einstieg und das Wiederöffnen bleiben im ursprünglichen Host.

### Diagnose und Korrektur

Der ursprüngliche ANSI-Termios-Pfad verwendet auf Mac Arm64 eine unpassende
native Struct-ABI; C-Probe/SDK zeigen72 statt56Bytes. Kein neuer ANSI-Lauf nach
Diagnose. Explizites `dotnet` plus ABI-korrekte Terminal-Lease und Wiederherstellung
von `Console.TreatControlCAsInput` korrigieren den Ausgangsbefund.

Alle konfigurierbaren Felder werden verglichen. Nur **PENDIN0x20000000** ist als
vom [nativen SDK-Kontrolllauf](evidence/maca-native-raw-control.json) ohne .NET/PS/
Terminal.Gui reproduzierter Kernelzustand ausgenommen. Der rohe Stringvergleich
`Result.TerminalRestored=false` bleibt sichtbar. Der präzisierte relevante Vergleich
`Result.ConfiguredTerminalModesRestored=true` vergleicht sämtliche übrigen Flags,
Controlbytes und Input-/Outputbaudrate. Kein pauschales Maskieren anderer Bits.
`InitialPtySettingsMatch` ist nur die ursprüngliche PTY-Einstellung vor Hoststart.

Vor Init nur lesende native Aufnahme; negative Hostfälle aktivieren keine
schreibende Lease. Aktive Lease wird nach Framework-Dispose wiederhergestellt.
UI- und Restorefehler werden gemeinsam erhalten. Restore-Systemcallfehler wurden
nicht künstlich als echte OS-Fehler ausgegeben; der doppelte Fehlerpfad ist
quellgeprüft, ein späterer Fault-Injectiontest bleibt Produktadapterarbeit.

`src/` enthält nur Wegwerf-Cmdlet/Testtreiber. Kein Produktgerüst. PTY emuliert
ANSI-Antworten; Endesequenzen sind keine tatsächliche Cursorbild-Abnahme. Jeder
UI-Lauf bindet ausgeführte Quelldateien und Assemblyhash; ergänzende Bewertungs-
skripte sind separat im [Manifest](evidence/manifest.json) gebunden. Evidence ist
uncommittierter Payload, kein Commitnachweis. Build/Paketrestore liegen temporär.

Frühere fehlgeschlagene Quellen, Rohdaten, Entscheidungen und Review sind im
[historischen Vorgänger](archive/20261008-before-fv01-fix/README.md) erhalten.
Kein Umschreiben alter Fehlversuche zu PASS. Historischer Ctrl+C-Timeout bleibt
zusätzlich als before-keymap-Datei erkennbar. Intake, Receipt und fachliches
Ready-Review bleiben unverändert; technisches Review ist separat.

### Weiteres Vorgehen

Ausgewählte Baseline in Tasks überführen und anschließend Konsistenz analysieren,
jeweils als eigener Auftrag. Vor Produktstart notwendige Quellen-/Governance-
ausrichtung mit frischer Herkunft bei geänderten gebundenen Quellen, geplante
Security-/Architecture-Gates und eigener Implementierungsauftrag. Produktadapter
für Linux/Windows brauchen ihre eigenen Modi-/ABI-Nachweise. Praktische Abnahme
bleibt mit Ownergrenzen separat; LH-02 sowie Serienaktivierung starten nicht.

## EN — Current outcome

Bounded automated Mac A feasibility is evidenced after correction. ODs resolve
technical choices; complete practical platform/accessibility/feature acceptance
remains open. Use the linked decisions, native assessment, owner limits and
independent review. Mac A uses PS7.6.6/.NET10.0.12, SDK10.0.401, Terminal.Gui2.5.0
with explicit dotnet driver. Supplemental Ubuntu-container scope/model uses
PS7.6.4/.NET10.0.11. Physical terminal/screen-reader tests are owner-deferred;
Braille hardware proof is owner-excluded for lack of hardware. No conformance claim.

Negative mixed-stream and remap/context cases pass. Actual keys, alternatives,
field/list navigation, remapping, repeated host entry, Ctrl+C, error, resize and
PowerShell-triggered StopProcessing are observed. 67 assertions over13 bounded PTY
records pass without timeouts. Exit3 is expected only for the named injected/negative
cases. No target executor/later-intake feature exists. StopProcessing is a separate
test runspace; ordinary and repeated UI use the original session.

The ANSI helper has the wrong Darwin ABI; explicit dotnet and a verified lease
avoid it and restore control-C handling. All configured modes/control bytes/both
speeds match. Preserve raw inequality for PENDIN alone, independently reproduced
by native SDK-only raw/saved control. Configured-mode comparison excludes only
that kernel-state bit; it is no relaxed general restore criterion. Read-Host
roundtrip works. Physical cursor appearance is unproven. Systemcall failure
aggregation is source-reviewed, not presented as executed OS fault injection.

Sources and actual assembly are hashed, with separately bound evaluator code.
Archived failures stay historical. Provenance/intake review is unchanged; this
technical review is distinct. Next: separately commissioned tasks/analysis, then
source/security/architecture readiness before implementation. Other platform
adapters and practical acceptance remain separately evidenced within owner limits;
no product run, commit, remote write or series activation occurred.
