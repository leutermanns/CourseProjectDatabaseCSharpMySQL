using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject
{
    public sealed class ConnectionSingleton
    {
        private static readonly Lazy<ConnectionSingleton> _instance = new Lazy<ConnectionSingleton>(() => new ConnectionSingleton());
        private MySqlConnection myConnection;
        private ConnectionSingleton() {
            string connectionString = buildConnectionString();
            this.myConnection = new MySqlConnection(connectionString);
        }
        private string buildConnectionString()
        {
            string databaseField = "school database schema";
            string serverField = "localhost";
            string portField = "3306";
            string usernameField = "root";
            string passwordField = "purpleapple662";
            string builtConnectionString = $"server={serverField};user={usernameField};database={databaseField};port={portField}; password={passwordField}";
            return builtConnectionString;
        }
        public MySqlConnection getSharedConnection()
        {
            return this.myConnection;
        }
        public static ConnectionSingleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
    }
}
