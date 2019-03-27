using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                        selectCommand.Parameters.AddWithValue("@inputUserName",  inputUserName);
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

        internal List<string> FindUserNameAndRole(string userName)
        {
            string selectStatement =
                "if exists(Select 'Nurse' as Role, fname, lname FROM Nurse WHERE nurseUserName = @userName)" +
                " Select 'Nurse' as Role, fname, lname from Nurse WHERE nurseUserName = @userName" +
                " else if exists(Select 'Admin' as Role, fname, lname FROM Administrator WHERE adminUserName = @userName)" +
                " Select 'Admin' as Role, fname, lname from Administrator WHERE adminUserName =  @userName" +
                " else if exists(Select 'Doctor' as Role, fname, lname FROM Doctor WHERE doctorUserName = @userName)" +
                " Select 'Doctor' as Role, fname, lname from Doctor WHERE doctorUserName = @userName" +
                " else " +
                "PRINT 'no records returned from tables'  ";

            List<string> nameAndRole = new List<string>();

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    if (userName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@userName", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@userName", userName);
                    }

                    
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nameAndRole.Add(reader["Role"].ToString());
                            nameAndRole.Add(reader["fname"].ToString());
                            nameAndRole.Add(reader["lname"].ToString());
                        }
                    }
                }
            }
            return nameAndRole;
        }
    }
}
