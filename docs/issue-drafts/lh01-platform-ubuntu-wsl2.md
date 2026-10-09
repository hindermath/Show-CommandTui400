# LH-01 Hand-off: Ubuntu 24.04 — WSL2 / Platform proof

Eltern-Issue / Parent issue: [#36](https://github.com/hindermath/Show-CommandTui400/issues/36)

**Ziel / Target:** `ubuntu-wsl2`. **Hostvertrag:** Ubuntu24.04 in WSL2, PowerShell Linux; wsl --list --verbose im Windows-Host lesen, Distro/Kernel/WSL-/Hostversion erfassen.

**Host contract:** Ubuntu24.04/WSL2 Linux PowerShell; read WSL inventory from Windows host and record distro/kernel/WSL/host versions.

## DE — Agentenauftrag

Lies dieses Issue, das Eltern-Issue und den versionierten Vertrag unter
`docs/validation/lh01/platform-handoff.md` samt `platform-handoff.json`.
Nur ein ausdrücklicher Prüfauftrag für diesen Zielhost autorisiert die Durchführung.
**Jetzt Prepared, nicht ausführbar:** kein Produktcommit/Driverhash/freigegebener
Kommandobestand oder Mac-A-Produktnachweis. Bei fehlender Voraussetzung ausschließlich
Blocked, Grund und nächste Aktion berichten. Kein Produktcode, Fixtureersatz,
Toolinstallieren oder eigenmächtiges Ändern des Teststands.

Nach separater Freigabe: exakten Commit/Planhash/Driverhash/Entscheidung und tatsächlichen
Host prüfen; isolierten Bestand/Outputs verwenden; Negativfälle zuerst, anschließend
Build/Verträge/Sitzung/Restore/Wiederöffnung im aktivierten Umfang. Soll/Ist und
Exitcodes auswerten, nicht nur Befehle abhaken. Sicherheits-/Restorefehler oder Timeout
stoppen positive Läufe. Keine automatische Reparatur oder neue Auslegung.

Driver/Harness entstehen erst mit T029/T053/T054. Geplante Schnittstelle:
`Invoke-Lh01PlatformProof.ps1 -Plan ... -Target ubuntu-wsl2 -OutputDirectory ... -CheckOnly`.
Nicht vorhandene Datei jetzt nicht ausführen. Vertrag definiert den späteren
Normalmodus und alle Voraussetzungen; keine geratenen Build-/Testkommandos.

Erzeuge später automatisiert `result.json`, `report.md` DE/EN und synthetische
Rohdaten/Hashes in der autorisierten isolierten Ausgabewurzel. Geplanter Evidence-Pfad:
`docs/validation/lh01/platform-runs/ubuntu-wsl2/<run-uuid>/`. Erfasse pro Fall ID, Soll/Ist,
Exitcode/Status, Befehl, Outputhash; dazu Commit/Manifest-/Driver-/Entscheidungshash,
Versionen, tatsächlichen Host, Grenzen, Quellenunverändertheit und Null-Nebenwirkungen.
Kein privater Sitzungskontext. Neues Laufverzeichnis statt Überschreiben.

Ein anderer Prüfer bewertet die Evidence; fehlender Review bleibt Open. Rückgabe im
Chat mit lokalen Artefaktpfaden. Kein Issuekommentar/Schließen/Commit/Push ohne passenden
Auftrag. Owner Thorsten erteilt abschließend die Abnahme; Agenten-PASS ersetzt sie nicht.

Stufe A: automatisierte Produktprüfungen nach geliefertem Mac-A-Inkrement. Stufe B:
reale Terminaloberflächen erst mit gesondertem Auftrag. Screenreader Deferred,
Braillehardware Excluded mangels Gerät im privaten Projekt. Keine behauptete
A11Y-/Plattformkonformität. LH-00-Prozessabnahme nach LH-02, vor LH-03 bleibt getrennt.

## EN — Agent instruction

Read own/parent issue and the pinned Markdown/JSON contract. Require explicit authority
for this target. **Prepared, not executable:** Missing product commit, driver/hash,
commands or Mac A product proof means Blocked with reason/action. Do not install,
implement, substitute feasibility tests or change the target revision.

After separate approval, verify exact product/plan/decision/driver hashes and actual
host; isolate sources and outputs; run negatives before enabled build/contract/session/
restoration/re-entry cases. Evaluate actual expectations and exits. Stop positive runs
on unsafe state/restore failure or timeout. No automatic repair/retry.

T029/T053/T054 create the future driver/harness. The displayed CLI is planned, not a
present executable. Follow the contract rather than inventing test commands. Produce
JSON, equivalent DE/EN report and synthetic hashed outputs in authorized isolation,
using a new target/run UUID directory. Bind versions/host, commands, expectation and
observation, exits, hashes, unchanged source and zero unintended effects. No private data.

A distinct reviewer assesses evidence; otherwise review stays Open. Return local
artefact paths in chat. No issue comments/closure/commits/push without separate authority.
Thorsten accepts separately. Phase A is automation after delivered Mac A proof; Phase B
needs explicit real-terminal authority. Screenreader proof remains Deferred, Braille
hardware Excluded for absent hardware; no full accessibility/platform/LH-00 claim.

## Verknüpfte Prüf-Issues / Linked validation issues

- [parent #36](https://github.com/hindermath/Show-CommandTui400/issues/36)
- [macb #37](https://github.com/hindermath/Show-CommandTui400/issues/37)
- [windows #38](https://github.com/hindermath/Show-CommandTui400/issues/38)
- [ubuntu-wsl2 #39](https://github.com/hindermath/Show-CommandTui400/issues/39)

Vertrag / Contract: [platform-handoff.md](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/validation/lh01/platform-handoff.md).
