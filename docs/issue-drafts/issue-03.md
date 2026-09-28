# Issue 3: LH-02 — Cmdlet-Suche, Auswahl und Modulauflösung / Cmdlet search, selection and module resolution

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-02, Issue #3](https://github.com/hindermath/Show-CommandTui400/issues/3)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:28Z`.
- Originaltext SHA-256 / Original body SHA-256: `08470b8ea1e452b826da12dc845712b6f2bd58469284b5c56d6896ff3d95900e`.
- Plan-ID: `LH-02`.
- Abhängigkeiten / Dependencies: [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Mit wenigen Buchstaben vom Verb über das Nomen zum gewünschten Cmdlet gelangen.

Find the desired cmdlet with a few letters, moving from the verb to the noun.

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

- **FR-02-001:** Verbpräfix live filtern; nach vollständigem Verb und Bindestrich das Nomenpräfix berücksichtigen.
- **FR-02-002:** Pfeil hoch/runter navigiert, Enter wählt, F4 öffnet die Parametermaske.
- **FR-02-003:** Gleichnamige Befehle mit Modul und Herkunft unterscheidbar anzeigen.
- **FR-02-004:** Installierte, noch nicht geladene Module soweit Metadaten verfügbar sind auffindbar machen, ohne beim Navigieren zu importieren.
- **FR-02-005:** Gezielte Auflösung beim Öffnen respektiert PSModuleAutoLoadingPreference; ausdrücklich angeforderter Import ist eine getrennte Aktion.
- **FR-02-006:** Moduldialog, unbekannte Exporte, Auflösungsfehler und F5-Aktualisierung berücksichtigen; bereits geladene Module beim Verlassen nicht entladen.

- **FR-02-001:** Filter the verb prefix live; after a complete verb and hyphen, also filter the noun prefix.
- **FR-02-002:** Up/down arrows navigate, Enter selects, and F4 opens the parameter form.
- **FR-02-003:** Distinguish commands with identical names by module and origin.
- **FR-02-004:** Make installed but unloaded modules discoverable where metadata is available, without importing during navigation.
- **FR-02-005:** Targeted resolution on form opening respects PSModuleAutoLoadingPreference; an explicitly requested import is a separate action.
- **FR-02-006:** Cover the module dialog, unknown exports, resolution errors and F5 refresh; do not unload previously loaded modules when leaving.

## Nicht-Ziele / Non-goals

Kein Ersatz für einen Paketmanager oder allgemeines Modulmanagement.

No package-manager replacement or general module management.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-02-001:** Get- und ein ergänztes Nomenpräfix reduzieren die sichtbare Liste nachvollziehbar.
- **AC-02-002:** Navigieren in der Liste löst keine Modulimporte aus.
- **AC-02-003:** All, ModuleQualified und None werden mit dokumentierten Fällen geprüft; Importfehler verlieren Suchtext und Auswahl nicht.
- **AC-02-004:** Treffer, Herkunft, Auswahl und Importfehler sind ohne Farbe verständlich; Aktualisierung erhält eine nachvollziehbare Fokusposition.
- **AC-02-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-02-001:** Get- and an added noun prefix reduce the visible list predictably.
- **AC-02-002:** Navigating the list triggers no module imports.
- **AC-02-003:** Test All, ModuleQualified and None with documented cases; import errors preserve search text and selection.
- **AC-02-004:** Results, origin, selection and import errors are understandable without color; refresh preserves a traceable focus position.
- **AC-02-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-02-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-02-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-02-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Treffer, Herkunft, Auswahl und Importfehler sind ohne Farbe verständlich; Aktualisierung erhält eine nachvollziehbare Fokusposition.
- **QG-02-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-02-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-02-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-02-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-02-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Results, origin, selection and import errors are understandable without color; refresh preserves a traceable focus position.
- **QG-02-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-02-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-02-001:** Umfang für Funktionen, Aliase und native Programme sowie Suchranking explizit entscheiden.

**OD-02-001:** Explicitly decide coverage of functions, aliases and native programs, and search ranking.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-02, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-02, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
