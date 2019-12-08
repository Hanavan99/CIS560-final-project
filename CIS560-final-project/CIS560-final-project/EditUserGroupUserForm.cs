using CIS560_final_project.database;
using CIS560_final_project.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_final_project
{
    public partial class EditUserGroupUserForm : Form
    {
        private IDatabaseManager database;
        private UserGroup userGroup;
        private User user;
        private Role role;

        public EditUserGroupUserForm(IDatabaseManager database, UserGroup userGroup, User user, Role role)
        {
            this.database = database;
            this.userGroup = userGroup;
            this.user = user;
            this.role = role;
            InitializeComponent();
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            string name = uxUserName.Text;
            Role localRole = (Role)uxRoleList.SelectedItem;
            User localUser = database.GetUserForUserName(name);
            if (localUser == null)
            {
                MessageBox.Show("User with that name does not exist.");
            }
            else
            {
                Dictionary<User, Role> userGroupUsers = database.GetUsersInUserGroup(userGroup);
                if (!userGroupUsers.ContainsKey(localUser))
                {
                    database.AddUserToUserGroup(userGroup, localUser, localRole);
                } else
                {
                    database.UpdateUserInUserGroup(userGroup, localUser, localRole);
                }
            }
            Close();
        }

        private void EditUserGroupUserForm_Load(object sender, EventArgs e)
        {
            List<Role> roles = database.GetRoles();
            uxRoleList.Items.AddRange(roles.ToArray());
            if (user != null)
            {
                uxUserName.Text = user.Name;
                uxRoleList.SelectedItem = role;
            }
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
