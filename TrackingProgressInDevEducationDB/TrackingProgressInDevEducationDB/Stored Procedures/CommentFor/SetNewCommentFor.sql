﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCommentFor]
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
--ZLoo (Все ок)	 w[pe[wp
