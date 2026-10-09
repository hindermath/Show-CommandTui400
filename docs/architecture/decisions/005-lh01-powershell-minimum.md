# PowerShell-Mindestversion / Minimum PowerShell

Datum / Date: 2026-10-09. Owner: Thorsten Hindermann. Status: technische Auswahl
aus bestehender Machbarkeit übernommen; Produktnachweis offen / existing bounded
feasibility choice recorded; product proof open. Kennungen / IDs: OD-01-001; F01/F02.

## DE — Entscheidung, Alternativen und Folgen

PowerShell7.6.4 als Minimum; Capability-/Versionsprüfung vor jeder Terminaländerung.

7.6.4 ist der geprüfte Container-Scope-/Modellstand; 7.6.6 ist der geprüfte synthetische Mac-UI-Host. Frühere Versionen sind nicht belegt. Sicherheits-/Wartungspatches verwenden.

Vollständige interaktive Mindestpatchprüfung auf Mac B/Windows/WSL2 offen; eine Mindestversionswahl ist kein Matrix-PASS.

## EN — Decision, alternatives and consequences

Minimum PowerShell7.6.4; check version and capabilities before terminal mutation.

7.6.4 provides container scope/model proof; 7.6.6 provides synthetic Mac UI proof. Earlier versions are unproven. Use supported maintenance/security patches.

Interactive minimum-patch coverage on Mac B/Windows/WSL2 remains open; selection is not a passing platform matrix.

## Quellen / Sources

- [Entscheidungen / Decisions](../../../specs/002-lh01-tui-foundation/feasibility/decisions.md)
- [Machbarkeit / Feasibility](../../../specs/002-lh01-tui-foundation/feasibility/README.md)
- [Native Grenzen / Native boundaries](../../../specs/002-lh01-tui-foundation/feasibility/native-dependency-assessment.md)
- [Anderes Review / Distinct review](../../../specs/002-lh01-tui-foundation/feasibility/independent-review.md)

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Owner Thorsten; Zielgruppe Implementierende und unabhängige
Prüfer. DE zuerst/EN danach, ungefähr B2; sourceOnly, kein Home-Sync. Leserpfad:
Spec/Plan → Architektur/Sicherheit → Startreview → aktuelles Intake-Review.
Neubewertung bei geändertem Scope, Paket, Treiber, Host oder Freigabe.

**UpdateRequired.** Thorsten owns these bilingual source-only records for authors
and distinct reviewers. Follow specification/plan → architecture/security → start
review → current intake review. No Home sync; reassess changed scope or baseline.
