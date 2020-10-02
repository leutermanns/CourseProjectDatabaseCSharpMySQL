using CourseProject.Forms;
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
    public partial class UserSkills : Form
    {
        public UserSkills()
        {
            InitializeComponent();

            
        }

        private void userEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserEvidence());
        }

        private void userDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserDetails());
        }

        private void UserSkills_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void adminControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new AdminControls());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewController.popupForm(new EvidenceReport(this, null));
        }

        private void UserSkills_Load(object sender, EventArgs e)
        {
            
        }

        private void UserSkills_VisibleChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        public void refreshTable()
        {
            DataController.genData(CurrentUser.UserId);
            this.dataGridViewSkills.DataSource = DataController.GetSkills().getTable();
            this.dataGridViewSkills.DataMember = DataController.GetSkills().getTableName();
            foreach (DataGridViewColumn column in dataGridViewSkills.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
