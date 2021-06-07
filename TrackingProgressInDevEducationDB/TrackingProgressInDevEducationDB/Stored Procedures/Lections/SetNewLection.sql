﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLection]
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
	OUTPUT INSERTED.id, INSERTED.GroupId, INSERTED.LectorId, INSERTED.StartedOn
	VALUES
	(
		 @GroupId
		,@LectorId
		,@StartedOn
	)
--ZLoo (Все ок)