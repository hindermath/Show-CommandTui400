# Issue-Veröffentlichung und Lieferung / Issue publication and delivery

Stand / Date: 2026-09-28. Owner: Thorsten Hindermann.
Dokumentationsentscheidung / Documentation decision: **UpdateRequired**.

## Auftrag und Ergebnis / Authority and result

Der Owner hat die acht Issue-Entwürfe genehmigt und deren Veröffentlichung mit
`DeliveryMode MergeAndSync` und Admin-Bypass beauftragt. Danach folgt ausdrücklich
`$speckit-intake-review intakes/LH-00.md`. Dieser Auftrag erweitert die frühere
Beschränkung auf lokale Erstellung um Commit, Push, PR, Merge, Synchronisation
und das benannte Review. Er startet keine Produktimplementierung und überträgt
keine Änderungen in das zentrale Home-Baseline-Repository.

The owner approved publication of all eight issue drafts with MergeAndSync and
admin bypass, followed by the named LH-00 intake review. This request extends
the earlier local-only authoring authority to commit, push, PR, merge, sync and
that review. It starts no product implementation and changes no central Home
Baseline repository.

Alle acht GitHub-Issues wurden aktualisiert und einzeln erneut gelesen.
Titel und Body entsprechen den vorbereiteten Veröffentlichungstexten; Status,
Labels, Zuständigkeiten und Abhängigkeiten wurden nicht geändert. Der
[maschinenlesbare Nachweis](issue-publication.json) bindet ursprüngliche und
veröffentlichte Texte durch SHA-256 sowie Zeitpunkte und Quellenpfade.

All eight GitHub issues were updated and read back individually. Titles and
bodies match the prepared publication text. State, labels, assignees and
dependencies were not changed. The linked evidence binds original and published
text through SHA-256 hashes, timestamps and source paths.

| Issue | Lastenheft / Intake | Ergebnis / Result |
|---|---|---|
| [#1](https://github.com/hindermath/Show-CommandTui400/issues/1) | LH-00 | Veröffentlicht und geprüft / Published and verified |
| [#2](https://github.com/hindermath/Show-CommandTui400/issues/2) | LH-01 | Veröffentlicht und geprüft / Published and verified |
| [#3](https://github.com/hindermath/Show-CommandTui400/issues/3) | LH-02 | Veröffentlicht und geprüft / Published and verified |
| [#4](https://github.com/hindermath/Show-CommandTui400/issues/4) | LH-03 | Veröffentlicht und geprüft / Published and verified |
| [#5](https://github.com/hindermath/Show-CommandTui400/issues/5) | LH-04 | Veröffentlicht und geprüft / Published and verified |
| [#6](https://github.com/hindermath/Show-CommandTui400/issues/6) | LH-05 | Veröffentlicht und geprüft / Published and verified |
| [#7](https://github.com/hindermath/Show-CommandTui400/issues/7) | LH-06 | Veröffentlicht und geprüft / Published and verified |
| [#8](https://github.com/hindermath/Show-CommandTui400/issues/8) | LH-07 | Veröffentlicht und geprüft / Published and verified |

## Quellenbindung und Sprachpflege / Source binding and language maintenance

Die acht Dateien unter `docs/issue-drafts/` bleiben historische, genehmigte
Entwurfssnapshots. Die Veröffentlichung ersetzt ihre lokalen Statushinweise,
verwendet vollständige GitHub-Dateilinks und aktualisiert die zugehörige
Veröffentlichungscheckliste. Anforderungen, IDs und Abhängigkeiten bleiben
inhaltlich erhalten. Die absoluten Links zeigen auf den mit dieser Lieferung
bereitgestellten Stand von `main`.

The eight draft files remain historical approved snapshots. Publication replaces
local status notices, uses absolute GitHub file links and updates the publication
checklist. Requirement meaning, identifiers and dependencies are preserved.
Absolute file links point to main as supplied by this delivery.

LH-00, sein Authoring-Receipt und dessen gebundene Quellen werden nicht heimlich
neu gehasht. Der öffentliche Issue-1-Snapshot im Receipt beschreibt den früheren
Abruf, nicht den heute geänderten GitHub-Body. Der Hashvergleich der neuen
Veröffentlichung steht separat oben. Frühere Aussagen wie „keine Commits“ oder
„Review noch nicht ausgeführt“ sind Aussagen des damaligen Authoring-Auftrags;
der aktuelle Auftrag und das nachfolgende Review werden getrennt nachgewiesen.

LH-00, its authoring receipt and bound source files are not silently rehashed.
The receipt's public issue-1 snapshot records the earlier fetch, not today's
updated GitHub body. The new publication has its own hash evidence above.
Earlier statements about no commits or no completed review describe the original
authoring task; current authority and the later review have separate evidence.

## Prüfungen und Grenzen / Checks and boundaries

Die bestehenden lokalen Authoring-Prüfungen stehen im
[historischen Validierungsbericht](lh00-validation.md). Für die Lieferung werden
die exakte gestagte Dateimenge und die Quellenbindung erneut geprüft. Nach dem
Inhaltscommit wird die Statistik regulär gerendert und gesondert committet.
Vor dem Merge werden der genaue PR-Head, technische Checks und Reviewbefunde
geprüft. Admin-Bypass betrifft die formale Reviewfreigabe; technische Fehler
werden dadurch nicht zu bestandenen Prüfungen.

Existing local authoring checks are recorded in the historical validation report.
Delivery revalidates the exact staged file set and source binding. Statistics
are rendered normally after the content commit and committed separately. The
exact PR head, technical checks and review findings are checked before merge.
Admin bypass handles formal review approval; it does not make technical failures
pass.

Die ignorierte maschinelokale `STATS.md` bleibt unverändert. Ihr bestehender
Homogenitätshinweis ist kein Produktfehler. Die zentrale Registeränderung bleibt
ein Patchvorschlag; Bestandsübersetzungen sowie Plattform- und assistive
Prozessnachweise bleiben in LH-00 als noch zu erfüllende Anforderungen erhalten.

The ignored machine-local STATS.md remains unchanged. Its existing homogeneity
warning is not a product defect. Central registry alignment remains a patch
proposal. Existing-document translations, platform evidence and assistive process
checks remain outstanding LH-00 requirements.
