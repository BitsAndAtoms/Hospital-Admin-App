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
                "WHERE DoctorID = @DoctorID" +
                    "AND appointmentDateTime = @Date";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {
                    
                    selectCommand.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    selectCommand.Parameters.AddWithValue("@Date", appointment.Date);
                    MessageBox.Show("The date is: " + appointment.Date, "Date");//For testing only

                    MessageBox.Show("It got here!", "Test");//For testing only
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            count += number;

                        }
                    }
                    MessageBox.Show("The count is: " + count, "Number of Results Test");//For testing only
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
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
