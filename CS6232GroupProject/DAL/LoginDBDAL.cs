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
        public bool CheckLogin(string inputPassword, string inputUserName)
        {
                string selectStatement =
                "SELECT username FROM[Clinic].[dbo].[Login] " +
                " WHERE PWDCOMPARE(@inputPassword , password) = 1" +
                " AND username = @inputUserName ";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    
                    if (inputPassword == null)
                    {
                        selectCommand.Parameters.AddWithValue("@inputPassword", DBNull.Value);
                    }
                    else
                    {
                     selectCommand.Parameters.AddWithValue("@inputPassword", inputPassword);
                    }

                    if (inputUserName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@inputUserName", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@inputUserName", inputUserName);
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
