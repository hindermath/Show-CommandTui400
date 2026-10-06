# Sichere Shell-Regeln / Secure shell rules

**Stand / Date:** 2026-10-06. **Basis / Base:** `e621d195f83f36ab2b99cd35d1b7ae3cbdb8fcdd`.
**Owner:** Thorsten Hindermann. **Autor / Author:** Codex `/root`.
**Review:** T012 durch separaten Agenten / by a separate agent.
**Wiedervorlage / Reassessment:** 2026-10-12; bei geändertem Scope oder Werkzeug / on changed scope or tooling.

## Bewertung / Assessment

Bash 5+ ist hier Wartungsumgebung, keine PowerShell-Produktmindestversion.
Pfade quoten, Arrays für Argumente nutzen, Fehlercodes prüfen, Bash `set -euo
pipefail` für eigene Wrapper. PowerShell 7 mit `-NoProfile`; eigene neue Logik
nutzt `Set-StrictMode -Version Latest`, `ErrorActionPreference=Stop`,
`-LiteralPath` und Arrays. Kein eval, Invoke-Expression oder Ausführen des
Issue-Texts. Leeres Windows-HOME darf Pfadauflösung nicht ändern. Upstream-Skripte
werden gezielt mit belegter Herkunft übernommen; keine globale StrictMode-
Nachrüstung in unveränderten Upstream-Funktionen ohne Kompatibilitätsnachweis.
SPECIFY_INIT_DIR muss eine vorhandene .specify-Root sein; feature_directory darf
keine Fremdpfade aus untrusted Quellen übernehmen. Fixtures kontrollieren alle
Featureparameter. Symlinks/Hashangriffe folgen später in T027/T035.

Bash 5+ is the maintenance environment, not a product version choice. Quote
paths, use argument arrays and check exits. Own new PowerShell logic uses strict
mode, terminating errors, literal paths and NoProfile. Never evaluate issue text.
Empty Windows HOME must not change root resolution. Preserve proven upstream
behavior rather than adding untested global strict mode. Only trusted fixtures
supply feature parameters; later tasks test lifecycle traversal and hash attacks.
