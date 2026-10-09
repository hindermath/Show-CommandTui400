# Inkrementprüfung T018–T036 / Increment checks T018–T036

## DE

Scope: eigener Mac-A-Implementierungsauftrag mit MergeAndSync/Admin-Bypass.
Aktueller Stand: [Produktnachweis](session-terminal.md),
[anderes Review](session-increment-review.md), [Aufgaben](../../../specs/002-lh01-tui-foundation/tasks.md).

- Intake-/Review-Frische: LH-00 und LH-01 jeweils aktuell/Ready; keine gebundenen
  Governancequellen geändert, daher kein gewöhnliches Intake-Update ausgelöst.
- Routing: Codex0.160.0 Aligned; 14-Preset-Matrix exakt, keine Installation.
- Locked Build, 20 Modell-/Lifecyclechecks und zehn synthetische Produkt-PTY-Fälle
  belegt. Der injizierte Restorefall bleibt Fail/Exit1, beide Ursachen erhalten.
- Driver: sieben negative Planverträge Pass; Prepared/Fremdhost bleibt Blocked,
  CheckOnly ohne Ausgaben. Kein Plattformtest auf Mac B/Windows/WSL2 ausgeführt.
- PSScriptAnalyzer: neue Testskripte ohne Warnungen/Fehler. Host-SMA nicht kopiert.
- NuGet-Audit: zum Prüfzeitpunkt keine bekannten anfälligen Pakete; keine Abnahme.
- Secretprüfung: high=0, medium=0. Diffprüfung ohne Fehler. GUIDs/Hashinventare
  sind Nachweise, keine Secrets. Neue Quellen vor Lieferung vollständig gestaged prüfen.
- Parität: bestehende Constitution-/Guidancequellen unverändert; T017-Guidance ist
  die eingefrorene Vorbereitungsbaseline. Aktueller Produktstand steht im
  Inkrementnachweis/Plan/Tasks; spätere Guidanceänderung verlangt T015/T016-Schleife.
- Gezielter Spec-/Plan-/Tasks-Abgleich: alle63 IDs erhalten,36 erledigt,27 offen;
  FR/AC/QG/OD und Einzelpilot unverändert. Keine offenen startrelevanten Befunde
  im begrenzten Inkrement. Keine vollständige LH-01- oder LH-00-Abnahme.
- Vor Quellencommit: Statistikdrift erwartet, Homogenität deshalb1FAIL; lokale
  ignorierte STATS.md behält1WARN. Nach Quellencommit Renderer aus sauberem
  Baum, Check-only und Statistikcommit; finale Homogenität/Statistik sind Liefergates.
- Assurance-Delta: Bash/PowerShell Exit0 mit **NeedsRemediation**, weil vollständige
  Produktkontrollen/andere Plattformen T052–T059 noch offen sind. Das ist kein
  Ready für das gesamte Feature. Closure/Image-Impact bleiben T062-Arbeit.

Lieferfolge: Quellencommit → sauber rendern/prüfen → Statistikcommit → Push/PR →
alle technischen Checks am endgültigen Head → exakter Admin-Merge → main0/0.
Keine Produkt-CI-/Releaseautomation, Serienaktivierung oder Flottenänderung.

## EN

The commissioned Mac A increment retains current intake/review provenance,
Aligned routing and the exact fourteen-preset matrix. No bound governance source
changed, so no ordinary intake update is triggered. Constitution and shared
agent guidance remain the frozen T017 preparation baseline; current product
status is in the increment report/plan/tasks. A later guidance update must repeat
T015/T016. This does not authorize later tasks implicitly.

Locked build,20 model/lifecycle checks, ten synthetic product PTY scenarios and
seven negative driver plan contracts are evidenced. The injected restoration
failure remains Fail/exit1, retaining both causes. No foreign-host proof is claimed.
New test scripts pass PSScriptAnalyzer, host SMA is absent from outputs, package
audit finds no known vulnerable packages, secret scan has no high/medium findings
and diff validation passes. Full staged inventory is checked before delivery.

Targeted artifact analysis preserves all63 task IDs,36 completed and27 open, all
FR/AC/QG/OD IDs and the standalone pilot. No start-relevant finding remains within
this increment. Complete platform/assistive/feature/process acceptance is open.
The delta validates structurally in Bash/PowerShell but remains NeedsRemediation
for later T052–T059 product consolidation; closure/image-impact belong to T062.

Pre-delivery statistics drift is expected and causes one homogeneity failure;
ignored local STATS.md retains one warning. Final gates follow the authorized
source commit, clean-tree render/check/statistics commit, PR checks at the exact
head, admin merge and clean main synchronization. No product CI, release,
series activation or fleet rollout is introduced.
