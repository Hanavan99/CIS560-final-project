using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_final_project.model;

namespace CIS560_final_project.database
{
    public interface IDatabaseManager
    {

        User CreateUser(string Name, string Email, string Password);

        User UpdateUser(User user, string Name, string Email, string Password);

        bool VerifyUser(string Name, string Password);

        TaskCategory CreateTaskCategory(User Owner, string Name, string Description, string Color);

        TaskCategory UpdateTaskCategory(TaskCategory TaskCategory, User Owner, string Name, string Description, string Color);

        UserGroup CreateUserGroup(User Owner, string Name, string Description);

        UserGroup UpdateUserGroup(UserGroup UserGroup, User Owner, string Name, string Description);

        void AddUserToGroup(UserGroup UserGroup, User User, Role Role);

        void UpdateUserInGroup(UserGroup UserGroup, User User, Role Role);



    }
}
