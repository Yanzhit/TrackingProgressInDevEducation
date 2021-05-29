CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllCommentTypes]

AS
	SELECT [id]
		   ,[Name] 
FROM [CommentType]