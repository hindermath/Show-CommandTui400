# Unabhängiges technisches Re-review / Independent technical re-review

Datum / Date: 2026-10-08. Prüfer / Reviewer: separater Agent `/root/lh01_feasibility_review`.
Vorgänger / Predecessor: [vorheriges Review](archive/20261008-before-fv01-fix/independent-review.md).

## DE — Ergebnis

**Begrenzte technische Planung: Ready. Vollständige Produkt-/Plattform-/A11Y-Abnahme: offen.** Der korrigierte isolierte Mac-A-Prüfaufbau begründet die getrennten technischen Auswahlentscheidungen OD-01-001/002. Dieses Ergebnis startet keine Implementierung oder Lieferung, bestätigt keine allgemeine Frameworkkonformität und ersetzt weder das Intake-Review noch Owner-/Featureabnahmen.

Unabhängig geprüft: alle 39 gebundenen Payloaddateien, aktuelle Fixture-/Treiber-/ABI-Quellen, native Kontrollmessung, 13 finale PTY-Ergebnisse samt Rohtranscripts, Mac/Linux-Scope, Paket-/NuGet-Provenienz, Ownergrenzen, Entscheidungen sowie die sieben betroffenen technischen Unterlagen. Die 67 gespeicherten Vertragsassertionen wurden durch den Reviewer erneut gegen die Rohdaten ausgewertet, ohne Dateien des ursprünglichen Prüflaufs zu schreiben. Manifestbindungen stimmen. Der Reviewer führte keine neuen interaktiven oder physischen Plattformläufe aus.

### Befundstand

| ID | Status | Bewertung |
|---|---|---|
| FV-01 | Closed für begrenzten Mac-A-Proof | Der unsichere ANSI-Termios-Pfad ist durch `ValidateSet(dotnet)` ausgeschlossen. Darwin ABI: 72 Bytes, Flags/Speeds 64-bit, c_cc20, Offsets56/64 stimmen mit SDK/C-Probe. Console-Control-C-Lease und Snapshot restaurieren nach GUI-Dispose. Alle konfigurierbaren Felder und beide Geschwindigkeiten sind erhalten; tatsächliche Read-Host-Rückgabe bestätigt Shellbedienbarkeit. |
| FV-02 | Closed für getrennt geprüfte Keyboard-/StopProcessing-Pfade | Ctrl+C liefert Cancel und normales Ende; tatsächliches PowerShell.Stop löst StopProcessing mindestens einmal aus und Testpipeline meldet Stopped. Das separate Test-Runspace ist klar als Testaufbau abgegrenzt. Kein finaler Timeout. |
| FV-03 | Closed lokal | Alt+X direkt bei30×6 funktioniert mit kurzer lesbarer Anleitung; Wert/Fokus bleiben erhalten. Reale Oberflächen nicht daraus ableiten. |
| FV-04 | Automatisierter Teil abgeschlossen; praktische Evidence Deferred/Excluded | Reale Frameworkevents für definierte Tasten, Navigation, Enter, Root-Zurück, Alt-Alternativen, F1→F2-Remap, Konfliktabweisung, Wiederöffnen und Kontextnegativfall liegen im synthetischen PTY vor. Owner verschiebt physische Terminal-/Screenreaderprüfungen und schließt Braillehardware-Nachweis mangels Hardware aus. Fachliche Kriterien bleiben erhalten; kein praktisches PASS/Konformitätsclaim. |
| FV-05 | Begrenzte native Planung bewertet; gesonderte Nutzungsgrenzen bleiben | Paketbindung und Native-Assets/Notices sind dokumentiert. Managed C# schützt eigenen managed Code; OS/Runtime/PInvoke/native Treiber bleiben getrennt. Onigwrap ist inventarisierte transitive Abhängigkeit; Fixture aktiviert TextMate/Markdown nicht. Native Oniguruma-Version/Buildprovenienz vor Aktivierung des Pfads klären. |

**PENDIN:** Der rohe Gleichheitsvergleich bleibt false. Ausschließlich das SDK-Zustandsbit0x20000000 wird beim konfigurierbaren Vergleich ausgenommen. Ein SDK-nativer raw→saved-Kontrolllauf ohne .NET/PS/Terminal.Gui reproduziert genau dieses Bit. Alle übrigen stty-Felder bleiben verglichen; unmittelbare Messung nach UI und nach Read-Host stimmen überein. Dies ist keine allgemeine Toleranz oder Abschwächung für beliebige Drift.

**Negative Sicherheit:** stdin-TTY/stdout-Redirect weist Start vor Init ab und erhält den vollständigen Terminalzustand. Vor Guard erfolgt nur native Snapshotlektüre; die schreibende Console-Lease wird erst nach erfolgreicher Capabilityprüfung aktiviert. Hilfe-Remapkonflikt scheitert vor Init; ungültiges Enter führt keine Bestätigung aus. Es gibt keinen Targetexecutor oder Folgefeature. UI- und Restorefehler werden zusammen als AggregateException erhalten. Die doppelte Fehlersituation selbst wurde nicht injiziert; die Aussage ist Quellcodeprüfung, kein Fehlerlaufnachweis.

### Verbleibende Grenzen und abgeschlossener Textabgleich

1. **Textkonsistenz: behoben und erneut geprüft.** research.md grenzt D01–D07 ausdrücklich historisch ab; D08 ist aktuell. Plan-A11Y entspricht den Ownergrenzen. Cmdlet-/Sitzungsvertrag enthält das gewählte Minimum7.6.4 und verlangt öffentliche Signatur-/Manifestkonkretisierung in Tasks statt Kopie der Fixtureparameter. Keine offene startrelevante Dokumentationsinkonsistenz aus diesem Review.
2. Vor Produktstart gezielte gemeinsame Guidance-/Registry-Ausrichtung einschließlich Statistikreferenz und aktualisierte Intake-Herkunft bei gebundenen Quellenänderungen, Security-/Architecture-Startchecks sowie gesonderter Implementierungsauftrag. Keine dieser Arbeiten als hier erledigt ausgeben.
3. Die gewählte Mindestversion7.6.4 ist eine begründete Planungsbaseline; nur Scope/Modelle wurden dort im Ubuntu-Container ausgeführt. Mac-UI lief auf7.6.6. Keine vollständige interaktive Mindestpatch-/Windows-/WSL2-/Mac-B-Matrix behaupten.
4. Physische Terminals und Screenreader bleiben Deferred; Braillehardware-Evidence Excluded mit Ownergrund. AC-01-004/QG-01-003 und vollständige Abnahme bleiben ohne praktisches PASS. Neubewertung auf Hardware-/Scopeänderung; kein WCAG-Konformitätsclaim.
5. Produktadapter brauchen plattformspezifische sichere Capability-/Lease-/Fehlerbehandlung. Darwinwerte nicht auf Linux/Windows kopieren. Paket-/Treiber-/Runtime-/native Nutzungsänderungen erfordern gezieltes erneutes Review.

Owner der Folgeschritte: Thorsten, technischer Bearbeiter nur mit Auftrag. Fälligkeit/Trigger: Startchecks vor Produktstart; native Highlightingprovenienz vor neuer Nutzung; praktische Evidence gemäß Ownerplanung bzw. Hardware-/Scopeänderung. Kein offenes technisches Risiko wird still angenommen.

## EN — Outcome

**Bounded technical planning: Ready. Complete product/platform/accessibility acceptance: open.** The corrected isolated Mac-A setup supports separate OD-01-001/002 technical selections. This grants no implementation/delivery authority, framework conformance, intake-review substitute or owner/feature acceptance.

The distinct reviewer inspected all39 bound payload files, code/ABI/native control,13 final PTY records/transcripts, Mac/Linux scope, package provenance, owner boundaries, choices and seven affected design documents. All67 contract assertions were independently reevaluated without rewriting their evidence. Manifest bindings match. No new physical/platform run was performed.

FV-01 is locally closed: explicit dotnet driver excludes unsafe ANSI ABI; verified72-byte Darwin layout and lease restore all configured fields and speeds, with actual caller input. FV-02 is locally closed for separately observed keyboard cancellation and actual StopProcessing; the isolated test runspace is not the product host. FV-03 small-surface escape is closed locally. FV-04 automated keys/navigation/remap/re-entry/context proof is complete for the bounded fixture; physical terminals/screen readers are owner-deferred and Braille hardware proof owner-excluded for missing hardware, without changing domain criteria or claiming PASS. FV-05 has bounded native planning evidence; Onigwrap inventory/notices and future native-use provenance remain separate obligations.

Only independently reproduced SDK PENDIN state is excluded from configured comparison; raw false remains. Immediate post-UI and post-ReadHost values match. Redirected stdout rejects before Init with unchanged terminal; writing lease activates after guard. Remap conflict rejects before Init; invalid Enter has no confirmation; no target executor exists. Both UI/restore exceptions are preserved in source, but the simultaneous double-failure path has not been experimentally injected.

Documentation findings are fixed and independently rechecked: research D01–D07 is explicitly historical; plan accessibility follows owner limits; the session contract selects minimum7.6.4 and reserves public signature/manifest definition for tasks without copying fixture API. Before product start, align bound guidance/registry/statistics, refresh affected intake provenance and complete security/architecture checks under separate authority. Minimum7.6.4 is a selected support baseline with container scope/model proof, while MacUI ran7.6.6; no complete interactive platform/minimum matrix is claimed. Deferred/excluded assistive proof remains outside acceptance; revisit hardware/scope changes. Other platform adapters require their own ABI evidence. Re-review dependency/runtime/driver/native-use changes. Thorsten owns follow-ups; no risk acceptance is implied.

## Hashbindungen / Hash bindings

SHA-256 independently inspected bytes; current review excluded. Later changes require focused refresh. / SHA-256 der unabhängig geprüften Bytes; eigenes Review ausgenommen.

| Pfad / Path | SHA-256 |
|---|---|
| `checklists/plan-validation.md` | `108295e8192e40d749854d800ddc089a97cce28c804c651f5d95f1b0e32626e6` |
| `contracts/actions-terminal.md` | `b7bce1b9e75e0ec307808d4e8db8038e0b0dc3e245086bf469705300acd8039c` |
| `feasibility/README.md` | `1bebff20bf1e03b8b7f388d151eb7277e8eb574c25d92a82c1a087490c1c9acf` |
| `feasibility/decisions.md` | `b02a18ced7a9b256332eaef770f0477484a3c2099ce14429d80493607af0b0f4` |
| `feasibility/evidence/build-maca.txt` | `3a69e86dd545d05125921d9476ef655c36b567ecb26fc43c4c8aa8967d8f64f5` |
| `feasibility/evidence/contract-assessment.json` | `b8c669d779412406bbdab34caf84110c3ad4b506ddfbc3e03c2cd7b2142a6b9e` |
| `feasibility/evidence/dependency-provenance.json` | `9bc21282332fdac1e80280032495fb511787c130a8caf9459b6032dd057b68fb` |
| `feasibility/evidence/linux-environment.json` | `45a0fc2a07ffe3ccd21d5ada071ad9a61dbfa7c6af9725473e99e2b554f80947` |
| `feasibility/evidence/linux-image.txt` | `b8545b359553e6a083a24556f6aea2b9eeb231bc394b998605f526385da58a9f` |
| `feasibility/evidence/linux-scope.json` | `a1345071dc97ddcbac9242d6d58d7a28c290c910d9417f7e476137dfae741f7f` |
| `feasibility/evidence/locked-restore.txt` | `1673e9bbcd908d6c34aad5f8282239c223612861029b92423c33dfe3de7ebd5a` |
| `feasibility/evidence/maca-native-raw-control.json` | `403696a1d852e805f10a2b3713d4ccbba76254cc8adff3afd6c6fccaa67673ee` |
| `feasibility/evidence/maca-pty-cancel-before-keymap.json` | `7e37d002d789405a1651131406ed7b8b0cb3bdba047a47069a32cd819a087b71` |
| `feasibility/evidence/maca-pty-cancel.json` | `bb224a2b0428978f5965bdfa14262806921c514a8a549b5f08fe002d30d092ed` |
| `feasibility/evidence/maca-pty-control.json` | `f055b065b1dc6c7a2014433ce4da6176c235a5eb009ff1697e2510ab38ddfa58` |
| `feasibility/evidence/maca-pty-error.json` | `b18e7c62cf43bd29496f50e3d22c3269623c90f038f74fe7f11e6e7ee1e0603f` |
| `feasibility/evidence/maca-pty-invalid-remap.json` | `53d6517758ac4a3cefab1dd666e89f0879e0db7aeaa99fa77b2cea7276fe4637` |
| `feasibility/evidence/maca-pty-invalid.json` | `4853286763238a1e8d5e311f21557aa8e73964c2e04a90ca4e4db0c02fa5826a` |
| `feasibility/evidence/maca-pty-matrix.json` | `5025c65adbabc75c6395793dd32980aab643c1e583fac559ec244fab7962d88f` |
| `feasibility/evidence/maca-pty-normal.json` | `2472bb260f69ea9f8f5da805289bb5d4c9aa0f077d9e4bd372e4a2a76334ce33` |
| `feasibility/evidence/maca-pty-out-redirect.json` | `dd3ec55194703f05f7c3cf816092976c30868843376436e8ce14153f747308b7` |
| `feasibility/evidence/maca-pty-remap.json` | `b29cac49e711f11776aa68fdfbbbddb2e49ed035f862656f36e247eb4f838344` |
| `feasibility/evidence/maca-pty-repeat.json` | `35cfa6ed0a66bca6cf45b26f8fb084e0138718bd59a31d4a31ac660213a28035` |
| `feasibility/evidence/maca-pty-resize.json` | `5ca6f1bf286954247eb4dff3150e6fc927c95ce4ac1f4d72e998d47179850ef2` |
| `feasibility/evidence/maca-pty-small-exit.json` | `4decdbfbc62d6aa42a3d89de51dc2434011fb6b7956386773912a7f29531f496` |
| `feasibility/evidence/maca-pty-stop.json` | `e869d4a130102e367d04bb6b2e12d9ee6a1a8a683e6a48c6390413ac0f49f44d` |
| `feasibility/evidence/maca-scope.json` | `7164434faa3f7a724910c4f2d125eca891a13821816244a1cc7e3483d0a087e2` |
| `feasibility/evidence/maca-termios-abi.json` | `9cf2518f1854a134d2d23f075a231154350e286e425d3aba707aaf40d1d73b3b` |
| `feasibility/evidence/manifest.json` | `6138ac8689d216b167e6b35868c2fd3ddb1c7f372c40ee8e8ef54e1b32a21695` |
| `feasibility/evidence/nuget-vulnerability-audit.json` | `4401abbcf95d7f474e2ffedcf68111b5c8541e4d1d15180ed0e8f9b4ebd8d26c` |
| `feasibility/native-dependency-assessment.md` | `e4c01b11a79f0026fd177211ac9225e39a103984930e4117c3b7e910971054d5` |
| `feasibility/owner-validation-boundaries.md` | `d5df23b28c3e1aedc2e1dd6c41baa30299efde527a0c1c8f6b9b48829b87e22d` |
| `feasibility/src/DarwinTerminalSnapshot.cs` | `7092368beb5d4576b7b0e43ba17b680badfbd4c89150f57847beb4163b446909` |
| `feasibility/src/Directory.Build.props` | `5db21870b2d6450b0e3bb5fa16bdf4af49680c59de93bfa5b321daa5cf271133` |
| `feasibility/src/Fixture.cs` | `4af1620f55b1934304a69565e8050a6dc418db9b1e0f70df0d35c45f8551f9e1` |
| `feasibility/src/Lh01Fixture.csproj` | `23cc499fc374cfbe1782765c402c1ea67cdb6a10dde2dd58e03fa32cfba50838` |
| `feasibility/src/NuGet.Config` | `33aa39ee926a9e2651ae39549df08dddc8e43d11896cf14d0465bc869d56b4c2` |
| `feasibility/src/assess-evidence.py` | `7b5e37d62eb837d7c720c79cabd6cbd60e707528fbaf8b6d543e4f5d75c41da6` |
| `feasibility/src/packages.lock.json` | `9a50991596ca623b8d4041f1ad193d9f3c18fcadaac18f5df824f2fb7baf4813` |
| `feasibility/src/probe-session.ps1` | `cc7af7189d96fe27e19fcf8700315dbae138ae251ca3549bca6672dcd3a5ac4b` |
| `feasibility/src/pty-probe.py` | `1534ef1c6699fc99a5f8e2242fe6f5cd9f3283cff4b3c4029ba9aa7d0cced5e8` |
| `feasibility/src/termios-abi.c` | `4e1597b0e853f8f8615369374a14f2b951ffb0e212711dafedbcdea799053d3c` |
| `plan.md` | `51464545f81c621a60b8389ca311f1b0242c4d73d93fa497c8692cfc06cd8128` |
| `quickstart.md` | `cb48d8da71e0d445e1e57aea66cf3584f2fa735cfbda606f37126b4f7b765c6f` |
| `research.md` | `34e0e597736ce0f431abd7dbedca8e693864b9e38bc005ea778c061a6859ac75` |
| `spec.md` | `a377786bedbf7d1aa0456411655ff42745bec0f2c86209c555912d6056d19e92` |
| `contracts/cmdlet-session.md` | `54ab17c91a3b2251b3911a5f10bcd2f078a624d302dcf0abcdfb9f19dc7dd5ca` |
| `tasks.md` | `ee3789c1f9166936aeb419f3468b27fe799950281eea86d1b824aab37ab2ed85` |
| `../../docs/validation/lh01/platform-handoff.md` | `389f267aa8b992710b0acd57716e3f3bad7aa202e1cf5160ed046266a9c7a336` |
| `../../docs/validation/lh01/platform-handoff.json` | `82a5c263dbc76be769b48a31b172934a31dfb00c566e86a974dc55de5ca68e1a` |
| `../../docs/issue-drafts/lh01-platform-parent.md` | `dc774aa1995524e595a789dee11044b2ad3b977483533028e7ba490aa9889ab4` |
| `../../docs/issue-drafts/lh01-platform-macb.md` | `ecb200843508c67b68317354e655ed6f31b3ec77ba88e4812da24cd449cfdc5c` |
| `../../docs/issue-drafts/lh01-platform-windows.md` | `1546e6fe8ec3979009aefd659d337797abfb58f732b94443947bce920291a22e` |
| `../../docs/issue-drafts/lh01-platform-ubuntu-wsl2.md` | `3502af9987145225ee0784b9f569c902b92b5cec798223ce20b3632254770e5f` |
| `../../docs/validation/lh01/approved-commands.schema.json` | `aebc793ebef874e7b76b019e622f5bac3e54485e9b7be92e706190002cafd286` |

## Fokussiertes unabhängiges Re-review 2026-10-09 / Focused independent re-review 2026-10-09

### DE — Umfang und Ergebnis

Prüfer: separater Agent `/root/lh01_corrections_review`. Auftrag: ausschließlich
Textkorrekturen I1/I2/I3 in `spec.md` und `tasks.md` sowie ihre Abhängigkeiten und
Prüfgrenzen erneut unabhängig bewerten. Der oben dokumentierte technische Lauf vom
2026-10-08 bleibt historisch erhalten; seine Rohdaten wurden nicht neu erzeugt.

**Ergebnis: Ready für die begrenzte technische Planung; keine offenen Befunde im
geprüften Korrekturumfang.** I1 nennt abgeschlossene technische Planung und begrenzte
automatisierte Machbarkeit, praktische Abnahme und Implementierungsfreigabe bleiben
offen. Die frühere fehlende Architekturwahl/Fixture ist ausdrücklich historisch;
formale Architektur-ADRs und Startnachweise bleiben vor Produktcode erforderlich.
I2 führt T022 zusätzlich zu T018/T021 als Voraussetzung von T025 sowohl in der
Aufgabe als auch in der Abhängigkeitsbeschreibung. I3 ordnet T060 → T062 → gegebenenfalls
T063 → bedingtes T061: Abschlussartefakte vor Quellencommit und Statistikrender,
abschließende Statistik-/Homogenitätsprüfung danach. Ein nicht anwendbarer
vollständiger Abschlussbericht blockiert keinen begrenzten Lieferstand. Ohne
Lieferautorität bleibt der Statistik-/Homogenitätsdrift offen; neue Quellen nach
Render verlangen erneute Render-/Prüffolge. Alle 63 Aufgaben bleiben offen.

Alle 46 unveränderten bisherigen Hashbindungen stimmen weiterhin exakt. Die
aktuelle `spec.md`-Bindung wurde nach Prüfung erneuert; ihr bisheriger, am
2026-10-08 geprüfter SHA-256 war
`ff7f07296912e4cd09d5d676b0efad41b10fbb936b7726d996a3f02cfd9f3cb3`.
`tasks.md` ist für diesen fokussierten Prüfumfang neu gebunden. Intake und Receipt,
Fixturequellen und Evidence-Manifest wurden nicht geändert. Kein neuer
Produkt-/Plattformlauf, keine physische Terminal-/Screenreader-/Brailleprüfung,
kein Commit oder Remote-Schreibzugriff. Ready ist weder vollständige Abnahme noch
Implementierungs-/Lieferautorität; Ownergrenzen und Einzelpilotweg bleiben bestehen.

### EN — Scope and outcome

Reviewer: distinct agent `/root/lh01_corrections_review`. This focused review only
assessed I1/I2/I3 corrections in `spec.md` and `tasks.md`, their dependency order
and evidence boundaries. The 2026-10-08 technical review and its raw evidence
remain historical; no technical run was repeated.

**Outcome: Ready for bounded technical planning; no open findings in the reviewed
correction scope.** I1 distinguishes completed planning and bounded automated
feasibility from open practical acceptance and implementation authority. The old
absence of a selected design/fixture is explicitly historical; formal ADRs and
start evidence still precede product code. I2 explicitly makes T025 wait for
T018/T021/T022 in both task and dependency text. I3 orders T060, T062, applicable
T063 and conditional T061: create closure artefacts before the source commit and
statistics render, then verify final statistics/homogeneity. An inapplicable full
completion report does not block bounded delivery. Drift remains open without
delivery authority; later source changes require another render/check cycle.
All 63 tasks remain open.

All 46 unchanged prior hash bindings still match. The reviewed `spec.md` binding
was renewed, with its prior 2026-10-08 digest preserved above; `tasks.md` was newly
bound for this focused review. Intake/receipt, fixture sources and evidence
manifest were unchanged. No new product/platform run, physical assistive test,
commit or remote write was performed. Ready grants no full acceptance or
implementation/delivery authority; owner limits and standalone pilot remain intact.

## Fokussiertes unabhängiges Hand-off-Review 2026-10-09 / Focused independent hand-off review 2026-10-09

### DE — Umfang und Ergebnis

Prüfer: separater Agent `/root/lh01_handoff_review`. Auftrag: gemeinsamen
Plattform-Prüfvertrag und Prepared-Manifest, vier veröffentlichte Issue-Drafts
(#36–#39) sowie die T029/T053/T054-Ergänzungen unabhängig prüfen und betroffene
Hashbindungen erneuern. Die früheren Reviews und technischen Messdaten bleiben
historisch erhalten. Keine Produkt-, Plattform- oder Terminaltests wurden ausgeführt.

**Ergebnis: Ready für das begrenzte Hand-off-Vorbereitungspaket; keine offenen
Befunde im geprüften Umfang.** Das Manifest bleibt Prepared und
executionAuthorized=false. Produktcommit, Driverhash, erlaubte Kommandos und
Mac-A-Produktnachweis fehlen ausdrücklich; der geplante Driver ist tatsächlich
noch nicht vorhanden. Die Feasibility-Fixture ersetzt keinen dieser Nachweise.
Lesen eines Issues oder dieses Ready erteilt keine Ausführungsbefugnis.

Mac B/Mac mini M4 Pro, native Windows-11-PowerShell und Ubuntu24.04/Linux-PowerShell
in WSL2 sind getrennte Ziele. Der Agent muss tatsächliche Hosts/Versionen und exakt
freigegebene Commit-/Plan-/Driver-/Entscheidungsbindungen prüfen; Abweichung oder
fehlender Adapter führt zu Blocked. T029 erstellt künftig Driver/Harness, T053
bindet nach tatsächlichem Mac-A-Produktproof den Prüfstand, T054 verwendet erst
unter separatem Auftrag die drei Ziel-Hand-offs. Alle 63 Aufgaben bleiben offen.

Der geplante Ablauf ist explizit negativ vor positiv. Erwartete Abweisungen
benötigen Soll/Ist, Exitcode und Nullwirkung; bloßes Exit0 reicht nicht. Sichere
Abbruch-/Restoregrenzen, isolierte Schreibwurzeln, neue Run-UUIDs, synthetische
bereinigte Rohdaten, eingeschränkter Locked-Restore und fehlende Installations-/
Reparatur-/Remote-Autorität sind beschrieben. Ergebnisse und DE/EN-Berichte werden
maschinenlesbar gebunden; ein anderer Prüfer und Ownerabnahme bleiben eigenständige
Schritte. Reale Terminals/Screenreader sind Deferred, Braillehardware Excluded mit
Ownergrund; kein A11Y-, vollständiges Produkt- oder LH-00-Abnahme-PASS wird erzeugt.

Unabhängig geprüft: Prepared-Felder, 19 eindeutige Fall-IDs, 63 offene Task-IDs,
vorhandene lokale Quelllinks und finale gegenseitige Issue-URLs #36–#39. Die 47
unveränderten bisherigen Bindungen stimmen exakt. Die tasks.md-Bindung wurde nach
Prüfung erneuert; der bisherige Digest des vorangehenden Korrektur-Reviews war
`416bb8e7316518cb15483090ba5491f8a8c828c2154d13351a95a9f1750e2323`.
Sechs geprüfte Vertrags-/Draftdateien sind neu gebunden; insgesamt bestehen 54
aktuelle Hashbindungen. Intake/Receipt und technische Roh-Evidence unverändert.
Keine Implementation, Installation, neue Messung, Commits oder Remote-Schreibzugriffe
durch diesen Reviewer. Ready bewertet Vorbereitung, keine spätere Ausführung.
Der ergänzte Dokumentationsentscheid UpdateRequired ist geprüft: Zielgruppe,
Dokumentklasse, kanonische Quelle/Owner, Issue-zu-Evidence-Leserpfad, DE/EN,
sourceOnly ohne Home-Sync und Neubewertungstrigger sind konkret benannt.
Vorbereitete Texte werden nicht als ausgeführte Plattformbeispiele ausgegeben.

### EN — Scope and outcome

Reviewer: distinct agent `/root/lh01_handoff_review`. This focused review inspected
the platform contract/Prepared manifest, four published issue drafts (#36–#39)
and future T029/T053/T054 changes, then renewed affected bindings. Earlier reviews
and raw technical evidence retain historical scope. No product, platform or
terminal tests were executed.

**Outcome: Ready for the bounded hand-off preparation package; no open findings
in the reviewed scope.** Prepared and executionAuthorized=false remain; missing
product commit, driver digest, approved commands and actual Mac A product evidence
block execution. The planned driver does not yet exist. The feasibility fixture,
reading an issue or this Ready grant no execution authority.

Mac B/Mac mini M4 Pro, native Windows 11 PowerShell and Ubuntu24.04 Linux PowerShell
in WSL2 are separate targets. Actual hosts, versions and exact approved revision/
manifest/driver/decision bindings are prerequisites. Missing or conflicting inputs
and unavailable adapters yield Blocked. Future T029 creates driver/harness; T053
binds the test revision after genuine Mac A product proof; T054 executes separately
authorized target instructions. All 63 tasks remain open.

The negative-first sequence evaluates exact expectations, exit codes and zero
unintended effects. Safe stop/restore, isolated outputs, fresh run UUIDs, scrubbed
synthetic data, locked restore and no implicit installation/repair/remote authority
are explicit. Machine-readable evidence and bilingual reports require distinct
review followed by separate owner acceptance. Real terminals and screen readers
remain Deferred; Braille hardware remains owner-excluded for absent equipment,
without accessibility, full product or LH-00 acceptance claims.

Independently checked Prepared fields, 19 unique cases, 63 open tasks, local source
links and final reciprocal issue URLs. All 47 unchanged prior bindings still match.
The old tasks digest is preserved above and its current binding renewed; six
contract/draft files were added, giving 54 current bindings. Intake/receipt and
raw evidence remain unchanged. This reviewer made no implementation, installation,
new measurement, commit or remote write. Ready assesses preparation only.
The added UpdateRequired documentation decision explicitly identifies audience,
class, canonical source/owner, issue-to-evidence reader path, DE/EN, sourceOnly
without Home sync and reassessment triggers. Prepared documentation is not
misrepresented as executed platform examples.

## Unabhängiges Korrektur-Re-review nach PR #40 / Independent correction re-review after PR #40

Datum / Date: 2026-10-09. Prüfer / Reviewer: separater Agent
`/root/lh01_handoff_review`. Das vorherige 54-Bindungen-Review bleibt historisch;
die folgenden Aussagen gelten für die gezielten nachfolgenden Korrekturen.

### DE — Umfang und Ergebnis

**Ready für das korrigierte Vorbereitungspaket; keine offenen Befunde im geprüften
Korrekturumfang.** Die vier PR-Reviewbefunde sind nachvollziehbar geschlossen:

- S05 verlangt einen behandelbaren Produktfehler mit erfolgreicher Wiederherstellung.
  S07 ist ein separater diagnostischer Wiederherstellungsfehlerlauf. Sein Fallresultat
  bleibt Fail, sein Gesamtlauf Fail/Exit1; positive Läufe stoppen und beide Fehler
  bleiben erhalten. Erwarteter Fehler ist kein Restore-PASS oder Gesamt-PASS.
- Das lokale Version-1-Kommandoschema definiert Array/Object-Form, neun Pflichtfelder,
  Stringargumentarray und eindeutige Integer-Exitcodes sowie keine Zusatzfelder.
  T029/Vertrag verlangen zusätzlich semantische Bindungen, eindeutige Kommandokennungen,
  vollständigen aktivierten Fallumfang, freigegebene Executables und sichere relative
  Arbeitsverzeichnisse. Shape-PASS allein ist keine Ausführungsfreigabe.
- Alle 20 eindeutigen Fälle führen ausdrückliche evidenceIds; die Vereinigung deckt
  E01-01–E01-07 ab. EV01 ist die eindeutige Inventar-/Integritätsfallkennung.
  Resultate müssen die Zuordnung erhalten und NotRun/Deferred/Excluded offen berichten.
- Plan und Tasks besitzen getrennte richtige Quelllinks. Die ergänzten T029-Verträge
  sind künftige Implementierungsaufgaben, keine jetzt vorhandene Driverfunktion.

Prepared/executionAuthorized=false, fehlender Produktcommit/Driver/Mac-A-Produktproof,
getrennte Zielhosts und unabhängige Review-/Ownerentscheidung bleiben erhalten.
Kein Produkt-, Plattform-, Terminal- oder Hilfsmittellauf wurde ausgeführt. Das Schema
wurde als JSON und statischer Vertrag geprüft; zusätzlich validierte der Reviewer
unabhängig mittels PowerShell Test-Json die leere Prepared-Liste und ein vollständiges
Kommandobeispiel erfolgreich. Dies ist Schemaprüfung, kein Produktlauf.

51 unveränderte bisherige Bindungen stimmen. Drei geprüfte Bindungen wurden erneuert,
das neue lokale Kommandoschema zusätzlich gebunden: **55/55 aktuelle Bindungen gültig**.
Bisherige Digests des ursprünglichen Hand-off-Reviews bleiben hier historisch erhalten:

- `tasks.md`: `5772d187a4b0c9295336828a450a7f53776533d7ad7f498f58318894f0153955`.
- `../../docs/validation/lh01/platform-handoff.md`: `009dd41c5b7e57ef51a9a762ab6a6b173cdfe77028a575dbfec0ada1980be36f`.
- `../../docs/validation/lh01/platform-handoff.json`: `f75f032cac5fa431f4c2abc1722d5ed5daeb440c6d0eed1372379c023c532b4c`.

Intake/Receipt, Roh-Evidence und vier Issue-Drafts bleiben unverändert. Nur dieses
Review wurde durch den Reviewer geschrieben; keine Implementierung, Installation,
Commits oder Remote-Schreibzugriffe. Ready gilt ausschließlich für Vorbereitung.

### EN — Scope and outcome

**Ready for the corrected preparation package; no open findings in the reviewed
correction scope.** S05 is a handled product error with successful restore; S07
is a separate diagnostic restore-failure run with case Fail, overall Fail and
exit1, preserving both errors and stopping positive tests. An expected failure
never becomes restore or total Pass.

The local version-1 command schema defines closed objects and nine required fields,
string argument arrays and unique integer exit codes. T029 and the contract also
require semantic bindings, unique commands, full enabled executable-case coverage,
approved executables and safe relative directories. Shape validity grants no authority.
All 20 unique cases retain explicit evidenceIds covering E01-01–E01-07; EV01 avoids
identifier collision. Results must preserve this mapping and open coverage limits.
Plan and Tasks links are distinct and correct. These remain future driver tasks.

Prepared, no execution authority and missing product/driver/Mac A prerequisites remain;
target isolation, distinct review and owner acceptance are retained. No product,
platform, terminal or assistive tests were run. The schema was parsed and statically
reviewed; the distinct reviewer also successfully validated an empty Prepared array
and complete command exemplar with PowerShell Test-Json. This tests shape, not product.
51 unchanged bindings match; three were renewed and the schema added: 55/55 current
bindings match. Prior hashes are preserved above. Intake/receipt, raw evidence and
four issue drafts are unchanged. Only this review was written, without implementation,
installation, commits or remote writes. Ready covers preparation only.
