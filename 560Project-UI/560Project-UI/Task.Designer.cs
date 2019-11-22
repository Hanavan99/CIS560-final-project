namespace _560Project_UI
{
    partial class Task
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
            this.TaskMembers = new System.Windows.Forms.ListBox();
            this.TaskCategories = new System.Windows.Forms.ListBox();
            this.TaskDescription = new System.Windows.Forms.TextBox();
            this.DueDate = new System.Windows.Forms.TextBox();
            this.StartDate = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferOwnershipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.CompletionDate = new System.Windows.Forms.TextBox();
            this.userOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaveTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskMembers
            // 
            this.TaskMembers.FormattingEnabled = true;
            this.TaskMembers.ItemHeight = 16;
            this.TaskMembers.Location = new System.Drawing.Point(13, 87);
            this.TaskMembers.Name = "TaskMembers";
            this.TaskMembers.Size = new System.Drawing.Size(157, 84);
            this.TaskMembers.TabIndex = 0;
            // 
            // TaskCategories
            // 
            this.TaskCategories.FormattingEnabled = true;
            this.TaskCategories.ItemHeight = 16;
            this.TaskCategories.Location = new System.Drawing.Point(13, 177);
            this.TaskCategories.Name = "TaskCategories";
            this.TaskCategories.Size = new System.Drawing.Size(157, 84);
            this.TaskCategories.TabIndex = 1;
            // 
            // TaskDescription
            // 
            this.TaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskDescription.Location = new System.Drawing.Point(176, 87);
            this.TaskDescription.Multiline = true;
            this.TaskDescription.Name = "TaskDescription";
            this.TaskDescription.ReadOnly = true;
            this.TaskDescription.Size = new System.Drawing.Size(158, 84);
            this.TaskDescription.TabIndex = 2;
            // 
            // DueDate
            // 
            this.DueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DueDate.Location = new System.Drawing.Point(176, 205);
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Size = new System.Drawing.Size(158, 22);
            this.DueDate.TabIndex = 6;
            this.DueDate.Text = "Due Date:";
            // 
            // StartDate
            // 
            this.StartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDate.Location = new System.Drawing.Point(176, 177);
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Size = new System.Drawing.Size(158, 22);
            this.StartDate.TabIndex = 7;
            this.StartDate.Text = "Start Date:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminOptionsToolStripMenuItem,
            this.userOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(348, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminOptionsToolStripMenuItem
            // 
            this.adminOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem,
            this.modifyRolesToolStripMenuItem,
            this.deleteTaskToolStripMenuItem,
            this.changeDetailsToolStripMenuItem,
            this.transferOwnershipToolStripMenuItem});
            this.adminOptionsToolStripMenuItem.Enabled = false;
            this.adminOptionsToolStripMenuItem.Name = "adminOptionsToolStripMenuItem";
            this.adminOptionsToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.adminOptionsToolStripMenuItem.Text = "Admin Options";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            // 
            // modifyRolesToolStripMenuItem
            // 
            this.modifyRolesToolStripMenuItem.Name = "modifyRolesToolStripMenuItem";
            this.modifyRolesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.modifyRolesToolStripMenuItem.Text = "Modify Roles";
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deleteTaskToolStripMenuItem.Text = "Delete Task";
            // 
            // changeDetailsToolStripMenuItem
            // 
            this.changeDetailsToolStripMenuItem.Name = "changeDetailsToolStripMenuItem";
            this.changeDetailsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.changeDetailsToolStripMenuItem.Text = "Change Details";
            // 
            // transferOwnershipToolStripMenuItem
            // 
            this.transferOwnershipToolStripMenuItem.Name = "transferOwnershipToolStripMenuItem";
            this.transferOwnershipToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.transferOwnershipToolStripMenuItem.Text = "Transfer Ownership";
            // 
            // TaskName
            // 
            this.TaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskName.Location = new System.Drawing.Point(13, 31);
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Size = new System.Drawing.Size(323, 22);
            this.TaskName.TabIndex = 9;
            this.TaskName.Text = "Task Name:";
            // 
            // CompletionDate
            // 
            this.CompletionDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompletionDate.Location = new System.Drawing.Point(176, 233);
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.ReadOnly = true;
            this.CompletionDate.Size = new System.Drawing.Size(158, 22);
            this.CompletionDate.TabIndex = 10;
            this.CompletionDate.Text = "Completion Date:";
            // 
            // userOptionsToolStripMenuItem
            // 
            this.userOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaveTaskToolStripMenuItem});
            this.userOptionsToolStripMenuItem.Name = "userOptionsToolStripMenuItem";
            this.userOptionsToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.userOptionsToolStripMenuItem.Text = "User Options";
            // 
            // leaveTaskToolStripMenuItem
            // 
            this.leaveTaskToolStripMenuItem.Name = "leaveTaskToolStripMenuItem";
            this.leaveTaskToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.leaveTaskToolStripMenuItem.Text = "Leave Task";
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 271);
            this.Controls.Add(this.CompletionDate);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.TaskDescription);
            this.Controls.Add(this.TaskCategories);
            this.Controls.Add(this.TaskMembers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Task";
            this.Text = "Task Viewer";
            this.Load += new System.EventHandler(this.Task_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TaskMembers;
        private System.Windows.Forms.ListBox TaskCategories;
        private System.Windows.Forms.TextBox TaskDescription;
        private System.Windows.Forms.TextBox DueDate;
        private System.Windows.Forms.TextBox StartDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferOwnershipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaveTaskToolStripMenuItem;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.TextBox CompletionDate;
    }
}