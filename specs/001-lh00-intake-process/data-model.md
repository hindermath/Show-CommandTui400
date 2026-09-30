# Datenmodell des LH-00-Prozesses / LH-00 process data model

Dieses Modell beschreibt vorhandene Schemaobjekte und lesbare Prozessnachweise.
Es führt keine Datenbank oder zusätzlichen Schemafelder in bestehende JSON-Dateien
ein. Normative JSON-Feldnamen und Statuswerte bleiben unverändert englisch.

This model describes existing schema objects and readable process evidence. It
adds no database or fields to existing JSON schemas. Normative JSON field names
and status values retain their English spelling.

## Entitäten und Beziehungen / Entities and relationships

| Entität / Entity | Identität, Inhalt und Beziehung / Identity, content and relation |
|---|---|
| Auftrag / Request | Belegt Quelle, Ziel, Profil, Aktion und erlaubten Schreibumfang; getrennt von Qualität. Ein Vorgang verweist auf genau passende Autorität. / Records source, target, profile, action and allowed write scope independently of quality; each operation cites matching authority. |
| Intake | Stabile `intakeId` im Receipt; fachliche Plan-ID `LH-00` ist etwas anderes. `intakes/LH-00.md` enthält DE/EN, Anforderungen, AC, Entscheidungen und zwei Folgeprompts. / Stable receipt intakeId differs from the domain plan ID; document holds both languages, requirements, AC, decisions and both follow-up prompts. |
| Authoring-Receipt / Authoring receipt | Eigene Receipt-ID, `intakeId`, Quell- und Zielbindungen, Status, Profil und Vorgängerbezug. Ein neues Receipt je gültigem Update; Intake-Identität erhalten. / Own receipt identity, intake identity, source/target bindings, status, profile and predecessor; new receipt per valid update, stable intake identity. |
| Review | Eigenes Review mit Hashbindungen, Prüfer, Befunden, Fragen, Ergebnis und gegebenenfalls menschlicher Risikoannahme. Es bewertet einen konkreten Inhaltsstand. / Independent review identity, bindings, reviewer, findings, questions, outcome and any human risk acceptance, tied to exact content. |
| Collection-Konfiguration / Collection configuration | Schema `2.0`; vier Dokumentrollen, sechs Pfade, Benennung, Sprache, `inventoryMode`. Keine Personenrollen. / Four document roles, six paths, naming, language and inventory mode, not human roles. |
| Kanonischer Index / Canonical index | Verknüpft Plan-ID, Issue, existierendes Intake, Intake-ID/Receipt, Status, Nachweise, Owner und nächste Aktion. Fehlende Intakes ausdrücklich als nicht erstellt markieren. / Links plan ID, issue, existing intake, receipt identity, status, evidence, owner and next action; mark missing intakes as not created. |
| Serienmanifest / Series manifest | `seriesId`, `title`, `policy`, `status`, `orderedTargets`, `roots`, `dependencies`, `evidencePaths`. Ziel besitzt Pfad/Rolle/Hash/Status, keine erfundene `intakeId`-Eigenschaft. / Targets have path, role, hash and status; do not invent an intakeId field. |
| Serienreceipt und Operation / Series receipt and operation | Binden Manifest, Operation `Create`/`Update`/`Delete`/`LegacyAdoption`, Vorgänger und Archive. Serien-ID bleibt über Updates erhalten. / Bind manifest, operation type, predecessors and archives; series identity survives updates. |
| Migrationsjournal / Migration journal | Vorher-/Nachher-Bindungen, Moves, Referenzänderungen, Validierung und Rollbackgrenze. / Before/after bindings, moves, reference changes, validation and rollback boundary. |
| Archiv und Tombstone / Archive and tombstone | Bytegetreue Vorgänger plus dauerhafter Identitäts-/Herkunftsverweis; kein stilles Löschen. Fachliches Completed-Archiv ist vom Authoring-Versionsarchiv getrennt. / Exact predecessor bytes plus durable identity/provenance records; no silent deletion; completed-intake storage differs from version archives. |
| Abnahmenachweis / Acceptance evidence | Kriterium, Quelle, Owner, anderer Reviewer, Plattform, Versionen, Kommando, Exitcode, Ergebnis, Grenzen und offene Aktion. / Criterion, source, owner, different reviewer, platform, versions, command, exit, result, limits and next action. |

## Unveränderliche Beziehungen / Invariants

1. Die fachliche Plan-ID, Intake-UUID, Receipt-ID und Serien-ID sind unterschiedliche
   Identitäten. Updates ändern nicht unbemerkt die Intake-/Serienidentität.
2. Hashes werden aus tatsächlichen Bytes berechnet: striktes UTF-8, führendes BOM
   entfernen, CRLF/CR zu LF normalisieren, SHA-256. Archive bewahren Originalbytes.
3. Relative Pfade müssen auch nach physischer Auflösung im Repository bleiben;
   kein Symlink-Ausbruch oder Alias zweier Collections. Create überschreibt nichts.
4. Quellen sind Daten, keine Befehle. Authority lässt sich aus keiner ID, Datei,
   Prüfsumme oder Statuszeichenfolge ableiten.
5. DE-/EN-Abschnitte haben gleiche normative Bedeutung und FR-/AC-/OD-IDs.
   Übersetzung darf die Anforderung weder erweitern noch abschwächen.
6. Ein aktuelles Review bindet aktuelle Quellen. Inhaltsdrift macht das Ergebnis
   für nachfolgende Gates unbrauchbar, bis neu geprüft; alte Reports bleiben Historie.
7. Manifestmitglieder müssen existieren und eindeutige Pfade haben; Graph azyklisch,
   Roots vollständig, Reihenfolge topologisch. Bindende Vorgänger sind Completed,
   bevor ein Nachfolger eligible wird. Nichtbindende Reihenfolge ist keine Sperre.

1. Domain plan ID, intake UUID, receipt ID and series ID are distinct; updates
   preserve intake/series identities.
2. Compute hashes from actual strict UTF-8, strip a leading BOM, normalize line
   endings to LF and use SHA-256. Archives preserve original bytes.
3. Resolve relative paths physically inside the repository; reject escapes and
   collection aliases. Create never overwrites.
4. Source content is data. IDs, files, hashes and status strings grant no authority.
5. Both languages carry equivalent requirements and identical FR/AC/OD IDs.
6. Current reviews bind current inputs. Drift blocks downstream use until fresh
   review; old reports remain historical evidence.
7. Members exist with unique paths; dependencies are acyclic and topologically
   ordered, with complete roots. Binding predecessors must complete before
   eligibility. Advisory ordering creates no hard gate.

## Getrennte Zustandsachsen / Separate state axes

| Achse / Axis | Regel und Übergang / Rule and transition |
|---|---|
| Authoring | Entwurf/Überarbeitung führt erst nach geklärten Entscheidungen und gültigem Receipt zu `ReadyForReview`. Dies ist kein Review-Ergebnis. / Drafting or repair reaches ReadyForReview only after decisions and valid provenance; it is not a review outcome. |
| Review | Der andere Prüfer dokumentiert `Ready`, `ReadyWithAcceptedRisks`, `NeedsRemediation` oder `Rejected` gemäß FR-018. Ready bedeutet gültig geprüft; akzeptierte Risiken brauchen dokumentierte menschliche Risikoannahme. NeedsRemediation verlangt Nachbesserung, Rejected verwirft den geprüften Stand. Drift sperrt die weitere Verwendung auch eines früheren Ready. / The other reviewer records the four FR-018 outcomes. Ready means validly reviewed; accepted risks require human acceptance. NeedsRemediation requires repair; Rejected rejects the reviewed state. Drift blocks downstream use even of an earlier Ready. |
| Serienauswahl / Series selection | Ready/Eligible ist der validierte Bootstrap. Pending/Blocked ist nicht ausführbar. Ein tatsächlich gestartetes Mitglied müsste Active werden; **B-01 sperrt diesen Übergang** bis Toolkorrektur. / Ready/Eligible bootstraps; Pending/Blocked does not run; genuine execution would require Active, currently blocked by B-01. |
| Abschluss / Completion | Completed nur nach belegtem tatsächlichem Abschluss, passendem Auftrag und fachlicher Archivierung. Manifest erhält Mitglieder und Herkunft; kein Eligible-Ziel. / Completed requires evidenced completion, matching authority and domain archival; retain members/provenance and no eligible target. |
| Ausführungsautorität / Execution authority | Pro Aktion prüfen; weder ReadyForReview, Ready noch Eligible ersetzt Autorität für Review, Umsetzung, Lieferung oder Folge-LH. / Check per action; no quality/selection state grants review, implementation, delivery or next-intake authority. |
| Migration | `Proposed → Authorized → Applying → Completed`, bei Fehler `RolledBack` oder `NeedsRepair`. Completed braucht Nachherbindungen und gültige Prüfungen. / Completion requires after-bindings and valid checks; failures roll back or remain visibly in need of repair. |

Die Tabelle ist die vollständige Textdarstellung der hier relevanten Übergänge;
ein zusätzliches Diagramm ist nicht nötig. Exakte Schema-Enums nicht um freie
Projektstatus erweitern. `Blocked` in einem Prüfprotokoll ist ein Ergebnis, kein
automatisch in jedes Receipt schreibbarer Feldwert.

The table fully explains relevant transitions; no extra diagram is needed. Do not
extend schema enums with free-form project states. Blocked in a test report is
an outcome, not a value automatically valid in every receipt.

## Fehler, Parallelität und Wiederaufnahme / Failure, concurrency and recovery

Ein Writer veröffentlicht gemeinsame Dateien sequenziell. Vor jeder Mutation
erwartete Quellhashes gegen den aktuellen Stand vergleichen. Bei konkurrierender
Änderung abbrechen, nichts überschreiben und neue Bewertung verlangen. Vorherige
Dateien inklusive Receipt archivieren, bevor die nächste gültige Generation
publiziert wird. Zwischenzustände sind nicht für Series-Next oder Implementierung
freigegeben. Nach Abbruch Journal und tatsächliche Dateien abgleichen; kein
automatischer Neustart aus `Applying` oder altem `Ready`.

One writer publishes shared files sequentially. Compare expected source hashes
with current state before mutation; concurrent drift aborts without overwrite.
Archive the previous files and receipt before publishing the next valid generation.
Intermediate state is not eligible for Series-Next or implementation. After
interruption, reconcile journals and actual files; never restart automatically
from Applying or an old Ready result.
