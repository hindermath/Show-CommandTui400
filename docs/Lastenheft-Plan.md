# Lastenheft-Plan / Intake order

Stand / Date: 28.09.2026. Plan-IDs sind keine GitHub-Issue-Nummern. / Plan IDs are not GitHub issue numbers.

| Plan-ID | Gegenstand / Subject | Abhängigkeiten / Dependencies |
|---|---|---|
| [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1) | Spec-Kit-Projektprofil und Lastenheft-Prozess / Spec Kit project profile and intake process | keine / none |
| [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2) | TUI-Grundlage, Sitzungsmodell und Tastaturbedienung / TUI foundation, session model and keyboard operation | [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1) |
| [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3) | Cmdlet-Suche, Auswahl und Modulauflösung / Cmdlet search, selection and module resolution | [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2) |
| [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4) | Parameterformular, Parametersätze und Eingabezustand / Parameter form, parameter sets and input state | [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3) |
| [LH-04](https://github.com/hindermath/Show-CommandTui400/issues/5) | Wertehilfe, Variablen, Completion und Validierung / Value assistance, variables, completion and validation | [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4) |
| [LH-05](https://github.com/hindermath/Show-CommandTui400/issues/6) | Aufrufvorschau, Befehlszeilenübernahme und Ausführung / Invocation preview, command-line transfer and execution | [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4), [LH-04](https://github.com/hindermath/Show-CommandTui400/issues/5) |
| [LH-06](https://github.com/hindermath/Show-CommandTui400/issues/7) | Stream Deck XL und Logitech MX Keypad: Tastenprofile / Stream Deck XL and Logitech MX Keypad key profiles | [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2), [LH-05](https://github.com/hindermath/Show-CommandTui400/issues/6) |
| [LH-07](https://github.com/hindermath/Show-CommandTui400/issues/8) | Optionale Geräteadapter mit Kontext und Sitzungsbindung / Optional device adapters with context and session binding | [LH-06](https://github.com/hindermath/Show-CommandTui400/issues/7) |

Zuerst [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1) für den Prozess bearbeiten. Danach Kernbedienung und Sitzung [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2), Suche [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3), Formular [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4), Wertehilfe [LH-04](https://github.com/hindermath/Show-CommandTui400/issues/5) und Abschluss [LH-05](https://github.com/hindermath/Show-CommandTui400/issues/6). Geräteprofile [LH-06](https://github.com/hindermath/Show-CommandTui400/issues/7) und dynamische Adapter [LH-07](https://github.com/hindermath/Show-CommandTui400/issues/8) sind nachgelagerte optionale Ausbaustufen.

Jedes Issue liefert Zweck, Anforderungen, Nicht-Ziele, Abnahmekriterien, offene Entscheidungen und einen Arbeitsauftrag. Die Issues sind angelegt. Das minimale lokale Authoring-Profil ist eingerichtet; die vollständige Prozessabnahme bleibt LH-00 zugeordnet. Issue-Entwürfe sind keine aktiven Lastenhefte.


Start with LH-00 for the process, then LH-01 for the session and core interaction,
LH-02 search, LH-03 form, LH-04 value assistance and LH-05 final invocation.
LH-06 device profiles and LH-07 dynamic adapters are optional later stages.
Each issue provides purpose, requirements, non-goals, acceptance, open decisions
and a drafting request. The issues exist; the minimal local authoring profile
is configured, but full process acceptance belongs to LH-00. Issue drafts are
not active intakes. The table above remains the sole binding dependency order.

## Lokaler Authoring-Stand / Local authoring state

Genau ein lokales Lastenheft: [LH-00](../intakes/LH-00.md), mit
[Receipt](../specs/intake-authoring-receipts/lh-00.json). Authoring-Status:
`ReadyForReview`; gesondertes Review noch nicht ausgeführt. Keine Serienfreigabe,
kein `Eligible`-Nachweis und keine Implementierungsfreigabe. LH-01 bis LH-07
liegen nur als [Issue-Entwürfe](issue-drafts/README.md) vor. Nächster fachlicher
Schritt: getrenntes Intake-Review von LH-00 nach ausdrücklichem Auftrag.

Exactly one local intake exists: LH-00, with the linked receipt. Authoring
status is ReadyForReview; separate review has not run. This is not series
approval, an Eligible result or implementation permission. LH-01 through LH-07
exist only as issue drafts. Next domain action: a separately requested intake
review of LH-00.
