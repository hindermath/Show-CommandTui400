# Show-CommandTui400 — Agenten-Guidance / Agent Guidance

## Überblick und Projektkontext / Overview and Project Context

Level 2 im Workspace `RiderProjects`; kanonische Quelle ist
`hindermath/Show-CommandTui400`, Standardbranch `main`.
Fachliche Baseline: `docs/Bedienkonzept.md`; verbindliche Reihenfolge:
`docs/Lastenheft-Plan.md`. Das Projekt ist in der Konzeptphase.
Der LH-00-Kernprozess und T045 sind geliefert; vollständige Prozessabnahme bleibt offen.
Zielumgebung ist die aktuelle PowerShell-7-Sitzung auf macOS, Linux und Windows.
LH-01 wählt managed C#14, Host-.NET10/net10.0, Terminal.Gui2.5.0 mit explizitem
dotnet-Treiber, Mindest-PowerShell7.6.4 und in-process PSCmdlet. Native/Runtime-
Grenzen und praktische Abnahme bleiben getrennt; kein Produktcode vorhanden.

*Level 2 in RiderProjects. The canonical source is hindermath/Show-CommandTui400
on main. Read the interaction concept and intake order before work. This is a
concept-stage project targeting the current PowerShell 7 session on macOS,
Linux and Windows. LH-01 selects managed C#14, host .NET10, Terminal.Gui2.5.0 explicit dotnet driver,
minimum PowerShell7.6.4 and in-process PSCmdlet. Native/runtime proof and practical
acceptance remain separate; no product code exists.*

## Arbeitsgrenzen / Work Boundaries

Die Einrichtung installiert Werkzeuge und Governance. Sie erstellt keine
Lastenhefte und startet keine Produktimplementierung oder autonomen Läufe.
Issues sind fachliche Eingaben; LH-00 bleibt zuerst zu bearbeiten.
Bestehende README, MIT-Lizenz und CODEOWNERS erhalten. Fremde Änderungen
nicht überschreiben. Keine Release-Automation ohne gesonderten Auftrag.

*Setup installs tooling and governance only. It does not author intakes, start
implementation or authorize autonomous runs. Issues are requirements input;
LH-00 comes first. Preserve existing content, license, owners and unrelated
changes. Release automation needs a separate request.*

## Governance und Sicherheit / Governance and Security

`constitution.md` und `.specify/memory/constitution.md` gemeinsam pflegen.
Die Projektzeile im Level-2-Umgebungsregister gilt für Runtime, Prüfungen,
Barrierefreiheit und Statistik. Primärsprache C#14; eigener managed Code ist MSL, native Grenzen separat.
Die zentralen Level-0-Regeln sind die gemeinsame Basis, keine Übernahme fremder
Produktanforderungen. NIST SSDF und CWE Top 25 gelten auch für die Einrichtung.
Anwendbarkeit und offene Produktnachweise stehen in `docs/security/README.md`.
Secrets, Tokens, lokale Agentenzustände und Preset-Caches niemals committen.
Vor schreibenden Wartungsläufen Hilfe und Check-/Dry-Run-/WhatIf-Modus verwenden.
Auf macOS/Linux zuerst Bash, auf Windows PowerShell 7 verwenden.
Neue Logik auf Eingabevalidierung, Datei-/Netzwerkzugriffe und sichere Defaults
prüfen. Kommentare erklären Gründe und Grenzen, nicht offensichtlichen Code.

*Keep both constitution copies aligned and use the project environment row.
Own managed C#14 code uses an MSL; native/runtime boundaries remain separate. Shared Level-0 policy
does not import another product's requirements. NIST SSDF and CWE Top 25 apply;
record applicability and open evidence in docs/security/README.md. Never commit
secrets, agent state or preset caches. Preview writes first; use Bash first on
macOS/Linux and PowerShell 7 on Windows. Review input validation, I/O and secure
defaults. Comments explain rationale and boundaries.*

## Spec Kit und Prüfungen / Spec Kit and Checks

Explizites Projektprofil: `project-statistics-fourteen-governance-presets`.
Versionsquelle: `scripts/config/spec-kit-project-statistics-governance-presets.json`.
Installierte Integrationen: `agy`, `opencode`, `claude`, `copilot`, `codex`.
Der globale Flottenstandard bleibt unverändert. Installation allein ist kein
Security-, A11Y-, Feature- oder Feldabnahmenachweis.

*Use the explicit fourteen-preset project profile and its version matrix.
The five integrations are installed; the fleet default is unchanged.
Installation alone proves no security, accessibility, feature or field acceptance.*

```bash
bash scripts/install-spec-kit-governance-presets.sh --repo . --preset-config scripts/config/spec-kit-project-statistics-governance-presets.json --check-only
bash scripts/scan-agent-secrets.sh --fail-on-high .
bash scripts/check-homogeneity.sh --dry-run --no-patch .
bash scripts/render-project-statistics.sh --repo . --check-only
pwsh -NoProfile -File scripts/invoke-psscriptanalyzer.ps1
```

Produkt-Build- und Laufzeittests werden erst mit der technischen Entscheidung
definiert. Verfügbare Intake-Kommandos und nächste Schritte stehen in
`docs/Entwicklungsumgebung.md`.

*Product build and runtime tests await the technical decision. Available intake
commands and next steps are documented in the development environment guide.*

## Dokumentation, A11Y und Statistik / Documentation, A11Y and Statistics

`Programmierung #include<everyone>` ist verbindlich. WCAG 2.2 AA gilt soweit
anwendbar; Tastatur, Screenreader, Braille und Textbrowser berücksichtigen.
Fachliche Dokumentation, Lastenhefte und gemeinsame Guidance werden DE zuerst/
EN danach gepflegt, ungefähr CEFR B2. Die frühere Deutsch-Ausnahme ist durch den
Owner-Auftrag zur LH-00-Erstellung aufgehoben. Begriffe bei erster Verwendung
erklären; keine Spec-Kit-Kenntnisse voraussetzen. Historische Nachweise behalten
ihren damaligen Kontext. Offene Bestandsübersetzungen stehen mit Owner und
Fälligkeit in `docs/intake-governance.md`; Upstream-Templates bleiben unverändert.
Dokumentationsauswirkung und Leserpfade im selben PR erfassen; zentrale
Grundlage ist die Level-0-Dokumentations-Governance.

Statistikprofil 2 verwendet `docs/project-statistics.config.json` und den
Renderer; Ledger nach abgeschlossenen Arbeitspaketen fortschreiben, älteste
Einträge zuerst, `Gesamtstatistik` zuletzt. Referenzen: `80` konservativ und
`125` Thorsten-Solo nach belegter C#-Auswahl; keine Zeit-/Qualitätsmessung. Git-Lieferdichte ist keine Zeitmessung oder Qualitätsbewertung.
ASCII-Diagramme maximal 100 Zeichen breit, mit exakten Zahlen und bilingualer
Textalternative. Das zusätzliche Statistik-Preset startet keine Messung.

*Design for keyboard, screen readers, Braille and text browsers, with WCAG 2.2
AA where applicable. Product documentation, intakes and shared guidance use
German first and English second at about CEFR B2. The owner-approved LH-00 work
replaces the earlier German-only exception. Explain terms on first use and do
not assume Spec Kit knowledge. Preserve historical evidence in its original
context. Outstanding translations have an owner and deadline in
`docs/intake-governance.md`; upstream templates remain unchanged.
Record documentation impact and reader paths in the same PR. Maintain the
Profile 2 ledger through its renderer, oldest entries first and overall
statistics last. References are 80 and125 lines/day after evidenced C# selection. Git delivery
density is no time or quality measurement. ASCII charts need exact numbers,
bilingual alternatives and at most 100 columns. The extra statistics preset
starts no measurement.*

Diese Guidance ist identisch in `AGENTS.md`, `CLAUDE.md`, `GEMINI.md`,
`.github/copilot-instructions.md` und `.github/agents/copilot-instructions.md`.
Alle fünf Flächen bei Änderungen gemeinsam pflegen.

*Keep all five agent-guidance files identical when changing shared rules.*

## Lastenheft-Erstellung / Intake authoring

Verbindlich sind `.specify/memory/intake-authoring-policy.json`,
`.specify/memory/intake-authoring-profile.md` und die Zuordnung in
`docs/intake-governance.md`. Ein Intake ist ein fachliches Lastenheft;
ein Receipt ist der maschinenlesbare Herkunfts- und Hashnachweis.
`ReadyForReview` bedeutet nur bereit für ein gesondertes Review.
`docs/issue-drafts/` enthält historische Quellen der veröffentlichten Issues,
keine weiteren aktiven Lastenhefte. LH-00 und der LH-01-Einzelpilot sind beauftragt; neue Folgefeatures brauchen
eigene Aufträge.
Der ursprüngliche Authoring-Auftrag war lokal begrenzt. Die danach ausdrücklich
beauftragten Reparatur-, Review- und Lieferaktionen stehen in
`docs/planning/lh00-repair-decisions.md`; aktueller Stand in Receipt und Reviewbericht.
Jede weitere Erstellung, Prüfung oder Lieferung benötigt passende ausdrückliche
Autorität. Folgeprompts sind Vorlagen für einen späteren Auftrag. Serienverwaltung
und Plattformabnahme sind Anforderungen von LH-00, nicht durch Erstellung erfüllt.

The policy, profile and governance mapping linked above are binding. An intake
is a requirements document; a receipt records its sources and content hashes.
`ReadyForReview` only means ready for a separate review. The issue-draft directory
contains historical sources for published issues, not additional active intakes.
LH-00 and the LH-01 standalone pilot are commissioned; further features need
separate authority. Original authoring was limited
to local changes. Later explicitly authorized repair, review and delivery actions
are recorded in docs/planning/lh00-repair-decisions.md; the current receipt and
review report show the state. Further creation, review or delivery needs matching
explicit authority. Follow-up prompts are templates for a later request. Series
management and platform acceptance remain LH-00 requirements, not authoring results.

## Governance-Pilot und Liefergrenzen / Governance pilot and delivery boundaries

DE: Das 14er-Profil bindet Security 0.7.1, Architecture 0.6.2 und Intake
Authoring 0.3.7 / Review 0.2.4 / Sequencing 0.2.8. Produkt, Werkzeuge und
Organisation werden regulatorisch getrennt bewertet; Ausbildungszweck und
AI-SBOM N/A ersetzen keine DS-GVO-/KI-VO-Anwendbarkeitspruefung.
Unbekannte Rollen, Jurisdiktionen oder direkte/vertragliche Pflichten bleiben Open.
Die urspruenglichen sechs Presets plus Secure Development Assurance werden
jaehrlich am 3. Oktober geprueft, naechster Termin 2027-10-03 um 10:00
Europe/Berlin. Anlassreviews verschieben den Termin nicht; Automation liest nur.
Stufe A ist Home Baseline/betroffene Home Runtime; B umfasst zwei benannte
public Level-2-Piloten. C (restliche public Level-2-Verbraucher) und D
(restliche Flotte) brauchen jeweils einen separaten Auftrag. Admin-Bypass
ersetzt keine technische Pruefung. Installation startet keine Implementierung.

EN: The fourteen-preset profile binds the five released versions above.
Assess product, tooling and organisation separately; unknown regulatory
scope remains Open. Education and AI-SBOM N/A are not blanket exemptions.
Review the original six presets plus Assurance every 3 October, next
2027-10-03 at 10:00 Europe/Berlin; event reviews do not reset this date.
Automation only reads. Deliver central/runtime first, then two named public
Level-2 pilots. Further public Level-2 consumers and the remaining fleet each
need a separate request. Installation grants no product execution authority.

Evidence: [pilot integration](docs/maintenance/coordinated-governance-oct03.md).
Policy: `docs/maintenance/governance-review-and-rollout.md` in the Level-0 source.

## macOS-CI-Runner / macOS CI runners

Bisherige macOS-14-Jobs verwenden explizit `macos-15`. Die bestehende
Repository-Auswahl fuer Linux-only-Wartungsjobs bleibt erhalten. Ein gruener
CI-Lauf beweist nur die ausgefuehrten Checks, keine Produkt-Plattformabnahme.
Bei Runnerwechseln auch verpflichtende Checknamen und Migrationsvorlagen
pruefen. Betrieb und Pruefgrenzen: `docs/maintenance/macos-runner-migration.md`.

Existing macOS 14 jobs explicitly use `macos-15`. Keep the existing repository
selection for Linux-only maintenance jobs. Successful CI proves the executed
checks, not product platform acceptance. Review required check names and
migration templates whenever runner labels change. See the linked guide.

## Aktueller LH-01-Stand / Current LH-01 state

LH-01 ist erstellt und technisch spezifiziert/geplant. Sprache/MSL, Runtime,
Framework, PowerShell-Minimum und Sitzungsintegration sind getrennt entschieden:
managed C#14, Host-.NET10, Terminal.Gui2.5.0 dotnet ohne ANSI-Fallback, PS7.6.4 und
in-process PSCmdlet. [ADRs](docs/architecture/decisions/002-lh01-language-msl.md)
und [Startprüfung](docs/validation/lh01/start-readiness.md) führen Grenzen.
T001–T017 bereiten nur den Produktstart vor; Produktcode braucht eigenen Auftrag.
LH-01 bleibt Einzelpilot außerhalb Serienauswahl. LH-02 braucht eigenen Auftrag
und fachlichen LH-01-Abschluss. Volle LH-00-Abnahme nach LH-02/vor LH-03 offen.
Reale Terminals/Screenreader Deferred, Braillehardware Excluded gemäß Ownergrund;
keine Konformität oder vollständige Abnahme behaupten.

LH-01 is authored and technically planned. Separate evidence-based choices are
managed C#14, host .NET10, Terminal.Gui2.5.0 explicit dotnet without ANSI fallback,
minimum PS7.6.4 and in-process PSCmdlet. Linked ADRs/readiness retain native and
practical limits. Readiness tasks grant no product execution. Preserve standalone
pilot, separate LH-02 authority/completion and full LH-00 acceptance order.
Physical terminals/screen readers remain Deferred; Braille hardware Excluded with
owner rationale. Never claim conformity or complete acceptance.
