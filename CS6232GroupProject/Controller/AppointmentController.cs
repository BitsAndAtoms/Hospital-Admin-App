using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;

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
    }
}
