# Collection und Serie / Collection and series

T037–T039 bereiten genau den festgelegten Vertrag vor: vier Rollen, sechs eindeutige
Pfade, SeriesManifest, eine echte Serien-ID, nur bestehendes LH-00 Primary/Eligible,
Ready, ein Root, keine Kanten. Keine LH-01–LH-07-Datei entsteht. Index enthält acht
Issues und markiert sieben fehlende Intakes. Temporär rekonstruierte Kandidaten
bestanden alle drei Collection-Kopien und Manifest/Receipt jeweils Bash/PowerShell.
Alle sieben Negativfälle (fehlende Datei, Hash, Ausbruch, Alias, Reihenfolge, Zyklus,
mehrere Eligible) wurden abgewiesen, Validatoren änderten keine Dateien.
Die archivierten Payloads haben .candidate-Endung; dadurch entsteht kein zweiter
aktiver Index im Repository. Tatsächliche Publikation T040 bleibt getrennt.

The exact four-role/six-path contract has one existing LH-00 member only, real
series identity, Ready/Eligible, one root and no edges. Seven future intakes stay
absent. All three collection copies and sequencing validators passed in both
shells; every negative case was rejected with zero writes. Retained inactive
.candidate payloads avoid a duplicate active index. T040 publication is separate.

[Ausgaben / Outputs](collection-results.json),
[genauer Vorschlag / exact proposal](../../../specs/001-lh00-intake-process/candidates/collection/proposal.json).

## T040: lokaler Ready-Bootstrap / Local Ready bootstrap

Der ausdrücklich beauftragte Vertragskandidat ist nach positiver T039-Prüfung
seriell lokal publiziert: echte Serie Ready, LH-00 Eligible, ein Root, null Kanten.
Alle drei Collection- und beide Sequencingvalidatoren bestehen Bash/PowerShell
auch am echten Bestand; das Completed-Migrationsjournal besteht beide Shells.
Completed bezeichnet nur den publizierten Migrationsvorgang, nicht LH-00/Serie.
B01-Ownerentscheid bleibt vor Active offen. Kein realer Active-/Completed-
Übergang, keine LH01/02-Piloten. T041 erneuert die Intake-/Reviewbindung nach
Migration vor jeder weiteren Gatebehauptung.

The commissioned candidate is locally published after T039 validation. All
paired validators pass on the actual Ready/Eligible bootstrap. Completed is
the migration journal state only, never intake/series completion. Owner B01
closure is still required before Active; T041 refreshes current evidence.

[Publikation und Journalprüfung / Publication evidence](collection-publication-results.json).

## Aktuelle lesende Auswahl T042 / Current read-only selection

Nach dem frischen unabhängigen T041-Ready wurde der tatsächliche Bestand lesend
geprüft. Alle drei Collection-Kopien, Manifest, Serienreceipt und Migrationsjournal
bestehen Bash/PowerShell. LH-00 ist das einzige Eligible-Mitglied der Ready-Serie;
ein Root, keine Abhängigkeiten und keine Reihenfolgeblocker. Aktive Intakes: 1,
Serienmitglieder: 1, eigenständige: 0. Archiv/Backlog/History enthalten fachlich
keine Lastenhefte; die Validatoren zählen jeweils ihre eine README-Datei.
Index und Reihenfolge führen LH-01/LH-02 als gesonderte Einzelpiloten und LH-03
nach vollständiger LH-00-Abnahme. Alle überprüften Bytes und Git-Status blieben
gleich. Die Auswahl startet keine Arbeit und erlaubt keinen Statuswechsel.
B-01-Owner-Entscheid, Statistikgates und Pilotfreigabe bleiben eigene offene Gates.

The actual read-only selection passed every paired validator after fresh Ready.
One eligible LH-00 member, one root, no edges or ordering blockers, no drift and
zero writes were observed. Domain counts differ explicitly from README file counts.
Future standalone pilots and full LH-00 acceptance retain their binding order.
Selection starts no work; human decisions and failed statistics gates remain open.

[Ausgaben und Vorher-/Nachherhashes / Outputs and before/after hashes](series-next-results.json).
Vorgeschlagener lesender Folgeaufruf / Suggested read-only command:
`$speckit-intake-series-status specs/intake-series/lh00-process/manifest.json`.
Der Folgeaufruf wurde nicht ausgeführt / The suggestion was not executed.
