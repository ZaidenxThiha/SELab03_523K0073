CREATE DATABASE Exe3LabDB;
GO

USE Exe3LabDB;
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50),
    Password NVARCHAR(50)  -- Plain text for lab only
);
GO

-- Insert sample users
INSERT INTO Users (Username, Password) VALUES ('admin', 'password123');
INSERT INTO Users (Username, Password) VALUES ('user1', 'pass1');
GO

USE Exe3LabDB;
GO

CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);
GO

-- Insert sample data
INSERT INTO Customers (Name, Email) VALUES ('John Doe', 'john.doe@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Jane Smith', 'jane.smith@tdtu.com');
INSERT INTO Customers (Name, Email) VALUES ('Thiha Aung', '523K0073@student.tdtu.edu.vn');
GO

-- Create Products table
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Price DECIMAL(10,2)
);
GO

-- Insert sample products
INSERT INTO Products (Name, Price) VALUES ('Laptop', 999.99);
INSERT INTO Products (Name, Price) VALUES ('Mouse', 25.50);
GO

-- Create Suppliers table
CREATE TABLE Suppliers (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    ContactEmail NVARCHAR(100)
);
GO

-- Insert sample suppliers
INSERT INTO Suppliers (Name, ContactEmail) VALUES ('TechCorp', 'info@techcorp.com');
INSERT INTO Suppliers (Name, ContactEmail) VALUES ('SupplyCo', 'sales@supplyco.com');
GO

-- Verify data
SELECT * FROM Products;
SELECT * FROM Suppliers;
GO
SELECT * FROM Customers;

