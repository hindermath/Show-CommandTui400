# LH-01 Datenmodell / Data model

Bedingter Framework-unabhängiger Entwurf; keine Klassenimplementierung oder Persistenz.
Conditional framework-neutral design, without code or persistence.

| Entität / Entity | Felder und Beziehung / Fields and relationships | Validierung / Validation |
|---|---|---|
| SessionContext | Prozess-/Runspaceidentität, zulässiger Aufruferkontext, Scope-Evidence / identity, allowed caller context | Kein Ersatz-Runspace, keine privaten Dumps; Sichtbarkeit separat beweisen / no replacement or private dumps |
| ActionDescriptor | Stabile ActionId, Name DE/EN, gültige Kontextarten, Verfügbarkeit / ID, name, contexts, availability | Unbekannt/ungültig/unverfügbar hat keine Wirkung / invalid actions have no effect |
| KeyBinding | Taste/Modifikator → ActionId; Ersatzbelegung und Legendentext / key, modifiers, alternative, legend | Mehrdeutigkeit ablehnen; Hilfe/Zurück/Beenden erreichbar / reject conflicts, keep escape paths |
| ViewState | Ansichts-ID, lokale Testwerte, Fokus-ID, Status, Fehler, Größe, vorherige Ansicht / view, values, focus, state, dimensions, previous view | Resize/Zurück erhalten Werte; kein Zielaufruf / preserve state, no execution |
| TerminalSnapshot | Betroffene Modi, Cursorzustand, Host-/Treiberfähigkeiten / affected modes, cursor, capabilities | Vor erster Änderung erfassen; nur selbst geänderte Zustände wiederherstellen / capture first, restore own changes |
| ProofRecord | F-/E01-ID, OS/Host/Terminal/Hilfsmittel/Versionen, Kommandos, Prüfer, Erwartung/Beobachtung, Exitcode, Hashes, Grenzen / proof identity/context/results | Synthetisch, kein Secret; nicht ausgeführt bleibt Open / synthetic, honest Open |

## Zustände / States

1. Created → CapabilityCheck: noch keine Terminaländerung.
2. CapabilityCheck → Rejected bei umgeleiteten Streams/ungeeignetem Host: textuelle
   Ablehnung, keine Initialisierung oder Ersatzsitzung.
3. CapabilityCheck → Running erst mit Snapshot und gültigem Kontext.
4. Running → Running: gültige Navigation/Resize/Refresh; Werte erhalten.
5. Running → Restoring bei Ende, Abbruch oder behandelbarem Fehler.
6. Restoring → Closed nach Wiederherstellung; Fehler/Restgrenze ehrlich ausgeben.

Created checks capabilities before changes; rejected I/O never initializes or
substitutes sessions. A captured snapshot precedes Running; navigation/resize/
refresh preserves values. Exit/cancel/handled error always enters Restoring before
Closed. Document restoration failures and external-kill/host-failure limits.

Aktionen Auswahl, Bearbeiten, Bestätigen, Refresh, Zurück, Hilfe, Beenden und spätere
Ausführung bleiben verschieden. Aktion ist nicht Taste; optionale Geräte würden
später dieselbe ID nutzen, werden hier nicht implementiert. Es gibt keinen Zielbefehl,
kein Formularmodell aus LH-03, keine Suchergebnisse aus LH-02 und keine Datenbank.

Selection/edit/confirmation/refresh/back/help/exit/future execution are distinct;
an action is not a key. Future devices may use the ID but are outside LH-01. No
target invocation, later search/form model or database exists in this design.
