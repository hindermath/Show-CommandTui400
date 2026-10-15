# Aktuelle Plattformmatrix / Current platform matrix

## DE

Owner: Thorsten Hindermann. Aktualisiert 2026-10-15. Der aktuelle Prüfcommit und
alle Bindungen stehen im [Manifest](platform-handoff.json), sein Hash in
[platform-handoff.sha256](platform-handoff.sha256). Der neue vollständige
[Mac-A-Lauf](platform-proof-maca/20261015-64fe627/suite-result.json) umfasst
19 reguläre Pass-Fälle und einen getrennten erwarteten S07-Fail. Die gemeinsame
K01-Gruppe prüft jetzt auch sichtbare Hilfe-/Refresh-Farben bei Standard-/Remap-Tasten.

| Ziel | Aktueller Stand | Review / Abnahme |
|---|---|---|
| Mac A, MacBook Air M2 2023 | Vollständige Automationssuite Pass; S07 separat Fail | Keine Vollabnahme |
| Mac B, Mac mini M4 Pro, #37 | Aktualisierter Auftrag vorbereitet; NotRun | Open |
| Windows11 nativ, #38 | Aktualisierter Auftrag vorbereitet; NotRun | Open |
| Ubuntu24.04 / WSL2, #39 | Aktualisierter Auftrag vorbereitet; NotRun | Open |
| Native Linux-/Windows-Server-CI | Technische PR-Checks des Lieferpakets getrennt prüfen | Kein Zielhostersatz |

IDE-Prüfungen gemäß [Einrichtung](../../lh01/development-setup.md) werden getrennt
berichtet: Rider/VS Code auf Mac B, Rider/VS Code/Visual Studio auf Windows,
WSL-Backend beziehungsweise WSL-Fenster unter Ubuntu. Fehlender GUI-Zugriff oder
fehlende IDE bleibt Open/Blocked; ein CLI-Build ist kein IDE-Nachweis. Keine
Installation, Reparatur, Issue-Schließung oder Abnahme durch den Prüfagenten.
Reale Terminal-/Screenreaderabnahme Deferred; Braillehardware Excluded mangels Gerät.

## EN

The current manifest/hash and fresh full Mac A proof are linked above. Nineteen
regular cases pass; diagnostic S07 deliberately stays Fail. Shared K01 now checks
actual visible help/refresh colors for default/remapped keys. Mac B, native Windows11
and Ubuntu24.04/WSL2 remain NotRun with independent review/acceptance Open. Delivery
CI proves only its native runners. IDE checks are separate; absent UI/IDE access is
Open/Blocked, not CLI-based acceptance. No installation, repair, closure or acceptance.
Physical terminal/screen-reader acceptance is Deferred; Braille hardware Excluded.

## Historischer Stand bis PR #48 / Historical state through PR #48

Der folgende frühere Bericht gehört ausschließlich zum alten Prüfcommit und
seinen Rohbelegen. / The following report belongs only to the old revision/evidence.

### Frühere Plattformmatrix / Earlier matrix

## DE — Stand und Grenzen

Owner: Thorsten Hindermann. Prüfautor: Codex. Auftrag: T053/T054, MergeAndSync mit Admin-Bypass. Mac A ist das MacBook Air M2 2023. Der [Prüfvertrag](platform-handoff.md) und das [Manifest](platform-handoff.json) trennen Produktcommit, spätere Genehmigung und tatsächliche Zielausführung.

T053 erhält einen frischen, vollständigen automatisierten Mac-A-Produktnachweis. T054 liefert native Linux-/Windows-CI und ausführbare Agentenaufträge; die drei echten Zielhostläufe und deren anderes Ergebnisreview bleiben offen. Keine vollständige Produkt-/Plattform-/A11Y-Abnahme. T055–T063 sind nicht ausgeführt.

| Umgebung | Automatischer Nachweis | Tatsächliche Aussage |
|---|---|---|
| Mac A / MacBook Air M2 | neuer vollständiger Produktlauf, siehe unten | synthetische PTY-/Sitzungsprüfung auf diesem Mac |
| CI Ubuntu24.04, azure-Kernel, glibc x64 | nativer Build und Unix-PTY | ausschließlich CI-Runner, kein WSL2 |
| CI Windows Server2022 x64 | nativer Build und ConPTY | ausschließlich CI-Runner, kein Windows11 |
| Mac B / Mac mini M4 Pro | NotRun; [#37](https://github.com/hindermath/Show-CommandTui400/issues/37) | ausdrücklicher Zielhostauftrag und vorhandene Werkzeuge nötig |
| Windows11 nativ | NotRun; [#38](https://github.com/hindermath/Show-CommandTui400/issues/38) | getrennt von WSL2 und Server-CI |
| Ubuntu24.04/WSL2 | NotRun; [#39](https://github.com/hindermath/Show-CommandTui400/issues/39) | tatsächliche Distro-, WSL- und Windows-Hostversion erforderlich |

Vollständiger Bestand: 20 Fallverträge, davon 19 reguläre Fälle `Pass` und der getrennte S07-Diagnosefall `Fail/exit1`. Ein erfüllter S07-Diagnosevertrag ist keine erfolgreiche Wiederherstellung. Die Sitzungs-/Terminalgruppen umfassen 19 PTY-/ConPTY-Szenarioläufe einschließlich der getrennten Restore-Injektion; wiederholte Eintritte werden auch in S01/S06 geprüft. B01 führt 43 Modell-/Lifecycle-Prüfgruppen aus. 7.6.4 ist eine explizite Modellgrenze; tatsächlich ausgeführte Hosts und Runtime-/SDK-Versionen stehen in den JSON-Nachweisen. Host-SMA wird nicht mitgeliefert. Die bestehende CS0618-TextView-Warnung bleibt dokumentiert und wird nicht unterdrückt.

Die Windows-Adapterentwicklung fand native Fehler: zuerst übernommene Capture-Streams statt Konsolenhandles, anschließend eine Vorzeichenkonvertierung beim Win32-Zugriffsflag. Explizite native Handles trennen stdin/stdout korrekt und starten den kontrollierten Produkttesthost. Die 1×1-Ausgabe zerlegt Textmarker; externe synthetische Bereitschaftssignale vermeiden diese Abhängigkeit. Fehlgeschlagene CI-Läufe bleiben in PR #48 historisch sichtbar und zählen nicht als PASS.

Erlaubte Schreibpfade sind neue externe Laufwurzeln, darin Buildoutputs, temporäre Dateien, NuGet-Caches und CLI-Home. Restore nutzt die gesperrte Repository-Konfiguration; keine Werkzeuginstallation auf Zielhosts. CI darf die ausdrücklich gebundenen Tools ausschließlich im Runner bereitstellen. Produktcode, öffentliche API, Intakes, Receipts, unabhängige Intake-Reviews, Serienstatus, Constitution und fünf Guidance-Kopien bleiben unverändert.

Praktische Terminal-/Screenreader-Abnahme **Deferred**; Braillehardware **Excluded** mangels Gerät im privaten Projekt. Bei Hardware-/Scopeänderung oder gesondertem Prüfauftrag neu bewerten. LH-00-Prozessabnahme nach LH-02/vor LH-03 bleibt getrennt. Codeprüfung hier durch den Implementierungsautor; vollständiges unabhängiges Architektur-/Assurance-Review bleibt T058. Copilot konnte PR #48 wegen Review-Kontingent nicht prüfen: Dienstgrenze, kein bestandenes Review.

## EN — Current state and limits

Thorsten owns acceptance; Codex performs this bounded T053/T054 delivery. Mac A is the MacBook Air M2 2023. The linked manifest/contract bind the immutable product stand separately from later approval and actual target execution. T053 provides fresh full local product automation. T054 adds native Linux/Windows CI and executable agent orders, while actual Mac B, Windows11 and Ubuntu24.04/WSL2 runs and distinct evidence reviews remain NotRun/Open. T055–T063 are not executed; no full product, platform or assistive acceptance follows.

The matrix separates real Mac A proof, Ubuntu24.04/azure-glibc CI, Windows Server2022 CI and the three absent target hosts. Each full automated suite retains 19 regular Pass cases and a separate S07 Fail/exit1 with satisfied diagnostic expectations. That failure is never successful restoration. Scenario bundles cover repeat entry, keyboard/remapping, size/text state, small/tiny exit and native restoration; B01 runs 43 model/lifecycle groups. PS7.6.4 remains a tested model boundary rather than an executed minimum-version host. JSON records identify actual versions and commit/file hashes. Host SMA is not redistributed; the existing TextView warning is retained.

Native Windows development exposed captured inherited streams, an unsigned access conversion and screen wrapping of readiness markers. Explicit native handles and external synthetic signals correct these test boundaries. Earlier failed CI runs remain historical in PR #48 and are not relabelled Pass. Test-only process bootstrapping does not change product session integration. Unix and Windows native observations remain distinct.

Writes stay inside new external run roots, including build, temporary and restore/CLI caches. Only locked configured restore may use its feed; target agents must not install tools. Product API/code, intake provenance, independent intake review, series state and shared guidance remain unchanged. Physical terminals/screen readers are Deferred; Braille hardware Excluded for absent hardware in this private project. Full independent architecture/assurance review remains T058; Copilot's quota failure is a service limit, not a passed review. Preserve separate LH-00 acceptance after LH-02/before LH-03.

## DE — Konkrete Bindung und Nachweise

Produktcommit: `41ec0f34d35c9d9e187e1a101b806d7ac93f6b00`. Das [Manifest](platform-handoff.json) bindet 58 Ausführungsdateien und 60 Kommandos; der [Manifesthash](platform-handoff.sha256) gehört in jeden Zielauftrag. [Mac-A-Export](platform-proof-maca/suite-result.json): macOS27.0.1 arm64, PS7.6.6, Host-.NET10.0.12, SDK10.0.401, Python3.9.6. Alle 20 Fallverträge erfüllt, regulärer Status Pass, S07 Fail mit erfülltem Diagnosevertrag. Sauberer isolierter Checkout vor/nach Lauf bestätigt.

[Native CI](platform-ci-evidence.json) und versionierte Rohbelege belegen denselben Quellpayload am tatsächlichen PR-Mergecommit `b1848b0157158fa4d821c975cfb3cea08753475d`: [Ubuntu](platform-proof-ci/ubuntu2404-ci/suite-result.json) mit Python3.12.3/glibc2.39; [Windows Server](platform-proof-ci/windows-server2022/suite-result.json) mit Python3.12.10/Build20348. Beide PS7.6.6, Host-.NET10.0.12, SDK10.0.401. Alle 58 Quellbindungen sind mit dem Produktcommit bytegleich; unterschiedliche Git-Versionierungsdaten machen die Binärhashes erwartbar verschieden und werden nicht gleichgesetzt.

Die Exporte erhalten die unveränderten originalen Suiteberichte sowie alle Fall-/Rohbelege. Nachweislich leere NuGet-Temporärlocks und Compiler-Caches werden nicht verteilt; Pfade und Originalhashes bleiben im Export ausdrücklich aufgeführt. Dies ändert keine Fallresultate. `.gitattributes` erhält die Rohbytes einschließlich Windows-CRLF; keine manuelle Hashkorrektur durch EOL-Normalisierung.

Preflight mit dem echten freigegebenen Manifest am Produktcommit auf Mac A: ausschließlich „Mac B hardware must be Mac mini M4 Pro“ als erwarteter Blocker, kein Hash-/Kommandofehler und keine geschriebene Ausgabewurzel. Dieser Negativnachweis ist kein Mac-B-Lauf. Mutierte Freigaben werden zusätzlich lesend abgewiesen; Quellen und Herkunft bleiben aktuell. Keine echten Fremdhosts geprüft.

## EN — Exact binding and evidence

The product commit above binds 58 execution files and 60 commands. Use the linked manifest digest in every target order. Fresh Mac A proof records macOS27.0.1/M2, PS7.6.6, host .NET10.0.12, SDK10.0.401/Python3.9.6 and all 20 fulfilled contracts, with the separate diagnostic Fail retained. The isolated checkout remained clean.

Versioned native CI raw evidence identifies its actual PR merge commit separately. All 58 source bindings match the selected product commit; do not equate binaries whose Git version information differs. Ubuntu uses glibc2.39/Python3.12.3, Windows Server build20348/Python3.12.10; both use PS7.6.6/host .NET10.0.12/SDK10.0.401. This is no actual target-host acceptance.

Exports retain original suite reports and every case/raw proof. Only explicitly listed temporary NuGet locks and compiler caches are omitted from distribution, with original paths/hashes preserved. Results are unchanged; Git attributes preserve raw CRLF bytes. Mac A CheckOnly validates the complete external approval at the product commit and blocks solely on expected Mac B hardware, without creating output. That is a negative host check, not Mac B execution. Mutated approvals are rejected separately; actual target runs and distinct reviews remain open.
