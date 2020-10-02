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

        private void buttonCreateEvidence_Click(object sender, EventArgs e)
        {
            ViewController.popupForm(new EvidenceReport(null, this));
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

            
        }

        private void UserEvidence_Shown(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void UserEvidence_VisibleChanged(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewEvidence_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteEvidence_Click(object sender, EventArgs e)
        {
            if(this.dataGridViewEvidence.SelectedRows[0] != null)
            {
                int evidenceId = DataController.GetEvidence().getEvidenceID(this.dataGridViewEvidence.SelectedRows[0].Cells[0].Value.ToString());
                DataController.GetEvidence().deleteEvidence(evidenceId);
                refreshTable();
            }
        }

        public void refreshTable()
        {
            DataController.genData(CurrentUser.UserId);
            this.dataGridViewEvidence.DataSource = DataController.GetEvidence().getTable();
            this.dataGridViewEvidence.DataMember = DataController.GetEvidence().getTableName();
            foreach (DataGridViewColumn column in dataGridViewEvidence.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dataGridViewEvidence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ViewController.popupForm(new EvidenceReport(this.dataGridViewEvidence.SelectedRows[0].Cells[0].Value.ToString(), null, this));

        }
    }
}
