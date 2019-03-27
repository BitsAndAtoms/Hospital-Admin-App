using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS6232GroupProject.DAL
{
    class LoginDBDAL
    {
        /// <summary>
        /// This method verifies login
        /// </summary>
        /// <returns>true/false</returns>
        public bool CheckLogin(string inputPassword)
        {
                string selectStatement =
                "SELECT username FROM[Clinic].[dbo].[Login] " +
                " WHERE PWDCOMPARE(@inputPassword, password_hash) = 1";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    
                    if (inputPassword == null)
                    {
                        selectCommand.Parameters.AddWithValue("@Description", DBNull.Value);
                    }
                    else
                    {
                     selectCommand.Parameters.AddWithValue("@inputPassword", inputPassword);
                    }
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

    }
}
