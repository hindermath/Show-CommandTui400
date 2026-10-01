# Specify-Nachweis und Anwendbarkeit / Specify evidence and applicability

Historischer Nachweis des unten datierten Laufs. Die damaligen Input-Hashes
bleiben erhalten; das Update vom 2026-10-01 und sein unabhängiges Review stehen
im aktuellen [Receipt](../../intake-authoring-receipts/lh-00.json) und
[Reviewbericht](../../intake-review-report.md).

Historical evidence of the dated run below. Its input hashes are preserved;
the 2026-10-01 update and independent review are recorded in the current receipt
and review report linked above.


**Datum / Date:** 2026-09-29. **Feature:** [LH-00-Prozess / LH-00 process](../spec.md).
**Umfang / Scope:** lokale Spezifikation und Checklisten / local specification and checklists.

Ein Nachweis belegt nur die ausdrücklich genannte Prüfung. `Applicable` heißt
anwendbar, `N/A` nicht anwendbar und `Open` noch zu klären. Davon getrennt stehen
`Fulfilled` (im genannten Umfang erfüllt), `Partly Fulfilled` (teilweise erfüllt),
`Not Fulfilled` (nicht erfüllt) und `Not Assessed` (nicht geprüft). N/A hat stets
`Not Assessed`. Für jede nachfolgende Zeile gilt: **Owner Thorsten Hindermann**;
**Autor und lokaler Prüfer: ausführender Codex-Agent**, kein unabhängiges
Spezifikationsreview. Für spätere Prozessnachweise benennt der Owner einen
anderen Reviewer als den Autor. Dessen fehlende Benennung ist ein offener
Abnahmepunkt, kein bestandener Test. Risikoannahme bleibt einem Menschen vorbehalten.

Evidence proves only its named check. Applicable means in scope, N/A means not
applicable and Open means undecided. Fulfilled, Partly Fulfilled, Not Fulfilled
and Not Assessed describe fulfillment separately. N/A always has Not Assessed.
For every row below, **Thorsten Hindermann is the owner** and the **executing
Codex agent is author and local checker**, not an independent specification
reviewer. The owner must appoint a reviewer other than the author for later
process evidence. Missing appointment is an open acceptance item, not a passed
test. Risk acceptance remains a human decision.

## Eingangsprüfung / Input preflight

- [x] Ausschließlich LH-00 als fachlichen Input verwendet / Used only LH-00 as domain input.
- [x] Profil `show-commandtui400-de-en` und geltende Projektregeln geprüft / Checked the profile and applicable project rules.
- [x] Aktuelles Receipt validiert und Zielbindung verglichen / Validated current receipt and compared its target binding.
- [x] Aktuelles Review validiert; Status `Ready`, keine Befunde, keine akzeptierten Risiken / Validated current review: Ready, no findings, no accepted risks.
- [x] Alle gebundenen Review-Ziele, Policy-, Quellen-, Vorgänger- und Auftragsnachweise lokal nachgehasht / Rehashed all bound review targets, policy, sources, predecessor and request evidence locally.
- [x] Unabhängigkeit des bestehenden Intake-Reviews belegt: anderer Agent gemäß IAD009 / Existing intake review independence evidenced: another agent under IAD009.

**Identitäten / Identities**

| Artefakt / Artifact | Identität / Identity | Normalisierter SHA-256 / Normalized SHA-256 |
|---|---|---|
| `intakes/LH-00.md` | Intake `2296d99d-f099-4c4d-88f7-789581693eb0` | `680baafd7534db9386f91a43cdbe3dbf260d6c0620c9f506c2be59ec3c826a65` |
| `specs/intake-authoring-receipts/lh-00.json` | Receipt `a627d004-b189-43df-b061-27e30a0e6a37` | `d1fd29c39875ce40c32e9d386d592a3dc852989bd5e0db6311eb096182d2d4dd` |
| `specs/intake-review-result.json` | Review `c22c0fcd-610a-4a77-8f8d-59e504efc113` | `d092921734b535572165716a83b392144a8275f34f878d302cdc96a46ad8a5d3` |

Normalisierung: UTF-8 ohne führende Byte-Reihenfolgemarke, einheitliche LF-Zeilenenden.
Der heutige HEAD war `b299b64de68ae8794cd8b4199eba338762e5e651`.
Das Review nennt seine historische Prüfbase; Aktualität beruht auf den weiterhin
passenden Inhaltsbindungen, nicht auf Gleichheit dieser beiden Commit-IDs.
Keine Remote-Quelle wurde neu eingelesen oder geschrieben. Die Input-Nachweise
wurden nicht umgeschrieben, und dies ist kein erneutes Intake-Review.

Normalization uses UTF-8 without a leading byte-order mark and LF line endings.
Today's HEAD was b299b64de68ae8794cd8b4199eba338762e5e651. The review records its
historical review base; freshness relies on matching content bindings, not on
these commit IDs being identical. No remote source was reread or written.
Input evidence was not rewritten; this is not another intake review.

Ausgeführte lesende Eingangsprüfungen, jeweils Exitcode 0 / Read-only preflight
commands executed, each with exit code 0:

```bash
bash .specify/presets/intake-authoring-governance/scripts/validate-intake-authoring-receipt.sh --receipt specs/intake-authoring-receipts/lh-00.json --repo .
bash .specify/presets/intake-review-governance/scripts/validate-intake-review-result.sh --result specs/intake-review-result.json --repo .
```

Diese zwei Kommandos prüfen Receipt und Review. Sie sind nicht die beiden
Bash-/PowerShell-Receipt-Prüfungen der späteren AC-00-006-Abnahme; deren Anforderung
bleibt erhalten. Der Hashvergleich umfasst zusätzlich alle im Review gebundenen
Dateien. Bestehendes Review: [Ergebnis / result](../../intake-review-result.json)
und [Bericht / report](../../intake-review-report.md).

These two commands check the receipt and review. They are not the two
Bash/PowerShell receipt checks required for later AC-00-006 acceptance; that
requirement remains. The additional hash check covers all review-bound files.
The linked result and report identify the existing review.

## Vorlage und lokale Zuordnung / Template and local selection

Die aufgelöste Vorlage wurde zuerst nach `spec.md` kopiert und dann ausgefüllt.
Die Zusammensetzung verwendet die Projektvorlage und folgende Anhänge in dieser
Reihenfolge: Autonomous Run, Agent Parity, Cross Platform, A11Y, iSAQB Architecture,
Architecture, Security. Alle vorgeschriebenen Abschnittsgruppen bleiben in dieser
Reihenfolge erhalten, mit DE/EN-Überschriften. SHA-256 der aufgelösten Ausgangsvorlage:
`ddfb8b3019d70ee68a6d1d17232608f2e3639125b9303b5278900be0629b07e0`.

The resolved template was first copied to spec.md and then completed. Composition
uses the project template followed by the listed addenda in that order. All
required section groups keep this order with DE/EN headings. The checksum above
identifies the resolved starting template.

Der erste Shell-Auflösungsversuch meldete fehlendes PyYAML und wurde vor jeder
Dateierstellung verworfen. Die erfolgreiche Auflösung verwendete die bereits
installierte Specify-Python-Umgebung mit YAML-Unterstützung; keine Installation
oder Werkzeugreparatur. `.specify/feature.json` verweist auf
`specs/001-lh00-intake-process`. Kein Branch-Hook und kein Commit-Hook:
`.specify/extensions.yml` existierte bei Vor- und Nachprüfung nicht.

The first shell-resolution attempt reported missing PyYAML and was discarded
before creating files. Successful resolution used the already installed Specify
Python environment with YAML support; nothing was installed or repaired.
The feature metadata selects specs/001-lh00-intake-process. There was no branch
or commit hook: extensions.yml was absent at both pre- and post-check.

## Prüfpunkte und verbleibende Nachweise / Checkpoints and remaining evidence

Die Erfüllung bewertet nur den genannten Specify-Umfang. Die zukünftige
Prozessumsetzung ist insgesamt `Not Assessed`. Quellen sind die in der
[Spezifikation](../spec.md) verlinkten Constitution, Policy, Profil und LH-00;
vorhandene Projektbelege bleiben unter ihren kanonischen Pfaden.

Fulfillment assesses only the named Specify scope. Future process implementation
is overall Not Assessed. Sources are the constitution, policy, profile and LH-00
linked in the specification; existing project evidence keeps its canonical paths.

| ID / Prüfung / Check | Anwendbarkeit / Applicability | Erfüllung / Fulfillment | Grund, Beleg und Restrisiko / Rationale, evidence and residual risk | Folgearbeit und Auslöser / Follow-up and trigger |
|---|---|---|---|---|
| G-INPUT – Input-Bindung / Input binding | Applicable | Fulfilled | Vorprüfung oben, unveränderte Hashes; nur lokaler gebundener Stand / Preflight above, unchanged hashes; bound local state only. | Bei Quellen-/Zieländerung erneut prüfen / Revalidate when sources or target change. |
| G-LANGUAGE – DE/EN, B2 | Applicable | Fulfilled | Normative Tabellen und Abschnitte der Spezifikation semantisch verglichen; kein externes Sprachzertifikat / Semantic comparison of normative tables and sections; no external language certification. | Bei Textänderung Parität erneut prüfen / Recheck parity after edits. |
| G-A11Y – Text und Hilfsmittel / Text and assistive access | Applicable | Partly Fulfilled | Überschriften, Textzustände, Diagrammalternative geprüft; reale Hilfsmittel-/Renderer-Prüfung offen / Headings, text states and diagram alternative checked; actual assistive/renderer checks open. | Bei Prozessumsetzung `docs/accessibility/` ergänzen, vor Abnahme prüfen / Add accessibility evidence during process implementation; verify before acceptance. |
| G-AGENT – fünf Flächen, zwei Kopien / Five surfaces, two copies | Applicable | Fulfilled | Keine Änderung; Gleichheit der fünf Guidance- und zwei Constitution-Dateien geprüft / Unchanged; equality of five guidance and two constitution files checked. | Bei gemeinsamen Regeländerungen alle Flächen synchronisieren / Synchronize all surfaces on shared-rule changes. |
| G-PLATFORM – vier Umgebungen / Four environments | Applicable | Not Assessed | FR-019/020 und US-06; hier nur lokale Dokumentarbeit, kein End-to-End-Prozesslauf / FR-019/020 and US-06; local document work only, no end-to-end process run. | E06 vor Prozessabnahme auf Mac A/B, Windows und WSL2 erbringen / Produce E06 on all four environments before process acceptance. |
| G-TOOLS – neue Skriptwerkzeuge / New script tools | Open | Not Assessed | Werkzeugbedarf, konkreter Verb-Noun-Name und Manpage offen; keine Skripte geändert / Tool need, concrete Verb-Noun name and man page open; no script changes. | Bei Plan entscheiden; bei neuen/geänderten Werkzeugen Bash/PowerShell, Hilfe und Vorschau gleichwertig / Decide in Plan; new/changed tools need equivalent Bash/PowerShell, help and preview. |
| G-ARCH – Prozessarchitektur / Process architecture | Applicable | Partly Fulfilled | Kontext und Qualitätsszenarien beschrieben; keine Detailarchitektur oder ADR beschlossen / Context and quality scenarios described; no detailed architecture or ADR selected. | Plan: Kontext, Collection-/Bestandsentscheidung unter `docs/architecture/` / Plan: context and collection/inventory decision under docs/architecture. |
| G-SECARCH – Vertrauensgrenzen / Trust boundaries | Applicable | Partly Fulfilled | Grenzen und Schutzbedarf spezifiziert; Maßnahmen noch nicht implementiert/geprüft / Boundaries and protection needs specified; mitigations not implemented/tested. | Plan: STRIDE/CIA, relevante CAPEC, ggf. S-ADR/arc42; vor Umsetzung / Plan: STRIDE/CIA, relevant CAPEC, possible S-ADR/arc42 before implementation. |
| G-SSDF – NIST SSDF | Applicable | Partly Fulfilled | Quellen-, Scope-, Nachweis- und Berechtigungsgrenzen geprüft; keine vollständige SSDF-Abnahme / Source, scope, evidence and authority boundaries checked; no full SSDF acceptance. | Bei Plan/Umsetzung Sicherheitscheckliste und negative Fälle / Security checklist and negative cases at Plan/implementation. |
| G-CWE – CWE Top 25 | Applicable | Partly Fulfilled | Kein neuer ausführbarer Code; Secret-Scan und Anforderungen zu Eingaben, Pfaden, Schutz vorhanden / No new executable code; secret scan and input/path/protection requirements present. | Neue Logik auf tatsächlich betroffene Schwächen prüfen / Check new logic against actually affected weaknesses. |
| G-MSL – Sprache / Language | Open | Not Assessed | Projektwert `unknown`; keine Sprachwahl aus Workspace oder Dokumentformat / Project value unknown; no language inferred from workspace or document format. | Bei Implementierungsplanung Sprache und Speichersicherheit begründen / Justify language and memory safety at implementation planning. |
| G-CODING – Sprachregeln und Kommentare / Language rules and comments | N/A | Not Assessed | Keine neue Programmlogik / No new program logic. | Bei neuem Code sichere Sprachregeln und erklärende Kommentare / Apply secure language rules and explanatory comments for new code. |
| G-ASVS – Web-Verifikation / Web verification | N/A | Not Assessed | Kein Web-/API-/HTTP-/Auth-Dienst in diesem Schritt / No web/API/HTTP/auth service in this step. | Bei solchem Dienst ASVS-Niveau und Verifikation festlegen / Select ASVS level and verification if such a service is introduced. |
| G-SBOM – SBOM, VEX, SLSA | N/A | Not Assessed | Keine neue auslieferbare Software oder Build-/Releaseänderung; Dokumente allein sind keine Produktlieferung / No new distributable software or build/release change; documents alone are no product delivery. | Bei Paket-/Release-/Buildänderung Supply-Chain-Nachweis / Supply-chain evidence on package/release/build changes. |
| G-AI – AI-SBOM | N/A | Not Assessed | KI nur Entwicklungswerkzeug, keine Laufzeitkomponente / AI is development tooling only, no runtime component. | Bei KI-Laufzeit oder Produktdaten Modell-/Komponentenherkunft prüfen / Assess model/component provenance for AI runtime or product data. |
| G-DEPS – Abhängigkeiten, OpenSSF / Dependencies, OpenSSF | Applicable | Not Assessed | Öffentliches Projekt; keine neue Abhängigkeit, kein neuer Score oder Audit behauptet / Public project; no new dependency, score or audit claimed. | Bei Werkzeugänderung/Übernahme und periodischem Prüfanlass `dependency-audit.md` / Dependency audit on tool change/adoption and periodic assessment trigger. |
| G-ZERO – Zero Trust | N/A | Not Assessed | Keine Änderung entfernter Dienste oder verteilter Architektur in diesem Specify-Schritt / No remote-service or distributed-architecture change in this Specify step. | Bei neuen Remote-/Service-Flüssen Anwendbarkeit neu bewerten / Reassess for new remote/service flows. |
| G-CLOUD – BSI C3A/C5 | N/A | Not Assessed | Kein Cloud-Betrieb oder Hostingwechsel; bestehende GitHub-Nutzung wählt kein Cloudprodukt / No cloud operation or hosting change; existing GitHub use selects no cloud product. | Bei Cloud-/Provider-/Hostingentscheidung beide Prüfgebiete bewerten / Assess both areas for cloud/provider/hosting decisions. |
| G-SAMM – Prozessreife / Process maturity | Applicable | Not Assessed | Bestehender Reifegradkontext, kein Assessment in diesem Schritt / Existing maturity context; no assessment in this step. | Bei periodischem Review oder Prozessänderung `samm-assessment.md` / SAMM assessment at periodic review or process change. |
| G-REG – NIS2, CRA, EU AI Act, DORA | Open | Not Assessed | Projektanwendbarkeit offen; kein neuer regulatorischer Auslöser durch lokale Spezifikation / Project applicability open; local specification creates no new regulatory trigger. | Vor Markt-/Kundenrelease, Cloud-/KI-Betrieb oder regulierter Nutzung bewerten / Assess before market/customer release, cloud/AI operation or regulated use. |
| G-AUTHOR – Quellen und Änderungen / Sources and changes | Applicable | Partly Fulfilled | Receipt aktuell; FR-014–016 definieren Schutz, späterer Prozess noch ungeprüft / Receipt is current; FR-014–016 define protection, later process untested. | E04 bei Prozessumsetzung: beide Receipt-Validatoren und kontrollierte Negativfälle / E04 at implementation: both receipt validators and controlled negative cases. |
| G-REVIEW – unabhängige Prüfung / Independent review | Applicable | Partly Fulfilled | Bestehender Input hat anderes Review; FR-017/018 sichern Trennung. Spec lokal selbstgeprüft / Existing input has another reviewer; FR-017/018 preserve separation. Spec locally self-checked. | Bei geänderten Intakes neues beauftragtes Review; kein stiller Folgeauftrag / New authorized review for changed intakes; no implicit downstream request. |
| G-SERIES – Sammlung und Serie / Collection and series | Applicable | Not Assessed | FR-007/008/021/022; derzeit kein neu validierter Serienbestand / Requirements defined; no newly validated series inventory. | Plan konkretisiert Pfade/Modus; E07 vor Prozessabnahme / Plan defines paths/mode; E07 before process acceptance. |
| G-AUTO – autonome Läufe / Autonomous runs | N/A | Not Assessed | Einzelnes Specify, kein Laufzustand oder Delivery-Schema geändert / Single Specify; no run state or delivery schema change. | Bei gesondertem autonomen Auftrag Autorität/Gates/Zustand neu prüfen / Recheck authority/gates/state for a separate autonomous request. |
| G-ROUTING – Modellrouting / Model routing | N/A | Not Assessed | Direkter Specify-Schritt ohne delegierte Phase oder Routingänderung / Direct Specify step without delegated phase or routing changes. | Bei delegierten/autonomen Phasen Routing-Regeln prüfen / Check routing rules for delegated/autonomous phases. |
| G-ASSURANCE – Secure-Development-Gates | Open | Not Assessed | Noch kein Implementierungsplan; spätere Gate-Auswahl darf nicht vorgetäuscht werden / No implementation plan yet; do not invent future gate selection. | Im Plan passende Gates auswählen, vor Umsetzung/Abnahme Nachweise / Select suitable gates in Plan, evidence before implementation/acceptance. |
| G-DOCS – Dokumentation / Documentation | Applicable | Fulfilled | CR-013: `UpdateRequired`, Leserpfad und gleichsprachige Partner im Feature; Grenzen explizit / CR-013: UpdateRequired, feature reader path and language partners; explicit boundaries. | Bei späterer Lieferung README-Navigation und Ledger angleichen / Align README navigation and ledger at later delivery. |
| G-STATS – Statistik / Statistics | Applicable | Partly Fulfilled | Lokaler Arbeitspaketnachweis hier; keine Commits oder neu behaupteten Git-Zahlen / Local work-package evidence here; no commits or new claimed Git metrics. | Bei genehmigter Lieferung chronologischen Ledger fortschreiben, Renderer nutzen / Update chronological ledger and use renderer on authorized delivery. |
| G-CLOSE – Übersetzungen und zentrale Ausrichtung / Translations and central alignment | Applicable | Not Assessed | Bestehende FU01–FU07 bleiben maßgeblich; kein abgeschlossener zentraler Sync behauptet / Existing FU01–FU07 remain authoritative; no completed central sync claimed. | Offene Übersetzungen/Registeränderung vor Prozessabnahme gemäß FR-023/024 / Complete open translations/registry change before process acceptance under FR-023/024. |
| G-DIAGRAM – Diagramm und Abschluss / Diagram and closeout | Applicable | Fulfilled | Mermaid und gleichwertiger Text vorhanden; Einzelkommando löst keinen Feature-Abschlussbericht aus / Mermaid and equivalent text present; one command triggers no full-feature completion report. | Bei Ablaufänderung beide Darstellungen; Abschlussbericht erst nach vollem Feature-Lauf / Update both representations on flow changes; completion report only after a full feature run. |

## Vollständigkeit G01–G12 / G01–G12 completeness

Quellen und ursprüngliche FR/AC sind unverändert aus der gebundenen
[Governance-Zuordnung](../../../docs/intake-governance.md) übernommen.
Die Owner-/Prüferzuordnung und Erfüllungsgrenzen oben gelten für jede Zeile.

Sources and original FR/AC references are preserved from the bound governance
mapping. Owner/reviewer assignments and fulfillment boundaries above apply to
every row.

| Quelle / Source | Spezifikation / Specification | Quell-Abnahme / Source acceptance | Nachweis hier / Evidence here |
|---|---|---|---|
| G01 – Constitution VIII/X | FR-009/010 | AC-00-004 | G-LANGUAGE |
| G02 – Constitution VII | FR-011/012 | AC-00-005 | G-A11Y |
| G03 – Constitution I/XII/XIV/XV | FR-013 | AC-00-005 | G-SSDF, G-CWE, G-SECARCH |
| G04 – Constitution II/X | FR-019/020 | AC-00-008 | G-PLATFORM, G-TOOLS |
| G05 – Constitution IX/XX | FR-013/024 | AC-00-005/009 | G-AGENT, G-DOCS, G-CLOSE |
| G06 – Authoring 0.3.5, Policy | FR-014–016 | AC-00-006 | G-INPUT, G-AUTHOR |
| G07 – Review 0.2.3, Governance | FR-017/018 | AC-00-007 | G-REVIEW, G-AUTO |
| G08 – Lastenheft-Plan, Sequencing 0.2.6 | FR-007/008/021/022 | AC-00-009 | G-SERIES |
| G09 – Constitution VI, Profil 2 | FR-013 | AC-00-005 | G-STATS |
| G10 – Mermaid-/Abschlussregel / diagram/closeout rule | FR-011 | AC-00-005 | G-DIAGRAM |
| G11 – Constitution XVI–XIX | FR-013 | AC-00-005 | G-MSL bis G-REG / G-MSL through G-REG |
| G12 – Constitution XX, Owner-Plan | FR-023/024 | AC-00-009 | G-CLOSE |

## Installierte Presets und Anwendung / Installed presets and application

Die Versionen stammen aus der vorhandenen Projektmatrix; kein Upgrade oder
Installationslauf wurde beauftragt. Die Prüfpunkte oben begründen die Anwendung
in diesem Schritt und die später erforderliche Arbeit.

Versions come from the existing project matrix; no upgrade or installation run
was requested. Checkpoints above explain applicability to this step and later work.

| Preset | Version | Prüfpunkte / Checkpoints |
|---|---|---|
| `security-governance` | `v0.6.2` | G-SSDF, G-CWE, G-MSL–G-REG |
| `secure-development-assurance-governance` | `v0.1.3` | G-ASSURANCE |
| `architecture-governance` | `v0.5.2` | G-SECARCH |
| `isaqb-architecture-governance` | `v0.2.2` | G-ARCH |
| `a11y-governance` | `v0.4.3` | G-A11Y |
| `cross-platform-governance` | `v0.2.2` | G-PLATFORM, G-TOOLS |
| `agent-parity-governance` | `v0.4.2` | G-AGENT |
| `model-routing-governance` | `v0.1.4` | G-ROUTING |
| `intake-authoring-governance` | `v0.3.5` | G-AUTHOR, G-INPUT |
| `intake-review-governance` | `v0.2.3` | G-REVIEW |
| `intake-sequencing-governance` | `v0.2.6` | G-SERIES |
| `autonomous-run-governance` | `v0.4.4` | G-AUTO |
| `parallel-autonomous-run-governance` | `v0.2.6` | G-AUTO |
| `project-statistics-governance` | `v0.1.0` | G-STATS |

## Abschlussprüfung des ursprünglichen Specify-Schritts / Original Specify final checks

Alle folgenden Prüfungen bestanden am 2026-09-29. Sie prüfen den lokalen
Spezifikationsumfang; Prozessabnahme bleibt offen.

All following checks passed on 2026-09-29. They cover the local specification
scope; process acceptance remains open.

- [x] Feature-Metadaten, Vorlagenreihenfolge, sechs Auditabschnitte und DE/EN-Überschriften geprüft / Checked feature metadata, template order, six audit sections and DE/EN headings.
- [x] 24 Spezifikations-FR, zwölf Quell-FR, neun Quell-AC/SC, 14 CR, sieben Szenarien mit 14 Abnahmefällen und G01–G12 abgedeckt / Covered 24 specification requirements, twelve source requirements, nine source acceptance/success criteria, 14 constitution requirements, seven stories with 14 acceptance cases and G01–G12.
- [x] 16 Qualitätscheckpunkte, normative DE/EN-Parität, lokale Links, Textalternative und fehlende Platzhalter geprüft / Checked 16 quality items, normative DE/EN parity, local links, text alternative and absence of placeholders.
- [x] 26 gebundene Nachweise nachgehasht; Intake, Receipt und Review unverändert; beide Eingangsvalidatoren erneut Exitcode 0 / Rehashed 26 bound evidence entries; intake, receipt and review unchanged; both preflight validators again returned exit code 0.
- [x] Fünf Guidance-Dateien und zwei Constitution-Kopien weiterhin identisch / Five guidance files and two constitution copies remain identical.
- [x] `gitleaks dir` für Feature-Verzeichnis und Feature-Metadaten: Exitcode 0, keine Funde / Secret scans of feature directory and metadata: exit code 0, no findings.
- [x] `git diff --check` und Textstrukturprüfung neuer Dateien bestanden; HEAD, Index und bestehende Dateien unverändert / Git whitespace and new-file text checks passed; HEAD, index and existing files unchanged.
- [x] Nur vier neue lokale Dateien: Spezifikation, zwei Checklisten und `.specify/feature.json`; kein Plan, keine Tasks, Implementierung, Commit oder Remote-Schreibzugriff / Only four new local files: specification, two checklists and feature metadata; no plan, tasks, implementation, commit or remote write.

Produkt-Build-, Laufzeit-, Vier-Plattform- und assistive Tests wurden in diesem
Specify-Schritt nicht ausgeführt. Der Secret-Scan und die Dokumentprüfung
ersetzen diese Nachweise nicht. Nächste mögliche Phase ist ein gesondert
beauftragter Plan; keine wesentliche fachliche Klärungsfrage bleibt offen.

Product build, runtime, four-platform and assistive tests were not run in this
Specify step. Secret scanning and document checks do not replace that evidence.
The next possible phase is a separately requested Plan; no material domain
clarification question remains open.

## Lieferergänzung / Delivery addendum

**Auftrag / Authority:** Der Owner beauftragt anschließend ausdrücklich Commit,
Push und die Erstellung eines regulären PR. Diese Autorität ersetzt die lokale
Liefergrenze des ursprünglichen Specify-Schritts, ohne fachliche Anforderungen
oder Intake-Bindungen zu ändern. Kein Merge oder weiterer Spec-Kit-Schritt ist
Teil dieses Auftrags. Branch: `codex/lh00-process-spec`, Basis: `main`.

The owner subsequently explicitly requests commit, push and creation of a regular
PR. This authority supersedes the original Specify step's local delivery boundary
without changing domain requirements or intake bindings. No merge or further
Spec Kit step is part of this request. The branch is codex/lh00-process-spec,
based on main.

Dokumentationsauswirkung bleibt `UpdateRequired`: Der README-Einstieg führt nun
zur Spezifikation und ihren Checklisten; das Statistik-Ledger enthält das neue
Arbeitspaket chronologisch. Der vorhandene Renderer aktualisiert den generierten
Statistikblock auf Basis des versionierten Inhalts. Die Abschnitte zur ursprünglichen
Specify-Prüfung oben sind historische Nachweise dieses einzelnen Schritts.
G-DOCS und G-STATS bleiben dadurch nachvollziehbar; Plattform-/Prozessabnahme
wird durch die Lieferung nicht erfüllt.

Documentation impact remains UpdateRequired: README navigation now leads to the
specification and its checklists; the statistics ledger records the new work
package in chronological order. The existing renderer updates generated metrics
from versioned content. Original Specify check sections above are historical
evidence of that single step. This preserves traceability for G-DOCS and G-STATS;
delivery does not fulfill platform or process acceptance.

Die Lieferung ergänzt die Statistik-Konfiguration um eine explizite
Dokumentationszuordnung für `specs/001-lh00-intake-process/spec.md`.
Damit zählt die bestehende Dateinamen-Heuristik die Spezifikation nicht als
Testcode. Es wird kein Renderer-Code geändert; die Methodik erklärt die Zuordnung.

Delivery adds an explicit documentation category override for
specs/001-lh00-intake-process/spec.md. This prevents the existing filename
heuristic from counting the specification as test code. Renderer code remains
unchanged; the methodology explains the classification.
