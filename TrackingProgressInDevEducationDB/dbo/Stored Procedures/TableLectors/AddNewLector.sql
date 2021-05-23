CREATE PROCEDURE [dbo].[AddNewLector](@FullName nvarchar(50))
AS
insert [Lectors] ([FullName])
values (@FullName)
