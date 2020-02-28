using HospitalAdminApp.DAL;
using HospitalAdminApp.Model;
using System;
using System.Collections.Generic;
using System.Data;

namespace HospitalAdminApp.Controller
{
    /// <summary>
    /// This class creates a LabTestResultController object to call on methods in the 
    /// LabTestResultDAL.
    /// </summary>
    class LabTestResultsController
    {

        private readonly LabTestResultsDAL labTestResultsSource;

        /// <summary>
        /// This instatiates the LabTestResultsDAL and constructs the LabTestResultsController.
        /// </summary>
        public LabTestResultsController()
        {
            this.labTestResultsSource = new LabTestResultsDAL();
        }

        /// <summary>
        /// check if there are pending tests
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <returns>true/false</returns>
        internal bool CheckForPendingTests(PatientVisit visit)
        {
            return this.labTestResultsSource.CheckForPendingTestsFromVisitDAL(visit);
        }

        /// <summary>
        /// get lab test result as list for a particular visit
        /// </summary>
        /// <param name="visit">visit</param>
        /// <returns>lsit of results for a given visit</returns>
        internal List<LabTestResult> GetLabTestResultByVisitID(PatientVisit visit)
        {
            return this.labTestResultsSource.GetLabTestResultByVisitID(visit);
        }

        /// <summary>
        /// enter test result for a test on a given visit
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <param name="test">test in the lab</param>
        /// <param name="result">result of the test</param>
        internal void EnterTestResultForVisit(PatientVisit visit, LabTest test, LabTestResult result)
        {
            this.labTestResultsSource.EnterTestResultForVisit(visit, test, result);
        }

        /// <summary>
        /// return the list of lab results
        /// </summary>
        /// <param name="visit">the visit for which results are reuired</param>
        /// <returns>list of results</returns>
        public List<LabTestResult> SearchLabTestResultByVisitID(PatientVisit visit)
        {
            return this.labTestResultsSource.GetLabTestResultByVisitID(visit);
        }

        /// <summary>
        /// Order the tests for given visit
        /// </summary>
        /// <param name="visit">given visit</param>
        /// <param name="testOrdered">name of test ordered</param>
        internal void OrderSelectedTestForVisit(PatientVisit visit, string testOrdered)
        {
            this.labTestResultsSource.OrderSelectedTestForVisit(visit, testOrdered);
        }

        /// <summary>
        /// Get lab test results stats
        /// </summary>
        /// <param name="BeginDate">Begin time for stats</param>
        /// <param name="EndDate"End time for stats</param>
        /// <returns>data table for lab stats</returns>

        public DataTable GetLabTestResultStatiscitsForReportController(DateTime BeginDate, DateTime EndDate)
        {
            return this.labTestResultsSource.GetLabTestResultStatiscitsForReport(BeginDate,EndDate);
        }
    }
}
