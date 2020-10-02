using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CourseProject.Models
{
    public class DiscreteUser
    {
        public DiscreteUser(string username, string password)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT id, firstname, lastname FROM users WHERE users.username = '{username}' AND users.password = '{password}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == false)
            {
                conn.Close();
                this.UserId = -1;
                this.Firstname = "Failed";
                this.Lastname = "Failed";
                this.IsValid = false;
                return;
                
            }
            dataReader.Read();// [id, firstname, lastname]
            this.UserId = dataReader.GetInt32(0);
            this.Firstname = dataReader.GetString(1);
            this.Lastname = dataReader.GetString(2);
            this.IsValid = true;
            conn.Close();
        }
        private bool IsValidUser(DataSet ds)
        {
            return false;
        }
        public string Firstname { get; }
        public string Lastname { get; }
        public bool IsValid { get; }
        public int UserId { get; }
    }
}
