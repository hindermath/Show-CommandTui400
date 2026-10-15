# LH-01 Hand-off: Windows 11 nativ

## DE — Aktueller freigegebener Prüfstand

Ersetzt den früheren Prüfstand aus PR #48. **Ausführbar nach ausdrücklichem
Hostauftrag**, nicht bereits ausgeführt. Die folgenden Bindungen sind verbindlich.
Die Übergabe des kopierten Prompts durch Thorsten autorisiert den genannten Host;
das bloße Lesen dieses Issues nicht. Eltern-Issue: [#36](https://github.com/hindermath/Show-CommandTui400/issues/36),
fachliches Issue [#2](https://github.com/hindermath/Show-CommandTui400/issues/2). Andere Ziele: #37, #38, #39.

- Produktcommit / Product: `64fe627e5f0799ce1a4f7d5ec1c26ceeea936e9b`.
- Genehmigungscommit / Approval: `0544c992d627a51a855dbfe5e8f908bec6dfe701`.
- Manifest-SHA-256: `71a56f525ed1dfa91f62a54a8018da548284dc58cdffbe695dac413d571b7194`.
- [Gepinnter Vertrag / Pinned contract](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.md), [Manifest](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.json), [SHA-256](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-handoff.sha256).
- [Vollständiger Mac-A-Nachweis / Complete Mac A proof](https://github.com/hindermath/Show-CommandTui400/tree/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-proof-maca/20261015-64fe627), [Matrix](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/validation/lh01/platform-matrix.md).
- [IDE-Einrichtung / IDE setup](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/docs/lh01/development-setup.md), [Plan](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/specs/002-lh01-tui-foundation/plan.md), [Tasks](https://github.com/hindermath/Show-CommandTui400/blob/0544c992d627a51a855dbfe5e8f908bec6dfe701/specs/002-lh01-tui-foundation/tasks.md).

## DE — Vollständiger Prompt zum Kopieren

```text
Ich beauftrage dich auf Windows 11 nativ mit der automatisierten LH-01-Prüfung
für Issue #38: https://github.com/hindermath/Show-CommandTui400/issues/38
Lies dieses Issue, Eltern-Issue #36 und den gepinnten Vertrag. Bei widersprüchlichen
Bindungen stoppen; keine neuere Revision eigenmächtig übernehmen.

Produktcommit: 64fe627e5f0799ce1a4f7d5ec1c26ceeea936e9b
Genehmigungscommit: 0544c992d627a51a855dbfe5e8f908bec6dfe701
Manifest-SHA-256: 71a56f525ed1dfa91f62a54a8018da548284dc58cdffbe695dac413d571b7194
Target: windows

Native Windows11-PowerShell-Sitzung, Build ab22000; kein WSL-Ersatz.
Vorhandene Werkzeuge prüfen: PowerShell>=7.6.4 auf Host-.NET10, passendes .NET10-
SDK/C#14 und Python>=3.9 als python3. NuGet-SMA7.6.4 ist nur Kompilierreferenz;
keine PSHOME-DLL und keine zweite PowerShell-Engine mitverteilen. Nur vorhandene
Werkzeuge nutzen; keine Installation, globale Einstellung oder Reparatur.

Erhalte vorhandene Checkouts und fremde Änderungen. Git-Lesezugriffe und ein neuer
isolierter Checkout sind erlaubt. Stelle den sauberen Produktcheckout exakt am
Produktcommit her. Hole Manifest, SHA-Datei, Vertrag und vollständigen Nachweisbaum
docs/validation/lh01/platform-proof-maca/20261015-64fe627
getrennt aus dem Genehmigungscommit in eine neue externe Genehmigungsablage.
Git-Archiv/Checkout verwenden; keine Rohansichten kopieren oder EOLs normalisieren.
Nicht das historische Manifest im Produktcheckout überschreiben. Alle 65 Bindungen,
Mac-A-Rohbelege und 60 Kommandos müssen passen; Hashes niemals selbst neu binden.

Wähle eine neue externe Ergebniswurzel unter TEMP; keine Symlinks/Reparse-Pfade.
Genehmigungsablage, Produktcheckout und Ergebniswurzel getrennt halten. Die
Ergebniswurzel vor dem Driver nicht anlegen. Driver aus dem Produktcheckout:
pwsh -NoProfile -File tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1
mit -Plan zum externen Manifest, -ExpectedPlanSha256 mit obigem Hash,
-Target windows, -OutputDirectory zur neuen Ergebniswurzel und zunächst -CheckOnly.
Nur bei Ready denselben Aufruf ohne -CheckOnly ausführen. Exit2 heißt Blocked.
Nur gebundene Argumentarrays; kein eval/Invoke-Expression und keine nachgebauten
Produktkommandos. Der gesperrte Restore über die Repository-Konfiguration ist erlaubt.

Negativfälle zuerst; der Driver führt die 20 Fälle einschließlich K01 mit
Keyboard-/Remap-Farbprüfung aus. Bei unerwartetem Fehler/Timeout stoppen, keine
automatische Wiederholung oder Korrektur. Der vollständige Driver liefert wegen
S07 erwartungsgemäß Exit1: result.json muss mainStatus=Pass und den getrennten
S07-Fail/exit1 mit erfülltem Diagnosevertrag und beiden injizierten Fehlern zeigen.
Alle 19 regulären Fälle müssen Pass sein. Exit1 allein beweist keinen Erfolg.

Zusätzlich, getrennt zur Produktautomation: prüfe Rider, VS Code mit C#-Unterstützung und Microsoft Visual Studio.
Öffne ShowCommandTui400.sln beziehungsweise den Repository-Ordner, lade beide
Projekte, prüfe echte C#-Analyse (PSCmdlet/CmdletAttribute aufgelöst) und baue die
Solution. Ein CLI-Build oder „Sonstige Dateien“ ist kein IDE-Nachweis. Vorhandene
kompatible Extension-Runtime darf nur lokal/Git-ignoriert gewählt werden. Keine
Signaturprüfung/Library Validation abschalten, kein allowInvalidPaths-Bypass,
keine Neusignierung. Fehlende IDE/GUI: betroffenen IDE-Nachweis Open/Blocked
berichten; vorhandene Produktbelege nicht umdeuten. Private IDE-Zustände und
übliche IDE-Caches sind nur für den isolierten Checkout erlaubt; keine Quelländerung.

Erzeuge JSON, DE/EN-Bericht, synthetische Rohbelege und Hashes. Erfasse Hardware,
OS/WSL, PowerShell/.NET/SDK/Python, IDE/Erweiterungen, Commit/Manifest/Driver,
Fall-ID/E01/Soll/Ist/Exitcodes/Befehle und unveränderte Quellen; IDE-Ergebnisse je
Werkzeug getrennt. Keine echten Profile, Variablenwerte, Tokens oder private Daten.
Berichte lokale Artefaktpfade im Chat. Unabhängiges Review bleibt Open; Thorsten
entscheidet die Abnahme. Keine Commits, Pushes, Remote-Writes, Issuekommentare,
Schließungen, Implementierung, Serienaktivierung oder Folgefeatures. Praktische
Terminal-/Screenreaderabnahme Deferred, Braillehardware Excluded mangels Gerät.
LH-01 bleibt Einzelpilot; volle LH-00-Abnahme nach LH-02/vor LH-03 getrennt.
```

## EN — Current approval and complete copyable prompt

This replaces the former PR #48 stand. Execution requires Thorsten to submit the
prompt to the named host. It does not claim target execution or acceptance. Exact
bindings and pinned sources above apply equally to the following English prompt.

```text
I commission automated LH-01 checks on Windows 11 nativ for issue #38:
https://github.com/hindermath/Show-CommandTui400/issues/38
Read this issue, parent #36 and the pinned contract. Stop on conflicting bindings;
never adopt a newer revision or rebind hashes yourself.
Product commit: 64fe627e5f0799ce1a4f7d5ec1c26ceeea936e9b
Approval commit: 0544c992d627a51a855dbfe5e8f908bec6dfe701
Manifest SHA-256: 71a56f525ed1dfa91f62a54a8018da548284dc58cdffbe695dac413d571b7194
Target: windows
Native Windows11 PowerShell, build22000+; no WSL substitute.
Require existing PS>=7.6.4 on host .NET10, a compatible .NET10 SDK/C#14 and
Python>=3.9 as python3. SMA7.6.4 is compile-only; no PSHOME reference or second
engine. No installation, global setting changes or repair.
Preserve existing work. Git reads/new isolated checkouts are allowed. Check out
exactly the product revision, clean. Obtain manifest, digest, contract and the
complete docs/validation/lh01/platform-proof-maca/20261015-64fe627 tree separately from the approval commit, using Git archive or
checkout, not copied raw views/EOL normalization. Do not overwrite the historical
manifest inside the product checkout. Verify all 65 bindings and 60 commands.
Use a new external results root under TEMP, without links/reparse paths;
keep approval, source and results separate. Do not create results before the driver.
Run pwsh -NoProfile -File tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1
from the product checkout with the external -Plan, exact -ExpectedPlanSha256 above,
-Target windows, new -OutputDirectory and -CheckOnly first. Execute the same
call without CheckOnly only after Ready. Exit2 means Blocked. Only bound argument
arrays; no shell evaluation or reconstructed product commands. Locked configured
NuGet restore is allowed.
The 20 cases run negatives first; K01 includes default/remapped text colors.
Stop unexpected failure/timeouts without retry or correction. Full-driver exit1
is expected only if result.json shows mainStatus=Pass, all 19 regular Pass cases,
and separate S07 Fail/exit1 with both injected errors and satisfied diagnostic
contract. Exit1 alone proves nothing; never claim successful total restoration.
Separately check Rider, VS Code with C# support and Microsoft Visual Studio: open the solution/folder, load both real projects,
verify C# analysis and resolved PSCmdlet/CmdletAttribute, then build the solution.
CLI-only or miscellaneous-file analysis is no IDE proof. Existing compatible
extension runtime selection may be local/ignored only. No signature/library-
validation disabling, allowInvalidPaths bypass or re-signing. Missing IDE/UI means
Open/Blocked for that IDE, not a rewritten product result. Private IDE state/caches
for this isolated checkout are allowed; no source or global changes.
Generate JSON, DE/EN report and synthetic raw/hash evidence. Record environment,
versions, IDE/extensions, exact commit/manifest/driver, cases/E01/commands/exits,
expectations/observations and unchanged sources. Separate results per IDE. Publish
no real session values, profiles, tokens or private data. Report local paths in chat;
independent review stays Open and Thorsten decides acceptance. No commits, pushes,
remote writes, issue comments/closure, implementation, series or later features.
Physical terminal/screen-reader acceptance Deferred; Braille hardware Excluded for
absent hardware. Preserve standalone LH-01 and separate full LH-00 acceptance
after LH-02/before LH-03.
```
