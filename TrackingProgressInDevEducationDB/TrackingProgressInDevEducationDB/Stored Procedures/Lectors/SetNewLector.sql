CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLector]
(
	 @FullName NVARCHAR(50)
	,@Email NVARCHAR(50)
	,@Password NVARCHAR(50)
)
AS
	DECLARE @isActive BIT = 0

	INSERT [Lectors]
	(
		 [FullName]
		,[Email]
		,[Password]
		,[IsActivated]
	)
	OUTPUT
	
		 INSERTED.[id]
		,INSERTED.[FullName]
		,INSERTED.[Email]
		,INSERTED.[Password]
		,INSERTED.IsActivated
	
	VALUES
	(
		 @FullName
		,@Email
		,@Password
		,@isActive
	)
--ZLoo (Все ок)				   --CAST(@Email as nvarchar(50))