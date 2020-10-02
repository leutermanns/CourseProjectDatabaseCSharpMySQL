namespace CourseProject
{
    partial class JobFunctions
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatedSkillsPanel = new System.Windows.Forms.Panel();
            this.skillPanel = new System.Windows.Forms.Panel();
            this.accordionButton = new System.Windows.Forms.Button();
            this.templateSkillLabel = new System.Windows.Forms.Label();
            this.skillDetailsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.skillNamePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.relatedSkillsPanel.SuspendLayout();
            this.skillPanel.SuspendLayout();
            this.skillDetailsPanel.SuspendLayout();
            this.skillNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.relatedSkillsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(824, 450);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Job Function";
            this.Column1.Name = "Column1";
            // 
            // relatedSkillsPanel
            // 
            this.relatedSkillsPanel.Controls.Add(this.skillPanel);
            this.relatedSkillsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.relatedSkillsPanel.Location = new System.Drawing.Point(0, 0);
            this.relatedSkillsPanel.Name = "relatedSkillsPanel";
            this.relatedSkillsPanel.Size = new System.Drawing.Size(408, 450);
            this.relatedSkillsPanel.TabIndex = 0;
            // 
            // skillPanel
            // 
            this.skillPanel.Controls.Add(this.skillNamePanel);
            this.skillPanel.Controls.Add(this.skillDetailsPanel);
            this.skillPanel.Location = new System.Drawing.Point(3, 3);
            this.skillPanel.Name = "skillPanel";
            this.skillPanel.Size = new System.Drawing.Size(402, 134);
            this.skillPanel.TabIndex = 1;
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
            // templateSkillLabel
            // 
            this.templateSkillLabel.AutoSize = true;
            this.templateSkillLabel.Location = new System.Drawing.Point(38, 8);
            this.templateSkillLabel.Name = "templateSkillLabel";
            this.templateSkillLabel.Size = new System.Drawing.Size(57, 13);
            this.templateSkillLabel.TabIndex = 2;
            this.templateSkillLabel.Text = "Skill Name";
            // 
            // skillDetailsPanel
            // 
            this.skillDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillDetailsPanel.Controls.Add(this.textBox1);
            this.skillDetailsPanel.Controls.Add(this.label3);
            this.skillDetailsPanel.Controls.Add(this.label2);
            this.skillDetailsPanel.Controls.Add(this.label1);
            this.skillDetailsPanel.Location = new System.Drawing.Point(3, 32);
            this.skillDetailsPanel.Name = "skillDetailsPanel";
            this.skillDetailsPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.skillDetailsPanel.Size = new System.Drawing.Size(396, 99);
            this.skillDetailsPanel.TabIndex = 3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timeline for Gaining Skill: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 36);
            this.textBox1.TabIndex = 3;
            // 
            // skillNamePanel
            // 
            this.skillNamePanel.Controls.Add(this.templateSkillLabel);
            this.skillNamePanel.Controls.Add(this.accordionButton);
            this.skillNamePanel.Location = new System.Drawing.Point(3, 3);
            this.skillNamePanel.Name = "skillNamePanel";
            this.skillNamePanel.Size = new System.Drawing.Size(396, 26);
            this.skillNamePanel.TabIndex = 4;
            // 
            // JobFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "JobFunctions";
            this.Text = "JobFunctions";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.relatedSkillsPanel.ResumeLayout(false);
            this.skillPanel.ResumeLayout(false);
            this.skillDetailsPanel.ResumeLayout(false);
            this.skillDetailsPanel.PerformLayout();
            this.skillNamePanel.ResumeLayout(false);
            this.skillNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel relatedSkillsPanel;
        private System.Windows.Forms.Panel skillPanel;
        private System.Windows.Forms.Button accordionButton;
        private System.Windows.Forms.Panel skillDetailsPanel;
        private System.Windows.Forms.Label templateSkillLabel;
        private System.Windows.Forms.Panel skillNamePanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}