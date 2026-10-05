# LH-00: B-01-Lieferung und Restnachweise / Delivery and remaining evidence

Stand / Date: 2026-10-05. Owner: Thorsten Hindermann.

Die [Quellen-Lockdatei](coordinated-governance-source-lock.json),
[Projektmatrix](../../scripts/config/spec-kit-project-statistics-governance-presets.json)
und [Pilotnachweise](coordinated-governance-oct03.md) belegen die vorhandene Lieferung.
PR [#21](https://github.com/hindermath/Show-CommandTui400/pull/21) und
[#22](https://github.com/hindermath/Show-CommandTui400/pull/22) sind Bestandteil des
lokalen main 063659b; die historische PR-pending-Aussage in der Recherche ist überholt.
Keine neuen Releases, zentralen Änderungen oder Installationen werden ausgeführt.

The linked source lock, project matrix and pilot evidence record delivered tooling.
PR #21/#22 are included in local main 063659b; earlier pending-delivery wording is
historical. This work publishes no release, changes no central pins and reinstalls
nothing.

| Task | Vorhandener Nachweis / Existing evidence | Verbleibend / Remaining |
|---|---|---|
| T034 | D-09: drei Source-PRs, neun native Jobs; Lock: Authoring 0.3.6, Review 0.2.4, Sequencing 0.2.7 mit Tag-Commits und ZIP-Hashes / source CI and immutable releases | Zusammengeführte Identitäten vor US5 erneut prüfen; kein Release-Auftrag mehr erforderlich / verify consolidated identities before US5, no new release needed |
| T035 | Zentrale Lieferung #318 und Quellen-Lock; Projektmatrix/Pilot PR #21/#22 / central and project pins delivered | Exakten Matrix-/Lock-Abgleich für US5 belegen; nur echte Abweichung separat ändern / evidence exact comparison, change only real drift separately |
| T036 | Gezielte Installation, drei Konfigurations-Fixture-Suiten in Bash/PowerShell mit Zero-write-Parität; 14er-Check-only / installation and paired configuration fixtures | Vollständigen Ready→Active→Completed-Lifecycle samt Archiv, Negativfällen und allen drei installierten Kopien nachweisen, soweit im vorhandenen Paket nicht belegt; anderes Review und Owner-Entscheid für B-01 / complete missing lifecycle/archive/negative proof, separate review and owner decision |

Die vorhandenen Release- und Fixture-Nachweise schließen den ursprünglichen
Werkzeugfehler technisch ab; sie sind keine Aktivierung der realen LH-00-Serie,
keine menschliche B-01-Freigabe und keine praktische Projektabnahme. T034–T036
bleiben bis zur jeweiligen vollständigen Durchführung offen. Neues Intake-Review
prüft fachliche Reife, nicht die bisher nicht ausgeführten Prozessfälle.
Empty Idle bleibt für die LH-00-Collection ausgeschlossen. Active erteilt keine
weitere Ausführungsbefugnis. Alle bisherigen Pfad-, Hash-, Archiv- und DAG-Prüfungen
bleiben verpflichtend. Vollabnahme nach LH-02, vor LH-03 gemäß IAD010.

Existing release/fixture evidence resolves the original tool defect technically,
but proves no real series activation, human B-01 permission or practical project
acceptance. Keep tasks open until their complete scope is evidenced. A fresh intake
review assesses requirements, not unexecuted process cases. Empty Idle remains
excluded; Active grants no added authority. Preserve all path/hash/archive/DAG
checks and full acceptance after LH-02, before LH-03.

UpdateRequired; sourceOnly; Owner Thorsten; DE/EN. Leserpfad / reader path:
Research/Plan/Tasks → diese Zuordnung / this mapping → Quellen-Lock/Pilot/Preflight.
Wiedervorlage / reassess: vor US5 oder bei Quellen-/Versionsänderung / before US5
or after source/version changes.

## Lesender Lieferabgleich 2026-10-05 / Read-only delivery check

Mit gh release view verifiziert: alle drei genannten Tags sind veröffentlicht,
kein Draft und kein Pre-Release (Publikation 2026-10-03). Zentrale PR #318 ist
MERGED, Merge 58a9a10f424964653fe2316dd3a162e34c912f4a; Projekt PR #21/#22
sind MERGED (12224440ee851711fb5f2c73eb8cd98eee7e07fe /
f05c201087e4af75d0908f3602054a9877d7f4fd). Matrix/Quellen-Lock stimmen für alle
fünf koordinierten Pakete überein; aktueller lokaler 14er-Check-only Exit 0.
Die früheren neun nativen Source-Jobs werden aus D-09 wiederverwendet, nicht neu
als heutige Prozessprüfung ausgegeben. T036-Restumfang bleibt wie oben beschrieben.

Read-only gh checks confirm all three published tags are neither drafts nor
pre-releases. Central PR #318 and project PR #21/#22 are merged at the recorded
commits. The five coordinated packages match the source lock; current fourteen-preset
check-only exits zero. Reuse the nine historical native source jobs from D-09,
without calling them a current process acceptance. Remaining T036 scope is unchanged.
