CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeam]
(
	@Name NVARCHAR(50),
	@From NVARCHAR(50), 
    @To NVARCHAR(50),
	@LectorId INT 
)
AS
	INSERT [Teams]
	(
		 [Name]
		,[From]
		,[To]
		,[LectorId]
	)
	OUTPUT INSERTED.[id], INSERTED.[Name]
	VALUES
	(
		 @Name
		,@From
		,@To
		,@LectorId
	)
--ZLoo (Все ок)