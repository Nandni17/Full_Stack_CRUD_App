# Employee Management System (Full-Stack CRUD Application)

A decoupled full-stack web application featuring an **ASP.NET Core MVC Client** interface that consumes an autonomous **ASP.NET Core Web API** backend. Data persistence is managed via **Entity Framework Core** communicating with an **SQL Server** instance.

---

##  Architecture & Tech Stack

This project is structured as a decoupled monorepo to demonstrate clean separation of concerns:

* **Client/Frontend:** ASP.NET Core MVC (utilizing asynchronous `HttpClient` to process API payloads)
* **Backend/API:** ASP.NET Core Web API (handles RESTful routing, business logic, and database operations)
* **Database & ORM:** SQL Server Express & Entity Framework Core (Code-First approach)

---

##  Key Technical Features

* **Asynchronous Execution:** Implements `async/await` patterns end-to-end across controllers, repository layers, and network calls for high-throughput performance.
* **API Consumer Integration:** Leveraged `HttpClient` to seamlessly issue REST requests (`GET`, `POST`, `PUT`, `DELETE`) from the MVC layer to the Web API layer.
* **JSON Data Transport:** Utilizes robust JSON serialization and deserialization (`Newtonsoft.Json`) for handling model payloads seamlessly across subsystems.

---

##  Local Setup Instructions

Follow these steps to get the full-stack system running on your local machine:

### 1. Database Configuration
1. Open **SQL Server Management Studio (SSMS)** and connect to your local SQL Server instance.
2. Open the script located in the `/Database/` directory (or wherever your script is saved).
3. Execute the script to generate the `EmployeeDB` database, the `Employees` table schema, and seed the initial dataset.
4. Open the backend API project (`ASP.NetCoreWebApis`) and verify the connection string in `appsettings.json` points to your local server:
```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;"
   }
