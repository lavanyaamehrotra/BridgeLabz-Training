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

--QUERY TO RUN AFTER SINGLE COLUMN INDEX--
SELECT * FROM Appointment
WHERE VisitType='Consultation';

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
