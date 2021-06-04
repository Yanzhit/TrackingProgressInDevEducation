CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetVisitsScore]
	@StudentId int
AS
DECLARE @TableMain Table(id int, StatusOn bit)
DECLARE @TableFirstTrimestr Table(id int, StatusOn bit, startDate datetime, studId int)
DECLARE @TableSecondTrimestr Table(id int, StatusOn bit, startDate datetime, studId int)
DECLARE @TableThirdTrimestr Table(id int, StatusOn bit, startDate datetime, studId int)
DECLARE @result Table(firstTrim DECIMAL(5,2), secondTrim DECIMAL(5,2), thirdTrim DECIMAL(5,2), General DECIMAL(5,2))


INSERT INTO @TableMain (id, StatusOn)

SELECT ROW_NUMBER() OVER(ORDER BY V.id ASC) AS RowNumber
	,V.VisitStatus
	FROM TrackingProgressInDevEducationDB.Visits V
	JOIN TrackingProgressInDevEducationDB.Lections L ON L.id = V.LectionId
	WHERE V.StudentId = @StudentId

INSERT INTO @TableFirstTrimestr (id, StatusOn)
SELECT [@TableMain].id, StatusOn FROM @TableMain WHERE id <= 12

INSERT INTO @TableSecondTrimestr (id, StatusOn)
SELECT [@TableMain].id, StatusOn FROM @TableMain WHERE id Between 13 AND 24

INSERT INTO @TableThirdTrimestr (id, StatusOn)
SELECT [@TableMain].id, StatusOn FROM @TableMain WHERE id Between 25 AND 36

INSERT INTO @result(firstTrim, secondTrim, thirdTrim, General)
SELECT
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableFirstTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableFirstTrimestr)  * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableSecondTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableSecondTrimestr) * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableThirdTrimestr WHERE StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL (5,2)) FROM @TableThirdTrimestr) * 100,
	(SELECT CAST(COUNT(*)AS DECIMAL(5,2)) FROM @TableMain WHERE [@TableMain].StatusOn = 1) / (SELECT CAST(COUNT(*)AS DECIMAL(5,2)) FROM @TableMain) * 100

select * from @result
