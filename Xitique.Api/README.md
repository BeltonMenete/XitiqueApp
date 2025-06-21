# Xitique.API - Development Setup Guide

Get ready to build! This guide jumpstarts your local development environment for `Xitique.API`, the powerful backend service powering XitiqueApp.

## 🚀 Getting Started

### Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Git](https://git-scm.com/)
- [SQL Server (or SQL Server Express)](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio Code](https://code.visualstudio.com/) or [JetBrains Rider](https://www.jetbrains.com/rider/)

## 📦 Cloning the Repository

```bash
git clone https://github.com/BeltonMenete/XitiqueApp.git
cd XitiqueApp/Xitique.API # Navigate to API project
```

## ⚙️ Database Setup (MS SQL Server)

### 1. Configure Connection String:

- Edit `appsettings.Development.json`.
- Update `ConnectionStrings:DefaultConnection`.

**Local SQL Server Express Example:**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=XitiqueDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

**Full SQL Server Instance Example:**

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=XitiqueDb;User Id=your_user;Password=your_password;MultipleActiveResultSets=true;TrustServerCertificate=True"
}
```

### 2. Apply Database Migrations:

From `Xitique.API` project directory:

```bash
dotnet ef database update
```

## 🔑 API Key / Secret Configuration

Secure sensitive data with .NET User Secrets:

**Initialize:**

```bash
dotnet user-secrets init
```

**Set secrets:**

```bash
dotnet user-secrets set "ExternalServices:Email:ApiKey" "your_email_api_key_here"
dotnet user-secrets set "Jwt:Key" "your_jwt_signing_key_here_must_be_long_and_strong"
```

## ▶️ Running the API

### Command Line:

From `Xitique.API` directory:

```bash
dotnet run
```

### Visual Studio Code:

Open `XitiqueApp/Xitique.API` folder → Run and Debug (Ctrl+Shift+D) → `.NET Core Launch` → Start.

### JetBrains Rider:

Open `XitiqueApp.sln` → Select `Xitique.API` project in the Run/Debug Configurations dropdown → Click the Run button.

API typically runs on [http://localhost:5000](http://localhost:5000) and [https://localhost:5001](https://localhost:5001).

> **Note:** For local development with tools like Postman/Insomnia, you might need to temporarily comment out `app.UseHttpsRedirection();` in `Program.cs` if you're experiencing issues with HTTPS certificate trust.

## 🧪 Testing the API

- **Scalar UI**: Access via the configured Scalar endpoint (e.g., [https://localhost:5001/scalar](https://localhost:5001/scalar)) after adding `app.MapScalarApiReference();` in `Program.cs`.
- **Tools**: Hoppscotch, Insomnia, Postman, Curl

## 📂 Project Structure

XitiqueApp follows a clean, layered architecture, emphasizing abstraction and extensibility (e.g., via `IService`, `IConfiguration` interfaces):

```
XitiqueApp/
├── Xitique.API/             # Presentation Layer: API Controllers, DTOs, endpoint definitions
│   ├── Controllers/
│   ├── appsettings.json
│   ├── Program.cs
│   └── Xitique.API.csproj
├── Xitique.Domain/          # Core Business Logic: Entities, Domain Services, Interfaces
│   ├── Entities/
│   ├── Services/
│   └── Xitique.Domain.csproj
└── Xitique.Contracts/       # Shared Contracts: Interfaces, Enums, shared DTOs (e.g., for API and Domain)
    ├── Interfaces/
    ├── Enums/
    └── Xitique.Contracts.csproj
```

(*This structure promotes modularity and maintainability.*)

## 🛠️ Dependencies

Key NuGet packages utilized:

- `Microsoft.EntityFrameworkCore`
- `Microsoft.AspNetCore.Identity.EntityFrameworkCore`
- `Microsoft.AspNetCore.Authentication.JwtBearer`
- `FluentValidation.AspNetCore` (for robust input validation)
- `Scalar.AspNetCore` (for OpenAPI documentation)
- `Microsoft.Extensions.Configuration.UserSecrets`

> *(Note: Additional NuGet packages will be integrated as development progresses.)*

## 🆘 Troubleshooting

- **"dotnet" command not found**: Verify .NET 9 SDK and PATH.
- **Database connection errors**: Check connection string, SQL Server status, firewall.
- **Migration errors**: Correct directory for `dotnet ef database update`. Add new migrations if models changed (`dotnet ef migrations add [MigrationName]`).

---

