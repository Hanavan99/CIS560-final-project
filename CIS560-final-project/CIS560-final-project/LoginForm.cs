using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_final_project.database;

namespace CIS560_final_project
{
    public partial class LoginForm : Form
    {
        private IDatabaseManager database;

        public LoginForm(IDatabaseManager database)
        {
            InitializeComponent();
            this.database = database;
        }

        private void zxLogin_Click(object sender, EventArgs e)
        {
            if (database.VerifyUser(uxUsername.Text, uxPassword.Text)) { 
                new EditTasksForm(database).Show();
                Hide();
            } else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void zxCancel_Click(object sender, EventArgs e) => Application.Exit();
    }
}
