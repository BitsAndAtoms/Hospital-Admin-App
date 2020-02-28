using HospitalAdminApp.DAL;
using HospitalAdminApp.Model;
using System.Collections.Generic;

namespace HospitalAdminApp.Controller
{
    /// <summary>
    /// This class creates a DoctorController object 
    /// and calls the DoctorDAL methods.
    /// </summary>
    class DoctorController
    {
        private readonly DoctorDAL doctorSource;

        /// <summary>
        /// This method constructs the DoctorController object
        /// and initialises the DoctorDAL variable.
        /// </summary>
        public DoctorController()
        {
            this.doctorSource = new DoctorDAL();
        }
        /// <summary>
        /// This method returns a list of Doctors.
        /// </summary>
        /// <returns>A list of Doctor objects.</returns>
        public List<Doctor> GetDoctors()
        {
            return this.doctorSource.GetDoctors();
        }
    }
}
