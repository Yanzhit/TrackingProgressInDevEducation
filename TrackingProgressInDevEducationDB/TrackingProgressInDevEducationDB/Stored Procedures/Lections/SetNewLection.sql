CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLection]
(
	 @GroupId INT
	,@LectorId INT
	,@StartedOn DATE
)
AS
	INSERT [Lections]
	(
		 [GroupId]
		,[LectorId]
		,[StartedOn]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		 @GroupId
		,@LectorId
		,@StartedOn
	)
--ZLoo (Все ок)