CREATE DATABASE HW3LabDb;
GO

USE HW3LabDb;
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50),
    Password NVARCHAR(50)
);
GO

INSERT INTO Users (Username, Password) VALUES ('admin', 'admin123');
INSERT INTO Users (Username, Password) VALUES ('user1', 'pass123');
GO

SELECT * FROM Instructors;

-- Create Departments table
CREATE TABLE Departments (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100)
);
GO

-- Create Instructors table
CREATE TABLE Instructors (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
);
GO

-- Create Courses table
CREATE TABLE Courses (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    InstructorId INT FOREIGN KEY REFERENCES Instructors(Id)
);
GO

-- Create Students table
CREATE TABLE Students (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    DepartmentId INT FOREIGN KEY REFERENCES Departments(Id)
);
GO

-- Create StudentEnrollments table (junction table)
CREATE TABLE StudentEnrollments (
    StudentId INT FOREIGN KEY REFERENCES Students(Id),
    CourseId INT FOREIGN KEY REFERENCES Courses(Id),
    EnrollmentDate DATE,
    PRIMARY KEY (StudentId, CourseId)
);
GO

-- Insert sample data
INSERT INTO Departments (Name) VALUES ('Computer Science');
INSERT INTO Departments (Name) VALUES ('Engineering');
GO

INSERT INTO Instructors (Name, DepartmentId) VALUES ('Dr. John Smith', 1);
INSERT INTO Instructors (Name, DepartmentId) VALUES ('Prof. Jane Doe', 2);
GO

INSERT INTO Courses (Name, InstructorId) VALUES ('Programming 101', 1);
INSERT INTO Courses (Name, InstructorId) VALUES ('Engineering Basics', 2);
GO

INSERT INTO Students (Name, DepartmentId) VALUES ('Alice Johnson', 1);
INSERT INTO Students (Name, DepartmentId) VALUES ('Bob Brown', 2);
GO

INSERT INTO StudentEnrollments (StudentId, CourseId, EnrollmentDate) VALUES (1, 1, '2025-09-01');
INSERT INTO StudentEnrollments (StudentId, CourseId, EnrollmentDate) VALUES (2, 2, '2025-09-01');
GO

-- Verify data
SELECT * FROM Departments;
SELECT * FROM Instructors;
SELECT * FROM Courses;
SELECT * FROM Students;
SELECT * FROM StudentEnrollments;
GO