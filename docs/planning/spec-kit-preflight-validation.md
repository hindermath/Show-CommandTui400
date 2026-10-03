# Preflight-Dokumentationsprüfung / Preflight documentation validation

Stand / Date: 2026-10-04. Owner: Thorsten Hindermann.

DE: Auftrag ist die Dokumentation bestehender Prüfungen, ohne neue Automatisierung.
Quelle ist [Issue #19](https://github.com/hindermath/Show-CommandTui400/issues/19),
einschließlich technischem Abschluss und Test-Nachlauf. Historische Nachweise
bleiben unverändert. Kanonische Anleitung:
[Entwicklungsumgebung](../Entwicklungsumgebung.md#vor-einem-spec-kit-lauf-nach-fetchpull--before-a-spec-kit-run-after-fetchpull).
Documentation Impact: **UpdateRequired**;
[strukturierte Evidence](spec-kit-preflight-documentation-impact.json).
Leserpfad: README → Entwicklungsumgebung → Preflight → Start-Gates → LH-00.

EN: The request documents existing checks without new automation. Issue #19,
including technical closeout and the test follow-up, is the source. Historical
evidence remains intact. The linked environment guide is canonical. Documentation
Impact is UpdateRequired, recorded in the linked structured evidence. Reader path:
README → environment guide → preflight → start gates → LH-00.

## Fachliche Fallprüfung / Semantic scenario review

Die folgenden Fälle sind eine Prüfung der Anleitung, keine ausgeführten
Produktläufe oder manipulierten Intake-Nachweise.

These cases review the guide; they are not executed product runs or modified
intake evidence.

| Fall / Case | Erwartete Entscheidung der Anleitung / Expected guide decision |
|---|---|
| Sauberer Stand / Clean state | Passende Branch-/Scope-Wahl, alle Pflichtchecks und aktuelle Autorität vor dem Start. / Matching branch/scope, required checks and current authority before starting. |
| Lokale Änderungen / Local changes | Auftrag zuordnen, Konflikte klären; kein automatisches Verwerfen. / Assign to a scope and resolve conflicts; no automatic discard. |
| Fehlgeschlagener Basischeck / Failed base check | Start blockiert; Ursache und nächste Klärung nennen, spätere Erfolge heben Fehler nicht auf. / Block start, report cause/resolution; later successes do not cancel failure. |
| Veraltetes Review / Stale review | Quellhash-/Governance-Auswirkung prüfen und erforderliche Nachprüfung gesondert beauftragen. / Inspect source hashes/governance impact and obtain matching authority for required rechecking. |
| Kein zulässiger Kandidat / No eligible candidate | Trotz möglicherweise validem Serienstatus kein Ziel ausführen oder Reihenfolge ändern. / Do not execute a target or reorder it even if the series state is valid. |
| Fehlendes Werkzeug / Missing tool | Betroffenen Schritt blockieren, Installation nicht behaupten oder automatisch starten. / Block the affected step; do not claim or start installation automatically. |

## Technische Prüfung und Grenzen / Technical validation and limits

| Prüfung / Check | Ergebnis / Result |
|---|---|
| Documentation-Impact-Validator | PASS, Schema 1.1 mit Leserpfad und Quellenbindung. / PASS, schema 1.1 with reader path and source reference. |
| 14er-Preset-Matrix Bash und PowerShell | PASS, exakte Versionen/Prioritäten. / PASS, exact versions/priorities. |
| Lokale Markdown-Links und Anker | PASS, 24 geprüfte Ziele einschließlich explizitem HTML-Anker. / PASS, 24 destinations including the explicit HTML anchor. |
| Bash-/PowerShell-Beispielsyntax | PASS, Bash-Syntaxcheck und PowerShell-Parser. / PASS, Bash syntax check and PowerShell parser. |
| PowerShell-Parameter | PASS, dokumentierte Parameter anhand der Skriptmetadaten geprüft. / PASS, documented parameters checked against script metadata. |
| Guidance-/Constitution-Hashvergleich | PASS, dokumentiertes Beispiel lokal ausgeführt. / PASS, documented example executed locally. |
| Sechs fachliche Fälle oben | Anhand der Anleitung nachvollzogen; keine Produkt-Testläufe. / Reviewed against the guide; no product test runs. |
| Feature-020-Dokumentationssuite | SKIP: zugehörige Feature-Artefakte sind hier nicht installiert; kein Test ausgeführt. / SKIP: feature artifacts are not installed here; no test executed. |
| `git diff --check` | PASS für die lokale Änderung. / PASS for the local change. |
| Secret-Scan vor Lieferung / Pre-delivery secret scan | PASS, keine High-/Medium-Befunde. / PASS, no high/medium findings. |
| PSScriptAnalyzer vor Lieferung / Pre-delivery PSScriptAnalyzer | PASS, Version 1.25.0, 73 Dateien ohne Error/Warning. / PASS, version 1.25.0, 73 files without errors/warnings. |
| Ursprünglicher Statistik-CheckOnly / Initial statistics CheckOnly | DRIFT nach Dokumentationsänderung; Vorschau erfolgreich. Schreiben durch Renderer abgelehnt, da Arbeitsbaum nicht sauber. / DRIFT after documentation changes; preview succeeded. Renderer rejected writing because the worktree is not clean. |

DE: Bei Abschluss der lokalen Dokumentationsarbeit wurde das Fortschreibungsprotokoll
ergänzt; Statistikgenerierung war durch den unsauberen Arbeitsbaum blockiert.
Die zwei neuen Evidence-Dateien waren noch untracked. Der Owner hat danach
Commit/Push und MergeAndSync mit Admin-Bypass ausdrücklich beauftragt. Die Lieferung
folgt dem bestehenden Ablauf: Inhaltscommit, Renderer-Vorschau und Generierung,
CheckOnly, separater Statistikcommit, PR-Checks am exakten Head, Merge und Sync.
Der Admin-Bypass ersetzt keine technische Prüfung. Ergebnisse der Remote-Lieferung
werden im PR dokumentiert; die ursprüngliche Blockade wird nicht als Erfolg gewertet.

EN: At local documentation closeout, the ledger was extended while statistics
writing was blocked by the dirty worktree. The two new evidence files were still
untracked. The owner then explicitly authorized commit/push and MergeAndSync with
admin bypass. Delivery follows the existing process: content commit, renderer
preview and generation, CheckOnly, separate statistics commit, exact-head PR checks,
merge and sync. Admin bypass does not replace technical validation. Remote delivery
results are recorded in the PR; the initial blockage is not treated as success.

DE: Keine neuen Validatoren oder Produkt-Builds. Bash-Feature-Prerequisites sind
installiert, native PowerShell-Basisskripte nicht. Dokumentierte PowerShell-
Wartungsbefehle ersetzen diese offene Plattformabnahme nicht. Keine Statusprüfung,
Serienaktivierung, neue Reviews, Implementierung im Rahmen der ursprünglichen Dokumentationsarbeit ausgeführt.

EN: No new validators or product builds. Bash feature prerequisites exist; native
PowerShell base scripts do not. Documented PowerShell maintenance commands do not
close that platform acceptance gap. No intake status check, series activation,
new review or implementation was performed during the original documentation work.
