# Entwicklungsumgebung / Development environment

Stand / Date: 04.10.2026. Owner: Thorsten Hindermann.

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

[LH-00](../intakes/LH-00.md) wurde mit
[Policy](../.specify/memory/intake-authoring-policy.json) und
[Profil](../.specify/memory/intake-authoring-profile.md) erstellt. Ein Intake ist
ein fachliches Lastenheft; ein Receipt bindet Quellen und Inhalt durch Prüfsummen.
Authoring ist die Erstellung, Review eine gesonderte fachliche Prüfung.
Das [aktuelle Receipt](../specs/intake-authoring-receipts/lh-00.json) und der
[aktuelle Reviewbericht](../specs/intake-review-report.md) dokumentieren den Stand.
`ReadyForReview` bestätigt keine Umsetzung oder Produktabnahme. Die beauftragte
Reparatur und das unabhängige Review folgen den
[Owner-Entscheidungen](planning/lh00-repair-decisions.md). Issues 1–8 wurden
[veröffentlicht](issue-publication.md); die ursprünglichen Entwürfe bleiben
historische Quellen. Vollständige Prozesskonfiguration und -abnahme bleiben
Anforderungen von LH-00.

This is an independent Level-2 project in RiderProjects, sourced from
hindermath/Show-CommandTui400 on main. The interaction concept and intake order
are binding. No product implementation exists; language, framework, minimum
PowerShell version and session integration remain undecided. The bundled .NET
maintenance TUI belongs to Home Baseline. LH-00 was created using the linked
policy and profile. An intake is a requirements document; a receipt binds sources
and content with hashes. Authoring creates the document; review is a separate
assessment. The current receipt and review report show its state. ReadyForReview
is not implementation or product acceptance. The authorized repair and independent
review follow the linked owner decisions. Issues 1–8 were published; original
drafts remain historical sources. Full process setup and acceptance remain
LH-00 requirements.

## Installierter Stand / Installed state

- Auf beiden macOS-Systemen von Thorsten ist **PowerShell 7.6.6.0** installiert
  (Versionsangabe und Installationsstand laut Owner vom 28.09.2026).
  Dies dokumentiert die vorhandene lokale Entwicklungsumgebung; eine globale
  Aussage zur jeweils neuesten Veröffentlichung oder eine Mindestversion für
  das spätere Produkt wird daraus nicht abgeleitet.

- GitHub Spec Kit CLI und Integrations-Templates: **0.12.8**.
- Integrationen: `agy`, `opencode`, `claude`, `copilot`, `codex`.
- Projektprofil: `project-statistics-fourteen-governance-presets`.
- Intake Authoring Governance: **v0.3.7**, aktiviert mit Priorität 64.
  Patch-Nachweis: [v0.3.7 und neue Start-Grenze](maintenance/intake-authoring-v037.md).
  Der [koordinierte Update-Nachweis](maintenance/coordinated-governance-oct03.md)
  bindet auch Review v0.2.4, Sequencing v0.2.7, Security v0.7.0 und Architecture
  v0.6.1. Die übrigen neun Presets und alle Prioritäten bleiben unverändert.
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
profile and pinned matrix. Authoring 0.3.7 is enabled at priority 64; the coordinated
update record also binds Review 0.2.4, Sequencing 0.2.7, Security 0.7.0 and
Architecture 0.6.1. The other nine presets and all priorities are unchanged. Integration manifests
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
Einrichtung wurden sie nicht ausgeführt; die ursprüngliche Authoring-Phase
verwendete nur das Erstellungsverfahren für LH-00. Die genaue Schreibweise folgt dem Agenten.

| Zweck | Codex / Antigravity | OpenCode / Copilot |
|---|---|---|
| Lastenheft erstellen | `speckit-intake-create` | `speckit.intake-create` |
| Lastenheft lesen | `speckit-intake-read` | `speckit.intake-read` |
| Autorierungsstatus prüfen | `speckit-intake-create-status` | `speckit.intake-create-status` |
| Review | `speckit-intake-review` | `speckit.intake-review` |
| Reviewstatus | `speckit-intake-review-status` | `speckit.intake-review-status` |
| Reihenfolge prüfen | `speckit-intake-series-status` | `speckit.intake-series-status` |
| Zulässige Kandidaten auflisten | `speckit-intake-series-next` | `speckit.intake-series-next` |

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
review status and series status. They were not run during setup; the original
authoring phase used only LH-00 creation. Command spelling depends on the agent. Codex and
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
and distributed tooling, not future product behavior. The original authoring task did
not reinstall hooks or run writing maintenance commands.

### Vor einem Spec-Kit-Lauf nach fetch/pull / Before a Spec Kit run after fetch/pull

Ein Preflight ist die Prüfung der Startvoraussetzungen. Die folgende Reihenfolge
verwendet vorhandene Werkzeuge, ohne Installation, Reparatur oder einen Produktlauf
zu starten. Alle Befehle aus der Repository-Wurzel ausführen. Jeder fehlgeschlagene
Pflichtcheck blockiert den Start; auch Warnungen mit Exitcode 0 auf ihre Auswirkung
prüfen. Ursache und erforderliche Klärung festhalten, keine Evidence automatisch
reparieren. Evidence bezeichnet hier einen nachvollziehbaren Nachweis.

A preflight checks whether a run may start. Use the existing tools in the order
below from the repository root. This does not install or repair anything or start
product work. Every failed required check blocks the start. Assess warnings even
when the exit code is zero. Record the cause and required resolution; do not repair
evidence automatically. Evidence means a traceable record supporting a claim.

**1. Git-Zustand / Git state**

```text
git status --short --branch
git branch --show-current
git rev-parse --abbrev-ref --symbolic-full-name "@{upstream}"
git rev-list --left-right --count "HEAD...@{upstream}"
git diff --check
```

Branch, Upstream-Abweichung, lokale Änderungen und Konflikte prüfen. Fehlenden
Upstream klären. Beim Start vom synchronisierten `main` muss der Zähler `0 0`
zeigen. Fortsetzungen verwenden den zugehörigen Featurebranch; `0 0` ersetzt keine
inhaltliche Prüfung. Lokale Änderungen einem Auftrag zuordnen, Konflikte vor dem
Start klären, nichts automatisch verwerfen. Nach `fetch` allein können Änderungen
noch nicht integriert sein; die Aussage bezieht sich auf den zuletzt abgerufenen
Remote-Stand. Bei gestagten Änderungen zusätzlich `git diff --cached --check` nutzen.

Check the branch, upstream difference, local changes and conflicts. Resolve a
missing upstream. A start from synchronized `main` requires counts of `0 0`.
Continue existing work on its feature branch; matching counts do not prove content
readiness. Assign local changes to an authorized scope and resolve conflicts before
starting. Do not discard changes automatically. Fetch alone may leave changes
unintegrated; the comparison uses the last fetched remote state. Also run
`git diff --cached --check` when changes are staged.

**2. Unterlagen und Governance / Documents and governance**

[Guidance](../AGENTS.md), [Constitution](../constitution.md), deren
[Spec-Kit-Kopie](../.specify/memory/constitution.md), [Bedienkonzept](Bedienkonzept.md),
[LH-00](../intakes/LH-00.md), [Reihenfolge](Lastenheft-Plan.md) und vorhandene
[Plan-/Tasks-/Checklist-Artefakte](../specs/001-lh00-intake-process/plan.md) lesen.
Die fünf Guidance-Dateien und beide Constitution-Kopien müssen jeweils identisch
sein. Der folgende read-only Hashvergleich läuft auf allen Zielplattformen:

Read the linked guidance, both constitution copies, interaction concept, LH-00,
intake order and existing plan/tasks/checklists. The five guidance files must match,
as must the two constitution copies. This read-only hash check works on all target
platforms:

```powershell
pwsh -NoProfile -Command '
$ErrorActionPreference = "Stop"
$expected = (Get-FileHash AGENTS.md -Algorithm SHA256).Hash
foreach ($path in @("CLAUDE.md", "GEMINI.md", ".github/copilot-instructions.md", ".github/agents/copilot-instructions.md")) {
    if ((Get-FileHash $path -Algorithm SHA256).Hash -ne $expected) { throw "Guidance differs: $path" }
}
if ((Get-FileHash constitution.md -Algorithm SHA256).Hash -ne (Get-FileHash .specify/memory/constitution.md -Algorithm SHA256).Hash) {
    throw "Constitution copies differ"
}
'
```

Neue zwingende Governance-Regeln minimal mit dem akzeptierten Plan und seinen
Folgeartefakten abgleichen. Bei inhaltlicher Auswirkung gezielt nachprüfen;
historische Reviews und Receipts erhalten, ihre aktuelle Gültigkeit getrennt
bewerten. Der [geschlossene Hand-off #19](https://github.com/hindermath/Show-CommandTui400/issues/19)
und seine [Abschlussnachweise](https://github.com/hindermath/Show-CommandTui400/issues/19#issuecomment-5972933761)
belegen die damalige technische Lieferung, keine aktuelle Produktstartfreigabe.

Reconcile new mandatory rules with the accepted plan and related artifacts using
the smallest necessary change. Recheck affected content when a rule changes its
meaning. Preserve historical reviews and receipts and assess their current validity
separately. Closed hand-off #19 and its linked closeout evidence prove historical
technical delivery, not current permission to start product work.

**3. Basisprüfungen / Base checks**

```bash
# macOS / Linux
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
bash scripts/render-project-statistics.sh --repo . --check-only
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
```

```powershell
# Windows / PowerShell 7
pwsh -NoProfile -File scripts/install-spec-kit-governance-presets.ps1 -Repo . -PresetConfig scripts/config/spec-kit-project-statistics-governance-presets.json -CheckOnly
pwsh -NoProfile -File scripts/scan-agent-secrets.ps1 -FailOnHigh
pwsh -NoProfile -File scripts/check-homogeneity.ps1 -TargetDir . -DryRun -NoPatch
pwsh -NoProfile -File scripts/render-project-statistics.ps1 -Repo . -CheckOnly
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
```

Die exakte 14er-Matrix verwenden. Den Exitcode jedes Befehls prüfen: ein späterer
erfolgreicher Befehl hebt einen früheren Fehler nicht auf. Bei geänderten Werkzeugen
oder Governance zusätzlich betroffene Validatoren, Vertrags-/Negativtests und
Agentenflächen-Parität prüfen. Die vollständige Pilotabnahme wird nicht bei jedem
Pull wiederholt. Fehlende native Plattformnachweise bleiben offen.

Use the exact fourteen-preset matrix and check each command's exit code; a later
success does not cancel an earlier failure. When tools or governance change, also
run affected validators, contract/negative tests and agent-surface parity checks.
Do not repeat the entire pilot acceptance after every pull. Missing native platform
proof remains open.

**4. Kommandoabhängige Start-Gates / Command-specific start gates**

| Geplanter Schritt / Planned step | Erforderliche Prüfung / Required check |
|---|---|
| Tasks | Featurebranch und Plan prüfen; Bash: `bash .specify/scripts/bash/check-prerequisites.sh --json`. / Check feature branch and plan using the Bash command. |
| Implementierung / Implementation | Featurebranch, Plan, Tasks und Checklists prüfen; Bash: `bash .specify/scripts/bash/check-prerequisites.sh --json --require-tasks --include-tasks`. / Check feature branch, plan, tasks and checklists using the Bash command. |
| Produktstart / Product start | Aktuelles Intake-Review samt Quellhashes, Serienstatus, zulässigen Kandidaten, Modell-Routing und konkrete Implementierungs-/Delivery-Autorität prüfen. / Validate current review and source hashes, series state, eligible candidate, model routing and explicit implementation/delivery authority. |
| Autonomer Lauf / Autonomous run | Zusätzlich vorhandenen Laufzustand prüfen; pausierte oder unterbrochene Läufe nach dem vorgesehenen Resume-Verfahren behandeln. / Also inspect existing run state; handle paused or interrupted runs through the required resume process. |

Die Feature-Prerequisite-Befehle sind keine allgemeinen Startchecks auf `main`.
Die installierten Basisskripte liegen unter `.specify/scripts/bash/`; eine native
PowerShell-Variante ist hier noch nicht installiert. Unter Windows keinen
entsprechenden Pfad erfinden oder WSL-Ergebnisse als native PowerShell-Abnahme
ausgeben. Ein benötigter, nicht verfügbarer Ablauf blockiert den betreffenden Schritt.

Feature prerequisite commands are not general start checks on `main`. Installed
base scripts are Bash scripts; no native PowerShell variant is installed here.
Do not invent a Windows script path or present WSL results as native PowerShell
acceptance. An unavailable required workflow blocks the affected step.

Die read-only Agentenkommandos aus der [Kommandotabelle](#intake-commands) verwenden:
`speckit-intake-review-status` für den gebundenen Intake,
`speckit-intake-series-status` für die benannte Serie und
`speckit-intake-series-next` für zulässige Kandidaten. Ergebnisse, Quellhashes,
Reihenfolge und Blocker auswerten; fehlt eine erforderliche Serie oder Evidence,
stoppen, ohne sie anzulegen. Ein valider Serienstatus allein belegt keinen
zulässigen Kandidaten. `Ready` oder ausdrücklich akzeptiertes
`ReadyWithAcceptedRisks` muss frisch und auf den konkreten Intake gebunden sein.
Unklare oder veraltete Nachweise blockieren; Statusprüfungen erteilen keine Freigabe.

Use read-only agent commands with the spelling shown in the linked command table:
review-status for the binding intake, series-status for the named series and
series-next for eligible candidates. Inspect results, source hashes, order and
blockers. Stop if required series or evidence is missing; do not create it.
A valid series state alone does not prove an eligible candidate. Ready or explicitly
accepted ReadyWithAcceptedRisks must be current and bound to the specific intake.
Unclear or stale evidence blocks the start; status checks grant no permission.

Für das ausgewählte Harness, hier beispielhaft Codex, Modell-Routing read-only
prüfen; für andere Harnesses deren tatsächlichen Namen verwenden:

Check model routing read-only for the selected harness (Codex shown here); use the
actual harness name for other integrations:

```bash
# macOS / Linux
bash scripts/resolve-model-routing.sh -Action Status -Harness Codex -RoutingRoot .specify/presets
```

```powershell
# Windows / PowerShell 7
pwsh -NoProfile -File scripts/resolve-model-routing.ps1 -Action Status -Harness Codex -RoutingRoot .specify/presets
```

**5. Werkzeuge und Startentscheidung / Tools and start decision**

Benötigte Werkzeuge anhand des gewählten Kommandos und des Wartungsvertrags auf
Installation und erforderliche Version prüfen: beispielsweise Git, Spec-Kit-CLI,
Bash, Python 3, PowerShell 7 und das gepinnte PSScriptAnalyzer-Modul. Pandoc, Typst
und VS-Code-Erweiterung `myriad-dreamin.tinymist` gehören zum Wartungsvertrag;
standalone Tinymist ist optional. Dateipropagation ist kein Installationsnachweis.
Für Produkt-Builds ausschließlich definierte Projekt-Testbefehle nutzen; Sprache,
Framework und offene Plattformabnahmen sichtbar lassen, keinen Build erfinden.

Verify actual installation and required versions against the chosen command and
maintenance contract, for example Git, Spec Kit CLI, Bash, Python 3, PowerShell 7
and pinned PSScriptAnalyzer. Pandoc, Typst and the VS Code extension
myriad-dreamin.tinymist belong to the maintenance contract; standalone Tinymist is
optional. Propagated files do not prove installed tools. Use only defined product
test commands; keep language/framework decisions and platform acceptance gaps
visible and do not invent a build.

Vor dem Start konkrete Scope-Freigabe und aktuelle Liefergrenze nachweisen:
lokale Implementierung, PR-Veröffentlichung oder Merge/Synchronisierung sind
unterschiedliche Befugnisse. Installation und geschlossene Issues ersetzen sie
nicht. Ein erfolgreicher Preflight bestätigt technische Voraussetzungen, keine
Produkt-, Risiko- oder Rechtsfreigabe. Bei Blockaden Ursache und nächste Klärung
melden. Reparatur, neue Reviews und Produktarbeit benötigen passende Beauftragung.

Before starting, verify explicit scope permission and current delivery boundaries:
local implementation, PR publication and merge/synchronization are separate rights.
Installation and closed issues do not grant them. A successful preflight proves
technical prerequisites, not product, risk or legal approval. Report blockers with
their cause and next resolution. Repairs, new reviews and product work require
matching authorization.

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
In der ursprünglichen lokalen Authoring-Phase wurde das Protokoll ohne Commit
ergänzt. Bei beauftragter Lieferung folgen Inhaltscommit, Statistikgenerierung
und ein gesonderter Statistikcommit.

Domain documents, intakes and shared guidance use German first and English
second at about CEFR B2. The former German-only exception is removed. Outstanding
translations and the central registry proposal are recorded in the governance
mapping. Five guidance files remain identical. Keyboard, screen-reader, Braille
and text access form the accessibility baseline, with WCAG 2.2 AA where relevant.
Statistics Profile 2 counts tracked text and Git activity, including imported
governance and tools; it is not a measure of authored product code. References
are 80 and provisionally 100 lines/workday for concept/scripting, with 125 to be
reevaluated if C#/.NET is selected. Installing the statistics preset starts no
pilot and proves no AI time saving. Original local authoring added a ledger entry
without committing. Authorized delivery uses a content commit, statistics rendering
and a separate statistics commit.

## Dokumentationsauswirkung / Documentation impact

Entscheidung: **UpdateRequired**. Owner: Thorsten Hindermann.
Zielgruppen: Maintainer und Agenten; Leserpfad: README → diese Anleitung →
Preflight → kommandoabhängige Start-Gates → LH-00. Quellen: fachliches
Bedienkonzept, zentrale Constitution,
gepinntes Presetprofil, live ausgelesene GitHub-Einstellungen und die
Owner-Angaben vom 28.09.2026 zur PowerShell-Installation auf beiden Macs
sowie zu Windows 11 und Ubuntu 24.04 unter WSL2; für den Preflight zusätzlich
Issue #19 samt Abschlusskommentaren und vorhandene Skripthilfe.
Prüfnachweis: [Preflight-Dokumentationsprüfung](planning/spec-kit-preflight-validation.md).
Dokumentklasse: Einrichtung/Betrieb; Sprachpartner: DE/EN in dieser Datei. Plattformnachweis: lokale macOS-Prüfungen
und PR-CI; daraus folgt keine Produktabnahme auf Linux oder Windows.
Distribution: versionierte Level-2-Quelle; lokale Registry und Caches privat.
Kein Home-Sync aus diesem Produktrepository. Zentrale Constitution-Änderungen
werden über den Level-0-Vertrag synchronisiert. Re-Evaluation bei Runtime-,
Preset-, Integrations- oder Repository-Regeländerungen.

Decision: UpdateRequired. Owner: Thorsten Hindermann. Audiences: maintainers and
agents. Reader path: README → this guide → preflight → command-specific gates →
LH-00 → separate review. Sources are the interaction concept, shared constitution, pinned
profile, recorded repository settings and owner environment reports, plus issue #19
with closeout comments and existing script help for the preflight. See the linked
preflight documentation validation record. Document
class: setup/operation, with DE/EN content in this file. Local macOS checks and
existing PR CI do not prove Linux/Windows product acceptance. Distribution is
versioned Level-2 source; local registries and caches remain private. No Home
Runtime sync is performed. Central constitution alignment follows the Level-0
contract. Reevaluate runtime, preset, integration and repository-rule changes.

## Lokaler Create-Weg T001–T018 / Local creation route

**Stand / Date:** 2026-10-06. Dies ist ein Kandidat für T032, noch nicht aktiv. / This is a T032 candidate, not yet published.
Thorsten ist fachlicher Owner, Codex Autor, ein anderer Agent oder Mensch prüft
später den Intake. Ein Issue ist eine Quelle, kein Auftrag. Der explizite Auftrag
nennt genau ein freies Ziel, Profil `show-commandtui400-de-en` und geordnete
Quellen. Vorhandene Ziele brauchen intake-update, niemals Create-Overwrite.
Thorsten owns requirements, Codex authors, and a different reviewer performs a
separate intake review. An issue supplies input; the explicit request names one
free target, the profile and ordered sources. Existing targets require intake-update.

Create liest ausschließlich benannte Quellen plus Governance, klärt Konflikte,
schreibt `intakes/LH-NN.md` und Schema-2.0-Receipt unter
`specs/intake-authoring-receipts/lh-nn.json`, bindet Quellen/Ziel und prüft beide
Shell-Validatoren. Ergebnis ReadyForReview ist nur Authoring-Bereitschaft.
Create reads named sources and governance, resolves conflicts, creates an intake
and schema-2.0 receipt, binds hashes and runs both validators. ReadyForReview
means authoring readiness only.

Pflichtinhalt (FR-006): Identität/Zielgruppe, Zweck, Ist-/Zielzustand, Scope,
Nicht-Ziele, atomare Anforderungen, Qualität, Governance, Abhängigkeiten, Risiken,
Artefakte, Nachweise, messbare Abnahme, Annahmen, Entscheidungen/offene Fragen
und zwei kopierfertige Folgeprompts. Deutsch zuerst, äquivalentes Englisch danach,
ungefähr B2; FR/AC/OD-IDs bleiben gleich. Baseline Bedienkonzept und verbindliche
Lastenheft-Reihenfolge gelten; NIST SSDF/CWE/WCAG2.2AA soweit passend.
Required content: identity/audience, purpose, current/target state, scope/non-goals,
atomic requirements, quality, governance, dependencies, risks, artifacts, evidence,
measurable acceptance, assumptions, decisions/questions and both follow-up prompts.
Use equivalent German-first/English-second B2 text and shared IDs. Preserve the
interaction baseline, intake order and applicable security/accessibility rules.

Die zwei Promptabschnitte binden exakt das neue Intake. Specify erlaubt nur
technische Spezifikation, keine Implementierung/Remote-Writes. Autonomous nennt
LocalImplementation und benötigt einen neuen ausdrücklichen Auftrag; kein Prompt
wird automatisch ausgeführt. Für das erste Inkrement liegt nur ein isoliertes
Test-Intake vor, keine zusätzliche aktive LH-Datei und keine reale Serienverwaltung.
Specify binds the exact intake and forbids implementation/remote writes. Autonomous
uses LocalImplementation and needs its own explicit request. Neither prompt runs
automatically; this increment creates only inactive isolated test data.

Aktuell Mac A: Spec Kit 0.12.8 (CLI Python 3.11.14), System-Python 3.14.8, Bash 5.3.20, PowerShell 7.6.6. 14-Preset-Check erfolgreich. / Current local versions and fourteen-preset check are recorded for Mac A; this is no product minimum version.

Verfügbare Intake-Skills / Available intake skills: `speckit-intake-create`, `speckit-intake-create-status`, `speckit-intake-delete`, `speckit-intake-read`, `speckit-intake-repair`, `speckit-intake-review`, `speckit-intake-review-status`, `speckit-intake-series-create`, `speckit-intake-series-delete`, `speckit-intake-series-next`, `speckit-intake-series-read`, `speckit-intake-series-status`, `speckit-intake-series-update`, `speckit-intake-update`.

## Zwei Folgeprompt-Vorlagen / Two follow-up templates

Ein neues Ziel ersetzt im generierten Prompt exakt `intakes/LH-NN.md`; NN bleibt
hier eine Benennungsvorlage. Beide Vorlagen sind heute inaktiv. Fehlende oder
ungültige Review-Nachweise sperren den jeweiligen Folgeauftrag.
Generated prompts substitute the exact new intake path; NN is a naming template
here. Both remain inactive today; invalid review evidence blocks a later run.

```text
$speckit-specify intakes/LH-NN.md
Nutze ausschließlich das benannte Intake mit Profil show-commandtui400-de-en;
prüfe zuvor gültigen Receipt und unabhängiges Review. Nur technische Spezifikation,
DE zuerst/EN danach; keine Implementierung, Commits oder Remote-Writes.
Use only the named intake/profile after current receipt and independent review.
Specify only in DE/EN; no implementation, commits or remote writes.
```

```text
$speckit-autonomous intakes/LH-NN.md
Profil show-commandtui400-de-en; DeliveryMode LocalImplementation. Nur nach
neuem ausdrücklichem Auftrag und gültigen Receipt-/Review-Nachweisen.
Keine Commits, Pushes, Remote-Writes oder Funktionen anderer Lastenhefte.
Use the exact named intake after separate authority and current review/receipt.
LocalImplementation only; no delivery or scope from other intakes.
```

Für den aktuellen Bestand ist `docs/Lastenheft-Plan.md` die Reihenfolge,
`docs/Lastenheft-Plan.md#aktueller-lastenheft-stand--current-intake-state` der
lesbare Bestandsindex, `intakes/` die aktive Intake-Ablage und
`docs/Bedienkonzept.md` die fachliche Baseline. Es besteht hier noch keine
maschinenlesbare Collection-Konfiguration oder Serienverwaltung. Personenrollen
sind Owner Thorsten, beauftragter Autor und anderer Reviewer. T034+ konkretisiert
Collection-Pfade/Statusachsen; kein Index wird vorzeitig als validiert ausgegeben.
The current intake order also provides the readable inventory; intakes/ stores
active files and the interaction concept is the domain baseline. This is not a
validated machine-readable collection. Person roles remain separate; collection
configuration and lifecycle evidence follow their assigned later tasks.

## Ausführungsbegriffe und Textzugang / Execution terms and text access

CEFR B2 bedeutet ungefähr selbstständiges Lesen einfacher technischer Sprache.
Hash (Prüfsumme) bindet Inhalt, beweist keine fachliche Richtigkeit. Ein Validator
prüft maschinell einen Vertrag. Ein Gate ist eine Bedingung vor einem Folgeschritt.
Receipt bezeichnet Herkunftsnachweis, Authoring die Erstellung. Fachliche IDs
FR (Anforderung), AC (Abnahme), OD (Entscheidung) bezeichnen in DE/EN dieselbe Sache.
Ein Manifest ist eine maschinenlesbare Mitgliederliste. Diagramme sind hier N/A:
der lineare Weg und seine Abhängigkeiten werden vollständig als Text beschrieben.
Das ist keine praktische Screenreader-/Braille-/Tastaturabnahme.
CEFR B2 means independent reading of plain technical language. A hash binds
content, not correctness. A validator checks a machine-readable contract; a gate
is a prerequisite. A receipt records provenance; authoring creates the intake.
FR/AC/OD identify the same requirements, acceptance and decisions in both languages.
A manifest lists members. No diagram is needed for this linear procedure; complete
text does not establish assistive field acceptance.

