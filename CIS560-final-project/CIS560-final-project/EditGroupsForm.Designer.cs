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
            this.uxGroupType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxGroupList
            // 
            this.uxGroupList.FormattingEnabled = true;
            this.uxGroupList.Location = new System.Drawing.Point(11, 38);
            this.uxGroupList.Margin = new System.Windows.Forms.Padding(2);
            this.uxGroupList.Name = "uxGroupList";
            this.uxGroupList.Size = new System.Drawing.Size(187, 251);
            this.uxGroupList.TabIndex = 0;
            // 
            // uxEditGroup
            // 
            this.uxEditGroup.Location = new System.Drawing.Point(11, 318);
            this.uxEditGroup.Margin = new System.Windows.Forms.Padding(2);
            this.uxEditGroup.Name = "uxEditGroup";
            this.uxEditGroup.Size = new System.Drawing.Size(187, 21);
            this.uxEditGroup.TabIndex = 1;
            this.uxEditGroup.Text = "View/Edit Group...";
            this.uxEditGroup.UseVisualStyleBackColor = true;
            this.uxEditGroup.Click += new System.EventHandler(this.uxEditGroup_Click);
            // 
            // uxCreateGroup
            // 
            this.uxCreateGroup.Location = new System.Drawing.Point(11, 293);
            this.uxCreateGroup.Margin = new System.Windows.Forms.Padding(2);
            this.uxCreateGroup.Name = "uxCreateGroup";
            this.uxCreateGroup.Size = new System.Drawing.Size(187, 21);
            this.uxCreateGroup.TabIndex = 2;
            this.uxCreateGroup.Text = "Create New Group...";
            this.uxCreateGroup.UseVisualStyleBackColor = true;
            this.uxCreateGroup.Click += new System.EventHandler(this.uxCreateGroup_Click);
            // 
            // uxDeleteGroups
            // 
            this.uxDeleteGroups.Location = new System.Drawing.Point(11, 343);
            this.uxDeleteGroups.Margin = new System.Windows.Forms.Padding(2);
            this.uxDeleteGroups.Name = "uxDeleteGroups";
            this.uxDeleteGroups.Size = new System.Drawing.Size(187, 21);
            this.uxDeleteGroups.TabIndex = 3;
            this.uxDeleteGroups.Text = "Delete Selected Group(s)";
            this.uxDeleteGroups.UseVisualStyleBackColor = true;
            this.uxDeleteGroups.Click += new System.EventHandler(this.uxDeleteGroups_Click);
            // 
            // uxGroupType
            // 
            this.uxGroupType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxGroupType.FormattingEnabled = true;
            this.uxGroupType.Items.AddRange(new object[] {
            "I\'m a Member",
            "I\'m an Owner"});
            this.uxGroupType.Location = new System.Drawing.Point(80, 12);
            this.uxGroupType.Name = "uxGroupType";
            this.uxGroupType.Size = new System.Drawing.Size(118, 21);
            this.uxGroupType.TabIndex = 4;
            this.uxGroupType.SelectedIndexChanged += new System.EventHandler(this.uxGroupType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Group type:";
            // 
            // EditGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxGroupType);
            this.Controls.Add(this.uxDeleteGroups);
            this.Controls.Add(this.uxCreateGroup);
            this.Controls.Add(this.uxEditGroup);
            this.Controls.Add(this.uxGroupList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditGroupsForm";
            this.Text = "Edit Groups";
            this.Load += new System.EventHandler(this.EditGroupsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxGroupList;
        private System.Windows.Forms.Button uxEditGroup;
        private System.Windows.Forms.Button uxCreateGroup;
        private System.Windows.Forms.Button uxDeleteGroups;
        private System.Windows.Forms.ComboBox uxGroupType;
        private System.Windows.Forms.Label label1;
    }
}