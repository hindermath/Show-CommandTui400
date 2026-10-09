# LH-01: Plattformprüfung koordinieren / Coordinate platform validation

**Prepared — nicht ausführbar / not executable.** Owner: Thorsten Hindermann.
Fachlicher Bezug / Domain reference: https://github.com/hindermath/Show-CommandTui400/issues/2

## DE — Koordinatorauftrag

Verwende `docs/validation/lh01/platform-handoff.md` und dessen JSON als gemeinsame
Prüfquelle. Drei getrennte Hand-offs: Mac B/Mac mini M4 Pro; native Windows 11;
Ubuntu24.04/WSL2. Nachweise gehören versioniert ins Repo, Issues koordinieren.
Lesen/Erstellen des Issues startet keine Prüfung. Der Produkt-Testdriver fehlt.

Ein später beauftragter Koordinator bindet den gelieferten Produktcommit, tatsächlichen
Mac-A-Produktnachweis, Entscheidung, Driver/Harness und freigegebene Kommandos für
alle drei Zielumgebungen. Der gleiche freigegebene Commit gilt für jede vergleichbare
Prüfrunde; Zielunterschiede bleiben ausdrücklich bezeichnet. Keine Branch-/latest-
Referenz als Teststand. Bei Teilinkrement Umfang pro Fall ausdrücklich begrenzen.

Agenten arbeiten lokal mit freigegebenem Prüfdriver und liefern maschinenlesbare
Evidence plus DE/EN-Bericht. Ein anderer Prüfer bewertet die gebundenen Nachweise.
Fehlende Hosts/Kommandos/Abdeckung bleiben Blocked/NotRun, nicht bestanden. Fehler
zentral korrigieren und einen neuen Prüfstand/Lauf freigeben; Historie erhalten.
Keine Vermischung verschiedener Commits zu einem Gesamt-PASS.

Nach technischem Review entscheidet Thorsten über die Abnahme. Issues nicht automatisch
schließen. Reale Terminalprüfungen separat beauftragen; Screenreader Deferred,
Braillehardware Excluded mangels Gerät im privaten Projekt. LH-01-Produktprüfung
und vollständige LH-00-Prozessabnahme nach LH-02/vor LH-03 bleiben getrennt.

## EN — Coordinator instruction

Use the versioned Markdown/JSON proof contract for three independent target hand-offs.
Evidence belongs in the repository; issues coordinate work. Preparation grants no
execution authority; the product driver is absent. Later explicit authority binds one
delivered product commit, actual Mac A product proof, decisions, driver/harness hashes
and approved commands. Never use latest/branch as a test revision. Limit partial cases
explicitly and preserve each environment's actual scope.

Agents execute local approved tests, return machine-readable evidence and a bilingual
report, followed by distinct review and owner acceptance. Missing prerequisites remain
Blocked/NotRun. Central repairs require a new approved test revision/run; preserve old
results and avoid mixed-revision Pass. No automatic issue closure or subsequent feature.
Physical terminals need separate authority; screen readers remain Deferred, Braille
hardware Excluded for lack of hardware. LH-00 process acceptance remains separate.

## Verknüpfte Prüf-Issues / Linked validation issues

- [parent #36](https://github.com/hindermath/Show-CommandTui400/issues/36)
- [macb #37](https://github.com/hindermath/Show-CommandTui400/issues/37)
- [windows #38](https://github.com/hindermath/Show-CommandTui400/issues/38)
- [ubuntu-wsl2 #39](https://github.com/hindermath/Show-CommandTui400/issues/39)

Vertrag / Contract: [platform-handoff.md](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/validation/lh01/platform-handoff.md).
