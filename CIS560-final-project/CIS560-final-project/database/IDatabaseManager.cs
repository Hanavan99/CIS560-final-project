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
        List<UserGroup> GetUsersInUserGroup(UserGroup UserGroup);// done?

        void AddUserToGroup(UserGroup UserGroup, User User, Role Role);

        void UpdateUserInGroup(UserGroup UserGroup, User User, Role Role);

        Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate);

        Task UpdateTask(Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, string DueDate, string StartDate, string CompletionDate);

        List<Task> GetTasksForOwner(User Owner);// done?
//
        List<Task> GetTasksForUserGroup(UserGroup UserGroup);
//
        TaskState CreateTaskState(string Name, string Description, string Color);

        TaskState UpdateTaskState(TaskState TaskState, string Name, string Description, string Color);

        List<TaskState> GetTaskStates();// done?

        Role CreateRole(string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT);

        Role UpdateRole(Role Role, string Name, bool CCreateT, bool CAssignT, bool CDeleteT, bool CModifyT);

        List<Role> GetRoles();// done?

    }


    public class DatabaseManagerImpl : IDatabaseManager
    {
        string connectionString = "Server=[server_name];Database=[database_name];Trusted_Connection=true";// PLEASE ENTER YOUR CONNECTION STRING HERE

        List<UserGroup> GetUsersInUserGroup(UserGroup userGroup)// done?
        {
            List<int> userID = new List<int>();
            List<string> userName = new List<string>();
            List<string> email = new List<string>();
            List<User> users = new List<User>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT UserID FROM Users.UserGroupUsers WHERE UserGroupID = " + userGroup.UserGroupID;
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    userID.Add(reader.GetInt(0));
                }
            }


            foreach (int i in userID)
            {
                query = "Select Name, Email From Users.Users Where UserID = " + i;
                cmd = SqlCommand(query, scon);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userName.Add(reader["Name"].GetValue(0).ToString());
                        email.Add(reader["Email"].GetValue(0).ToString());
                    }
                }
            }

            for (int i = 0; i < userID.Count; i++)
            {
                User tempUser = new User(userID[i], userName[i], email[i], "");
                users.Add(tempUser);
            }

            scon.Close();
            return users;
        }

        List<TaskState> GetTaskStates()// done?
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
                    TaskState tempTaskState = new TaskState(reader["TaskStateID"].GetValue(0).ToInt32(), reader["Name"].GetValue(0).ToString(), reader["Description"].GetValue(0).ToString(), reader["Color"].GetValue(0).ToString());
                    ts.Add(tempTaskState);
                }
            }

            scon.Close();
            return ts;
        }

        List<Role> GetRoles()// done?
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
                    Role tempRole = new Role(reader["RoleID"].GetValue(0).ToInt32(), reader["Name"].GetValue(0).ToString(), (bool)reader["CanCreateTasks"], (bool)reader["CanAssignTasks"], (bool)reader["CanDeleteTasks"], (bool)reader["CanModifyTasks"]);
                    roles.Add(tempRole);
                }
            }

            scon.Close();
            return roles;

        }

        List<Task> GetTasksForOwner(User Owner)// done?
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
                    Role tempTask = new Task(reader["TaskID"].GetValue(0).ToInt32(), 
                                        reader["Name"].GetValue(0).ToString(),
                                        reader["Description"].GetValue(0).ToString(),
                                        reader["OwnerUserID"].GetValue(0).ToInt32(),
                                        reader["TaskStateID"].GetValue(0).ToInt32(),
                                        (DateTime)reader["DueDate"], 
                                        (DateTime)reader["StartDate"], 
                                        (DateTime)reader["CompletionDate"]);

                    tasks.Add(tempTask);
                }
            }

            scon.Close();
            return tasks;
        }



    }// end of class
}// end of namespace
