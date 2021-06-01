CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewLector]
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
	)
	VALUES
	(
		 @FullName
		,@Email
		,@Password
	)
--ZLoo (Все ок)