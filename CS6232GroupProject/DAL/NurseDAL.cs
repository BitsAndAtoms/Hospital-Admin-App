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

    }
}
