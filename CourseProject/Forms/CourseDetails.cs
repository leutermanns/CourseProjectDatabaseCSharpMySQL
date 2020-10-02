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
        public CourseDetails()
        {
            InitializeComponent();
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
            Application.Exit();

        }
    }
}
