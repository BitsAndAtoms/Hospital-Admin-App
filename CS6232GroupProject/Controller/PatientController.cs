using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;
using System.Collections.Generic;

namespace CS6232GroupProject.Controller
{
    /// <summary>
    /// This class creates a PatientController object 
    /// and calls the PatientDAL methods.
    /// </summary>
    class PatientController
    {
        private readonly PatientDAL patientSource;

        /// <summary>
        /// This method constructs the PatientController object
        /// and initialises the PatientDAL variable.
        /// </summary>
        public PatientController()
        {
            this.patientSource = new PatientDAL();
        }

        /// <summary>
        /// This method returns a list of Patients.
        /// </summary>
        /// <returns>A list of Patient objects.</returns>
        public List<Patient> GetPatients()
        {
            return this.patientSource.GetPatients();
        }


    }
}
