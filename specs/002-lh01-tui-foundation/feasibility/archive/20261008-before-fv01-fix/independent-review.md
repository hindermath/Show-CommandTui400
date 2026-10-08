# Unabhängiges technisches Review / Independent technical review

Datum / Date: 2026-10-08. Prüfer / Reviewer: separater Agent `/root/lh01_feasibility_review`.

## DE — Ergebnis und Grenzen

**Status: Produktgate offen; kein Ready für Produktimplementierung.** Die isolierte Machbarkeitsarbeit liefert nützliche lokale Teilnachweise, aber keine vollständige F01–F07-Abnahme. OD-01-001/002 bleiben offen. Dieses Review ist kein Intake-Review, keine Ownerfreigabe und keine vollständige Plattform-/A11Y-Abnahme.

Geprüft wurden die nachstehend gehashten Fixture-Quellen und real ausgeführte synthetische Mac-A-PTY-Läufe einschließlich ursprünglichem Ctrl+C-Fehlversuch und gezielten Wiederholungen. PTY bedeutet Pseudoterminal; es emuliert einen Terminalkanal, keine physische Terminaloberfläche oder assistive Technologie. Der Reviewer hat Quellcode und gespeicherte Beobachtungen unabhängig geprüft; er hat die Läufe nicht selbst wiederholt. Die finalen Scope-Rohdaten für Mac A und Ubuntu-Container, Build/Restore-Ausgaben, öffentlicher NuGet-Audit sowie README/Entscheidungsstand und Payloadmanifest wurden zusätzlich gelesen und gebunden. Die 18 Modellassertionen, synthetischen Werte 710/711/712 und unveränderten Kontexte stimmen in beiden Scope-Dateien; Linux weist keine UI- oder WSL2-Prüfung nach.

### Nachweise

- Kein Produkt-Cmdlet, Zielausführungspfad, späteres LH-02–LH-07-Feature oder Serienänderung im Fixture erkennbar. Der PowerShell-Runner verwendet ausschließlich synthetische Werte. Terminal.Gui wird gepinnt; das Lockfile enthält auch transitive Pakete. Die Host-SMA-Referenz wird nicht als zusätzliche Runtime kopiert.
- Normaler PTY-Lauf: F1, F5 und Alt+X erreichen die erwarteten Fixture-Aktionen. Synthetischer Wert und tatsächlicher Eingabefokus bleiben erhalten. Prozess, Runspace, Arbeitsort, Variable, Funktion und Präferenz stimmen vor/nach dem Lauf überein. Das beweist nicht alle Tasten, alle Scopefälle oder alle Hosttypen.
- Fehlerlauf: Der injizierte Fehler ist gespeichert, der synthetische Aufruferkontext bleibt erhalten. Cursoranzeigen- und Alternate-Screen-Endesequenzen werden bei normalem Ende, Fehler, finalem Tastaturabbruch und Resize beobachtet. Eine gesendete Endesequenz beweist keine vollständige Terminalrestauration.
- Resize: 100×24 → 30×6 → 100×24 wurde ausgeführt; Wert und Fokus bleiben in den beiden Resize-Ereignissen erhalten. Dies ist ein echter Framework-Teilnachweis und kein bloßer ActionState-Modelltest.

### Offene Befunde und Folgeschritte

| ID | Schwere | Befund | Erforderlicher Nachweis |
|---|---|---|---|
| FV-01 | High | F04: Bei normalem Ende, Fehler, finalem Tastaturabbruch und Resize sind stty/termios vorher und nachher verschieden. Ein ansonsten gleicher Kontrolllauf ohne UI liefert identische Host-stty-Werte. Die Beobachtung enthält geänderte lflag und auffällige Baudraten. | Auf PowerShell-/PTY-Grundverhalten, Fixture und Framework isolieren; native Messgrenzen prüfen; vollständige Wiederherstellung erneut beobachten. Keine Frameworkursache ohne Kontrollversuch behaupten. |
| FV-02 | Closed, lokaler Tastaturpfad; StopProcessing Open | Der ursprüngliche Ctrl+C-Timeout ist historisch erhalten. Die finale Anwendungstastatur (`app.Keyboard.KeyDown`) liefert Cancel-Ereignis, Exit 0, unveränderten Aufruferkontext sowie Cursor-/Alternate-Screen-Endesequenzen ohne Timeout. | Tastaturproblem lokal behoben. StopProcessing ist nicht tatsächlich geprüft; vollständige Terminalrestauration bleibt FV-01. |
| FV-03 | Closed, lokal | F05: Die ursprüngliche Anleitung wurde bei 30×6 abgeschnitten. Nach Korrektur auf „Alt+X Ende/Exit“ bestätigt `maca-pty-small-exit.json` das Ende direkt bei 30×6, mit erhaltenem Wert und Fokus. | Lokales Mindestgrößen-/Escape-Problem behoben. Kein Abschluss von F04, Assistivzugang oder anderer Plattform. |
| FV-04 | Medium | F03/F06: Noch keine vollständige Tasten-/Alternativen-/Kontextmatrix, kein reales Remapping und keine tatsächlichen Screenreader-/Braillebeobachtungen. ActionState prüft ein eigenes Modell; sein Erfolg ist kein Terminal.Gui-Bindingnachweis. | Benannte Terminal-/Assistivwerkzeuge und konkrete Aktionen beobachten; ungeeigneten Renderer revidieren. N/A darf fehlende anwendbare A11Y-Evidence nicht ersetzen. |
| FV-05 | Medium | F07/MSL: TextMateSharp → Onigwrap ist eine konkrete native Abhängigkeit. C# macht native Bibliotheken und Terminaltreiber nicht automatisch speichersicher. | Native Nutzungsgrenzen, Plattformartefakte, Lieferkette und verbleibende Risiken bewerten. Ein NuGet-Audit ohne gemeldete Schwachstellen ist kein umfassendes Sicherheitsaudit. |

Owner für die technischen Folgeschritte: Projektowner Thorsten mit beauftragtem technischen Bearbeiter. Wiedervorlage: vor endgültiger OD-Entscheidung bzw. jeder Produktimplementierungsfreigabe. Es gibt keine Risikoannahme durch dieses Review.

### Getrennte Entscheidungen

C# ist als lokal kompilierter Fixture-Kandidat plausibel; MSL-Einstufung bleibt wegen nativer Grenzen gesondert zu begründen. PowerShell/.NET-Runtime, Terminal.Gui-Version, minimale unterstützte PowerShell-Version und Sitzungsintegration sind eigenständige Entscheidungen. Der direkte Binärcmdlet-Zugriff ist lokal teilweise belegt. Daraus folgen keine globale Primärsprachänderung und keine Mindestversion für alle Zielplattformen. Terminal.Gui ist wegen FV-01–FV-04 noch nicht als endgültiger Produkt-Renderer bestätigt. Mac B, Windows 11 und Ubuntu/WSL2 bleiben ohne ausgeführte lokale Nachweise offen.

## EN — Outcome and boundaries

**Status: product gate remains open; not Ready for product implementation.** The isolated feasibility work provides useful local partial evidence, not full F01–F07 acceptance. OD-01-001/002 remain open. This is a distinct technical review, not intake review, owner approval or complete platform/accessibility acceptance.

The reviewer independently inspected the hashed fixture sources and recorded synthetic Mac-A pseudoterminal runs, including the original cancellation failure and focused retries, without repeating them. A pseudoterminal emulates a terminal channel, not a physical terminal or assistive tool. Final raw Mac/Ubuntu-container scope evidence, build/restore output, public NuGet audit, README, decisions and payload manifest were also independently inspected and bound. Both scope records contain 18 model checks, values 710/711/712 and unchanged context; Linux has no UI or WSL2 proof.

The fixture contains no product cmdlet, target executor, later-intake feature or series mutation. The runner uses synthetic values. Terminal.Gui is pinned with a transitive lock; host SMA is not copied as a second runtime. Normal F1/F5/Alt+X actions retain the input value and real focus; the synthetic caller context is unchanged. The injected failure also retains caller context. Cursor-show and alternate-screen-leave sequences are observed for normal/error/keyboard-cancel/resize, but do not prove complete restoration. Real resizing 100×24 → 30×6 → 100×24 retains value and focus.

Open findings mirror the German table: **FV-01 High**, stty/termios differs after normal/error/keyboard-cancel/resize, while the no-UI control retains host stty; isolate the cause without blaming the framework. **FV-02 locally Closed for keyboard cancellation; StopProcessing Open**: the original timeout is historical. Final application-level keyboard handling yields a Cancel event, exit 0, unchanged context and leave sequences without timeout. This does not prove StopProcessing or full restoration. **FV-03 locally Closed**, the originally truncated instruction was shortened to “Alt+X Ende/Exit”; the focused small-exit run confirms exit directly at 30×6 with retained value/focus, without closing restoration or assistive/platform evidence. **FV-04 Medium**, the complete action/remap/assistive matrix is absent; model assertions are not real bindings or screenreader/Braille proof. **FV-05 Medium**, native Onigwrap/driver boundaries require separate memory-safety and supply-chain evidence; a vulnerability feed reporting nothing is not a security audit.

Technical follow-up owner is Thorsten with the commissioned technical contributor. Re-evaluate before final OD decisions or product implementation approval. No risk acceptance is granted. Keep language/MSL, runtime, framework, PowerShell minimum and session integration separate. C# is a plausible local candidate; Terminal.Gui remains unconfirmed as product renderer. The direct binary cmdlet has partial local session evidence only. Mac B, native Windows 11 and Ubuntu/WSL2 evidence remains open.

## Hashbindungen / Hash bindings

Alle Payloadmanifest-Einträge und finalen PTY-Quell-/Assemblybindungen stimmen überein. Historischer Ctrl+C-Fehlversuch bleibt gesondert. SHA-256 der unabhängig gelesenen finalen Bytes; eigene Reviewdatei ausgenommen. / All payload manifest and final PTY source/assembly bindings match. Historical cancellation failure remains separate. SHA-256 of independently inspected final bytes; this review file is excluded.

| Pfad / Path | SHA-256 |
|---|---|
| `README.md` | `42245885421ee765ea196b3db61fc8a34db3157e6fb9dfe778a41147531054db` |
| `decisions.md` | `f3a2f671329fee179494571f45678c5116a4b834586990420ecc7212c790919c` |
| `evidence/build-maca.txt` | `f00886fbb1d61ff414cdb1ee9ac9847b14856db204cf0e951b663a293b17b452` |
| `evidence/linux-environment.json` | `45a0fc2a07ffe3ccd21d5ada071ad9a61dbfa7c6af9725473e99e2b554f80947` |
| `evidence/linux-image.txt` | `b8545b359553e6a083a24556f6aea2b9eeb231bc394b998605f526385da58a9f` |
| `evidence/linux-scope.json` | `b758ec3e6dc2614c8c16861927b6c65250119e1b823c9b9c6e174a35a3476256` |
| `evidence/locked-restore.txt` | `1673e9bbcd908d6c34aad5f8282239c223612861029b92423c33dfe3de7ebd5a` |
| `evidence/maca-pty-cancel-before-keymap.json` | `7e37d002d789405a1651131406ed7b8b0cb3bdba047a47069a32cd819a087b71` |
| `evidence/maca-pty-cancel.json` | `4a2c3ecc3215f833b2049cadb2055493d639ccd73e25a0bc6286e9eb1cb43e05` |
| `evidence/maca-pty-control.json` | `240d06c10a96697fcc49aabcc9b0a9f2f4128e77e14bbdcc6f3660106667ef3c` |
| `evidence/maca-pty-error.json` | `22ab012bc8f0c280416e13da5e7226d966e145defbea1552d538236fb277dc6d` |
| `evidence/maca-pty-normal.json` | `10bea0145232390f9fbebb5ca4acc3a7bb2b945741d338dea9d7e53c8cc0a77c` |
| `evidence/maca-pty-resize.json` | `7fa5127f787eb5db49df41980beba12229bdf81e8c17a20095a5338a60260e34` |
| `evidence/maca-pty-small-exit.json` | `a6c50d5feb88c472cf455bbe00845a813c9a565584b59ab68c8fbb54c387e797` |
| `evidence/maca-scope.json` | `f33aefed9bcc1867fcaef91b81a96341c0b4beebb6ab1271735fe942b0a960a7` |
| `evidence/manifest.json` | `81738a0964bae41379cd1a611cd08dd389f174511492eb5c7223699ae07f1e6b` |
| `evidence/nuget-vulnerability-audit.json` | `4401abbcf95d7f474e2ffedcf68111b5c8541e4d1d15180ed0e8f9b4ebd8d26c` |
| `src/Directory.Build.props` | `5db21870b2d6450b0e3bb5fa16bdf4af49680c59de93bfa5b321daa5cf271133` |
| `src/Fixture.cs` | `50419159533f40bcf81d6467bd001bb0bef9a59d46f4bf914c64ad3c3b8b79fc` |
| `src/Lh01Fixture.csproj` | `23cc499fc374cfbe1782765c402c1ea67cdb6a10dde2dd58e03fa32cfba50838` |
| `src/NuGet.Config` | `33aa39ee926a9e2651ae39549df08dddc8e43d11896cf14d0465bc869d56b4c2` |
| `src/packages.lock.json` | `9a50991596ca623b8d4041f1ad193d9f3c18fcadaac18f5df824f2fb7baf4813` |
| `src/probe-session.ps1` | `9c574dcd3ab4f43427506d0895795658c470a59f8f32bd445f615811db682574` |
| `src/pty-probe.py` | `08a599542afb9f59fe4e122b425b01910b50ff093317ff53cb3bbcee7a518320` |
