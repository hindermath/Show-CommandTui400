# Sprache und Speichersicherheit / Language and memory safety

Datum / Date: 2026-10-09. Owner: Thorsten Hindermann. Status: technische Auswahl
aus bestehender Machbarkeit übernommen; Produktnachweis offen / existing bounded
feasibility choice recorded; product proof open. Kennungen / IDs: OD-01-002; F01–F07.

## DE — Entscheidung, Alternativen und Folgen

Managed C#14 im laufenden PowerShell-Prozess, ohne unsafe-Blöcke oder Pointerarithmetik.

PowerShell-Scripting erschwert den geprüften typisierten Frameworkadapter; C++ und C erhöhen eigene Speicherfehlergrenzen. Rust ist speichersicher, verlangt hier zusätzliche .NET-/PS-Interop. Der tatsächliche C#-Scope-/Lifecycle-Proof begründet diese Auswahl, nicht der Workspace.

C#-MSL schützt eigenen managed Code; OS, .NET, P/Invoke und native Pakete separat prüfen. Produktcode und vollständige Plattformbelege fehlen noch.

## EN — Decision, alternatives and consequences

Managed C#14 in the caller PowerShell process, without unsafe blocks or pointer arithmetic.

PowerShell scripting complicates the tested typed adapter; C/C++ add own memory-error exposure. Rust requires additional .NET/PowerShell interop. Actual C# scope/lifecycle feasibility supports this choice, not the workspace.

Own managed memory safety does not cover OS, runtime, P/Invoke or native packages. Product and complete platform proof remain future work.

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
