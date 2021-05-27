CREATE PROCEDURE [dbo].[NullifyCommentType]
AS
delete from [dbo].[CommentType]
DBCC CHECKIDENT ([CommentType], RESEED, 0)  -- Обнуление ключа indentify