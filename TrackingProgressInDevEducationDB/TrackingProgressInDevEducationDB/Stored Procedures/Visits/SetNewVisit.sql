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
	VALUES
	(
		 @VisitStatus
		,@StudentId
		,@LectionId
	)
--ZLoo (Все ок)