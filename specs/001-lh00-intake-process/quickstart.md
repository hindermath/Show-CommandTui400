# Prüfablauf LH-00 / LH-00 validation guide

Diese Anleitung trennt heute mögliche lesende Prüfungen von später beauftragten
Prozessläufen. Befehle aus der Repositorywurzel ausführen. `python3`, `bash`,
`pwsh` und `specify` müssen echte ausführbare Programme sein. Unter Windows gilt
PowerShell zuerst; Bash-Gegenprüfungen erfolgen auf macOS/Linux. Eine fehlende
Voraussetzung als Blocker erfassen, nicht als übersprungenen Erfolg.

This guide separates current read-only checks from later authorized process runs.
Run commands from the repository root. python3, bash, pwsh and specify must work.
Use PowerShell first on Windows and compare Bash on macOS/Linux. Missing
prerequisites are blockers, not skipped successes.

## 1. Heute lesend ausführbar / Available read-only now

```bash
git status --short --branch
specify version
python3 --version
pwsh -NoProfile -Command '$PSVersionTable'
bash .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.sh --receipt specs/intake-authoring-receipts/lh-00.json --repo .
bash .specify/presets/intake-review-governance/scripts/validate-intake-review-result.sh --result specs/intake-review-result.json --repo .
```

```powershell
Get-Command python3, pwsh, specify
python3 --version
pwsh -NoProfile -File .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.ps1 -Receipt specs/intake-authoring-receipts/lh-00.json -Repo .
pwsh -NoProfile -File .specify/presets/intake-review-governance/scripts/validate-intake-review-result.ps1 -Result specs/intake-review-result.json -Repo .
```

Erwartung: Exit 0 mit tatsächlicher Receipt-/Review-Validierung, aktuelles
`ReadyForReview` und separates Review `Ready`. Dies prüft den vorhandenen Input,
keine fertig eingerichtete Collection oder vollständige Prozessabnahme.

Expect exit 0 and actual validation of current receipt/review, with ReadyForReview
and separate Ready review. This checks existing inputs, not an installed collection
or complete process acceptance.

## 2. Vorbereitung späterer Prozessprüfung / Later process-test preparation

Owner beauftragt einen isolierten Testbestand, ein benanntes Beispiel-Issue und
genau ein Test-Intake. Kein LH-01–LH-07 anlegen und LH-00 nicht überschreiben.
Aktuelle Quellen/Policies samt Herkunft in den Testbestand übernehmen, dort gültige
Konfiguration nach [Collection-Vertrag](contracts/collection.md) erstellen.
B-01 vor Active-Prüfung lösen. PowerShell-Basisskripte kontrolliert aus derselben
Version ergänzen. Beide Varianten vor Mutation mit Hilfe/Preview prüfen; bei
Upstream-Befehlen ohne Preview ausschließlich im isolierten Bestand arbeiten.

The owner commissions an isolated test repository, a named sample issue and one
test intake. Do not create LH-01–LH-07 or overwrite LH-00. Copy current sources and
policies with provenance, then create valid test configuration from the contract.
Resolve B-01 before testing Active. Integrate same-version PowerShell scripts
narrowly. Inspect help/preview first; commands without preview run only in isolation.

## 3. Durchgängige Fälle / End-to-end cases

Die Agentenaufträge sind tatsächlich über die installierten gleichnamigen Skills
auszuführen, nicht als Shellbefehle. Pro Plattform genaue Prompts protokollieren.
Receipt/Review-Validatoren aus Abschnitt 1 mit dem erzeugten Testpfad verwenden.
Nicht die gebundenen Produktionsnachweise auf Testdateien umbiegen.

Run named agent actions through the installed skills, not the shell. Record exact
prompts per environment. Validate generated fixture receipts/reviews with the
section 1 commands using fixture paths; do not redirect production evidence.

| Fall / Case | Ausführung und erwartetes Ergebnis / Execution and expected result |
|---|---|
| E01 | `speckit-intake-create`: ausdrücklich benanntes Beispiel-Issue, ein Testziel, Profil show-commandtui400-de-en, nur lokal. Genau Intake + Receipt und keine Folgeaktion / Named sample issue, one fixture target, profile, local only; exactly intake/receipt and no downstream action. |
| E02 | Pflichtabschnitte, identische normative IDs, vollständige DE/EN-Äquivalenz, B2 und beide Folgeprompts prüfen; jede Lücke ist Befund / Check required sections, matching IDs, equivalence, B2 and both prompts; each gap is a finding. |
| E03 | Dokumente/CLI per Tastatur, Screenreader, Braille und Textansicht prüfen; Status/Abhängigkeiten/Entscheidungen/nächste Aktionen ohne Farbe/Diagramm vollständig / Test documents and CLI with keyboard, screen reader, Braille and text access; all relevant information remains available. |
| E04 | Gültiger Receipt in beiden Shells PASS; in separater Fixturekopie ein Inhaltsbyte ändern: Hashfehler. Create auf vorhandenes Testziel: Abweisung und unveränderte Vorher-/Nachher-Bytes. Beauftragtes Update archiviert Vorgänger und erhält Intake-ID / Paired positive validation, tamper rejection, no-overwrite proof, authorized update preserves lineage/identity. |
| E05 | Ein anderer Agent/Mensch führt `speckit-intake-review` aus. ReadyForReview ohne Review, veraltetes Ready und Eligible ohne Auftrag starten nichts. Risikoannahme nur menschlich belegt / Another reviewer; authoring state, stale Ready and unauthorised eligibility never start work; risk acceptance requires human evidence. |
| E07 | Gültige Collection/Serie/Receipt in allen Kopien prüfen; fehlender Pfad, Zyklus, falscher Hash und mehrere Eligible isoliert abweisen. Active-Fall erst nach B-01-Korrektur. Links, unveränderte Plan-IDs/Abhängigkeiten, Archive und FU-Abschluss belegen / Validate collection/series, reject invalid fixtures, test Active only after B-01, evidence links, preserved IDs/dependencies, archives and follow-ups. |
| E06 | E01–E05 und E07 als vollständige Strecke auf jeder der vier Umgebungen durchführen, einschließlich PowerShell-Basis und aller vorgeschriebenen lokalen Schritte. Geteilte plattformunabhängige Übersetzungs-/Zentralbelege referenzieren / Run the complete flow on each environment, including PowerShell base scripts; shared platform-independent translation/central evidence may be referenced. |

Nach autorisiertem Anlegen der echten Collection-/Seriendateien sind diese
lesenden Befehle ausführbar. Gegen den heutigen Bestand fehlen die Dateien;
jetzt ist kein PASS zu erwarten. Für Collection-Prüfungen den Presetnamen zusätzlich
durch `intake-authoring-governance` und `intake-review-governance` ersetzen.

After authorized creation of actual files, run these read-only commands. The files
do not exist today, so no current PASS is expected. Repeat collection checks with
the authoring and review preset names as well.

```bash
bash .specify/presets/intake-sequencing-governance/scripts/validate-intake-governance-config.sh --config requirements/intake-governance-config.json --repo . --json
bash .specify/presets/intake-sequencing-governance/scripts/validate-intake-series-manifest.sh --file specs/intake-series/lh00-process/manifest.json --repo . --json
bash .specify/presets/intake-sequencing-governance/scripts/validate-intake-series-receipt.sh --file specs/intake-series/lh00-process/receipt.json --repo . --json
```

```powershell
pwsh -NoProfile -File .specify/presets/intake-sequencing-governance/scripts/validate-intake-governance-config.ps1 -Config requirements/intake-governance-config.json -Repo . -Json
pwsh -NoProfile -File .specify/presets/intake-sequencing-governance/scripts/validate-intake-series-manifest.ps1 -File specs/intake-series/lh00-process/manifest.json -Repo . -Json
pwsh -NoProfile -File .specify/presets/intake-sequencing-governance/scripts/validate-intake-series-receipt.ps1 -File specs/intake-series/lh00-process/receipt.json -Repo . -Json
```

## 4. Vier Umgebungsprotokolle / Four environment records

| ID | Umgebung / Environment | Geplanter Nachweis / Planned evidence | Jetzt / Now |
|---|---|---|---|
| M-01 | Mac A | `docs/validation/lh00/mac-a.md` | Open |
| M-02 | Mac B | `docs/validation/lh00/mac-b.md` | Open |
| M-03 | Windows 11 nativ / native | `docs/validation/lh00/windows-11.md` | Open |
| M-04 | Ubuntu 24.04 / WSL2 | `docs/validation/lh00/ubuntu-wsl2.md` | Open |

Owner: Thorsten; anderer benannter Reviewer je Protokoll. Vor voller Abnahme
abschließen, spätestens 2026-10-12 neu bewerten. Jedes Protokoll bindet Commit,
Kandidatenhashes, Plattform/Runner, Toolversionen, Kommandos/Prompts, Exitcodes,
Payload-SHA-256, Entscheidungs-SHA-256 und tatsächliche Schreibgrenze. Bei
Safe-mode-Smokes `zeroWrite` nur nach Vorher-/Nachhervergleich bestätigen;
autorisierte Fixture-Mutationen ausdrücklich als solche protokollieren.
Native CI/isolierter Linux-Container kann fehlende Teilnachweise ergänzen,
ersetzt aber nicht automatisch eine der vier vollständigen Projektumgebungen.

Thorsten owns each report with another named reviewer. Complete before full
acceptance and reassess by 2026-10-12. Bind commit, candidate hashes, runner/platform,
versions, commands/prompts, exits, payload/decision hashes and actual write boundary.
Claim zeroWrite for safe-mode smokes only after before/after comparison; clearly
record authorized fixture mutations. Native CI or an isolated Linux container can
supplement partial evidence but does not automatically replace a required environment.

## 5. Repositoryprüfungen / Repository checks

Bei tatsächlichen Änderungen passende Prüfungen ausführen; kein Produkt-Build
existiert. Statistik schreibt nur der Renderer im autorisierten Lieferpaket.

Run checks appropriate to actual changes; no product build exists. Only the
renderer updates statistics during an authorized delivery.

```bash
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
python3 scripts/tests/test_spec_kit_agent_surface_parity.py
bash scripts/render-project-statistics.sh --repo . --check-only
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
git diff --check
```

Nach Review-/Quelländerungen alle betroffenen Hashbindungen erneut prüfen. Kein
Commit, Push, PR, Merge oder nächstes Lastenheft folgt aus dieser Anleitung.

Revalidate affected bindings after review/source changes. This guide grants no
commit, push, PR, merge or next-intake authority.
