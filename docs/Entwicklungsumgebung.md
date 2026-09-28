# Entwicklungsumgebung

Stand: 28.09.2026. Owner: Thorsten Hindermann.

## Einstieg und Grenzen

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

Nächste fachliche Aktion ist die ausdrücklich beauftragte Bearbeitung von
LH-00. Die Einrichtung erzeugt keine Lastenhefte, schließt keine Issues und
startet keine autonomen Läufe. Die projektspezifische Intake-Policy wird erst
im Rahmen von LH-00 konkretisiert.

## Installierter Stand

- Auf beiden macOS-Systemen von Thorsten ist **PowerShell 7.6.6.0** installiert
  (Versionsangabe und Installationsstand laut Owner vom 28.09.2026).
  Dies dokumentiert die vorhandene lokale Entwicklungsumgebung; eine globale
  Aussage zur jeweils neuesten Veröffentlichung oder eine Mindestversion für
  das spätere Produkt wird daraus nicht abgeleitet.

- GitHub Spec Kit CLI und Integrations-Templates: **0.12.8**.
- Integrationen: `agy`, `opencode`, `claude`, `copilot`, `codex`.
- Projektprofil: `project-statistics-fourteen-governance-presets`.
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

## Verfügbare Intake-Kommandos

Die folgenden Kommandos wurden als installierte Agentenoberflächen geprüft;
sie wurden bei der Einrichtung nicht ausgeführt.

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

## Lokale Prüfungen und Wartung

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

## Dokumentation und Statistik

Fachliche Dokumente bleiben deutsch; gemeinsame Governance-Guidance wird
Deutsch zuerst und Englisch danach gepflegt. Die fünf Agenten-Dateien sind
inhaltlich identisch. Tastatur, Screenreader, Braille und textorientierte
Darstellung bilden die A11Y-Basis; WCAG 2.2 AA gilt soweit anwendbar.

[Profil 2](project-statistics.md) zählt versionierten Text und Git-Aktivität.
Es umfasst auch importierte Governance und Wartungswerkzeuge und ist deshalb
kein Maß für selbst geschriebenen Produktcode. Referenzen: `80` konservativ,
vorläufig `100` Zeilen/Arbeitstag für Konzept/Scripting; bei C#/.NET auf `125`
reevaluieren. Das zusätzliche Statistik-Preset ist nur installiert; ein
Pilotmesslauf oder eine Aussage über KI-Zeitersparnis folgt daraus nicht.

## Dokumentationsauswirkung

Entscheidung: **UpdateRequired**. Owner: Thorsten Hindermann.
Zielgruppen: Maintainer und Agenten; Leserpfad: README → diese Anleitung →
Prüfungen → LH-00. Quellen: fachliches Bedienkonzept, zentrale Constitution,
gepinntes Presetprofil, live ausgelesene GitHub-Einstellungen und die
Owner-Angabe vom 28.09.2026 zur PowerShell-Installation auf beiden Macs.
Dokumentklasse: Einrichtung/Betrieb; Sprachpartner: deutsch für Fachtexte,
bilingual in gemeinsamer Guidance. Plattformnachweis: lokale macOS-Prüfungen
und PR-CI; daraus folgt keine Produktabnahme auf Linux oder Windows.
Distribution: versionierte Level-2-Quelle; lokale Registry und Caches privat.
Kein Home-Sync aus diesem Produktrepository. Zentrale Constitution-Änderungen
werden über den Level-0-Vertrag synchronisiert. Re-Evaluation bei Runtime-,
Preset-, Integrations- oder Repository-Regeländerungen.
