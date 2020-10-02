using CourseProject.Model;
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
    public partial class CreateNewUser : Form
    {
        public CreateNewUser()
        {
            InitializeComponent();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ViewController.switchForm(new Login());
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                return;
            UserTable temp = new UserTable();
            temp.CreateNewUser(textBoxUsername.Text, textBoxPassword.Text, textBoxLastName.Text, textBoxFirstName.Text);
            DataController.genData(1);
            ViewController.switchForm(new Login());
            
        }

        private void CreateNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
