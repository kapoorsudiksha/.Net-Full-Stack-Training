

-- Temporary Tables

	-- Local Temporary Tables
		-- Visible to the session created by them.
	-- Global Temporary Tables
		-- Visible to all sessions and users.

	CREATE TABLE #TempEmployee
	(EmpId INT,
	EmpName VARCHAR(200));

	INSERT INTO #TempEmployee VALUES 
		(1, 'John'), (2, 'Smith');

	SELECT * FROM #TempEmployee;

	DROP TABLE #TempEmployee;