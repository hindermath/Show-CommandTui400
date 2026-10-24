# LH-01 Planprüfung / Plan validation

**Datum / Date:** 2026-10-08. **Autor / Author:** Codex /root.

## Ausgeführte Prüfung / Performed checks

- [x] Aktiver Featurepfad und Setup-plan JSON korrekt; Git weiterhin main. / Correct feature resolution; Git remains main.
- [x] Aktueller Receipt und unabhängiges Ready-Review maschinell geprüft. / Current receipt and distinct Ready review validated.
- [x] Zwei Rechercheagenten, nur Primärdokumentation, keine Implementierung. / Two read-only primary-source research agents.
- [x] Sechs Planungsartefakte mit DE/EN, Scope/Pilot und konkreten Proof-Gates. / Six bilingual design artifacts with scope/pilot gates.
- [x] Daten-/Aktions-/Sitzungs-/Terminalverträge und F01–07 zu AC/E01 zugeordnet. / Contracts and cases mapped to acceptance.
- [x] Lokale Markdownlinks, Blockgrenzen, Platzhalter und Whitespace geprüft. / Local links, fences, placeholders and whitespace checked.
- [x] Alle 46 normativen Spec-Sprachzeilen unverändert; Intake-Zielhash stimmt. / All 46 normative spec lines unchanged; intake hash matches.
- [x] Keine Extension-Hooks registriert; kein automatischer Folgelauf. / No registered hooks or automatic follow-up.
- [x] Agent-Kontextschritt nachvollziehbar behandelt: Skript fehlt, frühere redundante Kontextdatei auf Owner-Auftrag entfernt; kein Ersatz/Guidance-Update. / Context script absent; prior owner rejects redundant file, no replacement/shared mutation.

## Historischer Erststand der Gates / Historical initial gates

- [ ] F01–F06 experimentell auf benannten Plattform-/Hilfsmittelkombinationen bestanden. / Actual platform and assistive proof passed.
- [ ] F07 mit Abhängigkeits-/native Prüfung, getrennten ADRs und anderem technischem Review abgeschlossen. / Dependency/native review and distinct technical assessment complete.
- [ ] OD-01-001/002 endgültig entschieden; Design-/Produktstart-Gate bestanden. / Final technical decisions and product-start gate passed.

Ergebnis: Entwurfsartefakte vorhanden, strenger Planabschluss nicht erreicht.
Dokumentierte Machbarkeit und lokale Versionslesung ersetzen keine experimentellen
Nachweise. Owner Thorsten; beauftragter technischer Autor und anderer Prüfer,
Fälligkeit vor Produktimplementierung, Wiedervorlage bei Proof-/Scope-/Versionsänderung.

Result: design artifacts exist, but the strict planning gate is not complete.
Documentation/local version inspection substitutes for no experimental evidence.
Thorsten owns the open gates; commissioned author/distinct reviewer must supply
proof before product implementation and revisit failed/changed proof or versions.

**Historischer Stand vor dem Machbarkeitsauftrag / Historical state before feasibility:**
Kein tasks.md, Produktgerüst, Prototyp, Paketinstallation, Commit, Push, Remote-
Write oder Serienmutation. Intake/Receipt/Review, Constitution, Guidance und
Statistik bleiben unverändert. Der bestehende Qualitätscheck gilt nur für Spec,
nicht als bestandene neue Machbarkeitsabnahme.

No tasks/scaffold/prototype/install/delivery/series change. Existing provenance,
constitution/guidance/statistics are unchanged. Spec quality is not feasibility
acceptance. Next work is an explicitly commissioned isolated feasibility increment.

## Historischer erster Machbarkeitsnachtrag / Historical first feasibility

- [x] Ausdrücklich genehmigter lokaler Routing-Refresh: Aligned. / Approved local refresh aligned.
- [x] Isoliertes Fixture gebaut, 0 Warnungen/Fehler; gepinnter öffentlicher Restore. / Fixture built with zero warnings/errors and pinned public restore.
- [x] Tatsächliche Mac-A-/Linux-Container-Scope- und Modellnachweise dokumentiert. / Actual scope/model proof recorded.
- [x] Reale PTY-Tasten-/Abbruch-/Resize-Teilfälle und fehlgeschlagene Restore-Prüfung dokumentiert. / Actual PTY cases and failed restoration recorded.
- [x] Getrennte Entscheidungen mit unveränderten offenen OD-Gates dokumentiert. / Separate bounded choices with open ODs recorded.
- [x] Anderes technisches Review beauftragt und geliefert; offene Befunde erhalten. / Distinct technical review delivered, findings retained.
- [ ] F04-Restore und übrige reale Tastatur-/Wiederöffnungs-/StopProcessing-Fälle bestanden. / Restoration and remaining real interaction cases passed.
- [ ] Benannte vollständige Plattform-/Screenreader-/Braille-Nachweise vorhanden. / Full named platform/assistive proof present.
- [ ] Native MSL-/Lieferkettenbewertung und endgültige OD-Entscheidungen abgeschlossen. / Native assessment/final ODs complete.

Aktuelle [Ergebnisse](../feasibility/README.md) und
[anderes Review](../feasibility/independent-review.md) ersetzen keinen fehlenden
Nachweis. Vorhandenes Intake-Ready bleibt fachliches Intake-Review, keine
technische Produktfreigabe. Intake/Receipt/Review und normative Spec-IDs unverändert.

Current results/distinct review do not substitute for missing proof. Intake Ready
remains requirements review, not technical product approval. Provenance/spec IDs
remain unchanged.

## Aktuelle Korrektur und Auswahl / Current correction and selection

- [x] Expliziter dotnet-Treiber und nachgewiesene Darwin-ABI; ANSI-Pfad ausgeschlossen. / Explicit dotnet/verified Darwin ABI, no ANSI fallback.
- [x] Normales Ende, Fehler, Ctrl+C und tatsächliches StopProcessing: konfigurierbare Modi/Shellrückgabe erhalten. / Actual restore and caller input.
- [x] PENDIN als alleinige native Kontrolldifferenz begründet; rohe Daten erhalten. / Only reproduced PENDIN distinguished, raw evidence retained.
- [x]13 PTY-Fälle,67 Vertragsassertionen; Keys/Remap/Wiederöffnen/Resize und Negativfälle. / Actual bounded cases/assertions.
- [x]24 Paket-Contenthashbindungen und native Grenzen gesondert bewertet. / Package/native assessment.
- [x] OD-01-001/002 technisch ausgewählt, Spec/Plan/Verträge abgeglichen. / ODs selected, design aligned.
- [x] Owner-Auftrag: reale Terminal-/Screenreaderprüfung jetzt deferred, Braillehardware-Nachweis ausgeschlossen und begründet. / Owner evidence limits recorded.
- [ ] Vollständige praktische Plattform-/A11Y-/Featureabnahme. / Full practical acceptance.

[Aktuelle Ergebnisse](../feasibility/README.md) und
[anderes Review](../feasibility/independent-review.md) bewerten den korrigierten
Payload. Kein PASS für zurückgestellte/ausgeschlossene Nachweise. Kein tasks.md,
Produktstart oder Remoteauftrag automatisch ausgeführt. Bindende vorgelagerte
Quellen bleiben unverändert; vor tatsächlichem Produktstart Ausrichtung/Frische
und Security-/Architecture-Gates berücksichtigen.

Current evidence/distinct review assess the corrected payload. Deferred/excluded
proof is not PASS. No automatic tasks/product/delivery. Prior sources stay intact;
source freshness/security/architecture readiness precedes product start.

## Quellen-/Analysevalidierung 2026-10-21 / Source and analysis validation

### DE

Auftrag: Quellenupdate LH-01, vollständiges anderes Review, gezielter Spec-/Plan-/Tasks-Abgleich und MergeAndSync/Admin-Bypass. Quelle: PR #52/702f163 plus erklärte vorherige Änderungen aus PR #49/#51. [Einzelbewertung](../../../docs/planning/lh00-lh01-gsdb344-assessment.md), [Quellenentscheid](../../../docs/planning/lh00-lh01-gsdb344-source-decisions.md). Sechs unterschiedliche Quellenabweichungen je Vorgängerreceipt sind im Entscheid mit alten/neuen Hashes und Git-Verlauf erklärt. Sämtliche vorherigen Generationen bleiben unverändert archiviert. Die normativen Kontrollauszüge erhalten Text und Vollquellhashbindung, ohne öffentliche Schlüssel-Beispielmarker in den Receipt-Quelldateien zu vervielfältigen oder Secret-Prüfungen abzumildern.

Analyse separat für dieses Feature, ausschließlich lesend: Featurepfade wurden explizit über SPECIFY_FEATURE_DIRECTORY und --paths-only aufgelöst, damit die persistierte Featureauswahl unverändert bleibt. Spec/Plan/Tasks, Constitution und vorhandene Abdeckungstabellen ausgewertet; kein Hook vorhanden. Keine neue offene Critical-/High-/Medium-/Low-Inkonsistenz im Änderungssatz. Die 29 offenen Anwendbarkeitsentscheidungen und die als Not Assessed erfasste Umsetzung sind ausdrücklich Folgearbeit, keine verdeckten Analysebefunde oder bestandene Abnahme.

| Analysebereich | Ergebnis | Zuordnung |
|---|---|---|
| Anforderungen/Erfolgskriterien | 21 eindeutige prüfbare Kennungen mit Aufgabenabdeckung plus zwei erhaltene technische OD-Entscheidungen; 100% zugeordnet, nicht 100% implementiert | FR-01-001–011; QG-01-001–005; AC-01-001–005 |
| Aufgaben | 65 eindeutige IDs; alle bestehenden Checkboxen unverändert | T001–T063; neu T064/T065 |
| Neue GSDB-Abdeckung | 50/50 Kontroll-IDs, 18 Applicable, 29 Open, 3 begrenzte N/A; Erfüllung getrennt Not Assessed | T064 → T058; T065 → T063 |
| Constitution | Keine neue Pflichtverletzung; Quellen-/Nachweistreue, DE/EN und Auftragstrennung gewahrt | FR-00-007/008/009 bzw. QG-01-002/004 |
| Nicht zugeordnete neue Aufgaben | 0 | Neue Aufgaben konkretisieren vorhandene Governance-Anforderungen |
| Dubletten/Unklarheiten | 0 neue offene Analysebefunde | Fachlicher Umfang und Entscheidungen unverändert |

Routing nach explizit freigegebenem lokalem Refresh Aligned; keine lokale Profil-/Providerkonfiguration versioniert. 14-Preset-Check exakt bestanden, Agenten-/Navigationsparität 7 Tests bestanden. PSScriptAnalyzer1.25.0: 84 Dateien, keine neuen Error/Warning, vier bestehende synthetische Probeausnahmen unverändert. Endgültige Receipt-/Review-, Link-/Secret-/Diff- und Lieferprüfungen werden nach frischen Reviews im abschließenden Nachweisblock ergänzt. Statistikdrift bleibt bis Quellencommit → Rendern → Prüfen → Statistikcommit erwartbar und wird nicht vorzeitig als PASS bezeichnet.

Documentation Impact genau `UpdateRequired`. Owner Thorsten; Zielgruppe Maintainer, Autoren und Lernende ohne Spec-Kit-Vorkenntnisse. Kanonische Quellen sind aktualisierte Intakes, ihre Vorgänger und gebundene Projekt-/GSDB-Dateien; Leserpfad Intake → Receipt/eigenes Review → Zuordnung → Spec/Plan/Tasks → nächste offene Aufgabe. Sprache DE zuerst/EN danach B2, Textalternative für die vollständige tabellarische Zuordnung; kein zusätzliches Diagramm erforderlich. Distribution sourceOnly im Repository, kein Home-Sync oder Flottenrollout. Wiedervorlage bei Quelle/Scope/Rolle und vor betroffenem Gate, spätestens 2027-01-10.

Keine Produkt-/Plattformtests, Installation, Folgefeature, Serienaktivierung oder neue menschliche Risiko-/Pilot-/Vollabnahme aus diesem Auftrag. Der LH-00-Mitgliedshash wurde mit Manifest-/Receipt-Vorgängern nachgeführt, Zustand Ready/Eligible und Kardinalität 1/1/0 Kanten unverändert. Die Plattformbindungen in #37–#39 und der produktive Payload bleiben bytegleich. Reale Terminals/Screenreader Deferred, Braillehardware Excluded; volle LH-00-Abnahme nach LH-02/vor LH-03.

### EN

The explicitly authorised package updates sources and distinct reviews, then aligns technical documents and delivers through exact-head MergeAndSync/admin bypass. The linked source decision explains six distinct predecessor-source drifts per intake with exact history/hashes; preserve all archives. Control excerpts avoid duplicating public key-example markers while retaining full canonical source/hash provenance and strict validation.

Read-only analysis resolves this feature explicitly without persisting feature selection. Compared spec/plan/tasks, Constitution and existing traceability: 21 testable identifiers assigned to 65 unique tasks, no newly unmapped task or open consistency finding. Assigned coverage is not implementation coverage. All 50 changed controls have scope/evidence rows; 29 applicability decisions and unassessed implementation remain owned follow-up work. Existing checkboxes stay unchanged. No extension hook exists.

Routing is Aligned after separately authorised local refresh. Exact fourteen-preset check, seven parity/navigation tests and PowerShell analysis pass with the four pre-existing synthetic probe exceptions. Final receipt/review/link/secret/diff/delivery checks follow below; statistics stay pending until authorised clean-tree rendering and final verification.

One documentation impact: UpdateRequired, Thorsten, maintainers/authors/learners, German-first/English-second B2, canonical source and complete textual reader path stated above. Source-only distribution, no Home/fleet sync. Review source/scope/role changes and affected gates, by 2027-01-10. No product/platform execution, installation, future feature, series activation or new human acceptance. Preserve Ready/Eligible membership, exact target-platform bindings and practical evidence limits.

### Abschließende Quellen-/Reviewprüfung / Final source and review checks

| Prüfung / Check | Ergebnis / Result |
|---|---|
| Receipt 37703cb2-bbb5-43a8-892d-847ecd01928c | Bash und PowerShell Exit0; validierter Kandidat bytegleich publiziert / candidate validated and published identically |
| Review b8cbae27-d13e-499d-bbc2-4f6a84a39cf9 | Ready,0 offene Befunde; vollständiger anderer Prüfer; beide Reviewvalidatoren Exit0 / complete distinct review, both validators pass |
| Herkunft / Provenance | Lokale Quellen, Kontrollquellhashes und Vorgängerarchive stimmen; historische URL/Inline-Metadaten sind keine neue Retrieval-Behauptung / current local hashes and exact archives, historical snapshots remain historical |
| Negativfall / Negative case | Manipulierter Zielhash mit Exit2 abgewiesen / tampered digest rejected |
| Änderungen / Changes | Bisherige Task-Checkboxen, Produktpayload und Plattformbindungen unverändert / existing task states, product and frozen platform bindings unchanged |
| Secrets | high=0, medium=0; Gitleaks kein Befund / no finding |
| Lieferung / Delivery | Quellencommit und sauberes Rendern folgen diesem datierten Prüfschritt; endgültige Statistik-/Homogenitäts- und exakte CI-Ergebnisse im Liefer-PR nachweisen / record final rendering and exact-head CI in delivery PR |

DE: Die beiden Analysen finden keine offenen startrelevanten Inkonsistenzen im Quellen-/Dokumentationsänderungssatz. Das erteilt keinen neuen Implementierungsauftrag und schließt keine der neuen Folgeaufgaben oder offenen Produkt-/Rechts-/Plattformabnahmen.
EN: Both analyses find no open start-relevant inconsistency in this source/documentation change set. No new implementation authority or completion of follow-up tasks, product/legal/platform acceptance follows.

DE: Vor der ersten Git-Lieferung wurden je eine überzählige leere Schlusszeile in zwei neuen Quelldokumenten entfernt. Die Intakes blieben bytegleich. Beide laufenden Authoring-Vorgänge dokumentieren die reinen Formatdeltas und exakte Receipt-Zwischenstände; vorherige Ready-Reviews sind bytegleich archiviert und durch frische unabhängige Reviews überholt. Finale aktuelle Receipt-Validierung schließt die Vorgangsreparatur vor Commit ab.
EN: Before initial Git delivery, remove one extra blank EOF line in each of two new source documents without changing intake bytes. Both authoring operations record exact format deltas and receipt checkpoints; preserve and supersede prior Ready reviews. Fresh distinct reviews and final current receipt validation close repair before commit.

## Prüfung Dokumentationskohorte 24.10.2026 / Documentation cohort validation

### DE

Ownerauftrag: gewöhnliche Aktualisierung LH-01, vollständiges unabhängiges Review, gezielter Spec-/Plan-/Tasks-Abgleich und MergeAndSync/Admin-Bypass. Ausgangspunkt PR #55/c0267d8. [Quellenbewertung](../../../docs/planning/lh00-lh01-preset-doc-rollout-20261024-decisions.md) erklärt alle vier abweichenden lokalen Bindungen mit alten/neuen Hashes und Git-Verlauf. Vorgängerintake und Receipt sind bytegleich archiviert, erste Quelle ist der Vorgängerintake; historische URL-/Inline-Nachweise bleiben historische Metadaten. Neue Versionsangaben erklären aktuelle Paketidentität, keine automatische Befugnis oder neue Produktanforderung.

Lesende speckit-analyze-Auswertung für dieses Feature: Featurepfade explizit über SPECIFY_FEATURE_DIRECTORY und --paths-only aufgelöst; keine persistierte Featureauswahl geändert und kein Extension-Hook vorhanden. Spec, Plan, Tasks, aktuelle Constitution und bestehende Abdeckungstabellen abgeglichen. Ergebnis: keine neue offene startrelevante Inkonsistenz, keine neue Duplikation oder ungeklärte Bedeutungsabweichung. Bestehende Produkt-/Rechts-/Hilfsmittel-/Plattformnachweise bleiben ausdrücklich offen; eine Quellenprüfung ist kein Umsetzungs-PASS.

| Bereich / Area | Ergebnis / Result | Abdeckung / Coverage |
|---|---|---|
| Prüffähige Kennungen / Testable identifiers | 21 mit vorhandener Aufgabenabdeckung, keine neue fachliche ID | FR-01-001–011; QG-01-001–005; AC-01-001–005; zwei technische OD-Entscheidungen zusätzlich erhalten |
| Aufgaben / Tasks | 65 eindeutige IDs; alle vorherigen Checkboxen unverändert | Keine neue oder nicht zugeordnete Aufgabe |
| Quellen / Sources | 14 Pakete/28 Leserpfade mit Version/Pfad/Hash; GSDB und50-Kontroll-Zuordnung unverändert | FR-00-001/002/005/007/008/009 beziehungsweise QG-01-001/002/004 und AC-01-005 |
| Routing | Aligned nach ausdrücklich freigegebenem lokalem Metadaten-Refresh; keine Modellzugangsprobe daraus behauptet | Rollenvertrag statt Installationspriorität; Codex/Antigravity-Automatik von übrigen Policy-Bezeichnungen getrennt |
| Verifikation / Verification | 14-Preset-Check exakt; sieben Agenten-/Navigations-/Kompositionstests bestanden | Sechs bestehende Specify-/Plan-/Tasks-Wrapper und fünf Integrationen; keine neue Generierung |
| Constitution und Nachweisgrenzen / Constitution and limits | Keine neue Pflichtverletzung; N/A/Open/Not Assessed und Ownerentscheidungen erhalten | B2 DE/EN, textuelle Grenzen; keine importierte Level-0-Freigabe |

PSScriptAnalyzer-Nachweis aus dem Rollout bleibt für die unveränderten84 Skriptdateien und vier synthetischen Probeausnahmen gültig; native CI prüft erneut den finalen PR-Head. Receipt-/Reviewvalidatoren, frische unabhängige Reviewidentitäten, Secret-/Link-/Diff- und finale Render-/Homogenitätsprüfungen werden im Abschlussblock bzw. Liefer-PR dokumentiert. Erwarteter Statistikdrift vor Quellencommit/Rendern ist kein PASS.

Documentation Impact genau UpdateRequired. Owner Thorsten; Zielgruppe Maintainer, Lernende und Entwickelnde ohne Spec-Kit-Vorkenntnisse. Quelle: aktualisiertes Intake und gebundene Projekt-/Paketdateien. Leserpfad Intake → Receipt/eigenes Review → Quellenbewertung/DE-EN-Leitfäden → Spec/Plan/Tasks → bestehende nächste Aufgabe. Sprache DE zuerst/EN danach, ungefähr B2. Vollständige Text-/Tabellenalternative; kein zusätzliches Diagramm nötig. Distribution sourceOnly im Repository, kein Home-Sync. Wiedervorlage bei Quelle/Paket/Rolle/Scope/Autorität und vor betroffenem Gate.

Keine Produktimplementierung, Installation, Veröffentlichung eines Pakets, Adapterentwicklung, Serienaktivierung, neue Risiko-/Pilot-/Produktabnahme oder Umbindung #37–#39. Praktische Terminals/Screenreader Deferred, Braillehardware Excluded; volle LH-00-Abnahme weiterhin nach LH-02/vor LH-03. Frühere datierte Nachweise behalten ihren historischen Kontext.

### EN

The explicit request covers ordinary source update, full distinct review, targeted technical alignment and exact-head MergeAndSync/admin delivery after PR #55. The linked source decision explains four local binding drifts with hashes/history. Preserve exact predecessors and historical snapshot metadata. Current package identity never implies new product scope or execution rights.

Read-only analysis resolves this feature without persisting selection and compares spec/plan/tasks, Constitution and existing coverage. All21 testable identifiers are assigned; all65 task IDs/check states remain unchanged. No new open start-relevant inconsistency, duplication or unmapped task. Preserve existing open implementation/legal/practical work. All14 packages/28 language reader paths are bound; reuse unchanged GSDB/control evidence. Current role/discovery limits distinguish metadata from model-access proof. Exact matrix and seven parity/composition tests pass; retain the unchanged script-analysis evidence and explicit synthetic exceptions until final native CI.

One impact decision: UpdateRequired, Thorsten, learner/developer/maintainer audience, source-governed bilingual B2 textual reader path, repository sourceOnly distribution. Review changes before relevant gates. No product, installation, release, adapter, series mutation, platform rebind or inferred acceptance. Preserve all practical and full-process acceptance boundaries.

### Abschließende Quellen-/Reviewnachweise / Final source and review evidence

| Prüfung / Check | Ergebnis / Result |
|---|---|
| Receipt `5166dc4d-afa3-4bd2-a6ad-2776566ec9c2` | Beide installierten Validatoren Exit0; genau geprüfter Kandidat publiziert / both validators pass, exact validated candidate published |
| Review `d73832df-d7ec-4888-a7aa-ab1a80076e53` | Ready,0 offene Befunde/Fragen/akzeptierte Risiken; vollständiger anderer Agent; Bash/PowerShell Exit0 / full distinct review, both validators pass |
| Quellen / Sources | 90 Einträge, alle aktuellen lokalen Bindungen und Archive unabhängig geprüft; historische Snapshots bleiben historisch / all current local bindings and exact archives verified |
| Leitfäden / Guides | 28 Hashbindungen,14 Paketidentitäten aktuell / current guide hashes and package identities |
| Negativfall / Negative case | Manipulierter Zielhash mit Exit2 abgewiesen / tampered target digest rejected |
| Grenzen / Boundaries | Task-IDs/Checkboxen, Produktpayload, Presets, Guidance und Plattformbindungen unverändert / unchanged task states and protected payload |
| Dokument-/Lieferprüfung / Document and delivery checks | Lokale Links, Secret-/Diff-Prüfung und finale Render-/Homogenitäts-/CI-Ergebnisse im Liefer-PR; kein vorzeitiger Statistik-PASS / record final checks in delivery PR after clean-tree rendering |

DE: Alle vier Quellenabweichungen sind erklärt und durch den gewöhnlichen Vorgang mit exakten Vorgängern aktualisiert. Die zwei Analysen finden keine neuen offenen startrelevanten Widersprüche im Dokumentationsänderungssatz. Keine fehlende Produkt-/Rechts-/Hilfsmittelabnahme wird dadurch geschlossen.
EN: All four source drifts are assessed and updated through ordinary preserved lineage. Both analyses find no new open start-relevant inconsistency in this documentation change set; missing product/legal/practical acceptance stays open.
