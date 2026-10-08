# LH-01 Machbarkeits-Prüfanleitung / Feasibility validation guide

**Aktueller Stand / Current state:** Isolierte Läufe sind dokumentiert in
[Machbarkeitsergebnissen](feasibility/README.md); technische Auswahl entschieden, praktische Abnahme offen. / Isolated runs
and choices are recorded; practical acceptance remains open.

**Historischer Anleitungsstand vor dem Machbarkeitsauftrag / Historical guide before
commissioned feasibility:** zukünftige Ausführung, kein ausgeführter Prototyp /
future validation, not an executed prototype. Diese Anleitung startet nichts. Ein eigener beauftragter
Machbarkeits-/Umsetzungsauftrag muss Scope und Schreibgrenzen enthalten. Kein
Produktstart solange F01–07 oder OD-01-001/002 offen sind.

This guide executes nothing. A separately commissioned feasibility/implementation
request must define scope/write boundaries. Product code waits for F01–07 and the ODs.

## Voraussetzungen / Prerequisites

Aktueller Receipt/anderes Review, Spec/Plan, synthetische lokale Fixtures; bekannte
Host-/Terminal-/Hilfsmittelversionen und isolierte Ausgabe. Kandidatenbaseline aus
research D01–03; kein Laden einer neuen Runtime in den Host. Späterer Proof-Quellcode
und Pfade entstehen erst im Machbarkeitsinkrement, daher heute keine lauffähige
Produkt- oder Testkommandosammlung vortäuschen.

Require current provenance/review, spec/plan, synthetic local fixtures and named
host/terminal/assistive versions. Candidate baseline comes from research. Proof code
is not present yet; do not pretend that product/test commands already exist.

Heute ausführbare lesende Vorprüfung / Runnable read-only precheck today:

```bash
bash .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.sh --receipt specs/intake-authoring-receipts/lh-01.json --repo .
bash .specify/presets/intake-review-governance/scripts/validate-intake-review-result.sh --result specs/intake-reviews/lh-01/result.json --repo .
dotnet --list-sdks
```

```powershell
$PSVersionTable.PSVersion
[System.Runtime.InteropServices.RuntimeInformation]::FrameworkDescription
[Console]::IsInputRedirected
[Console]::IsOutputRedirected
```

## Prüffolge / Test order

| Fall / Case | Durchführung und erwartetes Ergebnis / Procedure and expectation | AC/E01 |
|---|---|---|
| F01 Negativ / negative | Umgeleitete Streams, fehlende Fähigkeiten, unbekannte Aktionen, synthetische Steuerzeichen zuerst; keine Terminaländerung, Code-/Import-/Netzwirkung / negative inputs first, zero unintended effects | AC-01-001/003; E01-06 |
| F02 Session | Prozess/Runspace, synthetische Variable/Funktion/Arbeitsort/Präferenzen global, Funktion und Modul vor/nach vergleichen; wiederholtes Öffnen, klare Scopegrenzen / compare contexts and repeated entry | AC-01-002/003; E01-01 |
| F03 Aktionen / actions | Jede definierte Taste/Alternative, gültiger und ungültiger Kontext, remap-Konflikt, Root-Zurück prüfen; Hilfe/Beenden erreichbar und keine Zielausführung / every action/context, reachable escape paths | AC-01-001/002; E01-02 |
| F04 Restore | Modi/Cursor vor Start aufzeichnen; reguläres Ende, Ctrl+C/StopProcessing, behandelbarer Fehler; danach Shell bedienbar / normal/cancel/error restore shell | AC-01-002/003; E01-04 |
| F05 Resize | Mit lokalen Werten/Fokus verkleinern/vergrößern; keine Werteverluste, bei kleiner Größe Erklärung und sichere Rückkehr / resize without state loss | AC-01-002/004; E01-05 |
| F06 A11Y | Tastatur allein, benannter Screenreader, Braillehardware/Treiber, Hilfe/Legende/Fokus/Busy/Fehler ohne Farbbedeutung; Spec-WCAG-Matrix prüfen / actual named assistive access | AC-01-004; E01-03/05 |
| F07 Designreview | Sprache/MSL, Runtime, Framework, Minimum, Session/Terminal getrennt mit F01–06-Ergebnissen/Alternativen begründen; Dependency/native Review, anderes Review, DE/EN/IDs | AC-01-003/005; E01-06/07 |

Mac A zuerst (MacBook Air M2 2023), danach Mac B, Windows11 nativ und Ubuntu24.04/
WSL2. Exakte Terminalnamen erst im Proof-Matrixentscheid; Windows Terminal enthalten.
Native CI kann Build-/Vertragstests belegen, keine interaktive Screenreader-/Braille-
Abnahme. Fehlender Host/Hilfsmittel bleibt Open und wird nicht durch CI ersetzt.

Mac A first, then Mac B, native Windows11 and Ubuntu24.04/WSL2, including Windows
Terminal. Choose exact terminal combinations in proof planning. CI proves only
executed build/contract tests, never interactive assistive acceptance.

Je Lauf Commit oder vor Commit Quellpayload-Hash, Entscheidungs-Hash, Kommandos,
OS/Host/Terminal/Runtime/Framework, Prüfer, Erwartung/Beobachtung, Exitcode und
Schreibgrenzen dokumentieren. Ein nicht committierter Payload darf nicht als
Commitnachweis bezeichnet werden. Keine Secrets/privaten Variablenwerte.
Bei Fehler Ursache dokumentieren, Entwurf revidieren und betroffene Fälle wiederholen.
Erst nach F07 endgültige OD-ADRs; keine automatische Pilot-/Serien-/Ownerabnahme.

Bind exact commit or honest uncommitted payload hash, decision hash, commands,
versions, reviewer, expectations/results, exit code and allowed writes. Never label
an uncommitted payload as committed proof. Failures require design revision and
focused rerun. Close ODs after F07 without automatic series/owner acceptance.

## Ausführbarer isolierter Prüfaufbau / Runnable isolated setup

Nur im beauftragten Machbarkeitsumfang ausführen. Outputs/Paketrestore sind lokale
Testartefakte; kein Produktlauf. NuGet.Config begrenzt auf den öffentlichen Feed.
Das Host-SMA-DLL wird nicht mitverteilt. / Run only within commissioned feasibility;
restore/output are local proof artefacts, not a product run. No host runtime copy.

```bash
export LH01PowerShellHome="$(pwsh -NoProfile -Command '$PSHOME')"
export LH01BuildRoot=/tmp/lh01-proof-build
dotnet restore specs/002-lh01-tui-foundation/feasibility/src/Lh01Fixture.csproj --locked-mode --configfile specs/002-lh01-tui-foundation/feasibility/src/NuGet.Config
dotnet build specs/002-lh01-tui-foundation/feasibility/src/Lh01Fixture.csproj --no-restore
pwsh -NoProfile -File specs/002-lh01-tui-foundation/feasibility/src/probe-session.ps1 -Assembly /tmp/lh01-proof-build/bin/net10.0/Lh01Fixture.dll -Mode Scope
python3 specs/002-lh01-tui-foundation/feasibility/src/pty-probe.py control
python3 specs/002-lh01-tui-foundation/feasibility/src/pty-probe.py normal
```

Weitere PTY-Modi: error, cancel, resize, small-exit. Der Python-Treiber ist auf den
lokalen macOS/Linux-PTY-Prüfaufbau begrenzt; PowerShell-/Windows-UI-Kompatibilität
folgt daraus nicht. Er überschreibt jeweils die lokale Fall-Evidence; gebundene
Reviewnachweise danach gezielt erneuern. / Further modes are listed above; the PTY
runner is a local Unix test surface, not Windows proof. Reruns replace case evidence
and require affected review/hash refresh.

## Aktuelle Prüfergänzung / Current test extension

Modi zusätzlich: matrix, remap, repeat, stop, invalid, invalid-remap, out-redirect.
Nach den13 PTY-Fällen prüft `feasibility/src/assess-evidence.py` die tatsächlich
beobachteten Verträge. Umgeleiteter Output und ungültiges Remap erwarten Exit3
und passenden Fehler, nicht Exit0. Der Fehlertest erwartet seinen Testfehler.
`termios-abi.c` ist nur eine native SDK-Kontrolle, kein C-Produktsprachentscheid.
Reale Terminal-/Screenreadertests sind jetzt zurückgestellt; Braillehardware-
Nachweis ist begründet ausgeschlossen, siehe
[Ownergrenzen](feasibility/owner-validation-boundaries.md). Rohe Terminalgleichheit
und konfigurierbare Modi sind getrennt; ausschließlich PENDIN wird begründet
ausgenommen. Shell-Rückgabe und übrige Felder bleiben strikt geprüft.

Additional modes/evaluator cover actual contracts, with expected error codes for
negative/injected cases. Native C checks validate ABI, not product language. Owner
limits defer/exclude practical proof; only reproduced PENDIN is separately treated.
