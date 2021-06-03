CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewCity]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Cities]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)