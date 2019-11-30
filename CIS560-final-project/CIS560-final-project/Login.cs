using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 

namespace CIS560_final_project
{
    public partial class Login : Form
    {
        public Login(IDatabaseManager manager)
        {
            InitializeComponent();
        }

        private void zxLogin_Click(object sender, EventArgs e)
        {
            new TaskViewer().Show();
            Hide();
        }

        private void zxCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}
