# Abhängigkeitsprüfung / Dependency audit

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Spec Kit 0.12.8 stammt aus dem lokal installierten specify-cli/core_pack.
Seine fünf PowerShell-Dateien werden T013/T014 bytegebunden erfasst; Änderungen
umfassen DE/EN-Hilfe, Aufrufwege und zwei begründete Importkorrekturen
(schreibgeschützte PID-Variable, sichere Verbose-Meldung im bestehenden Catch). Bash-common ist bytegleich,
andere Bash-Dateien unterscheiden Whitespace und lokales Kommandorendering.
Die 14 Presets entsprechen der versionierten Projektmatrix; Prüfmodus ist
`--check-only`, kein Installationslauf. Pins/Quellen stehen in Matrix und
`docs/maintenance/lh00-b01-release-adoption.md`. Tag-/Archiv-URLs sind Herkunft,
keine kryptografische Signatur. Kein NuGet/npm-Produktbestand besteht.
Dependabot/Renovate-Konfiguration ist hier nicht vorhanden; Updates laufen als
explizite Governance-Aufträge. Automatische neue Dependency-Updates sind Open,
Owner Thorsten, 2026-10-12, Trigger erster Produkt-Dependencybestand.

Spec Kit is the installed 0.12.8 core pack. T013/T014 bind the five imported
PowerShell files; bilingual help, invocation routes and two narrow verified fixes are added. Core
Bash behavior is retained. Fourteen installed presets match the pinned project
matrix. Tag URLs establish provenance, not signatures. No product dependency
set exists. No Dependabot/Renovate configuration is present; new automated
updates remain Open for the owner at the first product dependency decision.
