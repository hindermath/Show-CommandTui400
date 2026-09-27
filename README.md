# Show-CommandTui400

Eine OS/400-inspirierte, rein textbasierte Bedienoberfläche für PowerShell 7.

## Ziel

Das Cmdlet startet in der aktuellen pwsh-Sitzung. Verb- und Nomenpräfixe grenzen die Befehlsauswahl ein. Pfeiltasten und Enter wählen einen Befehl; F4 öffnet das Parameterformular. Eine kompakte Ansicht zeigt die wichtigsten Felder, F10 weitere und F9 sämtliche Parameter. Zum Abschluss lässt sich der Aufruf zur Bearbeitung in die Befehlszeile übernehmen oder ausdrücklich ausführen.

Zielplattformen: macOS, Linux und Windows einschließlich Windows Terminal. Stream Deck XL und Logitech MX Keypad sind optionale Ergänzungen.

## Projektstand

Konzept- und Anforderungsphase. Es gibt noch keine installierbare Implementierung. Framework, minimale PowerShell-Version und technische Sitzungsintegration werden durch Machbarkeitsnachweise entschieden.

- [Bedienkonzept v0.2](docs/Bedienkonzept.md)
- [Lastenheft-Reihenfolge und acht Issues](docs/Lastenheft-Plan.md)
- [Repository-Einstellungen und offene Schutzregeln](docs/Repository-Einstellungen.md)

Die Lastenheft-Issues bilden die Eingabe für einen noch einzurichtenden Spec-Kit-Prozess. Sie sind keine Implementierungsfreigabe.

## Lizenz

MIT, entsprechend TinyCalc und TinyPl0. TuiVision dient als Vorbild für Repository-Regeln und Intake-Struktur; eine technische Abhängigkeit ist damit nicht beschlossen.

