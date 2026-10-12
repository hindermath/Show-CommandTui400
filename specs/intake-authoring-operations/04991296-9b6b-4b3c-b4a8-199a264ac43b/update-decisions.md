# Quellenupdate vor T037–T044 / Source update before T037–T044

## DE — Auftrag, Bewertung und Grenzen

Thorsten Hindermann hat am 12. Oktober 2026 ausdrücklich das lokale Routingrefresh,
die nötigen gewöhnlichen Updates für LH-00/LH-01 und unabhängige Reviews freigegeben.
T037–T044 auf Mac A und die Lieferung MergeAndSync mit Admin-Bypass sind separat
beauftragt. Das Authoring startet weder Produktcode noch Lieferung.
PR #45 übernimmt Security0.7.1, Architecture0.6.2 und Sequencing0.2.8. Gemäß
`docs/maintenance/preset-patches-2026-10-10.md` betreffen die Patches
Installationshinweise/Metadaten, keine neuen fachlichen Runtime-Anforderungen.
Constitution-Kopien, Guidance, Versionsmatrix und bei LH-00 Quellen-Lock haben
sich entsprechend geändert. Der bisherige Intake bleibt bytegleich und die erste
fachliche Quelle. IDs, Anforderungen, technische Auswahl und Pilotweg bleiben
erhalten. Aktuelle Herkunft liegt im neuen Receipt; ältere SRC-Nummern und
Authoring-/Lieferaussagen behalten ihren historischen Vorgangskontext.
Die Guidance-Aussage ohne Produktcode ist ein älterer Planungsstand; PR #44
lieferte T018–T036. Dieses Update ändert nicht die gemeinsame Guidance.
LH-00 bleibt offen; LH-01 bleibt Einzelpilot. Keine Serienmutation/Serienaktivierung,
Releases, Installationen, Flottenänderung oder fremden Plattformläufe. Reale
Terminals/Screenreader Deferred; Braillehardware Excluded gemäß Ownergrund.
Der unveränderte Intake-Zielhash erfordert keine Änderung der Serienbindung.
Das alte Ready-Review wird exakt archiviert und durch ein anderes vollständiges
Review ersetzt. Alte Snapshots werden nicht erneut remote abgerufen.

## EN — Authority, assessment and limits

On12October2026 the owner explicitly approved local routing refresh, ordinary
LH-00/LH-01 source updates and independent reviews. Mac A T037–T044 and separate
MergeAndSync delivery with admin bypass are commissioned. Authoring itself starts
neither implementation nor delivery. PR #45 updates three preset patches, limited
to installation documentation and metadata, without new domain runtime rules.
The previous intake remains byte-identical and the first domain source; IDs,
requirements, technical choices and standalone pilot boundaries are unchanged.
The new receipt defines current source IDs; old authoring/delivery wording keeps
its historical operation context. Guidance saying no product code predates PR #44,
which delivered T018–T036. Shared guidance stays unchanged. No series mutation,
activation, release, installation, fleet rollout or foreign platform test follows.
Physical terminals/screen readers remain Deferred and Braille hardware Excluded.
An unchanged target hash needs no series binding change. Exact predecessor files
and review triplets are archived before distinct complete reviews. Historical
URL/inline snapshots are not retrieved again.

Predecessor receipt: `fef04f91-8fc2-444a-8db2-6445de49f5f1`; predecessor review: `cf380598-13ea-4c9b-8bfd-c52c150aae42`.

| Quelle / Source | Alter Hash / Old hash | Neuer Hash / New hash |
|---|---|---|
| `specs/intake-authoring-receipts/lh-00.json` | `11a050590c6fef4c5fde643972a4bbc0bd2a127c6c5437628920c47a586f751c` | `0cdf3c141fca155c5de4ba2052cf3c07da28d736520c9286a44aaaff01c6c2cc` |
| `specs/intake-review-result.json` | `a4797cb1f4c6518412db018e592f7da1b69514a03437b31bd8b023a352b903ab` | `43e1ef25979de36d3836ede7f3fed039d832128fcd15329cc2aeb8de3770d2bc` |
| `specs/intake-review-report.md` | `b02486d445d2170b34248a1ca85137432906e7a28b4b444d9c9f62fb2a1ff189` | `95e63e9b2bed64a6086c8eb8cf8d2ccaa3ea233d5c04a9ce2a32513270548b67` |
| `constitution.md` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` |
| `.specify/memory/constitution.md` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` |
| `AGENTS.md` | `2d07ec9ee266efdfedfcc5af63857c50ddf5de82c400ea65156599ba40be3938` | `ab11a4193250aa896ec8b4c14634f24f9eed445984ec5afc07e87b28f56cad47` |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `3b41eede1bf49a3b7cc035c73aeecf06acf29447a65039288328f517708a8d64` | `9a18ab54ca781c87961f5bb88df27caaf72086c1abe24f7ba05c5d8a55ef97e4` |

DE: Quellenfolge: Vorgängerintake, dieser Entscheid, Patchbericht, erhaltene Quellen.
EN: Ordered sources: predecessor intake, this decision, patch report, retained sources.
