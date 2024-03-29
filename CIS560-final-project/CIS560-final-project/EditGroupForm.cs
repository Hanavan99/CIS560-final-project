﻿using CIS560_final_project.database;
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
            UpdateUserGroupList();
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uxGroupName.Text))
            {
                MessageBox.Show("Please enter a valid group name.");
            } else {
                if (userGroup != null)
                {
                    database.UpdateUserGroup(userGroup, userGroup.Owner, uxGroupName.Text, uxDescription.Text);
                }
                else
                {
                    database.CreateUserGroup(user, uxGroupName.Text, uxDescription.Text);
                }
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void uxAddUser_Click(object sender, EventArgs e)
        {
            new EditUserGroupUserForm(database, userGroup, null, null).ShowDialog();
            UpdateUserGroupList();
        }

        private void UpdateUserGroupList()
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
            }
            else
            {
                uxOwner.Text = user.Name;
            }
        }

        private void uxEditUser_Click(object sender, EventArgs e)
        {
            if (uxGroupTable.SelectedRows.Count >= 1)
            {
                User selectedUser = (User)uxGroupTable.SelectedRows[0].Cells[0].Value;
                Role role = (Role)uxGroupTable.SelectedRows[0].Cells[2].Value;
                new EditUserGroupUserForm(database, userGroup, selectedUser, role).ShowDialog();
                UpdateUserGroupList();
            }
        }
    }
}
