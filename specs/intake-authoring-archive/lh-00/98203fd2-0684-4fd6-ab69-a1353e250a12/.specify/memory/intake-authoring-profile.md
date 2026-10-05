# Lastenheft-Profil / Intake profile

## Identität und Zielgruppe / Identity and audience

Ein Projektprofil definiert Schreib- und Ablageregeln für Lastenhefte.
Profil-ID: `show-commandtui400-de-en`. Gilt für ausdrücklich beauftragte
Lastenhefte dieses Projekts. Fachlicher Owner: Thorsten Hindermann. Autoren
und spätere Implementierende brauchen keine vorherigen Spec-Kit-Kenntnisse.
Grundkenntnisse von Dateien, Terminal und PowerShell werden vorausgesetzt;
ein bestimmter Ausbildungsberuf oder ein Ausbildungsjahr wird nicht vorausgesetzt.
Ein Intake ist ein fachliches Lastenheft, ein Receipt dessen Herkunftsnachweis.

A project profile defines writing and storage rules for intakes.
Profile ID: `show-commandtui400-de-en`. Applies to explicitly commissioned
project intakes. Thorsten Hindermann is the subject owner. Authors and later
implementers need no prior Spec Kit knowledge. Basic knowledge of files,
terminals and PowerShell is assumed, but no training occupation or training year.
An intake describes requirements; its receipt records provenance.

## Sprache und Pflichtinhalt / Language and required content

Deutsch (`de-DE`) zuerst, Englisch (`en`) direkt nach dem entsprechenden
Abschnitt, ungefähr CEFR B2. Eine Datei und eine fachliche Identität für beide
Sprachen; gleiche FR-/AC-/OD-IDs bezeichnen Übersetzungen, keine Zusatzanforderungen.
Überschriften verwenden DE / EN. Begriffe bei erster Verwendung erklären.
Zweck, Ist-/Zielzustand, Scope, Nicht-Ziele, atomare Anforderungen, Qualität,
Governance, Abhängigkeiten, Risiken, Artefakte, Nachweise, messbare Abnahme,
Annahmen, Entscheidungen und beide kopierfertigen Folgeprompts sind Pflicht.

German (`de-DE`) comes first, followed directly by the matching English (`en`)
section, at about CEFR B2. Both languages share one file and one identity.
Repeated FR/AC/OD identifiers identify translations, not additional requirements.
Use DE / EN headings and explain terms on first use. Purpose, current/target
state, scope, non-goals, atomic requirements, quality, governance, dependencies,
risks, artefacts, evidence, measurable acceptance, assumptions, decisions and
both copy-ready follow-up prompts are mandatory.

## Begriffe / Terms

Spec Kit unterstützt Anforderungen, technische Planung und Prüfungen. Ein
Preset ist ein versioniertes Paket aus Regeln, Vorlagen, Kommandos und
Prüfwerkzeugen. Eine Integration stellt Kommandos für eine Agentenumgebung
bereit. FR bezeichnet Anforderungen, AC Abnahmekriterien, OD Entscheidungen.
Ein Tombstone ist ein dauerhaftes Kennzeichen, dass ein früherer Intake
archiviert oder gelöscht wurde. Die Herkunft bleibt damit nachvollziehbar.

Spec Kit supports requirements, technical planning and checks. A preset is a
versioned package of rules, templates, commands and validators. An integration
exposes commands for an agent environment. FR identifies requirements, AC
acceptance criteria and OD decisions. A tombstone permanently records that an
intake was archived or deleted, preserving its provenance.

## Benennung und Reihenfolge / Naming and order

Ziel: `intakes/LH-NN.md`; Receipt: `specs/intake-authoring-receipts/lh-nn.json`.
Explizites Ziel hat Vorrang vor Profilregel und generischem Preset-Fallback.
Plan-IDs sind keine Issue-Nummern. `docs/Lastenheft-Plan.md` ist die einzige
verbindliche Reihenfolge; Issue-Entwürfe sind kein aktiver Intake-Bestand.
Aktuell wird nur LH-00 erzeugt. Quellenreihenfolge verleiht keinen stillen Vorrang.
Für Änderungen an existierenden Zielen `speckit-intake-update` verwenden.
Löschung erfolgt nur mit eigener Autorität über Archiv und Tombstone.

Target: `intakes/LH-NN.md`; receipt: `specs/intake-authoring-receipts/lh-nn.json`.
An explicit target takes precedence over this profile and the generic fallback.
Plan IDs are not issue numbers. The intake order document is the only binding
order; issue drafts are not active intakes. Only LH-00 is created now. Source
order gives no silent precedence. Existing targets require intake-update;
deletion requires separate authority, archival and a tombstone.

## Sammlung und Nachweise / Collection and evidence

Eine Collection ist eine verwaltete Sammlung von Anforderungsdokumenten.
Ein Serienmanifest listet die Mitglieder einer Serie mit Reihenfolge,
Abhängigkeiten und Status maschinenlesbar auf. Die vier portablen Rollen
benennen Index, Reihenfolge, aktive Intakes und Baseline; sie sind keine
Personenrollen. Der kanonische Index ist die maßgebliche Bestandsübersicht.
`DirectoryStrict` gleicht die aktiven Dateien vollständig mit der Serie ab;
`SeriesManifest` erlaubt zusätzlich eigenständige Intakes außerhalb der Serie.
`Eligible` kennzeichnet ein nach seinen Abhängigkeiten auswählbares Ziel,
erteilt aber keine Ausführungsfreigabe. Lifecycle bezeichnet die geregelten
Übergänge zwischen Bearbeitungszuständen und Ablagen.

Das Profil unterstützt zunächst eigenständige Intakes ohne Serienbindung.
Keine Requirements-Collection-Konfiguration und kein Serienmanifest werden
vorgetäuscht. Die vier portablen Rollen, sechs Collection-Pfade, kanonischer
Index, `DirectoryStrict`/`SeriesManifest`, Archiv und Lifecycle-Übergänge werden
im späteren LH-00-Prozessnachweis konkretisiert. Vorher sind Serienstatus und
Eligible-Auswahl nicht nachgewiesen. Vorhandene Namen werden nicht umbenannt.

A collection is a managed set of requirement documents. A series manifest
provides a machine-readable list of members, order, dependencies and status.
The four portable roles name the index, order, active intakes and baseline;
they do not identify people. The canonical index is the authoritative inventory.
DirectoryStrict matches all active files to the series; SeriesManifest also
allows standalone intakes outside it. Eligible marks a target selectable by
its dependencies but grants no execution authority. Lifecycle means the
controlled transitions between work states and storage locations.

The initial profile supports standalone intakes without series binding.
It does not claim an installed requirements collection or series manifest.
The four portable roles, six collection paths, canonical index, inventory mode
(`DirectoryStrict` or `SeriesManifest`), archive and lifecycle transitions will
be established during later LH-00 process work. Series status and eligible
selection are not proven yet. Existing names are preserved.

## Qualitäts- und Berechtigungsgrenzen / Quality and authority boundaries

Die [Governance-Zuordnung](../../docs/intake-governance.md) gilt vollständig.
Status, Abhängigkeiten, Entscheidungen und nächste Aktion müssen in Text
verständlich sein. Hilfreiche Abläufe erhalten Mermaid plus gleichwertige
Textalternative; eine Nichtanwendung wird begründet. WCAG 2.2 AA soweit passend,
Tastatur, Screenreader, Braille und Textbrowser berücksichtigen. NIST SSDF und
CWE Top 25 gelten immer; weitere Standards mit Anwendbarkeit und Begründung.
Beide installierten Receipt-Validatoren müssen bestehen. Strukturprüfung ist
keine semantische, menschliche oder plattformübergreifende Produktabnahme.

The linked governance mapping applies in full. Status, dependencies, decisions
and the next action must be understandable in text. Useful flows use Mermaid
and equivalent text; explain justified omission. Apply WCAG 2.2 AA where relevant
and consider keyboard, screen readers, Braille and text browsers. NIST SSDF and
CWE Top 25 always apply; assess other standards explicitly. Both installed
receipt validators must pass. Structural validation does not prove semantic,
human or cross-platform product acceptance.

Öffentliche HTTPS-Quellen nur einzeln benannt, ohne Authentifizierung,
JavaScript oder Crawl abrufen; sichere Ziele und Weiterleitungen vorab prüfen.
UTF-8, Dateigrenzen, Größenlimits, Hashbindung und Überschreibschutz des Presets
gelten unverändert. `ReadyForReview` / `Enabled` folgt nur bei geklärten
Authoring-Entscheidungen; sonst `NeedsClarification` / `Blocked`.
Erst separates Intake-Review kann `Ready` oder `ReadyWithAcceptedRisks` liefern;
akzeptierte Risiken brauchen menschliche Zustimmung. `LocalImplementation` ist
nur die Vorgabe des späteren Autonomous-Prompts, kein aktueller Laufauftrag.
Dieses Profil allein erlaubt keine Commits, Remote-Schreibzugriffe, Reviews oder
Folgeläufe. Maßgeblich ist der ausdrückliche Auftrag; historische Reparatur- und
Lieferbefugnisse stehen in `docs/planning/lh00-repair-decisions.md`.
Der historische lokale Update-/Review-Auftrag IAD010 steht in
`docs/planning/lh00-staged-acceptance-decisions.md`. Der aktuelle Auftrag IAD011
steht in `docs/planning/lh00-preflight-refresh-decisions.md`: Nachweise aktualisieren,
unabhängig prüfen, Plan/Tasks abgleichen und Preflight lesen; kein Feature-Lauf,
Release, Remote-Rollout, Commit oder Tool-/Routing-Refresh.

Fetch only individually named public HTTPS sources without authentication,
JavaScript or crawling; check targets and redirects first. Preserve the preset's
UTF-8, containment, size, hash and overwrite protections. Use ReadyForReview /
Enabled only after authoring decisions are resolved; otherwise use
NeedsClarification / Blocked. Only a separate intake review can grant Ready or
ReadyWithAcceptedRisks, with human acceptance of risks. LocalImplementation is
the later Autonomous prompt default, not a current execution request. This profile
alone grants no commits, remote writes, reviews or downstream runs. Explicit
requests govern authority; historical repair and delivery decisions are recorded
in docs/planning/lh00-repair-decisions.md. Historical IAD010 is recorded in docs/planning/lh00-staged-acceptance-decisions.md.
Current IAD011 in docs/planning/lh00-preflight-refresh-decisions.md authorizes
evidence refresh, independent review, plan/task reconciliation and read-only
preflight, with no feature run, release, remote rollout, commit or tool/routing refresh.
