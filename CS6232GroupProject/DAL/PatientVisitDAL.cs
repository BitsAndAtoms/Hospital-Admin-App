using CS6232GroupProject.Model;
using System;
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
                "SELECT VisitID, AppoitnementID, NurseID, visitDateTime, Diagnosis, " +
                    "Weight, Systolic, Diastolic, Temperature, Pulse, Symptoms " +
                "FROM PatientVisit " +
                "WHERE AppoitnementID = @AppoitnementID";
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                connection.Open();

                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("@AppoitnementID", appointmentID);
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            visit.VisitID = (int)reader["VisitID"];
                            visit.AppointmentID = (int)reader["AppoitnementID"];
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
                    "AND appoitnementID = @OldAppointmentID " +
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
                    
                    if (newVisit.Symptoms == "" || newVisit.Symptoms == null)
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
                    
                    if (oldVisit.Symptoms == "" || oldVisit.Symptoms == null)
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
    }
}
