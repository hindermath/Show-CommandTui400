# Intake-Update T015 / Intake update T015

## Aktueller Quellenstand T014–T015 / Current source state T014–T015

DE: Der Owner hat am 9. Oktober 2026 T001–T017 einschließlich Registerausrichtung,
gewöhnlicher Intake-Updates und unabhängiger Reviews beauftragt und die separate
zentrale Schreibautorität ausdrücklich bestätigt: „Freigegeben, Bitte ausführen.“
Die vorherige Intake-Fassung bleibt erste fachliche Quelle; Anforderungen und
FR-/AC-/QG-/OD-IDs bleiben erhalten. Der aktuelle technische LH-01-Plan und seine
Machbarkeit wählen managed C#14, Host-.NET10/net10.0, Terminal.Gui2.5.0 mit explizitem
dotnet-Treiber, PowerShell mindestens7.6.4 und In-process-Integration. Eigener Code
ist managed; native Abhängigkeiten, Interop und OS bleiben getrennte Grenzen.
Registerwert `msl` bedeutet diese begrenzte eigene Speichersicherheit, keine globale
Sicherheitsabnahme. Statistikreferenz125 ist begründet, keine Zeitmessung.
Historische Kandidaten-/unknown-Aussagen sind der damalige Quellenstand, kein
heutiger offener Sprachentscheid. OD-01-001/002 bleiben als IDs und ursprüngliche
Planungspflichten erhalten; deren technische Entscheidungen sind im Plan und in
ADRs002–006 belegt. Keine neuen Produktanforderungen oder Implementierungsbefugnis.

EN: On9October2026 the owner commissioned T001–T017, including registry alignment,
ordinary intake updates and independent reviews, then explicitly approved the
separate central writes. The previous intake remains the first domain source;
requirements and FR/AC/QG/OD IDs stay intact. The technical LH-01 plan and feasibility
select managed C#14, host.NET10/net10.0, Terminal.Gui2.5.0 with the explicit dotnet
driver, PowerShell at least7.6.4 and in-process integration. Own managed memory
safety is separate from native dependencies, interop and OS boundaries. The existing
registry value `msl` records this limited own-code claim, not full security acceptance.
Reference125 is a justified statistics parameter, not measured time. Earlier unknown
or candidate statements describe their historical source state. OD-01-001/002 IDs
and original planning duties remain; the plan and ADRs002–006 evidence their technical
decisions. No new product requirement or product execution authority follows.

DE: LH-01 bleibt Einzelpilot außerhalb automatischer Serienauswahl. LH-00 bleibt
offen; volle Prozessabnahme folgt nach LH-02 und vor LH-03. Reale Terminal- und
Screenreaderprüfungen sind derzeit zurückgestellt. Braille-Hardware ist gemäß
Ownerentscheid für dieses private persönliche Projekt ausgeschlossen, weil kein
Gerät verfügbar ist; keine Prüfung oder vollständige WCAG-Konformität behaupten.
Anforderungen bleiben sichtbar, die begründete Hardware-Prüfgrenze ist keine
bestandene Abnahme. Änderungen dieser Grenze erfordern einen neuen Ownerentscheid.

EN: LH-01 remains a standalone pilot outside automatic selection. LH-00 stays open;
full process acceptance follows LH-02 and precedes LH-03. Real terminal and screen
reader checks are deferred. The owner excludes physical Braille proof for this
private personal project because no device is available; do not claim a passed test
or full WCAG conformance. Requirements remain visible, with the justified hardware
proof boundary recorded separately from acceptance. Changing this boundary needs
another owner decision.

Intake: LH-00; Vorgängerreceipt / predecessor receipt: `0a48758f-0722-4df8-8cb5-c20498d20c09`.
Vorgängerreview / predecessor review: `b9871c59-670b-4ac7-8f41-a486e1562af1`.

DE: Der Vorgang bewertet die folgende Quellenabweichung. Die neue Guidance setzt
den bereits begründeten technischen Entscheid um; das fachliche Prozess-/TUI-Ziel
ändert sich nicht. Alte Review-Tripel sind exakt archiviert und nicht aktuell.
Kein Commit, Push, Home-Sync, Release oder Flottenrollout ist beauftragt.
EN: This operation evaluates the following drift. Guidance applies the already
evidenced technical selection; the domain process/TUI goal is unchanged. Old review
triplets are archived exactly and are no longer current. No commit, push, Home sync,
release or fleet rollout is commissioned.

| Quelle / source | Alter Hash / old hash | Neuer Hash / new hash |
|---|---|---|
| `docs/Entwicklungsumgebung.md` | `5a418c007f73340e83919580272e132421333385d091abaaeac496fb10df5035` | `d95e83d8d923a81839d4f1613f8e141f4eec1e099dbef0fdb13899a7410957d0` |

DE: Quellenreihenfolge: exakter Vorgängerintake, dieser Entscheid, angewendete
Registerausrichtung und ADRs, danach erhaltene Ursprungsquellen in ihrer Reihenfolge.
Frühere SRC-Nummern im Intake gelten für die jeweils ausdrücklich historische
Receipt-Generation; die aktuelle Zuordnung steht ausschließlich im neuen Receipt.
EN: Source order is exact predecessor intake, this decision, applied registry proof
and ADRs, then retained original sources in their order. Earlier SRC numbers in the
intake belong to their explicitly historical receipt generation; the new receipt
alone defines current source IDs.

DE: LH-00 bleibt bytegleich; nur bewerteter Herkunftsstand wird erneuert. Manifest,
Serienreceipt, Ready/Eligible und sämtliche Kanten bleiben unverändert, da der
Zielhash unverändert ist. Keine Serienaktivierung.
EN: LH-00 bytes stay unchanged; only evaluated provenance is renewed. Its unchanged
target hash keeps manifest, series receipt, Ready/Eligible and edges unchanged.
No series activation.
