<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[RemoveHomeworksById](@id int)
AS
delete from [dbo].[Homeworks]
where id=@id
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[RemoveHomeworksByid](@ID int)
AS
delete from [TrackingProgressInDevEducationDB].[Homeworks]
where id=@ID
>>>>>>> DB_Actualize
