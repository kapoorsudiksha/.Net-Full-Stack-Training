
USE sampledb_bhawna;

SELECT * FROM departments;
SELECT * FROM employees;

-- (ORDER BY CLAUSE) To sort your data:

	SELECT *
	FROM Employees
	ORDER BY EmpName;

	SELECT *
	FROM Employees
	ORDER BY EmpName ASC;

	SELECT *
	FROM Employees
	ORDER BY EmpName DESC;

	SELECT *
	FROM Employees
	ORDER BY 3 DESC;

	SELECT *
	FROM Employees
	ORDER BY EmpName, ManagerId;

	SELECT EmpName, Salary, Salary*12 AnnualSalary
	FROM Employees
	WHERE (Salary*12) >= 300000
	ORDER BY AnnualSalary DESC;

-- OFFSET FETCH (To limit the Numbers of rows):

-- OFFSET will skip the first 4 rows and return the rest.

	SELECT *
	FROM Employees
	ORDER BY EmpName
	OFFSET 4 ROWS;

-- FETCH (To select next 4 ROWS)

SELECT *
	FROM Employees
	ORDER BY EmpName;

	SELECT *
	FROM Employees
	ORDER BY EmpName
	OFFSET 4 ROWS
	FETCH NEXT 4 ROWS ONLY;

-- TOP: Limits the number of rows or percentange of rows returned.

	SELECT TOP 2 EmpId, EmpName, Salary
	FROM Employees
	ORDER BY Salary DESC;

	SELECT TOP 2 PERCENT EmpId, EmpName, Salary
	FROM Employees
	ORDER BY Salary DESC;

-- DISTINCT: To remove duplicate records

	SELECT DISTINCT DeptId
	FROM Employees;

-- JOINS

	SELECT * FROM Employees;
	SELECT * FROM Departments;

-- INNER JOIN - retrives only matched records:

	SELECT EmpName, DeptName
	FROM employees JOIN departments 
	ON employees.DeptId = Departments.DeptId

	SELECT e.EmpName, e.Salary, d.DeptName, d.DeptLocation
	FROM employees e JOIN departments d 
	ON e.DeptId = d.DeptId

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e JOIN departments d
	ON e.DeptId = d.DeptId

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e JOIN departments d
	ON e.DeptId = d.DeptId
	WHERE e.DeptId IN (1,2)

-- LEFT OUTER JOIN (All matched and non-matched records from left table 
-- and only matched records from right table)

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e LEFT OUTER JOIN departments d
	ON e.DeptId = d.DeptId

-- RIGHT OUTER JOIN (All matched and non-matched records from right table 
-- and only matched records from left table)

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e RIGHT OUTER JOIN departments d
	ON e.DeptId = d.DeptId

-- FULL OUTER JOIN (All matched and non-matched records from left table and right table)

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e FULL OUTER JOIN departments d
	ON e.DeptId = d.DeptId

-- Self JOIN (Joining a Table Itself)

	SELECT emp.EmpName, emp.ManagerId, mgr.EmpName, emp.DeptId
	FROM Employees emp JOIN Employees mgr
	on emp.ManagerId = mgr.EmpId;

-- Cross JOIN (Cartesian Product) 
-- (Each row of table gets multiplied by each row of right table)
-- This join is applied 
	-- When join condition is ommitted
	-- When join condition is not correct

	SELECT e.EmpName, d.DeptId, d.DeptName
	FROM employees e CROSS JOIN departments d;

	SELECT emp.EmpName, emp.ManagerId, mgr.EmpName, emp.DeptId
	FROM Employees emp JOIN Employees mgr
	on emp.ManagerId = mgr.ManagerId;

-- SubQueries

	SELECT * FROM Employees;
	SELECT * FROM departments;

-- Single Row SubQuery - (Subquery returns only one row / one value)
-- Comparison Operators (Single Row SUquery Operators) - >, <, >=, <=, =, <>

-- Find employees earning more than the average salary in their department.

	SELECT EmpName, Salary
	FROM Employees e
	WHERE Salary > (SELECT AVG(salary) FROM Employees WHERE DeptId = e.DeptId);

-- Get employees from the department Sales

	SELECT EmpName, Salary
	FROM Employees
	WHERE DeptId  = (SELECT DeptId FROM Departments WHERE DeptName='Sales');

-- Multi-Row Subquery (returns more than one row)
-- Multi-Row Operators (IN, ANY, ALL)

-- Find Employees working in certain departments

	SELECT EmpName, DeptId
	FROM Employees
	WHERE DeptId IN (SELECT DeptId
	FROM Departments
	WHERE DeptName LIKE '%t');

-- List employees whose salaries are above the minimum salary in their department

	SELECT EmpName, Salary
	FROM Employees
	WHERE Salary > ALL (SELECT MIN(Salary) FROM Employees GROUP BY DeptId)

-- List employees whose salaries are above the minimum salary in each department

	SELECT EmpName, Salary
	FROM Employees
	WHERE Salary > ANY (SELECT MIN(Salary) FROM Employees GROUP BY DeptId)
	
-- IN - checks if a value is in a set of values.
-- ALL - checks if value is greater than, less thaor or otherwise satisfied a condition compared to all the values.
-- ANY - checks if a value is greater than, less than or otherwise satisfied a condition compared to all the values.
