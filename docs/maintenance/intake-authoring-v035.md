# Intake Authoring Governance v0.3.5

Datum: 28.09.2026. Owner: Thorsten Hindermann.

## Änderung und Grenzen

Das bestehende Authoring-Preset wird von 0.3.4 auf 0.3.5 aktualisiert,
weiterhin aktiviert mit Priorität 64. Das veröffentlichte Paket korrigiert
die Ablehnung von Receipts der eigenen Generatorvorlage. Unbekannte
Generatorversionen und falsche Schema-Zuordnungen bleiben gesperrt.

Ausgangscommit: `c7600d17c54030112c6f3ddeea2c4739f2b1e098`.
Die installierte 0.3.4-Kopie entsprach dem veröffentlichten Archiv ohne lokale
Abweichungen. Die neue Paketkopie entspricht ebenfalls vollständig dem
veröffentlichten Tag-Archiv. Die 13 anderen Registry-Einträge bleiben identisch.
Profilanzahl, Prioritäten und Aktivierungszustände ändern sich nicht.

Die CLI erzeugt einige Command-Dateien ohne abschließenden Zeilenumbruch und
entfernt den vorhandenen OpenCode-Kompatibilitätspfad. Der projektspezifische
Zeilenabschluss und beide bestehenden OpenCode-Flächen wurden wiederhergestellt;
die Command-Inhalte bleiben unverändert. Die Agentenparität besteht.

Keine Intakes, Receipts, fachlichen Abhängigkeiten oder Produktdateien wurden
erzeugt oder verändert. LH-00 bleibt der erste fachliche Schritt. Die Installation
erteilt keine Produkt-, Release-, Sicherheits- oder menschliche Feldfreigabe.

## Paketbindung

- [Stabiles Release v0.3.5](https://github.com/hindermath/spec-kit-preset-intake-authoring-governance/releases/tag/v0.3.5).
- [Release-PR #10](https://github.com/hindermath/spec-kit-preset-intake-authoring-governance/pull/10).
- Tag-Commit: `f90e707444237d768623f457f85d15a707c3476e`.
- Tag-ZIP SHA-256: `972b6106e9c0ecd95a90dc6bdb175e97a5cc5ef16261b84e56beca2928fa7ba8`.
- Release-ZIP SHA-256: `ed81f62f53dba7f46204ddd822b24747b55f428b9bb427cb2ea715dd56013339`.
- [Native Quell-CI](https://github.com/hindermath/spec-kit-preset-intake-authoring-governance/actions/runs/36429748508): macOS, Linux und Windows erfolgreich am Head `2ad74f88caf67bb7d8eb8292fef62baea845b9fe`.

## Prüfungen und Liefer-Gates

- Exakte 14-Preset-Matrix: Bash und PowerShell erfolgreich.
- Paketgleichheit, Erhalt der übrigen Registry-Einträge und Agentenparität: erfolgreich.
- Die lokale Lieferprüfung umfasst Template-Integrität, die installierte
  Lifecycle-Suite mit echten Vorlagen-Receipts, LF/CRLF/BOM, unveränderten
  Eingabe-Hashes sowie erwarteter Ablehnung mit Exitcode 2.
- Secret-Scan, PowerShell-Analyse und Statistikprüfung sind verbindliche
  zusätzliche lokale Gates. Native Projekt-CI wird am exakten PR-Head geprüft.
- Der Homogenitätsprüfer erwartete bereits im Ausgangsstand eine explizite
  Spec-Kit-Überschrift in der README. Der bestehende Einrichtungsabschnitt
  trägt nun diese Überschrift und verlinkt diesen Update-Nachweis. Die
  dokumentierte deutsche Produktsprache bleibt erhalten; keine Validatorregel
  wurde abgeschwächt.
- MergeAndSync mit Admin-Bypass nur nach erfolgreichen technischen Checks.
  Nicht gestartete oder fehlgeschlagene CI blockiert; sie zählt nicht als Pass.

NIST SSDF und CWE Top 25 gelten für diese Governance-Werkzeuge; Paket- und
Quellbindung bilden begrenzte Supply-Chain-Evidence. Keine neue Abhängigkeit,
kein Web-/API-Dienst und keine ausgelieferte KI-Runtime: ASVS und AI-SBOM
sind für diesen Patch N/A. Bestehende offene Produktnachweise bleiben offen.

## Dokumentationsauswirkung

Entscheidung: `UpdateRequired`. Zielgruppen: Maintainer und Lernende.
Leserpfad: README → Entwicklungsumgebung → dieser Nachweis → Release und PR.
Kanonische Quellen: veröffentlichtes Preset und zentrale Home-Baseline-Profile.
Aktuelle Profilkopien, Constitution und Bootstrap-Vorlagen binden 0.3.5;
historische Dokumente bleiben erhalten. Klasse: repository-lokaler
Integrationsnachweis. Deutsche Projektdokumentation gemäß Agenten-Guidance;
gemeinsame Vorlagen bleiben DE/EN. Kein Home-Sync dieses Level-2-Repositories.
Statistikmethodik unverändert; nur das vorhandene Profil-2-Ledger fortschreiben.
Wiedervorlage: Versions-, Profil-, Quellen- oder lokale Erweiterungsdrift.
