# Lokale LH-00-Validierung / Local LH-00 validation

Datum / Date: 2026-09-28. Owner: Thorsten Hindermann.
Prüfer / Checker: ausführender Agent / executing agent.
Dokumentationsentscheidung / Documentation decision: **UpdateRequired**.

Dieser Bericht hält den lokalen Authoring-Stand vor der späteren Lieferung fest.
Aktuelle Veröffentlichung und erweiterte Autorität: [Liefernachweis](issue-publication.md).

This report preserves local authoring evidence before later delivery. See the
linked delivery record for publication and extended authority.

## Umfang und Ergebnis / Scope and result

Ein lokales Authoring-Arbeitspaket: Governance-Ausrichtung, acht Issue-Entwürfe,
minimales Profil, genau [LH-00](../intakes/LH-00.md) und ein
[Receipt](../specs/intake-authoring-receipts/lh-00.json). Keine Produktimplementierung,
kein gesondertes Intake-Review, kein Spec-Kit-Feature-Lauf. Die nachfolgenden
Prüfungen belegen nur ihren genannten Umfang; offene Produkt-/Prozessnachweise
stehen in der [Governance-Zuordnung](intake-governance.md).

One local authoring work package: governance alignment, eight issue drafts, a
minimal profile, exactly LH-00 and one receipt. No product implementation,
separate intake review or Spec Kit feature run. Checks prove only their stated
scope; open product/process evidence is recorded in the governance mapping.

## Prüfungen / Checks

| Prüfung / Check | Ergebnis / Result | Grenze / Boundary |
|---|---|---|
| Authoring-Receipt, Bash | PASS, Exit 0 | ReadyForReview, sieben Quellen / seven sources |
| Authoring-Receipt, PowerShell | PASS, Exit 0 | Derselbe Intake und Receipt / same intake and receipt |
| Exakte Presetmatrix / Exact preset matrix | PASS, Exit 0 | 14 Presets; Authoring 0.3.5, Priorität / priority 64 |
| Secret-Scan | PASS, Exit 0; high=0, medium=0 | Agentenflächen und Git-Diff / agent surfaces and Git diff |
| PSScriptAnalyzer 1.25.0 | PASS, Exit 0; 72 Dateien / files | Keine Error-/Warning-Befunde / no error or warning findings |
| Homogenität / Homogeneity | Exit 1: 27/29, 93%; 1 FAIL, 1 WARN | Statistikdrift im uncommitteten Baum; Warnung der ignorierten STATS.md / statistics drift in uncommitted tree; ignored STATS.md warning |
| Zentrales Patch-Vorschaubild / Central patch preview | PASS, git apply --check, Exit 0 | Nur geprüft, nicht angewendet / checked only, not applied |
| Struktur, Links, DE/EN-IDs / Structure, links, bilingual IDs | PASS: 29 Dateien / files; 8 Issue-Entwürfe / drafts; 12 FR und / and 9 AC in beiden Sprachen / both languages | Dateilinks, IDs, Abhängigkeiten, JSON, fünf gleiche Guidance-Dateien, zwei gleiche Constitutions und Kontext-Hashes / file links, IDs, dependencies, JSON, guidance/constitution parity and context hashes |
| Kontrollierte Ziel-/Quellhash-Drift / Controlled target/source hash drift | PASS: beide Validatoren lehnen beide Abweichungen mit Exit 2 ab / both validators reject both changes with exit 2 | Isolierte Kopien; Originale unverändert / isolated copies, originals unchanged |
| Secret-Scan aller neuen und geänderten Dateien / All candidate-file secret scan | PASS: gitleaks dir, Exit 0 | Einschließlich ungetrackter Dokumente; keine gefundenen Secrets / including untracked documents; no detected secrets |

## Reproduzierbare Kommandos / Reproducible commands

Aus dem Repository-Verzeichnis ausführen. Beide Receipt-Validatoren verändern
weder Receipt noch Quellen. Die Validatoren prüfen strukturierte Evidence,
keine vollständige semantische oder assistive Abnahme.

Run from the repository root. Both receipt validators leave the receipt and
sources unchanged. They validate structured evidence, not full semantic or
assistive acceptance.

Die Negativprüfung wurde mit Kopien in einem temporären Verzeichnis ausgeführt:
jeweils eine zusätzliche Textzeile im Intake beziehungsweise in einer Dateiquelle,
danach beide Validatoren. Alle vier Läufe erkannten die abweichende Prüfsumme.
Der zusätzliche Secret-Scan verwendete Kopien aller 29 neuen/geänderten Dateien,
einschließlich der ungetrackten Dateien. Diese Tests schreiben keine Evidence
eines gesonderten Intake-Reviews.

Negative checks used temporary copies: append one line to the intake or one
file source, then run both validators. All four runs detected the changed hash.
The extra secret scan covered copies of all 29 new/changed files, including
untracked files. These checks create no separate intake-review evidence.

```bash
bash .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.sh --receipt specs/intake-authoring-receipts/lh-00.json --repo .
pwsh -NoProfile -File .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.ps1 -Receipt specs/intake-authoring-receipts/lh-00.json -Repo .
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
git diff --check
```

## Statistik und bestehende Warnung / Statistics and existing warning

Die Baseline war vor Bearbeitung `CURRENT`, Quellstand `309c6fb3d138`, 97.996
Textzeilen, zwei Git-Aktivtage. Nach lokalen Dokumentänderungen meldet der
Homogenitätsprüfer erwarteten Statistikdrift. Der Renderer verlangt für einen
schreibenden Lauf einen sauberen Baum. Der Auftrag schließt Commits aus; deshalb
bleibt der generierte Block unverändert, während das Fortschreibungsprotokoll
das lokale Authoring kennzeichnet. Eine spätere Lieferung muss committen,
regulär rendern und erneut prüfen; der aktuelle Homogenitätslauf ist kein PASS.

Before editing, the baseline was CURRENT at source 309c6fb3d138 with 97,996 text
lines and two Git-active days. Local document changes produce expected statistics
drift. Writing with the renderer requires a clean tree. This task excludes
commits, so the generated block stays unchanged while the ledger records local
authoring. Later delivery must commit, render normally and recheck. The current
homogeneity run is not a pass.

Die zweite Meldung ist `STATS.md: bilingual-section-missing`. Diese kleine
maschinelokale Datei ist ignoriert und wurde nicht verändert. Sie ist nicht
das versionierte Profil-2-Ledger. Keine Validatorregel wurde abgeschwächt.

The other finding is STATS.md: bilingual-section-missing. That small machine-local
file is ignored and was not changed; it is not the tracked Profile-2 ledger.
No validator rule was weakened.

## Herkunft, Freigaben und Übergabe / Provenance, authority and handoff

Sieben geordnete Quellen, sieben beantwortete Planentscheidungen, null neue
Fragen in diesem Ausführungspass. Der öffentliche Issue-1-Snapshot wurde per
HTTPS ohne Authentifizierung, JavaScript oder Crawl gelesen; Größe, HTTP-Metadaten,
Weiterleitungen und Hashes stehen im Receipt. Der eingebettete Issue-Text wurde
gegen die Entwurfsgrundlage verglichen. Remote-Snapshots beweisen keine spätere
Quellfrische. Rohdaten und Prüflogs bleiben temporär, außerhalb des Repositories.

Seven ordered sources, seven resolved planning decisions and no new questions
in this execution pass. The public issue-1 snapshot was fetched over HTTPS
without authentication, JavaScript or crawling. The receipt records size, HTTP
metadata, redirects and hashes. Its embedded body was compared with the drafting
input. Remote snapshots do not prove later source freshness. Raw responses and
check logs remain temporary outside the repository.

`LocalImplementation` ist nur der Presetdefault des späteren Autonomous-Prompts.
Aktuelle Autorität: lokale Erstellung; keine Commits, Remote-Änderungen oder
Folgeläufe. Die acht Entwürfe sind nicht veröffentlicht; der Level-0-Patch ist
nicht angewendet. Einziger nächster fachlicher Schritt, nicht ausgeführt:

LocalImplementation is only the later Autonomous prompt's preset default.
Current authority is local authoring, without commits, remote changes or
downstream runs. Eight drafts remain unpublished; the Level-0 patch is not
applied. The sole next domain action, not executed, is:

```text
$speckit-intake-review intakes/LH-00.md
```
