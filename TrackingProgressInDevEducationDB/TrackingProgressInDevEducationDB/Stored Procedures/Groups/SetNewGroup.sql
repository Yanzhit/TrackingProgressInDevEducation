
CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewGroup](@Name nvarchar(50), @CourseId int, @StartDate date, @EndDate date)
AS 
IF @StartDate = null SET @StartDate = GetDate() 
insert [Groups] ([Name], [CourseId],[StartDate], [EndDate])
values (@Name, @CourseId, @StartDate, @EndDate)