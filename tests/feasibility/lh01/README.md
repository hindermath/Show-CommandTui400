# LH-01 Produktprüfungen / Product tests

DE: Modell-/Lease-Verträge laufen als Testbibliothek im vorhandenen PowerShell-Prozess,
ohne Terminal.Gui-Initialisierung. Ein eigener Testframework-Download ist nicht nötig.
Der Sitzungsnachweis verwendet ausschließlich synthetische Daten. Ein separater
Runspace dient nur dem StopProcessing-Test; das Produkt erzeugt keinen Runspace.
PTY-Automation ist keine praktische Terminal- oder Hilfsmittelabnahme.

EN: Model/lease contracts run as a test library in the existing PowerShell process,
without GUI initialization or an additional test framework dependency. Session
proof uses synthetic data only. A separate runspace is test setup solely for
StopProcessing; the product creates none. PTY automation is not practical acceptance.

## DE — Regressionen nach dem PR-Review

`python3 tests/feasibility/lh01/proof-tooling-contract.py` prüft vier Gruppen:
alle Fragmentgrenzen der drei Terminalabfragen, getrennte Deskriptoren ohne
doppelte Antwort sowie Schreibsperren bei abweichender Groß-/Kleinschreibung
für Build- und Nachweispfade. OrdinalIgnoreCase sperrt konservativ auch auf
case-sensitiven Volumes; neue Verzeichnisse dürfen nicht im Checkout entstehen.
Der Vertragsbuild verwendet ausdrücklich die versionierte NuGet.Config über
RestoreConfigFile, einschließlich des Testprojekts, statt geerbter Paketquellen.

## EN — Regressions after PR review

The command above checks four groups: every split point of all three terminal
queries, separate descriptors with no duplicate replies, and case-varied build
and evidence path rejection before writes. OrdinalIgnoreCase conservatively
rejects these paths on case-sensitive volumes too. The contract build explicitly
uses the versioned NuGet.Config through RestoreConfigFile for both projects.

## DE — Produkt-Tastaturfälle bis T044

Der B01-Vertragsbuild umfasst jetzt zusätzlich ActionContractTests und
KeyBindingTests. `pty-product.py` ergänzt BindingConflict, Keyboard, Remap und
FunctionExit; Voraussetzungen und neue isolierte Ausgabe bleiben wie oben.
BindingConflict prüft den öffentlichen Cmdletfehler vor Lease/UI. Keyboard
verlangt alle27 gesendeten Eingaben einschließlich eines unbekannten Zeichens,
26 wirksame Beobachtungen mit exakten Aktionen/Kontexten/Fokus/Verfügbarkeit sowie
Enter auf allen3lokalen Knöpfen. Remap prüft Help F1→F2 und Refresh F5→F6;
FunctionExit prüft F3. Alte Primärtasten dürfen keine Wirkung behalten.
Die10bisherigen PTY-Szenarien bleiben Regression. RestorationFailure bleibt
absichtlich Fail/Exit1 mit diagnosticContractSatisfied=true. Diese Fälle sind
synthetische Mac-A-Produktbelege, keine fremde Plattform- oder praktische Abnahme.
Sie ändern keine Prepared-Hand-off-Kommandobindung.

## EN — Product keyboard cases through T044

B01 adds ActionContractTests and KeyBindingTests. The PTY runner adds
BindingConflict, Keyboard, Remap and FunctionExit, retaining isolated outputs.
The conflict case exercises public rejection before lease/UI. Keyboard requires
all27 injected inputs, including one unknown character,26 exact observations of
action/context/framework focus/availability, and Enter on all three local controls.
Remap proves Help F1→F2 and Refresh F5→F6 without old-key effects; FunctionExit
proves F3. The previous ten scenarios remain regression. RestorationFailure stays
Fail/exit1 with its diagnostic contract satisfied. These are synthetic Mac A
product proofs, not foreign-host or practical acceptance. Prepared command
bindings remain unchanged.
