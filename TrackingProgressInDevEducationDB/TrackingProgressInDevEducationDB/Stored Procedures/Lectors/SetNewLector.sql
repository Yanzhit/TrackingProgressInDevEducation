﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLector]
(
	 @FullName NVARCHAR(50)
	,@Email NVARCHAR(50)
	,@Password NVARCHAR(50)
)
AS
	INSERT [Lectors]
	(
		 [FullName]
		,[Email]
		,[Password]
		,[IsActivated]
	)
	OUTPUT INSERTED.id
	VALUES
	(
		 @FullName
		,@Email
		,@Password
		,0
	)
--ZLoo (Все ок)