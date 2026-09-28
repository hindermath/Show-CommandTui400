# LH-00-Reparatur und Validierung / LH-00 repair and validation

Stand / Date: 2026-09-28. Owner: Thorsten Hindermann.
Dokumentationsentscheidung / Documentation decision: **UpdateRequired**.

## Änderungen und Befugnis / Changes and authority

Der ausdrückliche Reparaturauftrag und die [Antworten IAD008/IAD009](planning/lh00-repair-decisions.md)
bestätigen Links zu Issues und Lastenheften sowie ein Review durch einen anderen
Prüfer als den Autor. LH-00 erklärt zusätzliche Begriffe in DE und EN. Aktuelle
Begleitdokumente unterscheiden historische Authoring-Beschränkungen von später
beauftragter Veröffentlichung, Reparatur, Review und Lieferung.

The explicit repair request and answers IAD008/IAD009 confirm links to both
issues and intakes and a reviewer other than the author. LH-00 explains further
terms in German and English. Current companion documents distinguish historical
authoring limits from later authorized publication, repair, review and delivery.

Die Intake-ID bleibt erhalten. Neues Receipt und neue Operation dokumentieren
die Reparatur; das neue Review ersetzt den archivierten Vorgänger ausdrücklich.
Fünf Guidance-Dateien sind identisch. Die Constitution-Kopien bleiben unverändert.
Die ursprünglichen Issue-Entwürfe, Entscheidungen, Authoring- und Reviewnachweise
sind historische Quellen. 15 Vorgängerdateien sind bytegenau archiviert.

Intake identity is preserved. A new receipt and operation record the repair;
the new review explicitly supersedes its archived predecessor. Five guidance
files match. Constitution copies remain unchanged. Original issue drafts,
decisions and authoring/review evidence remain historical sources. Fifteen
predecessor files are archived byte for byte.

## Unabhängiges Review / Independent review

**Ready**: ein Ziel, keine Worker, null offene Befunde, Fragen oder akzeptierte
Risiken. Ein vom Autor verschiedener Agent hat alle Reviewdimensionen geprüft.
IR001 (Begriffe), IR002 (DE/EN-Parität) und der dabei gefundene IR003
(Status-/Quellenkonsistenz) sind behoben. [Bericht](../specs/intake-review-report.md)
und [Ergebnis](../specs/intake-review-result.json) binden den Zielhash
`680baafd7534db9386f91a43cdbe3dbf260d6c0620c9f506c2be59ec3c826a65`.

Ready covers one target and zero workers, with no open findings, questions or
accepted risks. An agent distinct from the author reviewed all dimensions.
IR001 (terms), IR002 (bilingual parity) and IR003 (status/source consistency)
are resolved. Report and result bind the target hash above.

## Prüfungen / Checks

| Prüfung / Check | Ergebnis / Result |
|---|---|
| Receipt Bash + PowerShell | PASS; neun aktuelle Quellen / nine current sources |
| Vollständiges Review, Bash + PowerShell / Complete review | Ready; beide Validatoren PASS / both validators PASS |
| Manipulierte Zielkopie / Tampered target copy | Beide Validatoren lehnen mit Exit 2 und Hash-Drift ab / both reject with exit 2 and hash drift |
| Vorgänger und Identität / Predecessors and identity | 15 bytegleiche Archive, stabile Intake-ID / 15 byte-identical archives, stable intake identity |
| Guidance / Constitution | Fünf gleiche Guidance-Dateien, zwei gleiche Constitution-Kopien / five matching guidance files and two matching constitution copies |
| Presetmatrix / Preset matrix | 14/14 PASS |
| PowerShell-Analyse / PowerShell analysis | 72 Dateien, keine Fehler/Warnungen / 72 files, no errors or warnings |
| Homogenität / Homogeneity | Exit 0, 28/29; bekannter Hinweis zur ignorierten STATS.md / existing warning for ignored STATS.md |

Die exakte Liefermenge mit 36 Dateien besteht die Prüfung; vollständiger Secret-Scan:
keine hohen oder mittleren Befunde, keine Gitleaks-Treffer. Das abgeschlossene
Operation-Artefakt besteht Bash und PowerShell. Aktuelle Links und zusätzliche
Review-Hashbindungen sind gültig. Statistik wird nach dem Inhaltscommit auf
sauberem Baum generiert und gesondert committet; PR-Checks und exakter Head
werden vor dem Merge geprüft.

The exact delivery set of 36 files passes. The full secret scan reports no high
or medium findings and no Gitleaks detections. Both Bash and PowerShell accept
the completed operation artifact. Current links and extended review hash bindings
are valid. Statistics render on a clean tree after the content commit and receive
a separate commit; PR checks and the exact head are checked before merge.

Die archivierte `docs/Bedienkonzept.md` enthält ursprüngliche Markdown-Zeilenenden
mit Leerzeichen. Ihre bytegenaue Erhaltung ist durch Raw-SHA-256
`e41d0d035ad089f64e752d0a01558f744736a9514b394410123084010c12c30c`
gebunden. Nur dieser konkrete Archivpfad erhält beim Liefermengen-Validator die
Option `--allow-historical-whitespace`; aktuelle Inhalte erhalten keine Ausnahme.

The archived interaction concept retains original Markdown trailing whitespace.
Exact preservation is bound to the raw SHA-256 above. Only that exact archive
path receives the delivery validator's historical-whitespace allowance; current
content has no exception.

## Issue-Abgleich / Issue alignment

[Issue #1](https://github.com/hindermath/Show-CommandTui400/issues/1) wurde mit den
bestätigten FR-00-004-/AC-00-007-Aussagen aktualisiert und exakt zurückgelesen.
Titel, Status, Labels, Zuständigkeiten und Abhängigkeiten bleiben erhalten.
Der [Publikationsnachweis](issue-updates/issue-01-repair-publication.json) bindet
Vorher-/Nachher-Hashes, Zeitpunkte und die neue Quellfassung. Issues 2–8 wurden
bei dieser Reparatur nicht geändert.

Issue 1 was updated with the confirmed FR-00-004/AC-00-007 wording and read back
exactly. Title, state, labels, assignees and dependencies are preserved. Linked
publication evidence records before/after hashes, timestamps and the new source
body. This repair did not change issues 2–8.

## Grenzen und nächste Aktion / Boundaries and next action

Nach eigenem ausdrücklichem Auftrag den Specify-Folgeprompt in LH-00 ausführen.
Die Reparatur und das Review führen diesen Folgeschritt nicht aus.

On a separate explicit request, run the Specify follow-up prompt in LH-00.
Repair and review do not execute that next step.

Prozessabnahme, Collection-/Serienkonfiguration, Bestandsübersetzungen, zentraler
Registerpatch und Plattform-/A11Y-Nachweise bleiben offen gemäß LH-00 und
Governance-Zuordnung. Diese Lieferung implementiert kein Produkt und startet
keinen autonomen Lauf. Admin-Bypass betrifft ausschließlich die formale
Mergefreigabe nach erfolgreichen technischen Checks; er akzeptiert keine Risiken.

Process acceptance, collection/series configuration, existing-document translations,
central registry alignment and platform/accessibility evidence remain open as
specified in LH-00 and the governance mapping. This delivery implements no
product and starts no autonomous run. Admin bypass applies only to formal merge
approval after successful technical checks; it accepts no risks.

Leserpfad / Reader path: README → [LH-00](../intakes/LH-00.md) →
[Reviewbericht](../specs/intake-review-report.md) → dieser Nachweis / this evidence.
DE/EN in derselben Datei; versionierte Level-2-Quelle, keine Home-Runtime-Verteilung.
Re-Evaluation bei Quellen-, Policy-, Zielhash- oder Auftragsänderung.

German and English share this file. It is versioned Level-2 source, with no
Home Runtime deployment. Reevaluate when sources, policy, target hash or authority change.
