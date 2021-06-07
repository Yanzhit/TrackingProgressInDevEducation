CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCType]
(
	 @Name INT
)	
AS
	INSERT [CommentType]
	(
		[Name]
	)
	OUTPUT INSERTED.id, INSERTED.[Name]
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)