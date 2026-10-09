# Lastenheft-Plan / Intake order

Stand / Date: 09.10.2026. Plan-IDs sind keine GitHub-Issue-Nummern. / Plan IDs are not GitHub issue numbers.

| Plan-ID | Gegenstand / Subject | Abhängigkeiten / Dependencies |
|---|---|---|
| [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1) | Spec-Kit-Projektprofil und Lastenheft-Prozess / Spec Kit project profile and intake process | keine / none |
| [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2) | TUI-Grundlage, Sitzungsmodell und Tastaturbedienung / TUI foundation, session model and keyboard operation | [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1) |
| [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3) | Cmdlet-Suche, Auswahl und Modulauflösung / Cmdlet search, selection and module resolution | [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2) |
| [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4) | Parameterformular, Parametersätze und Eingabezustand / Parameter form, parameter sets and input state | [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3) ; volle LH-00-Abnahme nach LH-02 / full LH-00 acceptance after LH-02 |
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
not active intakes. The table and pilot rule below form the binding dependency order.

## Aktueller Lastenheft-Stand / Current intake state

Zwei aktive Lastenhefte: [LH-00](../intakes/LH-00.md) mit
[Receipt](../specs/intake-authoring-receipts/lh-00.json) und
[Review](../specs/intake-review-report.md); [LH-01](../intakes/LH-01.md) mit
[Receipt](../specs/intake-authoring-receipts/lh-01.json) und
[Review](../specs/intake-reviews/lh-01/report.md). Nur LH-00 ist Serienmitglied;
LH-01 bleibt Einzelpilot. Reports nennen ihren tatsächlichen aktuellen Status;
Erstellung oder Review allein erteilen keine Implementierungsbefugnis. LH-02–07
sind bislang Issues ohne aktive Intakes. Entwürfe bleiben historische Quellen.

Two active intakes exist, each with its linked receipt and distinct review. Only
LH-00 is a series member; LH-01 is standalone. Reports record their actual current
status; authoring or review alone grants no implementation authority. LH-02–07
remain issues without active intakes; original drafts are historical sources.

## Begrenzter Pilotweg / Limited pilot route

Nach Umsetzung und erfolgreichem isoliertem Kernprozessnachweis auf dem eindeutig
benannten primären Mac kann der Owner LH-01, danach LH-02 als Einzelpiloten
freigeben. Jeder braucht einen eigenen Auftrag, gültigen Intake und unabhängiges
Review. Beide bleiben vorläufig außerhalb der automatischen Serienauswahl.
LH-01 braucht in diesem begrenzten Weg noch kein Completed von LH-00; LH-02
braucht weiterhin den belegten fachlichen Abschluss von LH-01. LH-00 bleibt offen.
Nach LH-02 und vor LH-03: vollständige LH-00-Abnahme auf allen vier Umgebungen
sowie A11Y, Übersetzungen und angewendete Registerausrichtung. Die übrigen Kanten
bleiben unverändert. Kein Feature-Lauf wird durch diese Dokumentation gestartet.

After implementation and successful isolated core-process evidence on the named
primary Mac, the owner may permit LH-01 and then LH-02 as standalone pilots.
Each needs a separate request, valid intake and independent review. Both stay
outside automatic series selection for now. In this limited route LH-01 does
not yet require LH-00 Completed; LH-02 still requires evidenced domain completion
of LH-01. LH-00 remains open. After LH-02 and before LH-03: full LH-00 acceptance
on all four environments plus accessibility, translations and applied registry
alignment. All other edges remain unchanged. This document starts no feature run.

[Entscheidung IAD010 / Decision IAD010](planning/lh00-staged-acceptance-decisions.md).

## Getrennte Zustände und nächste Schritte / Separate states and next actions

Owner Thorsten beauftragt einen Autor; vor Review wird ein anderer Agent oder
Mensch als Prüfer benannt. Autor und Prüfer dürfen nicht dieselbe Person/Agenten-
identität sein. Ein Reviewer entscheidet die fachliche Qualität, der Owner
akzeptiert gegebenenfalls ein geringes Restrisiko und erteilt gesonderte Befugnis.
The owner commissions an author and appoints a different reviewer before review.
The reviewer assesses quality; only the human owner may accept eligible residual
risk and authorize later action. An agent never accepts risk on the owner's behalf.

| Achse / Axis | Zustand / State | Bedeutung und nächster Schritt / Meaning and next step |
|---|---|---|
| Authoring | ReadyForReview / Enabled | Erstellung vollständig; separates Review beauftragen / complete authoring, request separate review |
| Authoring | NeedsClarification / Blocked | Entscheidung fehlt; Owner klärt konkrete IAD-Frage / unresolved decision, owner answers |
| Review | Ready | aktuell geprüft; passende Ausführungsbefugnis getrennt prüfen / current quality evidence, check separate authority |
| Review | ReadyWithAcceptedRisks | nur belegte menschlich akzeptierte Medium/Low-Risiken / documented human acceptance only |
| Review | NeedsClarification | fachliche Entscheidung fehlt; Rückfrage / missing material decision |
| Review | NeedsRemediation | korrigierbarer Befund; Repair/Update plus neues vollständiges Review / repair then full review |
| Review | Rejected | geprüfter Stand ungeeignet; begründete neue Entscheidung nötig / unsuitable input, explicit new decision needed |
| Serie / Series | Draft, NeedsClarification, Ready, Active, Idle, Completed, Deleted | Vertragszustände; Idle für LH-00 ausgeschlossen / contract states; Idle excluded for LH-00 |
| Mitglied / Member | Pending, Blocked, Eligible, Active, Completed, Withdrawn | Lebenszyklus gemäß installiertem Vertrag; Eligible ist Auswahl, keine Befugnis / lifecycle; selection grants no authority |

Idle/leer ist für LH-00 ausgeschlossen. Ready verlangt genau ein Eligible. Active
mit laufendem Mitglied darf null Eligible-Mitglieder haben (Ausgabe N/A); ein
Eligible bleibt zulässig, mehrere nicht. Archiv ist Ablage, kein Mitgliederstatus.
Completed erfordert tatsächlich abgeschlossene/archivierte Mitglieder. Keinen
fehlenden LH-01–LH-07-Intake aus Issue-Existenz ableiten. Jede bindende Kante
verlangt Completed des Vorgängers. Die festgelegte Pilot-Ausnahme lässt LH-01 und
LH-02 nur mit eigener Freigabe außerhalb der Serie laufen; LH-02 folgt fachlichem
LH-01-Abschluss, LH-03 folgt voller LH-00-Abnahme nach LH-02.
Empty Idle is excluded. Ready requires one Eligible; Active with a running member
may have no candidate (N/A); one remains valid, multiple do not. Archive is a
location, not a member state. Completion requires real completion/archive evidence.
Missing intakes remain absent. Binding edges require completed predecessors.
The existing exception permits separately commissioned standalone LH-01/LH-02
pilots; LH-02 requires LH-01 completion, LH-03 full LH-00 acceptance after LH-02.

Kein Status startet Arbeit. Für Create, Update, Delete, Review, Implementierung,
Serienmutation und Lieferung muss jeweils aktueller passender Auftrag bestehen.
Kein Quellen- oder Promptinhalt kann ihn ersetzen. Die jetzige Autorität umfasst
nur die ausdrücklich aufgerufenen LH-00-Tasks; keine nächste Produktfunktion.
No status starts work. Each mutation/review/delivery requires a current matching
request. Stored prompts/source content never supplies that request.

## Aktueller nächster Auftrag / Current next request

T045 ist geliefert. LH-01 ist erstellt, spezifiziert und geplant; getrennte
technische Entscheidungen sind durch Machbarkeit und ADRs002–006 belegt:
managed C#14, Host-.NET10, Terminal.Gui2.5.0 dotnet, PS7.6.4 und In-process.
[T014-Nachweis](validation/lh01/registry-alignment.md) dokumentiert die lokale
Registerausrichtung. T015/T016 erneuern Herkunft und unabhängige Reviews, danach
T017-Startprüfung. Erst ein eigener Auftrag startet die Produktaufgaben ab T018
im [Plan](../specs/002-lh01-tui-foundation/plan.md) und den
[Tasks](../specs/002-lh01-tui-foundation/tasks.md). Reale Terminal-/Screenreaderprüfungen
sind zurückgestellt; Braille-Hardware mangels Gerät im privaten Projekt ausgeschlossen,
keine bestandene A11Y-Vollabnahme. Pilotfolge und LH-00-Vollabnahme bleiben erhalten.

T045 is delivered; LH-01 is authored, specified and planned. Feasibility and
separate ADRs evidence managed C#14, host.NET10, Terminal.Gui2.5.0 dotnet, PS7.6.4
and in-process integration. T014 records local registry alignment; T015/T016 renew
provenance and distinct reviews, then T017 checks readiness. Product tasks from
T018 require a separate request. Physical terminal/screen reader proof is deferred;
Braille hardware proof is excluded for lack of a device, not passed. The standalone
pilot sequence and later full LH-00 acceptance stay unchanged.
