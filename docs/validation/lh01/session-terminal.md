# LH-01 Sitzung und Terminal: Mac A / Session and terminal: Mac A

## DE — Auftrag und Ergebnis

Thorsten beauftragte T018–T036 auf **Mac A, MacBook Air M2 2023**, mit
MergeAndSync/Admin-Bypass. Ergebnis: begrenzter Produktkern vorhanden;
**keine vollständige Feature-, Plattform- oder Hilfsmittelabnahme**.
Aktuelle technische Grundlage: [Quell-/Nachweismanifest](session-increment-maca/manifest.json),
[anderes Review](session-increment-review.md), [Benutzeranleitung](../../lh01/session-and-terminal.md).
T037–T063 bleiben offen. LH-01 bleibt Einzelpilot, LH-00 offen; volle
LH-00-Prozessabnahme nach LH-02, vor LH-03. Keine reale Serienaktivierung.

Locked Build: C#14/net10.0, Terminal.Gui exakt2.5.0, öffentlicher NuGet-Feed,
keine Host-SMA-Kopie; 0 Compilerwarnungen. 20 Modell-/Lifecycle-Prüfungen bestanden:
14 negative Entryvarianten plus sechs Lifecycle-/native-Double-Prüfgruppen.
Sie wurden vor positiven Produktstarts eingeführt und ausgeführt. Die ersten
Builds belegten fehlende Schutzklassen; weitere Build-/Harnessfehler wurden
korrigiert, bevor die folgenden finalen Resultate erzeugt wurden.
NuGet-Audit meldete zum Laufzeitpunkt keine bekannten anfälligen Pakete;
dies ersetzt weder native Lieferkettenbewertung noch spätere SBOM/Abnahme.

| Produktfall | Soll / Ergebnis | Nachweis |
|---|---|---|
| Normal | Alt+X, gleiche Sitzung, tatsächlicher Arbeitsort/Präferenz/Funktion erhalten; Restore erfüllt | [Normal](session-increment-maca/Normal.json) |
| HiddenCursor | Ursprünglich versteckter Cursor per mode25 wiederhergestellt | [HiddenCursor](session-increment-maca/HiddenCursor.json) |
| Cancel | Ctrl+C, sichere Rückkehr und Eingabe-Rundlauf | [Cancel](session-increment-maca/Cancel.json) |
| Repeat | Drei Starts in globalem/Funktions-/Modulkontext; exakt710/711/712 sichtbar; PID/Runspace erhalten | [Repeat](session-increment-maca/Repeat.json) |
| Stop | Tatsächliches StopProcessing, PipelineStopped; separater Runspace nur Testaufbau | [Stop](session-increment-maca/Stop.json) |
| HandledFailure | Injizierter Primärfehler erhalten, echter Restore erfolgreich | [HandledFailure](session-increment-maca/HandledFailure.json) |
| AggregateFailure | Primärer AggregateException bleibt HandledFailure bei erfolgreichem Restore | [AggregateFailure](session-increment-maca/AggregateFailure.json) |
| RestorationFailure | Beide injizierten Ursachen erhalten, **Fail/Exit1**; Diagnosevertrag erfüllt | [RestorationFailure](session-increment-maca/RestorationFailure.json) |
| Redirect / InputRedirect | stdout beziehungsweise stdin abweisen; null Lease-/UI-Aufrufe, keine Moduländerung | [stdout](session-increment-maca/Redirect.json), [stdin](session-increment-maca/InputRedirect.json) |

## DE — Aussagegrenzen und nächste Plattformstufe

E01-01 und E01-04 sind **begrenzt lokal** belegt, nicht insgesamt abgenommen.
Die Restoreinjektion erfolgt nach erfolgreichem wirklichem Restore; sie belegt
Fehlererhaltung, keinen tatsächlichen defekten Hostrestore. Externe Prozesskills,
Hostausfälle oder Stromverlust erlauben keine Wiederherstellungsgarantie.
Darwin-PENDIN wird ausschließlich als bereits unabhängig reproduzierter
Kernelzustand getrennt verglichen; rohe Vorher-/Nachherbytes bleiben erhalten.
Für Unix-Cursor verwendet die Lease XTSAVE/XTRESTORE für Modus25 gemäß
[Xterm-Kontrollsequenzen](https://invisible-island.net/xterm/ctlseqs/ctlseqs.html).
Die Tests emulieren diesen Vertrag für sichtbaren/versteckten Cursor. Reale
Terminalemulatoren sind weiterhin Deferred; kein allgemeines Terminal-PASS.

Build-/Modellprüfungen sind für die drei Zielhosts vorbereitet. Der gemeinsame
[Driver](../../../tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1) ist implementiert;
Schema, Pflichtkatalog/E01, Freigabe, Commit/Hashes, Host, Pfade und fehlende
Kommandos werden vor Ausführung geprüft. Sieben negative Prüfplanfälle bestehen.
CheckOnly schreibt nichts. Timeout nach120Sekunden stoppt den Prozessbaum und
weitere Fälle; nach externem Kill wird Restore ausdrücklich nicht garantiert.
S07 erhält ein eigenes Diagnoseverzeichnis und bleibt Fail, getrennt vom Mainstatus.

**Noch kein ausführbarer Prüfstand für alle drei Systeme:** Das bestehende
Manifest bleibt Prepared; Produktcommit/Kommandos/Zielauftrag sind noch nicht
freigegeben. Unix-PTY-Harness ist vorhanden; Windows-ConPTY-/Terminal-Testadapter
fehlt. Kein Testagent darf fehlende Fälle eigenmächtig deaktivieren. T053/T054
binden später den gemeinsamen Stand; ein früher begrenzter Build-/Vertragslauf
braucht einen ausdrücklich genehmigten Teilprüfplan. Der Owner erhält dann den
Hinweis mit exaktem Commit und den drei Hand-offs #37/#38/#39.

Security-Baseline ist ein historischer Entwurfsnachweis. Ein vollständiger
Assurance-Kontext bleibt ohne Closure/Image-Impact offen; fehlende spätere
Nachweise werden nicht als bestanden dargestellt. Das neue Delta führt den
Inkrementstand und verbleibende T052–T059-Arbeit getrennt.

## EN — Bounded outcome and evidence

The owner commissioned T018–T036 on Mac A, a MacBook Air M2 2023, with
MergeAndSync/admin bypass. The product core now exists, with no complete feature,
platform, assistive or owner acceptance. T037–T063 remain open. Preserve the
standalone pilot, open LH-00 and full LH-00 acceptance after LH-02/before LH-03.

The locked C#14/net10.0 build pins Terminal.Gui2.5.0, excludes host SMA and has
zero compiler warnings. Twenty model/lifecycle checks passed, introduced before
positive product entry. Earlier missing-code/build/harness errors were corrected
before the linked final records. The package audit found no known vulnerable
packages at execution time; this is not native supply-chain or SBOM acceptance.

The ten linked synthetic PTY scenarios prove normal return, hidden/visible cursor
mode25, Ctrl+C, repeated global/function/module context (710/711/712), real
StopProcessing, handled/aggregate primary failures and both redirect boundaries.
The separate restoration injection retains both errors and remains **Fail/exit1**,
with its diagnostic contract satisfied; actual native restoration succeeded first.
Process, runspace, real location, preference and synthetic function are preserved.
Test-only seams exist in the friend test assembly, never as public cmdlet modes.

E01-01/E01-04 have bounded Mac A evidence only. Raw native bytes retain the
independently reproduced PENDIN boundary. Unix cursor save/restore follows the
linked Xterm mode25 protocol; its emulation is not practical terminal acceptance.
External kill/host/power failure is outside guaranteed restoration.

Build/model entry points and a guarded shared driver are available. Seven negative
plan cases pass; CheckOnly writes nothing, missing prerequisites stay Blocked.
The120-second timeout stops the process tree and further cases, retaining external
kill limitations. S07 has a separate diagnostic result and never becomes Pass.
**The three-host test stand is not yet executable:** its manifest remains Prepared,
without approved exact revision/commands/target orders, and Windows terminal test
adaptation is absent. A coordinator-approved partial build/contract plan could run
earlier; the agent may not reduce scope. T053/T054 bind the later common stand.
The owner will receive its exact commit and linked hand-offs when ready.

The old security baseline proves design integrity only. Full Assurance remains
open without closure/image-impact. The increment delta preserves later T052–T059
work without turning missing evidence into Pass. No series or later feature starts.
