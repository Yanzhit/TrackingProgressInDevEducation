CREATE PROCEDURE [dbo].[AddNewCourse]
@Name nvarchar(50)
AS
insert [Courses] 
values (@Name)