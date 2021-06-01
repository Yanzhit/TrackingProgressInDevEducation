CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeam]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Teams]
	(
		[Name]
	)
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)