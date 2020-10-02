namespace CourseProject
{
    partial class SkillSearch
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
            this.searchSkillsTextBox = new System.Windows.Forms.TextBox();
            this.searchUsersButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSearchLabel = new System.Windows.Forms.Label();
            this.andRadioButton = new System.Windows.Forms.RadioButton();
            this.skillsPanel = new System.Windows.Forms.Panel();
            this.orRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.numberOfSkillsRadioButton = new System.Windows.Forms.RadioButton();
            this.skillTagPanel = new System.Windows.Forms.Panel();
            this.skillNameLabel = new System.Windows.Forms.Label();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.skillPanel = new System.Windows.Forms.Panel();
            this.skillNamePanel = new System.Windows.Forms.Panel();
            this.templateSkillLabel = new System.Windows.Forms.Label();
            this.accordionButton = new System.Windows.Forms.Button();
            this.skillDetailsPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            this.skillsPanel.SuspendLayout();
            this.skillTagPanel.SuspendLayout();
            this.skillPanel.SuspendLayout();
            this.skillNamePanel.SuspendLayout();
            this.skillDetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchSkillsTextBox
            // 
            this.searchSkillsTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchSkillsTextBox.Name = "searchSkillsTextBox";
            this.searchSkillsTextBox.Size = new System.Drawing.Size(669, 20);
            this.searchSkillsTextBox.TabIndex = 0;
            this.searchSkillsTextBox.Text = "Search list of skills";
            // 
            // searchUsersButton
            // 
            this.searchUsersButton.Location = new System.Drawing.Point(687, 10);
            this.searchUsersButton.Name = "searchUsersButton";
            this.searchUsersButton.Size = new System.Drawing.Size(101, 23);
            this.searchUsersButton.TabIndex = 1;
            this.searchUsersButton.Text = "Search Users";
            this.searchUsersButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 141);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.personsDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.skillPanel);
            this.splitContainer1.Size = new System.Drawing.Size(776, 297);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.TabIndex = 2;
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.personsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.Size = new System.Drawing.Size(390, 297);
            this.personsDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Persons";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // typeOfSearchLabel
            // 
            this.typeOfSearchLabel.AutoSize = true;
            this.typeOfSearchLabel.Location = new System.Drawing.Point(9, 44);
            this.typeOfSearchLabel.Name = "typeOfSearchLabel";
            this.typeOfSearchLabel.Size = new System.Drawing.Size(83, 13);
            this.typeOfSearchLabel.TabIndex = 0;
            this.typeOfSearchLabel.Text = "Type of Search:";
            // 
            // andRadioButton
            // 
            this.andRadioButton.AutoSize = true;
            this.andRadioButton.Location = new System.Drawing.Point(98, 42);
            this.andRadioButton.Name = "andRadioButton";
            this.andRadioButton.Size = new System.Drawing.Size(48, 17);
            this.andRadioButton.TabIndex = 3;
            this.andRadioButton.TabStop = true;
            this.andRadioButton.Text = "AND";
            this.andRadioButton.UseVisualStyleBackColor = true;
            // 
            // skillsPanel
            // 
            this.skillsPanel.Controls.Add(this.skillTagPanel);
            this.skillsPanel.Location = new System.Drawing.Point(12, 65);
            this.skillsPanel.Name = "skillsPanel";
            this.skillsPanel.Size = new System.Drawing.Size(776, 70);
            this.skillsPanel.TabIndex = 4;
            // 
            // orRadioButton
            // 
            this.orRadioButton.AutoSize = true;
            this.orRadioButton.Location = new System.Drawing.Point(152, 42);
            this.orRadioButton.Name = "orRadioButton";
            this.orRadioButton.Size = new System.Drawing.Size(41, 17);
            this.orRadioButton.TabIndex = 5;
            this.orRadioButton.TabStop = true;
            this.orRadioButton.Text = "OR";
            this.orRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Location = new System.Drawing.Point(243, 44);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(44, 13);
            this.sortByLabel.TabIndex = 6;
            this.sortByLabel.Text = "Sort By:";
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(293, 42);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 7;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // numberOfSkillsRadioButton
            // 
            this.numberOfSkillsRadioButton.AutoSize = true;
            this.numberOfSkillsRadioButton.Location = new System.Drawing.Point(352, 42);
            this.numberOfSkillsRadioButton.Name = "numberOfSkillsRadioButton";
            this.numberOfSkillsRadioButton.Size = new System.Drawing.Size(101, 17);
            this.numberOfSkillsRadioButton.TabIndex = 8;
            this.numberOfSkillsRadioButton.TabStop = true;
            this.numberOfSkillsRadioButton.Text = "Number of Skills";
            this.numberOfSkillsRadioButton.UseVisualStyleBackColor = true;
            // 
            // skillTagPanel
            // 
            this.skillTagPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.skillTagPanel.Controls.Add(this.skillNameLabel);
            this.skillTagPanel.Controls.Add(this.removeItemButton);
            this.skillTagPanel.Location = new System.Drawing.Point(3, 3);
            this.skillTagPanel.Name = "skillTagPanel";
            this.skillTagPanel.Size = new System.Drawing.Size(115, 23);
            this.skillTagPanel.TabIndex = 0;
            // 
            // skillNameLabel
            // 
            this.skillNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillNameLabel.AutoSize = true;
            this.skillNameLabel.Location = new System.Drawing.Point(30, 5);
            this.skillNameLabel.Name = "skillNameLabel";
            this.skillNameLabel.Size = new System.Drawing.Size(82, 13);
            this.skillNameLabel.TabIndex = 0;
            this.skillNameLabel.Text = "Template Name";
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(1, 0);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(23, 23);
            this.removeItemButton.TabIndex = 0;
            this.removeItemButton.Text = "X";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // skillPanel
            // 
            this.skillPanel.Controls.Add(this.skillNamePanel);
            this.skillPanel.Controls.Add(this.skillDetailsPanel);
            this.skillPanel.Location = new System.Drawing.Point(3, 3);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.Size = new System.Drawing.Size(376, 106);
            this.skillPanel.TabIndex = 9;
            // 
            // skillNamePanel
            // 
            this.skillNamePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillNamePanel.Controls.Add(this.templateSkillLabel);
            this.skillNamePanel.Controls.Add(this.accordionButton);
            this.skillNamePanel.Location = new System.Drawing.Point(3, 3);
            this.skillNamePanel.Name = "skillNamePanel";
            this.skillNamePanel.Size = new System.Drawing.Size(370, 30);
            this.skillNamePanel.TabIndex = 4;
            // 
            // templateSkillLabel
            // 
            this.templateSkillLabel.AutoSize = true;
            this.templateSkillLabel.Location = new System.Drawing.Point(38, 8);
            this.templateSkillLabel.Name = "templateSkillLabel";
            this.templateSkillLabel.Size = new System.Drawing.Size(57, 13);
            this.templateSkillLabel.TabIndex = 2;
            this.templateSkillLabel.Text = "Skill Name";
            // 
            // accordionButton
            // 
            this.accordionButton.Location = new System.Drawing.Point(0, 3);
            this.accordionButton.Name = "accordionButton";
            this.accordionButton.Size = new System.Drawing.Size(32, 23);
            this.accordionButton.TabIndex = 1;
            this.accordionButton.Text = "\\/";
            this.accordionButton.UseVisualStyleBackColor = true;
            // 
            // skillDetailsPanel
            // 
            this.skillDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillDetailsPanel.Controls.Add(this.textBox1);
            this.skillDetailsPanel.Controls.Add(this.label3);
            this.skillDetailsPanel.Controls.Add(this.label1);
            this.skillDetailsPanel.Location = new System.Drawing.Point(3, 32);
            this.skillDetailsPanel.Name = "skillDetailsPanel";
            this.skillDetailsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skillDetailsPanel.Size = new System.Drawing.Size(370, 71);
            this.skillDetailsPanel.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 30);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Frequency of Retraining: 0";
            // 
            // SkillSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numberOfSkillsRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.orRadioButton);
            this.Controls.Add(this.skillsPanel);
            this.Controls.Add(this.andRadioButton);
            this.Controls.Add(this.typeOfSearchLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.searchUsersButton);
            this.Controls.Add(this.searchSkillsTextBox);
            this.Name = "SkillSearch";
            this.Text = "SkillSearch";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            this.skillsPanel.ResumeLayout(false);
            this.skillTagPanel.ResumeLayout(false);
            this.skillTagPanel.PerformLayout();
            this.skillPanel.ResumeLayout(false);
            this.skillNamePanel.ResumeLayout(false);
            this.skillNamePanel.PerformLayout();
            this.skillDetailsPanel.ResumeLayout(false);
            this.skillDetailsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchSkillsTextBox;
        private System.Windows.Forms.Button searchUsersButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label typeOfSearchLabel;
        private System.Windows.Forms.RadioButton andRadioButton;
        private System.Windows.Forms.Panel skillsPanel;
        private System.Windows.Forms.RadioButton orRadioButton;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton numberOfSkillsRadioButton;
        private System.Windows.Forms.Panel skillTagPanel;
        private System.Windows.Forms.Label skillNameLabel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Panel skillPanel;
        private System.Windows.Forms.Panel skillNamePanel;
        private System.Windows.Forms.Label templateSkillLabel;
        private System.Windows.Forms.Button accordionButton;
        private System.Windows.Forms.Panel skillDetailsPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}