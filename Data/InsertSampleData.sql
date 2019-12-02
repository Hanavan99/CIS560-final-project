--Users.Roles
INSERT INTO Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Owner', 1, 1, 1, 1);
INSERT INTO Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Member', 1, 0, 0, 1);
INSERT INTO Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Guest', 0, 0, 0, 0);

--Users.Users
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('wcabrera0', 'msouthworth0@virginia.edu', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('abeddall1', 'pfeatonby1@timesonline.co.uk', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('esandal2', 'mhucknall2@live.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('kcarnell3', 'ssatchel3@php.net', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('twhorlton4', 'talven4@mozilla.org', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('bcrunkhurn5', 'dchisman5@reverbnation.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('brosson6', 'rflegg6@blogspot.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('sfleming7', 'dband7@drupal.org', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('afairest8', 'sbarclay8@yale.edu', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('semberson9', 'bbrockhouse9@stumbleupon.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('pweinera', 'rmuzzia@geocities.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('tpenniellb', 'iodlinb@xrea.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('rspowagec', 'mistonc@google.com.au', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('tgurnerd', 'lhickinbottomd@blogtalkradio.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('bderislye', 'rschottlie@whitehouse.gov', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('acumesf', 'llovef@unc.edu', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('asiggeryg', 'lkorneichukg@homestead.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('scoopeyh', 'cpatnellih@answers.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('emccarrelli', 'mcalwelli@yelp.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('fmcquodej', 'lcowthardj@comsenz.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('demo', 'demo@demo.com', PWDENCRYPT('test'));
INSERT INTO Users.Users (Name, Email, PasswordHash) values ('demo2', 'demo2@demo.com', PWDENCRYPT('test'));

--Users.UserGroups
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Desktop Support', N'Provide end user support');
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'abeddall1'), N'Patching', N'Update and maintain OS and software');
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'esandal2'), N'Networking and Security', N'Provide and maintain a network and its security');
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'kcarnell3'), N'Web', N'Maintain and update website');
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'twhorlton4'), N'Hardware', N'Build and repair computers');
INSERT INTO Users.UserGroups (GroupOwnerID, [Name], [Description]) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'demo2'), N'560Testing', N'Test group for the presentation');


--Users.UserGroupUsers
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'abeddall1'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'esandal2'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'kcarnell3'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'twhorlton4'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'bcrunkhurn5'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'brosson6'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'sfleming7'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'afairest8'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'semberson9'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'pweinera'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'tpenniellb'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'rspowagec'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'tgurnerd'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'bderislye'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'acumesf'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'asiggeryg'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'scoopeyh'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'emccarrelli'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'fmcquodej'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'demo'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
INSERT INTO Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'560Testing'), (SELECT UserID FROM Users.Users WHERE [Name] = N'demo2'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));

--Tasks.TaskStates
INSERT INTO Tasks.TaskStates ([Name], [Description], Color) values (N'Not Started', N'', N'D3D3D3');
INSERT INTO Tasks.TaskStates ([Name], [Description], Color) values (N'In Progress', N'', N'00ffff');
INSERT INTO Tasks.TaskStates ([Name], [Description], Color) values (N'Completed', N'', N'008000');
INSERT INTO Tasks.TaskStates ([Name], [Description], Color) values (N'On Hold', N'', N'ffff00');

--Tasks.Tasks
INSERT INTO Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Create new user', N'Create an account on the network for new hire', (SELECT UserID FROM Users.Users WHERE [Name] = N'esandal2'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-25', '2019-11-18', '2019-11-25');
INSERT INTO Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Computer won''t power on', N'Trouble shoot to determine cause of problem and determine if new computer is needed', (SELECT UserID FROM Users.Users WHERE [Name] = N'twhorlton4'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-24', '2019-11-17', '2019-11-24');
INSERT INTO Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Update Roster', N'The web page needs to reflect the current workforce. Update the roster to include new hires.', (SELECT UserID FROM Users.Users WHERE [Name] = N'kcarnell3'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'In Progress'), '2019-11-20', '2019-11-13', '2019-11-20');
INSERT INTO Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Update Accounting Software', N'A new update has been release for the accounting software we use and it needs to be updated.', (SELECT UserID FROM Users.Users WHERE [Name] = N'abeddall1'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'Completed'), '2019-11-19', '2019-11-12', '2019-11-19');
INSERT INTO Tasks.Tasks ([Name], [Description], OwnerUserID, TaskStateID, DueDate, StartDate, CompletionDate) values 
	(N'Email is not loading.', N'Email keeps loading forever', (SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), (SELECT TaskStateID FROM Tasks.TaskStates WHERE [Name] = N'Completed'), '2019-10-10', '2019-10-7', '2019-10-10');

--Tasks.TaskCategories
INSERT INTO Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'High Priority', N'ffa500');
INSERT INTO Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Mid Priority', N'ffff00');
INSERT INTO Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Low Priority', N'008000');
INSERT INTO Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Production System', N'ff0000');
INSERT INTO Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Development Priority', N'0000ff');

--Tasks.TaskTaskCategories
INSERT INTO Tasks.TaskTaskCategories (TaskID, TaskCategoryID) values ((SELECT TaskID FROM Tasks.Tasks WHERE [Name] = N'Create new user'), (SELECT TaskCategoryID FROM Tasks.TaskCategories WHERE [Name] = N'Mid Priority'));
INSERT INTO Tasks.TaskTaskCategories (TaskID, TaskCategoryID) values ((SELECT TaskID FROM Tasks.Tasks WHERE [Name] = N'Computer won''t power on'), (SELECT TaskCategoryID FROM Tasks.TaskCategories WHERE [Name] = N'Mid Priority'));
INSERT INTO Tasks.TaskTaskCategories (TaskID, TaskCategoryID) values ((SELECT TaskID FROM Tasks.Tasks WHERE [Name] = N'Update Roster'), (SELECT TaskCategoryID FROM Tasks.TaskCategories WHERE [Name] = N'Low Priority'));
INSERT INTO Tasks.TaskTaskCategories (TaskID, TaskCategoryID) values ((SELECT TaskID FROM Tasks.Tasks WHERE [Name] = N'Update Accounting Software'), (SELECT TaskCategoryID FROM Tasks.TaskCategories WHERE [Name] = N'High Priority'));
INSERT INTO Tasks.TaskTaskCategories (TaskID, TaskCategoryID) values ((SELECT TaskID FROM Tasks.Tasks WHERE [Name] = N'Email is not loading.'), (SELECT TaskCategoryID FROM Tasks.TaskCategories WHERE [Name] = N'Mid Priority'));
