CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetStudentByIdJ](@id int)
AS
select [Name], [Surname], [Rate] from [Students]
where [id] = @id