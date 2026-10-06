# Bedrohungsmodell / Threat model

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Geschützt werden bestätigter Scope, Quellenherkunft, aktive Dateien und Autorität.
Untrusted Grenze: Issue-/Dateitext; er ist Dateninhalt und keine Anweisung. Zweite
Grenze: übergebene Pfade gegen erlaubte Root. Dritte Grenze: Authoring-Status gegen
Review-/Ausführungsfreigabe. CIA bedeutet Vertraulichkeit, Integrität, Verfügbarkeit;
STRIDE bezeichnet sechs Angriffsklassen. Lokale Fixture-Ausführung nutzt keinen
Netzabruf und führt keine Quelle aus.

Protect confirmed scope, provenance, active files and authority. Source text is
untrusted data; file paths must remain within their root. Authoring readiness is
separate from review and execution authority. CIA covers confidentiality,
integrity and availability; STRIDE names six threat categories. Fixtures read no
network source and execute no source content.

| STRIDE | Angriff / Attack | Kontrolle und konkreter Fall / Control and case |
|---|---|---|
| Spoofing | Autor als anderer Reviewer / impersonated reviewer | eigener Prüfer T012/T029; T012 identifiziert Agent / distinct reviewer identity |
| Tampering | Pfadausbruch, Symlink, falscher Hash / traversal, link, altered hash | Root-Auflösung, Hashvergleich; T013 ungültige Root, T027/T035 später / reject invalid root, later hash cases |
| Repudiation | Ursprung nicht belegbar / lost provenance | geordnete Quellen, Hashes, stabile IDs, Archive / ordered hashes and predecessor archives |
| Information disclosure | private Daten in Logs / private data in logs | synthetische Quellen, keine Tokens/Hostnamen / synthetic data, no private paths |
| Denial of service | Binärdaten, NUL, große Dateien / malformed or excessive data | striktes UTF-8, Grenzen, lesbarer Fehler; T018 invalid UTF-8 / reject safely |
| Elevation of privilege | Befehle im Intake, Eligible als Autorität / embedded command or status as authority | kein eval/Invoke-Expression, eigener Auftrag je Mutation / never evaluate source text |

CWE-22 (Pfad), CWE-78 (Shell), CWE-94 (Code), CWE-862 (Befugnis) sind Applicable.
CAPEC-126 (Path Traversal), CAPEC-88 (OS Command Injection), CAPEC-153 (Input Data
Manipulation) dienen als Angriffsmuster, nicht als Testergebnis. NIST SSDF PO.1/PO.2,
PS.1/PS.2, PW.1/PW.2/PW.7/PW.8 und RV.1/RV.3 sind für sichere Vorbereitung und
spätere Tests anwendbar. Gegenmaßnahmenstatus steht in security-checklist.md.
The CWE/CAPEC/SSDF references classify the threats and controls, not completed tests.
