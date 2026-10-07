# Nachweisgeneration nach Quellenupdate / Evidence generation after source update

Stand / Date: 2026-10-07, IAD019. Die T045-Ownerfreigabe bleibt erhalten;
keine volle LH-00-Abnahme. Die nachfolgenden Mac-/Hashprüfungen dokumentieren
unverändert den Stand vor diesem Quellenupdate, Git `9e3c638`.
Aktuelle Herkunftsbindungen und das neue andere Review stehen in
[Receipt](../../../specs/intake-authoring-receipts/lh-00.json) und
[Review](../../../specs/intake-review-result.json). Historische Rohhashes werden
nach gewöhnlicher Supersession nicht als aktuelle aktive Dateihashes ausgegeben.

Limited T045 permission remains; no full acceptance. The unchanged assessment
below records the pre-refresh Git state. The linked successor receipt and distinct
review provide current provenance. Historical raw hashes refer to predecessor
bytes, not newly superseded active files.

---

# LH-00: begrenzte Pilotfreigabe / Limited pilot permission

## Aktueller Owner-Entscheid, 2026-10-07 / Current owner decision

### DE

**Thorsten Hindermann erteilt die begrenzte Pilotfreigabe gemäß T045.
Abnahmeergebnis: `ReadyForPilot`. T045 ist abgeschlossen.**

Auftrag: „Ich erteile die begrenzte Pilotfreigabe gemäß T045. Bitte dokumentieren
und T045 abschließen.“ Die Freigabe gilt dem unabhängig geprüften isolierten
LH-00-Kernprozess auf Mac A, MacBook Air M2 (2023).
Der [Owner-Entscheid](pilot-owner-decision.json) verbindet diesen Auftrag mit der
unabhängigen Bewertung `3d780c5d-66f5-456f-b78d-4d6a6159346c`, dem
[B-01-Abschluss](b01-owner-decision.json) und den bestandenen
[Lieferprüfungen](delivery-gate-results.json) aus
[PR #32](https://github.com/hindermath/Show-CommandTui400/pull/32).
Heute erneut geprüft: alle 30 Mac-Payload-Rohhashes und 101 aktuelle
Receipt-/Request-/Review-Bindungen stimmen; das unabhängige Intake-Review bleibt
`Ready`, ohne offene Befunde oder Risikoannahmen. Die vorhandenen technischen
Nachweise werden wiederverwendet; eine neue Plattformprüfung wurde nicht ausgeführt.

LH-01 und anschließend LH-02 dürfen als jeweils gesondert beauftragte Einzelpiloten
vorbereitet und durchgeführt werden. Beide brauchen einen eigenen Auftrag,
ein gültiges Intake und unabhängiges Review. LH-02 setzt den fachlichen Abschluss
von LH-01 voraus. Diese Dokumentation startet keinen Pilot und ändert keinen
realen Serienstatus. `ReadyForPilot` bezeichnet nur dieses Abnahmeergebnis.

**Die vollständige LH-00-Abnahme bleibt offen:** nach LH-02, vor LH-03,
mit Nachweisen auf Mac A, Mac B, Windows 11 und Ubuntu/WSL2 sowie praktischer
Barrierefreiheit, Übersetzungen und angewendeter Registerausrichtung.
T046–T065 bleiben offen; LH-00 wird nicht als `Completed` archiviert.

### EN

**Thorsten Hindermann grants limited pilot permission under T045.
Acceptance outcome: `ReadyForPilot`. T045 is complete.**

The explicit owner request grants permission for the independently reviewed,
isolated LH-00 core process on Mac A, MacBook Air M2 (2023). The linked owner
record binds this decision to the separate assessment, B-01 owner acceptance
and passed delivery checks in PR #32. Today's read-only verification confirms
all 30 raw Mac payload hashes and 101 current receipt/request/review bindings.
The independent intake review remains `Ready`, with no findings or accepted risks.
Existing technical proof is reused; no new platform test was performed.

LH-01, then LH-02 may proceed as separately commissioned individual pilots.
Each needs its own request, a valid intake and independent review. LH-02 requires
domain completion of LH-01. This documentation starts no pilot and changes no
real series state. `ReadyForPilot` describes this acceptance outcome only.

**Full LH-00 acceptance remains open:** after LH-02 and before LH-03, with Mac A,
Mac B, Windows 11 and Ubuntu/WSL2 evidence, practical accessibility, translations
and applied registry alignment. T046–T065 stay open; LH-00 is not archived as
`Completed`.

## Historische unabhängige Bewertung vom 2026-10-06 / Historical independent assessment

Die ursprüngliche Bewertung folgt bytegleich. Ihre Pending-/Failed-Aussagen
beschreiben ausschließlich den damaligen Stand. Der obige Entscheid und die
spätere Lieferung ergänzen ihn; historische Prüfungen werden nicht umgedeutet.
[Unveränderter Git-Vorgänger](https://github.com/hindermath/Show-CommandTui400/blob/5da877fde456899f80863f4cac256422a4db6aed/docs/validation/lh00/acceptance.md).

The original assessment follows byte for byte. Its pending/failed statements
apply only to its recorded date. The decision above and later delivery supplement
that state without rewriting historical checks. The linked Git predecessor
preserves the original reviewed bytes.

---

# LH-00: begrenzte Mac-Pilotbewertung / Limited Mac pilot assessment

Stand / Date: 2026-10-06T19:33:49.774574+00:00.  
Owner: Thorsten Hindermann. Autor / Author: Codex `/root`.  
Anderer Prüfer / Distinct reviewer: `/root/lh00_inc2_b01_review`.  
Assessment-ID: `3d780c5d-66f5-456f-b78d-4d6a6159346c`. Aufgabe / Task: unabhängiger Teil von T045.

## DE

**Der isolierte technische Mac-A-Kernprozess ist als Teilnachweis bestätigt.
Eine Pilotfreigabe ist derzeit blockiert; der menschliche Entscheid steht aus.
Keine vollständige LH-00-Abnahme und kein `ReadyForPilot` werden behauptet.**

Mac A ist das ausdrücklich vom Owner benannte MacBook Air M2 (2023).
Der eingefrorene [Mac-Nachweis](mac-a-results.json) erfasst macOS 27.0.1,
Build 26A434, arm64, Bash 5.3.20, PowerShell 7.6.6 und Python 3.14.8.
Gitbasis ist `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd` mit lokalen
uncommitteten Prozessänderungen. Der Auftrag gilt T019–T045 lokal; seine
Hashbindung identifiziert den dokumentierten Scope, keine rohen App-Transportdaten.

Der andere Prüfer hat die echten Protokolle, Sprach-/Fixture-Reviews,
Update-/Delete-Archive, Rücknahme, Collection-/Seriennachweise, Parität und finalen
Prüfausgaben gelesen. Alle 30 im Mac-Nachweis gebundenen Payload-Rohhashes stimmen.
Auftrag und Kernentscheidung stimmen mit ihren dokumentierten Hashes überein.
Es wurde keine große Testsuite wiederholt und kein Quellartefakt verändert.

| Kernfall | Bewertung und Grenze |
|---|---|
| E01 | Ein echtes isoliertes Agenten-Create mit zwei benannten Quellen, genau einem Ziel/Receipt und beiden erfolgreichen Receiptvalidatoren. Kein Produktlauf oder Folgekommando. |
| E02 | Anderer vollständiger Fixture-/Leserreview Ready; normative DE/EN-IDs und Aussagen gleichwertig, Begriffe erklärt, qualitative B2-Prüfung und textliche Darstellung vorhanden. Praktische Hilfsmittelabnahme bleibt offen. |
| E04 | Negative Prüfungen vor positiven; beide Shells weisen Drift, Pfadausbruch, Symlink, ungültiges UTF-8, ungültige Größen-/URL-Metadaten und Binärquellen ab. Create-Existing wird durch den tatsächlichen Skill-Guard ohne Schreiben verweigert. Gewöhnliches Update erhält Identität und exakte Vorgänger; logisches Delete erhält Archive/Tombstone. Tatsächlicher Teilschreibfehler wird abgewiesen und vollständig zurückgenommen. |
| E05 | Vollständiger unabhängiger Fixture-Review sowie frische echte LH-00-Reviews. Veraltetes Ready wird abgewiesen; fehlendes Review, Eligible ohne Auftrag oder nicht menschlich belegte Risikoannahme starten keine Arbeit. Kein zusätzlicher CLI-/Autonomie-Mechanismus wird behauptet. |
| E07 | Drei installierte Bash-/PowerShell-Collection-Kopien prüfen isoliert den Lifecycle einschließlich Active/N/A und Completed/Archiv samt Negativfällen. Aktuelle echte Serie ist ausschließlich Ready/Eligible mit einem LH-00-Mitglied, einer Root und keinen Kanten. Vollständige spätere Übersetzungs-/Register-/FU-Abnahme ist damit nicht erfüllt. |

Unabhängig nachgeprüft: Vorher-/Nachher-Hashes der Negativ- und Relative-Path-Fälle
sind gleich. Die tatsächlich behaltenen Delete-Archive sind bytegenau und aktive
Testziele/Receipts fehlen. Der Recovery-Bestand entspricht nach Rücknahme vollständig
den ursprünglichen Rohbytes. Die missverständliche Delete-Formulierung wurde vom
Autor korrigiert und erneut gelesen: Nur aktive Review-Dateien werden nach exakter
Archivierung entfernt; historische Reviews bleiben erhalten. Kein offener zusätzlicher
Schutzbefund in diesen begrenzten technischen Fällen.

Das aktuelle vollständige unabhängige T041-Review
`1bcdfd12-6424-4097-a2fd-c3e522095794` ist Ready, ohne offene Befunde oder
Risikoannahme. Receipt `4ecf3164-881a-413e-9ab0-d717de91757f` bindet den
Zielhash `ea4919bfcff0bfcfbef8bb557bd37ad2483ad6b5ec28b4e1668db4a6948a35bd`.
Die 101 rekursiven Receipt-/Request-/Review-Bindungen wurden auch vom
Mac-Reviewer erneut erfolgreich geprüft. Die T042-Auswahl protokolliert zwölf
Validatorläufe Exit 0; alle 122 geschützten Dateihashes wurden unabhängig erneut
geprüft. Vorher-/Nachher-Bytes und Gitstatus sind gleich, Validatorwrites null.
Keine Ordnungskante blockiert LH-00; dies ersetzt keine Befugnis oder Abnahme.

| Gate | Tatsächlicher Stand | Owner und nächste Aktion |
|---|---|---|
| B-01 technisch | Bestanden; anderes technisches Review Ready | Thorsten entscheidet gesondert über B-01-Abschluss. |
| B-01 menschlich / T036 | **Pending**, kein Owner-Entscheid vorhanden | Vor tatsächlichem Active-Übergang konkrete technische Evidence bewerten und Entscheidung dokumentieren. |
| Secret-/Preset-/PowerShell-/Diff-/betroffene Linkprüfungen | Bestanden im bezeichneten Umfang; Routing Aligned | Neu prüfen bei betroffener Änderung. Die Vollverzeichnis-Secretsuche behält genau drei unabhängig bestätigte öffentliche False Positives; mit exakter temporärer Baseline keine weiteren Funde, keine pauschale Regel-/Pfadausnahme. |
| Statistik/Homogenität / T043 | **Failed**, jeweils Exit 1: generierter Statistikdrift; Homogenität zusätzlich historische STATS-Sprachwarnung | Thorsten beauftragt bei gewünschter Lieferung Commit der Quellen, Renderer aus sauberem Baum und erneute Prüfungen. Dieser lokale Auftrag erlaubt keinen Commit oder handgeschriebene Statistikzahlen. |
| Begrenzte Pilotfreigabe / T045 | **Pending; BlockedByChecks** | Erst nach B-01-Ownerentscheid und bestandenen betroffenen Gates den konkreten Teilnachweis bewerten; ausdrückliche begrenzte Ownerentscheidung festhalten. Der Agent entscheidet nicht stellvertretend. |
| Volle LH-00-Prozessabnahme | **Open** | Nach separat beauftragtem und fachlich abgeschlossenem LH-01, dann LH-02, vor LH-03: vier Plattformen, praktische A11Y, Übersetzungen, angewendete Registerausrichtung und alle Pflichtkriterien nachweisen und menschlich abnehmen. |

Die dokumentierten lokalen Sequenzabweichungen sind sichtbar: Ready-Bootstrap
und lesende Auswahl erfolgten vor vollständigem T036-Ownerabschluss; vorhandene
isolierte Mac-Teilnachweise wurden trotz offenem T043 festgehalten. Dies bestätigt
keinen abgeschlossenen ursprünglichen Gatepfad. Es gab kein tatsächliches Active,
Completed, LH-01-/LH-02-Featurepilot, Commit, Remote-Schreiben, Release oder Rollout.
LH-01/LH-02 brauchen jeweils eigenen Auftrag, gültiges Intake und anderes Review;
LH-02 bleibt vom fachlichen Abschluss von LH-01 abhängig. LH-00 bleibt offen.
Die Ergebniswörter dieses Protokolls erweitern keine Receipt- oder Serienstatuswerte.

## EN

**The isolated technical Mac A core flow is confirmed as partial evidence.
Pilot permission is currently blocked and the human decision is pending.
This is no full LH-00 acceptance or claim of ReadyForPilot.**

The owner explicitly identified Mac A as the MacBook Air M2 (2023). The frozen
Mac record binds the actual OS/tool versions listed above, the Git base and local
uncommitted changes. Authority is the local T019–T045 request; its hash identifies
the recorded scope rather than raw application transport data.

The distinct reviewer read the actual flow records, language/fixture reviews,
archives, rollback, collection/series and parity evidence, and final check outputs.
All 30 Mac-bound raw payload hashes match, as do the authority and core decision
hashes. No complete suite was rerun and no source artifact was changed.

| Core case | Assessment and limit |
|---|---|
| E01 | Actual isolated agent Create: two sources, one target/receipt and successful validators in both shells. No product or follow-up run. |
| E02 | Distinct complete fixture/reading review Ready, equivalent DE/EN normative IDs and content, explained terms, qualitative B2 and textual representation. Assistive field acceptance remains open. |
| E04 | Negatives precede positives; both shells reject drift, escaped/symlink paths, invalid UTF-8, invalid size/URL metadata and binary sources. The existing Create guard refuses overwrite without writes. Ordinary Update preserves identity and archives; logical Delete preserves tombstone/history; actual partial publication is rejected and completely rolled back. |
| E05 | Complete independent fixture and fresh real LH-00 reviews; stale Ready is rejected. Missing review, eligibility without matching authority and unsupported human risk acceptance start no work. No extra execution engine is asserted. |
| E07 | All three installed paired collection validators cover the isolated lifecycle and negative cases. The real series remains Ready/Eligible, one member/root and no edges. Later translation, registry and follow-up acceptance is not completed by these tests. |

The reviewer independently checked equal negative/relative-path snapshots, exact
retained Delete archives, absent active test targets/receipts and fully restored
Recovery bytes. The author corrected the ambiguous Delete wording; reinspection
confirms only active review files are removed after exact archival. No additional
open protection finding arose within these bounded technical cases.

Fresh complete independent T041 review `1bcdfd12-6424-4097-a2fd-c3e522095794`
is Ready with no findings or risk acceptance. Current receipt and target identities
are recorded above. All 101 recursive receipt/request/review bindings were also
independently verified by this Mac reviewer. T042 records twelve validator runs
with exit 0 and 122 protected file hashes, each rechecked. Before/after snapshots
and Git status match; validator writes are zero. Ordering eligibility supplies no
execution authority or acceptance.

| Gate | Actual state and next action |
|---|---|
| Technical B-01 | Passed, distinct technical review Ready. Thorsten separately decides human closure. |
| Human B-01 / T036 | Pending. Record the owner decision before real Active. |
| Secrets/presets/PowerShell/diff/changed links/routing | Scoped checks pass; routing Aligned. The full-directory secret scan retains exactly three independently confirmed public-guidance false positives and finds no additional issue with an exact temporary baseline. No blanket exclusion. Recheck affected changes. |
| Statistics/homogeneity / T043 | Failed, exit 1, generated statistics drift; homogeneity also records the historical STATS language warning. A separately authorized source commit, clean-tree renderer and renewed checks are needed. No manual figures or unauthorized commit. |
| Limited pilot / T045 | Pending; BlockedByChecks. Obtain human B-01 closure and passing applicable gates, then record Thorsten's explicit limited decision on this concrete reviewed evidence. No agent substitutes for it. |
| Full process acceptance | Open. After separately commissioned and completed LH-01, then LH-02, before LH-03: complete four-platform, practical accessibility, translation, applied registry and all mandatory acceptance evidence and human approval. |

Local sequencing exceptions remain explicit: Ready bootstrap/read-only selection
preceded full T036 human closure; existing isolated core evidence was recorded
while T043 remained open. This does not certify completion of the original gate
sequence. No real Active/Completed, feature pilot, commit, remote write, release or
rollout occurred. LH-01/LH-02 each need separate requests, valid intakes and distinct
reviews; LH-02 requires domain completion of LH-01. LH-00 stays open. Report outcome
words introduce no receipt/series schema states.

## Geprüfte Rohhashes / Reviewed raw hashes

| Artefakt / Artifact | SHA-256 |
|---|---|
| `docs/validation/lh00/mac-a-results.json` | `6574b600cd32d77efea956660aa08d6b4f0f6e9b2d0a9c0ae53432117c5232d5` |
| `docs/validation/lh00/series-next-results.json` | `8f1239aea2cf8ada5e193c589a8a8fca7ccde95ea35fc41833f8d103a864ed06` |
| `docs/validation/lh00/increment2-check-results.json` | `3165b13edec2aecb8989f5f6f63c85b103e31e91e6404deaf469e40d1303206e` |
| `specs/intake-authoring-receipts/lh-00.json` | `e9f9aaea14e87412915dc29d7d55e90ffd95da1fd28dafea3ac59b0d2217bf99` |
| `specs/intake-review-request.json` | `4c2df67bd9c676a1e9ac34199ce3bf4cc89693bb9b5515e79eb682ddb18eb3b1` |
| `specs/intake-review-result.json` | `266ee185d717d5c5d208065eac91169228de9e89ea9d75d3bd8f64a1483308cc` |
| `specs/intake-review-report.md` | `098b388068e4fbaf6793ed3831333e331679250026ae55209341b72116777131` |
| `docs/validation/lh00/delete.md` | `ad68106f89473d68c84b6219bf645b25d2b0ab804aa335bf2fd157607a27b38b` |

Leserpfad / Reader path: [Mac A](mac-a.md) → [Payloads](mac-a-results.json) →
[lesende Auswahl / read-only selection](series-next-results.json) →
[aktuelle Gates / current gates](increment2-check-results.json) → dieses Assessment /
this assessment → gesonderte Ownerentscheidungen / separate owner decisions.

Wiedervorlage / Re-evaluation: nach verändertem gebundenem Input, Gate-Reparatur,
Tool-/Hoständerung oder konkretem Ownerentscheid; spätestens 2026-10-12.
Owner Thorsten. Historische Belege bleiben erhalten / preserve historical evidence.
