CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeam]
(
	@Name NVARCHAR(50)
)
AS
	INSERT [Teams]
	(
		[Name]
	)
	OUTPUT INSERTED.[id], INSERTED.[Name]
	VALUES
	(
		@Name
	)
--ZLoo (Все ок)