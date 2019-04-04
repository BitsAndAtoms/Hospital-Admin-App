using System;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates a Nurse object with auto-implemented properties.
    /// </summary>
    class Nurse
    {
        public int NurseID { get; set; }
        public string FName  { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AddressID { get; set; }
        public Boolean Active { get; set; }
    }
}
