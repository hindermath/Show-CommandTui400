# LH-01: Mac B — Mac mini M4 Pro

## DE — Gebundener Prüfstand

**Stand:** ausführbarer automatisierter Prüfstand; tatsächliche Zielhostläufe und unabhängiges Ergebnisreview offen. Kein Zieltest wird durch dieses Issue als ausgeführt dargestellt.

- Produktcommit: `41ec0f34d35c9d9e187e1a101b806d7ac93f6b00`.
- Genehmigungscommit: `f050d8203da2a38b3458f5259d0d4fa36923a295`.
- Manifest-SHA-256: `96a1321757d216af9bcadf7b1af8bdba34b2133ed4956c7586512a1d1ea603b2`.
- [Gepinnter Vertrag](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-handoff.md), [Manifest](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-handoff.json), [SHA-Datei](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-handoff.sha256), [Mac-A-Nachweisbaum](https://github.com/hindermath/Show-CommandTui400/tree/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-proof-maca), [Matrix](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-matrix.md).

**Dein Ziel ist ausschließlich `macb`.** Erst ein ausdrücklicher Auftrag für diesen Host autorisiert die Ausführung. Verwende den Driver aus dem sauberen Produktcheckout, die Genehmigung aus dem oben gepinnten späteren Commit und den angegebenen ExpectedPlanSha256. Mac nutzt `/private/tmp`, Windows eine neue Wurzel unter TEMP, WSL2 `/tmp`; keine Symlink-/Reparse-Pfade. CheckOnly zuerst, dann nur bei Ready die gebundenen Kommandos ausführen. Keine Reparatur, Installation, Veröffentlichung oder Abnahme.

Verknüpfte fachliche/Prüf-Issues:

- [#2](https://github.com/hindermath/Show-CommandTui400/issues/2)
- [#36](https://github.com/hindermath/Show-CommandTui400/issues/36)
- [#37](https://github.com/hindermath/Show-CommandTui400/issues/37)
- [#38](https://github.com/hindermath/Show-CommandTui400/issues/38)
- [#39](https://github.com/hindermath/Show-CommandTui400/issues/39)


## DE — Ausführbarer Prüfvertrag

Owner: Thorsten Hindermann. Stand: 2026-10-14. Die Hand-offs [Mac B #37](https://github.com/hindermath/Show-CommandTui400/issues/37), [Windows #38](https://github.com/hindermath/Show-CommandTui400/issues/38) und [Ubuntu/WSL2 #39](https://github.com/hindermath/Show-CommandTui400/issues/39) gehören zum [Prüf-Issue #36](https://github.com/hindermath/Show-CommandTui400/issues/36).

Der exakte Produktcommit, Driver-/Dateihashes, der neue Mac-A-Produktnachweis und alle 60 Zielkommandos stehen in [platform-handoff.json](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-handoff.json). Ein SHA-256 bindet exakte Dateibytes. Ein Commit bezeichnet einen unveränderlichen Git-Stand. Das Manifest darf aus einem späteren Genehmigungscommit stammen; dadurch entsteht kein selbstreferenzieller Hash.

**Prüfstand und Durchführung sind getrennt:** Der beauftragte T053/T054-Lauf bereitet den Stand vor. Jeder Zielagent braucht weiterhin einen ausdrücklichen Auftrag für seinen Host und den veröffentlichten Manifesthash. Das Lesen eines Issues startet keine Prüfung. Fehlende Voraussetzungen ergeben `Blocked`; keine eigenmächtige Installation, Reparatur oder Änderung des Prüfstands.

Fachliche Quelle: [LH-01](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/intakes/LH-01.md). Technische Quellen: [Plan](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/specs/002-lh01-tui-foundation/plan.md) und [Tasks](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/specs/002-lh01-tui-foundation/tasks.md). Aktueller Nachweisstand: [Plattformmatrix](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/platform-matrix.md). Frühere Vorbereitung und frühere fehlende Adapter sind historische Zustände in Git und [session-terminal.md](https://github.com/hindermath/Show-CommandTui400/blob/f050d8203da2a38b3458f5259d0d4fa36923a295/docs/validation/lh01/session-terminal.md).

## DE — Host und Voraussetzungen

| Ziel | Erforderlicher Host | Aussagegrenze |
|---|---|---|
| macb | Mac mini M4 Pro, native macOS-Sitzung | eigener Hardware-/Hostnachweis, kein Mac-A-Ersatz |
| windows | natives Windows 11, OS-Build ab 22000, PowerShell | ConPTY-Automation; keine praktische Windows-Terminal-Abnahme |
| ubuntu-wsl2 | Ubuntu 24.04, WSL2-Kernel, PowerShell unter Linux; cmd.exe/wsl.exe erreichbar | eigener WSL-/Windows-Hostnachweis, keine native Ubuntu-Desktopabnahme |

Werkzeuge müssen vorhanden sein: PowerShell mindestens 7.6.4 mit Host-.NET10, .NET10-SDK und Python3.9+ als `python3`. Tatsächlich geprüft wurde 7.6.6; 7.6.4 bleibt zusätzlich eine Modellgrenze, kein ausgeführter Mindestversionshost. Keine Werkzeuginstallation durch den Prüfagenten. Gesperrter NuGet-Restore verwendet ausschließlich die Repository-Konfiguration und deren öffentliche Quelle; nur dieser benannte Restore darf Netzwerk nutzen. Der Produktprozess selbst führt keine Netzwerk- oder Zielaktionen aus.

PTY bedeutet automatisiertes Pseudoterminal. Unix nutzt PTY/termios, Windows nutzt natives ConPTY und explizite Win32-Konsolenhandles. Der Testbootstrap erzeugt einen kontrollierten Testhost; der Produktaufruf muss dessen Prozess, Runspace und synthetischen Sitzungskontext erhalten. Der Produktcode startet dadurch keine neue Sitzung. stdin und stdout werden einzeln umgeleitet und ihre tatsächlichen Flags geprüft. Windows meldet native Modus-/Cursorwiederherstellung; Unix-Protokollbelege werden nicht auf Windows übertragen.

## DE — Vollständiger Agentenauftrag

1. Lies eigenes Issue, Eltern-Issue, diesen gepinnten Vertrag und das freigegebene Manifest. Prüfe Auftrag, Ziel und Manifest-SHA-256. Widersprüche oder fehlende Autorität: `Blocked`, Grund und konkrete nächste Aktion nennen.
2. Erhalte vorhandene Checkouts und fremde Änderungen. Stelle einen **isolierten, sauberen Checkout genau von `productCommit`** her. Kein Branchname als Ersatz. Hole die Genehmigungsunterlagen getrennt aus dem im Issue gepinnten Genehmigungscommit: Manifest und vollständigen Mac-A-Nachweisbaum. Verändere keine Produktdatei, auch nicht das dort historische Prepared-Manifest. `.gitattributes` erhält LF-Dateibytes; Hashabweichung niemals durch Neubinden beheben.
3. Lege eine neue externe Ausgabewurzel fest; keine bestehenden Nachweise ersetzen und keine Symlink-/Reparse-Pfade verwenden. Driver und alle gebundenen Ausführungsdateien stammen aus dem Produktcheckout. Genehmigung und Nachweise können außerhalb dieses Checkouts liegen.
4. Rufe zuerst den Driver mit `-CheckOnly` auf. Er prüft Manifesthash, Schema, genaue Revision, sauberen Bestand, Dateihashes, alle 20 Fälle/E01-Zuordnungen, Mac-A-Rohbelege, Host und Werkzeuge. Exit2 bedeutet fehlende Voraussetzung und erlaubt keine Produktläufe.
5. Nur nach `Ready` und mit passendem Hostauftrag denselben Driver ohne `-CheckOnly` ausführen. Keine Testkommandos aus Issue-Prosa nachbauen. Er erweitert ausschließlich die ganzen Argumenttokens `{buildRoot}`, `{caseRoot}`, `{productCommit}` zu eigenen isolierten Pfaden und dem gebundenen Commit. Keine Shellauswertung, `eval` oder `Invoke-Expression`.
6. Der feste Ablauf ist PF01 → N01–N07 → B01 → S01–S06/K01/V01/V02 → EV01 → **getrennter S07-Fehlerlauf**. Negativfälle müssen ihre genaue Abweisung/Nullwirkung zeigen. K01 bündelt Tastatur, Remapping, F3-Ausgang und Konflikt; V01 Größenrückkehr/Textzustand; V02 kleine und 1×1-Ansicht. EV01 prüft die 18 vorausgehenden regulären Fallbelege. Bei unerwartetem Fehler/Timeout stoppen; keine automatische Reparatur oder Wiederholung.
7. S07 erhält beide injizierten Fehler und bleibt `Fail/exit1`, auch wenn sein Diagnosevertrag erfüllt ist. Deshalb liefert der vollständige Driver **Exit1 mit `mainStatus=Pass` und getrenntem, erwartungsgemäßem S07-Fail**. Dies ist kein erfolgreicher Gesamt-Restore. Ein unerwartetes Fail oder ein nicht erfüllter Diagnosevertrag bleibt ein echter Blocker. Externer Prozesskill, Host- oder Stromausfall garantieren keine Wiederherstellung.
8. Erzeuge automatisch `result.json`, `report.md` DE/EN und synthetische Rohdateien/Hashes. Erfasse Host/OS/WSL, PowerShell/.NET/Python/SDK, Commit/Manifest/Entscheidung/Driver, Fälle/E01/Soll/Ist/Exitcodes/Befehle, Quellenunverändertheit und Grenzen. Nur neue externe Outputs und darin isolierte temporäre/Restore-Caches schreiben. Keine realen Profile, Variablen, Tokens oder privaten Sitzungsdaten veröffentlichen.
9. Berichte lokale Artefaktpfade im Chat. Ein anderer Prüfer prüft Vollständigkeit und Bindungen; bis dahin bleibt `review=Open`. Keine Issuekommentare, Commits, Pushes, Schließungen oder Abnahme ohne eigenen Lieferauftrag. Spätere versionierte Nachweise verwenden `platform-runs/<target>/<run-id>/`. Thorsten entscheidet die Abnahme getrennt.

```powershell
# Im sauberen Produktcheckout; Werte aus dem gepinnten Zielauftrag verwenden.
# Run in the clean product checkout using values from the pinned target order.
./tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1 `
  -Plan <externe-Genehmigung/platform-handoff.json> `
  -ExpectedPlanSha256 <freigegebener-SHA256> `
  -Target <macb|windows|ubuntu-wsl2> `
  -OutputDirectory <neue-externe-Ausgabewurzel> -CheckOnly
```

## DE — Offene Abnahmegrenzen

CI beweist ausschließlich den benannten Runner: Ubuntu24.04/azure-glibc oder Windows Server2022, niemals Mac B, Windows11 oder WSL2. Bereits vorhandene CI-Nachweise ersetzen keine Zielausführung oder anderes Ergebnisreview. Praktische Terminaloberflächen und Screenreader bleiben **Deferred** bis zu einem gesonderten Auftrag. Braillehardware bleibt **Excluded**, weil im privaten Projekt kein Gerät vorhanden ist; bei Hardware-/Scopeänderung neu bewerten. Tastatur/Textzugang bleiben Pflicht. Keine WCAG-Konformität oder vollständige LH-01-Abnahme behaupten.

LH-01 bleibt Einzelpilot außerhalb automatischer Serienauswahl. LH-00 bleibt offen; vollständige Prozessabnahme nach LH-02, vor LH-03. Keine Serienaktivierung oder LH-02–LH-07-Funktion durch diesen Prüfauftrag.


<!-- LH01_COPY_PROMPT_DE_BEGIN -->
## DE — Vollständiger Prompt zum Kopieren

Kopiere den gesamten folgenden Block in den Agenten auf dem genannten Zielsystem.
Die Vorlage erteilt erst dann Ausführungsautorität, wenn Thorsten sie dort als
Auftrag übergibt. Ihr Vorhandensein im Issue startet keine Prüfung.

```text
Ich beauftrage die automatisierten LH-01-Plattformprüfungen auf
diesem Mac B, einem Mac mini M4 Pro gemäß:
https://github.com/hindermath/Show-CommandTui400/issues/37

Lies Issue #37, Eltern-Issue #36 und den darin verlinkten Prüfvertrag.
Prüfe die tatsächliche Hardware und native macOS-Umgebung.

Verbindliche Bindungen:
Produktcommit: 41ec0f34d35c9d9e187e1a101b806d7ac93f6b00
Genehmigungscommit: f050d8203da2a38b3458f5259d0d4fa36923a295
Manifest-SHA-256: 96a1321757d216af9bcadf7b1af8bdba34b2133ed4956c7586512a1d1ea603b2
Target: macb

Erhalte vorhandene Checkouts und fremde Änderungen. Git-Lesezugriffe
und neue isolierte Checkouts sind erlaubt. Stelle den sauberen
Produktcheckout exakt am Produktcommit her. Hole Manifest und vollständigen
Mac-A-Nachweisbaum getrennt aus dem Genehmigungscommit; überschreibe
nicht das historische Manifest im Produktcheckout. Erhalte exakte
Dateibytes; Hashabweichungen niemals durch Neubinden beheben.

Prüfe vorhandene Werkzeuge: PowerShell mindestens 7.6.4 mit Host-.NET10, .NET10-SDK und Python3.9+ als python3.
Verwende eine neue externe Ausgabewurzel unter /private/tmp, ohne Symlinks.

Rufe Invoke-Lh01PlatformProof.ps1 aus dem Produktcheckout zunächst mit
-CheckOnly, dem externen Plan, dem genannten -ExpectedPlanSha256 und
-Target macb auf. Nur bei Ready führe denselben Driver ohne
-CheckOnly aus. Verwende ausschließlich die gebundenen Kommandos.
Der konfigurierte Locked-NuGet-Restore ist erlaubt.

Bei fehlenden Voraussetzungen, widersprüchlichen Bindungen oder
unerwarteten Fehlern stoppen und Grund sowie nächste Aktion berichten.
Keine Installation, Reparatur, automatische Wiederholung oder Änderung
des Prüfstands.

S07 bleibt der getrennte erwartete Fail/exit1. Unterscheide ihn von einem
unerwarteten Fehler: Alle 19 regulären Fälle müssen Pass sein und der
S07-Diagnosevertrag einschließlich beider Fehler muss erfüllt sein.
Keine erfolgreiche Gesamtwiederherstellung daraus ableiten.

Erzeuge JSON, DE/EN-Bericht und synthetische Rohbelege mit Hashes.
Berichte lokale Artefaktpfade, Ergebnisse und offene Grenzen.
Unabhängiges Review bleibt Open; keine Abnahmeentscheidung.

Keine Implementierung, Commits, Pushes, Remote-Schreibzugriffe oder
Issue-Schließungen. Praktische Terminal-/Screenreaderprüfungen bleiben
Deferred, Braillehardware Excluded. Keine Serienaktivierung oder Folgefeatures.
```
<!-- LH01_COPY_PROMPT_DE_END -->

## EN — Pinned stand and target authority

<!-- LH01_COPY_PROMPT_EN_BEGIN -->
The German section “Vollständiger Prompt zum Kopieren” contains the complete
copyable host prompt, including explicit owner authority, exact revision/hash
bindings, permitted writes, execution sequence, diagnostic failure handling and
acceptance limits. Authority applies only when Thorsten submits that prompt to
the agent on the named host; its presence in this issue alone grants no execution.
<!-- LH01_COPY_PROMPT_EN_END -->

Product commit `41ec0f34d35c9d9e187e1a101b806d7ac93f6b00`; approval commit `f050d8203da2a38b3458f5259d0d4fa36923a295`; manifest SHA-256 `96a1321757d216af9bcadf7b1af8bdba34b2133ed4956c7586512a1d1ea603b2`. The automated stand is executable, but actual target runs and distinct evidence reviews remain NotRun/Open. Your only target is `macb`. Require an explicit host execution order. Use the pinned approval tree separately from the clean product checkout, verify ExpectedPlanSha256 and run CheckOnly before execution. No installation, correction, publishing, closure or acceptance authority is implied.



Owner: Thorsten Hindermann; updated 2026-10-14. Linked issues #36–#39 define the parent and three targets. The JSON binds the immutable product commit, decisions, driver/files, fresh Mac A evidence and 60 command arrays. Approval evidence may follow the product commit in Git; no self-referential hash is needed. This prepares an executable stand, not an automatic target dispatch. Each agent still needs explicit target authority and the published manifest SHA-256.

Targets are native Mac B/Mac mini M4 Pro; native Windows11/build22000+; Ubuntu24.04/WSL2 with cmd.exe/wsl.exe available. Require existing PS7.6.4+ on host .NET10, .NET10 SDK and Python3.9+ as python3. Actual automation uses PS7.6.6; the minimum remains a separate model boundary. No installation or repair. Locked restore may use only the configured public feed and isolated caches; product execution has no network or target effects.

Read own/parent issue, pinned contract and manifest. Reject conflicts or absent authority with Blocked and a concrete next action. Preserve existing work. Use a separate clean checkout of exactly productCommit, while obtaining approval manifest and its complete Mac A proof tree from the pinned later approval commit. Never replace the historical Prepared manifest inside the product checkout. Preserve LF bytes and reject changed hashes.

Choose a new external output root without links/reparse points. Invoke the product commit's driver with Plan, ExpectedPlanSha256, explicit Target and OutputDirectory, first with CheckOnly. Exit2 is Blocked and grants no product entry. The driver validates exact revision, clean sources, schema, hashes, complete cases/E01 mapping, Mac A raw proof, actual host and tools. Only after Ready and the target request, invoke the same command without CheckOnly. Whole argument tokens buildRoot/caseRoot/productCommit are resolved to driver-owned paths and the verified commit; no shell evaluation.

The order is PF01, negatives N01–N07, locked build B01, session/lifecycle S01–S06, keyboard K01, resize/text V01, small/tiny V02, integrity EV01, then isolated diagnostic S07. K01 includes remapping, alternate exit and invalid bindings. EV01 binds the 18 preceding regular cases. Stop unexpected errors or timeouts without automatic repair or retry. S07 deliberately remains Fail/exit1 with both injected errors; the full driver consequently returns exit1, mainStatus Pass and a separate expected diagnostic Fail. Never report that as successful restoration or overall acceptance. External kill/host/power loss remains outside guaranteed restoration.

Unix uses PTY/termios; Windows uses native ConPTY with explicit console handles and independent stdin/stdout redirection. The test-only bootstrap creates a controlled host; the product must preserve that host's identity and synthetic context. No new product session is implied. Keep native Windows mode/cursor observations separate from Unix terminal protocols.

Automatically retain JSON, a DE/EN report and synthetic raw files/hashes: actual host/runtime versions, commit/manifest/decision/driver, cases/E01/commands/expected/observed/exits, clean-source checks and limits. Write only new external outputs, temporary files and isolated restore caches. Publish no private session data. Return local paths in chat; distinct review stays Open until another reviewer checks the evidence. No comments, delivery, closure or acceptance without separate authority.

CI evidence belongs only to Ubuntu24.04/azure-glibc or Windows Server2022. Actual Mac B/Windows11/WSL2 proof and independent result review remain separate. Physical terminals/screen readers are Deferred; Braille hardware Excluded because no device is available in this private project, subject to reassessment. No conformity/full acceptance claim. Preserve standalone LH-01 and full LH-00 acceptance after LH-02/before LH-03; no series or later feature starts.
