using System.Data.SqlClient;

namespace HospitalAdminApp.DAL
{
    /// <summary>
    /// method for creating a connection between C# and DB
    /// </summary>
    class DBConnection
    {
        /// <summary>
        /// new sql connection is generated
        /// </summary>
        /// <returns>connection is connection to DB</returns>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=DESKTOP-KR44R24\\MSSQLSERVER01;Initial Catalog=CS6232-g4;" +
                "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False";
               


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
