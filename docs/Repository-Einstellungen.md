# Repository-Einstellungen

Stand: 27.09.2026. Referenzen: hindermath/TuiVision, hindermath/TinyPl0 und hindermath/TinyCalc.

## Verifiziert

Öffentliches Repository, Standardbranch main, MIT-Lizenz, Issues/Projects/Wiki aktiviert; Discussions/Pages/Auto-Merge deaktiviert. Merge-Commit, Squash und Rebase zugelassen. Automatisches Löschen gemergter Branches und Update-Branch-Option deaktiviert. Diese allgemeinen Optionen entsprechen den Referenzen; Pages bleibt bis zu einer späteren Dokumentationsveröffentlichung deaktiviert.

## Noch manuell einzurichten

Es wurden keine Rulesets angewendet. Die aktuelle GitHub-Anbindung unterstützt diese Änderung nicht.

Unter Settings → Rules → Rulesets ein Branch-Ruleset anlegen:

- Name: main; Enforcement: Active; Ziel: refs/heads/main.
- Restrict deletions und Block force pushes aktivieren.
- Require a pull request before merging aktivieren.
- Eine erforderliche Freigabe und Codeowner-Review aktivieren.
- Extra approval for unattributed changes aktivieren, sofern die Oberfläche diese Option anbietet.
- Dismiss stale approvals, Require approval of most recent push und Require conversation resolution deaktiviert lassen, entsprechend den Referenzen.
- Merge, Squash und Rebase zulassen.
- Repository administrators als Bypass mit Always zulassen, entsprechend den Referenzen. Das ermöglicht beim Einpersonenprojekt insbesondere eigene PRs zu integrieren; eigene PRs können nicht selbst freigegeben werden.

Zusätzlich nach Verfügbarkeit ein Ruleset „Automatic Copilot code review“ für main einrichten. Automatische Reviews aktivieren, Review on push und Review draft pull requests deaktiviert lassen.

Die maschinenlesbare Vorlage steht in [repository-settings.proposed.json](repository-settings.proposed.json). Sie dokumentiert Sollwerte; ihre Existenz aktiviert keine GitHub-Einstellung.

Optionale Repository-Beschreibung:
> OS/400-inspired, keyboard-driven command and parameter prompting for PowerShell 7 terminals.

## Referenzen

- https://github.com/hindermath/TuiVision/rules/13147568
- https://github.com/hindermath/TuiVision/rules/16124040
- https://github.com/hindermath/TinyPl0/rules/13093926
- https://github.com/hindermath/TinyCalc/rules/13146993
