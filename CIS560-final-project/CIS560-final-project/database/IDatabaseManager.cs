using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_final_project.model;
using Task = CIS560_final_project.model.Task;
using System.Data;
using System.Data.SqlClient;

namespace CIS560_final_project.database
{
    public interface IDatabaseManager
    {

        User CreateUser(string Name, string Email, string Password);

        User UpdateUser(User user, string Name, string Email, string Password);

        bool VerifyUser(string Name, string Password);

        TaskCategory CreateTaskCategory(User Owner, string Name, string Description, string Color);

        TaskCategory UpdateTaskCategory(TaskCategory TaskCategory, User Owner, string Name, string Description, string Color);
//
        List<TaskCategory> GetTaskCategoriesForOwner(User Owner);

        List<TaskCategory> GetTaskCategories();
//
        UserGroup CreateUserGroup(User Owner, string Name, string Description);

        UserGroup UpdateUserGroup(UserGroup UserGroup, User Owner, string Name, string Description);
//
        List<UserGroup> GetUserGroupsForOwner(User Owner);

        List<UserGroup> GetUserGroupsForUser(User User);
//
        List<User> GetUsersInUserGroup(UserGroup UserGroup);// done?

        void AddUserToGroup(UserGroup UserGroup, User User, Role Role);

        void UpdateUserInGroup(UserGroup UserGroup, User User, Role Role);

        Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate);

        Task UpdateTask(Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate);

        List<Task> GetTasksForOwner(User Owner);// done?
//
        List<Task> GetTasksForUserGroup(UserGroup UserGroup);

        List<Task> GetTasksForUser(User User);
//
        TaskState CreateTaskState(string Name, string Description, string Color);

        TaskState UpdateTaskState(TaskState TaskState, string Name, string Description, string Color);

        List<TaskState> GetTaskStates();// done?

        Role CreateRole(string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT);

        Role UpdateRole(Role Role, string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT);

        List<Role> GetRoles();// done?

    }


    /*public class DatabaseManagerImpl : IDatabaseManager
    {
        readonly string connectionString = "Server=mssql.cs.ksu.edu;Database=hanavan;Trusted_Connection=true";// PLEASE ENTER YOUR CONNECTION STRING HERE

        public List<User> GetUsersInUserGroup(UserGroup UserGroup)// done?
        {
            List<User> users = new List<User>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Users.UserGroups UG INNER JOIN Users.UserGroupUsers UGU ON UG.UserGroupID = UGU.UserGroupID"
                            + "INNER JOIN Users.Users U ON UGU.UserID = U.UserID WHERE UG.UserGroupID = " + UserGroup.UserGroupID;
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    User tempUser = new User((int)reader["UserID"], (string)reader["Name"], (string)reader["Email"], (string)reader["PasswordHash"]);
                    users.Add(tempUser);
                }
            }

            scon.Close();
            return users;
        }

        public List<TaskState> GetTaskStates()// done?
        {
            List<TaskState> ts = new List<TaskState>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Tasks.TaskStates";
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    TaskState tempTaskState = new TaskState((int)reader["TaskStateID"], (string)reader["Name"], (string)reader["Description"], (string)reader["Color"]);
                    ts.Add(tempTaskState);
                }
            }

            scon.Close();
            return ts;
        }

        public List<Role> GetRoles()// done?
        {
            List<Role> roles = new List<Role>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Users.Roles";
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Role tempRole = new Role(int.Parse(reader["RoleID"].ToString()), reader["Name"].ToString(), reader["CanCreateTasks"].Equals(1) ? true : false, reader["CanAssignTasks"].Equals(1) ? true : false, reader["CanDeleteTasks"].Equals(1) ? true : false, reader["CanModifyTasks"].Equals(1) ? true : false);
                    roles.Add(tempRole);
                }
            }

            scon.Close();
            return roles;

        }

        public List<Task> GetTasksForOwner(User Owner)// done?
        {
            List<Task> tasks = new List<Task>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Tasks.Tasks WHERE OwnerUserID = " + Owner.UserID;
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Task tempTask = new Task(int.Parse(reader["TaskID"].ToString()), 
                                        reader["Name"].ToString(),
                                        reader["Description"].ToString(),
                                        int.Parse(reader["OwnerUserID"].ToString()),
                                        int.Parse(reader["OwnerUserID"].ToString()),
                                        int.Parse(reader["TaskStateID"].ToString()),
                                        reader["DueDate"].ToString(), 
                                        reader["StartDate"].ToString(), 
                                        reader["CompletionDate"].ToString());

                    tasks.Add(tempTask);
                }
            }

            scon.Close();
            return tasks;
        }

        public User CreateUser(string Name, string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user, string Name, string Email, string Password)
        {
            throw new NotImplementedException();
        }

        public bool VerifyUser(string Name, string Password)
        {
            throw new NotImplementedException();
        }

        public TaskCategory CreateTaskCategory(User Owner, string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public TaskCategory UpdateTaskCategory(TaskCategory TaskCategory, User Owner, string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public List<TaskCategory> GetTaskCategoriesForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<TaskCategory> GetTaskCategories()
        {
            throw new NotImplementedException();
        }

        public UserGroup CreateUserGroup(User Owner, string Name, string Description)
        {
            throw new NotImplementedException();
        }

        public UserGroup UpdateUserGroup(UserGroup UserGroup, User Owner, string Name, string Description)
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

        public void AddUserToGroup(UserGroup UserGroup, User User, Role Role)
        {
            throw new NotImplementedException();
        }

        public void UpdateUserInGroup(UserGroup UserGroup, User User, Role Role)
        {
            throw new NotImplementedException();
        }

        public Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate)
        {
            throw new NotImplementedException();
        }

        List<Task> IDatabaseManager.GetTasksForOwner(User Owner)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasksForUserGroup(UserGroup UserGroup)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasksForUser(User User)
        {
            throw new NotImplementedException();
        }

        public TaskState CreateTaskState(string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public TaskState UpdateTaskState(TaskState TaskState, string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        List<TaskState> IDatabaseManager.GetTaskStates()
        {
            throw new NotImplementedException();
        }

        public Role CreateRole(string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT)
        {
            throw new NotImplementedException();
        }

        public Role UpdateRole(Role Role, string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT)
        {
            throw new NotImplementedException();
        }

        List<Role> IDatabaseManager.GetRoles()
        {
            throw new NotImplementedException();
        }
    }// end of class*/
}// end of namespace
