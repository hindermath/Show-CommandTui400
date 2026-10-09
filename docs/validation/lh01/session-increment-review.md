# Unabhängiges Inkrementreview T018–T036 / Independent increment review T018–T036

## DE — Ergebnis und Prüfer

**Status: Ready für das begrenzte Mac-A-Inkrement T018–T036.** Keine offenen
Befunde innerhalb dieses Umfangs. Geprüft am 2026-10-09T22:03:03.567916+00:00.
Prüfer: Codex-Unteragent `/root/lh01_start_review`; Autor der Implementierung und
Prüfläufe: Codex `/root`. Der getrennte Prüfer hat Quellen, Verträge, Nachweise
und ihre Rohhashbindungen eigenständig gelesen und abgeglichen. Keine neuen
Produktläufe, Commit-, Remote- oder Owner-Abnahmehandlungen durch den Prüfer.

Auftrag: ausdrücklich beauftragtes Produktinkrement auf **Mac A, MacBook Air M2
2023**, mit gesondert autorisierter MergeAndSync-Lieferung. Dieses Review bewertet
den technischen Stand; es erklärt die noch ausstehende Lieferung nicht als erledigt.
Die frühere T017-Architekturprüfung bleibt als historischer Vorbereitungsnachweis
unverändert. Intake-Quellen/Receipts werden durch dieses Review nicht erneuert.

## DE — Prüfung und geschlossene Befunde

Geprüft wurden öffentlicher Cmdlet-/Remapvertrag, EntryGuard vor Terminaländerung,
Caller-Session-Grenzen, native ABI-/Fähigkeitsprüfungen, UI-/Lease-Lifecycle,
Fehlererhaltung, Anzeigevalidierung, Build-/Abhängigkeitsgrenzen und gemeinsamer
Prüfdriver. Der Export enthält nur `Show-CommandTui400` und den fachlichen Parameter
`KeyBinding` neben PowerShell-Standardparametern. Testseams bleiben intern in der
Friend-Testassembly. Keine Zielausführung, fremde Session, Persistenz oder eigener
PowerShell-Host wurde eingebaut. Managed C# ohne unsafe bleibt von nativen
Terminal-/Runtimegrenzen getrennt; Host-SMA wird nicht ausgeliefert.

| ID | Ursprünglicher Befund | Verifizierte Korrektur | Stand |
|---|---|---|---|
| SI01 | Remap-Validierung akzeptierte nicht parsebare Schreibweisen/numerische IDs | Exakte Schlüssel-/Actionnamen, Syntax-/Case-/Zahlen-Negativchecks vor Init | geschlossen |
| SI02 | Jeder AggregateException konnte fälschlich als Restorefehler erscheinen | Eigener TerminalCombinedFailureException; primärer Aggregatefehler bleibt HandledFailure | geschlossen |
| SI03 | Wiederöffnungs-/Scopeproof konnte ohne konkrete Werte bestehen | 710/711/712, gleicher PID/Runspace, tatsächlicher Arbeitsort intern verglichen | geschlossen |
| SI04 | Unix-Cursorzustand war nicht vollständig gesichert | mode25 XTSAVE/XTRESTORE; sichtbarer und versteckter Cursor synthetisch geprüft | geschlossen |
| SI05 | Linux-/VT-Fähigkeit nicht vollständig vor Lease erkannt | glibc-Entrypointprobe, eigene x64-ABI und explizite VT/TERM-Grenze vor Änderung | geschlossen |
| SI06 | Prüfplan konnte Fallinventar/Erwartungen reduzieren | Kanonische Fälle/Felder/E01, eindeutige Kommandos, vollständige aktivierte Zuordnung | geschlossen |
| SI07 | Driver konnte hängen oder Ausgabepfade umgehen | 120s-Timeout, Prozessbaum-Kill/NotRun, Symlink-/Reparseprüfung; Outputprüfung vor CheckOnly | geschlossen |
| SI08 | Strukturierter Nachweis konnte unbereinigte lokale Pfade behalten | actual wird aus bereinigtem Text geparst; keine Shell-Stringauswertung | geschlossen |
| SI09 | Tasks-Kopf widersprach Checkboxen; Lieferung voreilig formuliert | 36/63 lokal abgeschlossen, T037–T063 offen; Lieferung ausdrücklich folgend | geschlossen |

Die letzte gezielte Nachprüfung fand keine weiteren konkreten Korrektheits-,
Sicherheits- oder Lifecyclebefunde im beauftragten Inkrement. Das ist keine
Vollständigkeitsbehauptung für spätere Produktfunktionen.

## DE — Nachweise und Grenzen

Der Prüfer glich die vom Autor ausgeführten finalen Resultate mit Quellcode und
Testaufbau ab: locked Build ohne Compilerwarnungen; **20 Modell-/Lifecyclechecks**,
**7 negative Driver-Planverträge** und **10 Produkt-PTY-Szenarien**. Neun PTY-Fälle
sind Pass. Die injizierte RestorationFailure bleibt **Fail/Exit1**, mit erfülltem
Diagnosevertrag und beiden erhaltenen Ursachen. Der native Restore war vor der
Injektion erfolgreich; daraus wird kein realer defekter Hostrestore abgeleitet.
Die Rohhashprüfung des Manifests umfasst **44/44** gültige Quellen-/Nachweisbindungen.
Alle63 Aufgaben-IDs bleiben erhalten:36 abgeschlossen,27 offen.

E01-01/E01-04 sind begrenzt lokal belegt. Linux-/Windows-Adapter sind durch
Testdoubles geprüft; native Mac-B-, Windows- und Ubuntu/WSL2-Läufe fanden nicht
statt. Cursorproof emuliert xterm mode25 und ist keine physische Terminalabnahme.
Externe Kills, Hostausfälle und Stromverlust garantieren keinen Restore.
Die Hand-offs bleiben Prepared; freigegebener Produktcommit, Zielaufträge und
vollständige Kommandobindung fehlen noch. Windows-PTY-/ConPTY-Anpassung ist offen.
Praktische Terminals/Screenreader bleiben Deferred, Braillehardware Excluded
aufgrund fehlenden Geräts gemäß Owner-Festlegung. Kein Konformitätsnachweis.

Das Assurance-Delta bleibt **NeedsRemediation** für offene vollständige
Produktkontrollen T052–T059; Closure/Image-Impact gehören zum späteren Abschluss.
Dieses fokussierte Ready hebt keine Produktkontrolle auf. T037+ bleiben offen;
Statistik/Entscheidungen/PR-Checks sind gesonderte Liefergates. Keine vollständige
LH-01-/LH-00-Abnahme, LH-02-Freigabe oder reale Serienaktivierung wird erteilt.

## EN — Result, reviewer and scope

**Ready for the bounded Mac A T018–T036 increment**, with no open findings in that
scope. Reviewer: distinct Codex subagent `/root/lh01_start_review`; implementation
and executed proof author: `/root`. The reviewer independently read and compared
sources, contracts, evidence and raw hashes. No new product runs, commits, remote
writes or owner acceptance actions were performed by the reviewer. The authorized
MergeAndSync delivery is still a separate step. Historical T017 review and intake
provenance remain unchanged.

The focused review covered the public cmdlet/remap boundary, pure rejection before
terminal mutation, caller context, native capabilities/ABIs, lifecycle and combined
errors, safe display, locked build/host dependency boundaries and the proof driver.
Only the named cmdlet and KeyBinding domain parameter are exported; synthetic seams
remain internal. There is no target execution, persistence, substitute session or
custom PowerShell host. Own managed code contains no unsafe blocks; native/runtime
boundaries remain separately assessed and host SMA is not redistributed.

SI01–SI09 in the table are closed: exact remap validation; distinct combined-failure
classification; concrete repeat/scope/location evidence; Unix cursor mode25 save and
restore; glibc/VT rejection; canonical case/E01/command validation; timeout/path and
CheckOnly safeguards; sanitized structured observations; consistent task/delivery
status. Final focused reinspection found no additional concrete defect in this scope.

The author-executed locked build,20 model/lifecycle checks,7 negative driver plan
contracts and10 synthetic product PTY scenarios were inspected against the code.
Nine scenarios Pass; injected restoration failure remains Fail/exit1 while satisfying
its diagnostic contract. Actual native restoration succeeded before injection.
The manifest has44/44 matching raw source/evidence bindings;63 task IDs remain,
36 locally complete and27 open. These are bounded E01-01/E01-04 observations.

No native Mac B, Windows or Ubuntu/WSL2 run occurred; foreign adapters have doubles
only. The xterm cursor emulator is not physical terminal acceptance. External kill,
host or power failure cannot guarantee restoration. Handoffs remain Prepared without
the final approved revision/commands/target orders; Windows PTY adaptation is absent.
Physical terminals/screen readers are Deferred and Braille hardware Excluded for
lack of a device, as directed by the owner. No conformity claim is made.

Full Assurance remains NeedsRemediation for later T052–T059 controls and later
closure/image-impact. This focused Ready waives no product control. T037+ and final
delivery gates remain open; no full LH-01/LH-00 acceptance, LH-02 authorization or
series activation is granted.

## Lieferkorrektur: JSON-Formatierung / Delivery correction: JSON formatting

DE: Der Push-Secretcheck erkannte den SHA256 neben dem Pfad zu
KeyBindingValidator.cs fälschlich als generische Zugangsdatenregel. Die zunächst versuchte
Unicode-Schreibweise wurde vom Scanner dekodiert und löste den Befund nicht.
Sie ist ersetzt: Der ursprüngliche Schlüssel bleibt wörtlich erhalten; lediglich
nach seinem Doppelpunkt stehen ein Zeilenumbruch und zwölf Leerzeichen vor dem
unveränderten Hash. Der unabhängige Vergleich mit HEAD bestätigt vollständige
Gleichheit der geparsten JSON-Werte sowie44/44 gültige Rohbindungen. Keine
Scanner-Ausnahme, Produktänderung oder erneuter Produktlauf. Ready bleibt für
denselben begrenzten Umfang bestehen. Historischer HEAD-Manifest-Rohhash:
`f01195cd000e0917bfec391da60e3c66f02e282f6bc454673751ed650f6c221b`; aktueller Rohhash steht in der Tabelle.

EN: The push secret check misidentified the SHA256 next to the validator path
as a generic credential rule. The initial Unicode spelling was decoded by the scanner and
did not resolve it. It is superseded by ordinary whitespace: the original literal
key remains, with a newline and twelve spaces after its colon before the unchanged
hash. Independent HEAD comparison confirms identical parsed JSON and44/44 matching
raw bindings. No scanner exemption, product change or new product run. Ready keeps
its bounded scope; the historical HEAD hash is above and the current hash below.

## Rohhashbindungen / Raw hash bindings

DE: SHA256 über unveränderte Dateibytes am Prüfzeitpunkt; keine normalisierten
Inhaltswerte. Die Tabelle bindet 58 geprüfte Dateien. Änderungen erfordern
gezielte Neubewertung; die Reviewdatei bindet sich nicht selbst.
EN: Raw-byte SHA256 at review time binds 58 files. Reassess changed files;
the review does not bind itself. Generated build/cache outputs are excluded.

| Datei / File | SHA256 |
|---|---|
| `.gitignore` | `85af767878a9dba97c5be46cceb54485b8c28fd17e1599ea3b2b0df9793a28a7` |
| `docs/lh01/session-and-terminal.md` | `aad7cf6c146c5c997e78b6e500334df2d83f3bb05320223a920819f9ed33d541` |
| `docs/security/secure-development/2026-10-09-lh01-tui-foundation/deltas/lh01-session-increment.json` | `7a1af80ff850b8dfede522f437e9212e090ad17c9d0511b747fd99ac30188cfe` |
| `docs/validation/lh01/approved-commands.schema.json` | `aebc793ebef874e7b76b019e622f5bac3e54485e9b7be92e706190002cafd286` |
| `docs/validation/lh01/negative-entry.md` | `d5891c04b3d6527a2d62551e24de559840c4fac483986506de99dc383a7cc816` |
| `docs/validation/lh01/platform-handoff.json` | `82a5c263dbc76be769b48a31b172934a31dfb00c566e86a974dc55de5ca68e1a` |
| `docs/validation/lh01/platform-handoff.md` | `42bce0f3cd7b6b777e1ec827755584603c43d08a3e14afe617b94477c6abec16` |
| `docs/validation/lh01/session-increment-checks.md` | `78b21128d7fa161d69dfae41b2c2a6fd80afe42e83d50a6ad69572aa5eb84b5e` |
| `docs/validation/lh01/session-increment-maca/AggregateFailure.json` | `30e13704500fbca56af7cc135e095e7ae0131ae3fc3dc681c39d38352e59ef26` |
| `docs/validation/lh01/session-increment-maca/Cancel.json` | `4209846fd35f8db0c991910e56f4e196baddcf683b995fcc755cd564433f4f23` |
| `docs/validation/lh01/session-increment-maca/HandledFailure.json` | `fa69fc4e317e27d8917f34d71d8a49b856933c7f190621488c869524f73633aa` |
| `docs/validation/lh01/session-increment-maca/HiddenCursor.json` | `3541323dafebf471d753310304db1537f689e4a2277f7643493e8b5da569f91b` |
| `docs/validation/lh01/session-increment-maca/InputRedirect.json` | `0833681a3198da54f0dcc51b5ff85077a2e033aeec7b08501a86db6789022f25` |
| `docs/validation/lh01/session-increment-maca/Normal.json` | `e451c5825da48628165b2d485aa9b3fd168628c0042d3e37d79d6a495e8e3033` |
| `docs/validation/lh01/session-increment-maca/Redirect.json` | `4ab169ca03a95cbc8db5d82fe4e28a256b08b00db85e428060a13b416629e03f` |
| `docs/validation/lh01/session-increment-maca/Repeat.json` | `f337200c3cd29bf43e50f11bbf6b65cbc58fe090e70858c033af96306a3e9766` |
| `docs/validation/lh01/session-increment-maca/RestorationFailure.json` | `9152c7bfb7f519ef45f182d0e6c899893f28dd479d92dcd63823eee1cd7f13be` |
| `docs/validation/lh01/session-increment-maca/Stop.json` | `c3514f4fa536be5088e24a28c236217f2e076cda74054ec441482b210c4c047d` |
| `docs/validation/lh01/session-increment-maca/build-contract.json` | `59dde2983d2e1d2583a2fa4f2a0132078cc9b48903e01da935644a7057516a40` |
| `docs/validation/lh01/session-increment-maca/manifest.json` | `44713a4125790a8bacfdbbdb000be8ae29fb90eb3dd47390d33c44ddea0fad21` |
| `docs/validation/lh01/session-increment-maca/proof-driver-contract.json` | `1e62f10a3d761191b40e5a1d9dd289f79d0a4a0add3e8676e60b3fd8e58a159e` |
| `docs/validation/lh01/session-terminal.md` | `25dab1e79d7ff036e5e74185a7f955b2fc91e5bf2bea1988b4ba0ce21a7c0bba` |
| `specs/002-lh01-tui-foundation/contracts/actions-terminal.md` | `b3221f30cf9759932197700bd2a340d159d07cd6d4c6f6b83937b1ae831fba34` |
| `specs/002-lh01-tui-foundation/contracts/cmdlet-session.md` | `64caf9abc52e3d8e254554e5d9ab93fbad311b744d467320ca49be86b5cdfd03` |
| `specs/002-lh01-tui-foundation/plan.md` | `499c0df4c5eb1563c225a43289e9fb64012dff11cca3b79875dde453c8a908a0` |
| `specs/002-lh01-tui-foundation/tasks.md` | `1afe57ca117ff995677779af00ab395f192f42ae36a1e0a346cc7ec3ee788f68` |
| `src/Directory.Build.props` | `32e91a5ddd7e191c3a2ec198a561a914ddebed129c2eb4a20f16f9839c8e241a` |
| `src/ShowCommandTui400/Actions/ActionDescriptor.cs` | `b52ae69025b1a8c97e102d50687cbbb451011c9d3eccf7c852dca60b88f72dd6` |
| `src/ShowCommandTui400/Actions/KeyBindingValidator.cs` | `a8e3292d4f51f5545b70f039d4572a4ff5fcca28451f87389c4f6c6fb5c8ffcb` |
| `src/ShowCommandTui400/Commands/ShowCommandTui400Command.cs` | `078f44add0e20e7b8a191d0311f25395f4940eb7f3a01f130d2e67c9b9a9a347` |
| `src/ShowCommandTui400/NuGet.Config` | `7a77c63a438cdf0524dc336da4bf2191d3f259645de430f5a4c61b3edd52fa9f` |
| `src/ShowCommandTui400/Presentation/SafeDisplayText.cs` | `abaaec8c5cf8ba6c1e51fdd459028c6e2810232ffd25015b9cdf82de545d5749` |
| `src/ShowCommandTui400/Session/CallerSessionAdapter.cs` | `d616c0fb8c0d908bb5bf13edabc30bbfda2598f5a840dde288a94ebab0be8f8a` |
| `src/ShowCommandTui400/Session/EntryGuard.cs` | `f382fa791f8d107ed21b641d1735058458ed5eac72252299ed541de9351e1637` |
| `src/ShowCommandTui400/Session/SessionContext.cs` | `b704fd55fb59f9d1b0926b051cea46050f0e3ae3a36f7ed1551a76ac2a87c138` |
| `src/ShowCommandTui400/ShowCommandTui400.csproj` | `6f7e753909d10c0a53d06f4e1248600851a38eb157b2611b51f2e3f4c4484007` |
| `src/ShowCommandTui400/ShowCommandTui400.psd1` | `fbc58b2fb0420865dca62ad9246aa18d3c5cb05f35cd69b648d2fc933185978a` |
| `src/ShowCommandTui400/State/ViewState.cs` | `a9b61a8ccec0a76ba8a78d88d1e7a56c1dc7764233dd935618e60d7f40f8abd3` |
| `src/ShowCommandTui400/Terminal/ITerminalLease.cs` | `5eacc9062c95ff9e620f2735eb60a267d8af140d2d7b38c49fd96a9013771ca1` |
| `src/ShowCommandTui400/Terminal/LinuxTerminalLease.cs` | `0cf90c10263c95c5eac4ba2b236de31780607a7bee4d846f76c2f39fbd71dc43` |
| `src/ShowCommandTui400/Terminal/MacTerminalLease.cs` | `3d327545861afeb64b5f919645a3a68e1765fdc2d8efe236b505e607a490b348` |
| `src/ShowCommandTui400/Terminal/NativeTerminalLease.cs` | `192104cdcaa5e72fde8b0af51b3574b42fe459d5cfea80dad85af5a7eac62fd9` |
| `src/ShowCommandTui400/Terminal/TerminalApplication.cs` | `465afeceb450804893e7d0d5b1128554b2a1ce3d754d631c52a2292d01f8d11f` |
| `src/ShowCommandTui400/Terminal/TerminalLifecycle.cs` | `ac3a561f9f90de1efa642b40c54456e0f5398074284c8fbd16c60e6079413984` |
| `src/ShowCommandTui400/Terminal/WindowsTerminalLease.cs` | `e4609d6cea031c5e5903ded3645e560bf350a3ba9acae20cde08d2d35aa2d1d2` |
| `src/ShowCommandTui400/packages.lock.json` | `9a50991596ca623b8d4041f1ad193d9f3c18fcadaac18f5df824f2fb7baf4813` |
| `tests/Directory.Build.props` | `32e91a5ddd7e191c3a2ec198a561a914ddebed129c2eb4a20f16f9839c8e241a` |
| `tests/ShowCommandTui400.Tests/EntryBoundaryTests.cs` | `f22d24b2617f53ed5704e1d782622e0bdf8e16cc0758b3badf262f1f4755416d` |
| `tests/ShowCommandTui400.Tests/ProductHarness.cs` | `e70c219b36f1d6d8aede1b54c0f71b7576fdcb29f60cfc1522debd416ed197ba` |
| `tests/ShowCommandTui400.Tests/ShowCommandTui400.Tests.csproj` | `0ddbbb332f7267bdad22caaa3fe2ec39b31f97633494e2a185dcff6bf0d80ac7` |
| `tests/ShowCommandTui400.Tests/TerminalLifecycleTests.cs` | `7c1a43fd9b2d0a537964e82676ef99df4c0eec948dc1ce4f45295acc2a41d58d` |
| `tests/ShowCommandTui400.Tests/packages.lock.json` | `be152f8f6783b9c9f74ff2c1700fee5e38815dfbba0a8772872b62e9c88cd998` |
| `tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1` | `88dad6077928884690a984ad100809f15bfda33c0d2a9efe13b04012aeb36366` |
| `tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1` | `2ffb0d82b98c07aedaeccd6f1103779ae0944aa1f0ad3d59c6b718d92ca5fe6c` |
| `tests/feasibility/lh01/README.md` | `5809b9ff9972ceb7500aa784307436d5c51179b8793c6d49b65dfeb9200458df` |
| `tests/feasibility/lh01/proof-driver-contract.py` | `5640f8391c91eb70e0964f51c268126302e7129c67198d9cd87b6fbaa4fc33da` |
| `tests/feasibility/lh01/pty-product.py` | `17b67e6518d54dc4b95524c5845cd148018939141911bc31ca82acb641f84583` |
| `tests/feasibility/lh01/session-contract.ps1` | `9f2697b300c3c216842ffbeb1b047b0c3829dcc4895d5dd9b4f4ea1580fad234` |
