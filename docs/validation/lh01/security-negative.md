# LH-01 Negativgrenzen E01-06 / Negative boundaries

## DE — Umfang und tatsächliche Prüfung T052

Auf Mac A wurden zuerst die negativen Sicherheits-/Eingabeverträge ausgeführt,
anschließend der gültige Produktablauf. `SecurityBoundaryTests.cs` prüft unbekannte
ActionIds, falschen Kontext, unverfügbare Bearbeitung/Ausführung, Ausdruckstext
als Aktions-/Tastenname, Kollisionen und sichere Anzeige von Steuerzeichen.
Die vorhandenen Entry-/Lifecycleverträge bleiben Regression.

Der Produktfall NegativeSecurity ruft das öffentliche Cmdlet fünfmal mit
unbekannter Aktion, Aktionsausdruck, Tastenausdruck, F3-Kollision und verdrängtem
Esc-Rückweg auf. Alle Fälle müssen InvalidConfiguration liefern. Erwartet werden
LeaseAcquisitions=0, UiCreations=0, fünf konkrete Ablehnungen und null Aufrufe einer
synthetischen Zielfunktion. Deren Namen als Text zu übergeben darf keine Auswertung
bewirken. Die aufrufende Sitzung bleibt erhalten; keine Zielmodule werden geladen.

Ein EventListener zählt während dieser Prüfung ausschließlich RequestStart,
ConnectStart und ResolutionStart der .NET-Quellen System.Net.Http, System.Net.Sockets
und System.Net.NameResolution. Er zeichnet keine URLs/Adressen/Payloads auf.
Ergebnis: null beobachtete Verbindungsversuche. Ein eigens erzeugtes temporäres
Testverzeichnis enthält danach exakt seine unveränderte Sentineldatei und wird
wieder entfernt. Diese Kontrollen belegen das getestete Fenster und Verzeichnis,
keine systemweite Netzwerk-/Dateiüberwachung. Zusätzlich zeigt die Quellprüfung:
der eigene Produktpfad hat keinen Zielaufrufer, HTTP-/Socketclient, Import- oder
Persistenzpfad. Ressourcen werden lokal gelesen, nicht als Code ausgewertet.

Separate tatsächliche Produktfälle prüfen umgeleitete Ein-/Ausgabe vor Init,
behandelte Fehler, zusammengesetzte Primärfehler und Restorefehler. Die absichtliche
Restore-Injektion bleibt Fail/Exit1 mit erfülltem Diagnosevertrag. Sie erfolgt
nach realem erfolgreichem Restore und beweist keinen defekten Hostrestore.
TextState setzt ausschließlich künstliche Busy-/Status-/Fehlerwerte über eine
interne Friend-Testassembly ein; Steuer-/Formatzeichen werden ersetzt. Es werden
keine privaten Sitzungswerte abgefragt oder veröffentlicht. Keine Probeparameter
oder zusätzlichen Ausgabeobjekte im öffentlichen Cmdlet.

Belege: [Manifest](text-state-maca/manifest.json), NegativeSecurity.json,
Redirect.json, InputRedirect.json, TextState.json und Fehlerfälle im selben
Verzeichnis. Jeder Produktfall bindet die Assembly und bereinigte Transcripthashes.
Die Testseams, EventListener und temporäre Sentinelanlage liegen im Prüfaufbau;
sie sind keine Produkt-Netz-/Dateifunktion. Abhängigkeiten/Lockfiles bleiben gleich.

Dies schließt T052 im lokalen Auftrag. Es ersetzt weder T058-Gesamtreview noch
native Fremdplattform-/praktische Hilfsmittelprüfungen. Reale Terminals und
Screenreader Deferred; Braillehardware Excluded mangels Gerät. Keine vollständige
Abnahme oder Sicherheitszertifizierung.

## EN — Scope and executed T052 proof

Negative security/entry contracts ran before valid product cases on Mac A.
SecurityBoundaryTests covers unknown IDs, forged context, unavailable edit/execute,
expression text, collisions and sanitized control/format characters.

NegativeSecurity calls the public cmdlet five times with invalid action/key
configurations. All five must produce InvalidConfiguration before lease/UI.
A synthetic target-function counter stays zero. Expression-shaped names are data,
never evaluated. Caller context and loaded modules stay unchanged.

The test listener records event counts only from the three named .NET networking
sources; observed request/connect/resolution attempts are zero. A controlled
external temporary directory retains exactly its unchanged sentinel, then is
removed. These controls cover the observed window and directory, not system-wide
monitoring. Source inspection corroborates that own product code has no target
executor, network client, module import or persistence path. Resources are local
read-only data. No URLs, event payloads or private session values are recorded.

Redirected streams and operation/restoration errors are separate product cases.
RestorationFailure intentionally remains Fail/exit1 with satisfied diagnostics
after real successful restore. TextState injects synthetic busy/error values
through internal friend seams only. Public parameters/outputs remain unchanged.
The linked manifest binds the source, binary and sanitized results. Test network
observation and sentinel setup are not product features; dependencies stay locked.

T052 is locally complete, not the T058 full review, native foreign-platform proof,
assistive acceptance or certification. Physical terminals/screen readers stay
Deferred; Braille hardware Excluded for lack of a device. Full acceptance is open.
