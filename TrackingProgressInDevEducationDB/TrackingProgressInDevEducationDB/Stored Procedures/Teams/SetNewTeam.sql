CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewTeam](@Name nvarchar(50))
AS 
insert [Teams] ([Name])
values (@Name)