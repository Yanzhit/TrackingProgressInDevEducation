CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetLectorById](@id int)
AS
select * from [Lectors]
where [id] = @id