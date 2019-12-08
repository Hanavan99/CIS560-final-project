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
using Task = CIS560_final_project.model.Task;

namespace CIS560_final_project
{
    public partial class EditTaskCategoriesForm : Form
    {
        private IDatabaseManager database;
        private User user;
        private Task task;
        public EditTaskCategoriesForm(IDatabaseManager database, User user, Task task)
        {
            this.database = database;
            this.user = user;
            this.task = task;
            InitializeComponent();
        }

        private void EditTaskCategoriesForm_Load(object sender, EventArgs e)
        {
            uxAssignedCategories.Items.AddRange(database.GetTaskCategories().ToArray());
            List<TaskCategory> selectedCategories = task.TaskCategories;
            for (int i = 0; i < uxAssignedCategories.Items.Count; i++)
            {
                if (selectedCategories.Contains(uxAssignedCategories.Items[i]))
                {
                    uxAssignedCategories.SetItemChecked(i, true);
                }
            }
        }

        private void uxSave_Click(object sender, EventArgs e)
        {
            List<TaskCategory> categories = new List<TaskCategory>();
            for (int i = 0; i < uxAssignedCategories.Items.Count; i++)
            {
                if (uxAssignedCategories.GetItemChecked(i))
                {
                    categories.Add((TaskCategory) uxAssignedCategories.Items[i]);
                }
            }
            //database.UpdateTask(task, task.Name, task.Description, task.UserGroup, task.Owner, task.TaskState, task.DueDate, task.StartDate, task.CompletionDate, categories);
            task.TaskCategories.Clear();
            task.TaskCategories.AddRange(categories);
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
