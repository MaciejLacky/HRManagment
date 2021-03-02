CREATE DATABASE HumanResourcesDB
GO
USE HumanResourcesDB
GO
CREATE TABLE Employees(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
Code INT NOT NULL,
GenderId INT NULL,
DateBirth DATETIME2(7) NULL,
Pesel NVARCHAR(11) NULL,
PhoneNumber NVARCHAR(50) NULL,
AdressEmail NVARCHAR(50) NULL,
IsseuDateIdentityCard DATETIME2(7) NULL,
ExpirationDateIdentityCard DATETIME2(7) NULL,
PassportNumber NVARCHAR(50) NULL,
IssueDatePassport DATETIME2(7) NULL,
ExpirationDatePassport DATETIME2(7) NULL,
StatusId INT NOT NULL
)
GO
CREATE TABLE Genders(
ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
Value NVARCHAR(20) NOT NULL
)


CREATE TABLE Statuses(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Value NVARCHAR(20) NOT NULL
)


CREATE TABLE Departments
(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
Name NVARCHAR(100) NOT NULL,
ManagerId INT NULL,
Location NVARCHAR(200) NULL,
ParentDepartmentId INT NULL,
)



CREATE TABLE TerminationWays(
ID INT PRIMARY KEY IDENTITY(1,1),
Value NVARCHAR(100)
)


CREATE TABLE TypeRates(
ID INT PRIMARY KEY IDENTITY(1,1),
Value NVARCHAR(100)
)


CREATE TABLE TypeContracts(
ID INT PRIMARY KEY IDENTITY(1,1),
Value NVARCHAR(100)
)


CREATE TABLE Currencies(
ID INT PRIMARY KEY IDENTITY(1,1),
Value NVARCHAR(10)
)


CREATE TABLE Positions(
ID INT PRIMARY KEY IDENTITY(1,1),
MaxSalary DECIMAL NULL,
MinSalary DECIMAL NULL,
)


CREATE TABLE Contracts(
ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
EmployeeId INT NOT NULL,
TypeContractsID INT NULL,
DateFrom DATETIME2(7) NOT NULL,
DateTo DATETIME2(7) NULL,
PositionId INT NULL,
DepartmentId INT NULL,
Salary DECIMAL NOT NULL,
CurrencyId INT NULL,
TypeRateId INT NULL,
TerminationWayId INT NULL
)


CREATE TABLE Users
(
ID INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
LastName NVARCHAR(100) NOT NULL,
FirstName NVARCHAR(100) NOT NULL,
EmailAdress NVARCHAR(100) NOT NULL,
Name NVARCHAR(100) NOT NULL,
Password NVARCHAR(10) NOT NULL,
IsAdministrator BIT NOT NULL,
PermissionId INT NOT NULL
)

CREATE TABLE Permissions(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
UserId INT NOT NULL,
ShowEmployees BIT NULL,
EditEmployees BIT NULL,
SendEmail BIT NULL,
ShowContracts BIT NULL,
DeleteContracts BIT NULL,
ShowPositions BIT NULL,
EditPositions BIT NULL,
ShowDepartments BIT NULL,
EditDepartments BIT NULL,
ShowOrganizationStructure BIT NULL,
ShowSalary BIT NULL

)
ALTER TABLE Users
ADD FOREIGN KEY (PermissionId) REFERENCES Permissions(ID)
ALTER TABLE Employees
ADD FOREIGN KEY (GenderId) REFERENCES Genders(ID)
ALTER TABLE Employees
ADD FOREIGN KEY (StatusId) REFERENCES Statuses(ID)
ALTER TABLE Departments
ADD FOREIGN KEY (ManagerId) REFERENCES Employees(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (EmployeeId) REFERENCES Employees(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (TypeContractsId) REFERENCES TypeContracts(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (PositionId) REFERENCES Positions(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (DepartmentId) REFERENCES Departments(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (CurrencyId) REFERENCES Currencies(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (TypeRateId) REFERENCES TypeRates(ID)
ALTER TABLE Contracts
ADD FOREIGN KEY (TerminationWayId) REFERENCES TerminationWays(ID)
ALTER TABLE Departments
ADD FOREIGN KEY (ParentDepartmentId) REFERENCES Departments(ID)


INSERT INTO Genders(Value) VALUES
('Kobieta'),
('Mê¿czyzna')

INSERT INTO Statuses(Value) VALUES
('Wprowadzony'),
('Zatrudniony'),
('Zwolniony'),
('Niezatrudniony')

INSERT INTO TerminationWays VALUES
('Za pozozumieniem stron'),
('dyscyplinarnie')
INSERT INTO TypeRates VALUES
('Godzinowa'),
('akord')
INSERT INTO TypeContracts VALUES
('umowa o prace'),
('umowa zlecenie')

INSERT INTO Currencies VALUES
('z³'),
('EUR')
INSERT INTO Positions VALUES
(1000, 5000),
(3000,10000)
INSERT INTO Employees VALUES
('Sprzeda¿', 1,'Budynek A',1)

INSERT INTO Employees VALUES
('£¹cki', 'Maciej',1,1,'2020-09-02 8:00:00','86050310911','605235852','lacky@gmail.com','2020-09-02 8:00:00','2020-09-02 8:00:00','asd4589212','2020-09-02 8:00:00','2020-09-02 8:00:00',2)

INSERT INTO Departments (Name,ManagerId,Location)VALUES
('Sprzeda¿',1,'Budynek A')

INSERT INTO Contracts VALUES
(1,1,'2020-09-02 8:00:00','2022-09-02 8:00:00',1,3,5000,1,1,1)

SELECT * FROM Departments

