# 🚀 BridgeLabz Backend Refresher Training (.NET)

> A structured learning journey covering **DBMS, SQL Server, Database Design, ER Modeling, Normalization, Indexing, Query Optimization, ADO.NET, ASP.NET Core, and Backend Development**.

This repository documents my day-wise progress throughout the BridgeLabz Backend Refresher Training. Each module includes theoretical concepts, practical implementations, database design exercises, assignments, and hands-on SQL Server development.

---

# 📚 Tech Stack

| Category | Technologies |
|----------|--------------|
| 💻 Database | Microsoft SQL Server |
| 🗄️ Query Language | SQL (T-SQL) |
| 🛠️ IDE | SQL Server Management Studio (SSMS) |
| 🔧 Version Control | Git & GitHub |
| 📐 Concepts | DBMS, RDBMS, ER Diagram, Normalization, Indexing, Query Optimization |
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
- ✅ Designed the complete **Entity Relationship (ER) Diagram** on paper using standard ER notation
- ✅ Included **Entities, Attributes, Relationships, Cardinality, Participation, Primary Keys, and Foreign Keys** in the ER Diagram
- ✅ Uploaded the hand-drawn **ER Diagram** to GitHub
- ✅ Created **Single Column Index**
- ✅ Created **Composite Index**
- ✅ Created **Covering Index**
- ✅ Created **PatientPhones** table for normalization
- ✅ Verified **1NF**, **2NF**, and **3NF**
- ✅ Compared query execution before and after indexing using **SQL Server Execution Plans**

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
- Documented both SQL implementation and hand-drawn ER diagrams in GitHub.

---

# 📂 Repository Structure

```text
Refresher-Training
│
├── Day1
│   ├── HealthClinicDB.sql
│   ├── ER_Diagram.png
│
├── Day2
│   ├── Assignment.sql
│   ├── ER_Diagram_HandDrawn.jpg
│   ├── ER_Diagram_Final.png
│
└── README.md
```

---

# 💡 Key Skills Acquired

- Database Design
- Relational Database Modeling
- Microsoft SQL Server
- T-SQL Programming
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
- Execution Plan Analysis
- Backend Database Development

---

# 📊 Progress Overview

| Day | Module | Status |
|------|-------------------------------|--------|
| Day 1 | DBMS Fundamentals & RDBMS Basics | ✅ Completed |
| Day 2 | ER Diagram, Normalization & Indexing | ✅ Completed |

---

# 🎯 Current Project

**Health Clinic Database Management System**

A relational database project built using **Microsoft SQL Server** to understand real-world database design concepts, including:

- Database Schema Design
- ER Modeling
- Table Relationships
- Data Integrity
- Normalization
- SQL Constraints
- Indexing
- Query Optimization

---

# 🌟 About This Repository

This repository serves as a record of my **BridgeLabz Backend Refresher Training**. It demonstrates my learning through daily hands-on implementations, database design exercises, SQL programming assignments, and backend development concepts. Each day builds on the previous one, helping me develop a strong foundation in SQL Server and .NET backend technologies.