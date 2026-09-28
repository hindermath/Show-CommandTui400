# Entwicklungsumgebung / Development environment

Stand / Date: 28.09.2026. Owner: Thorsten Hindermann.

## Einstieg und Grenzen / Entry and boundaries

Dieses Repository ist ein eigenständiges Level-2-Projekt im Workspace
`RiderProjects`. Die Quelle ist [Show-CommandTui400 auf GitHub](https://github.com/hindermath/Show-CommandTui400),
Standardbranch `main`. Der lokale Klon liegt unter
`~/RiderProjects/Show-CommandTui400`.

Das [Bedienkonzept](Bedienkonzept.md) bleibt die fachliche Baseline. Die
[Lastenheft-Reihenfolge](Lastenheft-Plan.md) bleibt verbindlich. Es existiert
noch keine Produktimplementierung: Sprache, Framework, Mindestversion von
PowerShell 7 und Sitzungsintegration bleiben offen. Die mitgelieferte
.NET-basierte Wartungs-TUI gehört zu Home Baseline und entscheidet nicht über
die Produktsprache.

Der aktuelle Auftrag erstellt [LH-00](../intakes/LH-00.md) lokal mit
[Policy](../.specify/memory/intake-authoring-policy.json) und
[Profil](../.specify/memory/intake-authoring-profile.md). Ein Intake ist ein
fachliches Lastenheft; ein Receipt bindet seine Quellen und seinen Inhalt durch
Prüfsummen. Authoring ist die Erstellung, Review eine gesonderte fachliche Prüfung.
`ReadyForReview` bestätigt keine Umsetzung oder Produktabnahme. Nächste fachliche
Aktion ist das getrennte Intake-Review nach ausdrücklichem Auftrag.
Lokale [Issue-Entwürfe](issue-drafts/README.md) sind noch nicht veröffentlicht.
Die vollständige Prozesskonfiguration und -abnahme bleiben Anforderungen von LH-00.

This is an independent Level-2 project in RiderProjects, sourced from
hindermath/Show-CommandTui400 on main. The interaction concept and intake order
are binding. No product implementation exists; language, framework, minimum
PowerShell version and session integration remain undecided. The bundled .NET
maintenance TUI belongs to Home Baseline. The current task creates LH-00 locally
with the linked policy and profile. An intake is a requirements document; a
receipt binds sources and content with hashes. Authoring creates the document;
review is a separate assessment. ReadyForReview is not implementation or product
acceptance. The next domain action is a separately requested intake review.
Issue drafts are not published. Full process setup and acceptance remain LH-00
requirements.

## Installierter Stand / Installed state

- Auf beiden macOS-Systemen von Thorsten ist **PowerShell 7.6.6.0** installiert
  (Versionsangabe und Installationsstand laut Owner vom 28.09.2026).
  Dies dokumentiert die vorhandene lokale Entwicklungsumgebung; eine globale
  Aussage zur jeweils neuesten Veröffentlichung oder eine Mindestversion für
  das spätere Produkt wird daraus nicht abgeleitet.

- GitHub Spec Kit CLI und Integrations-Templates: **0.12.8**.
- Integrationen: `agy`, `opencode`, `claude`, `copilot`, `codex`.
- Projektprofil: `project-statistics-fourteen-governance-presets`.
- Intake Authoring Governance: **v0.3.5**, aktiviert mit Priorität 64.
  Der [Update-Nachweis](maintenance/intake-authoring-v035.md) dokumentiert
  Paketbindung und Prüfgrenzen; die übrigen 13 Presets bleiben unverändert.
- Alle 14 Versionen und Prioritäten stehen in der
  [gepinnten Projektmatrix](../scripts/config/spec-kit-project-statistics-governance-presets.json).
- Installationsnachweis: `.specify/integrations/*.manifest.json` und
  `.specify/presets/.registry`.

Die Integrationen wurden mit `specify init --here --force --integration <name>
--script sh` initialisiert. Wiederholungen können Templates überschreiben;
vor Updates lokale Governance sichern und den Diff prüfen. Die vorhandenen
PowerShell-Wartungsskripte unterstützen Windows. PowerShell ist auch auf beiden
macOS-Systemen bereits installiert; die Wahl der Bash-Basisskripte bedeutet
nicht, dass PowerShell dort fehlt.

Offen bleibt der durchgängige Spec-Kit-Ablauf mit PowerShell-Basisskripten.
LH-00 klärt und prüft diesen Ablauf auf den vorhandenen macOS-Systemen sowie
separat unter Windows. Die Installation von PowerShell und die erfolgreiche
Windows-Setup-CI belegen diesen Ablauf noch nicht. Die vorhandene
Bash-Initialisierung wird durch diese Dokumentationskorrektur nicht umgestellt.

Die operative GSDB-Registry führt dieses Projekt explizit mit 14 Presets,
`gsdbRequired: true`, offener Primärsprache und `mslStatus: unknown`.
Der globale Default bleibt unverändert. Lokale Registry und Agentenzustände
werden nicht veröffentlicht.
Die kanonische Wartungsflotte führt `show-commandtui400` mit CI-Profil
`public-product`. Der Pre-Push-Hook erhält die zugehörigen versionierten
CI-Profil-/Pfadregister und den Workflowvertrag aus Level 0. Für dieses
öffentliche Repository verlangt er keine private CI-Gate-Evidence; seine
Secret-Prüfung bleibt aktiv.

The owner reported PowerShell 7.6.6.0 on both Macs on 28 September 2026. This
records the development environment, not the latest global release or product
minimum. Spec Kit CLI and integration templates are 0.12.8. Integrations are agy,
opencode, claude, copilot and codex. The project uses the explicit fourteen-preset
profile and pinned matrix. Authoring 0.3.5 is enabled at priority 64; its linked
update record captures package binding and proof limits. Integration manifests
and the preset registry record installation. Initialization used specify init
with --script sh. Reinitialization can overwrite templates, so preserve local
governance and inspect differences before updates. PowerShell maintenance
scripts support Windows; Bash initialization does not imply missing PowerShell
on macOS. End-to-end PowerShell base-script operation remains to be proven on
the Macs and separately on Windows. Existing Windows setup CI does not prove it.
The operational GSDB registry requires this project, leaves language/MSL open,
and selects fourteen presets without changing the fleet default. Local registries
and agent state stay private. The maintenance fleet uses public-product CI.
The pre-push hook uses versioned CI registries and workflow contracts; private
CI-gate evidence is not required here, while secret scanning remains active.

## Entwicklungs- und Testumgebungen / Development and test environments

| Umgebung | Rolle |
|---|---|
| Zwei macOS-Systeme | Entwicklung; PowerShell 7.6.6.0 laut Owner installiert |
| Windows 11 | PowerShell-First-Umgebung für native Windows-Abläufe |
| Ubuntu 24.04 unter WSL2 auf Windows 11 | Linux-Kompatibilitätstestumgebung |

Windows 11 ist Thorstens PowerShell-First-Umgebung. Ubuntu 24.04 unter WSL2 dient als Linux-Kompatibilitätstestumgebung. Native Windows-/PowerShell-Tests und Ubuntu-/WSL2-Tests werden getrennt dokumentiert; konkrete PowerShell-Versionen unter Windows und WSL2 sowie Testergebnisse sind noch zu erfassen.
Die Zuordnung folgt der Owner-Angabe vom 28.09.2026. WSL2-Ergebnisse werden
als solche ausgewiesen; sie sind kein Nachweis eines Tests auf einem
separaten nativen Linux-System.

The table defines two Macs for development, Windows 11 for native
PowerShell-first operation and Ubuntu 24.04 under WSL2 for Linux compatibility.
These are owner-reported roles from 28 September 2026. Windows and WSL2 need
their PowerShell versions and actual test outcomes recorded separately. WSL2
results are not proof of a separate native Linux installation.

<a id="intake-commands"></a>

## Verfügbare Intake-Kommandos / Available intake commands

Die folgenden Kommandos sind installierte Agentenoberflächen. Bei der
Einrichtung wurden sie nicht ausgeführt; im aktuellen Auftrag wird nur das
Authoring-Verfahren für LH-00 verwendet. Die genaue Schreibweise folgt dem Agenten.

| Zweck | Codex / Antigravity | OpenCode / Copilot |
|---|---|---|
| Lastenheft erstellen | `speckit-intake-create` | `speckit.intake-create` |
| Lastenheft lesen | `speckit-intake-read` | `speckit.intake-read` |
| Autorierungsstatus prüfen | `speckit-intake-create-status` | `speckit.intake-create-status` |
| Review | `speckit-intake-review` | `speckit.intake-review` |
| Reviewstatus | `speckit-intake-review-status` | `speckit.intake-review-status` |
| Reihenfolge prüfen | `speckit-intake-series-status` | `speckit.intake-series-status` |

Codex/Antigravity verwenden `.agents/skills/`, Claude `.claude/skills/`,
OpenCode `.opencode/commands/` mit identischer, versionierter
Kompatibilitätskopie `.opencode/command/` für den Home-Baseline-Paritätsvertrag
und Copilot `.github/agents/` plus
`.github/prompts/`. Claude verwendet ebenfalls die Bindestrich-Skillnamen.
Die genaue Aufrufschreibweise folgt dem jeweiligen Agenten.
Optionale `.vscode/settings.json`-Einträge des Upstream-Installationsmanifests
bleiben maschinenlokal. Editor-Berechtigungen werden nicht als Projekt-Policy
versioniert. Whitespace in generierten Command-Dateien wurde normalisiert;
die Upstream-Manifeste dokumentieren weiterhin die ursprüngliche Installation.
Bei OpenCode-Updates beide Verzeichnisse identisch halten und den gemeinsamen
Agenten-Paritätstest ausführen.

```bash
specify preset list
specify preset info intake-authoring-governance
specify preset resolve intake-authoring-policy-template
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
```

The table lists installed interfaces for create, read, authoring status, review,
review status and series status. They were not run during setup; the current
task uses only LH-00 authoring. Command spelling depends on the agent. Codex and
Antigravity use .agents/skills, Claude uses .claude/skills and hyphenated names,
OpenCode uses .opencode/commands with a matching .opencode/command compatibility
copy, and Copilot uses agents plus prompts. Optional editor settings remain
machine-local and are not project permissions. Generated whitespace was
normalized; upstream manifests retain original installation metadata. Keep both
OpenCode directories identical during updates and run the surface-parity check.
The shared command block inspects presets and validates the project matrix.

## Lokale Prüfungen und Wartung / Local checks and maintenance

Nach einem neuen Klon den versionierten Pre-Push-Hook installieren:

```bash
# macOS / Linux
bash scripts/install-hooks.sh
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
bash scripts/render-project-statistics.sh --repo . --check-only
```

```powershell
# Windows, PowerShell 7
pwsh -NoProfile -File scripts/install-hooks.ps1
pwsh -NoProfile -File scripts/scan-agent-secrets.ps1 -FailOnHigh
pwsh -NoProfile -File scripts/check-homogeneity.ps1 -TargetDir . -DryRun -NoPatch
pwsh -NoProfile -File scripts/render-project-statistics.ps1 -Repo . -CheckOnly
```

Statische PowerShell-Analyse: `pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1`.
PSScriptAnalyzer wird gemäß Modulregistry in Version 1.25.0 verwendet.
Wartungsskripte stammen aus dem kanonischen Level-0-Paket; Vorschau vor jedem
schreibenden Lauf. CI prüft Einrichtung und verteilte Wartungswerkzeuge,
keine noch nicht existierende Produktfunktion.

After a new clone, install the versioned pre-push hook using the platform's
command block. The listed checks cover secrets, homogeneity and statistics.
Static PowerShell analysis uses the pinned PSScriptAnalyzer 1.25.0. Maintenance
scripts come from Level 0; preview every maintenance write first. CI checks setup
and distributed tooling, not future product behavior. This authoring task does
not reinstall hooks or run writing maintenance commands.

## Dokumentation und Statistik / Documentation and statistics

Fachliche Dokumente, Lastenhefte und gemeinsame Governance-Guidance werden
Deutsch zuerst und Englisch danach gepflegt, ungefähr CEFR B2. Die alte
Deutsch-Ausnahme ist aufgehoben. Offene Bestandsübersetzungen und die zentrale
Registeränderung stehen in der [Governance-Zuordnung](intake-governance.md). Die fünf Agenten-Dateien sind
inhaltlich identisch. Tastatur, Screenreader, Braille und textorientierte
Darstellung bilden die A11Y-Basis; WCAG 2.2 AA gilt soweit anwendbar.

[Profil 2](project-statistics.md) zählt versionierten Text und Git-Aktivität.
Es umfasst auch importierte Governance und Wartungswerkzeuge und ist deshalb
kein Maß für selbst geschriebenen Produktcode. Referenzen: `80` konservativ,
vorläufig `100` Zeilen/Arbeitstag für Konzept/Scripting; bei C#/.NET auf `125`
reevaluieren. Das zusätzliche Statistik-Preset ist nur installiert; ein
Pilotmesslauf oder eine Aussage über KI-Zeitersparnis folgt daraus nicht.
Lokales Authoring ergänzt das Fortschreibungsprotokoll ohne Commit; die
commitbasierte Generierung folgt erst bei gesondert beauftragter Lieferung.

Domain documents, intakes and shared guidance use German first and English
second at about CEFR B2. The former German-only exception is removed. Outstanding
translations and the central registry proposal are recorded in the governance
mapping. Five guidance files remain identical. Keyboard, screen-reader, Braille
and text access form the accessibility baseline, with WCAG 2.2 AA where relevant.
Statistics Profile 2 counts tracked text and Git activity, including imported
governance and tools; it is not a measure of authored product code. References
are 80 and provisionally 100 lines/workday for concept/scripting, with 125 to be
reevaluated if C#/.NET is selected. Installing the statistics preset starts no
pilot and proves no AI time saving. Local authoring adds a ledger entry without
committing; commit-based rendering follows only during later authorized delivery.

## Dokumentationsauswirkung / Documentation impact

Entscheidung: **UpdateRequired**. Owner: Thorsten Hindermann.
Zielgruppen: Maintainer und Agenten; Leserpfad: README → diese Anleitung →
Prüfungen → LH-00. Quellen: fachliches Bedienkonzept, zentrale Constitution,
gepinntes Presetprofil, live ausgelesene GitHub-Einstellungen und die
Owner-Angaben vom 28.09.2026 zur PowerShell-Installation auf beiden Macs
sowie zu Windows 11 und Ubuntu 24.04 unter WSL2.
Dokumentklasse: Einrichtung/Betrieb; Sprachpartner: DE/EN in dieser Datei. Plattformnachweis: lokale macOS-Prüfungen
und PR-CI; daraus folgt keine Produktabnahme auf Linux oder Windows.
Distribution: versionierte Level-2-Quelle; lokale Registry und Caches privat.
Kein Home-Sync aus diesem Produktrepository. Zentrale Constitution-Änderungen
werden über den Level-0-Vertrag synchronisiert. Re-Evaluation bei Runtime-,
Preset-, Integrations- oder Repository-Regeländerungen.

Decision: UpdateRequired. Owner: Thorsten Hindermann. Audiences: maintainers and
agents. Reader path: README → this guide → checks/profile/mapping → LH-00 →
separate review. Sources are the interaction concept, shared constitution, pinned
profile, recorded repository settings and owner environment reports. Document
class: setup/operation, with DE/EN content in this file. Local macOS checks and
existing PR CI do not prove Linux/Windows product acceptance. Distribution is
versioned Level-2 source; local registries and caches remain private. No Home
Runtime sync is performed. Central constitution alignment follows the Level-0
contract. Reevaluate runtime, preset, integration and repository-rule changes.
