# Quellenentscheid LH-00/LH-01 / Source update decision

## DE

Ownerauftrag 2026-10-21: gewöhnliche Quellenupdates beider Intakes, vollständige unabhängige Reviews, gezielter Spec-/Plan-/Tasks-Abgleich und MergeAndSync mit Admin-Bypass. Keine Produktimplementierung, Releases, Installation, Serienaktivierung, LH-02-Ausführung oder Umbindung der Plattformprüfstände #37–#39. Die lokale Routingaktualisierung ist separat ausdrücklich freigegeben.

PR #49 ersetzt die rechnerabhängige Host-DLL-Kompilierreferenz durch NuGet System.Management.Automation7.6.4; zur Laufzeit bleibt die vorhandene PowerShell-Engine zuständig. Das ändert keine fachliche Sitzungsanforderung. PR #51 aktualisiert Governance-/Dokumentations-Presets, Constitution-/Guidance und Entwicklungsanleitung. PR #52 übernimmt GSDB3.4.4 und Assurance0.1.5 mit 50 geänderten Kontrollpassagen. Produkt, Werkzeuge und Organisation bleiben getrennt bewertet. Die gebundenen Sources und ihr genauer Git-Verlauf stehen unten; kein unexplained drift wird fortgeschrieben.

Die Vorgänger werden bytegleich archiviert und erste Quelle. Neue Entscheidungs-/GSDB-Quellen folgen; bestehende doppelte Dateiquellen werden auf den ersten identischen Pfad zusammengeführt, die vollständige alte Liste bleibt im archivierten Receipt. Aktuelle Quellen werden inhaltlich bewertet, nicht nur neu gehasht. Historische Entscheidungen bleiben datiert; klare aktuelle Ergänzungen konkretisieren FR-00-007/008/009 beziehungsweise QG-01-002/004. Alte Reviews werden archiviert und ausdrücklich superseded. LH-00-Manifest wird nur auf den neuen Inhalt gebunden, mit unveränderten Ready/Eligible-Zuständen, Reihenfolge, Wurzel und ohne neue Kante; Manifest/Receipt erhalten Vorgängerarchive und einen Updatevorgang. Dies aktiviert keine Serie.

Die 50 Einzelbewertungen stehen in [Zuordnung](lh00-lh01-gsdb344-assessment.md). Nicht belegte Umsetzung bleibt Not Assessed; rechtliche Unklarheiten Open. Keine neue N/A-Rechtsausnahme und keine menschliche Risikoannahme. Sprach-/MSL-, Runtime-, Framework-, PS-Minimum- und Sitzungsentscheidungen bleiben erhalten. Reale Terminals/Screenreader Deferred, Braillehardware Excluded. Volle LH-00-Abnahme nach LH-02/vor LH-03.

## EN

The 2026-10-21 owner authorises ordinary updates, complete distinct reviews, targeted technical alignment and exact-head MergeAndSync/admin delivery. Local routing refresh has separate explicit authority. No implementation, release, installation, series activation, LH-02 or platform rebind. PR #49 supplies portable NuGet compile assets while the current PowerShell host provides runtime implementation. PR #51 updates governance and documentation; PR #52 adopts GSDB3.4.4/Assurance0.1.5. Exact drift and Git history follow below.

Preserve exact predecessors as first sources; ordered decisions/GSDB sources follow. Deduplicate repeated file paths while preserving the full historical inventory in archived receipts. Assess semantics before rebinding hashes. Supersede old reviews explicitly. Rebind only the LH-00 member content through archived series lineage: no state, order, roots or edge changes. Preserve technical choices, pilot limits, Deferred physical terminal/screen-reader proof, Excluded Braille hardware and full LH-00 acceptance after LH-02/before LH-03. Open implementation/legal evidence never becomes a pass.

## Quellenlesegrenze / Source reading boundary

DE: CL09 enthält ein öffentliches synthetisches Credential-Muster außerhalb der geänderten Kontrollen, das der strikte Receipt-Validator abweist. Die kanonische Datei bleibt unverändert. Statt ihrer vollständigen Einbettung binden die Receipts die exakten normativen Änderungsauszüge; die Zuordnung bindet zusätzlich Pfad und Hash der vollständigen Datei. Kein Filter im Validator, keine Secret-Ausnahme und keine neue Behauptung zu Credential-Sicherheit.

EN: CL09 contains a public synthetic credential pattern outside changed controls. Preserve the canonical file and strict validation. Receipts bind exact normative excerpts; the assessment additionally binds the full canonical path/hash. No validator relaxation or secret exception.

## Geänderte Bindungen / Changed bindings

### lh-00

| Quelle / Source | Alt / Before | Neu / After | Git-Verlauf / History |
|---|---|---|---|
| `docs/architecture/decisions/003-lh01-runtime.md` | `cfabe9086509e257436b15bca5406fc37f949d65999a8396225c98823feabdc5` | `e0b46e42136f207bc9a4469ecd595f8e65c6881f4ee4fb83133897ee1ffc7cc5` | b076fc2 fix(lh01): make IDE references portable and help text visible |
| `docs/Entwicklungsumgebung.md` | `d95e83d8d923a81839d4f1613f8e141f4eec1e099dbef0fdb13899a7410957d0` | `4db577b676de8f61ba2110c261bca7d9611cd9c19b6d0438535ffe275f54cb8b` | b076fc2 fix(lh01): make IDE references portable and help text visible |
| `constitution.md` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `AGENTS.md` | `ab11a4193250aa896ec8b4c14634f24f9eed445984ec5afc07e87b28f56cad47` | `11c4aeef2e2db68906f46acb760ae2889e068539bd7111ffbd2b39b2c6cf6b54` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `9a18ab54ca781c87961f5bb88df27caaf72086c1abe24f7ba05c5d8a55ef97e4` | `c4e606e7679415f35e42b8d0ccf963f2d5b14754fe689d45393279a90196be8f` | 0c611cd feat(governance): adopt GSDB 3.4.4 and Assurance 0.1.5 pilot; 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `.specify/memory/constitution.md` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |

### lh-01

| Quelle / Source | Alt / Before | Neu / After | Git-Verlauf / History |
|---|---|---|---|
| `docs/architecture/decisions/003-lh01-runtime.md` | `cfabe9086509e257436b15bca5406fc37f949d65999a8396225c98823feabdc5` | `e0b46e42136f207bc9a4469ecd595f8e65c6881f4ee4fb83133897ee1ffc7cc5` | b076fc2 fix(lh01): make IDE references portable and help text visible |
| `constitution.md` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `.specify/memory/constitution.md` | `2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d` | `097fce80908109319792a7ff5e78169ab35caeb502febff3324172315f754460` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `AGENTS.md` | `ab11a4193250aa896ec8b4c14634f24f9eed445984ec5afc07e87b28f56cad47` | `11c4aeef2e2db68906f46acb760ae2889e068539bd7111ffbd2b39b2c6cf6b54` | 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
| `docs/Entwicklungsumgebung.md` | `d95e83d8d923a81839d4f1613f8e141f4eec1e099dbef0fdb13899a7410957d0` | `4db577b676de8f61ba2110c261bca7d9611cd9c19b6d0438535ffe275f54cb8b` | b076fc2 fix(lh01): make IDE references portable and help text visible |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `9a18ab54ca781c87961f5bb88df27caaf72086c1abe24f7ba05c5d8a55ef97e4` | `c4e606e7679415f35e42b8d0ccf963f2d5b14754fe689d45393279a90196be8f` | 0c611cd feat(governance): adopt GSDB 3.4.4 and Assurance 0.1.5 pilot; 66dcd89 chore: install fourteen documentation patch presets and bind technical evidence |
