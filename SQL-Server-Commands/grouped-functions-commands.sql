
USE [sampledb_bhawna];

SELECT * FROM Employees;
SELECT * FROM Departments;


-- Aggregate Functions/Group Functions
--  SUM, AVG, MIN, MAX, COUNT

	SELECT COUNT(*) FROM Employees;

	SELECT COUNT(EmpName) FROM Employees;

	SELECT COUNT(DeptId) FROM Employees;

	SELECT COUNT(DISTINCT DeptId) FROM Employees;

	SELECT SUM(Salary) TotalSalary
	FROM Employees;

	SELECT AVG(Salary) AverageSalary
	FROM Employees;

	SELECT MIN(Salary) MinimumSalary
	FROM Employees;

	SELECT MAX(Salary) MaximumSalary
	FROM Employees;

-- The query returns the salary distributed to each department.

	SELECT DeptId, SUM(Salary)
	FROM Employees
	GROUP BY DeptId;

	SELECT ManagerId, SUM(Salary)
	FROM Employees
	GROUP BY ManagerId;

	SELECT DeptId, ManagerId, SUM(Salary)
	FROM Employees
	GROUP BY DeptId, ManagerId;

	SELECT DeptId, SUM(Salary)
	FROM Employees
	WHERE DeptId IN (1,2)
	GROUP BY DeptId;

	SELECT DeptId, SUM(Salary)
	FROM Employees
	GROUP BY DeptId
	HAVING SUM(Salary) > 80000;

-- Count of Employees per Department

	SELECT DeptId, COUNT(*) AS EmployeeCount
	FROM Employees
	GROUP BY DeptId;

-- Average Salary per Department

	SELECT DeptId, AVG(Salary) AS AverageSalary
	FROM Employees
	GROUP BY DeptId;

-- Department with Average Salary Greater than a specific Amount

	SELECT 
		DeptId, 
		AVG(Salary) AS AverageSalary
	FROM Employees
	GROUP BY DeptId
	HAVING  AVG(Salary) > 28000;

-- Total Salary and Employee Count for Departments with More than 5 employees

	SELECT DeptId, COUNT(EmpId) AS employee_count, SUM(salary) AS total_salary
	FROM employees
	GROUP BY DeptId
	HAVING COUNT(EmpId) > 2;

