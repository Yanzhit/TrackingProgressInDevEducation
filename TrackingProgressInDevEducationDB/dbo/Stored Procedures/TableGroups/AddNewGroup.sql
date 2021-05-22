CREATE PROCEDURE [dbo].[AddNewGroup](@Name nvarchar(50), @CourseId int)
AS 
insert [Groups] ([Name], [CourseId])
values (@Name, @CourseId)