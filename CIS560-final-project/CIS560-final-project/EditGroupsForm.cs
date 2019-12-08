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
            uxGroupType.SelectedIndex = 0;
            UpdateUserGroupList();
        }

        private void uxDeleteGroups_Click(object sender, EventArgs e)
        {

        }

        private void uxEditGroup_Click(object sender, EventArgs e)
        {
            if (uxGroupList.SelectedItem != null)
            {
                new EditGroupForm(database, user, (UserGroup) uxGroupList.SelectedItem).ShowDialog();
                UpdateUserGroupList();
            } else
            {
                MessageBox.Show("Please select a group from the list.");
            }
        }

        private void uxCreateGroup_Click(object sender, EventArgs e)
        {
            new EditGroupForm(database, user, null).ShowDialog();
            UpdateUserGroupList();
        }

        private void UpdateUserGroupList()
        {
            switch (uxGroupType.SelectedIndex)
            {
                case 0: // I'm a member
                    List<UserGroup> groups = database.GetUserGroupsForUser(user);
                    uxGroupList.Items.Clear();
                    uxGroupList.Items.AddRange(groups.ToArray());
                    break;
                case 1: // I'm an owner
                    List<UserGroup> groups2 = database.GetUserGroupsForOwner(user);
                    uxGroupList.Items.Clear();
                    uxGroupList.Items.AddRange(groups2.ToArray());
                    break;
            }
            
        }

        private void uxGroupType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUserGroupList();
        }
    }
}
