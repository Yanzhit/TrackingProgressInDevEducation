CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetVisitsScore]
	@StudentId int
AS
DECLARE @TableMain Table(Id int, StatusOn bit)
DECLARE @TableFirstTrimestr Table(Id int, StatusOn bit, startDate datetime, studId int)
DECLARE @TableSecondTrimestr Table(Id int, StatusOn bit, startDate datetime, studId int)
DECLARE @TableThirdTrimestr Table(Id int, StatusOn bit, startDate datetime, studId int)
DECLARE @result Table(firstTrim DECIMAL(5,2), secondTrim DECIMAL(5,2), thirdTrim DECIMAL(5,2), General DECIMAL(5,2))


INSERT INTO @TableMain (Id, StatusOn)

SELECT ROW_NUMBER() OVER(ORDER BY V.Id ASC) AS RowNumber
	,V.VisitStatus
	FROM TrackingProgressInDevEducationDB.Visits V
	JOIN TrackingProgressInDevEducationDB.Lections L ON L.id = V.LectionId
	WHERE V.StudentId = @StudentId

INSERT INTO @TableFirstTrimestr (Id, StatusOn)
SELECT [@TableMain].Id, StatusOn FROM @TableMain WHERE Id <= 12

INSERT INTO @TableSecondTrimestr (id, StatusOn)
SELECT [@TableMain].Id, StatusOn FROM @TableMain WHERE Id Between 13 AND 24

INSERT INTO @TableThirdTrimestr (id, StatusOn)
SELECT [@TableMain].Id, StatusOn FROM @TableMain WHERE Id Between 25 AND 36

INSERT INTO @result(firstTrim, secondTrim, thirdTrim, General)
SELECT
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableFirstTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableFirstTrimestr)  * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableSecondTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableSecondTrimestr) * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableThirdTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableThirdTrimestr) * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL(5,2)) FROM @TableMain WHERE [@TableMain].StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL(5,2)) FROM @TableMain) * 100

select * from @result
