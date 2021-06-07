CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTStudent]
(
	 @TeamId INT
	,@StudentId INT
)
AS
	INSERT [Team_Student]
	(
		 [TeamId]
		,[StudentId]
	)
	OUTPUT INSERTED.StudentId, INSERTED.TeamId
	VALUES
	(
		 @TeamId
		,@StudentId
	)
--ZLoo (Все ок)