using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
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
        /// This method checks if the Doctor is available during the current time.
        /// It returns true if they do, false if they don't.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>A bool.</returns>
        public bool CheckAvailability(Appointment appointment)
        {
            int count = 0;
            string selectStatment =
                "SELECT SUM(Number) as 'Number' " +
                "FROM (" +
                "SELECT COUNT(DoctorID) as 'Number'  " +
                "FROM HasAppointment " + 
                "WHERE DoctorID = @DoctorID " +
                " AND appointmentDateTime >= DATEADD(minute, -30,@Date) " +
                " AND appointmentDateTime <= DATEADD(minute, 30,@Date) " +
                " UNION ALL " +
                "SELECT COUNT(PatientID) as 'Number'  " +
                "FROM HasAppointment " +
                "WHERE PatientID = @PatientID " +
                "AND appointmentDateTime >= DATEADD(minute, -30,@Date) " +
                "AND appointmentDateTime <= DATEADD(minute, 30,@Date) ) s";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", appointment.PatientID);
                    selectCommand.Parameters.AddWithValue("@DoctorID", appointment.DoctorID);
                    selectCommand.Parameters.AddWithValue("@Date", appointment.AppointmentDateTime);

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
                    insertCommand.Parameters.AddWithValue("@Date", appointment.AppointmentDateTime);
                    insertCommand.Parameters.AddWithValue("@Reason", appointment.Reasons);
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

        /// <summary>
        /// Return list of Appointments
        /// </summary>
        /// <returns></returns>
        public List<Appointment> GetAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            string selectStatement =
                "SELECT AppointmentID, DoctorID, PatientID,  AppointmentDateTime, Reasons " + 
                "FROM HasAppointment";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = (int)reader["AppointmentID"];
                            appointment.DoctorID = (int)reader["DoctorID"];
                            appointment.PatientID = (int)reader["PatientID"];
                            appointment.AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                            appointment.Reasons = reader["Reasons"].ToString();
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// Get Appointment with associated Patient
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns></returns>
        public List<Appointment> GetAppointmentsForPatient(int patientID)
        {

            List<Appointment> appointments = new List<Appointment>();

            string selectStatement =
                "SELECT AppointmentID, DoctorID, PatientID,  AppointmentDateTime, Reasons " +
                "FROM HasAppointment " +
                "WHERE PatientID = @PatientID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@PatientID", patientID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.AppointmentID = (int)reader["AppointmentID"];
                            appointment.DoctorID = (int)reader["DoctorID"];
                            appointment.PatientID = (int)reader["PatientID"];
                            appointment.AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                            appointment.Reasons = reader["Reasons"].ToString();
                            appointments.Add(appointment);
                        }
                    }
                }
            }
            return appointments;
        }

        /// <summary>
        /// This method gets an Appointment by appointmentID and returns it.
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns>An Appointment object. </returns>
        public Appointment GetAppointmentByID(int appointmentID)
        {

            Appointment appointment = new Appointment();

            string selectStatement =
                "SELECT AppointmentID, DoctorID, PatientID,  AppointmentDateTime, Reasons " +
                "FROM HasAppointment " +
                "WHERE AppointmentID = @AppointmentID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointment.AppointmentID = (int)reader["AppointmentID"];
                            appointment.DoctorID = (int)reader["DoctorID"];
                            appointment.PatientID = (int)reader["PatientID"];
                            appointment.AppointmentDateTime = (DateTime)reader["AppointmentDateTime"];
                            appointment.Reasons = reader["Reasons"].ToString();
                        }
                    }
                }
            }
            return appointment;
        }

        /// <summary>
        /// This method returns true or false if the patientID has 
        /// an appointment or not.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>True or false.</returns>
        public bool CheckIfAppointmentExists(int patientID)
        {
            int count = 0;
            string selectStatement =
                "SELECT COUNT(appointmentID) as 'Number'" +
                "FROM HasAppointment " +
                "WHERE patientID = @patientID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@patientID", patientID);

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
        /// This method returns true or false if the patientID has 
        /// an appointment in the furutre or not.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>True or false.</returns>
        public bool CheckIfFutureAppointmentExists(int patientID)
        {
            int count = 0;
            string selectStatement =
                "SELECT COUNT(appointmentID) as 'Number'" +
                "FROM HasAppointment " +
                "WHERE patientID = @patientID AND appointmentDateTime < @dateTime";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {

                    selectCommand.Parameters.AddWithValue("@patientID", patientID);
                    selectCommand.Parameters.AddWithValue("@dateTime", DateTime.Now);

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
        /// This method Updates an Appointment in the DB.
        /// </summary>
        /// <param name="newAppointment"></param>
        /// <param name="oldAppointment"></param>
        /// <returns>True or false.</returns>
        public bool UpdateAppointment(Appointment newAppointment, Appointment oldAppointment)
        {
            string updateStatement =
                "UPDATE HasAppointment SET " + 
                    "DoctorID = @NewDoctorID, " +
                    "appointmentDateTime = @NewDate, " +
                    "reasons = @NewReasons " +
                "WHERE appointmentID = @OldAppointmentID " + 
                    "AND patientID = @OldPatientID";


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updatedCommand = new SqlCommand(updateStatement, connection))
                {
                    if (newAppointment.Reasons == "")
                    {
                        updatedCommand.Parameters.AddWithValue("@NewReasons", oldAppointment.Reasons);
                    }
                    else
                    {
                        updatedCommand.Parameters.AddWithValue("@NewReasons", newAppointment.Reasons);
                    }
                    updatedCommand.Parameters.AddWithValue("@NewDate", newAppointment.AppointmentDateTime);
                    updatedCommand.Parameters.AddWithValue("@NewDoctorID", newAppointment.DoctorID);

                    updatedCommand.Parameters.AddWithValue("@OldAppointmentID", oldAppointment.AppointmentID);
                    updatedCommand.Parameters.AddWithValue("@OldPatientID", oldAppointment.PatientID);
                    updatedCommand.Parameters.AddWithValue("@OldDoctorID", oldAppointment.DoctorID);

                    int count = updatedCommand.ExecuteNonQuery();
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
        /// This method takes an appoinment ID and cancels the appointment.
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns>True or false</returns>
        public bool CancelAppointment(int appointmentID)
        {
            string deleteStatement =
                "DELETE FROM PatientVisit WHERE appointmentID = @appointmentID AND visitDateTime > @currentDate " +
                "DELETE FROM HasAppointment WHERE appointmentID = @appointmentID AND appointmentDateTime > @currentDate";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection))
                {

                    deleteCommand.Parameters.AddWithValue("@appointmentID", appointmentID);
                    deleteCommand.Parameters.AddWithValue("@currentDate", DateTime.Now);
                    

                    int count = deleteCommand.ExecuteNonQuery();
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
    }
}
