CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewHW](@Name nvarchar(50))
AS
insert [Homeworks] ([Name])
values (@Name)