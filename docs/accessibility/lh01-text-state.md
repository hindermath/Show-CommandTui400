# LH-01 Textzustand und Größe / Text state and size

## DE — Begrenzter Mac-A-Nachweis E01-03/E01-05

T045–T051 ergänzen Textzustand, sichere Fehler, vertikale Knöpfe, blätterbare
Hilfe und Größenkoordination. Mac A ist das MacBook Air M2 2023. Namen,
Verfügbarkeit, Fokus, Busy (beschäftigt), Status, Fehler und Legende werden ohne
alleinige Farbbedeutung ausgegeben. Die Benutzertexte stehen gleichwertig in
Messages.de.resx und Messages.en.resx; DE steht zuerst. Steuer- und unsichtbare
Formatzeichen in dynamischen Zuständen werden durch Fragezeichen ersetzt.
Es gibt keine Ausgabe privater Sitzungswerte.

Die Normalansicht benötigt die längste feste zweisprachige Knopfbeschriftung
plus sechs Rand-/Knopfzellen in der Breite. Die Höhe von13Zeilen ergibt sich aus
3Knöpfen,4Zustandszeilen,2Hilfszeilen und4Layout-/Randzeilen. Das sind Grenzen
dieses konkreten Layouts, keine neue fachliche Intake-Schwelle. Hilfe/Aktionen
lassen sich per Bildtasten blättern; Tab/Pfeile behalten ihre Fokusnavigation.
Bei kleinerer Größe zeigt die TUI eine kurze Erklärung mit Alt+H/Alt+X/Esc.
Bei extremen Größen wie1x1 kann kein lesbarer Volltext garantiert werden; die
Tastenbehandlung erlaubt dennoch die sichere Rückkehr zur Shell.

Resize verändert weder lokale Werte noch den logischen Fokus. Die Normalansicht
wird vorübergehend ausgeblendet; nach Vergrößern wird derselbe Fokus restauriert.
Hilfe/Zurück/Beenden bleiben global erreichbar. Andere Aktionen sind während
der Größenwarnung ohne Wirkung. Es werden keine Folgeformulare erzeugt.

Automatisierte Produktfälle: TextState (synthetisch eingesetzter Busy-/Fehlertext),
Resize (100x24 →20x5 →110x30, Werte/Fokus und anschließende Navigation), SmallExit
(Hilfe/Beenden bei20x5), TinyExit (Beenden bei1x1). Die Rohbelege und ihre Hashes
stehen in [text-state-maca](../validation/lh01/text-state-maca/manifest.json).
Die synthetische Busy-Injektion belegt die Darstellung; der lokale Refresh ist
synchron und startet keinen fachlichen Hintergrundvorgang. Interne Testseams
sind nicht als Cmdletparameter exportiert. Modelltests prüfen zusätzlich die
exakten Größenränder und alle DE/EN-Ressourcenschlüssel.

| Spec-Oberfläche / Kriterium | Anwendbarkeit und Ergebnis | Offene Grenze |
|---|---|---|
| Navigation:2.1.1,2.1.2,2.4.3 | Applicable; synthetische Tastatur/Fokus/Rückkehr lokal geprüft | Fremde Hosts und reale Terminalübertragung offen |
| Fokus/Legende:2.4.7,2.4.11,1.4.1 | Applicable; Textfokus, Verfügbarkeit, Resize und Wiederaufnahme geprüft | Keine praktische Sicht-/Hilfsmittelabnahme |
| Fehler/Zustand:3.3.1,3.3.3,4.1.2,4.1.3 | Applicable; sichere Textfehler, Namen/Rollenhinweis und Busy/Status | Textrolle ist keine native Screenreader-Schnittstelle; Hostgrenzen offen |
| Dokumentation:1.1.1,1.3.1,2.4.2,2.4.6,3.1.1/3.1.2 | Applicable; Überschriften, Texttabelle und Sprachabschnitte | Endgültiges E01-07-Review folgt T057 |
| Nur Mauszielgrößen:2.5.8 | N/A für reine Tastatur-TUI | Bei zusätzlicher Zeigeroberfläche neu bewerten |

TextView ist in der gesperrten Terminal.Gui-Version2.5.0 als veraltet markiert.
Der begrenzte Einsatz ist eine schreibgeschützte lokale Textanzeige mit Umbruch
und Scrollen, kein Editor. Die Compilerwarnung CS0618 wird nicht unterdrückt;
ein Ersatz durch eine zusätzliche Editor-Abhängigkeit ist hier nicht beauftragt.
Diese bekannte Migrationsgrenze bleibt vor einem späteren Frameworkwechsel zu prüfen.

Reale Terminals/Screenreader bleiben auf Ownerauftrag Deferred, Braillehardware
wegen fehlendem Gerät im privaten persönlichen Projekt Excluded. Keine
WCAG-Konformität, praktische Abnahme oder vollständige LH-01-/LH-00-Abnahme.
Mac B/Windows/Ubuntu24.04-WSL2 sind nicht durch Mac-A-PTYs nachgewiesen.

## EN — Bounded Mac A E01-03/E01-05 proof

T045–T051 add safe textual state, equivalent German/English resources, vertically
stacked controls, paged help and resize coordination. Names, availability, focus,
busy state, status, errors and legend do not rely on colour alone. Dynamic control
and invisible formatting characters are replaced; private session values are absent.

Minimum width derives from the longest bilingual button plus six margin cells.
Thirteen rows cover three controls, four state rows, two help rows and four layout/
border rows. These are implementation layout bounds, not new intake requirements.
Page keys scroll help/actions; Tab/arrows navigate controls. Small views explain
Alt+H/Alt+X/Esc. A1x1view cannot display full text, but keyboard exit still works.
Resize retains local values and logical focus; normal controls are restored after
enlargement. Only help/back/exit are available in the small view. No later forms.

Product cases TextState, Resize, SmallExit and TinyExit verify rendering, sanitized
synthetic busy/error state, preserved synthetic values/focus, navigation and shell
return. The linked manifest binds their source/binary/results. Busy injection proves
presentation only; synchronous local refresh starts no background domain operation.
Test seams stay internal. Model tests also cover exact boundaries and resource parity.

The table preserves the Spec WCAG surface matrix: navigation, focus/legend and
errors/state are Applicable with bounded automated evidence; host/assistive proof
is open. Documentation is Applicable with final T057 review pending. Pointer-only
size criteria are N/A for keyboard-only interaction and must be reassessed if added.
Text role labels are not native assistive interfaces.

Terminal.Gui2.5.0 marks TextView obsolete. Its bounded use is a read-only local,
wrapped/scrollable display. CS0618 remains visible; no additional editor dependency
or framework migration is authorized. Record this migration limit for later review.
Physical terminals/screen readers remain Deferred; Braille hardware Excluded for
lack of a device in this personal project. No conformance, practical/full acceptance
or foreign-host proof is claimed.
