# ADR 001: Bestehende Dateiverträge / Existing file contracts

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

**Status:** Angenommen für T001–T018 als lokale technische Entscheidung.
Intake/Receipt/Review bleiben getrennte Dateien mit den bestehenden Schemas.
`SeriesManifest` wird später für die Collection verwendet, damit Einzelpiloten
außerhalb der Serie explizit bleiben. Kein Schema, Status oder Validator wird verändert.
Gebundene Governance-Dateien werden zuerst als Kandidaten vorbereitet; T032
veröffentlicht erst mit Update/Archiven und anderem Review. Das vermeidet ein
stilles Ungültigwerden des aktuellen Startnachweises. Alternativen Datenbank,
eigener Prozessdienst und direkter Hashersatz wurden verworfen: unnötige Laufzeit,
fehlende Archivherkunft bzw. zusätzliche nicht beauftragte Migration.

Accepted for the local increment: reuse separate intake, receipt and review
contracts; later use SeriesManifest for explicit membership. Stage bound changes
until controlled T032 publication. A database, custom service and direct hash
replacement add unnecessary runtime or lose provenance and are rejected.
