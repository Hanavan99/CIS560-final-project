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
        public EditUserGroupUserForm(IDatabaseManager database, UserGroup userGroup, User user)
        {
            this.database = database;
            this.userGroup = userGroup;
            this.user = user;
            InitializeComponent();
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            string name = (string)row.Cells[0].Value;
            Role role = null;
            foreach (Role r in roles)
            {
                if (r.Name.ToUpper().Equals(roleName.ToUpper()))
                {
                    role = r;
                    break;
                }
            }
            User localUser = database.GetUserForUserName(name);
            if (localUser == null)
            {
                MessageBox.Show("User with that name does not exist.");
            }
            else if (role == null)
            {
                MessageBox.Show("Role with that name does not exist.");
            }
            else
            {
                row.Cells[1].Value = localUser.Email;
                database.AddUserToUserGroup(userGroup, localUser, role);
            }
        }
    }
}
