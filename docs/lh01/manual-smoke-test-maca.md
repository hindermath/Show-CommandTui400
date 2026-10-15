# Manueller Einstieg auf Mac A / Manual first run on Mac A

## DE — Zweck und Voraussetzungen

Diese Kurzanleitung zeigt die ersten einfachen Bedienproben für
`Show-CommandTui400` auf Mac A (MacBook Air M2 2023). Sie dokumentiert Befehle,
keine bereits ausgeführten Tests oder formale Plattformabnahme.

Benötigt werden ein interaktives Terminal, PowerShell mindestens 7.6.4 mit
Host-.NET10 und das .NET10-SDK. Unix verlangt `TERM=xterm` oder
`TERM=xterm-256color` und Virtual-Terminal-Unterstützung. Keine Ein-/Ausgabe
umleiten und das Cmdlet nicht in eine Pipeline einbetten.

Der Build verwendet gesperrte Paketversionen und kann Pakete von nuget.org
laden. Buildausgaben landen in einem neuen temporären Verzeichnis; es wird
kein Releasepaket installiert. Der Repositorypfad unten gilt für Mac A;
bei einer anderen Ablage nur diesen Pfad anpassen.

### 1. Frische PowerShell-Sitzung öffnen

Im Terminal ausführen:

```bash
pwsh -NoProfile
```

Die folgenden Blöcke in dieser PowerShell-Sitzung ausführen. Für einen späteren
Neubuild eine frische Sitzung verwenden: Bereits geladene .NET-Assemblies
werden durch einen erneuten Modulimport nicht zuverlässig ersetzt.

Voraussetzungen anzeigen:

```powershell
$PSVersionTable.PSVersion
$Host.Name                    # Erwartet: ConsoleHost
[Environment]::Version        # Erwartet: .NET 10
$env:TERM                     # xterm oder xterm-256color

dotnet --version              # .NET10-SDK erforderlich
```

### 2. Produkt bauen und Modul importieren

```powershell
Set-Location /Users/thorstenhindermann/RiderProjects/Show-CommandTui400

$manualBuild = "/private/tmp/lh01-manual-$([guid]::NewGuid().ToString('N'))"

dotnet build src/ShowCommandTui400/ShowCommandTui400.csproj `
    -p:RestoreLockedMode=true `
    "-p:RestoreConfigFile=$PWD/src/ShowCommandTui400/NuGet.Config" `
    "-p:LH01BuildRoot=$manualBuild"

if ($LASTEXITCODE -ne 0) {
    throw "Build fehlgeschlagen."
}

Import-Module "$manualBuild/ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1"
Get-Command Show-CommandTui400
```

Erwartung: Build ohne Fehler; `Get-Command` findet das Cmdlet. Die bekannte
CS0618-Warnung zum schreibgeschützten `TextView` ist dokumentiert und wird
nicht unterdrückt. Bei einem Build-/Importfehler hier stoppen.

### 3. TUI öffnen und bedienen

```powershell
Show-CommandTui400
```

Eine TUI ist eine textbasierte Bedienoberfläche. Erwartet wird die aktuelle
Grundansicht mit Hilfe, Aktionen und Statusinformationen.

| Eingabe | Erwartetes Verhalten |
|---|---|
| Tab / Umschalt+Tab | Fokus vorwärts / rückwärts wechseln |
| Enter | Die fokussierte lokale Aktion betätigen |
| F1 | Hilfe öffnen |
| F5 | Ansicht aktualisieren |
| Esc / F12 | Eine Ebene zurück; auf der Wurzel bleibt die TUI offen |
| F3 | TUI beenden und zur PowerShell zurückkehren |
| Terminal verkleinern / vergrößern | Kleine Ansicht mit Rettungstasten; danach wieder navigierbare Oberfläche |

Für Funktionstasten auf dem Mac gegebenenfalls zusätzlich **fn** drücken.

**Alt-Kürzel in macOS Terminal.app:** Unter **Terminal → Einstellungen →
Profile → aktives Profil → Tastatur** bei **„Option als Meta verwenden“**
die Auswahl **„Nur rechte Option“** setzen (Owner-Konfiguration auf Mac A).
Meta ist hier die vom Terminal gesendete Alt-Tastenkombination. Damit öffnet
**rechte ⌥+H** die Hilfe, **rechte ⌥+B** geht zurück und **rechte ⌥+X** beendet
die TUI. Die **linke Option-Taste** behält ihre normale Sonderzeicheneingabe,
etwa `@` und `~` auf der verwendeten deutschen Mac-Tastatur. Die Einstellung
gilt für das ausgewählte Terminalprofil; bei anderen Tastaturlayouts können
die Sonderzeichen anders belegt sein. Tab/Enter und Funktionstasten bleiben
als weitere Bedienwege verfügbar.

Nach F1 muss im Textbereich „Hilfe / Help: Hilfe und Aktionen / Help and actions“
stehen. Hilfe lässt sich auch mit Enter auf „Hilfe / Help“ öffnen.
Nach dem ersten F5 wechselt der Status von „Bereit / Ready“ zu
„Ansicht aktualisiert; Werte erhalten / View refreshed; values retained“.
Weitere Aktualisierungen zeigen denselben Status; es gibt keinen Zähler oder
wechselnde Beispieldaten. Enter auf „Aktualisieren / Refresh“ wirkt genauso.

Nach einer Codekorrektur eine neue `pwsh -NoProfile`-Sitzung öffnen und Schritt 2
(Build und Import) erneut ausführen. Eine bereits geladene Assembly wird durch
`Import-Module -Force` nicht zuverlässig ersetzt.

Suche, Parameterformulare und Zielbefehlsausführung sind noch nicht vorhanden.
Nach dem Beenden muss der PowerShell-Prompt wieder bedienbar sein. Ein erneutes
`Show-CommandTui400` prüft die Wiederöffnung.

### 4. Geänderte Tastenzuordnung ausprobieren

Nach dem Beenden des vorherigen Laufs:

```powershell
Show-CommandTui400 -KeyBinding @{ Help = 'F2'; Refresh = 'F6' }
```

Erwartung: F2 öffnet Hilfe, F6 aktualisiert. Die bisherigen Primärtasten F1/F5
lösen diese Aktionen nicht mehr aus; die Legende zeigt die neue Belegung.
F3 beendet weiterhin. Feste Alternativen wie Alt+H und Alt+X bleiben erhalten.

### 5. Beobachtungen festhalten

Notiere Versionen, Terminal, verwendete Tasten, erwartetes/tatsächliches
Verhalten und etwaige Fehlermeldungen. Bei `RestorationFailure` keine weiteren
Starts durchführen und die vollständige Fehlermeldung festhalten. Keine privaten
Sitzungswerte oder Tokens in öffentliche Fehlerberichte übernehmen.

Weitere Bedienung: [Sitzung und Terminal](session-and-terminal.md).
Formale automatisierte Zielprüfungen sind getrennt im
[Plattformvertrag](../validation/lh01/platform-handoff.md) beschrieben.
Diese Anleitung schließt keine Aufgabe oder Abnahme ab; praktische
Terminal-/Screenreader-Nachweise bleiben separat, Braillehardware ausgeschlossen.

## EN — Purpose and prerequisites

This guide provides the first manual checks for `Show-CommandTui400` on Mac A,
a MacBook Air M2 2023. It records instructions, not completed tests or formal
platform acceptance.

Require an interactive terminal, PowerShell7.6.4+ on host .NET10 and the .NET10
SDK. Unix requires TERM=xterm or xterm-256color and virtual-terminal support.
Do not redirect input/output or invoke the cmdlet through a pipeline.

Locked restore may download packages from nuget.org. Build output uses a new
temporary directory; no release package is installed. The repository path below
is the Mac A path; adjust only that path for another checkout location.

### 1. Open a fresh PowerShell session

Run in your terminal:

```bash
pwsh -NoProfile
```

Run the following blocks in that PowerShell session. Start a fresh session for
later rebuilds: importing the module again does not reliably replace already
loaded .NET assemblies.

Inspect prerequisites:

```powershell
$PSVersionTable.PSVersion
$Host.Name                    # Expected: ConsoleHost
[Environment]::Version        # Expected: .NET 10
$env:TERM                     # xterm or xterm-256color

dotnet --version              # Requires .NET10 SDK
```

### 2. Build and import the module

```powershell
Set-Location /Users/thorstenhindermann/RiderProjects/Show-CommandTui400

$manualBuild = "/private/tmp/lh01-manual-$([guid]::NewGuid().ToString('N'))"

dotnet build src/ShowCommandTui400/ShowCommandTui400.csproj `
    -p:RestoreLockedMode=true `
    "-p:RestoreConfigFile=$PWD/src/ShowCommandTui400/NuGet.Config" `
    "-p:LH01BuildRoot=$manualBuild"

if ($LASTEXITCODE -ne 0) {
    throw "Build failed."
}

Import-Module "$manualBuild/ShowCommandTui400/bin/net10.0/ShowCommandTui400.psd1"
Get-Command Show-CommandTui400
```

Expect a build without errors and discovery of the cmdlet. The known CS0618
warning for read-only TextView use is documented and not suppressed. Stop here
if the build or import fails.

### 3. Open and use the TUI

```powershell
Show-CommandTui400
```

A TUI is a text-based user interface. Expect the current foundation view with
help, actions and status information.

| Input | Expected behavior |
|---|---|
| Tab / Shift+Tab | Move focus forward / backward |
| Enter | Activate the focused local action |
| F1 | Open help |
| F5 | Refresh the view |
| Esc / F12 | Go back one level; root back leaves the TUI open |
| F3 | Exit and return to PowerShell |
| Shrink / enlarge terminal | Small view shows recovery keys; navigation resumes after enlargement |

On Mac, function keys may also require **fn**.

**Alt shortcuts in macOS Terminal.app:** Open **Terminal → Settings → Profiles →
active profile → Keyboard** and set **“Use Option as Meta key”** to
**“Right Option Key Only”** (the owner's Mac A configuration).
Meta means the Alt key sequence sent by the terminal. Use **right ⌥+H** for help,
**right ⌥+B** to go back and **right ⌥+X** to exit. The **left Option key** keeps
normal special-character entry, such as `@` and `~` on the German Mac keyboard
in use. This setting applies to the selected terminal profile; other keyboard
layouts may assign different special characters. Tab/Enter and function keys
remain available as alternative controls.

After F1, the text area must show “Hilfe / Help: Hilfe und Aktionen / Help and actions”.
Enter on “Hilfe / Help” also opens help. The first F5 changes the status from
“Bereit / Ready” to “Ansicht aktualisiert; Werte erhalten / View refreshed; values retained”.
Further refreshes show the same status; there is no counter or changing sample
data. Enter on “Aktualisieren / Refresh” has the same effect.

After a code fix, open a new `pwsh -NoProfile` session and repeat step 2
(build and import). `Import-Module -Force` does not reliably replace an already
loaded assembly.

Search, parameter forms and
target command execution are not implemented. After exit, the PowerShell prompt
must remain usable. Invoke `Show-CommandTui400` again to check reopening.

### 4. Try a different key mapping

After exiting the previous run:

```powershell
Show-CommandTui400 -KeyBinding @{ Help = 'F2'; Refresh = 'F6' }
```

Expect F2 to open help and F6 to refresh. Previous primary keys F1/F5 no longer
trigger those actions; the legend shows the new bindings. F3 still exits.
Fixed alternatives such as Alt+H and Alt+X remain available.

### 5. Record observations

Record versions, terminal, keys, expected/actual behavior and errors. If you see
RestorationFailure, stop further starts and retain the full error message. Never
include private session values or tokens in public reports.

See [session and terminal](session-and-terminal.md) for further usage and the
[platform contract](../validation/lh01/platform-handoff.md) for separate formal
automation. This guide completes no task or acceptance. Practical terminal and
screen-reader evidence remains separate; Braille hardware remains excluded.
