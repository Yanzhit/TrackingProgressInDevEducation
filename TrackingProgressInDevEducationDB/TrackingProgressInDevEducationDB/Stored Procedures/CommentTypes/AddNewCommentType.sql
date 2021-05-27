CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewCommentType]
	@Name nvarchar
AS
	INSERT [CommentType] (Name)
	VALUES (@Name)