# Aktionen und Terminal / Actions and terminal contract

## Vollständige Zuordnung / Complete mapping

| FR | Vertrag / Contract | Nachweis / Proof |
|---|---|---|
| FR-01-001 | Plattform-/Host-/Terminalmatrix getrennt / explicit matrix | F01/F02 |
| FR-01-002 | ActionId statt Geräteereignis / action independent of device | F03 |
| FR-01-003 | F1 Hilfe, F3 Ende, F4 Kontext, F5 Refresh, F9 alle/F10 weitere Parameter, F11 Details, F12/Esc zurück / preserve defined meanings | F03 |
| FR-01-004 | Remapping/Alternativen, keine vermischte Ausführung / separate actions and alternatives | F03/F06 |
| FR-01-005 | Resize/Ende/Abbruch/Fehlerzustände / resize and restoration | F04/F05 |
| FR-01-006 | Identische Sitzung, belegte Scopegrenzen / session and scoped access | F02 |
| FR-01-007 | Tab/Shift+Tab, Pfeil/Bild, Enter bestätigt; keine Zielausführung / navigation without execution | F03 |
| FR-01-008 | Textliche Namen/Verfügbarkeit/Fokus/Busy/Fehler und Legende / accessible text state | F06 |
| FR-01-009 | Gültiger Kontext/Whitelist, unbekannt oder unverfügbar ohne Wirkung / context validation, unavailable no effect | F01/F03 |
| FR-01-010 | Resize erhält Werte/Fokus, kleine Größe erklärt sichere Rückkehr / preserve state and exit | F05 |
| FR-01-011 | Betroffene Modi/Cursor wiederherstellen, externe Killgrenzen dokumentieren / restoration and external limits | F04 |

F4/F9/F10/F11 sind Kontextverträge; ohne Folgefunktion sichtbar nicht verfügbar.
Ein Fixture darf getrennte Actions zeigen, aber kein reales Formular, Suche,
Completion, Aufrufvorschau oder Ausführung aus LH-02–07 liefern. Enter bewegt nicht
stillschweigend zum nächsten Feld. Esc/F12 geht eine Ebene zurück und erhält Werte;
Beenden bleibt eigene Aktion. Root-Kontext und genaue Ersatz-/Menütaste werden im
Machbarkeitsvertrag entschieden, ohne die fachlichen Tastenbedeutungen zu ändern.

Later contextual actions are unavailable until their separate features exist.
Fixtures demonstrate actions, not later search/forms/completion/invocation behavior.
Enter does not silently advance fields; back retains state and exit stays separate.
Evidence root-context and alternate/menu keys without changing domain meanings.

Textzugang zu Hilfe, Aktionen, Fokus, Status und Fehler bleibt Pflicht. Farbe/Position
tragen keine alleinige Bedeutung. Reale Terminal-/Screenreadertests sind im jetzigen
Stadium auf Ownerauftrag zurückgestellt; Braillehardware-Nachweis ist wegen fehlender
Hardware im privaten persönlichen Projekt ausgeschlossen. Keine behauptete
Konformität. [Nachweisgrenzen](../feasibility/owner-validation-boundaries.md).

Text access remains required. Owner defers physical terminal/screen-reader testing
and excludes Braille hardware proof for lack of hardware in the personal project.
Do not claim conformance.

Gewählte Alternativen / Selected alternatives: Alt+H Hilfe/Help, Alt+B Zurück/Back,
Alt+X Ende/Exit, Alt+M textuelle Aktionsübersicht/text action overview. Root-Zurück
erhält Zustand und beendet nicht; tatsächliches Remapping im isolierten Proof
F1→F2, F3-Konflikt vor Init abgewiesen. / Root back retains state and never exits;
actual F1→F2 proof and pre-Init F3 conflict rejection are recorded.
