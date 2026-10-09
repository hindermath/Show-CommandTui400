# Framework und Treiber / Framework and driver

Datum / Date: 2026-10-09. Owner: Thorsten Hindermann. Status: technische Auswahl
aus bestehender Machbarkeit übernommen; Produktnachweis offen / existing bounded
feasibility choice recorded; product proof open. Kennungen / IDs: F01/F03/F04/F07.

## DE — Entscheidung, Alternativen und Folgen

Terminal.Gui2.5.0 mit explizitem dotnet-Treiber hinter eigenen Aktions-/Terminaladaptern.

ANSI-Fallback ausgeschlossen: sein termios-Aufbau ist auf macOS Arm64 ABI-inkompatibel (56 statt 72 Bytes). Eigene Terminal-Lease restauriert nach GUI-Dispose; Fachaktionen bleiben frameworkfrei.

Onigwrap/TextMate inventarisiert, Highlighting nicht aktivieren. Native Quellversion/Buildherkunft vor neuer Nutzung klären; Paketwechsel erneut reviewen.

## EN — Decision, alternatives and consequences

Terminal.Gui2.5.0 with explicit dotnet driver behind domain and terminal adapters.

Exclude ANSI fallback: its termios layout is incompatible on macOS Arm64 (56 versus 72 bytes). An owned lease restores after GUI disposal; domain actions stay framework-independent.

Inventory Onigwrap/TextMate without enabling highlighting. Establish native source/build provenance before use; review package changes.

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
