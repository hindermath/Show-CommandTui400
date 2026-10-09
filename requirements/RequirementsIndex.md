# Lastenheft-Bestand / Requirements inventory

Stand 2026-10-09; Owner Thorsten. Die [verbindliche Reihenfolge](../docs/Lastenheft-Plan.md)
bleibt unverändert. Plan-IDs sind keine Issue-Nummern.
The binding order remains unchanged; plan IDs differ from issue numbers.

| Plan-ID | Issue | Intake | Abhängigkeit / Dependency |
|---|---|---|---|
| LH-00 | [Issue 1](https://github.com/hindermath/Show-CommandTui400/issues/1) | [LH-00](../intakes/LH-00.md); offen / open | keine / none |
| LH-01 | [Issue 2](https://github.com/hindermath/Show-CommandTui400/issues/2) | [LH-01](../intakes/LH-01.md); Einzelpilot / standalone pilot | LH-00; begrenzter Einzelpilot vor Vollabnahme / limited standalone pilot before full acceptance |
| LH-02 | [Issue 3](https://github.com/hindermath/Show-CommandTui400/issues/3) | Nicht erstellt / Not created | LH-01 Completed; Einzelpilot / standalone pilot |
| LH-03 | [Issue 4](https://github.com/hindermath/Show-CommandTui400/issues/4) | Nicht erstellt / Not created | LH-02 Completed + volle LH-00-Abnahme / full acceptance |
| LH-04 | [Issue 5](https://github.com/hindermath/Show-CommandTui400/issues/5) | Nicht erstellt / Not created | LH-03 |
| LH-05 | [Issue 6](https://github.com/hindermath/Show-CommandTui400/issues/6) | Nicht erstellt / Not created | LH-03, LH-04 |
| LH-06 | [Issue 7](https://github.com/hindermath/Show-CommandTui400/issues/7) | Nicht erstellt / Not created | LH-01, LH-05 |
| LH-07 | [Issue 8](https://github.com/hindermath/Show-CommandTui400/issues/8) | Nicht erstellt / Not created | LH-06 |

Aktive Intakes insgesamt: 2; davon Serienmitglieder: 1; eigenständig: 1.
Eine Ein-Mitglied-Serie; Ready/Eligible ist auswählbarer Bootstrap, keine
Ausführungsbefugnis und kein Completed. Archiv/Backlog/History: jeweils 0 Intakes;
README-Dateien sind Ablageerklärungen. LH-01 und LH-02 bleiben vorläufig außerhalb
der automatischen Serie, benötigen eigene Aufträge, gültige Intakes, andere Reviews
und begrenzte Owner-Pilotfreigabe. LH-03 folgt voller LH-00-Abnahme nach LH-02.

Total active intakes: 2; series members: 1; standalone: 1. One single-member
series, with Ready/Eligible bootstrap only. No execution permission or completion.
Archive/backlog/history hold zero intakes; their README files describe storage.
LH-01/LH-02 are separately commissioned standalone pilots; LH-03 requires full
LH-00 acceptance after LH-02. Version archives remain authoritative in specs.

## Zählgrenze der installierten Validatoren / Validator counting boundary

Fachliche LH-Dateien in Archiv/Backlog/History: jeweils 0. Die installierten
Collectionvalidatoren zählen dort alle Dateien einschließlich je einer README:
archiveIntakeCount=1, backlogIntakeCount=1, historyIntakeCount=1. Diese Maschinen-
felder sind hier Datei-Artefaktzahlen, kein fachlicher Abschluss/Backlog-Intake.
Aktive LH-Dateien: 2; Serienmitglieder: 1; eigenständig: 1. Keine
Schema-/Validatoränderung wird aus dieser dokumentierten Zählgrenze abgeleitet.

Each storage collection has zero domain LH documents but one README artifact.
The installed fields above count all files, including README, so each reports 1.
Those values do not create domain intakes or completion. Active/member counts
are 2/1, standalone 1. Keep the existing schema/validators unchanged.
