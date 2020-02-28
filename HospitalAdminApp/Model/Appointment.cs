using System;

namespace HospitalAdminApp.Model
{
    /// <summary>
    /// This class creates an Appointment object with auto-implemented properties.
    /// </summary>
    class Appointment
    {
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime? AppointmentDateTime { get; set; }
        public string Reasons { get; set; }
    }
}
