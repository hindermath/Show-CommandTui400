# Sitzung und Terminal / Session and terminal

## DE — Benutzung des begrenzten Inkrements

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

## EN — Using the bounded increment

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
