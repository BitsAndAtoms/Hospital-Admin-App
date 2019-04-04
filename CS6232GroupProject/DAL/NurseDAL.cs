using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    class NurseDAL
    {

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
    }
}
