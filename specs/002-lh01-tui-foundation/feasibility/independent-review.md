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
| `spec.md` | `ff7f07296912e4cd09d5d676b0efad41b10fbb936b7726d996a3f02cfd9f3cb3` |
| `contracts/cmdlet-session.md` | `54ab17c91a3b2251b3911a5f10bcd2f078a624d302dcf0abcdfb9f19dc7dd5ca` |
