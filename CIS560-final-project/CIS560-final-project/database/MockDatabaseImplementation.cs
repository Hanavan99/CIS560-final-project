using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_final_project.model;

namespace CIS560_final_project.database
{
    class MockDatabaseImplementation : IDatabaseManager
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

            UserGroup desktopSupport = new UserGroup(0, 0, "Desktop Support", "Provide end user support");
            _userGroups.Add(desktopSupport);

            _userRoleInGroup.Add(new Tuple<User, UserGroup>(wcabrera0, desktopSupport), owner);
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

        public model.Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate)
        {
            int currentTaskID = 0;
            model.Task task = new model.Task(currentTaskID, Name, Description, UserGroup.UserGroupID, Owner.UserID, TaskState.TaskStateID, DueDate, StartDate, CompletionDate);
            currentTaskID++;
            _tasks.Add(task);
            return task;
        }

        public TaskCategory CreateTaskCategory(User Owner, string Name, string Description, string Color)
        {
            int currentTaskCategoryID = 0;
            TaskCategory taskCategory = new TaskCategory(currentTaskCategoryID, Owner.UserID, Name, Description, Color);
            currentTaskCategoryID++;
            _taskCategories.Add(taskCategory);
            return taskCategory;
        }

        public TaskState CreateTaskState(string Name, string Description, string Color)
        {
            int currentTaskStateID = 0;
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
            UserGroup userGroup = new UserGroup(currentUserGroupID, Owner.UserID, Name, Description);
            currentUserGroupID++;
            _userGroups.Add(userGroup);
            return userGroup;
        }

        public List<Role> GetRoles()
        {
            throw new NotImplementedException();
        }

        public List<TaskCategory> GetTaskCategories()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public List<model.Task> GetTasksForUserGroup(UserGroup UserGroup)
        {
            throw new NotImplementedException();
        }

        public List<TaskState> GetTaskStates()
        {
            throw new NotImplementedException();
        }

        public List<UserGroup> GetUserGroupsForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<UserGroup> GetUserGroupsForUser(User User)
        {
            throw new NotImplementedException();
        }

        public List<UserGroup> GetUsersInUserGroup(UserGroup UserGroup)
        {
            throw new NotImplementedException();
        }

        public Role UpdateRole(Role Role, string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT)
        {
            throw new NotImplementedException();
        }

        public model.Task UpdateTask(model.Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate)
        {
            throw new NotImplementedException();
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

        public bool VerifyUser(string Name, string Password)
        {
            foreach (User userName in _users)
            {
                if (userName.Name == Name)
                    return true;
            }

            return false;
        }
    }
}
