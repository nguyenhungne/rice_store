# Plumeria Rentals

## 📌 Overview
Plumeria Rentals is a WinForms-based rental management system that integrates with SQL Server using **Entity Framework Core**. This guide will help you set up the project, run database migrations, and apply them.

---

## 🚀 Getting Started

### **👉 1. Prerequisites**
Before running the project, ensure you have installed:
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server 2019+](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Entity Framework Core CLI](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
  ```sh
  dotnet tool install --global dotnet-ef
  ```
- **Docker (Optional)** if running SQL Server in a container:
  ```sh
  docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=YourPassword123" -p 1433:1433 --name sqlserver -d mcr.microsoft.com/mssql/server:2019-latest
  ```

---

## ⚙️ **2. Project Setup**
### **👉 Clone the Repository**
```sh
git clone https://github.com/nguyenhungne/rice_store
cd rice_store
```

### **👉 Install Dependencies**
```sh
dotnet restore
```

### **👉 Configure `appsettings.json`**

update `appsettings.json` with your connect string:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=RentalManagement;User Id=sa;Password=YourPassword123;"
  }
}
```

---

## 📝 **3. Running Migrations**
### **👉 Add a New Migration**
```sh
dotnet ef migrations add InitialCreate --project src/rice_store.data
```

### **👉 Apply Migrations to Database**
```sh
dotnet ef database update --project src/rice_store.data
```

### **👉 Verify Tables in SQL Server**
1. Open **SQL Server Management Studio (SSMS)** or Azure Data Studio.
2. Connect to the server (`localhost,1433`).
3. Run:
   ```sql
   USE RentalManagement;
   SELECT * FROM sys.tables;
   ```

---

## 🏃 **4. Running the Application**
### **👉 Option 1: Run via VS Code**
1. Open the project in **VS Code**.
2. Press **`F5`** to start debugging.

### **👉 Option 2: Run from Terminal**
```sh
dotnet run --project src/rice_store
```

---

## 🛠 **5. Common Issues & Fixes**
| **Issue** | **Solution** |
|-----------|-------------|
| `dotnet ef` not recognized | Run `dotnet tool install --global dotnet-ef` |
| `System.ArgumentException: Could not resolve connection string` | Ensure `appsettings.json` or `.env` contains the correct database connection |
| `Cannot connect to SQL Server` | Check if SQL Server is running: `docker ps` or `netstat -an | find "1433"` |
| `Migration applied but no tables` | Run `dotnet ef migrations list` to check migration status |

---

## 🎯 **6. Useful Commands**
### **👉 Check Installed Migrations**
```sh
dotnet ef migrations list --project src/rice_store.data
```

### **👉 Remove the Last Migration**
```sh
dotnet ef migrations remove --project src/rice_store.data
```

### **👉 Reset Database (Delete & Reapply Migrations)**
```sh
dotnet ef database drop --project src/rice_store.data
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🎉 **7. Contributing**
1. Fork the repository and create a new branch:
   ```sh
   git checkout -b feature/new-feature
   ```
2. Commit changes:
   ```sh
   git commit -m "Added new feature"
   ```
3. Push and create a **Pull Request**.

---

## 💪 **8. Support & Contact**
For issues, create a GitHub issue or contact:
- **Email:** nguyenhungf205@gmail.com
- **GitHub:** [rice_store](https://github.com/nguyenhungne)
```
This README file provides detailed onboarding instructions for setting up the project, running migrations, and applying them using **Entity Framework Core** in a WinForms-based project. 🚀
```

## 📌 Project By:
- **Nguyễn Quốc Nhật Hùng**
- **Lương Minh Tân**
