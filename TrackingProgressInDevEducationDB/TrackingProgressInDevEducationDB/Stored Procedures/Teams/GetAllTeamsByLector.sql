CREATE PROCEDURE [TrackingProgressInDevEducationDB].[GetAllTeamsByLector]
	@LectorId int
AS
	Select
 T.id
,T.Name
,G.id
,COUNT(T.id) StudentCount
FROM Teams T
LEFT JOIN Team_Student TS ON T.id = TS.TeamId
LEFT JOIN Students S ON S.id = TS.StudentId
LEFT JOIN Groups G ON G.id = S.GroupId
LEFT JOIN Lector_Group LG ON LG.GroupId = G.id
LEFT JOIN Lectors L ON L.id = LG.LectorId
WHERE L.id = @LectorId
GROUP BY T.Name, T.id, G.id