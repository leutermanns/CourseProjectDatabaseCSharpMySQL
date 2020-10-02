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
    public partial class GroupSkillReport : Form
    {
        public GroupSkillReport(bool canLeaveGroup)
        {
            InitializeComponent();
            button1.Visible = canLeaveGroup;

            if(this.skillsRadioButton.Checked)
                this.skillsListPanel.BringToFront();
            else
                this.peoplePanel.BringToFront();
        }

        private void returnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new UserDetails());
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void GroupSkillReport_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void skillsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.skillsListPanel.BringToFront();
        }

        private void peopleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.peoplePanel.BringToFront();
        }

        private void GroupSkillReport_Load(object sender, EventArgs e)
        {

        }
    }
}
