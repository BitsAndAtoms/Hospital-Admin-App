using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;

namespace CS6232GroupProject.DAL
{
    class PatientVisitDAL
    {

        //The DB has AppointmentID misspelled as AppoitnementID.
        public PatientVisit GetPatientVisitInfoByAppointment(int appointmentID)
        {
            PatientVisit visit = new PatientVisit();

            string selectStatement =
                "SELECT VisitID, AppoitnementID, NurseID, VisitDateTime, Diagnosis, " +
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
                            visit.Date = (DateTime)reader["VisitDateTime"];
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
    }
}
