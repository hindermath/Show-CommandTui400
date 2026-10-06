# Sicherheitskontrollen / Security controls

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Diese Tabelle trennt implementierte Eingrenzung von späteren Prozessnachweisen.
Vor T013 werden sichere Root-Auswahl, Quoting, isolierte Testziele und die
Unveränderlichkeit aktiver LH-00-Dateien geprüft. Ein Restrisiko darf nur Thorsten
explizit akzeptieren; bisher wurde keines als akzeptiert protokolliert.

The table separates present safeguards from later acceptance. Verify root
selection, quoting, isolated targets and unchanged active LH-00 evidence before
integration. Only the owner may accept residual risk; none is accepted here.

| Kontrolle / Control | Anwendbarkeit / Applicability | Umsetzung / Implementation | Evidence / Nächste Aktion / Next action |
|---|---|---|---|
| Root/keine Shellauswertung / contained paths, no evaluation | Applicable | Partly Fulfilled | Basisvergleich T013; manipulierter Hash/Symlink T027/T035 / base tests now, lifecycle tests later |
| Begrenzter Auftrag / bounded authority | Applicable | Fulfilled | aktueller T001–T018-Auftrag, fixture-plan.md / current request and fixture boundary |
| Überschreibschutz / overwrite protection | Applicable | Partly Fulfilled | Create-Policy; später T023/T026 / existing policy, later tests |
| UTF-8, keine Secrets / strict UTF-8, safe sources | Applicable | Partly Fulfilled | T018, abschließender Secret-Scan / negative fixtures and final scan |
| Unabhängiger Prüfer / independent reviewer | Applicable | Partly Fulfilled | T012 vor Integration; Produktprozess-Review T029–T033 offen / foundation review now, intake review later |
| Abhängigkeiten und Herkunft / dependencies and provenance | Applicable | Partly Fulfilled | dependency-audit.md; später Lifecycle-Nachweise / provenance now, lifecycle later |

Offene Teile: Owner Thorsten, Wiedervorlage 2026-10-12, Trigger entsprechender
Task-/Scopebeginn. Keine offene spätere Abnahme wird zu einem PASS umgedeutet.
Open controls retain the owner/date above and are reassessed at their matching task.
