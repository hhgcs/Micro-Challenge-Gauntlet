# Micro-Challenge-Gauntlet
Series of microchallenges to overcome skill stagnation


The Challenge Ladder
0. Warm-up (48 h max)
FizzBuzz, but evil – every 7th call to your function must run in ≤ 1 µs. Micro-benchmark and adjust.

Junior Tier — Foundations
CLI Task Tracker (JSON persistence)
Skills: basic I/O, classes/structs, LINQ, unit tests.
Constraint: no external packages, ≤ 500 LOC.

HTTP Log Analyzer
Ingest an Nginx log file, spit out top 10 endpoints by latency.
Skills: file streaming, regex, grouping, performance profiling.
Stretch: parallelize with Parallel.ForEach.

Tiny REST Client
Console app that pulls weather data from a public API and caches responses on disk.
Skills: HttpClient lifetime management, DTO mapping, error handling.
Mindset hit: resist the urge to over-abstract—ship.

Mid Tier — Real-World Layers
Minimal API URL Shortener
ASP.NET Core Minimal API + SQLite. Rate-limit by IP.
Skills: routing, DI, EF Core, migrations, validation.
Constraint: deploy to free Azure App Service in < 2 h.

Queue-Driven Image Resizer
Produce: ASP.NET API uploads images → pushes message → Worker resizes → stores in S3/Azure Blob.
Skills: background services, messaging (SQS/Azure Storage Queue), async patterns, cancellation tokens.
Stretch: add retry with exponential back-off.

Thread-Safe Stock Ticker
Build a library that maintains live prices via WebSocket and exposes reactive stream to clients.
Skills: Channel<T>, IObservable, locking vs lock-free, memory pressure measurement.
Mindset shift: latency budget beats pretty code.

Mid-Senior Tier — Architecture & DevOps
Feature-Flag Service
Multi-tenant, toggles served in < 20 ms. Provide REST + SDK client.
Skills: DDD aggregates, versioned contracts, OpenAPI, semantic versioning, rate limiting.
Constraint: Blue-green deploy scripted with GitHub Actions + Terraform.

Self-Healing Bot
Windows service that monitors CPU/RAM of processes, restarts misbehaving ones, logs to Grafana via Prometheus exporter.
Skills: WMI/PerformanceCounters, resilient design, observability, structured logging.
Brutal truth: you’ll hate Windows quirks—learn anyway.

Senior Tier — Distributed, High-Load, Deep Internals
Event-Sourced Order System
Domain events, snapshotting, eventual consistency between read & write models.
Skills: CQRS, optimistic concurrency, projections, idempotency.
Stretch: “chaos monkey” test harness.

Custom Roslyn Analyzer + Code Fix
Enforce a company-wide rule (e.g., forbid DateTime.Now). Ship as NuGet.
Skills: compiler AST, code generation, semantic models, packaging.
Mindset: mastering internals lets you bend the ecosystem to your will.

Distributed Cache (Raft-lite)
Three-node cluster that replicates a key/value store with basic leader election.
Skills: sockets, serialization, consensus algorithms, fault injection testing.
Constraint: ≤ 10 k LOC total, 99 % reads in < 5 ms on local network.

Zero-Downtime Migration Framework
Library + CLI that applies rolling, reversible migrations across microservices with dependency mapping.
Skills: orchestration, rollout strategies, graph algorithms, advanced CI/CD pipelines.
Senior filter: document failure modes first.

Master Stretch — The One that Gets You Hired Anywhere
Open-Source SaaS Skeleton
Combine auth (OIDC), billing (Stripe), API gateway, observability stack, k8s helm charts.
Publish as template repo + blog series.
Outcome: public artifact that proves horizontal skill set and leadership.
