namespace CourseProject
{
    partial class GroupSkillReport
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
            this.groupNameLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.peopleRadioButton = new System.Windows.Forms.RadioButton();
            this.skillsRadioButton = new System.Windows.Forms.RadioButton();
            this.organizeLabel = new System.Windows.Forms.Label();
            this.skillsListPanel = new System.Windows.Forms.Panel();
            this.skillPanel = new System.Windows.Forms.Panel();
            this.personsPanel = new System.Windows.Forms.Panel();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.personColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillInfoPanel = new System.Windows.Forms.Panel();
            this.skillStatusLabel = new System.Windows.Forms.Label();
            this.skillNameLabel = new System.Windows.Forms.Label();
            this.peoplePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.skillDataGridView = new System.Windows.Forms.DataGridView();
            this.skillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.peopleListLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePanel.SuspendLayout();
            this.skillsListPanel.SuspendLayout();
            this.skillPanel.SuspendLayout();
            this.personsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            this.skillInfoPanel.SuspendLayout();
            this.peoplePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupNameLabel
            // 
            this.groupNameLabel.AutoSize = true;
            this.groupNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLabel.Location = new System.Drawing.Point(4, 0);
            this.groupNameLabel.Name = "groupNameLabel";
            this.groupNameLabel.Size = new System.Drawing.Size(161, 29);
            this.groupNameLabel.TabIndex = 0;
            this.groupNameLabel.Text = "Group Name";
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.Location = new System.Drawing.Point(6, 0);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(34, 13);
            this.skillLabel.TabIndex = 1;
            this.skillLabel.Text = "Skills:";
            // 
            // titlePanel
            // 
            this.titlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePanel.Controls.Add(this.button1);
            this.titlePanel.Controls.Add(this.peopleRadioButton);
            this.titlePanel.Controls.Add(this.skillsRadioButton);
            this.titlePanel.Controls.Add(this.organizeLabel);
            this.titlePanel.Controls.Add(this.groupNameLabel);
            this.titlePanel.Location = new System.Drawing.Point(12, 27);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(776, 60);
            this.titlePanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Leave Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peopleRadioButton
            // 
            this.peopleRadioButton.AutoSize = true;
            this.peopleRadioButton.Location = new System.Drawing.Point(169, 43);
            this.peopleRadioButton.Name = "peopleRadioButton";
            this.peopleRadioButton.Size = new System.Drawing.Size(58, 17);
            this.peopleRadioButton.TabIndex = 3;
            this.peopleRadioButton.TabStop = true;
            this.peopleRadioButton.Text = "People";
            this.peopleRadioButton.UseVisualStyleBackColor = true;
            this.peopleRadioButton.CheckedChanged += new System.EventHandler(this.peopleRadioButton_CheckedChanged);
            // 
            // skillsRadioButton
            // 
            this.skillsRadioButton.AutoSize = true;
            this.skillsRadioButton.Location = new System.Drawing.Point(114, 43);
            this.skillsRadioButton.Name = "skillsRadioButton";
            this.skillsRadioButton.Size = new System.Drawing.Size(49, 17);
            this.skillsRadioButton.TabIndex = 2;
            this.skillsRadioButton.TabStop = true;
            this.skillsRadioButton.Text = "Skills";
            this.skillsRadioButton.UseVisualStyleBackColor = true;
            this.skillsRadioButton.CheckedChanged += new System.EventHandler(this.skillsRadioButton_CheckedChanged);
            // 
            // organizeLabel
            // 
            this.organizeLabel.AutoSize = true;
            this.organizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizeLabel.Location = new System.Drawing.Point(5, 40);
            this.organizeLabel.Name = "organizeLabel";
            this.organizeLabel.Size = new System.Drawing.Size(103, 20);
            this.organizeLabel.TabIndex = 1;
            this.organizeLabel.Text = "Organize By: ";
            // 
            // skillsListPanel
            // 
            this.skillsListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillsListPanel.Controls.Add(this.skillPanel);
            this.skillsListPanel.Controls.Add(this.skillLabel);
            this.skillsListPanel.Location = new System.Drawing.Point(12, 93);
            this.skillsListPanel.Name = "skillsListPanel";
            this.skillsListPanel.Size = new System.Drawing.Size(776, 395);
            this.skillsListPanel.TabIndex = 3;
            // 
            // skillPanel
            // 
            this.skillPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillPanel.Controls.Add(this.personsPanel);
            this.skillPanel.Controls.Add(this.skillInfoPanel);
            this.skillPanel.Location = new System.Drawing.Point(3, 19);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.Size = new System.Drawing.Size(770, 164);
            this.skillPanel.TabIndex = 0;
            // 
            // personsPanel
            // 
            this.personsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personsPanel.Controls.Add(this.personDataGridView);
            this.personsPanel.Location = new System.Drawing.Point(3, 28);
            this.personsPanel.Name = "personsPanel";
            this.personsPanel.Size = new System.Drawing.Size(764, 136);
            this.personsPanel.TabIndex = 1;
            // 
            // personDataGridView
            // 
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personColumn,
            this.personStatusColumn});
            this.personDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.Size = new System.Drawing.Size(764, 136);
            this.personDataGridView.TabIndex = 0;
            // 
            // personColumn
            // 
            this.personColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personColumn.HeaderText = "Person";
            this.personColumn.Name = "personColumn";
            // 
            // personStatusColumn
            // 
            this.personStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.personStatusColumn.HeaderText = "Level Status";
            this.personStatusColumn.Name = "personStatusColumn";
            // 
            // skillInfoPanel
            // 
            this.skillInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillInfoPanel.Controls.Add(this.skillStatusLabel);
            this.skillInfoPanel.Controls.Add(this.skillNameLabel);
            this.skillInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.skillInfoPanel.Name = "skillInfoPanel";
            this.skillInfoPanel.Size = new System.Drawing.Size(764, 19);
            this.skillInfoPanel.TabIndex = 0;
            // 
            // skillStatusLabel
            // 
            this.skillStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skillStatusLabel.AutoSize = true;
            this.skillStatusLabel.Location = new System.Drawing.Point(667, 0);
            this.skillStatusLabel.Name = "skillStatusLabel";
            this.skillStatusLabel.Size = new System.Drawing.Size(69, 13);
            this.skillStatusLabel.TabIndex = 1;
            this.skillStatusLabel.Text = "Status: Good";
            // 
            // skillNameLabel
            // 
            this.skillNameLabel.AutoSize = true;
            this.skillNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillNameLabel.Location = new System.Drawing.Point(0, 0);
            this.skillNameLabel.Name = "skillNameLabel";
            this.skillNameLabel.Size = new System.Drawing.Size(57, 13);
            this.skillNameLabel.TabIndex = 0;
            this.skillNameLabel.Text = "Skill Name";
            // 
            // peoplePanel
            // 
            this.peoplePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peoplePanel.Controls.Add(this.panel2);
            this.peoplePanel.Controls.Add(this.peopleListLabel);
            this.peoplePanel.Location = new System.Drawing.Point(12, 93);
            this.peoplePanel.Name = "peoplePanel";
            this.peoplePanel.Size = new System.Drawing.Size(776, 400);
            this.peoplePanel.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 169);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.skillDataGridView);
            this.panel3.Location = new System.Drawing.Point(3, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 141);
            this.panel3.TabIndex = 1;
            // 
            // skillDataGridView
            // 
            this.skillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skillDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.skillColumn,
            this.skillStatusColumn});
            this.skillDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skillDataGridView.Location = new System.Drawing.Point(0, 0);
            this.skillDataGridView.Name = "skillDataGridView";
            this.skillDataGridView.ReadOnly = true;
            this.skillDataGridView.Size = new System.Drawing.Size(764, 141);
            this.skillDataGridView.TabIndex = 0;
            // 
            // skillColumn
            // 
            this.skillColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillColumn.HeaderText = "Skill";
            this.skillColumn.Name = "skillColumn";
            this.skillColumn.ReadOnly = true;
            // 
            // skillStatusColumn
            // 
            this.skillStatusColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.skillStatusColumn.HeaderText = "Level Status";
            this.skillStatusColumn.Name = "skillStatusColumn";
            this.skillStatusColumn.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.personNameLabel);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 19);
            this.panel4.TabIndex = 0;
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameLabel.Location = new System.Drawing.Point(0, 0);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(71, 13);
            this.personNameLabel.TabIndex = 0;
            this.personNameLabel.Text = "Person Name";
            // 
            // peopleListLabel
            // 
            this.peopleListLabel.AutoSize = true;
            this.peopleListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleListLabel.Location = new System.Drawing.Point(6, 0);
            this.peopleListLabel.Name = "peopleListLabel";
            this.peopleListLabel.Size = new System.Drawing.Size(43, 13);
            this.peopleListLabel.TabIndex = 1;
            this.peopleListLabel.Text = "People:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "Logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // GroupSkillReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.skillsListPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.peoplePanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GroupSkillReport";
            this.Text = "GroupSkillReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GroupSkillReport_FormClosed);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.skillsListPanel.ResumeLayout(false);
            this.skillsListPanel.PerformLayout();
            this.skillPanel.ResumeLayout(false);
            this.personsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            this.skillInfoPanel.ResumeLayout(false);
            this.skillInfoPanel.PerformLayout();
            this.peoplePanel.ResumeLayout(false);
            this.peoplePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillDataGridView)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label groupNameLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel skillsListPanel;
        private System.Windows.Forms.Panel skillPanel;
        private System.Windows.Forms.Panel personsPanel;
        private System.Windows.Forms.Panel skillInfoPanel;
        private System.Windows.Forms.Label organizeLabel;
        private System.Windows.Forms.Label skillNameLabel;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn personColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personStatusColumn;
        private System.Windows.Forms.Label skillStatusLabel;
        private System.Windows.Forms.RadioButton peopleRadioButton;
        private System.Windows.Forms.RadioButton skillsRadioButton;
        private System.Windows.Forms.Panel peoplePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView skillDataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.Label peopleListLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillStatusColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button button1;
    }
}