using System;

namespace CS6232GroupProject.Model
{
    /// <summary>
    /// This class creates an Administrator objects with auto-implemented properties.
    /// </summary>
    class Administrator
    {
        public int AdminID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName { get; set; }
        public DateTime? DOB { get; set; }
        public string SSN { get; set; }
        public string Gender { get; set; }
        public string phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AddressID { get; set; }
    }
}
