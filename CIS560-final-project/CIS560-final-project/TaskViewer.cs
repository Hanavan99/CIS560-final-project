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
    public partial class TaskViewer : Form
    {
        private IDatabaseManager database;

        public TaskViewer(IDatabaseManager database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void TaskViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
