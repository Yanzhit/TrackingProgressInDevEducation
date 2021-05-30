CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudents] @Status BIT
AS
	SELECT 	
		 [id]
		,[Name]
		,[Surname]
		,[Rate]
		,[GroupId]
		,[Phone]
		,[Email]
		,[Contract]
		,[Birthday]
		,[MiddleName]
		,[Git]
		,[CityId]
		,[Status]

	FROM [Students]

	WHERE [Status] = @Status