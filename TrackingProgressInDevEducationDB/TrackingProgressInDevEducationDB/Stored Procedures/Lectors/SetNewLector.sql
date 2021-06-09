CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLector]
(
	 @Login NVARCHAR(50)
	,@FullName NVARCHAR(50)
	,@Email NVARCHAR(50)
	,@Password NVARCHAR(50)
)
AS
	DECLARE @isActive BIT = 0

	INSERT [Lectors]
	(
		 [Login]
		,[FullName]
		,[Email]
		,[Password]
		,[IsActivated]
	)
	OUTPUT
	
		 INSERTED.[id]
		,INSERTED.[Login]
		,INSERTED.[FullName]
		,INSERTED.[Email]
		,INSERTED.[Password]
		,INSERTED.[IsActivated]
	
	VALUES
	(
	     @Login
		,@FullName
		,@Email
		,@Password
		,@isActive
	)
--ZLoo (Все ок)