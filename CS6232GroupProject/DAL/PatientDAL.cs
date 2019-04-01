using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class creates a PatientDAL object to retrieve data from the 
    /// Clinic DB.
    /// </summary>
    class PatientDAL
    {
        /// <summary>
        /// This method returns a list of Patients from the 
        /// Clinic DB.
        /// </summary>
        /// <returns>A list of Patient objects.</returns>
        public List<Patient> GetPatients()
        {
            List<Patient> patients = new List<Patient>();

            string selectStatement =
                "SELECT PatientID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Patient " +
                "ORDER BY Fname ASC";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.PatientID = (int)reader["PatientID"];
                            patient.FName = reader["Fname"].ToString();
                            patient.LName = reader["Lname"].ToString();
                            patient.FullName = reader["Full Name"].ToString();
                            patient.DOB = (DateTime)reader["DOB"];
                            patient.SSN = reader["SSN"].ToString();
                            patient.Gender = reader["Gender"].ToString();
                            patient.Phone = reader["Phone"].ToString();
                            patient.AddressID = (int)reader["AddressID"];
                            patients.Add(patient);
                            
                        }
                    }
                }
            }
            return patients;
        }

        internal void updatePatient(Patient newPatient, Address newAddress)
        {
            string updateStatement =
               " begin transaction " +
               " begin try " +
               " UPDATE Address " +
               " SET state = @state, zip =@zip,street =@street " +
               " WHERE Address.addressID = (SELECT AddressID FROM Patient " +
               " WHERE patientID = @patientID) " +
               " UPDATE Patient" +
               " SET fname = @fname, lname =@lname, dob=@dob, ssn=@ssn, gender=@gender, phone=@phone, addressID =@addressID " +
                " WHERE patientID = @patientID " +
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
                    updateCommand.Parameters.AddWithValue("@patientID", newPatient.PatientID);
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
                    if (newPatient.FName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@fname", newPatient.FName);
                    }
                    if (newPatient.LName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@lname", newPatient.LName);
                    }
                    if (newPatient.DOB == null)
                    {
                        updateCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@dob", newPatient.DOB);
                    }
                    if (newPatient.SSN == null)
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", newPatient.SSN);
                    }
                    if (newPatient.Phone == null)
                    {
                        updateCommand.Parameters.AddWithValue("@phone", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@phone", newPatient.Phone);
                    }
                    if (newPatient.Gender == null)
                    {
                        updateCommand.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@gender", newPatient.Gender);
                    }



                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
    


        internal List<Patient> GetSearchPatientsByNameDOB(Patient newPatient)
        {
            List<Patient> patients = new List<Patient>();
            string selectStatement;
            if (!String.IsNullOrEmpty(newPatient.FName) && !String.IsNullOrEmpty(newPatient.LName)){
                selectStatement =
                "SELECT PatientID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Patient " +
                "WHERE Fname = @fname AND Lname = @lname";
            } else if (!String.IsNullOrEmpty(newPatient.LName))
                {
                    selectStatement =
                    "SELECT PatientID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                    "FROM Patient " +
                    "WHERE Lname = @lname AND DOB = @dob";
                } else 
                {
                selectStatement =
                "SELECT PatientID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Patient " +
                "WHERE DOB = @dob";
            }


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    if (newPatient.FName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@fname", newPatient.FName);
                    }
                    if (newPatient.LName == null)
                    {
                        selectCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@lname", newPatient.LName);
                    }
                    if (newPatient.DOB == null)
                    {
                        selectCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        selectCommand.Parameters.AddWithValue("@dob", newPatient.DOB.Value.Date);
                    }

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Patient patient = new Patient();
                            patient.PatientID = (int)reader["PatientID"];
                            patient.FName = reader["Fname"].ToString();
                            patient.LName = reader["Lname"].ToString();
                            patient.FullName = reader["Full Name"].ToString();
                            patient.DOB = (DateTime)reader["DOB"];
                            patient.SSN = reader["SSN"].ToString();
                            patient.Gender = reader["Gender"].ToString();
                            patient.Phone = reader["Phone"].ToString();
                            patient.AddressID = (int)reader["AddressID"];
                            patients.Add(patient);

                        }
                    }
                }
            }
            return patients;
        }

        internal void registerPatientInDB(Patient newPatient, Address newAddress)
        {
            string updateStatement = 
                " begin transaction " +
                " begin try " +
                " INSERT INTO Address(state, zip,street) Values(@state,@zip,@street) " +
                " SELECT SCOPE_IDENTITY()" +
                " INSERT INTO Patient(fname, lname, dob, ssn, gender, phone, addressID)" +
                " VALUES (@fname, @lname,@dob, @ssn, @gender, @phone, SCOPE_IDENTITY())" +
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
                    if (newPatient.FName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@fname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@fname", newPatient.FName);
                    }
                    if (newPatient.LName == null)
                    {
                        updateCommand.Parameters.AddWithValue("@lname", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@lname", newPatient.LName);
                    }
                    if (newPatient.DOB == null)
                    {
                        updateCommand.Parameters.AddWithValue("@dob", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@dob", newPatient.DOB);
                    }
                    if (newPatient.SSN == null)
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@ssn", newPatient.SSN);
                    }
                    if (newPatient.Phone == null)
                    {
                        updateCommand.Parameters.AddWithValue("@phone", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@phone", newPatient.Phone);
                    }
                    if (newPatient.Gender == null)
                    {
                        updateCommand.Parameters.AddWithValue("@gender", DBNull.Value);
                    }
                    else
                    {
                        updateCommand.Parameters.AddWithValue("@gender", newPatient.Gender);
                    }



                    updateCommand.ExecuteNonQuery();

                }

                connection.Close();
            }
        }
    }
}
