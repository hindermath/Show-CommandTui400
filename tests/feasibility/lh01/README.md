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
