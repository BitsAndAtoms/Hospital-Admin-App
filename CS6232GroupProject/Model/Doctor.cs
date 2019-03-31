using System;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates a Doctor object with auto-implemented properties. 
    /// </summary>
    class Doctor
    {
        public int DoctorID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int AddressID { get; set; }
    }
}
