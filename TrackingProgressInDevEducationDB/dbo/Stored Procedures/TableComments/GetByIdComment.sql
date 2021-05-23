CREATE PROCEDURE [dbo].[GetByIdComment](@id int)
AS
select [Text], [TypeId], [StudentId], [CreatedBy] from [Comments]
where [id] = @id