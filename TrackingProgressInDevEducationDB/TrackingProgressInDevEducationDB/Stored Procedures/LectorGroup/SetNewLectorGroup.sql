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
	OUTPUT INSERTED.Id
	VALUES
	(
		 @LectorId
		,@GroupId
	)
--ZLoo (Все ок)
