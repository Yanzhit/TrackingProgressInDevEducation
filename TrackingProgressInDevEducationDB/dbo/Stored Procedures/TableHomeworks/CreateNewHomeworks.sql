CREATE PROCEDURE [dbo].[CreateNewHomeworks](@Name nvarchar(50))
AS
	insert [Homeworks] ([Name])
values (@Name)
