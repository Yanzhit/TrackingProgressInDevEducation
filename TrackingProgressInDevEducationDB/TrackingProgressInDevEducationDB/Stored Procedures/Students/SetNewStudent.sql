CREATE PROCEDURE [TrackingProgressInDevEducationDB].[SetNewStudent]
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Rate Decimal(6,2),
	@GroupId int,
	@Phone nvarchar(50),
	@Email nvarchar(50),
	@Contract nvarchar(50),
	@Birthday date,
	@MiddleName nvarchar(50),
	@Git nvarchar(50),
	@CityId int,
	@Status BIT

AS
insert [Students] 
(
	[Name],
	[Surname],
	[Rate],
	[GroupId],
	[Phone],
	[Email],
	[Contract],
	[Birthday],
	[MiddleName],
	[Git],
	[CityId],
	[Status]
)
values 
(
	@Name,
	@Surname,
	@Rate,
	@GroupId,
	@Phone,
	@Email,
	@Contract,
	@Birthday,
	@MiddleName,
	@Git,
	@CityId,
	@Status
)