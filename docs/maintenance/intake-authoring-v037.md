# Authoring v0.3.7: Pilotlieferung / Pilot delivery

Stand / Date: 2026-10-05. Owner: Thorsten Hindermann.
Documentation Impact: `UpdateRequired`.

DE: Genehmigter Scope ist ausschliesslich die technische Uebernahme des stabilen
Authoring-Patches v0.3.7 und der zugehoerigen zentralen Quellenbindung.
MergeAndSync mit Admin-Bypass darf nur nach erfolgreichen technischen Checks
erfolgen. Konzeptphase, LH-00, vorhandene Receipts und menschliche Entscheidungen
bleiben unveraendert; diese Installation startet keine Produktimplementierung.

EN: Adopt only the stable Authoring patch and central source bindings. Admin
delivery requires successful technical checks. Preserve concept-stage scope,
LH-00, historical receipts and human decisions; no implementation is started.

## Herkunft und Pruefgrenzen / Provenance and proof boundaries

- [Source release v0.3.7](https://github.com/hindermath/spec-kit-preset-intake-authoring-governance/releases/tag/v0.3.7).
- Tag commit: `dbf135e89ba583fb27294f84e487cf1a5826604f`.
- Tag-ZIP SHA-256: `fc20a010c2124977249f926677d1bb2b03b81e7cd2a549bc4c7489de837e1427`.
- [Level-0 integration PR #326](https://github.com/hindermath/home-baseline/pull/326).
- Priority 64; full profile has fourteen enabled presets. Other thirteen
  package directories and registry entries retain their contents and versions.

DE: Nur Authoring neu installiert. Fuenf zentrale Matrizen und fuenf gemeinsame
Vorlagen ueber den kanonischen Propagator uebernommen; beide Constitutions und
alle fuenf identischen Guidance-Flaechen aktualisiert. Das Patch korrigiert den
einzeiligen README-Befehl und akzeptiert historische v0.3.6-Receipts ohne diese
umzuschreiben. Historische Berichte behalten ihren damaligen Versionsstand.

EN: Reinstall only Authoring; propagate five matrices and five shared templates.
Align both constitutions and all five identical guidance files. The patch fixes
the one-line README install command and preserves historical v0.3.6 receipts.
Historical records retain their original release context.

DE: LH-00 bindet unter anderem AGENTS.md, Constitution und die beiden aktuellen
Umgebungs-/Governance-Guides als Quellen. Diese Quellen aendern sich durch den
Patch. Das bisherige Receipt/Ready-Review bleibt historisch erhalten, ist aber
kein frischer Implementierungsstart-Nachweis mehr. Vor einem Produktlauf sind
ein separat beauftragtes Intake-Update und erneutes unabhaengiges Review noetig;
diese Lieferung schreibt keine Receipt-Hashes stillschweigend um.

EN: LH-00 binds guidance, constitution and current environment/governance guides.
This patch changes those sources. Preserve the existing receipt/Ready review
as historical evidence, not fresh implementation-start authority. A separately
authorized intake update and independent re-review are required before a run;
this delivery does not silently rewrite receipt hashes.

Pruefung / Checks: full matrix in Bash and PowerShell, installed template/README
test, secret scan, homogeneity and reproducible legacy statistics; native setup
CI on Linux/macOS/Windows, PSScriptAnalyzer and Maintenance TUI before merge.
No product build exists yet; language/framework/platform acceptance remain open.
Exact head, CI and merge evidence are attached to the delivery PR at closeout.

Zielgruppe / Audience: maintainers and pilot reviewers.
Leserpfad / Reader path: current environment guide -> this integration record ->
source lock and delivery PR. Canonical source: immutable preset tag, central
matrices and project provenance lock. Class: technical integration evidence.
Language: inline DE-first/EN-second. Distribution: repository only, no home sync.
Re-Evaluation: next package patch or fresh product-start preflight. Existing
statistics retain methodology; Git activity does not prove AI productivity.
