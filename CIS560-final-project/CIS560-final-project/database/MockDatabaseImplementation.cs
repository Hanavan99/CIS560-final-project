﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_final_project.model;

namespace CIS560_final_project.database
{
    class MockDatabaseImplementation //: IDatabaseManager
    {
        List<Role> _roles = new List<Role>();
        List<User> _users = new List<User>();
        List<UserGroup> _userGroups = new List<UserGroup>();
        Dictionary<Tuple<User, UserGroup>, Role> _userRoleInGroup = new Dictionary<Tuple<User, UserGroup>, Role>();

        List<model.Task> _tasks = new List<model.Task>();
        List<TaskCategory> _taskCategories = new List<TaskCategory>();
        List<TaskState> _taskStates = new List<TaskState>();

        public MockDatabaseImplementation()
        {
            User wcabrera0 = new User(0, "wcabrera0", "msouthworth0@virginia.edu", "9f4dca77c2be9c1549cb1c246cdbc34ff6785508");
            _users.Add(wcabrera0);

            User demo = new User(1, "demo", "demo@demo.com", "demo");
            _users.Add(demo);

            Role owner = new Role(0, "Owner", true, true, true, true);
            _roles.Add(owner);

            UserGroup desktopSupport = new UserGroup(0, wcabrera0, "Desktop Support", "Provide end user support");
            _userGroups.Add(desktopSupport);

            _userRoleInGroup.Add(new Tuple<User, UserGroup>(wcabrera0, desktopSupport), owner);
            _userRoleInGroup.Add(new Tuple<User, UserGroup>(demo, desktopSupport), owner);

            TaskState notStarted = new TaskState(0, "Not Started", "", "D3D3D3");
            _taskStates.Add(notStarted);

            List<TaskCategory> testTaskCategories = new List<TaskCategory>();
            TaskCategory highPriority = new TaskCategory(0, wcabrera0, "High Priority", "", "ffa500");
            testTaskCategories.Add(highPriority);

            DateTime date1 = new DateTime(2019, 12, 1, 0, 0, 0);
            DateTime date2 = new DateTime(2019, 11, 1, 0, 0, 0);
            DateTime date3 = new DateTime(2019, 12, 1, 0, 0, 0);

            _tasks.Add(new model.Task(0, "Testing", "A desc", desktopSupport, demo, notStarted, date1 , date2, date3, testTaskCategories));
        }

        public void AddUserToGroup(UserGroup UserGroup, User User, Role Role)
        {
            _userRoleInGroup.Add(new Tuple<User, UserGroup>(User, UserGroup), Role);
        }

        public Role CreateRole(string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT)
        {
            int currentRoleID = 1;
            Role role = new Role(currentRoleID, Name, CCreateT, CAssignT, CDeleteT, CModifyT);
            _roles.Add(role);
            currentRoleID++;
            return role;
        }

        public model.Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, DateTime DueDate, DateTime StartDate, DateTime? CompletionDate, List<TaskCategory> TaskCategories)
        {
            int currentTaskID = 0;
            model.Task task = new model.Task(currentTaskID, Name, Description, UserGroup, Owner, TaskState, DueDate, StartDate, CompletionDate, TaskCategories);
            currentTaskID++;
            _tasks.Add(task);
            return task;
        }

        public TaskCategory CreateTaskCategory(User Owner, string Name, string Description, string Color)
        {
            int currentTaskCategoryID = 1;
            TaskCategory taskCategory = new TaskCategory(currentTaskCategoryID, Owner, Name, Description, Color);
            currentTaskCategoryID++;
            _taskCategories.Add(taskCategory);
            return taskCategory;
        }

        public TaskState CreateTaskState(string Name, string Description, string Color)
        {
            int currentTaskStateID = 1;
            TaskState taskState = new TaskState(currentTaskStateID, Name, Description, Color);
            _taskStates.Add(taskState);
            currentTaskStateID++;
            return taskState;
        }

        public User CreateUser(string Name, string Email, string Password)
        {
            int currentUserID = 2;
            User user = new User(currentUserID, Name, Email, Password);
            _users.Add(user);
            currentUserID++;
            return user;
        }

        public UserGroup CreateUserGroup(User Owner, string Name, string Description)
        {
            int currentUserGroupID = 1;
            UserGroup userGroup = new UserGroup(currentUserGroupID, Owner, Name, Description);
            currentUserGroupID++;
            _userGroups.Add(userGroup);
            return userGroup;
        }

        public List<Role> GetRoles()
        {
            return _roles;
        }

        public List<TaskCategory> GetTaskCategories()
        {
            return _taskCategories;
        }

        public List<TaskCategory> GetTaskCategoriesForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<model.Task> GetTasksForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<model.Task> GetTasksForUser(User User)
        {
            List<model.Task> filteredTasks = new List<model.Task>();

            foreach (KeyValuePair<Tuple<User, UserGroup>, Role> userGroup in _userRoleInGroup)
            {
                if (userGroup.Key.Item1.UserID == User.UserID)
                {
                    foreach(model.Task aTask in _tasks)
                    {
                        if(aTask.UserGroup.UserGroupID == userGroup.Key.Item2.UserGroupID)
                        {
                            filteredTasks.Add(aTask);
                        }
                    }
                }
            }

            return filteredTasks;
        }

        public List<model.Task> GetTasksForUserGroup(UserGroup UserGroup)
        {
            List<model.Task> filteredTasks = new List<model.Task>();

            foreach (model.Task aTask in _tasks)
            {
              if (aTask.UserGroup.UserGroupID == UserGroup.UserGroupID)
              {
                filteredTasks.Add(aTask);
              }
            }

            return filteredTasks;
        }

        public List<TaskState> GetTaskStates()
        {
            return _taskStates;
        }

        public List<UserGroup> GetUserGroupsForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<UserGroup> GetUserGroupsForUser(User User)
        {
            List<UserGroup> filterdUserGroups = new List<UserGroup>();

            foreach (KeyValuePair<Tuple<User, UserGroup>, Role> userGroup in _userRoleInGroup)
            {
                if (userGroup.Key.Item1.UserID == User.UserID)
                {
                    filterdUserGroups.Add(userGroup.Key.Item2);
                }
            }

            return filterdUserGroups;
        }

        public List<User> GetUsersInUserGroup(UserGroup UserGroup)
        {
            List<User> filteredUsers = new List<User>();

            foreach (KeyValuePair<Tuple<User, UserGroup>, Role> userGroup in _userRoleInGroup)
            {
                if (userGroup.Key.Item2.UserGroupID == UserGroup.UserGroupID)
                {
                    filteredUsers.Add(userGroup.Key.Item1);
                }
            }

            return filteredUsers;
        }

        public Role UpdateRole(Role Role, string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT)
        {
            throw new NotImplementedException();
        }

        public model.Task UpdateTask(model.Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, DateTime DueDate, DateTime StartDate, DateTime? CompletionDate, List<TaskCategory> TaskCategories)
        {
            foreach (model.Task aTask in _tasks)
            {
                if(aTask.TaskID == Task.TaskID)
                {
                    int id = aTask.TaskID;
                    _tasks.Remove(aTask);
                    model.Task task = new model.Task(id, Name, Description, UserGroup, Owner, TaskState, DueDate, StartDate, CompletionDate, TaskCategories);
                    _tasks.Add(task);
                    return task;
                }
            }

            return null;
        }

        public TaskCategory UpdateTaskCategory(TaskCategory TaskCategory, User Owner, string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public TaskState UpdateTaskState(TaskState TaskState, string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user, string Name, string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public UserGroup UpdateUserGroup(UserGroup UserGroup, User Owner, string Name, string Description)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserInGroup(UserGroup UserGroup, User User, Role Role)
        {
            throw new NotImplementedException();
        }

        public User VerifyUser(string Name, string Password)
        {
            foreach (User userName in _users)
            {
                if (userName.Name == Name)
                    return userName;
            }

            return null;
        }
    }
}
