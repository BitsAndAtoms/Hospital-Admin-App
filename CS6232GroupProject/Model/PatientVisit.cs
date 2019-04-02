using System;

namespace CS6232GroupProject.Model
{
    class PatientVisit
    {
        /// <summary>
        /// This class creates a PatientVist object with auto-implemented properties.
        /// </summary>
        public int VisitID { get; set; }
        public int AppointmentID { get; set; }
        public int NurseID { get; set; }
        public int DoctorID { get; set; }
        public DateTime Date { get; set; }
        public string Diagnosis { get; set; }
        public decimal Weight { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public decimal Temperature { get; set; }
        public int Pulse { get; set; }
        public string Symptoms { get; set; }

    }
}
