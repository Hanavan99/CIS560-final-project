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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.uxGroupTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.uxGroupTable.Location = new System.Drawing.Point(9, 25);
            this.uxGroupTable.Margin = new System.Windows.Forms.Padding(2);
            this.uxGroupTable.Name = "uxGroupTable";
            this.uxGroupTable.RowHeadersWidth = 51;
            this.uxGroupTable.RowTemplate.Height = 24;
            this.uxGroupTable.Size = new System.Drawing.Size(448, 266);
            this.uxGroupTable.TabIndex = 0;
            this.uxGroupTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxGroupTable_CellValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.editSelectedUserToolStripMenuItem,
            this.deleteSelectedUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addUserToolStripMenuItem.Text = "Add User...";
            // 
            // editSelectedUserToolStripMenuItem
            // 
            this.editSelectedUserToolStripMenuItem.Name = "editSelectedUserToolStripMenuItem";
            this.editSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.editSelectedUserToolStripMenuItem.Text = "Edit Selected User...";
            // 
            // deleteSelectedUsersToolStripMenuItem
            // 
            this.deleteSelectedUsersToolStripMenuItem.Name = "deleteSelectedUsersToolStripMenuItem";
            this.deleteSelectedUsersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.deleteSelectedUsersToolStripMenuItem.Text = "Delete Selected User(s)";
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
            // EditGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 301);
            this.Controls.Add(this.uxGroupTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditGroupForm";
            this.Text = "Edit Group";
            this.Load += new System.EventHandler(this.EditGroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxGroupTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView uxGroupTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedUserToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
    }
}