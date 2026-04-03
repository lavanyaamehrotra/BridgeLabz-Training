/* =====================================================
   HEALTH CARE MANAGEMENT SYSTEM DATABASE
   Purpose : Central database for patients, doctors,
             appointments, billing, and audit logging
   Author  : <Your Name>
===================================================== */


/* ===============================
   DATABASE CREATION
   Creates the main database
================================ */
CREATE DATABASE HealthCare;
GO

USE HealthCare;
GO


/* ===============================
   PATIENT TABLE
   Stores patient demographic data
   Uses IDENTITY for auto-increment PK
================================ */
CREATE TABLE Patient (
    patient_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique patient identifier
    name VARCHAR(100) NOT NULL,               -- Patient full name
    dob DATE NOT NULL,                         -- Date of birth
    phone VARCHAR(10) UNIQUE NOT NULL,         -- Unique contact number
    address VARCHAR(200),                      -- Residential address
    blood_group VARCHAR(5)                     -- Blood group (A+, O+, etc.)
);
GO

-- Sample patient data
INSERT INTO Patient VALUES
('Lavanya Mehrotra','2004-04-10','9876543210','Delhi','O+'),
('Khushi Tiwari','2004-03-13','1234567890','Mumbai','A+'),
('Roshni Srivastava','2004-06-04','8899776655','Pune','B+'),
('Khushi Rathi','2004-02-16','9867452310','Noida','AB+');
GO


/* ===============================
   SPECIALIZATION TABLE
   Master lookup table for doctors
================================ */
CREATE TABLE Specialization (
    specialist_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique specialization ID
    specialist_name VARCHAR(100) NOT NULL        -- Name of specialization
);
GO

INSERT INTO Specialization VALUES
('Cardiologist'),
('Dermatologist'),
('Orthopedic'),
('Neurologist');
GO


/* ===============================
   DOCTOR TABLE
   Stores doctor profiles
   Linked to Specialization table
================================ */
CREATE TABLE Doctor (
    doctor_id INT IDENTITY(1,1) PRIMARY KEY, -- Unique doctor ID
    name VARCHAR(100) NOT NULL,               -- Doctor name
    contact VARCHAR(10),                      -- Contact number
    consultation_fee DECIMAL(10,2),           -- Fee per consultation
    specialist_id INT,                        -- FK to Specialization
    is_active BIT DEFAULT 1,                  -- Soft delete flag
    FOREIGN KEY (specialist_id) 
        REFERENCES Specialization(specialist_id)
);
GO

INSERT INTO Doctor (name,contact,consultation_fee,specialist_id) VALUES
('Dr. Mehrotra','9988776655',500,1),
('Dr. Priya','8877665544',400,2),
('Dr. Arjun','7766554433',600,3),
('Dr. Karan','6655443322',700,4);
GO


/* ===============================
   APPOINTMENT TABLE
   Manages patient-doctor scheduling
================================ */
CREATE TABLE Appointment (
    appointment_id INT IDENTITY(1,1) PRIMARY KEY, -- Appointment ID
    patient_id INT,                               -- FK to Patient
    doctor_id INT,                                -- FK to Doctor
    appointment_date DATE,                        -- Date of visit
    appointment_time TIME,                        -- Time slot
    status VARCHAR(50),                           -- Scheduled/Completed/Cancelled
    FOREIGN KEY (patient_id) REFERENCES Patient(patient_id),
    FOREIGN KEY (doctor_id) REFERENCES Doctor(doctor_id)
);
GO


/* ===============================
   VISIT TABLE
   Created after appointment completion
================================ */
CREATE TABLE Visit (
    visit_id INT IDENTITY(1,1) PRIMARY KEY, -- Visit ID
    appointment_id INT,                     -- FK to Appointment
    diagnosis VARCHAR(200),                 -- Doctor diagnosis
    notes VARCHAR(500),                     -- Additional notes
    visit_date DATE,                        -- Date of visit
    FOREIGN KEY (appointment_id) REFERENCES Appointment(appointment_id)
);
GO


/* ===============================
   PRESCRIPTION TABLE
   One-to-many relation with Visit
================================ */
CREATE TABLE Prescription (
    prescription_id INT IDENTITY(1,1) PRIMARY KEY, -- Prescription ID
    visit_id INT,                                  -- FK to Visit
    medicine_name VARCHAR(100),                    -- Medicine name
    dosage VARCHAR(50),                            -- Dosage instructions
    duration VARCHAR(50),                          -- Treatment duration
    FOREIGN KEY (visit_id) REFERENCES Visit(visit_id)
);
GO


/* ===============================
   BILLING TABLE
   Stores bill per visit
================================ */
CREATE TABLE Billing (
    bill_id INT IDENTITY(1,1) PRIMARY KEY, -- Bill ID
    visit_id INT,                          -- FK to Visit
    total_amount DECIMAL(10,2),            -- Total bill amount
    payment_status VARCHAR(20),            -- Paid / Pending
    FOREIGN KEY (visit_id) REFERENCES Visit(visit_id)
);
GO


/* ===============================
   PAYMENT TRANSACTIONS TABLE
   Stores individual payment records
================================ */
CREATE TABLE Payment_Transactions (
    transaction_id INT IDENTITY PRIMARY KEY, -- Transaction ID
    bill_id INT,                             -- FK to Billing
    payment_mode VARCHAR(50),                -- Cash/Card/UPI
    payment_date DATETIME DEFAULT GETDATE(), -- Payment timestamp
    amount DECIMAL(10,2),                    -- Amount paid
    FOREIGN KEY (bill_id) REFERENCES Billing(bill_id)
);
GO


/* ===============================
   USER AUTHENTICATION TABLE
   Stores hashed passwords
================================ */
CREATE TABLE Users (
    user_id INT IDENTITY PRIMARY KEY,        -- User ID
    username VARCHAR(50) UNIQUE NOT NULL,    -- Login username
    password_hash VARBINARY(256) NOT NULL,   -- Hashed password
    role VARCHAR(20) NOT NULL                -- User role
);
GO


/* ===============================
   LOGIN STORED PROCEDURE
   Secure login using SHA-256
================================ */
CREATE PROCEDURE sp_LoginUser
    @username VARCHAR(50),
    @password VARCHAR(50)
AS
BEGIN
    SELECT role
    FROM Users
    WHERE username = @username
      AND password_hash = HASHBYTES('SHA2_256', @password);
END;
GO


/* ===============================
   AUDIT LOG TABLE
   Stores insert/update/delete logs
================================ */
CREATE TABLE Audit_Log (
    log_id INT IDENTITY PRIMARY KEY,
    table_name VARCHAR(50),   -- Affected table
    action VARCHAR(20),       -- INSERT/UPDATE/DELETE
    action_date DATETIME DEFAULT GETDATE()
);
GO


/* ===============================
   AUDIT TRIGGERS
   Automatically log changes
================================ */
CREATE TRIGGER trg_Patient_Insert
ON Patient
AFTER INSERT
AS
BEGIN
    INSERT INTO Audit_Log (table_name, action)
    VALUES ('Patient', 'INSERT');
END;
GO


CREATE TRIGGER trg_Patient_Update
ON Patient
AFTER UPDATE
AS
BEGIN
    INSERT INTO Audit_Log (table_name, action)
    VALUES ('Patient', 'UPDATE');
END;
GO


CREATE TRIGGER trg_Patient_Delete
ON Patient
AFTER DELETE
AS
BEGIN
    INSERT INTO Audit_Log (table_name, action)
    VALUES ('Patient', 'DELETE');
END;
GO


/* ===============================
   APPOINTMENT AUDIT TABLE
   Logs appointment updates
================================ */
CREATE TABLE Appointment_Audit (
    audit_id INT IDENTITY PRIMARY KEY,
    appointment_id INT,
    action VARCHAR(50),
    action_date DATETIME DEFAULT GETDATE()
);
GO


CREATE TRIGGER trg_Appointment_Update
ON Appointment
AFTER UPDATE
AS
BEGIN
    INSERT INTO Appointment_Audit (appointment_id, action)
    SELECT appointment_id, 'UPDATED / CANCELLED'
    FROM inserted;
END;
GO


/* ===============================
   REVENUE REPORT PROCEDURE
   Aggregated analytics query
================================ */
CREATE PROCEDURE sp_RevenueReport
    @fromDate DATE,
    @toDate DATE
AS
BEGIN
    SELECT 
        d.name AS doctor_name,
        s.specialist_name,
        SUM(b.total_amount) AS total_revenue
    FROM Billing b
    JOIN Visit v ON b.visit_id = v.visit_id
    JOIN Appointment a ON v.appointment_id = a.appointment_id
    JOIN Doctor d ON a.doctor_id = d.doctor_id
    JOIN Specialization s ON d.specialist_id = s.specialist_id
    WHERE b.payment_status = 'Paid'
      AND v.visit_date BETWEEN @fromDate AND @toDate
    GROUP BY d.name, s.specialist_name
    HAVING SUM(b.total_amount) > 0;
END;
GO


/* ===============================
   SAFE DELETE PROCEDURE
   Prevents orphan doctor records
================================ */
CREATE PROCEDURE sp_DeleteSpecialization
    @specialist_id INT
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Doctor WHERE specialist_id = @specialist_id
    )
    BEGIN
        PRINT 'Cannot delete specialization. Doctors are assigned.';
        RETURN;
    END

    DELETE FROM Specialization WHERE specialist_id = @specialist_id;
END;
GO
