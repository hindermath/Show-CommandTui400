# LH-01 Recherche / Research

**Aktueller Stand / Current state:** D08 und verlinkte Entscheidungen gelten.
D01–D07 sind ausdrücklich der historische Recherche-/Erstversuchsstand vor
der aktuellen Reparatur und Auswahl; ihre damaligen Open-/Kandidaten-/Buildaussagen
beschreiben nicht den heutigen Stand. / D08 is current; D01–D07 are historical
pre-correction research/experiment states.

**Datum / Date:** 2026-10-08. **Owner:** Thorsten Hindermann.
**Historische Methode / Historical method:** zwei getrennte lesende Rechercheagenten; offizielle Primärquellen.
Keine Builds, Paketinstallation, Prototypen oder Produktimplementierung.
Two distinct read-only research agents used official primary sources. No build,
package installation, prototype or product implementation was performed.

## D01 — Sprache und Sitzungsintegration / Language and session integration

**Entwurfsentscheidung:** C# als priorisierter Machbarkeitskandidat, ein direkt
in die vorhandene Sitzung geladenes Binärcmdlet auf PSCmdlet-Basis. Kein neues
pwsh, eigener PowerShell-Host oder Ersatz-Runspace. C# gehört zur Constitution-
MSL-Liste; die verbindliche Primärsprache bleibt unknown bis belegtem OD-01-002.
PSCmdlet ist die PowerShell-Basisklasse mit Zugriff auf Sitzungsschnittstellen.
SessionState bezeichnet Kontext des aktuellen Runspaces, nicht automatisch alle
privaten lokalen Variablen des Aufrufers. Dies ist dokumentarische Machbarkeit,
kein experimenteller Gesamtbeweis.

**Design decision:** prioritize C# and an in-process binary PSCmdlet, without a
replacement process/host/runspace. C# is on the constitution MSL list; project
language remains unknown until evidenced OD-01-002. SessionState addresses the
current runspace, not unrestricted caller-local visibility. Documentation shows
an integration route, not completed experimental feasibility.

**Alternativen:** PowerShell Advanced Function bleibt Vergleichskandidat; F# könnte
 denselben CLR-Modulweg nutzen. Separate Rust-/Go-/Python-Prozesse schaffen zusätzliche
Schnittstellen und können nicht still dieselbe Sitzung ersetzen. Die Bewertung
folgt Architekturgrenzen, keiner gemessenen Rangfolge.
**Alternatives:** PowerShell advanced functions and F# remain alternatives; separate
Rust/Go/Python processes introduce extra interfaces and cannot silently replace the
session. This is architecture reasoning, not a measured ranking.

Quellen / Sources:
- [Cmdlet overview](https://learn.microsoft.com/en-us/powershell/scripting/developer/cmdlet/cmdlet-overview?view=powershell-7.6)
- [PSCmdlet.SessionState](https://learn.microsoft.com/en-us/dotnet/api/system.management.automation.pscmdlet.sessionstate?view=powershellsdk-7.4.0)
- [Scope-Grenzen / Scope boundaries](https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_scopes?view=powershell-7.6)
- [StopProcessing](https://learn.microsoft.com/en-us/dotnet/api/system.management.automation.cmdlet.stopprocessing?view=powershellsdk-7.4.0)

## D02 — Runtime und Mindestversion / Runtime and minimum version

**Entwurfsentscheidung:** PowerShell 7.6 / .NET 10 als Prüfbaseline. Der laufende
PowerShell-Prozess bestimmt die Runtime; ein geladenes Cmdlet startet keine eigene.
Die endgültige minimale PowerShell-Version bleibt OD-01-001 und braucht Tests.
Lokal lesend beobachtet: PowerShell 7.6.6, .NET 10.0.12, Arm64, ConsoleHost;
Eingabe/Ausgabe des Werkzeugaufrufs sind umgeleitet. SDK 10.0.401 ist installiert.
Dies beweist weder interaktive Terminalfähigkeit noch Modul-/Frameworkkompatibilität.

**Design decision:** use PowerShell 7.6/.NET 10 as the proof baseline; the caller
process owns runtime. Final minimum remains OD-01-001 and needs tests. Read-only
local observation found PS7.6.6/.NET10.0.12 Arm64 ConsoleHost, redirected I/O and
SDK10.0.401. This proves no interactive UI or dependency compatibility.

**Begründung:** Microsoft führt 7.6 als LTS mit .NET10; ein Framework mit net10.0
kann nicht ohne Beleg für ältere PowerShell-Runtimes zugesagt werden. Ältere
Baseline benötigt eigenen Wartungsgrund und vollständigen Nachweis, kein stilles
Multi-Targeting. PowerShell-Referenzassemblies nicht als eigene Runtime mitliefern;
NuGet-Referenz-/PrivateAssets-Strategie und Abhängigkeitskonflikte prüfen.

**Rationale:** Microsoft lists PS7.6 LTS with .NET10. A net10.0 dependency cannot
be promised on older hosts. Older support needs a maintenance reason and complete
proof. Do not distribute host reference assemblies as a replacement runtime;
validate NuGet reference/private-assets handling and dependency collisions.

Quellen / Sources:
- [PowerShell support lifecycle](https://learn.microsoft.com/en-us/powershell/scripting/install/powershell-support-lifecycle?view=powershell-7.6)
- [NuGet package choice](https://learn.microsoft.com/en-us/powershell/scripting/dev-cross-plat/choosing-the-right-nuget-package?view=powershell-7.6)
- [Dependency conflicts](https://learn.microsoft.com/en-us/powershell/scripting/dev-cross-plat/resolving-dependency-conflicts?view=powershell-7.6)

## D03 — Framework und Treiber / Framework and drivers

**Entwurfsentscheidung:** Terminal.Gui v2.5.0 als gepinnter Prüfkandidat, nicht
als freigegebene Produktabhängigkeit. Fokus/Aktionen/Layout passen zum LH-01.
Versioniertes Projekt: net10.0, C#14, AllowUnsafeBlocks; native Treibergrenzen
bleiben trotz C#-MSL-Bewertung sicherheitsrelevant. Minor-Updates können APIs
ändern; keine ungebundene latest-Version. Treiberwahl je Plattform separat prüfen.

**Design decision:** pinned Terminal.Gui v2.5.0 is a feasibility candidate, not an
approved dependency. Focus/actions/layout fit the intake. Its versioned project
uses net10.0, C#14 and unsafe blocks; native drivers require boundary review despite
C# memory safety. Minor versions may break APIs; assess each driver separately.

**Alternativen:** Spectre.Console eignet sich für Ausgabe/Prompts, unterstützt
Live-Display nicht gemeinsam mit interaktiven Prompts; kein gleichwertiger
Fokusvertrag. 0.57.2 ist als Pre-release markiert. Eigene Console-/ANSI-Schicht
bleibt Reserve, erhöht jedoch Eingabe-/Resize-/Wiederherstellungsaufwand.
Keine Primärquelle belegt vollständigen Screenreader-/Braille-Zugang des gewählten
Frameworks. Ein Fehlschlag verlangt Entwurfsrevision, kein A11Y-N/A.

**Alternatives:** Spectre.Console handles output/prompts but does not combine
live display with interactive prompts; 0.57.2 is marked prerelease. A custom
Console/ANSI layer is a fallback with higher input/resize/restoration risk.
No source proves complete assistive access. Failure requires design revision,
not an accessibility waiver.

Quellen / Sources:
- [Terminal.Gui v2.5.0 release](https://github.com/tui-cs/Terminal.Gui/releases/tag/v2.5.0)
- [Versioniertes Projekt / Versioned project](https://github.com/tui-cs/Terminal.Gui/blob/v2.5.0/Terminal.Gui/Terminal.Gui.csproj)
- [Treiber / Drivers](https://tui-cs.github.io/Terminal.Gui/docs/drivers.html)
- [Tastaturvertrag / Keyboard model](https://tui-cs.github.io/Terminal.Gui/docs/keyboard.html)
- [MIT-Lizenz / License](https://github.com/tui-cs/Terminal.Gui/blob/develop/LICENSE)
- [Spectre Live display](https://spectreconsole.net/console/live/live-display/)
- [Spectre 0.57.2](https://github.com/spectreconsole/spectre.console/releases/tag/0.57.2)

## D04 — Nichtinteraktivität und Aufrufersichtbarkeit / Non-interactive I/O and caller visibility

**Entwurfsvertrag:** Umgeleitete Ein-/Ausgabe bzw. unzureichende Host-/Terminal-
Fähigkeit vor Änderungen erkennen und verständlich ablehnen; kein Ersatzprozess.
Scope-Grenzen getrennt für globalen, Funktions- und Modulkontext belegen. Keine
unbeschränkte Aufrufersichtbarkeit versprechen. Keine Zielausführung, Netzabfrage,
Modulauflösung oder Persistenz durch Navigation/Refresh.

**Design contract:** reject redirected I/O or insufficient host/terminal capability
before state changes, without a replacement process. Prove global/function/module
scope separately and never promise unrestricted caller visibility. No target
execution, network access, module resolution or persistence through navigation.

Quellen / Sources:
- [Host RawUI](https://learn.microsoft.com/en-us/dotnet/api/system.management.automation.host.pshostuserinterface.rawui?view=powershellsdk-7.4.0)
- [Console.IsInputRedirected](https://learn.microsoft.com/en-us/dotnet/api/system.console.isinputredirected?view=net-10.0)
- SessionState/Scopes aus D01 / from D01.

## D05 — Historischer Erstentwurf / Historical initial design

OD-01-001/002 bleiben Open mit Owner Thorsten. Die unbekannten Optionen sind
recherchiert und als konkrete Prüfkandidaten eingeordnet; endgültiger Entscheid
setzt F01–F07 aus [quickstart.md](quickstart.md), anderes technisches Review und
begründete getrennte ADRs voraus. Fällig vor Produktimplementierung; bei Fehler,
Versions-/Treiberwechsel oder widersprüchlichem Scope erneut prüfen. Keine Owner-
Abnahme, Produkt-/Plattform-/A11Y-Freigabe oder Änderung am Umgebungsregister.

OD-01-001/002 remain Open, owned by Thorsten. Research identifies concrete
candidates; final decisions require F01–F07, distinct technical review and separate
reasoned ADRs before product implementation. Revisit failure/version/driver/scope
changes. No owner acceptance, registry change or product/platform/A11Y permission.

## D06 — Agent-Kontext / Agent context

Plan bleibt technische Quelle. Das installierte Repository enthält kein
update-agent-context-Skript. Der frühere Owner-Auftrag untersagt die bloße
Verweisdatei als Ersatz; keine Regenerierung oder Änderung hashgebundener Guidance.
Der fehlende Skriptschritt ist N/A für diese Installation; kein automatisch
geladener Kontext wird behauptet. Wiedervorlage bei tatsächlicher Guidanceänderung.

The plan remains the technical source. No update-agent-context script is installed.
The prior owner instruction rejects a redundant pointer file; do not recreate it
or mutate hash-bound guidance. Record the unavailable step as N/A for this setup,
without claiming automatically loaded context. Revisit actual guidance changes.

## D07 — Historischer erster Versuch / Historical first experiment

2026-10-08: Die Dokumentenrecherche wurde durch
[isolierte Rohdaten und Ergebnisse](feasibility/README.md) ergänzt. Globaler,
Funktions- und Modulscope mit synthetischen Werten sind im aktuellen Prozess
belegt; reale F1/F5/Alt+X-, Ctrl+C- und Resize-Teilfälle auf Mac-A-PTY geprüft.
Nach UI-Ende ist stty verändert, ohne UI im Kontrolllauf unverändert. Ursache
zwischen Fixture/Framework/Host noch unbestimmt; kein endgültiger Framework- oder
MSL-Entscheid. Öffentlicher NuGet-Audit und Lockfile ersetzen keine native
Lieferkettenbewertung. Frühere Aussagen zu fehlendem Proof sind der historische
Planungsstand. Siehe separate Entscheidungen und anderes Review im Evidence-Pfad.

Document research now has experimental partial scope/action/resize evidence.
Restoration differs after UI but not in the no-UI control; exact cause remains
unresolved. Public vulnerability data/lock do not replace native supply-chain
assessment. Earlier absence-of-proof statements retain historical planning context.

## D08 — Korrigierte Auswahl / Corrected selection

Siehe [aktueller Entscheidungsstand](feasibility/decisions.md) und
[native Diagnose](feasibility/native-dependency-assessment.md). ANSI-Termios-ABI
passt auf Mac Arm64 nicht; expliziter dotnet-Treiber plus Snapshot/Control-C-Lease
stellt konfigurierbare Modi wieder her. Allein PENDIN ist als reproduzierter
Kernelzustand separat behandelt. Tatsächliche Remap-/Navigation-/Wiederöffnungs-
und StopProcessingfälle belegt; praktische Tests gemäß
[Ownerauftrag](feasibility/owner-validation-boundaries.md) zurückgestellt bzw.
Braillehardware-Nachweis ausgeschlossen. ODs sind Auswahlentscheidungen, kein
Konformitätsclaim. Frühere D05/D07 bleiben historisch.

Explicit dotnet driver and verified lease correct Mac restore; only independently
reproduced PENDIN remains a separate kernel-state observation. Actual remap,
navigation, re-entry and StopProcessing evidence supports selected ODs. Owner
limits defer/exclude practical proof, never claim conformance. D05/D07 are history.
