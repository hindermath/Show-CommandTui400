# Memory-Safe-Language-Anwendbarkeit / MSL applicability

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Produkttechnik und MSL-Status bleiben Open: keine Produktsprache wurde gewählt.
Bash/PowerShell sind vorhandene Wartungswerkzeuge, kein Produktsprachenentscheid.
MSL bedeutet speichersichere Sprache. Der gebundene CISA-Leitfaden liefert eine
Entscheidungsgrundlage, keine automatische Ausnahme. Thorsten klärt Produkt-
Framework und Sprache vor dem fachlich passenden Feature; Wiedervorlage
2026-10-12, Trigger erste Laufzeit-/Integrationsentscheidung.

Product language and MSL status remain Open. Existing shell tooling does not
select a product language. MSL means memory-safe language; the bound CISA guidance
supports later decisions, with no automatic exception. The owner reassesses at
the first runtime/integration decision and the stated review date.

## Entscheidungsort LH-01, IAD019 / LH-01 decision stage

Ownerentscheid vom 2026-10-07: „In LH-01 entscheiden.“ Die historische Open-
Bewertung oben bleibt erhalten. C# wird geprüft; Primärsprache/MSL bleiben unknown.
OD-01-002 bindet den Sprachentscheid an den technischen LH-01-Plan, mit
Architekturentscheidung und Machbarkeitsnachweis vor Produktimplementierung.

Owner decision: decide in LH-01. Preserve the historical Open assessment above.
Evaluate C#; primary language/MSL remain unknown. OD-01-002 requires a recorded
language choice in LH-01's technical plan with architecture and feasibility
evidence before product implementation.

## LH-01 Startentwurf 2026-10-09 / Readiness design

Historische LH-00-Bewertungen oben bleiben erhalten. / Prior LH-00 context is preserved.

LH-01 managed C#14 ohne unsafe/Pointerarithmetik ist die gewählte eigene MSL. Runtime/OS/PInvoke/native Pakete bleiben eigene Vertrauensgrenzen. ADR002 und native Bewertung begründen Auswahl; Produktprüfung T058 offen.

LH-01 selects managed C#14 without unsafe/pointer arithmetic. Runtime/OS/interop/native dependencies remain separate trust boundaries. ADR002 and native assessment justify selection; product verification T058 remains open.
