# Cmdlet- und Sitzungsvertrag / Cmdlet and session contract

**Status:** gewählter Planungsvertrag, keine öffentliche Implementierung / selected design contract, no public implementation. Bezieht FR-01-001/005/006/011
und AC-01-002/003 ein / covers the named requirements.

- Einstieg `Show-CommandTui400` direkt in der vorhandenen Sitzung. Kein eigenes
  pwsh, Ersatz-Runspace oder implizites PowerShell-Hosting. / Enter in the caller
  session without a replacement process/runspace/host.
- Mindest-PowerShell7.6.4 ist in OD-01-001 gewählt. Signatur/Modulmanifest und
  öffentliche API in den Umsetzungstasks konkretisieren; keine Produktparameter
  aus dem Wegwerf-Fixture übernehmen. / Minimum PS7.6.4 is selected; specify public
  signature/manifest in implementation tasks, never copy fixture parameters.
- Umgeleitete Eingabe/Ausgabe bzw. fehlende Hostfähigkeiten vor Terminaländerung
  mit verständlichem Fehler zurückweisen; kein interaktives Fallback. / Reject
  redirected I/O/unsupported capability before changing state, without fallback host.
- Aufruferzustand vor/nach normalem Ende, Abbruch und behandelbarem Fehler vergleichen.
  Prozess- und Runspaceidentität allein beweisen keinen Scopezugriff. / Compare
  synthetic caller state; identity alone does not prove visibility.
- Wiederholtes Öffnen innerhalb derselben Sitzung muss separat geprüft werden;
  keine hängenden Eventhandler/Modi/Cursor. / Test repeated entry without leaked state.
- Keine Zielausführung, Modulauflösung, Netzabfrage oder Persistenz. Öffentliche Hilfe
  nur lokal. Private Werte nicht in Logs/Evidence kopieren. / No target execution,
  discovery/network/persistence or private-value logging.

Fehlerklassen: CapabilityRejected, InvalidContext, Cancelled, HandledFailure und
RestorationFailure sind fachliche Kategorien, keine jetzt festgelegten ErrorIds.
Dokumentierte Grenzen bei Hostausfall/externem Kill bleiben außerhalb garantierter
Wiederherstellung. / These error categories define behavior without fixing public
ErrorIds; external termination/host failure has explicit restoration limits.

Leserpfad / Reader path: [Datenmodell](../data-model.md) → [Prüfanleitung](../quickstart.md).

## Öffentliche Signatur des ersten Inkrements / First increment public signature

DE: `Show-CommandTui400 [-KeyBinding <hashtable>] [<CommonParameters>]`.
Kein Pipelineinput und keine Ausgabeobjekte; Rückkehr zur aufrufenden Sitzung.
Das Manifest exportiert genau dieses Binärcmdlet; `Show` ist ein Approved Verb
(`Get-Verb Show`). Keine Modi, Treiber- oder Fehler-Injektionsparameter.
`KeyBinding` ordnet ActionIds Tasten zu: ausschließlich `Help`, `Back`, `Exit`;
Werte `F1` bis `F12`, `Esc` oder `Alt+H/B/X/M`. Unbekannte IDs/Syntax und
Kollisionen und abweichende Groß-/Kleinschreibung werden vor UI-Init abgewiesen. Fest erhalten bleiben Alt+H, Alt+B,
Alt+X und Esc/Back; Remaps dürfen diese Pfade nicht verdrängen. Vorgaben sind
F1/Help, F3/Exit, F12/Back. Vollständige Aktionen/Remap-Oberfläche folgen T037–T044.

EN: The signature above accepts an optional ActionId-to-key hashtable, no pipeline
input and emits no objects. Names and key spelling are exact. Only Help, Back and Exit are configurable in this
increment. Values, fixed alternatives and conflict rejection follow the rules
above. The manifest exports this binary cmdlet only; Show is approved. No test
mode, driver or fault injection parameters are public. Later action UI remains open.

DE: Stabile ErrorId-Präfixe: `CapabilityRejected`, `InvalidConfiguration`,
`InvalidContext`, `Cancelled`, `HandledFailure`, `RestorationFailure`.
Ctrl+C/StopProcessing beendet ohne Zielwirkung; die PowerShell-Pipeline darf dabei
`PipelineStopped` melden. Primär- und Restorefehler bleiben gemeinsam erhalten.
EN: Stable error prefixes are listed above. Cancellation stops without domain
effects; the caller pipeline may report PipelineStopped. Combined errors retain
both causes. Restoration failure is never presented as successful restoration.
