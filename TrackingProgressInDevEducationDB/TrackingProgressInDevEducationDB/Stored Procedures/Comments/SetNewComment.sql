﻿CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewComment]
(
	 @Text NVARCHAR(50)
	,@TypeId INT
	,@StudentId INT
	,@CreatedBy INT
	,@TeamId INT
)
AS
	INSERT [Comments]
	(
		 [Text]
		,[TypeId]
		,[StudentId]
		,[CreatedBy]
		,[TeamId]
	)
	OUTPUT INSERTED.id
	VALUES
	(
		 @Text
		,@TypeId
		,@StudentId
		,@CreatedBy
		,@TeamId
	)
--ZLoo (Все ок)