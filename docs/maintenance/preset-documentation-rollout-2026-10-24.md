# Dokumentations-Pilotrollout / Documentation pilot rollout

Owner: Thorsten Hindermann. Datum / Date: 2026-10-24.
Ausgangscommit / Baseline: `3721aec0407ea978557d843df888433422a3fa1f`.
Level 0: `ded29751b58eece7711e80cf997a89b559812c93`.

## Auftrag und Leserpfad / Authority and reader path

DE: Beauftragt ist genau dieser Show-CommandTui400-Pilot der veröffentlichten
14er-Kohorte nach Level 0, in einem getrennten sauberen Worktree. Der PR bleibt
bis zur abgeschlossenen Level-0/Home-Runtime-Stufe und grünen technischen Checks
ungemergt. Der Nutzer hat MergeAndSync mit Admin-Bypass beauftragt und für diesen
begrenzten Rollout auf die erneute Einzel-Head-Sichtung verzichtet.
README → dieser Bericht → Quellen-/Installed-Lock → separater Assurance-Kontext
ist der Leserpfad für Lernende, Entwickelnde und Reviewer.

EN: This bounded Show-CommandTui400 pilot installs the published fourteen-package
cohort after Level 0 in a separate clean worktree. The PR remains unmerged until
completed Level-0/Home-Runtime delivery and green technical checks. The user
authorized MergeAndSync with admin bypass and waived repeated individual head
review for this bounded rollout. Read README, this report,
the source/installed locks and the separate assurance context in that order.

## Pakete und Agentenkomposition / Packages and agent composition

DE: Die [Projektmatrix](../../scripts/config/spec-kit-project-statistics-governance-presets.json)
ist die Versionsquelle. Der [Quellen-Lock](gsdb-344-preset-source-lock.json)
bindet veröffentlichte Tags, Commits und ZIP-Hashes. Der
[Installed-Lock](gsdb-344-preset-installed-lock.json) bindet die tatsächliche
Registry und alle installierten Paketdateien, nicht nur ein Versionsziel.
Die beiden bisherigen Locks sind bytegleich unter
`preset-documentation-rollout-2026-10-24-previous-*-lock.json` erhalten.
Keine Home-only-Runner-Overlays werden übernommen. GSDB 3.4.4 bleibt unverändert.

EN: The project matrix is the version source. The source lock binds published
tags, commits and ZIP hashes; the installed lock binds the real registry and
package payloads. Previous locks are preserved byte-for-byte in separate dated
files. No Home-only runner overlay is copied. GSDB 3.4.4 stays unchanged.

DE: Alte Agentenableitungen sind nicht übernehmbar: Show hat gegenüber der neuen
Kohorte geänderte Commands und Markdown-Templates. Das unveränderte SDK 0.12.8
komponiert mit `PresetResolver.resolve_content` aus dem vollständigen aktuellen
Presetstapel und dem lokalen Projekt-Core. `CommandRegistrar.register_commands`
schreibt daraus die fünf vorhandenen Integrationen. Alle sechs Wrapper für
Specify, Plan und Tasks müssen enthalten sein; `{CORE_TEMPLATE}` darf nicht
zurückbleiben. Die gemeinsame agy/codex-Skillfläche wird nur einmal versioniert.
Dies sind erzeugte Agentenflächen, kein Spec-Kit- oder Modelllauf.

EN: Old generated surfaces cannot be inherited because commands and Markdown
templates changed. The unchanged SDK composes the complete current preset stack
with the project core and registers the resulting content for the five existing
integrations. Specify, Plan and Tasks retain all six wrappers without a core
placeholder. agy/codex share one physical skill surface. This regenerates files;
it does not execute Spec Kit or call a model.

## Erhaltung und Nachweisgrenzen / Preservation and evidence limits

DE: LH-00/LH-01, Receipts, Reviews, Serien und Vorgängerarchive bleiben bytegleich.
Ihre gebundenen Guidance-, Constitution- und Matrixquellen ändern sich; alte
Ready-Aussagen sind deshalb keine aktuelle Herkunfts- oder Startfreigabe. Eine
spätere Fortsetzung verlangt separat beauftragte Aktualitätsprüfung und passende
Update-/Reviewautorität. Kein Intake-Lifecycle, LH-02, Produktimplementierung,
Modellaufruf, Toolchainwartung, Image-Rollout oder Home-Sync ist enthalten.

EN: Preserve LH-00/LH-01, receipts, reviews, series and archives byte-for-byte.
Their bound guidance, constitution and matrix inputs change, so previous Ready
statements do not establish current provenance or execution readiness. A later
continuation needs separately authorized freshness checks and update/review.
No intake lifecycle, product implementation, model call, toolchain maintenance,
image rollout or Home sync follows from this package integration.

DE: Der [neue technische Kontext](../security/secure-development/2026-10-24-show-commandtui400-documentation-rollout/evidence-matrix.md)
prüft Dokument-/Paketintegrität getrennt von menschlichen Entscheidungen. Alle
bisherigen menschlichen Entscheidungswerte bleiben unverändert; insbesondere
Produkt-, A11Y-, Rechts- und Zertifizierungsabnahme werden nicht abgeleitet.

EN: The new technical context separates document/package integrity from human
decisions. Existing human decision values remain unchanged. No product,
accessibility, legal or certification acceptance is inferred.

## Prüfungen und Documentation Impact / Checks and documentation impact

DE: Bestätigte lokale Befehle und Ergebnisse stehen in der technischen
[Prüfaufzeichnung](preset-documentation-rollout-2026-10-24-tests.json); native
CI bleibt an den exakten PR-Head gebunden. Ein grüner Teilnachweis gilt nur für
den ausgeführten Befehl und ersetzt keine physische A11Y-/Plattformabnahme.

EN: Actual local commands and results are recorded separately. Native CI binds
the exact PR head. A successful partial check proves its executed command only,
not physical accessibility or platform acceptance.

DE: `UpdateRequired`: aktuelle Guidance, Constitution, Matrix, Paketbindung und
dieser zweisprachige Leserpfad. `GeneratedUpdate`: einmaliger kanonischer
Statistiknachlauf, unveränderte Methodik und Konfiguration. Dokumentklasse:
aktive Projektdokumentation und technische Review-Evidence; Distribution
`sourceOnly`, kein Home-Sync. [Strukturierter Impact](preset-documentation-rollout-2026-10-24-impact.json).
Neubewertung bei Quellen-, Paket-, Prioritäts-, Scope- oder Autoritätsdrift.

EN: Current project guidance and package evidence require updates; statistics
are regenerated once with unchanged methodology/configuration. These bilingual
project and technical-review sources are source-only, with no Home sync.
Reevaluate on source, package, priority, scope or authority drift.
