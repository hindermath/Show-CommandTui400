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

## LH-01 — zusätzliche Grenzen / Additional boundaries

Assets: Sitzungsidentität, private Kontextdaten, Terminalmodi/Cursor, lokale Werte,
Scope/Autorität und Softwareherkunft. Grenzen: fremder Text/Remap → Guard/Modell;
Modell → Framework; Framework → OS/Runtime; Prüfplan → autorisierte lokale Ausgabe.

| STRIDE / CIA | Fall / Case | Geplanter Schutz / Planned control | Nachweis / Evidence |
|---|---|---|---|
| Spoofing / I | Falscher Host oder Reviewer / wrong host/reviewer | Capability/Version plus anderer Prüfer / guard and distinct review | N01–04/PF01 |
| Tampering / I | Steuerzeichen/Remap/Manifest geändert / altered data | SafeDisplay, Schema/Hash, Rootkontrolle / sanitize and bind | N06/07/PF01 |
| Repudiation / I | Ungebundener Lauf / unbound run | UUID, Commit/Hash, Soll/Ist/Exits / attributable record | EV01/E01-07 |
| Disclosure / C | Private Variablen/Logs / private data | Synthetische Daten, kein Dump/Persistieren / minimize | E01-06/T009 |
| DoS / A | Kleine Oberfläche, Abbruch, Restorefehler / interruption | Safe exit, Dispose/Restore, Fehler erhalten / safe stop | V02/S03–S07 |
| Elevation / I | Unverfügbare Aktion oder Testtext ausgeführt / executed data | Whitelist UND Kontext, kein Targetexecutor/Eval / separate checks | N05/K01 |

CWE-20/78/94/862/22 und CAPEC-88/153/126 beschreiben Eingabe-, Code-, Befugnis-
und Pfadangriffe, keine bestandenen Tests. NIST SSDF PO/PS/PW/RV bleiben Applicable.
Konkrete Schutzschichten: Aktion muss bekannt UND im aktuellen Kontext zulässig
sein. Entfernt ein Test eine Schicht, muss die andere ihren Vertrag separat zeigen.
Datenentkräftung ist zusätzlich, kein Ersatz für Befugnisprüfung.

Session/terminal state, privacy, local values and provenance are protected across
data/guard, model/framework, framework/native and manifest/output boundaries.
The table maps all STRIDE classes to controls and future E01 cases. Allow-list
and context validation are independent; tests demonstrate each layer. Safe display
never substitutes for authority. These are design checks; product tests remain open.
Owner Thorsten, reassess before product code and on input/interop/scope changes.

### LH-01 Restrisiken je Kategorie / Residual risks by category

| Kategorie | Verbleibendes Risiko / Residual risk | Owner, Aktion und Trigger / Action and trigger |
|---|---|---|
| Spoofing | Nicht belegte native Hosts / unproven hosts | Thorsten; T032/T054 vor Host-PASS / before host pass |
| Tampering | Produktguard noch nicht implementiert / guard absent | Thorsten; T021–T026 negative Tests vor gültigem Start / negatives before entry |
| Repudiation | Produktnachweise/Driver fehlen / product proof absent | Thorsten; T029/T053/T054 bindet Stand vor Übergabe / bind before hand-off |
| Disclosure | Spätere private Sitzungsdaten könnten geloggt werden / accidental private logging | Thorsten; T009/T058 Datenfluss/Logger vor Produktlauf prüfen / review before product run |
| DoS | Native Restore-/Killgrenzen / restoration and kill limits | Thorsten; T028/T035/S07 gesondert Fail; vor unterstütztem OS-PASS / before OS pass |
| Elevation | Dispatcher/Adapter noch nicht vorhanden / dispatcher absent | Thorsten; T037/T043 beide Schichten getrennt prüfen vor Integration / review before integration |

Keine Risikoannahme durch den Agenten. Grenzen sind offen bis passend geprüft,
keine Startfreigabe für unerfüllte Produktverträge. / No agent risk acceptance.
Future product controls stay open until verified, without bypassing readiness.
