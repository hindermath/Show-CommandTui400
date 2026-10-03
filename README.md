# Show-CommandTui400

Eine OS/400-inspirierte, rein textbasierte Bedienoberfläche für PowerShell 7:
Befehle finden, Parameter geführt ausfüllen und den fertigen Aufruf in der
aktuellen Sitzung verwenden.

**Projektstand: Konzept- und Anforderungsphase.** Die Level-2-Projektumgebung
auf Basis von [home-baseline](https://github.com/hindermath/home-baseline) ist
eingerichtet. Das erste Lastenheft [LH-00](intakes/LH-00.md) liegt mit dem Authoring-Status `ReadyForReview` vor. Ein installierbares Cmdlet gibt es noch nicht. Die acht überarbeiteten Issues sind
[veröffentlicht und geprüft](docs/issue-publication.md); Quellen und Grenzen stehen in der
[Governance-Zuordnung](docs/intake-governance.md).

An OS/400-inspired, text-only interface for PowerShell 7: find commands,
enter parameters with guidance and use the prepared invocation in the current
session. The project is in the concept and requirements phase. Its independent
Level-2 environment is configured. LH-00 has authoring status ReadyForReview;
there is no installable cmdlet. The eight revised issues are published and verified (see the publication evidence above). The
linked governance mapping records sources and boundaries.

## Koordinierter Governance-Pilot / Coordinated governance pilot

Die [gebundenen Quellen und Prüfgrenzen](docs/maintenance/coordinated-governance-oct03.md)
beschreiben das aktualisierte 14er-Profil und das Wartungspaket aus Home Baseline
#317. Installation startet keine Produktimplementierung; die technische Lieferung
und die spätere praktische Prozessabnahme sind getrennt.

The integration record binds the updated fourteen-preset profile and approved
maintenance files. Installation starts no implementation; technical delivery
and later practical process acceptance remain separate.

## Reviewstand LH-00 / LH-00 review status

Das [unabhängige erneute Intake-Review](specs/intake-review-report.md) ergibt
**Ready**: keine offenen Befunde, Fragen oder akzeptierten Risiken. Begriffe und
normative DE/EN-Aussagen sind korrigiert; ein anderer Agent als der Autor hat
vollständig geprüft. [Reparatur und Nachweise](docs/lh00-repair-validation.md)
sind dokumentiert. Prozess- und Produktabnahme bleiben offen. Die daraus erstellte
Spezifikation und der nächste mögliche Schritt sind unten verlinkt.

The independent complete re-review returns **Ready**, with no open findings,
questions or accepted risks. Terms and normative DE/EN wording are corrected;
an agent other than the author performed the review. Repair evidence is linked
above. Process and product acceptance remain open. The resulting specification
and next possible step are linked below.

## Spezifikation des LH-00-Prozesses / LH-00 process specification

Die [DE/EN-Spezifikation](specs/001-lh00-intake-process/spec.md) beschreibt
ausschließlich den Prozess aus LH-00: Erstellung und Änderung von Lastenheften,
unabhängiges Review, Berechtigungen, Serienverwaltung und erforderliche Nachweise.
Die [Qualitätscheckliste](specs/001-lh00-intake-process/checklists/requirements.md)
enthält 16 bestandene Punkte der lokalen Selbstprüfung. Der
[Governance-Nachweis](specs/001-lh00-intake-process/checklists/governance.md)
trennt geprüfte Dokumente von offenen Plattform-, A11Y- und Prozessnachweisen.
Der [Implementierungsplan](specs/001-lh00-intake-process/plan.md) ergänzt Datenmodell,
Schnittstellenverträge und [Prüfanleitung](specs/001-lh00-intake-process/quickstart.md).
Vor Serienaktivierung ist ein belegter Widerspruch der Collection-Validatoren zu
beheben. Nächste mögliche Phase ist `speckit-tasks` nach gesondertem Auftrag.
Die Planung enthält keine Produktfunktionen aus LH-01–LH-07.

The linked DE/EN specification covers only the LH-00 process: intake creation
and updates, independent review, authority, series management and required
evidence. Its quality checklist records sixteen passed local self-checks.
Governance evidence separates checked documents from outstanding platform,
accessibility and process evidence. The implementation plan adds a data model,
interface contracts and a validation guide. A demonstrated collection-validator
conflict must be resolved before series activation. The next possible phase is
speckit-tasks after a separate request. Planning adds no LH-01–LH-07 product functions.

## Das geplante Bedienkonzept / Planned interaction concept

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

Show-CommandTui400 is intended to start as a cmdlet in the current pwsh session,
entirely in a terminal on macOS, Linux and Windows, including Windows Terminal.
Type a verb prefix and then a noun prefix to filter commands. Arrows and Enter
select a command; F4 opens its form. The initial view shows important and
required fields; F10 shows more matching fields and F9 all parameters. Finally,
transfer the invocation to the editable command line or explicitly execute it
in the current session. Types, parameter sets, value assistance and validation
support input. View changes preserve entered values. Stream Deck XL and the
standalone MX Keypad are optional; every core action remains available from
the keyboard. The linked interaction concept contains the domain details.

## Spec-Kit und eingerichtete Projektumgebung / Configured environment

- Eigenständiges **Level-2-Repository** mit gemeinsamer Agenten-Guidance,
  Wartungswerkzeugen, Hooks und Secret-Scanning.
- **Spec Kit 0.12.8**, fünf Integrationen für Codex, Claude, Copilot,
  OpenCode und Antigravity sowie **14 versionsgebundene Governance-Presets**.
- Werkzeuge für Lastenheft-Erstellung, Review und Abhängigkeitsverwaltung.
- Intake Authoring Governance **v0.3.5** korrigiert die Prüfung von Receipts
  der eigenen Generatorvorlage; [Update-Nachweis](docs/maintenance/intake-authoring-v035.md).
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

The repository has shared agent guidance, maintenance tools, hooks and secret
scanning. Spec Kit 0.12.8 provides five integrations (Codex, Claude, Copilot,
OpenCode and Antigravity) and fourteen pinned governance presets. Authoring
0.3.5 fixes validation of receipts from its own generator. Authoring, review and
dependency tools are installed. CI checks setup, PowerShell scripts and the
bundled Home Baseline maintenance TUI. Main is protected and automatic Copilot
reviews are configured. Eight existing issues provide requirements, acceptance
criteria and linked dependencies. The development guide describes versions and
checks; GitHub Actions shows current run status. Setup evidence proves no
product function. Language, TUI framework, minimum PowerShell version and session
integration remain open. The .NET maintenance TUI does not choose product architecture.

## Entwicklungs- und Testumgebungen / Development and test environments

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

Development uses two Macs; the owner reports PowerShell 7.6.6.0 installed on
both. Windows 11 is the PowerShell-first native Windows environment. Ubuntu
24.04 under WSL2 is the Linux compatibility environment. These roles were
reported on 28 September 2026. Windows and WSL2 results are recorded separately;
their PowerShell versions remain to be captured. Spec Kit currently uses Bash
base scripts. End-to-end use of PowerShell base scripts remains an LH-00 process
requirement. Installed development versions do not define the product minimum.

## Nächster Schritt: Lastenhefte / Next step: intakes

Ein Lastenheft beschreibt die fachlichen Anforderungen und ihre Abnahme.
Die vorbereiteten Issues dienen dafür als Eingabe.

Begonnen wurde mit **[LH-00: Spec-Kit-Projektprofil und Lastenheft-Prozess](https://github.com/hindermath/Show-CommandTui400/issues/1)**.
Das minimale [Authoring-Profil](.specify/memory/intake-authoring-profile.md)
und die [veröffentlichten Issue-Grundlagen](docs/issue-publication.md) liegen vor.
Ein Intake ist ein fachliches Lastenheft; sein Receipt belegt Quellen und Inhalt
mit Prüfsummen. `ReadyForReview` bedeutet bereit für eine gesonderte fachliche
Prüfung. Das [aktuelle Review](specs/intake-review-report.md) nennt Ergebnis
und nächsten Schritt; eine Prozess- oder Produktabnahme ist davon getrennt.

Danach folgen TUI-Grundlage und Sitzung, Cmdlet-Suche, Parameterformular,
Wertehilfe und Aufrufabschluss. Geräteprofile und dynamische Geräteadapter
sind nachgelagerte optionale Ausbaustufen. Die verbindliche Reihenfolge mit
allen acht Issues steht im [Lastenheft-Plan](docs/Lastenheft-Plan.md).

Installierte Agenten-Kommandos für Erstellung, Review und Reihenfolge sind
in der [Entwicklungsumgebung](docs/Entwicklungsumgebung.md#intake-commands)
aufgeführt. Die Issues und die Werkzeuginstallation starten keine
Produktimplementierung oder autonomen Läufe.

An intake describes domain requirements and acceptance. Existing issues provide
its input. Work starts with LH-00, the project profile and intake process.
The minimal authoring profile and published issue input now exist. A receipt
records source and content hashes. ReadyForReview means ready for separate
review. The current review report names the outcome and next step; process and
product acceptance remain separate. Later intakes address the session/TUI foundation,
search, form, value assistance and final invocation. Device profiles and dynamic
adapters are optional later stages. The linked order document remains binding.
Installed commands are listed in the development guide. Neither issues nor tool
installation authorize implementation or autonomous runs.

## Dokumentation / Documentation

| Einstieg | Inhalt |
|---|---|
| [Bedienkonzept](docs/Bedienkonzept.md) | Fachliche Baseline und geplante Bedienabläufe |
| [Lastenheft-Plan](docs/Lastenheft-Plan.md) | Reihenfolge, Abhängigkeiten und Issue-Links |
| [LH-00-Prozessspezifikation / LH-00 process specification](specs/001-lh00-intake-process/spec.md) | Anforderungen, Abnahme und nächste Planungsphase / Requirements, acceptance and next planning phase |
| [Entwicklungsumgebung](docs/Entwicklungsumgebung.md) | Einrichtung, Plattformen, Kommandos und Prüfungen |
| [Repository-Einstellungen](docs/Repository-Einstellungen.md) | GitHub-Einstellungen und aktive Schutzregeln |
| [Agenten-Guidance](AGENTS.md) | Gemeinsame Arbeitsregeln für KI-Agenten |
| [Projektstatistik](docs/project-statistics.md) | Versionierter Text und Git-Aktivität, einschließlich übernommener Werkzeuge |

Für das aktuelle Authoring außerdem die [Governance-Zuordnung](docs/intake-governance.md),
den [Index der Issue-Entwürfe](docs/issue-drafts/README.md) und den
[lokalen Validierungsbericht](docs/lh00-validation.md) lesen. Neue und geänderte
Projekt-Guidance verwendet DE zuerst/EN danach, ungefähr CEFR B2. Offene
Übersetzungen bestehender Fachtexte sind in der Zuordnung aufgeführt.

The table links the domain concept, binding issue/intake order, environment,
repository settings, shared agent guidance and statistics. For current authoring,
also read the [governance mapping](docs/intake-governance.md),
[issue-draft index](docs/issue-drafts/README.md) and
[local validation report](docs/lh00-validation.md). New or changed project guidance
uses German first and English second at about CEFR B2. Remaining translations
of existing domain documents are explicitly listed in the governance mapping.

## Barrierefreiheit (A11Y) / Accessibility

`Programmierung #include<everyone>` gilt als Leitspruch. Das Bedienkonzept
fordert Tastaturbedienung und textorientierte Nutzung mit Screenreadern und
Braille-Zeilen; WCAG 2.2 AA wird angewendet, soweit die Kriterien passen.
Die Laufzeitabnahme steht aus, da noch keine Implementierung existiert.
Dokumentation erklärt Status, Abhängigkeiten und nächste Aktionen vollständig
in Text, auch wenn Diagramme vorhanden sind.

Programmierung #include<everyone> is binding. The interaction concept requires
keyboard and text-oriented use with screen readers and Braille displays.
WCAG 2.2 AA applies where relevant. No implementation exists, so runtime
accessibility acceptance remains open. Documentation must explain status,
dependencies and the next action in text, including when diagrams are present.

## Für Azubis / For apprentices

Zum Einstieg zuerst das [Bedienkonzept](docs/Bedienkonzept.md), anschließend
den [Lastenheft-Plan](docs/Lastenheft-Plan.md) lesen. Das Lesen der Konzepte
setzt weder ein GitHub-Konto noch einen KI-Agenten voraus; konkrete
Lernaufträge bleiben gesondert festzulegen.
Ein installierbares Cmdlet gibt es noch nicht. Workflowbegriffe werden bei
erster Verwendung erklärt.

Start with the interaction concept and then the intake order. Reading these
documents requires neither a GitHub account nor an AI agent. No installable
cmdlet exists yet. Explain workflow terms on first use; separate learning tasks
still need an explicit definition.

## Lizenz / License

[MIT](LICENSE), entsprechend TinyCalc und TinyPl0. TuiVision dient als Vorbild
für Repository-Regeln und Intake-Struktur; eine technische Abhängigkeit ist
damit nicht beschlossen.

MIT, as with TinyCalc and TinyPl0. TuiVision is a reference for repository
rules and intake structure; no technical dependency has been selected.
