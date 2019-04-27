using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{

    /// <summary>
    /// This class creates a LoginDBDAL object to get data 
    /// from the DB.
    /// </summary>
    class LoginDBDAL
    {
        /// <summary>
        /// This method verifies login
        /// </summary>
        /// <returns>true/false</returns>
        public bool CheckLogin(string inputPassword, string inputUserName)
        {
                string selectStatement =
                "SELECT username FROM [CS6232-g4].[dbo].[Login] " +
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

        /// <summary>
        /// This method returns the username role, and id of the person logging in.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>A list of usernames and roles.</returns>
        internal List<string> FindUserNameAndRole(string userName)
        {

            string selectStatement =
                "if exists(Select 'Nurse' as Role, fname, lname, nurseID FROM Nurse WHERE nurseUserName = @userName)" +
                " Select 'Nurse' as Role, fname, lname, nurseID from Nurse WHERE nurseUserName = @userName" +
                " else if exists(Select 'Admin' as Role, fname, lname, adminID FROM Administrator WHERE adminUserName = @userName)" +
                " Select 'Admin' as Role, fname, lname, adminID from Administrator WHERE adminUserName =  @userName" +
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
                            if (reader["Role"].ToString() == "Nurse")
                            {
                                nameAndRole.Add(reader["Role"].ToString());
                                nameAndRole.Add(reader["fname"].ToString());
                                nameAndRole.Add(reader["lname"].ToString());
                                nameAndRole.Add(reader["nurseID"].ToString());
                            }
                            else if (reader["Role"].ToString() == "Admin")
                            {
                                nameAndRole.Add(reader["Role"].ToString());
                                nameAndRole.Add(reader["fname"].ToString());
                                nameAndRole.Add(reader["lname"].ToString());
                                nameAndRole.Add(reader["adminID"].ToString());
                            }
                        }
                    }
                }
            }
            return nameAndRole;
        }
        
        /// <summary>
        /// This method checks if a Username is taken or not.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>True or false</returns>
        public bool CheckNurseUsername(string username, int nurseID)
        {
            int count = 0;
            string selectStatment =
                "SELECT COUNT(username) as 'Number' " +
                "FROM Login " +
                "INNER JOIN Nurse " +
                "ON Login.username = Nurse.nurseUsername " +
                "WHERE username = @username AND NOT nurseID = @nurseID";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);
                    selectCommand.Parameters.AddWithValue("@nurseID", nurseID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            count = number;

                        }
                    }
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// This method checks if a Username is taken or not.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool CheckNurseUsername(string username)
        {
            int count = 0;
            string selectStatment =
                "SELECT COUNT(username) as 'Number' " +
                "FROM Login " +
                "INNER JOIN Nurse " +
                "ON Login.username = Nurse.nurseUsername " +
                "WHERE username = @username and activeStatus = 0";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {
                    selectCommand.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            count = number;

                        }
                    }
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

    }
}
