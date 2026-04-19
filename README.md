University Management System — .NET & EF Core

A **console-based University Management System** built with **C# (.NET)** and **Entity Framework Core**, demonstrating real-world database management with code-first migrations, LINQ queries, and relational data modelling across core university entities such as students, teachers, courses, departments, and enrollments.

---

## 🚀 Features

- **Student Management** — Add, view, update, and delete student records
- **Teacher / Faculty Management** — Manage instructor profiles and department assignments
- **Department Management** — Create and manage university departments
- **Course Management** — Define courses, assign instructors, link to departments
- **Enrollment System** — Enroll students in courses and track academic progress
- **Grade & Result Tracking** — Record and retrieve student grades per course
- **EF Core Code-First** — Full database schema managed via C# models and migrations
- **LINQ Queries** — Strongly-typed data retrieval with eager loading (`.Include()`)

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET 8 / .NET 9) |
| ORM | Entity Framework Core |
| Database | SQL Server / SQL Server LocalDB |
| IDE | Visual Studio 2022 (v17.14) |
| Architecture | Console Application (Single Project) |

---

## 📁 Project Structure

```
UniversityManagmentSystem/
│
├── Models/                        # Entity classes
│   ├── Student.cs
│   ├── Teacher.cs
│   ├── Course.cs
│   ├── Department.cs
│   └── Enrollment.cs
│
├── Data/                          # EF Core DbContext
│   └── UniversityDbContext.cs
│
├── Migrations/                    # Auto-generated EF Core migrations
│
├── Program.cs                     # Application entry point & menu logic
│
└── UniversityManagmentSystem.csproj
```

---

## ⚙️ Getting Started

### Prerequisites

- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)
- SQL Server (LocalDB / Express / Full)
- Visual Studio 2022 **or** VS Code with C# Dev Kit

### 1. Clone the Repository

```bash
git clone https://github.com/Humaisdev/UniversityManagmentSystem.git
cd UniversityManagmentSystem
```

### 2. Configure the Connection String

Open `Program.cs` or `appsettings.json` and update your connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=UniversityDB;Trusted_Connection=True;"
}
```

### 3. Apply Migrations & Create Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run --project UniversityManagmentSystem
```

---

## 🗄️ Database Schema (Overview)

```
Department
 └── DepartmentId, Name

Teacher
 └── TeacherId, Name, Email, DepartmentId (FK)

Course
 └── CourseId, Title, Credits, DepartmentId (FK), TeacherId (FK)

Student
 └── StudentId, Name, Email, DateOfBirth, DepartmentId (FK)

Enrollment
 └── EnrollmentId, StudentId (FK), CourseId (FK), Grade, EnrollmentDate
```

**Relationships:**
- A `Department` has many `Students`, `Teachers`, and `Courses`
- A `Teacher` teaches many `Courses`
- A `Student` can enroll in many `Courses` through `Enrollment` (many-to-many)

---

## 📦 EF Core Commands Reference

```bash
# Add a new migration after model changes
dotnet ef migrations add <MigrationName>

# Apply pending migrations to the database
dotnet ef database update

# Remove the last unapplied migration
dotnet ef migrations remove

# Drop and recreate the database
dotnet ef database drop
dotnet ef database update
```

---

## 🧪 Sample Code

```csharp
// Get all students with their enrolled courses
var students = context.Students
    .Include(s => s.Enrollments)
        .ThenInclude(e => e.Course)
    .ToList();

// Enroll a student in a course
context.Enrollments.Add(new Enrollment
{
    StudentId = 1,
    CourseId = 3,
    EnrollmentDate = DateTime.Now
});
context.SaveChanges();

// Get all courses in a department
var courses = context.Courses
    .Where(c => c.DepartmentId == 2)
    .Include(c => c.Teacher)
    .ToList();
```

---

## 📌 Roadmap

- [x] Student CRUD operations
- [x] Course & Department management
- [x] EF Core code-first migrations
- [x] Enrollment & grade tracking
- [ ] ASP.NET Core Web API layer
- [ ] Role-based access (Admin / Teacher / Student)
- [ ] Attendance management
- [ ] Fee management module
- [ ] Unit tests (xUnit)

---

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/YourFeature`
3. Commit your changes: `git commit -m 'Add YourFeature'`
4. Push to the branch: `git push origin feature/YourFeature`
5. Open a Pull Request

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

## 👤 Author

**Humais**
GitHub: [@Humaisdev](https://github.com/Humaisdev)
