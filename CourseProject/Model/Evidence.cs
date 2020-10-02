using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Evidence
    {
        private DataSet evidence_table;
        private string evidence_table_name = "Evidence_Table";
        private string detailed_evidence_table_name = "Detailed_Evidence_Table";
        public Evidence(int user_id)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = $@"
            SELECT evidence.name AS Evidence_Name, evidence.description AS Evidence_Description, skills.name AS Skill_Name
            FROM evidence
            INNER JOIN link_evidence_skills ON evidence.id = link_evidence_skills.evidence_id  
            INNER JOIN skills ON link_evidence_skills.skill_id = skills.id 
            INNER JOIN link_users_skills ON skills.id = link_users_skills.skill_id
            INNER JOIN users ON users.id = link_users_skills.user_id
            WHERE users.id = {user_id} GROUP BY evidence.name;";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, evidence_table_name);
            conn.Close();
            evidence_table = ds;
        }
        public DataSet getTable()
        {
            return this.evidence_table;
        }
        public string getTableName()
        {
            return this.evidence_table_name;
        }

        public DataSet getDetailedTable(string evidenceName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT users.id as User_Id, evidence.name as Evidence_Name, evidence.timecreated, " +
            "skills.id as Skill_Id, evidence.description as Evidence_Description, evidence.timemodified FROM evidence " +
            "INNER JOIN link_evidence_skills ON evidence.id = link_evidence_skills.evidence_id " +
            "INNER JOIN skills ON link_evidence_skills.skill_id = skills.id " +
            "INNER JOIN link_users_skills ON skills.id = link_users_skills.skill_id " +
            "INNER JOIN users ON users.id = link_users_skills.user_id " +
            "WHERE evidence.name = \"" + evidenceName + "\"";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, detailed_evidence_table_name);
            conn.Close();
            return ds;
        }

        public int getEvidenceID(string evidenceID)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT evidence.id FROM evidence WHERE evidence.name = '{evidenceID}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == false)
            {
                conn.Close();
                return -1;
            }
            dataReader.Read();
            int groupID = dataReader.GetInt32(0);
            conn.Close();
            return groupID;
        }

        public void createEvidence(string evidenceName, int skillId, int userId, string description)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"INSERT INTO evidence (userid, name, description)
                            VALUES({userId}, '{evidenceName}', '{description}');";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            int evidenceId = getEvidenceID(evidenceName);

            conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            sql = $@"INSERT INTO link_evidence_skills (evidence_id, skill_id, grade)
                            VALUES({evidenceId}, {skillId}, 65);";
            cmd = new MySqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            conn.Close();

            // Only creates link if no link between user and skill already exists
            conn = ConnectionSingleton.Instance.getSharedConnection();
            DataSet ds = new DataSet();
            conn.Open();
            sql = $@"SELECT * FROM link_users_skills
                     WHERE user_id = {userId} AND skill_id = {skillId}";
            cmd = new MySqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            conn.Close();

            if (ds.Tables.Count == 0)
            {
                conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                sql = $@"INSERT INTO link_users_skills (user_id, skill_id, grade)
                            VALUES({userId}, {skillId}, 65);";
                cmd = new MySqlCommand(sql, conn);
                dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        public void saveEvidence(int evidenceId, string evidenceName, int skillId, int userId, string description)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"SELECT skillid FROM evidence
                            INNER JOIN link_users_skill ON link_users_skill.user_id = evidence.userid
                            WHERE link_evidence_skill.evidence_id = {evidenceId} AND evidence.userid = {userId};";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();

            conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            sql = $@"UPDATE evidence
                            SET name = '{evidenceName}', userid = {userId}, description = '{description}'
                            WHERE evidence.id = {evidenceId};
                            UPDATE link_evidence_skill
                            SET skillid = {skillId};
                            WHERE link_evidence_skill.evidence_id = {evidenceId};";
            cmd = new MySqlCommand(sql, conn);
            dataReader = cmd.ExecuteReader();
            conn.Close();
        }

        public void deleteEvidence(int evidenceId)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"DELETE FROM evidence
                            WHERE evidence.id = {evidenceId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();
        }
    }
}
