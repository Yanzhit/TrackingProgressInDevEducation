CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllStudentsByTeam]
	@TeamId int
AS
	SELECT * 
	FROM Students S
	LEFT JOIN Team_Student TS ON S.id = TS.StudentId
	LEFT JOIN Teams T ON T.id = TS.TeamId
	WHERE T.id = @TeamId