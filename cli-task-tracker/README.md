# CLI Task Tracker

A single-binary command-line program that lets a user record, list, complete, and delete personal tasks, storing everything in one local JSON file.

---

## Skills Exercised

- File I/O  
- Collections / LINQ  
- Args parsing  
- Simple domain modeling  
- Testable design  

---

## Objective

Write code that someone (future me) would actually run — not just read.

---

## Constraints

- No external NuGet packages — only BCL / MSBuild / xUnit  
- ≤ **500 lines** of production code (measured by `cloc`, excluding blanks/comments/tests)  
- **≥ 80%** unit test coverage of production LOC  
- `dotnet run --list` must:
  - Allocate **≤ 10MB RAM**
  - Read **≤ 1MB** from disk  
- All commands must finish in **< 200ms** on a 5000-task JSON file (release build)

---

## User-Visible Commands

```bash
todo add "Write spec" --due 2025-07-14   # Add new task  
todo list                                # List all open tasks  
todo list --all                          # List open + completed  
todo done 3                              # Mark ID 3 as done  
todo delete 5                            # Delete task with ID 5  
todo clear-completed                     # Purge all completed tasks  
```

--- 

## Data Model (Keep it Stupid-Simple)

```json
[
  {
    "id": 1,
    "title": "Write brutal spec",
    "created": "2025-07-11T20:42:00-06:00",
    "due": "2025-07-14",
    "done": false
  },
  {
    "id": 2,
    "title": "Test persistence",
    "created": "...",
    "due": null,
    "done": true
  }
]
```

- Filename: tasks.json in the same directory as the executable
- Alternatively: %APPDATA%/todo/ on Windows or $HOME/.todo/ on Linux/macOS (your call, but document it)
- IDs: Monotonically increasing integers (gaps are fine)

---

## Architecture Skeleton

``` 
src/
├── Todo.Domain/TaskItem.cs
├── Todo.Persistence/JsonRepository.cs
├── Todo.Cli/
│   ├── Program.cs         ← thin adapter only
│   └── CommandParser.cs
└── Todo.Tests/ (…)
Design Rules
All business logic must live outside Program.cs
JsonRepository: write atomically to tasks.tmp, then File.Replace
No DI container — use constructor injection + new() as needed
```

---

## Minimum Test Suite

- Adding a task appends one element and persists to disk  
- Marking a task as done flips the `done` flag and persists  
- Deleting a task removes it from the collection and persists  
- Listing returns tasks **sorted by due date ascending**, then by created timestamp  
- Concurrency guard: two sequential `add` calls produce unique, incrementing IDs  
- Use a `TempFile` or `InMemoryRepository` pattern to mock file I/O and accelerate tests

---

## Performance Gate (Automatic)

Include an xUnit `[Fact]` test that:

- Seeds the repository with **5000 tasks** (once; reused across tests)  
- Runs `CliRunner.Invoke("list")`  
- Asserts elapsed execution time is **< 200ms** using `Stopwatch`

>  If this test fails, the build fails — performance is not optional.

---

## Stretch Goals (Post-MVP Only)

| Feature                            | Skill Exercised              |
|------------------------------------|------------------------------|
| `todo edit 4 --title "..." --due ...` | Optional argument parsing   |
| `todo export --csv`               | Custom serialization formats |
| Tag support (`--tag urgent`)      | Many-to-many modeling        |
| File locking                      | OS concurrency primitives    |

---

## Delivery Checklist

- [ ] `README.md` with:
  - Build and run instructions
  - Full spec
  - Constraints
  - Performance metrics
- [ ] `cloc` output proving **≤ 500** LOC in production code  
- [ ] `dotnet test -c Release` passes on CI (bonus: GitHub Actions YAML)  
- [ ] Binary (`todo` or `todo.exe`) built via:  
  ```bash
  dotnet publish -c Release -p:PublishSingleFile=true -o ./artifacts/
