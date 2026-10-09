# LH-01 Architektur / Architecture

Datum / Date: 2026-10-09. Owner Thorsten. T007: geplanter Produktaufbau, kein Code.
Plattform-/A11Y-Abnahme offen. ADR002–006 sind die getrennten Entscheidungen.

## DE — Kontext und Bausteine

Nutzer → aufrufende PowerShell → Show-CommandTui400 → EntryGuard → Aktionsmodell/
ViewState → Terminaladapter → Terminal. Hilfe und Remapping sind lokale Eingaben.
Sitzungsdaten verbleiben im Prozess; kein Netzwerkdienst, keine Persistenz, kein
Zielbefehl. Fremde Anzeigetexte und Tastenbelegungen sind unvertrauenswürdige Daten.

| Baustein | Verantwortung und Grenze |
|---|---|
| PSCmdlet / CallerSessionAdapter | Aktuelle SessionState, keine Ersatzsitzung oder Modulauflösung |
| EntryGuard / KeyBindingValidator | Version, Streams, Fähigkeiten, Whitelist und erreichbare Escapeaktionen vor Init |
| ActionDescriptor / Dispatcher | Stabile fachliche Aktion plus separate Kontextprüfung; kein Targetexecutor |
| ViewState / SafeDisplayText | Lokale Werte/Fokus, rein textliche Statusanzeige, Steuerzeichen entkräften |
| TerminalLease / Renderer | Geprüfter OS-Snapshot, dotnet-Treiber, Dispose und sichere Wiederherstellung |
| Testharness / Prüfdriver | Synthetische Daten, getrennte Produkt-/Diagnoseläufe und gebundene Nachweise |

Laufzeit: Created → CapabilityCheck → Rejected oder Running → Restoring → Closed.
Rejected schreibt keine Terminalmodi. Wiederöffnung verwendet denselben Aufrufer;
Lease pro Lauf freigeben. Fehler plus Restorefehler bleiben gemeinsam erkennbar.
Deployment: Binärcmdlet mit locked Terminal.Gui-Paketen; Host-SMA/.NET nicht
mitverteilen. macOS zuerst, eigene Linux-/Windowsadapter und WSL2 separat prüfen.

Qualität: E01-01 identischer Prozess/Runspace und sichtbarer Scope; E01-02 ungültige
Aktion ohne Wirkung; E01-03 textlicher Fokus; E01-04 Restore und Fail-Grenze;
E01-05 Resize ohne Werteverlust; E01-06 Eingabeschutz; E01-07 DE/EN/Quellenbindung.
Kein erfundener Performancewert. Risiken: fremde OS-ABI, native Lieferkette, Host-
Kill, fehlende praktische Hilfsmittel. Technische Schulden: Plattformadapter und
Produktprüfdriver noch nicht implementiert. Owner Thorsten; vor passendem T018–T063
und bei Paket-/Hostwechsel erneut prüfen. Reale Terminals/Screenreader Deferred;
Braillehardware Excluded gemäß Ownergrund, keine Konformitätsbehauptung.

## EN — Views and boundaries

The caller PowerShell hosts the cmdlet, guarded action/state model and terminal
adapter. Untrusted display text/key mappings are data, never executable code.
Session state stays in process; no service, persistence, target execution or later
feature. Guard version/streams/capabilities and reachable escape keys before init.
Separate the allow-list from context validation; keep domain actions independent
of Terminal.Gui. Text state represents focus/errors without colour dependence.

Capture a platform snapshot before the writing lease. Rejected entry changes no
terminal state. Dispose precedes restore; retain primary and restoration errors.
Repeated entry keeps the caller, with one released lease per run. Ship locked
product dependencies without host SMA/runtime; verify native Mac/Linux/Windows
adapters separately. WSL2 results only prove WSL2.

E01-01–07 cover session, actions, text access, restoration, resize, security and
bilingual provenance. No arbitrary performance threshold is added. Native ABI,
supply chain and external kill are distinct risks. Platform adapters/driver remain
future debt owned by Thorsten before their tasks; review package/host changes.
Physical terminals/screen readers stay Deferred, Braille hardware Excluded; this
design claims no product, assistive or full LH-00 acceptance.

## Leserpfad / Reader path

[ADRs](decisions/002-lh01-language-msl.md) → [Sicherheitsszenarien](../security/security-quality-scenarios-lh01.md)
→ [Startreview](../validation/lh01/architecture-start-review.md).

## Dokumentationsauswirkung / Documentation impact

**UpdateRequired.** Owner Thorsten; Zielgruppe Implementierende und unabhängige
Prüfer. DE zuerst/EN danach, ungefähr B2; sourceOnly, kein Home-Sync. Leserpfad:
Spec/Plan → Architektur/Sicherheit → Startreview → aktuelles Intake-Review.
Neubewertung bei geändertem Scope, Paket, Treiber, Host oder Freigabe.

**UpdateRequired.** Thorsten owns these bilingual source-only records for authors
and distinct reviewers. Follow specification/plan → architecture/security → start
review → current intake review. No Home sync; reassess changed scope or baseline.
