**Status: Genehmigte Issue-Grundlage; Veröffentlichungsstände werden separat nachgewiesen. Das Issue ist kein aktives Lastenheft.**

**Status: Approved issue input; publication states are evidenced separately. This issue is not an active intake.**

- Original: [LH-00, Issue #1](https://github.com/hindermath/Show-CommandTui400/issues/1)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-28T05:44:33Z`.
- Originaltext SHA-256 / Original body SHA-256: `07cea12d4b043979af5bbed888f934a91396b436698528f6ecb156f10453e015`.
- Plan-ID: `LH-00`.
- Abhängigkeiten / Dependencies: keine / none.

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Eine nachvollziehbare Grundlage schaffen, um aus den folgenden Issues eigenständige, reviewbare Lastenhefte zu erzeugen.

Establish a traceable basis for turning the following issues into independent, reviewable requirements documents.

## Ausgangslage / Current state

Ein Lastenheft (Intake) beschreibt Anforderungen und Abnahme; ein Receipt belegt
Quellen und Inhalt durch Hashes. Ein Review ist eine gesonderte fachliche Prüfung.
Das eingerichtete Level-2-Projekt verwendet Spec Kit 0.12.8, fünf Integrationen,
14 versionsgebundene Presets und Intake Authoring 0.3.5. Produktcode fehlt.
Das lokale Profil `show-commandtui400-de-en` regelt das Authoring; die vollständige
Prozessabnahme einschließlich PowerShell-Basisskripten bleibt Gegenstand von LH-00.
PowerShell 7.6.6.0 auf beiden Macs ist eine Owner-Angabe vom 28.09.2026,
keine Produkt-Mindestversion. Windows 11 und Ubuntu 24.04 unter WSL2 werden
getrennt geprüft; ihre PowerShell-Versionen und Testergebnisse sind offen.
Technische Produktentscheidungen gelten nur, soweit die Baseline sie festlegt.

An intake describes requirements and acceptance; a receipt binds sources and
content through hashes. A review is a separate assessment of the requirements.
The configured Level-2 project uses Spec Kit 0.12.8, five integrations,
14 pinned presets and Intake Authoring 0.3.5. No product code exists.
The local show-commandtui400-de-en profile governs authoring; full process
acceptance, including PowerShell base scripts, remains part of LH-00.
PowerShell 7.6.6.0 on both Macs is owner-reported as of 28 September 2026,
not a product minimum. Windows 11 and Ubuntu 24.04 under WSL2 are tested
separately; their PowerShell versions and results remain open. Product
technology decisions apply only where the baseline establishes them.

## Verbindliche Quellen / Binding sources

- [Constitution](https://github.com/hindermath/Show-CommandTui400/blob/main/constitution.md)
- [Agenten-Guidance / Agent guidance](https://github.com/hindermath/Show-CommandTui400/blob/main/AGENTS.md)
- [Governance-Zuordnung / Governance mapping](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/intake-governance.md)
- [Bedienkonzept / Interaction concept](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/Bedienkonzept.md)
- [Reihenfolge / Order](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/Lastenheft-Plan.md)
- [Entwicklungsumgebung / Development environment](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/Entwicklungsumgebung.md)
- [Authoring-Profil / Authoring profile](https://github.com/hindermath/Show-CommandTui400/blob/main/.specify/memory/intake-authoring-profile.md)
- [Sicherheitsanwendbarkeit / Security applicability](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/security/README.md)

## Anforderungen / Requirements

- **FR-00-001:** Spec-Kit-Version, verwendete Erweiterungen und tatsächlich verfügbare Intake-Kommandos feststellen und dokumentieren.
- **FR-00-002:** Projektprofil mit Deutsch zuerst (de-DE), Englisch danach (en), ungefähr CEFR B2 sowie Ablage, Statusmodell und Verantwortlichkeiten festlegen.
- **FR-00-003:** Bedienkonzept als fachliche Baseline referenzieren; Lastenhefte, technische Spezifikationen und Implementierungspläne getrennt halten.
- **FR-00-004:** Reihenfolge und Abhängigkeiten in einer einzigen verbindlichen Übersicht pflegen; Issues und Lastenhefte jeweils nach ihrer Erstellung verlinken.
- **FR-00-005:** Pflege fachliche Dokumente DE zuerst/EN danach mit gleichen IDs und ungefähr CEFR B2; erkläre Fach- und Workflowbegriffe bei erster Verwendung.
- **FR-00-006:** Beschreibe Status, Abhängigkeiten, Entscheidungen und nächste Aktion vollständig in Text; prüfe Tastatur-, Screenreader-, Braille- und Textbrowserzugang sowie WCAG 2.2 AA soweit anwendbar.
- **FR-00-007:** Ordne alle anwendbaren Level-2-Vorgaben Anforderungen, Abnahmekriterien, Ownern und Nachweisen zu; begründe N/A und kennzeichne offene Nachweise.
- **FR-00-008:** Erzeuge nachprüfbare Quellen- und Zielhashes mit Receipts; schütze bestehende Ziele und trenne Create, Update, Review und Ausführung.
- **FR-00-009:** Definiere Authoring- und Reviewstatus getrennt; ein Review oder ein kopierter Prompt erteilt keine automatische Produkt- oder Remote-Freigabe.
- **FR-00-010:** Weise den durchgängigen PowerShell-Spec-Kit-Prozess auf beiden Macs, nativem Windows 11 und Ubuntu 24.04 unter WSL2 getrennt nach; erfasse Versionen und Testgrenzen.
- **FR-00-011:** Konkretisiere später die portablen Collection-Rollen, Pfade und ein validiertes Serienmanifest aus der bestehenden Reihenfolge; bewahre IDs, Abhängigkeiten und Archivnachweise.
- **FR-00-012:** Erledige die inventarisierten Fachtextübersetzungen und die zentrale Register-Synchronisation vor der Abnahme des LH-00-Prozesses; bewahre historische Nachweise.

- **FR-00-001:** Identify and document the Spec Kit version, extensions and actually available intake commands.
- **FR-00-002:** Define the project profile with German first (de-DE), English second (en), about CEFR B2, storage, status model and responsibilities.
- **FR-00-003:** Reference the interaction concept as the domain baseline; keep intakes, technical specifications and implementation plans separate.
- **FR-00-004:** Maintain order and dependencies in one binding overview; link both issues and intakes after each is created.
- **FR-00-005:** Maintain domain documents in German first and English second, with matching IDs and about CEFR B2; explain technical and workflow terms on first use.
- **FR-00-006:** Explain status, dependencies, decisions and the next action fully in text; assess keyboard, screen reader, Braille and text-browser access and applicable WCAG 2.2 AA criteria.
- **FR-00-007:** Map every applicable Level-2 rule to requirements, acceptance criteria, owners and evidence; justify N/A and label open evidence.
- **FR-00-008:** Produce verifiable source and target hashes in receipts; protect existing targets and separate Create, Update, Review and execution.
- **FR-00-009:** Define authoring and review states separately; review or a copied prompt grants no automatic product or remote authority.
- **FR-00-010:** Prove the end-to-end PowerShell Spec Kit process separately on both Macs, native Windows 11 and Ubuntu 24.04 under WSL2; record versions and proof boundaries.
- **FR-00-011:** Later establish portable collection roles, paths and a validated series manifest from the existing order; preserve IDs, dependencies and archival evidence.
- **FR-00-012:** Complete inventoried domain-document translations and central registry synchronization before LH-00 process acceptance; preserve historical evidence.

## Nicht-Ziele / Non-goals

Keine Produktimplementierung und keine ungeprüfte Übernahme der vollständigen TuiVision-Governance.

No product implementation and no unchecked adoption of the full TuiVision governance.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-00-001:** Ein Lastenheft lässt sich mit dem dokumentierten, tatsächlich verfügbaren Verfahren aus einem Issue erzeugen.
- **AC-00-002:** Jeder Intake enthält Zweck, Ist-/Zielzustand, Scope, Nicht-Ziele, Anforderungen, Risiken, Nachweise, Abnahmekriterien und offene Entscheidungen.
- **AC-00-003:** Es werden keine fremden Features, Build-Anforderungen oder Freigaben aus TuiVision übernommen.
- **AC-00-004:** Alle normativen Abschnitte liegen in beiden Sprachen mit gleicher Bedeutung und gleichen IDs vor; Begriffe sind erklärt.
- **AC-00-005:** Jede Governance-Zeile hat Quelle, Anforderung, Abnahmekriterium, Owner, Prüfer und Nachweisstatus; Mermaid besitzt eine gleichwertige Textalternative.
- **AC-00-006:** Beide installierten Validatoren bestehen für das Receipt; eine kontrolliert geänderte Zielkopie wird abgelehnt und bestehende Ziele werden nicht durch Create überschrieben.
- **AC-00-007:** Authoring, Review durch einen anderen Prüfer (Agent oder Mensch) als den Autor und Umsetzung besitzen unterscheidbare Status und Freigaben; ohne Auftrag startet kein Folgelauf.
- **AC-00-008:** Für Mac A, Mac B, Windows 11 und WSL2 existiert je ein Ergebnis mit Versionen, Befehl, Exitcode und Grenze oder eine sichtbare offene Blockade; vollständige Prozessabnahme setzt erfolgreiche Nachweise aller vier Umgebungen voraus.
- **AC-00-009:** Collection-Konfiguration und Serienmanifest sind validiert, Bestandsübersetzungen geprüft und die zentrale Registeränderung nachgewiesen; erst dann gilt der LH-00-Prozess als abgenommen.

- **AC-00-001:** The documented, available procedure can produce an intake from an issue.
- **AC-00-002:** Each intake includes purpose, current/target state, scope, non-goals, requirements, risks, evidence, acceptance criteria and open decisions.
- **AC-00-003:** No foreign features, build requirements or permissions are imported from TuiVision.
- **AC-00-004:** All normative sections exist in both languages with matching meaning and IDs; terms are explained.
- **AC-00-005:** Each governance row has a source, requirement, acceptance criterion, owner, reviewer and evidence status; Mermaid has equivalent text.
- **AC-00-006:** Both installed validators pass the receipt; a controlled changed target copy is rejected and Create does not overwrite existing targets.
- **AC-00-007:** Authoring, review by a different reviewer (agent or human) than the author, and implementation have distinct states and permissions; no downstream run starts without a request.
- **AC-00-008:** Mac A, Mac B, Windows 11 and WSL2 each have a result with versions, command, exit code and boundary, or a visible open blocker; full process acceptance requires successful evidence from all four environments.
- **AC-00-009:** The collection configuration and series manifest validate, existing-document translations are checked and the central registry change is evidenced; only then is the LH-00 process accepted.

## Qualität und Nachweise / Quality and evidence

- **QG-00-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-00-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-00-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Status und nächster Schritt des Verfahrens bleiben ohne Diagramm verständlich; ein Textbrowser-/Screenreader-Durchgang wird als eigener Nachweisfall geführt.
- **QG-00-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-00-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-00-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-00-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-00-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. The process status and next step are understandable without diagrams; a text-browser/screen-reader walkthrough is a separate evidence case.
- **QG-00-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-00-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-00-001:** Entschieden: vorhandenes GitHub Spec Kit 0.12.8, Intake Authoring Governance 0.3.5, fünf Integrationen und gepinntes Vierzehn-Preset-Profil verwenden. Keine Produkttechnologie festgelegt.

**OD-00-001:** Resolved: use the installed GitHub Spec Kit 0.12.8 with Intake Authoring Governance 0.3.5, the five existing integrations and the pinned fourteen-preset project profile. This does not settle product technology.

## Abschlusskriterien des Authorings / Authoring completion criteria

- [ ] Lastenheft und Receipt anhand des Projektprofils erstellt, validiert und lokal verlinkt.
- [ ] Scope, Nicht-Ziele, Anforderungen, Abnahme, Risiken und beide Sprachen geprüft.
- [ ] Bestehende Abhängigkeiten und IDs erhalten; offene Entscheidungen ausdrücklich markiert.
- [ ] Kein nachgelagerter Lauf und keine Produktfreigabe aus diesem Issue abgeleitet.
- [ ] Veröffentlichungsstatus und Links geprüft; Issue-Aktualisierung ist keine fachliche Abnahme.

- [ ] Intake and receipt created from the profile, validated and linked locally.
- [ ] Scope, non-goals, requirements, acceptance, risks and both languages checked.
- [ ] Existing dependencies and IDs retained; open decisions explicitly marked.
- [ ] No downstream run or product permission inferred from this issue.
- [ ] Publication status and links checked; updating the issue is not domain acceptance.

## Arbeitsauftrag zum Kopieren / Copy-ready request

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-00, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-00, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.

Lokales Ergebnis / Local result: [LH-00](https://github.com/hindermath/Show-CommandTui400/blob/main/intakes/LH-00.md).

## Bestätigte Korrektur / Confirmed correction

IR002 wurde gemäß Owner-Entscheidung präzisiert: FR-00-004 verlinkt Issues und
Lastenhefte, AC-00-007 verlangt einen anderen Prüfer (Agent oder Mensch) als den
Autor. Die [Reparaturentscheidungen](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/planning/lh00-repair-decisions.md)
bewahren den Auftrag; die früheren Entwürfe bleiben historische Quellen.

IR002 is clarified by owner decision: FR-00-004 links both issues and intakes;
AC-00-007 requires another reviewer (agent or human), distinct from the author.
The linked repair decisions record authority; earlier drafts remain historical
sources.
