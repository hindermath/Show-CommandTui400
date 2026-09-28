# Issue 6: LH-05 — Aufrufvorschau, Befehlszeilenübernahme und Ausführung / Invocation preview, command-line transfer and execution

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-05, Issue #6](https://github.com/hindermath/Show-CommandTui400/issues/6)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:30Z`.
- Originaltext SHA-256 / Original body SHA-256: `b8228d9907d18069eae01ea4801cda3dd117091b55a06c79d6ba196c979ddfee`.
- Plan-ID: `LH-05`.
- Abhängigkeiten / Dependencies: [LH-03](https://github.com/hindermath/Show-CommandTui400/issues/4), [LH-04](https://github.com/hindermath/Show-CommandTui400/issues/5).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Den vorbereiteten Aufruf nachvollziehbar in die Shell übernehmen oder ausdrücklich in der aktuellen Sitzung ausführen.

Transfer the prepared invocation to the shell transparently or explicitly execute it in the current session.

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

- **FR-05-001:** Vor Abschluss den Aufruf und verbleibende Validierungsprobleme darstellen.
- **FR-05-002:** Übernahme in eine bearbeitbare Befehlszeile und unmittelbare Ausführung als zwei getrennte Aktionen anbieten.
- **FR-05-003:** Integration mit PSReadLine und alternative Hosts untersuchen; fehlende Unterstützung sichtbar erklären.
- **FR-05-004:** Argumente korrekt übertragen; Quoting, Arrays und Variablenreferenzen berücksichtigen, ohne ungeprüfte Textverkettung als Ausführungsmechanismus.
- **FR-05-005:** Ausführung im vereinbarten Sitzungskontext mit Fehlern, Ausgabestreams, Abbruch und Rückkehr zur Shell definieren.
- **FR-05-006:** PowerShell ShouldProcess/Confirm/WhatIf dort erhalten, wo der Zielbefehl sie unterstützt; keine allgemeine Verfügbarkeit vortäuschen.

- **FR-05-001:** Show the invocation and remaining validation problems before completion.
- **FR-05-002:** Offer transfer to an editable command line and immediate execution as separate actions.
- **FR-05-003:** Investigate PSReadLine integration and alternative hosts; visibly explain unsupported cases.
- **FR-05-004:** Transfer arguments correctly, including quoting, arrays and variable references, without unchecked text concatenation as the execution mechanism.
- **FR-05-005:** Define execution in the agreed session context, including errors, output streams, cancellation and return to the shell.
- **FR-05-006:** Preserve ShouldProcess/Confirm/WhatIf where the target command supports them; do not imply universal availability.

## Nicht-Ziele / Non-goals

Keine unaufgeforderte Ausführung und keine implizite Ausweitung auf Remote-Sitzungen.

No unrequested execution and no implicit extension to remote sessions.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-05-001:** Leerzeichen, Anführungszeichen, Unicode, Arrays, false und ausgelassene Parameter werden anhand konkreter Bindungsfälle geprüft.
- **AC-05-002:** Übernahme führt den Aufruf nicht aus; Enter bei der Befehlsauswahl führt ebenfalls nichts aus.
- **AC-05-003:** Sitzungsabhängige Variablen und Module sind gemäß dokumentiertem Modell verfügbar; interaktive Rückfragen bleiben bedienbar.
- **AC-05-004:** Übernehmen und Ausführen besitzen eindeutige textuelle Bezeichnungen; Bestätigung, Abbruch und Rückfragen bleiben mit Tastatur und assistiver Technik bedienbar.
- **AC-05-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-05-001:** Concrete binding cases cover spaces, quotes, Unicode, arrays, false and omitted parameters.
- **AC-05-002:** Transfer does not execute the invocation; Enter in command selection also executes nothing.
- **AC-05-003:** Session variables and modules remain available under the documented model; interactive prompts remain operable.
- **AC-05-004:** Transfer and Execute have clear text labels; confirmation, cancellation and prompts remain operable with the keyboard and assistive technology.
- **AC-05-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-05-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-05-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-05-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Übernehmen und Ausführen besitzen eindeutige textuelle Bezeichnungen; Bestätigung, Abbruch und Rückfragen bleiben mit Tastatur und assistiver Technik bedienbar.
- **QG-05-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-05-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-05-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-05-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-05-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Transfer and Execute have clear text labels; confirmation, cancellation and prompts remain operable with the keyboard and assistive technology.
- **QG-05-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-05-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-05-001:** PSReadLine-Integrationsmechanismus, Objekte ohne verlustfreie Textdarstellung und Verhalten nach Ausführung entscheiden.

**OD-05-001:** Decide the PSReadLine integration mechanism, handling of objects without lossless text representations and behavior after execution.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-05, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-05, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
