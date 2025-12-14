-- 1. Создание базы данных
CREATE DATABASE publishing;
GO

USE publishing;
GO

-- 2. Создание таблицы Authors
CREATE TABLE Authors (
    id_Author INT PRIMARY KEY IDENTITY(1,1),
    Surname NVARCHAR(100) NOT NULL,
    Name NVARCHAR(100) NOT NULL
);
GO

-- 3. Создание таблицы Publications (Книги)
CREATE TABLE Publications (
    id_Publication INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL,
    Author INT NULL,
    ReleaseYear INT NOT NULL,
    VolumeOfSheets INT NOT NULL,
    Circulation INT NOT NULL,
    Price DECIMAL(10,2) NOT NULL DEFAULT 0,
    FOREIGN KEY (Author) REFERENCES Authors(id_Author)
);
GO

-- 4. Создание таблицы Offices (Офисы)
CREATE TABLE Offices (
    id_Office INT PRIMARY KEY IDENTITY(1,1),
    Office NVARCHAR(200) NOT NULL,
    Address NVARCHAR(500) NOT NULL,
    Phone NVARCHAR(50) NOT NULL
);
GO

-- 5. Создание таблицы Customers (Клиенты)
CREATE TABLE Customers (
    id_Customer INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL,
    Type INT NOT NULL DEFAULT 1,
    Address NVARCHAR(500) NULL,
    Phone NVARCHAR(50) NULL
);
GO

-- 6. Создание таблицы Orders (Заказы)
CREATE TABLE Orders (
    id_Order INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(200) NOT NULL,
    Type INT NOT NULL DEFAULT 1,
    Publication INT NOT NULL,
    Office INT NOT NULL,
    Customer INT NOT NULL,
    DateOfAdmission DATETIME NOT NULL DEFAULT GETDATE(),
    DateOfCompletion DATETIME NULL,
    Price DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (Publication) REFERENCES Publications(id_Publication),
    FOREIGN KEY (Office) REFERENCES Offices(id_Office),
    FOREIGN KEY (Customer) REFERENCES Customers(id_Customer)
);
GO

-- 7. Вставка тестовых данных
INSERT INTO Authors (Surname, Name) VALUES
('Толстой', 'Лев'),
('Достоевский', 'Федор'),
('Пушкин', 'Александр');

INSERT INTO Publications (Name, Author, ReleaseYear, VolumeOfSheets, Circulation, Price) VALUES
('Война и мир', 1, 1869, 1225, 5000, 1200.00),
('Преступление и наказание', 2, 1866, 672, 3000, 800.00),
('Евгений Онегин', 3, 1833, 320, 2000, 500.00);

INSERT INTO Offices (Office, Address, Phone) VALUES
('Главный офис', 'ул. Ленина, 1', '+7 (495) 123-45-67'),
('Филиал на Пушкина', 'ул. Пушкина, 10', '+7 (495) 987-65-43');

INSERT INTO Customers (Name, Address, Phone) VALUES
('Иванов Иван Иванович', 'ул. Советская, 5', '+7 (912) 345-67-89'),
('Петрова Мария Сергеевна', 'пр. Мира, 15', '+7 (923) 456-78-90');
GO