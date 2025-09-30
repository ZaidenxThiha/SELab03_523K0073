-- Create the database (if it doesn't exist)
CREATE DATABASE LabDB;
GO

-- Use the database
USE LabDB;
GO

-- Create the Customers table
CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);
GO

-- Insert sample data
INSERT INTO Customers (Name, Email) VALUES ('John Doe', 'john.doe@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Jane Smith', 'jane.smith@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Trung Pham', 'trung.pham@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Emily Davis', 'emily.davis@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Thai Pham', 'thai.pham@etdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Thiha Aung', '523K0073@student.tdtu.edu.vn');
GO

SELECT * FROM Customers;