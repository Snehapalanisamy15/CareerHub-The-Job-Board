using System.Configuration;
using System.Data.SqlClient;

namespace CareerHub__The_Job_Board.Util
{
    static class DbConnUtil
    {
        static SqlConnection connection = null;

        public static SqlConnection GetConnection()
        {
            connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
            return connection;
        }
    }
}
