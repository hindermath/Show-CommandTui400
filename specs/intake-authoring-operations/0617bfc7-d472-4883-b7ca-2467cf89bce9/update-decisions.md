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

Intake: LH-01; Vorgängerreceipt / predecessor receipt: `59f3e085-f12e-4a6e-8347-8a7c11b7c65a`.
Vorgängerreview / predecessor review: `dd62a398-16bc-4382-a4bb-5916cef9dfc2`.

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
| `specs/intake-authoring-receipts/lh-00.json` | `b8c63bf04438e3b9b1c4e0a811163c3d57f01d26f893491641d5b48e9b33c664` | `43d96e09ba2e41d7db794f112a39984c2ccd5f87ced157ce7100f5cf4fb53056` |
| `specs/intake-review-result.json` | `def6d53f6d9ad78a362c534c06cba1e43e77d751097f039bf23836128ba119be` | `0cbea5580f4f98703c377fee317e80540c18eada33976117f902c17d61924c00` |
| `specs/intake-review-report.md` | `d1ef60e7be2b582e2a780996083b07f1bdd19a6fc188d915b475f6789a5606ce` | `b368533dac1b0ca55957126144d2f9876ae00bf8af4c02063212ded6b54f565f` |
| `constitution.md` | `8031f1fb425336dda6dc1e2e582e7cf2d90a680e4f4383253f6a294ae0bd1d6e` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` |
| `.specify/memory/constitution.md` | `8031f1fb425336dda6dc1e2e582e7cf2d90a680e4f4383253f6a294ae0bd1d6e` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` |
| `AGENTS.md` | `cfddd301099d82967a8170541d3cd77ba959d30a4d9c00f3c8f074181fd45830` | `2d07ec9ee266efdfedfcc5af63857c50ddf5de82c400ea65156599ba40be3938` |
| `docs/Lastenheft-Plan.md` | `e29789e79d9f626f3716befaa9e369df83455ab6aa6c7558c01c7d4ef4cdf60f` | `2801f591ce479b2aef8b28c99d4f05ce8d09fc9e7a8c83688c60dd175f128cf5` |
| `docs/intake-governance.md` | `400b56476e75f1f34fe1ffbda3595e55b68aeda03ecba782da50d6da8079e30d` | `3cc4998cf41e57b513a2db4576707d7b07f7bb2a0aa8ca9af3efb278c2d5cc9b` |
| `docs/Entwicklungsumgebung.md` | `0c4fe962582d0bb2ab7b313a770fdf01bb526a09c2061ceef1be7a1b7ed40409` | `d95e83d8d923a81839d4f1613f8e141f4eec1e099dbef0fdb13899a7410957d0` |
| `.specify/memory/intake-authoring-profile.md` | `a145327d6713ccf7ffe13d42ec12c4ee286e1594af7b7657b207c8ce1e22a467` | `a534f5a813bc166f4bc5c7358e320321c641ce0bf9cade40063cce57390bf611` |
| `docs/security/README.md` | `2b4da0e2bf3e8c2f5672319c223a0420b6a6c6618374db5eb6c1d552c28332d3` | `6435df9d48afd4f4c2c72b143e8936e943139a21ad422302f2e5bd2682392d26` |
| `docs/security/msl-applicability.md` | `c082a84ee2e4802d5d56d9d9cf7ebcd73a11dd4eb7f96943098f7169e284829f` | `75a266292902a5fbebde71afad22d8a0b1712aaaabb546fd248b754881178a3b` |
| `docs/security/regulatory-applicability.md` | `63b67e588cbec0dbc0100a8b2dc4561426efd696ef3196a249845fdc76fbde61` | `a40b8f3cc4a041a791ef30f9b03c5ac7c42ce5f0276f1bac7271668aefba1020` |

DE: Quellenreihenfolge: exakter Vorgängerintake, dieser Entscheid, angewendete
Registerausrichtung und ADRs, danach erhaltene Ursprungsquellen in ihrer Reihenfolge.
Frühere SRC-Nummern im Intake gelten für die jeweils ausdrücklich historische
Receipt-Generation; die aktuelle Zuordnung steht ausschließlich im neuen Receipt.
EN: Source order is exact predecessor intake, this decision, applied registry proof
and ADRs, then retained original sources in their order. Earlier SRC numbers in the
intake belong to their explicitly historical receipt generation; the new receipt
alone defines current source IDs.
