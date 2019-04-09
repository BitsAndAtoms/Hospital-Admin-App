using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID, activeStatus " +
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
                            nurse.AddressID = (int)reader["AddressID"];

                            //This section either needs to be re-written after the DB sets the ActiveStatus for 
                            // Nurses to not null with default false, or we need to make sure it is all correct.
                            if (reader["activeSatus"] == null)
                            {
                                nurse.Active = false;
                            }
                            else if ((bool)reader["activeSatus"] == true)
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

        /// <summary>
        /// This method adds a new Nurse to the DB if possible, or rollsback 
        /// if not.
        /// </summary>
        /// <param name="newNurse"></param>
        /// <param name="newAddress"></param>
        internal void AddNurse(Nurse newNurse, Address newAddress)//We may want to make it a bool that returns true or false
                                                                //So that we can have a MessageBox pop up and notify the user 
                                                                //of any issues in the view based on what is returned.
        {
            string updateStatement =
                " begin transaction " +
                " begin try " +
                " INSERT INTO Address(state, zip,street) Values(@state,@zip,@street) " +
                " SELECT SCOPE_IDENTITY()" +
                " INSERT INTO Nurse(fname, lname, dob, ssn, gender, phone, addressID, activeStatus)" +
                " VALUES (@fname, @lname,@dob, @ssn, @gender, @phone, @activeStatus, SCOPE_IDENTITY())" +
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
                    updateCommand.Parameters.AddWithValue("@activeStatus", newNurse.Active);



                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        //Below from rchesser
        internal List<Nurse> GetSearchNurseByNameDOB(Nurse newNurse)
        {
            List<Nurse> nurses = new List<Nurse>();
            string selectStatement;
            if (!String.IsNullOrEmpty(newNurse.FName) && !String.IsNullOrEmpty(newNurse.LName))
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Nurse " +
                "WHERE Fname = @fname AND Lname = @lname";
            }
            else if (!String.IsNullOrEmpty(newNurse.LName))
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Nurse " +
                "WHERE Lname = @lname AND DOB = @dob";
            }
            else
            {
                selectStatement =
                "SELECT NurseID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
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
                        selectCommand.Parameters.AddWithValue("@fname", newNurse.FName);
                    }
                    if (newNurse.LName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@lname", newNurse.LName);
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
                            nurse.AddressID = (int)reader["AddressID"];
                            //nurse.Active = (Boolean)reader["Active"];
                            nurses.Add(nurse);

                        }
                    }
                }
            }
            return nurses;
        }

        internal void updateNurse(Nurse newNurse, Address newAddress)
        {
            string updateStatement =
               " begin transaction " +
               " begin try " +
               " UPDATE Address " +
               " SET state = @state, zip =@zip,street =@street " +
               " WHERE Address.addressID = (SELECT AddressID FROM Nurse " +
               " WHERE nurseID = @nurseID) " +
               " UPDATE Nurse" +
               " SET fname = @fname, lname =@lname, dob=@dob, ssn=@ssn, gender=@gender, phone=@phone, addressID =@addressID " +//Activestatus missing
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



                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

        internal void registerNurseInDB(Nurse newNurse, Address newAddress)
        {
            string updateStatement =
                " begin transaction " +
                " begin try " +
                " INSERT INTO Address(state, zip,street) Values(@state,@zip,@street) " +
                " SELECT SCOPE_IDENTITY()" +
                " INSERT INTO Nurse(fname, lname, dob, ssn, gender, phone, addressID)" +
                " VALUES (@fname, @lname,@dob, @ssn, @gender, @phone, SCOPE_IDENTITY())" +//active status missing
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



                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }

    }
}
