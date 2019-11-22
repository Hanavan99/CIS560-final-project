DROP TABLE IF EXISTS Tasks.TaskTaskCategories;
DROP TABLE IF EXISTS Tasks.Tasks;
DROP TABLE IF EXISTS Tasks.TaskCategories;
DROP TABLE IF EXISTS Tasks.TaskStates;
DROP TABLE IF EXISTS Users.UserGroupUsers;
DROP TABLE IF EXISTS Users.UserGroups;
DROP TABLE IF EXISTS Users.Users;
DROP TABLE IF EXISTS Users.Roles;

DROP SCHEMA IF EXISTS Tasks;
DROP SCHEMA IF EXISTS Users;
GO

CREATE SCHEMA Tasks;
GO

CREATE SCHEMA Users;
GO

CREATE TABLE Users.Roles (
	RoleID INT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(64) NOT NULL UNIQUE,
	CanCreateTasks BIT NOT NULL,
	CanAssignTasks BIT NOT NULL,
	CanDeleteTasks BIT NOT NULL,
	CanModifyTasks BIT NOT NULL

	CONSTRAINT PK_Users_Roles_RoleID PRIMARY KEY(RoleID)
);

CREATE TABLE Users.Users (
	UserID INT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(64) NOT NULL UNIQUE,
	Email NVARCHAR(64) NOT NULL UNIQUE,
	PasswordHash VARCHAR(64) NOT NULL

	CONSTRAINT PK_Users_Users_UserID PRIMARY KEY(UserID)
);

CREATE TABLE Users.UserGroups (
	UserGroupID INT NOT NULL IDENTITY(1, 1),
	GroupOwnerID INT NOT NULL,
	[Name] NVARCHAR(64) NOT NULL UNIQUE,
	[Description] NVARCHAR(512)

	CONSTRAINT PK_Users_UserGroups_UserGroupID PRIMARY KEY(UserGroupID),
	CONSTRAINT FK_Users_UserGroups_GroupOwnerID FOREIGN KEY(GroupOwnerID) REFERENCES Users.Users(UserID)
);

CREATE TABLE Users.UserGroupUsers (
	UserGroupID INT NOT NULL,
	UserID INT NOT NULL,
	RoleID INT NOT NULL,

	CONSTRAINT PK_Users_UserGroupUsers_UserID_UserGroupID PRIMARY KEY(UserID, UserGroupID),
	CONSTRAINT FK_Users_UserGroupUsers_UserGroupID FOREIGN KEY(UserGroupID) REFERENCES Users.UserGroups(UserGroupID),
	CONSTRAINT FK_Users_UserGroupUsers_UserID FOREIGN KEY(UserID) REFERENCES Users.Users(UserID),
	CONSTRAINT FK_Users_UserGroupUsers_RoleID FOREIGN KEY(RoleID) REFERENCES Users.Roles(RoleID)
);

CREATE TABLE Tasks.TaskStates (
	TaskStateID INT NOT NULL IDENTITY(1, 1),
	[Name] NVARCHAR(64) NOT NULL,
	[Description] NVARCHAR(512),
	Color CHAR(6) NOT NULL DEFAULT('000000')

	CONSTRAINT PK_Tasks_TaskStates_TaskStateID PRIMARY KEY(TaskStateID),
	CONSTRAINT CC_Tasks_TaskStates_Color CHECK(Color LIKE '[0-9A-F][0-9A-F][0-9A-F][0-9A-F][0-9A-F][0-9A-F]')
);

CREATE TABLE Tasks.Tasks (
	TaskID INT NOT NULL IDENTITY(1, 1),
	Name NVARCHAR(64) NOT NULL,
	Description NVARCHAR(256) NOT NULL,
	OwnerUserID INT,
	TaskStateID INT,
	DueDate DATETIME2 NOT NULL,
	StartDate DATETIME2 NOT NULL,
	CompletionDate DATETIME2 NOT NULL

	CONSTRAINT PK_Tasks_Tasks_TaskID PRIMARY KEY(TaskID),
	CONSTRAINT FK_Tasks_Tasks_OwnerUserID FOREIGN KEY(OwnerUserID) REFERENCES Users.Users(UserID),
	CONSTRAINT FK_Tasks_Tasks_TaskStateID FOREIGN KEY (TaskStateID) REFERENCES Tasks.TaskStates(TaskStateID)
);

CREATE TABLE Tasks.TaskCategories (
	TaskCategoryID INT NOT NULL IDENTITY(1, 1),
	OwnerID INT,
	[Name] NVARCHAR(64) NOT NULL UNIQUE,
	[Description] NVARCHAR(512),
	Color CHAR(6) NOT NULL DEFAULT('000000')

	CONSTRAINT PK_Tasks_TaskCategories_TaskCategoryID PRIMARY KEY(TaskCategoryID),
	CONSTRAINT FK_Tasks_TaskCategories_OwnerID FOREIGN KEY(OwnerID) REFERENCES Users.Users(UserID),
	CONSTRAINT CC_Tasks_TaskCategories_Color CHECK(Color LIKE '[0-9A-F][0-9A-F][0-9A-F][0-9A-F][0-9A-F][0-9A-F]')
);

CREATE TABLE Tasks.TaskTaskCategories (
	TaskID INT NOT NULL,
	TaskCategoryID INT NOT NULL

	CONSTRAINT PK_Tasks_TaskTaskCategories_TaskID_TaskCategoryID PRIMARY KEY(TaskID, TaskCategoryID)
);