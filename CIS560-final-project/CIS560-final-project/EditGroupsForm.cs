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
    public partial class EditGroupsForm : Form
    {
        private IDatabaseManager database;
        private User user;

        public EditGroupsForm(IDatabaseManager database, User user)
        {
            this.database = database;
            this.user = user;
            InitializeComponent();
        }

        private void EditGroupsForm_Load(object sender, EventArgs e)
        {
            List<UserGroup> groups = database.GetUserGroupsForUser(user);
            uxGroupList.Items.AddRange(groups.ToArray());
        }

        private void uxDeleteGroups_Click(object sender, EventArgs e)
        {

        }

        private void uxEditGroup_Click(object sender, EventArgs e)
        {
            if (uxGroupList.SelectedItem != null)
            {

            } else
            {
                MessageBox.Show("Please select a group from the list.");
            }
        }
    }
}
