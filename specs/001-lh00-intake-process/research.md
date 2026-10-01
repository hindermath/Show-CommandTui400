# Recherche zum LH-00-Prozess / LH-00 process research

Stand / Date: 2026-09-30. Die Recherche verwendet den installierten Code und die
gebundenen Projektquellen. Zwei vom Plan-Skill verlangte Recherche-Agenten haben
Collection-Verträge und Toolchain unabhängig lesend untersucht. Ihre Befunde wurden
mit den lokalen Vorlagen und Wrappern abgeglichen. Keine Recherche änderte Presets,
erstellte Intakes oder führte Remote-Schreibzugriffe aus.

Research uses installed code and bound project sources. Two research agents required
by the Plan skill examined collection contracts and tooling read-only. Findings
were checked against local templates and wrappers. No research changed presets,
authored intakes or performed remote writes.

## D-01: Vorhandene Werkzeuge / Existing tools

**Entscheidung:** Spec Kit 0.12.8 und die 14 gepinnten Presets weiterverwenden;
keinen neuen Generator, Server oder Validator entwickeln. Versionen aus der
[Projektmatrix](../../scripts/config/spec-kit-project-statistics-governance-presets.json)
lesen. Produkttechnik und Produkt-Mindestversion nicht aus Prozesswerkzeugen ableiten.

**Begründung:** Erstellung, Herkunft, Review, Serien und Migration haben bereits
Schemas und Wrapper. Ein zweiter Mechanismus würde abweichende Zustandsregeln schaffen.
**Alternativen:** Eigenentwicklung und vollständiges Re-Bootstrap verworfen;
beide würden unnötige Änderungen an Governance und Integrationen verursachen.

**Decision:** Reuse Spec Kit 0.12.8 and the pinned fourteen-preset matrix without a
new generator, server or validator. Do not infer product technology/minimums from
process tools. **Rationale:** Existing schemas and wrappers already cover authoring,
provenance, review, series and migration. **Alternatives:** Custom tooling and full
re-bootstrap add competing state rules or unnecessary governance/integration changes.

## D-02: Collection und Pfade / Collection and paths

**Entscheidung:** Schema `2.0`, `inventoryMode: SeriesManifest`, explizite
Benennung `LH-<slug>.md`; vorhandenes `intakes/LH-00.md` erhalten. Vier Rollen und
sechs Pfade stehen im [Collection-Vertrag](contracts/collection.md).

**Begründung:** Eine Serie darf nur ausdrücklich gewählte vorhandene Intakes
umfassen. `SeriesManifest` lässt zusätzlich eigenständige Intakes zu, ohne deren
Ausführung zu delegieren. Die Baseline-Rolle verlangt ein Verzeichnis; ein
Verweisdokument darin zeigt auf das weiterhin kanonische Bedienkonzept.
**Alternativen:** `DirectoryStrict` bindet jeden passenden aktiven Intake an die
Serie. Ein zweites Bedienkonzept oder Umbenennung von LH-00 würde Herkunft und
Referenzen unnötig ändern. Historische Issue-Entwürfe werden kein aktiver Backlog.

**Decision:** Use schema 2.0, SeriesManifest and explicit LH naming, preserving
the existing intake path. **Rationale:** Series membership is explicit, while
standalone intakes remain possible without delegated execution. The baseline role
requires a directory containing a reference to the canonical interaction concept.
**Alternatives:** DirectoryStrict binds every matching active intake to the series;
duplicating the concept or renaming LH-00 adds provenance risk. Historical issue
drafts do not become active backlog items.

## D-03: Bootstrap und Kompatibilität / Bootstrap and compatibility

**Entscheidung:** Zunächst genau LH-00 als `Primary`/`Eligible`, Serienstatus
`Ready`, ein Root und keine Kanten. Andere LH erscheinen nur als noch nicht
erstellte Einträge im bestehenden Lastenheft-Plan und späteren Index. `Eligible`
bedeutet auswählbar, weder beauftragt noch fertig implementiert.

**Decision:** Bootstrap with only LH-00, Primary/Eligible, series Ready, one root
and no edges. Other intakes remain not-yet-created order/index entries. Eligible
means selectable, not commissioned or implemented.

Read-only-Probe mit tatsächlicher LH-00-Datei und Manifesten im Arbeitsspeicher:

Read-only probe using the actual LH-00 file and in-memory manifests:

| Fall / Case | Authoring 0.3.5 | Review 0.2.3 | Sequencing 0.2.6 |
|---|---|---|---|
| Ready, genau ein Eligible / one Eligible | PASS, 1/1/1 | PASS, 1/1/1 | PASS, 1/1/1 |
| Active, genau ein Active / one Active | RIG017: 0 Eligible | RIG017: 0 Eligible | RIG017: 0 Eligible |
| Idle, keine Mitglieder / empty | RIG014 | RIG014 | PASS |

1/1/1 bedeutet ein Manifestziel, eine aktive Datei, ein berechtigtes Ziel.
Das ist eine isolierte Validatorprobe, keine angelegte oder abgenommene Collection.
Ein allein gültiges Sequencing-Manifest beweist keine gültige Collection.

1/1/1 means one manifest target, one active file and one eligible target. This is
an isolated validator probe, not an installed or accepted collection. A valid
standalone sequencing manifest does not prove collection validity.

**B-01:** Alle Collection-Kopien verlangen außerhalb `Completed` genau ein
Eligible-Ziel; das widerspricht dem einzigen tatsächlich aktiven Mitglied.
Owner Thorsten; nächste Aktion: Korrektur in den maßgeblichen Preset-Quellen
beauftragen, versioniert übernehmen und alle drei Kopien in beiden Shells prüfen.
Fällig vor Active-Aktivierung und voller Prozessabnahme; Wiedervorlage spätestens
2026-10-12. Kein erfundenes zweites Ziel, kein falscher Eligible-Status, kein
lokaler Cache-Patch. Bis dahin bleibt dieser Übergang `Blocked`.

**B-01:** Every collection copy requires exactly one Eligible target outside
Completed, conflicting with the single genuinely active member. Owner Thorsten
must commission a source-level versioned correction and retest all three copies
in both shells before activation and acceptance; reassess by 2026-10-12. Do not
invent a second member, mislabel Active as Eligible or patch the installed cache.
The transition remains Blocked until resolved.

**Aufhebungskriterium:** Ein versionierter, autorisiert übernommener Stand muss
in allen drei Collection-Kopien und beiden Shells den tatsächlichen Zustand
einer Ein-Mitglied-Serie als Active/Active ohne erfundenes Eligible-Ziel zulassen.
Ready/Eligible und der tatsächliche Completed-/Archivfall müssen weiterhin gültig
sein; ungültige Mitglieder, Hashes und Zyklen weiterhin abgewiesen werden.
Prüfstand, Ergebnisse und anderes Review dokumentieren, bevor der Owner B-01
schließt. Idle/leer bleibt ausgeschlossen, solange sein Vertrag nicht gesondert
vereinheitlicht ist. Das definiert die Nachweisbedingung, keine hier erfolgte Reparatur.

**Resolution criterion:** An authorized versioned update must let all three
collection copies in both shells accept the genuine single-member Active/Active
state without an invented Eligible target. Ready/Eligible and actual completed
archival must remain valid; invalid members, hashes and cycles must still be
rejected. Record versions, outcomes and another review before the owner closes
B-01. Empty Idle remains excluded until its contract is separately aligned.
These are evidence conditions, not a repair performed here.

**Alternativen:** Idle nicht als gemeinsam validierten Bootstrap verwenden.
Completed ist erst nach tatsächlichem Abschluss und Archivierung zulässig; alle
Mitglieder bleiben mit Herkunft im Manifest. Eine echte, autorisierte Aufnahme
weiterer Intakes löst den grundlegenden Grenzfall nicht zuverlässig.

**Alternatives:** Empty Idle is not a jointly valid bootstrap. Completed requires
actual completion and archival while preserving members/provenance. Adding other
genuinely authorized intakes does not reliably resolve the underlying edge case.

## D-04: Sichere Migration / Safe migration

**Entscheidung:** Bestehende Namen und IDs erhalten. Konfiguration, Index,
Baseline-Verweis, Serienmanifest/-Receipt, Referenzänderungen und Migrationsjournal
gemeinsam vorbereiten. Vorherige Bytes archivieren, Quelle/Target vorher und nachher
binden; erst nach Validierung veröffentlichen. Bei Teilfehler vollständig
zurückrollen oder sichtbar `NeedsRepair` ohne fortsetzbaren aktiven Zustand.

**Begründung:** Policy, Profil, Lastenheft-Plan und Guidance sind im aktuellen
Intake-Review gebunden. Inhaltsänderungen erfordern autorisierte Aktualisierung
und frisches Review, keine bloße Ersetzung gespeicherter Hashwerte.
**Alternative:** Schrittweises Aktivschalten einer halbfertigen Collection verworfen.

**Decision:** Preserve names/IDs, stage the full migration set, archive prior bytes,
bind before/after state and publish only after validation. Roll back completely
or expose NeedsRepair without a resumable active state on partial failure.
**Rationale:** Bound policy/profile/order/guidance changes require authorized updates
and fresh review, not replacement hashes. **Alternative:** Partial live activation
is rejected.

## D-05: PowerShell-Basis / PowerShell base support

**Entscheidung:** Die fünf fehlenden PowerShell-Basisskripte aus dem vorhandenen
Spec-Kit-0.12.8-Paket zunächst in isoliertem Vergleichsbestand prüfen und später
gezielt übernehmen: `common.ps1`, `check-prerequisites.ps1`, `create-new-feature.ps1`,
`setup-plan.ps1`, `setup-tasks.ps1`. Herkunft/Hashes und Bash-Parität dokumentieren.
Keine Produkt-PowerShell-Mindestversion festlegen.

**Begründung:** `.specify/init-options.json` wählt derzeit `sh`; das Paket enthält
beide Varianten. `specify integration upgrade <key> --script ps` aktualisiert
zusätzlich Integrationen, Shared Infrastructure und gegebenenfalls Init-Optionen;
es bietet keinen Dry-run. Deshalb nicht direkt im aktiven Repo ausführen.
**Alternativen:** Vollinitialisierung oder Versionsupgrade sind hierfür unnötig.
Vorhandene Validatoren funktionieren bereits als `.sh`/`.ps1`, benötigen aber
Python 3 unter dem Namen `python3`, auch auf Windows.

**Decision:** Inspect and later import only the five missing PowerShell base
scripts from the installed same-version bundle, with provenance/hashes and Bash
parity. **Rationale:** The repository selects sh but the package contains both
variants. Integration upgrade changes more surfaces and has no dry-run; do not
run it directly in the active checkout. **Alternatives:** Full initialization or
version upgrade is unnecessary. Existing paired validators require python3 on
Windows as well. No product minimum is selected.

## D-06: Agent-Kontext / Agent context

**Korrigierte Entscheidung:** Der [Plan](plan.md) bleibt die technische
Informationsquelle und ist bereits direkt aus der README erreichbar. Die zunächst
erzeugte `agent-context.md` wurde auf Owner-Auftrag ersatzlos entfernt.

**Begründung:** Die Datei enthielt lediglich einen Planverweis und wurde nicht
automatisch als Agent-Guidance geladen. Eine zusätzliche Lesestation bietet hier
keinen Nutzen. Der erfolgte Skriptlauf bleibt als historischer Vorgang in der
[Planprüfung](checklists/plan-validation.md) dokumentiert.
**Alternativen:** Keine erneute Generierung, Ersatzdatei oder Extension-Installation;
die bestehenden hashgebundenen Guidance-Dateien bleiben unverändert.

**Corrected decision:** The plan remains the technical source of information and
is already linked directly from the README. The initially generated agent-context.md
was removed without replacement at the owner's request. **Rationale:** It contained
only a plan reference and was not automatically loaded as agent guidance. The extra
reading step added no value. The validation report retains the script execution as
a historical event. **Alternatives:** No regeneration, replacement file or extension
installation; existing hash-bound guidance files remain unchanged.

## D-07: Nachweise und Plattformen / Evidence and platforms

**Entscheidung:** Bestehende Validatoren plus dokumentierte menschliche/Agent-
Prüfung; keine neue Testplattform. Isolierte Fixture-Abläufe prüfen positive und
negative Fälle. Mac A, Mac B, Windows 11 und Ubuntu 24.04/WSL2 erhalten eigene
vollständige Protokolle. Owner benennt Hostrollen; CI-/Container-Smokes zählen nur
für die tatsächlich geprüfte Teilfläche. Vier Validator-Smokes sind keine vier
vollständigen Prozessläufe.

**Begründung:** Hashvalidatoren können keine Sprachäquivalenz, tatsächliche
Unabhängigkeit des Reviewers, Hilfsmittelnutzung oder Ausführungsbefugnis beweisen.
**Alternative:** Grüne Gesamt-CI oder lokaler PowerShell-Start als Abnahme verworfen.

**Decision:** Use existing validators and documented human/agent review, isolated
positive/negative fixtures and separate complete reports for all four environments.
The owner identifies hosts. CI/container smokes prove only their tested surface.
**Rationale:** Hash validators do not prove language equivalence, reviewer
independence, assistive access or execution authority. **Alternative:** Aggregate
green CI or local PowerShell startup cannot establish acceptance.

## D-08: Dokumentation und Grenzen / Documentation and boundaries

**Entscheidung:** DE zuerst/EN danach in jeder neuen Datei; kein neues Produkt-
oder Schulungsziel. Fachliche Quelle bleibt LH-00; Lastenheft-Plan bleibt
verbindlich. README verlinkt Plan und Prüfanleitung. Statistik wird mit dem nächsten
autorisierten Lieferpaket seriell über den vorhandenen Renderer gepflegt.

**Begründung:** Aktuelle gebundene Nachweise bleiben gültig; historische Dokumente
werden nicht durch technische Planung umgeschrieben. FU01–FU07 und zentrale
Registerausrichtung sind beauftragbare spätere Umsetzungs-/Abnahmearbeit.
**Alternative:** Jetzt alle gebundenen Dokumente übersetzen oder Hashes aktualisieren
würde den Plan-Auftrag überschreiten und das gültige Review veralten lassen.

**Decision:** Keep DE-first/EN-second content in each new file, preserve domain and
order authorities, add README navigation and maintain statistics with the next
authorized delivery using the existing renderer. **Rationale:** Preserve current
bound evidence and historical context; translation and central-alignment follow-ups
remain later work. **Alternative:** Translating/rebinding all inputs now exceeds
planning scope and invalidates the current review.

## Primärquellen im installierten Stand / Installed primary sources

- [Collection-Vorlage / Collection template](../../.specify/presets/intake-authoring-governance/templates/intake-governance-config-template.json)
- [Migrationsjournal / Migration journal](../../.specify/presets/intake-authoring-governance/templates/intake-governance-migration-journal-template.json)
- [Serienmanifest / Series manifest](../../.specify/presets/intake-sequencing-governance/templates/intake-series-manifest-template.json)
- [Serienreceipt / Series receipt](../../.specify/presets/intake-sequencing-governance/templates/intake-series-receipt-template.json)
- [Authoring-Validator / Authoring validator](../../.specify/presets/intake-authoring-governance/scripts/validate-intake-governance-config.py)
- [Review-Validator / Review validator](../../.specify/presets/intake-review-governance/scripts/validate-intake-governance-config.py)
- [Sequencing-Validator / Sequencing validator](../../.specify/presets/intake-sequencing-governance/scripts/validate-intake-governance-config.py)

Die lokal installierten Spec-Kit-Paketpfade sind maschinenabhängig; Version,
Skript-Hash und historischer Lauf des Kontext-Updaters stehen in der Planprüfung.
Die offenen B-01-/Plattform-/Abnahmenachweise sind keine ungelösten Entwurfsfragen.

Installed Spec Kit package paths are machine-specific. The plan validation report
records version, script hash and the historical context-updater execution. B-01, platform
and acceptance evidence remain open implementation work, not unresolved design questions.

## D-09: B-01-Quellenkorrektur und Abnahmestufen / Source fix and acceptance stages

IAD010 vom 2026-10-01 präzisiert D-03: Die lokale Quellenkorrektur in Authoring,
Review und Sequencing erlaubt Active mit null Eligible nur bei mindestens einem
Active-Mitglied. Ready, Completed und alle Schutzprüfungen bleiben erhalten;
Idle/leer ist ausdrücklich nicht Teil der Korrektur. Die D-03-Matrix bleibt ein
historischer Nachweis der installierten Versionen. Diese Installation bleibt
unverändert; B-01 sperrt die tatsächliche Serienaktivierung bis Release,
gezielter Installation und erneuter Prüfung. Native Linux-/Windows-CI ist noch
für den neuen Patch zu erbringen. Werkzeugtests sind keine Projektabnahme.

Kernprozess zuerst auf dem benannten primären Mac; LH-01/LH-02 danach als getrennt
beauftragte Einzelpiloten außerhalb der Serienauswahl. LH-02 setzt LH-01-Abschluss
voraus. Volle LH-00-Abnahme nach LH-02, vor LH-03; alle vier Umgebungen, A11Y,
Übersetzungen und angewendete Registerausrichtung bleiben zwingend. Bis dahin
kein Completed für LH-00. Siehe [IAD010](../../docs/planning/lh00-staged-acceptance-decisions.md).

IAD010 dated 2026-10-01 refines D-03: the local Authoring, Review and Sequencing
source fix permits Active with zero Eligible only when a member is Active.
Ready, Completed and safety checks remain unchanged; empty Idle is excluded.
D-03's matrix remains historical evidence of installed versions. Installation
stays unchanged; B-01 blocks actual series activation until release, targeted
installation and retesting. Native Linux/Windows CI for the new patch is still
pending. Tool tests do not accept the project process.

Prove the core process on the named primary Mac first; then commission LH-01/LH-02
separately as standalone pilots outside series selection. LH-02 requires LH-01
completion. Full LH-00 acceptance follows after LH-02 and before LH-03: all four
environments, accessibility, translations and applied registry alignment remain
mandatory. LH-00 must not be Completed before then. See IAD010 above.
