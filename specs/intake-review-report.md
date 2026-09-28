# LH-00 Intake-Review / LH-00 intake review

## Ergebnis und Identität / Outcome and identity

**Ergebnis / Outcome: NeedsRemediation.** Ein Ziel, null Worker; 0 Critical,
0 High, 2 Medium, 0 Low. Keine akzeptierten Risiken, keine offenen Fragen.
Die bekannten Qualitätsanforderungen sind nachzubessern; es fehlt keine neue
Produktentscheidung für die Erstellung dieses Reviewberichts.

One target, zero workers; two Medium findings, no Critical/High/Low findings.
No accepted risks or open questions. Known quality requirements need correction;
no new product decision is needed to produce this review report.

- Review-ID: `f0741205-05b7-42c5-8680-451c1483627d`.
- Zeitpunkt / Reviewed at: `2026-09-28T20:55:20Z`.
- Modus / Mode: `Single`, Policy: `generic-markdown` plus Projektprofil / project profile `show-commandtui400-de-en`.
- Geprüfter Stand / Reviewed commit: `2078f29ecfcb4ae3bf6487aee0ca6eaa8d0d7a2f`.
- Ziel / Target: [intakes/LH-00.md](../intakes/LH-00.md).
- Normalisierter SHA-256 / Normalized SHA-256: `b79cc8445dff76053eac428e1d572551a0723619bd8a92ecbd9cf48538d8fd3c`.
- [Anfrage / Request](intake-review-request.json) und [maschinelles Ergebnis / machine result](intake-review-result.json).
- Vorgänger / Supersedes: `N/A` — erstes Review / first review.

Das Review erfolgte nach [PR #13](https://github.com/hindermath/Show-CommandTui400/pull/13)
und sauberer Synchronisation von main. Der Owner hat genau LH-00 benannt.
Verwandte Issues und Dokumente sind Kontext, keine weiteren Reviewziele.
Die installierte allgemeine Review-Policyvorlage und Checkliste wurden zusammen
mit den verbindlichen Projektregeln verwendet. Es gibt keine aktivierte
projektspezifische Review-Policydatei und keine Requirements-Collection-Konfiguration;
beides wird hier nicht als installiert behauptet. Das explizite Review ist
unabhängig davon beauftragt.

Review followed PR #13 and a clean main sync. The owner named only LH-00.
Related issues and documents are context, not extra review targets. The installed
generic policy template and checklist were applied with project rules. No active
project review-policy file or requirements-collection configuration exists;
this report claims neither. The owner explicitly requested this review.

Prüfer ist der ausführende Codex-Agent in einem gesonderten Reviewdurchgang.
Er war zuvor auch am Authoring beteiligt. Dies ist keine unabhängige menschliche
Abnahme und kein Nachweis für die spätere Prozessanforderung AC-00-007.

The executing Codex agent performed a separate review pass after authoring.
This is not independent human acceptance or proof of later process criterion
AC-00-007.

## Befunde / Findings

| ID | Schwere / Severity | Kategorie / Category | Status / Disposition | Owner |
|---|---|---|---|---|
| IR001 | Medium | Zielgruppe und Verständlichkeit / Audience and readability | Offen, nachbessern / Open, remediate | Thorsten Hindermann |
| IR002 | Medium | Normative Sprachparität / Normative language parity | Offen, abgleichen / Open, align | Thorsten Hindermann |

### IR001 — Begriffe erklären / Explain terms

LH-00 setzt in Zeilen 13–30 keine Spec-Kit-Kenntnisse voraus und verlangt in
FR-00-005 sowie AC-00-004 Erklärungen bei erster Verwendung. Dennoch bleiben
„Integrationen“ und „Presets“ (45–46), „Collection-Rollen“ und „Serienmanifest“
(127/140) sowie ASVS, SBOM, VEX und AI-SBOM (151/159) unerklärt. Auch das verlinkte
Profil erklärt die zentralen Collection-Begriffe nicht. Einsteiger können damit
Werkzeugpaket, Projektprofil und Anforderungssammlung nicht zuverlässig
unterscheiden oder die Sicherheitsanwendbarkeit nachvollziehen.

The intake requires no prior Spec Kit experience and promises first-use
explanations, but integrations/presets, collection roles/series manifest and
ASVS/SBOM/VEX/AI-SBOM remain unexplained at the cited lines. The linked profile
does not explain the central collection terms either. Beginners cannot reliably
distinguish tooling packages, project profiles and requirement collections or
interpret security applicability.

Korrektur: passende Erklärungen bei der ersten Verwendung in beiden Sprachen
ergänzen, ohne Anforderungen auszuweiten. Anschließend vollständiger Sprach- und
Reviewdurchgang. Re-Evaluation bei dieser Korrektur oder geändertem Zielgruppen-
beziehungsweise Sprachvertrag.

Remediation: explain relevant terms in both languages at first use without
expanding requirements, then repeat the language check and full review.
Reevaluate after this correction or a changed audience/language contract.

### IR002 — Normative Bedeutung angleichen / Align normative meaning

FR-00-004 nennt deutsch nur das Verlinken von Issue-IDs (Zeile 120), englisch
zusätzlich Lastenhefte (133). AC-00-007 verlangt deutsch ein „unabhängiges Review“
(258), englisch nur ein „separate review“ (268). Eine zeitlich getrennte Prüfung
belegt keine Unabhängigkeit der prüfenden Rolle. Beide Abweichungen betreffen
prüfbare Pflichten und widersprechen der geforderten Bedeutungsparität. Die
Abweichungen stehen auch in der genehmigten Issue-01-Quelle; identische IDs
reichen als Übersetzungsnachweis nicht aus.

FR-00-004 requires issue-ID links in German but additionally intake links in
English. AC-00-007 requires an independent review in German and only a separate
review in English. A separate review pass does not establish reviewer independence.
These differences change verifiable obligations and violate meaning parity.
Both also occur in the approved issue-01 source; matching IDs are insufficient.

Korrektur: die gewünschte Verlinkung und Review-Unabhängigkeit ausdrücklich
bestätigen und in beiden Sprachen gleich formulieren. Betroffene Quellen oder
Issues nur mit passender Änderungsautorität nachführen; Receipt-Historie erhalten.
Re-Evaluation nach autorisiertem Abgleich und vollständigem erneutem Review.

Remediation: explicitly confirm the intended linking and reviewer-independence
obligations and express the same meaning in both languages. Update affected
sources/issues only with appropriate authority and preserve receipt lineage.
Reevaluate after authorized alignment and a complete new review.

## Prüfabdeckung / Coverage

| Bereich / Dimension | Bewertung und Nachweis / Assessment and evidence |
|---|---|
| Identität, Zielgruppe, Ziel / Identity, audience, goal | LH-00, Issue #1, Owner, Datum und Zweck klar; Begriffe siehe IR001. / Identity, owner, date and purpose clear; terminology covered by IR001. |
| Vorwissen und Lesbarkeit / Prior knowledge and readability | Vorwissen ausdrücklich begrenzt; Erklärungen unvollständig, IR001. / Prior knowledge bounded explicitly; explanations incomplete, IR001. |
| Umfang und Nicht-Ziele / Scope and non-goals | Prozessanforderungen und lokale Authoring-Leistung getrennt; keine Produkttechnologie festgelegt. / Process requirements separated from authoring delivery; no product stack selected. |
| Anforderungen und Abnahme / Requirements and acceptance | 12 FR und 9 AC mit identischen IDs in DE/EN, E01–E07 decken sie ab; spätere Prozessprüfungen offen. Bedeutungsunterschiede: IR002. / Matching IDs and evidence mapping; later process checks remain open, meaning differences in IR002. |
| Reihenfolge und Abhängigkeiten / Order and dependencies | LH-00 ohne Vorgänger, Lastenheft-Plan ist maßgeblich; kein Serien-/Workerreview. / No predecessor; intake order is authoritative; no series or worker review. |
| Text und Barrierefreiheit / Text and accessibility | Status und Ablauf als Text plus Mermaid-Alternative; keine alleinige Farbcodierung. Keine assistiven Gerätetests ausgeführt. / Text status and flow plus Mermaid alternative; no color-only meaning; no assistive-device tests performed. |
| Sicherheit, Datenschutz, Lieferkette / Security, privacy, supply chain | SSDF/CWE anwendbar, weitere Standards mit N/A/Open; keine Secrets oder unnötigen personenbezogenen Daten gefunden. Keine Produktsicherheitsabnahme. / Applicability recorded, no detected secrets or unnecessary personal data; no product security acceptance. |
| Plattformen und Nachweise / Platforms and evidence | Beide Macs, Windows 11 und WSL2 getrennt gefordert; fehlende Laufzeitnachweise ehrlich offen. / Four environments distinguished, missing runtime evidence remains open. |
| Quellen und Prompts / Sources and prompts | Lokale Links vorhanden, Receipt gebunden, Specify/Autonomous zeigen dasselbe Ziel; verlangen gesonderten Auftrag und gültiges Review. IR002 betrifft Sprachpflichten. / Local links and hashes valid; prompts bind the same target and require separate authority plus valid review; IR002 affects normative parity. |
| Autorität, Risiken und Folgearbeit / Authority, risks, follow-ups | Aktueller Auftrag erweitert frühere lokale Grenze nur um Lieferung und Review; keine Risikoannahme. Übersetzung, zentrale Übernahme und Prozessnachweise bleiben spätere Arbeit. / Current authority adds delivery/review, not risk acceptance; translations, central adoption and process proof remain later work. |

## Quellenfrische und technische Validierung / Freshness and technical validation

Das Authoring-Receipt bleibt an seinen früheren öffentlichen Snapshot und
unveränderte Dateiquellen gebunden. Die nun veröffentlichten Issue-Texte sind
über den [Publikationsnachweis](../docs/issue-publication.json) separat vergleichbar;
das alte URL-Hashfeld behauptet keine heutige Remote-Frische. Ziel und gebundene
Quellen bleiben unverändert. Hashbildung: ein optionales UTF-8-BOM entfernen,
CRLF/CR nach LF umwandeln; keine weiteren Zeichen oder Leerzeichen ändern.

The authoring receipt retains its earlier public snapshot and unchanged file
sources. Published issue text has separate comparable publication evidence; the
old URL hash does not claim current remote freshness. Target and bound sources
remain unchanged. Hashing removes one optional UTF-8 BOM and converts CRLF/CR to
LF, changing no other characters or whitespace.

Beide installierten Review-Validatoren und beide Authoring-Validatoren
bestehen mit Exit 0. Ein Validator-PASS bestätigt die
Struktur und Hashbindung des Befundes `NeedsRemediation`, keine fachliche
Freigabe. Der unveränderte Intake enthält historisch noch „Review nicht
durchgeführt“; dieses getrennte Ergebnis ist der aktuelle Reviewnachweis.

Both installed review validators and both authoring validators pass with exit 0.
A validator pass confirms structure and hashes of NeedsRemediation, not domain
readiness. The unchanged intake still records the historical pre-review state;
this separate result is current review evidence.

## Entscheidungen und nächster Schritt / Decisions and next step

Keine Risiken wurden akzeptiert. Kein Specify-, Autonomous- oder Produktlauf
wurde gestartet. `NeedsRemediation` ist kein zulässiger Ready-Status. Der nächste
fachliche Schritt ist eine ausdrücklich autorisierte Reparatur von IR001/IR002
mit bestätigter Bedeutung der beiden normativen Stellen, Nachführung betroffener
Quellen und vollständigem erneutem Review. Dieser Reviewauftrag nimmt sie nicht vor.

No risks were accepted and no Specify, Autonomous or product run was started.
NeedsRemediation is not an accepted ready status. The next domain action is
explicitly authorized repair of IR001/IR002, confirming the two normative clauses,
updating affected sources and performing a complete new review. This review
does not perform that repair.

```text
$speckit-intake-repair intakes/LH-00.md — IR001 und IR002 auf Basis von specs/intake-review-result.json; normative Bedeutung vorher bestätigen, Quellenbindung mit Historie erhalten und vollständig erneut reviewen.
```

Dokumentationsentscheidung: UpdateRequired; Owner Thorsten; Leserpfad README →
Reviewbericht → Befunde → autorisierte Reparatur. DE/EN in einer Datei,
Distribution sourceOnly. Kein abgeschlossener Spec-Kit-Feature-Lauf.

Documentation decision: UpdateRequired; owner Thorsten; reader path README →
review report → findings → authorized repair. Both languages share one file;
distribution is sourceOnly. No completed Spec Kit feature run is claimed.
