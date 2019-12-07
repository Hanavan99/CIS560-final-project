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
            DataGridViewRowCollection col = uxGroupTable.Rows;
            col.Clear();   
            foreach (KeyValuePair<User, Role> kvp in database.GetUsersInUserGroup(userGroup))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(uxGroupTable);
                row.Cells[0].Value = kvp.Key;
                row.Cells[1].Value = kvp.Key.Email;
                ((DataGridViewComboBoxCell)row.Cells[2]).DataSource = new List<object>(new object[] { "test", "test2" });
                col.Add(row);
            }
        }

        private void uxGroupTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 2)
            {
                User user = (User)uxGroupTable.Rows[e.RowIndex].Cells[0].Value;
                //database.UpdateUserInUserGroup(userGroup, user, )
            }
        }
    }
}
