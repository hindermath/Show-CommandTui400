# T037–T044 — Unabhängiges technisches Review / Independent technical review

## DE — Ergebnis und Umfang

**Ready für das begrenzte Mac-A-Inkrement T037–T044.** Keine offenen Befunde,
Fragen oder akzeptierten Risiken. Prüfer `/root/lh01_keyboard_intake_review`,
Implementierungsautor `/root`; unterschiedliche Agenten. Dieses Review beurteilt
technische Quellen und vom Autor erzeugte Nachweise unabhängig lesend. Der Prüfer
hat keine Produkt-/Plattformtests erneut ausgeführt und keine Quellen verändert.
Nur dieser Reviewbericht wird geschrieben.

Geprüft wurden Aufgaben, Spec/Plan/Vertrag und Constitution gegen ActionDescriptor,
ActionAvailability, Dispatcher, KeyBindingValidator/Map, ViewState, Navigation,
Hilfe und TerminalApplication, Modelltests, Friend-Harness und PTY-/PowerShell-
Prüfaufbau. Die Whitelist und zweite Kontextkontrolle verhindern unbekannte,
falsche oder unverfügbare Aktionen. Enter aktiviert genau den fokussierten lokalen
Knopf; Tab/Pfeil/Bildnavigation und Framework-Fokus stimmen überein. Zurück erhält
Werte/Fokus und beendet Root nicht. Refresh, Bestätigung und spätere Ausführung
bleiben getrennt. Alle acht Funktionstastenaktionen sind remappbar; feste
Alt+H/B/X/M- und Esc-Rückwege bleiben erreichbar. Ungültige Syntax/Kollisionen
werden vor UI/Lease abgewiesen. F4/F9/F10/F11 bleiben sichtbar unverfügbar und
wirkungslos; kein Folgefeature, Such-/Import-/Netz-/Persistenz-/Ausführungspfad.
Ungebundene Tasten werden konsumiert, bevor Frameworkdefaults Wirkung entfalten.
Eigener Code bleibt managed C# ohne unsafe; native Grenzen/Lockfiles unverändert.

### Behobene Befunde

| ID | Schwere | Korrektur und unabhängige Nachprüfung |
|---|---|---|
| KA01 | Medium | Globales Enter/Confirm durch fokusabhängige Help-/ActionsMenu-/Refresh-Aktivierung ersetzt; Modellfälle und alle drei realen Produktbeobachtungen geprüft. |
| KA02 | Medium | Alle acht Funktionstastenaktionen statt nur drei konfigurierbar; feste Rettungspfade, Konflikt-/Remaptests und wirksame Legende erhalten. |
| KA03 | Medium | PTY-Driver fordert die gesamte feste Eingabefolge, genaue Aktionen/Kontexte/Fokus/Accepted-Werte, letzten expliziten Exit und unveränderte Module; vorzeitiges Ende kein verkürzter PASS. |
| KA04 | Low | Alte Nutzeranleitung eindeutig als historisches T018–T036-Inkrement eingeordnet; aktuelle T044-Remap-/Bediensektion separat. |
| KA05 | Low | Nicht erreichbare reine Modellaktion Confirm aus der UI-Verfügbarkeitslegende entfernt; kein zusätzlicher Formularkontext eingeführt. |

### Nachweise und Grenzen

Der geprüfte locked Build enthält 31 Modell-/Lifecycle-Prüfgruppen ohne kopierte
Host-SMA. Alle 14 Produktszenarien referenzieren dieselbe Assembly; ihre bereinigten
Protokollhashes wurden nachgerechnet. 13 Szenarien sind Pass/Exit0. Der absichtlich
injizierte Restorefehler bleibt **Fail/Exit1** mit erfülltem Diagnosevertrag; die
Injektion folgt erfolgreichem echtem Restore. Keyboard enthält 27 gesendete
Tastenereignisse einschließlich wirkungslosem unbekanntem z und 26 exakt erwartete
Produktbeobachtungen, einschließlich Enter auf jedem Knopf. Remap prüft F1→F2 und
F5→F6 sowie wirkungslose alte Belegungen. Fehler-/Cancel-/Stop-/Wiederöffnungs- und
Cursor-/Native-Restorefälle bleiben belegt. Test-zuerst und negative Driver-/
Werkzeugverträge sind getrennte Belege, keine Plattformabnahme.

Manifest-Quellhashes stimmen mit den aktuellen Rohbytes überein. Basis-HEAD und
geprüfter uncommitteter Quellsnapshot sind ausdrücklich getrennt; kein falscher
freigegebener fremder Produktcommit. Beide unveränderten Intakes haben gewöhnliche
Updates mit exakten Vorgängerarchiven und aktuelle andere Ready-Reviews. Dieses
technische Review ersetzt jene Reviews nicht und verändert ihre Tripel nicht.
Historische T017/T036-Nachweise bleiben historisch.

T045–T063, vollständige Assurance, Plattform-/Feature-/Prozessabnahme bleiben offen.
Assurance-Delta NeedsRemediation ist kein Widerspruch zu diesem eng begrenzten
technischen Ready. Mac B, Windows11 und Ubuntu/WSL2 wurden hier nicht ausgeführt.
Hand-offs bleiben Prepared: ausdrückliche Commit-/Kommandobindung und Windows-
Terminaltestadapter fehlen. Reale Terminals/Screenreader Deferred; Braillehardware
Excluded wegen fehlendem Gerät im privaten persönlichen Projekt. Keine WCAG-
Konformität, Ownerabnahme, Risikoannahme, Serienaktivierung oder LH02-Freigabe.
Die separat beauftragte Lieferung erfordert ihre eigenen exakten Head-/CI-Gates.
Änderungen an gebundenen Quellen/Belegen verlangen erneute passende Prüfung.

## EN — Outcome, resolved findings and limits

**Ready for bounded Mac A T037–T044 only**, with no open findings, questions or
accepted risks. Reviewer `/root/lh01_keyboard_intake_review` is distinct from
author `/root`. This review independently reads product/test sources and author-
generated evidence; it did not rerun product/platform tests or mutate sources.

Spec/plan/tasks/contract/constitution were checked against action availability,
context allow-list/dispatcher, all eight validated function-key remaps, fixed
Alt/Esc escape routes, local navigation/help, actual Framework focus and terminal
adapter integration. Enter activates the focused local control; root back does
not exit; local state survives refresh/confirm/back. Unavailable future actions
remain effect-free; no later search/forms/invocation/devices, network/import or
persistence is added. Unknown input is consumed before Framework defaults.
Managed own code stays unsafe-free; native/supply-chain boundaries are unchanged.

KA01 fixes global Enter to use the focused control; KA02 completes remapping;
KA03 prevents truncated PTY sequences from passing and checks exact effects/focus;
KA04 labels earlier user instructions historical; KA05 removes unreachable model-
only Confirm from the UI availability legend. All fixes were independently read
and reconciled with final proof, with no remaining finding.

The locked build records31 model/lifecycle groups and no redistributed host SMA.
All14 scenarios bind one assembly; sanitized transcript hashes were independently
recomputed. Thirteen Pass/Exit0, one deliberately Fail/Exit1 restoration injection
with the diagnostic contract satisfied. Keyboard sends27 inputs including inert z
and produces26 exact expected observations; Enter activates each local control.
Actual F1→F2 and F5→F6 remaps, fixed alternatives, zero module change and the prior
lifecycle/restoration regressions remain evidenced. Negative model/driver/tooling
proof does not establish native foreign-host or assistive acceptance.

Exact current source/evidence raw hashes follow. The base HEAD is distinguished
from the tested uncommitted snapshot and is not an approved foreign-host test
revision. Ordinary LH00/LH01 updates and separate current intake Ready reviews
remain untouched. T045–T063 and broader Assurance/platform/feature/process
acceptance stay open. NeedsRemediation in the full Assurance delta is separate
from this bounded technical Ready. All three hand-offs remain Prepared, missing
explicit commit/command approval and the Windows terminal test adapter. Physical
terminals/screen readers remain Deferred; Braille hardware Excluded for the owner's
hardware reason. No conformance, human acceptance, risk decision, series activation
or LH02 authority. Delivery retains its separately authorized exact-head/CI gates.

## Exakte Rohhashbindungen / Exact raw hash bindings

```json
{
  "reviewId": "42d0d896-bfa4-43ad-b6dc-41be38d56e39",
  "status": "Ready",
  "scope": "LH01 T037–T044 Mac A technical/security increment only",
  "reviewer": "Codex /root/lh01_keyboard_intake_review",
  "author": "Codex /root",
  "distinctFromAuthor": true,
  "reviewedAt": "2026-10-12T20:52:17.755324+00:00",
  "openFindings": [],
  "acceptedRisks": [],
  "resolvedFindings": [
    "KA01",
    "KA02",
    "KA03",
    "KA04",
    "KA05"
  ],
  "bindings": [
    {
      "path": ".specify/memory/constitution.md",
      "rawSha256":
      "2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d"
    },
    {
      "path": "constitution.md",
      "rawSha256":
      "2a657bb6ada33344bfad7c2ba0822c8b1f8f30c97c4eb951770dd76c8d99de4d"
    },
    {
      "path": "docs/lh01/session-and-terminal.md",
      "rawSha256":
      "9e2fa029a443d7326b26bb66a16c1a267eeacbee6203967c4086c12e5bf115f5"
    },
    {
      "path": "docs/security/secure-development/2026-10-09-lh01-tui-foundation/deltas/lh01-keyboard-increment.json",
      "rawSha256":
      "9d64c7ebdb4856f94346806ccf19c62d191dbaaa3c64d62d156912ab454c1790"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-checks.md",
      "rawSha256":
      "1fd2a03f2cae5195bafb6091b20e95092d7100d428fc3858935f3bd631ac3655"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/AggregateFailure.json",
      "rawSha256":
      "30182b5ea1fb39665f84f5833685f349e85377834f72adbb43613db2174e24dc"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/BindingConflict.json",
      "rawSha256":
      "7227d0fd48d1fba13760e9543a644ee034adbe7d8a5c675b8620e469a836fc3f"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Cancel.json",
      "rawSha256":
      "edffd3817e6a0f9944ff223d9199f14fc4c0907112cf899c7df738f1ce198db6"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/FunctionExit.json",
      "rawSha256":
      "27719b479c5331c150f8fc1307d63bf3b12a3fc7a07dfbc673f9d42c3254f0fc"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/HandledFailure.json",
      "rawSha256":
      "2edd482a909ef57c6135765698e30f4c517fe033eb862f6e0363d3f94c8ce86f"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/HiddenCursor.json",
      "rawSha256":
      "97dac1690d23b2e71b07384ca4b06720c7942d9dd94557505eb0dfd393a8bc4f"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/InputRedirect.json",
      "rawSha256":
      "fb05e5956d30079595edb11fccdde3807b8cdc2170af2588791f6d4fba117ce4"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Keyboard.json",
      "rawSha256":
      "42915acb005ba8b7ab2f019e309be6e6cb387b2b7c5ac44aa7a18748e69465e0"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Normal.json",
      "rawSha256":
      "69aa45b5c0c96296dc6164598ce4548fc8877286f1568128790b34199e0f5791"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Redirect.json",
      "rawSha256":
      "d00721fc0563ec8a7e122abdcf21da92bed3c6a69275ee82b9bdf4747a09b561"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Remap.json",
      "rawSha256":
      "9edbff5f25a3f552283df22ea2d27b1cc0089b43c35da33c906831ec4c4861c9"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Repeat.json",
      "rawSha256":
      "a8ffcfb60bbee3c86337ffe648131d53bd8e7fc8ae8229fad298b99a7dd5dab8"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/RestorationFailure.json",
      "rawSha256":
      "611ac003263df17fed434f1e9dc7a9be742a0c80b06793a57646b6897d7ea9c3"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/Stop.json",
      "rawSha256":
      "2c13a2c6f94191ab2cc8570528789313bc2f92b7d3036a3cf662d82d70114f6d"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/build-contract.json",
      "rawSha256":
      "85538c150554e0b84da877662dd30bef23fab5d363888a443216538dfb2a3092"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/driver-contract.json",
      "rawSha256":
      "1e62f10a3d761191b40e5a1d9dd289f79d0a4a0add3e8676e60b3fd8e58a159e"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/manifest.json",
      "rawSha256":
      "78413a23a0192b93a39cdd6a011accb26ab668da1f9664be2d355f3d5bcf9239"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/test-first.json",
      "rawSha256":
      "2b03a0fbeafdbd449641c36446c2e37704df2865262a8b67a1d81accdc2f41ee"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions-maca/tooling-contract.json",
      "rawSha256":
      "1e178321f2e4419490ab358a28ef85283e7c84775389b3a4d3036170df3e0dbc"
    },
    {
      "path": "docs/validation/lh01/keyboard-actions.md",
      "rawSha256":
      "292d7795eb5c80f819a1f676b0c087322345d2237a215c8db389e5a0401313fb"
    },
    {
      "path": "specs/002-lh01-tui-foundation/contracts/actions-terminal.md",
      "rawSha256":
      "298a1dc81fef9fd819186ec63615c1a6803a2efa933c81464b1b5eb53f02d2b7"
    },
    {
      "path": "specs/002-lh01-tui-foundation/plan.md",
      "rawSha256":
      "889448fe38f4eb9f3a8aa7c9bf18ef15b037ddb8b0239648ab469517b92f7054"
    },
    {
      "path": "specs/002-lh01-tui-foundation/spec.md",
      "rawSha256":
      "37821498a41a190c737e9cc93124dc441bcdca9cf8c1a513df16a61c37d70ddc"
    },
    {
      "path": "specs/002-lh01-tui-foundation/tasks.md",
      "rawSha256":
      "d2c0c5adfff1da83196abae04be7e1f9359750834167c4c5917409146860fb56"
    },
    {
      "path": "specs/intake-authoring-receipts/lh-00.json",
      "rawSha256":
      "0cdf3c141fca155c5de4ba2052cf3c07da28d736520c9286a44aaaff01c6c2cc"
    },
    {
      "path": "specs/intake-authoring-receipts/lh-01.json",
      "rawSha256":
      "facc5c95411f78fb5b2347efa73ae1377e3df6e317e38e3cf59f3b8e9e303c3d"
    },
    {
      "path": "specs/intake-review-result.json",
      "rawSha256":
      "43e1ef25979de36d3836ede7f3fed039d832128fcd15329cc2aeb8de3770d2bc"
    },
    {
      "path": "specs/intake-reviews/lh-01/result.json",
      "rawSha256":
      "c69965ff98f6d52eb1458fe386cbe4b2431f44957ec3fdc542699b81904c8e44"
    },
    {
      "path": "src/Directory.Build.props",
      "rawSha256":
      "32e91a5ddd7e191c3a2ec198a561a914ddebed129c2eb4a20f16f9839c8e241a"
    },
    {
      "path": "src/ShowCommandTui400/Actions/ActionAvailability.cs",
      "rawSha256":
      "ffdab84f8d858d4c289800f3c04ec7ec715e1c0211f63d8eed4f2065fce22207"
    },
    {
      "path": "src/ShowCommandTui400/Actions/ActionDescriptor.cs",
      "rawSha256":
      "fc7634fc88d36796ec9787071fdbcfae1d8ef07caa3325486c6a2a55b395e6ef"
    },
    {
      "path": "src/ShowCommandTui400/Actions/ActionDispatcher.cs",
      "rawSha256":
      "83554f2020eec1a7985dcacaffd0b1ee3f3b2ca897c11a2bcd89b661d30d3ba3"
    },
    {
      "path": "src/ShowCommandTui400/Actions/KeyBindingMap.cs",
      "rawSha256":
      "a1ab6b00e7d9fc55c50646e7658be8b78d4e42d1a5ca95abfb368c51e798f082"
    },
    {
      "path": "src/ShowCommandTui400/Actions/KeyBindingValidator.cs",
      "rawSha256":
      "c1e686d854af0b811564829c10bf8a518cbfc839f3d18cb471ecfa0bdc9f8bc5"
    },
    {
      "path": "src/ShowCommandTui400/Commands/ShowCommandTui400Command.cs",
      "rawSha256":
      "078f44add0e20e7b8a191d0311f25395f4940eb7f3a01f130d2e67c9b9a9a347"
    },
    {
      "path": "src/ShowCommandTui400/NuGet.Config",
      "rawSha256":
      "7a77c63a438cdf0524dc336da4bf2191d3f259645de430f5a4c61b3edd52fa9f"
    },
    {
      "path": "src/ShowCommandTui400/Presentation/SafeDisplayText.cs",
      "rawSha256":
      "abaaec8c5cf8ba6c1e51fdd459028c6e2810232ffd25015b9cdf82de545d5749"
    },
    {
      "path": "src/ShowCommandTui400/Session/CallerSessionAdapter.cs",
      "rawSha256":
      "d616c0fb8c0d908bb5bf13edabc30bbfda2598f5a840dde288a94ebab0be8f8a"
    },
    {
      "path": "src/ShowCommandTui400/Session/EntryGuard.cs",
      "rawSha256":
      "f382fa791f8d107ed21b641d1735058458ed5eac72252299ed541de9351e1637"
    },
    {
      "path": "src/ShowCommandTui400/Session/SessionContext.cs",
      "rawSha256":
      "b704fd55fb59f9d1b0926b051cea46050f0e3ae3a36f7ed1551a76ac2a87c138"
    },
    {
      "path": "src/ShowCommandTui400/ShowCommandTui400.csproj",
      "rawSha256":
      "6f7e753909d10c0a53d06f4e1248600851a38eb157b2611b51f2e3f4c4484007"
    },
    {
      "path": "src/ShowCommandTui400/ShowCommandTui400.psd1",
      "rawSha256":
      "fbc58b2fb0420865dca62ad9246aa18d3c5cb05f35cd69b648d2fc933185978a"
    },
    {
      "path": "src/ShowCommandTui400/State/ViewState.cs",
      "rawSha256":
      "923cf163685fbc7457315d79e0e11e6f6a4528464e577b2708744f7e502f568b"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/ITerminalLease.cs",
      "rawSha256":
      "5eacc9062c95ff9e620f2735eb60a267d8af140d2d7b38c49fd96a9013771ca1"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/LinuxTerminalLease.cs",
      "rawSha256":
      "0cf90c10263c95c5eac4ba2b236de31780607a7bee4d846f76c2f39fbd71dc43"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/MacTerminalLease.cs",
      "rawSha256":
      "3d327545861afeb64b5f919645a3a68e1765fdc2d8efe236b505e607a490b348"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/NativeTerminalLease.cs",
      "rawSha256":
      "192104cdcaa5e72fde8b0af51b3574b42fe459d5cfea80dad85af5a7eac62fd9"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/TerminalApplication.cs",
      "rawSha256":
      "c43d3caf54c8a2a7a81e75c0cd05676c304d065d9eac79c80215b162abda3279"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/TerminalLifecycle.cs",
      "rawSha256":
      "ac3a561f9f90de1efa642b40c54456e0f5398074284c8fbd16c60e6079413984"
    },
    {
      "path": "src/ShowCommandTui400/Terminal/WindowsTerminalLease.cs",
      "rawSha256":
      "e4609d6cea031c5e5903ded3645e560bf350a3ba9acae20cde08d2d35aa2d1d2"
    },
    {
      "path": "src/ShowCommandTui400/Views/ActionHelpView.cs",
      "rawSha256":
      "ae726aebd6870fa22ce5f05e8566f714bdf43666e8a6045eecbc6549ef09c62b"
    },
    {
      "path": "src/ShowCommandTui400/Views/NavigationAdapter.cs",
      "rawSha256":
      "b342c5f4379738ef2b638a30a3ac2cddeec4e4f8a8926a6dcd4a33f4c438ae68"
    },
    {
      "path": "src/ShowCommandTui400/packages.lock.json",
      "rawSha256":
      "9a50991596ca623b8d4041f1ad193d9f3c18fcadaac18f5df824f2fb7baf4813"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/ActionContractTests.cs",
      "rawSha256":
      "35cc44e77b6751465972642c3902642644516c1a50759b0f5ceb125d0f4f4d2f"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/EntryBoundaryTests.cs",
      "rawSha256":
      "f22d24b2617f53ed5704e1d782622e0bdf8e16cc0758b3badf262f1f4755416d"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/KeyBindingTests.cs",
      "rawSha256":
      "87622296d29c9cb5ff7ad5fa086e8214c3239b9c491a82b09ecdcc90e7d669f2"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/ProductHarness.cs",
      "rawSha256":
      "20de4086154a02f5f0668822e0c6163b586860981a87ae062268fa6053e3ae99"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/ShowCommandTui400.Tests.csproj",
      "rawSha256":
      "0ddbbb332f7267bdad22caaa3fe2ec39b31f97633494e2a185dcff6bf0d80ac7"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/TerminalLifecycleTests.cs",
      "rawSha256":
      "7c1a43fd9b2d0a537964e82676ef99df4c0eec948dc1ce4f45295acc2a41d58d"
    },
    {
      "path": "tests/ShowCommandTui400.Tests/packages.lock.json",
      "rawSha256":
      "be152f8f6783b9c9f74ff2c1700fee5e38815dfbba0a8772872b62e9c88cd998"
    },
    {
      "path": "tests/feasibility/lh01/Invoke-Lh01ContractProof.ps1",
      "rawSha256":
      "fa6a24f803fa2e18190cd662cf79a514904e3645e896cd19ff0042a16416b9de"
    },
    {
      "path": "tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1",
      "rawSha256":
      "b31da5792498b6400352e12dab39803173f55810d9ceb1a426a0369b38a20abc"
    },
    {
      "path": "tests/feasibility/lh01/README.md",
      "rawSha256":
      "8208dbe3e5cf9ccd56aa9d4f3fd0cc078cf6dd99e4a8c3e4b526ee478ba4bbbe"
    },
    {
      "path": "tests/feasibility/lh01/proof-driver-contract.py",
      "rawSha256":
      "5640f8391c91eb70e0964f51c268126302e7129c67198d9cd87b6fbaa4fc33da"
    },
    {
      "path": "tests/feasibility/lh01/proof-tooling-contract.py",
      "rawSha256":
      "223cf79d29cc80ab3e066add242b8bb55d5659330e18638c2c06eddab3f858d6"
    },
    {
      "path": "tests/feasibility/lh01/pty-product.py",
      "rawSha256":
      "d956dbd72ec5935e79a15f041aafeaefe6173cbeedfd6f80041abb65ccb7c808"
    },
    {
      "path": "tests/feasibility/lh01/session-contract.ps1",
      "rawSha256":
      "87d16397941dd465e9a27c91cde97e35191004ff2167c321ea9dced39099805e"
    },
    {
      "path": "tests/feasibility/lh01/terminal_probes.py",
      "rawSha256":
      "35e7f2b74e27a348a2fd24cd70496c15d8a7572527cc1a61276f289fa428e257"
    }
  ]
}
```
