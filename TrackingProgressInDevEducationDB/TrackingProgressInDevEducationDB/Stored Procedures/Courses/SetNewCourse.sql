CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCourse]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Courses]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)