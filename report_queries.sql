-- get percentage of tasks completed per user group
SELECT
	--UG.UserGroupID,
	UG.[Name],
	COUNT(T.TaskID) AS TaskCount,
	CAST((
		SELECT
			COUNT(*)
		FROM Tasks.Tasks T
		WHERE T.CompletionDate IS NOT NULL AND T.UserGroupID = UG.UserGroupID
	) * 100.0 / COUNT(T.TaskID) AS DECIMAL(3, 1)) AS CompletedPercent 
FROM Users.UserGroups UG
	INNER JOIN Tasks.Tasks T ON UG.UserGroupID = T.UserGroupID
GROUP BY UG.UserGroupID, UG.[Name]