using CourseProject.Forms;
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
    public partial class UserEvidence : Form
    {
        public UserEvidence()
        {
            InitializeComponent();
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserDetails());
        }

        private void userSkillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserSkills());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewController.switchForm(new EvidenceReport());
        }

        private void buttonCreateEvidence_Click(object sender, EventArgs e)
        {
            ViewController.popupForm(new EvidenceReport());
        }

        private void UserEvidence_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new AdminControls());
        }

        private void UserEvidence_Load(object sender, EventArgs e)
        {
            clearSkillsTable();
            updateSkillsTable();
        }
        private void clearSkillsTable()
        {
            evidenceGridView.DataSource = null;
            evidenceGridView.Rows.Clear();
            evidenceGridView.Columns.Clear();
        }
        private void updateSkillsTable()
        {
            Evidence currentEvidence = new Evidence(CurrentUser.UserId);
            evidenceGridView.DataSource = currentEvidence.getTable();
            evidenceGridView.DataMember = currentEvidence.getTableName();
        }
    }
}
