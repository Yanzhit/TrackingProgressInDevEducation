CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCourse]
	@Name nvarchar(50)
AS
insert [Courses] 
values (@Name)