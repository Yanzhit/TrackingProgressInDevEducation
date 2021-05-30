CREATE PROCEDURE [TrackingProgressInDevEducationDB].[AddNewStudent](@Name nvarchar(50), @Surname nvarchar(50), @Rate Decimal(6,2))
AS
insert [Students] ([Name], [Surname], [Rate])
values (@Name, @Surname, @Rate)