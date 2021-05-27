CREATE PROCEDURE [dbo].[UpdateLectorById](@id int, @FullName nvarchar(50))
AS
update [dbo].[Lectors] set FullName=@FullName
where id=@id