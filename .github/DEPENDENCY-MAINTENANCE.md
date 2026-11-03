# Abhaengigkeiten pflegen / Dependency Maintenance

## Deutsch

Verbindliche Konfiguration: [Dependabot](dependabot.yml). Owner: Repository-Maintainer.
Versionsupdates werden montags ab 07:10 Uhr (Europe/Berlin) geprueft; die tatsaechliche Startzeit kann abweichen.
Minor- und Patch-Updates sind je Oekosystem gebuendelt, Major-Updates bleiben einzeln.
Je Oekosystem sind hoechstens fuenf Versions-PRs gleichzeitig offen.
Sicherheitsupdates verwenden eigene Gruppen und warten nicht auf den Wochenlauf.
Vorhandene SHA-Pins bleiben erhalten. Es wird kein Auto-Merge eingerichtet.

Kopierte Maintenance-TUI-Dateien und zentral verteilte Wartungsworkflows werden in home-baseline gepflegt. Ihre Aktualisierung erfolgt ueber den bestehenden Propagationsprozess.
Historische Specs, Archive und Evidence-Fixtures werden nicht automatisch umgeschrieben.
Aktive Produkt-, Beispiel- und Testabhaengigkeiten bleiben erfasst.
Nicht in Manifesten erfasste Downloads und Toolversionen benoetigen weiterhin ihren eigenen Wartungsprozess.

Naechster Schritt: [Dependabot-Laeufe](https://github.com/hindermath/Show-CommandTui400/actions/workflows/dependabot/dependabot-updates)
und [Sicherheitsmeldungen](https://github.com/hindermath/Show-CommandTui400/security/dependabot) pruefen.
Bei Fehlern den betroffenen Job oeffnen und Manifestpfad, Registry-Zugriff und bestehende Pins kontrollieren.
Neue PRs anhand von Changelog, CI und Projektvorgaben pruefen und regulär freigeben.
Gruene Checks sind keine Produkt-, Plattform- oder Barrierefreiheitsabnahme.

## English

Authoritative configuration: [Dependabot](dependabot.yml). Owner: repository maintainer.
Version checks run on Mondays from 07:10 (Europe/Berlin); actual start times may vary.
Minor and patch updates are grouped per ecosystem; major updates stay separate.
Each ecosystem allows at most five open version PRs.
Security updates use independent groups and do not wait for the weekly run.
Existing SHA pins remain intact. This change configures no auto-merge.

Copied Maintenance TUI files and centrally distributed maintenance workflows are maintained in home-baseline and updated through the existing propagation process.
Historical specs, archives and evidence fixtures are not rewritten automatically.
Active product, example and test dependencies remain covered.
Downloads and tool versions outside supported manifests still need their existing maintenance process.

Next, inspect [Dependabot runs](https://github.com/hindermath/Show-CommandTui400/actions/workflows/dependabot/dependabot-updates)
and [security alerts](https://github.com/hindermath/Show-CommandTui400/security/dependabot).
For failed jobs, check manifest paths, registry access and existing pins in the job log.
Review new PRs using their changelog, CI and project requirements before a regular approval.
Passing checks do not establish product, platform or accessibility acceptance.

## Abdeckung / Coverage

| Oekosystem / Ecosystem | Pfad / Path |
|---|---|
| `github-actions` | `/` |
| `nuget` | `/` |

## Dokumentationsentscheidung / Documentation Decision

UpdateRequired, 2026-11-03. Zielgruppe / audience: Maintainer und / and agents.
Leserpfad / reader path: configuration -> this guide -> Dependabot run or alert -> reviewed PR.
Quelle / source: repository-local configuration. Klasse / class: ActiveSemantic.
Sprache / language: German first, equivalent English in the same file.
Source-only; kein / no Home Sync, runtime distribution or package installation.
Nachweis / evidence: YAML round-trip, Dependabot schema and manifest coverage checks;
hosted checks are recorded on the configuration PR before merge.
Risiko / risk: update proposals still require compatibility and security review.
Neu pruefen bei / reevaluate on: new manifests, moved paths, changed pins or maintenance ownership.

## Feste PowerShell-API / Fixed PowerShell API

DE: `System.Management.Automation` ist eine private, reine Compile-Referenz auf
die verbindliche Mindest-API 7.6.4, keine ausgelieferte PowerShell-Engine.
Versionsupdates dieser Referenz bleiben ausgenommen. Eine neue API-Untergrenze
benoetigt einen eigenen Kompatibilitaetsnachweis und eine abgestimmte Aenderung
der Plattformvorgaben. Sicherheitsupdates und Alerts bleiben aktiv und werden
unter Beachtung dieser Grenze separat bewertet. Die Host-Engine wird ueber den
bestehenden Host-Wartungsweg aktualisiert. Das separate PKCS-Paket bleibt in der
normalen Versions- und Sicherheitswartung; es importiert weder API noch Runtime.
Owner: Repository-Maintainer. Neu pruefen bei geaenderter Mindest-API oder neuen
Security-Alerts. Nachweis: `assert-no-powershell-runtime.py` und LH-01-Produkttests.

EN: `System.Management.Automation` is a private compile-only reference to the
required minimum API 7.6.4, not a redistributed PowerShell engine. Version updates
for this reference are excluded. Raising the minimum API requires separate
compatibility evidence and an aligned platform-policy change. Security updates
and alerts remain enabled and require separate assessment against this boundary.
The host engine follows the existing host-maintenance process. The separate PKCS
package retains normal version and security maintenance and imports no API or
runtime. Owner: repository maintainer. Reevaluate after minimum-API changes or new
security alerts. Evidence: `assert-no-powershell-runtime.py` and LH-01 product tests.
