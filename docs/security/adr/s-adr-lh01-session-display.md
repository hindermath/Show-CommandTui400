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

## Implementierungsnachtrag 2026-11-23 / Implementation addendum

DE: Terminal.Gui 2.6 benötigt System.Text.Json 11. Der neue Einstieg
`src/ShowCommandTui400/ShowCommandTui400.psm1` lädt die Binärimplementierung über
`Bootstrap/DependencyLoader.cs` in einen privaten AssemblyLoadContext. Lokale
Paketbibliotheken werden aus dem Modulverzeichnis geladen; die PowerShell-API
bleibt die bereits geladene Host-Assembly. Das erhält den aktuellen Runspace und
die Mindestversion 7.6.4. Alternativen wären ein höherer Mindesthost oder das
Ersetzen bereits geladener Hostbibliotheken; die private Ladung erhält den
bestehenden Hostvertrag. Der Kontext trennt Assembly-Versionen. Modulcode läuft
weiterhin mit denselben Benutzerrechten; ausschließlich vertrauenswürdige,
kontrolliert gebaute Moduldateien gehören zum Lieferumfang.

NIST SSDF/CWE gelten für Ladepfade und Supply Chain. BOOT01 prüft private JSON-
und gemeinsame PowerShell-Identität; B01 und die vollständige synthetische
Produktsuite wurden nativ mit 7.6.6 und 7.7.0 geprüft. Der erwartete S07-Fehler
bleibt ein Fehler mit erfülltem Diagnosevertrag. ASVS und verteiltes Zero Trust
bleiben für dieses lokale Cmdlet N/A nach den bestehenden Anwendbarkeitsnotizen.
SBOM-/Locked-Restore- und Host-Runtime-Ausschlüsse bleiben verbindlich; kein
KI-Runtime-Scope und keine Änderung der bestehenden regulatorischen Matrix.
Physische Terminal-, Screenreader- und Braille-Abnahmen bleiben separate Gates.

EN: Terminal.Gui 2.6 requires System.Text.Json 11. The new script-module entry
loads the binary implementation through a private AssemblyLoadContext. Local
package libraries load from the module directory; the PowerShell API remains
the host's already-loaded assembly. This retains the caller's runspace and
minimum version 7.6.4. Raising the minimum host or replacing loaded host libraries
were alternatives; private loading preserves the existing host contract. The
context separates assembly versions. Module code retains the user's permissions;
only trusted, controlled module build outputs belong to the distribution.

NIST SSDF/CWE apply to load paths and supply chain. BOOT01 checks private JSON
and shared PowerShell identity. B01 and the complete synthetic product suite
were tested natively with 7.6.6 and 7.7.0. Expected S07 failure remains a failure
with its diagnostic contract satisfied. ASVS and distributed Zero Trust remain
N/A for this local cmdlet under the existing applicability records. SBOM, locked
restore and host-runtime exclusion checks remain binding. No AI-runtime scope
or change to the regulatory matrix is introduced. Physical terminal, screen-reader
and Braille acceptance remain separate gates.
