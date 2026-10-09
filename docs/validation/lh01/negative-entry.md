# Negative Startverträge / Negative entry contracts

DE: Mac A, 2026-10-09, SDK 10.0.401 / PS 7.6.6. Vor der Implementierung
fehlten die Schutzklassen: Build scheiterte mit CS0234. Danach bestanden die
14 Negativprüfungen N01–N07 einschließlich Host-/ABI-/Syntax-/Escapevarianten.
Der reine EntryGuard besitzt keine Terminal-, Netzwerk-, Import- oder
Zieladapter; abgewiesene Konfigurationen erreichen keinen UI-/Lease-Aufruf.
Tests prüfen ausschließlich synthetische Capability-Werte, keine privaten Daten.
Reale Redirect-Ablehnung des Cmdlets wird zusätzlich im Sitzungsnachweis geprüft.

EN: On Mac A, the pre-implementation test build failed with CS0234. After guard
implementation, fourteen negative checks passed. The pure guard has no terminal,
network, import or domain adapter and rejection prevents UI/lease entry.
Capabilities are synthetic; actual cmdlet redirect rejection is additionally
checked by the session proof. This is not proof for other operating systems.

DE: Beide echten Redirectfälle erreichen null Lease-/UI-Aufrufe und ändern keine geladenen Module; Belege im [Sitzungsnachweis](session-terminal.md). / EN: Both actual redirect cases reach zero lease/UI calls and preserve module membership; see the linked session proof.
