
Performance Tunning Best Practices:

	- Select fields instead of using SELECT *.
	- Avoid Using DISTINCT.
	- Create queries with INNER JOIN (Instead of WHERE or CROSS JOIN)
	- Use WHERE instead of HAVING to define filters
	- USE WILDCARD at the end of phrase only.
	- Use LIMIT to sample query limits
	- Run complex queries during off-peak hours
	
SQL Performance Tunning Tools

	SQL Sentry (SolarWinds)
	SQL Doctor (IDERA
	Profiler (Microsoft)
	SQL Defrag Manager (IDERA)
	DB Optimizer (IDERA)
	SQL Check (IDERA)
	Query Optimizer (DBSophic)
	SQL Diagnostic Manager(IDERA)
	
--------------------------------------------
	

SELECT * FROM Departments;
SELECT * FROM Employees;

-- Get Employee from a specific Department

	SELECT *
	FROM Employees
	WHERE DeptId = 2;

-- Get the average salary by department

	SELECT d.DeptName, AVG(e.Salary) AvgALey
	FROM Employees e JOIN Departments d
	on e.DeptId = d.DeptId
	GROUP BY d.DeptName;

-- I/O Statistics shows how many reads were performed.
- Time Statistics will show the CPU time and elapsed time for the query execution.


-- Enable I/O and Time Statistics Both

	SET STATISTICS IO ON
	SET STATISTICS TIME ON;

	SELECT *
	FROM Employees
	WHERE DeptId = 2;

-- Disable I/O and Time Statistics Both

	SET STATISTICS IO OFF;
	SET STATISTICS TIME OFF;


-- Get the average salary by department

	SELECT d.DeptName, AVG(e.Salary) AvgALey
	FROM Employees e JOIN Departments d
	on e.DeptId = d.DeptId
	GROUP BY d.DeptName;

-- Query Performance with '[sys].[dm_exec_query_stats]'

	SELECT
		qs.total_worker_time / qs.execution_count AS AvgCPUTime,
		qs.execution_count,
		qs.total_elapsed_time / qs.execution_count AS AvgElapsedTime,
		qt.text as QueryText
	FROM [sys].[dm_exec_query_stats] qs
	CROSS APPLY
	sys.dm_exec_sql_text(qs.sql_handle) qt
	ORDER BY AvgCPUTime;

-- Query Performance with sys.dm_exec_requests

	SELECT session_id, status, blocking_session_id, 
	wait_type,wait_time, wait_resource, 
	percent_complete, estimated_completion_time
	FROM sys.dm_exec_requests
	WHERE status = 'running';

--------------------------------------------

-- To check the performance of query:

	-- Use IO and Time Statistics 
	-- Include the Actual Estimated Plan
	-- Using DMVs (Database Management Views)
	
/* **************************************************** */


	CREATE TABLE Dept
	(DeptId INT,
	DeptName VARCHAR(50),
	DeptLocation VARCHAR(50));

	INSERT INTO Dept(DeptId, DeptName, DeptLocation) 
	VALUES
		(1, 'Sales', 'Delhi'),
		(2, 'Marketing', 'Chennai'),
		(3, 'Advertisment', 'Delhi'),
		(4, 'Development', 'Chennai'),
		(5, 'Testing', 'Mumbai')

	CREATE TABLE Emps
	(EmpId INT,
	EmpName VARCHAR(100),
	Salary FLOAT,
	Email VARCHAR(100),
	HireDate DATE,
	ManagerId INT,
	DeptId INT);

	INSERT INTO Emps(EmpName, Salary, Email, HireDate, ManagerId, DeptId)
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

	SELECT * FROM Dept;
	SELECT * FROM Emps;

	SELECT *
	FROM Emps
	WHERE DeptId = 2;

	CREATE INDEX IX_Dept_DeptId 
	ON Dept(DeptId)

	CREATE INDEX IX_Emps_EmpId 
	ON Emps(EmpId)

	CREATE INDEX IX_Emps_DeptId
	ON Emps(DeptId)

	SELECT *
	FROM Employees
	WHERE DeptId = 2;

-- Rebuild Index

	ALTER INDEX IX_Emps_DeptId ON Emps REBUILD;

-- Update Statistics

	UPDATE STATISTICS Emps;
	UPDATE STATISTICS Dept;























