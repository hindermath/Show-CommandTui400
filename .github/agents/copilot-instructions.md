# Show-CommandTui400 — Agenten-Guidance / Agent Guidance

## Überblick und Projektkontext / Overview and Project Context

Level 2 im Workspace `RiderProjects`; kanonische Quelle ist
`hindermath/Show-CommandTui400`, Standardbranch `main`.
Fachliche Baseline: `docs/Bedienkonzept.md`; verbindliche Reihenfolge:
`docs/Lastenheft-Plan.md`. Das Projekt ist in der Konzeptphase.
Zielumgebung ist die aktuelle PowerShell-7-Sitzung auf macOS, Linux und Windows.
Implementierungssprache, Framework, minimale PowerShell-Version und technische
Sitzungsintegration sind offen. Aus dem Workspace-Namen folgt keine .NET-Vorgabe.

*Level 2 in RiderProjects. The canonical source is hindermath/Show-CommandTui400
on main. Read the interaction concept and intake order before work. This is a
concept-stage project targeting the current PowerShell 7 session on macOS,
Linux and Windows. Language, framework, minimum PowerShell version and session
integration remain undecided; the workspace name does not select .NET.*

## Arbeitsgrenzen / Work Boundaries

Die Einrichtung installiert Werkzeuge und Governance. Sie erstellt keine
Lastenhefte und startet keine Produktimplementierung oder autonomen Läufe.
Issues sind fachliche Eingaben; LH-00 bleibt zuerst zu bearbeiten.
Bestehende README, MIT-Lizenz und CODEOWNERS erhalten. Fremde Änderungen
nicht überschreiben. Keine Release-Automation ohne gesonderten Auftrag.

*Setup installs tooling and governance only. It does not author intakes, start
implementation or authorize autonomous runs. Issues are requirements input;
LH-00 comes first. Preserve existing content, license, owners and unrelated
changes. Release automation needs a separate request.*

## Governance und Sicherheit / Governance and Security

`constitution.md` und `.specify/memory/constitution.md` gemeinsam pflegen.
Die Projektzeile im Level-2-Umgebungsregister gilt für Runtime, Prüfungen,
Barrierefreiheit und Statistik. Primärsprache und MSL-Status bleiben `unknown`.
Die zentralen Level-0-Regeln sind die gemeinsame Basis, keine Übernahme fremder
Produktanforderungen. NIST SSDF und CWE Top 25 gelten auch für die Einrichtung.
Anwendbarkeit und offene Produktnachweise stehen in `docs/security/README.md`.
Secrets, Tokens, lokale Agentenzustände und Preset-Caches niemals committen.
Vor schreibenden Wartungsläufen Hilfe und Check-/Dry-Run-/WhatIf-Modus verwenden.
Auf macOS/Linux zuerst Bash, auf Windows PowerShell 7 verwenden.
Neue Logik auf Eingabevalidierung, Datei-/Netzwerkzugriffe und sichere Defaults
prüfen. Kommentare erklären Gründe und Grenzen, nicht offensichtlichen Code.

*Keep both constitution copies aligned and use the project environment row.
Implementation language and MSL status remain unknown. Shared Level-0 policy
does not import another product's requirements. NIST SSDF and CWE Top 25 apply;
record applicability and open evidence in docs/security/README.md. Never commit
secrets, agent state or preset caches. Preview writes first; use Bash first on
macOS/Linux and PowerShell 7 on Windows. Review input validation, I/O and secure
defaults. Comments explain rationale and boundaries.*

## Spec Kit und Prüfungen / Spec Kit and Checks

Explizites Projektprofil: `project-statistics-fourteen-governance-presets`.
Versionsquelle: `scripts/config/spec-kit-project-statistics-governance-presets.json`.
Installierte Integrationen: `agy`, `opencode`, `claude`, `copilot`, `codex`.
Der globale Flottenstandard bleibt unverändert. Installation allein ist kein
Security-, A11Y-, Feature- oder Feldabnahmenachweis.

*Use the explicit fourteen-preset project profile and its version matrix.
The five integrations are installed; the fleet default is unchanged.
Installation alone proves no security, accessibility, feature or field acceptance.*

```bash
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
bash scripts/render-project-statistics.sh --repo . --check-only
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
```

Produkt-Build- und Laufzeittests werden erst mit der technischen Entscheidung
definiert. Verfügbare Intake-Kommandos und nächste Schritte stehen in
`docs/Entwicklungsumgebung.md`.

*Product build and runtime tests await the technical decision. Available intake
commands and next steps are documented in the development environment guide.*

## Dokumentation, A11Y und Statistik / Documentation, A11Y and Statistics

`Programmierung #include<everyone>` ist verbindlich. WCAG 2.2 AA gilt soweit
anwendbar; Tastatur, Screenreader, Braille und Textbrowser berücksichtigen.
Fachliche Dokumentation, Lastenhefte und gemeinsame Guidance werden DE zuerst/
EN danach gepflegt, ungefähr CEFR B2. Die frühere Deutsch-Ausnahme ist durch den
Owner-Auftrag zur LH-00-Erstellung aufgehoben. Begriffe bei erster Verwendung
erklären; keine Spec-Kit-Kenntnisse voraussetzen. Historische Nachweise behalten
ihren damaligen Kontext. Offene Bestandsübersetzungen stehen mit Owner und
Fälligkeit in `docs/intake-governance.md`; Upstream-Templates bleiben unverändert.
Dokumentationsauswirkung und Leserpfade im selben PR erfassen; zentrale
Grundlage ist die Level-0-Dokumentations-Governance.

Statistikprofil 2 verwendet `docs/project-statistics.config.json` und den
Renderer; Ledger nach abgeschlossenen Arbeitspaketen fortschreiben, älteste
Einträge zuerst, `Gesamtstatistik` zuletzt. Referenzen: `80` konservativ und
vorläufig `100` Thorsten-Solo für Konzept/Scripting; bei C#/.NET auf `125`
reevaluieren. Git-Lieferdichte ist keine Zeitmessung oder Qualitätsbewertung.
ASCII-Diagramme maximal 100 Zeichen breit, mit exakten Zahlen und bilingualer
Textalternative. Das zusätzliche Statistik-Preset startet keine Messung.

*Design for keyboard, screen readers, Braille and text browsers, with WCAG 2.2
AA where applicable. Product documentation, intakes and shared guidance use
German first and English second at about CEFR B2. The owner-approved LH-00 work
replaces the earlier German-only exception. Explain terms on first use and do
not assume Spec Kit knowledge. Preserve historical evidence in its original
context. Outstanding translations have an owner and deadline in
`docs/intake-governance.md`; upstream templates remain unchanged.
Record documentation impact and reader paths in the same PR. Maintain the
Profile 2 ledger through its renderer, oldest entries first and overall
statistics last. References are 80 and provisionally 100 lines/day for concept
and scripting work; reevaluate to 125 if C#/.NET is selected. Git delivery
density is no time or quality measurement. ASCII charts need exact numbers,
bilingual alternatives and at most 100 columns. The extra statistics preset
starts no measurement.*

Diese Guidance ist identisch in `AGENTS.md`, `CLAUDE.md`, `GEMINI.md`,
`.github/copilot-instructions.md` und `.github/agents/copilot-instructions.md`.
Alle fünf Flächen bei Änderungen gemeinsam pflegen.

*Keep all five agent-guidance files identical when changing shared rules.*

## Lastenheft-Erstellung / Intake authoring

Verbindlich sind `.specify/memory/intake-authoring-policy.json`,
`.specify/memory/intake-authoring-profile.md` und die Zuordnung in
`docs/intake-governance.md`. Ein Intake ist ein fachliches Lastenheft;
ein Receipt ist der maschinenlesbare Herkunfts- und Hashnachweis.
`ReadyForReview` bedeutet nur bereit für ein gesondertes Review.
`docs/issue-drafts/` enthält historische Quellen der veröffentlichten Issues,
keine weiteren aktiven Lastenhefte. Aktuell ist genau `intakes/LH-00.md` beauftragt.
Der ursprüngliche Authoring-Auftrag war lokal begrenzt. Die danach ausdrücklich
beauftragten Reparatur-, Review- und Lieferaktionen stehen in
`docs/planning/lh00-repair-decisions.md`; aktueller Stand in Receipt und Reviewbericht.
Jede weitere Erstellung, Prüfung oder Lieferung benötigt passende ausdrückliche
Autorität. Folgeprompts sind Vorlagen für einen späteren Auftrag. Serienverwaltung
und Plattformabnahme sind Anforderungen von LH-00, nicht durch Erstellung erfüllt.

The policy, profile and governance mapping linked above are binding. An intake
is a requirements document; a receipt records its sources and content hashes.
`ReadyForReview` only means ready for a separate review. The issue-draft directory
contains historical sources for published issues, not additional active intakes.
Only `intakes/LH-00.md` is currently commissioned. Original authoring was limited
to local changes. Later explicitly authorized repair, review and delivery actions
are recorded in docs/planning/lh00-repair-decisions.md; the current receipt and
review report show the state. Further creation, review or delivery needs matching
explicit authority. Follow-up prompts are templates for a later request. Series
management and platform acceptance remain LH-00 requirements, not authoring results.
