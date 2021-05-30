CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeamStudent]
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
	VALUES
	(
		 @TeamId
		,@StudentId
	)
--ZLoo (Все ок)