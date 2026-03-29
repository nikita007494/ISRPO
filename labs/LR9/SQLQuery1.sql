-- Создание базы данных (если не существует)
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'FileHistoryDB')
BEGIN
    CREATE DATABASE FileHistoryDB;
END
GO

-- Переход в базу данных
USE FileHistoryDB;
GO

-- Создание таблицы (если не существует)
IF NOT EXISTS (
    SELECT * FROM sys.objects 
    WHERE object_id = OBJECT_ID(N'[dbo].[FileOperations]') 
    AND type in (N'U')
)
BEGIN
    CREATE TABLE dbo.FileOperations (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        FilePath NVARCHAR(500),
        Content NVARCHAR(MAX),
        SymbolCount INT,
        OperationType NVARCHAR(50),
        OperationDate DATETIME DEFAULT GETDATE()
    );
END
GO