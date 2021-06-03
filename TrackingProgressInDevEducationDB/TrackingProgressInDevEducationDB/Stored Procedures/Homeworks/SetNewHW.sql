CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewHW]
(
	 @Name NVARCHAR(50)
	,@Deskription NVARCHAR(50)
)
AS
	INSERT [Homeworks]
	(
		 [Name]
		,[Deskription]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		 @Name
		,@Deskription
	)
--ZLoo (Все ок)