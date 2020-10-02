using CourseProject.Mockups;
using CourseProject.Models;
using MySql.Data.MySqlClient;
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
    public partial class EvidenceReport : Form
    {
        private string oldName = "";
        private UserSkills us;
        private UserEvidence ue;
        private string oldSkill = "";

        public EvidenceReport(UserSkills curUS, UserEvidence curUE)
        {
            InitializeComponent();

            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, "Skills_Table");
            conn.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
                this.comboBoxSkill.Items.Add(row[0]);

            conn = ConnectionSingleton.Instance.getSharedConnection();
            sql = "SELECT users.firstname, users.lastname FROM users";
            dataAdapter = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, "Users_Table");
            conn.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
                this.comboBoxUser.Items.Add(row[0] + " " + row[1]);

            this.labelAuthro.Text = $@"Author: {DataController.GetDiscreteUser().Firstname} {DataController.GetDiscreteUser().Lastname}";
            this.labelCreated.Text = $@"Created At: {DateTime.Now.ToString()}";
            this.labelLastEdit.Text = $@"Last Edit At: {DateTime.Now.ToString()}";

            this.buttonAddEvidence.Visible = true;
            this.buttonSave.Visible = false;

            if(curUS != null)
                us = curUS;
            if (curUE != null)
                ue = curUE;
        }

        public EvidenceReport(string evidenceName, UserSkills curUS, UserEvidence curUE)
        {
            InitializeComponent();

            oldName = evidenceName;

            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, "Skills_Table");
            conn.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
                this.comboBoxSkill.Items.Add(row[0]);

            conn = ConnectionSingleton.Instance.getSharedConnection();
            sql = "SELECT users.firstname, users.lastname FROM users";
            dataAdapter = new MySqlDataAdapter(sql, conn);
            ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, "Users_Table");
            conn.Close();

            foreach (DataRow row in ds.Tables[0].Rows)
                this.comboBoxUser.Items.Add(row[0] + " " + row[1]);

            //foreach (DataRow row in DataController.GetSkills().getSubSkillsTable(evidenceName).Tables[0].Rows)
            //    this.listBoxAssociatedSkills.Items.Add(row[0]);

            foreach (DataRow row in DataController.GetEvidence().getDetailedTable(evidenceName).Tables[0].Rows)
            {
                if(evidenceName.Equals(row["Evidence_Name"].ToString()))
                {
                    this.textBoxEvidenceName.Text = row["Evidence_Name"].ToString();
                    this.descriptionTextBox.Text = row["Evidence_Description"].ToString();
                    this.comboBoxUser.SelectedIndex = Int32.Parse(row["User_Id"].ToString());
                    this.comboBoxSkill.SelectedIndex = Int32.Parse(row["Skill_Id"].ToString());
                    //this.labelCreated.Text = $@"Created At: {(new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(row["timecreated"].ToString()))}";
                    //this.labelLastEdit.Text = $@"Last Edit At: {(new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(row["timemodified"].ToString()))}";
                    break;
                }
            }

            this.buttonAddEvidence.Visible = true;
            this.buttonSave.Visible = false;

            us = curUS;
            ue = curUE;
        }

        private void comboBoxSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBoxAssociatedSkills.Items.Clear();
            foreach (DataRow row in DataController.GetSkills().getSubSkillsTable(this.comboBoxSkill.SelectedItem.ToString()).Tables[0].Rows)
                this.listBoxAssociatedSkills.Items.Add(row[0]);
        }

        private void buttonAddEvidence_Click(object sender, EventArgs e)
        {
            string evidenceName = this.textBoxEvidenceName.Text;
            int skillId = DataController.GetSkills().getSkillID(this.comboBoxSkill.SelectedItem.ToString());

            string[] names = this.comboBoxUser.SelectedItem.ToString().Split(' ');
            int userId = DataController.GetUserTable().GetUserID(names[0], names[1]);

            string description = this.descriptionTextBox.Text;
            DataController.GetEvidence().createEvidence(evidenceName, skillId, userId, description);

            if (us != null)
                us.refreshTable();
            if (ue != null)
                ue.refreshTable();
            this.Close();
        }

        private void EvidenceReport_VisibleChanged(object sender, EventArgs e)
        {
            //comboBoxSkill.DataSource = DataController.GetSkills().getTable();
            
            labelAuthro.Text = CurrentUser.FullName;
        }
    }
}
