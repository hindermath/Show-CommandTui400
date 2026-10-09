# LH-01 Sicherheitsqualität / Security quality scenarios

Stand / Date: 2026-10-09. Owner Thorsten. Szenarien sind Produkt-Sollprüfungen;
bestehende Fixture ist begrenzte Machbarkeit, kein Produkt-PASS.

| Fall / Case | Auslöser / Stimulus | Soll / Expected observation | Evidence |
|---|---|---|---|
| Q01 | Redirect/ungeeigneter Host / unsuitable host | Vor Init ablehnen; Nullwirkung / reject before mutation | N01–N04; E01-01/06; T021/T026 |
| Q02 | Unbekannte oder falsche Kontextaktion / invalid action | Whitelist UND Kontext blockieren getrennt / independent allow-list and context checks | N05/K01; E01-02/06; T037/T043 |
| Q03 | Steuerzeichen in Text / hostile display text | Lesbarer Ersatz, keine Terminalinjektion / safe visible representation | N07; E01-03/06; T024 |
| Q04 | Ende/Abbruch/Fehler / exit/cancel/error | Modi/Cursor und Shellinput erhalten / restore modes/cursor and input | S02–S05; E01-04; T035 |
| Q05 | Restore scheitert / restoration fails | Fail, beide Fehler, Stop positiver Läufe / Fail, both errors, stop positives | S07 separate failure run; E01-04/06; T028/T029 |
| Q06 | Resize/zu klein / small view | Werte/Fokus erhalten, sichere Rückkehr / retain state and safe exit | V01/V02; E01-05; T048/T051 |
| Q07 | Manipulierter Prüfplan/Pfad / altered proof plan | Blocked, kein Eval/Install/Outputausbruch / no evaluation/install/path escape | PF01/EV01; E01-06/07; T029/T054 |

T017 prüft vollständige Planungs-/Startnachweise, nicht diese späteren Produktläufe.
Prüfer meldet Soll/Ist, Exitcodes, Hashes und Grenzen; Owner nimmt separat ab.

T017 validates readiness documentation, not future product runs. Record expected/
observed outcomes, exits, hashes and scope; owner acceptance remains separate.

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Owner Thorsten; Zielgruppe Implementierende und unabhängige
Prüfer. DE zuerst/EN danach, ungefähr B2; sourceOnly, kein Home-Sync. Leserpfad:
Spec/Plan → Architektur/Sicherheit → Startreview → aktuelles Intake-Review.
Neubewertung bei geändertem Scope, Paket, Treiber, Host oder Freigabe.

**UpdateRequired.** Thorsten owns these bilingual source-only records for authors
and distinct reviewers. Follow specification/plan → architecture/security → start
review → current intake review. No Home sync; reassess changed scope or baseline.
