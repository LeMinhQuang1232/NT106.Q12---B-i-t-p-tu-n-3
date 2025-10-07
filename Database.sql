CREATE DATABASE UserManagement;
GO

USE UserManagement;
GO

CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Password NVARCHAR(64) NOT NULL,  
    Email NVARCHAR(100) NOT NULL
);
GO