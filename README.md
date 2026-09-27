# Show-CommandTui400

Eine OS/400-inspirierte, rein textbasierte Bedienoberfläche für PowerShell 7.

## Ziel

Das Cmdlet startet in der aktuellen pwsh-Sitzung. Verb- und Nomenpräfixe grenzen die Befehlsauswahl ein. Pfeiltasten und Enter wählen einen Befehl; F4 öffnet das Parameterformular. Eine kompakte Ansicht zeigt die wichtigsten Felder, F10 weitere und F9 sämtliche Parameter. Zum Abschluss lässt sich der Aufruf zur Bearbeitung in die Befehlszeile übernehmen oder ausdrücklich ausführen.

Zielplattformen: macOS, Linux und Windows einschließlich Windows Terminal. Stream Deck XL und Logitech MX Keypad sind optionale Ergänzungen.

## Projektstand

Konzept- und Anforderungsphase. Es gibt noch keine installierbare Implementierung. Framework, minimale PowerShell-Version und technische Sitzungsintegration werden durch Machbarkeitsnachweise entschieden.

- [Bedienkonzept v0.2](docs/Bedienkonzept.md)
- [Lastenheft-Reihenfolge und acht Issues](docs/Lastenheft-Plan.md)
- [Repository-Einstellungen und aktive Schutzregeln](docs/Repository-Einstellungen.md)
- [Entwicklungsumgebung und installierte Governance](docs/Entwicklungsumgebung.md)
- [Projektstatistik](docs/project-statistics.md)

Die Lastenheft-Issues bilden die Eingabe für den in LH-00 zu konkretisierenden
Spec-Kit-Prozess. Die Werkzeuge und 14 Governance-Presets sind eingerichtet.
Die Issues sind keine Implementierungsfreigabe.

## Spec-Kit: Einrichtung und nächste Schritte

Die [Entwicklungsumgebung](docs/Entwicklungsumgebung.md) beschreibt installierte
Versionen, Prüfkommandos und offene Prozessentscheidungen. LH-00 konkretisiert
das Intake-Verfahren; Installation allein startet keinen Feature-Lauf.

## Barrierefreiheit (A11Y)

`Programmierung #include<everyone>` gilt als Leitspruch. Das Bedienkonzept
fordert Tastaturbedienung und textorientierte Nutzung mit Screenreadern und
Braille-Zeilen; WCAG 2.2 AA wird angewendet, soweit die Kriterien passen.
Die Laufzeitabnahme steht aus, da noch keine Implementierung existiert.

## Für Azubis

Zum Einstieg zuerst das [Bedienkonzept](docs/Bedienkonzept.md), anschließend
die [Lastenheft-Reihenfolge](docs/Lastenheft-Plan.md) lesen. Es gibt noch kein
installierbares Cmdlet. Das Lesen der Konzepte setzt weder ein GitHub-Konto
noch einen KI-Agenten voraus; konkrete Lernaufträge bleiben gesondert festzulegen.

## Lizenz

MIT, entsprechend TinyCalc und TinyPl0. TuiVision dient als Vorbild für Repository-Regeln und Intake-Struktur; eine technische Abhängigkeit ist damit nicht beschlossen.
