CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLectorGroup]
(
	 @LectorId INT
	,@GroupId INT
)
AS
	INSERT [Lector_Group]
	(
		 [LectorId]
		,[GroupId]
	)
	OUTPUT INSERTED.LectorId, INSERTED.[GroupId]
	VALUES
	(
		 @LectorId
		,@GroupId
	)
--ZLoo (Все ок)
