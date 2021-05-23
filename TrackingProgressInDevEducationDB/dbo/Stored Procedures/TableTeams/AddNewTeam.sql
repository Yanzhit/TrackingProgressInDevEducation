CREATE PROCEDURE [dbo].[AddNewTeam](@Name nvarchar(50))
AS 
insert [Teams] ([Name])
values (@Name)
