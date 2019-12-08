namespace CIS560_final_project
{
    partial class EditGroupForm
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
            this.components = new System.ComponentModel.Container();
            this.uxGroupTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.uxGroupName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxOwner = new System.Windows.Forms.TextBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uxGroupTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxGroupTable
            // 
            this.uxGroupTable.AllowUserToAddRows = false;
            this.uxGroupTable.AllowUserToDeleteRows = false;
            this.uxGroupTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxGroupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxGroupTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Email,
            this.Role});
            this.uxGroupTable.Location = new System.Drawing.Point(11, 118);
            this.uxGroupTable.Margin = new System.Windows.Forms.Padding(2);
            this.uxGroupTable.Name = "uxGroupTable";
            this.uxGroupTable.ReadOnly = true;
            this.uxGroupTable.RowHeadersWidth = 51;
            this.uxGroupTable.RowTemplate.Height = 24;
            this.uxGroupTable.Size = new System.Drawing.Size(405, 216);
            this.uxGroupTable.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Username";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Role.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(427, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxAddUser,
            this.uxEditUser,
            this.deleteSelectedUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // uxAddUser
            // 
            this.uxAddUser.Name = "uxAddUser";
            this.uxAddUser.Size = new System.Drawing.Size(193, 22);
            this.uxAddUser.Text = "Add User...";
            this.uxAddUser.Click += new System.EventHandler(this.uxAddUser_Click);
            // 
            // uxEditUser
            // 
            this.uxEditUser.Name = "uxEditUser";
            this.uxEditUser.Size = new System.Drawing.Size(193, 22);
            this.uxEditUser.Text = "Edit Selected User...";
            this.uxEditUser.Click += new System.EventHandler(this.uxEditUser_Click);
            // 
            // deleteSelectedUsersToolStripMenuItem
            // 
            this.deleteSelectedUsersToolStripMenuItem.Name = "deleteSelectedUsersToolStripMenuItem";
            this.deleteSelectedUsersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteSelectedUsersToolStripMenuItem.Text = "Delete Selected User(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Group name:";
            // 
            // uxGroupName
            // 
            this.uxGroupName.Location = new System.Drawing.Point(86, 27);
            this.uxGroupName.Name = "uxGroupName";
            this.uxGroupName.Size = new System.Drawing.Size(139, 20);
            this.uxGroupName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Owner:";
            // 
            // uxOwner
            // 
            this.uxOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOwner.Enabled = false;
            this.uxOwner.Location = new System.Drawing.Point(278, 27);
            this.uxOwner.Name = "uxOwner";
            this.uxOwner.Size = new System.Drawing.Size(138, 20);
            this.uxOwner.TabIndex = 5;
            // 
            // uxCancel
            // 
            this.uxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCancel.Location = new System.Drawing.Point(341, 339);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 6;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSave
            // 
            this.uxSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSave.Location = new System.Drawing.Point(260, 339);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 7;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // uxDescription
            // 
            this.uxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxDescription.Location = new System.Drawing.Point(86, 53);
            this.uxDescription.Multiline = true;
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(330, 60);
            this.uxDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 374);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxGroupName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGroupTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditGroupForm";
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxGroupTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView uxGroupTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxAddUser;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxEditUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxGroupName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxOwner;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.TextBox uxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}