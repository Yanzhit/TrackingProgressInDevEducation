CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewTeam](@Name nvarchar(50))
AS 
insert [Teams] ([Name])
values (@Name)