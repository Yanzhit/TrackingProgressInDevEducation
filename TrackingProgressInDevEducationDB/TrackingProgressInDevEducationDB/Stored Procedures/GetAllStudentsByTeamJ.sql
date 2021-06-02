CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudentsByTeamJ]
	@TeamId int
AS
	SELECT S.[id]
		,S.[Name]
		,S.[Surname]
		,S.[Rate]
		,S.[GroupId]
		,S.[Phone]
		,S.[Email]
		,S.[Contract]
		,S.[Birthday]
		,S.[MiddleName]
		,S.[Git]
		,S.[CityId]
		,S.[Status]
	FROM Students S
	LEFT JOIN Team_Student TS ON S.id = TS.StudentId
	LEFT JOIN Teams T ON T.id = TS.TeamId
	WHERE T.id = @TeamId