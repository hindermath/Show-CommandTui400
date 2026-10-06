# Herkunft: Negativprüfungen / Negative provenance checks

T025 wurde vor T024 ausgeführt. Acht mutierte Einzelkopien wurden von beiden
installierten Receipt-Validatoren mit Exit 2 abgewiesen: Quell-/Zieldrift,
Pfadausbruch, Symlink außerhalb der Wurzel, ungültiges UTF-8, URL-Größe über
2 MiB, binäre Erweiterung und URL-Benutzerkennung. Alle Dateihashes vor/nach
Validierung sind identisch; Validatoren schreiben nicht. Create auf vorhandenem
Ziel wurde anhand des installierten Skill-Guards verweigert, ohne CLI zu erfinden.
URL-Metadaten sind bewusst ungültige synthetische Eingaben; kein Abruf fand statt.

T025 preceded T024. Both installed validators rejected eight separate tampered
copies with exit 2. Complete before/after hashes prove zero validator writes.
The existing-target Create skill guard refused mutation. URL inputs are synthetic
invalid metadata; no network retrieval or new validator implementation is claimed.

Details und tatsächliche Ausgaben / actual outputs: [JSON](provenance-negative-results.json).
