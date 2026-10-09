# LH-01 Plattform-Hand-offs / Platform hand-offs

## DE — Zweck, Stand und Autorität

Owner: Thorsten Hindermann. Datum: 2026-10-09. Vorbereitung, keine ausgeführten
Plattformtests. Kanonische maschinenlesbare Auftragsdaten:
[platform-handoff.json](platform-handoff.json). Fachliche Quelle bleibt
[LH-01](../../../intakes/LH-01.md); technische Grundlage sind
[Plan und Tasks](../../../specs/002-lh01-tui-foundation/tasks.md) und die
[Owner-Prüfgrenzen](../../../specs/002-lh01-tui-foundation/feasibility/owner-validation-boundaries.md).

Ein Hand-off ist ein übertragbarer Prüfauftrag. Ein Prüfdriver führt dieselben
vereinbarten Fälle auf dem benannten Host aus. Eine Prüfsumme (SHA-256) bindet
exakte Dateibytes. Ein Commit ist ein unveränderlicher Git-Stand, kein Branchname.
Ein PTY ist ein automatisiertes Pseudoterminal, keine reale Terminaloberfläche.

**Aktuell Prepared, nicht ausführbar:** Produktcommit, Driverhash, Kommandofreigabe
und Mac-A-Produktnachweis fehlen. Das vorhandene Feasibility-Fixture darf diese
Voraussetzungen nicht ersetzen. Das Öffnen eines Issues startet nichts; der
Agent benötigt einen ausdrücklichen Auftrag für den benannten Host und Umfang.
Dieses Vorbereitungspaket autorisiert keine Plattformprüfung oder Installation.

## DE — Ziele, Stufen und Grenzen

| Ziel-ID | Erwartete Umgebung | Getrennte Aussage |
|---|---|---|
| macb | Mac B, Mac mini M4 Pro, native macOS-Sitzung | eigener Hardware-/Hostnachweis, nicht Mac A |
| windows | Windows 11, native PowerShell, Windows Terminal bei späterer Oberflächenprüfung | kein Linux-/WSL2-Nachweis |
| ubuntu-wsl2 | Ubuntu 24.04 in WSL2, PowerShell unter Linux | WSL2/Ubuntu und Windows-Hostversion erfassen; keine native Ubuntu-Desktopabnahme |

Stufe A: Nach geliefertem Mac-A-Produktinkrement automatisierte Build-, Vertrags-
und Sitzungs-/PTY-Prüfungen. Nur freigegebene, auf diesem Ziel tatsächlich ausführbare
Fälle zählen; CI belegt ausschließlich ihre Runnerumgebung. Stufe B: Reale
Terminaloberflächen erst mit eigenem Auftrag und stabilisiertem LH-01-Bedienumfang.
Screenreader bleiben Deferred; Braillehardware ist Excluded, weil der Owner im
privaten persönlichen Projekt keine Braillezeile besitzt. Text-/Tastaturdesign
bleibt Pflicht; keine WCAG- oder Hilfsmittel-Konformität behaupten.

LH-01-Produktprüfung ist getrennt von der vollständigen LH-00-Prozessabnahme nach
LH-02, vor LH-03. Dieser Vertrag aktiviert keine Serie und beauftragt keine
LH-02–LH-07-Funktion. Ein technisches PASS ist keine Ownerabnahme.

## DE — Freigabe des späteren ausführbaren Prüfstands

T029/T053/T054 erstellen den gemeinsamen Driver und die plattformspezifischen
Harnesses in einem späteren Implementierungsauftrag. Danach darf ein ausdrücklich
beauftragter Koordinator das Manifest auf einen gelieferten Stand konkretisieren:

- Vollständigen 40-stelligen Produktcommit eintragen; Driver/Harness, Build-/
  Testprojekte und ihre Lockfiles müssen in diesem Commit vorhanden sein.
- Aktuellen Entscheidungshash und tatsächlichen Mac-A-Produktnachweis binden.
  Der Feasibility-Nachweis ist kein Mac-A-Produktnachweis.
- Driverhash aus den Commitbytes berechnen. Kommandos als erlaubte Executable-/
  Argumentarrays mit Arbeitsverzeichnis, Fall-ID und erwarteter Exitcode-/
  Ergebnisbedingung festlegen. Kein shell-String, Invoke-Expression oder Eval.
- Gültige Freigabe mit Owner, Datum und getrenntem Auftrag verlinken; erst dann
  `state=Executable` und `executionAuthorized=true`. Dies sind interne
  Prüfauftragsfelder, keine Änderung von Receipt- oder Serienstatusmodellen.
- Teilinkrement: Nicht vorhandene spätere Fälle dürfen nur durch den Koordinator
  ausdrücklich `enabled=false` mit Grund/Owner/Trigger werden. Der Agent darf
  den Fallumfang nicht selbst verkleinern. Ein Teil-PASS ist kein Gesamt-PASS.

Das Manifest kann nach dem Produktcommit in einem eigenen Governancecommit
versioniert sein. Auftrag und Manifesthash müssen diesen konkreten Prüfplan binden;
Produktdateien und Driver werden trotzdem aus exakt `productCommit` geprüft.
Keine Forderung nach einem selbstreferenziellen Commit-/Manifesthash.

## DE — Einheitlicher Agentenablauf

1. **Auftrag lesen:** Eigenes Issue, Eltern-Issue und versionierten Vertrag lesen.
   Nur festgelegten Zielhost und Prüfplan verwenden. Widersprüche zwischen Issue,
   Manifest oder Auftrag führen zu Blocked, nicht zu freier Auslegung.
2. **Preflight:** Manifeststatus/Freigabe, Produktcommit, Plan-/Entscheidungs-/
   Driverhash und Mac-A-Nachweis prüfen. Tatsächliche Hardware, OS, Host, Terminal,
   PowerShell, .NET und gegebenenfalls WSL/Distroversionen erfassen. Fehlende
   Werkzeuge, falscher Host oder nicht unterstützter Treiber führen zu Blocked.
3. **Isolation:** Vorhandenen Checkout und fremde Änderungen erhalten. Einen
   isolierten Arbeitsbestand aus dem Produktcommit verwenden; Manifest aus dem
   gebundenen Prüfplan übernehmen und dessen Hash erhalten. Product tree bleibt
   unverändert. Build-/Testoutputs nur außerhalb des Quellbestands zulassen.
4. **Ausführen:** Prüfdriver mit Ziel-ID aufrufen. Er prüft Manifest und Umgebung
   selbst, führt freigegebene Negativfälle zuerst aus und überprüft deren erwartete
   Abweisung samt Nullwirkung. Erst dann Build/Verträge und positive Sitzungsfälle.
   Erwartete Negativ-Exitcodes sind erfolgreich, wenn genau die Sollbedingung erfüllt
   ist; ein allgemeines Exit0 reicht nicht als PASS.
5. **Fehler:** Bei Sicherheits-/Terminalzustandsverlust oder Timeout sicher
   abbrechen, Restore versuchen und FAIL mit Rohdaten melden; keine weiteren
   positiven Läufe. Externe Host-/Prozesskillgrenzen ehrlich benennen. Keine
   Ergebnisüberschreibung, automatische Reparatur oder eigenmächtige Wiederholung.
6. **Nachweis:** Ergebnisdatei und DE/EN-Bericht automatisch erzeugen, kontrollierte
   synthetische Rohdaten beilegen, vollständigen Fallbestand prüfen und Hashes
   binden. Keine realen Variablen, Profile, Tokens oder absolute Privatpfade kopieren.
7. **Review und Rückgabe:** Ein anderer Prüfer bewertet Ergebnisbindung und
   Vollständigkeit. Ohne separat beauftragten Prüfer bleibt Review Open. Agent
   berichtet lokale Artefaktpfade im Chat; kein Issuekommentar, Commit, Push oder
   Schließen ohne passenden Auftrag. Owner nimmt später ausdrücklich ab.

## DE — Geplante Driverschnittstelle, noch nicht vorhanden

`tests/feasibility/lh01/Invoke-Lh01PlatformProof.ps1` soll folgende Parameter
anbieten: `-Plan`, `-Target` (macb/windows/ubuntu-wsl2), `-OutputDirectory` und
`-CheckOnly`. CheckOnly führt keinerlei Produkt- oder Terminaltest aus; es meldet
Startfähigkeit und Blocker. Normalmodus benötigt freigegebenes Executable-Manifest
und einen passenden Ausführungsauftrag. Default ist keine implizite Hostauswahl.
Driver kann geplante Harnesses mit Argumentarrays aufrufen; keine Produktparameter
oder Testmodi in `Show-CommandTui400` exportieren.

Driver-Exitcodes: 0 = alle aktivierten Fälle erfüllt, 1 = tatsächlicher Prüffehler,
2 = fehlende/ungültige Voraussetzung (Blocked). Das Ergebnis unterscheidet
`Pass`, `Fail`, `Blocked` und `NotRun` je Fall; eine nicht ausgeführte Pflichtprüfung
verhindert Gesamt-Pass. Der Reporter zeigt Scope, deaktivierte und praktische
Deferred/Excluded-Fälle zusätzlich, statt sie als PASS zu zählen.

**Jetzt keinen Beispielaufruf ausführen:** Der Pfad bezeichnet einen geplanten
Testdriver, keine vorhandene Datei. Fehlt Driver oder Stand, ist die korrekte
Agentenantwort Blocked mit konkreter nächster Aktion.

## DE — Schreibumfang, Ergebnis und Wiederholung

Nur die beauftragte isolierte Ausgabewurzel darf geschrieben werden. Für spätere
lieferbare Evidence gilt `docs/validation/lh01/platform-runs/<target>/<run-id>/`;
vorher lokal außerhalb des Produktbestands sammeln. Run-ID ist UUID, Ziel eine
bekannte ID; nie freie Issuewerte als Pfad auswerten. Bestehende Läufe nicht ersetzen.
Resultat: `result.json`, `report.md`, bereinigte Rohoutputs und SHA-256-Inventar.

Ergebnisfelder: Ziel/Run-ID/UTC-Zeit, Produktcommit, Manifest-/Entscheidungs-/
Driverhash, tatsächliche Versions-/Hostdaten, zugelassener Schreibumfang,
Case-ID/Soll/Ist/Exitcode/Ergebnis/Dauer/Outputhash, Gesamtstatus, Blocker und
nächste Aktion. Auch Vorher-/Nachher-Quellstatus und unbeabsichtigte Schreib-/
Netz-/Zielwirkungen erfassen. Dauer ist eine Messung, keine erfundene Abnahmeschwelle.
Bei nicht unterstütztem Terminal-Testadapter Blocked statt Modelltest als Ersatz.

Buildrestore: nur freigegebene öffentliche Registry und gesperrte Abhängigkeiten;
Netzwerk nur für diesen benannten Restore, keine Installationen oder Produkt-
Netzabfragen. Vorhandene Offline-Caches nutzen, wenn sie vollständig/gebunden sind.
Wird zusätzliche Berechtigung/Software gebraucht, stoppen und konkrete Aktion nennen.

Korrekturen erfolgen zentral unter gesondertem Auftrag. Neue Manifest-/Commit-
Freigabe führt zu neuem Laufverzeichnis. Betroffene Fälle und gemeinsame
Sicherheits-/Restorefälle erneut prüfen; volle Abdeckung nur bei vollständigem
aktiviertem Fallbestand. Keine Ergebnisse verschiedener Commits zu einem
unqualifizierten Gesamt-PASS zusammenführen.

## EN — Agent contract

Owner: Thorsten Hindermann; prepared on 2026-10-09. The linked JSON is the canonical
machine-readable hand-off. A hand-off transfers a test instruction; a driver runs
its approved cases. SHA-256 binds bytes, a commit fixes Git content, and a PTY is
an automated pseudo-terminal rather than a physical terminal application.

**Prepared, not executable:** Product commit, driver hash, command approval and
Mac A product evidence are absent. Existing feasibility evidence does not replace
them. Reading an issue grants no execution authority. Require an explicit request
for the target host and scope; no installation or platform test starts now.

Targets are Mac B/Mac mini M4 Pro on native macOS, native Windows 11 PowerShell,
and Ubuntu24.04 PowerShell inside WSL2. Record actual hardware/host/OS/runtime and
WSL/distro versions. Windows and WSL proofs are independent; neither PTY, container
nor CI results prove actual terminal or assistive acceptance.

Phase A runs approved automated build, contract and session cases after delivered
Mac A product evidence. Phase B requires separate actual-terminal authority and
stable UI behavior. Screen readers remain Deferred; Braille hardware proof is
Excluded because the owner has no display in this personal project. Keyboard/text
access remains required. No WCAG conformity, full LH-01 or LH-00 acceptance,
series activation or later-feature authority follows from this preparation.

The future coordinator binds a full product commit, decision hash, actual Mac A
product proof and driver bytes; all relevant harness/project/lock files must exist
at that product commit. Approved commands use executable/argument arrays, working
directory, case ID and expected exit/result conditions, never eval/shell strings.
A separately authorized plan may be versioned after the product commit: bind its
manifest hash without a self-referential commit hash. Only explicit owner authority
permits Executable state. For partial increments, the coordinator alone can disable
later cases with reason/owner/trigger; the agent must not shrink scope.

Agent sequence: read own/parent issue and pinned contract; reject contradictions;
check authority, hashes and actual environment; use an isolated product checkout
with outputs outside source; reject absent tools/wrong host; run negative cases
before positive builds/session tests. Expected negative nonzero exits can pass only
when the exact intended rejection and zero effects are observed. Stop on unsafe
terminal/state loss or timeout, attempt restore and report Fail. Never silently
repair/retry or borrow another environment's success.

Automatically produce result.json, bilingual report.md, scrubbed synthetic raw
outputs and a hash inventory. Include target/run UUID/time, commits/hashes, actual
versions, allowed writes, per-case expectation/observation/exit/outcome/duration/
output digest and total state, blockers and next action. Verify source unchanged
and no unintended network/target effects. No private session data or local paths.
A missing test adapter is Blocked, not permission to substitute model tests.

The planned PowerShell test driver has Plan, explicit Target, OutputDirectory and
CheckOnly parameters. CheckOnly does no product/terminal testing. Exit0 means all
enabled cases fulfilled; Exit1 means actual failure; Exit2 means Blocked prerequisite.
Each case is Pass, Fail, Blocked or NotRun; mandatory unexecuted cases prevent total
Pass. Display disabled and practical Deferred/Excluded cases separately. The driver
does not exist yet; do not run its planned path now or export probe APIs in product.

Only authorized isolated output may be written; deliverable evidence uses unique
platform-runs/<target>/<run-uuid> directories. Preserve old results. Restore only
locked packages from approved public feeds, with narrowly allowed network/cache;
never install tooling or add product network behavior. Report missing authority/tools.
A different reviewer checks evidence; missing review stays Open. Local execution
grants no issue-comment/commit/push/closure authority. The owner separately accepts.
Central correction and a newly approved commit/manifest require a new evidence run;
rerun impacted and shared security/restore cases. Mixed commits never imply full Pass.

## Issue-Verknüpfung / Issue links

Die vier veröffentlichten URLs stehen in `platform-handoff.json` unter `issues`.
Sie sind Koordination, keine fachlichen Quellenupdates. / Published issue URLs in
the JSON coordinate work; they do not update domain intake sources.

## Verknüpfte Prüf-Issues / Linked validation issues

- [parent #36](https://github.com/hindermath/Show-CommandTui400/issues/36)
- [macb #37](https://github.com/hindermath/Show-CommandTui400/issues/37)
- [windows #38](https://github.com/hindermath/Show-CommandTui400/issues/38)
- [ubuntu-wsl2 #39](https://github.com/hindermath/Show-CommandTui400/issues/39)

Vertrag / Contract: [platform-handoff.md](https://github.com/hindermath/Show-CommandTui400/blob/main/docs/validation/lh01/platform-handoff.md).

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Zielgruppe: Owner, beauftragte Prüfagenten und unabhängige
Prüfer. Dokumentklasse: Prüfvertrag und koordinierende Issue-Anweisungen.
Kanonische technische Quelle ist dieser Vertrag mit seinem JSON, Owner Thorsten.
Leserpfad: LH-01-Issue #2 → Eltern-Issue #36 → Ziel-Hand-off → Vertrag/Startplan →
spätere gebundene Nachweise und anderes Review. Die vier veröffentlichten Issues
und versionierten Texte verweisen gegenseitig aufeinander; bestehende fachliche
Issues bleiben unverändert. DE zuerst/EN danach in derselben Datei, ungefähr B2.
Distribution sourceOnly; kein Home-Sync. Evidence sind die vorbereiteten Texte,
Hashbindungen und das unabhängige technische Review, keine ausgeführten
Plattformbeispiele. Bei Änderung von Umfang, Prüfstand, Driver, Freigabe oder
Plattformgrenzen erneut bewerten. Die bestehende Feature-Entscheidung
UpdateRequired bleibt erhalten.

**UpdateRequired.** Audience: owner, commissioned proof agents and distinct
reviewers. These are a proof contract and coordinating issue instructions. This
contract and its JSON are the canonical technical source, owned by Thorsten.
Navigate domain issue #2 → parent #36 → target hand-off → contract/start plan →
later bound evidence and distinct review. Published issues and versioned texts
link each other; existing domain issues stay unchanged. German precedes English
in each file at about B2. Distribution is sourceOnly, without Home sync. Prepared
texts, hash bindings and distinct technical review are evidence of preparation,
not executed platform examples. Reevaluate changes to scope, revision, driver,
authority or platform limits. Preserve the feature's existing UpdateRequired decision.
