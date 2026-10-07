# Aktuelle Einordnung / Current context

Stand / Date: 2026-10-07. Die fachlichen Bedienregeln der folgenden Konzeptbasis
v0.2 bleiben unverändert. Repository und LH-00-Kernprozess sind inzwischen
vorbereitet und geliefert; T045 erteilt begrenzte Pilotfreigabe. LH-01 ist noch
nicht erstellt. Sprache/MSL, Framework, PowerShell-Mindestversion und technische
Sitzungsintegration bleiben offen; der Sprachentscheid gehört zu LH-01 mit
Machbarkeits-/Architekturnachweis. C# ist eine Prüfoption.

The v0.2 interaction rules below remain unchanged. Repository setup and LH-00
core delivery now exist, with limited T045 permission. LH-01 has not been authored.
Language/memory-safety, framework, minimum PowerShell and session integration stay
open; LH-01 will document feasibility and architecture for the language decision.
C# is a candidate. The German concept below remains historical domain baseline;
full English access is still tracked as FU01 before full process acceptance.

---

# Show-CommandTui400 – Konzeptbasis

**Projektname und Einstiegscmdlet:** `Show-CommandTui400`  
**Konzeptstand:** 0.2 · 27. September 2026  
**Status:** Vereinbarte Diskussionsgrundlage; noch keine Implementierung oder Softwareversion.

## 1. Ziel und Rahmen

`Show-CommandTui400` unterstützt die interaktive Auswahl und Parametrisierung von PowerShell-Befehlen durch eine ausschließlich textbasierte, vollständig tastaturbedienbare Oberfläche. Historisches Vorbild ist das Command Prompting von OS/400 beziehungsweise IBM i.

Das Cmdlet wird aus der aktuellen PowerShell-7-/`pwsh`-Sitzung gestartet. Die Oberfläche arbeitet im vorhandenen Terminal unter macOS, Linux und Windows, einschließlich Windows Terminal unter Windows. Arbeitsort, sichtbare Variablen, verfügbare Befehle und Sitzungseinstellungen bilden ihren Kontext.

Die Grundidee verbindet die schrittweise Befehlsauswahl mit einem feldorientierten Parameterformular. Nutzende können einen Aufruf anschließend in die bearbeitbare PowerShell-Befehlszeile übernehmen oder direkt ausführen.

Optional ergänzen ein Elgato Stream Deck XL und ein Logitech MX Keypad die Tastaturbedienung. Gemeint ist das eigenständige MX Keypad, nicht das Keypad der MX Creative Console. Die Geräte machen dieselben Aktionen über beschriftete physische Tasten zugänglich; sämtliche Funktionen bleiben im Terminal per Tastatur erreichbar.

Diese Fassung hält die bisher besprochene Bedienung fest. Technologiewahl, Repository, Implementierungsplanung und weitergehende Bedienideen folgen später. Eine 5250-Protokollemulation ist kein Ziel.

## 2. Durchgängiger Bedienablauf

1. `Show-CommandTui400` in der laufenden Sitzung aufrufen.
2. Die ersten Buchstaben des Verbs eingeben; eine Trefferliste erscheint.
3. Mit vollständigem Verb, Bindestrich und ersten Nomenbuchstaben weiter eingrenzen.
4. Mit Pfeil hoch/runter einen Treffer markieren; Enter wählt den Befehl.
5. F4 öffnet dessen Parameterformular. Ein gegebenenfalls erforderlicher Modulimport folgt den Regeln in Abschnitt 4.
6. Parameter bearbeiten, F4-Auswahlhilfen und F1-Hilfe nutzen, bei Bedarf mit F10 oder F9 weitere Parameter anzeigen.
7. Enter bestätigt die Formulareingabe, prüft die prüfbaren Regeln und führt zur Abschlussauswahl.
8. „In Befehlszeile übernehmen“ oder „Ausführen“ wählen.

Enter führt im Formular nicht zum nächsten Feld; dafür dienen Tab und Umschalt+Tab. In Auswahldialogen übernimmt Enter den markierten Eintrag. Der Zielbefehl wird erst durch die entsprechende Abschlussaktion ausgeführt.

## 3. Befehlsauswahl und Reaktionsfähigkeit

| Eingabe | Bedeutung |
| --- | --- |
| `G` | Verb beginnt mit G, beispielsweise Get oder Group |
| `Ge` | Weitere Eingrenzung des Verbs |
| `Get-` | Befehle mit Verb Get |
| `Get-C` | Zusätzlich beginnt das Nomen mit C |
| `Get-Ch` | Weitere Eingrenzung des Nomens |

Die Suche verwendet zunächst eine Präfixsuche ohne Unterscheidung zwischen Groß- und Kleinschreibung. Rückschritt erweitert die Auswahl. Weitere Buchstaben verändern das Suchfeld auch während der Navigation in der Trefferliste. Selbst ein einzelner Treffer wird bewusst mit Enter ausgewählt.

Die Liste umfasst Befehle der aktuellen Sitzung und auffindbare Befehle lokal installierter Module. Ein Filter „Nur aktuelle Sitzung“ begrenzt sie entsprechend. Herkunftsmodul und Ladezustand sind sichtbar; Version und Herkunftspfad stehen im Detailbereich. Gleichnamige Befehle verschiedener Module bleiben unterscheidbar. Die Auswahl wird bis zur Ausführung an den tatsächlich gewählten Befehl gebunden.

Beim Start wird ein Befehlsbestand ermittelt. Tastatureingaben filtern diesen zwischengespeicherten Bestand. F5 aktualisiert ihn; nach einem erfolgreichen Import werden betroffene Einträge automatisch aktualisiert. Eine zeitgesteuerte Neuordnung während der Navigation ist zunächst nicht vorgesehen.

Suchtext, Filter, Markierung und Listenposition bleiben soweit möglich erhalten. Verschwindet ein ausgewählter Befehl nach einer Aktualisierung, wird eine neue Auswahl erforderlich. Die nächste Aktion darf nicht unbemerkt auf einen anderen Befehl wirken. Bei schrittweisem Aufbau des Bestands dürfen neue Treffer die aktuelle Auswahl nicht verschieben.

## 4. Modulerkennung und Laden

Durchsuchen, Markieren und Auswählen sollen keinen Modulimport auslösen. Bereits bekannte Informationen werden angezeigt; unvollständige Angaben werden als solche gekennzeichnet. Exakte Detailabfragen, die einen Import auslösen können, gehören zur gezielten Auflösung beim Öffnen des Formulars.

F4 löst den gewählten Befehl auf, berücksichtigt seinen Ladezustand, lädt gegebenenfalls das Modul und liest anschließend die tatsächlichen Parametermetadaten erneut. Währenddessen zeigt die TUI einen Status. Bei einem Ladefehler bleiben Suchtext und Auswahl erhalten.

| `$PSModuleAutoLoadingPreference` | Vorgesehenes Verhalten |
| --- | --- |
| `All` beziehungsweise nicht gesetzt | Gezielte Befehlsauflösung darf das benötigte Modul automatisch laden. |
| `ModuleQualified` | Auflösung über `Modulname\Befehlsname`; die Qualifizierung bleibt in der Vorschau sichtbar. |
| `None` | Kein automatischer Import. Die Aktion „Modul laden und Formular öffnen“ ermöglicht einen ausdrücklichen Import. |

Die Einstellung der Sitzung wird respektiert. Ein explizit gewählter Modulimport ist auch bei deaktiviertem automatischem Laden möglich. Eine zusätzliche Bestätigung jedes regulär erlaubten Imports ist nicht vorgesehen.

Ein erfolgreich geladenes Modul bleibt in der Sitzung. Zurückgehen oder Abbrechen beendet die Bearbeitung, setzt aber die Sitzung nicht auf den Zustand vor dem Import zurück. F5 aktualisiert Informationen; es bedeutet weder erzwungenes Neuladen importierter Module noch Zurücksetzen von Parameterwerten.

## 5. Ergänzender Moduldialog

„Module anzeigen“ öffnet innerhalb der TUI einen per Tastatur bedienbaren Dialog. Er zeigt alle ermittelten Module und kann optional auf die Module der aktuellen Befehlstreffer begrenzt werden. Module mit unbekanntem Befehlsbestand müssen gesondert auffindbar bleiben: Ein unbekannter Befehlsname kann nicht über die Verb-/Nomen-Suche gefunden werden.

Ladezustand und Informationsstand werden getrennt dargestellt:

| Information | Darstellung |
| --- | --- |
| Identität | Modulname und Version |
| Ladezustand | Geladen / Noch nicht geladen |
| Kenntnis des Befehlsbestands | Ermittelt / Unvollständig / Unbekannt |
| Beschreibung | Soweit verfügbar |
| Details | Herkunftspfad und gegebenenfalls letzter Ladefehler |

Namen filtern die Liste; Pfeiltasten markieren; Enter öffnet Details. „Befehle anzeigen“ wechselt zur entsprechend gefilterten Befehlsauswahl. „Modul laden“ importiert ausdrücklich. F5 aktualisiert; F12 beziehungsweise Esc führt zurück.

Nach erfolgreichem Laden bleibt der Moduldialog geöffnet und zeigt den neuen Zustand. Nutzende können dessen Befehle anzeigen oder zur ursprünglichen Suche zurückkehren. Fehler bleiben am betroffenen Modul nachvollziehbar. Statusinformationen sind auch ohne Farben verständlich.

## 6. Parameterformular

Das Formular besitzt einen Kopf mit Befehl, Herkunftsmodul und Aufrufvariante, einen Bereich zur Parameterbearbeitung und einen unteren Bereich für Befehlsvorschau, kurze Feldhilfe und Tastenlegende. Ausführliche Hilfe ist über F1 erreichbar. Die Anordnung passt sich der Terminalgröße an.

Jedes Feld macht Parametername, Datentyp, aktuelle Erforderlichkeit, Wertquelle und Übergabezustand erkennbar. Optionale Parameter beginnen mit „nicht angegeben“. Ein angezeigter Standardwert ist zunächst Information und wird nicht allein durch die Anzeige ausdrücklich übergeben.

Insbesondere sind „nicht angegeben“, `$false`, `$null`, leere Zeichenfolge und `0` unterschiedliche Zustände. Ein eigener Übergabezustand ist daher notwendig; die bloße Änderung eines Feldes genügt als Modell nicht.

### Sichtbarkeitsstufen

| Stufe | Inhalt |
| --- | --- |
| Grundansicht | Aktuell erforderliche, bereits belegte und als wesentlich eingestufte Parameter |
| F10: Weitere Parameter | Zusätzlich die übrigen fachlichen Parameter der aktuell möglichen Aufrufvarianten |
| F9: Alle Parameter | Zusätzlich gemeinsame Parameter und eine Übersicht über Parameter anderer Aufrufvarianten |

Die Grundansicht ist der Einstieg. Beim Einblenden bleibt die Reihenfolge nachvollziehbar und stabil. Zusätzliche Bereiche werden sichtbar abgegrenzt. Die Maske zeigt an, dass weitere Parameter verfügbar sind. Eine Parametersuche ermöglicht den gezielten Zugriff.

Belegte Parameter bleiben auch bei Rückkehr zur Grundansicht sichtbar. Inaktive gespeicherte Angaben aus anderen Parametersätzen werden als inaktiv kenntlich gemacht und nicht als aktuelle Übergabe dargestellt. Mehr Sichtbarkeit ändert keine Bindungs- oder Gültigkeitsregeln. Noch nicht ermittelbare dynamische Parameter können erst im passenden Kontext ergänzt werden.

PowerShell-Metadaten bestimmen nicht zuverlässig die fachlich wichtigsten Parameter. Die Grundauswahl soll belegte und erforderliche Parameter sowie Parameter zur Unterscheidung von Aufrufvarianten berücksichtigen. Positionsparameter sind ein Anhaltspunkt. Optionale Darstellungsprofile und persönliche Festlegungen sollen wesentliche Parameter und deren Reihenfolge ergänzen können. Die genaue Auswahlregel und das Format solcher Profile sind noch offen.

## 7. Parametersätze und Bearbeitungszustand

Parametersätze werden zunächst aus den Eingaben abgeleitet. Solange mehrere Varianten möglich sind, wird dies angezeigt. „Aufrufvariante wählen“ ermöglicht eine ausdrückliche Auswahl und zeigt die unterscheidenden Parameter.

Bei widersprüchlichen Angaben erklärt die Oberfläche den Konflikt. Ein bestätigter Variantenwechsel darf bisherige Werte nicht stillschweigend verlieren lassen. Nicht mehr passende Angaben bleiben während der TUI-Bearbeitung gespeichert, sind jedoch inaktiv und erscheinen weder im Aufruf noch als aktive Übergabe. Bei Rückkehr zur vorherigen Variante können sie wiederhergestellt werden.

Beim Zurückgehen zur Befehlsauswahl bleiben Parameterwerte während des laufenden TUI-Aufrufs erhalten. Die erneute Auswahl desselben Befehls setzt die Bearbeitung fort. Ein anderer Befehl erhält diese Werte nicht automatisch.

## 8. F4-Auswahlhilfen und Wertquellen

| Kontext | F4-Unterstützung |
| --- | --- |
| Gewählter Befehl | Parameterformular öffnen |
| Verbindliche Wertemenge | Zulässige Werte auswählen |
| Argumentvervollständigung | Vorschläge anzeigen; erlaubte freie Eingabe erhalten |
| Pfad | Kontextbezogene Pfadvervollständigung beziehungsweise Navigation |
| Mehrere Werte | Einträge hinzufügen, bearbeiten und entfernen |
| Variablenmodus | Im aufrufenden Kontext sichtbare Sitzungsvariablen auswählen |
| Keine spezifische Auswahlhilfe | Eingabearten und vorhandene Feldinformationen anbieten |

Verbindliche Wertemengen und unverbindliche Vorschläge sind erkennbar verschieden. Fehlende Vorschläge verhindern eine zulässige freie Eingabe nicht.

Als Wertquellen sind feste Werte, Variablenreferenzen und bewusst eingegebene PowerShell-Ausdrücke vorgesehen. `$quelle` als Text und `$quelle` als Referenz werden dadurch eindeutig unterschieden. Die Variablenauswahl zeigt Name, Typ und eine geeignete Vorschau; passende Typen werden bevorzugt, weitere Kandidaten bleiben zugänglich. Die Referenz bleibt im aufgebauten Aufruf erhalten.

Ausdrücke werden nicht automatisch beim Tippen ausgeführt. Komplexe Objekte dürfen nicht unbemerkt in Text umgewandelt werden. PowerShell bleibt für tatsächliche Typkonvertierung und Parameterbindung maßgeblich.

## 9. Tastenkonzept

| Taste | Bedeutung in Show-CommandTui400 |
| --- | --- |
| F1 | Kontextbezogene Hilfe zum Feld, Befehl oder zur Meldung |
| F3 | TUI verlassen |
| F4 | Formular oder Auswahlhilfe öffnen |
| F5 | Informationen aktualisieren und Eingaben erhalten |
| F9 | Alle Parameter anzeigen, im Kontext des Parameterformulars |
| F10 | Zusätzliche Parameter anzeigen |
| F11 | Fachliche Erläuterungen und technische Parameterdetails umschalten |
| F12 / Esc | Eine Dialogebene zurück; Bearbeitungsstand erhalten |
| Tab / Umschalt+Tab | Feld wechseln |
| Pfeil hoch/runter | In Listen navigieren |
| Bild hoch/runter | Seitenweise navigieren |
| Enter | Auswahl übernehmen beziehungsweise Formulareingabe prüfen und abschließen |

Eine sichtbare, kontextabhängige Legende beschreibt verfügbare Aktionen. Eine Funktionstaste hat nur dort eine Funktion, wo diese definiert ist. F9 ist beispielsweise keine automatisch vereinbarte Historienfunktion in der Befehlsliste.

Erweiterte Funktionen wie Bedienhilfe, vollständige Befehlsvorschau und Fehlerübersicht sind über ein tastaturbedienbares Aktionsmenü erreichbar. Die grundlegende Bedienung soll mit F1 bis F12 auskommen. Alternative Belegungen für Terminal- oder Betriebssystemkonflikte sind vorzusehen; genaue Alternativen und die Taste des Aktionsmenüs bleiben offen.

Die Anpassung ist bewusst keine vollständige Nachbildung der IBM-Tastenbelegung. Besonders F5 behält die vereinbarte Bedeutung „Informationen aktualisieren, Eingaben erhalten“.

## 10. Prüfung, Abschluss und Rückgabe

Bekannte Eingabefehler werden am Feld angezeigt, ohne den Wert zu verwerfen. Prüfungen mit Codeausführung oder externen Abfragen benötigen eine bewusst festgelegte Auslösung. Eine erfolgreiche Formularprüfung bestätigt nur die prüfbaren Eingaberegeln; sie garantiert keinen erfolgreichen Zielbefehl.

Die Vorschau zeigt den vorgesehenen Aufruf einschließlich ausdrücklich übergebener Parameter, Variablenreferenzen und nötiger Modulqualifizierung.

| Abschlussaktion | Ergebnis |
| --- | --- |
| In Befehlszeile übernehmen | TUI schließt; der Aufruf steht bearbeitbar am PowerShell-Prompt. |
| Ausführen | TUI gibt das Terminal frei; der Aufruf läuft im vorgesehenen Kontext der aktuellen Sitzung. Ausgaben und Rückfragen erscheinen dort. |

Die beiden Abschlusswege bleiben ausdrücklich unterscheidbar. Das Abschließen eines Eingabefeldes oder Auswählen eines Befehls führt den Zielbefehl nicht aus.

## 11. Optionale Bediengeräte

### 11.1 Gemeinsame Aktionen und Zustände

Tastatur, Stream Deck XL und MX Keypad bedienen dieselben fachlichen Aktionen. „Weitere Parameter anzeigen“ hat unabhängig vom Eingabegerät dieselben Voraussetzungen und Auswirkungen. Die TUI bleibt maßgeblich für den aktiven Dialog, den Fokus, den Bearbeitungsstand und die Verfügbarkeit einer Aktion.

Für die weitere Ausarbeitung wird ein gemeinsamer Aktionsbestand vorgesehen: Hilfe, Zurück, Bestätigen, vorheriger/nächster Eintrag oder Feld, kontextbezogene Auswahl öffnen, Aktualisieren, Module anzeigen, weitere/alle Parameter, Vorschau sowie die beiden Abschlussaktionen. Die genaue technische Schnittstelle wird später festgelegt.

Bei geeigneter Anbindung können beide Geräte gleichzeitig dieselbe TUI bedienen. Sie führen keinen unabhängigen Formularzustand. Texte werden weiterhin über die Tastatur eingegeben; die Zusatzgeräte erleichtern vor allem Navigation, Auswahl, Ansicht und Abschluss.

### 11.2 Ausbaustufen

| Stufe | Umfang | Grenze |
| --- | --- | --- |
| 1: Tastenprofile | Gerätesoftware sendet einzelne Funktionstasten beziehungsweise Tastenkombinationen an das fokussierte Terminal. Beschriftungen nennen Aktion und gegebenenfalls Tastenkürzel. | Keine verlässliche Rückmeldung des inneren TUI-Zustands; Ziel wird durch den Eingabefokus bestimmt. |
| 2: Kontextabhängige Adapter | Geräteadapter tauschen Aktionen und Zustandsinformationen mit einer eindeutig zugeordneten TUI-Instanz aus. Anzeigen passen sich an Dialog und verfügbare Aktionen an. | Geräte- und plattformspezifische Integration muss praktisch geprüft werden. |

Für Stufe 1 werden getrennte, geeignete Profile je Gerät und Betriebssystem vorgesehen. Ein Tastendruck löst eine einzelne Bedienaktion aus. Aufgezeichnete Folgen von Tab- und Enter-Tasten sind keine Grundlage der Formularnavigation. Ein Profil kann zunächst manuell aktiviert werden; die Erkennung der Terminalanwendung allein identifiziert keine laufende TUI.

Stufe 2 ergänzt Rückmeldungen wie Dialogtyp, Aktionsbezeichnung, Verfügbarkeit und Beschäftigtzustand. Plugin-SDKs von Elgato und Logitech sind mögliche Anbindungen. Logitech bietet dafür auch C# an. Diese Quellen belegen die verfügbaren Erweiterungsmöglichkeiten, noch keine fertige Show-CommandTui400-Integration. [13–16]

### 11.3 Layout und Beschriftung

Das Stream Deck XL bietet Platz für feste Navigation und mehrere kontextbezogene Aktionen. Beim kleineren MX Keypad werden häufige Aktionen priorisiert und weitere über Seiten oder ein Aktionsmenü erschlossen. Beide Geräte sollen jeweils auch allein sinnvoll bedienbar sein.

Hilfe, Zurück und Bestätigen behalten möglichst feste Positionen. Tasten werden nach Wirkung beschriftet, beispielsweise „Weitere Parameter“ mit einem ergänzenden „F10“. Unverfügbare Aktionen bleiben in Stufe 2 an ihrem Platz erkennbar inaktiv oder werden dort durch eine eindeutig bezeichnete Statusanzeige ersetzt; sie rücken nicht unbemerkt zusammen.

| TUI-Kontext | Beispiele für Geräteaktionen in Stufe 2 |
| --- | --- |
| Befehlsauswahl | Auswählen, Parameter öffnen, Module, Aktualisieren |
| Moduldialog | Details, Befehle anzeigen, ausdrücklich Modul laden, Zurück |
| Parameterformular | Werte auswählen, weitere/alle Parameter, Hilfe, Vorschau, Abschließen |
| Werteauswahl | Vorheriger/nächster Eintrag, Übernehmen, Zurück |
| Abschlussdialog | In Befehlszeile übernehmen, Ausführen, Zurück |
| Modulimport oder laufende Abfrage | Beschäftigtzustand; nur tatsächlich verfügbare Aktionen |

Die Tastenlegende im Terminal und die Gerätebeschriftungen verwenden dieselben Aktionsnamen. „Bestätigen“ bleibt kontextbezogen und wird nicht stillschweigend zu einem universellen Ausführungsbefehl. „Ausführen“ gehört zur ausdrücklich bezeichneten Abschlussaktion und darf die vereinbarte Prüfung nicht umgehen. Das endgültige Layout wird später gemeinsam festgelegt.

### 11.4 Sitzung und Lebenszyklus

Bei Hotkey-Profilen gilt der Fokus des Terminals. Bei der direkten Anbindung wird jede laufende TUI eindeutig identifiziert und eine Zielsitzung ausdrücklich erkennbar zugeordnet. Mehrere Terminalfenster, Tabs oder TUI-Instanzen dürfen nicht aufgrund derselben Prozessbezeichnung verwechselt werden. Ein Sitzungswechsel aktualisiert Anzeigen und Zuordnung gemeinsam.

Eine Aktion wird nur im gültigen Kontext der zugeordneten Instanz verarbeitet. Nach dem Schließen einer TUI werden deren direkte Geräteaktionen inaktiv. Ein Wiederverbinden synchronisiert den aktuellen Zustand; zuvor ausstehende Eingaben werden nicht nachträglich ausgeführt. Ob und wie Fokuswechsel automatisch zur Auswahl der Zielinstanz führen können, ist noch zu untersuchen.

Anschließen, Abziehen oder Ausfall eines Geräts verändert weder Parameterwerte noch die aktuelle Auswahl. Die Tastatur bleibt durchgehend nutzbar. Ein Ausfall eines Adapters verhindert nicht die weitere TUI-Bedienung. Die Unterstützung ist optional und setzt gegebenenfalls installierte und eingerichtete Gerätesoftware voraus.

### 11.5 Plattformumfang und spätere Erprobung

Die TUI selbst bleibt auf macOS, Linux und Windows ausgerichtet. Die offiziellen Herstelleranwendungen für Stream Deck und MX Keypad unterstützen Windows und macOS. Für Stream Deck ist unter Linux beispielsweise StreamController ein möglicher zusätzlicher Adapterweg; die konkrete XL-Unterstützung und Integration sind praktisch zu prüfen. Eine Linux-Unterstützung des MX Keypad wird bislang nicht zugesagt. [13–17]

Für die spätere Umsetzung sind folgende Bedienfälle zu erproben:

- Tastatur allein, jedes Gerät allein als Ergänzung und beide Geräte gleichzeitig.
- Gleiche Wirkung einer Aktion über Tastatur und Zusatzgerät.
- Wechsel zwischen Befehlsliste, Formular, Werteauswahl und Abschlussdialog.
- Verlust und Wiederherstellung der Geräteverbindung bei erhaltenem Bearbeitungsstand.
- Mehrere TUI-Instanzen und eindeutiger Wechsel der Zielsitzung.
- Veraltete Geräteanzeige oder Beschäftigtzustand: Die TUI entscheidet weiterhin über die gültige Aktion.
- Unterscheidung zwischen Übernehmen und Ausführen ohne doppelte Auslösung desselben Geräteereignisses.

## 12. Offene Detail- und Machbarkeitsfragen

Diese Punkte sind keine Änderung des Bedienkonzepts, sondern bei der weiteren Ausarbeitung zu klären:

- Verlässlicher Zugriff auf den aufrufenden Kontext trotz Funktions- und Modul-Scope; dieselbe Sitzung allein garantiert nicht denselben Sichtbarkeitsbereich.
- Übergabe eines aufgebauten Aufrufs in den nächsten bearbeitbaren Prompt. Reine String-Ausgabe eines Cmdlets erfüllt diese Anforderung nicht; eine Zeileneditor-/Host-Integration ist notwendig.
- Konkrete Einbindung der TUI und der PowerShell-Abfragen in den laufenden Runspace.
- Auswahl und Reihenfolge wesentlicher Parameter; Darstellungsprofile und persönliche Anpassungen.
- Genaue Rückschaltbedienung zwischen Grundansicht, weiteren und allen Parametern.
- Behandlung dynamischer Metadaten, benutzerdefinierter Validierung und langsam laufender Completer.
- Modulidentität bei mehreren installierten Versionen; eine explizite Versionsauswahl wurde noch nicht festgelegt.
- Nicht vollständig ermittelbare Befehlsbestände und belastbare Kennzeichnung ihres Informationsstands.
- Konkrete Terminalunterstützung, Funktionstastenübermittlung, Größenänderung und alternative Tastenbelegungen.
- Darstellungsdetails des Abschlussdialogs und Verhalten nach Laufzeitfehlern.
- Geräteprofile und endgültige Tastenlayouts für Stream Deck XL und Logitech MX Keypad.
- Direkte Adapteranbindung, Zustandsabgleich und Instanz-/Fokuszuordnung bei mehreren Terminals.
- Linux-Anbindung der optionalen Geräte, insbesondere ungeklärte Unterstützung des MX Keypad.

## 13. Begründung durch das IBM-Vorbild

Die recherchierte Grundlage bestätigt die kompakte Startansicht: IBM kann selten benötigte Parameter deklarativ zurückstellen und über F10 ergänzen. Bereits angegebene Werte machen solche Parameter vorher sichtbar. F9 erweitert die Sicht bei Prompt-Steuerung. F4 führt kontextbezogen zu weiterer Eingabeunterstützung. [1–3]

IBM unterscheidet außerdem Schlüsselparameter und kann nach deren Eingabe aktuelle Objektwerte für weitere Felder ermitteln. Für PowerShell wird daraus keine generische automatische Abfrage bestehender Objektzustände abgeleitet; dafür wäre zusätzliches Wissen über das jeweilige Cmdlet erforderlich. [4]

Die dokumentierten Funktionen für Schlüsselwortanzeige, Befehlsvorschau, Hilfe und Fehlermeldungen begründen die entsprechende Unterstützung im Projekt. Historische Tastenzuordnung und Projektanpassung bleiben getrennt: Insbesondere kann F5 in IBM-i-Promptdialogen Werte zurücksetzen, während unser F5 Eingaben erhält. [3]

## 14. Quellen

Die Quellen stützen die technischen Grundlagen und das historische Vorbild. Die projektspezifischen Bedienregeln dieses Dokuments sind die aus der Diskussion abgeleiteten Festlegungen. Recherche: 27. September 2026.

1. IBM: Hiding additional or advanced parameters when prompting a CL command.  
   https://www.ibm.com/docs/en/i/7.4.0?topic=spcccp-hiding-additional-advanced-parameters-when-prompting-cl-command
2. IBM: CL Programming V5R3, insbesondere Prompt Control und Additional Parameters, gedruckte Seiten 321–325.  
   https://public.dhe.ibm.com/systems/power/docs/systemi/v5r3/en_US/sc415721.pdf
3. Fortra: Dokumentierter IBM-i-Promptdialog, Configure Default Thresholds (AVCFGTHR), Function Keys.  
   https://hstechdocs.helpsystems.com/manuals/powertech/powertech-antivirus-for-ibm-i/current/user_guide/content/configure-apex-thresholds.htm
4. IBM: Key parameters and prompt override programs for a CL command.  
   https://www.ibm.com/docs/en/i/7.4.0?topic=commands-key-parameters-prompt-override-programs-cl-command
5. Microsoft: Get-Command.  
   https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/get-command?view=powershell-7.5
6. Microsoft: Get-Module.  
   https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/get-module?view=powershell-7.5
7. Microsoft: about_Preference_Variables, PSModuleAutoLoadingPreference.  
   https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_preference_variables?view=powershell-7.5#psmoduleautoloadingpreference
8. Microsoft: about_Functions_Advanced_Parameters.  
   https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_functions_advanced_parameters?view=powershell-7.5
9. Microsoft: about_Functions_Argument_Completion.  
   https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_functions_argument_completion?view=powershell-7.6
10. Microsoft: about_Parameter_Sets.  
    https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_parameter_sets?view=powershell-7.5
11. Microsoft: about_Scopes.  
    https://learn.microsoft.com/en-us/powershell/module/microsoft.powershell.core/about/about_scopes?view=powershell-7.5
12. Microsoft: PSConsoleHostReadLine und Set-PSReadLineKeyHandler.  
    https://learn.microsoft.com/en-us/powershell/module/psreadline/psconsolehostreadline?view=powershell-7.6  
    https://learn.microsoft.com/en-us/powershell/module/psreadline/set-psreadlinekeyhandler?view=powershell-7.5
13. Elgato: Stream Deck XL und Profile.  
    https://www.elgato.com/us/en/p/stream-deck-xl  
    https://docs.elgato.com/stream-deck/profiles/getting-started/
14. Elgato: Stream Deck SDK, Plugin WebSocket Reference.  
    https://docs.elgato.com/streamdeck/sdk/references/websocket/plugin/
15. Logitech: MX Keypad, Produkt und Einführung vom 8. September 2026.  
    https://www.logitech.com/en-us/shop/p/mx-keypad  
    https://news.logitech.com/press-releases/news-details/2026/Logitech-Unveils-MX-Keypad-for-Developers-The-Customizable-Multi-App-AI-Control-Center/default.aspx
16. Logitech: Logi Actions SDK.  
    https://logitech.github.io/actions-sdk-docs/
17. StreamController: Projekt für Stream-Deck-Unterstützung unter Linux.  
    https://github.com/StreamController/StreamController

## 15. Fortschreibung

Dieser Stand ersetzt frühere Vorschläge, das Formular standardmäßig vollständig aufzuklappen oder Enter zum nächsten Feld wechseln zu lassen. Künftige Bedienungsentscheidungen werden als nachvollziehbare Weiterentwicklung dieser Konzeptbasis festgehalten.

| Konzeptstand | Änderung |
| --- | --- |
| 0.1 · 27. September 2026 | Erste konsolidierte Konzeptbasis mit Befehlsauswahl, Modulen, Parameterformular und IBM-orientierter Tastenbedienung. |
| 0.2 · 27. September 2026 | Stream Deck XL und ausdrücklich das eigenständige Logitech MX Keypad als optionale Bediengeräte aufgenommen; gemeinsame Aktionen, gestufte Anbindung, Sitzungszuordnung, Verbindungswechsel und Plattformgrenzen verfeinert. |
