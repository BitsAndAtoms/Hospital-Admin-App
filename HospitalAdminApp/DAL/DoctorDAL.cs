using HospitalAdminApp.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HospitalAdminApp.DAL
{
    /// <summary>
    /// This class creates a DoctorDAL object to retrieve data from the 
    /// Clinic DB.
    /// </summary>
    class DoctorDAL
    {
        /// <summary>
        /// This method returns a list of Doctor objects from the DB.
        /// </summary>
        /// <returns>A list of Doctor objects.</returns>
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            string selectStatement =
                "SELECT DoctorID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Doctor " +
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
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = (int)reader["DoctorID"];
                            doctor.FName = reader["Fname"].ToString();
                            doctor.LName = reader["Lname"].ToString();
                            doctor.FullName = reader["Full Name"].ToString();
                            doctor.DOB = (DateTime)reader["DOB"];
                            doctor.SSN = reader["SSN"].ToString();
                            doctor.Gender = reader["Gender"].ToString();
                            doctor.Phone = reader["Phone"].ToString();
                            doctor.AddressID = (int)reader["AddressID"];
                            doctors.Add(doctor);
                        }
                    }
                }
            }
            return doctors;
        }
    }
}
