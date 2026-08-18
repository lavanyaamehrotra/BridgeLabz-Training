# 🚀 BridgeLabz Backend Refresher Training (.NET)
A structured learning journey covering **DBMS, SQL Server, Database Design, ER Modeling, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers, ADO.NET, ASP.NET Core MVC, ASP.NET Core Minimal APIs, REST APIs, and Backend Development**.

This repository documents my day-wise progress throughout the **BridgeLabz Backend Refresher Training**. Each module includes theoretical concepts, practical implementations, database design exercises, SQL programming, ADO.NET applications, ASP.NET Core MVC projects, ASP.NET Core Minimal API development, CRUD operations, RESTful API implementation, and backend development practices using the .NET ecosystem.

---

# 📚 Tech Stack

| Category | Technologies |
|----------|--------------|
| 💻 **Database** | Microsoft SQL Server, H2 Database |
| 🗄️ **Query Language** | SQL (T-SQL) |
| 💻 **Programming Language** | C# |
| 🌐 **Backend Framework** | ASP.NET Core, ASP.NET Core MVC, ASP.NET Core Minimal APIs |
| 🎨 **Frontend** | HTML5, CSS3, Razor Views (.cshtml) |
| 🔗 **Data Access** | ADO.NET, H2Sharp |
| 🛠️ **IDE** | Visual Studio, Visual Studio Code, SQL Server Management Studio (SSMS) |
| 🔧 **Version Control** | Git & GitHub |
| 📐 **Concepts** | DBMS, RDBMS, Database Design, ER Diagram, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers, ADO.NET, H2 Database, Distributed Architecture, SDLC, MVC Architecture, Minimal APIs, REST APIs, CRUD Operations, Routing, HTTP Methods (GET, POST, PUT, DELETE), Model Binding, Dependency Injection, IConfiguration, Repository Pattern |
| 🎯 **Domain** | Backend Development (.NET), RESTful API Development |
---

# 📅 Daily Learning Progress

---

# 📅 Day 1 – DBMS Fundamentals & RDBMS Basics

## 📖 Topics Covered

- Introduction to Database Management System (DBMS)
- Relational Database Management System (RDBMS)
- SQL vs NoSQL Databases
- Microsoft SQL Server
- T-SQL Basics
- DDL Commands
- DML Commands
- Database Schema Design
- Primary Keys
- Foreign Keys
- One-to-Many Relationships
- Data Integrity using Constraints

---

## 🛠️ Practical Implementation

Designed and implemented a **Health Clinic Database** using Microsoft SQL Server.

### Database Created

```sql
HealthClinicDB
```

### Tables Created

- Doctor
- Patient
- Appointment

### Relationships

- One Doctor → Many Appointments
- One Patient → Many Appointments

---

## 🧠 Concepts Practiced

- CREATE DATABASE
- CREATE TABLE
- PRIMARY KEY
- FOREIGN KEY
- IDENTITY
- UNIQUE Constraint
- NOT NULL Constraint

---

## 🎯 Learning Outcomes

- Understood the fundamentals of DBMS and relational databases.
- Designed a healthcare database schema using SQL Server.
- Created relational tables with appropriate constraints.
- Implemented one-to-many relationships using foreign keys.
- Strengthened understanding of SQL DDL and DML commands.

---

# 📅 Day 2 – ER Diagram, Normalization & Indexing

## 📖 Topics Covered

- ER Diagram Design
- Entities
- Attributes
- Relationships
- Cardinality
- Participation
- Primary Keys
- Foreign Keys
- Database Normalization
- First Normal Form (1NF)
- Second Normal Form (2NF)
- Third Normal Form (3NF)
- SQL Server Indexing
- Query Optimization
- Execution Plan Analysis

---

## 🛠️ Practical Implementation

Extended the existing **Health Clinic Database** by implementing advanced database design and optimization concepts.

### Tasks Completed

- ✅ Created **Room** table
- ✅ Established **Doctor–Room** relationship using a Foreign Key
- ✅ Designed the complete ER Diagram
- ✅ Uploaded ER Diagram to GitHub
- ✅ Created Single Column Index
- ✅ Created Composite Index
- ✅ Created Covering Index
- ✅ Created PatientPhones table
- ✅ Verified 1NF, 2NF and 3NF
- ✅ Compared execution plans before and after indexing

---

## 🗄️ Database Enhancements

### New Table

- Room

### New Relationships

- One Room → Many Doctors
- One Doctor → Many Appointments
- One Patient → Many Appointments

---

## 📈 Indexes Implemented

### Single Column Index

```sql
IX_VisitType
```

### Composite Index

```sql
IX_Doctor_Date
```

### Covering Index

```sql
IX_Covering_Doctor
```

---

## ⚡ Query Optimization

Implemented and analyzed:

- Query execution without an index
- Query execution using a Single Column Index
- Query execution using a Composite Index
- Query execution using a Covering Index

Verified query optimization using SQL Server Execution Plans (Index Seek).

---

## 🧩 Database Normalization

Created the **PatientPhones** table to support multiple phone numbers per patient and verified:

- ✅ First Normal Form (1NF)
- ✅ Second Normal Form (2NF)
- ✅ Third Normal Form (3NF)

---

## 🎯 Learning Outcomes

- Designed a complete ER Diagram.
- Applied normalization techniques.
- Implemented Single, Composite and Covering Indexes.
- Learned query optimization using SQL Server Execution Plans.
- Strengthened database design skills.

---

# 📅 Day 3 – SQL Joins, Stored Procedures & Triggers

## 📖 Topics Covered

- SQL Joins
- INNER JOIN
- LEFT JOIN
- RIGHT JOIN
- FULL OUTER JOIN
- Stored Procedures
- Parameterized Stored Procedures
- SQL Triggers
- INSERT Trigger
- UPDATE Trigger
- DELETE Trigger
- Audit Tables
- Database Automation
- Data Auditing

---

## 🛠️ Practical Implementation

Enhanced the **Health Clinic Database** by implementing advanced SQL programming concepts for querying, automation, and auditing.

### Tasks Completed

- ✅ Performed **INNER JOIN** to retrieve doctor, patient, and appointment information
- ✅ Implemented **LEFT JOIN** to display all doctors with or without appointments
- ✅ Executed **RIGHT JOIN** to retrieve all patients and their appointments
- ✅ Implemented **FULL OUTER JOIN** to combine doctor and patient appointment information
- ✅ Created reusable **Stored Procedures** for common healthcare operations
- ✅ Created **DoctorAudit**, **PatientAudit**, and **AppointmentAudit** tables
- ✅ Implemented INSERT, UPDATE and DELETE Triggers
- ✅ Verified automatic audit logging through SQL Server Triggers

---

## 🗄️ Database Enhancements

### Audit Tables Created

- DoctorAudit
- PatientAudit
- AppointmentAudit

### Triggers Implemented

#### Doctor

- TR_Doctor_Insert
- TR_Doctor_Update
- TR_Doctor_Delete

#### Patient

- TR_Patient_Insert

#### Appointment

- TR_Appointment_Insert

---

## 🔗 SQL Joins Practiced

Implemented and tested:

- INNER JOIN
- LEFT JOIN
- RIGHT JOIN
- FULL OUTER JOIN

using:

- Doctor
- Patient
- Appointment
- Room

---

## ⚙️ Stored Procedures

Created reusable Stored Procedures for:

- Retrieving doctor appointments
- Viewing patient appointment history
- Fetching doctor schedules
- Updating appointment details
- Managing appointment records

---

## 🔄 Database Automation

Implemented SQL Server Triggers to automatically:

- Record newly inserted records
- Log updates made to records
- Maintain deletion history
- Store historical data in Audit Tables

---

## 📊 Audit Logging

Captured:

- Record ID
- Entity Information
- Operation Performed
- Timestamp of Action

---

## 🎯 Learning Outcomes

- Learned practical implementation of SQL Joins.
- Created reusable Stored Procedures.
- Understood SQL Server Triggers.
- Implemented database automation.
- Built Audit Tables.
- Strengthened backend database programming skills.

---

# 📅 Day 4 – ADO.NET & Health Clinic Application Development

## 📖 Topics Covered

- Introduction to ADO.NET
- ADO.NET Architecture
- Connected Architecture
- CRUD Operations using ADO.NET
- SQL Server Connectivity
- SqlConnection
- SqlCommand
- SqlDataReader
- SqlParameter
- ExecuteNonQuery()
- ExecuteReader()
- Parameterized Queries
- Exception Handling
- Layered Architecture
- Health Clinic Console Application

---

## 🛠️ Practical Implementation

Developed a **Health Clinic Console Application** using **ADO.NET** and connected it with **Microsoft SQL Server**.

### Tasks Completed

- ✅ Connected the .NET application with SQL Server using **SqlConnection**
- ✅ Implemented Doctor Management Module
- ✅ Implemented Patient Management Module
- ✅ Performed CRUD operations using ADO.NET
- ✅ Used Stored Procedures for Update operation
- ✅ Executed Parameterized Queries to prevent SQL Injection
- ✅ Applied Exception Handling using try-catch blocks
- ✅ Created a layered architecture using Entities, Interfaces, Services, and Exceptions
- ✅ Integrated the finalized Health Clinic ER Diagram with the application

---

## 🗄️ Application Modules

### Doctor Module

- Add Doctor
- View Doctors
- Update Doctor
- Delete Doctor

### Patient Module

- Register Patient
- View Patients
- Update Patient
- Delete Patient

### Appointment Module

- Schedule Appointment
- View Appointments
- Update Appointment
- Cancel Appointment

---

## ⚙️ ADO.NET Components Used

- SqlConnection
- SqlCommand
- SqlDataReader
- SqlParameter
- ExecuteNonQuery()
- ExecuteReader()

---

## 🔒 Security Features

- Parameterized Queries
- Exception Handling
- Input Validation
- Stored Procedures

---

## 🎯 Learning Outcomes

- Understood ADO.NET Architecture.
- Learned Connected Architecture in ADO.NET.
- Connected C# applications with SQL Server.
- Implemented CRUD operations using ADO.NET.
- Prevented SQL Injection using Parameterized Queries.
- Built a console-based Health Clinic Management System.
- Improved backend development skills using C# and SQL Server.
---

# 📅 Day 5 – ASP.NET Core Web API & RESTful Services

## 📖 Topics Covered

- Introduction to ASP.NET Core
- ASP.NET Core Web API
- RESTful APIs
- HTTP Methods
- GET, POST, PUT and DELETE Requests
- API Controllers
- Routing
- Dependency Injection
- JSON Data Exchange
- Swagger / OpenAPI
- Project Structure
- Model Binding
- Action Methods

---

## 🛠️ Practical Implementation

Created a **Contacts Management Web API** using **ASP.NET Core Web API** by following a layered architecture.

### Tasks Completed

- ✅ Created an ASP.NET Core Web API solution
- ✅ Organized the project into API, Models, Repository, and Service layers
- ✅ Implemented API Controllers
- ✅ Followed Repository Pattern and Service Layer architecture

---

## 🌐 REST APIs Implemented

### Doctor APIs

- GET Doctors
- GET Doctor by ID
- POST Doctor

### Patient APIs

- GET Patients
- POST Patient

---

## ⚙️ Technologies Used

- ASP.NET Core
- ASP.NET Core Web API
- C#
- REST API
- HTTP Protocol
- Swagger / OpenAPI
- Visual Studio

---

## 📚 API Features

- RESTful API Design
- JSON Response Handling
- Controller-based Architecture
- Routing
- Dependency Injection
- Swagger Documentation

---

## 🎯 Learning Outcomes

- Understood ASP.NET Core architecture.
- Learned REST API development.
- Created Controllers and API endpoints.
- Implemented GET and POST APIs.
- Tested APIs using Swagger.
- Learned request-response lifecycle.
- Strengthened backend development using ASP.NET Core.

---

---

# 📅 Day 6 – ASP.NET Core MVC & REST Request Handling

## 📖 Topics Covered

- Introduction to ASP.NET Core MVC
- MVC (Model-View-Controller) Architecture
- Model
- View
- Controller
- Routing in ASP.NET Core MVC
- HTTP Request & Response Lifecycle
- REST Request Handling
- Controller Action Methods
- IConfiguration
- View Rendering
- Razor Views (.cshtml)
- Static Files (CSS)
- Project Structure

---

## 🛠️ Practical Implementation

Built a **My Greetings App** using **ASP.NET Core MVC** by following the MVC architecture and implementing request-response handling.

### Tasks Completed

- ✅ Created an ASP.NET Core MVC Project
- ✅ Organized the project using MVC architecture
- ✅ Created Greeting Model
- ✅ Implemented Greetings Controller
- ✅ Created Razor View (Index.cshtml)
- ✅ Used IConfiguration to read greeting messages from appsettings.json
- ✅ Implemented POST request handling using form submission
- ✅ Added Routing between Controller and View
- ✅ Designed a responsive UI using HTML & CSS
- ✅ Displayed greeting message on button click

---

## 🏗️ Project Structure

```text
MyGreetingsApp
│
├── Controllers
│   └── GreetingsController.cs
│
├── Models
│   └── GreetingModel.cs
│
├── Views
│   ├── Greetings
│   │   └── Index.cshtml
│   └── Shared
│
├── wwwroot
│   └── css
│       └── style.css
│
├── Program.cs
├── appsettings.json
└── MyGreetingsApp.csproj
```

---

## ⚙️ Technologies Used

- ASP.NET Core MVC
- C#
- Razor Views (.cshtml)
- HTML5
- CSS3
- IConfiguration
- HTTP Protocol
- Visual Studio

---

## 🌐 Features Implemented

- MVC Project Structure
- Controller-Based Request Handling
- Razor View Rendering
- Model Binding
- Routing
- Form Submission
- Configuration Management using appsettings.json
- Responsive UI
- Static File Handling (CSS)

---

## 🎯 Learning Outcomes

- Understood the MVC (Model-View-Controller) architecture.
- Learned how requests are processed in ASP.NET Core MVC.
- Implemented Controllers, Models, and Razor Views.
- Learned Routing and Action Methods.
- Used IConfiguration to access application settings.
- Built a simple ASP.NET Core MVC application.
- Styled the application using HTML and CSS.
- Strengthened understanding of request-response handling in MVC.

---

---

### 📅 Day 7 — August 10, 2026
**Topic:** ASP.NET Core Minimal API with ADO.NET (Contacts CRUD Application) 🌐

### 📚 What I Learnt

- 🚀 Introduction to ASP.NET Core Minimal APIs and how they differ from MVC.
- ⚡ Understood that Minimal APIs are lightweight and use endpoint mapping instead of Controllers.
- 🗄️ Created a SQL Server database (`ContactsDB`) from scratch.
- 📋 Designed the `Contacts` table with proper data types and constraints.
- 🔤 Learned the difference between `VARCHAR` and `NVARCHAR` and why Unicode support is important.
- 📦 Created a Minimal API project using:

```bash
dotnet new web -n ContactsApp
```

- 📥 Installed required NuGet package:

```bash
dotnet add package Microsoft.Data.SqlClient
```

- 🔗 Connected the application to SQL Server using ADO.NET.
- 🏗️ Implemented the Repository Pattern to separate business logic from database access.
- ⚙️ Configured the database connection using `appsettings.json`.
- 📑 Built complete CRUD functionality for Contacts.
- 🌐 Learned endpoint mapping using:
  - `MapGet()`
  - `MapPost()`
  - `MapPut()`
  - `MapDelete()`
- 🔒 Used parameterized SQL queries to prevent SQL Injection.
- 🧪 Tested API endpoints using browser (GET) and Postman (POST, PUT, DELETE).

---

## 📂 Project Structure

```text
ContactsApp
│
├── Database
│      DbConnectionFactory.cs
│
├── Models
│      Contact.cs
│
├── Repositories
│      IContactRepository.cs
│      ContactRepository.cs
│
├── Program.cs
├── appsettings.json
└── ContactsApp.csproj
```

---

## 🗄️ Database Structure

```text
ContactsDB
│
└── Contacts
      │
      ├── Id
      ├── Name
      ├── Email
      └── Phone
```

---

## 🌐 API Endpoints Implemented

| HTTP Method | Endpoint | Purpose |
|-------------|----------|---------|
| GET | `/contacts` | Retrieve all contacts |
| GET | `/contacts/{id}` | Retrieve contact by Id |
| POST | `/contacts` | Add a new contact |
| PUT | `/contacts/{id}` | Update an existing contact |
| DELETE | `/contacts/{id}` | Delete a contact |

---

## 🏛️ Application Architecture

```text
Client (Browser / Postman)
            │
            ▼
 ASP.NET Core Minimal API
            │
            ▼
 Repository Layer
            │
            ▼
 DbConnectionFactory
            │
            ▼
      SQL Server Database
```

---

## 🔄 CRUD Flow

```text
Request
   │
   ▼
Minimal API Endpoint
   │
   ▼
Repository Method
   │
   ▼
ADO.NET
(SqlConnection, SqlCommand)
   │
   ▼
SQL Server
   │
   ▼
Response
```

---

## 🛠️ Technologies Used

- C#
- ASP.NET Core Minimal API
- SQL Server
- ADO.NET
- Repository Pattern
- Dependency Injection
- REST API
- Postman

---

## 💡 Key Learnings

- Difference between Minimal API and MVC.
- Project setup from scratch.
- Folder organization and clean architecture.
- SQL Server integration using ADO.NET.
- Dependency Injection basics.
- CRUD implementation using REST APIs.
- Repository Pattern implementation.
- Parameterized SQL queries.
- HTTP methods (`GET`, `POST`, `PUT`, `DELETE`).
- API testing using Postman.

---

## 🛠️ Practice Project

**Contacts Management System**

Developed a complete Contacts CRUD application using ASP.NET Core Minimal API, SQL Server, ADO.NET, and the Repository Pattern. The application supports creating, reading, updating, and deleting contact records through RESTful API endpoints while following a clean project structure and separating data access from endpoint logic.



---

# 📅 Day 8 – H2Sharp Database, Distributed Architecture & SQL Server Integration

### 📅 August 11, 2026

**Topic:** H2Sharp Database, Distributed Architecture & SDLC Exposure with Contacts Management Application 🗄️🌐

### 📚 What I Learnt

- 🗄️ Introduction to H2 Database.
- 🔗 Learned about **H2Sharp**, an ADO.NET wrapper for H2 Database.
- ⚙️ Understood how database connectivity can be handled through an ADO.NET-based wrapper.
- 🏗️ Learned the basics of **Distributed Architecture**.
- 🔄 Understood the role of different components/services in a distributed system.
- 🧩 Learned about service separation and communication between distributed components.
- 📋 Got exposure to **Software Development Life Cycle (SDLC)** and its different phases.
- 🔧 Continued development of the **Contacts Management Application**.
- 🗄️ Implemented **Microsoft SQL Server** integration in the Contacts App.
- 🔗 Connected the Contacts App backend with SQL Server.
- 📦 Applied the concepts learned during the daily live sessions to the existing backend project.

---

## 🛠️ Practical Implementation

Continued working on the **Contacts Management Application** and implemented database integration using **Microsoft SQL Server**.

### Tasks Completed

- ✅ Studied H2 Database fundamentals.
- ✅ Learned about the H2Sharp ADO.NET wrapper.
- ✅ Understood database connectivity through H2Sharp.
- ✅ Learned the basics of Distributed Architecture.
- ✅ Got exposure to SDLC concepts and development practices.
- ✅ Continued development of the Contacts Management backend.
- ✅ Integrated Microsoft SQL Server with the Contacts App.
- ✅ Configured SQL Server database connectivity.
- ✅ Applied database concepts to the existing Contacts CRUD application.
- ✅ Continued following a layered project structure with Repository and database-access components.

---

## 🗄️ Database Technologies Studied

### H2 Database

- H2 Database fundamentals
- H2 database connectivity
- H2Sharp
- ADO.NET wrapper concept

### Microsoft SQL Server

- SQL Server database integration
- Database connectivity from .NET
- CRUD operations
- SQL Server configuration
- Backend-to-database communication

---

## 🏗️ Distributed Architecture

Learned the basic concepts of distributed architecture, including:

- Distributed systems
- Service separation
- Communication between components
- Scalability
- Reliability
- Independent service responsibilities
- Backend service architecture

---

## 🔄 SDLC Exposure

Got practical exposure to the major phases of the Software Development Life Cycle:

- Requirement Analysis
- Design
- Development
- Testing
- Deployment
- Maintenance

---

## 🌐 Contacts App – SQL Server Integration

The Contacts Management Application was continued with **Microsoft SQL Server** as the database.

### Application Flow

```text
Client
   │
   ▼
ASP.NET Core Minimal API
   │
   ▼
Repository Layer
   │
   ▼
Database Connection
   │
   ▼
Microsoft SQL Server
   │
   ▼
Contacts Table


```
# 📅 Day 9 – Entity Framework Core, Code First & Database Migrations

### 📅 August 12, 2026

**Topic:** Entity Framework Core, Code First Approach, SQL Server Integration, Repository & Service Architecture, Dependency Injection and Database Migrations 🗄️⚙️

### 📚 What I Learnt

- 🧩 Introduction to **Entity Framework Core (EF Core)**.
- 🗄️ Learned about **Object Relational Mapping (ORM)** and how C# classes are mapped to database tables.
- 📦 Learned how to create **Entities** using C# classes.
- 🔗 Learned about **DbContext** and its role in database communication.
- 📋 Learned about **DbSet** and how it represents a database table.
- 🏗️ Understood the **Code First Approach**.
- 🔄 Learned about **Entity Framework Core Migrations**.
- 🛠️ Learned how to create migrations using:

```bash
dotnet ef migrations add InitialCreate --output-dir Repo/Migrations
```

- 🗄️ Learned how to create and update the database using:

```bash
dotnet ef database update
```

- 📋 Learned how to view existing migrations using:

```bash
dotnet ef migrations list
```

- 🆕 Created a **new SQL Server database using EF Core Migrations** instead of using an existing database.
- 🌐 Continued development of the **Contacts Management Application** using **Entity Framework Core and SQL Server**.
- 📑 Worked with **ASP.NET Core Web API**, Entity Framework Core, SQL Server and Swagger/OpenAPI.
- 🔍 Understood how EF Core generates database tables from C# entities.
- 🏢 Learned about the **Repository Layer** for handling database operations.
- ⚙️ Learned about the **Service Layer** for handling application/business logic.
- 🔌 Learned how to use **Interfaces** for Repository and Service abstraction.
- 💉 Learned about **Dependency Injection (DI)** in ASP.NET Core.
- 📑 Configured the SQL Server connection string using `appsettings.json`.
- 🧪 Tested API operations using **Swagger** and verified the generated database using **SQL Server Management Studio (SSMS)**.

---

## 🛠️ Practical Implementation

Continued working on the **Contacts Management Application** and implemented database interaction using **Entity Framework Core and Microsoft SQL Server**.

### Tasks Completed

- ✅ Studied Entity Framework Core fundamentals.
- ✅ Learned about ORM and object-relational mapping.
- ✅ Created Entity classes using C#.
- ✅ Created `AppDbContext`.
- ✅ Configured Entity Framework Core with SQL Server.
- ✅ Configured the SQL Server connection string in `appsettings.json`.
- ✅ Implemented the Code First approach.
- ✅ Created a new SQL Server database using EF Core Migrations.
- ✅ Generated the initial migration inside the `Repo/Migrations` folder.
- ✅ Applied the migration using `dotnet ef database update`.
- ✅ Created the **Repository Layer** for database operations.
- ✅ Created the **Service Layer** for application/business logic.
- ✅ Created `IContactRepository` and `IContactService` interfaces.
- ✅ Configured **Dependency Injection** for `AppDbContext`, Repository and Service.
- ✅ Connected the Controller → Service → Repository → DbContext architecture.
- ✅ Verified the generated database and tables using SQL Server Management Studio.
- ✅ Practiced modifying entities and creating new migrations.
- ✅ Continued development of the Contacts Management backend using EF Core.
- ✅ Tested API endpoints using Swagger/OpenAPI.

---

## 🗄️ Entity Framework Core

### Entity

An Entity is a C# class that represents a table in the database.

Example:

```csharp
namespace ContactsApp.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
```

### DbContext

`DbContext` is responsible for managing communication between the application and the database.

Example:

```csharp
using ContactsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsApp.Repo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
```

### DbSet

`DbSet` represents a database table.

Example:

```csharp
public DbSet<Contact> Contacts { get; set; }
```

### Code First

In the Code First approach, we create C# entity classes first and Entity Framework Core generates the database structure from those classes.

---

## 🔄 Entity Framework Core Migrations

Migrations are used to track changes in the Entity Framework Core model and apply those changes to the database.

### Create Migration

```bash
dotnet ef migrations add InitialCreate --output-dir Repo/Migrations
```

Creates migration files based on the current Entity Framework Core model and stores them inside the `Repo/Migrations` folder.

### Apply Migration

```bash
dotnet ef database update
```

Creates or updates the SQL Server database and applies the migration.

### View Migrations

```bash
dotnet ef migrations list
```

Displays all migrations available in the project.

---

## 🔄 EF Core Migration Flow

```text
C# Entity
    │
    ▼
AppDbContext
    │
    ▼
EF Core Model
    │
    ▼
Migration
    │
    ▼
Database Update
    │
    ▼
SQL Server Database
```

---

## 🏗️ Repository & Service Architecture

The Contacts Management Application follows a layered architecture:

```text
Client / Swagger
       │
       ▼
ContactController
       │
       ▼
IContactService
       │
       ▼
ContactService
       │
       ▼
IContactRepository
       │
       ▼
ContactRepository
       │
       ▼
AppDbContext
       │
       ▼
Entity Framework Core
       │
       ▼
SQL Server
```

### Controller

The Controller handles HTTP requests and responses.

The application supports:

```text
GET
POST
PUT
DELETE
```

### Service Layer

The Service Layer handles application and business logic.

The Controller communicates with the Service Layer instead of directly accessing the database.

### Repository Layer

The Repository Layer handles database operations.

Examples include:

```text
Get
Add
Update
Delete
```

The Repository communicates with `AppDbContext` to perform database operations.

### Interfaces

Interfaces provide abstraction between the different layers.

The project contains:

```text
Interfaces
│
├── IContactRepository.cs
└── IContactService.cs
```

### Dependency Injection

ASP.NET Core Dependency Injection is used to provide the required dependencies automatically.

Example:

```csharp
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

builder.Services.AddScoped<IContactRepository, ContactRepository>();

builder.Services.AddScoped<IContactService, ContactService>();
```

---

## 🌐 Contacts App – Entity Framework Core

The Contacts Management Application was continued using **ASP.NET Core Web API, Entity Framework Core and Microsoft SQL Server**.

### Application Flow

```text
Client / Swagger / Postman
          │
          ▼
ASP.NET Core Web API
          │
          ▼
ContactController
          │
          ▼
ContactService
          │
          ▼
ContactRepository
          │
          ▼
AppDbContext
          │
          ▼
Entity Framework Core
          │
          ▼
Microsoft SQL Server
          │
          ▼
Contacts Table
```

---

## 🗄️ Database Structure

The Contacts application was implemented using an EF Core Code First database.

```text
ContactsEFDB
│
└── Contacts
      │
      ├── ContactId
      ├── Name
      ├── Email
      ├── Phone
      ├── Address
      ├── City
      └── State
```

---

## 🏗️ Project Structure

```text
ContactsApp
│
├── Controllers
│   └── ContactController.cs
│
├── Interfaces
│   ├── IContactRepository.cs
│   └── IContactService.cs
│
├── Models
│   └── Contact.cs
│
├── Repo
│   ├── AppDbContext.cs
│   ├── ContactRepository.cs
│   │
│   └── Migrations
│       ├── 20260812133326_InitialCreate.cs
│       ├── 20260812133326_InitialCreate.Designer.cs
│       └── AppDbContextModelSnapshot.cs
│
├── Services
│   └── ContactService.cs
│
├── Properties
│
├── appsettings.json
├── appsettings.Development.json
├── Program.cs
├── ContactsApp.http
└── ContactsApp.csproj
```

---

## 🧪 Database Verification

After applying the migration, the generated database can be verified using **SQL Server Management Studio (SSMS)**.

Example:

```sql
USE ContactsEFDB;
GO

SELECT * FROM Contacts;
```

The database and table are generated based on the Entity Framework Core model.

---

## 🔁 Creating a New Migration

When changes are made to the Entity class, a new migration can be created.

For example, if a new property is added:

```csharp
public string Country { get; set; }
```

Create a new migration:

```bash
dotnet ef migrations add AddCountryToContact --output-dir Repo/Migrations
```

Then update the database:

```bash
dotnet ef database update
```

The new change is then applied to the SQL Server database.

---

## 🏗️ Code First Process

```text
Entity Class
     │
     ▼
DbContext
     │
     ▼
Entity Framework Core
     │
     ▼
Migration
     │
     ▼
SQL Server
     │
     ▼
Database + Tables
```

---

## ⚙️ Technologies Used

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Code First
- EF Core Migrations
- Repository Pattern
- Service Layer
- Interfaces
- Dependency Injection
- Swagger / OpenAPI
- Visual Studio Code
- SQL Server Management Studio (SSMS)

---

## 💡 Key Learnings

- Difference between **ADO.NET and Entity Framework Core**.
- Understanding **ORM** and object-relational mapping.
- Creating database tables using C# entities.
- Understanding `DbContext` and `DbSet`.
- Understanding the **Code First Approach**.
- Creating databases using **EF Core Migrations**.
- Applying database changes using migrations.
- Connecting ASP.NET Core applications with SQL Server using EF Core.
- Understanding the **Repository Pattern**.
- Understanding the **Service Layer**.
- Understanding the purpose of **Interfaces**.
- Understanding **Dependency Injection** in ASP.NET Core.
- Understanding how EF Core maps entities to database tables.
- Organizing database-related code inside the `Repo` layer.
- Organizing migrations inside the `Repo/Migrations` folder.
- Verifying generated databases and tables using SQL Server Management Studio.
- Testing APIs using Swagger/OpenAPI.

---

## 🎯 Learning Outcomes

- Understood the fundamentals of **Entity Framework Core**.
- Learned how C# entities are mapped to database tables.
- Learned how `DbContext` manages database communication.
- Learned the purpose of `DbSet`.
- Implemented the **Code First Approach**.
- Created and applied EF Core migrations.
- Created a new SQL Server database using migrations.
- Learned how to modify entities and create new migrations.
- Implemented a **Repository Layer** for database operations.
- Implemented a **Service Layer** for application/business logic.
- Used **Interfaces** for abstraction.
- Implemented **Dependency Injection** in ASP.NET Core.
- Integrated EF Core with ASP.NET Core Web API.
- Continued development of the Contacts Management Application using EF Core and SQL Server.
- Strengthened understanding of modern .NET database access techniques.

---

## 🛠️ Practice Project

**Contacts Management System**

Continued the Contacts Management Application using **ASP.NET Core Web API, Entity Framework Core and SQL Server**. Implemented database interaction using `AppDbContext` and `DbSet`, created the database using the Code First approach, managed database changes using EF Core Migrations, and structured the application using **Controller, Service and Repository layers with Dependency Injection**.

---

# 📅 Day 10 – Entity Framework Core, ORM, SQL Server, Repository Pattern, Business Layer, DTOs, Migrations & CRUD Operations

### 📅 August 13, 2026

**Topic:** Entity Framework Core, ORM, SQL Server, Repository Pattern, Business Layer, DTOs, Dependency Injection, EF Core Migrations, CRUD Operations and Swagger 📚🗄️⚙️

---

## 📚 What I Learnt

Today I continued working with **Entity Framework Core** and built an **Address Book application** using ASP.NET Core Web API and SQL Server.

The main concepts learned today were:

- 🧩 Entity Framework Core
- 🔄 Object Relational Mapping (ORM)
- 🗄️ SQL Server
- 🏗️ Layered Architecture
- 📦 Repository Pattern
- 💼 Business Layer
- 🔌 Interfaces
- 💉 Dependency Injection
- 📑 DTOs (Data Transfer Objects)
- 🔄 Entity Framework Core Migrations
- 🔁 CRUD Operations
- 🌐 ASP.NET Core Web API
- 🧪 Swagger / OpenAPI
- 🛠️ Code First Approach
- 🗂️ Project and layer separation

---

# 1. 🏗️ Layered Architecture

The Address Book application follows a layered architecture where different responsibilities are separated into different projects.

The project structure is:

```text
AddressBook
│
├── AddressBook
│   └── Controllers
│       └── ContactController.cs
│
├── BusinessLayer
│   ├── Interface
│   │   └── IContactBusiness.cs
│   │
│   └── Service
│       └── ContactBusiness.cs
│
├── ModelLayer
│   └── Entities
│       └── Contact.cs
│
└── RepositoryLayer
    ├── Context
    │   └── AppDbContext.cs
    │
    ├── Interface
    │   └── IContactRepository.cs
    │
    ├── Service
    │   └── ContactRepository.cs
    │
    └── Migration
        ├── InitialCreate.cs
        ├── InitialCreate.Designer.cs
        └── AppDbContextModelSnapshot.cs

Each layer has a specific responsibility.

```text
Client / Swagger
       │
       ▼
ContactController
       │
       ▼
IContactBusiness
       │
       ▼
ContactBusiness
       │
       ▼
IContactRepository
       │
       ▼
ContactRepository
       │
       ▼
AppDbContext
       │
       ▼
Entity Framework Core
       │
       ▼
SQL Server
```

## 2. 🧩 Entity Framework Core
Learned how to use Entity Framework Core (EF Core) with ASP.NET Core Web API and SQL Server.

Entity Framework Core is an Object Relational Mapper (ORM) that allows applications to work with databases using C# objects and classes.

EF Core is used to:

Connect the application with SQL Server
Map C# classes to database tables
Perform CRUD operations
Track changes in entities
Save changes to the database
Create and manage database migrations

---
````markdown
# 📅 Day 12 – Fundoo Notes App – User Management Module

### 📚 What I Learnt

Today I started developing the **Fundoo Notes App** and implemented the **User Management Module** using ASP.NET Core Web API with a layered architecture.

The main concepts learned and implemented were:

- 👤 User Management
- 📝 User Registration
- 🔐 User Login
- 🔑 Password Encryption
- 📧 Password Recovery
- 🔄 Password Reset
- 📦 DTOs (Data Transfer Objects)
- 🧩 Entity Classes
- 🏗️ Layered Architecture
- 📁 API Layer
- 💼 Business Layer
- 🗄️ Repository Layer
- 🔌 Interfaces
- ⚠️ Custom Exceptions
- 💉 Dependency Injection
- 🗄️ Entity Framework Core
- 🗃️ SQL Server
- 🔄 EF Core Migrations
- 🧪 Swagger / OpenAPI
- 🔐 Authentication groundwork

---

## 🛠️ Practical Implementation

Developed the initial **Fundoo Notes App** backend and implemented the **User Management Module** using ASP.NET Core Web API.

The application follows a layered architecture:

```text
API Layer
    ↓
Business Layer
    ↓
Repository Layer
    ↓
Entity Framework Core
    ↓
SQL Server
````

### Tasks Completed

* ✅ Created the Fundoo Notes App solution.
* ✅ Created separate projects for API, Business Layer, Model Layer and Repository Layer.
* ✅ Created `UserController`.
* ✅ Created `UserEntity` for representing the user data.
* ✅ Created Request DTOs for registration, login and password recovery.
* ✅ Created Response DTO.
* ✅ Created Business Layer interface `IUserBL`.
* ✅ Created Business Layer service `UserBL`.
* ✅ Created Repository Layer interface `IUserRL`.
* ✅ Created Repository Layer service `UserRL`.
* ✅ Created `FundooContext` for Entity Framework Core database communication.
* ✅ Added EF Core Migrations.
* ✅ Added custom exceptions for user-related errors.
* ✅ Created password encryption helper.
* ✅ Created JWT token helper as groundwork for authentication.
* ✅ Structured the application using separation of responsibilities.

---

# 👤 User Management Module

The User Management Module is responsible for handling user-related operations.

### Main User Operations

```text
User Management
│
├── Registration
├── Login
├── Forgot Password
└── Reset Password
```

---

## 📝 User Registration

The registration functionality is used to create a new user account.

The registration flow follows:

```text
Client
   │
   ▼
UserController
   │
   ▼
UserBL
   │
   ▼
UserRL
   │
   ▼
FundooContext
   │
   ▼
SQL Server
```

During registration, user information is received through a DTO and processed through the Business and Repository layers.

---

## 🔐 User Login

The login functionality allows an existing user to authenticate using their credentials.

The basic flow is:

```text
Client
   │
   ▼
Login Request
   │
   ▼
UserController
   │
   ▼
UserBL
   │
   ▼
UserRL
   │
   ▼
Database
   │
   ▼
Login Response
```

The project also contains authentication-related helper classes that provide groundwork for token-based authentication.

---

## 🔑 Password Encryption

A separate helper class named:

```text
PasswordEncryption.cs
```

was created inside the Business Layer.

The purpose of password encryption is to avoid handling user passwords directly in plain text and to provide a dedicated place for password-related processing.

---

## 📧 Forgot Password

The application contains a DTO for handling forgot password requests:

```text
ForgotPasswordDTO.cs
```

The forgot password functionality provides the groundwork for recovering access to an existing account.

---

## 🔄 Reset Password

The application also contains:

```text
ResetPasswordDTO.cs
```

This DTO is used for handling password reset information.

The basic flow is:

```text
User
 │
 ▼
Forgot Password
 │
 ▼
Password Recovery
 │
 ▼
Reset Password
 │
 ▼
Updated Password
```

---

# 📦 DTOs – Data Transfer Objects

DTOs are used to transfer data between the client and application layers.

The Fundoo Notes App contains separate DTOs for different user operations.

### Request DTOs

```text
RequestDTO
│
├── ForgotPasswordDTO.cs
├── LoginDTO.cs
├── RegistrationDTO.cs
└── ResetPasswordDTO.cs
```

### Purpose of DTOs

* Separate API request data from database entities.
* Define the required input for each operation.
* Avoid directly exposing database entities through API requests.
* Keep request models organized according to their purpose.

---

# 🧩 User Entity

The application contains:

```text
Entities
└── UserEntity.cs
```

`UserEntity` represents the user information that is stored in the database.

The Entity Framework Core model is responsible for mapping the entity to the corresponding database structure.

---

# 📤 Response DTO

The project contains:

```text
ResponseDTO
└── ResponseDTO.cs
```

The Response DTO is used to provide a structured response from the application to the client.

This helps maintain a consistent API response structure.

---

# ⚠️ Custom Exceptions

Custom exceptions were created to handle common user-related errors.

```text
Exceptions
│
├── InvalidCredentialsException.cs
├── UserAlreadyExistsException.cs
└── UserNotFoundException.cs
```

### InvalidCredentialsException

Used when the provided login credentials are invalid.

### UserAlreadyExistsException

Used when an attempt is made to register a user that already exists.

### UserNotFoundException

Used when the requested user cannot be found.

---

# 🔐 Authentication Helpers

The Business Layer contains helper classes related to authentication and password handling.

```text
Helpers
│
├── JwtTokenHelper.cs
└── PasswordEncryption.cs
```

### JwtTokenHelper

`JwtTokenHelper.cs` provides the groundwork for generating and working with JWT-based authentication tokens.

JWT stands for:

```text
JSON Web Token
```

It is commonly used for stateless authentication in Web APIs.

### PasswordEncryption

`PasswordEncryption.cs` is responsible for password-related encryption or hashing logic.

Keeping this functionality inside a helper class keeps password processing separate from the main business logic.

---

# 🏗️ Layered Architecture

The Fundoo Notes App follows a layered architecture.

```text
Client / Swagger / Postman
          │
          ▼
   FundooNotesApp.API
          │
          ▼
   Business Layer
          │
          ▼
  Repository Layer
          │
          ▼
 Entity Framework Core
          │
          ▼
      SQL Server
```

Each layer has a specific responsibility.

---

## 🌐 API Layer

The API layer handles HTTP requests and responses.

The project contains:

```text
FundooNotesApp.API
│
├── Controllers
│   └── UserController.cs
│
├── Program.cs
├── appsettings.json
└── appsettings.Development.json
```

### UserController

`UserController.cs` acts as the entry point for user-related API requests.

The controller communicates with the Business Layer instead of directly communicating with the database.

---

# 💼 Business Layer

The Business Layer contains application and business logic.

```text
FundooNotesApp.BusinessLayer
│
├── Helpers
│   ├── JwtTokenHelper.cs
│   └── PasswordEncryption.cs
│
├── Interfaces
│   └── IUserBL.cs
│
└── Services
    └── UserBL.cs
```

### IUserBL

`IUserBL` defines the contract for user-related business operations.

### UserBL

`UserBL` contains the business logic for user management operations.

The Business Layer communicates with the Repository Layer through its interface.

---

# 🗄️ Repository Layer

The Repository Layer handles database-related operations.

```text
FundooNotesApp.RepositoryLayer
│
├── Context
│   └── FundooContext.cs
│
├── Interfaces
│   └── IUserRL.cs
│
├── Migrations
│
└── Services
    └── UserRL.cs
```

### FundooContext

`FundooContext.cs` is the Entity Framework Core `DbContext`.

It manages communication between the application and SQL Server.

### IUserRL

`IUserRL` defines the contract for repository-level user operations.

### UserRL

`UserRL` implements the repository operations and communicates with `FundooContext`.

---

# 🔄 Application Flow

The user management request flows through the layers as follows:

```text
Client
  │
  ▼
UserController
  │
  ▼
IUserBL
  │
  ▼
UserBL
  │
  ▼
IUserRL
  │
  ▼
UserRL
  │
  ▼
FundooContext
  │
  ▼
Entity Framework Core
  │
  ▼
SQL Server
  │
  ▼
Response
```

This separation makes the application easier to maintain and organize.

---

# 📂 Model Layer

The Model Layer contains entities and DTOs used by the application.

```text
FundooNotesApp.ModelLayer
│
├── DTOs
│   │
│   ├── RequestDTO
│   │   ├── ForgotPasswordDTO.cs
│   │   ├── LoginDTO.cs
│   │   ├── RegistrationDTO.cs
│   │   └── ResetPasswordDTO.cs
│   │
│   └── ResponseDTO
│       └── ResponseDTO.cs
│
├── Entities
│   └── UserEntity.cs
│
├── Exceptions
│   ├── InvalidCredentialsException.cs
│   ├── UserAlreadyExistsException.cs
│   └── UserNotFoundException.cs
│
└── Models
    └── UserModel.cs
```

---

# 🗃️ Entity Framework Core

The Fundoo Notes App uses Entity Framework Core for database interaction.

EF Core acts as an Object Relational Mapper (ORM).

It allows the application to work with SQL Server using C# classes and objects.

EF Core is used for:

* Mapping C# entities to database tables.
* Managing database communication.
* Performing CRUD operations.
* Tracking entity changes.
* Managing database migrations.

---

# 🔄 Database Migrations

The Repository Layer contains the EF Core migration files.

```text
FundooNotesApp.RepositoryLayer
│
└── Migrations
```

Migrations allow database changes to be tracked and applied through Entity Framework Core.

The basic migration flow is:

```text
UserEntity
    │
    ▼
FundooContext
    │
    ▼
EF Core Model
    │
    ▼
Migration
    │
    ▼
SQL Server
```

---

# 💉 Dependency Injection

Dependency Injection is used to connect the different layers of the application.

The application can register:

```text
FundooContext
IUserBL → UserBL
IUserRL → UserRL
```

This allows the Controller to receive the required Business Layer dependency without creating the objects manually.

---

# 🌐 API Layer Responsibility

The API Layer is responsible for:

* Receiving HTTP requests.
* Validating request models.
* Calling the Business Layer.
* Returning HTTP responses.
* Exposing user-related endpoints.

The controller should not directly contain database logic.

---

# 💼 Business Layer Responsibility

The Business Layer is responsible for:

* Application logic.
* User-related business rules.
* Password processing.
* Authentication-related processing.
* Calling the Repository Layer.
* Handling user-related operations.

---

# 🗄️ Repository Layer Responsibility

The Repository Layer is responsible for:

* Database operations.
* Communicating with `FundooContext`.
* Working with Entity Framework Core.
* Retrieving user information.
* Adding and updating user information.

---

# 🧪 API Testing

The Fundoo Notes App API can be tested using:

```text
Swagger / OpenAPI
Postman
```

Swagger helps to view and test the available API endpoints during development.

---

# 🎯 Learning Outcomes – Day 12

* ✅ Understood layered architecture in ASP.NET Core Web API.
* ✅ Learned how to structure a multi-project backend application.
* ✅ Implemented the User Management Module.
* ✅ Learned user registration and login concepts.
* ✅ Learned about password encryption.
* ✅ Learned about password recovery and reset DTOs.
* ✅ Learned how to create Request DTOs and Response DTOs.
* ✅ Learned how to create custom exceptions.
* ✅ Understood the purpose of the Business Layer.
* ✅ Understood the purpose of the Repository Layer.
* ✅ Learned the purpose of interfaces.
* ✅ Learned how `DbContext` communicates with the database.
* ✅ Created authentication-related helper classes.
* ✅ Created JWT token helper groundwork.
* ✅ Continued working with Entity Framework Core and SQL Server.
* ✅ Strengthened understanding of backend project architecture.

---

# 🛠️ Practice Project

## **Fundoo Notes App**

Developed the initial **Fundoo Notes App backend** using ASP.NET Core Web API and Entity Framework Core.

The User Management Module provides the foundation for:

```text
Registration
      │
      ▼
   Login
      │
      ▼
Authentication
      │
      ▼
Password Recovery
      │
      ▼
Password Reset
```

The application follows a layered architecture with separate API, Business, Model and Repository layers.

---

# 📅 Day 13 – Fundoo Notes App – Authentication & Authorization

### 📚 What I Learnt

Today I continued working on the **Fundoo Notes App** and started the groundwork for the **Authentication and Authorization Module**.

The main concepts covered were:

* 🔐 Authentication
* 🛡️ Authorization
* 🎫 JWT Authentication
* 🔑 Password Encryption
* 👤 User Identity
* 🔒 Securing APIs
* 🧩 Authentication Helpers
* 🏗️ Layered Architecture
* 💼 Business Layer
* 🗄️ Repository Layer
* 🔌 Interfaces
* 💉 Dependency Injection
* 📦 DTO-based request handling
* ⚠️ Custom Exceptions
* 🌐 ASP.NET Core Web API

---

## 🔐 Authentication

Authentication is the process of verifying the identity of a user.

In the Fundoo Notes App, authentication is connected with the user login functionality.

The basic flow is:

```text
User
 │
 ▼
Login
 │
 ▼
Validate Credentials
 │
 ▼
Authentication
 │
 ▼
JWT Token
```

The project contains a JWT helper:

```text
Helpers
└── JwtTokenHelper.cs
```

This provides the groundwork for token-based authentication.

---

# 🛡️ Authorization

Authorization determines whether an authenticated user is allowed to access a particular resource or perform a particular operation.

The basic concept is:

```text
Authentication
      │
      ▼
Who are you?
      │
      ▼
Authorization
      │
      ▼
What are you allowed to access?
```

The Fundoo Notes App is being structured to support authenticated and authorized API operations.

---

# 🎫 JWT Authentication

JWT stands for:

```text
JSON Web Token
```

JWT can be used to represent the authenticated user after successful login.

The basic authentication flow is:

```text
Client
  │
  ▼
Login Request
  │
  ▼
UserController
  │
  ▼
UserBL
  │
  ▼
Validate User
  │
  ▼
Generate JWT
  │
  ▼
Return Token
```

For subsequent protected requests, the client can send the token with the request.

```text
Client
  │
  │  JWT Token
  ▼
Protected API
  │
  ▼
Authentication
  │
  ▼
Authorization
  │
  ▼
Resource
```

---

# 🔑 Password Security

The project contains:

```text
PasswordEncryption.cs
```

Password-related processing is separated into a helper class.

This keeps password processing separate from the Controller, Business Layer and Repository Layer.

The overall concept is:

```text
User Password
     │
     ▼
Password Processing
     │
     ▼
Secure Password Representation
     │
     ▼
Database
```

---

# 🧩 Authentication Helpers

The Business Layer contains authentication-related helpers:

```text
Helpers
│
├── JwtTokenHelper.cs
└── PasswordEncryption.cs
```

### JwtTokenHelper

Responsible for JWT-related authentication groundwork.

### PasswordEncryption

Responsible for password-related processing.

Keeping these responsibilities inside helper classes makes the Business Layer more organized.

---

# 🏗️ Authentication Architecture

The authentication-related request follows the layered architecture:

```text
Client
  │
  ▼
UserController
  │
  ▼
IUserBL
  │
  ▼
UserBL
  │
  ├──────────────► JwtTokenHelper
  │
  ├──────────────► PasswordEncryption
  │
  ▼
IUserRL
  │
  ▼
UserRL
  │
  ▼
FundooContext
  │
  ▼
Entity Framework Core
  │
  ▼
SQL Server
```

---

# 📂 Fundoo Notes App Project Structure

The Fundoo Notes App is organized into separate projects.

```text
Day-12
│
└── FundooNotesApp
    │
    ├── FundooNotesApp.API
    │   │
    │   ├── Controllers
    │   │   └── UserController.cs
    │   │
    │   ├── Properties
    │   │
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   ├── FundooNotesApp.API.csproj
    │   ├── FundooNotesApp.API.http
    │   └── Program.cs
    │
    ├── FundooNotesApp.BusinessLayer
    │   │
    │   ├── Helpers
    │   │   ├── JwtTokenHelper.cs
    │   │   └── PasswordEncryption.cs
    │   │
    │   ├── Interfaces
    │   │   └── IUserBL.cs
    │   │
    │   └── Services
    │       └── UserBL.cs
    │
    ├── FundooNotesApp.ModelLayer
    │   │
    │   ├── DTOs
    │   │   │
    │   │   ├── RequestDTO
    │   │   │   ├── ForgotPasswordDTO.cs
    │   │   │   ├── LoginDTO.cs
    │   │   │   ├── RegistrationDTO.cs
    │   │   │   └── ResetPasswordDTO.cs
    │   │   │
    │   │   └── ResponseDTO
    │   │       └── ResponseDTO.cs
    │   │
    │   ├── Entities
    │   │   └── UserEntity.cs
    │   │
    │   ├── Exceptions
    │   │   ├── InvalidCredentialsException.cs
    │   │   ├── UserAlreadyExistsException.cs
    │   │   └── UserNotFoundException.cs
    │   │
    │   └── Models
    │       └── UserModel.cs
    │
    ├── FundooNotesApp.RepositoryLayer
    │   │
    │   ├── Context
    │   │   └── FundooContext.cs
    │   │
    │   ├── Interfaces
    │   │   └── IUserRL.cs
    │   │
    │   ├── Migrations
    │   │
    │   └── Services
    │       └── UserRL.cs
    │
    └── FundooNotesApp.slnx
```

---

# 🔄 Authentication Request Flow

The authentication request moves through the application layers:

```text
Client
  │
  ▼
UserController
  │
  ▼
Business Layer
  │
  ▼
Password Validation
  │
  ▼
Repository Layer
  │
  ▼
FundooContext
  │
  ▼
SQL Server
  │
  ▼
User Validation
  │
  ▼
JWT Token Helper
  │
  ▼
JWT Token
  │
  ▼
Client
```

---

# 🔒 Authentication vs Authorization

| Authentication         | Authorization                                       |
| ---------------------- | --------------------------------------------------- |
| Verifies user identity | Determines user permissions                         |
| Answers "Who are you?" | Answers "What can you access?"                      |
| Happens during login   | Happens when accessing protected resources          |
| Can use JWT tokens     | Can use authenticated user information and policies |
| Identity verification  | Access control                                      |

---

# 📦 DTOs Used for Authentication

The authentication and user management module contains:

```text
RequestDTO
│
├── LoginDTO.cs
├── RegistrationDTO.cs
├── ForgotPasswordDTO.cs
└── ResetPasswordDTO.cs
```

### LoginDTO

Used for receiving login information.

### RegistrationDTO

Used for receiving registration information.

### ForgotPasswordDTO

Used for receiving forgot-password information.

### ResetPasswordDTO

Used for receiving reset-password information.

---

# ⚠️ Exception Handling

The application contains custom exceptions related to user authentication and management.

```text
Exceptions
│
├── InvalidCredentialsException.cs
├── UserAlreadyExistsException.cs
└── UserNotFoundException.cs
```

These exceptions help represent specific user-related error conditions.

---

# 🧱 Separation of Responsibilities

The project separates responsibilities across different layers.

```text
API Layer
    │
    └── Handles HTTP Requests/Responses

Business Layer
    │
    └── Handles Application Logic

Model Layer
    │
    └── Contains Entities, DTOs and Exceptions

Repository Layer
    │
    └── Handles Database Operations
```

This structure makes the application easier to maintain and extend.

---

# 🌐 Authentication Module Flow

```text
                 Fundoo Notes App
                        │
                        ▼
                 User Login
                        │
                        ▼
              Validate Credentials
                        │
                        ▼
              Password Processing
                        │
                        ▼
                User Validation
                        │
                        ▼
                 JWT Generation
                        │
                        ▼
                  JWT Token
                        │
                        ▼
             Authenticated Request
                        │
                        ▼
                  Authorization
                        │
                        ▼
              Protected Resource
```

---

# 🛠️ Technologies Used

* C#
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT
* REST API
* DTOs
* Repository Pattern
* Business Layer
* Interfaces
* Dependency Injection
* Swagger / OpenAPI
* Visual Studio Code
* Git & GitHub

---

# 💡 Key Learnings

* 🔐 Difference between Authentication and Authorization.
* 🎫 Basic concept of JWT-based authentication.
* 🔑 Importance of password security.
* 🧩 Purpose of `JwtTokenHelper`.
* 🔐 Purpose of `PasswordEncryption`.
* 👤 User login and registration flow.
* 📦 Importance of DTOs.
* 🏗️ Layered architecture in ASP.NET Core.
* 💼 Role of the Business Layer.
* 🗄️ Role of the Repository Layer.
* 🔌 Importance of interfaces.
* ⚠️ Custom exception handling.
* 💉 Dependency Injection.
* 🗃️ Entity Framework Core database communication.
* 🌐 Authentication groundwork for REST APIs.

---

# 🎯 Learning Outcomes – Day 13

* ✅ Understood the difference between Authentication and Authorization.
* ✅ Learned the basic JWT authentication flow.
* ✅ Created JWT authentication helper groundwork.
* ✅ Created password encryption helper.
* ✅ Understood the role of authentication in a Web API.
* ✅ Understood how authentication and authorization fit into a layered architecture.
* ✅ Learned how login can be connected with token-based authentication.
* ✅ Strengthened understanding of secure user management.
* ✅ Continued development of the Fundoo Notes App.
* ✅ Improved understanding of API security concepts.
* ✅ Practiced separation of concerns using API, Business, Model and Repository layers.

---

# 🛠️ Practice Project

## **Fundoo Notes App**

Continued development of the **Fundoo Notes App** with the User Management and Authentication modules.

The application currently provides the groundwork for:

```text
User Registration
       │
       ▼
   User Login
       │
       ▼
 Password Security
       │
       ▼
 Authentication
       │
       ▼
 JWT Token
       │
       ▼
 Authorization
       │
       ▼
 Protected APIs
```

The project follows a layered architecture:

```text
FundooNotesApp.API
        │
        ▼
FundooNotesApp.BusinessLayer
        │
        ▼
FundooNotesApp.ModelLayer
        │
        ▼
FundooNotesApp.RepositoryLayer
        │
        ▼
   SQL Server
   ```

---
# 🎯 Overall Learning Journey

```text
Database Fundamentals
        │
        ▼
SQL & Database Design
        │
        ▼
ADO.NET
        │
        ▼
ASP.NET Core Web API
        │
        ▼
Minimal APIs
        │
        ▼
Entity Framework Core
        │
        ▼
Repository & Business Layers
        │
        ▼
DTOs & Dependency Injection
        │
        ▼
Fundoo Notes App
        │
        ▼
User Management
        │
        ▼
Authentication
        │
        ▼
Authorization
        │
        ▼
.NET Backend Development
```

## 🚀 Current Learning Progress

```text
Day 1  → DBMS & RDBMS
Day 2  → ER Diagram, Normalization & Indexing
Day 3  → SQL Joins, Stored Procedures & Triggers
Day 4  → ADO.NET & Health Clinic Application
Day 5  → ASP.NET Core Web API & REST APIs
Day 6  → ASP.NET Core MVC
Day 7  → Minimal APIs & ADO.NET
Day 8  → H2Sharp, Distributed Architecture & SQL Server
Day 9  → Entity Framework Core & Migrations
Day 10 → Repository, Business Layer & DTOs
Day 12 → Fundoo Notes App – User Management
Day 13 → Authentication & Authorization Groundwork
```

---

---

# 📂 Repository Structure – Updated

```text
BridgeLabz-Backend-Refresher
│
├── Day1
│   └── database.sql
│
├── Day2
│   ├── database.sql
│   └── ER_Diagram.png
│
├── Day3
│   └── database.sql
│
├── Day4
│   ├── HealthClinicApp
│   ├── Entities
│   ├── Interfaces
│   ├── Services
│   ├── Exceptions
│   └── Program.cs
│
├── Day5
│   └── ContactsApp
│       ├── ContactsApp.API
│       ├── ContactsApp.Models
│       ├── ContactsApp.Repository
│       ├── ContactsApp.Service
│       └── ContactsApp.slnx
│
├── Day6
│   └── MyGreetingsApp
│       ├── Controllers
│       │   └── GreetingsController.cs
│       ├── Models
│       │   └── GreetingModel.cs
│       ├── Views
│       │   ├── Greetings
│       │   │   └── Index.cshtml
│       │   └── Shared
│       ├── wwwroot
│       │   └── css
│       │       └── style.css
│       ├── Program.cs
│       ├── appsettings.json
│       └── MyGreetingsApp.csproj
│
├── Day7
│   └── ContactsApp
│       ├── Database
│       │   └── DbConnection.cs
│       ├── Models
│       │   └── Contact.cs
│       ├── Repositories
│       │   ├── IContactRepository.cs
│       │   └── ContactRepository.cs
│       ├── Program.cs
│       ├── appsettings.json
│       └── ContactsApp.csproj
│
├── Day8
│   └── ContactsApp
│       ├── Database
│       │   └── DbConnection.cs
│       ├── Models
│       │   └── Contact.cs
│       ├── Repositories
│       │   ├── IContactRepository.cs
│       │   └── ContactRepository.cs
│       ├── Program.cs
│       ├── appsettings.json
│       └── ContactsApp.csproj
│
├── Day9
│   └── ContactsApp
│       ├── Controllers
│       │   └── ContactController.cs
│       ├── Interfaces
│       │   ├── IContactRepository.cs
│       │   └── IContactService.cs
│       ├── Models
│       │   └── Contact.cs
│       ├── Repo
│       │   ├── AppDbContext.cs
│       │   ├── ContactRepository.cs
│       │   └── Migrations
│       ├── Services
│       │   └── ContactService.cs
│       ├── Program.cs
│       ├── appsettings.json
│       ├── appsettings.Development.json
│       ├── ContactsApp.http
│       └── ContactsApp.csproj
│
├── Day10
│   └── AddressBook
│       ├── AddressBook
│       │   └── Controllers
│       │       └── ContactController.cs
│       ├── BusinessLayer
│       │   ├── Interface
│       │   │   └── IContactBusiness.cs
│       │   └── Service
│       │       └── ContactBusiness.cs
│       ├── ModelLayer
│       │   └── Entities
│       │       └── Contact.cs
│       └── RepositoryLayer
│           ├── Context
│           │   └── AppDbContext.cs
│           ├── Interface
│           │   └── IContactRepository.cs
│           ├── Service
│           │   └── ContactRepository.cs
│           └── Migration
│
├── Day12
│   └── FundooNotesApp
│       ├── FundooNotesApp.API
│       │   ├── Controllers
│       │   │   └── UserController.cs
│       │   ├── Properties
│       │   ├── appsettings.Development.json
│       │   ├── appsettings.json
│       │   ├── FundooNotesApp.API.csproj
│       │   ├── FundooNotesApp.API.http
│       │   └── Program.cs
│       │
│       ├── FundooNotesApp.BusinessLayer
│       │   ├── Helpers
│       │   │   ├── JwtTokenHelper.cs
│       │   │   └── PasswordEncryption.cs
│       │   ├── Interfaces
│       │   │   └── IUserBL.cs
│       │   └── Services
│       │       └── UserBL.cs
│       │
│       ├── FundooNotesApp.ModelLayer
│       │   ├── DTOs
│       │   │   ├── RequestDTO
│       │   │   │   ├── ForgotPasswordDTO.cs
│       │   │   │   ├── LoginDTO.cs
│       │   │   │   ├── RegistrationDTO.cs
│       │   │   │   └── ResetPasswordDTO.cs
│       │   │   └── ResponseDTO
│       │   │       └── ResponseDTO.cs
│       │   ├── Entities
│       │   │   └── UserEntity.cs
│       │   ├── Exceptions
│       │   │   ├── InvalidCredentialsException.cs
│       │   │   ├── UserAlreadyExistsException.cs
│       │   │   └── UserNotFoundException.cs
│       │   └── Models
│       │       └── UserModel.cs
│       │
│       ├── FundooNotesApp.RepositoryLayer
│       │   ├── Context
│       │   │   └── FundooContext.cs
│       │   ├── Interfaces
│       │   │   └── IUserRL.cs
│       │   ├── Migrations
│       │   └── Services
│       │       └── UserRL.cs
│       │
│       └── FundooNotesApp.slnx
│
├── Day13
│   └── FundooNotesApp
│       └── Authentication & Authorization groundwork
│
└── README.md

```

---

---

# 🌟 About This Repository

This repository serves as a comprehensive record of my **BridgeLabz Backend Refresher Training (.NET)**.

It documents my day-wise learning through hands-on implementations using:

* Microsoft SQL Server
* SQL
* ADO.NET
* ASP.NET Core
* ASP.NET Core MVC
* ASP.NET Core Minimal APIs
* Entity Framework Core
* REST APIs
* Repository Pattern
* Service / Business Layer
* DTOs
* Dependency Injection
* JWT Authentication
* Authentication & Authorization
* Swagger / OpenAPI

Each module builds upon the previous one and helps strengthen my understanding of **.NET Backend Development**, database integration, layered architecture, RESTful API development and backend application security.
---


---
