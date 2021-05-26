CREATE PROCEDURE [dbo].[GetGroupsByLector]
	@LectorId int
AS
SELECT 
	 G.id
	,G.[Name]
	,G.StartDate
	,G.EndDate
	,C.[Name]
	,COUNT(S.id) [StudCount]
	FROM Groups G
	LEFT JOIN Lector_Group LG ON G.id = LG.GroupId
	LEFT JOIN Lectors L ON L.id = LG.LectorId
	LEFT JOIN Students S ON S.GroupId = G.id
	JOIN Courses C ON C.id = G.CourseId
	WHERE L.id = 1
	GROUP BY G.[Name], G.StartDate,C.[Name], G.id, G.EndDate
