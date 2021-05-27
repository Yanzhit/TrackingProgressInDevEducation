CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewCourse]
@Name nvarchar(50)
AS
insert [Courses] 
values (@Name)