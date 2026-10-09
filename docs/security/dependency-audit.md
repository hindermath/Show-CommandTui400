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

## LH-01 Startentwurf 2026-10-09 / Readiness design

Historische LH-00-Bewertungen oben bleiben erhalten. / Prior LH-00 context is preserved.

LH-01-Auswahl Terminal.Gui2.5.0 und 24 locked Fixturepakete: vorhandene Contenthash-/Lizenz-/Native-Assetbewertung in specs/002-lh01-tui-foundation/feasibility/native-dependency-assessment.md. Kein neuer Restore oder aktueller Schwachstellen-Freibrief. Produktpackages.lock.json und freigegebene öffentliche Registry erst T019. Onigwrap1.0.11 über TextMateSharp2.0.4 nicht aktivieren; native Oniguruma-Version/Buildherkunft vor Highlighting. Thorsten prüft mindestens monatlich (2026-11-09), vor Release und bei Advisories/Paketwechsel; Updateautomation bleibt eigener Auftrag.

Terminal.Gui2.5.0 and 24 locked fixture packages have existing content/license/native evidence; no new restore or current vulnerability clearance is claimed. Product lock/feed follow at T019. Do not activate Onigwrap/TextMate highlighting before native source/build provenance. Thorsten audits monthly (2026-11-09), before release and on advisory/package changes; automation requires separate authority.
