namespace CourseProject
{
    partial class UserDetails
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.groupTabPage = new System.Windows.Forms.TabPage();
            this.groupDataGridView = new System.Windows.Forms.DataGridView();
            this.coursesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.userTabPage = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSkillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.groupTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.coursesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.userTabPage.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.groupTabPage);
            this.tabControl.Controls.Add(this.coursesTabPage);
            this.tabControl.Controls.Add(this.userTabPage);
            this.tabControl.ItemSize = new System.Drawing.Size(96, 18);
            this.tabControl.Location = new System.Drawing.Point(12, 34);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(776, 454);
            this.tabControl.TabIndex = 0;
            // 
            // groupTabPage
            // 
            this.groupTabPage.Controls.Add(this.groupDataGridView);
            this.groupTabPage.Location = new System.Drawing.Point(4, 22);
            this.groupTabPage.Name = "groupTabPage";
            this.groupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupTabPage.Size = new System.Drawing.Size(768, 428);
            this.groupTabPage.TabIndex = 1;
            this.groupTabPage.Text = "My Groups";
            this.groupTabPage.UseVisualStyleBackColor = true;
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupDataGridView.ColumnHeadersHeight = 21;
            this.groupDataGridView.Location = new System.Drawing.Point(6, 6);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.Size = new System.Drawing.Size(756, 416);
            this.groupDataGridView.TabIndex = 1;
            this.groupDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDataGridView_CellClick);
            // 
            // coursesTabPage
            // 
            this.coursesTabPage.Controls.Add(this.dataGridViewCourses);
            this.coursesTabPage.Location = new System.Drawing.Point(4, 22);
            this.coursesTabPage.Name = "coursesTabPage";
            this.coursesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.coursesTabPage.Size = new System.Drawing.Size(768, 428);
            this.coursesTabPage.TabIndex = 2;
            this.coursesTabPage.Text = "My Courses";
            this.coursesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCourses.ColumnHeadersHeight = 21;
            this.dataGridViewCourses.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.ReadOnly = true;
            this.dataGridViewCourses.Size = new System.Drawing.Size(756, 416);
            this.dataGridViewCourses.TabIndex = 1;
            this.dataGridViewCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // userTabPage
            // 
            this.userTabPage.Controls.Add(this.label4);
            this.userTabPage.Controls.Add(this.label3);
            this.userTabPage.Controls.Add(this.label2);
            this.userTabPage.Controls.Add(this.label1);
            this.userTabPage.Controls.Add(this.textBoxLastname);
            this.userTabPage.Controls.Add(this.textBoxFirstname);
            this.userTabPage.Controls.Add(this.textboxPassword);
            this.userTabPage.Controls.Add(this.textBoxUsername);
            this.userTabPage.Controls.Add(this.buttonSaveChanges);
            this.userTabPage.Location = new System.Drawing.Point(4, 22);
            this.userTabPage.Name = "userTabPage";
            this.userTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTabPage.Size = new System.Drawing.Size(768, 428);
            this.userTabPage.TabIndex = 3;
            this.userTabPage.Text = "My Profile";
            this.userTabPage.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControl);
            this.panelMain.Controls.Add(this.menuStrip1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 500);
            this.panelMain.TabIndex = 8;
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // userDetailsToolStripMenuItem
            // 
            this.userDetailsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
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
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(25, 391);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(162, 31);
            this.buttonSaveChanges.TabIndex = 0;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(113, 43);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(209, 24);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textboxPassword
            // 
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.Location = new System.Drawing.Point(113, 92);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(209, 24);
            this.textboxPassword.TabIndex = 2;
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(113, 142);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(209, 24);
            this.textBoxFirstname.TabIndex = 3;
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.Location = new System.Drawing.Point(113, 187);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(209, 24);
            this.textBoxLastname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name:";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panelMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDetails_FormClosed);
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.VisibleChanged += new System.EventHandler(this.UserDetails_VisibleChanged);
            this.tabControl.ResumeLayout(false);
            this.groupTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.coursesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.userTabPage.ResumeLayout(false);
            this.userTabPage.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage groupTabPage;
        private System.Windows.Forms.TabPage coursesTabPage;
        private System.Windows.Forms.DataGridView groupDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSkillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEvidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminControlsToolStripMenuItem;
        private System.Windows.Forms.TabPage userTabPage;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}