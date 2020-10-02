using CourseProject.Forms;
using CourseProject.Mockups;
using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    public partial class UserDetails : Form
    {
        public UserDetails()
        {
            InitializeComponent();

            
        }

        private void userSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserSkills());
        }

        private void userEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserEvidence());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void UserDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // ViewController.popupForm(new GroupSkillReport(true));
        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new AdminControls());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewCourses.SelectedCells[0].ColumnIndex != 0)
                return;
            string courseID = this.dataGridViewCourses.SelectedCells[0].Value.ToString();
            if (courseID.Equals(""))
                return;
            ViewController.switchForm(new CourseDetails(courseID));
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void UserDetails_VisibleChanged(object sender, EventArgs e)
        {
            DataController.genData(CurrentUser.UserId);

            this.groupDataGridView.DataSource = DataController.GetGroups().getTable();
            this.groupDataGridView.DataMember = DataController.GetGroups().getTableName();

            this.dataGridViewCourses.DataSource = DataController.GetCourses().getCoursesTable();
            this.dataGridViewCourses.DataMember = DataController.GetCourses().getCoursesTableName();

            var userInfo = DataController.GetUserTable().GetUserInfoFromID(CurrentUser.UserId);
            this.textBoxUsername.Text = userInfo.Item1;
            this.textboxPassword.Text = userInfo.Item2;
            this.textBoxFirstname.Text = userInfo.Item3;
            this.textBoxLastname.Text = userInfo.Item4;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.textBoxUsername.Text;
            string password = this.textboxPassword.Text;
            string firstname = this.textBoxFirstname.Text;
            string lastname = this.textBoxLastname.Text;
            DataController.GetUserTable().UpdateUserInfo(CurrentUser.UserId, username, password, firstname, lastname);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
