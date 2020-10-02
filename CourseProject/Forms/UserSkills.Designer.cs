namespace CourseProject.Mockups
{
    partial class UserSkills
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.skillsDataGridView = new System.Windows.Forms.DataGridView();
            this.skillNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillDescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillsDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.button1);
            this.panelMain.Controls.Add(this.skillsDataGridView);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 500);
            this.panelMain.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 467);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Evidence";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // skillsDataGridView
            // 
            this.skillsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillNameColumn,
            this.SkillDescriptionColumn,
            this.LevelColumn1});
            this.skillsDataGridView.Location = new System.Drawing.Point(10, 23);
            this.skillsDataGridView.Name = "skillsDataGridView";
            this.skillsDataGridView.ReadOnly = true;
            this.skillsDataGridView.Size = new System.Drawing.Size(781, 439);
            this.skillsDataGridView.TabIndex = 2;
            // 
            // skillNameColumn
            // 
            this.skillNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillNameColumn.HeaderText = "Skill Name";
            this.skillNameColumn.Name = "skillNameColumn";
            this.skillNameColumn.ReadOnly = true;
            // 
            // SkillDescriptionColumn
            // 
            this.SkillDescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SkillDescriptionColumn.HeaderText = "Description";
            this.SkillDescriptionColumn.Name = "SkillDescriptionColumn";
            this.SkillDescriptionColumn.ReadOnly = true;
            // 
            // LevelColumn1
            // 
            this.LevelColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LevelColumn1.HeaderText = "Level";
            this.LevelColumn1.Name = "LevelColumn1";
            this.LevelColumn1.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userDetailsToolStripMenuItem,
            this.userSkillsToolStripMenuItem,
            this.userEvidenceToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.adminControlsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.Name = "userDetailsToolStripMenuItem";
            this.userDetailsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.userDetailsToolStripMenuItem.Text = "User Details";
            this.userDetailsToolStripMenuItem.Click += new System.EventHandler(this.userDetailsToolStripMenuItem_Click);
            // 
            // userSkillsToolStripMenuItem
            // 
            this.userSkillsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userSkillsToolStripMenuItem.Name = "userSkillsToolStripMenuItem";
            this.userSkillsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.userSkillsToolStripMenuItem.Text = "User Skills";
            // 
            // userEvidenceToolStripMenuItem
            // 
            this.userEvidenceToolStripMenuItem.Name = "userEvidenceToolStripMenuItem";
            this.userEvidenceToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.userEvidenceToolStripMenuItem.Text = "User Evidence";
            this.userEvidenceToolStripMenuItem.Click += new System.EventHandler(this.userEvidenceToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminControlsToolStripMenuItem
            // 
            this.adminControlsToolStripMenuItem.Name = "adminControlsToolStripMenuItem";
            this.adminControlsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.adminControlsToolStripMenuItem.Text = "Admin Controls";
            this.adminControlsToolStripMenuItem.Click += new System.EventHandler(this.adminControlsToolStripMenuItem_Click);
            // 
            // UserSkills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelMain);
            this.Name = "UserSkills";
            this.Text = "UserSkills";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserSkills_FormClosed);
            this.Load += new System.EventHandler(this.UserSkills_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillsDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEvidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView skillsDataGridView;
        private System.Windows.Forms.ToolStripMenuItem adminControlsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillDescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelColumn1;
    }
}