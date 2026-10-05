# LH-00: Quellenaktualisierung nach Authoring v0.3.7 / Source refresh after Authoring v0.3.7

Stand / Date: 2026-10-05. Owner: Thorsten Hindermann. Entscheidung / Decision: IAD012.
Basis / Base: `e5a3b4c335394bda036abd3186aa5070da2b0257`; [Projektlieferung PR #26](https://github.com/hindermath/Show-CommandTui400/pull/26).

## Auftrag / Authority

Der Owner benannte ausdrücklich das gesonderte LH-00-Intake-Update und unabhängige
Review vor dem Implementierungsstart. Danach wählte er die drei Schritte
Quellenbewertung/Update, anderes Review und Spec-/Plan-/Tasks-Abgleich mit Startchecks
und beauftragte dafür „DeliveryMode MergeAndSync mit Admin-Bypass.“
Dieser Auftrag umfasst genau dieses Vorbereitungspaket einschließlich Commit,
Push, PR, technischer CI-Prüfung, an den geprüften Head gebundenem Merge und lokalem
main-Sync. Ein separater Agent prüft den Intake nach IAD009; der Hauptagent ist Autor.
Keine Implementierung, keine weiteren Lastenhefte, keine reale Serienaktivierung,
keine Feature-Piloten, keine Releases, keine zentralen Änderungen, keine Installation,
kein Routing-Refresh und keine Flottenrollouts.
Admin-Bypass ersetzt keine technischen Prüfungen. Produkttechnik bleibt offen.

The owner explicitly required a separate LH-00 update and independent review
before implementation, then selected source assessment/update, another reviewer
and spec/plan/task reconciliation with affected start checks, commissioning
“DeliveryMode MergeAndSync mit Admin-Bypass.” Authority covers this preparation
package only: commit, push, PR, technical CI, exact-head merge and local main sync.
A separate agent reviews under IAD009; the main agent authors. No implementation,
other intakes, live series activation, feature pilots, releases, central changes,
installation, routing refresh or fleet rollout. Admin bypass replaces no technical
check. Product technology remains undecided.

## Erklärte Quellenänderung / Explained source change

Receipt `98203fd2-0684-4fd6-ab69-a1353e250a12` bindet sechs Quellen vor PR #26:
docs/intake-governance.md, docs/Entwicklungsumgebung.md, constitution.md, AGENTS.md,
Projektmatrix und Quellen-Lock. Der Patch bindet Authoring 0.3.7 statt 0.3.6,
korrigiert den einzeiligen README-Installationsbefehl und akzeptiert historische
0.3.6-Receipts; deren Quellenfrische wird dadurch nicht wiederhergestellt.
Zielbytes und Intake-ID passen noch zum Vorgänger; alle bisherigen Operationen
sind Completed. Kein unerklärter Drift, Tombstone oder unterbrochener Vorgang.

The previous receipt binds six sources predating PR #26. The patch pins Authoring
0.3.7, fixes the one-line README install command and accepts historical 0.3.6
receipts without restoring stale source bindings. Target bytes and intake identity
still match; all prior operations are completed. No unexplained drift, tombstone
or incomplete operation is present.

## Erhaltener Umfang und Reihenfolge / Preserved scope and order

Die zwölf FR-00 und neun AC-00 pro Sprache bleiben bytegleich, ebenso IAD010s
Pilotweg: Kernprozess auf einem benannten primären Mac; eigene LH-01-/LH-02-Aufträge
und Reviews; vollständige Abnahme nach LH-02, vor LH-03. Neue Receipt-/Operations-IDs,
gleiche Intake-ID, bytegleiche Vorgängerarchive und explizit abgelöstes altes Review
sichern die Herkunft. Vorgängerintake ist die erste Quelle, danach diese Entscheidung
und die im Receipt geordneten aktuellen Dateien einschließlich des Patchnachweises.
IAD001–IAD011 und historische Versions-/Prüfaussagen behalten ihren Kontext.

Preserve twelve FR-00 and nine AC-00 lines per language byte-for-byte and retain
IAD010's staged pilot route. Keep intake identity; create new receipt/operation IDs,
archive predecessors exactly and explicitly supersede the old review. The prior
intake is the first source, followed by this decision and the receipt's ordered
current files including patch evidence. Preserve IAD001–IAD011 and historical
version/check statements in their original context.

## Fachliche Auswirkungen und Lieferung / Domain impact and delivery

Nur aktuelle Versions-/Quellenbezüge und Auftragskontext ändern sich. Keine neuen
Anforderungen, Statuswerte, JSON-Schemas oder Abnahmeregeln. Spec/Plan/Tasks gezielt
abgleichen; vorhandene Werkzeugnachweise wiederverwenden, keine 0.3.6-Historie
als 0.3.7-Test ausgeben. Beide Receipt-Validatoren, anderes vollständiges Review,
Analyze und betroffene lesende Startchecks folgen vor der Lieferung.
Das neue Review bewertet ausschließlich LH-00; Ready ist keine Implementierungs-
oder Pilotfreigabe. Alle 65 Umsetzungstasks bleiben offen. Die LocalImplementation-
Folgevorlage bleibt für einen späteren eigenen Auftrag lokal begrenzt; die aktuelle
MergeAndSync-Befugnis gilt allein für dieses Nachweispaket.

Only current version/source references and request context change, without new
requirements, states, schemas or acceptance rules. Reconcile existing design/tasks
and reuse bounded tool evidence without relabeling historical 0.3.6 tests as 0.3.7.
Run both receipt validators, a complete independent review, Analyze and affected
read-only start checks before delivery. Ready grants no implementation or pilot
permission; all sixty-five implementation tasks remain open. Keep the future
LocalImplementation template bounded to a separate local run; current MergeAndSync
only delivers this evidence package.

## Dokumentationsauswirkung / Documentation impact

UpdateRequired; sourceOnly; Owner Thorsten; DE zuerst/EN danach, ungefähr B2.
Leserpfad: LH-00 → Receipt/Review → Spec/Plan/Tasks → neuer v0.3.7-Preflight.
Wiedervorlage: Quellen-, Tool-, Scope- oder Auftragsänderung; vor Implementierung.
Historischer Preflight bleibt unverändert; neue Ergebnisse werden getrennt erfasst.

UpdateRequired; sourceOnly; owner Thorsten; German first, English second, about B2.
Reader path: intake → receipt/review → spec/plan/tasks → fresh v0.3.7 preflight.
Reassess changed sources, tools, scope or authority and before implementation.
Preserve the earlier preflight; record new results separately.
