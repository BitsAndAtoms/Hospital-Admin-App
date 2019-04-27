using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    /// <summary>
    /// This class creates an AppointmentController object 
    /// and calls the AppointmentDAL methods.
    /// </summary>
    class AppointmentController
    {
        private readonly AppointmentDAL appointmentSource;

        /// <summary>
        /// This constructs the Appointment Controller object and 
        /// initialises the AppointmentDAL variable.
        /// </summary>
        public AppointmentController()
        {
            this.appointmentSource = new AppointmentDAL();
        }

        /// <summary>
        /// This method passes an Appointment object to the AppointmentDAL 
        /// which updates the DB with that information and returns the ID 
        /// of the appointment.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>The ID of the appointment created.</returns>
        public int CreateAppointment(Appointment appointment)
        {
            return this.appointmentSource.CreateAppointment(appointment);
        }

        /// <summary>
        /// This method passing the potential appointment to the DAL and 
        /// returns true or false if the Doctor and DateTime are available.
        /// </summary>
        /// <param name="appointment"></param>
        /// <returns>True or false.</returns>
        public bool CheckAvailability(Appointment appointment)
        {
            return this.appointmentSource.CheckAvailability(appointment);
        }

        /// <summary>
        /// This method returns a list of appointments.
        /// </summary>
        /// <returns>A list of Appointment objects.</returns>
        public List<Appointment> GetAppointments()
        {
            return this.appointmentSource.GetAppointments();
        }

        /// <summary>
        /// This method returns a list of Appointment objects based on 
        /// a patientID.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>List of Appointmnet objects.</returns>
        public List<Appointment> GetAppointmentsForPatient(int patientID)
        {
            return this.appointmentSource.GetAppointmentsForPatient(patientID);
        }

        /// <summary>
        /// This method returns an Appointment object based on 
        /// an AppointmentID.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>An Appointment object. </returns>
        public Appointment GetAppointmentByID(int ID)
        {
            return this.appointmentSource.GetAppointmentByID(ID);
        }

        /// <summary>
        /// This method returns true or false if a patient has 
        /// an appointment or not.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>True or false.</returns>
        public bool CheckIfAppointmentExists(int patientID)
        {
            return this.appointmentSource.CheckIfAppointmentExists(patientID);
        }

        /// <summary>
        /// This method Updates and Appointment in the DB.
        /// </summary>
        /// <param name="newAppointment"></param>
        /// <param name="oldAppointment"></param>
        /// <returns>True or false.</returns>
        public bool UpdateAppointment(Appointment newAppointment, Appointment oldAppointment)
        {
            return this.appointmentSource.UpdateAppointment(newAppointment, oldAppointment);
        }

        /// <summary>
        /// This method returns true or false if a patient has 
        /// an appointment in the future or not.
        /// </summary>
        /// <param name="patientID"></param>
        /// <returns>True or false.</returns>
        public bool CheckIfFutureAppointmentExists(int patientID)
        {
            return this.appointmentSource.CheckIfFutureAppointmentExists(patientID);
        }
    }
}
