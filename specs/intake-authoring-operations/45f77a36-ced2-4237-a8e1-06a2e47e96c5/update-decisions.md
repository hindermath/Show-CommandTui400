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

Predecessor receipt: `0ef60142-cacd-4e01-be35-3824f02e7dd4`; predecessor review: `1ccc35b4-18e8-4cf0-b8b4-ccd2d91a83d0`.

| Quelle / Source | Alter Hash / Old hash | Neuer Hash / New hash |
|---|---|---|
| `constitution.md` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` |
| `AGENTS.md` | `2d07ec9ee266efdfedfcc5af63857c50ddf5de82c400ea65156599ba40be3938` | `ab11a4193250aa896ec8b4c14634f24f9eed445984ec5afc07e87b28f56cad47` |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `3b41eede1bf49a3b7cc035c73aeecf06acf29447a65039288328f517708a8d64` | `9a18ab54ca781c87961f5bb88df27caaf72086c1abe24f7ba05c5d8a55ef97e4` |
| `docs/maintenance/coordinated-governance-source-lock.json` | `c6c0088bf5fe03376d425dd417fb1a6a3048275ae887d94ae8ffbf92d5cdccf4` | `0b398d5741ae462fb8ff56f1656b1c7cf005786be31c0d49ca2d1a9132c693c9` |
| `.specify/memory/constitution.md` | `1089e2750e1a837dda669fda2da1027616fd9cb768e4293bbc1e410528f69f96` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` |

DE: Quellenfolge: Vorgängerintake, dieser Entscheid, Patchbericht, erhaltene Quellen.
EN: Ordered sources: predecessor intake, this decision, patch report, retained sources.
