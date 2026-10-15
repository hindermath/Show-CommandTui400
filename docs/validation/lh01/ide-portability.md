# IDE-Portabilität / IDE portability

## DE — Lokaler Nachweis 2026-10-15

Owner: Thorsten Hindermann. Mac A: MacBook Air M2 2023. Geprüfte lokale
Arbeitskopie, kein neuer freigegebener Produktcommit. Ausgangscommit, Quellhashes,
Versionen und Ergebniszustände stehen in [ide-portability.json](ide-portability.json).
[Einrichtung und reproduzierbare Befehle](../../lh01/development-setup.md).

Die früheren PSHOME-Referenzen wurden durch die gemeinsame private compile-only
SMA7.6.4-Referenz ersetzt. PKCS10.0.13 wird ohne Assets gepinnt: Die anfängliche
Restore-Warnung zu PKCS10.0.5 wurde durch korrigierte Paketauflösung behoben,
nicht unterdrückt. Das aktualisiert nicht den installierten Host.
Quellen: [Microsoft-/GitHub-Advisory](https://github.com/advisories/GHSA-846f-f764-76mx),
[weiteres Advisory](https://github.com/advisories/GHSA-2fmv-rv2c-59x7).

| Prüfung | Ergebnis und Grenze |
|---|---|
| Gesperrter Restore und Solution-Build | Pass; SDK10.0.401, ohne Hostpfadparameter |
| Frischer Quellsnapshot in Pfad mit Leerzeichen | Pass; neue bin/obj, Standardbefehle und nur versionierbare Build-Eingaben; kein Git-Clone-Nachweis |
| Build-/Publish-Paketgrenze | Pass; tatsächliche Ausgaben enthalten keine Engine oder ausschließlich PowerShell zugehörige Laufzeitabhängigkeiten |
| Negative Regressionsprüfung | Pass; synthetisch eingeschleuste System.Management.Automation.dll wird abgewiesen |
| Vertragsrunner B01 | Pass unter PowerShell7.6.6 / Host-.NET10.0.12; Mindesthost7.6.4 nicht ausgeführt |
| Rider2026.2.3.1 Solution-Build | Pass; eigener SolutionBuilder-Log: beide Projekte, 0 Fehler, bekannte CS0618-Warnung; SDK10.0.401 |
| Rider-C#-Codeanalyse | Pass; Cmdlet-Datei und erneute Solutionanalyse ohne Referenz-/Compilerfehler; Stil-/Nutzungshinweise bleiben sichtbar |
| VS Code | Erneut geprüft: echte Solution und beide Projekte geladen, keine C#-Fehler/-Warnungen; lokaler Extension-Runtime-Pfad separat |
| Keyboard-PTY-Nachprüfung | Pass/Exit0; Hilfe-/Refresh-Text und unterschiedliche Farben geprüft; ursprünglicher Timeout bleibt historisch |
| Mac B / Windows11 / Ubuntu-WSL2 / Visual Studio | Open; keine Läufe auf fremden Systemen |

Lokale Ausgaben: `/private/tmp/lh01-nuget-20261015` (Build/Publish),
`/private/tmp/lh01-nuget-contract-20261015` (Vertragsrunner),
`/private/tmp/lh01 portable fresh 20261015` (frischer Quellsnapshot),
`/private/tmp/lh01-nuget-proof-20261015` (fehlgeschlagener PTY-Lauf).
Riders Log stammt aus `Library/Logs/JetBrains/Rider2026.2/SolutionBuilder/`;
der genaue Rohdateihash steht im JSON, persönliche Pfade werden nicht versioniert.

Der erste Versuch bleibt historisch: Rider-Freeze-Dumps, unerreichbarer GUI-Dienst
und PTY-Timeout bei beobachteter Last32.37. Seine Ursache wurde nicht abschließend
isoliert. Der ausdrücklich beauftragte Wiederholungslauf besteht ohne Änderung
der Timeoutgrenzen. Rohdaten: [Keyboard.json](ide-maca-recheck/Keyboard.json).

Rider2026.2.3.1: Cmdlet-Datei geprüft, gesamte Solution erneut analysiert und erneut
gebaut. Keine C#-Referenz-/Compilerfehler. Stil-, Nutzungshinweise und unabhängige
IDE-/Pluginmeldungen werden nicht unterdrückt.

VS Code1.141.0 mit C#2.160.4 und C# Dev Kit3.40.210: Der erste echte Dev-Kit-Start
scheiterte an `libhostfxr.dylib`, unterschiedlichen Signatur-Team-IDs und Exit130.
Eine leere Fehlerliste im Modus „Sonstige Dateien“ war kein Projektnachweis.
Die bereits installierte Microsoft-signierte ASP.NET-Runtime10.0.12 wurde lokal
über `dotnetAcquisitionExtension.existingDotnetPath` ausgewählt; ursprüngliche
Workspace-Einstellungen extern gesichert. Keine Installation, keine globale
Einstellung und keine Abschaltung von Signatur-/Library-Validation. Die lokale
Datei bleibt Git-ignoriert. Das Produkt-SDK bleibt10.0.401. Nach Neuladen melden
C#-Server und GUI beide echten Projekte und die Solution. C#-Fehler/-Warnungen:0;
Spellcheck-/Stil-/Providerhinweise bleiben getrennt. Build aus dem integrierten Terminal: Exit0, beide Projekte erfolgreich,
[bereinigte Buildausgabe](ide-maca-recheck/vscode-build.txt). Details und Hashes im JSON.

Die drei anderen Systeme und PowerShell7.6.4 als tatsächlicher Mindesthost bleiben
Open. Bestehende Hand-off-Manifeste/Issues werden nicht umgebunden; dieser Lieferstand
ist keine neue Plattformprüffreigabe oder praktische Abnahme.

Secret-Scan: Exit0, high=0/medium=0; bekannte niedrige Agentenverzeichnis-Hinweise.
Diff-Prüfung, lokale Dokumentationspfade und Python-Syntaxprüfung: Pass.
14/14-Preset-Matrix und PSScriptAnalyzer ohne Error-/Warning-Befunde: Pass.
Die CI-Suite prüft nun auch die tatsächlichen Keyboard-/Remap-Farbattribute.
CS0618 bleibt sichtbar. Praktische Terminal-/Screenreaderabnahme bleibt getrennt;
Braillehardware bleibt ausgeschlossen. Kein neues unabhängiges Review oder
Produkt-/Plattformabnahme. Geänderte gebundene technische Dokumente erfordern vor
einem neuen freigegebenen Lauf eine Frischeprüfung; Intakes/Receipts bleiben unverändert.

## EN — Local evidence and limits

Mac A, 2026-10-15; the JSON binds the modified working tree, versions and outcomes.
This is not an approved product revision. Locked restore/CLI build, a fresh source
snapshot with spaces in its path, actual build/publish runtime exclusion, injected
forbidden-DLL rejection and B01 contracts pass. The snapshot is not a Git clone.
API package7.6.4 is compile-only; asset-free PKCS10.0.13 fixes the transitive restore
advisories without suppressions or patching the installed host. Runtime contracts
use PS7.6.6/.NET10.0.12; PS7.6.4 remains untested.

Rider2026.2.3.1 now passes the repeated GUI check: cmdlet diagnostics, full-solution
reanalysis and build, with no C# reference/compiler errors. Existing style/usage
hints and unrelated IDE/plugin notices remain visible.

VS Code1.141.0/C#2.160.4/Dev Kit3.40.210 initially failed with a signing-Team-ID
mismatch in the Homebrew libhostfxr and exit130. A blank error list in miscellaneous
file mode was not project evidence. A local ignored runtime selection now uses an
already installed Microsoft-signed ASP.NET10.0.12 runtime; original settings were
backed up outside the repository. No installation, global setting, invalid-path
bypass, re-signing or signature/library-validation change. Product SDK stays10.0.401.
After reload, both real projects and the solution are loaded with zero C# errors
or warnings. Spellcheck/style/provider notices remain separate. The integrated-terminal solution build passes with exit0; its sanitized log is linked
above. See JSON for hashes.

The expressly commissioned Keyboard PTY repeat passes with exit0, actual visible
help/refresh text, unequal text colors and terminal return. Its raw record is linked
above. The original timeout and GUI failure remain historical; no timeout setting
was changed and their root cause was not fully isolated. Minimum PS7.6.4 and other
platforms remain Open. Existing platform approval bindings are unchanged; no
independent review, practical acceptance or conformity is claimed. Terminal/screen
reader acceptance stays separate; Braille hardware remains excluded.
