insert into Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Owner', 1, 1, 1, 1);
insert into Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Member', 1, 0, 0, 1);
insert into Users.Roles ([Name], CanCreateTasks, CanAssignTasks, CanDeleteTasks, CanModifyTasks) values (N'Guest', 0, 0, 0, 0);