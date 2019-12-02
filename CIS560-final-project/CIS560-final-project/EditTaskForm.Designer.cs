namespace CIS560_final_project
{
    partial class EditTaskForm
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
            this.uxTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxTaskState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxEditTaskCategories = new System.Windows.Forms.Button();
            this.uxUserGroup = new System.Windows.Forms.ComboBox();
            this.uxOwner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxStartDate = new System.Windows.Forms.DateTimePicker();
            this.uxDueDate = new System.Windows.Forms.DateTimePicker();
            this.uxCompletionDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTaskName
            // 
            this.uxTaskName.Location = new System.Drawing.Point(112, 12);
            this.uxTaskName.Name = "uxTaskName";
            this.uxTaskName.Size = new System.Drawing.Size(201, 20);
            this.uxTaskName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // uxDescription
            // 
            this.uxDescription.Location = new System.Drawing.Point(112, 38);
            this.uxDescription.Multiline = true;
            this.uxDescription.Name = "uxDescription";
            this.uxDescription.Size = new System.Drawing.Size(201, 129);
            this.uxDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description:";
            // 
            // uxTaskState
            // 
            this.uxTaskState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxTaskState.FormattingEnabled = true;
            this.uxTaskState.Location = new System.Drawing.Point(112, 174);
            this.uxTaskState.Name = "uxTaskState";
            this.uxTaskState.Size = new System.Drawing.Size(201, 21);
            this.uxTaskState.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task state:";
            // 
            // uxEditTaskCategories
            // 
            this.uxEditTaskCategories.Location = new System.Drawing.Point(112, 202);
            this.uxEditTaskCategories.Name = "uxEditTaskCategories";
            this.uxEditTaskCategories.Size = new System.Drawing.Size(201, 23);
            this.uxEditTaskCategories.TabIndex = 6;
            this.uxEditTaskCategories.Text = "Edit Task Categories...";
            this.uxEditTaskCategories.UseVisualStyleBackColor = true;
            // 
            // uxUserGroup
            // 
            this.uxUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxUserGroup.FormattingEnabled = true;
            this.uxUserGroup.Location = new System.Drawing.Point(112, 232);
            this.uxUserGroup.Name = "uxUserGroup";
            this.uxUserGroup.Size = new System.Drawing.Size(201, 21);
            this.uxUserGroup.TabIndex = 7;
            // 
            // uxOwner
            // 
            this.uxOwner.Enabled = false;
            this.uxOwner.Location = new System.Drawing.Point(112, 260);
            this.uxOwner.Name = "uxOwner";
            this.uxOwner.Size = new System.Drawing.Size(201, 20);
            this.uxOwner.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User group:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Owner:";
            // 
            // uxStartDate
            // 
            this.uxStartDate.Location = new System.Drawing.Point(112, 286);
            this.uxStartDate.Name = "uxStartDate";
            this.uxStartDate.Size = new System.Drawing.Size(201, 20);
            this.uxStartDate.TabIndex = 11;
            // 
            // uxDueDate
            // 
            this.uxDueDate.Location = new System.Drawing.Point(112, 312);
            this.uxDueDate.Name = "uxDueDate";
            this.uxDueDate.Size = new System.Drawing.Size(201, 20);
            this.uxDueDate.TabIndex = 12;
            // 
            // uxCompletionDate
            // 
            this.uxCompletionDate.Location = new System.Drawing.Point(112, 338);
            this.uxCompletionDate.Name = "uxCompletionDate";
            this.uxCompletionDate.Size = new System.Drawing.Size(201, 20);
            this.uxCompletionDate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Due date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Completion date:";
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(238, 364);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 17;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxSave
            // 
            this.uxSave.Location = new System.Drawing.Point(156, 364);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(75, 23);
            this.uxSave.TabIndex = 18;
            this.uxSave.Text = "Save";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 396);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxCompletionDate);
            this.Controls.Add(this.uxDueDate);
            this.Controls.Add(this.uxStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxOwner);
            this.Controls.Add(this.uxUserGroup);
            this.Controls.Add(this.uxEditTaskCategories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxTaskState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxTaskName);
            this.Name = "EditTaskForm";
            this.Text = "Edit Task";
            this.Load += new System.EventHandler(this.EditTaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxTaskState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxEditTaskCategories;
        private System.Windows.Forms.ComboBox uxUserGroup;
        private System.Windows.Forms.TextBox uxOwner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker uxStartDate;
        private System.Windows.Forms.DateTimePicker uxDueDate;
        private System.Windows.Forms.DateTimePicker uxCompletionDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSave;
    }
}