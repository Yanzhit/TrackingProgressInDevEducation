CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLection]
(
	 @GroupId INT
	,@LectorId INT
	,@StartedOn NVARCHAR(50)
)
AS
	INSERT [Lections]
	(
		 [GroupId]
		,[LectorId]
		,[StartedOn]
	)
	OUTPUT INSERTED.[id], INSERTED.[GroupId], INSERTED.[LectorId], INSERTED.[StartedOn]
	VALUES
	(
		 @GroupId
		,@LectorId
		,@StartedOn
	)
--ZLoo (Все ок)