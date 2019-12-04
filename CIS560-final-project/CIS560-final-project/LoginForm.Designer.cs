namespace CIS560_final_project
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.uxUsername = new System.Windows.Forms.TextBox();
            this.uxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zxCancel = new System.Windows.Forms.Button();
            this.zxLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // uxUsername
            // 
            this.uxUsername.Location = new System.Drawing.Point(122, 12);
            this.uxUsername.Name = "uxUsername";
            this.uxUsername.Size = new System.Drawing.Size(208, 20);
            this.uxUsername.TabIndex = 1;
            // 
            // uxPassword
            // 
            this.uxPassword.Location = new System.Drawing.Point(122, 40);
            this.uxPassword.Name = "uxPassword";
            this.uxPassword.Size = new System.Drawing.Size(208, 20);
            this.uxPassword.TabIndex = 2;
            this.uxPassword.UseSystemPasswordChar = true;
            this.uxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uxPassword_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // zxCancel
            // 
            this.zxCancel.Location = new System.Drawing.Point(255, 69);
            this.zxCancel.Name = "zxCancel";
            this.zxCancel.Size = new System.Drawing.Size(75, 23);
            this.zxCancel.TabIndex = 4;
            this.zxCancel.Text = "Cancel";
            this.zxCancel.UseVisualStyleBackColor = true;
            this.zxCancel.Click += new System.EventHandler(this.zxCancel_Click);
            // 
            // zxLogin
            // 
            this.zxLogin.Location = new System.Drawing.Point(174, 69);
            this.zxLogin.Name = "zxLogin";
            this.zxLogin.Size = new System.Drawing.Size(75, 23);
            this.zxLogin.TabIndex = 5;
            this.zxLogin.Text = "Login";
            this.zxLogin.UseVisualStyleBackColor = true;
            this.zxLogin.Click += new System.EventHandler(this.zxLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(340, 102);
            this.Controls.Add(this.zxLogin);
            this.Controls.Add(this.zxCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxPassword);
            this.Controls.Add(this.uxUsername);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxUsername;
        private System.Windows.Forms.TextBox uxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button zxCancel;
        private System.Windows.Forms.Button zxLogin;
    }
}