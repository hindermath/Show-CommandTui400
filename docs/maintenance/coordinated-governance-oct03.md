# Koordinierter Governance-Pilot / Coordinated governance pilot

Aktueller Ergänzungsnachweis / Current addendum:
[stabile Assurance-v0.1.3-Veröffentlichung / stable Assurance v0.1.3 publication](assurance-v013-stable-publication.md).

DE: Technischer Test-Nachlauf: zentrale Windows-CI in Home Baseline #322
fand einen OS-abhaengigen Namespacevergleich. PurePosixPath wertet jetzt
getrackte Manifestpfade plattformneutral aus; Backslash-/Drive-Pfade bleiben
ungueltig. Nur gemeinsamer Test, Nachweis und bestehende Statistikableitungen
aendern sich. Keine Paket-, Produkt-, Baseline- oder Evidence-Aenderung.
EN: Bounded follow-up to central #322 parses tracked manifest paths as POSIX
on every host and rejects backslash/drive paths. Only test, documentation and
existing statistics change; no product, package or assurance-evidence changes.

Datum / Date: 2026-10-03. Owner: Thorsten Hindermann.
Status: Quellen gebunden / sources bound. Delivery closeout: hand-off #19.
Documentation Impact: UpdateRequired for integration, GeneratedUpdate for statistics.

## Umfang und Quellen / Scope and sources

DE: Das bestehende 14er-Profil bleibt erhalten. Aktualisiert sind Security
0.7.0, Architecture 0.6.1 und Intake Authoring 0.3.6 / Review 0.2.4 /
Sequencing 0.2.7. Andere Pakete, Prioritaeten und globale Defaults bleiben
unveraendert. Versionen, Tag-Commits und ZIP-SHA-256 stehen im
[Quellen-Lock](coordinated-governance-source-lock.json); die Archive sind
veroeffentlichte eigenstaendige Preset-Quellen, keine Home-Baseline-Scaffolds.
EN: Retain the fourteen-preset profile, updating only these five releases.
The source lock binds immutable tags and tag-archive hashes; other packages,
priorities and global defaults remain unchanged. Source release notes explain
historical candidate README snapshots in immutable packages.

- [Central delivery #318](https://github.com/hindermath/home-baseline/pull/318)
- [Generated statistics #319](https://github.com/hindermath/home-baseline/pull/319)
- [Narrative parity follow-up #321](https://github.com/hindermath/home-baseline/pull/321)
- [Pilot hand-off #19](https://github.com/hindermath/Show-CommandTui400/issues/19)

DE: Das bereits gelieferte Wartungspaket aus #317 wird als Dateien/Registries
uebernommen, nicht neu implementiert. Keine tatsaechlichen Tool-Installationen
oder allgemeine Wartung. Fuenf identische Projekt-Guidance-Dateien und beide
Constitution-Kopien bilden dieselben Projektgrenzen ab. Generierte OpenCode-
Flaechen verwenden das deklarierte `.opencode/commands/`; alte Duplikate
unter `.opencode/command/` werden entfernt. Preset-Caches bleiben ausgeschlossen.
EN: Propagate the approved maintenance files, never run tool installation.
Keep five project guidance files identical and both constitutions aligned.
OpenCode uses the declared plural path; remove obsolete duplicate surfaces.
Exclude preset caches.

DE: PR #21 zeigte in Ubuntu-CI einen roten Paritaetstest: Der gemeinsame Test
war noch an den singularen OpenCode-Pfad gebunden. Er liest jetzt ausschliesslich
den versionierten Integrationsmanifest-Pfad. Fixtures erlauben genau einen
singularen oder pluralen Namespace und blockieren gemischte oder unsichere Pfade;
Dateiexistenz und kanonische Command-Inhalte bleiben vollstaendig geprueft.
EN: The Ubuntu red observation in PR #21 exposed a stale singular test path.
Parity now follows only the tracked integration manifest. Fixtures reject mixed
or unsafe namespaces; all existence and canonical-body checks remain intact.

## Technische Pruefung / Technical verification

| Pruefung / Check | Beobachteter Stand / Observed state |
| --- | --- |
| Exact fourteen-preset matrix | Bash and PowerShell passed |
| Security regulatory contract | Structural contract, six synthetic reviewed-input examples and nine negative regressions passed |
| Architecture contract | Five tests passed |
| Three Intake configuration suites | Bash/PowerShell JSON and zero-write parity passed |
| Maintenance hardening fixtures | 20 tests passed; two platform-specific skips on macOS |
| Complete maintenance regression | 89 tests passed locally; twelve environment/platform skips; native Ubuntu CI required |
| PowerShell analysis | 72 repository-owned files; no Error/Warning findings |
| Homogeneity and delivery | Final source-bound evidence follows in PR and hand-off |
| Existing Profile 2 statistics | Regenerate after source commit; no new optional measurement context |
| Product build/test/runtime | Not defined for this concept-stage project; not tested |

DE: Dies sind technische Nachweise, keine menschliche Pilot-, Produkt-,
Risiko-, Rechts-, C5-, Konformitaets- oder Zertifizierungsfreigabe.
NIST SSDF und CWE Top 25 gelten fuer diese Governance-Arbeit. Kein Produktcode;
TDD/Changed-Code-Coverage sind dafuer N/A und vor Produktcode neu zu bewerten.
Das Projekt bleibt in der Konzeptphase; Sprache, Framework, MSL-Status und
minimale PowerShell-Version bleiben offen. Kein Spec-Kit-Feature gestartet.
EN: Technical proof grants no human or legal approval. SSDF and CWE apply.
No product code changed; reevaluate TDD/coverage before product implementation.
Language/framework/MSL/minimum PowerShell version remain undecided.

## Regulatorik und Jahresreview / Regulatory scope and annual review

DE: Beispielprodukt, Entwicklungswerkzeuge und Organisation getrennt bewerten;
Jurisdiktion, Rolle, direkte/vertragliche Pflichten, Quelle, Owner, Reviewer,
Evidence und Follow-up festhalten. Ausbildungszweck und AI-SBOM N/A sind
keine pauschale Ausnahme. Unbekannt bleibt Open; bestehende Receipts,
Reviews und menschliche Entscheidungen werden nicht umgeschrieben.
EN: Separate product, tooling and organisation. Record role, jurisdiction,
duties and evidence. Education and AI-SBOM N/A are no blanket exemptions.
Unknown stays Open; preserve historical receipts and human decisions.

DE: Die sechs urspruenglichen Governance-Presets plus Assurance erhalten die
feste Jahrespruefung am 3. Oktober, naechste 2027-10-03 um 10:00 Europe/Berlin.
Anlassreviews verschieben den Termin nicht. Die Automation liest und berichtet.
A zentral/Home Runtime, B zwei benannte public Level-2-Piloten; C und D brauchen
jeweils einen neuen Auftrag. Projekt-Evidence-Wiedervorlagen bleiben getrennt.
EN: Annual review is fixed; event reviews do not reset it and automation only
reads. Further public Level-2 consumers and remaining fleet each require a
separate request. This does not reset project-evidence due dates.

## Vor einer Implementierung / Before implementation

DE: Unmittelbar vor einem gesondert beauftragten Produktlauf Intake-Review-
Frische, Serien-/Kandidatenstatus, lokale Modellrollen, benoetigte Werkzeuge
und aktuelle Delivery-Autoritaet fail-closed pruefen. Fehlende Werkzeuge
gesondert freigeben/installieren; Installation dieses Piloten ersetzt das nicht.
Auf TinyCalc oder den breiteren Rollout muss der spaetere Show-Start nicht
warten, sobald dieses Projekt selbst geprueft und geliefert ist.
EN: Recheck freshness, series/candidate, local model routing, tools and current
authority before any separately commissioned implementation. Missing tools
need separate installation authority. A ready Show project need not wait for
TinyCalc or the later fleet.

Reevaluation: source/version change, pilot finding, product scope or annual date.
