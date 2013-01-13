using System.Data.SqlClient;
using System.Configuration;

namespace MAS.DAL
{
    public static class SqlHelper
    {
        public static SqlConnection GetConnection()
        {
            string conString = ConfigurationManager.ConnectionStrings["MASConnectionString"].ConnectionString;
            return new SqlConnection(conString);
        }
    }
}
