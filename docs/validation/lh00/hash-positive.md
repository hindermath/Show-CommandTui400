# Positive Hashprüfung / Positive hash validation

Nach T025 bestanden beide installierten Validatoren in eigener Kopie jeweils
UTF-8/LF und UTF-8-BOM/CRLF mit Exit 0. Rohhashes unterscheiden sich; BOM-Entfernung
und LF-Normalisierung erhalten denselben gebundenen Zielhash. Keine Validatorwrites.
After T025 both validators passed UTF-8/LF and BOM/CRLF in a separate copy, exit 0.
Raw bytes differ; the normalized target hash remains identical. Zero writes.

[Ausgaben und Hashes / Outputs and hashes](hash-positive-results.json).
