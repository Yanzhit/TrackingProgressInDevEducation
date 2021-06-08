CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCFor]
	@Name NVARCHAR(50)	

AS
	INSERT [CommentFor]
	(
		[Name]
	)
	OUTPUT INSERTED.id, INSERTED.[Name]
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)
