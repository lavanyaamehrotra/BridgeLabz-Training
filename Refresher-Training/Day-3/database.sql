
-- CREATING DATABASE --
CREATE DATABASE HealthClinicDB;
GO

-- USING THE DATABASE--
USE HealthClinicDB;
GO

-- CREATING DOCTOR TABLE --
CREATE TABLE Doctor
(
    DoctorID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorName VARCHAR(100) NOT NULL,
    Specialization VARCHAR(50) NOT NULL,
    Qualification VARCHAR(100),
    Experience INT,
    PhoneNumber VARCHAR(15) UNIQUE,
    Email VARCHAR(100) UNIQUE
);


-- CREATING PATIENT TABLE --

CREATE TABLE Patient
(
    PatientID INT IDENTITY(1,1) PRIMARY KEY,
    PatientName VARCHAR(100) NOT NULL,
    Gender VARCHAR(10),
    Age INT,
    BloodGroup VARCHAR(5),
    PhoneNumber VARCHAR(15) UNIQUE,
    City VARCHAR(50)
);

-- CREATING APPOINTMENT TABLE --

CREATE TABLE Appointment
(
    AppointmentID INT IDENTITY(1,1),
    AppointmentDate DATE NOT NULL,
    AppointmentTime TIME NOT NULL,
    VisitType VARCHAR(30) NOT NULL,
    AppointmentStatus VARCHAR(20) DEFAULT 'Scheduled',
    DoctorID INT NOT NULL,
    PatientID INT NOT NULL
    CONSTRAINT Appointment_PK
        PRIMARY KEY (AppointmentID),
    CONSTRAINT Appointment_Doctor_FK
        FOREIGN KEY (DoctorID)
        REFERENCES Doctor(DoctorID),
    CONSTRAINT Appointment_Patient_FK
        FOREIGN KEY (PatientID)
        REFERENCES Patient(PatientID)
);

SELECT * FROM Doctor;
SELECT * FROM Patient;
SELECT * FROM Appointment;

-- DAY-2--

-- 1)Add a rooms table and a doctor_room relationship reflecting doctors assigned to specific consultation rooms. --

-- CREATING ROOM TABLE --
CREATE TABLE Room
(
    RoomID INT IDENTITY(1,1) PRIMARY KEY,
    RoomNumber VARCHAR(10) NOT NULL UNIQUE,
    FloorNumber INT,
    RoomType VARCHAR(50)
);

-- ADD ROOMID IN DOCTOR --
ALTER TABLE Doctor
ADD RoomID INT;

-- CREATING FOREIGN KEY --
ALTER TABLE Doctor
ADD CONSTRAINT FK_Doctor_Room
FOREIGN KEY(RoomID)
REFERENCES Room(RoomID);

--2)Write and run EXPLAIN on at least 3 different queries against the appointments table — one with no index, one using a single-column index, one using the composite index — and note the differences in the type and rows columns. --

-- QUERY WITHOUT INDEX --
SELECT * FROM Appointment
WHERE VisitType='Consultation';

--CREATING SINGLE COLUMN INDEX --
CREATE INDEX IX_VisitType
ON Appointment(VisitType);

-- CREATING COMPOSITE INDEX --
CREATE INDEX IX_Doctor_Date
ON Appointment(DoctorID, AppointmentDate);

--QUERY TO RUN AFTER CREATING COMPOSITE INDEX --
SELECT * FROM Appointment
WHERE DoctorID = 1 AND AppointmentDate='2026-08-05';


--3)Take the patient_phones design and verify it satisfies 1NF, 2NF, and 3NF — write a shortjustification for each.--
CREATE TABLE PatientPhones
(
    PhoneID INT IDENTITY(1,1) PRIMARY KEY,
    PatientID INT NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL,
    CONSTRAINT FK_PatientPhones
    FOREIGN KEY(PatientID)
    REFERENCES Patient(PatientID)
);

-- Normalization Verification

-- 1NF:
-- Each row stores a single phone number.
-- No repeating groups or multi-valued attributes.

-- 2NF:
-- The table is in 1NF.
-- PatientID and PhoneNumber depend completely on the primary key (PhoneID).
-- No partial dependency exists.

-- 3NF:
-- The table is in 2NF.
-- There are no transitive dependencies.
-- Patient information is stored in the Patient table, while phone numbers are stored separately.

--4)Create a covering index for a query that reports doctor_id, appointment_date,status from the appointments table, and verify with EXPLAIN that Extra shows Using index.--

--QUERY--
SELECT
    DoctorID,
    AppointmentDate,
    AppointmentStatus
FROM Appointment WHERE DoctorID = 1;

--CREATING COVER INDEX--
CREATE INDEX IX_Covering_Doctor
ON Appointment(DoctorID)
INCLUDE (AppointmentDate, AppointmentStatus);

-- The query execution plan shows Index Seek (NonClustered) on IX_Covering_Doctor, indicating that SQL Server is using the covering index to retrieve the required columns without needing additional lookups to the base table. This improves query performance.--

----------------TRIGGERS FLOW ----------------
--- DOCTOR AUDIT TABLE ---
CREATE TABLE DoctorAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    DoctorID INT,
    DoctorName VARCHAR(100),
    ActionPerformed VARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);

-- INSERT TRIGGER --
CREATE TRIGGER TR_Doctor_Insert
ON Doctor
AFTER INSERT
AS
BEGIN
    INSERT INTO DoctorAudit
    (   
        DoctorID,
        DoctorName,
        ActionPerformed
    )
    SELECT
        DoctorID,
        DoctorName,
        'INSERT'
    FROM inserted;
END;
GO

--INSERT ROOMS--
INSERT INTO Room
(RoomNumber, FloorNumber, RoomType)
VALUES
('R101',1,'Consultation'),
('R102',1,'Consultation'),
('R201',2,'ICU'),
('R202',2,'General'),
('R301',3,'Surgery');

-- INSERT DOCTORS --
INSERT INTO Doctor
(DoctorName,Specialization,Qualification,Experience,PhoneNumber,Email,RoomID)
VALUES
('Dr. Amit Sharma','Cardiologist','MBBS, MD',10,'9876543210','amit@clinic.com',1),
('Dr. Neha Verma','Dentist','BDS, MDS',8,'9876543211','neha@clinic.com',2),
('Dr. Raj Malhotra','Neurologist','MBBS, DM',12,'9876543212','raj@clinic.com',3),
('Dr. Priya Singh','Orthopedic','MBBS, MS',7,'9876543213','priya@clinic.com',4),
('Dr. Karan Mehta','Pediatrician','MBBS, MD',5,'9876543214','karan@clinic.com',5);


SELECT * FROM Doctor;
SELECT * FROM Room;
SELECT * FROM DoctorAudit;

-- UPDATE TRIGGER --

CREATE TRIGGER TR_Doctor_Update
ON Doctor
AFTER UPDATE
AS
BEGIN
INSERT INTO DoctorAudit
(DoctorID,DoctorName,ActionPerformed)
SELECT
DoctorID,DoctorName,
'UPDATE'
FROM inserted;
END;
GO

-- RUNNING UPDATE --

UPDATE Doctor
SET Experience = 15
WHERE DoctorID = 1;

SELECT * FROM Doctor;
SELECT * FROM DoctorAudit;


-- DELETE TRIGGER --

CREATE TRIGGER TR_Doctor_Delete
ON Doctor
AFTER DELETE
AS
BEGIN
INSERT INTO DoctorAudit
(DoctorID,DoctorName,ActionPerformed)
SELECT
DoctorID,DoctorName,
'DELETE'
FROM deleted;
END;
GO

-- DELETE 1 DOCTOR --
DELETE FROM Doctor
WHERE DoctorID=5;

SELECT * FROM Doctor;
SELECT * FROM DoctorAudit;


-- PATIENT AUDIT TABLE --

CREATE TABLE PatientAudit
(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
PatientID INT,
PatientName VARCHAR(100),
Gender VARCHAR(10),
Age INT,
BloodGroup VARCHAR(5),
PhoneNumber VARCHAR(15),
City VARCHAR(50),
ActionPerformed VARCHAR(20),
ActionDate DATETIME DEFAULT GETDATE()
);

-- INSERT TRIGGER --
CREATE TRIGGER TR_Patient_Insert
ON Patient
AFTER INSERT
AS
BEGIN
INSERT INTO PatientAudit
(PatientID,PatientName,Gender,Age,BloodGroup,PhoneNumber,City,ActionPerformed)
SELECT
PatientID,PatientName,Gender,Age,BloodGroup,PhoneNumber,City,
'INSERT'
FROM inserted;
END;
GO


-- INSERT INTO PATIENTS --
INSERT INTO Patient
(PatientName,Gender,Age,BloodGroup,PhoneNumber,City)
VALUES
('Rahul Gupta','Male',28,'B+','9876500001','Delhi'),
('Sneha Sharma','Female',25,'A+','9876500002','Mumbai'),
('Arjun Singh','Male',34,'O+','9876500003','Lucknow'),
('Priya Kapoor','Female',29,'AB+','9876500004','Jaipur'),
('Rohan Verma','Male',40,'B-','9876500005','Noida');

SELECT * FROM Patient;
SELECT * FROM PatientAudit;


-- APPOINTMENT AUDIT TABLE --

CREATE TABLE AppointmentAudit
(
AuditID INT IDENTITY(1,1) PRIMARY KEY,
AppointmentID INT,
AppointmentDate DATE,
AppointmentTime TIME,
VisitType VARCHAR(30),
AppointmentStatus VARCHAR(20),
DoctorID INT,
PatientID INT,
ActionPerformed VARCHAR(20),
ActionDate DATETIME DEFAULT GETDATE()
);

--CREATING TRIGGER --
CREATE TRIGGER TR_Appointment_Insert
ON Appointment
AFTER INSERT
AS
BEGIN
INSERT INTO AppointmentAudit
(AppointmentID,AppointmentDate,AppointmentTime,VisitType,AppointmentStatus,DoctorID,PatientID,ActionPerformed)
SELECT
AppointmentID,AppointmentDate,AppointmentTime,VisitType,AppointmentStatus,DoctorID,PatientID,
'INSERT'
FROM inserted;
END;
GO

--INSERT APPOINTMENTS --
INSERT INTO Appointment
(AppointmentDate,AppointmentTime,VisitType,AppointmentStatus,DoctorID,PatientID)
VALUES
('2026-08-05','10:00','Consultation','Scheduled',1,1),
('2026-08-05','11:00','Dental Checkup','Scheduled',2,2),
('2026-08-06','09:30','Neurology Visit','Scheduled',3,3),
('2026-08-06','12:00','Orthopedic','Scheduled',4,4),
('2026-08-07','02:00','Vaccination','Scheduled',4,5);

SELECT * FROM Appointment;
SELECT * FROM AppointmentAudit;