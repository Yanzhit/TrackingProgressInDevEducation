CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCType]
(
	 @Name INT
)	
AS
	INSERT [CommentType]
	(
		[Name]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)