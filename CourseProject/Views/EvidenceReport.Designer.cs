namespace CourseProject
{
    partial class EvidenceReport
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
            this.labelAuthro = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxSkill = new System.Windows.Forms.ComboBox();
            this.listBoxAssociatedSkills = new System.Windows.Forms.ListBox();
            this.labelCreated = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelAssociatedSkills = new System.Windows.Forms.Label();
            this.labelLastEdit = new System.Windows.Forms.Label();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.textBoxEvidenceName = new System.Windows.Forms.TextBox();
            this.buttonAddEvidence = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAuthro
            // 
            this.labelAuthro.AutoSize = true;
            this.labelAuthro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthro.Location = new System.Drawing.Point(12, 109);
            this.labelAuthro.Name = "labelAuthro";
            this.labelAuthro.Size = new System.Drawing.Size(154, 20);
            this.labelAuthro.TabIndex = 1;
            this.labelAuthro.Text = "Author: <Full Name>";
            this.labelAuthro.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(422, 587);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(61, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.Location = new System.Drawing.Point(10, 284);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(472, 298);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // comboBoxSkill
            // 
            this.comboBoxSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSkill.FormattingEnabled = true;
            this.comboBoxSkill.Location = new System.Drawing.Point(12, 47);
            this.comboBoxSkill.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSkill.Name = "comboBoxSkill";
            this.comboBoxSkill.Size = new System.Drawing.Size(470, 28);
            this.comboBoxSkill.TabIndex = 5;
            this.comboBoxSkill.Text = "<Skill Name>";
            this.comboBoxSkill.SelectedIndexChanged += new System.EventHandler(this.comboBoxSkill_SelectedIndexChanged);
            // 
            // listBoxAssociatedSkills
            // 
            this.listBoxAssociatedSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAssociatedSkills.FormattingEnabled = true;
            this.listBoxAssociatedSkills.Location = new System.Drawing.Point(10, 184);
            this.listBoxAssociatedSkills.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAssociatedSkills.Name = "listBoxAssociatedSkills";
            this.listBoxAssociatedSkills.Size = new System.Drawing.Size(470, 82);
            this.listBoxAssociatedSkills.TabIndex = 6;
            // 
            // labelCreated
            // 
            this.labelCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCreated.AutoSize = true;
            this.labelCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreated.Location = new System.Drawing.Point(10, 129);
            this.labelCreated.Name = "labelCreated";
            this.labelCreated.Size = new System.Drawing.Size(234, 20);
            this.labelCreated.TabIndex = 7;
            this.labelCreated.Text = "Created: MM/DD/YYYY HH:mm";
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Location = new System.Drawing.Point(11, 268);
            this.labelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(39, 13);
            this.labelDetails.TabIndex = 8;
            this.labelDetails.Text = "Details";
            // 
            // labelAssociatedSkills
            // 
            this.labelAssociatedSkills.AutoSize = true;
            this.labelAssociatedSkills.Location = new System.Drawing.Point(11, 169);
            this.labelAssociatedSkills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAssociatedSkills.Name = "labelAssociatedSkills";
            this.labelAssociatedSkills.Size = new System.Drawing.Size(86, 13);
            this.labelAssociatedSkills.TabIndex = 9;
            this.labelAssociatedSkills.Text = "Associated Skills";
            // 
            // labelLastEdit
            // 
            this.labelLastEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastEdit.AutoSize = true;
            this.labelLastEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastEdit.Location = new System.Drawing.Point(10, 149);
            this.labelLastEdit.Name = "labelLastEdit";
            this.labelLastEdit.Size = new System.Drawing.Size(240, 20);
            this.labelLastEdit.TabIndex = 10;
            this.labelLastEdit.Text = "Last Edit: MM/DD/YYYY HH:mm";
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(12, 79);
            this.comboBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(470, 28);
            this.comboBoxUser.TabIndex = 11;
            this.comboBoxUser.Text = "<Targeted User>";
            // 
            // textBoxEvidenceName
            // 
            this.textBoxEvidenceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEvidenceName.Location = new System.Drawing.Point(12, 16);
            this.textBoxEvidenceName.Name = "textBoxEvidenceName";
            this.textBoxEvidenceName.Size = new System.Drawing.Size(471, 26);
            this.textBoxEvidenceName.TabIndex = 12;
            this.textBoxEvidenceName.Text = "Name";
            // 
            // buttonAddEvidence
            // 
            this.buttonAddEvidence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddEvidence.Location = new System.Drawing.Point(384, 587);
            this.buttonAddEvidence.Name = "buttonAddEvidence";
            this.buttonAddEvidence.Size = new System.Drawing.Size(98, 23);
            this.buttonAddEvidence.TabIndex = 13;
            this.buttonAddEvidence.Text = "Create Evidence";
            this.buttonAddEvidence.UseVisualStyleBackColor = true;
            this.buttonAddEvidence.Click += new System.EventHandler(this.buttonAddEvidence_Click);
            // 
            // EvidenceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 621);
            this.Controls.Add(this.textBoxEvidenceName);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.labelLastEdit);
            this.Controls.Add(this.labelAssociatedSkills);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.labelCreated);
            this.Controls.Add(this.listBoxAssociatedSkills);
            this.Controls.Add(this.comboBoxSkill);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAuthro);
            this.Controls.Add(this.buttonAddEvidence);
            this.Name = "EvidenceReport";
            this.Text = "EvidenceReport";
            this.VisibleChanged += new System.EventHandler(this.EvidenceReport_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAuthro;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ComboBox comboBoxSkill;
        private System.Windows.Forms.ListBox listBoxAssociatedSkills;
        private System.Windows.Forms.Label labelCreated;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelAssociatedSkills;
        private System.Windows.Forms.Label labelLastEdit;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.TextBox textBoxEvidenceName;
        private System.Windows.Forms.Button buttonAddEvidence;
    }
}