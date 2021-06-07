CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetVisitsByStudentJ]
	@StudentId int
AS
	SELECT V.[id]
	,V.[VisitStatus]
	,L.[StartedOn]
	--,V.StudentId
	FROM Visits V
	JOIN Lections L ON L.[id] = V.[LectionId]
	WHERE V.[StudentId] = @StudentId