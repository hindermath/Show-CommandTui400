# LH-01: sichtbarer Hilfe- und Statustext / Visible help and status text

## DE

Lokaler Korrektur- und Regressionsnachweis vom 2026-10-15 auf Mac A
(MacBook Air M2 2023). Ausgangscommit: `fa5067c03c49389cd8df37ce28e469c32c66aafd`.
Die geprüfte Arbeitskopie enthält die unten gebundene, noch nicht committete Korrektur.

Der Owner meldete in Terminal.app einen leeren Textbereich bei F1, umbelegtem F2
und Enter auf Hilfe. Im bisherigen tatsächlichen PTY-Protokoll
`platform-proof-maca/cases/K01/Keyboard.json` sind Vorder- und Hintergrund des
Textbereichs gleich (SGR 37/47). Die bisherige Text-/Zustandsprüfung erkannte das nicht.
Die neue Prüfung weist diesen historischen Datensatz mit Exitcode 1 zurück.

Der schreibgeschützte Textbereich verwendet jetzt die normalen Textfarben des
Fensters. Fokus, Tasten und Refresh-Verhalten bleiben erhalten. Refresh zeigt
„Ansicht aktualisiert; Werte erhalten / View refreshed; values retained“;
weitere Aktualisierungen behalten diesen Status bei.

Gesperrter Build und sämtliche B01-Vertragsprüfungen bestehen (Exitcode 0).
Die bekannte CS0618-Warnung bleibt bestehen. Frische synthetische Unix-PTY-Läufe
bestehen inklusive Eingaben, Terminalwiederherstellung und zusätzlicher Prüfung
auf tatsächlich ausgegebenen Hilfe-/Refresh-Text ohne identische Textfarben:

| Fall | Ergebnis | Exitcode | JSON SHA-256 |
|---|---|---|---|
| Keyboard | Pass | 0 | `883c6766a909df332d1cf56b6b0afc7f69001d71f77127a33f052b69f8b89617` |
| Remap | Pass | 0 | `6ffeaef31b314e9c5934b12ab7e2bafc27aad56d08229edef7a6f504db37aab9` |

Lokale Rohdaten: `/private/tmp/lh01-readable-proof-20261015`. Sie sind temporäre Nachweise, keine gelieferten
Plattformfreigaben. Reproduktion aus dem Repository:

```bash
pwsh -NoProfile -File tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1 -CaseId B01 -BuildRoot /private/tmp/lh01-readable-new
python3 tests/feasibility/lh01/pty-product.py --scenario Keyboard --output /private/tmp/lh01-readable-new-proof/Keyboard.json --build-root /private/tmp/lh01-readable-new
python3 tests/feasibility/lh01/assert-readable-text.py --record /private/tmp/lh01-readable-new-proof/Keyboard.json
python3 tests/feasibility/lh01/pty-product.py --scenario Remap --output /private/tmp/lh01-readable-new-proof/Remap.json --build-root /private/tmp/lh01-readable-new
python3 tests/feasibility/lh01/assert-readable-text.py --record /private/tmp/lh01-readable-new-proof/Remap.json
```

Neue externe Ausgabepfade verwenden und bei Fehlern stoppen.

Die synthetischen Prüfungen belegen ausgegebenen Text und unterschiedliche
Farbattribute, keinen WCAG-Kontrastwert, keine Terminal.app-Abnahme und keine andere
Plattform. Der manuelle Test ist nach Neubuild in frischer PowerShell zu wiederholen.
Bestehende Plattformfreigaben enthalten diese lokale Korrektur nicht. Praktische
Terminal-/Screenreader-Abnahme bleibt getrennt und zurückgestellt; Braillehardware
bleibt ausgeschlossen.


## EN

Local fix and regression evidence on Mac A, 2026-10-15, based on the commit above
with the uncommitted source hash below. The owner reported invisible help in
Terminal.app using default/remapped keys and Enter. The historical PTY transcript
contains identical foreground/background colors; the new check rejects it.

The read-only text area now uses the window's normal text colors without changing
focus or actions. The first refresh shows the bilingual status quoted above;
repeated refreshes retain it. Locked build/B01, Keyboard and Remap pass with exit
code 0. The existing CS0618 warning remains. The table binds fresh temporary raw
records. Use the commands above with new external output paths; stop on failure.

These synthetic checks prove emitted text and unequal color attributes, not a
WCAG contrast ratio, real Terminal.app acceptance or another platform. The owner
must repeat the manual test in a fresh PowerShell session after rebuilding.
Existing platform approvals and their pinned product commit remain unchanged;
they do not include this local fix. Practical terminal/screen-reader acceptance
remains separate and deferred; Braille hardware remains excluded.

## Hashbindungen / Hash bindings

- `src/ShowCommandTui400/Terminal/TerminalApplication.cs`: `40d2b926da4c00e3ea1bc17439bb202ad795491e7a4aef96ff2e5b9008517480`
- `tests/feasibility/lh01/assert-readable-text.py`: `27ee605f98bc429bd7a3b615a55164b028ce96d4538a2f1859316434003e87fa`
