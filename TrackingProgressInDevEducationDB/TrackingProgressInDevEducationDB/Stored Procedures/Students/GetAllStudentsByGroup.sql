CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudentsByGroup]
	@GroupId int
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

	WHERE [GroupId] = @GroupId