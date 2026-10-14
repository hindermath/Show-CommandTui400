# Sitzung und Terminal / Session and terminal

## DE — Historischer Stand T018–T036

Der folgende Abschnitt beschreibt die erste gelieferte Generation. Aktuell ergänzt
die Tastatursektion unten T037–T044 und erweitert die Remapoberfläche.

`Show-CommandTui400` öffnet eine einfache Hilfe-/Ende-Ansicht in der aktuellen
PowerShell-Sitzung. Voraussetzung: ConsoleHost, PowerShell mindestens7.6.4,
Host-.NET10, interaktive Eingabe/Ausgabe und unterstützte Terminalfähigkeit.
Mac A wurde mit7.6.6 geprüft. macOS unterstützt derzeit arm64, Linux glibc/x64;
Unix verlangt TERM=xterm oder xterm-256color und Virtual-Terminal-Unterstützung.
Windows nutzt native Console-APIs. Fremde OS-Adapter haben bisher Double-Nachweise.

Build aus dem Repository mit `Invoke-Lh01ContractProof.ps1 -CaseId B01 -BuildRoot`
und einem neuen kanonischen externen Verzeichnis, etwa `/private/tmp/lh01-build`.
Unter Windows einen expliziten neuen Pfad verwenden. Der Testeinstieg nutzt den
laufenden PSHOME und gesperrte Pakete; keine Werkzeuge eigenmächtig installieren.
Danach das erzeugte `ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1` importieren
und `Show-CommandTui400` aufrufen. Build-/Testartefakte sind keine Releasepakete.

F1/Alt+H zeigt Hilfe, F3/Alt+X beendet, F12/Esc/Alt+B kehrt zur einfachen Ansicht
zurück. `-KeyBinding @{Help='F2'}` ändert eine Startbelegung. Nur Help/Back/Exit,
exakte Schreibweise und dokumentierte Tasten sind zulässig; Kollisionen und
Verdrängen fester Alternativen werden vor Terminaländerung abgewiesen.
Vollständige Aktionen, Aktionsmenü, Größen-/A11Y-Oberflächen und Modulhelp folgen
T037–T056. Keine Suche, Formulare, Zielmodule oder Befehlsausführung vorhanden.

Kein neues pwsh/Runspace/Host wird erzeugt; keine Ausgabeobjekte. Variablen,
Funktionen, Arbeitsort und Präferenzen bleiben im bestehenden Kontext. Das ist
keine Zusage für beliebige private Scopezugriffe. Ctrl+C/StopProcessing endet
ohne Zielwirkung; die Pipeline darf PipelineStopped melden. Unsupported/Redirect
liefert CapabilityRejected; falsches Remap InvalidConfiguration; Konflikt mit
laufender UI InvalidContext; behandelter Fehler HandledFailure. Restorefehler
liefert RestorationFailure; beide Ursachen bleiben bei Doppelfehlern erhalten.
Dann keine weiteren positiven Starts, sondern Nachweis/Korrektur prüfen.

Mode-/Cursorrestore ist auf Mac A synthetisch belegt. Externer Kill, Hostausfall
und Stromverlust sind nicht garantiert beherrschbar. Praktische Terminals und
Screenreader bleiben Deferred; Braillehardware wegen fehlendem Gerät Excluded.
Andere Plattformen, vollständige LH-01-/LH-00-Abnahme und Folgefeatures sind offen.
Details: [Mac-A-Nachweise](../validation/lh01/session-terminal.md).

## EN — Historical T018–T036 state

This section records the first delivered generation. The keyboard section below
adds T037–T044 and expands the remap surface.

The command opens a simple help/exit view in the current PowerShell session.
It requires interactive ConsoleHost, PS7.6.4+, host.NET10 and supported VT capability.
Mac A was tested on7.6.6. Current native boundaries are macOS arm64, Linux glibc/x64
and Windows Console APIs; Unix requires TERM=xterm or xterm-256color. Foreign OS
adapters currently have double evidence only.

Use the contract proof script with B01 and a new canonical external BuildRoot,
then import the built module manifest listed above. It references the caller's
PSHOME and locked packages; install nothing implicitly. Build outputs are not releases.
F1/Alt+H opens help, F3/Alt+X exits, F12/Esc/Alt+B returns to the simple view.
The shown Help-to-F2 configuration accepts exact supported names/keys only;
conflicts and displaced fixed alternatives are rejected before terminal mutation.
Full actions, resize/accessibility views and module help remain T037–T056 work.
No search, forms, target modules or target execution exist.

No new host/process/runspace is created and no objects are emitted. Existing
context is retained without promising arbitrary private scope access. Ctrl+C or
StopProcessing exits without domain effects; PowerShell may report PipelineStopped.
Error prefixes distinguish capability, configuration, context, handled operation
and restoration failures. Combined failures retain both causes; stop positive
runs after restoration failure. Native mode/cursor proof is synthetic Mac A only.
External kill, host or power failure cannot guarantee recovery. Practical terminals
and screen readers remain Deferred, Braille hardware Excluded for lack of a device.
Other platforms and complete LH-01/LH-00 acceptance remain open; see linked evidence.

## DE — Tastaturinkrement T037–T044

F1/Alt+H öffnet lokale Hilfe, Alt+M die textuelle Aktionsübersicht. Tab,
Umschalt+Tab, Pfeile und Bildtasten bewegen den Fokus zwischen den lokalen
Hilfe-/Aktions-/Refreshknöpfen. Enter betätigt den fokussierten Knopf, niemals
einen Zielbefehl. F5 aktualisiert die Ansicht und erhält Werte/Fokus; F12/Esc/Alt+B
kehrt eine Ebene zurück. Auf der Wurzel bleibt Zurück ohne Beenden. F3/Alt+X
beendet. F4/F9/F10/F11 bleiben sichtbar nicht verfügbar.

`-KeyBinding @{Help='F2';Refresh='F6'}` ersetzt die Primärtasten tatsächlich.
Alle acht definierten Funktionstastenaktionen sind konfigurierbar; feste
Alt+H/B/X/M- und Esc-Pfade bleiben erhalten. Kollisionen werden vor Init abgewiesen.
Die Legende zeigt die wirksame Belegung. [Nachweis und Grenzen](../validation/lh01/keyboard-actions.md).

## EN — Keyboard increment T037–T044

F1/Alt+H opens local help, Alt+M the text action overview. Tab, Shift+Tab, arrows
and page keys move focus between local Help/Actions/Refresh controls. Enter
activates that control without invoking any target. F5 refreshes while retaining
values/focus; F12/Esc/Alt+B goes back one level. Root back never exits. F3/Alt+X
exits. F4/F9/F10/F11 stay visibly unavailable.

The example above really replaces the primary keys. All eight defined function-key
actions can be remapped; fixed Alt+H/B/X/M and Esc remain reachable. Conflicts fail
before Init. The legend shows effective bindings. The linked proof records limits.

## DE — Textzustand und Größe bis T052

Die TUI zeigt Namen, Verfügbarkeit, Fokus, Beschäftigtzustand, Status und Fehler
als Text. Hilfe/Aktionen lassen sich mit Bildtasten blättern. Unterhalb der aus
den konkreten Knöpfen und Textzeilen abgeleiteten Mindestgröße erscheinen zuerst
Alt+X Ende und Alt+H Hilfe. Bei1x1ist kein Volltext möglich; Alt+X bleibt wirksam.
Resize erhält lokale Werte/Fokus, nach Vergrößern ist Navigation wieder möglich.
Fehlertexte enthalten keine Terminal-Steuerzeichen. Kein zusätzlicher öffentlicher
Parameter. [Text-/Größennachweis](../accessibility/lh01-text-state.md) und
[Negativgrenzen](../validation/lh01/security-negative.md).

## EN — Text state and size through T052

Names, availability, focus, busy state, status and errors are text. Page keys scroll
help/actions. Below the layout-derived minimum, recovery keys appear first. A1x1
view cannot display full text; Alt+X still exits. Resize retains local values/focus
and navigation resumes after enlargement. Errors cannot inject terminal control
characters. No new public parameter. The linked proof records practical limits.
