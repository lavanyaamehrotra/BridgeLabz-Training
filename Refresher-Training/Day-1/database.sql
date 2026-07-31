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
    PatientID INT NOT NULL,
    CONSTRAINT Appointment_PK
        PRIMARY KEY (AppointmentID),
    CONSTRAINT Appointment_Doctor_FK
        FOREIGN KEY (DoctorID)
        REFERENCES Doctor(DoctorID),
    CONSTRAINT Appointment_Patient_FK
        FOREIGN KEY (PatientID)
        REFERENCES Patient(PatientID)
);

