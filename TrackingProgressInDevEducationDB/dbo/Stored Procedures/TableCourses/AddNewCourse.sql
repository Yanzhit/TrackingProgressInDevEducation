CREATE PROCEDURE [dbo].[AddNewCourse](@Name nvarchar(50), @StartedOn date, @FinishedOn date)
AS
insert [Courses] ([Name], [StartedOn], [FinishedOn])
values (@Name, @StartedOn, @FinishedOn)