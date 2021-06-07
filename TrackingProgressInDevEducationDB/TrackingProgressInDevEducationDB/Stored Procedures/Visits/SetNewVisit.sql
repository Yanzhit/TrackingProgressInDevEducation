CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewVisit]
(
	 @VisitStatus BIT
	,@StudentId INT
	,@LectionId INT
)
AS 
	INSERT [Visits]
	(	
		 [VisitStatus]
		,[StudentId]
		,[LectionId]
	)
	OUTPUT INSERTED.id
	,INSERTED.[VisitStatus]
		,INSERTED.[StudentId]
		,INSERTED.[LectionId]
	VALUES
	(
		 @VisitStatus
		,@StudentId
		,@LectionId
	)
--ZLoo (Все ок)