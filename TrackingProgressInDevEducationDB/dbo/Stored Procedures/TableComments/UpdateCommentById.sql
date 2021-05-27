<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[UpdateCommentById](@id int, @Text nvarchar(50))
AS
update [dbo].[Comments] set Text=@Text
where id=@id
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateCommentById](@ID int, @Text nvarchar(50))
AS
update [TrackingProgressInDevEducationDB].[Comments] set Text=@Text
where id=@ID
>>>>>>> DB_Actualize
