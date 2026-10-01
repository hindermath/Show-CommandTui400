# Collection-Dateivertrag / Collection file contract

Dies ist ein Entwurf, keine aktive Konfiguration. Pfade beziehen sich auf das
Repository. Maßgeblich bleiben die installierten Schemas; keine Platzhalter-ID
oder erfundene Prüfsumme wird als aktiver Nachweis geschrieben.

This is a design, not active configuration. Paths are repository-relative.
Installed schemas govern; no placeholder ID or invented hash becomes active evidence.

## Konfiguration und Rollen / Configuration and roles

Zieldatei: `requirements/intake-governance-config.json`; Schema `2.0`,
`documentationLanguage: de-DE`, `inventoryMode: SeriesManifest`,
`artifactNaming.profile: explicit`, `legacyArtifactNames: []`.
Die Sprachkennung ersetzt nicht die verbindliche EN-Fassung.

The target file uses schema 2.0, de-DE, SeriesManifest, explicit naming and no
legacy names. The language tag does not remove the required English track.

| Feld / Field | Festgelegter Pfad bzw. Wert / Selected path or value |
|---|---|
| `artifactNaming.canonicalIndex`, `roles.requirements-index` | `requirements/RequirementsIndex.md` |
| `artifactNaming.intakePattern` | `LH-<slug>.md` |
| `artifactNaming.orderView`, `roles.intake-order` | `docs/Lastenheft-Plan.md` |
| `roles.requirements-intake`, `collections.active` | `intakes` |
| `roles.requirements-baseline`, `collections.baseline` | `requirements/baseline` |
| `collections.archive` | `requirements/intakes/archive` |
| `collections.backlog` | `requirements/intakes/backlog` |
| `collections.history` | `requirements/intakes/history` |
| `collections.seriesManifest` | `specs/intake-series/lh00-process/manifest.json` |

Genau vier Rollen und sechs Collection-Keys verwenden. Index und Reihenfolge sind
Dateien, Baseline ein Verzeichnis. Alle Collection-Pfade sind eindeutig und
physisch im Repo; Symlink-Ausbruch/Aliase werden abgewiesen. Ein kurzer bilingualer
Verweis in `requirements/baseline/` zeigt auf `docs/Bedienkonzept.md`, ohne Kopie
oder Umbenennung. Der Index verlinkt vorhandene Issues und Intakes; LH-01–LH-07
bleiben als nicht erstellt markiert. `docs/issue-drafts/` bleibt historisch.

Use exactly four roles and six collection keys. Index/order are files, baseline
is a directory. Collection paths are unique and physically contained; reject
symlink escapes/aliases. A bilingual baseline reference points to the canonical
concept without copying or renaming it. Link existing issues/intakes and mark
LH-01–LH-07 as not created. Issue drafts remain historical sources.

`active` enthält aktive fachliche Intakes, `archive` tatsächlich abgeschlossene
und fachlich archivierte Intakes. `backlog` ist die vorgesehene Ablage für später
ausdrücklich zugeordnete, noch nicht aktive Dokumente; die vorhandenen Issues
werden dadurch nicht zu Intake-Dateien. `history` dient historischen
Collection-Verweisen. Die bestehenden Authoring-Versionsarchive bleiben die
Quelle für frühere Intake-/Receipt-Generationen; weder history noch archive
ersetzt oder kopiert sie automatisch.

The active collection holds active domain intakes; archive holds genuinely
completed and archived intakes. Backlog is reserved for later explicitly assigned
documents not yet active; existing issues do not thereby become intake files.
History holds historical collection references. Existing authoring version archives
remain authoritative for earlier intake/receipt generations; neither history nor
archive automatically replaces or copies them.

## Serienvertrag / Series contract

Bei später autorisierter Erstellung eine echte dauerhafte `seriesId` erzeugen;
`schemaVersion: 1.0`, `documentType: IntakeSeriesManifest`, Titel DE/EN,
`policy: .specify/memory/intake-series-policy.json`, `status: Ready`.
`orderedTargets` enthält genau ein Objekt:

| Feld / Field | Wert / Value |
|---|---|
| `path` | `intakes/LH-00.md` |
| `role` | `Primary` |
| `normalizedSha256` | Aus dem dann aktuellen, geprüften Dateiinhalt berechnen / Compute from current reviewed file content. |
| `status` | `Eligible` |
| `roots` auf Manifestebene / at manifest level | `["intakes/LH-00.md"]` |
| `dependencies` auf Manifestebene / at manifest level | `[]` |

Bei Erstellung tatsächliche Nachweispfade in `evidencePaths` aufnehmen;
neben Manifest `receipt.json` und `operation.json` nach den installierten
Sequencing-Vorlagen erzeugen. Die Sequencing-Policy folgt der vorhandenen Vorlage:
Manifestroot `specs/intake-series`, Archivroot `specs/intake-series-archive`,
explizite Schreibautorität, kein physischer Purge, `nextCommandStartsWork: false`.
Authoring-Serienartefakte unter `specs/intake-authoring-series` sind ein anderer
Vertrag und werden nicht durch Sequencing-Dateien überschrieben.

During authorized creation, generate a real stable series ID, a bilingual title,
the stated policy reference and the single target above. Compute current hashes
and record real evidence paths. Create receipt/operation from installed sequencing
templates. The policy uses the installed manifest/archive roots, explicit write
authority, no physical purge and no execution from Next. Authoring-series artifacts
are a separate contract and must not be overwritten with sequencing files.

Die bestehende Reihenfolge bleibt allein im Lastenheft-Plan maßgeblich. Nach vollständiger LH-00-Abnahme und
später beauftragter Erstellung weiterer Intakes deren tatsächlich existierende
Mitglieder und Kanten per Series-Update aufnehmen: LH-00→LH-01 als bindendes
`RequirementsGovernanceGate`, fachliche Abschlussabhängigkeiten als
`HardCompletionGate`. Keine Kanten zu nicht vorhandenen Dateien; keine Reduktion
oder Änderung bestehender Abhängigkeiten. Advisory-Kanten sind nicht bindend.

The existing intake plan remains the order authority. Only after full LH-00 acceptance and separately
authorized intake creation may Series-Update add existing targets and dependencies:
LH-00→LH-01 as a binding RequirementsGovernanceGate, domain completion dependencies
as HardCompletionGate. Add no edges to missing files and preserve all dependencies.
Advisory edges are non-binding.

**B-01:** Ready/Eligible ist validierbar. Active/Active mit nur einem Mitglied
scheitert an RIG017. Nicht aktivieren, bis eine versionierte Korrektur alle
Collection-Prüfungen bestehen lässt. Idle/leer ist zwischen Presets inkonsistent.
Completed braucht tatsächlichen Abschluss, Archivpfade und erhaltene Mitglieder.

**B-01:** Ready/Eligible validates. A single Active/Active member fails RIG017;
do not activate until a versioned correction passes every collection check.
Empty Idle is inconsistent across presets. Completed requires actual completion,
archive paths and preserved membership.

Fehlende Mitglieder, Zyklen, unpassende Reihenfolge oder mehr als ein Eligible-Ziel
sperren die betroffene Serie mit konkretem Grund. Idle/leer wird für diese
Collection nicht aktiviert. Das Schließen von B-01 richtet sich nach den
[Aufhebungskriterien in D-03](../research.md#d-03-bootstrap-und-kompatibilität--bootstrap-and-compatibility),
nicht nach einem allein erfolgreichen Ready/Eligible-Bootstrap.

Missing members, cycles, inconsistent order or multiple Eligible targets block
the affected series with a specific reason. Empty Idle is not activated for this
collection. Closing B-01 follows D-03's resolution criteria, not a successful
Ready/Eligible bootstrap alone.

## Migration und Nachweis / Migration and evidence

Journal unter `requirements/intake-governance-operations/` nach Schema-Vorlage
führen. Vorhandene Namen/Identitäten bewahren. Reihenfolge: Ausgangshashes und
Autorität prüfen → vollständigen Kandidatensatz vorbereiten → beide Shells und
alle drei Collection-Kopien validieren → Referenzen/Policy/Profil konsistent
publizieren → frisches unabhängiges Review gebundener Änderungen. Kein
`Ready` aus bloßer Rehash-Bearbeitung. Rollback stellt Originalbytes wieder her;
unvollständige Wiederherstellung führt zu `NeedsRepair` und sperrt Folgeaktionen.

Keep a schema-based journal in the stated directory and preserve names/identities.
Check source hashes and authority, stage the complete candidate set, validate both
shells/all three collection copies, publish consistent references/policy/profile,
then obtain fresh independent review for bound changes. Rehashing alone never
creates Ready. Rollback restores original bytes; incomplete recovery produces
NeedsRepair and blocks downstream actions.

## Pilot-Ausnahme und B-01-Zielregel / Pilot exception and B-01 target rule

Vor voller LH-00-Abnahme bleiben LH-01 und LH-02 nach IAD010 außerhalb dieser
Serie. SeriesManifest zählt sie als eigenständige aktive Intakes, nicht als
Serienmitglieder. Vor jedem Pilot manuell Auftrag, gültigen Intake, unabhängiges
Review und begrenzte Owner-Pilotfreigabe prüfen; LH-02 zusätzlich gegen den
belegten LH-01-Abschluss. Kein falsches Completed für LH-00 und keine gelockerten
bindenden Kanten. Vor LH-03 volle LH-00-Abnahme nach LH-02 nachweisen.

Für den B-01-Patch gilt: Ready genau ein Eligible; Active null oder ein Eligible,
aber null nur bei mindestens einem Active-Mitglied; mehrere Eligible bleiben
ungültig. Completed und alle Sicherheitsprüfungen bleiben unverändert. Bei null
Kandidaten eligibleCandidate N/A. Leeres Idle bleibt ausgeschlossen. Die lokale
Quellenkorrektur wird erst nach getrennt autorisierten Releases, zentralen Pins,
gezielter Installation und erneuter Prüfung für diese Collection wirksam.

Before full LH-00 acceptance, IAD010 keeps LH-01 and LH-02 outside this series.
SeriesManifest counts them as standalone active intakes rather than series
members. Before each pilot, manually verify its request, valid intake, independent
review and limited owner pilot permission; LH-02 also requires evidenced LH-01
completion. No false LH-00 Completed and no relaxed binding edges. Prove full
LH-00 acceptance after LH-02 and before LH-03.

The B-01 patch requires exactly one Eligible in Ready. Active permits zero or one,
but zero requires at least one Active member; multiple remain invalid. Completed
and all safety checks remain unchanged. Zero candidates yield eligibleCandidate
N/A. Empty Idle remains excluded. The local source fix takes effect in this
collection only after separately authorized releases, central pins, targeted
installation and retesting.
