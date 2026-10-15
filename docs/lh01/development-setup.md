# Portable Produktentwicklung / Portable product development

## DE — Voraussetzungen und Einstieg

Owner: Thorsten Hindermann. Stand: 2026-10-15. Für Auszubildende und andere
Entwickler gelten dieselben Schritte; Agentenwerkzeuge sind nicht erforderlich.

- .NET10-SDK mit C#14-Unterstützung; ein Runtime-Paket allein genügt nicht.
- Rider beziehungsweise Visual Studio mit .NET10-Unterstützung; in VS Code die
  Microsoft-C#-Erweiterung `ms-dotnettools.csharp`, optional C# Dev Kit für die
  Solution-Ansicht. Visual Studio benötigt die .NET-Entwicklungswerkzeuge.
- Netzwerkzugriff auf nuget.org beim ersten Restore. Die Repository-Konfiguration
  begrenzt die Paketquellen; keine privaten Feeds oder Anmeldedaten erforderlich.
- Zum Bauen ist keine PowerShell-Installation nötig. Zum Import und Ausführen:
  PowerShell mindestens 7.6.4 mit Host-.NET10. Windows PowerShell 5.1 reicht nicht.

Im Repository-Stamm, nach einem frischen Clone:

```text
dotnet --version
dotnet restore ShowCommandTui400.sln --locked-mode
dotnet build ShowCommandTui400.sln --no-restore
```

Bei jedem Fehler stoppen. `System.Management.Automation` 7.6.4 ist eine private
compile-only NuGet-Referenz: Nur die API wird zum Kompilieren verwendet. Die
laufende PowerShell liefert die Engine. Kein PSHOME-Pfad und keine lokale
MSBuild-Datei erforderlich. Gesperrte Lockdateien verhindern unbeabsichtigte
Paketversionswechsel. Der private PKCS-Pin 10.0.13 mit `IncludeAssets=none`
korrigiert die verwundbare transitive Restore-Version, ohne eine weitere
Laufzeitbibliothek zu liefern. Er aktualisiert keine installierte PowerShell.

Nach einem IDE-Wechsel dieselbe Solution verwenden. Nach Paketänderungen Restore
und Projektneuladen durchführen. SDK und IDE regelmäßig auf unterstützte
Wartungsstände bringen; keine persönlichen SDK-Pfade versionieren.

## DE — In der IDE öffnen

| Umgebung | Öffnen und prüfen |
|---|---|
| Mac A / Mac B | Rider: `ShowCommandTui400.sln` öffnen. VS Code: Repository-Ordner öffnen und Solution auswählen. |
| Windows 11 | Dieselben Schritte für Rider/VS Code; Visual Studio: `ShowCommandTui400.sln` öffnen. |
| Ubuntu 24.04 / WSL2 | Eigener Linux-Checkout; Rider-Backend in WSL2 oder VS Code im WSL-Fenster. SDK und spätere PowerShell-Ausführung liegen in Linux. |

Rider und Visual Studio dürfen aus der grafischen Oberfläche starten; Shell-
Variablen sind nicht notwendig. Nach Restore in Produkt und Testprojekt prüfen:
`PSCmdlet`, `CmdletAttribute` und `System.Management.Automation` werden aufgelöst,
die IDE-Codeanalyse meldet keine Referenz-/Compilerfehler, Solution-Build besteht.
Die Testbibliothek enthält einen eigenen Vertragsrunner, keinen VSTest-Adapter;
fehlende Testentdeckung in einer IDE ist deshalb kein Referenzfehler.

Windows- und WSL2-Checkouts sowie bin/obj-Ausgaben getrennt halten. Persönliche
`.idea`, `.vs`, `.vscode` und Benutzerdateien bleiben Git-ignoriert. Visual Studio
wird nativ nur unter Windows geprüft; Visual Studio für Mac ist eingestellt.

## DE — Ausführen und Paketgrenze prüfen

In einer frischen PowerShell-Sitzung aus dem Repository-Stamm:

```powershell
$PSVersionTable.PSVersion
[Environment]::Version
Import-Module ./src/ShowCommandTui400/bin/Debug/net10.0/ShowCommandTui400.psd1
Get-Command Show-CommandTui400
Show-CommandTui400
```

Die TUI benötigt einen geeigneten interaktiven Terminalhost. Ein eingebautes
IDE-Ausgabefenster ersetzt diesen nicht. Nach Neubuild eine neue PowerShell
verwenden, damit keine alte Assembly geladen bleibt. Siehe
[manuelle Mac-A-Prüfung](manual-smoke-test-maca.md).

Automatisierte Vertragsprüfung mit neuem externem Buildpfad (macOS-Beispiel):

```text
pwsh -NoProfile -File tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1 -CaseId B01 -BuildRoot /private/tmp/lh01-contract-new
```

Build-/Publish-Grenze mit Standardausgaben prüfen:

```text
dotnet publish src/ShowCommandTui400/ShowCommandTui400.csproj -c Debug --no-restore
python3 tests/feasibility/lh01/assert-no-powershell-runtime.py --assets src/ShowCommandTui400/obj/project.assets.json --output src/ShowCommandTui400/bin/Debug/net10.0 --output src/ShowCommandTui400/bin/Debug/net10.0/publish
```

Python3.9+ wird nur für diese Prüfwerkzeuge benötigt; unter Windows denselben
verfügbaren Python-Interpreter verwenden. Der Prüfer leitet die ausschließlich
PowerShell zugehörigen Pakete aus dem Restore-Graph ab und prüft Dateien sowie
Dependency-Manifeste. Gemeinsame Terminal.Gui-Abhängigkeiten bleiben zulässig.
Ein bestandener Build beweist keine Mindestversions- oder Plattformkompatibilität.

## Plattform-Hand-offs

Diese Ergänzung gilt für #37 Mac B, #38 Windows11 und #39 Ubuntu/WSL2 erst nach
separater Lieferung eines exakten neuen Prüfstands und ausdrücklichem Hostauftrag.
Die vorhandenen Manifest-/Kommandobindungen werden dadurch nicht verändert.

Agenten führen je erlaubter IDE getrennt aus:

1. Freigegebenen Commit, sauberen Checkout, OS/Hardware, SDK, IDE und Erweiterungen
   erfassen. Keine Installation, Kontenanmeldung oder Reparatur ohne Auftrag.
2. Die drei CLI-Befehle oben ausführen; Befehle, Exitcodes und Restore-/Buildausgabe
   sichern. Bei fehlenden Voraussetzungen `Blocked`, bei unerwarteten Fehlern stoppen.
3. Solution über die GUI laden, Restore abschließen, Produkt- und Testprojekt
   inspizieren und mit dem IDE-Build bauen. Versionsstände, Fehlerliste und
   tatsächliches Build-Ergebnis erfassen. Nicht verfügbare IDE bleibt Open.
4. Ausgabeprüfung sowie separat beauftragte Laufzeitprüfungen ausführen. VS-Code-
   Terminal-Build allein belegt keine funktionierende C#-Codeanalyse.
5. DE/EN-Bericht mit Commit, Hashes der Solution/Props/Lockdateien, Umgebung,
   Ergebnissen je IDE und Grenzen erzeugen. Nachweise bleiben getrennt von
   unabhängigem Review und Owner-Abnahme. Kein Commit, Push oder Issue-Schließen.

Aktueller Nachweis: [IDE-Portabilität](../validation/lh01/ide-portability.md).
Praktische Terminal-/Screenreaderabnahme bleibt getrennt; Braillehardware ausgeschlossen.

## DE — Fehlerdiagnosen und Dokumentationsauswirkung

`dotnet` fehlt oder NETSDK1045: Passendes .NET10-SDK bereitstellen und den tatsächlich
von der IDE verwendeten Toolset prüfen. NU1301/Restorefehler: Netzwerk/nuget.org
prüfen; keine privaten Feeds hinzufügen und Lockdateien nicht als Workaround löschen.
Nicht aufgelöste PowerShell-Typen: Solution-Restore, importierte gemeinsame Props
und Projektreload prüfen; keine Host-DLL manuell hinzufügen. Laufzeit zu alt:
unterstützten PowerShell-Host verwenden. Die bestehende CS0618-TextView-Warnung
bleibt sichtbar; keine Unterdrückung oder vollständige Abnahme behaupten.

**macOS und C# Dev Kit:** Meldet der Erweiterungshost bei `libhostfxr.dylib`
„different Team IDs“ und Exit130, ist die Projektanalyse nicht bestanden, auch
wenn die Fehlerliste leer bleibt. Ein Homebrew-SDK kann für CLI/Rider funktionieren,
während der signierte Dev-Kit-Prozess eine Microsoft-signierte Runtime benötigt.
Eine bereits vorhandene passende Runtime über
`dotnetAcquisitionExtension.existingDotnetPath` für `ms-dotnettools.csdevkit` und
`ms-dotnettools.csharp` lokal auswählen, dann das VS-Code-Fenster neu laden.
Der Eintrag hat `extensionId` und `path` zum lokalen `dotnet`-Programm. Keinen
rechnerabhängigen Pfad versionieren. Diese Einstellung betrifft den Erweiterungshost,
nicht das Produkt-SDK. Signaturprüfung und Library Validation nicht abschalten;
keine Bibliotheken neu signieren. Fehlt eine passende Runtime, bleibt der Nachweis
Blocked bis zur gesonderten Einrichtung. Installationen brauchen einen eigenen Auftrag.

UpdateRequired: Leserpfad README/Entwicklungsumgebung → diese Anleitung → CLI/IDE-
Nachweis → getrennte Plattform-Hand-offs. Keine Intake-, Schema- oder API-Änderung.
Geänderte gebundene technische Quellen benötigen vor einem neuen freigegebenen
Lauf eine erneute Frischeprüfung; historische Nachweise behalten ihren Stand.

## EN — Setup, IDEs and execution

Owner/date as above. Apprentices and other developers use the same procedure;
no agent tooling is required. Install a .NET10 SDK with C#14 support and a compatible
IDE. VS Code requires Microsoft's C# extension; C# Dev Kit is optional for solution
views. Visual Studio needs .NET development tools. Restore uses only nuget.org.
Build requires no installed PowerShell, PSHOME property or local MSBuild file.
Run the three CLI commands above from the repository root, stopping on failure.

Open the solution in Rider or Windows Visual Studio; open the repository folder
and select its solution in VS Code. Mac A/B support Rider/VS Code. WSL2 uses its own
Linux checkout and SDK with a Rider WSL backend or VS Code WSL window. Do not share
Windows/Linux build outputs. GUI launches require no shell environment. Personal
IDE files remain ignored. Visual Studio for Mac is retired.

SMA7.6.4 supplies only the compile-time API. Private compile-only assets prevent
engine redistribution; the running PowerShell supplies its own implementation.
The private, asset-free PKCS10.0.13 pin fixes the transitive restore advisory;
it does not patch an installed host. Lockfiles pin package resolution. Update
supported SDK/IDE maintenance versions and reload projects after package changes.

Check C# analysis in both projects, resolved PSCmdlet/CmdletAttribute types and a
successful IDE solution build. The test library uses a custom contract runner,
not a VSTest adapter; absent IDE test discovery is expected. For execution, use
fresh PS7.6.4+ on .NET10 and the import commands above in a suitable interactive
terminal. IDE output panes do not replace a terminal. Rebuilds need a fresh host.

Use the B01 runner with a new external build root, then the publish/output-check
commands above. Python3.9+ is required only for test tooling. The checker inspects
actual files/dependency manifests against the exclusive PowerShell package graph;
shared Terminal.Gui dependencies remain allowed. Build success does not prove
minimum-host or platform acceptance.

The hand-off sequence above applies to #37/#38/#39 only after a separately delivered
exact revision and explicit host request. Record commit, clean sources, hardware,
OS, SDK, IDE/extensions, commands/exits, C# analysis, IDE builds, file hashes and
limits separately per IDE. Missing prerequisites mean Blocked; unavailable IDEs
remain Open. Do not install, repair, sign in, deliver or close issues without
matching authority. A VS Code terminal build alone is not C# analysis evidence.
Independent review and owner acceptance remain separate. Existing product approval
bindings are unchanged. Practical terminal/screen-reader acceptance remains
separate; Braille hardware stays excluded.

For missing dotnet/NETSDK1045, provide the supported SDK and check the IDE toolset.
For NU1301, inspect access to nuget.org, without deleting lockfiles or adding private
feeds. For unresolved PowerShell types, restore/reload the solution and check shared
props; do not add a host DLL. Use a supported PowerShell runtime for execution.
Keep the existing CS0618 warning visible. Documentation impact is UpdateRequired;
reader path and source-freshness limits are stated above. No intake/schema/API change.

On macOS, a C# Dev Kit `libhostfxr.dylib` failure with “different Team IDs” and
exit130 blocks project analysis even if no C# errors appear. A Homebrew SDK may
work in CLI/Rider while the signed Dev Kit process needs a Microsoft-signed
runtime. Select an existing compatible runtime locally using
`dotnetAcquisitionExtension.existingDotnetPath`, with `extensionId` and `path`
entries for `ms-dotnettools.csdevkit` and `ms-dotnettools.csharp`, then reload the
window. Keep machine paths unversioned. This changes the extension host, not the
product SDK. Never disable signature/library validation or re-sign libraries.
If no compatible runtime exists, record Blocked pending separately commissioned setup.
