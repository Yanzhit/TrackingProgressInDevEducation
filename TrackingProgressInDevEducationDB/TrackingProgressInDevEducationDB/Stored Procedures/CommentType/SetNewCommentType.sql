CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCommentType]
(
	 @Name INT
)	
AS
	INSERT [CommentType]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)