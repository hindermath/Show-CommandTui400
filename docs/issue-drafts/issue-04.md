# Issue 4: LH-03 — Parameterformular, Parametersätze und Eingabezustand / Parameter form, parameter sets and input state

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-03, Issue #4](https://github.com/hindermath/Show-CommandTui400/issues/4)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:29Z`.
- Originaltext SHA-256 / Original body SHA-256: `50ef697369a9857e67b8f515c7378c1e06d58087a99bd265ac8798b0fbd28ded`.
- Plan-ID: `LH-03`.
- Abhängigkeiten / Dependencies: [LH-02](https://github.com/hindermath/Show-CommandTui400/issues/3).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Komplexe Cmdlet-Signaturen in einem verständlichen, zustandserhaltenden Formular bearbeiten.

Edit complex cmdlet signatures in an understandable form that preserves input state.

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

- **FR-03-001:** Zunächst Pflichtparameter, wichtige Parameter und bereits belegte Felder anzeigen; Kriterien für wichtig explizit festlegen.
- **FR-03-002:** F10 zeigt weitere zum Parametersatz passende Felder, F9 sämtliche Parameter einschließlich Common Parameters; Konflikte und inaktive Felder markieren.
- **FR-03-003:** Parametersätze sichtbar auswählen bzw. anhand der Eingaben eingrenzen; widersprüchliche Kombinationen erklären.
- **FR-03-004:** Nicht angegeben, null, false, leere Zeichenfolge und nullwertige Zahlen unterscheidbar speichern.
- **FR-03-005:** Sichtwechsel, Rücknavigation und F5 erhalten Eingaben; ungültig gewordene Werte sichtbar zur Korrektur vorhalten.
- **FR-03-006:** Dynamische Parameter nach gezielter Kontextänderung auflösen und Herkunft sowie Fehler darstellen.

- **FR-03-001:** Initially show required, important and already assigned parameters; explicitly define the criteria for importance.
- **FR-03-002:** F10 shows further fields matching the parameter set; F9 shows all parameters, including common parameters; mark conflicts and inactive fields.
- **FR-03-003:** Allow visible selection of parameter sets or narrow them from input; explain conflicting combinations.
- **FR-03-004:** Store omitted, null, false, empty string and numeric zero as distinct states.
- **FR-03-005:** View changes, back navigation and F5 preserve input; retain newly invalid values visibly for correction.
- **FR-03-006:** Resolve dynamic parameters after targeted context changes and show their origin and errors.

## Nicht-Ziele / Non-goals

Keine eigene Nachbildung sämtlicher PowerShell-Bindungsregeln.

Do not reimplement all PowerShell binding rules.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-03-001:** Pflichtparameter bleiben sichtbar; F10 und F9 verändern keine eingegebenen Werte.
- **AC-03-002:** Ein Parametersatzwechsel kennzeichnet Konflikte, statt still Werte zu verwerfen.
- **AC-03-003:** Ausgelassen, null, false, Leerstring und 0 sind anhand eigenständiger Fälle unterscheidbar.
- **AC-03-004:** Feldname, Erforderlichkeit, Wertquelle, inaktive Werte und Konflikte sind textuell unterscheidbar; Tab-Reihenfolge und Fokus nach Sichtwechsel werden geprüft.
- **AC-03-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-03-001:** Required parameters remain visible; F10 and F9 do not change entered values.
- **AC-03-002:** A parameter-set switch marks conflicts instead of silently discarding values.
- **AC-03-003:** Separate cases distinguish omitted, null, false, empty string and zero.
- **AC-03-004:** Field name, required status, value source, inactive values and conflicts are textually distinct; test tab order and focus after view changes.
- **AC-03-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-03-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-03-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-03-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Feldname, Erforderlichkeit, Wertquelle, inaktive Werte und Konflikte sind textuell unterscheidbar; Tab-Reihenfolge und Fokus nach Sichtwechsel werden geprüft.
- **QG-03-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-03-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-03-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-03-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-03-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Field name, required status, value source, inactive values and conflicts are textually distinct; test tab order and focus after view changes.
- **QG-03-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-03-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-03-001:** Regel für wichtige Parameter, Darstellung von Arrays/komplexen Objekten und Auslöser dynamischer Auflösung entscheiden.

**OD-03-001:** Decide the rule for important parameters, representation of arrays/complex objects and triggers for dynamic resolution.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-03, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-03, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
