CREATE PROCEDURE [dbo].[GetAllCommentTypes]

AS
	SELECT [id]
		   ,[Name] 
FROM [CommentType]
