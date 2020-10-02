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

namespace CourseProject.Mockups
{
    public partial class CourseDetails : Form
    {
        private string current_courseID = "";
        public CourseDetails(string courseID)
        {
            InitializeComponent();
            current_courseID = courseID;
            this.labelCourseID.Text = current_courseID;
            string courseName = DataController.GetCourses().getCourseNameFromID(current_courseID);
            this.dataGridViewMembers.DataSource = DataController.GetCourses().getCourseMembers(courseName);
            string thing = DataController.GetCourses().getMembersTableName();
            this.dataGridViewMembers.DataMember = thing;
            foreach (DataGridViewColumn column in dataGridViewMembers.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            this.dataGridViewRelatedSkills.DataSource = DataController.GetCourses().getCourseSkill(courseName);
            this.dataGridViewRelatedSkills.DataMember = DataController.GetCourses().getSkillsTableName();
            foreach (DataGridViewColumn column in dataGridViewRelatedSkills.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            foreach (DataRow row in DataController.GetCourses().getCourseNonMembers(courseName).Tables[0].Rows)
                this.comboBoxUsers.Items.Add(row["firstname"] + " " + row["lastname"]);

            foreach (DataRow row in DataController.GetCourses().getCourseNonSkills(courseName).Tables[0].Rows)
                this.comboBoxSkills.Items.Add(row["name"]);
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserDetails());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void CourseDetails_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.comboBoxUsers.SelectedItem.ToString();
        }

        private void buttonRemoveUser_Click(object sender, EventArgs e)
        {
            //DataController.GetCourses().RemoveUserFromCourse(CurrentUser.UserId, getCourseDetailsCourseID());
            ViewController.switchForm(new UserDetails());
        }
        //get course ID
        private int getCourseDetailsCourseID()
        {
            int courseID = -1;
            courseID = Int32.Parse(labelCourseID.Text);
            return courseID;
        }
        private void buttonAddSkills_Click(object sender, EventArgs e)
        {
            this.comboBoxSkills.SelectedItem.ToString();
        }

        private void buttonRemoveSkill_Click(object sender, EventArgs e)
        {
            
        }

        private void labelCourseName_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseDetails_Load(object sender, EventArgs e)
        {

        }

        private void CourseDetails_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                ViewController.ForgetForm(this);
        }
    }
}
