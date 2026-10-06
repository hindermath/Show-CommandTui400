# B-01: unabhängiges technisches Review / Independent technical review

Datum / Date: 2026-10-06T19:00:20.063090+00:00.  
Reviewer: `/root/lh00_inc2_b01_review`; Review-ID: `735deefd-cc9c-4504-830f-8f4e37392397`.  
Autor der geprüften Lieferung / delivery author: `/root`.

## DE

**Technische Entscheidung: Ready. Keine offenen technischen Befunde in diesem
begrenzten B-01-Werkzeugnachweis.** Dies ist weder das LH-00-Intake-Review noch
eine menschliche Freigabe oder praktische Prozessabnahme.

Die aktuellen Nachweise wurden vollständig gelesen und mit den installierten
Quellen verglichen. Der separate Reviewer hat zusätzlich die drei exakt in der
Projektmatrix genannten Tagarchive lesend geladen, ihre ZIP-Hashes gegen den
Quellen-Lock geprüft und pro Paket Testskript, Bash-/PowerShell-/Python-Validator
und `preset.yml` bytegenau mit der Installation verglichen. Alle 15 Dateien stimmen
mit den gebundenen Quellen überein. Es wurde nichts neu installiert.

- Authoring 0.3.7, Review 0.2.4 und Sequencing 0.2.7 stimmen in Matrix, Lock,
  installiertem Manifest und Registry überein. Veröffentlichungs- und Tagidentität
  sind im geprüften JSON dokumentiert; alle drei Releases sind stabil veröffentlicht.
- Zentral- und Projektmatrix sind bytegleich. Ein erneuter unabhängiger
  `--check-only` für das 14er-Profil bestand mit Exit 0. Die fünf Integrationen
  `agy`, `opencode`, `claude`, `copilot`, `codex` haben vorhandene Manifeste und
  deren Basisdateien; die benötigten Intake-/Review-/Series-Kommandoflächen bestehen.
- Die drei aktuellen Suite-Ausgaben melden Exit 0 und Bash-/PowerShell-JSON- sowie
  Nullschreibparität. Die Suites wurden nicht erneut vollständig ausgeführt;
  ihre aufgezeichneten Ergebnisse und unveränderten Quellen wurden geprüft.
- Die Tests prüfen tatsächlich `Ready/Eligible → Active/Active` mit Kandidat `N/A`
  und danach den **gleichen** nach Archiv verschobenen, `Completed` markierten
  Vorgang. `Active` ohne aktives und ohne `Eligible`-Mitglied sowie mehrere
  `Eligible`-Mitglieder werden abgewiesen. Gültige Mehrmitglied-/Archivfälle bleiben
  erhalten. Falsche Hashes, fehlende Dateien, Pfadausbrüche, physische Aliase,
  ungültige Abhängigkeiten und unzulässige Archivzustände werden weiterhin geprüft.
- Die neun dokumentierten nativen Source-CI-Jobs sind historische B-01-Patchnachweise
  für macOS, Linux und Windows. Sie werden weder als neuer Lauf des heutigen
  Authoring-Tags noch als Produkt-Plattformabnahme ausgegeben.

Zwei Evidenzklarstellungen wurden während dieses Reviews vom Autor korrigiert
und danach erneut geprüft: Tagarchive sind von separat gepackten Release-Assets
unterschieden (`sourceArchiveUrl`, `archiveKind`). Ihre unterschiedlichen ZIP-Hashes
und Größen begründen daher keinen Integritätsfehler. Die 49 statischen
`Invoke-Fixture`-Aufrufstellen heißen nun `fixtureInvocationSites`; eine nicht
instrumentierte Laufzeitzahl wird nicht behauptet.

**Grenze:** Der menschliche B-01-Owner-Entscheid steht weiterhin aus. Dieses Review
nimmt kein Restrisiko an, startet keine reale Serie und schließt T036 nicht allein
ab. Leere `Idle`-Serien bleiben im LH-00-Prozess ausgeschlossen; `Active` erteilt
keine zusätzliche Ausführungsbefugnis. Die vollständige LH-00-Abnahme bleibt nach
LH-02 und vor LH-03 erforderlich.

## EN

**Technical decision: Ready. No open technical findings within this bounded
B-01 tooling proof.** This is neither the LH-00 intake review nor human permission
or practical process acceptance.

The separate reviewer read the current evidence in full and compared installed
sources. The reviewer also retrieved the three exact source tag archives named by
the project matrix without writes, checked their ZIP hashes against the source
lock and compared each package's test script, Bash/PowerShell/Python validators
and `preset.yml` byte for byte with the installation. All 15 files match; no
reinstallation occurred.

- Authoring 0.3.7, Review 0.2.4 and Sequencing 0.2.7 agree across matrix, lock,
  installed manifest and registry. The reviewed JSON records publication and tag
  identities; all three releases are stable.
- Central and project matrices are byte-identical. An independent fourteen-preset
  `--check-only` passed with exit 0. All five integration manifests and their base
  files exist, as do the required authoring, review and series command surfaces.
- Recorded outputs from all three current suites report exit 0, identical
  Bash/PowerShell JSON and zero validator writes. The complete suites were not
  rerun during review; their current results and unchanged sources were assessed.
- The tests exercise `Ready/Eligible → Active/Active` with candidate `N/A`, then
  completion of the **same** member after moving it into the archive. Active
  without an active or eligible member and multiple eligible members remain
  invalid. Existing multi-member/archive cases pass. Hash drift, missing files,
  path escapes, physical aliases, invalid dependencies and invalid archive states
  remain covered.
- The nine native source CI jobs remain historical macOS/Linux/Windows evidence
  for the B-01 patch, with no claim of new CI on today's Authoring tag or product
  platform acceptance.

The author resolved two evidence clarifications and the reviewer checked the
corrections: source tag archives are distinguished from separately packaged
release assets by `sourceArchiveUrl` and `archiveKind`, so different ZIP sizes and
hashes are expected. The 49 static fixture invocation sites are labelled accurately;
no uninstrumented runtime case count is asserted.

**Boundary:** Human B-01 owner acceptance remains pending. This review accepts no
risk, starts no real series and does not alone complete T036. Empty Idle series
remain excluded for LH-00; Active grants no additional execution authority. Full
LH-00 process acceptance remains after LH-02 and before LH-03.

## Geprüfte Hashbindungen / Reviewed hash bindings

Die folgenden SHA-256-Werte binden die tatsächlich geprüften Rohbytes.
The following SHA-256 values bind the reviewed raw bytes.

| Datei / File | Raw SHA-256 |
|---|---|
| `docs/validation/lh00/b01-technical-results.json` | `04ab62cfd0d5326af01cc930418811a8d6e2fad94ad8b8defbe98e23ada54e99` |
| `docs/validation/lh00/release-verification.json` | `4f865dcf46c306434d994a17079611e17376a612aac7e4af6a09250b329be21e` |
| `docs/maintenance/coordinated-governance-source-lock.json` | `c6c0088bf5fe03376d425dd417fb1a6a3048275ae887d94ae8ffbf92d5cdccf4` |
| `scripts/config/spec-kit-project-statistics-governance-presets.json` | `3b41eede1bf49a3b7cc035c73aeecf06acf29447a65039288328f517708a8d64` |

Alle drei Testskripte / all three test scripts:
`3cfd727f7c199418b393c20cbc33081762a268128ea4c8416d676f7917269486`.
Alle drei Validator-Kopien / all three validator copies:
Bash `65883402020f36416c652437999cf646ead4eae1a40a73012db7d4136ac7cf3d`,
PowerShell `c14349c5f03c67a04a78eab16d3876269e16b03911e7035fe2c4dbc87bcd3e22`,
Python `e139287ce32c9f3301aa700715e44318ef8ddb2b6d4c815fbfe0d6d3ceec66c4`.

Leserpfad / Reader path: [Lieferzuordnung](../../maintenance/lh00-b01-release-adoption.md)
→ [Techniknachweis](b01-technical-results.json) → [Release-/CI-Metadaten](release-verification.json)
→ dieses Review / this review → gesonderter Owner-Entscheid / separate owner decision.
