<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[GetGroupById](@id int)
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetGroupById](@ID int)
>>>>>>> DB_Actualize
AS 
select * from [Groups]
where id=@id