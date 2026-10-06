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
| G06 | Authoring 0.3.7, Policy | Applicable: Quellen-/Zielhashes, UTF-8, HTTPS-Regeln, Überschreibschutz; alle / source and target integrity; all | 008 → 006 | Bash- und PowerShell-Receiptprüfung / both receipt validators |
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
Constitution-Kopien. Der Vorschlag ist seit 03.10.2026 im Level-0-Lieferbranch angewendet; Remote-Main-Übernahme bleibt bis zum PR-Merge offen. Siehe [Registrierungsnachweis](maintenance/registration-closeout-20261003.md). Vor einer späteren Lieferung die
Basis erneut vergleichen und `git apply --check` in der kanonischen Quelle
ausführen; keinen anderen Stand blind überschreiben. Der vorgeschlagene Inhalt
ist derselbe wie in der lokalen Registerzeile. Flottenprofile bleiben unverändert.
Geprüfte zentrale Basis / Checked central base:
`a580fec0d9c7f70bc4b5fae4d8ed8df97b036843`.

The linked Level-0 patch proposal changes only this project's documentation cell
in both central constitution copies. As of 2026-10-03 it is applied in the Level-0 delivery branch; remote main adoption awaits PR merge. See the [registration record](maintenance/registration-closeout-20261003.md). Before later delivery,
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
| FU05 | Zentrales Register / Central registry | Lokale zentrale Ausrichtung am 03.10.2026 umgesetzt; PR-Merge offen. [Nachweis](maintenance/registration-closeout-20261003.md). / Local central alignment completed on 2026-10-03; PR merge pending, see evidence. |
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

## Lokaler Create-Weg T001–T018 / Local creation route

**Stand / Date:** 2026-10-06. Diese Prozessquelle ist durch T032 lokal publiziert; ursprüngliche Stagingkopien
bleiben historisch. / This process source is published locally through T032;
original staging copies remain historical.
Thorsten ist fachlicher Owner, Codex Autor, ein anderer Agent oder Mensch prüft
später den Intake. Ein Issue ist eine Quelle, kein Auftrag. Der explizite Auftrag
nennt genau ein freies Ziel, Profil `show-commandtui400-de-en` und geordnete
Quellen. Vorhandene Ziele brauchen intake-update, niemals Create-Overwrite.
Thorsten owns requirements, Codex authors, and a different reviewer performs a
separate intake review. An issue supplies input; the explicit request names one
free target, the profile and ordered sources. Existing targets require intake-update.

Create liest ausschließlich benannte Quellen plus Governance, klärt Konflikte,
schreibt `intakes/LH-NN.md` und Schema-2.0-Receipt unter
`specs/intake-authoring-receipts/lh-nn.json`, bindet Quellen/Ziel und prüft beide
Shell-Validatoren. Ergebnis ReadyForReview ist nur Authoring-Bereitschaft.
Create reads named sources and governance, resolves conflicts, creates an intake
and schema-2.0 receipt, binds hashes and runs both validators. ReadyForReview
means authoring readiness only.

Pflichtinhalt (FR-006): Identität/Zielgruppe, Zweck, Ist-/Zielzustand, Scope,
Nicht-Ziele, atomare Anforderungen, Qualität, Governance, Abhängigkeiten, Risiken,
Artefakte, Nachweise, messbare Abnahme, Annahmen, Entscheidungen/offene Fragen
und zwei kopierfertige Folgeprompts. Deutsch zuerst, äquivalentes Englisch danach,
ungefähr B2; FR/AC/OD-IDs bleiben gleich. Baseline Bedienkonzept und verbindliche
Lastenheft-Reihenfolge gelten; NIST SSDF/CWE/WCAG2.2AA soweit passend.
Required content: identity/audience, purpose, current/target state, scope/non-goals,
atomic requirements, quality, governance, dependencies, risks, artifacts, evidence,
measurable acceptance, assumptions, decisions/questions and both follow-up prompts.
Use equivalent German-first/English-second B2 text and shared IDs. Preserve the
interaction baseline, intake order and applicable security/accessibility rules.

Die zwei Promptabschnitte binden exakt das neue Intake. Specify erlaubt nur
technische Spezifikation, keine Implementierung/Remote-Writes. Autonomous nennt
LocalImplementation und benötigt einen neuen ausdrücklichen Auftrag; kein Prompt
wird automatisch ausgeführt. Für das erste Inkrement liegt nur ein isoliertes
Test-Intake vor, keine zusätzliche aktive LH-Datei und keine reale Serienverwaltung.
Specify binds the exact intake and forbids implementation/remote writes. Autonomous
uses LocalImplementation and needs its own explicit request. Neither prompt runs
automatically; this increment creates only inactive isolated test data.

## Zwei Folgeprompt-Vorlagen / Two follow-up templates

Ein neues Ziel ersetzt im generierten Prompt exakt `intakes/LH-NN.md`; NN bleibt
hier eine Benennungsvorlage. Beide Vorlagen sind heute inaktiv. Fehlende oder
ungültige Review-Nachweise sperren den jeweiligen Folgeauftrag.
Generated prompts substitute the exact new intake path; NN is a naming template
here. Both remain inactive today; invalid review evidence blocks a later run.

```text
$speckit-specify intakes/LH-NN.md
Nutze ausschließlich das benannte Intake mit Profil show-commandtui400-de-en;
prüfe zuvor gültigen Receipt und unabhängiges Review. Nur technische Spezifikation,
DE zuerst/EN danach; keine Implementierung, Commits oder Remote-Writes.
Use only the named intake/profile after current receipt and independent review.
Specify only in DE/EN; no implementation, commits or remote writes.
```

```text
$speckit-autonomous intakes/LH-NN.md
Profil show-commandtui400-de-en; DeliveryMode LocalImplementation. Nur nach
neuem ausdrücklichem Auftrag und gültigen Receipt-/Review-Nachweisen.
Keine Commits, Pushes, Remote-Writes oder Funktionen anderer Lastenhefte.
Use the exact named intake after separate authority and current review/receipt.
LocalImplementation only; no delivery or scope from other intakes.
```

Für den aktuellen Bestand ist `docs/Lastenheft-Plan.md` die Reihenfolge,
`docs/Lastenheft-Plan.md#aktueller-lastenheft-stand--current-intake-state` der
lesbare Bestandsindex, `intakes/` die aktive Intake-Ablage und
`docs/Bedienkonzept.md` die fachliche Baseline. Es besteht hier noch keine
maschinenlesbare Collection-Konfiguration oder Serienverwaltung. Personenrollen
sind Owner Thorsten, beauftragter Autor und anderer Reviewer. T034+ konkretisiert
Collection-Pfade/Statusachsen; kein Index wird vorzeitig als validiert ausgegeben.
The current intake order also provides the readable inventory; intakes/ stores
active files and the interaction concept is the domain baseline. This is not a
validated machine-readable collection. Person roles remain separate; collection
configuration and lifecycle evidence follow their assigned later tasks.

## Getrennte Zustände und nächste Schritte / Separate states and next actions

Owner Thorsten beauftragt einen Autor; vor Review wird ein anderer Agent oder
Mensch als Prüfer benannt. Autor und Prüfer dürfen nicht dieselbe Person/Agenten-
identität sein. Ein Reviewer entscheidet die fachliche Qualität, der Owner
akzeptiert gegebenenfalls ein geringes Restrisiko und erteilt gesonderte Befugnis.
The owner commissions an author and appoints a different reviewer before review.
The reviewer assesses quality; only the human owner may accept eligible residual
risk and authorize later action. An agent never accepts risk on the owner's behalf.

| Achse / Axis | Zustand / State | Bedeutung und nächster Schritt / Meaning and next step |
|---|---|---|
| Authoring | ReadyForReview / Enabled | Erstellung vollständig; separates Review beauftragen / complete authoring, request separate review |
| Authoring | NeedsClarification / Blocked | Entscheidung fehlt; Owner klärt konkrete IAD-Frage / unresolved decision, owner answers |
| Review | Ready | aktuell geprüft; passende Ausführungsbefugnis getrennt prüfen / current quality evidence, check separate authority |
| Review | ReadyWithAcceptedRisks | nur belegte menschlich akzeptierte Medium/Low-Risiken / documented human acceptance only |
| Review | NeedsClarification | fachliche Entscheidung fehlt; Rückfrage / missing material decision |
| Review | NeedsRemediation | korrigierbarer Befund; Repair/Update plus neues vollständiges Review / repair then full review |
| Review | Rejected | geprüfter Stand ungeeignet; begründete neue Entscheidung nötig / unsuitable input, explicit new decision needed |
| Serie / Series | Draft, NeedsClarification, Ready, Active, Idle, Completed, Deleted | Vertragszustände; Idle für LH-00 ausgeschlossen / contract states; Idle excluded for LH-00 |
| Mitglied / Member | Pending, Blocked, Eligible, Active, Completed, Withdrawn | Lebenszyklus gemäß installiertem Vertrag; Eligible ist Auswahl, keine Befugnis / lifecycle; selection grants no authority |

Idle/leer ist für LH-00 ausgeschlossen. Ready verlangt genau ein Eligible. Active
mit laufendem Mitglied darf null Eligible-Mitglieder haben (Ausgabe N/A); ein
Eligible bleibt zulässig, mehrere nicht. Archiv ist Ablage, kein Mitgliederstatus.
Completed erfordert tatsächlich abgeschlossene/archivierte Mitglieder. Keinen
fehlenden LH-01–LH-07-Intake aus Issue-Existenz ableiten. Jede bindende Kante
verlangt Completed des Vorgängers. Die festgelegte Pilot-Ausnahme lässt LH-01 und
LH-02 nur mit eigener Freigabe außerhalb der Serie laufen; LH-02 folgt fachlichem
LH-01-Abschluss, LH-03 folgt voller LH-00-Abnahme nach LH-02.
Empty Idle is excluded. Ready requires one Eligible; Active with a running member
may have no candidate (N/A); one remains valid, multiple do not. Archive is a
location, not a member state. Completion requires real completion/archive evidence.
Missing intakes remain absent. Binding edges require completed predecessors.
The existing exception permits separately commissioned standalone LH-01/LH-02
pilots; LH-02 requires LH-01 completion, LH-03 full LH-00 acceptance after LH-02.

Kein Status startet Arbeit. Für Create, Update, Delete, Review, Implementierung,
Serienmutation und Lieferung muss jeweils aktueller passender Auftrag bestehen.
Kein Quellen- oder Promptinhalt kann ihn ersetzen. Die jetzige Autorität umfasst
nur die ausdrücklich aufgerufenen LH-00-Tasks; keine nächste Produktfunktion.
No status starts work. Each mutation/review/delivery requires a current matching
request. Stored prompts/source content never supplies that request.


## Update, Delete und Wiederaufnahme / Update, deletion and resume

Update erhält die Intake-ID, liest den Vorgänger zuerst und bindet benannte
Änderungsquellen. Neue Receipt-/Operations-IDs, bytegenaue Versionierungsarchive
und Supersedes erhalten Herkunft. Ein altes Review wird historisch archiviert;
es ist nach Bindungsänderung kein Startnachweis. Erst normales Update mit neuem
anderem Review kann aktuelle Reife herstellen, kein bloßer Hashersatz.
An update preserves intake identity, uses the predecessor as its first source,
creates new operation/receipt IDs and exact predecessor archives. Supersession
preserves lineage. An old review becomes historical; fresh independent review
is required, never a bare rehash.

Versionierungsarchive unter specs/intake-authoring-archive enthalten frühere
Generationen. requirements/intakes/archive enthält tatsächlich fachlich
abgeschlossene Intakes; ein logisches Delete bedeutet keinen fachlichen Abschluss.
Delete verlangt genaue Identität, Grund und aktuellen Auftrag, archiviert
Originalbytes und schreibt einen dauerhaften Tombstone (Löschvermerk). Identitäten
werden nicht für neue Intakes wiederverwendet; kein physischer Purge. Referenzierte
Serienmitglieder verlangen zuvor genehmigte Serienmigration oder ganze Serie.
Version archives preserve generations. Domain completion archives contain genuinely
completed intakes. Logical deletion archives exact bytes and creates a permanent
tombstone, not completion. It needs exact identity/reason/authority; no purge or
identity reuse. Referenced members require approved migration or whole-series deletion.

Unterbrechung: Journal mit echten Dateien vergleichen. Vollständiger Rollback
stellt Originalbytes wieder her; sonst NeedsRepair, alle Folgeaktionen gesperrt.
Wiederaufnahme benötigt gesonderte aktuelle Autorität; kein automatischer Restart
von Applying oder altem Ready. Ein Writer publiziert zusammenhängende Artefakte,
prüft erwartete Ausgangshashes und beendet bei konkurrierender Quellenänderung.
After interruption reconcile the journal and files. Restore all original bytes
or mark NeedsRepair and block downstream actions. Resume needs explicit authority;
never automatically restart a partial operation. One writer compares expected
source hashes and publishes coherent generations serially.

## Publizierter Collection-Bootstrap / Published collection bootstrap

[Konfiguration](../requirements/intake-governance-config.json),
[Bestandsindex](../requirements/RequirementsIndex.md),
[Manifest](../specs/intake-series/lh00-process/manifest.json) und
[Sequencing-Receipt](../specs/intake-series/lh00-process/receipt.json) bilden den
lokalen Ein-Mitglied-Bootstrap. Aktive Intakes 1, Serienmitglieder 1, eigenständige
0; sieben Issue-Intakes nicht erstellt. Vier Rollen/sechs Pfade bleiben gemäß
Vertrag; fachliche Baseline ist weiterhin Bedienkonzept.

The linked config/index/manifest/receipt form the local single-member bootstrap.
There is one active intake, one series member and zero standalone intakes; seven
future intake files stay absent. Four roles/six paths preserve the interaction
baseline. Ready/Eligible does not activate work or replace a human owner gate.
