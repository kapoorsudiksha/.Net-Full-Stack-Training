

-- Create and Use Database:

	CREATE DATABASE [sampledb_bhawna];	

	USE sampledb_bhawna;

-- Create `Departments` Table:

	CREATE TABLE Departments
	(DeptId INT PRIMARY KEY,
	DeptName VARCHAR(50) NOT NULL,
	DeptLocation VARCHAR(50) CHECK (DeptLocation IN('Delhi', 'Mumbai', 'Chennai')));

-- Drop Existing Table:

	DROP TABLE Departments;
	
-- Re-Crete Table with Constraints:

	CREATE TABLE Departments
	(DeptId INT CONSTRAINT pk_dept_deptId PRIMARY KEY,
	DeptName VARCHAR(50) NOT NULL,
	DeptLocation VARCHAR(50) CONSTRAINT check_dept_deptLocation CHECK (DeptLocation IN('Delhi', 'Mumbai', 'Chennai')));

-- Create `Employees` Table

	CREATE TABLE Employees
	(EmpId INT PRIMARY KEY,
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE DEFAULT GETDATE(),
	ManagerId INT)

	DROP TABLE Employees;

-- Re-create Table with Constraints:

	CREATE TABLE Employees
	(EmpId INT constraint PK_EMPID_PK PRIMARY KEY,
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT constraint CK_Salary_CK CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE constraint DeF_HireDate_DF DEFAULT GETDATE(),
	ManagerId INT)

	DROP TABLE Employees;

	CREATE TABLE Employees
	(EmpId INT constraint PK_EMPID_PK PRIMARY KEY,
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT constraint CK_Salary_CK CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE constraint DeF_HireDate_DF DEFAULT GETDATE(),
	ManagerId INT);

-- Re-create table with Relationship Keys:

	-- Referencial Integrity (Reference to another table)
	-- Self Referencial Integrity (Reference to the table itselft)
	
	CREATE TABLE Departments
	(DeptId INT CONSTRAINT pk_dept_deptId PRIMARY KEY,
	DeptName VARCHAR(50) NOT NULL,
	DeptLocation VARCHAR(50) CONSTRAINT check_dept_deptLocation CHECK (DeptLocation IN('Delhi', 'Mumbai', 'Chennai')));

	CREATE TABLE Employees
	(EmpId INT constraint PK_EMPID_PK PRIMARY KEY,
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT constraint CK_Salary_CK CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE constraint DeF_HireDate_DF DEFAULT GETDATE(),
	ManagerId INT CONSTRAINT fk_Emps_MgrId FOREIGN KEY REFERENCES Employees(EmpId),
	DeptId INT CONSTRAINT fk_Emps_deptId FOREIGN KEY REFERENCES Departments(DeptId));

	DROP TABLE Employees;

	CREATE TABLE Employees
	(EmpId INT constraint PK_EMPID_PK PRIMARY KEY,
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT constraint CK_Salary_CK CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE constraint DeF_HireDate_DF DEFAULT GETDATE(),
	ManagerId INT REFERENCES Employees(EmpId),
	DeptId INT CONSTRAINT fk_Emps_deptId FOREIGN KEY REFERENCES Departments(DeptId));

/* ************************************************************** */


	CREATE TABLE Departments
	(DeptId INT CONSTRAINT pk_dept_deptId PRIMARY KEY,
	DeptName VARCHAR(50) NOT NULL,
	DeptLocation VARCHAR(50) CONSTRAINT check_dept_deptLocation CHECK (DeptLocation IN('Delhi', 'Mumbai', 'Chennai')));

	CREATE TABLE Employees
	(EmpId INT constraint PK_EMPID_PK PRIMARY KEY IDENTITY(101,1),
	EmpName VARCHAR(100) NOT NULL,
	Salary FLOAT constraint CK_Salary_CK CHECK (Salary >= 5000),
	Email VARCHAR(100) UNIQUE,
	HireDate DATE constraint DeF_HireDate_DF DEFAULT GETDATE(),
	ManagerId INT REFERENCES Employees(EmpId),
	DeptId INT CONSTRAINT fk_Emps_deptId FOREIGN KEY REFERENCES Departments(DeptId));

-- Sample Insertions: INSERT RECORDS TO Department Table:

	INSERT INTO Departments VALUES(1, 'Sales', 'Delhi');
	INSERT INTO Departments(DeptId, DeptName, DeptLocation) VALUES(2, 'Marketing', 'Mumbai');
	INSERT INTO Departments VALUES(3, 'Development', NULL);
	INSERT INTO Departments VALUES(4, 'Testing', 'Chennai');
	INSERT INTO Departments(DeptLocation, DeptId, DeptName) VALUES('Delhi', 5, 'Advertisment');

	DELETE FROM Departments;

	-- OR
	
-- Final Insertions:

	INSERT INTO Departments(DeptId, DeptName, DeptLocation) 
	VALUES
		(1, 'Sales', 'Delhi'),
		(2, 'Marketing', 'Chennai'),
		(3, 'Advertisment', 'Delhi'),
		(4, 'Development', 'Chennai'),
		(5, 'Testing', 'Mumbai')

	INSERT INTO Employees(EmpName, Salary, Email, HireDate, ManagerId, DeptId)
	VALUES
		('King Kochhar', 42000, 'kk@gmail.com', DEFAULT, NULL, 1),
		('Shreya Sharma', 20000, 'ss@gmail.com', DEFAULT, NULL, 2),
		('Sumit Dhawan', 10000, 'sd@gmail.com', DEFAULT, NULL, 3),
		('Gautam Bhalla', 25000, 'gb@gmail.com', DEFAULT, NULL, 1),
		('John Smith', 22000, 'js@gmail.com', DEFAULT, NULL, 1),
		('Rohit Sharma', 30000, 'rs@gmail.com', DEFAULT, NULL, 2),
		('Roger Lee', 32000, 'rl@gmail.com', DEFAULT, NULL, 2),
		('Kartik Sharma', 8000, 'ks@gmail.com', DEFAULT, NULL, 3),
		('Ruskin Bond', 25000, 'rb@gmail.com', DEFAULT, NULL, 3),
		('Sarah Bowling', 26000, 'sb@gmail.com', DEFAULT, NULL, NULL)

	SELECT * FROM Departments;
	SELECT * FROM Employees;

	UPDATE Employees
	SET ManagerId = 101
	WHERE EmpId IN (102,103);

	UPDATE Employees
	SET ManagerId = 102
	WHERE EmpId IN (106,107);

	UPDATE Employees
	SET ManagerId = 103
	WHERE EmpId IN (108,109);

	UPDATE Employees
	SET ManagerId = 101
	WHERE EmpId IN (104,105);



 

