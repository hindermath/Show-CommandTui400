# Wiederherstellung / Recovery

T028 hat in eigener Kopie wirklich nur das Ziel geändert, bevor der Receipt
publiziert wurde. Beide Validatoren wiesen den Teilstand ab. Sämtliche Originalbytes
wurden wiederhergestellt; Dateiliste und alle Rohhashes entsprechen dem Ausgang.
Beide Receiptvalidatoren bestehen danach. Das Journal dokumentiert Applying →
RolledBack samt Teilschreibstand. Es wurde kein automatischer Restart ausgeführt;
eine spätere Wiederaufnahme benötigt einen separaten aktuellen Auftrag.

A controlled partial publication changed the target before its receipt. Both
validators rejected it. Complete rollback restored the original file list and
all raw hashes; both receipt validators then passed. Applying/rollback evidence
is preserved; no automatic restart or implied resume authority.

[Journal und echte Ausgaben / Journal and actual outputs](recovery-results.json).
