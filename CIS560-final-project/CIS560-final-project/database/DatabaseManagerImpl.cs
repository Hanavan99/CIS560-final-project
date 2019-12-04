using CIS560_final_project.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = CIS560_final_project.model.Task;

namespace CIS560_final_project.database
{
    class DatabaseManagerImpl : IDatabaseManager
    {
        string connectionString;

        public DatabaseManagerImpl()
        {
            try
            {
                StreamReader reader = new StreamReader("D:/CIS560/sqlconnstr.txt");
                connectionString = reader.ReadLine();
                reader.Close();
            }
            catch (IOException e)
            {
                MessageBox.Show("Failed to read SQL string");
            }
        }

        public List<User> GetUsersInUserGroup(UserGroup UserGroup)// done
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
                    UserGroup tempUserGroup = new UserGroup((int)reader["UserGroup"], Owner, reader["Name"].ToString(), reader["Description"].ToString());
                    TaskState tempTaskState = new TaskState((int)reader["TaskStateID"], reader["Name"].ToString(), reader["Description"].ToString(), reader["Color"].ToString());
                    Task tempTask = new Task(int.Parse(reader["TaskID"].ToString()),
                                        reader["Name"].ToString(),
                                        reader["Description"].ToString(),
                                        tempUserGroup,
                                        Owner,
                                        tempTaskState,
                                        (DateTime)reader["DueDate"],
                                        (DateTime)reader["StartDate"],
                                        (DateTime)reader["CompletionDate"], null);

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

        public User VerifyUser(string Name, string Password)//done?
        {
            User tempUser;
            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Users.Users UU WHERE UU.Name = '" + Name + "' and PWDCOMPARE('" + Password + "', UU.PasswordHash) = 1";
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    tempUser = new User((int)reader["UserID"], (string)reader["Name"], (string)reader["Email"], null);
                }
                else
                {
                    tempUser = null;
                }
            }
            scon.Close();
            return tempUser;
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

        public Task CreateTask(string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, DateTime DueDate, DateTime StartDate, DateTime? CompletionDate, List<TaskCategory> TaskCategories)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            scon.Open();

            string query = "INSERT INTO Tasks.Tasks([Name], [Description], OwnerUserID, UserGroupID, TaskStateID, DueDate, StartDate, CompletionDate) OUTPUT INSERTED.TaskID values (@Name, @Description, @OwnerUserID, @UserGroupID, @TaskStateID, @DueDate, @StartDate, @CompletionDate)";
            SqlCommand cmd = new SqlCommand(query, scon);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@OwnerUserID", Owner.UserID);
            cmd.Parameters.AddWithValue("@UserGroupID", UserGroup.UserGroupID);
            cmd.Parameters.AddWithValue("@TaskStateID", TaskState.TaskStateID);
            cmd.Parameters.AddWithValue("@DueDate", DueDate);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@CompletionDate", CompletionDate != null ? (object)CompletionDate : (object)DBNull.Value);

            int TaskID = (int)cmd.ExecuteScalar();
            scon.Close();
            Task tempTask = new Task(TaskID, Name, Description, UserGroup, Owner, TaskState, DueDate, StartDate, CompletionDate, null);
            return tempTask;
        }

        public Task UpdateTask(Task Task, string Name, string Description, UserGroup UserGroup, User Owner, TaskState TaskState, DateTime DueDate, DateTime StartDate, DateTime? CompletionDate, List<TaskCategory> TaskCategories)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            scon.Open();

            string query = "UPDATE Tasks.Tasks SET [Name] = @Name, [Description] = @Description, OwnerUserID = @OwnerUserID, UserGroupID = @UserGroupID, TaskStateID = @TaskStateID, DueDate = @DueDate, StartDate = @StartDate, CompletionDate = @CompletionDate WHERE TaskID = @TaskID";
            SqlCommand cmd = new SqlCommand(query, scon);
            cmd.Parameters.AddWithValue("@TaskID", Task.TaskID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Description", Description);
            cmd.Parameters.AddWithValue("@OwnerUserID", Owner.UserID);
            cmd.Parameters.AddWithValue("@UserGroupID", UserGroup.UserGroupID);
            cmd.Parameters.AddWithValue("@TaskStateID", TaskState.TaskStateID);
            cmd.Parameters.AddWithValue("@DueDate", DueDate);
            cmd.Parameters.AddWithValue("@StartDate", StartDate);
            cmd.Parameters.AddWithValue("@CompletionDate", CompletionDate != null ? (object)CompletionDate : (object)DBNull.Value);
            cmd.ExecuteNonQuery();

            scon.Close();
            Task tempTask = new Task(Task.TaskID, Name, Description, UserGroup, Owner, TaskState, DueDate, StartDate, CompletionDate, null);
            return tempTask;
        }

        public List<Task> GetTasksForUserGroup(UserGroup UserGroup)
        {
            throw new NotImplementedException();
        }

        public List<Task> GetTasksForUser(User User)
        {
            List<Task> tasks = new List<Task>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT U.UserID, U.[Name] AS UserName, U.Email AS UserEmail, T.TaskID, T.TaskStateID, T.[Name] AS TaskName, T.[Description] AS TaskDescription, TS.[Name] AS TaskStateName, TS.[Description] AS TaskStateDescription, T.[Description] AS TaskDescription, T.DueDate, T.StartDate, T.CompletionDate, T.UserGroupID, UG.[Name] AS UserGroupName, UG.[Description] AS UserGroupDescription, TS.Color FROM Tasks.Tasks T INNER JOIN Tasks.TaskStates TS ON T.TaskStateID = TS.TaskStateID INNER JOIN Users.UserGroupUsers UGU ON T.UserGroupID = UGU.UserGroupID INNER JOIN Users.UserGroups UG ON UGU.UserGroupID = UG.UserGroupID INNER JOIN Users.Users U ON T.OwnerUserID = U.UserID WHERE UGU.UserID = " + User.UserID;// modify the query
            SqlCommand cmd = new SqlCommand(query, scon);
            List<TaskCategory> ltc = new List<TaskCategory>();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserGroup tempUserGroup = new UserGroup((int)reader["UserGroupID"], User, reader["UserGroupName"].ToString(), reader["UserGroupDescription"].ToString());
                    TaskState tempTaskState = new TaskState((int)reader["TaskStateID"], reader["TaskStateName"].ToString(), reader["TaskStateDescription"].ToString(), reader["Color"].ToString());
                    Task tempTask = new Task(int.Parse(reader["TaskID"].ToString()),
                                        reader["TaskName"].ToString(),
                                        reader["TaskDescription"].ToString(),
                                        tempUserGroup,
                                        new User((int)reader["UserID"], (string)reader["UserName"], (string)reader["UserEmail"], null), // fix this
                                        tempTaskState,
                                        (DateTime)reader["DueDate"],
                                        (DateTime)reader["StartDate"],
                                        reader["CompletionDate"].Equals(DBNull.Value) ? null : (DateTime?)reader["CompletionDate"], ltc);

                    tasks.Add(tempTask);
                }
            }

            scon.Close();
            return tasks;
        }

        public TaskState CreateTaskState(string Name, string Description, string Color)
        {
            throw new NotImplementedException();
        }

        public TaskState UpdateTaskState(TaskState TaskState, string Name, string Description, string Color)
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

        public List<UserGroup> GetUserGroupsForUser(User User)
        {
            List<UserGroup> userGroups = new List<UserGroup>();

            SqlConnection scon = new SqlConnection(connectionString);

            scon.Open();
            string query = "SELECT * FROM Users.UserGroups UG INNER JOIN Users.UserGroupUsers UGU ON UG.UserGroupID = UGU.UserGroupID WHERE UGU.UserID = " + User.UserID;
            SqlCommand cmd = new SqlCommand(query, scon);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserGroup tempUserGroup = new UserGroup((int)reader["UserGroupID"], User, (string)reader["Name"], (string)reader["Description"]);
                    userGroups.Add(tempUserGroup);
                }
            }

            scon.Close();
            return userGroups;
        }

        Dictionary<User, Role> IDatabaseManager.GetUsersInUserGroup(UserGroup UserGroup)
        {
            throw new NotImplementedException();
        }

        public KeyValuePair<User, Role> AddUserToUserGroup(UserGroup UserGroup, User User, Role Role)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            scon.Open();

            string query = "INSERT INTO Users.UserGroupUsers(UserGroupID, UserID, RoleID) OUTPUT INSERTED.UserGroupID values (@UserGroupID, UserID, RoleID)"; 
            SqlCommand cmd = new SqlCommand(query, scon);

            cmd.Parameters.AddWithValue("@UserGroupID", UserGroup.UserGroupID);
            cmd.Parameters.AddWithValue("@UserID", User.UserID);
            cmd.Parameters.AddWithValue("@RoleID", Role.RoleID);

            scon.Close();

            return new KeyValuePair<User, Role>(User, Role);
        }

        public KeyValuePair<User, Role> UpdateUserInUserGroup(UserGroup UserGroup, User User, Role Role)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            scon.Open();

            string query = "UPDATE Users.UserGroupUsers SET UserGroupID = @UserGroupID, UserID = @UserID, RoleID = @RoleID WHERE UserGroupID = @UserGroupID";
            SqlCommand cmd = new SqlCommand(query, scon);

            cmd.Parameters.AddWithValue("@UserGroupID", UserGroup.UserGroupID);
            cmd.Parameters.AddWithValue("@UserID", User.UserID);
            cmd.Parameters.AddWithValue("RoleID", Role.RoleID);

            scon.Close();

            return new KeyValuePair<User, Role>(User, Role);
        }
    }
}
