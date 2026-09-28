# Projektstatistik / Project Statistics — Show-CommandTui400

## Methodik / Methodology

Profil 2 zählt Git-getrackte Texte einschließlich importierter Governance und
Wartung. Es misst Lieferdichte, keine Produktqualität oder persönliche Arbeitszeit.
Referenzen: 80 konservativ, vorläufig 100 Zeilen/Arbeitstag für Konzept/Scripting;
bei C#/.NET auf 125 reevaluieren. Noch keine belastbaren Implementierungsphasen.

*Profile 2 includes tracked text, imported governance and maintenance tooling.
It measures delivery density, not quality or personal time. Reference values
are 80 and provisionally 100 lines/day; reevaluate to 125 if C#/.NET is chosen.
No implementation phase values are available.*

## Fortschreibungsprotokoll / Update Log

| Datum / Date | Arbeitspaket / Work package | Nachweis / Evidence |
|---|---|---|
| 2026-09-27 | Level-2-Einrichtung / Level-2 setup | Fünf Integrationen, 14 Presets, Registry, Hooks, CI und GitHub-Regeln; keine Produktimplementierung. / Five integrations, fourteen presets, registry, hooks, CI and repository rules; no product implementation. |
| 2026-09-28 | Authoring-Patch v0.3.5 / Authoring patch v0.3.5 | Veröffentlichtes Paket, unveränderte übrige Presets, Quellenbindung und Agentenparität; keine Lastenheft- oder Produktarbeit. / Published package, preserved other presets, source binding and agent parity; no intake or product work. [Nachweis / Evidence](maintenance/intake-authoring-v035.md). |
| 2026-09-28 | Lokales LH-00-Authoring / Local LH-00 authoring | DE/EN-Governance, acht unveröffentlichte Issue-Entwürfe, minimales Profil und ein validierter Intake; kein Commit oder Feature-Lauf. / Bilingual governance, eight unpublished issue drafts, a minimal profile and one validated intake; no commit or feature run. [Prüfungen und Grenzen / Checks and limits](lh00-validation.md). |
| 2026-09-28 | Veröffentlichung und Lieferung / Publication and delivery | Acht genehmigte Issues aktualisiert; Authoring-Artefakte für MergeAndSync geliefert. Review folgt getrennt. / Updated eight approved issues and delivered authoring artefacts through MergeAndSync; review follows separately. [Nachweis / Evidence](issue-publication.md). |
| 2026-09-28 | Gesondertes LH-00-Review / Separate LH-00 review | Ein Ziel, NeedsRemediation mit zwei Medium-Befunden; Ziel unverändert, keine Reparatur oder Umsetzung. / One target, NeedsRemediation with two Medium findings; target unchanged, no repair or implementation. [Review](../specs/intake-review-report.md). |

## Gesamtstatistik / Overall Statistics

<!-- project-statistics-v2:begin -->

Profil 2 verwendet Git-getrackte Textdateien und sichtbare Git-Aktivitaet. Die Werte beschreiben Lieferdichte, keine persoenliche Arbeitszeit.

*Profile 2 uses Git-tracked text files and visible Git activity. The values describe delivery density, not personal working time.*

| Kennzahl / Metric | Wert / Value |
|---|---:|
| Textbasis / Text base | 100839 lines |
| Textdateien / Text files | 849 |
| Beobachtbarer Zeitraum / Observable period | 2025-10-05..2026-09-28 |
| Aktivtage / Active days | 2 |
| Relevante Commits / Relevant commits | 10 |
| Zeilen je Aktivtag / Lines per active day | 50419.5 |
| Peak-Tag im Fenster / Peak day in window | 2026-09-27 / 97728 |
| Peak-Woche im Fenster / Peak week in window | 2026-09-27 / 101275 |
| Laengste Serie / Longest streak | 2 days |
| Speedup vs. 80 lines/day | 630.2x |
| Speedup vs. 100 lines/day | 504.2x |
| Methodik / Methodology | v2; source `0bf0e998d225` |

### Artefaktmix / Artifact Mix

```text
Produktiv / Production          [....................]   0.0% | 0
Tests                           [#...................]   4.2% | 4232
Dokumentation / Documentation   [##############......]  68.6% | 69179
Skripte / Scripts               [#####...............]  26.6% | 26800
Konfiguration / Configuration   [#...................]   0.5% | 480
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
Di/Tu  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -
Mi/We  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -
Do/Th  0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 -
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
      100000 | . . . . . . . . . . . #
       66667 | . . . . . . . . . . . #
       33333 | . . . . . . . . . . . #
           0 +-------------------------
```

Es liegen keine belastbaren Phasendaten vor. Deshalb zeigt dieses Diagramm Monate und erfindet keine Projektphasen.

*No reliable phase series is available. This chart therefore shows months and does not invent project phases.*

### Beschleunigungsfaktoren / Acceleration Factors

```text
Scale: 0..500x
80 lines/day       [####################] >500x
100 lines/day      [####################] >500x
```

Die Faktoren vergleichen sichtbare Lieferdichte mit den dokumentierten manuellen Referenzen. Sie messen keine Arbeitszeit.

*The factors compare visible delivery density with documented manual references. They do not measure working time.*

### Durchsatzvergleich / Throughput Comparison

```text
Scale: 0..100000 lines/day
Experienced manual [#...................] 80
Thorsten solo      [#...................] 100
Visible repository [##########..........] 50419.5
```

Die gemeinsame Skala vergleicht Referenzen und sichtbare Lieferdichte. Sie schreibt die Git-Aktivitaet keiner Person oder KI pauschal zu.

*The common scale compares references with visible delivery density. It does not attribute Git activity to a person or AI by default.*

### Textalternative / Text Alternative

DE: Das Fenster beginnt am 2025-10-05 und endet am 2026-09-28. Es enthaelt 2 aktive und 357 inaktive vergangene Tage. Peak-Tag: 2026-09-27 / 97728. Peak-Woche: 2026-09-27 / 101275. Laengste Serie: 2 Tage (2026-09-27..2026-09-28).

*EN: The window starts on 2025-10-05 and ends on 2026-09-28. It contains 2 active and 357 inactive elapsed days. Peak day: 2026-09-27 / 97728. Peak week: 2026-09-27 / 101275. Longest streak: 2 days (2026-09-27..2026-09-28).*

| Monat / Month | Geaenderte Textzeilen / Changed text lines |
|---|---:|
| 2025-10 | 0 |
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
| 2026-09 | 101275 |

<!-- project-statistics-v2:end -->
