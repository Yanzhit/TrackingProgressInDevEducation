CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCourse]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Courses]
	(
		[Name]
	)
	OUTPUT INSERTED.id, INSERTED.[Name]
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)