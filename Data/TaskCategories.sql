insert into Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'High Priority', N'ffa500');
insert into Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Mid Priority', N'ffff00');
insert into Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Low Priority', N'008000');
insert into Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Production System', N'ff0000');
insert into Tasks.TaskCategories (OwnerID, [Name], Color) values ((SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), N'Development Priority', N'0000ff');

--(SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0')