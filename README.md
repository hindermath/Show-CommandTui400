# Show-CommandTui400

Eine OS/400-inspirierte, rein textbasierte Bedienoberfläche für PowerShell 7:
Befehle finden, Parameter geführt ausfüllen und den fertigen Aufruf in der
aktuellen Sitzung verwenden.

**Projektstand: Konzept- und Anforderungsphase.** Die Level-2-Projektumgebung
auf Basis von [home-baseline](https://github.com/hindermath/home-baseline) ist
eingerichtet. Als Nächstes entstehen die Lastenhefte. Ein installierbares
Cmdlet gibt es noch nicht.

## Das geplante Bedienkonzept

`Show-CommandTui400` soll als Cmdlet in der aktuellen `pwsh`-Sitzung starten.
Die Bedienung erfolgt vollständig im Terminal auf macOS, Linux und Windows,
einschließlich Windows Terminal.

1. Erste Buchstaben des Verbs eingeben und die angezeigte Befehlsliste eingrenzen.
2. Nach dem vollständigen Verb mit Bindestrich und Nomenpräfix weiterfiltern.
3. Mit Pfeil hoch/runter navigieren und mit Enter einen Befehl auswählen.
4. Mit **F4** das Parameterformular öffnen.
5. Zunächst wichtige und erforderliche Parameter bearbeiten; **F10** zeigt
   weitere passende Parameter, **F9** sämtliche Parameter.
6. Den vorbereiteten Aufruf zur weiteren Bearbeitung in die Befehlszeile
   übernehmen oder ausdrücklich in der aktuellen Sitzung ausführen.

Datentypen, Parametersätze, Wertehilfe und Validierung sollen bei der Eingabe
unterstützen. Bereits eingegebene Werte bleiben beim Wechsel der Ansichten
erhalten. Stream Deck XL und Logitech MX Keypad sind optionale Ergänzungen;
alle Kernfunktionen bleiben über die Tastatur erreichbar.

Die fachlichen Einzelheiten stehen im [Bedienkonzept v0.2](docs/Bedienkonzept.md).

## Was bereits eingerichtet ist

- Eigenständiges **Level-2-Repository** mit gemeinsamer Agenten-Guidance,
  Wartungswerkzeugen, Hooks und Secret-Scanning.
- **Spec Kit 0.12.8**, fünf Integrationen für Codex, Claude, Copilot,
  OpenCode und Antigravity sowie **14 versionsgebundene Governance-Presets**.
- Werkzeuge für Lastenheft-Erstellung, Review und Abhängigkeitsverwaltung.
- CI-Workflows für Setup-Validierung, PowerShell-Analyse und die
  mitgelieferte Home-Baseline-Wartungs-TUI.
- Aktive Schutzregeln für `main` und automatische Copilot-Reviews.
- Acht vorbereitete Lastenheft-Issues mit Anforderungen, Abnahmekriterien
  und verlinkten Abhängigkeiten.

Die [Entwicklungsumgebung](docs/Entwicklungsumgebung.md) dokumentiert Versionen,
Prüfkommandos und offene Nachweise. Den aktuellen Ausführungsstatus zeigt
[GitHub Actions](https://github.com/hindermath/Show-CommandTui400/actions).
Die Einrichtung und ihre Prüfungen belegen noch keine Produktfunktion.

Implementierungssprache, TUI-Framework, minimale PowerShell-Version und
technische Sitzungsintegration werden im weiteren Verfahren entschieden.
Die .NET-basierte Wartungs-TUI gehört zu home-baseline und legt die
Produktarchitektur nicht fest.

## Entwicklungs- und Testumgebungen

| Umgebung | Rolle |
|---|---|
| Zwei macOS-Systeme | Entwicklung; laut Owner ist PowerShell 7.6.6.0 installiert |
| Windows 11 | PowerShell-First-Umgebung für native Windows-Abläufe |
| Ubuntu 24.04 unter WSL2 auf Windows 11 | Linux-Kompatibilitätstestumgebung |

Stand der Umgebungsangaben: **28.09.2026**. Windows- und WSL2-Ergebnisse werden
getrennt dokumentiert. Die konkreten PowerShell-Versionen unter Windows und
WSL2 sind noch zu erfassen.

Spec Kit ist bisher mit Bash-Basisskripten initialisiert. Der durchgängige
Ablauf mit PowerShell-Basisskripten bleibt Bestandteil der Prozessprüfung in
LH-00. Die lokal installierte PowerShell-Version ist keine Festlegung der
späteren Produkt-Mindestversion.

## Nächster Schritt: Lastenhefte

Ein Lastenheft beschreibt die fachlichen Anforderungen und ihre Abnahme.
Die vorbereiteten Issues dienen dafür als Eingabe.

Begonnen wird mit **[LH-00: Spec-Kit-Projektprofil und Lastenheft-Prozess](https://github.com/hindermath/Show-CommandTui400/issues/1)**.
Dabei werden die projektspezifische Intake-Policy, Ablage, Statusmodell und
das Reviewverfahren konkretisiert.

Danach folgen TUI-Grundlage und Sitzung, Cmdlet-Suche, Parameterformular,
Wertehilfe und Aufrufabschluss. Geräteprofile und dynamische Geräteadapter
sind nachgelagerte optionale Ausbaustufen. Die verbindliche Reihenfolge mit
allen acht Issues steht im [Lastenheft-Plan](docs/Lastenheft-Plan.md).

Installierte Agenten-Kommandos für Erstellung, Review und Reihenfolge sind
in der [Entwicklungsumgebung](docs/Entwicklungsumgebung.md#verfügbare-intake-kommandos)
aufgeführt. Die Issues und die Werkzeuginstallation starten keine
Produktimplementierung oder autonomen Läufe.

## Dokumentation

| Einstieg | Inhalt |
|---|---|
| [Bedienkonzept](docs/Bedienkonzept.md) | Fachliche Baseline und geplante Bedienabläufe |
| [Lastenheft-Plan](docs/Lastenheft-Plan.md) | Reihenfolge, Abhängigkeiten und Issue-Links |
| [Entwicklungsumgebung](docs/Entwicklungsumgebung.md) | Einrichtung, Plattformen, Kommandos und Prüfungen |
| [Repository-Einstellungen](docs/Repository-Einstellungen.md) | GitHub-Einstellungen und aktive Schutzregeln |
| [Agenten-Guidance](AGENTS.md) | Gemeinsame Arbeitsregeln für KI-Agenten |
| [Projektstatistik](docs/project-statistics.md) | Versionierter Text und Git-Aktivität, einschließlich übernommener Werkzeuge |

## Barrierefreiheit (A11Y)

`Programmierung #include<everyone>` gilt als Leitspruch. Das Bedienkonzept
fordert Tastaturbedienung und textorientierte Nutzung mit Screenreadern und
Braille-Zeilen; WCAG 2.2 AA wird angewendet, soweit die Kriterien passen.
Die Laufzeitabnahme steht aus, da noch keine Implementierung existiert.

## Für Azubis

Zum Einstieg zuerst das [Bedienkonzept](docs/Bedienkonzept.md), anschließend
den [Lastenheft-Plan](docs/Lastenheft-Plan.md) lesen. Das Lesen der Konzepte
setzt weder ein GitHub-Konto noch einen KI-Agenten voraus; konkrete
Lernaufträge bleiben gesondert festzulegen.

## Lizenz

[MIT](LICENSE), entsprechend TinyCalc und TinyPl0. TuiVision dient als Vorbild
für Repository-Regeln und Intake-Struktur; eine technische Abhängigkeit ist
damit nicht beschlossen.
