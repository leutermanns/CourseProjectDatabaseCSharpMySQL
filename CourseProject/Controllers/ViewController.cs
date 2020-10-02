﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseProject
{
    class ViewController
    {
        public static Form curForm;
        public static Form popUpForm;
        public static List<Form> forms = new List<Form>();

        public static void switchForm(Form form)
        {
            if (curForm != null)
                curForm.Hide();

            if (popUpForm != null)
                popUpForm.Hide();
            
            bool addForm = true;
            curForm = form;
            foreach(Form f in forms)
            {
                if(f.GetType().Equals(form.GetType()))
                {
                    addForm = false;
                    curForm = f;
                }
            }

            if (addForm)
                forms.Add(form);

            curForm.Show();
        }
        public static void ForgetForm(Form form)
        {
            forms.Remove(form);
        }
        public static void popupForm(Form form)
        {
            popUpForm = form;
            popUpForm.Show();
        }
    }
}
