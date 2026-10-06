# LH-00-Barrierefreiheit / LH-00 accessibility

Stand 2026-10-06; Owner Thorsten; Autor Codex; andere Leserprüfung T022.
Wiedervorlage 2026-10-12, praktische Prüfung spätestens T050.
Date and roles above; reassess on changed surfaces and at T050.

Markdown-Quellen, gerenderte Leserpfade, CLI-Ausgaben und Statistikrenderer sind
betroffen. WCAG 2.2 AA gilt soweit passend. Struktur ist maschinell/inhaltlich
prüfbar, echte Hilfsmittelbedienung braucht separate Tests. Heute ist kein
Produkt-TUI-Zugangsmodell implementiert.
Markdown, rendered reading paths, CLI output and statistics are in scope.
Apply relevant WCAG 2.2 AA. Structure can be inspected; assistive operation needs
separate field evidence. No product TUI accessibility model is implemented yet.

| Fläche / Surface | Kriterien / Criteria | Heute / Today | Offen, Owner Thorsten / Open evidence |
|---|---|---|---|
| Markdown | 1.3.1 Struktur, 1.3.2 Reihenfolge, 2.4.6 Überschriften, 3.1.1/2 Sprache / structure, order, headings, language | DE/EN-Überschriften, Listen, echte Linkziele; unabhängiger Leser T022 / structural inspection | Rendering-/Sprachumschaltung, Screenreader und Braille T050 / field checks |
| CLI | 1.4.1 Farbe, 2.1.1 Tastatur, 2.4.3 Fokus, 4.1.3 Status / colour, keyboard, focus, status | JSON/Text nennt Zustände/Fehler, kein Farbzwang / explicit text | Terminalbedienung und Fokus mit Hilfsmitteln je Host T050 / assistive operation |
| Statistik / Statistics | Textalternative, 1.3.1, 1.4.1 / equivalent text and structure | bestehender Renderer, keine neue Visualisierung / existing renderer | sauberer Renderstand und praktische Reader-Prüfung später / later checks |
| Textbrowser / Text browser | Linkzweck und Reihenfolge / link purpose and order | Markdown-Quellprüfung ist kein Textbrowser-Test / source is not browser evidence | gerenderter Pfad in echtem Textbrowser T050 / actual rendered reader path |

Braillegerät, Screenreader-/Tastaturfälle und native Plattformen sind Open / Not
Assessed. Fehlende Geräte sind Blocked, unerwartetes Verhalten Failed. Keine
praktische A11Y-Abnahme oder vollständige WCAG-Erfüllung wird aus Struktur abgeleitet.
Die linearen Texte besitzen alle Zustände, Abhängigkeiten, Entscheidungen und
nächsten Aktionen ohne Diagramm. Diagramme sind begründet N/A für diese Darstellung.
Assistive devices and native platforms remain Open/Not Assessed. Missing tools
block field proof, unexpected behavior fails it. Structure does not grant full
WCAG acceptance. Linear text provides all required information; a diagram adds
no information here and is therefore not used.
