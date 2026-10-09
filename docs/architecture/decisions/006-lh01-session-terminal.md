# Sitzung und Terminal / Session and terminal

Datum / Date: 2026-10-09. Owner: Thorsten Hindermann. Status: technische Auswahl
aus bestehender Machbarkeit übernommen; Produktnachweis offen / existing bounded
feasibility choice recorded; product proof open. Kennungen / IDs: OD-01-001; FR-01-005/006/011; E01-01/04.

## DE — Entscheidung, Alternativen und Folgen

Synchrones in-process PSCmdlet in aktueller SessionState/Runspace; umgeleitete Streams sicher vor GUI-Init ablehnen.

Kein kopierter Aufruferkontext. Globale/Funktions-/Modulscopes ausdrücklich testen; private Scopes nicht allgemein zusagen. Snapshot vor Schreib-Lease, Dispose vor Restore; Primär-/Restorefehler gemeinsam erhalten.

StopProcessing im isolierten Test-Runspace ist Testaufbau. Externer Kill/Hostausfall kann Restore verhindern. Darwin-ABI nicht auf Linux/Windows kopieren; nur reproduziertes PENDIN getrennt vergleichen.

## EN — Decision, alternatives and consequences

Synchronous in-process PSCmdlet using current SessionState/runspace; reject redirected streams before UI initialization.

Do not copy caller context. Test global/function/module scopes without promising private visibility. Snapshot precedes writing lease; disposal precedes restore; retain both primary and restoration errors.

Isolated StopProcessing runspace is a test fixture. External kill/host failure may prevent restore. Never copy Darwin ABI elsewhere; only reproduced PENDIN has a separate comparison.

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
