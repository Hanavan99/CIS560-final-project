using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_final_project.model;
using Task = CIS560_final_project.model.Task;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CIS560_final_project.database
{
    public interface IDatabaseManager
    {

        User CreateUser(string name, string email, string password);

        User UpdateUser(User user, string name, string email, string password);

        User GetUserForUserName(string name);

        User VerifyUser(string name, string password);

        TaskCategory CreateTaskCategory(User owner, string name, string description, string color);

        TaskCategory UpdateTaskCategory(TaskCategory taskCategory, User owner, string name, string description, string color);

        List<TaskCategory> GetTaskCategoriesForOwner(User owner);

        List<TaskCategory> GetTaskCategories();

        UserGroup CreateUserGroup(User owner, string name, string description);

        UserGroup UpdateUserGroup(UserGroup userGroup, User owner, string name, string description);

        List<UserGroup> GetUserGroupsForOwner(User owner);

        List<UserGroup> GetUserGroupsForUser(User user);

        Dictionary<User, Role> GetUsersInUserGroup(UserGroup userGroup);

        KeyValuePair<User, Role> AddUserToUserGroup(UserGroup userGroup, User user, Role role);

        KeyValuePair<User, Role> UpdateUserInUserGroup(UserGroup userGroup, User user, Role role);

        Task CreateTask(string name, string description, UserGroup userGroup, User owner, TaskState taskState, DateTime dueDate, DateTime startDate, DateTime? completionDate, List<TaskCategory> taskCategories);

        Task UpdateTask(Task task, string name, string description, UserGroup userGroup, User owner, TaskState taskState, DateTime dueDate, DateTime startDate, DateTime? completionDate, List<TaskCategory> taskCategories);

        List<Task> GetTasksForOwner(User owner);

        List<Task> GetTasksForUserGroup(UserGroup userGroup);

        List<Task> GetTasksForUser(User user);

        TaskState CreateTaskState(string name, string description, string color);

        TaskState UpdateTaskState(TaskState taskState, string name, string description, string color);

        List<TaskState> GetTaskStates();

        Role CreateRole(string name, bool canCreateTasks, bool canAssignTasks, bool canDeleteTasks, bool canModifyTasks);

        Role UpdateRole(Role role, string name, bool canCreateTasks, bool canAssignTasks, bool canDeleteTasks, bool canModifyTasks);

        Role GetRoleForUser(User user);

        List<Role> GetRoles();

    }

}
