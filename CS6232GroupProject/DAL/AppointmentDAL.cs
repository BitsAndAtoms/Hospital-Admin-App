using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class creates an AppointmentDAL object to retrieve data from the 
    /// Clinic DB.
    /// </summary>
    class AppointmentDAL
    {

        /// <summary>
        /// This method checks if the Doctor is available during the current time.
        /// It returns true if they do, false if they don't.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>A bool.</returns>
        public bool CheckAvailability(Appointment appointment)
        {
            int count = 0;
            string selectStatment =
                "SELECT COUNT(DoctorID) as 'Number' " +
                "FROM HasAppointment " + 
                "WHERE DoctorID = @DoctorID " +
                    "AND appointmentDateTime = @Date";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {
                    
                    selectCommand.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    selectCommand.Parameters.AddWithValue("@Date", appointment.Date);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            count += number;

                        }
                    }
                    if (count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }


            
        }
        /// <summary>
        /// This method inserts a new Appointment into the DB and 
        /// returns the appointmentID.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>The inserted appointmentID.</returns>
        public int CreateAppointment(Appointment appointment)
        {
            string insertStatment =
                "Insert HasAppointment " +
                "(PatientID, DoctorID, appointmentDateTime, Reasons)" +
                "VALUES (@PatientID, @DoctorID, @Date, @Reason)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatment, connection))
                {
                    insertCommand.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                    insertCommand.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    insertCommand.Parameters.AddWithValue("@Date", appointment.Date);
                    insertCommand.Parameters.AddWithValue("@Reason", appointment.Reason);
                    insertCommand.ExecuteNonQuery();

                    // This is the issue!
                    //string selectStatment =
                    //"SELECT INDENT_CURRENT('HasAppointment') FROM HasAppoinment";
                    //SqlCommand selectCommand = new SqlCommand(selectStatment, connection);
                    //int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    int appointmentID = 0;
                    return appointmentID;
                }
            }
        }
    }
}
