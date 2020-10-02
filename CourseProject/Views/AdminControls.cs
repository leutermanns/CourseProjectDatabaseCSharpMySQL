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

namespace CourseProject.Forms
{
    public partial class AdminControls : Form
    {
        // These strings are used to update the names of courses, groups, and skills
        private string courseOldName = "", groupOldName = "", skillOldName = "";

        public AdminControls()
        {
            InitializeComponent();

            AdminControlsRefreshCoursesTable();
            AdminControlsRefreshGroupsTable();
            AdminControlsRefreshSkillsTable();
            AdminControlsRefreshSkillCategoriesTable();
        }

        #region Refresh

        private void AdminControlsRefreshCoursesTable()
        {
            this.dataGridViewCourses.DataSource = DataController.GetCourses().getCourseNamesTable();
            this.dataGridViewCourses.DataMember = DataController.GetCourses().getCourseNamesTableName();
            foreach (DataGridViewColumn column in dataGridViewCourses.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminControlsRefreshGroupsTable()
        {
            groupOldName = this.textBoxGroupName.Text;

            this.dataGridViewGroups.DataSource = DataController.GetGroups().getGroupNamesTable();
            this.dataGridViewGroups.DataMember = DataController.GetGroups().getGroupNamesTableName();
            foreach (DataGridViewColumn column in dataGridViewGroups.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminControlsRefreshSkillsTable()
        {
            skillOldName = this.textBoxSkillName.Text;

            this.dataGridViewSkills.DataSource = DataController.GetSkills().getSkillNamesTable();
            this.dataGridViewSkills.DataMember = DataController.GetSkills().getSkillNamesTableName();
            foreach (DataGridViewColumn column in dataGridViewSkills.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminControlsRefreshSkillCategoriesTable()
        {
            this.dataGridViewSkillCategories.DataSource = DataController.GetSkillCategories().getCategoryTable();
            this.dataGridViewSkillCategories.DataMember = DataController.GetSkillCategories().getCategoryTableName();
            foreach (DataGridViewColumn column in dataGridViewSkillCategories.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void AdminControlsRefreshCourses()
        {
            try
            {
                this.textBoxCourseName.Text = this.dataGridViewCourses.SelectedCells[0].Value.ToString();
            }
            catch (NullReferenceException)
            {
                return;
            }
            
            
            courseOldName = this.textBoxCourseName.Text;
            DataController.GetCourses().addUsers.Clear();
            DataController.GetCourses().addSkills.Clear();
            DataController.GetCourses().removeUsers.Clear();
            DataController.GetCourses().removeSkills.Clear();

            foreach (DataRow row in DataController.GetCourses().getCompleteCoursesTable().Tables[0].Rows)
            {
                if (row[0].ToString().Equals(this.textBoxCourseName.Text))
                {
                    textBoxCourseSummary.Text = row[1].ToString();
                    break;
                }
                else
                    textBoxCourseSummary.Text = "";
            }

            listBoxCourseRoster.Items.Clear();
            foreach (DataRow row in DataController.GetCourses().getCourseMembers(this.textBoxCourseName.Text).Tables[0].Rows)
                this.listBoxCourseRoster.Items.Add(row["firstname"] + " " + row["lastname"]);

            listBoxCourseSkills.Items.Clear();
            foreach (DataRow row in DataController.GetCourses().getCourseSkill(this.textBoxCourseName.Text).Tables[0].Rows)
                this.listBoxCourseSkills.Items.Add(row[0]);

            comboBoxCourseRoster.Items.Clear();
            foreach (DataRow row in DataController.GetCourses().getCourseNonMembers(this.textBoxCourseName.Text).Tables[0].Rows)
                this.comboBoxCourseRoster.Items.Add(row["firstname"] + " " + row["lastname"]);

            comboBoxCourseSkills.Items.Clear();
            foreach (DataRow row in DataController.GetCourses().getCourseNonSkills(this.textBoxCourseName.Text).Tables[0].Rows)
                this.comboBoxCourseSkills.Items.Add(row[0]);
        }

        private void AdminControlsRefreshGroups()
        {
            try
            {
                this.textBoxGroupName.Text = this.dataGridViewGroups.SelectedCells[0].Value.ToString();
            }
            catch (NullReferenceException)
            {
                return;
            }
            

            groupOldName = this.textBoxGroupName.Text;
            DataController.GetGroups().addUsers.Clear();
            DataController.GetGroups().addSkills.Clear();
            DataController.GetGroups().removeUsers.Clear();
            DataController.GetGroups().removeSkills.Clear();

            foreach (DataRow row in DataController.GetGroups().getCompleteTable().Tables[0].Rows)
            {
                if (row[0].ToString().Equals(this.textBoxGroupName.Text))
                {
                    textBoxGroupSummary.Text = row[1].ToString();
                    comboBoxGroupActive.SelectedIndex = (bool)row[2] ? 0 : 1;
                    break;
                }
                else
                {
                    textBoxGroupSummary.Text = "";
                }
            }

            listBoxGroupRoster.Items.Clear();
            foreach (DataRow row in DataController.GetGroups().getGroupMembers(this.textBoxGroupName.Text).Tables[0].Rows)
                this.listBoxGroupRoster.Items.Add(row["firstname"] + " " + row["lastname"]);

            listBoxGroupSkills.Items.Clear();
            foreach (DataRow row in DataController.GetGroups().getGroupSkill(this.textBoxGroupName.Text).Tables[0].Rows)
                this.listBoxGroupSkills.Items.Add(row[0]);

            comboBoxGroupRoster.Items.Clear();
            foreach (DataRow row in DataController.GetGroups().getGroupNonMembers(this.textBoxGroupName.Text).Tables[0].Rows)
                this.comboBoxGroupRoster.Items.Add(row["firstname"] + " " + row["lastname"]);

            comboBoxGroupSkill.Items.Clear();
            foreach (DataRow row in DataController.GetGroups().getGroupNonSkills(this.textBoxGroupName.Text).Tables[0].Rows)
                this.comboBoxGroupSkill.Items.Add(row[0]);
        }

        private void AdminControlsRefreshSkills()
        {
            try
            {
                this.textBoxSkillName.Text = this.dataGridViewSkills.SelectedCells[0].Value.ToString();
            }
            catch (NullReferenceException)
            {
                return;
            }

            skillOldName = this.textBoxSkillName.Text;
            DataController.GetSkills().addSkills.Clear();
            DataController.GetSkills().removeSkills.Clear();

            foreach (DataRow row in DataController.GetSkills().getCompleteTable().Tables[0].Rows)
            {
                if (row[0].ToString().Equals(this.textBoxSkillName.Text))
                {
                    textBoxSkillDescription.Text = row[1].ToString();
                    break;
                }
                else
                    textBoxSkillDescription.Text = "";
            }

            listBoxSubskills.Items.Clear();
            foreach (DataRow row in DataController.GetSkills().getSubSkillsTable(this.textBoxSkillName.Text).Tables[0].Rows)
                this.listBoxSubskills.Items.Add(row[0]);

            comboBoxSubskills.Items.Clear();
            foreach (DataRow row in DataController.GetSkills().getNonSubSkillsTable(this.textBoxSkillName.Text).Tables[0].Rows)
                this.comboBoxSubskills.Items.Add(row[0]);
        }
        #endregion

        #region Button Actions
        #region Course Button Actions
        private void buttonCourseRemoveUser_Click(object sender, EventArgs e)
        {
            int userId = getUserId(listBoxCourseRoster.Text);

            if (!DataController.GetCourses().addUsers.Contains(userId))
                DataController.GetCourses().removeUsers.Add(userId);
            else
                DataController.GetCourses().addUsers.Remove(userId);

            comboBoxCourseRoster.Items.Add(listBoxCourseRoster.Text);
            listBoxCourseRoster.Items.Remove(listBoxCourseRoster.Text);
        }

        private void buttonCourseRemoveSkill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(listBoxCourseSkills.Text);

            if (!DataController.GetCourses().addSkills.Contains(skillId))
                DataController.GetCourses().removeSkills.Add(skillId);
            else
                DataController.GetCourses().addSkills.Remove(skillId);

            comboBoxCourseSkills.Items.Add(listBoxCourseSkills.Text);
            listBoxCourseSkills.Items.Remove(listBoxCourseSkills.Text);
        }

        private void buttonCourseAddUser_Click(object sender, EventArgs e)
        {
            int userId = getUserId(comboBoxCourseRoster.Text);

            if (!DataController.GetCourses().removeUsers.Contains(userId))
                DataController.GetCourses().addUsers.Add(userId);
            else
                DataController.GetCourses().removeUsers.Remove(userId);

            listBoxCourseRoster.Items.Add(comboBoxCourseRoster.Text);
            comboBoxCourseRoster.Items.Remove(comboBoxCourseRoster.Text);
        }

        private void buttonCourseAddSkill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(comboBoxCourseSkills.Text);

            if (!DataController.GetCourses().removeSkills.Contains(skillId))
                DataController.GetCourses().addSkills.Add(skillId);
            else
                DataController.GetCourses().removeSkills.Remove(skillId);

            listBoxCourseSkills.Items.Add(comboBoxCourseSkills.Text);
            comboBoxCourseSkills.Items.Remove(comboBoxCourseSkills.Text);
        }

        private void buttonDeleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedCells[0].Value != null)
            {
                int courseId = getSelectedCourseId();
                DataController.GetCourses().DeleteCourse(courseId);

                AdminControlsRefreshCoursesTable();
            }
        }

        private void buttonCreateNewCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedCells[0].Value != null)
                System.Windows.Forms.MessageBox.Show("Please select the last cell before creating a new course. Then name the new course.");
            else
            {
                string courseName = this.textBoxCourseName.Text;
                string courseSummary = this.textBoxCourseSummary.Text;
                DataController.GetCourses().CreateCourse(courseName, courseSummary);

                int courseID = getSelectedCourseId(courseName);
                DataController.GetCourses().AddUserToCourse(courseID);
                DataController.GetCourses().RemoveUserFromCourse(courseID);
                DataController.GetCourses().AddSkillToCourse(courseID);
                DataController.GetCourses().RemoveSkillFromCourse(courseID);

                AdminControlsRefreshCoursesTable();
            }
            //this.dataGridViewCourses.DataSource = DataController.GetCourses().getCompleteCoursesTable();
            //this.dataGridViewCourses.DataMember = DataController.GetCourses().getCoursesTableName();
            //AdminControlsRefreshCoursesTable();
        }

        private void buttonSaveCourse_Click(object sender, EventArgs e)
        {
            int courseID = getSelectedCourseId(courseOldName);
            string newName = this.textBoxCourseName.Text;
            string summary = this.textBoxCourseSummary.Text;
            DataController.GetCourses().UpdateCourseName(courseID, newName);
            DataController.GetCourses().UpdateCourseSummary(courseID, summary);
            DataController.GetCourses().AddUserToCourse(courseID);
            DataController.GetCourses().RemoveUserFromCourse(courseID);
            DataController.GetCourses().AddSkillToCourse(courseID);
            DataController.GetCourses().RemoveSkillFromCourse(courseID);

            AdminControlsRefreshCoursesTable();
        }
        #endregion

        #region Group Button Actions
        private void buttonGroupRemoveUser_Click(object sender, EventArgs e)
        {
            int userId = getUserId(listBoxCourseRoster.Text);

            if (!DataController.GetGroups().addUsers.Contains(userId))
                DataController.GetGroups().removeUsers.Add(userId);
            else
                DataController.GetGroups().addUsers.Remove(userId);

            comboBoxGroupRoster.Items.Add(listBoxGroupRoster.Text);
            listBoxGroupRoster.Items.Remove(listBoxGroupRoster.Text);
        }

        private void buttonGroupRemoveSkill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(listBoxGroupSkills.Text);

            if (!DataController.GetGroups().addSkills.Contains(skillId))
                DataController.GetGroups().removeSkills.Add(skillId);
            else
                DataController.GetGroups().addSkills.Remove(skillId);

            comboBoxGroupSkill.Items.Add(listBoxGroupSkills.Text);
            listBoxGroupSkills.Items.Remove(listBoxGroupSkills.Text);
        }

        private void buttonGroupAddUser_Click(object sender, EventArgs e)
        {
            int userId = getUserId(comboBoxGroupRoster.Text);

            if (!DataController.GetGroups().removeUsers.Contains(userId))
                DataController.GetGroups().addUsers.Add(userId);
            else
                DataController.GetGroups().removeUsers.Remove(userId);

            listBoxGroupRoster.Items.Add(comboBoxGroupRoster.Text);
            comboBoxGroupRoster.Items.Remove(comboBoxGroupRoster.Text);
        }

        private void buttonGroupAddSkill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(comboBoxGroupSkill.Text);

            if (!DataController.GetGroups().removeSkills.Contains(skillId))
                DataController.GetGroups().addSkills.Add(skillId);
            else
                DataController.GetGroups().removeSkills.Remove(skillId);

            listBoxGroupSkills.Items.Add(comboBoxGroupSkill.Text);
            comboBoxGroupSkill.Items.Remove(comboBoxGroupSkill.Text);
        }

        private void buttonDeleteGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedCells[0].Value != null)
            {
                int groupId = getSelectedGroupId();
                DataController.GetGroups().DeleteGroup(groupId);

                AdminControlsRefreshGroupsTable();
            }
        }

        private void buttonCreateNewGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedCells[0].Value != null)
                System.Windows.Forms.MessageBox.Show("Please select the last cell before creating a new group. Then name the new group.");
            else
            {
                string groupName = this.textBoxGroupName.Text;
                string groupSummary = this.textBoxGroupSummary.Text;

                bool active;
                if (this.comboBoxGroupActive.SelectedIndex >= 0)
                    active = Boolean.Parse(this.comboBoxGroupActive.SelectedIndex.ToString());
                else
                    active = true;


                DataController.GetGroups().CreateGroup(groupName, groupSummary, active);

                int groupID = getSelectedGroupId(groupName);
                DataController.GetGroups().AddUserToGroup(groupID);
                DataController.GetGroups().RemoveUserFromGroup(groupID);
                DataController.GetGroups().AddSkillToGroup(groupID);
                DataController.GetGroups().RemoveSkillFromGroup(groupID);

                AdminControlsRefreshGroupsTable();
            }
        }


        private void buttonSaveGroup_Click(object sender, EventArgs e)
        {
            int groupID = getSelectedCourseId(groupOldName);
            string newName = this.textBoxGroupName.Text;
            string summary = this.textBoxGroupSummary.Text;
            DataController.GetGroups().UpdateGroupName(groupID, newName);
            DataController.GetGroups().UpdateGroupDescription(groupID, summary);
            DataController.GetGroups().AddUserToGroup(groupID);
            DataController.GetGroups().RemoveUserFromGroup(groupID);
            DataController.GetGroups().AddSkillToGroup(groupID);
            DataController.GetGroups().RemoveSkillFromGroup(groupID);

            AdminControlsRefreshGroupsTable();
        }
        #endregion

        #region Skill Button Actions
        private void buttonRemoveSubskill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(listBoxGroupSkills.Text);

            if (!DataController.GetSkills().addSkills.Contains(skillId))
                DataController.GetSkills().removeSkills.Add(skillId);
            else
                DataController.GetSkills().addSkills.Remove(skillId);

            comboBoxSubskills.Items.Add(listBoxSubskills.Text);
            listBoxSubskills.Items.Remove(listBoxSubskills.Text);
        }

        private void buttonAddSubskill_Click(object sender, EventArgs e)
        {
            int skillId = getSelectedSkillId(comboBoxSubskills.Text);

            if (!DataController.GetSkills().removeSkills.Contains(skillId))
                DataController.GetSkills().addSkills.Add(skillId);
            else
                DataController.GetSkills().removeSkills.Remove(skillId);

            listBoxSubskills.Items.Add(comboBoxSubskills.Text);
            comboBoxSubskills.Items.Remove(comboBoxSubskills.Text);
        }

        private void buttonDeleteSkill_Click(object sender, EventArgs e)
        {
            if (dataGridViewSkills.SelectedCells[0].Value != null)
            {
                int skillId = getSelectedSkillId(textBoxSkillName.Text);
                DataController.GetSkills().DeleteSkill(skillId);

                AdminControlsRefreshSkillsTable();
            }
        }

        private void buttonCreateNewSkill_Click(object sender, EventArgs e)
        {
            if (dataGridViewSkills.SelectedCells[0].Value != null)
                System.Windows.Forms.MessageBox.Show("Please select the last cell before creating a new skill. Then name the new skill.");
            else
            {
                string skillName = this.textBoxSkillName.Text;
                string skillDescription = this.textBoxSkillDescription.Text;
                DataController.GetSkills().CreateSkill(skillName, skillDescription);

                int skillID = getSelectedSkillId(skillName);
                DataController.GetSkills().AddSubskill(skillID);
                DataController.GetSkills().RemoveSubskill(skillID);

                AdminControlsRefreshSkillsTable();
            }
        }

        private void buttonSaveSkill_Click(object sender, EventArgs e)
        {
            int skillID = getSelectedCourseId(skillOldName);
            string newName = this.textBoxSkillName.Text;
            string summary = this.textBoxSkillDescription.Text;
            DataController.GetSkills().UpdateSkillName(skillID, newName);
            DataController.GetSkills().UpdateSkillDescription(skillID, summary);
            DataController.GetSkills().AddSubskill(skillID);
            DataController.GetSkills().RemoveSubskill(skillID);

            AdminControlsRefreshSkillsTable();
        }
        #endregion

        #region Skill Category Actions
        private void buttonCreateCategory_Click(object sender, EventArgs e)
        {
            string name = this.textBoxCategoryName.Text;
            int lowerBound = Int32.Parse(this.numericUpDownLowerBound.Value.ToString());
            int upperBound = Int32.Parse(this.numericUpDownUpperBound.Value.ToString());
            DataController.GetSkillCategories().CreateCategory(name, lowerBound, upperBound, true);

            AdminControlsRefreshSkillCategoriesTable();
        }
        #endregion

        private void buttonCompleteCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedCells[0].Value != null)
            {
                foreach (string person in listBoxCourseRoster.Items)
                {
                    int userId = getUserId(person);
                    foreach (string skill in listBoxCourseSkills.Items)
                    {
                        int skillId = getSelectedSkillId(skill);
                        DataController.GetSkills().AddSkillToUser(skillId, userId);
                    }
                }

                int courseId = getSelectedCourseId();
                DataController.GetCourses().DeleteCourse(courseId);

                AdminControlsRefreshCoursesTable();
            }
        }

        #endregion

        #region Get IDs
        private int getUserId(string userFullName)
        {
            string[] eachName = userFullName.Split(' ');
            string firstname = eachName[0];
            string lastname = eachName[1];

            return DataController.GetUserTable().GetUserID(firstname, lastname);
        }

        private int getSelectedCourseId()
        {
            string courseName = textBoxCourseName.Text;
            return DataController.GetCourses().getCourseID(courseName);
        }

        private int getSelectedCourseId(string courseName)
        {
            return DataController.GetCourses().getCourseID(courseName);
        }

        private int getSelectedGroupId()
        {
            string groupName = textBoxGroupName.Text;
            return DataController.GetGroups().getGroupID(groupName);
        }

        private int getSelectedGroupId(string groupName)
        {
            return DataController.GetGroups().getGroupID(groupName);
        }

        private int getSelectedSkillId(string skillName)
        {
            return DataController.GetSkills().getSkillID(skillName);
        }
        #endregion

        #region Change Views
        private void buttonViewGapReport_Click(object sender, EventArgs e)
        {
            ViewController.popupForm(new GroupSkillReport(false));
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserDetails());
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

        private void AdminControls_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminControlsRefreshCourses();
        }

        private void AdminControls_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewGroups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminControlsRefreshGroups();
        }

        private void dataGridViewSkills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AdminControlsRefreshSkills();
        }


        #endregion
    }
}
