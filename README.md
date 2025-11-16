# StudentManagementSystem

Short overview of the project directory structure.

```
StudentManagementSystem/ Solution root
├─ StudentManagementSystem.csproj Project file (.NET8)
├─ Program.cs Application bootstrap, DI and middleware setup
├─ Controllers/ ASP.NET Core API controllers (entry points)
│ └─ StudentsController.cs Exposes student CRUD endpoints calling MediatR
├─ Application/ Application (CQRS) layer
│ ├─ Commands/ Write operations
│ │ ├─ AddStudents/ Add student command + handler
│ │ ├─ UpdateStudent/ Update student command + handler
│ │ └─ DeleteStudent/ Delete student command + handler
│ └─ Queries/ Read operations
│ └─ GetAllStudents/ Query + handler to list students
├─ Data/ Persistence infrastructure
│ └─ AppDbContext.cs EF Core DbContext for Student entity
├─ Models/ Domain / entity classes
│ └─ Student.cs Student entity definition
└─ obj/ Build artifacts (auto-generated)
```

Key points:
- Implements CQRS using MediatR: commands mutate state; queries read state.
- `Controllers` depend only on MediatR (`IMediator`) to dispatch requests.
- `Application` layer holds request/handler pairs keeping logic separated.
- `Data` layer provides EF Core context; entity defined in `Models`.
- Target framework: .NET8; C#12 features may be used (e.g., record types).
