CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTC]
	(
	 @TestId INT
	,@StudentId INT
	,@Status BIT
)
AS
	INSERT [TestComplete]
	(
		 [TestId]
		,[StudentId]
		,[Status]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		 @TestId
		,@StudentId
		,@Status
	)	
--ZLoo (Все ок)
