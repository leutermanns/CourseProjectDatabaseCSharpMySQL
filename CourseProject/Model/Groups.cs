using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Groups
    {
        private DataSet groups_table;
        private string groups_table_name = "Groups_Table",
            complete_groups_table_name = "Complete_Groups_Table", 
            group_names_table_name = "Group_Names_Table",
            members_table_name = "Group_Members_Table",
            skills_table_name = "Group_Skills_Table",
            nonmembers_table_name = "Group_Non_Members_Table",
            nonskills_table_name = "Group_Non_Skills_Table";

        public List<int> addUsers = new List<int>();
        public List<int> addSkills = new List<int>();
        public List<int> removeUsers = new List<int>();
        public List<int> removeSkills = new List<int>();

        public Groups(int user_id)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = $@"
            SELECT name AS Group_Name, description AS Group_Description, active AS Active FROM groups_table
            INNER JOIN link_groups_table_users ON groups_table.id = link_groups_table_users.group_id  
            INNER JOIN users ON link_groups_table_users.user_id = users.id 
            WHERE users.id = {user_id} GROUP BY groups_table.name";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, groups_table_name);
            conn.Close();
            groups_table = ds;
        }
        public DataSet getTable()
        {
            return this.groups_table;
        }
        public string getTableName()
        {
            return this.groups_table_name;
        }

        public DataSet getGroupNamesTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT groups_table.name as Group_Name FROM groups_table";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, group_names_table_name);
            conn.Close();
            return ds;
        }
        public string getGroupNamesTableName()
        {
            return this.group_names_table_name;
        }
        
        public DataSet getGroupMembers(string groupName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT firstname, lastname FROM users " +
            "INNER JOIN link_groups_table_users ON link_groups_table_users.user_id = users.id " +
            "INNER JOIN groups_table ON groups_table.id = link_groups_table_users.group_id " +
            "WHERE groups_table.name = \"" + groupName + "\"";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, members_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getGroupSkill(string groupName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
            "INNER JOIN link_groups_table_skills ON link_groups_table_skills.skill_id = skills.id " +
            "INNER JOIN groups_table ON groups_table.id = link_groups_table_skills.group_id " +
            "WHERE groups_table.name = \"" + groupName + "\"";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, skills_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getGroupNonMembers(string groupName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT firstname, lastname FROM users " +
            "INNER JOIN link_groups_table_users ON link_groups_table_users.user_id = users.id " +
            "INNER JOIN groups_table ON groups_table.id = link_groups_table_users.group_id " +
            "WHERE groups_table.name != \"" + groupName + "\";";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, nonmembers_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getGroupNonSkills(string groupName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
            "WHERE skills.name NOT IN (" +
            "SELECT skills.name FROM skills " +
            "INNER JOIN link_groups_table_skills ON link_groups_table_skills.skill_id = skills.id " +
            "INNER JOIN groups_table ON groups_table.id = link_groups_table_skills.group_id " +
            "WHERE groups_table.name = \"" + groupName + "\");";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, nonskills_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getCompleteTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT name AS Group_Name, description AS Group_Description, active AS Active FROM groups_table";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, complete_groups_table_name);
            conn.Close();
            return ds;
        }

        public int getGroupID(string grompName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT groups_table.id FROM groups_table WHERE groups_table.name = '{grompName}'";
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

        public void RemoveUserFromGroup(int groupID)
        {
            foreach(int userId in removeUsers)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"DELETE FROM link_groups_table_users 
                            WHERE link_groups_table_users.user_id = {userId} AND link_groups_table_users.group_id = {groupID}; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                conn.Close();
            }
        }

        public void AddUserToGroup(int groupId)
        {
            foreach (int userId in addUsers)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"INSERT INTO link_groups_table_users (group_id, user_id)
                            VALUES({groupId}, {userId});";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                conn.Close();
            }
        }

        public void CreateGroup(string name, string description, bool active)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"INSERT INTO groups_table (name, description, active)
                            VALUES('{name}', '{description}', {active});";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateGroupDescription(int groupId, string description)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE groups_table
                            SET summary = '{description}'
                            WHERE groups_table.id = {groupId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateGroupName(int groupId, string newName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE groups_table
                            SET name = '{newName}'
                            WHERE groups_table.id = {groupId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void DeleteGroup(int groupId)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"DELETE FROM groups_table
                            WHERE groups_table.id = {groupId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void RemoveSkillFromGroup(int groupID)
        {
            foreach (int skillID in removeSkills)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"DELETE FROM link_groups_table_skills 
                            WHERE link_groups_table_skills.skill_id = {skillID} AND link_groups_table_skills.group_id = {groupID}; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        public void AddSkillToGroup(int groupID)
        {
            foreach (int skillID in addSkills)
            { 
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"INSERT INTO link_groups_table_skills (group_id, skill_id)
                            VALUES({groupID}, {skillID});";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }
    }
}
