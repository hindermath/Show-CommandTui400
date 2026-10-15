# Runtime / Runtime

Datum / Date: 2026-10-09. Owner: Thorsten Hindermann. Status: technische Auswahl
aus bestehender Machbarkeit übernommen; Produktnachweis offen / existing bounded
feasibility choice recorded; product proof open. Kennungen / IDs: F02; separate Runtimeentscheidung.

## DE — Entscheidung, Alternativen und Folgen

Host-.NET10, target net10.0. Seit 2026-10-15 liefert NuGet System.Management.Automation
(SMA) 7.6.4 ausschließlich als Kompilierreferenz. Die laufende PowerShell liefert
weiterhin die Implementierung; keine Engine oder PowerShell-Laufzeitabhängigkeiten
mitverteilen. Die frühere direkte PSHOME-DLL-Referenz ist damit historisch.
[Portable Einrichtung](../../lh01/development-setup.md) und
[Prüfnachweis](../../validation/lh01/ide-portability.md) dokumentieren die Änderung.

Eine zweite Runtime/PowerShell-Sitzung würde den Sitzungsvertrag brechen. Kein eigener Host, kein separater Prozess als Produkt-Einstieg.

Mac-A-Proof .NET10.0.12; Linux-Container10.0.11. Laufzeitpatches und Binärkompatibilität bei jedem Produktprüfstand erfassen.

## EN — Decision, alternatives and consequences

Use host .NET10, target net10.0. Since 2026-10-15, NuGet SMA 7.6.4 supplies only
the compile-time API. The running PowerShell still supplies the implementation;
redistribute neither engine nor PowerShell runtime dependencies. The earlier
direct PSHOME DLL reference is historical. See the linked setup and evidence.

A second runtime/session would break the caller-session contract. No custom host or substitute entry process.

Mac proof used .NET10.0.12; Linux container10.0.11. Record actual patches and binary compatibility per product test revision.

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
