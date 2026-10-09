# ASVS-Zuordnung / ASVS mapping

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

ASVS-Webanwendungsprüfung ist N/A für das lokale Dateiverfahren: keine Webanwendung, Sitzungscookies oder HTTP-Authentisierung. Prinzipien Eingabeprüfung und sichere Fehler sind über CWE/SSDF Applicable; keine ASVS-Konformität.

Owner Thorsten, Wiedervorlage 2026-10-12; Trigger Web-/Dienst-/Cloud-Scope oder geänderter Vertrag.

Web-application ASVS checks are N/A for this local file process. Input validation and safe errors apply through CWE/SSDF; no ASVS conformity is claimed.

Owner Thorsten; reassess on 2026-10-12 or changed web/service/cloud/contract scope.

## LH-01 Startentwurf 2026-10-09 / Readiness design

Historische LH-00-Bewertungen oben bleiben erhalten. / Prior LH-00 context is preserved.

LH-01-Produkt-ASVS N/A: lokales Binärcmdlet ohne Web/API/Auth/HTTP-Dienst. Sichere Eingaben und Fehler weiterhin Applicable über SSDF/CWE. Bei neuem Web-/API-Scope neu bewerten; Owner Thorsten.

Product ASVS is N/A for the local binary cmdlet without web/API/auth service. SSDF/CWE input/error controls still apply; Thorsten reassesses changed web/API scope.
