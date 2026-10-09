# Intake-Update T015 / Intake update T015

DE: Dieser Nachfolger ersetzt widersprüchliche Lieferautorität im Vorgängerprotokoll; aktuelle Lieferung ist ausdrücklich MergeAndSync.
EN: This successor supersedes conflicting delivery wording in the predecessor log; current delivery explicitly uses MergeAndSync.

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

Intake: LH-01; Vorgängerreceipt / predecessor receipt: `ff697098-91cc-460d-a2b0-c6bb7793c4fc`.
Vorgängerreview / predecessor review: `2e1342c6-5208-4ee4-b2a0-acf68cd05527`.

DE: Der Vorgang bewertet die folgende Quellenabweichung. Die neue Guidance setzt
den bereits begründeten technischen Entscheid um; das fachliche Prozess-/TUI-Ziel
ändert sich nicht. Alte Review-Tripel sind exakt archiviert und nicht aktuell.
Die aktuelle Lieferung ist MergeAndSync mit Admin-Bypass; keine Produktimplementierung,
Releases oder weiteren Flottenrollouts.
EN: This operation evaluates the following drift. Guidance applies the already
evidenced technical selection; the domain process/TUI goal is unchanged. Old review
triplets are archived exactly and are no longer current. Current delivery uses
MergeAndSync with Admin-Bypass; no product implementation, release or further fleet rollout.

| Quelle / source | Alter Hash / old hash | Neuer Hash / new hash |
|---|---|---|
| `specs/intake-authoring-receipts/lh-00.json` | `43d96e09ba2e41d7db794f112a39984c2ccd5f87ced157ce7100f5cf4fb53056` | `e9032fcf1f4a581618ff141db6ba68a5cbbb58a0331cc35a7773ed24da5d54ea` |
| `specs/intake-review-result.json` | `0cbea5580f4f98703c377fee317e80540c18eada33976117f902c17d61924c00` | `c94963f584577137dda0fbe00e5aea8f0f8b0e97b8b426dd0f024c65721549b9` |
| `specs/intake-review-report.md` | `b368533dac1b0ca55957126144d2f9876ae00bf8af4c02063212ded6b54f565f` | `e89885999d13b335e86b19a659f649528100c39bb77b8292b408c10ea5739937` |

DE: Quellenreihenfolge: exakter Vorgängerintake, dieser Entscheid, angewendete
Registerausrichtung und ADRs, danach erhaltene Ursprungsquellen in ihrer Reihenfolge.
Frühere SRC-Nummern im Intake gelten für die jeweils ausdrücklich historische
Receipt-Generation; die aktuelle Zuordnung steht ausschließlich im neuen Receipt.
EN: Source order is exact predecessor intake, this decision, applied registry proof
and ADRs, then retained original sources in their order. Earlier SRC numbers in the
intake belong to their explicitly historical receipt generation; the new receipt
alone defines current source IDs.

DE: Folgekorrektur zu PR #42: historische Specify-Links zeigen auf exakte Archive;
die englische Spezifikation beschreibt den gewählten Sprachstand; IAD019 in LH-00
wird ausdrücklich historisch eingeordnet. LH-01 bleibt bytegleich. Für LH-00 wird
nur die abhängige Serien-Hashbindung samt Vorgängerarchiv erneuert; Ready/Eligible,
Mitgliedschaft, Kanten und Ausführungsbefugnisse bleiben gleich.
EN: Follow-up to PR #42: historical Specify links address exact archives; English
specification reflects the selected language; LH-00 IAD019 is explicitly historical.
LH-01 bytes remain unchanged. Only the dependent LH-00 series hash and predecessor
archive are renewed; Ready/Eligible, membership, edges and execution authority stay unchanged.
