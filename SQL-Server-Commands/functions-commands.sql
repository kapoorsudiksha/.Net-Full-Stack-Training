
Functions in SQL Server
Temp Tables
Performance Improvement (Views)

------------------------------------

Functions 

	- Built-In Functions
			- Windows Functions
			- System Functions
			- JSON Functions
	
		- Single Row Functions - Returns one result per row
			- String Functions
			- Date and Time Functions
			- Mathematical Functions
			- Conversion Functions
			- Logical Functions
			- Ranking Functions
			
		- Multi Row Functions - Returns a single result for a set of rows
			- Aggregate Functions
			
	- User Defined Functions
	
		- Scalar Functions - Returns a single value
		- Table Valued Functions
		- Mult Statement Table Valued Functions
		
/* ****************************************** */


USE [sampledb_bhawna];

SELECT * FROM Employees;
SELECT * FROM Departments;

-- Single Row Function

	SELECT UPPER(EmpName)
	FROM Employees;

-- Multi Row Function

	SELECT DeptId, SUM(Salary)
	FROM Employees
	GROUP BY DeptId;

-- Scalar Function (UDF)

	SELECT * FROM Employees

	CREATE FUNCTION fnCalculateTax(@salary FLOAT)
	RETURNS FLOAT
	AS
	BEGIN 
		DECLARE @tax FLOAT;
		IF @salary <= 20000
			SET @tax = @salary * 0.10;
		ELSE IF @salary <= 30000
			SET @tax = @salary * 0.20;
		ELSE
			SET @tax = @salary * 0.30;
		RETURN @tax;
	END;

-- Usage

	SELECT [dbo].[fnCalculateTax](12000);

	SELECT EmpId, EmpName, Salary, 
		[dbo].[fnCalculateTax](Salary) as Tax
	FROM Employees

-- Table Valued Functions - returns a table data type

	SELECT * FROM Employees;
	SELECT * FROM Departments;

	CREATE FUNCTION fnGetEmployeesByDepartment(@deptid INT)
	RETURNS TABLE
	AS
	RETURN
		(SELECT EmpId, EmpName, Salary,DeptId 
		FROM Employees
		WHERE DeptId = @deptid);

-- Usage:

	SELECT * FROM [fnGetEmployeesByDepartment](1);

	SELECT e.EmpName, d.DeptName, d.DeptId
	FROM [fnGetEmployeesByDepartment](1) as e
	JOIN Departments as d
	ON e.DeptId = d.DeptId;

	



