CREATE PROCEDURE [dbo].[UpdateLectorById](@ID int, @FullName nvarchar(50))
AS
update [dbo].[Lectors] set FullName=@FullName
where id=@ID