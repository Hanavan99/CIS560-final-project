insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'abeddall1'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'esandal2'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'kcarnell3'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'twhorlton4'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Owner'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'bcrunkhurn5'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'brosson6'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Desktop Support'), (SELECT UserID FROM Users.Users WHERE [Name] = N'sfleming7'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'afairest8'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'semberson9'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'pweinera'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Patching'), (SELECT UserID FROM Users.Users WHERE [Name] = N'tpenniellb'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'rspowagec'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'tgurnerd'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Networking and Security'), (SELECT UserID FROM Users.Users WHERE [Name] = N'bderislye'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'acumesf'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'asiggeryg'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Web'), (SELECT UserID FROM Users.Users WHERE [Name] = N'scoopeyh'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'emccarrelli'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));
insert into Users.UserGroupUsers (UserGroupID, UserID, RoleID) values 
	((SELECT UserGroupID FROM Users.UserGroups WHERE [Name] = N'Hardware'), (SELECT UserID FROM Users.Users WHERE [Name] = N'fmcquodej'), (SELECT RoleID FROM Users.Roles WHERE [Name] = N'Member'));


--(SELECT UserID FROM Users.Users WHERE [Name] = N'wcabrera0')