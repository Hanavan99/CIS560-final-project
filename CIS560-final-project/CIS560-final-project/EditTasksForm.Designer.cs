namespace CIS560_final_project
{
    partial class EditTasksForm
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
            this.uxCalendar = new System.Windows.Forms.MonthCalendar();
            this.uxTaskList = new System.Windows.Forms.DataGridView();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxEditGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uxUserGroup = new System.Windows.Forms.ComboBox();
            this.uxFilterAll = new System.Windows.Forms.RadioButton();
            this.uxFilterUserGroup = new System.Windows.Forms.RadioButton();
            this.uxFilterOwner = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.uxTaskList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxCalendar
            // 
            this.uxCalendar.Location = new System.Drawing.Point(13, 33);
            this.uxCalendar.Name = "uxCalendar";
            this.uxCalendar.TabIndex = 0;
            // 
            // uxTaskList
            // 
            this.uxTaskList.AllowUserToAddRows = false;
            this.uxTaskList.AllowUserToDeleteRows = false;
            this.uxTaskList.AllowUserToResizeRows = false;
            this.uxTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.TaskState,
            this.TaskCategories,
            this.UserGroup,
            this.Owner,
            this.DueDate,
            this.StartDate,
            this.CompletionDate});
            this.uxTaskList.Location = new System.Drawing.Point(287, 33);
            this.uxTaskList.Name = "uxTaskList";
            this.uxTaskList.ReadOnly = true;
            this.uxTaskList.RowHeadersWidth = 51;
            this.uxTaskList.RowTemplate.Height = 24;
            this.uxTaskList.Size = new System.Drawing.Size(842, 621);
            this.uxTaskList.TabIndex = 1;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Task Name";
            this.TaskName.MinimumWidth = 6;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 125;
            // 
            // TaskState
            // 
            this.TaskState.HeaderText = "State";
            this.TaskState.MinimumWidth = 6;
            this.TaskState.Name = "TaskState";
            this.TaskState.ReadOnly = true;
            this.TaskState.Width = 125;
            // 
            // TaskCategories
            // 
            this.TaskCategories.HeaderText = "Categories";
            this.TaskCategories.MinimumWidth = 6;
            this.TaskCategories.Name = "TaskCategories";
            this.TaskCategories.ReadOnly = true;
            this.TaskCategories.Width = 125;
            // 
            // UserGroup
            // 
            this.UserGroup.HeaderText = "User Group";
            this.UserGroup.MinimumWidth = 6;
            this.UserGroup.Name = "UserGroup";
            this.UserGroup.ReadOnly = true;
            this.UserGroup.Width = 125;
            // 
            // Owner
            // 
            this.Owner.HeaderText = "Owner";
            this.Owner.MinimumWidth = 6;
            this.Owner.Name = "Owner";
            this.Owner.ReadOnly = true;
            this.Owner.Width = 125;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "Due Date";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 125;
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Start Date";
            this.StartDate.MinimumWidth = 6;
            this.StartDate.Name = "StartDate";
            this.StartDate.ReadOnly = true;
            this.StartDate.Width = 125;
            // 
            // CompletionDate
            // 
            this.CompletionDate.HeaderText = "Completion Date";
            this.CompletionDate.MinimumWidth = 6;
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.ReadOnly = true;
            this.CompletionDate.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripMenuItem,
            this.editSelectedTaskToolStripMenuItem,
            this.deleteSelectedTasksToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.editToolStripMenuItem.Text = "Tasks";
            // 
            // createTaskToolStripMenuItem
            // 
            this.createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            this.createTaskToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.createTaskToolStripMenuItem.Text = "Create Task...";
            // 
            // editSelectedTaskToolStripMenuItem
            // 
            this.editSelectedTaskToolStripMenuItem.Name = "editSelectedTaskToolStripMenuItem";
            this.editSelectedTaskToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.editSelectedTaskToolStripMenuItem.Text = "Edit Selected Task...";
            // 
            // deleteSelectedTasksToolStripMenuItem
            // 
            this.deleteSelectedTasksToolStripMenuItem.Name = "deleteSelectedTasksToolStripMenuItem";
            this.deleteSelectedTasksToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.deleteSelectedTasksToolStripMenuItem.Text = "Delete Selected Task(s)";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxEditGroups});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // uxEditGroups
            // 
            this.uxEditGroups.Name = "uxEditGroups";
            this.uxEditGroups.Size = new System.Drawing.Size(224, 26);
            this.uxEditGroups.Text = "Edit Groups...";
            this.uxEditGroups.Click += new System.EventHandler(this.uxEditGroups_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uxFilterOwner);
            this.groupBox1.Controls.Add(this.uxFilterUserGroup);
            this.groupBox1.Controls.Add(this.uxFilterAll);
            this.groupBox1.Controls.Add(this.uxUserGroup);
            this.groupBox1.Location = new System.Drawing.Point(13, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // uxUserGroup
            // 
            this.uxUserGroup.FormattingEnabled = true;
            this.uxUserGroup.Location = new System.Drawing.Point(6, 75);
            this.uxUserGroup.Name = "uxUserGroup";
            this.uxUserGroup.Size = new System.Drawing.Size(250, 24);
            this.uxUserGroup.TabIndex = 1;
            // 
            // uxFilterAll
            // 
            this.uxFilterAll.AutoSize = true;
            this.uxFilterAll.Location = new System.Drawing.Point(6, 21);
            this.uxFilterAll.Name = "uxFilterAll";
            this.uxFilterAll.Size = new System.Drawing.Size(81, 21);
            this.uxFilterAll.TabIndex = 2;
            this.uxFilterAll.TabStop = true;
            this.uxFilterAll.Text = "All tasks";
            this.uxFilterAll.UseVisualStyleBackColor = true;
            // 
            // uxFilterUserGroup
            // 
            this.uxFilterUserGroup.AutoSize = true;
            this.uxFilterUserGroup.Location = new System.Drawing.Point(6, 48);
            this.uxFilterUserGroup.Name = "uxFilterUserGroup";
            this.uxFilterUserGroup.Size = new System.Drawing.Size(100, 21);
            this.uxFilterUserGroup.TabIndex = 3;
            this.uxFilterUserGroup.TabStop = true;
            this.uxFilterUserGroup.Text = "User group";
            this.uxFilterUserGroup.UseVisualStyleBackColor = true;
            // 
            // uxFilterOwner
            // 
            this.uxFilterOwner.AutoSize = true;
            this.uxFilterOwner.Location = new System.Drawing.Point(6, 106);
            this.uxFilterOwner.Name = "uxFilterOwner";
            this.uxFilterOwner.Size = new System.Drawing.Size(70, 21);
            this.uxFilterOwner.TabIndex = 4;
            this.uxFilterOwner.TabStop = true;
            this.uxFilterOwner.Text = "Owner";
            this.uxFilterOwner.UseVisualStyleBackColor = true;
            // 
            // EditTasksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1141, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uxTaskList);
            this.Controls.Add(this.uxCalendar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditTasksForm";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.EditTasksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxTaskList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar uxCalendar;
        private System.Windows.Forms.DataGridView uxTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskState;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uxEditGroups;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox uxUserGroup;
        private System.Windows.Forms.RadioButton uxFilterOwner;
        private System.Windows.Forms.RadioButton uxFilterUserGroup;
        private System.Windows.Forms.RadioButton uxFilterAll;
    }
}

