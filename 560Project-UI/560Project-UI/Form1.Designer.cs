namespace _560Project_UI
{
    partial class TaskOrganizer
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
            this.TaskList = new System.Windows.Forms.ComboBox();
            this.GroupList = new System.Windows.Forms.ComboBox();
            this.TaskCalendar = new System.Windows.Forms.MonthCalendar();
            this.DaysTasks = new System.Windows.Forms.ListBox();
            this.TaskText = new System.Windows.Forms.TextBox();
            this.GroupText = new System.Windows.Forms.TextBox();
            this.TaskButton = new System.Windows.Forms.Button();
            this.OpenGroup = new System.Windows.Forms.Button();
            this.CalendarText = new System.Windows.Forms.TextBox();
            this.DailyTaskText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TaskList
            // 
            this.TaskList.FormattingEnabled = true;
            this.TaskList.Location = new System.Drawing.Point(12, 12);
            this.TaskList.Name = "TaskList";
            this.TaskList.Size = new System.Drawing.Size(121, 24);
            this.TaskList.TabIndex = 1;
            this.TaskList.SelectedIndexChanged += new System.EventHandler(this.TaskSelector_SelectedIndexChanged);
            // 
            // GroupList
            // 
            this.GroupList.FormattingEnabled = true;
            this.GroupList.Location = new System.Drawing.Point(12, 64);
            this.GroupList.Name = "GroupList";
            this.GroupList.Size = new System.Drawing.Size(121, 24);
            this.GroupList.TabIndex = 2;
            // 
            // TaskCalendar
            // 
            this.TaskCalendar.Location = new System.Drawing.Point(18, 148);
            this.TaskCalendar.Name = "TaskCalendar";
            this.TaskCalendar.TabIndex = 3;
            // 
            // DaysTasks
            // 
            this.DaysTasks.FormattingEnabled = true;
            this.DaysTasks.ItemHeight = 16;
            this.DaysTasks.Location = new System.Drawing.Point(322, 148);
            this.DaysTasks.Name = "DaysTasks";
            this.DaysTasks.Size = new System.Drawing.Size(262, 196);
            this.DaysTasks.TabIndex = 4;
            // 
            // TaskText
            // 
            this.TaskText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TaskText.Location = new System.Drawing.Point(166, 13);
            this.TaskText.Name = "TaskText";
            this.TaskText.ReadOnly = true;
            this.TaskText.Size = new System.Drawing.Size(315, 15);
            this.TaskText.TabIndex = 5;
            this.TaskText.Text = "Select a task and click the button to examine it";
            // 
            // GroupText
            // 
            this.GroupText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupText.Location = new System.Drawing.Point(166, 66);
            this.GroupText.Name = "GroupText";
            this.GroupText.ReadOnly = true;
            this.GroupText.Size = new System.Drawing.Size(315, 15);
            this.GroupText.TabIndex = 6;
            this.GroupText.Text = "Select a group and click the button to examine it";
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(509, 12);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(75, 42);
            this.TaskButton.TabIndex = 7;
            this.TaskButton.Text = "Open Task";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // OpenGroup
            // 
            this.OpenGroup.Location = new System.Drawing.Point(509, 64);
            this.OpenGroup.Name = "OpenGroup";
            this.OpenGroup.Size = new System.Drawing.Size(75, 42);
            this.OpenGroup.TabIndex = 8;
            this.OpenGroup.Text = "Open Group";
            this.OpenGroup.UseVisualStyleBackColor = true;
            this.OpenGroup.Click += new System.EventHandler(this.OpenGroup_Click);
            // 
            // CalendarText
            // 
            this.CalendarText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CalendarText.Location = new System.Drawing.Point(18, 127);
            this.CalendarText.Name = "CalendarText";
            this.CalendarText.ReadOnly = true;
            this.CalendarText.Size = new System.Drawing.Size(277, 15);
            this.CalendarText.TabIndex = 9;
            this.CalendarText.Text = "Select a calendar day to see its tasks";
            this.CalendarText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DailyTaskText
            // 
            this.DailyTaskText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DailyTaskText.Location = new System.Drawing.Point(322, 127);
            this.DailyTaskText.Name = "DailyTaskText";
            this.DailyTaskText.ReadOnly = true;
            this.DailyTaskText.Size = new System.Drawing.Size(277, 15);
            this.DailyTaskText.TabIndex = 10;
            this.DailyTaskText.Text = "Daily Tasks";
            this.DailyTaskText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TaskOrganizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 364);
            this.Controls.Add(this.DailyTaskText);
            this.Controls.Add(this.CalendarText);
            this.Controls.Add(this.OpenGroup);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.GroupText);
            this.Controls.Add(this.TaskText);
            this.Controls.Add(this.DaysTasks);
            this.Controls.Add(this.TaskCalendar);
            this.Controls.Add(this.GroupList);
            this.Controls.Add(this.TaskList);
            this.Name = "TaskOrganizer";
            this.Text = "Task Organizer";
            this.Load += new System.EventHandler(this.TaskOrganizer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TaskList;
        private System.Windows.Forms.ComboBox GroupList;
        private System.Windows.Forms.MonthCalendar TaskCalendar;
        private System.Windows.Forms.ListBox DaysTasks;
        private System.Windows.Forms.TextBox TaskText;
        private System.Windows.Forms.TextBox GroupText;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Button OpenGroup;
        private System.Windows.Forms.TextBox CalendarText;
        private System.Windows.Forms.TextBox DailyTaskText;
    }
}

