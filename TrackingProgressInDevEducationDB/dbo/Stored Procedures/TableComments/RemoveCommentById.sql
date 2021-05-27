<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[RemoveCommentById](@id int)
AS 
delete from [dbo].[Comments]
where id=@id
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveCommentById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Comments]
where id=@ID
>>>>>>> DB_Actualize
