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
    public partial class EditGroupForm : Form
    {
        private IDatabaseManager database;
        private User user;
        private UserGroup userGroup;

        public EditGroupForm(IDatabaseManager database, User user, UserGroup userGroup)
        {
            this.database = database;
            this.user = user;
            this.userGroup = userGroup;
            InitializeComponent();
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            if (userGroup != null)
            {
                List<Role> roles = database.GetRoles();
                DataGridViewRowCollection col = uxGroupTable.Rows;
                col.Clear();

                foreach (KeyValuePair<User, Role> kvp in database.GetUsersInUserGroup(userGroup))
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(uxGroupTable);
                    row.Cells[0].Value = kvp.Key;
                    row.Cells[1].Value = kvp.Key.Email;
                    row.Cells[2].Value = kvp.Value;
                    col.Add(row);
                }

                uxGroupName.Text = userGroup.Name;
                uxOwner.Text = userGroup.Owner.Name;
                uxDescription.Text = userGroup.Description;
            } else
            {
                uxOwner.Text = user.Name;
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            if (userGroup != null)
            {
                database.UpdateUserGroup(userGroup, userGroup.Owner, uxGroupName.Text, uxDescription.Text);
            } else
            {
                database.CreateUserGroup(user, uxGroupName.Text, uxDescription.Text);
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
