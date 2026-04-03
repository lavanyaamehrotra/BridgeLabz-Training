/* =========================================================
   DATABASE CREATION (DDL)

        -- CREATE DATABASE
           CREATE DATABASE database_name;

        -- USE DATABASE
           USE database_name;
  ========================================================= */
CREATE DATABASE CollegeDB;
GO

USE CollegeDB;
GO

/* =========================================================
   DROP TABLE (DDL)

        -- DROP TABLE
           DROP TABLE table_name;

        -- DROP TABLE IF EXISTS
           DROP TABLE IF EXISTS table_name;
  ========================================================= */
DROP TABLE IF EXISTS Enrollments;
DROP TABLE IF EXISTS Students;
DROP TABLE IF EXISTS Courses;
DROP TABLE IF EXISTS Departments;
GO
/* =========================================================
   CREATE TABLE : Departments (DDL)

        -- CREATE TABLE
           CREATE TABLE table_name (
               column datatype constraint
           );

        -- PRIMARY KEY
           column datatype PRIMARY KEY;

        -- UNIQUE
           column datatype UNIQUE;
  ========================================================= */
CREATE TABLE Departments (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50) UNIQUE NOT NULL
);
GO
/* =========================================================
   CREATE TABLE : Students (DDL)

        -- FOREIGN KEY
           FOREIGN KEY (column)
           REFERENCES parent_table(column);
  ========================================================= */
CREATE TABLE Students (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE,
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);
GO
/* =========================================================
   CREATE TABLE : Courses (DDL)
  ========================================================= */
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50) NOT NULL,
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);
GO
/* =========================================================
   CREATE TABLE : Enrollments (COMPOSITE KEY)

        -- COMPOSITE PRIMARY KEY
           PRIMARY KEY (column1, column2);
  ========================================================= */
CREATE TABLE Enrollments (
    StudentID INT,
    CourseID INT,
    Semester VARCHAR(20),
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);
GO
/* =========================================================
   INSERT DATA (DML)

        -- INSERT INTO
           INSERT INTO table_name VALUES (...);

        -- INSERT WITH COLUMNS
           INSERT INTO table_name (col1, col2)
           VALUES (...);
  ========================================================= */

INSERT INTO Departments VALUES
(1, 'Computer Science'),
(2, 'Mechanical'),
(3, 'Electrical');

INSERT INTO Students VALUES
(101, 'Lavanya', 'lavanya@gmail.com', 1),
(102, 'Khushi', 'khushi@gmail.com', 1),
(103, 'Roshni', 'roshni@gmail.com', 2);

INSERT INTO Courses VALUES
(201, 'DBMS', 1),
(202, 'Operating Systems', 1),
(203, 'Thermodynamics', 2);

INSERT INTO Enrollments VALUES
(101, 201, 'Sem 1'),
(101, 202, 'Sem 1'),
(102, 201, 'Sem 1'),
(103, 203, 'Sem 1');
GO


/* =========================================================
   SELECT QUERIES (DQL)

        -- SELECT ALL
           SELECT * FROM table_name;

        -- WHERE
           SELECT * FROM table_name WHERE condition;

        -- ORDER BY
           SELECT * FROM table_name ORDER BY column;

        -- GROUP BY
           SELECT column, COUNT(*)
           FROM table_name
           GROUP BY column;
  ========================================================= */

SELECT * FROM Students;
SELECT * FROM Students WHERE DeptID = 1;
SELECT * FROM Students ORDER BY StudentName;

SELECT DeptID, COUNT(*) AS TotalStudents
FROM Students
GROUP BY DeptID;
GO


/* =========================================================
   JOINS

        -- INNER JOIN
           SELECT *
           FROM A INNER JOIN B ON condition;

        -- LEFT JOIN / RIGHT JOIN / FULL JOIN
  ========================================================= */

SELECT s.StudentName, c.CourseName
FROM Students s
INNER JOIN Enrollments e ON s.StudentID = e.StudentID
INNER JOIN Courses c ON e.CourseID = c.CourseID;

SELECT s.StudentName, e.CourseID
FROM Students s
LEFT JOIN Enrollments e ON s.StudentID = e.StudentID;
GO


/* =========================================================
   UPDATE & DELETE (DML)

        -- UPDATE
           UPDATE table_name SET column=value WHERE condition;

        -- DELETE
           DELETE FROM table_name WHERE condition;
  ========================================================= */

UPDATE Students
SET Email = 'lavanya_new@gmail.com'
WHERE StudentID = 101;

DELETE FROM Enrollments
WHERE StudentID = 102 AND CourseID = 201;
GO


/* =========================================================
   TCL COMMANDS

        -- BEGIN TRANSACTION
           BEGIN TRANSACTION;

        -- COMMIT
           COMMIT;

        -- ROLLBACK
           ROLLBACK;
  ========================================================= */

BEGIN TRANSACTION;
INSERT INTO Students VALUES (104, 'David', 'david@gmail.com', 3);
ROLLBACK;

BEGIN TRANSACTION;
INSERT INTO Students VALUES (105, 'Eva', 'eva@gmail.com', 2);
COMMIT;
GO


/* =========================================================
   NORMALIZATION

        -- 1NF : Atomic values
        -- 2NF : No partial dependency
        -- 3NF : No transitive dependency
        -- BCNF: Every determinant is a key
  ========================================================= */

CREATE TABLE Student_1NF (
    StudentID INT,
    StudentName VARCHAR(50),
    Course VARCHAR(50)
);

CREATE TABLE Student_2NF (
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50)
);

CREATE TABLE Department_3NF (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Teacher_Subject_BCNF (
    Teacher VARCHAR(50) PRIMARY KEY,
    Subject VARCHAR(50)
);
GO
