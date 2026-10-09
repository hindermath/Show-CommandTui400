# LH-01 arc42 Abschnitt 8 / Cross-cutting security

## DE — Übergreifende Konzepte

Input: Version/Host/Streams/Remap vor UI-Schreibzugriff prüfen. Fremde Texte
entkräften und nie ausführen. Fachmodell: ActionId-Whitelist und Kontextprüfung
getrennt; keine Targetausführung oder Folgefeatures. Session: aktuell in-process,
keine privaten Daten persistieren. Lifecycle: Snapshot → Lease → GUI → Dispose →
Restore; Ctrl+C/StopProcessing/Fehler erhalten. Restorefehler bleiben Fail.
Lieferkette: locked öffentliche Abhängigkeiten, Host-SMA ausschließen, native Pfade
einzeln inventarisieren. Logs: synthetisch, nur beauftragte Pfade. Rechtliche
Anwendbarkeit verweist auf bestehendes Register, keine parallele Rechtsentscheidung.

## EN — Cross-cutting concepts

Validate version/host/streams/remapping before terminal writes; sanitize untrusted
text without evaluation. Separate action allow-list from context checks and avoid
target execution. Keep the current session and no private persistence. Snapshot
precedes lease/UI; dispose precedes restore; preserve cancellation and both errors.
Restoration failure stays Fail. Lock public dependencies, exclude host SMA and
inventory native paths. Use synthetic scoped evidence and refer to the existing
regulatory assessment rather than duplicating legal decisions.

[Bedrohungen / Threats](threat-model.md) · [Szenarien / Scenarios](security-quality-scenarios-lh01.md)
· [S-ADR](adr/s-adr-lh01-session-display.md).

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Owner Thorsten; Zielgruppe Implementierende und unabhängige
Prüfer. DE zuerst/EN danach, ungefähr B2; sourceOnly, kein Home-Sync. Leserpfad:
Spec/Plan → Architektur/Sicherheit → Startreview → aktuelles Intake-Review.
Neubewertung bei geändertem Scope, Paket, Treiber, Host oder Freigabe.

**UpdateRequired.** Thorsten owns these bilingual source-only records for authors
and distinct reviewers. Follow specification/plan → architecture/security → start
review → current intake review. No Home sync; reassess changed scope or baseline.

## DE — Authentisierung, Krypto und Deployment

Authentisierung N/A: kein eigener Login oder Remote-Identitätsdienst; vorhandene
OS-/PowerShell-Sitzung nutzen, keine Berechtigungen erweitern. Autorisierung
Applicable: nur bekannte UND im aktuellen Kontext erlaubte lokale Aktionen,
keine Ausführung eines Zielbefehls. Verschlüsselung in Transit/at Rest für
Produktdaten N/A: kein Transportdienst und keine persistierten Produktdaten.
Das erlaubt keine privaten Dumps; öffentliche Paket-Restore-Verbindungen nutzen
HTTPS gemäß Lieferkettengrenze. Bei Remotezugriff, Persistenz oder Auth-Scope
alle N/A-Entscheidungen vor betroffener Nutzung neu bewerten; Owner Thorsten.

Deployment Security: öffentlicher Feed, gepinnte/locked Abhängigkeiten, überprüfte
Buildherkunft und Notices; Host-SMA/.NET nicht mitliefern. Lokaler Import nur aus
freigegebenem Modulstand, keine globalen Installationen oder Schreibrechte aus
Prüfanweisungen ableiten. T019/T059 liefern Produktbelege; Release bleibt eigener
Auftrag. Logging/Audit beschränkt auf synthetische beauftragte Nachweise, keine
privaten Variablen, Telemetrie oder dauerhafte Sitzungslogs.

## EN — Authentication, cryptography and deployment

Authentication is N/A without a product login/remote identity service; retain the
existing OS/PowerShell session without privilege escalation. Authorization applies:
allow known actions only in permitted contexts and never execute targets. Product
transit/at-rest encryption is N/A without transport/persisted product data; this
never permits private dumps. Public package restore uses HTTPS under supply-chain
controls. Thorsten reassesses remote, persistence or authentication scope before use.

Deployment needs pinned/locked public packages, build provenance and notices, no
redistributed host SMA/runtime. Import only the approved local module; tests imply
no global install/privilege. T019/T059 provide actual product evidence; release needs
separate authority. Synthetic scoped audit evidence excludes private variables,
telemetry and persistent session logs.
