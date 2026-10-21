# Normative GSDB-Änderungsauszüge / Normative GSDB change excerpts

DE: Unveränderte normative Textpassagen aus dem gelieferten Kontroll-Delta. Die vollständigen kanonischen Quellen und deren Dateihashes sind in der Zuordnung gebunden. Das öffentliche synthetische Credential-Beispiel außerhalb der geänderten Kontrollen in CL09 wird nicht als Intake-Quelldatei eingebettet; die Secret-Prüfung wird nicht abgeschwächt.

EN: Exact normative passages from the delivered control delta. The assessment binds full canonical source hashes. A public synthetic credential example outside changed CL09 controls is not embedded as an intake source file; secret validation remains strict.

## CL-01-10

- **DE:** Die OWASP Cheat Sheet Series dient als laufend gepflegte Implementierungshilfe. Proactive Controls wird als Ausgabe 2024 referenziert; Kontrollnummern dürfen nicht mit 2018 vermischt werden. Relevante Kontrollen mit Name, Ausgabe und direkter Quelle den Anforderungen und Tests zuordnen. Die Sammlung ist kein Beweis für eine sichere Implementierung.
- **EN:** Use the continuously maintained OWASP Cheat Sheet Series for implementation guidance. Reference Proactive Controls edition 2024 and do not mix its identifiers with 2018. Map relevant controls by name, edition, and direct source to requirements and tests. Using guidance does not prove implementation security.
- **Akzeptanz / Acceptance:** Verlinkte Kontrollauswahl und Tests; Quelle: https://top10proactive.owasp.org/the-top-10/ / Linked control selection and tests; same primary source.

## CL-07-02

- **DE:** Wichtige Produkte anhand ihrer Kernfunktion Anhang III Klasse I oder II zuordnen. Die Kategorienbeschreibung nach (EU) 2025/2392 und den gewählten Konformitätspfad aus Art. 32 dokumentieren. Klasse I erlaubt Modul A nur bei Erfüllung der Bedingungen aus Art. 32(2); sonst Modul B+C oder H. Klasse II benötigt einen Pfad nach Art. 32(3). Die besondere FOSS-Regel aus Art. 32(5) erlaubt für Klasse-I/II-Produkte interne Kontrolle nur bei öffentlich verfügbarer technischer Dokumentation und darf nicht auf alle Produkte übertragen werden.
- **EN:** Map important products by core functionality to Annex III Class I or II. Record the category description under (EU) 2025/2392 and the selected Article 32 conformity path. Class I allows Module A subject to Article 32(2); otherwise use Module B+C or H. Class II requires an Article 32(3) path. The special FOSS rule in Article 32(5) permits internal control for Class I/II only when technical documentation is publicly available; it is not a blanket exception.
- **Akzeptanz / Acceptance:** Klasse, Rechtsstelle, Bedingungen, Evidence und gegebenenfalls zuständige notifizierte Stelle begründet dokumentiert. / Record class, legal provision, conditions, evidence and any required notified body with rationale.

## CL-07-12

- **DE:** N/A mit Produkt/Version, Rolle, konkreter Rechtsstelle oder Definition, Begründung, Datum, Owner, Gegenprüfung, nächstem Review und gegebenenfalls Fachberatung dokumentieren. Art. 2(2)(a)/(b) betrifft MDR/IVDR und (c) Fahrzeuge nach (EU) 2019/2144, Art. 2(3) zertifizierte Luftfahrt, 2(4) Schiffsausrüstung, 2(5) delegierte Ausschlüsse, 2(6) identische Ersatzteile, 2(7) ausschließlich nationale Sicherheit/Verteidigung beziehungsweise besondere Verschlusssachen-Verarbeitung; Art. 2(8) begrenzt gesondert Auskunftspflichten bei entgegenstehenden wesentlichen Interessen der nationalen/öffentlichen Sicherheit oder Verteidigung und ist kein N/A-Ausschluss des Produkts. Nichtkommerzielle FOSS anhand Art. 2(1)/3(22) und der kommerziellen Marktbereitstellung abgrenzen; Steward-Pflichten nach Art. 24 gesondert prüfen. Die Fahrzeugausnahme (EU) 2025/1535 mit L1e-Pedal-Rückausnahme und die getrennten Bestandsprodukt-/Meldeentscheidungen nach Art. 69(2)/(3) aus CL-07-01/09 übernehmen. SaaS anhand Art. 2(1), Art. 3(1)/(2) und Erwägungsgrund 12 abgrenzen, nicht über eine erfundene SaaS-Ausnahme. NIS2, DORA und Datenschutz getrennt bewerten. Unbekannte Anwendbarkeit bleibt Open; kein stillschweigendes Weglassen.
- **EN:** Document N/A with product/version, role, exact provision or definition, rationale, date, owner, second review, next review and specialist advice where needed. Article 2(2)(a)/(b) covers MDR/IVDR and (c) vehicles under (EU) 2019/2144; Article 2(3) certified aviation, 2(4) marine equipment, 2(5) delegated exclusions, 2(6) identical spare parts, 2(7) exclusive national security/defence or specified classified-information processing; separately, Article 2(8) limits information-supply duties where disclosure would conflict with essential national/public security or defence interests; it is not a product-scope N/A exclusion. Assess non-commercial FOSS under Articles 2(1)/3(22) and commercial market availability; assess Article 24 steward duties separately. Apply the (EU) 2025/1535 vehicle exclusion with the L1e pedal exception and separate existing-product/reporting decisions under Article 69(2)/(3) from CL-07-01/09. Assess SaaS under Articles 2(1), 3(1)/(2) and recital 12 rather than an invented SaaS exemption. Assess NIS2, DORA and privacy separately. Unknown applicability remains Open; silent omission is not acceptable.
- **Akzeptanz / Acceptance:** Anwendbarkeitsbericht nach CL-01-12 mit genauem Rechtsbezug und dokumentiertem Review. / Applicability report under CL-01-12 with precise legal reference and documented review.

## CL-08-03

- **DE:** Etablierte Authentifizierung verwenden, etwa OpenID Connect oder WebAuthn. OAuth 2.0 betrifft delegierte Autorisierung und ist allein kein Anmeldeprotokoll; aktuelle Sicherheitspraktiken nach RFC 9700 anwenden. Issuer, Audience, Signatur, Ablauf und Redirect-URI prüfen, PKCE einsetzen, wo erforderlich. Protokollfassungen und Framework-Defaults vor Umsetzung verifizieren; Entwürfe nicht als fertigen Standard bezeichnen.
- **EN:** Use established authentication such as OpenID Connect or WebAuthn. OAuth 2.0 provides delegated authorization and alone is not a login protocol; apply RFC 9700 security practice. Validate issuer, audience, signature, expiry, and redirect URI, using PKCE where required. Verify protocol versions and framework defaults; do not describe drafts as final standards.
- **Akzeptanz / Acceptance:** Positive und negative Authentifizierungstests; https://www.rfc-editor.org/rfc/rfc9700.html / Positive and negative authentication tests; primary source.

## CL-08-10

- **DE:** Dateipfade mit pfadkomponentenbewusstem Vergleich innerhalb eines erlaubten Basisverzeichnisses halten; ein einfacher Zeichenketten-Präfixvergleich genügt nicht. Symlinks, Reparse Points und Rennen zwischen Prüfung und Öffnung berücksichtigen und sichere Dateioperationen verwenden. Netzwerkziele einschließlich Redirects und aufgelöster IP-Adressen auf erlaubte Ziele begrenzen; Timeouts und Größenlimits setzen.
- **EN:** Confine files with a path-component-aware check against an allowed base directory; a string-prefix check is insufficient. Account for symlinks, reparse points, and check/open races, and use safe file operations. Restrict network destinations including redirects and resolved IP addresses; set timeouts and size limits.
- **Akzeptanz / Acceptance:** Negativtests für Geschwisterpräfix, Traversal, Symlink und Redirect/SSRF. / Negative tests for sibling prefixes, traversal, symlinks, redirects, and SSRF.

## CL-08-13

- **DE:** Bei sicherheitsrelevanten Änderungen wird geprüft, ob ein
  sprachspezifisches Secure-Coding-Profil aus dem Spec-Kit-Preset
  `security-governance` ausgefüllt oder gleichwertig abgedeckt ist. Dies
  gilt besonders für Änderungen an Eingabevalidierung, Ausgabe-Codierung,
  Authentifizierung, Autorisierung, Kryptografie, Datei-I/O, Netzwerk-I/O,
  Datenbankzugriff, Logging, Dependency Handling oder Shell-/Script-Code.
  Der Status „Memory-Safe Language" ersetzt diese Prüfung nicht; er
  reduziert nur bestimmte Speicherfehler-Risiken.
- **EN:** For security-relevant changes, check whether a language-specific
  secure-coding profile from the Spec Kit `security-governance` preset has
  been completed or covered in an equivalent way. This applies especially
  to changes in input validation, output encoding, authentication,
  authorisation, cryptography, file I/O, network I/O, database access,
  logging, dependency handling, or shell/script code. "Memory-safe
  language" status does not replace this review; it only reduces certain
  memory-error risks.
- **DE:** Sprachwahl nach CISA „The Case for Memory Safe Roadmaps“ (Dezember 2023) im Sprachprofil begründen: MSL bevorzugen, Nicht-MSL-Ausnahmen mit Plattformzwang, kompensierenden Kontrollen und priorisierter Migrations-Roadmap dokumentieren. CL-08-12 prüft Tests für verbleibende unsichere Grenzen. Die Roadmap ist eine Empfehlung; MSL allein verhindert nicht alle Schwachstellen.
- **EN:** Justify language selection in the language profile using CISA “The Case for Memory Safe Roadmaps” (December 2023): prefer MSL; document non-MSL exceptions with platform constraints, compensating controls and a prioritised migration roadmap. CL-08-12 tests remaining unsafe boundaries. The roadmap is guidance; MSL alone does not prevent all vulnerabilities.
- **Akzeptanz / Acceptance:** Pull Request, Review-Dokument oder
  Spec-Kit-Artefakt verweist auf die ausgefüllten Profile für die
  betroffenen Sprachen (z. B. C/C89, C#/.NET, Rust, Go, Swift,
  Java/Kotlin, Python, TypeScript/JavaScript, SQL, Bash, PowerShell) oder
  begründet die Nichtanwendbarkeit. / Pull request, review document, or
  Spec Kit artefact links the completed profiles for affected languages
  (for example C/C89, C#/.NET, Rust, Go, Swift, Java/Kotlin, Python,
  TypeScript/JavaScript, SQL, Bash, PowerShell) or justifies
  non-applicability.
- **Referenz / Reference:** Spec-Kit `security-governance`, Template
  `secure-coding-language-rules-template`.

## CL-08-12

- **DE:** Sicherheitsrelevante Pfade (Authentifizierung, Autorisierung,
  Eingabevalidierung, Ausgabe-Codierung, Krypto-Operationen, Session-
  Verwaltung, Fehlerbehandlung, File/Network-I/O) haben automatisierte
  Tests in zwei Varianten: positive Fälle (erwartetes Verhalten bei
  zulässiger Eingabe) und negative Fälle (Ablehnung bei Angriffsversuchen,
  Boundary-Werten, NULL/leeren Werten, Unicode-Edge-Cases). Test-
  Frameworks: Java JUnit 5 + Mockito + AssertJ + REST Assured; Spring
  Boot `@WebMvcTest` und `@SpringBootTest`; C#/.NET xUnit + Moq + FluentAssertions
  + WebApplicationFactory; Python pytest + pytest-mock + httpx; Go
  `testing` + testify; Node.js Jest + supertest. Security-spezifische
  Tools: OWASP ZAP für DAST in CI (`zap-baseline.py`), Burp Suite für
  manuelle Pentests, Semgrep für SAST mit OWASP Top 10 Rules
  (`semgrep --config p/owasp-top-ten`), CodeQL für GitHub-native SAST,
  SonarQube/SonarCloud, Snyk Code, Checkmarx. Coverage-Minimum für
  sicherheitskritische Module: mindestens 85 % oder besser Branch
  Coverage. Integrationstests decken mindestens 80 % oder besser der
  dokumentierten öffentlichen Schnittstellen (zum Beispiel REST APIs,
  CLI-Kommandos oder vergleichbare externe Schnittstellen) und mindestens
  80 % oder besser der dokumentierten kritischen UI-Flows ab. Jede neue
  oder geänderte öffentliche Schnittstelle hat mindestens einen positiven
  und einen negativen Integrationstest. Property-Based Testing für
  Validierung (Java `jqwik`, Python `hypothesis`, Go `testing/quick`);
  Fuzz-Testing für Parser und Eingabeverarbeitung (Go-Fuzz, libFuzzer,
  Atheris für Python, Jazzer für Java). Beispiele
  für negative Tests: SQL-Injection-Strings (`' OR 1=1--`), XSS-Payloads
  (`<script>alert(1)</script>`), Path-Traversal (`../../etc/passwd`),
  Buffer-Overflow-Strings (10 000 Zeichen), Authentifizierung mit
  ungültigem Token, Autorisierung mit fremder User-ID. Continuous Security
  Testing: GitHub Actions Workflow mit SAST + SCA + DAST + Secret Scanning
  bei jedem PR. Referenzen: OWASP Testing Guide v4.2, OWASP ASVS V12,
  NIST SP 800-53 SA-11, ISO/IEC 27001 A.8.29.
- **EN:** Security-relevant paths (authentication, authorization, input
  validation, output encoding, crypto operations, session management,
  error handling, file/network I/O) have automated tests in two variants:
  positive cases (expected behaviour on valid input) and negative cases
  (rejection on attack attempts, boundary values, NULL/empty values,
  Unicode edge cases). Test frameworks: Java JUnit 5 + Mockito +
  AssertJ + REST Assured; Spring Boot `@WebMvcTest` and `@SpringBootTest`;
  C#/.NET xUnit + Moq + FluentAssertions + WebApplicationFactory; Python
  pytest + pytest-mock + httpx; Go `testing` + testify; Node.js Jest +
  supertest. Security-specific tools: OWASP ZAP for DAST in CI
  (`zap-baseline.py`), Burp Suite for manual pentest, Semgrep for SAST
  with OWASP Top 10 rules (`semgrep --config p/owasp-top-ten`), CodeQL
  for GitHub-native SAST, SonarQube/SonarCloud, Snyk Code, Checkmarx.
  Coverage minimum for security-critical modules: at least 85 % or
  better branch coverage. Integration tests cover at least 80 % or
  better of the documented public interfaces (for example REST APIs,
  CLI commands, or comparable external interfaces) and at least 80 % or
  better of the documented critical UI flows. Every new or changed
  public interface has at least one positive and one negative integration
  test. Property-based testing for validation (Java `jqwik`, Python
  `hypothesis`, Go `testing/quick`); fuzz testing for parsers and input
  processing (Go-Fuzz, libFuzzer, Atheris for Python, Jazzer for Java).
  Examples of negative tests: SQL injection strings (`' OR 1=1--`), XSS
  payloads (`<script>alert(1)</script>`), path traversal
  (`../../etc/passwd`), buffer-overflow strings (10,000 characters),
  authentication with invalid token, authorization with foreign user ID.
  Continuous security testing: GitHub Actions workflow with SAST + SCA +
  DAST + secret scanning on every PR. References: OWASP Testing Guide
  v4.2, OWASP ASVS V12, NIST SP 800-53 SA-11, ISO/IEC 27001 A.8.29.
- **Akzeptanz / Acceptance:** Coverage-Bericht zeigt mindestens 85 %
  oder besser Branch Coverage für sicherheitskritische Module; Test-
  oder Traceability-Report zeigt mindestens 80 % oder besser Abdeckung
  der dokumentierten öffentlichen Schnittstellen und kritischen UI-Flows;
  jede neue oder geänderte öffentliche Schnittstelle hat mindestens
  einen positiven und einen negativen Integrationstest. / Coverage report
  shows at least 85 % or better branch coverage for security-critical
  modules; test or traceability report shows at least 80 % or better
  coverage of documented public interfaces and critical UI flows; every
  new or changed public interface has at least one positive and one
  negative integration test.
- **DE:** An unsicheren Sprach-/FFI-Grenzen, nativen Abhängigkeiten und Nicht-MSL-Komponenten zusätzlich risikobasiert Fuzzing und geeignete Speicher-/Undefined-Behavior-Sanitizer einsetzen, soweit die Zielplattform dies unterstützt. Andernfalls Plattformgrenze, kompensierende Tests und Restrisiko dokumentieren. Diese lokale Testregel unterstützt die Memory-Safe-Roadmap nach CL-08-13; eine MSL allein beweist keine sichere native Grenze.
- **EN:** At unsafe language/FFI boundaries, native dependencies and non-MSL components, additionally use risk-based fuzzing and suitable memory/undefined-behaviour sanitizers where the target platform supports them. Otherwise record the platform limit, compensating tests and residual risk. This local testing rule supports the memory-safe roadmap under CL-08-13; MSL alone does not prove native-boundary safety.
- **DE:** Spring Security 6 oder gleichwertig (Apache Shiro, Quarkus
  Security) korrekt konfiguriert: explizite `SecurityFilterChain`-Bean,
  `authorizeHttpRequests` mit Default-Deny, CSRF-Schutz aktiv für Web
  (`http.csrf(Customizer.withDefaults())` mit `CookieCsrfTokenRepository`).
  SQL: `Statement` durch `PreparedStatement` mit `?`-Platzhaltern ersetzt;
  JPA/Hibernate mit JPQL-Parametern (`:param`) statt String-Konkatenation;
  jOOQ als typsicheres Builder-Framework. Sichere Deserialisierung: kein
  blindes `ObjectInputStream`; `ValidatingObjectInputStream` mit Allowlist
  (`apache-commons-io`); JSON-Deserialisierung mit Jackson und
  `@JsonTypeInfo` ohne `Default Typing` (`ObjectMapper.activateDefaultTyping`
  vermeiden); SnakeYAML mit `SafeConstructor`; XML mit
  `disallow-doctype-decl=true`. Build mit Java 21 LTS; `--enable-preview`
  nur für Tests; Pattern Matching, Records und sealed Classes für sichere
  Datentypen. Statische Analyse: SpotBugs + FindSecBugs Plugin, Error
  Prone, PMD mit Security Ruleset, SonarQube. Beispiel sichere Query:
  `var stmt = conn.prepareStatement("SELECT * FROM users WHERE email = ?");
  stmt.setString(1, email);`.
- **EN:** Spring Security 6 or equivalent (Apache Shiro, Quarkus Security)
  configured correctly: explicit `SecurityFilterChain` bean,
  `authorizeHttpRequests` with default-deny, CSRF protection on for web
  (`http.csrf(Customizer.withDefaults())` with `CookieCsrfTokenRepository`).
  SQL: `Statement` replaced by `PreparedStatement` with `?` placeholders;
  JPA/Hibernate with JPQL parameters (`:param`) instead of string
  concatenation; jOOQ as type-safe builder framework. Safe deserialisation:
  no blind `ObjectInputStream`; `ValidatingObjectInputStream` with
  allowlist (`apache-commons-io`); JSON deserialisation with Jackson and
  `@JsonTypeInfo` without default typing (avoid
  `ObjectMapper.activateDefaultTyping`); SnakeYAML with `SafeConstructor`;
  XML with `disallow-doctype-decl=true`. Build with Java 21 LTS;
  `--enable-preview` only for tests; pattern matching, records, and sealed
  classes for safe data types. Static analysis: SpotBugs + FindSecBugs
  plugin, Error Prone, PMD with security ruleset, SonarQube. Example safe
  query: `var stmt = conn.prepareStatement("SELECT * FROM users WHERE
  email = ?"); stmt.setString(1, email);`.
- **DE:** Parametrisierte Datenbankzugriffe per ADO.NET
  (`SqlCommand.Parameters.AddWithValue`/`Add` mit `SqlDbType`), Dapper
  (`connection.Query<User>("SELECT ... WHERE id = @id", new { id })`),
  Entity Framework Core mit LINQ und `FromSqlInterpolated` (sicher) statt
  `FromSqlRaw` (unsicher bei String-Konkatenation). Anti-Forgery-Token in
  Web: ASP.NET Core `services.AddAntiforgery()`, `[ValidateAntiForgeryToken]`
  auf Controller-Actions, Razor `@Html.AntiForgeryToken()` in Forms,
  Header `X-XSRF-TOKEN` für SPAs. Sichere JSON-Deserialisierung mit
  `System.Text.Json` (`JsonSerializerOptions { PropertyNameCaseInsensitive
  = true, AllowTrailingCommas = false }`); bei `Newtonsoft.Json`
  `TypeNameHandling = None` setzen (CVE-2017-9785, CVE-2020-7060). XML
  mit `XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit,
  XmlResolver = null }` gegen XXE. `HttpClient` als Singleton oder per
  `IHttpClientFactory` (Socket-Erschöpfung vermeiden); Polly für
  Retry/Circuit-Breaker. `Set-StrictMode -Version Latest` in PowerShell-
  Hilfsskripten. Async/await durchgängig (kein `.Result`/`.Wait()` —
  Deadlock-Gefahr); `CancellationToken` propagieren. Nullable Reference
  Types aktivieren (`<Nullable>enable</Nullable>` in `.csproj`).
  Logging mit `ILogger<T>` und Source-Generators (kein String-Format mit
  User-Input). Build: .NET 8 LTS oder neuer; SDK-Style `.csproj` mit
  `<TreatWarningsAsErrors>true</TreatWarningsAsErrors>`; Roslyn-Analyzer
  `Microsoft.CodeAnalysis.NetAnalyzers` mit Security-Regeln (CA5xxx),
  Security Code Scan, SonarAnalyzer.
- **EN:** Parameterised database access via ADO.NET
  (`SqlCommand.Parameters.AddWithValue`/`Add` with `SqlDbType`), Dapper
  (`connection.Query<User>("SELECT ... WHERE id = @id", new { id })`),
  Entity Framework Core with LINQ and `FromSqlInterpolated` (safe) instead
  of `FromSqlRaw` (unsafe with string concatenation). Anti-forgery tokens
  in web: ASP.NET Core `services.AddAntiforgery()`,
  `[ValidateAntiForgeryToken]` on controller actions, Razor
  `@Html.AntiForgeryToken()` in forms, header `X-XSRF-TOKEN` for SPAs.
  Safe JSON deserialisation with `System.Text.Json`
  (`JsonSerializerOptions { PropertyNameCaseInsensitive = true,
  AllowTrailingCommas = false }`); with `Newtonsoft.Json` set
  `TypeNameHandling = None` (CVE-2017-9785, CVE-2020-7060). XML with
  `XmlReaderSettings { DtdProcessing = DtdProcessing.Prohibit,
  XmlResolver = null }` against XXE. `HttpClient` as singleton or via
  `IHttpClientFactory` (avoid socket exhaustion); Polly for
  retry/circuit-breaker. `Set-StrictMode -Version Latest` in PowerShell
  helper scripts. Async/await throughout (no `.Result`/`.Wait()` —
  deadlock risk); propagate `CancellationToken`. Enable nullable reference
  types (`<Nullable>enable</Nullable>` in `.csproj`). Logging with
  `ILogger<T>` and source generators (no string format with user input).
  Build: .NET 8 LTS or newer; SDK-style `.csproj` with
  `<TreatWarningsAsErrors>true</TreatWarningsAsErrors>`; Roslyn analyzer
  `Microsoft.CodeAnalysis.NetAnalyzers` with security rules (CA5xxx),
  Security Code Scan, SonarAnalyzer.
- **DE:** Bibliothek `cryptography` (PyCA, mit moderner High-Level-API
  `Fernet`, Low-Level `hazmat.primitives`) statt eigener Krypto-
  Implementierung oder veralteter `pycrypto`-Fork. Sichere Parser:
  `defusedxml` für XML (verhindert XXE, Billion Laughs, External Entity
  Injection); `defusedjson` für sichere JSON-Tiefe; `ruamel.yaml` mit
  `safe_load` oder `yaml.safe_load` (kein `yaml.load` ohne Loader).
  Kein `eval`, `exec`, `compile` oder `pickle.loads` auf nicht
  vertrauenswürdigen Eingaben (RCE-Risiko); Alternativen: `ast.literal_eval`
  für Literale, JSON, msgpack, Protocol Buffers für Datenaustausch.
  `subprocess` ohne `shell=True` für nicht vertrauenswürdige Eingaben:
  `subprocess.run([cmd, arg1, arg2], capture_output=True, text=True,
  check=True)` mit Listen-Argumenten; bei Bedarf `shlex.quote(arg)`.
  HTTP-Requests mit `requests` und `verify=True` (Default), Timeout setzen
  (`timeout=10`); SSRF-Schutz mit Allowlist. Frameworks: FastAPI mit
  `pydantic` v2 für Validierung, Starlette mit
  `SecurityHeaders`-Middleware; Django mit `SecurityMiddleware`,
  `CsrfViewMiddleware`, ORM (`Model.objects.filter` statt rohem SQL).
  Type-Hints (`mypy --strict`) und `ruff` Linter mit Security-Rules
  (`bandit`-Integration). Build: Python 3.12+ (3.13 bevorzugt); virtuelle
  Umgebungen (`venv`, `uv`, `poetry`); Lock-File `requirements.txt` mit
  `pip-compile --generate-hashes` oder `uv lock`. Statische Analyse:
  bandit, semgrep, ruff, mypy, pylint mit Security-Plugin.
- **EN:** `cryptography` library (PyCA, with modern high-level API
  `Fernet`, low-level `hazmat.primitives`) instead of custom crypto
  implementation or deprecated `pycrypto` fork. Safe parsers:
  `defusedxml` for XML (prevents XXE, billion laughs, external entity
  injection); `defusedjson` for safe JSON depth; `ruamel.yaml` with
  `safe_load` or `yaml.safe_load` (no `yaml.load` without loader). No
  `eval`, `exec`, `compile`, or `pickle.loads` on untrusted inputs (RCE
  risk); alternatives: `ast.literal_eval` for literals, JSON, msgpack,
  Protocol Buffers for data exchange. `subprocess` without `shell=True`
  for untrusted inputs: `subprocess.run([cmd, arg1, arg2],
  capture_output=True, text=True, check=True)` with list arguments;
  `shlex.quote(arg)` if needed. HTTP requests with `requests` and
  `verify=True` (default), set timeout (`timeout=10`); SSRF protection
  with allowlist. Frameworks: FastAPI with `pydantic` v2 for validation,
  Starlette with `SecurityHeaders` middleware; Django with
  `SecurityMiddleware`, `CsrfViewMiddleware`, ORM (`Model.objects.filter`
  instead of raw SQL). Type hints (`mypy --strict`) and `ruff` linter with
  security rules (`bandit` integration). Build: Python 3.12+ (3.13
  preferred); virtual environments (`venv`, `uv`, `poetry`); lock file
  `requirements.txt` with `pip-compile --generate-hashes` or `uv lock`.
  Static analysis: bandit, semgrep, ruff, mypy, pylint with security
  plugin.
- **DE:** Kontextgebundene HTTP-Templates (`html/template`,
  kontextsensitives Auto-Escaping pro Output-Stelle: HTML-Body, Attribut,
  JS, URL, CSS) statt `text/template` für HTML-Output. `database/sql` mit
  Platzhaltern (`db.QueryContext(ctx, "SELECT * FROM users WHERE id = $1",
  id)`) statt `fmt.Sprintf` mit User-Input; ORM-Bibliotheken `sqlc`
  (typsicher, Code-Generator), `gorm` mit `Where("name = ?", name)` oder
  `ent` (Facebook). `crypto/rand` (CSPRNG) statt `math/rand` für
  Sicherheits-Token, Session-IDs, Salts (`b := make([]byte, 32);
  crypto/rand.Read(b)`). `math/rand/v2` (Go 1.22+) nur für nicht-
  sicherheitsrelevante Zufallswerte. Race-Detector im Test:
  `go test -race ./...` in CI Pflicht (Datenrennen-Bugs sind häufig
  Sicherheitslücken). Web-Frameworks: `net/http` mit
  `http.TimeoutHandler` und `Server.ReadTimeout`/`WriteTimeout`/`IdleTimeout`
  gegen Slowloris; `chi`, `echo`, `gin`, `fiber` mit Security-
  Middleware (CSRF, CORS, Security Headers). Kontext-Propagation
  (`context.Context`) für Cancellation und Deadlines durchgängig. Statische
  Analyse: `go vet`, `staticcheck`, `gosec` (Security-Linter mit Regeln
  G101-G505), `golangci-lint` mit `gosec`-Plugin. Build: Go 1.22 oder
  neuer; `go.sum` committen; `go mod verify` in CI; `go build -trimpath`
  (Pfade aus Binary entfernen); `-buildmode=pie` für ASLR. Verbotene
  Pakete: `unsafe` ohne dokumentierte Begründung, `os/exec` mit `Shell`-
  Wrapper, eigene HTTP-Parser.
- **EN:** Context-aware HTML templates (`html/template`, context-sensitive
  auto-escaping per output position: HTML body, attribute, JS, URL, CSS)
  instead of `text/template` for HTML output. `database/sql` with
  placeholders (`db.QueryContext(ctx, "SELECT * FROM users WHERE id = $1",
  id)`) instead of `fmt.Sprintf` with user input; ORM libraries `sqlc`
  (type-safe, code generator), `gorm` with `Where("name = ?", name)`, or
  `ent` (Facebook). `crypto/rand` (CSPRNG) instead of `math/rand` for
  security tokens, session IDs, salts (`b := make([]byte, 32);
  crypto/rand.Read(b)`). `math/rand/v2` (Go 1.22+) only for
  non-security-relevant random values. Race detector in tests:
  `go test -race ./...` mandatory in CI (data races are often security
  bugs). Web frameworks: `net/http` with `http.TimeoutHandler` and
  `Server.ReadTimeout`/`WriteTimeout`/`IdleTimeout` against slowloris;
  `chi`, `echo`, `gin`, `fiber` with security middleware (CSRF, CORS,
  security headers). Context propagation (`context.Context`) for
  cancellation and deadlines throughout. Static analysis: `go vet`,
  `staticcheck`, `gosec` (security linter with rules G101-G505),
  `golangci-lint` with `gosec` plugin. Build: Go 1.22 or newer; commit
  `go.sum`; `go mod verify` in CI; `go build -trimpath` (remove paths
  from binary); `-buildmode=pie` for ASLR. Forbidden packages: `unsafe`
  without documented justification, `os/exec` with shell wrapper, custom
  HTTP parsers.
- **DE:** Keychain-Services (`Security.framework`) für Geheimnisse mit
  passenden Accessibility-Klassen
  (`kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly` für Server-Tokens,
  `kSecAttrAccessibleWhenUnlockedThisDeviceOnly` für interaktive
  Daten); kein `UserDefaults` für Geheimnisse. `URLSession` mit
  korrekter TLS-Konfiguration: ATS (App Transport Security) aktiv lassen;
  TLS 1.3 minimum
  (`URLSessionConfiguration.tlsMinimumSupportedProtocolVersion = .TLSv13`);
  Public Key Pinning oder Certificate Pinning per
  `URLSessionDelegate.urlSession(_:didReceive:completionHandler:)` für
  kritische Endpunkte; Hostname-Validierung nicht deaktivieren. Speicher-
  sichere Initialisierungen für Strings und Daten (Swift ist standardmäßig
  speichersicher; Vorsicht bei Bridging zu C-APIs): `Data` und `String`
  statt `UnsafeMutableBufferPointer`; bei Schlüsseln/Passwörtern explizit
  zero-out nach Gebrauch (`data.resetBytes(in: 0..<data.count)`); kein
  blindes `unsafeBitCast` oder Pointer-Arithmetik. Crypto:
  `CryptoKit` (iOS 13+, macOS 10.15+) statt CommonCrypto; `SymmetricKey`,
  `ChaChaPoly.seal`, `Curve25519.Signing` für moderne Algorithmen.
  Concurrency: `async/await` und Actors statt manueller Locks; `Sendable`-
  Protokolle für Thread-Safety. Frameworks: SwiftUI mit `@AppStorage`
  (kein Secret-Speicher), Combine; Vapor für Server-Side Swift mit
  Security-Middleware. Build: Swift 5.9+ oder Swift 6 mit `Strict
  Concurrency Checking`; SwiftLint mit Security-Regeln; Xcode Static
  Analyzer; Address Sanitizer + Thread Sanitizer in Tests.
- **EN:** Keychain services (`Security.framework`) for secrets with
  appropriate accessibility classes
  (`kSecAttrAccessibleAfterFirstUnlockThisDeviceOnly` for server tokens,
  `kSecAttrAccessibleWhenUnlockedThisDeviceOnly` for interactive data);
  no `UserDefaults` for secrets. `URLSession` with correct TLS
  configuration: leave ATS (App Transport Security) on; TLS 1.3 minimum
  (`URLSessionConfiguration.tlsMinimumSupportedProtocolVersion = .TLSv13`);
  public key pinning or certificate pinning via
  `URLSessionDelegate.urlSession(_:didReceive:completionHandler:)` for
  critical endpoints; do not disable hostname validation. Memory-safe
  initialisation for strings and data (Swift is memory-safe by default;
  caution when bridging to C APIs): `Data` and `String` instead of
  `UnsafeMutableBufferPointer`; for keys/passwords explicitly zero out
  after use (`data.resetBytes(in: 0..<data.count)`); no blind
  `unsafeBitCast` or pointer arithmetic. Crypto: `CryptoKit` (iOS 13+,
  macOS 10.15+) instead of CommonCrypto; `SymmetricKey`, `ChaChaPoly.seal`,
  `Curve25519.Signing` for modern algorithms. Concurrency: `async/await`
  and actors instead of manual locks; `Sendable` protocols for thread
  safety. Frameworks: SwiftUI with `@AppStorage` (no secret store),
  Combine; Vapor for server-side Swift with security middleware. Build:
  Swift 5.9+ or Swift 6 with strict concurrency checking; SwiftLint with
  security rules; Xcode Static Analyzer; Address Sanitizer + Thread
  Sanitizer in tests.
- **DE:** Keine dynamischen SQL-Strings aus Benutzereingaben — niemals
  String-Konkatenation, `String.format`, Template-Strings (`${var}`,
  `f"..."`, `"..."+"..."`) oder ORM-Methoden, die rohen SQL durchreichen
  (`@Query(value="...", nativeQuery=true)` JPA, `cursor.execute("..." %
  user_input)` Python). Nur parametrisierte Statements (Prepared
  Statements) mit Platzhaltern (`?` JDBC, `@param` ADO.NET, `:name` JPA,
  `$1` PostgreSQL/Go, `%s` Python DB-API) oder geprüfte Stored Procedures
  mit typisierten Parametern. Identifier-Werte (Tabellennamen, Spalten-
  namen, ORDER-BY-Klauseln), die nicht parametrisiert werden können,
  ausschließlich aus Allowlist
  (`if (sortField !in setOf("name", "date")) throw IllegalArgumentException`).
  Beispiele: PostgreSQL `SELECT * FROM users WHERE email = $1` mit
  `pgx.Conn.QueryRow(ctx, sql, email)`; MySQL `SELECT * FROM users
  WHERE id = ?` mit `stmt.setInt(1, id)`; SQL Server
  `SELECT * FROM users WHERE id = @id` mit `cmd.Parameters.Add("@id",
  SqlDbType.Int).Value = id`. Stored Procedures: ein `EXECUTE
  sp_GetUser @userId = ?` mit Parameter, `WITH RECOMPILE` nur wenn
  nötig. Least-Privilege-DB-User pro Anwendung (kein `dbo`, `root`,
  `postgres` superuser); separate Read-/Write-Rollen. SQL-Injection-Test:
  Sleep-Test (`'; WAITFOR DELAY '00:00:05'--`), Boolean-Blind, Time-Based,
  UNION-Based mit `sqlmap` in Pentests. Defensive Tools: SonarQube SQL-
  Injection-Regeln, Semgrep `tainted-sql-string`, GitHub CodeQL
  `cs/sql-injection`, Checkmarx, Veracode. Referenzen: OWASP SQL
  Injection Prevention Cheat Sheet, OWASP ASVS V5.3, CWE-89.
- **EN:** No dynamic SQL strings from user input — never string
  concatenation, `String.format`, template strings (`${var}`, `f"..."`,
  `"..."+"..."`), or ORM methods that pass through raw SQL
  (`@Query(value="...", nativeQuery=true)` JPA, `cursor.execute("..." %
  user_input)` Python). Only parameterised statements (prepared
  statements) with placeholders (`?` JDBC, `@param` ADO.NET, `:name` JPA,
  `$1` PostgreSQL/Go, `%s` Python DB-API) or reviewed stored procedures
  with typed parameters. Identifier values (table names, column names,
  ORDER BY clauses) that cannot be parameterised exclusively from
  allowlist (`if (sortField !in setOf("name", "date")) throw
  IllegalArgumentException`). Examples: PostgreSQL `SELECT * FROM users
  WHERE email = $1` with `pgx.Conn.QueryRow(ctx, sql, email)`; MySQL
  `SELECT * FROM users WHERE id = ?` with `stmt.setInt(1, id)`; SQL
  Server `SELECT * FROM users WHERE id = @id` with
  `cmd.Parameters.Add("@id", SqlDbType.Int).Value = id`. Stored
  procedures: an `EXECUTE sp_GetUser @userId = ?` with parameter, `WITH
  RECOMPILE` only when needed. Least-privilege DB user per application
  (no `dbo`, `root`, `postgres` superuser); separate read/write roles.
  SQL injection test: sleep test (`'; WAITFOR DELAY '00:00:05'--`),
  boolean blind, time-based, UNION-based with `sqlmap` in pentests.
  Defensive tools: SonarQube SQL-injection rules, Semgrep
  `tainted-sql-string`, GitHub CodeQL `cs/sql-injection`, Checkmarx,
  Veracode. References: OWASP SQL Injection Prevention Cheat Sheet,
  OWASP ASVS V5.3, CWE-89.
- **DE:** Variablen immer in doppelten Anführungszeichen (`"$var"`,
  `"${var}"`, `"$@"` statt `$@` oder `$*`); kein `eval` auf nicht
  vertrauenswürdigen Eingaben (Code-Injection-Risiko); `--` als
  Optionsbegrenzer (`rm -- "$file"`, `cd -- "$dir"`) gegen Datei-Namen,
  die mit `-` beginnen; `set -euo pipefail` am Skriptstart (`-e` Exit bei
  Fehler, `-u` Fehler bei undefinierten Variablen, `-o pipefail` Exit-Code
  der gescheiterten Pipeline-Stufe). Zusätzlich `IFS=$'\n\t'` für
  vorhersehbares Word-Splitting. Verwende `[[ ... ]]` (Bash-Builtin) statt
  `[ ... ]` (POSIX) für sicherere Tests; arithmetisch `(( ... ))` statt
  `expr`. Kein Globbing auf User-Input ohne Prüfung (`set -f`/`set +f`
  oder Quoting). `mktemp` für temporäre Dateien (`mktemp -t myapp.XXXXXX`)
  statt `/tmp/$$.tmp`. Heredocs mit Quoting (`<<'EOF'`) gegen Variablen-
  Expansion. Subshells für Side-Effect-Isolation (`( cd dir && cmd )`).
  Externe Befehle: `command -v` für Existenzprüfung; vollständige Pfade
  (`/usr/bin/env`) bei Sicherheits-relevanten Skripten. Statische Analyse:
  `shellcheck` (Pflicht in CI, mindestens Severity warning); `bashate`;
  `shfmt` für Formatierung. Bash-Version: 4+ für `mapfile`, `[[ -v ]]`;
  Bash 5+ für `EPOCHSECONDS`. Beispiel sichere Argumente:
  `if [[ "$1" =~ ^[A-Za-z0-9_-]+$ ]]; then ...`. Verbotene Konstrukte:
  `cmd | sh`, `wget -O- url | bash`, `eval "$user_input"`,
  `unquoted glob *.txt` mit User-Input.
- **EN:** Always quote variables in double quotes (`"$var"`, `"${var}"`,
  `"$@"` instead of `$@` or `$*`); no `eval` on untrusted input (code
  injection risk); `--` as option terminator (`rm -- "$file"`,
  `cd -- "$dir"`) against filenames starting with `-`; `set -euo
  pipefail` at script start (`-e` exit on error, `-u` error on undefined
  variables, `-o pipefail` exit code of failed pipeline stage). Also
  `IFS=$'\n\t'` for predictable word splitting. Use `[[ ... ]]` (bash
  builtin) instead of `[ ... ]` (POSIX) for safer tests; arithmetic
  `(( ... ))` instead of `expr`. No globbing on user input without check
  (`set -f`/`set +f` or quoting). `mktemp` for temporary files
  (`mktemp -t myapp.XXXXXX`) instead of `/tmp/$$.tmp`. Heredocs with
  quoting (`<<'EOF'`) against variable expansion. Subshells for
  side-effect isolation (`( cd dir && cmd )`). External commands:
  `command -v` for existence check; full paths (`/usr/bin/env`) in
  security-relevant scripts. Static analysis: `shellcheck` (mandatory in
  CI, at least severity warning); `bashate`; `shfmt` for formatting.
  Bash version: 4+ for `mapfile`, `[[ -v ]]`; Bash 5+ for
  `EPOCHSECONDS`. Example safe arguments: `if [[ "$1" =~
  ^[A-Za-z0-9_-]+$ ]]; then ...`. Forbidden constructs: `cmd | sh`,
  `wget -O- url | bash`, `eval "$user_input"`, unquoted glob `*.txt`
  with user input.
- **DE:** `Set-StrictMode -Version Latest` und
  `$ErrorActionPreference = 'Stop'` am Skriptanfang (Erkennung
  undeklarierter Variablen, Eigenschaften und Argumentfehler;
  Fehler nicht stillschweigend ignorieren). Validierte Parameter via
  `[CmdletBinding()]`-Funktion mit Validation-Attributen:
  `[ValidateNotNullOrEmpty()]`, `[ValidateSet('Foo','Bar')]`,
  `[ValidatePattern('^[A-Za-z0-9_-]+$')]`, `[ValidateRange(1,100)]`,
  `[ValidateScript({Test-Path $_})]`. Kein `Invoke-Expression` auf nicht
  vertrauenswürdigen Eingaben (RCE-Risiko); Alternativen: Splatting
  (`& $command @parameters`), `Start-Process -ArgumentList`. PowerShell
  Execution Policy auf Servern mindestens `RemoteSigned`, idealerweise
  `AllSigned` mit Code-Signing-Zertifikat (Authenticode). PowerShell-
  Skripte mit `.psd1`-Manifest und Module-Manifest-Felder. Sichere
  Strings für Geheimnisse: `Read-Host -AsSecureString` und
  `ConvertFrom-SecureString -Key $key`; `[System.Net.NetworkCredential]`
  zur Konvertierung. Web-Anfragen: `Invoke-RestMethod` und
  `Invoke-WebRequest` mit `-UseBasicParsing`,
  `-SkipCertificateCheck` nur in Tests; TLS 1.2+ erzwingen
  (`[Net.ServicePointManager]::SecurityProtocol =
  [Net.SecurityProtocolType]::Tls12 -bor [Net.SecurityProtocolType]::Tls13`).
  PowerShell 7+ (Cross-Platform Core, nicht Windows PowerShell 5.1) für
  neue Skripte. Comment-Based Help (`<#  .SYNOPSIS ... #>`) und
  Pester-Tests (Pflicht für jede Funktion). Statische Analyse:
  `PSScriptAnalyzer` mit Security-Regeln (`Invoke-ScriptAnalyzer -Path
  . -Severity Error,Warning`); `Pester` mit Code-Coverage;
  Inject- und Constrained-Language-Mode bei sensitiven Hosts.
  Logging: `Start-Transcript`, `Write-Verbose`, `Write-Information`
  (kein `Write-Host` für strukturierte Ausgabe). Tipp: `pwsh -NoProfile`
  in CI und Subprozessen, um Profile-Side-Effects zu verhindern.
- **EN:** `Set-StrictMode -Version Latest` and
  `$ErrorActionPreference = 'Stop'` at script start (detection of
  undeclared variables, properties, and argument errors; do not silently
  ignore errors). Validated parameters via `[CmdletBinding()]` function
  with validation attributes: `[ValidateNotNullOrEmpty()]`,
  `[ValidateSet('Foo','Bar')]`,
  `[ValidatePattern('^[A-Za-z0-9_-]+$')]`, `[ValidateRange(1,100)]`,
  `[ValidateScript({Test-Path $_})]`. No `Invoke-Expression` on
  untrusted input (RCE risk); alternatives: splatting (`& $command
  @parameters`), `Start-Process -ArgumentList`. PowerShell execution
  policy on servers at least `RemoteSigned`, ideally `AllSigned` with
  code-signing certificate (Authenticode). PowerShell scripts with
  `.psd1` manifest and module manifest fields. SecureStrings for
  secrets: `Read-Host -AsSecureString` and `ConvertFrom-SecureString
  -Key $key`; `[System.Net.NetworkCredential]` for conversion. Web
  requests: `Invoke-RestMethod` and `Invoke-WebRequest` with
  `-UseBasicParsing`, `-SkipCertificateCheck` only in tests; force TLS
  1.2+ (`[Net.ServicePointManager]::SecurityProtocol =
  [Net.SecurityProtocolType]::Tls12 -bor
  [Net.SecurityProtocolType]::Tls13`). PowerShell 7+ (cross-platform
  Core, not Windows PowerShell 5.1) for new scripts. Comment-based help
  (`<#  .SYNOPSIS ... #>`) and Pester tests (mandatory for every
  function). Static analysis: `PSScriptAnalyzer` with security rules
  (`Invoke-ScriptAnalyzer -Path . -Severity Error,Warning`); `Pester`
  with code coverage; inject and constrained-language mode on sensitive
  hosts. Logging: `Start-Transcript`, `Write-Verbose`,
  `Write-Information` (no `Write-Host` for structured output). Tip:
  `pwsh -NoProfile` in CI and subprocesses to prevent profile side
  effects.
- **DE:** Bounds-Checking bei jedem Array-Zugriff und String-Operation
  (Buffer-Overflows sind die Hauptursache von Memory-Safety-CVEs in
  C/C89). Kein `gets()` (entfernt aus C11; verwende `fgets(buf, sizeof
  buf, stdin)`). Kein ungeprüftes `sprintf()` oder `strcpy()`/`strcat()`
  — Alternativen: `snprintf(buf, sizeof buf, "%s", input)`,
  `strncpy_s`/`strcat_s` (C11 Annex K, optional), `strlcpy`/`strlcat`
  (BSD), oder eigene gepuffte Wrapper mit expliziter Längenprüfung.
  Keine `scanf("%s", buf)` (immer Längenbegrenzung `scanf("%99s", buf)`).
  Integer-Overflows prüfen vor `malloc(n * size)`: `if (n > SIZE_MAX /
  size) abort();`. `free`-Pointer nach Freigabe auf `NULL` setzen
  (`free(p); p = NULL;`); kein Double-Free, kein Use-After-Free.
  CERT-C-Regeln (Top-Verstöße im Review prüfen): STR31-C (sufficient
  buffer), ARR30-C (no out-of-bounds index), INT30-C (unsigned overflow),
  MEM30-C (no use after free), MSC24-C (avoid deprecated functions).
  Statische Analyse Pflicht: `clang-tidy` mit `bugprone-*`,
  `cert-*`-Checks; `cppcheck`; PVS-Studio; Coverity Scan;
  `gcc -Wall -Wextra -Wpedantic -Werror -fanalyzer`. Sanitizer in Tests:
  Address Sanitizer (`-fsanitize=address`), Undefined Behavior Sanitizer
  (`-fsanitize=undefined`), Memory Sanitizer (`-fsanitize=memory`).
  Fuzzing mit `libFuzzer`, AFL++, Honggfuzz. Compiler-Härtung:
  `-D_FORTIFY_SOURCE=3`, `-fstack-protector-strong`, `-fPIE -pie`,
  `-Wl,-z,relro,-z,now`, `-Wl,-z,noexecstack`. Begründung CRA: C ist
  nicht MSL — Begründung in `constitution.md` halten (z. B. cc65/C89-
  Retro-Plattform). Referenzen: SEI CERT C Coding Standard, MISRA C 2023,
  CWE-787 (Out-of-bounds Write), CWE-125 (Out-of-bounds Read), CWE-416
  (Use After Free), CWE-119, ISO/IEC 9899:2018 Annex K.
- **EN:** Bounds checking on every array access and string operation
  (buffer overflows are the main cause of memory-safety CVEs in C/C89).
  No `gets()` (removed from C11; use `fgets(buf, sizeof buf, stdin)`).
  No unchecked `sprintf()` or `strcpy()`/`strcat()` — alternatives:
  `snprintf(buf, sizeof buf, "%s", input)`,
  `strncpy_s`/`strcat_s` (C11 Annex K, optional), `strlcpy`/`strlcat`
  (BSD), or custom buffered wrappers with explicit length check. No
  `scanf("%s", buf)` (always length-limit `scanf("%99s", buf)`). Check
  integer overflows before `malloc(n * size)`: `if (n > SIZE_MAX / size)
  abort();`. Set `free`-pointers to `NULL` after free (`free(p); p =
  NULL;`); no double-free, no use-after-free. CERT C rules (top
  violations to check in review): STR31-C (sufficient buffer), ARR30-C
  (no out-of-bounds index), INT30-C (unsigned overflow), MEM30-C (no use
  after free), MSC24-C (avoid deprecated functions). Mandatory static
  analysis: `clang-tidy` with `bugprone-*`, `cert-*` checks; `cppcheck`;
  PVS-Studio; Coverity Scan; `gcc -Wall -Wextra -Wpedantic -Werror
  -fanalyzer`. Sanitizers in tests: Address Sanitizer
  (`-fsanitize=address`), Undefined Behavior Sanitizer
  (`-fsanitize=undefined`), Memory Sanitizer (`-fsanitize=memory`).
  Fuzzing with `libFuzzer`, AFL++, Honggfuzz. Compiler hardening:
  `-D_FORTIFY_SOURCE=3`, `-fstack-protector-strong`, `-fPIE -pie`,
  `-Wl,-z,relro,-z,now`, `-Wl,-z,noexecstack`. CRA justification: C is
  not MSL — keep justification in `constitution.md` (e.g. cc65/C89 retro
  platform). References: SEI CERT C Coding Standard, MISRA C 2023,
  CWE-787 (Out-of-bounds Write), CWE-125 (Out-of-bounds Read), CWE-416
  (Use After Free), CWE-119, ISO/IEC 9899:2018 Annex K.

## CL-08-06

- **DE:** Aktuelle Algorithmen werden verwendet: AES-256-GCM oder
  ChaCha20-Poly1305 für symmetrische Verschlüsselung (AEAD bevorzugt);
  RSA mindestens 3072 Bit oder ECDSA P-256/P-384 oder Ed25519 für
  Signaturen; ECDH P-256 oder X25519 für Schlüsselaustausch; SHA-256, SHA-
  384, SHA-512 oder SHA-3 für Hashing; HMAC-SHA-256 für Nachrichten-
  authentifizierung. Veraltete Verfahren — MD5, SHA-1 (für Signaturen und
  Zertifikate, weiterhin OK für HMAC mit Hinweis), DES/3DES, RC4, MD2 — sind
  verboten oder mit dokumentierter Risikobegründung in `docs/security/
  crypto-exceptions.md` markiert. Konkrete Bibliotheken: Java JCA mit
  Bouncy Castle Provider (`Cipher.getInstance("AES/GCM/NoPadding")`,
  `Signature.getInstance("Ed25519", "BC")`); Tink (Google) für High-Level
  API; C#/.NET `System.Security.Cryptography` (`AesGcm`, `RSACng`,
  `ECDsaCng`, `ECDiffieHellman`); Python `cryptography` Bibliothek
  (`Fernet` für symmetrisch, `hazmat.primitives` für Low-Level); Go
  `crypto/aes`, `crypto/cipher` (`cipher.NewGCM`), `crypto/ed25519`,
  `golang.org/x/crypto/chacha20poly1305`. TLS-Konfiguration nach CL-03-07: TLS 1.3 bevorzugen, TLS 1.2 nur im dort geprüften Profil und bis zum dokumentierten Migrationshorizont; HSTS-Header
  (`Strict-Transport-Security: max-age=31536000; includeSubDomains;
  preload`), OCSP Stapling. Schlüsselverwaltung: Hardware Security Module
  (HSM) PKCS#11, Cloud-KMS (AWS KMS, Azure Key Vault, GCP Cloud KMS) oder
  HashiCorp Vault. Schlüssel-Rotation alle 90 Tage für aktive Keys.
  Referenzen: NIST SP 800-131A Rev. 2, BSI TR-02102-1, OWASP Cryptographic
  Storage Cheat Sheet, ENISA Cryptographic Guidelines.
- **EN:** Current algorithms are used: AES-256-GCM or ChaCha20-Poly1305
  for symmetric encryption (AEAD preferred); RSA at least 3072 bits or
  ECDSA P-256/P-384 or Ed25519 for signatures; ECDH P-256 or X25519 for
  key exchange; SHA-256, SHA-384, SHA-512, or SHA-3 for hashing;
  HMAC-SHA-256 for message authentication. Deprecated methods — MD5, SHA-1
  (for signatures and certificates, still OK for HMAC with caveat),
  DES/3DES, RC4, MD2 — are forbidden or flagged with documented risk
  justification in `docs/security/crypto-exceptions.md`. Concrete
  libraries: Java JCA with Bouncy Castle Provider
  (`Cipher.getInstance("AES/GCM/NoPadding")`,
  `Signature.getInstance("Ed25519", "BC")`); Tink (Google) for high-level
  API; C#/.NET `System.Security.Cryptography` (`AesGcm`, `RSACng`,
  `ECDsaCng`, `ECDiffieHellman`); Python `cryptography` library (`Fernet`
  for symmetric, `hazmat.primitives` for low-level); Go `crypto/aes`,
  `crypto/cipher` (`cipher.NewGCM`), `crypto/ed25519`,
  `golang.org/x/crypto/chacha20poly1305`. TLS configuration follows CL-03-07: prefer TLS 1.3, use TLS 1.2 only within its reviewed profile and documented migration horizon; HSTS header
  (`Strict-Transport-Security: max-age=31536000; includeSubDomains;
  preload`), OCSP Stapling. Key management: Hardware Security Module
  (HSM) PKCS#11, cloud KMS (AWS KMS, Azure Key Vault, GCP Cloud KMS), or
  HashiCorp Vault. Key rotation every 90 days for active keys. References:
  NIST SP 800-131A Rev. 2, BSI TR-02102-1, OWASP Cryptographic Storage
  Cheat Sheet, ENISA Cryptographic Guidelines.
- **DE:** Die obige generische Algorithmusauswahl und 90-Tage-Rotation sind lokale Baseline-Policy, keine pauschale BSI-Empfehlung. ChaCha20, Ed25519 und X25519 nicht als Empfehlung der TR-02102-1 ausgeben. Für BSI-Profilkonformität die konkrete Teilfassung und Parameter prüfen; für TLS gilt ausschließlich CL-03-07 mit TR-02102-2. Abweichungen mit Risiko und Owner dokumentieren.
- **EN:** The generic algorithm choices and 90-day rotation above are local baseline policy, not blanket BSI recommendations. Do not attribute ChaCha20, Ed25519 or X25519 to TR-02102-1. Assess the specific part and parameters for BSI conformity; TLS follows CL-03-07 and TR-02102-2. Record deviations with risk and owner.

## CL-08-02

- **DE:** HTML-, Attribut-, JavaScript- und URL-Ausgaben kontextgerecht codieren; Rich Content nur mit geeigneter Sanitization. Für SQL parametrisierte Statements verwenden. Für Prozesse strukturierte Argumentlisten ohne Shell-Auswertung nutzen. Allgemeines Escaping ersetzt weder Parametrisierung noch sichere APIs. Positiv-, Negativ- und Kontextwechseltests ausführen.
- **EN:** Encode HTML, attribute, JavaScript, and URL output for its context; sanitize rich content appropriately. Use parameterized SQL statements. Invoke processes with structured argument lists without shell evaluation. Generic escaping replaces neither parameterization nor safe APIs. Test valid, malicious, and cross-context input.
- **Akzeptanz / Acceptance:** Tests belegen sichere Senken; keine SQL- oder Shell-Interpolation aus untrusted Input. / Tests cover safe sinks; no untrusted SQL or shell interpolation.

## CL-09-11

- **DE:** Werkzeugkonfiguration und Telemetrie anhand der aktuellen offiziellen Dokumentation und der tatsächlichen Version prüfen. Ignore-Dateien, Kontextausschlüsse und Kontoeinstellungen wirken produktspezifisch und sind keine allgemeine Zugriffssperre. Private Kontodaten, Sitzungen und Secrets nicht in die versionierte Konfiguration aufnehmen. Nicht nachgewiesene Ausschlussmechanismen als offen behandeln.
- **EN:** Verify configuration and telemetry against current official documentation and the actual tool version. Ignore files, context exclusions, and account settings are product-specific and do not provide a universal access barrier. Keep private account data, sessions, and secrets out of tracked configuration. Treat unverified exclusion mechanisms as open.
- **Akzeptanz / Acceptance:** Versionsgebundene Konfigurationsprüfung mit Negativtest für ausgeschlossene Daten. / Version-bound configuration review with a negative test for excluded data.

## CL-09-01

- **DE:** KI-Werkzeuge werden vor Nutzung mit Betriebsart, Anbieter, Datenflüssen, Vertragslage, Telemetrie, Aufbewahrung und technischen Zugriffen bewertet und genehmigt. Produktnamen oder Tarifbezeichnungen beweisen weder Trainingsausschluss noch Zero Data Retention. Anbieterangaben und wirksame Kontoeinstellungen am Prüftag belegen; unbekannte Vertrags- oder Datenschutzeigenschaften bleiben offen.
- **EN:** Approve AI tools only after reviewing operating mode, provider, data flows, contracts, telemetry, retention, and technical access. Product or plan names prove neither training exclusion nor zero data retention. Record current provider evidence and effective account settings; unknown contract or privacy properties remain open.
- **Akzeptanz / Acceptance:** Datierter Inventareintrag mit Quelle, Owner, Scope und Ablauf. / Dated inventory with source, owner, scope, and expiry.

## CL-09-13

- **DE:** Die Audit-Spur nennt Werkzeug, Version, Scope, verantwortliche Person und relevante Entscheidungen. Aufbewahrung je Datenkategorie aus Zweck, Rechtsgrundlage, Vertragslage und Schutzbedarf ableiten; DSGVO und CRA begründen keine pauschalen Fristen von sechs beziehungsweise zehn Jahren für sämtliche Agenten- oder Plattformlogs. Zugriff begrenzen, Integrität sichern und Löschung testen.
- **EN:** Audit records identify tool, version, scope, responsible person, and relevant decisions. Derive retention per data category from purpose, legal basis, contracts, and risk; GDPR and CRA do not impose universal six- or ten-year periods for all agent or platform logs. Restrict access, protect integrity, and test deletion.
- **Akzeptanz / Acceptance:** Dokumentierter Aufbewahrungs- und Löschplan mit Quelle, Owner und Integritätstest. / Retention and deletion plan with source, owner, and integrity test.

## CL-09-05

- **DE:** Von KI vorgeschlagene Pakete vor Installation in der offiziellen Registry prüfen: Name, Maintainer, Quellrepository, veröffentlichte Version und Herkunft müssen zusammenpassen. Ähnliche Schreibweisen und unerwartete Installationsskripte prüfen. Downloads oder Paketalter allein beweisen keine Vertrauenswürdigkeit. Keine ungeprüften historischen Vorfallsbehauptungen als Begründung übernehmen.
- **EN:** Verify AI-proposed packages in the official registry before installation: name, maintainer, source repository, release, and provenance must agree. Check similar spellings and unexpected installation scripts. Download counts or package age alone do not establish trust. Do not rely on unverified historical incident claims.
- **Akzeptanz / Acceptance:** Registry- und Herkunftsnachweis sowie Dependency-/Secret-Scan nach Risiko. / Registry and provenance evidence plus risk-based dependency and secret checks.

## CL-09-16

- **DE:** Regulatorische Anwendbarkeit nach CL-01-12 fuer Produkt, KI-Werkzeugbetrieb
  und Organisation getrennt pruefen. Je Rechtsregime (KI-VO, CRA, NIS2/BSIG,
  DORA sowie Kunden-/Sektorvorgaben) Land, Rolle, Scope und Anwendungsdatum
  dokumentieren. Auch reine KI-Werkzeugnutzung kann Betreiberpflichten ausloesen,
  etwa Massnahmen zur KI-Kompetenz nach KI-VO Art. 4; das Fehlen einer
  KI-Komponente im ausgelieferten Produkt begruendet kein pauschales N/A.
  N/A nur fuer den einzeln begruendeten Rechts-/Rollenumfang; unbekannte
  Anwendbarkeit bleibt Open.
- **EN:** Assess regulatory applicability under CL-01-12 separately for the
  product, AI tool operation and organisation. For each regime (AI Act, CRA,
  NIS2/German BSIG, DORA and customer/sector rules), record jurisdiction, role,
  scope and application date. Tool-only AI use can still trigger deployer duties,
  such as measures supporting AI literacy under AI Act Article 4; absence of
  AI in the released product establishes no blanket N/A. Use N/A only for an
  individually justified legal/role scope; unknown applicability remains Open.
- **Akzeptanz / Acceptance:** Verlinktes CL-01-12-Screening mit getrennten
  Produkt-/Werkzeug-/Organisationsentscheidungen je Rechtsregime, Rolle,
  Begruendung, Quellenfassung, Evidence, Owner/Reviewer und Wiedervorlage;
  KI-Kompetenzmassnahmen soweit anwendbar nachgewiesen. / Link CL-01-12 screening
  with separate product/tool/organisation decisions per regime, role, rationale,
  source version, evidence, owner/reviewer and re-review date; evidence AI-literacy
  measures where applicable.

## CL-09-06

- **DE:** Übernommene KI-Vorschläge auf Herkunft, Lizenzhinweise und erkennbare Übernahmen prüfen. Die Länge eines Snippets ist keine allgemeine rechtliche Freigabegrenze. Unklare Rechte werden durch zuständige Personen bewertet; fremde Lizenzhinweise erhalten und Pflichten dokumentieren. Aktuelle Rechtsfragen nicht aus pauschalen Aussagen über laufende Verfahren ableiten.
- **EN:** Check adopted AI suggestions for origin, licence notices, and identifiable copying. Snippet length is not a universal legal clearance threshold. Responsible people resolve unclear rights; retain third-party notices and record obligations. Do not infer legal status from general claims about ongoing litigation.
- **Akzeptanz / Acceptance:** Nachvollziehbare Lizenzentscheidung oder Open mit Owner und nächster Maßnahme. / Traceable licence decision or Open with owner and next action.

## CL-09-12

- **DE:** Entwicklerinnen und Entwickler erhalten eine Schulung zu Stärken, Schwächen
  und Risiken von KI-Code-Assistenten. Auffrischung mindestens jährlich.
  Schulungs-Curriculum: (a) Stärken — Beschleunigung von Boilerplate,
  Test-Skelette, Doku-Generierung, Refactoring-Vorschläge,
  Sprach-/Framework-Onboarding, Code-Erklärung; (b) Schwächen —
  Halluzinationen (erfundene APIs, falsche Bibliotheksnamen, falsche
  Versions-Annahmen), veraltete Trainingsdaten (typischer Cut-off Monate
  bis Jahre vor Modell-Release), Übergeneralisierung („Standardlösung"
  passt nicht zum Kontext), tautologische Tests, unsicherer Default-
  Code (siehe Item 8 — Krypto-Anti-Patterns); (c) Risiken — Slopsquatting
  (Item 5), Lizenz-Probleme (Item 6), Prompt-Datenleck (Item 7),
  Übervertrauen (NIST AI RMF MEASURE-2.7), schwächere
  Programmier-Fertigkeiten bei Junior-Entwicklern bei Dauernutzung
  („skill atrophy", Stanford 2024), Verzerrungen aus Trainingsdaten,
  Halluzinations-Wiederholungen bei iterativen Prompts; (d) Praktiken
  — präzise Prompts mit Kontext, Context-Window-Management, manuelle
  zeilenweise Prüfung, Kreuz-Verifikation gegen offizielle Dokumentation,
  Schulungs-Übungen mit absichtlich falschen KI-Vorschlägen
  („Spot-the-Bug"-Übungen). Empfohlene Schulungsformate: 4-Stunden-
  Onboarding (mit Praxisteil zu allen Items dieser Checkliste),
  jährliche Auffrischung 2 h, Just-in-Time-Mikro-Trainings bei neuen
  Tool-Versionen oder bekannten KI-Vorfällen (z. B. „Slopsquatting-
  Vorfall huggingface-cli"), Capture-the-Flag mit absichtlich
  fehlerhaften KI-Vorschlägen halbjährlich. Schulungs-Plattformen:
  SecureFlag (Modul „AI-Assisted Development"), Kontra Application
  Security, GitHub Skills (kostenlose „Copilot for Pull Requests"-
  Pfade), Anthropic Skill-Quests (kostenlos), interne Workshops mit
  Security Champions. Empfohlene Lektüre: OWASP Top 10 for LLM
  Applications (`genai.owasp.org/llm-top-10`), Stanford Study „Do
  Users Write More Insecure Code with AI Assistants?" (Perry et al.
  2023), GitHub Octoverse Reports zu Copilot-Adoption und Bug-Korrelation.
  Nachweisführung: Schulungsmatrix in HR/LMS (Workday, SAP
  SuccessFactors, Cornerstone OnDemand, Moodle, TalentLMS), automatische
  Eskalation bei Frist-Überschreitung (30-Tage-Nachfrist, dann
  Sperrung des KI-Tool-Zugriffs via Microsoft Entra ID/Okta SCIM).
  Onboarding-Pflicht: KI-Tool-Zugriff erst nach abgeschlossener
  Schulung. Referenzen: NIST SP 800-50 (Building IT Security Awareness
  and Training Program), NIST SP 800-181 (NICE Workforce Framework),
  NIST AI RMF MAP-3.5 (skill awareness), ISO/IEC 27001 A.6.3 (Awareness,
  Education, Training), BSI ORP.3, EU AI Act Art. 4 (AI Literacy).
- **EN:** Developers receive training on strengths, weaknesses, and
  risks of AI code assistants. Refreshed at least once a year. Training
  curriculum: (a) strengths — boilerplate acceleration, test
  skeletons, documentation generation, refactoring suggestions,
  language/framework onboarding, code explanation; (b) weaknesses —
  hallucinations (invented APIs, wrong library names, wrong version
  assumptions), outdated training data (typical cut-off months to
  years before model release), overgeneralization ("standard solution"
  does not fit the context), tautological tests, unsafe default code
  (see item 8 — crypto anti-patterns); (c) risks — slopsquatting (item
  5), licence issues (item 6), prompt data leakage (item 7), over-
  reliance (NIST AI RMF MEASURE-2.7), weaker programming skills in
  junior developers under continuous use ("skill atrophy", Stanford
  2024), biases from training data, hallucination repetition under
  iterative prompts; (d) practices — precise prompts with context,
  context window management, manual line-by-line review, cross-
  verification against official documentation, training exercises with
  intentionally wrong AI suggestions ("spot the bug" exercises).
  Recommended training formats: 4-hour onboarding (with hands-on for
  all items in this checklist), annual refresher 2 h, just-in-time
  micro trainings on new tool versions or known AI incidents (e.g.,
  "slopsquatting incident huggingface-cli"), capture-the-flag with
  intentionally flawed AI suggestions semi-annually. Training
  platforms: SecureFlag (module "AI-Assisted Development"), Kontra
  Application Security, GitHub Skills (free "Copilot for Pull
  Requests" paths), Anthropic Skill Quests (free), internal workshops
  with security champions. Recommended reading: OWASP Top 10 for LLM
  Applications (`genai.owasp.org/llm-top-10`), Stanford Study "Do
  Users Write More Insecure Code with AI Assistants?" (Perry et al.
  2023), GitHub Octoverse reports on Copilot adoption and bug
  correlation. Proof: training matrix in HR/LMS (Workday, SAP
  SuccessFactors, Cornerstone OnDemand, Moodle, TalentLMS), automatic
  escalation on deadline overrun (30-day grace period, then AI tool
  access suspension via Microsoft Entra ID/Okta SCIM). Onboarding
  obligation: AI tool access only after completed training.
  References: NIST SP 800-50 (Building IT Security Awareness and
  Training Program), NIST SP 800-181 (NICE Workforce Framework), NIST
  AI RMF MAP-3.5 (skill awareness), ISO/IEC 27001 A.6.3 (awareness,
  education, training), BSI ORP.3, EU AI Act Art. 4 (AI Literacy).
- **Akzeptanz / Acceptance:** Schulungsnachweis pro Person in HR/LMS
  vorhanden; Onboarding vor erstem KI-Tool-Zugriff abgeschlossen;
  jährliche Auffrischung dokumentiert; CTF/Spot-the-Bug-Übungen
  halbjährlich; Erfüllungsquote ≥ 95 % im Quartalsbericht; als lokale Freigaberegel ausgewiesen. / Local release rule: evidence training per person, onboarding before first AI-tool access, annual refresher, semiannual CTF/spot-the-bug exercises and ≥95% completion in the quarterly report.
- **DE:** Jahres-/Halbjahresintervalle, Stundenansätze, Zugriffssperre und ≥95-%-Quote sind zusätzliche lokale Baseline-Vorgaben, keine Zahlen- oder Zugangsvorgaben aus KI-VO Art. 4. Dessen geänderte Fassung verlangt Maßnahmen zur Unterstützung der Entwicklung von KI-Kompetenz unter Berücksichtigung der Personen und des Nutzungskontexts, jedoch keine Garantie eines bestimmten individuellen Kompetenzniveaus. Gesetzliche Anwendbarkeit und lokale Schulungsfreigabe getrennt dokumentieren.
- **EN:** Annual/semiannual intervals, training hours, access suspension and the ≥95% quota are additional local baseline rules, not numerical or access requirements imposed by AI Act Article 4. Its amended wording requires measures supporting development of AI literacy in light of people and use context, without guaranteeing any specific individual literacy level. Record statutory applicability separately from local training clearance.

## CL-10-12

- **DE:** Die Audit-Spur nennt Werkzeug, Version, Scope, verantwortliche Person und relevante Entscheidungen. Aufbewahrung je Datenkategorie aus Zweck, Rechtsgrundlage, Vertragslage und Schutzbedarf ableiten; DSGVO und CRA begründen keine pauschalen Fristen von sechs beziehungsweise zehn Jahren für sämtliche Agenten- oder Plattformlogs. Zugriff begrenzen, Integrität sichern und Löschung testen.
- **EN:** Audit records identify tool, version, scope, responsible person, and relevant decisions. Derive retention per data category from purpose, legal basis, contracts, and risk; GDPR and CRA do not impose universal six- or ten-year periods for all agent or platform logs. Restrict access, protect integrity, and test deletion.
- **Akzeptanz / Acceptance:** Dokumentierter Aufbewahrungs- und Löschplan mit Quelle, Owner und Integritätstest. / Retention and deletion plan with source, owner, and integrity test.

## CL-11-11

- **DE:** Die Wahrnehmung der Betroffenenrechte gemäß DSGVO Art. 12–22
  wird technisch und organisatorisch sichergestellt. Geprüft werden:
  transparente Information bei Erhebung (Art. 13/14), Auskunftsrecht
  (Art. 15), Recht auf Berichtigung (Art. 16), Recht auf Löschung
  („Recht auf Vergessenwerden", Art. 17), Recht auf Einschränkung
  (Art. 18), Mitteilungspflicht bei Berichtigung/Löschung (Art. 19),
  Recht auf Datenübertragbarkeit (Art. 20), Widerspruchsrecht
  (Art. 21), keine ausschließlich automatisierte Entscheidung mit
  rechtlicher Wirkung ohne Schutzvorkehrungen (Art. 22).
  Implementierung: Selfservice-Portal für Auskunft und Export, klare
  Kontaktstelle für formlose Anfragen, dokumentierter Workflow zur
  Bearbeitung mit Einhaltung der Frist (Monat, mit begründeter Verlängerung um bis zu zwei Monate und Mitteilung
  innerhalb des ersten Monats gemäß Art. 12 Abs. 3), Identitätsprüfung der
  Antragsstellenden, Lösch- und Sperrkonzept für jede Datenkategorie.
- **EN:** The exercise of data-subject rights per GDPR Art. 12–22 is
  ensured technically and organisationally. Reviews: transparent
  information at collection (Art. 13/14), right of access (Art. 15),
  rectification (Art. 16), erasure ("right to be forgotten", Art. 17),
  restriction (Art. 18), notification of recipients (Art. 19),
  portability (Art. 20), objection (Art. 21), no solely automated
  decision with legal effect without safeguards (Art. 22).
  Implementation: self-service portal for access and export, clear
  contact point for informal requests, documented handling workflow
  meeting the deadline (one month, with a justified extension of up to two months and notification
  within the first month under Art. 12(3)), identity verification of requesters, erasure and blocking
  concept per data category.
- **Akzeptanz / Acceptance:** Dokumentierte Prozesse und Schnittstellen
  für jedes Betroffenenrecht; Frist- und Identitätsprüfung im
  Workflow. / Documented processes and interfaces for every data-
  subject right; deadline and identity check in the workflow.

## CL-11-06

- **DE:** Die DPIA wird gemäß DSGVO Art. 35 Abs. 2 unter Beteiligung
  einer oder eines benannten DSB, sofern benannt, erstellt. Die
  Stellungnahme der oder des DSB wird in die DPIA-Dokumentation
  aufgenommen. Sie enthält mindestens: Beurteilung der DPIA-Methodik,
  Beurteilung der Vollständigkeit, Empfehlungen zu Maßnahmen,
  Hinweise auf weitergehenden Beratungs- oder Konsultationsbedarf,
  abschließende Bewertung (zum Beispiel keine Bedenken, Bedenken mit
  Auflagen, erhebliche Bedenken). Wenn die Empfehlung der oder des DSB
  nicht oder nicht vollständig umgesetzt wird, wird dies begründet
  dokumentiert.
- **EN:** The DPIA is prepared with involvement of the Organisation data
  protection officer (DPO), where designated, per GDPR Art. 35(2). The DPO opinion is
  included in the DPIA documentation. It contains at least: assessment
  of DPIA methodology, completeness assessment, recommendations on
  measures, indication of any further advice or consultation needs,
  final assessment (for example no concerns, concerns with conditions,
  significant concerns). If the DPO recommendation is not or not fully
  implemented, the reasons are documented.
- **Akzeptanz / Acceptance:** Datierte und unterschriebene Stellungnahme
  der oder des DSB, sofern benannt, als Anlage zur DPIA; Antwortdokument bei
  Abweichungen. / Dated and signed DPO opinion, where designated, attached to the DPIA;
  response document where there are deviations.

## CL-11-12

- **DE:** Die DPIA ist ein lebendes Dokument. Sie wird mindestens
  jährlich (lokale Review-Regel, keine feste DSGVO-Jahresfrist) auf Aktualität
  geprüft und bei jeder wesentlichen Änderung
  der Verarbeitung außerplanmäßig aktualisiert. Wesentliche Änderungen
  sind insbesondere: neue Datenkategorien, neue Empfänger oder neue
  Drittlandsübermittlungen, neue Auftragsverarbeiter, Wechsel der
  Rechtsgrundlage, neue Zwecke, Einsatz neuer Technologien (zum
  Beispiel KI/Machine-Learning, Verschlüsselungs- oder Anonymisierungs-
  verfahren), Erweiterung des Verarbeitungsumfangs (Skalierung), neue
  Schwellwertanalyse-relevante Erkenntnisse aus Vorfällen, Audits oder
  Schwachstellen. Die Versionshistorie der DPIA wird in der
  Dokumentation geführt; jede Version wird mit Datum, Autor\*in und
  gegebenenfalls DSB-Stellungnahme versehen.
- **EN:** The DPIA is a living document. It is reviewed at least
  annually (local policy, not a fixed GDPR annual deadline) and updated outside the regular cycle on any material change
  of the processing. Material changes include new data categories, new
  recipients or third-country transfers, new processors, change of legal
  basis, new purposes, use of new technologies (for example AI/machine
  learning, encryption or anonymisation), expansion of the processing
  scope (scaling), new threshold-analysis-relevant findings from
  incidents, audits, or vulnerabilities. The DPIA version history is
  kept in the documentation; each version carries date, author, and
  DPO opinion where a DPO is designated.
- **Akzeptanz / Acceptance:** DPIA mit aktueller Versionsangabe;
  jährliche Überprüfung dokumentiert; Auslöser für außerplanmäßige
  Aktualisierungen festgelegt. / DPIA with current version; annual
  review documented; triggers for unplanned updates defined.

## CL-11-08

- **DE:** Jede Verarbeitung personenbezogener Daten wird im zentralen
  Verzeichnis der Verarbeitungstätigkeiten (Records of Processing
  Activities, RoPA) der Organisation geführt. Dies ist die lokale
  Baseline-Vorgabe; die eng begrenzte gesetzliche Ausnahme aus Art. 30(5)
  und die Rollen aus Art. 30(1)/(2) werden gesondert bewertet.
  Mindestinhalte: Name und Kontaktdaten der verantwortlichen Stelle,
  Zwecke der Verarbeitung, Kategorien Betroffener, Kategorien
  personenbezogener Daten, Empfängerkategorien, Drittlandsübermittlungen
  einschließlich Garantien, geplante Löschfristen, allgemeine
  Beschreibung der TOM gemäß Art. 32. Die DPIA ist mit dem RoPA-Eintrag
  verknüpft, sodass die Auditspur eindeutig ist. Werkzeuge: projektspezifisches
  internes RoPA-System; alternativ DSGVO-konforme Drittsysteme; in
  Spezialfällen tabellarische Vorlagen mit Versionierung im definierten Nachweisspeicher.
- **EN:** Every processing of personal data is registered in the Organisation
  central record of processing activities (RoPA) under local baseline
  policy. Assess the narrow Article 30(5) exemption and controller/processor
  roles under Article 30(1)/(2) separately.
  Minimum content: name and contact details of the controller,
  purposes of processing, categories of data subjects, categories of
  personal data, categories of recipients, third-country transfers
  with safeguards, planned deletion periods, general description of
  technical and organisational measures per Art. 32. The DPIA is
  linked to the RoPA entry to keep the audit trail unambiguous.
  Tooling: project-specific internal RoPA system; otherwise GDPR-compliant
  third-party systems; in special cases tabular templates with
  versioning in the defined evidence location.
- **Akzeptanz / Acceptance:** RoPA-Eintrag mit allen Mindestinhalten
  und Verknüpfung zur DPIA; mindestens jährliche Überprüfung. / RoPA
  entry with all minimum content and link to the DPIA; at least
  annual review.

## CL-11-07

- **DE:** Wenn die DPIA trotz geplanter Maßnahmen ein verbleibendes
  hohes Risiko ergibt, wird die zuständige Aufsichtsbehörde gemäß
  DSGVO Art. 36 vor Verarbeitungsbeginn konsultiert. Für die Organisation ist
  dies die zuständige Datenschutzaufsichtsbehörde des Projekt- oder Sitzlandes. Die Konsultation umfasst die DPIA, die Beschreibung
  der Verarbeitung, die Aufgabenverteilung zwischen Verantwortlichen
  und Auftragsverarbeitern, geplante Schutzmaßnahmen und alle
  weiteren von der Behörde angeforderten Informationen. Die Antwort
  der Aufsichtsbehörde wird in der DPIA-Dokumentation abgelegt; die
  Verarbeitung beginnt als zusätzliche lokale Freigaberegel erst nach dokumentierter Klärung. Art. 36 verlangt die vorherige Konsultation bei verbleibendem hohen Risiko; er ist kein pauschales gesetzliches Genehmigungserfordernis für jede Verarbeitung.
- **EN:** If the DPIA shows residual high risk despite planned measures,
  the competent supervisory authority is consulted before processing
  starts per GDPR Art. 36. For the organisation this is the competent data protection supervisory authority of the project or seat jurisdiction. The consultation
  includes the DPIA, the processing description, the allocation of
  responsibilities between controllers and processors, planned
  protective measures, and any further information requested by the
  authority. The authority's response is filed with the DPIA
  documentation; as an additional local release rule, processing only begins after documented resolution. Article 36 requires prior consultation for residual high risk; it is not a blanket statutory authorisation requirement for every processing activity.
- **Akzeptanz / Acceptance:** Konsultationsanfrage und Antwort der
  Aufsichtsbehörde dokumentiert; zusätzliche lokale Freigaberegel kenntlich gemacht; Verarbeitung erst nach abgeschlossener
  Konsultation aufgenommen. / Consultation request and authority
  response documented; identify the additional local release rule; processing only started after the consultation
  is closed.

## CL-07-06

- **DE:** Den Bewertungspfad anhand Produktkategorie, anwendbaren harmonisierten Standards und geltenden Sonderregeln bestimmen. Bei Klasse I kann Selbstbewertung an Bedingungen gebunden sein; Klasse II und kritische Produkte benötigen grundsätzlich externe Bewertung beziehungsweise ein zulässiges Zertifizierungsschema. Art. 32(5) erlaubt für FOSS-Produkte der Klasse I/II die interne Kontrolle nur bei öffentlich zugänglicher technischer Dokumentation. Keine pauschale Entscheidung aus einer Beispieltabelle ableiten.
- **EN:** Choose the assessment path from product category, applicable harmonised standards, and current exceptions. Class I self-assessment may be conditional; class II and critical products generally require external assessment or an eligible certification scheme. Article 32(5) permits internal control for FOSS Class I/II products only with publicly available technical documentation. Do not decide from an example table alone.
- **Akzeptanz / Acceptance:** Begründeter Pfad mit zuständiger Entscheidung; [CRA Art. 32](https://eur-lex.europa.eu/eli/reg/2024/2847/oj) / Justified route with responsible decision and primary institutional source.

## CL-07-01

- **DE:** Produkt, Rolle und Marktbereitstellung anhand Art. 2 und Art. 3 CRA prüfen. Erfasst sind Software/Hardware und erforderliche Daten-Fernverarbeitungslösungen; fehlende lokale Installation allein begründet keine Ausnahme. Eigenständige SaaS-Dienste außerhalb dieser Definition gesondert prüfen. NIS2-Anwendbarkeit folgt aus Einrichtung, Sektor, Größe und nationalem Recht, nicht automatisch aus SaaS. Nichtkommerzielle freie Open-Source-Software und die besondere Steward-Rolle nach Art. 24 unterscheiden. Sektorale Ausnahmen (u. a. MDR/IVDR, Fahrzeuge, Luftfahrt, Schiffsausrüstung) am konkreten Rechtsakt prüfen. Nach Art. 69(2) gelten die allgemeinen Anforderungen für vor dem 11.12.2027 in Verkehr gebrachte Produkte nur bei wesentlicher Änderung ab diesem Datum; Art. 69(3) lässt Art. 14 seit 11.09.2026 trotzdem auch für diese Bestandsprodukte gelten. Je Produkteinheit das Inverkehrbringen prüfen, nicht pauschal das erste Release einer Produktfamilie. (EU) 2025/1535 Art. 1 nimmt Produkte nach (EU) Nr. 168/2013 aus, jedoch nicht die L1e-Pedalfahrzeuge nach dessen Art. 3(94)(b). Anhang III/IV und die technischen Kategorienbeschreibungen aus Durchführungsverordnung (EU) 2025/2392 heranziehen.
- **EN:** Assess product, role and market availability under CRA Articles 2 and 3. Software/hardware and necessary remote data-processing solutions are included; absence of local installation alone establishes no exemption. Assess standalone SaaS outside that definition separately. NIS2 scope depends on entity, sector, size and national law, not automatically on SaaS. Distinguish non-commercial free/open-source software from the steward role under Article 24. Check sector exemptions (including MDR/IVDR, vehicles, aviation and marine equipment) against the applicable act. Under Article 69(2), general requirements apply to products placed on the market before 2027-12-11 only if substantially modified from that date; Article 69(3) nevertheless applies Article 14 to these existing products since 2026-09-11. Assess placing on the market per product unit, not solely the first product-family release. Article 1 of (EU) 2025/1535 excludes products under (EU) No 168/2013, except its Article 3(94)(b) L1e vehicles designed to pedal. Use Annexes III/IV and Implementing Regulation (EU) 2025/2392 for technical category descriptions.
- **Akzeptanz / Acceptance:** Produkt/Version, Rolle, Rechtsfassung, Markt, Ausnahmen und Entscheidungsgrund in `docs/security/cra-applicability.md`; zuständige Prüfung datiert. / Record product/version, role, legal version, market, exemptions and rationale; date the responsible review.

## CL-07-09

- **DE:** Hersteller melden aktiv ausgenutzte Schwachstellen und schwerwiegende Sicherheitsvorfälle nach Art. 14 über die Single Reporting Platform gleichzeitig an koordinierenden CSIRT und ENISA: Frühwarnung ohne unangemessene Verzögerung, spätestens 24 Stunden nach Kenntnis, Meldung spätestens nach 72 Stunden. Schwachstellen-Schlussbericht spätestens 14 Tage nach verfügbarer Abhilfe; Vorfall-Schlussbericht spätestens einen Monat nach Vorfallmeldung. Inhalt, Zuständigkeit und Nutzerinformation nach Art. 14 dokumentieren. CRA Art. 16(2), Art. 14(9) und (EU) 2026/881 betreffen eine begründete Verzögerung der CSIRT-Weiterleitung; sie verlängern keine Hersteller-Meldefrist. Art. 14 gilt nach Art. 69(3)/71(2) seit 11.09.2026 auch für zuvor in Verkehr gebrachte, in den CRA-Geltungsbereich fallende Bestandsprodukte. Keine gewöhnliche E-Mail-Adresse als gesetzlichen Plattformersatz ausgeben. Herstellerpflicht ab 11.09.2026, Steward-Pflichten nach Art. 24 ab 11.12.2027 separat behandeln; die [Kommissionsauslegung zu Meldepflichten](https://digital-strategy.ec.europa.eu/en/policies/cra-reporting) bestätigt diesen Beginn ausdrücklich für Art. 24(3). Eine zugleich bestehende Herstellerrolle bleibt ab 11.09.2026 gesondert meldepflichtig. Interne Übungen und Bereitschaft nach Risiko organisieren.
- **EN:** Manufacturers report actively exploited vulnerabilities and severe incidents under Article 14 through the Single Reporting Platform simultaneously to the coordinating CSIRT and ENISA: early warning without undue delay, at most 24 hours after awareness, followed by notification within 72 hours. Vulnerability final reports are due within 14 days after a corrective/mitigating measure is available; incident final reports within one month after incident notification. Record content, responsibility and user information under Article 14. CRA Articles 16(2), 14(9) and (EU) 2026/881 concern a justified delay of CSIRT dissemination; they do not extend manufacturer reporting deadlines. Under Articles 69(3)/71(2), Article 14 applies since 2026-09-11 also to existing in-scope products placed on the market earlier. Do not present an ordinary email address as a statutory platform substitute. Distinguish manufacturer duties from 11 September 2026 and steward Article 24 duties from 11 December 2027; the [Commission reporting guidance](https://digital-strategy.ec.europa.eu/en/policies/cra-reporting) explicitly confirms that start for Article 24(3). A concurrent manufacturer role retains its separate reporting duties from 11 September 2026. Organise exercises and on-call arrangements according to risk.
- **Akzeptanz / Acceptance:** Runbook mit beiden Meldeketten, Auslösern, Plattformzugang, Vertretung, Quellenstand und Übungsnachweis. / Runbook with both reporting chains, triggers, platform access, deputies, source version and exercise evidence.

## CL-07-05

- **DE:** Anhang I Teil II Nr. 1–8 einzeln nachweisen: Komponenten-/Schwachstelleninventar und maschinenlesbare SBOM (rechtlich mindestens Top-Level-Abhängigkeiten; lokale Vollständigkeitsvorgaben gesondert), zügige Behebung und soweit technisch möglich getrennte Sicherheitsupdates, regelmäßige Tests/Reviews, Information über behobene Lücken mit begründeten Offenlegungs-Ausnahmen, CVD-Policy, erreichbarer Meldekontakt, sichere Updateverteilung sowie zügige grundsätzlich kostenlose Sicherheitsupdates. Die Sonderregel für maßgeschneiderte Produkte zwischen Hersteller und gewerblichem Nutzer aus Nr. 8 gesondert prüfen. Vorgegebene Jahresintervalle, konkrete Scanwerkzeuge und SBOM-Formate sind lokale Umsetzung, keine wörtlichen CRA-Pflichten.
- **EN:** Evidence Annex I Part II points 1–8 individually: component/vulnerability inventory and machine-readable SBOM (statutory minimum top-level dependencies; separate local completeness rules), prompt remediation with separate security updates where technically feasible, regular tests/reviews, information on fixed issues with justified disclosure exceptions, CVD policy, reachable reporting contact, secure update delivery, and prompt generally free security updates. Assess the point 8 tailored-product agreement exception between manufacturer and business user separately. Fixed annual intervals, specific scanners and SBOM formats are local implementation choices rather than literal CRA duties.
- **Akzeptanz / Acceptance:** Acht Punkte mit Evidence in `docs/security/cra-annex-i-part-ii-mapping.md`; alter Dateiname `cra-annex-ii-mapping.md` nur als dokumentierter Legacy-Verweis. / Evidence for eight points; document the old misleading filename as a legacy alias only.

## CL-01-08

- **DE:** OWASP SAMM (Software Assurance Maturity Model, Version 2)
  bewertet die Sicherheitsreife eines Projekts oder einer Organisation in
  fünf Geschäftsfunktionen: **Governance** (Strategy & Metrics, Policy &
  Compliance, Education & Guidance), **Design** (Threat Assessment,
  Security Requirements, Security Architecture), **Implementation**
  (Secure Build, Secure Deployment, Defect Management), **Verification**
  (Architecture Assessment, Requirements-driven Testing, Security
  Testing), **Operations** (Incident Management, Environment Management,
  Operational Management). Je Praktik gibt es drei Reifestufen
  (1 = ad-hoc, 2 = strukturiert, 3 = kontinuierlich verbessert).
  Werkzeuge: SAMM-Toolbox als Excel oder Web-App
  (`https://owaspsamm.org/assessment/`); SAMMY (interaktiv); GitHub-
  Repository `OWASP/samm` mit Modellen und Beispielen. Verbesserungsplan
  benennt Ist-Stufe je Praktik, Ziel-Stufe in 6–12 Monaten,
  Maßnahmen und Verantwortliche.
- **EN:** OWASP SAMM (Software Assurance Maturity Model, currently version
  2.x) assesses security maturity of a project or organisation across
  five business functions: **Governance** (Strategy & Metrics, Policy
  & Compliance, Education & Guidance), **Design** (Threat Assessment,
  Security Requirements, Security Architecture), **Implementation**
  (Secure Build, Secure Deployment, Defect Management), **Verification**
  (Architecture Assessment, Requirements-driven Testing, Security
  Testing), **Operations** (Incident Management, Environment
  Management, Operational Management). Each practice has three
  maturity levels (1 = ad-hoc, 2 = structured, 3 = continuously
  improved). Tooling: SAMM Toolbox as Excel or web app
  (`https://owaspsamm.org/assessment/`); SAMMY (interactive); GitHub
  repository `OWASP/samm` with models and examples. The improvement
  plan names current level per practice, target level in 6–12 months,
  actions, and owners.
- **Akzeptanz / Acceptance:** SAMM-Bewertung mit Datum, Ist- und Ziel-
  Reifegrad je Praktik und Folgeaufgabenliste in
  `docs/security/samm-assessment.md`. / SAMM assessment with date,
  current and target maturity per practice, and follow-up task list in
  `docs/security/samm-assessment.md`.
- **Referenz / Reference:** Verfassung XVIII.

## CL-01-03

- **DE:** Für jedes auslieferbare Artefakt eine SBOM (Software Bill of
  Materials) in CycloneDX (JSON `bom.json` oder XML, OWASP-Format) oder
  SPDX (JSON `*.spdx.json` oder Tag-Value, Linux-Foundation-Format)
  pflegen. SBOM bei jedem Release aktualisieren und mitveröffentlichen.
  Werkzeuge: `syft` (Anchore, sprachübergreifend), `cdxgen` (CycloneDX
  Generator, viele Sprachen), `cyclonedx-bom` (Python),
  `cyclonedx-dotnet` (.NET), `cyclonedx-maven-plugin` (Java),
  `@cyclonedx/cyclonedx-npm` (Node.js), `cyclonedx-gomod` (Go).
  Container-SBOM mit `syft` oder
  `trivy sbom`. Pflichtfelder: Komponenten-Name, Version, Lizenz,
  Hash (SHA-256), Lieferant, Beziehungs-Typ. Die SBOM wird im
  CI/CD-Pipeline-Build erzeugt, signiert (z. B. Cosign) und zusammen
  mit dem Artefakt veröffentlicht.
- **EN:** Maintain a CycloneDX (JSON `bom.json` or XML, OWASP format) or
  SPDX (JSON `*.spdx.json` or tag-value, Linux Foundation format) SBOM
  for every shipped artefact. Refresh and publish the SBOM at every
  release. Tooling: `syft` (Anchore, multi-language), `cdxgen`
  (CycloneDX Generator, many languages), `cyclonedx-bom` (Python),
  `cyclonedx-dotnet` (.NET), `cyclonedx-maven-plugin` (Java),
  `@cyclonedx/cyclonedx-npm` (Node.js), `cyclonedx-gomod` (Go).
  Container SBOM via `syft` or
  `trivy sbom`. Required fields: component name, version, licence,
  hash (SHA-256), supplier, relationship type. The SBOM is generated
  in the CI/CD pipeline build, signed (e.g. Cosign), and published
  alongside the artefact.
- **Akzeptanz / Acceptance:** SBOM-Datei im Release-Artefakt; Format
  (CycloneDX oder SPDX), Erzeugungs-Werkzeug, Signaturpfad in
  `docs/security/supply-chain-evidence.md`. / SBOM file in the release
  artefact; format (CycloneDX or SPDX), generation tool, signature
  path in `docs/security/supply-chain-evidence.md`.
- **Referenz / Reference:** ISO 27002 A.8.30; Verfassung XVI.

## CL-01-01

- **DE:** NIST SSDF 1.1 ist die veröffentlichte Basis; 1.2 ist als Entwurf getrennt zu bewerten. PO.1 betrifft Sicherheitsanforderungen, PS.1 den Schutz von Code gegen unberechtigte Änderung, PW.4 die Wiederverwendung gesicherter Komponenten, PW.5 sichere Codierung, PW.7 die Analyse menschenlesbaren Codes und PW.8 Tests ausführbaren Codes. Statische Analyse gehört zu PW.7. Signierte Commits sind ein mögliches Mittel, keine alleinige SSDF-Pflicht. CWE-Jahrgang und ausgewählte Prüfungen dokumentieren.
- **EN:** NIST SSDF 1.1 is the published baseline; assess draft 1.2 separately. PO.1 concerns security requirements, PS.1 code protection, PW.4 reuse of secured components, PW.5 secure coding, PW.7 analysis of human-readable code, and PW.8 executable-code testing. Static analysis belongs to PW.7. Signed commits are one possible measure, not a standalone SSDF mandate. Record the CWE edition and chosen checks.
- **Akzeptanz / Acceptance:** Versioniertes SSDF-/CWE-Mapping mit Nachweisen im Projektplan. / Versioned SSDF/CWE mapping with evidence in the project plan.

## CL-01-11

- **DE:** Nichtanwendbarkeit erfordert eine projektspezifische Begründung. Anwendbarkeit und Umsetzung bleiben getrennt: Applicable, N/A oder Open sowie Fulfilled, Partly Fulfilled, Not Fulfilled oder Not Assessed. Unsicherheit wird als Open mit Folgeaufgabe dokumentiert; N/A bekommt Not Assessed. Ein CLI- oder Konfigurationsprojekt ist nicht allein wegen seiner Artefaktart von Lieferkettenprüfungen ausgenommen.
- **EN:** Non-applicability needs a project-specific rationale. Keep applicability separate from implementation: Applicable, N/A, or Open and Fulfilled, Partly Fulfilled, Not Fulfilled, or Not Assessed. Record uncertainty as Open with follow-up; N/A uses Not Assessed. CLI or configuration artefacts do not automatically exempt a project from supply-chain review.
- **Akzeptanz / Acceptance:** Begründung, Owner, Evidence, Restrisiko, Wiedervorlage und nächste Maßnahme. / Rationale, owner, evidence, residual risk, review trigger, and next action.

## CL-01-12

- **DE:** Quellenstand 20.10.2026: KI-VO konsolidiert am 27.07.2026 durch (EU) 2026/1744. Art. 113 unterscheidet allgemeine Geltung ab 02.08.2026, Kapitel I/II seit 02.02.2025 (neue Art.-5-Verbote ab 02.12.2026), GPAI-/Governance-Regeln seit 02.08.2025 sowie Hochrisiko Kapitel III Abschnitte 1–3 (außer Art. 6(5)) ab 02.12.2027 für Art. 6(2)/Anhang III und 02.08.2028 für Art. 6(1)/Anhang I. Produkt, KI-Werkzeugbetrieb (einschließlich Betreiberrolle) und Organisation getrennt bewerten; Art. 4 verlangt bei einschlägiger Anbieter-/Betreiberrolle Maßnahmen, die die Entwicklung von KI-Kompetenz unterstützen, unter Berücksichtigung von Vorkenntnissen, Ausbildung und Nutzungskontext; ein bestimmtes individuelles Kompetenzniveau muss nicht garantiert werden. Für Deutschland gilt BSIG seit 06.12.2025; §§ 28–30, 32/33 und 38 sowie Sonderregeln und Anlagen prüfen. DORA gilt seit 17.01.2025; unmittelbare Finanzunternehmenspflichten, Vertragsanforderungen an Zulieferer und Aufsicht über kritische IKT-Drittdienstleister unterscheiden. Andere Länder/Branchen benötigen eigene Primärprüfung.
- **EN:** Source date 2026-10-20: AI Act consolidated on 2026-07-27 by (EU) 2026/1744. Article 113 separates general application from 2026-08-02, Chapters I/II since 2025-02-02 (new Article 5 prohibitions from 2026-12-02), GPAI/governance rules since 2025-08-02, and high-risk Chapter III Sections 1–3 (except Article 6(5)) from 2027-12-02 for Article 6(2)/Annex III and 2028-08-02 for Article 6(1)/Annex I. Assess product, AI tool operation (including the deployer role) and organisation separately; Article 4 requires measures supporting the development of AI literacy where the provider/deployer role applies, considering knowledge, training and use context; no specific individual literacy level must be guaranteed. German BSIG applies since 2025-12-06; review sections 28–30, 32/33, 38, special rules and annexes. DORA applies since 2025-01-17; distinguish direct financial-entity duties, supplier contracts and oversight of critical ICT third-party providers. Other jurisdictions/sectors require their own primary review.
- **DE:** Für jedes Rechtsregime (NIS2/BSIG, CRA, KI-VO, DORA und sektor-/kundenspezifische Regeln) getrennt über Produkt, Werkzeugbetrieb und Organisation entscheiden. Je Ebene Land, Rechtsfassung, Rechtsträger, Rolle (etwa Anbieter, Betreiber oder Hersteller), Anwendungsdatum und direkte beziehungsweise vertragliche Pflichten prüfen. Interne Werkzeuge, Ausbildung oder fehlender Vertrieb rechtfertigen kein pauschales N/A: KI-VO Art. 4 kann beim Einsatz von KI-Werkzeugen einschlägig sein, auch ohne ein eigenes KI-Produkt anzubieten. N/A nur für die konkret geprüfte Ebene, Rolle und Rechtsgrundlage begründen. Unbekannte Sachverhalte bleiben `Open` mit Owner und Wiedervorlage.
- **EN:** Decide separately for product, tool operation and organisation under each regime (NIS2/BSIG, CRA, AI Act, DORA and sector/customer rules). For each level assess jurisdiction, legal version, legal entity, role (such as provider, deployer or manufacturer), application date and direct or contractual duties. Internal tools, training or absence of sales do not justify blanket N/A: AI Act Article 4 may apply to AI tool use without offering an AI product. Justify N/A only for the assessed level, role and legal basis. Unknown facts remain `Open` with an owner and review date.
- **Akzeptanz / Acceptance:** `docs/security/regulatory-applicability.md` oder gleichwertige Evidence enthält je Rechtsregime getrennte Zeilen für Produkt, Werkzeugbetrieb und Organisation mit Rolle, Land, Rechtsfassung/Datum, Entscheidung, konkreter Rechtsgrundlage, Begründung, Evidence, Owner/Reviewer und Wiedervorlage; Art.-4-Maßnahmen oder rollenbezogenes N/A sind belegt. / Equivalent evidence records separate product, tool-operation and organisation rows per regime, with role, jurisdiction, legal version/date, decision, exact legal basis, rationale, evidence, owner/reviewer and reevaluation; evidence Article 4 measures or role-specific N/A.
- **Referenz / Reference:** Spec-Kit `security-governance`, Template
  `regulatory-applicability-template`.

## CL-02-13

- **DE:** Wenn ein Projekt Cloud-Dienste wesentlich nutzt oder bereitstellt,
  wird BSI C5:2026 v1.1.0 (11.08.2026) als Assurance-Rahmen geprüft. Die Architektur dokumentiert,
  ob ein C5-Testat oder ein gleichwertiger Nachweis vorliegt, welchen
  Umfang dieser Nachweis abdeckt, welche Shared-Responsibility-Lücken
  bleiben, welche Subdienstleister betroffen sind und welche
  Kundenpflichten offen sind. Fehlt ein C5-Nachweis, werden Ersatznachweise
  und Restrisiken dokumentiert. Testattyp, geprüfter Zeitraum, Dienst/Region, Abweichungen und ergänzende Kundenkontrollen nachweisen. Ein C5-Testat ist keine pauschale Souveränitäts- oder Datenschutzfreigabe.
- **EN:** If a project materially uses or provides cloud services, it
  uses BSI C5:2026 v1.1.0 (2026-08-11) as an assurance framework. The architecture documents whether
  a C5 attestation or equivalent evidence exists, which scope it covers,
  which shared-responsibility gaps remain, which subprocessors are
  involved, and which customer-side duties remain open. If C5 evidence is
  missing, substitute evidence and residual risks are documented. Evidence report type, assessed period, service/region, exceptions and complementary customer controls. A C5 report is not blanket sovereignty or privacy approval.
- **Akzeptanz / Acceptance:** `docs/security/cloud-compliance-assurance.md`
  oder ein gleichwertiges Spec-Kit-Artefakt nennt C5-/Assurance-Status,
  Scope, Provider/Subdienstleister, Shared-Responsibility-Gaps,
  Datenstandort, Logging-/Backup-Nachweise, S-ADR-Links und offene Risiken.
  / `docs/security/cloud-compliance-assurance.md` or an equivalent Spec Kit
  artefact states C5 or assurance status, scope, provider/subprocessors,
  shared-responsibility gaps, data location, logging and backup evidence,
  S-ADR links, and open risks.
- **Referenz / Reference:** Spec-Kit `architecture-governance`, Template
  `cloud-compliance-assurance-template`.

## CL-02-12

- **DE:** Wenn ein Projekt Cloud-Dienste, SaaS, PaaS, IaaS, verwaltete
  Dienste, Container-Registries, Artefakt-Hosting oder providergebundene
  Deployments wesentlich nutzt oder bereitstellt, wird BSI C3A v1.0 (27.04.2026) als
  Bewertungsrahmen für selbstbestimmte Cloud-Nutzung geprüft. Die
  Architektur dokumentiert Provider-Abhängigkeiten, Lock-in-Risiken,
  Exit- oder Portabilitätsoptionen, Daten- und Betriebsstandorte sowie
  betroffene S-ADRs. C3A ist selbst nicht bindend, setzt C5 voraus und umfasst SOV-1 bis SOV-6; SOV-7/8 sind ausgenommen. Eine EU-Region allein belegt keine Autonomie; C3A ersetzt weder C5 noch Datenschutz-/Transferprüfung. Reine Entwicklungsinfrastruktur darf mit kurzer
  Toolchain-Begründung als `nicht anwendbar` dokumentiert werden.
- **EN:** If a project materially uses or provides cloud services, SaaS,
  PaaS, IaaS, managed services, container registries, artefact hosting, or
  provider-dependent deployments, BSI C3A v1.0 (2026-04-27) is checked as an assessment
  framework for self-determined cloud use. The architecture documents
  provider dependencies, lock-in risks, exit or portability options, data
  and operation locations, and affected S-ADRs. C3A is not binding by itself, presupposes C5 and covers SOV-1 to SOV-6; SOV-7/8 are excluded. An EU region alone does not demonstrate autonomy; C3A replaces neither C5 nor privacy/transfer review. Generic development
  infrastructure may be documented as `not applicable` with a short
  toolchain rationale.
- **Akzeptanz / Acceptance:** `docs/security/cloud-autonomy-applicability.md`
  oder ein gleichwertiges Spec-Kit-Artefakt nennt Entscheidung, Cloud-
  Service-Scope, Provider-Abhängigkeiten, Lock-in-/Portabilitätsrisiken,
  Exit-Optionen, S-ADR-Links und N/A-Begründung. / `docs/security/cloud-
  autonomy-applicability.md` or an equivalent Spec Kit artefact states the
  decision, cloud-service scope, provider dependencies, lock-in and
  portability risks, exit options, S-ADR links, and N/A rationale.
- **Referenz / Reference:** Spec-Kit `architecture-governance`, Template
  `cloud-autonomy-applicability-template`.

## CL-02-02

- **DE:** Defense in Depth bedeutet: ein Schutzmechanismus reicht nicht,
  weil jeder Mechanismus versagen kann. Beispiel-Schichten für ein
  Web-Backend: (1) Web Application Firewall oder Reverse Proxy mit
  Rate-Limiting (nginx, Cloudflare, AWS WAF, ModSecurity); (2)
  Eingangsvalidierung im Application-Code (Bean Validation, Pydantic,
  FluentValidation); (3) parametrisierte SQL-Queries; (4) Datenbank-
  Berechtigungen mit Read-Only-Rollen je nach Anwendungsfall; (5)
  Datenbank-Verschlüsselung at-rest (plattformgeeignete Speicherverschlüsselung,
  AWS RDS Encryption); (6) Audit-Logging mit unveränderlichem Speicher
  (Append-Only-Log, S3 Object Lock). Beispiel für ein API-Token:
  HTTPS + kurze TTL + Audience-Claim + Token-Revocation-Liste.
  Beispiel für Container: signiertes Image (Cosign) + Image-Scanner
  (Trivy, Grype) + Pod Security Standards + Network Policy +
  Runtime-Schutz (Falco, Cilium Tetragon). Schichten sollen aus
  unterschiedlichen Komponenten bestehen, sodass ein einzelner Bug
  nicht alle Schichten gleichzeitig kompromittiert.
- **EN:** Defense in depth means: a single mechanism is not enough,
  because every mechanism can fail. Example layers for a web backend:
  (1) web application firewall or reverse proxy with rate limiting
  (nginx, Cloudflare, AWS WAF, ModSecurity); (2) input validation in
  application code (Bean Validation, Pydantic, FluentValidation);
  (3) parameterised SQL queries; (4) database privileges with
  read-only roles per use case; (5) database encryption at rest
  (platform-appropriate storage encryption, AWS RDS encryption); (6) audit
  logging with immutable storage (append-only log, S3 Object Lock).
  Example for an API token: HTTPS + short TTL + audience claim +
  token revocation list. Example for containers: signed image
  (Cosign) + image scanner (Trivy, Grype) + Pod Security Standards
  + network policy + runtime protection (Falco, Cilium Tetragon).
  Layers should be built from different components so a single bug
  cannot bypass them all at once.
- **Akzeptanz / Acceptance:** Tabelle mit kritischen Assets, je Asset
  mindestens zwei unabhängige Schutzschichten und zugehörige Tools. /
  Table of critical assets, with at least two independent protection
  layers and the matching tools per asset.

## CL-03-10

- **DE:** Rotationsfristen werden je Schlüsseltyp, Schutzbedarf und geltendem Standard festgelegt. Für öffentlich vertrauenswürdige TLS-Serverzertifikate gelten ausstellungsabhängige CA/Browser-Fristen: ab 15.03.2026 höchstens 200 Tage, ab 15.03.2027 100 Tage, ab 15.03.2029 47 Tage. Interne PKI getrennt bewerten. Erneuerung automatisieren und vor Ablauf testen; bei Kompromittierung sofort widerrufen beziehungsweise rotieren. Statische Tokenfristen sind lokale Risikopolicy, keine allgemeine Normvorgabe.
- **EN:** Set rotation periods by key type, risk, and applicable standard. Publicly trusted TLS server certificates have issuance-dependent CA/Browser limits: at most 200 days from 2026-03-15, 100 days from 2027-03-15, and 47 days from 2029-03-15. Assess internal PKI separately. Automate renewal and test before expiry; revoke or rotate immediately after compromise. Static token periods are local risk policy, not universal standard requirements.
- **Akzeptanz / Acceptance:** Rotations- und Wiederherstellungstest; Quelle: https://cabforum.org/working-groups/server/baseline-requirements/requirements/ Abschnitt / section 6.3.2.

## CL-03-14

- **DE:** Krypto-Inventar und risikobasierten PQC-Migrationsplan führen, nicht nur Entwicklungen beobachten. TR-02102-1, 2026-01, Abschnitt 2.1 empfiehlt alleinige klassische Schlüsseleinigung nur bis Ende 2031, bei sehr hohem Schutzbedarf Umstellung bis Ende 2030; für klassische Signaturen wird derzeit Ende 2035 als Horizont genannt. Langfristig vertrauliche Daten wegen „Store Now, Decrypt Later“ schon heute prüfen. Teil 2 empfiehlt TLS 1.2 nur bis Ende 2031. Empfohlene PQ-Verfahren geeignet hybrid kombinieren; Standardsstatus, Sicherheitsparameter, Protokollprofil und Implementierungsreife getrennt bewerten. Der Plan nennt Owner, Datenklassen, Abhängigkeiten, Zieltermine, Tests und Wiedervorlage; Bibliotheksverfügbarkeit ist keine Freigabe.
- **EN:** Maintain a crypto inventory and risk-based PQC migration plan rather than merely tracking developments. TR-02102-1, 2026-01, section 2.1 recommends standalone classical key agreement only until end-2031, with migration by end-2030 for very high protection needs; end-2035 is the current horizon for classical signatures. Assess long-term confidentiality now because of store-now-decrypt-later risk. Part 2 recommends TLS 1.2 only until end-2031. Combine recommended PQ mechanisms appropriately in hybrid form; assess standardisation, parameters, protocol profile and implementation maturity separately. Record owner, data classes, dependencies, dates, tests and reevaluation; library availability is not approval.
- **Akzeptanz / Acceptance:** Inventar und S-ADR mit teilfassungsgebundenem Migrationsplan und Wiedervorlage vorhanden. / Inventory and S-ADR provide a part/version-bound migration plan and reevaluation.

## CL-12-05

- **DE:** Eingesetzte agentische KI-Werkzeuge (zum Beispiel OpenCode, Codex), Provider, Modelle und Konfigurationen sind im KI-Werkzeug-Inventar der Organisation geführt und freigegeben. Werkzeug-Versionen, Container-Image-Digests und Modell-Identifikatoren sind reproduzierbar gepinnt. Selbst-aktualisierende Mechanismen sind deaktiviert.
- **EN:** Agentic AI tools in use (for example OpenCode, Codex), providers, models, and configurations are listed in the Organisation AI tool inventory and approved. Tool versions, container image digests, and model identifiers are reproducibly pinned. Self-updating mechanisms are disabled.
- **Akzeptanz / Acceptance:** Inventar-Eintrag, Versionsausgabe (`tool --version`), Image-Digest und Modell-IDs sind dokumentiert; im Werkzeug ist kein Auto-Update aktiv; die KI-Lieferkettentransparenz nach CL-09-15 ist berücksichtigt. / Inventory entry, version output (`tool --version`), image digest, and model IDs are documented; auto-update is disabled in the tool; AI supply-chain transparency per CL-09-15 is taken into account.

## CL-03-07

- **DE:** TLS 1.3 bevorzugen; TLS 1.2 ist nach TR-02102-2 (2026-01), Kap. 3, nur bis Ende 2031 empfohlen. SSLv2/v3 und TLS 1.0/1.1 deaktivieren. Für das BSI-Profil TLS-1.3-Suites aus Tabelle 13 verwenden, etwa `TLS_AES_256_GCM_SHA384` oder `TLS_AES_128_GCM_SHA256`; TLS-1.2-Beispiele aus Tabelle 3 sind `TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384` und `TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384`. Signaturverfahren, Gruppen und Schlüssellängen zusätzlich nach Tabellen 7–12 und Kap. 3.6 prüfen: bei RSA PSS verwenden; TLS-1.2-RSA mit PKCS#1-v1.5-Padding wurde nur bis 2025 empfohlen. ChaCha20-Suites stehen nicht in Tabellen 3/13 dieser Ausgabe; eine lokal gewählte Abweichung ist gesondert zu begründen und darf nicht als BSI-konform ausgegeben werden. Ein Cipher-String allein erzwingt weder PSS noch alle BSI-Parameter. Effektive Konfiguration und Handshake je Zielplattform prüfen; CL-03-14/15 steuern Migration und Quellenabgleich. HSTS für öffentliche Web-Endpunkte nach geprüfter Subdomain-Policy setzen. Öffentliche Web-Zertifikate über eine vertrauenswürdige CA mit anwendbarer CT-Policy; geschlossene Test-/Entwicklungsumgebungen dürfen dokumentierte eigene Vertrauensanker verwenden.
- **EN:** Prefer TLS 1.3; TR-02102-2 (2026-01), Chapter 3 recommends TLS 1.2 only through 2031. Disable SSLv2/v3 and TLS 1.0/1.1. For the BSI profile use TLS 1.3 suites from Table 13, such as `TLS_AES_256_GCM_SHA384` or `TLS_AES_128_GCM_SHA256`; TLS 1.2 examples from Table 3 are `TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384` and `TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384`. Also assess signature schemes, groups and key sizes under Tables 7–12 and Chapter 3.6: use PSS for RSA; TLS 1.2 RSA with PKCS#1 v1.5 padding was recommended only through 2025. ChaCha20 suites do not appear in Tables 3/13 of this edition; justify any locally chosen deviation separately and do not label it BSI-conformant. A cipher string alone enforces neither PSS nor all BSI parameters. Check effective configuration and handshakes per target platform; CL-03-14/15 govern migration and source review. Apply HSTS to public web endpoints with a reviewed subdomain policy. Use a trusted CA with applicable CT policy for public web certificates; closed test/development environments may use documented private trust anchors.
- **Akzeptanz / Acceptance:** TLS-Scan und Handshake-Nachweis je Endpunkt, Protokoll/Suite/Gruppe/Signatur/Schlüssellänge gegen die datierte BSI-Ausgabe bewertet, Abweichungen begründet und Migration terminiert; ein Scanner-Rating allein genügt nicht. / Per-endpoint TLS scan and handshake evidence assess protocol, suite, group, signature and key size against the dated BSI edition, justify deviations and schedule migration; a scanner rating alone is insufficient.

## CL-05-11

- **DE:** Lizenzen werden anhand konkreter Lizenzfassung, Nutzungsart, Weitergabe und Kombination bewertet. Copyleft ist nicht pauschal kommerziell unvereinbar und dynamisches Linken ist keine allgemeine Ausnahme für alle Lizenzen. Fehlende oder unklare Rechte bleiben Open bis zur zuständigen Entscheidung. SBOM, Lizenztexte, Pflichten und Projekt-Allowlist nachvollziehbar halten; Rechtsfragen werden nicht durch Scanner entschieden.
- **EN:** Assess exact licence versions, use, redistribution, and combination. Copyleft is not inherently incompatible with commercial use, and dynamic linking is not a universal exemption. Missing or unclear rights remain Open until the responsible decision. Maintain SBOM, licence texts, obligations, and project allow-list; scanners do not decide legal questions.
- **Akzeptanz / Acceptance:** Lizenzentscheidung mit Quelle, Owner und Pflichten; ungeklärte Rechte blockieren die betroffene Weitergabe. / Licence decision with source, owner, and obligations; unresolved rights block affected redistribution.

## CL-05-13

- **DE:** Bindet ein release- oder verteilbares Artefakt ein KI-Modell
  oder einen KI-Dienst ein, wird diese KI-Abhängigkeit in der SBOM bzw.
  im Lieferketten-Evidenz-Dokument geführt. CycloneDX bildet dies über
  Modell-Komponenten des Typs `machine-learning-model` und die eigene
  `services`-Sammlung für Dienste ab (ML-BOM; eingesetzte Schemaversion prüfen). Erfasst werden Anbieter, Modell- oder Dienst-Identifikator,
  Version oder Endpunkt sowie ein Verweis auf Model Card oder AI-SBOM
  des Anbieters. Für fremdbezogene Modelle wird keine eigene Modell-
  oder Trainingsdaten-SBOM erzeugt; maßgeblich ist die
  Anbieter-Transparenz (siehe CL-09-15).
  Bezugsrahmen ist die G7-Leitlinie „Software Bill of Materials for AI –
  Minimum Elements" (2026).
- **EN:** If a release or distributable artefact embeds an AI model or
  AI service, this AI dependency is recorded in the SBOM or the
  supply-chain evidence document. CycloneDX represents this through
  model components of type `machine-learning-model` and the separate
  `services` collection (ML-BOM; check the emitted schema version).
  Recorded are the provider, model or service identifier, version or
  endpoint, and a link to the provider's model card or AI-SBOM. For
  externally sourced models no own model or training-data SBOM is
  generated; the provider transparency is authoritative (see
  CL_KI-Codeerzeugung, item 15). The reference framework is the G7
  guideline "Software Bill of Materials for AI – Minimum Elements"
  (2026).
- **Akzeptanz / Acceptance:** Enthält das Artefakt eine KI-Abhängigkeit,
  ist sie in der SBOM als KI-Komponente geführt und auf die
  Anbieter-Transparenzquelle verwiesen; zusätzlich ist der Nachweis im
  Lieferketten-Evidenzdokument oder in einem gleichwertigen Spec-Kit-
  Artefakt referenziert; andernfalls „nicht anwendbar" mit Begründung. /
  If the artefact contains an AI dependency, it is recorded in the SBOM as
  an AI component with a link to the provider transparency source; the
  evidence is also referenced in the supply-chain evidence document or in
  an equivalent Spec Kit artefact; otherwise "not applicable" with
  justification.

## CL-06-09

- **DE:** Unterstützte Versionen, Supportende, Patch- und Backportstrategie veröffentlichen. Für CRA-Produkte CL-07-10 und Art. 13(8)–(10) anwenden: Support begründen, gesetzliche Ausnahme für erwartete Nutzung unter fünf Jahren gesondert prüfen und verfügbare Updates mindestens zehn Jahre nach Ausgabe oder bis Supportende bereithalten, je nachdem, was länger ist. Ersatz einer älteren Softwarefassung nur unter den Bedingungen aus Art. 13(10). Ein kurzer Beispiel-Lifecycle oder kommerzielle LTS-Zusatzleistung hebt diese Pflichten nicht auf. Releases mit Integritätsnachweis und verständlicher EOL-/Migrationsinformation bereitstellen.
- **EN:** Publish supported versions, support end, patch and backport strategy. For CRA products apply CL-07-10 and Article 13(8)–(10): justify support, assess the expected-use-under-five-years exception separately, and retain issued updates for at least ten years after issue or until support end, whichever is longer. Replace an older software version only under Article 13(10) conditions. A short example lifecycle or commercial LTS add-on does not override these duties. Provide release integrity evidence and clear EOL/migration information.
- **Akzeptanz / Acceptance:** Lifecycle-Tabelle, Patch-/Backportplan und drei getrennte CRA-Fristen konsistent nachgewiesen. / Consistent lifecycle table, patch/backport plan and three distinct CRA clocks.

## CL-06-07

- **DE:** CRA-Meldeketten aus CL-07-09 im Runbook umsetzen: 24-/72-Stunden-Fristen ab Kenntnis und getrennte Schlussfristen für Schwachstelle/Vorfall; gesetzliche Plattform und Pflichtinhalte verwenden. Zusätzlich Anwendbarkeit anderer Meldeketten prüfen: DSGVO Art. 33 mit Risikoschwelle und 72 Stunden ab Kenntnis des Verantwortlichen; Auftragsverarbeiter informiert nach Art. 33(2) ohne unangemessene Verzögerung. NIS2/BSIG und DORA haben eigene Rollen, Schwellen und Fristauslöser. Eine gemeinsame Incident-Akte darf mehrere Pflichten bedienen, ersetzt aber keine einzelne vorgeschriebene Meldung.
- **EN:** Implement CL-07-09 CRA reporting chains in the runbook: awareness-based 24/72-hour clocks and separate vulnerability/incident final deadlines; use the statutory platform and content. Also screen other chains: GDPR Article 33 with its risk threshold and 72 hours from controller awareness; a processor informs without undue delay under Article 33(2). NIS2/BSIG and DORA have their own roles, thresholds and triggers. One incident file may support several duties but does not replace any required notification.
- **Akzeptanz / Acceptance:** Runbook mit Rollen, Schwellen, Fristen, Vertretung und Übungsnachweis; Screening nach CL-01-12 verlinkt. / Runbook with roles, thresholds, clocks, deputies and exercise evidence; link CL-01-12 screening.

## CL-07-11

- **DE:** Hersteller nach Art. 13, Bevollmächtigte nach Art. 18, Importeure nach Art. 19, Distributoren nach Art. 20 und Rollenwechsel nach Art. 21/22 getrennt prüfen. Lieferantenverträge risikobasiert auf Schwachstelleninformation, Support, SBOM, Auditrechte und Zuständigkeiten abstimmen. Eine interne 24-Stunden-Zulieferfrist, Haftungsregel oder Quellcode-Escrow kann eine begründete Vertragsanforderung sein; sie ist keine universelle CRA-Klausel. Vertragspflichten ersetzen nicht die verbleibende Herstellerverantwortung und dürfen nicht pauschal auf alle OSS-Beitragenden übertragen werden.
- **EN:** Distinguish manufacturer Article 13, authorised representative Article 18, importer Article 19, distributor Article 20 and role changes under Articles 21/22. Align supplier contracts on a risk basis for vulnerability information, support, SBOM, audit rights and responsibilities. An internal 24-hour supplier deadline, liability term or source escrow may be a justified contractual requirement; it is not a universal CRA clause. Contracts do not replace remaining manufacturer responsibility and must not be imposed indiscriminately on all OSS contributors.
- **Akzeptanz / Acceptance:** Rollen-/Pflichtenmatrix, geprüfte Verträge und begründete zusätzliche lokale Klauseln dokumentiert. / Record role/duty matrix, reviewed contracts and justified additional local terms.

## CL-07-04

- **DE:** Anhang I Teil I vollständig und risikobasiert abbilden: Nr. 1 sicheres Design; Nr. 2(a) keine bekannten ausnutzbaren Schwachstellen, (b) sichere Defaults, (c) Sicherheitsupdates, (d) Zugriffsschutz, (e) Vertraulichkeit, (f) Integrität, (g) Datenminimierung für persönliche und andere Daten, (h) Verfügbarkeit, (i) Auswirkungen auf andere Systeme, (j) Angriffsfläche, (k) Exploit-Folgenbegrenzung, (l) Logging mit Opt-out, (m) sichere Löschung und Übertragung. Anwendbarkeit und gesetzliche Bedingungen je Punkt bewerten. Nr. 2(b) umfasst die Rücksetzung in den Originalzustand; eine abweichende Vereinbarung zu sicheren Defaults gilt nur zwischen Hersteller und gewerblichem Nutzer bei einem maßgeschneiderten Produkt, nicht pauschal für Anhang I. Eine Scan-Ausgabe allein beweist keine Erfüllung. Konformitätsvermutung nach Art. 27 nur für die tatsächlich im EU-Amtsblatt für den CRA referenzierten einschlägigen Teile einer Norm annehmen; verwandte RED-/IoT-/Industrienormen sind nicht automatisch CRA-harmonisiert.
- **EN:** Map all of Annex I Part I on a risk basis: point 1 secure design; point 2(a) no known exploitable vulnerabilities, (b) secure defaults, (c) security updates, (d) access protection, (e) confidentiality, (f) integrity, (g) minimisation of personal and other data, (h) availability, (i) impact on other systems, (j) attack surface, (k) exploit mitigation, (l) logging with opt-out, (m) secure erasure and transfer. Assess applicability and statutory conditions per point. Point 2(b) includes resetting to the original state; a different agreement on secure defaults applies only between manufacturer and business user for a tailor-made product, not to Annex I as a whole. A scan alone does not prove fulfilment. Claim Article 27 presumption only for applicable standard parts actually referenced in the EU Official Journal for the CRA; related RED/IoT/industrial standards are not automatically CRA-harmonised.
- **Akzeptanz / Acceptance:** Vollständiges Punkt-Mapping in `docs/security/cra-annex-i-mapping.md` mit Risiko, Umsetzung, Test/Evidence und geprüften Amtsblattreferenzen. / Complete point mapping with risk, implementation, tests/evidence and checked OJ references.

## CL-07-07

- **DE:** EU-Konformitätserklärung nach Art. 28 und Anhang V (gegebenenfalls vereinfachte Erklärung nach Anhang VI) vor Inverkehrbringen nach Art. 13(12) erstellen. CE-Regeln stehen in Art. 29/30, nicht Art. 32. Für Software ist das CE-Zeichen auf der Erklärung oder der leicht direkt zugänglichen begleitenden Website zulässig; ein Splash-Screen ist keine allgemeine Pflicht. Begleitinformationen nach Anhang II und die erforderlichen Sprachen der Zielmitgliedstaaten prüfen. Nur tatsächlich angewandte, einschlägige Normen und reale Notifizierungs-/Zertifikatsdaten nennen; Beispielnormen oder erfundene Zertifikate sind kein Konformitätsnachweis.
- **EN:** Prepare the EU declaration under Article 28 and Annex V (or simplified declaration under Annex VI where applicable) before placing on the market under Article 13(12). CE rules are in Articles 29/30, not Article 32. Software may carry CE marking on the declaration or an easily/directly accessible accompanying website; a splash screen is not universally required. Check Annex II information and languages required by target Member States. Name only standards actually applied and applicable, and real notification/certificate data; example standards or invented certificates do not establish conformity.
- **Akzeptanz / Acceptance:** Datierte Erklärung, begründeter CE-Ort, Begleitinformationen und Sprachprüfung im Release-Dossier. / Dated declaration, justified CE location, accompanying information and language review in the release dossier.

## CL-07-10

- **DE:** Support nach Art. 13(8) an erwarteter Nutzungsdauer und Produktart ausrichten, grundsätzlich mindestens fünf Jahre; ist die erwartete Nutzung kürzer, entspricht der Support dieser Dauer. Begründung und berücksichtigte Faktoren in der technischen Dokumentation festhalten. Art. 13(9) verlangt, veröffentlichte Sicherheitsupdates mindestens zehn Jahre nach Ausgabe oder für den verbleibenden Supportzeitraum verfügbar zu halten, je nachdem, was länger ist. Supportdauer, Updateverfügbarkeit und Dokumentationsaufbewahrung sind verschiedene Fristen; EOL-Hinweis allein erlaubt keine Verkürzung gesetzlicher Pflichten. Art. 13(18) verlangt Anhang-II-Informationen mindestens zehn Jahre nach Inverkehrbringen oder für den längeren Supportzeitraum zugänglich zu halten; bei Online-Bereitstellung verständlich und nutzerfreundlich online. Nach Art. 13(19) Supportende bereits beim Kauf klar und leicht zugänglich mindestens mit Monat/Jahr nennen und, soweit technisch nach Produktart möglich, bei Supportende einen Nutzerhinweis anzeigen.
- **EN:** Determine support under Article 13(8) from expected use and product type, generally at least five years; if expected use is shorter, support corresponds to that period. Record the rationale and considered factors in technical documentation. Article 13(9) requires issued security updates to remain available for at least ten years after issue or the remaining support period, whichever is longer. Support duration, update availability and document retention are distinct clocks; an EOL notice alone cannot shorten statutory duties. Article 13(18) requires Annex II information to remain available for at least ten years after placing on the market or the longer support period; online provision must remain accessible and user-friendly. Under Article 13(19), clearly state the support end at purchase in an easily accessible way with at least month/year and, where technically feasible for the product, display an end-of-support notification.
- **Akzeptanz / Acceptance:** Begründete, zuständig geprüfte Supportentscheidung mit getrennten Support-, Update-, Dokumentations- und Anhang-II-Informationsfristen, Kauf-/EOL-Hinweisen und Wiedervorlage. / Justified, responsibly reviewed support decision with separate support, update, documentation and Annex II information clocks, purchase/EOL notices and reevaluation.

## CL-07-08

- **DE:** Technische Dokumentation gemäß Art. 31 und Anhang VII vor Inverkehrbringen erstellen und während des Supportzeitraums aktuell halten. Sie umfasst Produktbeschreibung, Entwurf/Entwicklung, Risikobewertung, Anhang-I-Mapping, angewandte Spezifikationen, Prüfungen, SBOM und nachvollziehbare Schwachstellenbehandlung. Nach Art. 13(13) technische Dokumentation und Konformitätserklärung mindestens zehn Jahre nach Inverkehrbringen oder für den Supportzeitraum aufbewahren, je nachdem, was länger ist. Dies ist keine pauschale Aufbewahrungsfrist für personenbezogene Agentenlogs. Zugriff, Integrität, Aktualisierung und Datenminimierung belegen.
- **EN:** Prepare technical documentation under Article 31 and Annex VII before placing on the market and keep it current during support. Include product description, design/development, risk assessment, Annex I mapping, applied specifications, tests, SBOM and traceable vulnerability handling. Article 13(13) requires retaining technical documentation and the declaration for at least ten years after placing on the market or the support period, whichever is longer. This is not a blanket retention period for personal agent logs. Evidence access control, integrity, updates and data minimisation.
- **Akzeptanz / Acceptance:** Indexiertes CRA-Dossier mit Anhang-VII-Mapping, Quellenstand und begründeter Aufbewahrungsentscheidung. / Indexed CRA dossier with Annex VII mapping, source version and justified retention decision.

## CL-07-03

- **DE:** Anhang IV auf kritische Produkte prüfen: Hardware mit Sicherheitsboxen, Smart-Meter-Gateways und weitere Geräte für fortgeschrittene Sicherheitszwecke einschließlich sicherer Kryptoverarbeitung sowie Smartcards oder ähnliche Geräte einschließlich sicherer Elemente. Art. 8 und Art. 32(4) bestimmen den Pfad: einschlägige delegierte Rechtsakte und verfügbare europäische Zertifizierungsschemata prüfen; soweit die Bedingungen aus Art. 8(1) nicht vorliegen, ist nach Art. 32(4)(b) jeder Pfad aus Art. 32(3) zulaessig: Modul B+C, Modul H oder, soweit verfuegbar und anwendbar, ein europaeisches Cybersicherheitszertifizierungsschema nach Art. 27(9) mit mindestens Vertrauenswuerdigkeitsstufe „substanziell“. Aus dem CRA folgt kein allgemeines EAL4+-Gebot. Produktzertifizierung, Laborakkreditierung und CRA-Notifizierung sind verschiedene Nachweise; konkrete Stelle im offiziellen Notifizierungsregister prüfen.
- **EN:** Check Annex IV for critical products: hardware devices with security boxes, smart-meter gateways and other devices for advanced security purposes including secure cryptoprocessing, and smartcards or similar devices including secure elements. Articles 8 and 32(4) determine the path: assess applicable delegated acts and available European certification schemes; where Article 8(1) conditions are not met, Article 32(4)(b) allows any Article 32(3) route: Module B+C, Module H, or, where available and applicable, a European cybersecurity certification scheme under Article 27(9) at assurance level at least substantial. The CRA does not impose a universal EAL4+ requirement. Product certification, laboratory accreditation and CRA notification are separate proofs; verify any selected body in the official notification register.
- **Akzeptanz / Acceptance:** Anhang-IV-Treffer oder begründetes N/A, geprüfte Rechtsakte/Schemata und Konformitätspfad im CRA-Dossier. / Record Annex IV match or justified N/A, checked acts/schemes and conformity path in the CRA dossier.

## CL-03-02

- **DE:** RSA mit mindestens 3072 Bit, ECDSA mit Kurve P-256 (secp256r1) oder höher,
  oder Ed25519 nach begründeter Profilentscheidung. Für Schlüsseltausch: ECDH (P-256
  oder höher) oder X25519. RSA-Verschlüsselung verwendet RSA-OAEP mit SHA-256
  (`Cipher.getInstance("RSA/ECB/OAEPWithSHA-256AndMGF1Padding")` in Java,
  `RSA.encrypt(..., padding=OAEP(SHA256()))` in Python `cryptography`,
  `RSAEncryptionPadding.OaepSHA256` in .NET); RSA-PKCS#1 v1.5 ist für neue
  Anwendungen verboten. ECDSA-Signaturen sollen RFC 6979 (deterministisch)
  oder einen geprüften CSPRNG verwenden, um Nonce-Kollisionen zu vermeiden.
  Verbotene Kurven: P-192 (secp192r1), brainpoolP160 und kürzere.
- **EN:** RSA with at least 3072 bit, ECDSA with curve P-256 (secp256r1) or
  higher, or Ed25519 under a justified profile decision. For key exchange: ECDH
  (P-256 or higher) or X25519. RSA encryption uses RSA-OAEP with SHA-256
  (`Cipher.getInstance("RSA/ECB/OAEPWithSHA-256AndMGF1Padding")` in Java,
  `RSA.encrypt(..., padding=OAEP(SHA256()))` in Python `cryptography`,
  `RSAEncryptionPadding.OaepSHA256` in .NET); RSA-PKCS#1 v1.5 is forbidden
  for new applications. ECDSA signatures should use RFC 6979 (deterministic)
  or a vetted CSPRNG to avoid nonce collisions. Forbidden curves: P-192
  (secp192r1), brainpoolP160, and shorter.
- **DE:** Diese Auswahl ist lokale Baseline-Policy, keine pauschale BSI-Freigabe.
  Je Protokoll die konkrete TR-02102-Teilfassung, Parameter und Laufzeit prüfen;
  generische Bibliotheksunterstützung beweist keine Profilkonformität.
- **EN:** This selection is local baseline policy, not blanket BSI approval.
  Check the relevant TR-02102 part, parameters and validity period per protocol;
  library support does not establish profile conformity.
- **Akzeptanz / Acceptance:** Algorithmus, Kurve, Padding und Bibliothek je
  Modul dokumentiert. / Algorithm, curve, padding, and library documented
  per module.

## CL-12-12

- **DE:** Mindestens quartalsweise und anlassbezogen die GSDB und sämtliche im zugeordneten Profil aktiven Presets prüfen. Das Acht-Preset-Standardprofil und die verwalteten Profile 12, 13 und 14 bleiben unterscheidbar. Assurance ist ab Profil 13 enthalten, Project Statistics ab Profil 14. Versionspins, Prioritäten, Overrides und fachliche Abdeckung prüfen; Änderungen nur nach Auftrag übernehmen. Die jährliche vertiefte Preset-Prüfung am 3. Oktober bleibt zusätzlich bestehen.
- **EN:** Review the GSDB and every preset active in the assigned profile at least quarterly and after relevant changes. Distinguish the eight-preset default and managed profiles 12, 13, and 14. Assurance is included from profile 13, Project Statistics from profile 14. Check pinned versions, priorities, overrides, and content coverage; apply changes only under authority. Annual in-depth preset review on 3 October remains additional.
- **Akzeptanz / Acceptance:** Profilgebundene Installationsprüfung, Abdeckungsmatrix, Quellenreview und datierter Ergebnisbericht. / Profile-bound installation check, coverage matrix, source review, and dated outcome report.
