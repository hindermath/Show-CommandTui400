# B-01 und gestufte Prozessabnahme / B-01 and staged process acceptance

Stand / Date: 2026-10-01. Owner: Thorsten Hindermann.

## Auftrag und Grenze / Authority and boundary

Der Owner hat den Plan „B-01 beheben und LH-00 gestuft abnehmen“ ausdrücklich
mit „PLEASE IMPLEMENT THIS PLAN“ beauftragt. IAD010 ergänzt IAD001–IAD009:
B-01 in den kanonischen Authoring-, Review- und Sequencing-Quellen korrigieren,
den begrenzten Pilotweg in LH-00, Governance und Reihenfolge verankern und den
gebundenen Intake mit archiviertem Vorgänger sowie neuem unabhängigen Review
aktualisieren. Dieser Auftrag erlaubt lokale Quellenänderungen und Nachweise.
Er startet keine Feature-Läufe, Releases oder Remote-Rollouts; auch Commit,
Push, zentrale Versionsänderung und Projektinstallation erfolgen hier nicht.

The owner explicitly commissioned the plan “Fix B-01 and accept LH-00 in stages”
with “PLEASE IMPLEMENT THIS PLAN”. IAD010 supplements IAD001–IAD009: fix the
canonical Authoring, Review and Sequencing sources, record the limited pilot
route in LH-00, governance and order, then update the bound intake with archived
predecessor evidence and a fresh independent review. This authorizes local source
changes and evidence. It starts no feature run, release or remote rollout;
commit, push, central version changes and project installation are also excluded.

## IAD010: Gestufte Abnahme / Staged acceptance

1. Nach Umsetzung des LH-00-Kernprozesses auf dem primären Mac ein isoliertes
   Beispiel vollständig prüfen: Erstellung, Änderung, Herkunftsnachweise,
   Review durch einen anderen Prüfer und Serienzustände. Mac A oder Mac B,
   Versionen, Befehle, Ergebnisse und Grenzen im Nachweis benennen. Der Owner
   entscheidet anhand erfolgreicher Nachweise über eine begrenzte Pilotfreigabe.
2. LH-01 und danach LH-02 dürfen als Einzelpiloten außerhalb der automatischen
   Serienauswahl stattfinden. Jeder Pilot benötigt seinen eigenen ausdrücklichen
   Auftrag, gültigen Intake und unabhängiges Review. LH-02 setzt den belegten
   fachlichen Abschluss von LH-01 voraus. Prozessprobleme und Korrekturen im
   bestehenden LH-00-Nachweis sammeln; Feature-Abnahmen bleiben getrennt.
3. Nach LH-02 und vor LH-03 den vollständigen Prozess auf Mac A, Mac B,
   Windows 11 und Ubuntu 24.04 unter WSL2 nachweisen. A11Y-Nachweise,
   Bestandsübersetzungen und angewendete zentrale Registerausrichtung abschließen.
   Alle neun AC bleiben unverändert verbindlich. Erst nach vollständiger
   Owner-Abnahme darf LH-00 mit eigener Statusautorität Completed und archiviert
   werden. LH-03 setzt außerdem weiterhin den Abschluss von LH-02 voraus.

1. After implementing the LH-00 core process, prove a complete isolated example
   on the primary Mac: creation, update, provenance, a different reviewer and
   series states. Identify Mac A or Mac B, versions, commands, results and limits.
   Successful evidence lets the owner decide on limited pilot permission.
2. LH-01, then LH-02 may run as standalone pilots outside automatic series
   selection. Each requires its own explicit request, valid intake and independent
   review. LH-02 requires evidenced domain completion of LH-01. Record process
   problems and corrections in existing LH-00 evidence; feature acceptance stays
   separate.
3. After LH-02 and before LH-03, prove the full process on Mac A, Mac B,
   Windows 11 and Ubuntu 24.04 under WSL2. Complete accessibility evidence,
   existing-document translations and applied central registry alignment. All
   nine AC remain binding. Only full owner acceptance and separate status
   authority allow LH-00 to become Completed and archived. LH-03 still also
   requires LH-02 completion.

Die Freigabe dieses Plans ist keine bereits erteilte Pilot- oder Prozessabnahme.
LH-00 bleibt offen. Die bindenden Serienkanten verlangen weiterhin abgeschlossene
Vorgänger; die Ausnahme wird manuell vor dem jeweiligen Einzelpilot geprüft,
nicht durch abgeschwächte Validatoren. Leeres Idle bleibt ausgeschlossen.

Approving this plan does not itself accept the pilot process or full process.
LH-00 remains open. Binding series edges still require completed predecessors;
check the exception manually before each standalone pilot rather than weakening
validators. Empty Idle remains excluded.

## B-01: Korrektur- und Liefergrenze / Fix and delivery boundary

Ready verlangt genau ein Eligible-Mitglied. Active erlaubt null nur bei mindestens
einem Active-Mitglied; ein Eligible bleibt zulässig, mehrere bleiben ungültig.
Completed verlangt weiterhin archivierte, tatsächlich abgeschlossene Mitglieder
und keinen Kandidaten. Ohne Kandidaten bleibt eligibleCandidate N/A. Keine neuen
Felder, Statuswerte, Schemas oder Berechtigungen. Alle vorhandenen Pfad-, Hash-,
Archiv- und Abhängigkeitsprüfungen bleiben erhalten.

Ready requires exactly one Eligible member. Active permits zero only with at
least one Active member; one Eligible remains valid and multiple remain invalid.
Completed still requires archived, genuinely completed members and no candidate.
With no candidate eligibleCandidate remains N/A. No new fields, states, schemas
or authority. Existing path, hash, archive and dependency checks remain intact.

Die drei Source-Tests prüfen beide Shells auf macOS. Bestehende CI-Matrizen
umfassen native macOS-, Linux- und Windows-Runner; ein späterer autorisierter
PR muss die geänderten Tests dort bestehen. Erst nach gesondert autorisierten
Patch-Releases: zentrale Versionsreferenzen aktualisieren, gezielt dieses
Projekt installieren und die drei installierten Kopien erneut prüfen.
Kein automatischer Flottenrollout. Bis dahin bleibt B-01 für die tatsächliche
Projekt-Serienaktivierung offen. Werkzeugtests sind keine praktische Abnahme.

The three source tests check both shells on macOS. Existing CI matrices cover
native macOS, Linux and Windows runners; a later authorized PR must pass the
changed tests there. Only after separately authorized patch releases: update
central version references, install into this project specifically and retest
all three installed copies. No automatic fleet rollout. Until then B-01 remains
open for actual project series activation. Tool tests are no practical acceptance.

## Dokumentationsauswirkung / Documentation impact

UpdateRequired; Owner Thorsten. Leserpfad: Lastenheft-Plan → LH-00 → Governance
→ technische Spezifikation, Plan und Quickstart. Diese Entscheidung bindet den
lokalen Update-Vorgang; historische Review- und Liefernachweise bleiben archiviert.
DE/EN gemeinsam, textorientiert; keine automatisch geladene Agent-Guidance.
Zentrale Regeln, fünf Guidance-Dateien und installierte Presets bleiben unverändert.
Wiedervorlage: vor Pilotfreigabe, bei Quellenänderung und spätestens 2026-10-12.

UpdateRequired; owner Thorsten. Reader path: intake order → LH-00 → governance
→ technical specification, plan and quickstart. This decision binds the local
update; historical review and delivery evidence remain archived. DE/EN together,
text first; no automatically loaded agent guidance. Central rules, the five
shared guidance files and installed presets remain unchanged. Reassess before
pilot permission, on source changes and no later than 2026-10-12.
