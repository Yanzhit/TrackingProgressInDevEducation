CREATE PROCEDURE [dbo].[GetLectorById](@id int)
AS
select [FullName] from [Lectors]
where [id] = @id