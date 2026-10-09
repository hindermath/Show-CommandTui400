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
