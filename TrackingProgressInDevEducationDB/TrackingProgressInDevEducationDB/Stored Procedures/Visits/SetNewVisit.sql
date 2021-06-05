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
	VALUES
	(
		 @VisitStatus
		,@StudentId
		,@LectionId
	)
--ZLoo (Все ок)