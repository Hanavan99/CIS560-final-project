--Show the number of completed and uncompleted tasks for a given user and the number of groups they are a part of
SELECT UU.UserID, UU.[Name], 
	(
		SELECT COUNT(*) AS NumberOfGroups
		FROM Users.UserGroupUsers UGU
			INNER JOIN Users.Users U ON U.UserID=UGU.UserID
		WHERE UU.UserID=U.UserID
	) AS NumberOfUserGroupsUserIsAMemberOf,
	(
		SELECT COUNT(*) AS NumberOfTasks
		FROM Users.Users U
			INNER JOIN Users.UserGroupUsers UGU ON UGU.UserID=U.UserID
			INNER JOIN Tasks.Tasks T ON T.UserGroupID=UGU.UserGroupID
		WHERE T.CompletionDate <= T.DueDate
			AND UU.UserID=U.UserID
	) AS TasksCompletedOnTime,
	(
		SELECT COUNT(*) AS NumberOfTasks
		FROM Users.Users U
			INNER JOIN Users.UserGroupUsers UGU ON UGU.UserID=U.UserID
			INNER JOIN Tasks.Tasks T ON T.UserGroupID=UGU.UserGroupID
		WHERE T.CompletionDate > T.DueDate
			AND UU.UserID=U.UserID
	) AS TasksNotCompleted
FROM Users.Users UU;

-- get percentage of tasks completed per user group
SELECT
	UG.[Name] AS [User Group],
	COUNT(T.TaskID) AS [Task Count],
	CAST((
		SELECT
			COUNT(*)
		FROM Tasks.Tasks T
		WHERE T.CompletionDate IS NOT NULL AND T.UserGroupID = UG.UserGroupID
	) * 100.0 / COUNT(T.TaskID) AS DECIMAL(3, 1)) AS [Percent Completed] 
FROM Users.UserGroups UG
	INNER JOIN Tasks.Tasks T ON UG.UserGroupID = T.UserGroupID
GROUP BY UG.UserGroupID, UG.[Name]

-- get average completion time for tasks in a specific user group
SELECT
	UG.[Name] AS [User Group],
	(
		SELECT
			AVG(DATEDIFF(DAY, T.StartDate, T.CompletionDate))
		FROM Tasks.Tasks T
		WHERE T.CompletionDate IS NOT NULL AND T.UserGroupID = UG.UserGroupID
	) AS [Average Completion Time (Days)]
FROM Users.UserGroups UG
ORDER BY [Average Completion Time (Days)] ASC;

-- get number of tasks completed per day in the last 30 days
WITH DateTable
AS
(
    SELECT CAST(DATEADD(MONTH, -1, SYSDATETIMEOFFSET()) AS DATE) AS [Date]
    UNION ALL
    SELECT DATEADD(DAY, 1, [Date])
    FROM DateTable
    WHERE DATEADD(DAY, 1, [Date]) <= CAST(SYSDATETIMEOFFSET() AS DATE)
)
SELECT
	DateTable.[Date],
	COUNT(T.TaskID) AS TaskCount
FROM Tasks.Tasks T
	RIGHT JOIN DateTable ON DateTable.[Date] = CAST(T.CompletionDate AS DATE)
GROUP BY DateTable.[Date], CAST(T.CompletionDate AS DATE)
ORDER BY DateTable.[Date] DESC;