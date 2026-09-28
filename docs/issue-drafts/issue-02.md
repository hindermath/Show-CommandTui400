# Issue 2: LH-01 — TUI-Grundlage, Sitzungsmodell und Tastaturbedienung / TUI foundation, session model and keyboard operation

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-01, Issue #2](https://github.com/hindermath/Show-CommandTui400/issues/2)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:27Z`.
- Originaltext SHA-256 / Original body SHA-256: `257f02376b1dd560f4398bc9855c9d38f317ae7bdad8a489c57eb81efd491236`.
- Plan-ID: `LH-01`.
- Abhängigkeiten / Dependencies: [LH-00](https://github.com/hindermath/Show-CommandTui400/issues/1).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Show-CommandTui400 startet als Cmdlet in der aktuellen pwsh-Sitzung und bietet eine vollständig tastaturbedienbare Textoberfläche.

Show-CommandTui400 starts as a cmdlet in the current pwsh session and provides a fully keyboard-operated text interface.

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

- **FR-01-001:** macOS, Linux und Windows mit geeigneten Terminals einschließlich Windows Terminal berücksichtigen; keine Desktop-GUI voraussetzen.
- **FR-01-002:** Ein gemeinsames Aktionsmodell für Tastatur und optionale Geräte definieren.
- **FR-01-003:** F1 Hilfe, F3 Beenden, F4 kontextbezogene Eingabehilfe, F5 Aktualisieren, F9 alle Parameter, F10 weitere Parameter, F11 Details sowie F12/Esc Zurück vorsehen.
- **FR-01-004:** Funktionstasten remappbar machen und sichtbare Alternativen anbieten; Eingabe, Auswahl und Ausführung als getrennte Aktionen modellieren.
- **FR-01-005:** Terminalzustand bei regulärem Ende, Abbruch und Fehler wiederherstellen; Resize und zu kleine Fenster behandeln.

- **FR-01-001:** Support macOS, Linux and Windows with suitable terminals, including Windows Terminal; do not require a desktop GUI.
- **FR-01-002:** Define a shared action model for the keyboard and optional devices.
- **FR-01-003:** Provide F1 help, F3 exit, F4 contextual input assistance, F5 refresh, F9 all parameters, F10 more parameters, F11 details and F12/Esc back.
- **FR-01-004:** Allow function-key remapping and show alternatives; model input, selection and execution as separate actions.
- **FR-01-005:** Restore terminal state after normal exit, cancellation and failure; handle resize and windows that are too small.

## Nicht-Ziele / Non-goals

Kein endgültiges TUI-Framework und keine .NET-Zielversion ohne Machbarkeitsentscheidung festlegen.

Do not choose a final TUI framework or .NET target version without feasibility evidence.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-01-001:** Die fachlichen Abläufe sind ohne Maus und Zusatzgerät erreichbar.
- **AC-01-002:** Ein Machbarkeitsnachweis dokumentiert Eingabe, Resize, Abbruch und Wiederherstellung auf allen drei Plattformen.
- **AC-01-003:** Die aktuelle Sitzung bleibt erhalten; Architekturentscheidung benennt Runspace-, Host- und Terminalgrenzen.
- **AC-01-004:** Fokus, Tastenalternativen, zu kleines Terminal und Rückkehr zur Shell werden ohne Maus sowie mit Screenreader/Braille geprüft; nicht ausgeführte Fälle bleiben offen.
- **AC-01-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-01-001:** All domain flows are accessible without a mouse or an additional device.
- **AC-01-002:** A feasibility proof documents input, resize, cancellation and restoration on all three platforms.
- **AC-01-003:** The current session is retained; the architecture decision identifies runspace, host and terminal boundaries.
- **AC-01-004:** Test focus, key alternatives, a small terminal and shell restoration without a mouse and with screen-reader/Braille access; unexecuted cases remain open.
- **AC-01-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-01-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-01-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-01-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Fokus, Tastenalternativen, zu kleines Terminal und Rückkehr zur Shell werden ohne Maus sowie mit Screenreader/Braille geprüft; nicht ausgeführte Fälle bleiben offen.
- **QG-01-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-01-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-01-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-01-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-01-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Test focus, key alternatives, a small terminal and shell restoration without a mouse and with screen-reader/Braille access; unexecuted cases remain open.
- **QG-01-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-01-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-01-001:** Framework, minimale PowerShell-Version, Terminalmatrix und Verhalten bei umgeleiteten Streams festlegen.

**OD-01-001:** Select the framework, minimum PowerShell version, terminal matrix and behavior with redirected streams.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-01, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-01, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
