# S-ADR LH-01 — Sitzung, Anzeige, Autorität / Session, display, authority

Datum / Date: 2026-10-09. Owner Thorsten. Status: Designentscheidung, Produktprüfung offen.

## DE — Entscheidung

Untrusted Text/Remap bleibt Daten. Whitelist und Kontext separat prüfen, fremde
Steuerzeichen entkräften, kein Eval/Import/Targetexecutor. Version/Capabilities
vor Schreib-Lease prüfen; aktuellen Host nutzen statt Ersatzsitzung. Snapshot und
OS-spezifische Lease restaurieren nach Dispose; beide Fehler bei Doppelversagen
erhalten und Fail melden. Keine privaten Kontextdumps, persistierten Werte oder
Netzdienste. Native Assets sind kein allgemeiner MSL-Nachweis.

Alternativen: Shelltexte ausführen oder separate Sitzung kopieren verletzt Scope
und Befugnisgrenze; ANSI-Fallback verletzt die geprüfte Darwin-ABI. Einfaches
Verschlucken von Restorefehlern würde sichere Rückkehr vortäuschen.

Folgen: sichere Ablehnung ungeeigneter Hosts, eigene Adapter pro OS, offener
Produktbeleg T021/T026/T028/T035/T058. Externer Kill bleibt Restoregrenze.

## EN — Decision and trade-offs

Keep source text/remapping as data; independently validate allowed action and
context, sanitize display and never evaluate/import/execute targets. Check host
capability before writes, retain caller session and restore native snapshots after
disposal. Preserve both errors and report Fail on restoration failure. Avoid
private dumps/persistence/network services. Native assets have separate safety.
Shell evaluation, copied sessions, ABI-incompatible ANSI fallback and swallowed
restore errors are rejected alternatives. Safe rejection and per-OS adapters are
required; product cases remain open, with external kill a restoration boundary.

[Threat model](../threat-model.md) · [Scenarios](../security-quality-scenarios-lh01.md)
· [ADR006](../../architecture/decisions/006-lh01-session-terminal.md).

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Owner Thorsten; Zielgruppe Implementierende und unabhängige
Prüfer. DE zuerst/EN danach, ungefähr B2; sourceOnly, kein Home-Sync. Leserpfad:
Spec/Plan → Architektur/Sicherheit → Startreview → aktuelles Intake-Review.
Neubewertung bei geändertem Scope, Paket, Treiber, Host oder Freigabe.

**UpdateRequired.** Thorsten owns these bilingual source-only records for authors
and distinct reviewers. Follow specification/plan → architecture/security → start
review → current intake review. No Home sync; reassess changed scope or baseline.

## Compliance-Evidence / Compliance evidence

| Constitution | Entscheidung und Nachweis / Decision and evidence | Status |
|---|---|---|
| I/XII | Datenvalidierung/keine Auswertung, unabhängige Guard-Schichten / validation and no evaluation | Design; Produkt T021/T026/T043 offen / product open |
| XI | Eigener managed C#14-Code; native Grenze separat / own memory safety, native boundaries | ADR002/004; T058 später / later |
| XIII/XVII | STRIDE, S-ADR-Alternativen, arc42 und Restore-Fail / threats, alternatives, cross-cutting concepts | Startreview T013; Produkt T035 offen / product open |
| VII/VIII | Text/Tastatur, DE/EN, ehrliche Deferred/Excluded / accessible text and evidence limits | T055/T057 praktische Grenzen offen / practical limits open |
| XVI | Locked Pakete, Host-SMA nicht verteilen, native Herkunft / supply chain | T019/T059 offen / open |
| XIX/XX | Regulatorik getrennt Open; UpdateRequired mit Leserpfad / separate applicability and documentation | Bestehende Register/Impact; keine Ausnahme / no exemption |

Die Tabelle ordnet Architekturentwurf zu; sie bescheinigt keine implementierten
Produktkontrollen oder Standardskonformität. / This maps design evidence, without
certifying implemented product controls or standards conformity.
