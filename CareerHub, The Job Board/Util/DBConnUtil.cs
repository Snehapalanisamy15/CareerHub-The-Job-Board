using System.Configuration;
using System.Data.SqlClient;

namespace CareerHub__The_Job_Board.Util
{
    static class DBConnUtil
    {
        static SqlConnection connection = null;
        public static SqlConnection GetConnection(string connectionString)
        {
            connection.ConnectionString = connectionString;
            return connection;
        }
    }
}
