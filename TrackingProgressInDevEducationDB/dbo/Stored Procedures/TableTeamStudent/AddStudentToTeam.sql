CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddStudentToTeam]
	@StudentId int,
	@TeamId int
AS
	Insert [Team_Student]
	VALUES (@StudentId, @TeamId)
