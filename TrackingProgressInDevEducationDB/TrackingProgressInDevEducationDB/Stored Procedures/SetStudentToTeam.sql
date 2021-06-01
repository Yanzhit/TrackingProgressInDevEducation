CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetStudentToTeam]
	@StudentId int,
	@TeamId int
AS
	Insert [Team_Student]
	VALUES (@StudentId, @TeamId)