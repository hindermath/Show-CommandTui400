# Issue 8: LH-07 — Optionale Geräteadapter mit Kontext und Sitzungsbindung / Optional device adapters with context and session binding

**Status: Lokaler Änderungsentwurf; nicht auf GitHub veröffentlicht. Kein aktives Lastenheft.**

**Status: Local change proposal; not published on GitHub. Not an active intake.**

- Original: [LH-07, Issue #8](https://github.com/hindermath/Show-CommandTui400/issues/8)
- Abruf / Retrieved: `2026-09-28T18:51:20Z`; Original geändert / Source updated: `2026-09-27T19:00:32Z`.
- Originaltext SHA-256 / Original body SHA-256: `2ceadd4f392da29d8bbd139c39e177ff9f8deffec56717341c4dea28b7651fa8`.
- Plan-ID: `LH-07`.
- Abhängigkeiten / Dependencies: [LH-06](https://github.com/hindermath/Show-CommandTui400/issues/7).

## Auftrag und Zielgruppe / Request and audience

Aus diesem Issue ein eigenständiges zweisprachiges Lastenheft erstellen. Zielgruppe: Projektverantwortlicher, Lastenheft-Autor und spätere Implementierende. Keine vorausgesetzten Spec-Kit-Kenntnisse. Dieses Issue beauftragt keine Produktimplementierung.

Create an independent bilingual intake from this issue for the project owner, intake author and later implementers. Do not assume Spec Kit experience. This issue does not authorize product implementation.

## Zweck und Zielzustand / Purpose and target state

Später dynamische Beschriftungen und Zustandsrückmeldung ermöglichen, ohne das Kernprodukt von Geräten abhängig zu machen.

Later enable dynamic labels and state feedback without making the core product depend on devices.

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

- **FR-07-001:** Stufe 2 transportiert semantische Aktionen und sichtbaren Zustand über optionale Adapter.
- **FR-07-002:** Adapter explizit an eine Sitzung binden; Verwechslungen zwischen mehreren pwsh-Sitzungen vermeiden.
- **FR-07-003:** Aktive Ansicht, verfügbare Aktionen und deaktivierte Aktionen synchronisieren.
- **FR-07-004:** Verbindungsverlust und erneute Verbindung behandeln, ohne Formularzustand zu verlieren oder alte Aktionen nachträglich auszuführen.
- **FR-07-005:** Gleiche Validierung und Ausführungsgrenzen wie bei Tastaturaktionen anwenden.
- **FR-07-006:** Lokale Schnittstelle hinsichtlich Zugriffsschutz, Versionskompatibilität und minimierter Übertragung sensibler Werte definieren.

- **FR-07-001:** Stage 2 transfers semantic actions and visible state through optional adapters.
- **FR-07-002:** Bind adapters explicitly to a session; avoid confusion between multiple pwsh sessions.
- **FR-07-003:** Synchronize the active view, available actions and disabled actions.
- **FR-07-004:** Handle connection loss and reconnection without losing form state or replaying old actions.
- **FR-07-005:** Apply the same validation and execution boundaries as keyboard actions.
- **FR-07-006:** Define access control, version compatibility and minimal transfer of sensitive values for the local interface.

## Nicht-Ziele / Non-goals

Keine Pflicht zu Cloud-Diensten, keine automatische Produktimplementierung vor Abschluss des Kernablaufs.

No mandatory cloud service and no automatic product implementation before the core flow is complete.

## Abnahmekriterien für spätere Umsetzung / Acceptance criteria for later implementation

- **AC-07-001:** Zwei parallel geöffnete Sitzungen erhalten ausschließlich die jeweils zugeordneten Aktionen.
- **AC-07-002:** Hotplug und veraltete Ereignisse lösen keine unbeabsichtigte Ausführung aus.
- **AC-07-003:** Ohne Adapter startet und funktioniert der gesamte Kernablauf; Statusanzeigen kennzeichnen Verbindungsverlust.
- **AC-07-004:** Sitzungszuordnung, Verbindungsverlust und deaktivierte Aktionen sind textuell erkennbar; alle Kernaktionen bleiben ohne Adapter zugänglich.
- **AC-07-005:** Beide Sprachfassungen und die Anforderungs-/Governance-Zuordnung sind vollständig; offene Produktnachweise werden nicht als bestanden dargestellt.

- **AC-07-001:** Two concurrent sessions receive only their assigned actions.
- **AC-07-002:** Hotplug and stale events trigger no unintended execution.
- **AC-07-003:** The entire core flow starts and works without an adapter; status displays identify connection loss.
- **AC-07-004:** Session binding, disconnection and disabled actions are visible in text; all core actions remain accessible without an adapter.
- **AC-07-005:** Both language tracks and the requirement/governance mapping are complete; open product evidence is not presented as passed.

## Qualität und Nachweise / Quality and evidence

- **QG-07-001:** DE zuerst/EN danach, ungefähr CEFR B2; gleiche Bedeutung und IDs, Begriffe bei erster Verwendung erklären.
- **QG-07-002:** Alle anwendbaren Zeilen G01–G12 der Governance-Zuordnung übernehmen, Nachweisfälle zuordnen und N/A begründen. NIST SSDF und CWE Top 25 bleiben anwendbar.
- **QG-07-003:** WCAG 2.2 AA soweit passend; Tastatur, Screenreader, Braille und Textbrowser sowie Status-/Fehlertext berücksichtigen. Sitzungszuordnung, Verbindungsverlust und deaktivierte Aktionen sind textuell erkennbar; alle Kernaktionen bleiben ohne Adapter zugänglich.
- **QG-07-004:** Risiken, Datenschutz, Zustandsverlust, Plattformgrenzen und Fehlerpfade prüfbar erfassen. Behauptete Nachweise mit Quelle, Version, Ergebnis und Grenze belegen; keine Frameworkentscheidung erfinden.
- **QG-07-005:** Hilfreiche Abläufe mit Mermaid und gleichwertiger Textalternative beschreiben; Nichtanwendung begründen. Authoring-, Review-, Prozess- und Produktabnahme getrennt halten.

- **QG-07-001:** German first, English second, about CEFR B2; matching meaning and IDs, with terms explained on first use.
- **QG-07-002:** Apply all relevant G01–G12 governance rows, assign evidence cases and justify N/A. NIST SSDF and CWE Top 25 remain applicable.
- **QG-07-003:** Apply relevant WCAG 2.2 AA criteria; consider keyboard, screen readers, Braille, text browsers and status/error text. Session binding, disconnection and disabled actions are visible in text; all core actions remain accessible without an adapter.
- **QG-07-004:** Make risks, privacy, state loss, platform limits and failure paths testable. Support claimed evidence with source, version, outcome and boundary; invent no framework decision.
- **QG-07-005:** Describe useful flows with Mermaid and equivalent text; justify omission. Keep authoring, review, process and product acceptance separate.

## Entscheidungen / Decisions

**OD-07-001:** Adapterprotokoll, Sitzungswahl, Hersteller-APIs und Linux-Alternativen durch separate Machbarkeitsentscheidung bestimmen.

**OD-07-001:** Determine the adapter protocol, session selection, vendor APIs and Linux alternatives through a separate feasibility decision.

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

> Erzeuge aus diesem Issue ein eigenständiges Lastenheft für Show-CommandTui400, Deutsch zuerst und Englisch danach, ungefähr CEFR B2. Verwende die oben benannten verbindlichen Quellen und das Profil show-commandtui400-de-en mit Authoring 0.3.5. Erhalte LH-07, vorhandene IDs und Abhängigkeiten. Leite passende A11Y-, Sicherheits-, Plattform- und Dokumentationsanforderungen samt Nachweisfällen aus der Governance-Zuordnung ab. Erfinde keine Entscheidungen oder Nachweise. Frage bei wesentlichen Konflikten nach. Kein Produktcode, Review, Folgelauf oder Remote-Schreibzugriff.

> Create an independent Show-CommandTui400 intake in German first and English second, at about CEFR B2. Use the binding sources listed above and profile show-commandtui400-de-en with Authoring 0.3.5. Preserve LH-07, existing IDs and dependencies. Derive relevant accessibility, security, platform and documentation requirements and evidence cases from the governance mapping. Invent no decisions or evidence. Ask about material conflicts. No product code, review, downstream run or remote write.
