namespace CourseProject.Mockups
{
    partial class UserEvidence
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidenceGridView = new System.Windows.Forms.DataGridView();
            this.EvidenceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkillColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCreateEvidence = new System.Windows.Forms.Button();
            this.buttonDeleteEvidence = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceGridView)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 2;
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
            this.userSkillsToolStripMenuItem.Name = "userSkillsToolStripMenuItem";
            this.userSkillsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.userSkillsToolStripMenuItem.Text = "User Skills";
            this.userSkillsToolStripMenuItem.Click += new System.EventHandler(this.userSkillsToolStripMenuItem_Click);
            // 
            // userEvidenceToolStripMenuItem
            // 
            this.userEvidenceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userEvidenceToolStripMenuItem.Name = "userEvidenceToolStripMenuItem";
            this.userEvidenceToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.userEvidenceToolStripMenuItem.Text = "User Evidence";
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
            // evidenceGridView
            // 
            this.evidenceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evidenceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EvidenceNameColumn,
            this.SkillColumn1,
            this.DescriptionColumn});
            this.evidenceGridView.Location = new System.Drawing.Point(12, 27);
            this.evidenceGridView.Name = "evidenceGridView";
            this.evidenceGridView.ReadOnly = true;
            this.evidenceGridView.Size = new System.Drawing.Size(776, 432);
            this.evidenceGridView.TabIndex = 3;
            this.evidenceGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // EvidenceNameColumn
            // 
            this.EvidenceNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EvidenceNameColumn.HeaderText = "Evidence Name";
            this.EvidenceNameColumn.Name = "EvidenceNameColumn";
            this.EvidenceNameColumn.ReadOnly = true;
            // 
            // SkillColumn1
            // 
            this.SkillColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SkillColumn1.HeaderText = "Skill";
            this.SkillColumn1.Name = "SkillColumn1";
            this.SkillColumn1.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // buttonCreateEvidence
            // 
            this.buttonCreateEvidence.Location = new System.Drawing.Point(12, 465);
            this.buttonCreateEvidence.Name = "buttonCreateEvidence";
            this.buttonCreateEvidence.Size = new System.Drawing.Size(85, 23);
            this.buttonCreateEvidence.TabIndex = 4;
            this.buttonCreateEvidence.Text = "Add Evidence";
            this.buttonCreateEvidence.UseVisualStyleBackColor = true;
            this.buttonCreateEvidence.Click += new System.EventHandler(this.buttonCreateEvidence_Click);
            // 
            // buttonDeleteEvidence
            // 
            this.buttonDeleteEvidence.Location = new System.Drawing.Point(692, 465);
            this.buttonDeleteEvidence.Name = "buttonDeleteEvidence";
            this.buttonDeleteEvidence.Size = new System.Drawing.Size(96, 23);
            this.buttonDeleteEvidence.TabIndex = 5;
            this.buttonDeleteEvidence.Text = "Delete Evidence";
            this.buttonDeleteEvidence.UseVisualStyleBackColor = true;
            // 
            // UserEvidence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonDeleteEvidence);
            this.Controls.Add(this.buttonCreateEvidence);
            this.Controls.Add(this.evidenceGridView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UserEvidence";
            this.Text = "UserEvidence";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserEvidence_FormClosed);
            this.Load += new System.EventHandler(this.UserEvidence_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evidenceGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEvidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView evidenceGridView;
        private System.Windows.Forms.Button buttonCreateEvidence;
        private System.Windows.Forms.Button buttonDeleteEvidence;
        private System.Windows.Forms.ToolStripMenuItem adminControlsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvidenceNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkillColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
    }
}