# Issue 7: LH-06 — Stream Deck XL und Logitech MX Keypad: Tastenprofile / Stream Deck XL and Logitech MX Keypad key profiles

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-06, Issue #7](https://github.com/hindermath/Show-CommandTui400/issues/7)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:31Z`.
- Originaltext SHA-256 / Original body SHA-256: `c36cccd195df134badda06e235c1198d3ad6e456e7f5fd19c14cde69724d30b7`.
- Plan-ID: `LH-06`.
- Abhängigkeiten / Dependencies: [LH-01](https://github.com/hindermath/Show-CommandTui400/issues/2), [LH-05](https://github.com/hindermath/Show-CommandTui400/issues/6).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Beide optionalen Geräte als direkte Ergänzung derselben Tastaturaktionen nutzbar machen.

Make both optional devices usable as direct supplements to the same keyboard actions.

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

- **FR-06-001:** Stream Deck XL und eigenständiges Logitech MX Keypad separat sowie gemeinsam berücksichtigen.
- **FR-06-002:** Stufe 1 verwendet konfigurierbare Tasten-/Hotkey-Zuordnungen; vollständige Kernbedienung bleibt ohne Hersteller-Software möglich.
- **FR-06-003:** Hilfe, Zurück, Prompt, Ansichtswechsel und Finalisierung konsistent mit sichtbarer Tastenleiste belegen.
- **FR-06-004:** Profile und Plattformvoraussetzungen getrennt dokumentieren; Linux-Unterstützung je Gerät/Software nachweisen statt voraussetzen.
- **FR-06-005:** Hotkeys wirken auf das fokussierte Terminal; Grenzen bei mehreren Sitzungen ausdrücklich beschreiben.

- **FR-06-001:** Consider Stream Deck XL and the standalone Logitech MX Keypad separately and together.
- **FR-06-002:** Stage 1 uses configurable key/hotkey mappings; full core operation remains possible without vendor software.
- **FR-06-003:** Map help, back, prompt, view changes and finalization consistently with the visible key legend.
- **FR-06-004:** Document profiles and platform prerequisites separately; prove Linux support for each device/software combination instead of assuming it.
- **FR-06-005:** Hotkeys act on the focused terminal; explicitly describe limitations with multiple sessions.

## Nicht-Ziele / Non-goals

Keine dynamischen Statusanzeigen und keine Behauptung einer offiziellen Logitech-Linux-Unterstützung.

No dynamic status displays and no claim of official Logitech Linux support.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-06-001:** Eine Belegungsmatrix ordnet jede belegte Gerätetaste genau einer fachlichen Aktion zu.
- **AC-06-002:** Abziehen eines Geräts beeinträchtigt die Tastaturbedienung und vorhandenen Eingaben nicht.
- **AC-06-003:** Plattformnachweise unterscheiden geprüft, geplant und nicht unterstützt; unbeabsichtigte Ausführung wird durch gleiche UI-Abläufe verhindert.
- **AC-06-004:** Jede Geräteaktion besitzt eine dokumentierte Tastaturalternative; Beschriftungen und Plattformgrenzen sind auch ohne Geräteabbildung verständlich.
- **AC-06-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-06-001:** A mapping table assigns each configured device key to exactly one domain action.
- **AC-06-002:** Disconnecting a device does not affect keyboard operation or existing input.
- **AC-06-003:** Platform evidence distinguishes tested, planned and unsupported; the same UI flow prevents unintended execution.
- **AC-06-004:** Every device action has a documented keyboard alternative; labels and platform limits are understandable without device images.
- **AC-06-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-06-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-06-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-06-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Jede Geräteaktion besitzt eine dokumentierte Tastaturalternative; Beschriftungen und Plattformgrenzen sind auch ohne Geräteabbildung verständlich.
- **QG-06-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-06-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-06-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-06-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-06-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Every device action has a documented keyboard alternative; labels and platform limits are understandable without device images.
- **QG-06-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-06-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-06-001:** Exakte Geräte-/Software-Versionen sowie portable Ersatzbelegungen für abgefangene Funktionstasten feststellen.

**OD-06-001:** Identify exact device/software versions and portable alternative mappings for intercepted function keys.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-06, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-06, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
