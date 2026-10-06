# Baseline-Integrität prüfen / Check baseline integrity

Owner Thorsten; Autor Codex; Review T012. Stand 2026-10-06; Wiedervorlage 2026-10-12.

In der Projektwurzel ausschließlich das Baseline-Gate prüfen:
Run only the baseline gate from the project root:

```sh
pwsh -NoProfile -File .specify/presets/secure-development-assurance-governance/scripts/validate-secure-development-assurance.ps1 -Action Review -Gate baseline -ContextId lh00-process -Mode development
```

Exit 0 bestätigt echte Manifest-/Versions-/Hashbindung. Bei Fehler nichts
freigeben; genaue Drift-/Pfadmeldung beheben, Owner Thorsten informieren und
erneut prüfen. Keine Hashänderung ohne nachvollziehbare neue Snapshot-Quelle.
Kein Full-context Status: Closure/Image-Impact und Prozessabnahme fehlen noch.
Exit zero proves baseline binding integrity. A failure grants no readiness;
resolve its exact source/path issue with the owner and repeat the check. Never
replace hashes without a traceable new snapshot. This is not a full-context
status check or process acceptance.
