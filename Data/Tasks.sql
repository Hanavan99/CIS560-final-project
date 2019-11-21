insert into Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Create new user', N'Create an account on the network for new hire', (SELECT UserID FROM Users.Users WHERE [Name] = N'esandal2'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-25', '2019-11-18', '2019-11-25');
insert into Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Computer won''t power on', N'Trouble shoot to determine cause of problem and determine if new computer is needed', (SELECT UserID FROM Users.Users WHERE [Name] = N'twhorlton4'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-24', '2019-11-17', '2019-11-24');
insert into Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Update Roster', N'The web page needs to reflect the current workforce. Update the roster to include new hires.', (SELECT UserID FROM Users.Users WHERE [Name] = N'kcarnell3'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-20', '2019-11-13', '2019-11-20');
insert into Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Update Accounting Software', N'A new update has been release for the accounting software we use and it needs to be updated.', (SELECT UserID FROM Users.Users WHERE [Name] = N'abeddall1'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'Completed'), '2019-11-19', '2019-11-12', '2019-11-19');
insert into Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Email is not loading.', N'Email keeps loading forever', (SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'Completed'), '2019-10-10', '2019-10-7', '2019-10-10');




--(SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress')