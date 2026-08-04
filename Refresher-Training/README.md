# 🚀 BridgeLabz Backend Refresher Training (.NET)

> A structured learning journey covering **DBMS, SQL Server, Database Design, ER Modeling, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers, ADO.NET, ASP.NET Core, and Backend Development**.

This repository documents my day-wise progress throughout the **BridgeLabz Backend Refresher Training**. Each module includes theoretical concepts, practical implementations, database design exercises, assignments, query optimization techniques, and hands-on SQL Server development to strengthen backend development skills using the .NET ecosystem.

---

# 📚 Tech Stack

| Category | Technologies |
|----------|--------------|
| 💻 Database | Microsoft SQL Server |
| 🗄️ Query Language | SQL (T-SQL) |
| 🛠️ IDE | SQL Server Management Studio (SSMS) |
| 🔧 Version Control | Git & GitHub |
| 📐 Concepts | DBMS, RDBMS, ER Diagram, Normalization, Indexing, Query Optimization, SQL Joins, Stored Procedures, Triggers |
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
- ✅ Designed the complete **Entity Relationship (ER) Diagram** using standard ER notation
- ✅ Included **Entities, Attributes, Relationships, Cardinality, Participation, Primary Keys, and Foreign Keys**
- ✅ Uploaded the hand-drawn **ER Diagram** to GitHub
- ✅ Created **Single Column Index**
- ✅ Created **Composite Index**
- ✅ Created **Covering Index**
- ✅ Created **PatientPhones** table for normalization
- ✅ Verified **1NF**, **2NF**, and **3NF**
- ✅ Compared query execution before and after indexing using SQL Server Execution Plans

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

Verified query optimization using **SQL Server Execution Plans (Index Seek)**.

---

## 🧩 Database Normalization

Created the **PatientPhones** table to support multiple phone numbers per patient and verified:

- ✅ First Normal Form (1NF)
- ✅ Second Normal Form (2NF)
- ✅ Third Normal Form (3NF)

---

## 🎯 Learning Outcomes

- Designed a complete ER Diagram using standard database design principles.
- Identified entities, attributes, relationships, cardinality, and participation constraints.
- Applied normalization techniques to eliminate redundancy.
- Extended the database by introducing new entities and relationships.
- Implemented Single Column, Composite, and Covering Indexes.
- Learned query optimization techniques using SQL Server Execution Plans.
- Documented both SQL implementation and ER diagrams in GitHub.

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
- ✅ Implemented **INSERT Trigger** for Doctor table
- ✅ Implemented **UPDATE Trigger** for Doctor table
- ✅ Implemented **DELETE Trigger** for Doctor table
- ✅ Implemented **INSERT Trigger** for Patient table
- ✅ Implemented **INSERT Trigger** for Appointment table
- ✅ Verified automatic audit logging through SQL Server triggers

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

Created reusable stored procedures for operations such as:

- Retrieving doctor appointments
- Viewing patient appointment history
- Fetching doctor schedules
- Updating appointment status
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

Implemented dedicated Audit Tables to maintain historical records of database operations.

Captured:

- Record ID
- Entity Information
- Operation Performed (INSERT / UPDATE / DELETE)
- Timestamp of Action

---

## 🎯 Learning Outcomes

- Learned practical implementation of SQL Joins.
- Created reusable Stored Procedures.
- Understood SQL Server Triggers for database automation.
- Implemented INSERT, UPDATE, and DELETE triggers.
- Built Audit Tables for maintaining historical records.
- Automated database auditing using SQL Server.
- Strengthened backend database programming skills.

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
│
├── Day3
│   ├── database.sql
│   
│
└── README.md
```

---

# 💡 Key Skills Acquired

- Database Design
- Relational Database Modeling
- Microsoft SQL Server
- T-SQL Programming
- Database Schema Design
- Primary & Foreign Keys
- Data Integrity
- ER Diagram Design
- Cardinality & Participation
- Database Normalization (1NF, 2NF, 3NF)
- SQL Constraints
- Single Column Index
- Composite Index
- Covering Index
- Query Optimization
- SQL Joins
- Stored Procedures
- SQL Triggers
- Audit Tables
- Database Automation
- Execution Plan Analysis
- Backend Database Development

---

# 📊 Progress Overview

| Day | Module | Status |
|------|-----------------------------------------------|--------|
| Day 1 | DBMS Fundamentals & RDBMS Basics | ✅ Completed |
| Day 2 | ER Diagram, Normalization & Indexing | ✅ Completed |
| Day 3 | SQL Joins, Stored Procedures & Triggers | ✅ Completed |

---

# 🎯 Current Project

## 🏥 Health Clinic Database Management System

A relational database project built using **Microsoft SQL Server** to understand real-world backend database development concepts, including:

- Database Schema Design
- ER Modeling
- Table Relationships
- Data Integrity
- Database Normalization
- SQL Constraints
- SQL Joins
- Indexing
- Query Optimization
- Stored Procedures
- SQL Triggers
- Audit Tables
- Database Automation

---

# 🌟 About This Repository

This repository serves as a comprehensive record of my **BridgeLabz Backend Refresher Training**. It showcases my day-wise learning through hands-on SQL Server implementations, database design exercises, SQL programming assignments, query optimization techniques, joins, stored procedures, triggers, and backend development concepts. Each module builds upon the previous one, helping me develop a strong foundation in **Microsoft SQL Server**, **T-SQL**, and **.NET Backend Development** while applying industry-standard database design and programming practices.