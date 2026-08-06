# 🚀 BridgeLabz Backend Refresher Training (.NET)

> A structured learning journey covering **DBMS, SQL Server, Database Design, ER Modeling, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers, ADO.NET, ASP.NET Core, and Backend Development**.

This repository documents my day-wise progress throughout the **BridgeLabz Backend Refresher Training**. Each module includes theoretical concepts, practical implementations, database design exercises, assignments, query optimization techniques, hands-on SQL Server development, ADO.NET programming, and ASP.NET Core Web API development to strengthen backend development skills using the .NET ecosystem.

---

# 📚 Tech Stack

| Category | Technologies |
|----------|--------------|
| 💻 Database | Microsoft SQL Server |
| 🗄️ Query Language | SQL (T-SQL) |
| 💻 Programming Language | C# |
| 🌐 Backend Framework | ASP.NET Core |
| 🔗 Data Access | ADO.NET |
| 🛠️ IDE | Visual Studio, SQL Server Management Studio (SSMS) |
| 🔧 Version Control | Git & GitHub |
| 📐 Concepts | DBMS, RDBMS, ER Diagram, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers, ADO.NET, REST APIs |
| 🎯 Domain | Backend Development (.NET) |

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

# 📂 Repository Structure

```text
BridgeLabz-Backend-Refresher
│
├── Day1
│   ├── database.sql
│
├── Day2
│   ├── database.sql
│   ├── ER_Diagram.png
│
├── Day3
│   ├── database.sql
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
└── README.md
```

---

# 🌟 About This Repository

This repository serves as a comprehensive record of my **BridgeLabz Backend Refresher Training (.NET)**. It showcases my day-wise learning through hands-on implementations in **Microsoft SQL Server**, **ADO.NET**, and **ASP.NET Core Web API**. The repository covers database design, SQL programming, query optimization, joins, stored procedures, triggers, connected database programming, CRUD operations, and RESTful API development. Each module builds upon the previous one, helping me develop a strong foundation in **.NET Backend Development** while following industry-standard software development practices.

---

## ⭐ If you found this repository helpful, consider giving it a Star!