using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{

    /// <summary>
    /// This class creates an AppointmentDAL object to retrieve data from the 
    /// Clinic DB.
    /// </summary>
    class PatientVisitDAL
    {

        /// <summary>
        /// This method gets a PatientVist object based on an appointmentID.
        /// </summary>
        /// <param name="appointmentID"></param>
        /// <returns>A PatientVisit object. </returns>
        public PatientVisit GetPatientVisitInfoByAppointment(int appointmentID)
        {
            PatientVisit visit = new PatientVisit();

            string selectStatement =
                "SELECT VisitID, appointmentID, NurseID, visitDateTime, Diagnosis, " +
                    "Weight, Systolic, Diastolic, Temperature, Pulse, Symptoms " +
                "FROM PatientVisit " +
                "WHERE appointmentID = @appointmentID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@appointmentID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visit.VisitID = (int)reader["VisitID"];
                            visit.AppointmentID = (int)reader["appointmentID"];
                            visit.NurseID = (int)reader["NurseID"];
                            visit.Date = (DateTime)reader["visitDateTime"];
                            visit.Diagnosis = reader["Diagnosis"].ToString();
                            visit.Weight = (decimal)reader["Weight"];
                            visit.Systolic = (int)reader["Systolic"];
                            visit.Diastolic = (int)reader["Diastolic"];
                            visit.Temperature = (decimal)reader["Temperature"];
                            visit.Pulse = (int)reader["Pulse"];
                            visit.Symptoms = reader["Symptoms"].ToString();
                        }
                    }
                }
            }
            return visit;
        }

        /// <summary>
        /// This method orders the tests chosen from checkbox list
        /// </summary>
        /// <param name="visit"> is the visit of the patient</param>
        /// <param name="testOrdered"> is the name of the test to be added for the visitID</param>
        internal void OrderSelectedTestForVisit(PatientVisit visit, string testOrdered)
        {
            string insertStatement =
                "INSERT LabTestResult (testID, visitID) " +
                "VALUES (SELECT testID FROM LabTestList WHERE testName = @testName, @visitID)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                    insertCommand.Parameters.AddWithValue("@testName", testOrdered);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }



        public List<LabTestResult> GetLabTestResultByVisitID(PatientVisit visit)
        {
            List<LabTestResult> result = new List<LabTestResult>();
            
            string selectStatement =
                "SELECT testResult, testDate " +
                   
                "FROM LabTestResult " +
                "WHERE visitID = @visitID";
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
                            newResult.Result = reader["testResult"].ToString();
                            newResult.TestDate = (DateTime)reader["testDate"];
                            result.Add(newResult);
                        }
                    }
                }
            }
            return result;
        }









        internal void EnterTestResultForVisit(PatientVisit visit,LabTest test,LabTestResult result)
        {
            string insertStatement =
                "UPDATE LabTestResult SET" +
                " testResult = @testResult " +
                "WHERE  testID = (SELECT testID FROM LabTestList WHERE testName = @testName)" +
                " AND visitID = @visitID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@visitID", visit.VisitID);
                    insertCommand.Parameters.AddWithValue("@testName", test.Name);
                    insertCommand.Parameters.AddWithValue("@testResult",result.Result);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }





        internal bool EnterInitialDiagnosis(PatientVisit visit)
        {
            string updateStatement =
                "UPDATE PatientVisit SET " +
                    "diagnosis = @diagnosis, " +
                "WHERE VisitID = @OldVisitID ";
            
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updatedCommand = new SqlCommand(updateStatement, connection))
                {
                    updatedCommand.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
                    updatedCommand.Parameters.AddWithValue("@OldVisitID", visit.VisitID);
                    int count = updatedCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        internal bool EnterFinalDiagnosis(PatientVisit visit)
        {
            string updateStatement =
                "UPDATE PatientVisit SET " +
                    "diagnosis = @diagnosis, " +
                "WHERE VisitID = @OldVisitID ";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updatedCommand = new SqlCommand(updateStatement, connection))
                {
                    updatedCommand.Parameters.AddWithValue("@diagnosis", visit.Diagnosis);
                    updatedCommand.Parameters.AddWithValue("@OldVisitID", visit.VisitID);
                    int count = updatedCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// This method updates a PatientVisit row that returns true if complete
        /// or false if not.
        /// </summary>
        /// <param name="newVisit"></param>
        /// <param name="oldVisit"></param>
        /// <returns>True or False</returns>
        public bool UpdateRoutineCheck(PatientVisit newVisit, PatientVisit oldVisit)
        {
            string updateStatement =
                "UPDATE PatientVisit SET " +
                    "Symptoms = @NewSymptoms, " +
                    "Weight = @NewWeight, " +
                    "Systolic = @NewSystolic, " +
                    "Diastolic = @NewDiastolic, " +
                    "Temperature = @NewTemperature, " +
                    "Pulse = @NewPulse " +
                "WHERE VisitID = @OldVisitID " +
                    "AND appointmentID = @OldAppointmentID " +
                    "AND visitDateTime = @OldDate " +
                    "AND Symptoms = @OldSymptoms " +
                    "AND Weight = @OldWeight " +
                    "AND Systolic = @OldSystolic " +
                    "AND Diastolic = @OldDiastolic " +
                    "AND Temperature = @OldTemperature " +
                    "AND Pulse = @OldPulse ";
            


            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand updatedCommand = new SqlCommand(updateStatement, connection))
                {
                    
                    if ( newVisit.Symptoms == null)
                    {
                        updatedCommand.Parameters.AddWithValue("@NewSymptoms", DBNull.Value);
                    }
                    else
                    {
                        updatedCommand.Parameters.AddWithValue("@NewSymptoms", newVisit.Symptoms);
                    }
                    
                    updatedCommand.Parameters.AddWithValue("@NewWeight", newVisit.Weight);
                    updatedCommand.Parameters.AddWithValue("@NewSystolic", newVisit.Systolic);
                    updatedCommand.Parameters.AddWithValue("@NewDiastolic", newVisit.Diastolic);
                    updatedCommand.Parameters.AddWithValue("@NewTemperature", newVisit.Temperature);
                    updatedCommand.Parameters.AddWithValue("@NewPulse", newVisit.Pulse);

                    

                    updatedCommand.Parameters.AddWithValue("@OldVisitID", oldVisit.VisitID);
                    updatedCommand.Parameters.AddWithValue("@OldAppointmentID", oldVisit.AppointmentID);

                    if (oldVisit.Date == null)
                    {
                        updatedCommand.Parameters.AddWithValue("@OldDate", DBNull.Value);
                    }
                    else
                    {
                        updatedCommand.Parameters.AddWithValue("@OldDate", oldVisit.Date);
                    }
                    
                    if ( oldVisit.Symptoms == null)
                    {
                        updatedCommand.Parameters.AddWithValue("@OldSymptoms", DBNull.Value);
                    }
                    else
                    {
                        updatedCommand.Parameters.AddWithValue("@OldSymptoms", oldVisit.Symptoms);
                    }
                    updatedCommand.Parameters.AddWithValue("@OldWeight", oldVisit.Weight);
                    updatedCommand.Parameters.AddWithValue("@OldSystolic", oldVisit.Systolic);
                    updatedCommand.Parameters.AddWithValue("@OldDiastolic", oldVisit.Diastolic);
                    updatedCommand.Parameters.AddWithValue("@OldTemperature", oldVisit.Temperature);
                    updatedCommand.Parameters.AddWithValue("@OldPulse", oldVisit.Pulse);
                    
                    int count = updatedCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Checks if an appointment exists yet and returns 
        /// true if it does, false if it doesn't.
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns>True or false.</returns>
        public bool DoesPatientVisitExist(int AppointmentID)
        {
            int count = 0;
            string selectStatment =
                "SELECT COUNT(appointmentID) as 'Number' " +
                "FROM PatientVisit " +
                "WHERE appointmentID = @appointmentID";

            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatment, connection))
                {

                    selectCommand.Parameters.AddWithValue("@appointmentID", AppointmentID);

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
        /// This method creates a PatientVisit object.
        /// </summary>
        /// <param name="visit"></param>
        /// <returns>Returns an int.</returns>
        public int AddPatientVisit(PatientVisit visit)
        {
            string insertStatement =
                "INSERT  PatientVisit " +
                "(appointmentID, nurseID, visitDateTime, weight, systolic, diastolic, temperature, pulse, symptoms) " +
                "VALUES (@appointmentID, @nurseID, @visitDateTime, @weight, @systolic, @diastolic, @temperature, @pulse, @symptoms)";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand insertCommand = new SqlCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("@appointmentID", visit.AppointmentID);
                    insertCommand.Parameters.AddWithValue("@nurseID", visit.NurseID);
                    insertCommand.Parameters.AddWithValue("@visitDateTime", visit.Date);
                    insertCommand.Parameters.AddWithValue("@weight", visit.Weight);
                    insertCommand.Parameters.AddWithValue("@systolic", visit.Systolic);
                    insertCommand.Parameters.AddWithValue("@diastolic", visit.Diastolic);
                    insertCommand.Parameters.AddWithValue("@temperature", visit.Temperature);
                    insertCommand.Parameters.AddWithValue("@pulse", visit.Pulse);
                    insertCommand.Parameters.AddWithValue("@symptoms", visit.Symptoms);
                    insertCommand.ExecuteNonQuery();
                    int appointmentID = 0;
                    return appointmentID;
                }
            }
        }
    }
}
