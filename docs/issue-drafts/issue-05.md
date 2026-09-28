# Issue 5: LH-04 — Wertehilfe, Variablen, Completion und Validierung / Value assistance, variables, completion and validation

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-04, Issue #5](https://github.com/hindermath/Show-CommandTui400/issues/5)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:29Z`.
- Originaltext SHA-256 / Original body SHA-256: `e9ae4e3c259e4c9187d7fb616c07527740eb16219edce121b5526494b843021d`.
- Plan-ID: `LH-04`.
- Abhängigkeiten / Dependencies: [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Passende Eingaben finden, ohne Vorschläge mit verbindlichen Einschränkungen zu verwechseln.

Find suitable input without confusing suggestions with binding restrictions.

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

- [Constitution](../../constitution.md)
- [Agenten-Guidance / Agent guidance](../../AGENTS.md)
- [Governance-Zuordnung / Governance mapping](../intake-governance.md)
- [Bedienkonzept / Interaction concept](../Bedienkonzept.md)
- [Reihenfolge / Order](../Lastenheft-Plan.md)
- [Entwicklungsumgebung / Development environment](../Entwicklungsumgebung.md)
- [Authoring-Profil / Authoring profile](../../.specify/memory/intake-authoring-profile.md)
- [Sicherheitsanwendbarkeit / Security applicability](../security/README.md)

## Anforderungen / Requirements

- **FR-04-001:** Datentypen, Pflichtstatus und Hilfe feldbezogen anzeigen.
- **FR-04-002:** Enum und ValidateSet als begrenzte Wertemengen behandeln; ArgumentCompleter-Ergebnisse als Vorschläge kennzeichnen.
- **FR-04-003:** Festwert, Variablenreferenz und Ausdruck als unterscheidbare Eingabearten anbieten.
- **FR-04-004:** Ausdrücke beim Tippen nicht ausführen; Variablen im aktuellen Sitzungskontext auflösen.
- **FR-04-005:** Seiteneffekte, Laufzeit und Abbruch von Completern und dynamischen Metadaten berücksichtigen; keine Reinheit versprechen.
- **FR-04-006:** Validierungsfehler verständlich beim Feld anzeigen; endgültige PowerShell-Bindung bleibt maßgeblich.

- **FR-04-001:** Show data types, required status and help for each field.
- **FR-04-002:** Treat Enum and ValidateSet as bounded value sets; label ArgumentCompleter results as suggestions.
- **FR-04-003:** Offer literal value, variable reference and expression as distinct input modes.
- **FR-04-004:** Do not execute expressions while typing; resolve variables in the current session context.
- **FR-04-005:** Account for side effects, run time and cancellation of completers and dynamic metadata; do not promise purity.
- **FR-04-006:** Show understandable validation errors at the field; final PowerShell binding remains authoritative.

## Nicht-Ziele / Non-goals

Kein allgemeiner PowerShell-Editor und kein pauschales Sicherheitsversprechen für fremden Modulcode.

No general PowerShell editor and no blanket security guarantee for third-party module code.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-04-001:** Enum-/ValidateSet-Auswahl und freie Completion verhalten sich entsprechend ihrer unterschiedlichen Semantik.
- **AC-04-002:** Ein Ausdruck mit Seiteneffekt wird durch bloßes Tippen und Navigieren nicht ausgeführt.
- **AC-04-003:** Fehlerhafte und langsame Completion blockiert die Oberfläche nicht unbegrenzt und verliert keine Eingabe.
- **AC-04-004:** Vorschlag, verbindliche Wertemenge, Fehler und Abbruch sind textuell unterscheidbar; der Rückweg aus der Wertehilfe ist per Tastatur erreichbar.
- **AC-04-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-04-001:** Enum/ValidateSet selection and free completion follow their different semantics.
- **AC-04-002:** Typing and navigating alone do not execute an expression with side effects.
- **AC-04-003:** Failing or slow completion does not block the interface indefinitely or discard input.
- **AC-04-004:** Suggestions, binding value sets, errors and cancellation are textually distinct; keyboard access permits returning from value assistance.
- **AC-04-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-04-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-04-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-04-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Vorschlag, verbindliche Wertemenge, Fehler und Abbruch sind textuell unterscheidbar; der Rückweg aus der Wertehilfe ist per Tastatur erreichbar.
- **QG-04-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-04-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-04-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-04-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-04-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Suggestions, binding value sets, errors and cancellation are textually distinct; keyboard access permits returning from value assistance.
- **QG-04-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-04-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-04-001:** Policy für auszuführende Completer, sensible Werte und Auflösung von Variablen entscheiden.

**OD-04-001:** Decide the policy for executing completers, handling sensitive values and resolving variables.

## Abschlusskriterien des Authorings / Authoring completion criteria

- [ ] Lastenheft und Receipt anhand des Projektprofils erstellt, validiert und lokal verlinkt.
- [ ] Scope, Nicht-Ziele, Anforderungen, Abnahme, Risiken und beide Sprachen geprüft.
- [ ] Bestehende Abhängigkeiten und IDs erhalten; offene Entscheidungen ausdrücklich markiert.
- [ ] Kein nachgelagerter Lauf und keine Produktfreigabe aus diesem Issue abgeleitet.
- [ ] Veröffentlichungsstatus ehrlich ausgewiesen; Remote-Link erst nach gesonderter Lieferung ergänzen.

- [ ] Intake and receipt created from the profile, validated and linked locally.
- [ ] Scope, non-goals, requirements, acceptance, risks and both languages checked.
- [ ] Existing dependencies and IDs retained; open decisions explicitly marked.
- [ ] No downstream run or product permission inferred from this issue.
- [ ] Publication status stated honestly; add a remote link only after separate delivery.

## Arbeitsauftrag zum Kopieren / Copy-ready request

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-04, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-04, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
