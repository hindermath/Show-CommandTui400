# LH-01 — Aktueller Plattformprüfstand / Current platform test stand

## DE

Freigegebener aktualisierter Stand; ersetzt die Bindungen aus PR #48. Neue
NuGet-Kompilierreferenz, sichtbare Hilfe/Status und gemeinsame K01-Farbprüfung.
Frischer vollständiger Mac-A-Lauf: 19 reguläre Pass-Fälle, S07 erwarteter separater
Fail/exit1 mit erfülltem Diagnosevertrag. Kein Zielhost ist dadurch geprüft.

- Produktcommit / Product: `64fe627e5f0799ce1a4f7d5ec1c26ceeea936e9b`.
- Genehmigungscommit / Approval: `0544c992d627a51a855dbfe5e8f908bec6dfe701`.
- Manifest-SHA-256: `71a56f525ed1dfa91f62a54a8018da548284dc58cdffbe695dac413d571b7194`.
- [Gepinnter Vertrag / Pinned contract](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.md), [Manifest](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.json), [SHA-256](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.sha256).
- [Vollständiger Mac-A-Nachweis / Complete Mac A proof](https://github.com/hindermath/Show-CommandTui400/tree/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-proof-maca/20261015-64fe627), [Matrix](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-matrix.md).
- [IDE-Einrichtung / IDE setup](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/lh01/development-setup.md), [Plan](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/specs/002-lh01-tui-foundation/plan.md), [Tasks](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/specs/002-lh01-tui-foundation/tasks.md).


Die vollständigen direkt kopierbaren DE/EN-Agenten-Prompts stehen in:

- [Mac B, Mac mini M4 Pro — #37](https://github.com/hindermath/Show-CommandTui400/issues/37)
- [Windows11 nativ — #38](https://github.com/hindermath/Show-CommandTui400/issues/38)
- [Ubuntu24.04 / WSL2 — #39](https://github.com/hindermath/Show-CommandTui400/issues/39)

Jeder Prompt bindet genau denselben Produkt-/Genehmigungscommit und Manifesthash,
CheckOnly vor Ausführung, 65 Dateien, 60 Kommandos und 20 unveränderte Fälle.
Rider/VS Code und unter Windows Visual Studio werden zusätzlich getrennt geprüft.
Fehlende IDE/GUI bleibt Open/Blocked. Nur vorhandene Werkzeuge, isolierte Ausgaben
und private IDE-Zustände; keine Installation, globalen Änderungen oder Reparatur.
Kein Zielstart durch Veröffentlichung. Ergebnisse, unabhängiges Review und
Ownerabnahme bleiben getrennt. T054 offen; keine Serien-/Folgefeaturefreigabe.
Praktische Terminal-/Screenreaderabnahme Deferred, Braillehardware Excluded mangels
Gerät. LH-00 vollständig nach LH-02/vor LH-03 abnehmen.

## EN

Current approval replaces PR #48 bindings. NuGet compile-only API, visible help/status
and shared K01 color regression are included. Fresh complete Mac A proof has 19
regular Pass cases and a separate expected S07 Fail/exit1 with its diagnostic
contract satisfied. The three linked issues contain complete copyable DE/EN prompts
with the same exact revisions/hash, CheckOnly, 65 bindings, 60 commands and 20 cases.
IDE proof is separate; missing IDE/UI remains Open/Blocked. No installation, global
changes or repair. Publication starts no target execution. T054, target reviews and
owner acceptance remain open. Physical terminals/screen readers Deferred, Braille
hardware Excluded for absent hardware. Preserve LH-00 acceptance after LH-02/before LH-03.
