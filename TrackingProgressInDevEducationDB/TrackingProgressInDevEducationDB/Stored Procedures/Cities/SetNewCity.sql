CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCity]
(
	@Name NVARCHAR(50)	
)
AS
	INSERT [Cities]
	(
		[Name]
	)
	OUTPUT INSERTED.id
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)	 w[pe[wp