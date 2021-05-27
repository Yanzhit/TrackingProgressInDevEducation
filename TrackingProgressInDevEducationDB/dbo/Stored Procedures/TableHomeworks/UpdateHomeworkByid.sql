<<<<<<< HEAD
﻿CREATE PROCEDURE [dbo].[UpdateHomeworkById](@Name nvarchar(50), @id int)
AS
update [dbo].[Homeworks] set Name=@Name
where id=@id
=======
﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[UpdateHomeworkByid](@Name nvarchar(50), @ID int)
AS
update [TrackingProgressInDevEducationDB].[Homeworks] set Name=@Name
where id=@ID
>>>>>>> DB_Actualize
