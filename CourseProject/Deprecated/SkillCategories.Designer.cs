namespace CourseProject
{
    partial class SkillCategories
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
            this.currentCategoriesPanel = new System.Windows.Forms.Panel();
            this.accordionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cellPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.templateTitleTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.buttomPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.newCategoryTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.currentCategoriesPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.cellPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.buttomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // currentCategoriesPanel
            // 
            this.currentCategoriesPanel.Controls.Add(this.accordionButton);
            this.currentCategoriesPanel.Controls.Add(this.label1);
            this.currentCategoriesPanel.Location = new System.Drawing.Point(12, 12);
            this.currentCategoriesPanel.Name = "currentCategoriesPanel";
            this.currentCategoriesPanel.Size = new System.Drawing.Size(535, 44);
            this.currentCategoriesPanel.TabIndex = 0;
            // 
            // accordionButton
            // 
            this.accordionButton.Location = new System.Drawing.Point(12, 10);
            this.accordionButton.Name = "accordionButton";
            this.accordionButton.Size = new System.Drawing.Size(27, 23);
            this.accordionButton.TabIndex = 0;
            this.accordionButton.Text = "\\/";
            this.accordionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Skill Categories";
            // 
            // middlePanel
            // 
            this.middlePanel.Controls.Add(this.tableLayoutPanel1);
            this.middlePanel.Location = new System.Drawing.Point(12, 62);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(535, 318);
            this.middlePanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cellPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cellPanel
            // 
            this.cellPanel.Controls.Add(this.removeButton);
            this.cellPanel.Controls.Add(this.templateTitleTextBox);
            this.cellPanel.Controls.Add(this.numericUpDown1);
            this.cellPanel.Controls.Add(this.numericUpDown2);
            this.cellPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellPanel.Location = new System.Drawing.Point(3, 3);
            this.cellPanel.Name = "cellPanel";
            this.cellPanel.Size = new System.Drawing.Size(523, 306);
            this.cellPanel.TabIndex = 0;
            this.cellPanel.Visible = false;
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(334, 147);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(25, 24);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "X";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // templateTitleTextBox
            // 
            this.templateTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.templateTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateTitleTextBox.Location = new System.Drawing.Point(43, 147);
            this.templateTitleTextBox.Name = "templateTitleTextBox";
            this.templateTitleTextBox.Size = new System.Drawing.Size(159, 22);
            this.templateTitleTextBox.TabIndex = 0;
            this.templateTitleTextBox.Text = "Template Title";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(208, 147);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(58, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(272, 147);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown2.TabIndex = 2;
            // 
            // buttomPanel
            // 
            this.buttomPanel.Controls.Add(this.saveButton);
            this.buttomPanel.Controls.Add(this.addCategoryButton);
            this.buttomPanel.Controls.Add(this.newCategoryTextBox);
            this.buttomPanel.Controls.Add(this.numericUpDown3);
            this.buttomPanel.Controls.Add(this.numericUpDown4);
            this.buttomPanel.Location = new System.Drawing.Point(13, 387);
            this.buttomPanel.Name = "buttomPanel";
            this.buttomPanel.Size = new System.Drawing.Size(534, 51);
            this.buttomPanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(442, 16);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(86, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(263, 17);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(110, 23);
            this.addCategoryButton.TabIndex = 6;
            this.addCategoryButton.Text = "Add New Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            // 
            // newCategoryTextBox
            // 
            this.newCategoryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCategoryTextBox.Location = new System.Drawing.Point(11, 17);
            this.newCategoryTextBox.Name = "newCategoryTextBox";
            this.newCategoryTextBox.ReadOnly = true;
            this.newCategoryTextBox.Size = new System.Drawing.Size(120, 22);
            this.newCategoryTextBox.TabIndex = 3;
            this.newCategoryTextBox.Text = "New Category";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(137, 17);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(58, 22);
            this.numericUpDown3.TabIndex = 4;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(201, 17);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(56, 22);
            this.numericUpDown4.TabIndex = 5;
            // 
            // SkillCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.buttomPanel);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.currentCategoriesPanel);
            this.Name = "SkillCategories";
            this.Text = "SkillCategories";
            this.currentCategoriesPanel.ResumeLayout(false);
            this.currentCategoriesPanel.PerformLayout();
            this.middlePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.cellPanel.ResumeLayout(false);
            this.cellPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.buttomPanel.ResumeLayout(false);
            this.buttomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentCategoriesPanel;
        private System.Windows.Forms.Button accordionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel buttomPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel cellPanel;
        private System.Windows.Forms.TextBox templateTitleTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox newCategoryTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Button removeButton;
    }
}