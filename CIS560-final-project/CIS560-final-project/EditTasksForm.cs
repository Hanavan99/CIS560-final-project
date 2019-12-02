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
    public partial class EditTasksForm : Form
    {
        private IDatabaseManager database;
        private User user;

        public EditTasksForm(IDatabaseManager database, User user)
        {
            InitializeComponent();
            this.database = database;
            this.user = user;

        }

        private void uxEditGroups_Click(object sender, EventArgs e)
        {
            new EditGroupsForm(database).Show();
        }

        private void EditTasksForm_Load(object sender, EventArgs e)
        {
            //database.GetTasksForUser();
            List<model.Task> tasks = database.GetTasksForUser(user);
            DataGridViewRowCollection col = uxTaskList.Rows;
            col.Clear();
            foreach (model.Task task in tasks)
            {
                col.Add(new object[] { task.Name, null, null, null, null, task.DueDate, task.StartDate, task.CompletionDate});
            }
        }

        private void uxCreateTask_Click(object sender, EventArgs e)
        {
            
        }

        private void uxEditTask_Click(object sender, EventArgs e)
        {
            List<model.Task> tasks = database.GetTasksForUser(user);
            new EditTaskForm(database, user, tasks[uxTaskList.SelectedRows[0].Index]).ShowDialog();
            tasks = database.GetTasksForUser(user);
            DataGridViewRowCollection col = uxTaskList.Rows;
            col.Clear();
            foreach (model.Task task in tasks)
            {
                col.Add(new object[] { task.Name, null, null, null, null, task.DueDate, task.StartDate, task.CompletionDate });
            }
        }

        private void EditTasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
