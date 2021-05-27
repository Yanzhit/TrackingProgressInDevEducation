<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[RemoveGroupById](@id int)
AS 
delete from [dbo].[Groups]
where id=@id
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveGroupById](@ID int)
AS 
delete from [TrackingProgressInDevEducationDB].[Groups]
where id=@ID
>>>>>>> DB_Actualize
