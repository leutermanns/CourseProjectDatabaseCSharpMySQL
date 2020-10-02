using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class SkillCategoriesSQL
    {
        string category_table_name = "Category_Table";

        public SkillCategoriesSQL()
        {
            
        }

        public DataSet getCategoryTable()
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            string sql = $@"
            SELECT training_category, lower_bound, upper_bound, active FROM skill_categories";
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            dataAdapter.Fill(ds, category_table_name);
            conn.Close();
            return ds;
        }

        public string getCategoryTableName()
        {
            return category_table_name;
        }

        public void CreateCategory(string name, int lowerBound, int upperBound, bool active)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $@"INSERT INTO skill_categories(training_category, lower_Bound, upper_Bound, active) 
                            VALUES ('{name}', {lowerBound}, {upperBound}, {active});";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();

            conn.Close();
        }
    }
}

