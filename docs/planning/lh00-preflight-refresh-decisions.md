# LH-00: Nachweis- und Planaktualisierung / Evidence and plan refresh

Stand / Date: 2026-10-05. Owner: Thorsten Hindermann. Entscheidung / Decision: IAD011.

## Auftrag / Authority

Der Owner hat die drei angezeigten Vorbereitungsschritte ausdrücklich mit
„Diese 3 Schritte bitte ausführen.“ beauftragt: LH-00-Nachweise einschließlich
nachvollziehbarem Intake-Update und frischem unabhängigem Review aktualisieren;
Plan/Tasks gezielt an die neue Governance und die B-01-Lieferung angleichen;
anschließend Analyze und den lesenden Preflight durchführen.
Ein separater Agent prüft den Intake gemäß IAD009. Der ausführende Hauptagent
aktualisiert die Dokumente und prüft deren Konsistenz. Kein Commit, Push, PR,
Merge, Release, Tool-Installations-/Routing-Refresh oder Implementierungslauf
gehört zu diesem Auftrag. Historische Lieferbefugnisse werden nicht wiederverwendet.

The owner explicitly requested the three displayed preparation steps: update
LH-00 evidence through a governed intake update and fresh independent review;
reconcile plan/tasks with new governance and delivered B-01 releases; then run
Analyze and read-only preflight checks. Under IAD009 a separate agent reviews
the intake; the main agent authors the update and checks consistency. This
request includes no commit, push, PR, merge, release, tool installation, routing
refresh or implementation run. Historical delivery authority is not reused.

## Erklärte Änderungen / Explained changes

Das bisherige Receipt db6043c8-2ddc-477c-a045-1c3621762660 scheitert an geänderten
Quellenhashes für docs/intake-governance.md und docs/Entwicklungsumgebung.md.
Die gelieferten PRs #21/#22 aktualisierten Governance/Preset-Bezüge; PR #23
fügte den Preflight hinzu; PR #24 ergänzt die stabile Assurance-0.1.3-Veröffentlichung. Auch Constitution und Guidance sind neuer als die
historischen Bindungen. Die Dateien und alten Ergebnisse werden nicht bloß
neu datiert: Vorgänger bleiben bytegleich archiviert, neue Quellen werden
geordnet gebunden und semantisch erneut geprüft. Der alte Review-Validator
meldet zwar PASS für das unveränderte Ziel, prüft aber nicht sämtliche erweiterten
Quell-/Governance-Bindungen. Dieser PASS hebt den Receipt-Fehler nicht auf.

The old receipt fails on changed source hashes for the governance and development
environment documents. Delivered PRs #21/#22 updated governance and preset
references; PR #23 added the preflight; PR #24 records stable Assurance 0.1.3. Constitution and guidance also changed.
Preserve predecessors byte-for-byte, bind ordered current sources and repeat
semantic review rather than replacing dates/hashes alone. The old review validator
passes the unchanged target but does not validate every extended source/governance
binding; that PASS cannot cancel the receipt failure.

## IAD011: Umfang und Nachweise / Scope and evidence

Die zwölf FR-00-, neun AC-00- und bisherigen OD-/IAD-IDs sowie IAD010 bleiben
fachlich erhalten. Aktuelle Releases: Security 0.7.0, Architecture 0.6.1,
Authoring 0.3.6, Review 0.2.4, Sequencing 0.2.7. Quellen-Lock, Projektmatrix und
Pilotnachweis belegen die Lieferung; T034–T036 werden damit abgeglichen, ohne
ungeprüfte Restarbeiten als erledigt zu markieren oder Presets neu zu installieren.
Vor tatsächlicher Serienaktivierung verbleiben ein vollständiger installierter
Lifecycle-Nachweis und dessen anderes Review/Owner-Entscheid, soweit nicht schon
vollständig belegt. Keine reale Collection oder Serie wird hier angelegt.

All twelve FR-00, nine AC-00 and existing OD/IAD identifiers, including staged
acceptance IAD010, retain their domain meaning. Current releases and source-lock,
project matrix and pilot evidence prove delivery. Reconcile T034–T036 without
claiming incomplete work done or reinstalling presets. Before real series
activation complete any still-missing installed lifecycle evidence and separate
review/owner decision. This preparation creates no live collection or series.

Regulatorische Anwendbarkeit trennt Beispielprodukt, Entwicklungswerkzeuge und
Organisation; unbekannte Jurisdiktionen, Rollen und direkte/vertragliche Pflichten
bleiben Open. Ausbildungszweck und Produkt-AI-SBOM N/A sind keine Ausnahme.
Bei anwendbarem C5 Type 1, Type 2 und Unknown unterscheiden; bei C3A die exakten
C/AC-IDs und SI-Auslegung bewahren. Es entsteht keine Rechts-/Risikofreigabe.
Jahresreview: 2027-10-03, 10:00 Europe/Berlin, nur lesend; kein weiterer Rollout.

Separate sample product, development tooling and organisation when assessing
regulatory scope; unknown jurisdictions, roles and direct/contractual duties
remain Open. Education and product AI-SBOM N/A grant no exemption. If C5 applies,
distinguish Type 1, Type 2 and Unknown; retain exact C/AC IDs and SI interpretation
for applicable C3A. No legal/risk approval or further rollout is granted. Annual
read-only review remains due 2027-10-03 at 10:00 Europe/Berlin.

## Dokumentationsauswirkung / Documentation impact

UpdateRequired; sourceOnly; Owner Thorsten. DE zuerst/EN danach, ungefähr B2.
Leserpfad: LH-00 → Receipt/Review → Spec/Plan/Tasks → Preflight-Nachweis.
Reevaluation: Quell-, Tool-, Scope- oder Autoritätsänderung; spätestens vor Umsetzung.
Historische Prüfberichte behalten Datum und damalige Grenzen. Der neue
Preflight-Bericht liegt in specs/001-lh00-intake-process/checklists/preflight-20261005.md.

UpdateRequired; sourceOnly; owner Thorsten; German first, English second, about B2.
Reader path: intake → receipt/review → spec/plan/tasks → preflight evidence.
Reassess on changed sources, tools, scope or authority and before implementation.
Preserve historical reports and their original dates/limits. Record current
checks separately in the named preflight report.
