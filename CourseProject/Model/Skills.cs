using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Skills
    {
        private DataSet skills_table;
        private string skills_table_name = "Skills_Table",
            complete_skills_table_name = "Complete_Skills_Table", 
            skill_names_table_name = "Skills_Name_Table",
            subskills_table_name = "Subskills_Table";

        public List<int> addSkills = new List<int>();
        public List<int> removeSkills = new List<int>();

        public Skills(int user_id) 
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.id as Skill_ID, skills.name AS Name, skills.description AS Description FROM skills " +
                         "INNER JOIN link_users_skills ON skills.id = link_users_skills.skill_id " +
                         "INNER JOIN users ON link_users_skills.user_id = users.id " +
                         $"WHERE users.id = {user_id} GROUP BY skills.name";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, skills_table_name);
            conn.Close();
            skills_table = ds;
        }
        public DataSet getTable()
        {
            return this.skills_table;
        }
        public string getTableName()
        {
            return this.skills_table_name;
        }

        public DataSet getSkillNamesTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name AS Name FROM skills";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, skill_names_table_name);
            conn.Close();
            return ds;
        }
        public string getSkillNamesTableName()
        {
            return this.skill_names_table_name;
        }

        public DataSet getSubSkillsTable(string parentSkill)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
                "WHERE skills.id IN (" +
                "SELECT link_skills_subskill.subskill_id FROM link_skills_subskill " +
                "INNER JOIN skills ON skills.id = link_skills_subskill.skill_id " +
                "WHERE skills.name = \"" + parentSkill + "\")";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, subskills_table_name);
            conn.Close();
            return ds;
        }

        public string getSubSkillsTableName()
        {
            return subskills_table_name;
        }

        public DataSet getNonSubSkillsTable(string parentSkill)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
                "WHERE skills.id NOT IN (" +
                "SELECT link_skills_subskill.subskill_id FROM link_skills_subskill " +
                "INNER JOIN skills ON skills.id = link_skills_subskill.skill_id " +
                "WHERE skills.name = \"" + parentSkill + "\")";

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, subskills_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getCompleteTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT name, description FROM skills";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, complete_skills_table_name);
            conn.Close();
            return ds;
        }

        public int getSkillID(string skillName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT skills.id FROM skills WHERE skills.name = '{skillName}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == false)
            {
                conn.Close();
                return -1;
            }
            dataReader.Read();
            int skillID = dataReader.GetInt32(0);
            conn.Close();
            return skillID;
        }

        public void RemoveSubskill(int parentSkillID)
        {
            foreach (int subskillID in addSkills)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"DELETE FROM link_skills_subskill 
                            WHERE link_skills_subskill.subskill_id = {subskillID} AND link_skills_subskill.skill_id = {parentSkillID}; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        public void AddSubskill(int parentSkillID)
        {
            foreach (int subskillID in addSkills)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"INSERT INTO link_skills_subskill (skill_id, subskill_id)
                            VALUES({parentSkillID}, {subskillID});";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        public void CreateSkill(string name, string description)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"INSERT INTO skills (name, description)
                            VALUES('{name}', '{description}');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateSkillDescription(int skillId, string description)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE skills
                            SET description = ""{description}""
                            WHERE skills.id = {skillId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateSkillName(int skillId, string newName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE skills
                            SET name = ""{newName}""
                            WHERE skills.id = {skillId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void DeleteSkill(int skillId)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"DELETE FROM skills
                            WHERE skills.id = {skillId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void AddSkillToUser(int skillId, int userId)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"INSERT INTO link_users_skills(user_id, skill_id)
                            VALUES({userId}, {skillId});";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }
    }
}
