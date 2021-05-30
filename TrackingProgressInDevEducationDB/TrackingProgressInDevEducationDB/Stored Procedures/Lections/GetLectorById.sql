CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetLectorById](@id int)
AS
select 
[id],
[FullName],
[Email],
[Password]
from [Lectors]
where [id] = @id