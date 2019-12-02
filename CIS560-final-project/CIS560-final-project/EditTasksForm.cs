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
            new EditGroupsForm(database, user).Show();
        }

        private void EditTasksForm_Load(object sender, EventArgs e)
        {
            UpdateTaskList();
            uxUserGroup.Items.AddRange(database.GetUserGroupsForUser(user).ToArray());
            uxUserGroup.SelectedIndex = 0;
        }

        private void uxCreateTask_Click(object sender, EventArgs e)
        {
            new EditTaskForm(database, user, null).ShowDialog();
            UpdateTaskList();
        }

        private void uxEditTask_Click(object sender, EventArgs e)
        {
            if (uxTaskList.SelectedRows.Count > 0)
            {
                new EditTaskForm(database, user, (model.Task) uxTaskList.SelectedRows[0].Cells[0].Value).ShowDialog();
                UpdateTaskList();
            } else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void EditTasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTaskList()
        {
            List<model.Task> tasks = database.GetTasksForUser(user);
            DataGridViewRowCollection col = uxTaskList.Rows;
            col.Clear();
            foreach (model.Task task in tasks)
            {
                StringBuilder taskCategories = new StringBuilder();
                foreach (TaskCategory tc in task.TaskCategories)
                {
                    taskCategories.Append(tc.Name);
                    taskCategories.Append(", ");
                }
                if (taskCategories.Length >= 2)
                {
                    taskCategories.Length -= 2;
                }
                if ((uxFilterDateRange.Checked && task.DueDate >= uxDateRange.SelectionStart && task.DueDate < uxDateRange.SelectionEnd)
                    || (uxFilterUserGroup.Checked && task.UserGroup.UserGroupID.Equals(((UserGroup)uxUserGroup.SelectedItem).UserGroupID))
                    || (uxFilterOwner.Checked && task.Owner.UserID.Equals(user.UserID))
                    || (uxFilterNotCompleted.Checked && task.CompletionDate == null)
                    || (!uxFilterDateRange.Checked && !uxFilterUserGroup.Checked && !uxFilterOwner.Checked && !uxFilterNotCompleted.Checked))
                {
                    col.Add(new object[] { task, task.CompletionDate != null ? "Completed" : task.TaskState.Name, taskCategories.ToString(), task.UserGroup.Name, task.Owner.Name, task.DueDate, task.StartDate, task.CompletionDate != null ? task.CompletionDate.ToString() : "Not Completed" });
                }
            }
        }

        private void uxFilterDateRange_CheckedChanged(object sender, EventArgs e)
        {
            uxDateRange.Enabled = uxFilterDateRange.Checked;
            UpdateTaskList();
        }

        private void uxFilterUserGroup_CheckedChanged(object sender, EventArgs e)
        {
            uxUserGroup.Enabled = uxFilterUserGroup.Checked;
            UpdateTaskList();
        }

        private void uxFilterOwner_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTaskList();
        }

        private void uxDateRange_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateTaskList();
        }

        private void uxUserGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTaskList();
        }

        private void uxFilterNotCompleted_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTaskList();
        }
    }
}
