
-- Stored Procedures

	-- a collection of SQL statements that can executed as a unit to perform specific tasks.
	-- Stored procedures are termed as pre-compiled bodies.
	-- hence, it improves the query improves.

	USE [sampledb_bhawna];

	SELECT * FROM Employees;
	SELECT * FROM Departments;

-- Creating a Procedure

	CREATE PROCEDURE getEmployeesByDepartment
	AS
	BEGIN
		SELECT * FROM Employees
		WHERE DeptId = 1;
	END;

-- Alter an existing Procedure

	ALTER PROCEDURE getEmployeesByDepartment
	AS
	BEGIN
		SELECT * FROM Employees
		WHERE DeptId = 1;
	END;

-- Executing a Procedure

	EXEC getEmployeesByDepartment;

-- Proccedure with IN Parameters

	ALTER PROCEDURE getEmployeesByDepartment
	@deptartmentId INT
	AS
	BEGIN
		SELECT * FROM Employees
		WHERE DeptId = @deptartmentId;
	END;

-- Executing a Procedure

	EXEC getEmployeesByDepartment 1;

-- Proccedure with IN Parameters

	ALTER PROCEDURE getEmployeesByDepartment
	@deptartmentId INT
	AS
	BEGIN
		SELECT e.EmpName, e.Salary, d.DeptName, d.DeptLocation 
		FROM Employees e JOIN Departments d
		ON e.DeptId = d.DeptId
		AND d.DeptId = @deptartmentId;
	END;

-- Executing a Procedure

	EXEC getEmployeesByDepartment 1;

-- Proccedure with IN Parameters with insert statement

	ALTER PROCEDURE procAddDepartment
	@dId INT,
	@dName VARCHAR(100),
	@dLocation VARCHAR(100)
	AS
	BEGIN
		INSERT INTO Departments(DeptId, DeptName, DeptLocation)
		VALUES(@dId, @dName, @dLocation);
	END;

	EXEC procAddDepartment @dId = 6, @dName = 'Analyst', @dLocation = 'Delhi';

-- Procedure with Error Handling

	ALTER PROCEDURE procAddDepartment
	@dId INT,
	@dName VARCHAR(100),
	@dLocation VARCHAR(100)
	AS
	BEGIN
		BEGIN TRY
			BEGIN TRANSACTION
				INSERT INTO Departments(DeptId, DeptName, DeptLocation)
				VALUES(@dId, @dName, @dLocation);
				UPDATE Departments
				SET DeptLocation = 'Chennai'
				WHERE DeptName = 'Marketing';
			COMMIT TRANSACTION;
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION;
			SELECT ERROR_MESSAGE() as ErrorMessage;
		END CATCH
	END;

	EXEC procAddDepartment @dId = 6, @dName = 'Analyst', @dLocation = 'Delhi';

	SELECT * FROM Departments;

-- Exercise:

	CREATE PROCEDURE procDeleteDepartment
	@deptId INT
	AS
	BEGIN
		BEGIN TRY

		END TRY
		BEGIN CATCH
		END CATCH
	END;


	Create PROCEDURE DeleteDepartment
    @DeptID INT
AS
BEGIN
    DECLARE @EmployeeCount INT;
    DECLARE @ErrorMessage NVARCHAR(4000);
    BEGIN TRANSACTION;
    SELECT @EmployeeCount = COUNT(*)
    FROM Employees
    WHERE DeptId = @DeptID;
    IF @EmployeeCount > 0
    BEGIN
        SET @ErrorMessage = 'Cannot delete department because there are employees still assigned to it.';
        RAISERROR(@ErrorMessage, 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    BEGIN TRY
        DELETE FROM Departments
        WHERE DeptId = @DeptID;
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SET @ErrorMessage = ERROR_MESSAGE();
        RAISERROR(@ErrorMessage, 16, 1);
    END CATCH
END;

-- Procedure with Output Parameter

-- Calculate the total number of employees and the total salary in a specifc department

	CREATE PROC getEmployeeStats
	@DepartmentId INT,
	@EmployeeCount INT OUTPUT,
	@TotalSalary FLOAT OUTPUT
	AS
	BEGIN
		SELECT @EmployeeCount = COUNT(*),
		@TotalSalary = SUM(Salary)
		FROM Employees
		WHERE DeptId = @DepartmentId
	END;

-- Exec

	DECLARE @EmpCount INT, @TotalSal FLOAT
	EXEC getEmployeeStats
		@departmentId = 1,
		@EmployeeCount = @EmpCount OUTPUT,
		@TotalSalary = @TotalSal OUTPUT
	SELECT @EmpCount, @TotalSal;

	-- Exercise

CREATE PROCEDURE GetEmployeeStats

    @DepartmentID INT,               

    @TotalEmployees INT OUTPUT,      

    @TotalSalary DECIMAL(18, 2) OUTPUT  

AS

BEGIN

    SET @TotalEmployees = 0;

    SET @TotalSalary = 0;
 
    SELECT 

        @TotalEmployees = COUNT(*),

        @TotalSalary = SUM(salary)

    FROM employees

    WHERE DeptId = @DepartmentID;

END;
 