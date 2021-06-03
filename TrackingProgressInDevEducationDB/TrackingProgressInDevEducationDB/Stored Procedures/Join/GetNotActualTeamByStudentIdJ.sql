CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetNotActualTeamByStudentIdJ]
	@Id INT
AS
	SELECT
	T.id
	,T.[Name] Team
    from [TrackingProgressInDevEducationDB].Teams T
	LEFT JOIN [TrackingProgressInDevEducationDB].Team_Student TS ON TS.TeamId = T.id
	JOIN [TrackingProgressInDevEducationDB].Students S ON S.id = TS.StudentId
	
	WHERE S.[id] = @Id AND (GETDATE() NOT BETWEEN T.[From] AND T.[To])