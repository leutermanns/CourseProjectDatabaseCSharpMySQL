namespace CourseProject
{
    partial class Competency
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.rateButton = new System.Windows.Forms.Button();
            this.skillLevelLabel = new System.Windows.Forms.Label();
            this.requestButton = new System.Windows.Forms.Button();
            this.crossReferencedCompetenciesListBox = new System.Windows.Forms.ListBox();
            this.proficientLabel = new System.Windows.Forms.Label();
            this.reviewStatusLabel = new System.Windows.Forms.Label();
            this.crossReferencedLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.evidencePanel = new System.Windows.Forms.Panel();
            this.collapseEvidencePanel = new System.Windows.Forms.Panel();
            this.accordionButton = new System.Windows.Forms.Button();
            this.evidenceLabel = new System.Windows.Forms.Label();
            this.listedEvidencePanel = new System.Windows.Forms.Panel();
            this.templateEvidencePanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.publisherNameLabel = new System.Windows.Forms.Label();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.evidenceDetailTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.evidencePanel.SuspendLayout();
            this.collapseEvidencePanel.SuspendLayout();
            this.listedEvidencePanel.SuspendLayout();
            this.templateEvidencePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rateButton);
            this.mainPanel.Controls.Add(this.evidencePanel);
            this.mainPanel.Controls.Add(this.skillLevelLabel);
            this.mainPanel.Controls.Add(this.requestButton);
            this.mainPanel.Controls.Add(this.crossReferencedCompetenciesListBox);
            this.mainPanel.Controls.Add(this.proficientLabel);
            this.mainPanel.Controls.Add(this.reviewStatusLabel);
            this.mainPanel.Controls.Add(this.crossReferencedLabel);
            this.mainPanel.Controls.Add(this.titleLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(499, 593);
            this.mainPanel.TabIndex = 0;
            // 
            // rateButton
            // 
            this.rateButton.Location = new System.Drawing.Point(142, 223);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(75, 23);
            this.rateButton.TabIndex = 9;
            this.rateButton.Text = "Rate";
            this.rateButton.UseVisualStyleBackColor = true;
            // 
            // skillLevelLabel
            // 
            this.skillLevelLabel.AutoSize = true;
            this.skillLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLevelLabel.Location = new System.Drawing.Point(13, 223);
            this.skillLevelLabel.Name = "skillLevelLabel";
            this.skillLevelLabel.Size = new System.Drawing.Size(123, 24);
            this.skillLevelLabel.TabIndex = 7;
            this.skillLevelLabel.Text = "Skill Level: ##";
            // 
            // requestButton
            // 
            this.requestButton.Location = new System.Drawing.Point(17, 151);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(104, 23);
            this.requestButton.TabIndex = 6;
            this.requestButton.Text = "Request Review";
            this.requestButton.UseVisualStyleBackColor = true;
            // 
            // crossReferencedCompetenciesListBox
            // 
            this.crossReferencedCompetenciesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crossReferencedCompetenciesListBox.FormattingEnabled = true;
            this.crossReferencedCompetenciesListBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.crossReferencedCompetenciesListBox.Location = new System.Drawing.Point(17, 65);
            this.crossReferencedCompetenciesListBox.Name = "crossReferencedCompetenciesListBox";
            this.crossReferencedCompetenciesListBox.Size = new System.Drawing.Size(470, 56);
            this.crossReferencedCompetenciesListBox.TabIndex = 5;
            // 
            // proficientLabel
            // 
            this.proficientLabel.AutoSize = true;
            this.proficientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proficientLabel.Location = new System.Drawing.Point(13, 186);
            this.proficientLabel.Name = "proficientLabel";
            this.proficientLabel.Size = new System.Drawing.Size(151, 24);
            this.proficientLabel.TabIndex = 4;
            this.proficientLabel.Text = "Proficient: ---------";
            // 
            // reviewStatusLabel
            // 
            this.reviewStatusLabel.AutoSize = true;
            this.reviewStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewStatusLabel.Location = new System.Drawing.Point(13, 124);
            this.reviewStatusLabel.Name = "reviewStatusLabel";
            this.reviewStatusLabel.Size = new System.Drawing.Size(191, 24);
            this.reviewStatusLabel.TabIndex = 3;
            this.reviewStatusLabel.Text = "Review Status: ---------";
            // 
            // crossReferencedLabel
            // 
            this.crossReferencedLabel.AutoSize = true;
            this.crossReferencedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossReferencedLabel.Location = new System.Drawing.Point(13, 38);
            this.crossReferencedLabel.Name = "crossReferencedLabel";
            this.crossReferencedLabel.Size = new System.Drawing.Size(288, 24);
            this.crossReferencedLabel.TabIndex = 2;
            this.crossReferencedLabel.Text = "Cross-referenced Competencies:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Competency Title";
            // 
            // evidencePanel
            // 
            this.evidencePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evidencePanel.Controls.Add(this.listedEvidencePanel);
            this.evidencePanel.Controls.Add(this.collapseEvidencePanel);
            this.evidencePanel.Location = new System.Drawing.Point(12, 252);
            this.evidencePanel.Name = "evidencePanel";
            this.evidencePanel.Size = new System.Drawing.Size(475, 329);
            this.evidencePanel.TabIndex = 8;
            // 
            // collapseEvidencePanel
            // 
            this.collapseEvidencePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseEvidencePanel.Controls.Add(this.evidenceLabel);
            this.collapseEvidencePanel.Controls.Add(this.accordionButton);
            this.collapseEvidencePanel.Location = new System.Drawing.Point(3, 3);
            this.collapseEvidencePanel.Name = "collapseEvidencePanel";
            this.collapseEvidencePanel.Size = new System.Drawing.Size(469, 29);
            this.collapseEvidencePanel.TabIndex = 0;
            // 
            // accordionButton
            // 
            this.accordionButton.Location = new System.Drawing.Point(3, 3);
            this.accordionButton.Name = "accordionButton";
            this.accordionButton.Size = new System.Drawing.Size(26, 23);
            this.accordionButton.TabIndex = 0;
            this.accordionButton.Text = "\\/";
            this.accordionButton.UseVisualStyleBackColor = true;
            // 
            // evidenceLabel
            // 
            this.evidenceLabel.AutoSize = true;
            this.evidenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evidenceLabel.Location = new System.Drawing.Point(35, 3);
            this.evidenceLabel.Name = "evidenceLabel";
            this.evidenceLabel.Size = new System.Drawing.Size(74, 20);
            this.evidenceLabel.TabIndex = 1;
            this.evidenceLabel.Text = "Evidence";
            // 
            // listedEvidencePanel
            // 
            this.listedEvidencePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listedEvidencePanel.Controls.Add(this.templateEvidencePanel);
            this.listedEvidencePanel.Location = new System.Drawing.Point(3, 35);
            this.listedEvidencePanel.Name = "listedEvidencePanel";
            this.listedEvidencePanel.Size = new System.Drawing.Size(469, 291);
            this.listedEvidencePanel.TabIndex = 1;
            // 
            // templateEvidencePanel
            // 
            this.templateEvidencePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateEvidencePanel.Controls.Add(this.evidenceDetailTextBox);
            this.templateEvidencePanel.Controls.Add(this.timeStampLabel);
            this.templateEvidencePanel.Controls.Add(this.publisherNameLabel);
            this.templateEvidencePanel.Controls.Add(this.removeButton);
            this.templateEvidencePanel.Location = new System.Drawing.Point(3, 3);
            this.templateEvidencePanel.Name = "templateEvidencePanel";
            this.templateEvidencePanel.Size = new System.Drawing.Size(463, 77);
            this.templateEvidencePanel.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(436, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(24, 21);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "X";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // publisherNameLabel
            // 
            this.publisherNameLabel.AutoSize = true;
            this.publisherNameLabel.Location = new System.Drawing.Point(3, 7);
            this.publisherNameLabel.Name = "publisherNameLabel";
            this.publisherNameLabel.Size = new System.Drawing.Size(81, 13);
            this.publisherNameLabel.TabIndex = 5;
            this.publisherNameLabel.Text = "Publisher Name";
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Location = new System.Drawing.Point(236, 7);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(197, 13);
            this.timeStampLabel.TabIndex = 6;
            this.timeStampLabel.Text = "Day of Week, DD Month YYYY, HH:mm";
            // 
            // evidenceDetailTextBox
            // 
            this.evidenceDetailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evidenceDetailTextBox.Location = new System.Drawing.Point(6, 30);
            this.evidenceDetailTextBox.Multiline = true;
            this.evidenceDetailTextBox.Name = "evidenceDetailTextBox";
            this.evidenceDetailTextBox.Size = new System.Drawing.Size(454, 44);
            this.evidenceDetailTextBox.TabIndex = 7;
            // 
            // Competency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 593);
            this.Controls.Add(this.mainPanel);
            this.Name = "Competency";
            this.Text = "Competency";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.evidencePanel.ResumeLayout(false);
            this.collapseEvidencePanel.ResumeLayout(false);
            this.collapseEvidencePanel.PerformLayout();
            this.listedEvidencePanel.ResumeLayout(false);
            this.templateEvidencePanel.ResumeLayout(false);
            this.templateEvidencePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label proficientLabel;
        private System.Windows.Forms.Label reviewStatusLabel;
        private System.Windows.Forms.Label crossReferencedLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label skillLevelLabel;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.ListBox crossReferencedCompetenciesListBox;
        private System.Windows.Forms.Button rateButton;
        private System.Windows.Forms.Panel evidencePanel;
        private System.Windows.Forms.Panel listedEvidencePanel;
        private System.Windows.Forms.Panel templateEvidencePanel;
        private System.Windows.Forms.Panel collapseEvidencePanel;
        private System.Windows.Forms.Label evidenceLabel;
        private System.Windows.Forms.Button accordionButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox evidenceDetailTextBox;
        private System.Windows.Forms.Label timeStampLabel;
        private System.Windows.Forms.Label publisherNameLabel;
    }
}