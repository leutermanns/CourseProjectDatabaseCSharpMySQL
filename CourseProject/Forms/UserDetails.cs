using CourseProject.Forms;
using CourseProject.Mockups;
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
            ViewController.popupForm(new GroupSkillReport(true));
        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new AdminControls());
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewController.switchForm(new CourseDetails());
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            //int temp = CurrentUser.UserId;
           // MessageBox.Show($"{temp}");
            clearGridViews();
            
            updateTables();
        }
        private void updateTables()
        {
            
            Courses CurrentCourses = new Courses(CurrentUser.UserId);
            coursesDataGridView.DataSource = CurrentCourses.getTable();
            coursesDataGridView.DataMember = CurrentCourses.getTableName();

            Groups CurrentGroups = new Groups(CurrentUser.UserId);
            groupsDataGridView.DataSource = CurrentGroups.getTable();
            groupsDataGridView.DataMember = CurrentGroups.getTableName();
        }
        private void clearGridViews()
        {
            coursesDataGridView.DataSource = null;
            coursesDataGridView.Rows.Clear();
            coursesDataGridView.Columns.Clear();
            groupsDataGridView.DataSource = null;
            groupsDataGridView.Rows.Clear();
            groupsDataGridView.Columns.Clear();
        }
    }
}
