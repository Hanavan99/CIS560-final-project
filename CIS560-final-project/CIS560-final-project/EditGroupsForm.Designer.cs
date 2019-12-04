namespace CIS560_final_project
{
    partial class EditGroupsForm
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
            this.uxGroupList = new System.Windows.Forms.ListBox();
            this.uxEditGroup = new System.Windows.Forms.Button();
            this.uxCreateGroup = new System.Windows.Forms.Button();
            this.uxDeleteGroups = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxGroupList
            // 
            this.uxGroupList.FormattingEnabled = true;
            this.uxGroupList.Location = new System.Drawing.Point(11, 11);
            this.uxGroupList.Margin = new System.Windows.Forms.Padding(2);
            this.uxGroupList.Name = "uxGroupList";
            this.uxGroupList.Size = new System.Drawing.Size(188, 251);
            this.uxGroupList.TabIndex = 0;
            // 
            // uxEditGroup
            // 
            this.uxEditGroup.Location = new System.Drawing.Point(11, 291);
            this.uxEditGroup.Margin = new System.Windows.Forms.Padding(2);
            this.uxEditGroup.Name = "uxEditGroup";
            this.uxEditGroup.Size = new System.Drawing.Size(188, 21);
            this.uxEditGroup.TabIndex = 1;
            this.uxEditGroup.Text = "View/Edit Group...";
            this.uxEditGroup.UseVisualStyleBackColor = true;
            this.uxEditGroup.Click += new System.EventHandler(this.uxEditGroup_Click);
            // 
            // uxCreateGroup
            // 
            this.uxCreateGroup.Location = new System.Drawing.Point(11, 266);
            this.uxCreateGroup.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreateGroup.Name = "uxCreateGroup";
            this.uxCreateGroup.Size = new System.Drawing.Size(188, 21);
            this.uxCreateGroup.TabIndex = 2;
            this.uxCreateGroup.Text = "Create New Group...";
            this.uxCreateGroup.UseVisualStyleBackColor = true;
            // 
            // uxDeleteGroups
            // 
            this.uxDeleteGroups.Location = new System.Drawing.Point(11, 316);
            this.uxDeleteGroups.Margin = new System.Windows.Forms.Padding(2);
            this.uxDeleteGroups.Name = "uxDeleteGroups";
            this.uxDeleteGroups.Size = new System.Drawing.Size(188, 21);
            this.uxDeleteGroups.TabIndex = 3;
            this.uxDeleteGroups.Text = "Delete Selected Group(s)";
            this.uxDeleteGroups.UseVisualStyleBackColor = true;
            this.uxDeleteGroups.Click += new System.EventHandler(this.uxDeleteGroups_Click);
            // 
            // EditGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 349);
            this.Controls.Add(this.uxDeleteGroups);
            this.Controls.Add(this.uxCreateGroup);
            this.Controls.Add(this.uxEditGroup);
            this.Controls.Add(this.uxGroupList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditGroupsForm";
            this.Text = "Edit Groups";
            this.Load += new System.EventHandler(this.EditGroupsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxGroupList;
        private System.Windows.Forms.Button uxEditGroup;
        private System.Windows.Forms.Button uxCreateGroup;
        private System.Windows.Forms.Button uxDeleteGroups;
    }
}