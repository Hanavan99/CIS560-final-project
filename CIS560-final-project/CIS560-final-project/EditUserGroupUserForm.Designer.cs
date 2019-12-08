namespace CIS560_final_project
{
    partial class EditUserGroupUserForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxRoleList = new System.Windows.Forms.ComboBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(126, 65);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 2;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxRoleList
            // 
            this.uxRoleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxRoleList.FormattingEnabled = true;
            this.uxRoleList.Location = new System.Drawing.Point(97, 38);
            this.uxRoleList.Name = "uxRoleList";
            this.uxRoleList.Size = new System.Drawing.Size(185, 21);
            this.uxRoleList.TabIndex = 3;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(207, 65);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 4;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role:";
            // 
            // EditUserGroupUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxRoleList);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "EditUserGroupUserForm";
            this.Text = "Edit User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.ComboBox uxRoleList;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Label label2;
    }
}