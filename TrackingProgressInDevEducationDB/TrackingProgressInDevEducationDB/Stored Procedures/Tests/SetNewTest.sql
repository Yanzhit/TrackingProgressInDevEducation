CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTest]
	(
	 @Name NVARCHAR(50)
	,@Description NVARCHAR(50)
)
AS
	INSERT [Tests]
	(
		 [Name]
		,[Description]
	)
	VALUES
	(
		 @Name
		,@Description
	)
--ZLoo (Все ок)