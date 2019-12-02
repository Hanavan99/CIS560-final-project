using CIS560_final_project.database;
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
    public partial class EditTasksForm : Form
    {
        private IDatabaseManager database;

        public EditTasksForm(IDatabaseManager database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void uxEditGroups_Click(object sender, EventArgs e)
        {
            new EditGroupsForm(database).Show();
        }

        private void EditTasksForm_Load(object sender, EventArgs e)
        {
            //database.GetTasksForUser();
        }
    }
}
