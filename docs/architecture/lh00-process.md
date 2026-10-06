# Architektur des LH-00-Dateiprozesses / LH-00 file-process architecture

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Kontext / Context

Thorsten beauftragt einen Autor; dieser liest benannte fachliche Quellen und die
Projektregeln. Ein anderer Prüfer bewertet ein Intake unabhängig. Bestehende
Bash-/PowerShell-Validatoren prüfen Datei- und Hashverträge. Fachliche Baseline
ist `docs/Bedienkonzept.md`, Reihenfolge `docs/Lastenheft-Plan.md`. GitHub-Issues
sind Eingaben, keine Ausführungsbefugnis. Das Produkt hat noch keine Laufzeitarchitektur.
The owner commissions an author, who reads named sources and project rules.
A different reviewer assesses the intake. Existing validators check file and hash
contracts. Issues supply requirements; they grant no execution authority.
No product runtime architecture is selected.

## Bausteine und Ablage / Building blocks and storage

1. Profil/Policy regeln Sprache, Ziele, Herkunft und Überschreibschutz.
2. Intake enthält eine fachliche Identität in DE/EN; Schema-2.0-Receipt bindet Quellen/Ziel.
3. Review besitzt einen eigenen Status und seine eigenen Hashbindungen.
4. Eine spätere Collection erhält Index, Reihenfolge, aktive Intakes und Baseline;
   `SeriesManifest` umfasst nur deklarierte Mitglieder. Archive erhalten Vorgänger.
5. Git liefert versionierte Nachweise; Statistik wird separat aus sauberem Baum erzeugt.

Profile/policy govern language, targets and overwrite protection. The intake and
receipt share one identity; review remains separate. Later collection storage
uses an explicit member manifest and predecessor archives. Git records evidence;
statistics require a clean worktree. Existing process/collection contracts under
`specs/001-lh00-intake-process/contracts/` remain authoritative.

## Laufzeit und Deployment / Runtime and deployment

Create: Auftrag prüfen → Quellen strikt lesen → Konflikte klären → neues Ziel
und Receipt schreiben → beide Validatoren → getrennte nächste Review-Aktion. Zwei gespeicherte
Specify-/Autonomous-Folgeprompts bleiben Vorlagen und werden nicht ausgeführt.
Update: Kandidat → bytegenaue Vorgängerarchive → kontrollierte Veröffentlichung
→ neue Hashbindungen → anderes vollständiges Review. Die Veröffentlichung der
heutigen Governance-Kandidaten gehört zu T032, nicht zu diesem Inkrement.
Review/Serie/Archiv sind spätere unabhängige Schritte. Lokale Dateien bilden
keinen Dienst; kein Server, Container oder Netzwerklistener wird ergänzt.
Creation checks authority, strictly reads sources, resolves conflicts, creates a
new target/receipt and validates both shells. Two stored Specify/Autonomous prompt
templates remain inactive; the next separate action is intake review. Updates preserve predecessor bytes
and require fresh independent review. Today's bound-source candidates await T032.
No server, container or network listener is introduced.

## Qualitätsszenarien / Quality scenarios

| Story | Auslöser / Trigger | Erwartung / Expected result | Nachweis / Evidence |
|---|---|---|---|
| US-02 | Leser braucht reine Textausgabe / reader needs text | DE/EN, erklärte Begriffe, Zustände ohne Farbe / equivalent language, explicit states | T019–T022, T050 offen / open |
| US-03 | Quelle/Ziel manipuliert / altered source or target | Hashfehler, kein stilles Überschreiben / reject drift, preserve existing files | T023–T028 offen / open |
| US-04 | Prüfer ist Autor / same author and reviewer | anderes Review statt Selbstfreigabe / separate reviewer required | T029–T033 offen / open |
| US-06 | anderer Host / different host | gleicher Vertrag, Grenzen und Exitcode sichtbar / same contract, explicit limits | lokale Parität T013–T015, native Hosts T039–T044 offen / open |

## Risiken und Schulden / Risks and technical debt

Hashintegrität beweist keine fachliche Richtigkeit. Agenten benötigen einen
begrenzten Auftrag; Validator-Pass erteilt keine Freigabe. Unterbrochene Mehrdatei-
Updates und Konflikte bleiben Gegenstand T023–T033. Heute fehlen native Tests auf
Mac B/Windows/Linux sowie praktische A11Y-Nachweise. Owner Thorsten, Wiedervorlage
2026-10-12, Abschluss nach LH-02/vor LH-03. Keine Restrisiken wurden menschlich akzeptiert.
Hashes do not prove semantic correctness. Multi-file recovery and conflicts remain
later work. Native platforms and assistive tests remain open. No risk acceptance
or final process acceptance is inferred from this increment.

C3A/C5-Anwendbarkeit steht in den zugehörigen Security-Dokumenten; heute kein
Cloud-Service und keine ausgewählten C/AC-Kriterien. Bei Cloud-Scope müssen alle
30 C3A-Gruppen und SI-Auslegung sowie C5 Type 1/2/Unknown und Zeitraum erhalten bleiben.
C3A/C5 assessments are linked from security evidence. Cloud introduction requires
an exact group/control index and assurance type/period, with no inferred conformity.
