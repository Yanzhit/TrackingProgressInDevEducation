<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[GetHomeworkByid](@id int)
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetHomeworkByid](@ID int)
>>>>>>> DB_Actualize
AS
select * from [Homeworks] 
where id=@id
