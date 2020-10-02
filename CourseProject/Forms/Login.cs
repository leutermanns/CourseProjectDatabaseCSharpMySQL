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

namespace CourseProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                DiscreteUser user = new DiscreteUser(textBoxUsername.Text, textBoxPassword.Text);
                if (!user.IsValid)
                    throw new ArgumentException();
                else
                    CurrentUser.UserId = user.UserId;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Login Failed!");
                return;
            }
            ViewController.switchForm(new UserDetails());
        }

        private void linkLabelNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewController.switchForm(new CreateNewUser());
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }
    }
}
