# Lastenheft-Governance / Intake governance

Stand / Date: 2026-10-01. Owner: Thorsten Hindermann.
Dokumentationsentscheidung / Documentation decision: **UpdateRequired**.

## Zweck und Geltung / Purpose and applicability

Diese Zuordnung verbindet die Level-2-Regeln mit den Lastenheften LH-00 bis
LH-07. Ein Intake ist ein fachliches Lastenheft. Ein Receipt bindet Inhalt und
Quellen über SHA-256-Prüfsummen. Ein Review prüft die fachliche Qualität getrennt
von der Erstellung. Es gibt noch keine Produktimplementierung oder Produktabnahme.
Die Erstellung von LH-00 setzt nur das minimale Authoring-Profil um; die
vollständige Umsetzung seiner Prozessanforderungen folgt später.

This mapping connects Level-2 rules to LH-00 through LH-07. An intake is a
requirements document. A receipt binds content and sources with SHA-256 hashes.
A review assesses requirements separately from authoring. No product implementation
or product acceptance exists. Creating LH-00 establishes only the minimal
authoring profile; full implementation of its process requirements follows later.

Verbindliche Quellen sind die [Constitution](../constitution.md),
[Agenten-Guidance](../AGENTS.md), das [Bedienkonzept](Bedienkonzept.md),
die [Reihenfolge](Lastenheft-Plan.md), [Entwicklungsumgebung](Entwicklungsumgebung.md),
[Sicherheitsanwendbarkeit](security/README.md),
[Dokumentations-Governance](documentation-governance.md), die
[Presetmatrix](../scripts/config/spec-kit-project-statistics-governance-presets.json)
und das [Authoring-Profil](../.specify/memory/intake-authoring-profile.md).
Die Issues ergänzen fachliche Eingaben; sie setzen diese Regeln nicht außer Kraft.

The linked constitution, agent guidance, interaction concept, order, development
environment, security applicability, documentation rules, preset matrix and
authoring profile are binding. Issues provide domain input; they do not suspend
these rules.

## Zuordnung / Mapping

Für jede Zeile gilt: fachlicher Owner ist Thorsten; Autor und lokaler Prüfer ist
der ausführende Agent. Der davon getrennte Reviewer ist im
[aktuellen Reviewnachweis](../specs/intake-review-result.json) benannt;
[Entscheidung IAD009](planning/lh00-repair-decisions.md) verlangt einen anderen Prüfer.
`Applicable` bedeutet anwendbar, `Open` einen offenen Nachweis; beides bedeutet
noch nicht erfüllt. Umsetzungsstatus der späteren Prozessanforderungen:
`Not Assessed`, bis ein benannter Nachweis vorliegt. Lokale Authoring-Prüfungen
stehen getrennt im [Validierungsbericht](lh00-validation.md).

For every row, Thorsten is the subject owner and the executing agent is the
author and local checker. The current review evidence names a different reviewer,
as required by decision IAD009. Applicable means
in scope; Open means evidence is outstanding. Neither means fulfilled. Later
process requirements remain Not Assessed until named evidence exists. Local
authoring checks are recorded separately in the linked validation report.

| ID | Quelle / Source | Regel und betroffene Lastenhefte / Rule and intakes | LH-00 FR → AC | Nachweis / Evidence |
|---|---|---|---|---|
| G01 | Constitution VIII, X | Applicable: DE/EN, CEFR B2, Begriffserklärungen; alle / bilingual content, readable terms; all | 005 → 004 | Sprachvergleich gleicher IDs / language comparison for matching IDs |
| G02 | Constitution VII | Applicable: textuelle Status, Tastatur, Screenreader, Braille, Textbrowser; alle / text status and assistive access; all | 006 → 005 | Dokumentprüfung; spätere assistive Prozess- und Produkttests offen / document check; later assistive process and product tests open |
| G03 | Constitution I, XII, XIV–XV; security/README | Applicable: NIST SSDF, CWE Top 25, Eingaben und sichere Defaults; alle / inputs and secure defaults; all | 007 → 005 | Secret-Scan, Anwendbarkeit, spätere Bedrohungs-/Fehlerfälle / secret scan, applicability, later threat/failure cases |
| G04 | Constitution II, X | Applicable: Plattformnachweise getrennt; alle / separate platform evidence; all | 010 → 008 | Mac A, Mac B, Windows 11, WSL2; genaue Versionen und Grenzen / exact versions and boundaries |
| G05 | Constitution IX, XX | Applicable: fünf gleiche Guidance-Dateien, zwei Constitution-Kopien, Leserpfade; alle / guidance parity and reader paths; all | 007, 012 → 005, 009 | Hashvergleich, Links, zentraler Vorschlag / hash comparison, links, central proposal |
| G06 | Authoring 0.3.6, Policy | Applicable: Quellen-/Zielhashes, UTF-8, HTTPS-Regeln, Überschreibschutz; alle / source and target integrity; all | 008 → 006 | Bash- und PowerShell-Receiptprüfung / both receipt validators |
| G07 | Review 0.2.4; Constitution Governance | Applicable: Authoring ≠ Review ≠ Laufauftrag; alle / separate authoring, review and execution; all | 009 → 007 | Status-/Prompt-Prüfung; [aktuelles Review / current review](../specs/intake-review-report.md) |
| G08 | Lastenheft-Plan; Sequencing 0.2.7 | Applicable: IDs, Abhängigkeiten, Reihenfolge; alle / identity, dependencies, order; all | 004, 011 → 009 | Reihenfolgetabelle jetzt, validierte Collection/Serie später / order table now, validated collection/series later |
| G09 | Constitution VI; Statistikprofil 2 | Applicable: chronologisches Ledger, Gesamtstatistik zuletzt; alle Arbeitspakete / chronological ledger and final overall statistics; all work packages | 007 → 005 | Ledger, Renderer; keine Zeit-/Qualitätsbehauptung / ledger, renderer; no time or quality claim |
| G10 | Constitution Mermaid/Abschlussbericht | Applicable: hilfreiche Abläufe mit Mermaid und Text; alle / useful flows with Mermaid and equivalent text; all | 006 → 005 | Lesbarer Quelltext und Textablauf; kein Feature-Abschlussbericht durch Authoring / readable diagram and text; authoring is not a completed feature run |
| G11 | Constitution XVI–XIX; security/README | Applicable: weitere Standards einordnen; alle / classify other standards; all | 007 → 005 | Begründete N/A/Open-Einträge, Re-Evaluation bei Architektur/Release / justified N/A/Open records, reevaluate at architecture/release |
| G12 | Constitution XX; Owner-Plan | Applicable: Lieferstand und Restarbeiten ehrlich ausweisen; alle / state delivery status and remaining work honestly; all | 012 → 009 | [Issue-Veröffentlichung / issue publication](issue-publication.md), Übersetzungsinventar, zentraler Patchvorschlag / translation inventory, central patch proposal |

Für LH-01 bis LH-07 werden diese Zeilen jeweils durch QG-NN-001 bis QG-NN-005
gebunden; AC-NN-004 ergänzt einen fachbezogenen A11Y-Fall, AC-NN-005 prüft Sprache
und Zuordnung. Das ersetzt keine spätere fachliche Ergänzung von Security- oder
Laufzeitfällen. Die ursprünglichen FR-/AC-/OD-IDs bleiben erhalten.

For LH-01 through LH-07, QG-NN-001 through QG-NN-005 bind these rows.
AC-NN-004 adds a domain-specific accessibility case; AC-NN-005 checks languages
and mapping. Later security and runtime cases still need domain detail.
Original FR/AC/OD identifiers are preserved.

## Anwendbarkeit und Nachweisgrenzen / Applicability and proof boundaries

NIST SSDF und CWE Top 25 gelten bereits für Governance-Arbeit. ASVS ist hier
N/A (kein Web-/HTTP-/API-Produktdienst), Produkt-SBOM/VEX/Release-Provenance
N/A (kein auslieferbares Produkt), AI-SBOM N/A (keine KI-Produktkomponente).
Diese N/A-Einträge haben Umsetzungsstatus `Not Assessed`, keine bestandene Prüfung.
Die vorhandene Paketbindung von Authoring ist begrenzte Tooling-Evidence.
Threat Model, S-ADRs, arc42, Abhängigkeitsprüfung und Sicherheitsqualitätsfälle
bleiben für die spätere Architektur/Implementierung offen. Cloud-/Zero-Trust-
und regulatorische Anwendbarkeit werden gemäß Sicherheitsübersicht erneut
bewertet; Entwicklung auf GitHub allein macht das Projekt nicht zum Cloudprodukt.

NIST SSDF and CWE Top 25 already apply to governance work. ASVS is N/A here
(no web/HTTP/API product service); product SBOM/VEX/release provenance is N/A
(no distributable product), and AI-SBOM is N/A (no AI product component).
Implementation status for N/A is Not Assessed, not a passed check. Authoring
package binding is limited tooling evidence. Threat modeling, security decisions,
arc42, dependency audits and security quality cases remain open for architecture
and implementation. Reassess cloud/Zero Trust and regulatory applicability under
the security overview; GitHub development alone does not create a cloud product.

## Sprachänderung und zentrale Quelle / Language change and central source

Die bisherige Deutsch-Ausnahme in AGENTS und der Projektregisterzeile widersprach
der allgemeinen Zweisprachigkeit und Nichtabschwächung in Constitution VIII/X.
Der angenommene Plan hebt diese Ausnahme ausdrücklich auf (IAD003). Die lokalen
Dateien werden gemeinsam ausgerichtet. Die gemeinsame Constitution-Version
1.22.0 bleibt erhalten; es wird keine neue globale Regel erfunden.

The earlier German-only exception in agent guidance and the project registry
conflicted with bilingual delivery and non-weakening rules in Constitution
VIII/X. The approved plan explicitly removes it (IAD003). Local files are aligned
together. Shared constitution version 1.22.0 is retained; no new global rule is
invented.

Der [Level-0-Patchvorschlag](proposals/level0-show-commandtui400-language.patch)
ändert nur die Dokumentationszelle der Show-CommandTui400-Zeile in beiden zentralen
Constitution-Kopien. Er ist nicht angewendet. Vor einer späteren Lieferung die
Basis erneut vergleichen und `git apply --check` in der kanonischen Quelle
ausführen; keinen anderen Stand blind überschreiben. Der vorgeschlagene Inhalt
ist derselbe wie in der lokalen Registerzeile. Flottenprofile bleiben unverändert.
Geprüfte zentrale Basis / Checked central base:
`a580fec0d9c7f70bc4b5fae4d8ed8df97b036843`.

The linked Level-0 patch proposal changes only this project's documentation cell
in both central constitution copies. It is not applied. Before later delivery,
compare the base again and run git apply --check in the canonical source; never
overwrite a different state blindly. Proposed wording matches the local project
row. Fleet profiles are unchanged.

## Übersetzungsinventar und Restarbeiten / Translation inventory and follow-ups

Owner aller FU-Einträge: Thorsten. Der aktuelle Intake-Reviewer steht im
Reviewnachweis; die spätere Prozessabnahme braucht weiterhin einen benannten Prüfer. Frist: vor LH-00-Prozessabnahme und vor öffentlicher
Behauptung vollständiger DE/EN-Konformität. Wiedervorlage zur Planung:
2026-10-12, keine eingerichtete Erinnerung. Das sind geplante Nachweise,
keine bereits abgeschlossenen Arbeiten. Der Owner hat die Begrenzung durch
Annahme dieses Plans bestätigt; es entsteht keine allgemeine A11Y-/Security-Ausnahme.

Thorsten owns all follow-ups. Current intake evidence names its reviewer; later
process acceptance still needs a named reviewer. Due before LH-00 process acceptance and any public claim of complete
bilingual conformity. Planning re-evaluation date: 2026-10-12; no reminder has
been scheduled. These are planned checks, not completed work. The owner accepted
this scope boundary with the plan; it creates no general accessibility or
security exception.

| ID | Artefakt / Artefact | Entscheidung, Risiko und Nachweis / Decision, risk and evidence |
|---|---|---|
| FU01 | [Bedienkonzept](Bedienkonzept.md) | FollowUp: deutsche fachliche Baseline unverändert; englischer Zugang unvollständig. Übersetzung und Bedeutungsabgleich vor Prozessabnahme. / German domain baseline preserved; English access incomplete. Translate and check meaning before process acceptance. |
| FU02 | [Repository-Einstellungen](Repository-Einstellungen.md) | FollowUp: aktuelle deutsche Anleitung; englischer Leserpfad offen. Live-Einstellungen bei Übersetzung erneut prüfen. / Current German guide; English reader path pending. Recheck live settings during translation. |
| FU03 | [Sicherheitsübersicht](security/README.md) | FollowUp: deutsche Anwendbarkeitsübersicht bleibt als Quelle; englische Zusammenfassung oben mindert, beseitigt aber nicht die Sprachlücke. Vollständigen Sprachpartner prüfen. / German applicability source retained; summary above reduces but does not remove the gap. Check a full language partner. |
| FU04 | [Einrichtungsnachweis v0.3.5](maintenance/intake-authoring-v035.md) | Historische Evidence erhalten; keine rückwirkende Umdeutung. Bei Bedarf erläuterte Übersetzung als Partner ergänzen. / Preserve historical evidence without rewriting decisions; add an explained translation partner if needed. |
| FU05 | Zentrales Register / Central registry | FollowUp: lokaler Patch vorhanden, zentrale Übernahme offen; bis dahin Governance-Drift sichtbar halten. / Local patch prepared, central adoption pending; keep drift visible until then. |
| FU06 | Issues 1–8 | Ursprüngliche Grundlage veröffentlicht und [nachgewiesen](issue-publication.md). Weitere Änderungen, einschließlich Issue-1-Reparatur, vor Veröffentlichung erneut vergleichen und separat nachweisen. / Original input published and evidenced. Compare later changes, including the Issue 1 repair, again before publication and record separate evidence. |
| FU07 | PowerShell-Prozess / PowerShell process | FollowUp: Versionen, Basisskripte und Ende-zu-Ende-Nachweise auf vier Umgebungen offen. / Versions, base scripts and end-to-end evidence remain open on four environments. |

Wiederverwendete Home-Baseline-Dokumente, Manpages und Preset-Templates behalten
ihre kanonische Herkunft und bestehende Sprachstrategie; keine pauschale
Übersetzung fremder Vorlagen. README, Entwicklungsumgebung, Lastenheft-Plan,
Profil, Zuordnung, Entscheidungen, neue Issue-Entwürfe und LH-00 werden in diesem
Arbeitspaket zweisprachig gepflegt.

Reused Home Baseline documents, man pages and preset templates retain their
canonical origin and language strategy; no blanket translation of upstream
templates. This work maintains bilingual README, development environment,
intake order, profile, mapping, decisions, new issue drafts and LH-00.

## Dokumentationsauswirkung / Documentation impact

UpdateRequired für Authoring sowie beauftragte Reparatur und Reviewnachweise. Zielgruppen: Owner, Autoren,
spätere Implementierende und Lernende ohne Spec-Kit-Vorkenntnisse. Leserpfad:
README → Entwicklungsumgebung → Zuordnung/Profil → LH-00 → separates Review.
Kanonische Quelle: gemeinsame Level-0-Prinzipien plus Level-2-Fachlichkeit.
Klasse: `sourceOnly`; keine Home-Runtime-Distribution. Sprache: DE/EN in derselben
Datei. Plattformgrenze: lokale Strukturprüfung, keine assistive Feldabnahme.
Re-Evaluation bei Policy-, Quellen-, Plattform-, Architektur- oder Releaseänderung.

UpdateRequired applies to authoring and the authorized repair and review evidence. Audiences: owner, authors, later
implementers and learners without Spec Kit experience. Reader path: README →
development environment → mapping/profile → LH-00 → separate review. Sources:
shared Level-0 principles and Level-2 domain truth. Distribution: sourceOnly,
no Home Runtime deployment. Languages: DE/EN in the same file. Platform boundary:
local structural validation, no assistive field acceptance. Reevaluate when
policy, sources, platforms, architecture or release scope changes.

## Abnahmestufen und Pilotfreigabe / Acceptance stages and pilot permission

[IAD010](planning/lh00-staged-acceptance-decisions.md) ergänzt den Zeitpunkt der
bestehenden Nachweise. Erst Kernprozess auf dem benannten primären Mac;
danach getrennt beauftragte Einzelpiloten LH-01 und LH-02 mit gültigen Intakes
und unabhängigen Reviews außerhalb der automatischen Serienauswahl. LH-02
setzt den fachlichen Abschluss von LH-01 voraus. Prozessfehler und Korrekturen
stehen im LH-00-Nachweis, Feature-Abnahmen getrennt. LH-00 bleibt offen.
Alle vier Plattformnachweise, A11Y, FU01–FU07 einschließlich Übersetzungen und
angewendeter zentraler Registerausrichtung sind zur vollständigen Abnahme nach
LH-02 und vor LH-03 zu erledigen; bisherige frühere Fälligkeiten und Wiedervorlagen
bleiben erhalten. Weder lokale Werkzeugtests noch Pilotfreigabe erfüllen diese
Gesamtabnahme. Owner Thorsten bewertet die Stufen; der Reviewer ist ein anderer
Agent oder Mensch als der Autor. Eine Statusänderung benötigt eigene Autorität.

IAD010 adds timing to existing evidence requirements. First prove the core process
on the named primary Mac; then separately commission LH-01 and LH-02 standalone
pilots with valid intakes and independent reviews, outside automatic series
selection. LH-02 requires domain completion of LH-01. Record process failures and
fixes in LH-00 evidence, separate from feature acceptance. LH-00 remains open.
All four platform records, accessibility and FU01–FU07 including translations and
applied central registry alignment must be completed for full acceptance after
LH-02 and before LH-03; existing earlier deadlines and reassessment dates remain.
Local tool tests and pilot permission do not satisfy full acceptance. Owner
Thorsten assesses the stages; the reviewer is an agent or person other than the
author. A status change requires separate authority.
