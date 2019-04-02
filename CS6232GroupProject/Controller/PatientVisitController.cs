using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;

namespace CS6232GroupProject.Controller
{

    /// <summary>
    /// This class creates a PatientVisitController object that allows 
    /// the calling of PatientVisitDAL methods.
    /// </summary>
    class PatientVisitController
    {
        private readonly PatientVisitDAL visitSource;

        /// <summary>
        /// This constructs the PatientVisitController and instatiates the
        /// PatientVisitDAL.
        /// </summary>
        public PatientVisitController()
        {
            this.visitSource = new PatientVisitDAL();
        }

        /// <summary>
        /// This method gets a PatientVisit object by appointmentID.
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns>A PatientVisit object. </returns>
        public PatientVisit GetPatientVisitInfoByAppointment(int appointmentID)
        {
            return this.visitSource.GetPatientVisitInfoByAppointment(appointmentID);
        }

        /// <summary>
        /// This method updates a PatientVisit object.
        /// </summary>
        /// <param name="newVisit"></param>
        /// <param name="oldVisit"></param>
        /// <returns>True or false.</returns>
        public bool UpdateRoutineCheck(PatientVisit newVisit, PatientVisit oldVisit)
        {
            return this.visitSource.UpdateRoutineCheck(newVisit, oldVisit);
        }
    }
}
