using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Model
{
    class UserTable
    {
        public UserTable()
        {
            //MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            //string sql = "SELECT * FROM users";
            //MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, conn);
            

        }
        public int GetUserID(string firstname, string lastname)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT users.id FROM users WHERE firstname = '{firstname}' AND lastname = '{lastname}'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.HasRows == false)
            {
                conn.Close();
                return -1;
            }
            dataReader.Read();// [id]
            int userID = dataReader.GetInt32(0);
            conn.Close();
            return userID;
        }
        public void CreateNewUser(string username, string password, string lastname, string firstname)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"INSERT INTO users(username, password, firstname, lastname) " +
                         $"VALUES('{username}', '{password}', '{firstname}','{lastname}')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
        public (string, string, string, string) GetUserInfoFromID(int userID)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"SELECT username, password, firstname, lastname FROM users WHERE id = {userID}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string username = reader.GetString(0);
            string password = reader.GetString(1);
            string firstname = reader.GetString(2);
            string lastname = reader.GetString(3);
            conn.Close();
            return (username, password, firstname, lastname);
        }
        public void UpdateUserInfo(int userID, string username, string password, string firstname, string lastname)
        {
            MySqlConnection conn = ConnectionSingleton.Instance.getSharedConnection();
            conn.Open();
            string sql = $"UPDATE users SET username ='{username}', password = '{password}', firstname = '{firstname}', lastname ='{lastname}' WHERE id = {userID}";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
    }
}
