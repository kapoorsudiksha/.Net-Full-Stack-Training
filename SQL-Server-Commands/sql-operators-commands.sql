

	SELECT * FROM Departments;
	SELECT * FROM Employees;

-- Projection (Restrict the Columns/Fields)

	SELECT EmpId, EmpName, Salary 
	FROM Employees;

-- Selection (Restrict the Rows/Records/Tuples)

	SELECT * 
	FROM Employees
	WHERE Salary > 30000;

-- Projection and Selection

	SELECT EmpId, EmpName, Salary 
	FROM Employees
	WHERE Salary > 30000;

-- Arithmetic Operators (+, -, *, /)

	SELECT EmpId, EmpName, Salary, Salary*12 
	FROM Employees
	WHERE Salary > 20000;

-- Alias Name to the COlumns: 

	SELECT EmpId, EmpName, Salary, Salary*12 AnnualSalary
	FROM Employees
	WHERE Salary > 20000;

	SELECT EmpId, EmpName, Salary, Salary*12 'Annual Salary'
	FROM Employees
	WHERE Salary > 20000;

	SELECT EmpId, EmpName, Salary, Salary*12 as 'Annual Salary'
	FROM Employees
	WHERE Salary > 20000;

-- Logical Operators (AND, OR, NOT)

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary > 15000 AND Salary < 25000;

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary > 20000 AND DeptId IN (2,3);

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary > 20000 OR DeptId IN (2,3);

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName= 'King Kochhar' OR EmpName = 'Kartik Sharma';

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary > 20000 AND NOT DeptId = 3;

-- MISC Operations (BETWEEN, IN, LIKE, NOT NULL)

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary BETWEEN 15000 AND 25000;
	
	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE Salary NOT BETWEEN 15000 AND 25000;

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName IN ('King Kochhar', 'Kartik Sharma');

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName NOT IN ('King Kochhar', 'Kartik Sharma');

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName LIKE 'S%';

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName LIKE '%a';

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName LIKE 'S%a';

	SELECT EmpId, EmpName, Salary, DeptId
	FROM Employees
	WHERE EmpName LIKE '_a%';

	
	SELECT *
	FROM Employees
	WHERE ManagerId IS NULL;

	SELECT *
	FROM Employees
	WHERE ManagerId IS NULL AND DeptId IS NOT NULL;
	

SELECT * FROM Employees;