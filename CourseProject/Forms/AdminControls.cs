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
        public AdminControls()
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            ViewController.popupForm(new GroupSkillReport(false));
        }
    }
}
