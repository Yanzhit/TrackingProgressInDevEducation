CREATE PROCEDURE [dbo].[GetLectorById](@id int)
AS
select * from [Lectors]
where [id] = @id