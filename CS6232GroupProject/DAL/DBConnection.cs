using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232GroupProject.DAL
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
            string connectionString =
                "Data Source=localhost;Initial Catalog=Clinic;" +
                "Integrated Security=True";


            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
