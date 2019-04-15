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
        /// <summary>
        /// Registeartion of patients 
        /// </summary>
        /// <param name="newPatient">is the patients info</param>
        /// <param name="newAddress">is the address of the patient</param>
        internal void registerPatient(Patient newPatient, Address newAddress)
        {
            this.patientSource.registerPatientInDB(newPatient, newAddress);
        }

        /// <summary>
        /// search the patient info by name and dob
        /// </summary>
        /// <param name="newPatient">is the patients info</param>
        /// <returns></returns>
        public List<Patient> getPatientInformation(Patient newPatient)
        {
           return this.patientSource.GetSearchPatientsByNameDOB(newPatient);
        }

        /// <summary>
        /// update the patients information
        /// </summary>
        /// <param name="newPatient"></param>
        /// <param name="newAddress"></param>
        internal void updatePatient(Patient newPatient, Address newAddress)
        {
            this.patientSource.updatePatient(newPatient,newAddress);
        }

        /// <summary>
        /// This method calls a method in the PatientDAL that
        /// deletes a patient if they have no appointments.
        /// </summary>
        /// <param name="newPatient"></param>
        /// <param name="newAddress"></param>
        internal void deletePatient(Patient newPatient, Address newAddress)
        {
            this.patientSource.deletePatient(newPatient, newAddress);
        }

        /// <summary>
        /// This method calls a method in the PatientDAL that 
        /// checks if a SSN is unqiue or not.
        /// </summary>
        /// <param name="ssn"></param>
        /// <param name="patientID"></param>
        /// <returns>True or false.</returns>
        public bool CheckIfPatientSSNExists(string ssn, int patientID)
        {
            return this.patientSource.CheckPatientSSN(ssn, patientID);
        }
    }
}
