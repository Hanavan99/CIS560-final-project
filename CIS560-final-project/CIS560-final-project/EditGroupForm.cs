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
            DataGridViewRowCollection col = uxGroupTable.Rows;
            col.Clear();
            foreach (User user in database.GetUsersInUserGroup(userGroup))
            {
                col.Add(new object[] { user.Name, user.Email, "NYI" });
            }
        }
    }
}
