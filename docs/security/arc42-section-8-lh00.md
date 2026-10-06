# arc42 Abschnitt 8: Sicherheit / Section 8: security

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Querschnittsregeln: strikt dekodieren, keine Befehle aus Quellen auswerten,
übergebene Dateipfade als Literale behandeln, Root vor Zugriff prüfen, Quellen-
und Zielhashes normalisiert vergleichen. Nur dokumentierte Versionen nutzen,
kein Download zur Laufzeit. Fehler nennen Regel und nächste Aktion, keine
Credentials oder private Vollpfade. Logs verwenden stabile Fall-/Intake-IDs,
Zeit, Hash, Exitcode und Scope. Profile, Receipt und Review behalten getrennte
Statusachsen. Native spätere Tests sind keine heutige Zusage.

Cross-cutting controls use strict decoding, literal paths, contained roots,
normalized hashes and pinned dependencies. No runtime download or source
execution is added. Errors identify the rule and next action without credentials.
Logs record stable case IDs, time, hashes, exit and scope. Profile, receipt and
review states remain distinct; native platform proof remains future work.
