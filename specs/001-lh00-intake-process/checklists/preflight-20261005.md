# LH-00: Startprüfung / Start preflight

Datum / Date: 2026-10-05. Basis / Base: `063659b60cded40b7407220bf820d214c1ed5904`.
Auftrag / Authority: [IAD011](../../../docs/planning/lh00-preflight-refresh-decisions.md).
Autor / Author: Codex-Hauptagent / main agent. Owner: Thorsten Hindermann.

## Aktueller technischer Nachlauf / Current technical follow-up

Codex-Routing Aligned/Exit 0; Statistikrenderer und Homogenitätscheck nach
reproduzierbarer Aktualisierung erfolgreich/Exit 0. Der Homogenitätscheck meldet
weiterhin die bestehende lokale STATS.md-Sprachwarnung (kein FAIL). Die folgenden
Blocked-/Failed-Zeilen dokumentieren den ursprünglichen Befund, nicht den jetzigen
Nachlauf. Finaler Lieferhead und Merge-/Sync-Ergebnis stehen im PR-/Chat-Nachweis.
Kein Implementierungsauftrag, keine Serienaktivierung oder Prozessabnahme.

Codex routing is Aligned; regenerated statistics and homogeneity checks pass,
all with exit zero. Homogeneity retains the existing local STATS.md language
warning without failure. Blocked/Failed rows below preserve the original outcome,
not the current follow-up. PR/chat evidence binds final delivery head and merge/sync.
This grants no implementation, series activation or process acceptance.

## Historischer Vorbereitungsbefund IAD011 / Historical preparation outcome IAD011

**Preflight: Blocked für einen Implementierungsstart.** Die lokale Vorbereitung
ist ausgeführt; sie startet keine Implementierung. Zwei technische Pflichtchecks
sind nicht grün: Modell-Routing meldet RefreshRequired und der Statistikrenderer
meldet Drift. Die Implementierungs-/Lieferbefugnis ist ebenfalls noch nicht
beauftragt; das ist eine Auftragsgrenze, kein Fehler des Intakes. Kein automatischer
Refresh, Statistik-Schreiblauf, Commit, Push oder Release wurde ausgeführt.
Die Matrix-Installation und PowerShell-/Paritätsprüfungen sind erfolgreich.

**Preflight: Blocked for implementation.** Local preparation is performed without
starting implementation. Two technical required checks are not green: routing
reports RefreshRequired and the statistics renderer reports drift. Implementation
and delivery are also outside the current request; this is an authority boundary,
not a defect in the intake. No refresh, statistics write, commit, push or release
was performed. Installed matrix, PowerShell analysis and parity checks pass.

## Tatsächliche Prüfungen / Actual checks

Alle Kommandos laufen aus der Projektwurzel, Bash zuerst auf macOS. Die Prüfungen
sind keine native Windows-/Linux- oder vollständige LH-00-Prozessabnahme.
Commands run from the repo root, Bash first on macOS. They prove neither native
Windows/Linux operation nor full LH-00 process acceptance.

| Prüfung / Check | Ergebnis / Outcome | Nachweis und Grenze / Evidence and boundary |
|---|---|---|
| Git vor Änderung / before editing | PASS | main und origin/main auf 063659b, sauber; Remote-main mit git ls-remote bestätigt. Für lokale Vorbereitung Branch codex/lh00-preflight-refresh erstellt, ohne Remote-Upstream; Änderungen gehören IAD011 / clean synchronized base, local unpublished preparation branch |
| Alte Receipt-Bindung / previous receipt | Failed, Exit 2 | Quellenhashdrift in docs/intake-governance.md und docs/Entwicklungsumgebung.md; Vorgänger unverändert archiviert / explained source drift, predecessor preserved |
| Alter Review-Validator / previous review validator | PASS, Exit 0; nicht als Startfreigabe verwendbar / unusable as start permission | Prüfte unverändertes Ziel, nicht alle erweiterten Quellen-/Governance-Bindungen; hebt Receipt-Fehler nicht auf / target check cannot cancel source drift |
| Neues Receipt / new receipt | PASS in Bash/PowerShell, jeweils Exit 0 | Beide installierten Shell-Validatoren sowie unabhängiger Quellen-/Governance-Hashvergleich / paired validators and complete hash bindings |
| Neues unabhängiges Review / fresh independent review | Ready; Result Bash/PowerShell jeweils PASS, Exit 0 | Separater Agent, Single; fachliche Reife getrennt vom Preflight / separate semantic reviewer, not start permission |
| 14-Preset-Matrix / matrix | PASS, Exit 0 | bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only |
| Secret-Scan | PASS, Exit 0 | bash scripts/scan-agent-secrets.sh --fail-on-high .; high=0, medium=0, fünf low-Hinweise auf Agentenverzeichnisse / five low directory notices |
| Homogenität / homogeneity | Failed, Exit 1 | bash scripts/check-homogeneity.sh --dry-run --no-patch .; Statistikdrift als FAIL, bestehende STATS.md-Sprachwarnung / statistics failure and existing bilingual-section warning |
| Statistik / statistics | Failed, Exit 1 | bash scripts/render-project-statistics.sh --repo . --check-only; Drift bereits am sauberen Ausgangsstand / drift already present before edits |
| PowerShell-Analyse / analysis | PASS, Exit 0 | pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1; PSScriptAnalyzer 1.25.0, 73 Dateien ohne Error/Warning / 73 files without Error/Warning |
| Agentenflächen / agent surfaces | PASS, Exit 0 | python3 scripts/tests/test_spec_kit_agent_surface_parity.py; vier Tests / four tests |
| Guidance/Constitution | PASS | Fünf Guidance-Dateien bytegleich, zwei Constitution-Kopien bytegleich; unverändert / identical bytes, unchanged |
| Matrix/Quellen-Lock / source lock | PASS | Fünf koordinierte Versionsbindungen stimmen; gh verifiziert stabile drei Intake-Releases, zentrale PR #318 und Projekt PR #21/#22 MERGED / current immutable version/delivery mapping |
| Codex-Modell-Routing / model routing | RefreshRequired, Exit 2 | bash scripts/resolve-model-routing.sh -Action Status -Harness Codex -RoutingRoot .specify/presets; Discovery Enumerate, acht Modelle. Lokale Konfiguration unterscheidet sich vom aktuellen berechneten Profil / local profile differs from current calculated profile |
| Collection/Serie/Kandidat / collection/series/candidate | N/A für diesen Einzelintake-Start / for standalone preparation | Das bindende Profil erlaubt zunächst Einzelintakes. Collection/Serie werden erst in US5 eingerichtet; keine Fake-Serie, keine Eligible-Auswahl und kein automatischer Serienstart / collection remains a later US5 task, no fabricated selection |
| Feature-Prerequisites / Analyze | PASS, Exit 0; keine Befunde / no findings | Bestehende Feature-Zuordnung und vollständige Plan-/Tasks-Dateien / existing feature mapping and artifacts |
| Diff/Links/Struktur / structure | PASS | Keine kaputten lokalen Links, 65 eindeutige offene Task-IDs, 17 Parallelmarker; negative Fälle vor positiven / bounded checks, not process acceptance |

## Tatsächliche Werkzeuge / Actual tools

Git 2.54.0; ausgewähltes Bash 5.3.20 (kein Ausführen mit macOS-System-Bash 3.2);
Python3 3.14.8; PowerShell 7.6.6; Specify CLI 0.12.8 mit eigener Python-3.11.14-
Umgebung; Pandoc 3.11; Typst 0.15.1; VS-Code-Erweiterung
myriad-dreamin.tinymist 0.15.8. Versionen wurden mit tatsächlichen CLI-Aufrufen
beziehungsweise code --list-extensions --show-versions gelesen. Standalone
Tinymist ist optional. Keine Tools installiert, keine Produkt-Mindestversion
entschieden. Mac A/B-Zuordnung erfolgt vor dem späteren Fixture-Lauf in T003.

Actual CLI/editor checks find the versions above. Bash execution uses 5+; Specify
has its own Python environment. Standalone Tinymist is optional. No installation
or product-minimum decision occurred. Assign this host to Mac A/B before the
later fixture run in T003.

## Nächste Aktionen / Next actions

1. Codex-Routing nach ausdrücklich beauftragtem lokalen speckit-model-routing-refresh
   erneut mit Status prüfen; diesen lesenden Auftrag nicht als Refresh-Autorität nutzen.
2. Bestehende Git-gebundene Statistik beim autorisierten Commit-/Lieferpaket mit dem
   Renderer fortschreiben und Check-only/Homogenität erneut prüfen. Keine handgemachten
   Statistikzahlen; ursprünglichen Driftbefund nicht als PASS umdeuten.
3. Den konkreten LH-00-Implementierungsauftrag und seine Liefergrenze festlegen;
   anschließend nur die durch Änderungen betroffenen Startchecks wiederholen.

1. After an explicit local routing-refresh request, recheck status; read-only
   preflight authority alone does not permit refresh.
2. Update existing Git-bound statistics with the renderer during the authorized
   commit/delivery package, then repeat check-only/homogeneity. Never hand-edit
   figures or turn the original drift result into PASS.
3. Commission a concrete LH-00 implementation scope and delivery boundary; then
   repeat only start checks affected by intervening changes.

## Ausführbarer Umfang nach Startfreigabe / Scope after start permission

T001–T018 war ein kleiner erster Prüfpunkt, keine dauerhafte Begrenzung. Ein
passender nächster Auftrag kann den Kernprozess T001–T045 sowie unabhängig
vorbereitbare Dokumentations-/Governancearbeit umfassen. Foundation, negative
Prüfungen, unabhängiges Review, Serienauftrag und Owner-Pilotentscheidung bleiben
in ihrer Reihenfolge erhalten. T046–T050 und T059–T060 hängen von erfolgreich
abgeschlossenen, separat beauftragten LH-01-/LH-02-Piloten ab. Die volle Abnahme
folgt vor LH-03; ein vorzeitiges LH-00 Completed bleibt ausgeschlossen.

T001–T018 was a small first checkpoint, not a permanent limit. A future request
may cover core tasks T001–T045 plus independently preparable documentation and
governance work, preserving foundation, negative tests, independent review,
series authority and owner pilot permission. T046–T050 and T059–T060 require
completed, separately commissioned LH-01/LH-02 pilots. Full acceptance precedes
LH-03, with no premature LH-00 Completed.

UpdateRequired; sourceOnly; Owner Thorsten; DE/EN B2. Leserpfad / reader path:
Plan/Tasks → dieser Nachweis / this record → Receipt/Review und B-01-Zuordnung.
Wiedervorlage / reassess: vor Umsetzung oder bei geänderten Quellen/Tools/Autorität.

## Neue Bindungen / Refreshed bindings

Intake-ID unverändert / unchanged: 2296d99d-f099-4c4d-88f7-789581693eb0.
Receipt-ID: 98203fd2-0684-4fd6-ab69-a1353e250a12.
Review-ID: 482709fb-f89a-4f48-b925-3e16b1dd3daa.
Zielhash / target hash: 7bf415b47b81b0c13a165107b7c2021712a314bd7cf4533e6cc58950147e681a.
Receipt-Ziel, 14 Quellen und vier Governance-Bindungen aktuell; zusätzlich 34
Review-Bindungen geprüft. Autor: Hauptagent. Anderer Prüfer: Codex-Agent
/root/lh00_refresh_independent_review. IR005 wurde vor Ready vom Autor korrigiert
und vom separaten Prüfer erneut bewertet; kein offener Befund oder akzeptiertes Risiko.
Vorgänger-Intake, Receipt, Profil und altes Reviewpaket bytegleich archiviert.
Bash-/PowerShell-Receipt-/Review-Commands, Zeitpunkt und Validatorhashes stehen im
maschinellen Review unter validationEvidence; keine nativen Fremdplattformnachweise.

Receipt target, fourteen sources and four governance bindings are current; thirty-four
additional review bindings pass. The main agent authored the change; a separate
named agent reviewed it. IR005 was author-corrected and independently rechecked
before Ready, with no open finding or accepted risk. Prior intake/receipt/profile
and review package are archived byte-for-byte. The result records actual paired
commands, timestamps and validator hashes; no native foreign-platform proof.

## Analyze und Abschlussprüfung / Analyze and final verification

Der einmalige Prerequisite-Aufruf
`bash .specify/scripts/bash/check-prerequisites.sh --json --require-tasks --include-tasks`
lieferte das vorhandene Feature-Verzeichnis und research/data-model/contracts/quickstart/tasks.
Keine before-/after_analyze-Hooks: .specify/extensions.yml ist nicht vorhanden.
Die anschließende lesende Konsistenzanalyse prüfte Spec, Plan, Tasks und bindende
Constitution: 24 FR und neun SC, 65 Tasks, 100 % geplante Abdeckung, keine offenen
CRITICAL/HIGH/MEDIUM/LOW-Befunde, keine Dopplungen, ungeklärten Mehrdeutigkeiten
oder nicht zugeordneten Aufgaben; Setup/Foundation/Polish sind gemeinsame Unterstützung.
FR-013/CR-006 decken die neue Governance; T005/T010/T012/T058 konkretisieren sie.
T018 bleibt vor T017, T025 vor T024; 17 Parallelmarker und gestufte Piloten bleiben
konsistent. T034–T036 verlangen keine erneuten Releases/Installation ohne Abweichung.
Das ist Anforderungs-/Planabdeckung, keine erledigte Implementation oder Produktabnahme.

One prerequisite call resolves the existing feature and available design inputs.
No extension hooks are configured. Read-only cross-artifact analysis checks
spec/plan/tasks against the binding constitution: 24 FR, nine SC, 65 tasks, 100 %
planned coverage, no open findings at any severity, duplication, unresolved ambiguity
or unmapped tasks; common setup/foundation/polish support the mapped requirements.
Existing IDs cover the new governance. Negative-before-positive dependencies,
seventeen parallel markers and staged pilots are consistent. Integration tasks
reuse delivered releases/installation. Coverage does not mean implementation or
product acceptance.

Nach lokaler Veröffentlichung bestehen die Bash-Receipt-/Review-Statusprüfungen
erneut mit Exit 0. Der Secret-Scan wurde gegen die geänderten Dateien wiederholt;
keine High-/Medium-Befunde. Verweis-, Struktur- und Whitespace-Check bestanden.
Alle 65 Umsetzungstasks bleiben offen. Keine gemeinsame Guidance, Constitution,
installierten Presets oder Statistikzahlen geändert; kein Feature-Abschlussbericht.

After local publication the Bash receipt/review status checks pass again with
exit zero. Repeat secret scan finds no high/medium findings; links, structure and
whitespace pass. All implementation tasks remain open. Guidance, constitution,
installed presets and statistics figures are unchanged; no feature completion
report is produced.

## Beauftragter Liefernachlauf / Authorized delivery follow-up

Stand / Date: 2026-10-05. Der Owner beauftragte anschließend ausdrücklich den
lokalen Codex-Routing-Refresh sowie Statistikpflege und DeliveryMode MergeAndSync
mit Admin-Bypass. Dies erweitert die Lieferbefugnis für das vorbereitete Paket;
es startet keine LH-00-Implementierung, Serie oder Einzelpiloten. IAD011 oben
bleibt der historische Vorbereitungsscope. Intake, Receipt und fachliches Review
werden nicht verändert; lokale Routingdaten werden nicht versioniert.

Der installierte Bash-Aufruf mit -Action Refresh -Harness Codex -RoutingRoot
.specify/presets wurde zuerst mit -WhatIf geprüft: keine Änderung, erwartetes
RefreshRequired/Exit 2. Der echte Refresh und anschließende read-only Status
melden beide Aligned/Exit 0 (Discovery Enumerate, acht Modelle). Der ursprüngliche
RefreshRequired-Befund bleibt oben als Historie erhalten.
Die Git-gebundene Statistik wird nach dem Quellencommit mit dem bestehenden
Renderer aktualisiert und zusammen mit Homogenität vor Push/Merge erneut geprüft.
Die abschließenden Ergebnisse gehören zum PR-/Chat-Liefernachweis; kein Commit
allein für selbstreferenzielle Merge-/Statistikwerte. Unabhängiges Intake-Ready
bleibt von Prozessabnahme und Implementierungsautorität getrennt.

The owner subsequently commissioned local Codex routing refresh, statistics
maintenance and MergeAndSync with admin bypass for the prepared package, without
implementation, series activation or pilots. Preserve historical IAD011 authority
and current intake/receipt/review; local routing data is never versioned. WhatIf
performed no write and reported expected RefreshRequired/exit two. Actual refresh
and subsequent status both report Aligned/exit zero, with eight discovered models.
Update Git-bound statistics after the source commit and check statistics plus
homogeneity before push/merge. Final results belong to PR/chat delivery evidence;
no extra commit solely for self-referential merge/statistics values. Semantic
Ready remains separate from process acceptance and implementation permission.

Lokaler Statistik-Nachlauf / Local statistics follow-up: Renderer zunächst mit
--dry-run --json geprüft, dann auf sauberem Quellencommit ausgeführt. Check-only
meldet CURRENT/Exit 0. Homogenität: Exit 0, 0 FAIL, 1 bestehende STATS.md-WARN.
Nach dem finalen Quellencommit werden die generierten Werte erneut deterministisch
abgeleitet und geprüft; keine numerischen Handänderungen oder Methodikänderungen.

Preview statistics with --dry-run --json, render from a clean source commit, then
verify CURRENT/exit zero. Homogeneity has no failure and one existing STATS.md
warning. Recompute/check generated values from the final source commit without
manual figures or methodology changes.
