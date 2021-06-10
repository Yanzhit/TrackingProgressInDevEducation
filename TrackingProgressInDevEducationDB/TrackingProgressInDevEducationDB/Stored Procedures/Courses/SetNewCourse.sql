CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCourse]
(
	@Name NVARCHAR(50),
	@Description NvarCHAr(300)
)
AS
	INSERT [Courses]
	(
		[Name],
		[Description]
	)
	OUTPUT INSERTED.id, INSERTED.[Name], INSERTED.[Description]
	VALUES
	(
		@Name,
		@Description
	)
--ZLoo (Все ок)