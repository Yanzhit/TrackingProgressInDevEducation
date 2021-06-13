CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudents] @Status BIT
AS
	SELECT 	
		 S.[id]
		,S.[Name]
		,[Surname]
		,[Rate]
		,G.[Name]
		,[Phone]
		,[Email]
		,[Contract]
		,[Birthday]
		,[MiddleName]
		,[Git]
		,C.[Name]
		,[Status]
		,Cr.[Name]

	FROM [Students] S
	LEFT JOIN [TrackingProgressInDevEducationDB].[Groups] G ON G.ID = S.GroupId
	JOIN [TrackingProgressInDevEducationDB].[Cities] C ON C.ID = S.CityId
	JOIN [TrackingProgressInDevEducationDB].[Courses] Cr ON Cr.ID = G.CourseId
	WHERE [Status] = @Status