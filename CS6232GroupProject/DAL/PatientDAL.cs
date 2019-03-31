﻿using CS6232GroupProject.Model;
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
                "FROM Patient";

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
    }
}
