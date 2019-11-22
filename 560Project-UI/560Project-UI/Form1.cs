using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _560Project_UI
{
    public partial class TaskOrganizer : Form
    {
        public TaskOrganizer()
        {
            InitializeComponent();
        }

        private void TaskSelector_SelectedIndexChanged(object sender, EventArgs e)// displays the user's tasks
        {
            // allow them to select a task?
        }

        private void TaskOrganizer_Load(object sender, EventArgs e)
        {

        }

        private void TaskButton_Click(object sender, EventArgs e)// shows the selected Task
        {
            Task t = new Task();
            t.ShowDialog();
        }

        private void OpenGroup_Click(object sender, EventArgs e)// shows the selected group
        {
            Group g = new Group();
            g.ShowDialog();
        }
    }
}
