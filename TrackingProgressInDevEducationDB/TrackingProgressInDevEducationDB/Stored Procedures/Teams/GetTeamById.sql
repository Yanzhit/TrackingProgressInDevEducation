CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetTeamById](@id int)
AS 
select  [id]   
       ,[Name] 
       ,[From] 
       ,[To] 
from [TrackingProgressInDevEducationDB].[Teams]
where id=@id