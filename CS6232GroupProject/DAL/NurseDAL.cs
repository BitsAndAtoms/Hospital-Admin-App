using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class allows retrival of Nurse data from the DB.
    /// </summary>
    class NurseDAL
    {

        /// <summary>
        /// This method gets a list of Nurse objects from the database.
        /// </summary>
        /// <returns>A list of Nurse objects.</returns>
        public List<Nurse> GetNurses()
        {
            List<Nurse> nurses = new List<Nurse>();

            string selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, Username, AddressID, activeStatus " +
                "FROM Nurse";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse();
                            nurse.NurseID = (int)reader["NurseID"];
                            nurse.FName = reader["Fname"].ToString();
                            nurse.LName = reader["Lname"].ToString();
                            nurse.FullName = reader["Full Name"].ToString();
                            nurse.DOB = (DateTime)reader["DOB"];
                            nurse.SSN = reader["SSN"].ToString();
                            nurse.Gender = reader["Gender"].ToString();
                            nurse.Phone = reader["Phone"].ToString();
                            nurse.Username = reader["Username"].ToString();
                            nurse.AddressID = (int)reader["AddressID"];

                            //This section either needs to be re-written after the DB sets the ActiveStatus for 
                            // Nurses to not null with default false, or we need to make sure it is all correct.
                            if (reader["activeStatus"] == null)
                            {
                                nurse.Active = false;
                            }
                            else if ((bool)reader["activeStatus"] == true)
                            {
                                nurse.Active = true;
                            }
                            else
                            {
                                nurse.Active = false;
                            }

                            nurses.Add(nurse);
                        }
                    }
                }
            }
            return nurses;
        }

        

        //Below from rchesser
        internal List<Nurse> GetSearchNurseByNameDOB(Nurse newNurse)
        {
            List<Nurse> nurses = new List<Nurse>();
            string selectStatement;
            if (!String.IsNullOrEmpty(newNurse.FName) && !String.IsNullOrEmpty(newNurse.LName))
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, nurseUsername, AddressID, activeStatus " +
                "FROM Nurse " +
                "WHERE Fname LIKE @fname AND Lname LIKE @lname";
            }
            else if (!String.IsNullOrEmpty(newNurse.LName))
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, nurseUsername, AddressID, activeStatus " +
                "FROM Nurse " +
                "WHERE Lname LIKE @lname AND DOB = @dob";
            }
            else
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, nurseUsername, AddressID, activeStatus " +
                "FROM Nurse " +
                "WHERE DOB = @dob";
            }


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (newNurse.FName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@fname", newNurse.FName + "%");
                    }
                    if (newNurse.LName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@lname", newNurse.LName + "%");
                    }
                    if (newNurse.DOB == null)
                    {
                        selectCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@dob", newNurse.DOB.Value.Date);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Nurse nurse = new Nurse();
                            nurse.NurseID = (int)reader["NurseID"];
                            nurse.FName = reader["Fname"].ToString();
                            nurse.LName = reader["Lname"].ToString();
                            nurse.FullName = reader["Full Name"].ToString();
                            nurse.DOB = (DateTime)reader["DOB"];
                            nurse.SSN = reader["SSN"].ToString();
                            nurse.Gender = reader["Gender"].ToString();
                            nurse.Phone = reader["Phone"].ToString();
                            nurse.Username = reader["nurseUsername"].ToString();
                            nurse.AddressID = (int)reader["AddressID"];
                            if (reader["activeStatus"] == null)
                            {
                                nurse.Active = false;
                            }
                            else if ((bool)reader["activeStatus"] == true)
                            {
                                nurse.Active = true;
                            }
                            else
                            {
                                nurse.Active = false;
                            }
                            nurses.Add(nurse);

                        }
                    }
                }
            }
            return nurses;
        }

        internal void updateNurse(Nurse newNurse, Address newAddress, Login newLogin)//Not Done yet
        {
            string updateStatement =
               " begin transaction " +
               " begin try " +
               " UPDATE Address " +
               " SET state = @state, zip =@zip,street =@street " +
               " WHERE Address.addressID = (SELECT AddressID FROM Nurse " +
               " WHERE nurseID = @nurseID) " +
               " UPDATE Nurse" +
               " SET fname = @fname, lname =@lname, dob=@dob, ssn=@ssn, gender=@gender, phone=@phone, addressID =@addressID, activeStatus = @activeStatus " +
                " WHERE nurseID = @nurseID" +
               " commit transaction" +
               " end try" +
               " begin catch" +
               "  raiserror('Update failed',16,1)" +
               "  rollback transaction" +
               " end catch";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("@addressID", newAddress.AddressID);
                    updateCommand.Parameters.AddWithValue("@nurseID", newNurse.NurseID);
                    if (newAddress.State == null)
                    {
                        updateCommand.Parameters.AddWithValue("@state", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@state", newAddress.State);
                    }
                    if (newAddress.Zip.ToString() == null)
                    {
                        updateCommand.Parameters.AddWithValue("@zip", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@zip", newAddress.Zip.ToString());
                    }
                    if (newAddress.Street == null)
                    {
                        updateCommand.Parameters.AddWithValue("@street", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@street", newAddress.Street);
                    }
                    if (newNurse.FName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@fname", newNurse.FName);
                    }
                    if (newNurse.LName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@lname", newNurse.LName);
                    }
                    if (newNurse.DOB == null)
                    {
                        updateCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@dob", newNurse.DOB);
                    }
                    if (newNurse.SSN == null)
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", newNurse.SSN);
                    }
                    if (newNurse.Phone == null)
                    {
                        updateCommand.Parameters.AddWithValue("@phone", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@phone", newNurse.Phone);
                    }
                    if (newNurse.Gender == null)
                    {
                        updateCommand.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@gender", newNurse.Gender);
                    }
                    // Need to check if true/false is automatically converted into 1/0 in the DB.
                    if (newNurse.Active == true)
                    {
                        updateCommand.Parameters.AddWithValue("@activeStatus", 1);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@activeStatus", 0);
                    }

                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        internal void registerNurseInDB(Nurse newNurse, Address newAddress, Login newLogin)
        {
            string updateStatement =
                " begin transaction " +
                " begin try " +
                " INSERT INTO Address(state, zip,street) Values(@state,@zip,@street) " +
                " SELECT SCOPE_IDENTITY()" +
                " INSERT INTO Login(username, password) Values(@username, PWDENCRYPT(@password)) " +
                " SELECT SCOPE_IDENTITY()" +
                " INSERT INTO Nurse(fname, lname, dob, ssn, gender, phone, nurseUsername, addressID, activeStatus)" +
                " VALUES (@fname, @lname, @dob, @ssn, @gender, @phone, @nurseUsername, @activeStatus, SCOPE_IDENTITY())" +
                " commit transaction" +
                " end try" +
                " begin catch" +
                "  raiserror('Update failed',16,1)" +
                "  rollback transaction" +
                " end catch";

            
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand updateCommand = new SqlCommand(updateStatement, connection))
                {
                    if (newAddress.State == null)
                    {
                        updateCommand.Parameters.AddWithValue("@state", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@state", newAddress.State);
                    }
                    if (newAddress.Zip.ToString() == null)
                    {
                        updateCommand.Parameters.AddWithValue("@zip", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@zip", newAddress.Zip.ToString());
                    }
                    if (newAddress.Street == null)
                    {
                        updateCommand.Parameters.AddWithValue("@street", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@street", newAddress.Street);
                    }
                    
                    updateCommand.Parameters.AddWithValue("@username", newLogin.Username);
                    updateCommand.Parameters.AddWithValue("@password", newLogin.Password);

                    if (newNurse.FName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@fname", newNurse.FName);
                    }
                    if (newNurse.LName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@lname", newNurse.LName);
                    }
                    if (newNurse.DOB == null)
                    {
                        updateCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@dob", newNurse.DOB);
                    }
                    if (newNurse.SSN == null)
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", newNurse.SSN);
                    }
                    if (newNurse.Phone == null)
                    {
                        updateCommand.Parameters.AddWithValue("@phone", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@phone", newNurse.Phone);
                    }
                    if (newNurse.Gender == null)
                    {
                        updateCommand.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@gender", newNurse.Gender);
                    }

                    updateCommand.Parameters.AddWithValue("@nurseUsername", newNurse.Username);

                    if (newNurse.Active == true)
                    {
                        updateCommand.Parameters.AddWithValue("@activeStatus", true);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@activeStatus", false);
                    }

                    MessageBox.Show("Before the Execute!", "Error Here!");
                    updateCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

    }
}
