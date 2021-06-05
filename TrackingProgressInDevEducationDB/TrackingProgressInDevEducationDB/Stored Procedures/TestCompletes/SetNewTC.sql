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
	OUTPUT INSERTED.id
	VALUES
	(
		 @TestId
		,@StudentId
		,@Status
	)	
--ZLoo (Все ок)
