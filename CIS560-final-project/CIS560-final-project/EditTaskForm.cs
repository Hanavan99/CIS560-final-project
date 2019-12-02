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
                uxCompletionDate.Value = task.CompletionDate;
            } else
            {
                uxOwner.Text = user.Name;
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            if (task != null)
            {
                database.UpdateTask(task, uxTaskName.Text, uxDescription.Text, (UserGroup)uxUserGroup.SelectedItem, task.Owner, (TaskState)uxTaskState.SelectedItem, uxDueDate.Value, uxStartDate.Value, uxCompletionDate.Value);
            } else
            {
                database.CreateTask(uxTaskName.Text, uxDescription.Text, (UserGroup)uxUserGroup.SelectedItem, user, (TaskState)uxTaskState.SelectedItem, uxDueDate.Value, uxStartDate.Value, uxCompletionDate.Value);
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
