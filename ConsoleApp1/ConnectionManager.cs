using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApp1
{
    public class ConnectionManager
    {
        private SqlConnection connection;
        private readonly string _connectionString;

        public ConnectionManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["TutorialDbConnection"].ConnectionString;
        }
        public SqlConnection OpenSqlConnection()
        {
            connection = new SqlConnection(_connectionString); 
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public SqlConnection CloseSqlConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = _connectionString;
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
