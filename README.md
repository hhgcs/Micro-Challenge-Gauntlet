# Micro-Challenge Gauntlet  
*From “junior who waits for clarity” to **senior who ships under fire***  

> **Read this first:** Ambiguity is your lifelong teammate.  
> Ship anyway, measure the pain, iterate. No excuses.

---

## Execution Rules (Non-Negotiable)

1. **Ship before you’re ready** – 80 % functionality → release → refine.  
2. **Tests from challenge #2 onward** – red ➜ green ➜ refactor.  
3. **One-page design memo** for everything ≥ *Mid Tier*.  
4. **Public repo** – sunlight kills perfectionism.  
5. **Post-mortem** – what sucked, what surprised you, how to prevent repeat pain.

Copy these rules into every project’s `README`. Break one and the checkbox stays unchecked.

---

## Challenge Ladder

### 0. Warm-Up (48 h cap)
- [ ] ~~**FizzBuzz, but evil** – every 7th call must run in ≤ 1 µs (micro-benchmark)~~.

---

### Junior Tier — Foundations

| # | Project | Core Skills | Extra Constraints |
|---|---------|-------------|-------------------|
| 1 | **CLI Task Tracker (JSON)** | I/O, classes/structs, LINQ, xUnit | No external packages, ≤ 500 LOC |
| 2 | **HTTP Log Analyzer** | Streaming files, regex, grouping, perf profiling | Add `Parallel.ForEach` once baseline works |
| 3 | **Tiny REST Client** | `HttpClient` lifetime, DTO mapping, error handling, caching | Ship with **one** concrete YAGNI cut |

---

### Mid Tier — Real-World Layers

| # | Project | Core Skills | Ship-Fast Constraint |
|---|---------|-------------|----------------------|
| 4 | **Minimal API URL Shortener** | ASP.NET Core Minimal API, DI, EF Core | Deploy to free Azure App Service in < 2 h |
| 5 | **Queue-Driven Image Resizer** | Background workers, messaging, async, cancellation -| Add retry w/ exponential back-off |
| 6 | **Thread-Safe Stock Ticker** | `Channel<T>`, `IObservable`, lock-free patterns, memory profiling | 95 % updates < 100 ms round-trip |

---

### Mid-Senior Tier — Architecture & DevOps

| # | Project | Core Skills | Brutal Constraint |
|---|---------|-------------|-------------------|
| 7 | **Feature-Flag Service** | DDD, versioned contracts, OpenAPI, rate limiting | Blue-green deploy via GH Actions + Terraform |
| 8 | **Self-Healing Bot (Windows)** | WMI/PerfCounters, resiliency, observability | Alert to Grafana in under 30 s of failure |

---

### Senior Tier — Distributed, High-Load, Deep Internals

| # | Project | Core Skills | Reality Check |
|---|---------|-------------|---------------|
| 9 | **Event-Sourced Order System** | CQRS, snapshots, projections, idempotency | Build a chaos-monkey harness |
| 10 | **Custom Roslyn Analyzer + Fix** | Compiler AST, code gen, NuGet packaging | Enforce **no `DateTime.Now`** company-wide |
| 11 | **Distributed Cache (Raft-Lite)** | Sockets, consensus, serialization | ≥ 3 nodes, 99 % reads < 5 ms LAN |
| 12 | **Zero-Downtime Migration Framework** | Orchestration, rollout, graph algorithms | Document failure modes **first** |

---

### Master Stretch — “Hire-Me Anywhere” Artifact

| # | Project | Core Skills | Outcome |
|---|---------|-------------|---------|
| 13 | **Open-Source SaaS Skeleton** | Auth (OIDC), billing (Stripe), API gateway, k8s Helm, observability stack | Template repo + blog series that shows leadership |

---

## Immediate Action

1. Fork a blank repo named **`Micro-Challenge-Gauntlet`**.  
2. Paste this file as `README.md`.  
3. Check ☑️ box 1 (*CLI Task Tracker*) – commit **first failing test** within **30 minutes** of reading this.  
4. Drop the repo link here for a ruthless code review.

Success begins *now*, not after another tutorial binge. Go write painful, glorious code.

