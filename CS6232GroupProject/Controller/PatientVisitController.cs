using CS6232GroupProject.DAL;
using CS6232GroupProject.Model;

namespace CS6232GroupProject.Controller
{
    class PatientVisitController
    {
        private readonly PatientVisitDAL visitSource;

        public PatientVisitController()
        {
            this.visitSource = new PatientVisitDAL();
        }

        public PatientVisit GetPatientVisitInfoByAppointment(int appointmentID)
        {
            return this.visitSource.GetPatientVisitInfoByAppointment(appointmentID);
        }

        public bool UpdateRoutineCheck(PatientVisit newVisit, PatientVisit oldVisit)
        {
            return this.visitSource.UpdateRoutineCheck(newVisit, oldVisit);
        }
    }
}
