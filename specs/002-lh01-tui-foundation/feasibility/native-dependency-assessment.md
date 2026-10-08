# Native Grenzen und Lieferkette / Native boundaries and supply chain

## DE — Bewertung

Datum: 2026-10-08. Grundlage: [Paketmetadaten](evidence/dependency-provenance.json),
Lockfile, installierte Paketassets und versionierte Primärquellen. 24 aufgelöste
Pakete stimmen zwischen Lock-Contenthash und NuGet-Cachemetadaten überein. Die
öffentliche Feedprüfung meldet keine bekannten Schwachstellen; das ist kein
umfassendes Sicherheitsaudit oder Quell-zu-Binary-Herkunftsnachweis.

**Terminaltreiber:** Terminal.Gui2.5.0 hat im ANSI-Pfad eine konkrete native
ABI-Abweichung auf macOS Arm64. Die Frameworkstruktur nutzt vier uint32-Flags,
32 Controlbytes und uint32-Geschwindigkeiten (56 Bytes). Der lokale Apple-SDK-
Header und [kompilierte C-Probe](evidence/maca-termios-abi.json) ergeben 72 Bytes,
vier uint64-Flags, 20 Controlbytes und uint64-Geschwindigkeiten ab Offset56/64.
Der unveränderte ANSI-Pfad wird nicht erneut als sicherer Produktkandidat
verwendet; es wird kein Upstream-Patch oder Release erzeugt.

Primärquellen:
[UnixRawModeHelper](https://github.com/tui-cs/Terminal.Gui/blob/v2.5.0/Terminal.Gui/Drivers/UnixHelpers/UnixRawModeHelper.cs),
[DriverRegistry](https://github.com/tui-cs/Terminal.Gui/blob/v2.5.0/Terminal.Gui/Drivers/DriverRegistry.cs),
[NetInput](https://github.com/tui-cs/Terminal.Gui/blob/v2.5.0/Terminal.Gui/Drivers/DotNetDriver/NetInput.cs).
Der explizite `dotnet`-Treiber vermeidet diesen ANSI-Termios-Pfad. Er setzt
`Console.TreatControlCAsInput=true`, stellt die Eigenschaft im gezeigten Dispose
aber nicht wieder her. Der isolierte Adapter speichert sie und die ABI-korrekte
native Snapshotstruktur und stellt beides nach GUI-Dispose wieder her. Negative
Hostfälle aktivieren keine schreibende Lease. Fehler aus UI und Restore werden
zusammen erhalten, statt den ursprünglichen Fehler still zu verdecken.

**PENDIN:** Apple-SDK bezeichnet 0x20000000 als Zustand für ausstehende Eingabe.
Der [native Kontrolllauf](evidence/maca-native-raw-control.json) reproduziert bei
raw→saved ohne PowerShell/.NET/Terminal.Gui exakt diesen Bitwechsel. Der rohe
Vergleich bleibt sichtbar. Der zweite Vergleich nimmt ausschließlich PENDIN aus;
alle übrigen Flags, Controlbytes und beide Geschwindigkeiten bleiben verbindlich.
Zusätzlich wird eine echte Read-Host-Rückgabe im synthetischen Host geprüft.

**Onigwrap:** TextMateSharp2.0.4 → Onigwrap1.0.11 liefert native macOS-, Linux-
und Windows-Assets. Das Fixture verwendet kein Markdown/TextMate-Highlighting;
Assets im Restore bedeuten nicht automatisch, dass native Bibliotheken geladen
oder ausgeführt wurden. Die Abhängigkeit bleibt im Inventar und bei Paketpflege
zu berücksichtigen. Keine pauschale MSL- oder Sicherheits-N/A-Einstufung.
Metadaten zeigen Repositorycommits und Lizenzangaben; Notices aus den Paketen
sind bei tatsächlicher Weitergabe zu erhalten. Für Oniguruma bleiben genaue
native Quellversion, Buildprovenienz und Plattformartefakte gesondert zu klären,
bevor der Highlightingpfad genutzt wird. LH-01 aktiviert ihn nicht.

**MSL-Entscheid:** Eigener Produktcode wird als managed C# ohne unsafe-Blöcke und
Pointerarithmetik geplant. Memory Safety Language (MSL) bezeichnet hier die
Sprachgarantien für eigenen managed Code. .NET-Runtime, OS und P/Invoke/native
Pakete sind gesonderte Vertrauensgrenzen; C# macht diese nicht automatisch sicher.
Der macOS-Adapter hat feste libc-Einstiegspunkte und feste native Structgröße,
Architektur-/Größenprüfung und geprüfte Rückgabecodes. Dies ist ein begrenzter
Machbarkeitsnachweis. Produktadapter für andere Plattformen brauchen eigene
ABI-/Modi-Nachweise; Darwinwerte dürfen nicht dorthin kopiert werden.

Bei Paket-/Runtime-/Treiberwechsel, neuer nativer Nutzung oder erweitertem Scope
gezielt erneut bewerten. Kein Security-, Plattform- oder A11Y-Abnahmeclaim.

## EN — Assessment

24 resolved packages match locked NuGet content provenance. Public vulnerability
data reports no known advisories; this is no comprehensive security or source-to-
binary assessment. The Terminal.Gui2.5.0 ANSI termios structure is ABI-incompatible
with macOS Arm64: 56 framework bytes versus 72 native bytes, differing flag/speed
width and control array. Explicit `dotnet` driver selection avoids that path.
Its control-C input setting needs separate restoration; the isolated adapter
restores it and a verified Darwin snapshot after GUI disposal. Negative hosts do
not activate a writing lease. Preserve both UI and restore errors.

The native SDK-only raw/saved control reproduces PENDIN alone. Retain raw equality
and exclude only that kernel state bit in the configured-mode comparison; require
all other flags, control bytes and both speeds plus a synthetic host Read-Host
roundtrip. Never reuse Darwin ABI values on another platform.

Onigwrap native assets remain a concrete dependency through TextMateSharp. The
fixture does not enable Markdown/TextMate; presence does not prove loading.
Keep inventory, patch tracking and notices. Native Oniguruma version/build
provenance needs further evidence before enabling that path, outside current LH-01.
Managed C# supplies own-code memory-safety guarantees, not safety for OS/runtime/
PInvoke/native libraries. These remain explicit trust boundaries. Reassess changes;
no blanket security/platform/accessibility acceptance is claimed.
