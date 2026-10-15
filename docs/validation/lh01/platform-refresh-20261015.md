# Aktualisierter LH-01-Prüfstand / Refreshed LH-01 test stand

## DE

Ownerauftrag 2026-10-15: freigegebenen Prüfstand und vollständige Agenten-Prompts
für Mac B #37, Windows11 #38 und Ubuntu/WSL2 #39 aktualisieren; Lieferung per
MergeAndSync/Admin-Bypass. Eltern-Issue #36 erhält denselben Bindungsblock, damit
keine widersprüchliche Prüfautorität entsteht. Kein Zielhoststart, keine Installation,
keine Featureimplementierung und keine Abnahme.

Produktbasis ist die gelieferte NuGet-/Sichtbarkeitskorrektur aus PR #49. Der
unveränderliche Prüfcommit `64fe627e5f0799ce1a4f7d5ec1c26ceeea936e9b` verlegt
zusätzlich die Keyboard-/Remap-Farbprüfung vom reinen CI-Wrapper in den gemeinsamen
K01-Falleinstieg. Die 20 Fall-IDs, 60 Kommandos, E01-Zuordnungen und Schemas bleiben
erhalten. Produkt-API und Produktcode sind gegenüber PR #49 unverändert.

Frischer vollständiger Mac-A-Lauf aus sauberem isoliertem Checkout: 19 reguläre
Pass-Fälle, S07 getrennt Fail/exit1 bei erfülltem Diagnosevertrag. Alle Rohbelege
und der ursprüngliche Suitebericht bleiben erhalten; nur nachweislich leere
Temporärdateien sind mit Originalpfad/hash im Export ausgewiesen und ausgelassen.
[Suite](platform-proof-maca/20261015-64fe627/suite-result.json),
[Manifest](platform-handoff.json), [Hash](platform-handoff.sha256).
65 Ausführungs-/Leserpfadbindungen umfassen nun Solution, Root-NuGet-Konfiguration,
gemeinsame Kompilierreferenz und beide Regressionsprüfer. Ein Receipt- oder
Intake-Update gehört nicht zu diesem Prüfstandsauftrag; keines wird behauptet.

[CheckOnly-Nachweis](platform-refresh-readiness-20261015.json): Das vollständige
Manifest wird am echten Produktcheckout ausschließlich wegen der erwarteten
Mac-B-Hardwareabweichung auf Mac A blockiert. Mutierte Hashes, Kommandos, E01-
Zuordnung, Revision und Pfadausbruch werden abgewiesen; keine Ausgabewurzel wird
angelegt. Prepared-Inventarregression bleibt bestanden. Dies ist kein Mac-B-Lauf.

Die neue Freigabe liegt in einem späteren Genehmigungscommit als der Produktstand.
Issue-Prompts werden danach mit dessen konkretem SHA erzeugt und erst nach grünen
technischen PR-Checks und Merge veröffentlicht. So entsteht keine Selbstreferenz.
Alte Freigabe und Nachweise bleiben historisch, werden nicht auf neue Hashes umgedeutet.
IDE-Prüfungen laufen zusätzlich getrennt: Rider/VS Code auf Mac B, auch Visual
Studio auf Windows; WSL-Backend/WSL-Fenster unter Ubuntu. Fehlende IDE/GUI bleibt
Open/Blocked, ohne Produktlauf als IDE-Nachweis auszugeben. Neue private IDE-
Zustände/Caches im isolierten Checkout sind erlaubt, keine globalen Einstellungen.
Nur vorhandene Werkzeuge verwenden; keine Installation oder Reparatur.

T054 und echte Zielhostreviews bleiben offen. Praktische Terminals/Screenreader
Deferred, Braillehardware Excluded mangels Gerät. Keine Vollabnahme oder
Serienaktivierung. LH-00-Abnahme weiterhin nach LH-02/vor LH-03. Dokumentationswirkung:
UpdateRequired; Leserpfad Tasks/Matrix → gepinnter Vertrag/Manifest → kopierbarer
Issue-Prompt → Ergebnisse → anderes Review → Ownerentscheidung.

## EN

The 2026-10-15 owner request refreshes #37–#39 and their parent binding in #36,
under MergeAndSync/admin bypass. No target execution, installation, feature or
acceptance. The pinned revision above contains PR #49's NuGet/visibility fix and
moves actual Keyboard/Remap color assertions into shared K01. Product API/code,
20 case IDs, E01 mapping, 60 commands and schemas are unchanged.

Fresh complete Mac A proof from a clean isolated checkout passes all 19 regular
cases; S07 remains Fail/exit1 with its diagnostic contract satisfied. Preserve raw
proof and original suite; export metadata lists only omitted verified empty temp
files. The 65 bindings cover solution, root feed, compile reference and regression
scripts. No intake/receipt update is performed or claimed.

CheckOnly validates the exact new approval at the product revision and blocks only
on actual Mac A/Mac B hardware mismatch. Tampered bindings/commands/inventory and
paths are rejected without output creation; Prepared regression also passes.
Approval follows the immutable product commit. Copyable prompts pin that later
approval SHA and publish after delivery checks/merge; no self-reference. Preserve
historical approval/evidence. IDE proof is separate; missing GUI/IDE means Open/
Blocked. Private IDE state/caches in the isolated checkout are allowed, no global
changes, installation or repair. Actual target runs/reviews and full acceptance
remain open. Physical terminals/screen readers Deferred, Braille hardware Excluded;
retain LH-00 acceptance after LH-02/before LH-03. Reader path and documentation
impact are stated above.
