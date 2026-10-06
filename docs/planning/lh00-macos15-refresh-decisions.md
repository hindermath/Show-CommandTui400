# LH-00: Quellenaktualisierung nach Runnerwechsel / Source refresh after runner migration

Stand / Date: 2026-10-06. Owner: Thorsten Hindermann. Entscheidung / Decision: IAD013.
Basis / Base: `0c944508bf0cc1d91eda5cffb278a34b1c48c704`.
Änderungen / Changes: [PR #29](https://github.com/hindermath/Show-CommandTui400/pull/29),
[PR #30](https://github.com/hindermath/Show-CommandTui400/pull/30).

## Auftrag und Grenzen / Authority and boundaries

Der Owner beauftragte ausdrücklich den Plan „LH-00 nach den GitHub-Actions-Änderungen
aktualisieren“: Quellenbewertung, gewöhnliches Intake-Update, vollständiges Review durch
einen separaten Agenten, gezielten technischen Abgleich, Analyze, Startchecks und
Nachweislieferung per MergeAndSync mit Admin-Bypass. IAD009 gilt: Der Hauptagent
ist Autor; ein anderer Agent prüft. Die Lieferbefugnis umfasst dieses Vorbereitungspaket,
Commit/Push/PR, erfolgreiche technische Checks am endgültigen Head, gebundenen Merge
und lokalen main-Sync. Sie startet keine Implementierung, reale Serienaktivierung,
LH-01-/LH-02-Piloten, Releases, Neuinstallation, Routing-Refresh oder Flotten-Rollout.

The owner explicitly commissioned the plan “Refresh LH-00 after GitHub Actions changes”:
source assessment, ordinary intake update, complete separate-agent review, targeted
technical reconciliation, Analyze, start checks and evidence delivery through
MergeAndSync with admin bypass. Under IAD009 the main agent authors and another agent
reviews. Delivery includes commit/push/PR, successful final-head technical checks,
head-bound merge and local main sync. It starts no implementation, live series,
LH-01/LH-02 pilot, release, reinstall, routing refresh or fleet rollout.

## Erklärte Abweichung und Auswirkungen / Explained drift and impact

PR #29 ersetzte macos-14 durch macos-15 in drei Workflows und ergänzte die fünf
identischen Guidance-Flächen. AGENTS.md ist die einzige veränderte gebundene Quelle
im bisherigen Receipt; dessen Validator meldet Quellenabweichung. Der alte Review-
Validator prüft weiterhin erfolgreich die unveränderten Zielbytes, doch die damalige
Ready-Aussage ist wegen der veralteten Quellenbindung kein aktueller Startnachweis.
PR #30 korrigierte die Metadaten zur bestehenden generierten Statistik: keine neue
Navigation. Zielhash und Intake-ID stimmen mit dem Vorgänger überein; bisherige
Update-Vorgänge sind abgeschlossen. Die Abweichung ist erklärt.

PR #29 replaced macos-14 with macos-15 in three workflows and appended matching rules
to all five guidance files. AGENTS.md is the only changed bound source in the old
receipt, whose validator reports drift. The old review validator still accepts the
unchanged target bytes, but stale source bindings invalidate present readiness.
PR #30 corrected existing generated-statistics metadata without adding navigation.
Target hash and intake identity match the predecessor; earlier update operations
are complete. This source drift is explained.

Setup-Validierung nutzt hier Ubuntu 22.04, macOS 15 und Windows 2022. PowerShell-
Analyse und Maintenance TUI bleiben für dieses Repository Linux-only; deren bedingte
Mac-/Windows-Matrix gilt weiterhin nur für die benannten Referenz-Repositories.
Nicht ausgeführte Jobs sind kein Nachweis. Der Runnerwechsel bestimmt weder eine
Produkt-Mindestversion noch eine der vier späteren Abnahmeumgebungen.

Setup validation here uses Ubuntu 22.04, macOS 15 and Windows 2022. PowerShell
analysis and Maintenance TUI remain Linux-only in this repository; their conditional
Mac/Windows matrix still applies only to named reference repositories. Unexecuted
jobs prove nothing. Runner migration selects neither a product minimum version nor
one of the four later acceptance environments.

## Umfang, Herkunft und Quellenreihenfolge / Scope, provenance and source order

Zwölf FR-00 und neun AC-00 je Sprache bleiben bytegleich. Intake-ID und IAD010s
Pilotweg bleiben erhalten: benannter primärer Mac, eigene LH-01- und danach LH-02-
Aufträge mit Reviews, volle Prozessabnahme nach LH-02 vor LH-03. Alle 65 Tasks bleiben
offen. Keine neue Anforderung, API, Schema oder Statusmodell. Neue Receipt-/Vorgangs-
IDs und bytegleiche Vorgängerarchive sichern die Herkunft. Das alte Review wird
explizit abgelöst. Historische Quellenbytes bleiben mit ihrem Kontext erhalten.

Keep twelve FR-00 and nine AC-00 lines per language byte-identical. Preserve intake
identity and IAD010: named primary Mac, separate LH-01 then LH-02 requests/reviews,
full process acceptance after LH-02 before LH-03. All sixty-five tasks stay open.
No new requirement, API, schema or status model. New receipt/operation IDs and exact
predecessor archives preserve lineage. Explicitly supersede the old review and
retain historical source bytes in context.

Der Vorgängerintake ist die erste verbindliche Quelle, danach diese Entscheidung,
die bisherigen aktuellen Quellen und die Runner-/Workflow-Nachweise. Quellenreihenfolge
allein entscheidet keinen Konflikt. Explizite Reihenfolge / explicit source order:

1. `specs/intake-authoring-archive/lh-00/c515439e-cd09-4e44-8fe2-ac6135e21e3f/intakes/LH-00.md`
2. `docs/planning/lh00-macos15-refresh-decisions.md`
3. `docs/planning/lh00-v037-refresh-decisions.md`
4. `docs/intake-governance.md`
5. `docs/Entwicklungsumgebung.md`
6. `.specify/memory/intake-authoring-profile.md`
7. `docs/Lastenheft-Plan.md`
8. `docs/Bedienkonzept.md`
9. `constitution.md`
10. `AGENTS.md`
11. `scripts/config/spec-kit-project-statistics-governance-presets.json`
12. `docs/maintenance/coordinated-governance-source-lock.json`
13. `docs/maintenance/coordinated-governance-oct03.md`
14. `docs/security/README.md`
15. `docs/maintenance/assurance-v013-stable-publication.md`
16. `docs/maintenance/intake-authoring-v037.md`
17. `docs/maintenance/macos-runner-migration.md`
18. `docs/maintenance/macos-runner-documentation-impact.json`
19. `.github/workflows/homogeneity-check.yml`
20. `.github/workflows/powershell-analysis.yml`
21. `.github/workflows/maintenance-tui.yml`

## Prüfung und Dokumentationsauswirkung / Checks and documentation impact

Beide Receipt- und Review-Validatoren in Bash und PowerShell, rekursive Hashprüfung,
anderes vollständiges Review, gezieltes Analyze, Routing-Status, 14-Preset-Matrix,
Werkzeuge, Secret-/Homogenitäts-/Statistik-/Diff-Prüfung folgen vor Lieferung.
Quellen zuerst committen, Statistik aus sauberem Arbeitsbaum vorschauen und rendern,
prüfen und separat committen. Admin-Bypass ersetzt keine technische Prüfung.
Ready zeigt nur fachliche Intake-Reife; ein eigener Implementierungsauftrag bleibt nötig.

Run receipt and review validators in both shells, recursive hash checks, complete
independent review, targeted Analyze, routing status, preset matrix/tool checks and
secret/homogeneity/statistics/diff checks before delivery. Commit source first,
preview/render statistics on a clean tree, validate and commit generated output
separately. Admin bypass replaces no technical gate. Ready shows semantic intake
readiness only; implementation still needs its own request.

UpdateRequired; sourceOnly; Owner Thorsten; DE zuerst/EN danach, etwa CEFR B2.
Leserpfad: LH-00 → IAD013 → Receipt/Review → Spec/Plan/Tasks → Aufgabenvalidierung.
Wiedervorlage: Quellen-, Policy-, Scope- oder Auftragsänderung und Implementierungsstart.

UpdateRequired; sourceOnly; owner Thorsten; German first, English second, about B2.
Reader path: intake → IAD013 → receipt/review → design/tasks → task validation.
Reassess source, policy, scope or authority changes and before implementation.
