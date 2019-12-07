namespace CIS560_final_project
{
    partial class EditTaskCategoriesForm
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
            this.uxAvailableCategories = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uxAssignedCategories = new System.Windows.Forms.ListBox();
            this.uxAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxRemove = new System.Windows.Forms.Button();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxAvailableCategories
            // 
            this.uxAvailableCategories.FormattingEnabled = true;
            this.uxAvailableCategories.Location = new System.Drawing.Point(12, 40);
            this.uxAvailableCategories.Name = "uxAvailableCategories";
            this.uxAvailableCategories.Size = new System.Drawing.Size(120, 277);
            this.uxAvailableCategories.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // uxAssignedCategories
            // 
            this.uxAssignedCategories.FormattingEnabled = true;
            this.uxAssignedCategories.Location = new System.Drawing.Point(138, 40);
            this.uxAssignedCategories.Name = "uxAssignedCategories";
            this.uxAssignedCategories.Size = new System.Drawing.Size(120, 277);
            this.uxAssignedCategories.TabIndex = 2;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(12, 323);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(120, 23);
            this.uxAdd.TabIndex = 3;
            this.uxAdd.Text = "Add Selected";
            this.uxAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Categories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Assigned Categories:";
            // 
            // uxRemove
            // 
            this.uxRemove.Location = new System.Drawing.Point(138, 323);
            this.uxRemove.Name = "uxRemove";
            this.uxRemove.Size = new System.Drawing.Size(120, 23);
            this.uxRemove.TabIndex = 6;
            this.uxRemove.Text = "Remove Selected";
            this.uxRemove.UseVisualStyleBackColor = true;
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // EditTaskCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 357);
            this.Controls.Add(this.uxRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxAssignedCategories);
            this.Controls.Add(this.uxAvailableCategories);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditTaskCategoriesForm";
            this.Text = "Edit Task Categories";
            this.Load += new System.EventHandler(this.EditTaskCategoriesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxAvailableCategories;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox uxAssignedCategories;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxRemove;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
    }
}