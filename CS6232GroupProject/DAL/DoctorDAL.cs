using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    class DoctorDAL
    {
        public List<Doctor> GetDoctors()
        {
            List<Doctor> doctors = new List<Doctor>();

            string selectStatement =
                "SELECT DoctorID, Fname, Lname, CONCAT(Fname, ' ', Lname) as 'Full Name', DOB, SSN, Gender, Phone, AddressID " +
                "FROM Doctor";

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
