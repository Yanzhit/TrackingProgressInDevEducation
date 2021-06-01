CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCType]
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