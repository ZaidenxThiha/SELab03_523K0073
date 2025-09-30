CREATE DATABASE Exe2LabDB;
GO

USE Exe2LabDB;
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50),
    Password NVARCHAR(50)  -- Plain text for lab; hash in production
);
GO

-- Insert sample users (hardcoded for testing)
INSERT INTO Users (Username, Password) VALUES ('admin', 'password123');
INSERT INTO Users (Username, Password) VALUES ('user1', 'pass1');
GO

SELECT * FROm Users;