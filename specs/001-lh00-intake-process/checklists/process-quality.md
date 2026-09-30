# Anforderungsqualität: LH-00-Prozess / Requirements quality: LH-00 process

**Zweck / Purpose:** Vollständigkeit, Klarheit und Konsistenz der beschriebenen
Anforderungen vor der Aufgabenzerlegung beurteilen / Assess requirement completeness,
clarity and consistency before task breakdown.

**Erstellt / Created:** 2026-09-30.
**Feature:** [Spezifikation / Specification](../spec.md).
**Kontext / Context:** [Plan](../plan.md), [Datenmodell / Data model](../data-model.md),
[Collection-Vertrag / Collection contract](../contracts/collection.md),
[Prozessvertrag / Process contract](../contracts/process.md),
[Recherche / Research](../research.md), [Prüfanleitung / Validation guide](../quickstart.md).
**Tiefe / Depth:** Standard, risikoorientiert / Standard, risk-focused.
**Zielgruppe und Zeitpunkt / Audience and timing:** Autor und anderer Reviewer,
vor `speckit-tasks` / Author and another reviewer, before speckit-tasks.
**Status:** 24/24 Punkte nach Dokumentkorrekturen als ausreichend beschrieben
bewertet / 24/24 items assessed as adequately specified after document corrections.
**Prüfer und Datum / Reviewer and date:** ausführender Codex-Agent, 2026-09-30;
Selbstprüfung mit Korrekturen, kein unabhängiges Review / executing Codex agent;
self-review with corrections, not independent review.

Erstellt mit `speckit-checklist`. Jeder Punkt prüft die Qualität des geschriebenen
Anforderungsvertrags, nicht die funktionierende Umsetzung. FR bezeichnet eine
funktionale Anforderung, AC ein Abnahmekriterium und SC ein messbares Erfolgskriterium.
Der Durchführungshinweis nennt Lesestellen und Bewertungsmaßstab. Keine Kommandos
oder Prozessfälle ausführen. Ein fachlich offener Umsetzungsnachweis ist nicht
automatisch eine unklare Anforderung, wenn seine Bedingungen vollständig definiert sind.

Generated with speckit-checklist. Each item assesses the written requirements, not
working implementation. FR denotes a functional requirement, AC an acceptance
criterion and SC a measurable outcome. Each review instruction identifies reading
targets and the assessment standard. Do not run commands or process scenarios.
Outstanding implementation evidence is not automatically an unclear requirement
when its conditions are fully specified.

## Vollständigkeit / Requirement completeness

- [x] CHK001 Ist LH-00 als alleiniger fachlicher Umfang mit ausdrücklichen Nicht-Zielen beschrieben? / Is LH-00 defined as the sole domain scope with explicit non-goals? [Completeness, Spec §Annahmen 1/6, AC-00-003]

  **Durchführungshinweis:** Scope und Annahmen der Spec mit der Planzusammenfassung vergleichen. Als ausreichend bewerten, wenn Folge-LH, Produkttechnik und Lieferbefugnisse nicht stillschweigend hinzukommen. / **Review instruction:** Compare specification scope/assumptions with the plan summary. Pass only if later intakes, product technology and delivery authority are not silently added.

- [x] CHK002 Sind alle geforderten Intake-Inhalte einschließlich beider Folgeprompts eindeutig aufgeführt? / Are all required intake sections, including both follow-up prompts, explicitly listed? [Completeness, Spec §FR-005–006]

  **Durchführungshinweis:** Die Liste in FR-006 mit dem Prozessvertrag abgleichen; fehlende oder unterschiedlich verpflichtende Abschnitte mit Fundstelle notieren. / **Review instruction:** Compare the FR-006 list with the process contract; record missing sections or inconsistent obligation levels with references.

- [x] CHK003 Sind Owner, Autor, anderer Reviewer und Zuständigkeit für offene Punkte vollständig beschrieben? / Are owner, author, different reviewer and responsibility for open items fully defined? [Completeness, Spec §FR-004, FR-018]

  **Durchführungshinweis:** Rollenbeschreibung und Governance-Matrix lesen. Für jede Rolle Verantwortungsumfang und Benennungszeitpunkt suchen; eine spätere Personenbenennung braucht einen klaren Zeitpunkt. / **Review instruction:** Read role definitions and the governance matrix; locate each responsibility and appointment point. Deferred naming needs a clear deadline.

## Klarheit / Requirement clarity

- [x] CHK004 Sind Authoring-, Review-, Auswahl- und Umsetzungsstatus begrifflich voneinander getrennt? / Are authoring, review, selection and implementation states clearly distinguished? [Clarity, Spec §FR-017–018]

  **Durchführungshinweis:** Die Zustandsachsen im Datenmodell den Spec-Aussagen zuordnen. Für ReadyForReview, Ready und Eligible jeweils Bedeutung und ausgeschlossene Befugnis benennen können. / **Review instruction:** Map model state axes to the specification. Each named state must have an explicit meaning and authority boundary.

- [x] CHK005 Sind Plan-ID, Intake-Identität, Receipt-Identität und Serienidentität eindeutig unterschieden? / Are plan, intake, receipt and series identities unambiguously distinguished? [Clarity, Spec §FR-014–016, FR-022]

  **Durchführungshinweis:** Entitätentabelle und Update-Regeln lesen. Festhalten, welche Identität bleibt und welcher Nachweis erneuert wird; widersprüchliche Verwendung derselben Bezeichnung als Befund erfassen. / **Review instruction:** Read entities and update rules. Identify stable identities and renewed evidence; flag conflicting use of a term.

- [x] CHK006 Ist „vollständiger Prozess“ je Umgebung präzise genug abgegrenzt? / Is the complete process precisely bounded for each environment? [Clarity, Spec §FR-019–020, US-06]

  **Durchführungshinweis:** US-06 mit E06 der Prüfanleitung vergleichen. Als ausreichend bewerten, wenn enthaltene E-Fälle, PowerShell-Anteil und nur gemeinsam referenzierbare Nachweise benannt sind. / **Review instruction:** Compare US-06 with quickstart E06; require named evidence cases, PowerShell scope and the evidence allowed to be shared.

## Konsistenz / Requirement consistency

- [x] CHK007 Haben normative DE-/EN-Aussagen dieselbe Bedeutung und dieselben Anforderungs- und Abnahme-IDs? / Do normative German and English statements have equivalent meaning and matching IDs? [Consistency, Spec §FR-009, SC-002]

  **Durchführungshinweis:** Beide Sprachfassungen abschnittsweise vergleichen, besonders MUSS/MUST, Ausnahmen, Rollen und Abnahmebedingungen. Jede Bedeutungsabweichung mit beiden Textstellen notieren. / **Review instruction:** Compare language tracks section by section, especially obligations, exceptions, roles and acceptance conditions; record both locations for discrepancies.

- [x] CHK008 Sind verbindliche Reihenfolge, explizite Serienmitgliedschaft und noch fehlende Intakes widerspruchsfrei beschrieben? / Are binding order, explicit series membership and missing intakes described consistently? [Consistency, Spec §FR-007–008, FR-022]

  **Durchführungshinweis:** Spec und Collection-Vertrag mit dem referenzierten Lastenheft-Plan vergleichen. Die vollständige fachliche Reihenfolge darf nicht mit der aktuellen Ein-Mitglied-Serie gleichgesetzt werden. / **Review instruction:** Compare specification and collection contract with the referenced intake order; distinguish the full domain order from current single-member membership.

- [x] CHK009 Sind die vier Dokumentrollen, sechs Collection-Pfade und der Bestandsmodus in allen Entwürfen gleich beschrieben? / Are four document roles, six collection paths and inventory mode consistent across designs? [Consistency, Spec §FR-021, Plan §Phase 0 und Phase 1]

  **Durchführungshinweis:** Begriffe und Zuordnungen in Plan, Datenmodell und Collection-Vertrag nebeneinander lesen. Abweichende Zuständigkeiten, doppelte kanonische Quellen oder unklare Archivbedeutungen notieren. / **Review instruction:** Compare mappings across plan, model and collection contract; flag conflicting roles, competing canonical sources or unclear archive meanings.

## Qualität der Abnahmekriterien / Acceptance criteria quality

- [x] CHK010 Ist jede funktionale Anforderung auf ein beobachtbares Abnahmekriterium zurückgeführt? / Is each functional requirement traced to an observable acceptance criterion? [Measurability, Spec §Nachverfolgbarkeit, SC-009]

  **Durchführungshinweis:** Die Zuordnung für 24 Spec-FR, zwölf Quell-FR und neun Quell-AC lesen. Fehlende Verbindungen oder Kriterien ohne erkennbaren Entscheidungsmaßstab markieren. / **Review instruction:** Read the mapping of 24 spec FR, twelve source FR and nine source AC; flag missing links or criteria lacking a decision standard.

- [x] CHK011 Sind vier erfolgreiche Gesamtstrecken ausdrücklich von vier einzelnen Validatornachweisen unterschieden? / Are four successful complete flows explicitly distinguished from four validator checks? [Measurability, Spec §SC-006, FR-020]

  **Durchführungshinweis:** SC-006 und die vier Umgebungsprotokolle der Prüfanleitung lesen. Für Erfolg, fehlende Umgebung und Teilnachweis muss eine eindeutige Bewertung beschrieben sein. / **Review instruction:** Read SC-006 and the four environment-record definitions; require clear assessment rules for success, unavailable environments and partial evidence.

- [x] CHK012 Sind erforderliche Nachweisinhalte und die Grenze zwischen Anwendbarkeit und Erfüllung objektiv beschrieben? / Are required evidence fields and the distinction between applicability and fulfillment objectively defined? [Measurability, Spec §FR-013, FR-020]

  **Durchführungshinweis:** Prozessvertrag und Governance-Matrix auf Quelle, Owner, Reviewer, Ergebnis, Grenzen und nächste Aktion abgleichen. N/A braucht eine Begründung; Open darf nicht als Erfüllung gelten. / **Review instruction:** Compare evidence definitions for source, owner, reviewer, outcome, limits and next action. N/A needs rationale; Open cannot mean fulfillment.

## Szenarioabdeckung / Scenario coverage

- [x] CHK013 Ist der Hauptablauf vom benannten Issue bis zum gesonderten Review vollständig beschrieben? / Is the primary flow from a named issue to separate review fully described? [Coverage, Spec §US-01, US-04, FR-002]

  **Durchführungshinweis:** Für jeden beschriebenen Schritt Eingabe, Ergebnis und erforderlichen Auftrag im Prozessvertrag suchen. Unbenannte Übergänge als Lücke erfassen, ohne den Ablauf auszuführen. / **Review instruction:** Locate each step's input, output and authority in the process contract; record unspecified transitions without running the flow.

- [x] CHK014 Sind beauftragte Änderung, Archivierung und Löschung als getrennte Alternativen vollständig definiert? / Are authorized update, archival and deletion fully defined as distinct alternatives? [Coverage, Spec §FR-015–016]

  **Durchführungshinweis:** Die Aktionsbeschreibungen auf Vorgängerbindung, Identitätserhalt und Archivverweis vergleichen. Insbesondere klären die Texte, ob Serienlöschung die Intake-Dateien betrifft. / **Review instruction:** Compare action definitions for predecessor binding, identity preservation and archive records, including whether series deletion affects intake files.

- [x] CHK015 Sind Wiederherstellung nach Teilfehler und Wiederaufnahme nach Unterbrechung eindeutig geregelt? / Are partial-failure recovery and resumption after interruption unambiguously specified? [Coverage, Recovery, Spec §FR-014–016, Plan §Phase 2]

  **Durchführungshinweis:** Migrations- und Wiederaufnahmetext auf vollständigen Rollback, sichtbares NeedsRepair, gesperrte Folgeaktionen und erneute Autorität lesen. Fehlende Regeln als Anforderungslücke notieren. / **Review instruction:** Read migration/recovery text for full rollback, visible NeedsRepair, blocked follow-ups and renewed authority; record missing rules as gaps.

## Grenzfälle / Edge case coverage

- [x] CHK016 Sind vorhandenes Ziel, veränderte Quelle und veraltetes Review mit klaren Folgen für den Prozess beschrieben? / Are existing targets, changed sources and stale reviews described with clear process consequences? [Coverage, Edge Case, Spec §FR-014–018]

  **Durchführungshinweis:** Zu jedem der drei Fälle die textliche Ablehnungs- oder Sperrbedingung suchen. Prüfen, ob bloßes Ersetzen einer Prüfsumme ausdrücklich keine neue fachliche Prüfung darstellt. / **Review instruction:** Locate the written rejection or blocking condition for each case, including the distinction between rehashing and fresh domain review.

- [x] CHK017 Sind leere, mehrdeutige und widersprüchliche Serienbestände als Grenzfälle berücksichtigt? / Are empty, ambiguous and conflicting series inventories covered as edge cases? [Coverage, Edge Case, Spec §FR-021–022, Research §D-03]

  **Durchführungshinweis:** Beschreibungen für fehlende Mitglieder, mehrere Eligible-Ziele, Zyklen und Idle/leer vergleichen. Erwartete fachliche Grenzen müssen erkennbar sein; keine Validatoren ausführen. / **Review instruction:** Compare written rules for missing members, multiple eligible targets, cycles and empty Idle; assess documented boundaries without invoking validators.

## Nichtfunktionale Anforderungen / Non-functional requirements

- [x] CHK018 Sind Sprachverständlichkeit und barrierefreie Informationsvermittlung für alle betroffenen Dokument- und CLI-Flächen beschrieben? / Are readability and accessible information requirements defined for every affected document and CLI surface? [Completeness, Spec §FR-010–012, SC-003]

  **Durchführungshinweis:** B2, Erstbegriffserklärung, Tastatur, Screenreader, Braille, Textbrowser und Textalternative im Anforderungstext zuordnen. Fehlende Flächen oder nur farblich ausgedrückte Bedeutungen als Dokumentationslücke benennen. / **Review instruction:** Map B2, term definitions, keyboard, screen reader, Braille, text-browser and text-alternative requirements; flag missing surfaces or color-only meaning in the written contract.

- [x] CHK019 Sind Schutzanforderungen für unvertraute Eingaben, Pfade, Geheimnisse und Befugnisse nachvollziehbar begründet? / Are protections for untrusted inputs, paths, secrets and authority traceably justified? [Completeness, Spec §CR-006, CR-010–011]

  **Durchführungshinweis:** Sicherheitsabschnitte der Spec und des Plans lesen. Für jede Schutzgrenze eine formulierte Anforderung und einen vorgesehenen Nachweis suchen; Installation allein darf nicht als Sicherheitsabnahme gelten. / **Review instruction:** Read specification/plan security sections; locate a requirement and intended evidence for each boundary. Installation alone must not equal security acceptance.

- [x] CHK020 Sind nicht vorgegebene Leistungsziele und offene Produkttechnik ausdrücklich vom Prozessumfang abgegrenzt? / Are unspecified performance targets and undecided product technology explicitly bounded outside the process scope? [Clarity, Assumption, Spec §Messbare Ergebnisse, CR-005]

  **Durchführungshinweis:** Erfolgsmaßstäbe und technischen Kontext vergleichen. Keine erfundenen Antwortzeiten, Produktsprache oder Produkt-Mindestversion aus lokalen Werkzeugversionen ableiten. / **Review instruction:** Compare success measures and technical context; identify any invented latency target or product-language/minimum-version assumption derived from local tools.

## Abhängigkeiten und Annahmen / Dependencies and assumptions

- [x] CHK021 Sind Werkzeugabhängigkeiten und Plattformannahmen mit ihren Nachweisgrenzen dokumentiert? / Are tool dependencies and platform assumptions documented with evidence limits? [Dependency, Assumption, Spec §FR-001, FR-019, Annahmen 2/4]

  **Durchführungshinweis:** Versions- und Plattformangaben zwischen Spec, Plan und Recherche vergleichen. Owner-Angabe, lokal beobachtete Version und noch benötigter Plattformnachweis müssen unterscheidbar sein. / **Review instruction:** Compare versions/platform statements across spec, plan and research; distinguish owner reports, local observations and required future platform evidence.

- [x] CHK022 Sind Übersetzungen und zentrale Registerausrichtung als Abnahmeabhängigkeiten mit Owner und Fälligkeit definiert? / Are translations and central registry alignment defined as acceptance dependencies with owner and due point? [Dependency, Spec §FR-023–024, SC-008]

  **Durchführungshinweis:** Die referenzierten FU-Punkte mit SC-008 vergleichen. Aus dem Text muss hervorgehen, dass eine vorbereitete Änderung keine angewendete zentrale Ausrichtung belegt. / **Review instruction:** Compare referenced follow-ups with SC-008; the text must distinguish a prepared change from applied central alignment.

## Unklarheiten und Konflikte / Ambiguities and conflicts

- [x] CHK023 Ist B-01 als unerfüllte Voraussetzung für Active erkennbar, ohne das geforderte Lebenszyklusverhalten abzuschwächen? / Is B-01 explicit as an unmet prerequisite for Active without weakening required lifecycle behavior? [Conflict, Spec §FR-021–022, Research §D-03]

  **Durchführungshinweis:** D-03, Collection-Vertrag und Plan-Gates gegeneinander lesen. Ausreichend sind benannter Konflikt, Owner, nächster Schritt und Aufhebungskriterium; Ready/Eligible darf nicht als Ersatz für einen abgeschlossenen Active-Nachweis gelten. / **Review instruction:** Compare D-03, collection contract and plan gates; require conflict, owner, next action and resolution criterion. Ready/Eligible must not substitute for Active evidence.

- [x] CHK024 Sind technische Prüfergebnisse, menschliche Risikoannahme und Ausführungs- oder Lieferfreigabe widerspruchsfrei getrennt? / Are technical outcomes, human risk acceptance and execution/delivery authority consistently separated? [Consistency, Conflict, Spec §FR-018, SC-005]

  **Durchführungshinweis:** Review-Ergebnisse, Folgeprompts und Phasenübergabe lesen. Jede Formulierung markieren, die aus Ready, Eligible oder einem positiven Bericht automatisch Umsetzung, Remote-Schreiben oder nächste Lastenhefte ableitet. / **Review instruction:** Read review outcomes, follow-up prompts and phase handoff; flag wording that derives implementation, remote writes or further intakes automatically from a positive status/report.

## Durchführung und Befunde / Review records

Pro geprüftem CHK-Punkt Prüfer, Datum, konkrete Fundstelle und Bewertung ergänzen.
Nur bei ausreichender Anforderungsbeschreibung `[x]` setzen. Bei Lücke offen lassen
und Befund, zuständigen Owner und nächste Klärung notieren. Eine begründete
Nichtanwendbarkeit ausdrücklich dokumentieren. Bestehende Prüfberichte bleiben
historische Nachweise; diese neue Liste übernimmt deren Häkchen nicht.

For each assessed CHK item record reviewer, date, exact location and assessment.
Mark `[x]` only when the requirement is adequately specified. Keep gaps open and
record the finding, owner and next clarification. Explicitly justify any
non-applicability. Existing reports retain their historical meaning; this new list
does not inherit their completed check marks.

### Ergebnis dieses Durchgangs / Results of this pass

Die folgenden Bewertungen gelten für die Anforderungsbeschreibung, nicht für
erbrachte Umsetzung. Die korrigierten Texte wurden erneut gegen den jeweiligen
Punkt gelesen. B-01, vier Plattformnachweise, Hilfsmittelprüfung, Übersetzungen
und zentrale Ausrichtung bleiben offene Umsetzungsvoraussetzungen. Ihre präzise
Beschreibung erfüllt einen Checklistenpunkt, schließt aber den offenen Nachweis
nicht. Intake, Receipt, Intake-Review und gemeinsame Guidance wurden nicht geändert.

These assessments concern written requirements, not delivered implementation.
Corrected wording was reread against the corresponding item. B-01, four-platform
evidence, assistive checks, translations and central alignment remain outstanding.
Precisely defining them can satisfy a checklist item without closing the evidence
gap. Intake, receipt, intake review and shared guidance remain unchanged.

| ID | Bewertung, Fundstelle und Korrektur / Assessment, location and correction |
|---|---|
| CHK001 | Ausreichend: Spec §Annahmen 1/6 und Plan §Zusammenfassung grenzen LH-00, Folge-LH und Lieferung ab / Adequate: scope and authority boundaries agree. |
| CHK002 | Korrigiert: Prozessvertrag vor §Rollen übernimmt jetzt die vollständige FR-006-Liste, einschließlich Ist-/Zielzustand, atomarer Anforderungen, Artefakten und Annahmen / Corrected: the complete required-content list is explicit. |
| CHK003 | Korrigiert: Prozessvertrag §Rollen und Benennungszeitpunkte nennt Verantwortung, Benennung vor Schreiben/Review und die Sperre bei fehlender Benennung / Corrected: responsibilities, appointment points and missing-role blocking defined. |
| CHK004 | Korrigiert: Datenmodell §Getrennte Zustandsachsen nennt alle vier Review-Ergebnisse und die Driftfolge; FR-017/018 bleibt maßgeblich / Corrected: all four review outcomes and drift consequences are explicit. |
| CHK005 | Ausreichend: Datenmodell §Entitäten und §Unveränderliche Beziehungen 1; Prozessvertrag Update-Zeile unterscheiden stabile Identitäten von erneuerten Receipts / Adequate: stable identities and renewed receipts are distinct. |
| CHK006 | Ausreichend nach Präzisierung: Spec §US-06 und Quickstart §§3/4 definieren E01–E05/E07, PowerShell-Anteil und gemeinsam referenzierbare Nachweise / Adequate: full flow and shared-evidence limits are defined. |
| CHK007 | Korrigiert: Prozessvertrag sprachlich auf Intake statt „jede Datei“ begrenzt; Pflichtliste in beiden Sprachen ergänzt. Plan §Technischer Kontext enthält lokale Versionen nun auch im EN-Text / Corrected: intake scope, required content and local-version statements aligned across languages. |
| CHK008 | Ausreichend: Lastenheft-Plan §Reihenfolgetabelle, Spec FR-007/008/022 und Collection-Vertrag §Serienvertrag erhalten die vollständigen Abhängigkeiten bei zunächst nur einem Mitglied / Adequate: full dependency order remains distinct from single-member bootstrap. |
| CHK009 | Korrigiert: Collection-Vertrag §Konfiguration und Rollen erklärt jetzt auch backlog/history und die Trennung zum bestehenden Versionsarchiv / Corrected: collection purposes and archive boundaries clarified. |
| CHK010 | Ausreichend: Spec §Nachverfolgbarkeit und Plan §Anforderungsabdeckung ordnen 24 FR, zwölf Quell-FR und neun AC den E-Fällen zu / Adequate: requirement and acceptance mapping complete. |
| CHK011 | Korrigiert: Quickstart §4 definiert vollständigen Erfolg, erwartete Negativfälle, Blockade, Teilnachweis und unerwarteten Fehler / Corrected: full success and non-success conditions defined. |
| CHK012 | Korrigiert: Prozessvertrag §Abnahmeprotokoll ergänzt Owner und Quellverweis. Governance-Matrix trennt Baseline vor Umsetzung von Delta/Abschlussnachweisen; Anwendbarkeit bleibt von Erfüllung getrennt / Corrected: evidence metadata and gate timing clarified. |
| CHK013 | Ausreichend: Prozessvertrag Aktionstabelle und Rollenabschnitt beschreiben Quelle/Ziel, Ergebnis und getrennte Autorität für Erstellung und anderes Review / Adequate: primary flow inputs, outputs and authority specified. |
| CHK014 | Korrigiert: Prozessvertrag §Rollen und Benennungszeitpunkte grenzt Abschlussarchivierung von logischer Löschung ab; Series-Delete erhält Intake-Dokumente / Corrected: archival, deletion and series-deletion scope distinguished. |
| CHK015 | Ausreichend: Collection-Vertrag §Migration und Datenmodell §Fehler definieren Rollback, NeedsRepair und gesperrte Zwischenzustände; Plan §Phase 2 verlangt ausdrückliche Wiederaufnahme / Adequate: recovery and resumption boundaries explicit. |
| CHK016 | Ausreichend: Spec §Grenzfälle, Prozessvertrag §Validatorverträge und Collection-Vertrag §Migration schließen Overwrite, stille Hashreparatur und Weiterverwendung veralteter Reviews aus / Adequate: stale and conflicting inputs have explicit consequences. |
| CHK017 | Korrigiert: Collection-Vertrag §Serienvertrag nennt Sperren für fehlende Mitglieder, Zyklen, Reihenfolge und mehrere Eligible; Idle/leer bleibt ausgeschlossen / Corrected: inventory edge-case outcomes explicit. |
| CHK018 | Korrigiert: Plan §Plattform-, A11Y- und Agentenparität und Quickstart E03 nennen Textbrowser ausdrücklich zusätzlich zu CLI-Textzugang; Spec §Barrierefreiheit bleibt Maßstab / Corrected: documentation text-browser coverage explicit. |
| CHK019 | Korrigiert: Plan und Governance-Matrix verwenden den Spec-Nachweispfad `docs/security/threat-model.md`. Spec CR-006/010/011 und Plan §Architektur benennen Schutzgrenzen und Belege / Corrected: threat-model evidence path aligned; safeguards traceable. |
| CHK020 | Ausreichend: Spec §Messbare Ergebnisse/CR-005 und Plan §Technischer Kontext erfinden weder Leistungsziele noch Produkttechnik / Adequate: no unsupported performance or product-technology commitments. |
| CHK021 | Korrigiert: Quickstart Einleitung verlangt Bash nur für macOS/Linux-Gegenprüfungen, nicht als native Windows-Voraussetzung. Plan kennzeichnet lokale Versionen als historischen Planungsbefund / Corrected: native Windows prerequisites and observation date clarified. |
| CHK022 | Korrigiert: Verweise in Plan, Recherche und Governance-Matrix auf die tatsächlich verwendeten IDs FU01–FU07 vereinheitlicht. Governance-Zuordnung FU01–FU07, Spec SC-008 und FR-023/024 verlangen Abschluss vor Abnahme / Corrected: follow-up IDs aligned; prepared versus applied evidence remains distinct. |
| CHK023 | Korrigiert: Recherche D-03 nennt konkrete Aufhebungskriterien und anderes Review vor Owner-Schließung; Collection-Vertrag verweist darauf. B-01 bleibt offen / Corrected: resolution criteria explicit; B-01 remains open. |
| CHK024 | Ausreichend: Spec FR-018/SC-005, Datenmodell §Zustandsachsen und Prozessvertrag trennen Qualität, menschliche Risikoannahme und Ausführungs-/Remote-Autorität / Adequate: outcomes and permissions remain separate. |

Keine Prozessfälle, Plattformtests oder Validator-Reparaturen wurden in dieser
Dokumentprüfung ausgeführt. Die bestehende Planprüfung dokumentiert ihren früheren
Stand; diese Tabelle hält die anschließenden Korrekturen fest.

No process cases, platform tests or validator repairs were performed in this
document review. The existing plan-validation report records its earlier state;
this table records the subsequent corrections.
