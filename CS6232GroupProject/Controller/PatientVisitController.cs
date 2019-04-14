using System;
using System.Collections.Generic;
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

        /// <summary>
        /// This method checks to see if a PatientVisit exists.
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns>True or false.</returns>
        public bool DoesPatientVisitExist(int AppointmentID)
        {
            return this.visitSource.DoesPatientVisitExist(AppointmentID);
        }

        /// <summary>
        /// Add a patients visti
        /// </summary>
        /// <param name="visit"></param>
        /// <returns></returns>
        public int AddPatientVisit(PatientVisit visit)
        {
            return this.visitSource.AddPatientVisit(visit);
        }

        /// <summary>
        /// return the list of lab results
        /// </summary>
        /// <param name="visit">the visit for which results are reuired</param>
        /// <returns>list of results</returns>
        public List<LabTestResult> SearchLabTestResultByVisitID(PatientVisit visit)
        {
            return this.visitSource.GetLabTestResultByVisitID(visit);
        }

        /// <summary>
        /// Order the tests for given visit
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <param name="testOrdered">name of test ordered</param>
        internal void OrderSelectedTestForVisit(PatientVisit visit,string testOrdered)
        {
            this.visitSource.OrderSelectedTestForVisit(visit, testOrdered);
        }

        /// <summary>
        /// enter the final diagnosis
        /// </summary>
        /// <param name="visit">given visit</param>
        internal void EnterFinalDiagnosis(PatientVisit visit)
        {
            this.visitSource.EnterFinalDiagnosis(visit);
        }

        /// <summary>
        /// enter test result for a test on a given visit
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <param name="test">test in the lab</param>
        /// <param name="result">result of the test</param>
        internal void EnterTestResultForVisit(PatientVisit visit, LabTest test, LabTestResult result)
        {
            this.visitSource.EnterTestResultForVisit(visit, test, result);
        }

        /// <summary>
        /// Enter the initial diagnosis
        /// </summary>
        /// <param name="visit"></param>
        internal void EnterInitialDiagnosis(PatientVisit visit)
        {
            this.visitSource.EnterInitialDiagnosis(visit);
        }

        /// <summary>
        /// check if there are pending tests
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <returns>true/false</returns>
        internal bool CheckForPendingTests(PatientVisit visit)
        {
           return this.visitSource.CheckForPendingTestsFromVisitDAL(visit);
        }

        /// <summary>
        /// get lab test result as list for a particular visit
        /// </summary>
        /// <param name="visit">visit</param>
        /// <returns>lsit of results for a given visit</returns>
        internal List<LabTestResult> GetLabTestResultByVisitID(PatientVisit visit)
        {
            return this.visitSource.GetLabTestResultByVisitID(visit);
        }
    }
}
