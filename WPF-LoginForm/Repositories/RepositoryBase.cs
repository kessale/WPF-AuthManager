using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace WPF_LoginForm.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            // Connection string for MySQL database
            var userId = Environment.GetEnvironmentVariable("DB_USER");
            var password = Environment.GetEnvironmentVariable("DB_PASSWORD");
            _connectionString = $"Server=localhost; Database=MVVMLoginDb; Uid={userId}; Pwd={password};";
            
        }
        protected MySqlConnection GetConnection()
        {
            // Initializes a new instance of the MySqlConnection class
            return new MySqlConnection(_connectionString);
        }
    }
}
