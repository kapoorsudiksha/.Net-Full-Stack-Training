

CREATE DATABASE [sampledb_bhawna];

USE sampledb_bhawna;

-- Create `Departments` Table

	CREATE TABLE Departments
	(DeptId INT PRIMARY KEY,
	DeptName VARCHAR(50) NOT NULL,
	DeptLocation VARCHAR(50) CHECK (DeptLocation IN('Delhi', 'Mumbai', 'Chennai')));

	DROP TABLE Departments;

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


	Referencial Integrity (Reference to another table)
	Self Referencial Integrity (Reference to the table itselft)
	
	
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




 

