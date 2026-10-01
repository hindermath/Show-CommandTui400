# Projektstatistik / Project Statistics — Show-CommandTui400

## Methodik / Methodology

Profil 2 zählt Git-getrackte Texte einschließlich importierter Governance und
Wartung. Es misst Lieferdichte, keine Produktqualität oder persönliche Arbeitszeit.
Referenzen: 80 konservativ, vorläufig 100 Zeilen/Arbeitstag für Konzept/Scripting;
bei C#/.NET auf 125 reevaluieren. Noch keine belastbaren Implementierungsphasen.
Die neue LH-00-Prozessspezifikation wird über die Projektkonfiguration ausdrücklich
als Dokumentation gezählt; die Dateinamen-Heuristik würde `spec.md` sonst als Test zählen.

*Profile 2 includes tracked text, imported governance and maintenance tooling.
It measures delivery density, not quality or personal time. Reference values
are 80 and provisionally 100 lines/day; reevaluate to 125 if C#/.NET is chosen.
No implementation phase values are available. The project configuration explicitly
classifies the new LH-00 process specification as documentation; the filename
heuristic would otherwise count spec.md as a test.*

## Fortschreibungsprotokoll / Update Log

| Datum / Date | Arbeitspaket / Work package | Nachweis / Evidence |
|---|---|---|
| 2026-09-27 | Level-2-Einrichtung / Level-2 setup | Fünf Integrationen, 14 Presets, Registry, Hooks, CI und GitHub-Regeln; keine Produktimplementierung. / Five integrations, fourteen presets, registry, hooks, CI and repository rules; no product implementation. |
| 2026-09-28 | Authoring-Patch v0.3.5 / Authoring patch v0.3.5 | Veröffentlichtes Paket, unveränderte übrige Presets, Quellenbindung und Agentenparität; keine Lastenheft- oder Produktarbeit. / Published package, preserved other presets, source binding and agent parity; no intake or product work. [Nachweis / Evidence](maintenance/intake-authoring-v035.md). |
| 2026-09-28 | Lokales LH-00-Authoring / Local LH-00 authoring | DE/EN-Governance, acht unveröffentlichte Issue-Entwürfe, minimales Profil und ein validierter Intake; kein Commit oder Feature-Lauf. / Bilingual governance, eight unpublished issue drafts, a minimal profile and one validated intake; no commit or feature run. [Prüfungen und Grenzen / Checks and limits](lh00-validation.md). |
| 2026-09-28 | Veröffentlichung und Lieferung / Publication and delivery | Acht genehmigte Issues aktualisiert; Authoring-Artefakte für MergeAndSync geliefert. Review folgt getrennt. / Updated eight approved issues and delivered authoring artefacts through MergeAndSync; review follows separately. [Nachweis / Evidence](issue-publication.md). |
| 2026-09-28 | Gesondertes LH-00-Review / Separate LH-00 review | Ein Ziel, NeedsRemediation mit zwei Medium-Befunden; Ziel unverändert, keine Reparatur oder Umsetzung. / One target, NeedsRemediation with two Medium findings; target unchanged, no repair or implementation. [Historisches Review / Historical review](../specs/intake-review-archive/f0741205-05b7-42c5-8680-451c1483627d/intake-review-report.md). |
| 2026-09-28 | LH-00-Reparatur und unabhängiges erneutes Review / LH-00 repair and independent re-review | IR001–IR003 behoben, Ready ohne offene Befunde; neues Receipt mit Vorgängerarchiv, Issue 1 abgeglichen. Keine Prozess- oder Produktabnahme. / Resolved IR001–IR003, Ready with no open findings; successor receipt with predecessor archive, Issue 1 aligned. No process or product acceptance. [Nachweis / Evidence](lh00-repair-validation.md). |
| 2026-09-29 | LH-00-Prozessspezifikation / LH-00 process specification | Zwölf Quellanforderungen und neun Abnahmekriterien in einer DE/EN-Spezifikation mit 16 bestandenen lokalen Qualitätschecks; gültiger Input unverändert, keine Implementierung. / Twelve source requirements and nine acceptance criteria mapped in a bilingual specification with sixteen passed local quality checks; valid input unchanged, no implementation. [Spezifikation / Specification](../specs/001-lh00-intake-process/spec.md), [Nachweise / Evidence](../specs/001-lh00-intake-process/checklists/governance.md). |

| 2026-09-30 | LH-00-Planung und Anforderungsprüfung / LH-00 planning and requirements review | DE/EN-Plan mit Datenmodell, Verträgen und Prüfanleitung; 24 Anforderungsprüfpunkte nach direkter Dokumentkorrektur ausreichend beschrieben (Selbstprüfung). Überflüssige Kontextdatei entfernt. B-01 und praktische Prozessabnahme offen; keine Produktimplementierung. / Bilingual plan, data model, contracts and validation guide; 24 requirements checks adequately specified after document corrections (self-review). Redundant context file removed. B-01 and practical process acceptance remain open; no product implementation. [Plan](../specs/001-lh00-intake-process/plan.md), [Prüfung / Review](../specs/001-lh00-intake-process/checklists/process-quality.md). |

| 2026-10-01 | Gestufte LH-00-Abnahme und Aufgabenplanung / Staged LH-00 acceptance and task planning | Aktualisierter Intake mit Receipt, Vorgängerarchiven und unabhängigem Ready-Review; 65 DE/EN-Aufgaben. Analyze-Befunde C1/I1/I2 korrigiert, erneute Analyse ohne offene Befunde. Neun native CI-Jobs der B-01-Preset-Quellen bestanden; Release-Übernahme und Projektinstallation vor Serienaktivierung offen. Keine Prozessabnahme oder Produktimplementierung. / Updated intake with receipt, predecessor archives and independent Ready review; 65 bilingual tasks. Resolved C1/I1/I2; reanalysis found no open issues. Nine native CI jobs for B-01 preset sources passed; release adoption and project installation remain prerequisites for series activation. No process acceptance or product implementation. [Aufgaben / Tasks](../specs/001-lh00-intake-process/tasks.md), [Nachweis / Evidence](../specs/001-lh00-intake-process/checklists/tasks-validation.md), [CI-Lieferstand / CI delivery](../specs/001-lh00-intake-process/research.md#lieferstand-nach-quellenlieferung--update-after-source-delivery). |

## Gesamtstatistik / Overall Statistics

<!-- project-statistics-v2:begin -->

Profil 2 verwendet Git-getrackte Textdateien und sichtbare Git-Aktivitaet. Die Werte beschreiben Lieferdichte, keine persoenliche Arbeitszeit.

*Profile 2 uses Git-tracked text files and visible Git activity. The values describe delivery density, not personal working time.*

| Kennzahl / Metric | Wert / Value |
|---|---:|
| Textbasis / Text base | 111171 lines |
| Textdateien / Text files | 897 |
| Beobachtbarer Zeitraum / Observable period | 2025-10-05..2026-10-01 |
| Aktivtage / Active days | 5 |
| Relevante Commits / Relevant commits | 18 |
| Zeilen je Aktivtag / Lines per active day | 22234.2 |
| Peak-Tag im Fenster / Peak day in window | 2026-09-27 / 97728 |
| Peak-Woche im Fenster / Peak week in window | 2026-09-27 / 113167 |
| Laengste Serie / Longest streak | 5 days |
| Speedup vs. 80 lines/day | 277.9x |
| Speedup vs. 100 lines/day | 222.3x |
| Methodik / Methodology | v2; source `928b80980c26` |

### Artefaktmix / Artifact Mix

```text
Produktiv / Production          [....................]   0.0% | 0
Tests                           [#...................]   3.8% | 4232
Dokumentation / Documentation   [##############......]  69.8% | 77558
Skripte / Scripts               [#####...............]  24.1% | 26800
Konfiguration / Configuration   [#...................]   2.2% | 2433
Daten und Medien / Data and media [....................]   0.0% | 0
Sonstiger Text / Other text     [#...................]   0.1% | 148
```

Die Balken teilen die aktuelle getrackte Textbasis in stabile Kategorien. Prozent und Zeilenwert sind die genaue, textorientierte Aussage.

*The bars split the current tracked text base into stable categories. Percentages and line counts provide the exact text-first result.*

### Tagesaktivitaet / Daily Activity

```text
Wochen / Weeks 01..26 | 2025-10-05..2026-04-04
So/Su  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Mo/Mo  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Di/Tu  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Mi/We  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Do/Th  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Fr/Fr  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
Sa/Sa  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
```

```text
Wochen / Weeks 27..52 | 2026-04-05..2026-10-03
So/Su  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 4
Mo/Mo  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 4
Di/Tu  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 3
Mi/We  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 3
Do/Th  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 4
Fr/Fr  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -
Sa/Sa  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -
```

DE: 0 = keine Aenderung; 1 = 1..79; 2 = 80..399; 3 = 400..1599; 4 = 1600+ geaenderte Textzeilen; - = noch nicht abgelaufen.

*EN: 0 = no change; 1 = 1..79; 2 = 80..399; 3 = 400..1599; 4 = 1600+ changed text lines; - = not elapsed.*

### Wochenvolumen / Weekly Volume

```text
Wochen / Weeks 01..26 | 2025-10-05..2026-04-04
Keine Aktivitaet / No activity
```

```text
Wochen / Weeks 27..52 | 2026-04-05..2026-10-03
  cap 200000 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      166667 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      133333 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      100000 | . . . . . . . . . . . . . . . . . . . . . . . . . #
       66667 | . . . . . . . . . . . . . . . . . . . . . . . . . #
       33333 | . . . . . . . . . . . . . . . . . . . . . . . . . #
           0 +-----------------------------------------------------
```

Das Wochenvolumen zeigt Additionen plus Loeschungen. Es ist Aenderungsaktivitaet, nicht die aktuelle Groesse des Repositories.

*Weekly volume shows additions plus deletions. It represents change activity, not the current repository size.*

### Kumulative Entwicklung / Cumulative Development

```text
Wochen / Weeks 01..26 | 2025-10-05..2026-04-04
Keine Aktivitaet / No activity
```

```text
Wochen / Weeks 27..52 | 2026-04-05..2026-10-03
  cap 200000 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      166667 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      133333 | . . . . . . . . . . . . . . . . . . . . . . . . . .
      100000 | . . . . . . . . . . . . . . . . . . . . . . . . . #
       66667 | . . . . . . . . . . . . . . . . . . . . . . . . . #
       33333 | . . . . . . . . . . . . . . . . . . . . . . . . . #
           0 +-----------------------------------------------------
```

Die kumulative Kurve summiert nur das Brutto-Aenderungsvolumen im Fenster. Sie darf nicht als aktuelle Codebasis gelesen werden.

*The cumulative curve sums gross change volume within the window only. It must not be read as the current code base.*

### Monatsvolumen / Monthly Volume

```text
Last 12 calendar months
  cap 200000 | . . . . . . . . . . . .
      166667 | . . . . . . . . . . . .
      133333 | . . . . . . . . . . . .
      100000 | . . . . . . . . . . # .
       66667 | . . . . . . . . . . # .
       33333 | . . . . . . . . . . # .
           0 +-------------------------
```

Es liegen keine belastbaren Phasendaten vor. Deshalb zeigt dieses Diagramm Monate und erfindet keine Projektphasen.

*No reliable phase series is available. This chart therefore shows months and does not invent project phases.*

### Beschleunigungsfaktoren / Acceleration Factors

```text
Scale: 0..500x
80 lines/day       [###########.........] 277.9x
100 lines/day      [#########...........] 222.3x
```

Die Faktoren vergleichen sichtbare Lieferdichte mit den dokumentierten manuellen Referenzen. Sie messen keine Arbeitszeit.

*The factors compare visible delivery density with documented manual references. They do not measure working time.*

### Durchsatzvergleich / Throughput Comparison

```text
Scale: 0..50000 lines/day
Experienced manual [#...................] 80
Thorsten solo      [#...................] 100
Visible repository [#########...........] 22234.2
```

Die gemeinsame Skala vergleicht Referenzen und sichtbare Lieferdichte. Sie schreibt die Git-Aktivitaet keiner Person oder KI pauschal zu.

*The common scale compares references with visible delivery density. It does not attribute Git activity to a person or AI by default.*

### Textalternative / Text Alternative

DE: Das Fenster beginnt am 2025-10-05 und endet am 2026-10-01. Es enthaelt 5 aktive und 357 inaktive vergangene Tage. Peak-Tag: 2026-09-27 / 97728. Peak-Woche: 2026-09-27 / 113167. Laengste Serie: 5 Tage (2026-09-27..2026-10-01).

*EN: The window starts on 2025-10-05 and ends on 2026-10-01. It contains 5 active and 357 inactive elapsed days. Peak day: 2026-09-27 / 97728. Peak week: 2026-09-27 / 113167. Longest streak: 5 days (2026-09-27..2026-10-01).*

| Monat / Month | Geaenderte Textzeilen / Changed text lines |
|---|---:|
| 2025-11 | 0 |
| 2025-12 | 0 |
| 2026-01 | 0 |
| 2026-02 | 0 |
| 2026-03 | 0 |
| 2026-04 | 0 |
| 2026-05 | 0 |
| 2026-06 | 0 |
| 2026-07 | 0 |
| 2026-08 | 0 |
| 2026-09 | 109576 |
| 2026-10 | 3591 |

<!-- project-statistics-v2:end -->
