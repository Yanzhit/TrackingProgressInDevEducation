CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeam]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Teams]
	(
		[Name]
	)
	OUTPUT INSERTED.Id
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)