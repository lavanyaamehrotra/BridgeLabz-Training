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
---



# 📂 Repository Structure

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
│       ├── ContactsApp.csproj
│
└── README.md
```

---

# 🌟 About This Repository

This repository serves as a comprehensive record of my **BridgeLabz Backend Refresher Training (.NET)**. It showcases my day-wise learning through hands-on implementations using **Microsoft SQL Server**, **ADO.NET**, **ASP.NET Core Web API**, and **ASP.NET Core MVC**. The repository covers database design, SQL programming, query optimization, joins, stored procedures, triggers, connected database programming, CRUD operations, RESTful API development, MVC architecture, routing, Razor Views, and request-response handling. Each module builds upon the previous one, helping me develop a strong foundation in **.NET Backend Development** while following industry-standard software development practices.

---

## ⭐ If you found this repository helpful, consider giving it a Star!