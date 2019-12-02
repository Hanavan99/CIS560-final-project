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
    public partial class EditTaskForm : Form
    {
        private IDatabaseManager database;
        private User user;
        private model.Task task;

        public EditTaskForm(IDatabaseManager database, User user, model.Task task)
        {
            this.database = database;
            this.user = user;
            this.task = task;
            InitializeComponent();
        }

        private void EditTaskForm_Load(object sender, EventArgs e)
        {
            uxTaskState.Items.AddRange(database.GetTaskStates().ToArray());
            uxUserGroup.Items.AddRange(database.GetUserGroupsForUser(user).ToArray());
            if (task != null)
            {
                uxTaskName.Text = task.Name;
                uxDescription.Text = task.Description;
                uxTaskState.SelectedItem = task.TaskState;
                uxUserGroup.SelectedItem = task.UserGroup;
                uxOwner.Text = task.Owner.Name;
                uxStartDate.Value = task.StartDate;
                uxDueDate.Value = task.DueDate;
                if (task.CompletionDate != null)
                {
                    uxCompletionDate.Value = (DateTime)task.CompletionDate;
                    uxCompleted.Checked = true;
                }
            }
            else
            {
                uxOwner.Text = user.Name;
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uxTaskName.Text))
            {
                MessageBox.Show("Please enter a valid task name");
            }
            else if (uxTaskState.SelectedItem == null)
            {
                MessageBox.Show("Please select a task state");
            }
            else if (uxUserGroup.SelectedItem == null)
            {
                MessageBox.Show("Please select a user group");
            }
            else
            {
                DateTime? t = null;
                if (uxCompleted.Checked)
                {
                    t = uxCompletionDate.Value;
                }
                if (task != null)
                {
                    database.UpdateTask(task, uxTaskName.Text, uxDescription.Text, (UserGroup)uxUserGroup.SelectedItem, task.Owner, (TaskState)uxTaskState.SelectedItem, uxDueDate.Value, uxStartDate.Value, t, task.TaskCategories);
                }
                else
                {
                    database.CreateTask(uxTaskName.Text, uxDescription.Text, (UserGroup)uxUserGroup.SelectedItem, user, (TaskState)uxTaskState.SelectedItem, uxDueDate.Value, uxStartDate.Value, t, new List<TaskCategory>());
                }
                Close();
            }
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxCompleted_CheckedChanged(object sender, EventArgs e)
        {
            uxCompletionDate.Enabled = uxCompleted.Checked;
        }
    }
}
