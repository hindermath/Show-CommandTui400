# Drei Preset-Patches / Three preset patches

Stand / Date: 2026-10-10. Owner: Thorsten Hindermann.
Documentation Impact: `UpdateRequired`.

DE: Der genehmigte begrenzte Rollout uebernimmt Security v0.7.1, Architecture
v0.6.2 und Intake Sequencing v0.2.8 nach der zentralen Lieferung in
[Home Baseline PR #332](https://github.com/hindermath/home-baseline/pull/332),
Merge `224739c59311f5f0d64a3037135095288c0aa756`. Die Tag-Commits und
ZIP-Pruefsummen stehen im [Quellen-Lock](coordinated-governance-source-lock.json).
Nur diese drei Pakete werden neu installiert; Prioritaeten, die anderen elf
Presets und Statistikmethodik bleiben erhalten. Die Patches korrigieren
README-Installationsbefehle und Metadaten, nicht fachliche Runtime-Regeln.

EN: The authorized bounded rollout adopts Security v0.7.1, Architecture v0.6.2
and Intake Sequencing v0.2.8 after central delivery. The linked source lock
records immutable commits and archive hashes. Reinstall only these packages;
preserve priorities, the other eleven presets and statistics methodology.
These patches correct installation instructions and metadata, not runtime rules.

## Grenzen und Nachweise / Boundaries and evidence

DE: Kein Produktlauf und keine neue Produkt-, Risiko-, Pilot- oder Releasefreigabe.
Bestehende Intakes, Receipts und historische Nachweise werden nicht umgeschrieben.
Vor einem spaeteren Implementierungsstart sind Quellen-/Review-Frische,
Serienstatus, lokales Modell-Routing und Delivery-Autoritaet erneut zu pruefen.
Der Rollout ersetzt diese Gates nicht. NIST SSDF/CWE bleiben anwendbar auf die
Integration; kein neuer Web-/KI-Produkt- oder Cloud-Scope wird eingefuehrt.

EN: No product run or new product, risk, pilot or release acceptance. Preserve
existing intakes, receipts and historical evidence. Before a later implementation
start, recheck source/review freshness, series status, local model routing and
delivery authority. This rollout does not replace those gates or introduce a
new web, AI-product or cloud scope.

DE: Liefergates sind das exakte 14er-Profil in Bash/PowerShell, installierte
Pakettests, Preset-Auflistung/Info/Resolve, Secret-Scan, Homogeneity, bestehender
Statistik-Renderer und native PR-Checks. Tatsaechliche Ergebnisse, exakter Head,
Merge und main-Synchronisierung werden im Liefer-PR dokumentiert.

EN: Delivery gates cover the exact fourteen-preset profile in both shells,
installed tests, list/info/resolve, secret scan, homogeneity, existing statistics
renderer and native PR checks. Record actual results, exact head, merge and
main synchronization in the delivery PR, without claiming completion in advance.

Audience / Zielgruppe: Maintainer und Pilot-Reviewer.
Reader path / Leserpfad: Statistik-Ledger -> Bericht -> Quellen-Lock -> PR.
Canonical source: immutable preset tags and central matrices; owner: maintainer.
Class: technical integration evidence; DE first / EN second, text-readable.
Distribution: repository only; Home Runtime was handled separately in Level 0.
Reevaluation: source drift or next product-start preflight; no new methodology.
