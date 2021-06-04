CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCType]
(
	 @Name INT
)	
AS
	INSERT [CommentType]
	(
		[Name]
	)
	OUTPUT INSERTED.id
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)