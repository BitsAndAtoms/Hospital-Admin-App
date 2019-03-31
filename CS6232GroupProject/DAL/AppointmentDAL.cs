using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class creates an AppointmentDAL object to retrieve data from the 
    /// Clinic DB.
    /// </summary>
    class AppointmentDAL
    {
        /// <summary>
        /// This method inserts a new Appointment into the DB and 
        /// returns the appointmentID.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>The inserted appointmentID.</returns>
        public int CreateAppointment(Appointment appointment)
        {
            string insertStatment =
                "Insert Appointments " + 
                "(PatientID, DoctorID, Date, Reason)" +
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
                    string selectStatment =
                        "SELECT INDENT_CURRENT('Appointments') FROM Appoinments";
                    SqlCommand selectCommand = new SqlCommand(selectStatment, connection);
                    int appointmentID = Convert.ToInt32(selectCommand.ExecuteScalar());
                    return appointmentID;
                }
            }
        }
    }
}
