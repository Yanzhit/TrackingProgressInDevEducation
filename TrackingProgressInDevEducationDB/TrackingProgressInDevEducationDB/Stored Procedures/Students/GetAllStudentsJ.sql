CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudentsJ] @Status BIT
AS
	IF @Status = '' SET @Status = 1
	SELECT 	
		 S.[id]
		,S.[Name] [NameS]
		,[Surname]
		,[Rate]
		,G.[Name] [NameG]
		,[Phone]
		,[Email]
		,[Contract]
		,[Birthday]
		,[MiddleName]
		,[Git]
		,C.[Name] [NameC]
		,[Status]
		,Cr.[Name] [NameCr]

	FROM [Students] S
	LEFT JOIN [TrackingProgressInDevEducationDB].[Groups] G ON G.ID = S.GroupId
	JOIN [TrackingProgressInDevEducationDB].[Cities] C ON C.ID = S.CityId
	JOIN [TrackingProgressInDevEducationDB].[Courses] Cr ON Cr.ID = G.CourseId
	WHERE [Status] = @Status