namespace CourseProject.Mockups
{
    partial class CourseDetails
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
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelCourseID = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMembers = new System.Windows.Forms.TabPage();
            this.buttonRemoveUser = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.dataGridViewMembers = new System.Windows.Forms.DataGridView();
            this.tabPageRelatedSkills = new System.Windows.Forms.TabPage();
            this.buttonRemoveSkill = new System.Windows.Forms.Button();
            this.buttonAddSkills = new System.Windows.Forms.Button();
            this.comboBoxSkills = new System.Windows.Forms.ComboBox();
            this.dataGridViewRelatedSkills = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).BeginInit();
            this.tabPageRelatedSkills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatedSkills)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
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
            // labelCourseID
            // 
            this.labelCourseID.AutoSize = true;
            this.labelCourseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourseID.Location = new System.Drawing.Point(12, 24);
            this.labelCourseID.Name = "labelCourseID";
            this.labelCourseID.Size = new System.Drawing.Size(127, 24);
            this.labelCourseID.TabIndex = 7;
            this.labelCourseID.Text = "Course Name";
            this.labelCourseID.Click += new System.EventHandler(this.labelCourseName_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMembers);
            this.tabControl.Controls.Add(this.tabPageRelatedSkills);
            this.tabControl.Location = new System.Drawing.Point(12, 51);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 437);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageMembers
            // 
            this.tabPageMembers.Controls.Add(this.buttonRemoveUser);
            this.tabPageMembers.Controls.Add(this.buttonAddUser);
            this.tabPageMembers.Controls.Add(this.comboBoxUsers);
            this.tabPageMembers.Controls.Add(this.dataGridViewMembers);
            this.tabPageMembers.Location = new System.Drawing.Point(4, 22);
            this.tabPageMembers.Name = "tabPageMembers";
            this.tabPageMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMembers.Size = new System.Drawing.Size(768, 411);
            this.tabPageMembers.TabIndex = 0;
            this.tabPageMembers.Text = "Members";
            this.tabPageMembers.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveUser
            // 
            this.buttonRemoveUser.Location = new System.Drawing.Point(676, 7);
            this.buttonRemoveUser.Name = "buttonRemoveUser";
            this.buttonRemoveUser.Size = new System.Drawing.Size(86, 23);
            this.buttonRemoveUser.TabIndex = 4;
            this.buttonRemoveUser.Text = "Leave Course";
            this.buttonRemoveUser.UseVisualStyleBackColor = true;
            this.buttonRemoveUser.Click += new System.EventHandler(this.buttonRemoveUser_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(274, 6);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Add User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Visible = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(6, 6);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(262, 21);
            this.comboBoxUsers.TabIndex = 2;
            this.comboBoxUsers.Visible = false;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // dataGridViewMembers
            // 
            this.dataGridViewMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMembers.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewMembers.Name = "dataGridViewMembers";
            this.dataGridViewMembers.ReadOnly = true;
            this.dataGridViewMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMembers.Size = new System.Drawing.Size(756, 370);
            this.dataGridViewMembers.TabIndex = 1;
            // 
            // tabPageRelatedSkills
            // 
            this.tabPageRelatedSkills.Controls.Add(this.buttonRemoveSkill);
            this.tabPageRelatedSkills.Controls.Add(this.buttonAddSkills);
            this.tabPageRelatedSkills.Controls.Add(this.comboBoxSkills);
            this.tabPageRelatedSkills.Controls.Add(this.dataGridViewRelatedSkills);
            this.tabPageRelatedSkills.Location = new System.Drawing.Point(4, 22);
            this.tabPageRelatedSkills.Name = "tabPageRelatedSkills";
            this.tabPageRelatedSkills.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRelatedSkills.Size = new System.Drawing.Size(768, 411);
            this.tabPageRelatedSkills.TabIndex = 1;
            this.tabPageRelatedSkills.Text = "Related Skills";
            this.tabPageRelatedSkills.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveSkill
            // 
            this.buttonRemoveSkill.Location = new System.Drawing.Point(676, 7);
            this.buttonRemoveSkill.Name = "buttonRemoveSkill";
            this.buttonRemoveSkill.Size = new System.Drawing.Size(86, 23);
            this.buttonRemoveSkill.TabIndex = 8;
            this.buttonRemoveSkill.Text = "Remove Skill";
            this.buttonRemoveSkill.UseVisualStyleBackColor = true;
            this.buttonRemoveSkill.Visible = false;
            this.buttonRemoveSkill.Click += new System.EventHandler(this.buttonRemoveSkill_Click);
            // 
            // buttonAddSkills
            // 
            this.buttonAddSkills.Location = new System.Drawing.Point(274, 7);
            this.buttonAddSkills.Name = "buttonAddSkills";
            this.buttonAddSkills.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSkills.TabIndex = 7;
            this.buttonAddSkills.Text = "Add Skill";
            this.buttonAddSkills.UseVisualStyleBackColor = true;
            this.buttonAddSkills.Visible = false;
            this.buttonAddSkills.Click += new System.EventHandler(this.buttonAddSkills_Click);
            // 
            // comboBoxSkills
            // 
            this.comboBoxSkills.FormattingEnabled = true;
            this.comboBoxSkills.Location = new System.Drawing.Point(6, 6);
            this.comboBoxSkills.Name = "comboBoxSkills";
            this.comboBoxSkills.Size = new System.Drawing.Size(262, 21);
            this.comboBoxSkills.TabIndex = 6;
            this.comboBoxSkills.Visible = false;
            // 
            // dataGridViewRelatedSkills
            // 
            this.dataGridViewRelatedSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRelatedSkills.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewRelatedSkills.Name = "dataGridViewRelatedSkills";
            this.dataGridViewRelatedSkills.ReadOnly = true;
            this.dataGridViewRelatedSkills.Size = new System.Drawing.Size(756, 370);
            this.dataGridViewRelatedSkills.TabIndex = 5;
            // 
            // CourseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelCourseID);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CourseDetails";
            this.Text = "CourseDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseDetails_FormClosed);
            this.Load += new System.EventHandler(this.CourseDetails_Load);
            this.VisibleChanged += new System.EventHandler(this.CourseDetails_VisibleChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageMembers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMembers)).EndInit();
            this.tabPageRelatedSkills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRelatedSkills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label labelCourseID;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMembers;
        private System.Windows.Forms.TabPage tabPageRelatedSkills;
        private System.Windows.Forms.Button buttonRemoveUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.DataGridView dataGridViewMembers;
        private System.Windows.Forms.Button buttonRemoveSkill;
        private System.Windows.Forms.Button buttonAddSkills;
        private System.Windows.Forms.ComboBox comboBoxSkills;
        private System.Windows.Forms.DataGridView dataGridViewRelatedSkills;
    }
}