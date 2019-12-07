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
            uxAvailableCategories.Items.AddRange(database.GetTaskCategories().ToArray());
            uxAssignedCategories.Items.AddRange(task.TaskCategories.ToArray());
        }
    }
}
