# Registrierung / Registration

## Lokaler Registrierungsabschluss 2026-10-03 / Local registration closeout

Der Klon auf diesem Mac ist eingerichtet: `~/RiderProjects/Show-CommandTui400`,
`origin` = `https://github.com/hindermath/Show-CommandTui400.git`, Default `main`.
Vorher waren die lokalen Level-0-/Level-1-Checkouts veraltet; Fast-forward aus
`origin/main` hat die bereits veröffentlichten Aufnahme-Einträge übernommen.
Workspace-Ignore und Projektlink sind vorhanden; der Klon ist kein Gitlink.
Die private operative Registry enthält genau einen Eintrag, Level 2,
`primaryLanguage=unknown`, `mslStatus=unknown`, `gsdbRequired=true`, Rolle
`level-2-project`, Quelle `manual-registration`, explizites 14-Preset-Profil.
Der globale Registry-Default bleibt unverändert. Absolute Rechnerpfade und
Registry-Dateien werden nicht veröffentlicht.

*This Mac now has the independent clone with the expected origin and main
branch. Fast-forwarding stale Level-0/1 checkouts recovered existing published
onboarding entries. The workspace ignores and links the project, with no Gitlink.
The private operational registry has one Level-2 entry with unknown primary
language/MSL, GSDB required and the explicit fourteen-preset profile. Its global
default is unchanged; machine paths and registry contents stay private.*

Beide Constitution-Kopien auf Level 0, 1 und 2 verwenden dieselbe Projektzeile.
Die pauschale C#-/MSL-Zuordnung aller RiderProjects-Einträge ist korrigiert.
Die zentrale Dokumentationszelle folgt der bereits beschlossenen DE/EN-Regel
im Produkt: CEFR B2, Begriffe erklären, WCAG 2.2 AA soweit anwendbar.
Gemeinsame neue Hinweise werden auf Level 0/1 in allen fünf Agentenflächen
gepflegt; die identische Level-2-Guidance enthält diese Aussage bereits.
PR-Lieferung bedeutet noch keine Übernahme in die geschützten Main-Branches.

*The three levels use the same project row in both constitution copies.
Workspace membership no longer implies C# or a known MSL. The central row
matches existing bilingual product policy. All five Level-0/1 guidance surfaces
receive the same clarification; Level-2 guidance already records it. PR delivery
is pending review and does not mean the protected main branches have merged.*

Prüfungen auf macOS: Registry-Vorschau und Wiederholbarkeit, Git-Ignore/Index,
Constitution-Parität, fünf identische Produkt-Guidance-Dateien, Hooks und
Secret-Scanning, exakte lokale 14-Preset-Matrix, Agentenoberflächen-Parität,
Statistikrenderer und statische PowerShell-Analyse. Konkrete Resultate werden
im PR festgehalten. Produkt-Laufzeittests sind noch nicht definiert; aus diesen
Prüfungen folgt kein nativer Windows-/Linux- oder Produktabnahmenachweis.

*Local macOS validation covers registration, ignore/index, matching constitution
copies, identical product guidance, hooks, secrets, the installed fourteen-preset
matrix, agent surface parity, statistics rendering and PowerShell analysis.
The PR records actual outcomes. These checks do not prove product acceptance
or native Windows/Linux operation.*

Die gezielte Level-0-Propagation meldet **21 bestehende Abweichungen** und
bleibt als Drift-Nachweis offen. Die Vorschau wurde geprüft, kein Schreiblauf
ausgeführt. Sie würde auch sieben Preset-Matrizen und Governance-Templates
ersetzen. Das wäre ein Versionsrollout über die reine Registrierung hinaus;
das installierte Produktprofil entspricht exakt seiner eigenen gepinnten Matrix.
Owner: Thorsten. Wiedervorlage bei dem bereits geplanten Governance-Pilotrollout,
spätestens 2026-10-12; kein Erinnerungsauftrag. Risiko: neuere Wartungs- und
Governance-Dateien stehen bis zur abgestimmten Übernahme nicht im Produktklon
bereit. Kein erfolgreicher flottenweiter Drift-Check wird behauptet.

*Targeted propagation reports 21 pre-existing differences. Its preview includes
seven preset matrices and governance templates, so no writing propagation was
performed during registration. The installed product profile exactly matches
its own pinned matrix. Thorsten owns reassessment with the planned governance
pilot rollout, by 2026-10-12; no reminder is scheduled. Newer maintenance and
governance files remain unavailable in this clone until coordinated adoption.
The propagation drift check is explicitly not a pass.*

Dokumentationsauswirkung: **UpdateRequired**. Owner: Thorsten. Zielgruppen:
Maintainer und Agenten; Leserpfad Workspace-README → Produkt-README →
Entwicklungsumgebung und Projektregister. Kanonische Quellen: Level-0-Register,
Level-1-Projektzusammensetzung und Level-2-Produktwahrheit. Dokumentklasse:
Governance/Navigation/Einrichtungsnachweis; DE/EN in denselben Dateien.
Constitution und gemeinsame Guidance auf Level 0: `homeRuntime`; diese Evidence:
`sourceOnly`; operative Registry und `STATS.md`: lokal. Home-Sync nach Vorschau,
ohne Pull/Commit; keine Constitution-Verteilung an unbeteiligte Repositories.
Re-Evaluation bei Runtime-/MSL-Entscheidung, Umzug, Profilwechsel oder PR-Merge.

*Documentation impact: UpdateRequired; owner Thorsten. Maintainers and agents
follow workspace → product → environment/registry. Level 0 owns shared registry,
Level 1 owns membership and Level 2 owns product truth. This bilingual governance,
navigation and setup evidence is source-only; Level-0 constitution/guidance are
homeRuntime, while registry and STATS.md remain local. Preview home sync and
perform it without pull/commit. Reevaluate after runtime/MSL decisions, moves,
profile changes or PR merges.*

### Gebundene lokale Resultate / Recorded local results

- Registry-Dry-Run nach Eintragung: `unchanged`; genau ein passender Datensatz.
- Workspace: `git check-ignore Show-CommandTui400/` erfolgreich; `git ls-files Show-CommandTui400` leer.
- Strukturprüfung: sechs Constitution-Kopien paarweise identisch; eine identische Projektzeile auf allen drei Ebenen; fünf Produkt-Guidance-Dateien identisch; neuer Hinweis auf allen zehn Level-0/1-Flächen vorhanden.
- Lokale Projektmatrix: 14 Presets exakt passend (`--check-only`, Exit 0).
- Agentenoberflächen-Parität: drei Tests bestanden (`python3 -m unittest discover -s scripts/tests -p test_spec_kit_agent_surface_parity.py`, Exit 0).
- PSScriptAnalyzer 1.25.0: 72 repository-eigene Dateien, keine Error-/Warning-Befunde (Exit 0).
- Secret-Scans auf Level 0 und im Produkt: keine High-Befunde (Exit 0). Der rekursive Workspace-Scan meldet zwei bestehende lokale Agenten-/Vendor-Dateihinweise außerhalb dieses Produkts (Exit 2); das ist kein grüner Workspace-Scan. Diese Dateien werden nicht veröffentlicht; die zu pushenden Änderungen werden zusätzlich vom Pre-Push-Hook geprüft.
- Hook: versionierter Pre-Push-Hook in der lokalen `.git/hooks/` installiert.
- Home-Sync: Syntaxcheck und Check/Vorschau vor dem Lauf; `--no-pull --no-commit` erfolgreich; abschließender Check Exit 0, kein Force.
- Propagation: Check meldet 21 Abweichungen (Exit 1); Vorschau durchgeführt, keine Anwendung oder Preset-Versionsänderung. Diese Grenze bleibt ausdrücklich offen.

*Actual local results: registration is idempotent; the nested repository is
ignored and absent from the parent index; constitution/guidance structure is
consistent. Fourteen installed presets match; all three agent-parity tests and
analysis of 72 PowerShell files pass. Level-0/product secret scans find no high-risk result; the recursive workspace scan reports two pre-existing local agent/vendor findings outside this product (exit 2), so it is not a pass;
local hooks are installed. Previewed home sync and the final drift check pass.
Propagation still reports 21 pre-existing differences and is not represented
as successful maintenance. Statistics and whitespace are checked again on the
delivery commits; hosted CI outcomes are separate evidence.*
