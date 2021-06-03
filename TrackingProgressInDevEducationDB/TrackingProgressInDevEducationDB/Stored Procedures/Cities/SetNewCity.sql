CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCity]
(
	@Name NVARCHAR(50)	 	
)
AS
	INSERT [Cities]
	(
		[Name]
	)
	VALUES
	(
		@Name
	) 	
	RETURN(0)
--ZLoo (Все ок)