﻿CREATE PROCEDURE [dbo].[DeleteSelectedCommentType]
	@ID int
AS
	DELETE FROM  [CommentType] 
	WHERE id = @ID