using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    /// <summary>
    /// This class creates a LabTestResultsDAL that can send or recieve 
    /// information from the DB.
    /// </summary>
    class LabTestResultsDAL
    {

        /// <summary>
        /// This method orders the tests chosen from checkbox list
        /// </summary>
        /// <param name="visit"> is the visit of the patient</param>
        /// <param name="testOrdered"> is the name of the test to be added for the visitID</param>
        internal void OrderSelectedTestForVisit(PatientVisit visit, string testOrdered)
        {
            string insertStatement =
                "INSERT LabTestResult (testID, visitID,testPerformedDate,testResultDate) " +
                "VALUES ((SELECT testID FROM LabTestList WHERE testName = @testName), @visitID, @testPerformedDate,@testResultDate)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                    insertCommand.Parameters.AddWithValue("@testName", testOrdered);
                    insertCommand.Parameters.AddWithValue("@testPerformedDate", visit.Date);
                    insertCommand.Parameters.AddWithValue("@testResultDate", DateTime.Now);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Check if their are pending tests
        /// </summary>
        /// <param name="visit">visit </param>
        /// <returns>true or false</returns>
        internal bool CheckForPendingTestsFromVisitDAL(PatientVisit visit)
        {
            int count = 0;
            string selectStatment =
                "SELECT COUNT(testID) as 'Number' " +
                "FROM LabTestResult " +
                "WHERE visitID = @visitID AND testResult IS NULL ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {

                    selectCommand.Parameters.AddWithValue("@visitID", visit.VisitID);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int number = (int)reader["Number"];
                            count += number;

                        }
                    }
                    if (count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }

        }

        /// <summary>
        /// Get lab test results based on visit
        /// </summary>
        /// <param name="visit">visit of the patient</param>
        /// <returns>list of lab test results</returns>
        public List<LabTestResult> GetLabTestResultByVisitID(PatientVisit visit)
        {
            List<LabTestResult> result = new List<LabTestResult>();

            string selectStatement =
                "SELECT t1.testID as testID, visitID, labTestResultID as resultID, testName, testResult, testResultDate, testPerformedDate " +
                "FROM LabTestResult t1 " +
                "LEFT JOIN " +
                "LabTestList t2 " +
                " ON t1.testID = t2.testID " +
                " WHERE visitID = @visitID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LabTestResult newResult = new LabTestResult();
                            newResult.ResultID = (int)reader["resultID"];
                            newResult.TestID = (int)reader["testID"];
                            newResult.VisitID = (int)reader["visitID"];
                            newResult.Result = reader["testResult"].ToString();
                            newResult.Name = reader["testName"].ToString();
                            newResult.TestResultDate = (DateTime)reader["testResultDate"];
                            newResult.TestOrderedDate = (DateTime)reader["testPerformedDate"];


                            result.Add(newResult);
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Method to enter results of test
        /// </summary>
        /// <param name="visit">Is the associated visit</param>
        /// <param name="test">Is the associated test</param>
        /// <param name="result">Result of the test</param>
        internal void EnterTestResultForVisit(PatientVisit visit, LabTest test, LabTestResult result)
        {
            string insertStatement =
                "UPDATE LabTestResult SET" +
                " testResult = @testResult, testResultDate = getdate() " +
                "WHERE  testID = " +
                "(SELECT testID FROM LabTestList " +
                "WHERE testName = @testName)" +
                " AND visitID = @visitID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                    insertCommand.Parameters.AddWithValue("@testName", test.Name);
                    insertCommand.Parameters.AddWithValue("@testResult", result.Result);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }
    }
}
