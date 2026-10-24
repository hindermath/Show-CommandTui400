# LH-00/LH-01: Dokumentationsrollout bewerten / Assess documentation rollout

## DE

Ownerauftrag 24.10.2026: gewöhnliche Quellenupdates LH-00 und LH-01, vollständige unabhängige Reviews, gezielter Spec-/Plan-/Tasks-Abgleich und MergeAndSync mit Admin-Bypass. Kein Produkt-/Folgefeature, keine Installation, kein Release, keine reale Serienaktivierung, kein Home-/Flotten-Sync und keine Umbindung der Plattformprüfstände/Prompts #37–#39. Lokaler Routing-Refresh ist separat ausdrücklich freigegeben; Discovery-/Metadatenprüfung ist kein Modellzugangs-Preflight.

PR #55 übernimmt die veröffentlichte 14er-Dokumentationskohorte. Vier Quellen je Intake weichen ab: beide Constitution-Kopien, AGENTS.md und die Projektmatrix. Das Dokumentationspaket ergänzt Leserhilfen, Paketidentitäten und erzeugte Agentenflächen; Rollen, Statuswerte, Schemas und Ausführungsrechte bleiben erhalten. Die zwei tatsächlich geänderten Runtime-Validatoren ergänzen nur die akzeptierten historischen Schema-2-Generatoridentitäten0.3.8/0.3.9. Eigene Releaseerkennung, Hash-, Datei-, Pfad- und Statusprüfungen bleiben unverändert. CI bindet das neue Documentation-Impact-Dokument und den eigenen technischen Kontext, nicht eine menschliche Projektabnahme.

GSDB3.4.4 einschließlich aller37 kontrollierten Dateien ist gegenüber der vorherigen Lieferung bytegleich. Die bestehende50-Kontroll-Zuordnung mit18 Applicable,29 Open und3 begrenzten N/A wird unverändert wiederverwendet. Ihre Umsetzungs-/Rechtsnachweise bleiben offen; dieser Dokumentationsrollout schließt sie nicht. Die neuen deutschen und englischen Nutzerleitfäden aller14 Presets sind mit Pfad/Hash gebunden. Maßgeblich sind projektbezogene Anforderungen; Paketbeispiele importieren weder fremde Produktfunktionen noch neue Genehmigungsrunden, wenn die bestehende Nutzerautorität den Schritt bereits abdeckt.

Wesentliche Leserklärungen: Ein Starter ist eine auszufüllende Vorlage, kein Nachweis. Ein Prompt ist Agenteneingabe, kein Shell-Befehl und keine Freigabe. Installation komponiert Anweisungen, startet aber keine Aufgabe oder Modellprobe. Stabile Rollen stehen in model-routing.json; Priorität und Aufgabenrolle sind verschieden. Automatische lokale Profile kann der stabile Resolver nur für Codex und Antigravity erstellen. Claude, Copilot und OpenCode haben Policy-Bezeichnungen, keine implementierten automatischen Adapter. Refresh prüft Discovery-Metadaten; ein separater Modellzugangs-Preflight kann Kontingent verbrauchen und braucht passende Laufautorität. Der heutige Refresh beansprucht keinen Zugangstest.

Anwendbarkeit und Umsetzung bleiben getrennt. Unbekannte Rollen/Provider/Rechtsfragen Open, ungemessene Abdeckung Not Assessed. Reale Terminals/Screenreader Deferred, Braillehardware Excluded. Volle LH-00-Abnahme nach LH-02/vor LH-03. Keine neue Risikoannahme, Zertifizierung, A11Y-Konformität oder Pilotfreigabe. Der technische Stack und die portable Compile-only-/Host-Runtime-Trennung bleiben unverändert.

## EN

The owner commissions ordinary source updates, complete distinct reviews, targeted technical alignment and exact-head MergeAndSync/admin delivery. No product/future feature, installation, release, series activation, fleet/Home sync or platform rebind. Local routing refresh has separate authority and is discovery metadata validation, not model-access proof.

PR #55 supplies fourteen published documentation packages and regenerated agent surfaces. Four bound sources per intake changed. Reader help and package identity do not change schemas, statuses or execution rights. The only two runtime-validator changes add accepted historical schema-2 generator identities; current self-release detection and hash/path/state checks remain strict. CI points to the new documentation evidence/context, never human acceptance. All37 controlled GSDB3.4.4 files and the50-control assessment remain unchanged. Reuse their evidence with explicit limits and owned open tasks.

All28 language guide paths/hashes are recorded. Templates require actual completion; prompts are agent input, not shell commands or authority. Package examples do not import product scope or duplicate already sufficient user approvals. Installed roles do not change the current chat or prove model access. The stable resolver creates automatic profiles only for Codex/Antigravity; other integrations have policy labels, not implemented automatic adapters. Refresh does not run a quota-consuming model-access preflight. Preserve separate product/tool/organisation decisions, Open/Not Assessed evidence, practical limits and full LH-00 acceptance order.

## Paket-/Leserpfadzuordnung / Package and reader-path mapping

| Preset | Version | Priorität / Priority | Leserpfade / Reader paths |
|---|---|---:|---|
| security-governance | v0.7.4 | 10 | [DE](../../.specify/presets/security-governance/docs/user-guide.md) / [EN](../../.specify/presets/security-governance/docs/user-guide.EN.md) |
| secure-development-assurance-governance | v0.1.8 | 15 | [DE](../../.specify/presets/secure-development-assurance-governance/docs/user-guide.md) / [EN](../../.specify/presets/secure-development-assurance-governance/docs/user-guide.EN.md) |
| architecture-governance | v0.6.5 | 20 | [DE](../../.specify/presets/architecture-governance/docs/user-guide.md) / [EN](../../.specify/presets/architecture-governance/docs/user-guide.EN.md) |
| isaqb-architecture-governance | v0.2.5 | 30 | [DE](../../.specify/presets/isaqb-architecture-governance/docs/user-guide.md) / [EN](../../.specify/presets/isaqb-architecture-governance/docs/user-guide.EN.md) |
| a11y-governance | v0.4.6 | 40 | [DE](../../.specify/presets/a11y-governance/docs/user-guide.md) / [EN](../../.specify/presets/a11y-governance/docs/user-guide.EN.md) |
| cross-platform-governance | v0.2.5 | 50 | [DE](../../.specify/presets/cross-platform-governance/docs/user-guide.md) / [EN](../../.specify/presets/cross-platform-governance/docs/user-guide.EN.md) |
| agent-parity-governance | v0.4.5 | 60 | [DE](../../.specify/presets/agent-parity-governance/docs/user-guide.md) / [EN](../../.specify/presets/agent-parity-governance/docs/user-guide.EN.md) |
| model-routing-governance | v0.1.7 | 61 | [DE](../../.specify/presets/model-routing-governance/docs/user-guide.md) / [EN](../../.specify/presets/model-routing-governance/docs/user-guide.EN.md) |
| intake-authoring-governance | v0.3.10 | 64 | [DE](../../.specify/presets/intake-authoring-governance/docs/user-guide.md) / [EN](../../.specify/presets/intake-authoring-governance/docs/user-guide.EN.md) |
| intake-review-governance | v0.2.7 | 65 | [DE](../../.specify/presets/intake-review-governance/docs/user-guide.md) / [EN](../../.specify/presets/intake-review-governance/docs/user-guide.EN.md) |
| intake-sequencing-governance | v0.2.11 | 66 | [DE](../../.specify/presets/intake-sequencing-governance/docs/user-guide.md) / [EN](../../.specify/presets/intake-sequencing-governance/docs/user-guide.EN.md) |
| autonomous-run-governance | v0.4.7 | 70 | [DE](../../.specify/presets/autonomous-run-governance/docs/user-guide.md) / [EN](../../.specify/presets/autonomous-run-governance/docs/user-guide.EN.md) |
| parallel-autonomous-run-governance | v0.2.9 | 80 | [DE](../../.specify/presets/parallel-autonomous-run-governance/docs/user-guide.md) / [EN](../../.specify/presets/parallel-autonomous-run-governance/docs/user-guide.EN.md) |
| project-statistics-governance | v0.1.3 | 90 | [DE](../../.specify/presets/project-statistics-governance/docs/user-guide.md) / [EN](../../.specify/presets/project-statistics-governance/docs/user-guide.EN.md) |

## Quellenabweichungen / Source drift

### lh-00

| Quelle / Source | Alt / Before | Neu / After | Git |
|---|---|---|---|
| `constitution.md` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | `eef6170db105fa13fabb349c3875bd8b3ea67f74bac915ef542fd22ee9decf4a` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `AGENTS.md` | `11c4aeef2e2db68906f46acb760ae2889e068539bd7111ffbd2b39b2c6cf6b54` | `45721ee81c102b6e032b054bfa252ae08408ea311b12c17dd1d379e7092061c3` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `c4e606e7679415f35e42b8d0ccf963f2d5b14754fe689d45393279a90196be8f` | `2cb57b4651616439b45bee12156b8c513187141100ecb39ac64f3fe9eaa8bcfa` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `.specify/memory/constitution.md` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | `eef6170db105fa13fabb349c3875bd8b3ea67f74bac915ef542fd22ee9decf4a` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |

### lh-01

| Quelle / Source | Alt / Before | Neu / After | Git |
|---|---|---|---|
| `constitution.md` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | `eef6170db105fa13fabb349c3875bd8b3ea67f74bac915ef542fd22ee9decf4a` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `.specify/memory/constitution.md` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | `eef6170db105fa13fabb349c3875bd8b3ea67f74bac915ef542fd22ee9decf4a` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `AGENTS.md` | `11c4aeef2e2db68906f46acb760ae2889e068539bd7111ffbd2b39b2c6cf6b54` | `45721ee81c102b6e032b054bfa252ae08408ea311b12c17dd1d379e7092061c3` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `c4e606e7679415f35e42b8d0ccf963f2d5b14754fe689d45393279a90196be8f` | `2cb57b4651616439b45bee12156b8c513187141100ecb39ac64f3fe9eaa8bcfa` | f62eb03 docs: integrate fourteen published governance packages in Show pilot |

[Maschinenlesbare Bewertung / Machine-readable assessment](lh00-lh01-preset-doc-rollout-20261024-assessment.json).
