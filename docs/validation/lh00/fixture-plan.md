# Isolierter Prüfbestand / Isolated fixtures

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

Mac A ist laut Owner-Antwort dieses Laufs ein MacBook Air M2 (2023). Die Bezeichnung
wurde vom Owner bestätigt; kein Seriennummern- oder Hostnamenexport ist nötig.
Mac A is the owner's MacBook Air M2 (2023), confirmed for this run. No serial number
or hostname is exported.

Der Auftrag T003/T017/T018 genehmigt das synthetische Beispiel-Issue FIX-LH00-01:
„Einen lokalen Beispiel-Lastenheft-Prozess beschreiben, ohne Produktfunktionen.“
Es ist kein GitHub-Issue und wird nicht veröffentlicht. Sein einziger fachlicher
Zweck ist ein nachvollziehbares DE/EN-Test-Intake samt Receipt (E01/E02,
FR-001–006, AC-00-001–003). Jede Kopie enthält höchstens ein eigenes Testziel.
The request approves synthetic issue FIX-LH00-01, a local intake-process example
with no product functions. It is not a GitHub issue. Each isolated copy contains
at most one separate test target and receipt.

Wurzeln entstehen über `tempfile.mkdtemp(prefix="lh00-")` außerhalb des Projekts.
Für Create sind ausschließlich `sources/issue.md` und `sources/constraints.md`
in dieser Reihenfolge fachliche Quellen. Profil, Policy und Guidance sind
benannte Governance-Eingaben. Keine private Datei, kein Netzabruf, keine Secrets.
Roots are temporary directories outside this project. Creation reads only the two
named sources in the given order. Policy, profile and guidance govern the run;
no private files, network requests or credentials are used.

Erlaubt sind nur Datei-Erstellung innerhalb der zugewiesenen Kopie und geprüfte
Basis-Skripte ohne Remotes. Negative Kopien erhalten fehlende Inhalte, Konflikte,
fehlende/nicht UTF-8-lesbare Quellen oder ein unvollständiges Profil. T018 kommt
vor E01/T017. Ein Blocker nennt Owner, genaue Korrektur und gesperrte Folgeaktion.
Writes are limited to the assigned isolated copy. Negative copies model missing
content, conflicts, unreadable sources or incomplete profiles. T018 precedes T017.
Every blocker names its owner, correction and blocked next action.

Beweisdaten werden unter `docs/validation/lh00/fixtures/` als ausdrücklich inaktive
Testdaten aufbewahrt. Sie sind weder aktive Projekt-Intakes noch Teil einer Serie.
Die reale `intakes/LH-00.md`, Receipt und Review bleiben bytegleich. Der Test
führt kein Review, Specify, Autonomous, Commit, Push oder Serien-Update aus.
Retained fixture data are inactive test data, not project intakes or series members.
Real LH-00 artifacts remain unchanged. No downstream run or delivery is started.

## Erweitertes beauftragtes Inkrement T019–T045 / Authorized second increment

Die vorstehenden Nullmutations-/Keinreview-Grenzen gelten historisch für T001–T018.
Der jetzige ausdrückliche Auftrag erlaubt in separaten eigenen Kopien Update,
logisches Delete, kontrollierte Teilstörung/Rollback, anderes Review und Collection-
Lifecycle. Jedes Beispiel behält dieselbe synthetische Identität nur in seiner
isolierten Kopie; keine Identität wird in einem aktiven Projekt wiederverwendet.
T032/T041 erlauben getrennte echte LH-00-Quellenupdates mit Archiven und anderen
Reviews; sie sind keine Fixture-Mutation. Tag-/CI-/ZIP-Abfragen sind lesende
Werkzeugliefernachweise, kein Netzabruf im synthetischen Create-Fall.

The original no-review/no-real-intake-mutation limits apply historically to the
first increment. The current request authorizes separate isolated lifecycle/review
and collection tests. Real T032/T041 updates are distinct traceable project
operations, never inferred from fixture authority. Public release/CI checks are
read-only tooling evidence, not source fetches in synthetic creation.
