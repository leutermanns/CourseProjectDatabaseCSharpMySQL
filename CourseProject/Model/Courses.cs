using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    class Courses
    {
        private DataSet courses_table;
        private string courses_table_name = "Courses_Table",
            complete_courses_table_name = "Complete_Course_Table",
            course_names_table_name = "Course_Name_Table",
            members_table_name = "Members_Table",
            skills_table_name = "Skills_Table",
            nonmembers_table_name = "Non_Members_Table",
            nonskills_table_name = "Non_Skills_Table";

        public List<int> addUsers = new List<int>();
        public List<int> addSkills = new List<int>();
        public List<int> removeUsers = new List<int>();
        public List<int> removeSkills = new List<int>();

        public Courses(int user_id)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = $@"
            SELECT courses.id AS Course_ID, name AS Course_Name, summary AS Course_Summary FROM courses
            INNER JOIN link_users_courses ON courses.id = link_users_courses.course_id
            INNER JOIN users ON link_users_courses.user_id = users.id
            WHERE users.id = {user_id} GROUP BY courses.name";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, courses_table_name);
            conn.Close();
            courses_table = ds;
        }

        public int getCourseID(string courseName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT courses.id FROM courses WHERE courses.name = '{courseName}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == false)
            {
                conn.Close();
                return -1;
            }
            dataReader.Read();// [id]
            int courseID = dataReader.GetInt32(0);
            conn.Close();
            return courseID;
        }

        public DataSet getCoursesTable()
        {
            return this.courses_table;
        }
        public string getCoursesTableName()
        {
            return this.courses_table_name;
        }

        public DataSet getCompleteCoursesTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT name, summary FROM courses";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, complete_courses_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getCourseNamesTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT name AS Course_Name FROM courses";
            conn = ConnectionSingleton.Instance.getSharedConnection();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, course_names_table_name);
            conn.Close();
            return ds;
        }
        public string getCourseNamesTableName()
        {
            return this.course_names_table_name;
        }
        public DataSet getCourseMembers(string courseName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT firstname, lastname, users.id FROM users " +
                "INNER JOIN link_users_courses ON link_users_courses.user_id = users.id " +
                "INNER JOIN courses ON courses.id = link_users_courses.course_id " +
                "WHERE courses.name = \"" + courseName + "\"; ";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, members_table_name);
            conn.Close();
            return ds;
        }

        public string getMembersTableName()
        {
            return this.members_table_name;
        }

        public DataSet getCourseSkill(string courseName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
                "INNER JOIN link_courses_skills ON link_courses_skills.skill_id = skills.id " +
                "INNER JOIN courses ON courses.id = link_courses_skills.course_id " +
                "WHERE courses.name = \"" + courseName + "\"; ";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, skills_table_name);
            conn.Close();
            return ds;
        }

        public string getSkillsTableName()
        {
            return this.skills_table_name;
        }

        public DataSet getCourseNonMembers(string courseName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = $@"SELECT users.firstname, users.lastname FROM users
                            WHERE users.id NOT IN(
                            SELECT users.id FROM users
                            INNER JOIN link_users_courses ON link_users_courses.user_id = users.id
                            INNER JOIN courses ON courses.id = link_users_courses.course_id
                            WHERE courses.name = '{courseName}')" ;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, nonmembers_table_name);
            conn.Close();
            return ds;
        }

        public DataSet getCourseNonSkills(string courseName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = "SELECT skills.name FROM skills " +
                "WHERE skills.name NOT IN (" +
                "SELECT skills.name FROM skills " +
                "INNER JOIN link_courses_skills ON link_courses_skills.skill_id = skills.id " +
                "INNER JOIN courses ON courses.id = link_courses_skills.course_id " +
                "WHERE courses.name = \"" + courseName + "\");";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, nonskills_table_name);
            conn.Close();
            return ds;
        }

        //this is a dumb work around for time constraints
        public string getCourseNameFromID(string courseID)
        {
            string name = "error";
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"SELECT courses.name FROM courses WHERE courses.id = {courseID}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader;
            try
            {
                dataReader = cmd.ExecuteReader();
            }
            catch (MySqlException)
            {
                conn.Close();
                return name;
                throw;
            }
            dataReader.Read();
            name = dataReader.GetString(0);
            conn.Close();
            return name;

        }
        public void RemoveUserFromCourse(int courseId)
        {
            foreach(int userID in removeUsers)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"DELETE FROM link_users_courses 
                            WHERE link_users_courses.user_id = {userID} AND link_users_courses.course_id = {courseId}; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                conn.Close();
            }
        }

        public void AddUserToCourse(int courseId)
        {
            foreach (int userID in addUsers)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"INSERT INTO link_users_courses (course_id, user_id, timestart, timeend)
                            VALUES({courseId}, {userID}, {DateTime.Now.Millisecond}, {DateTime.Now.Millisecond});";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                conn.Close();
            }
        }

        public void CreateCourse(string courseName, string summary)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = "INSERT INTO courses(name, summary) VALUES (\"" + courseName + "\", \"" + summary + "\");";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateCourseSummary(int courseId, string summary)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE courses
                            SET summary = '{summary}'
                            WHERE courses.id = {courseId}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void UpdateCourseName(int courseId, string newName)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"UPDATE courses
                            SET name = '{newName}'
                            WHERE courses.id = {courseId};";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void DeleteCourse(int courseId)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"DELETE FROM courses
                            WHERE courses.id = {courseId};";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }

        public void AddSkillToCourse(int courseId)
        {
            foreach (int skillID in addSkills)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"INSERT INTO link_courses_skills (course_id, skill_id, grade)
                            VALUES({courseId}, {skillID}, 65);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }

        public void RemoveSkillFromCourse(int courseId)
        {
            foreach (int skillID in removeSkills)
            {
                MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
                conn.Open();
                string sql = $@"DELETE FROM link_courses_skills 
                            WHERE link_courses_skills.skill_id = {skillID} AND link_courses_skills.course_id = {courseId}; ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                conn.Close();
            }
        }
    }
}
