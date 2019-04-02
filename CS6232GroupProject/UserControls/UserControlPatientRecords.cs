using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    /// <summary>
    /// This class creates a user control to hold record information for 
    /// a Patient.
    /// </summary>
    public partial class UserControlPatientRecords : UserControl
    {

        private List<Appointment> appointmentList;
        private AppointmentController appointmentController;
        private DoctorController doctorController;
        private PatientVisitController visitController;
        private List<Doctor> doctorList;
        private Appointment appointment;
        private PatientVisit visit;
        private int appointmentID;

        /// <summary>
        /// This constructs the UserControlPatientRecords objects and instatiates
        /// the needed variables.
        /// </summary>
        public UserControlPatientRecords()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            this.visitController = new PatientVisitController();
            SetComboBox();
            SetAppointment();
            
        }

        private void SetAppointment()
        {
            try
            {
                this.appointmentID = (int)this.comboBoxPatientRecordsAppointment.SelectedValue;
                this.appointment = this.appointmentController.GetAppointmentByID(this.appointmentID);
                this.visit = this.visitController.GetPatientVisitInfoByAppointment(this.appointmentID);
                this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
                
            }
            catch
            {
                MessageBox.Show("This patient has no appointments.");
            }
        }

        private void SetPatientVisit()
        {
            this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
            this.textBoxAppointmentsSummary.Text = this.appointment.Reasons;
            this.dateTimePickerAppointments.Value = (DateTime)this.appointment.AppointmentDateTime;
            this.dateTimePickerAppointmentsTime.Value = (DateTime)this.appointment.AppointmentDateTime;

            this.textBoxRoutineChecksWeight.Text = this.visit.Weight.ToString();
            this.textBoxRoutineChecksSystolic.Text = this.visit.Systolic.ToString();
            this.textBoxRoutineChecksDiastolic.Text = this.visit.Diastolic.ToString();
            this.textBoxRoutineChecksTemp.Text = this.visit.Temperature.ToString();
            this.textRoutineChecksPulse.Text = this.visit.Pulse.ToString();
            this.textBoxRoutineChecksSummary.Text = this.visit.Symptoms;
            this.textBoxDiagnosisIntial.Text = this.visit.Diagnosis;
        }

        private void SetComboBox()
        {
            try
            {
                this.appointmentList = this.appointmentController.GetAppointmentsForPatient(UserControlNurseMain.patientID);
                this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentList;

                this.doctorList = this.doctorController.GetDoctors();
                this.comboBoxAppointmentsPhysician.DataSource = this.doctorList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void SetCheckUpInfo()
        {
            PatientVisit newVisit = new PatientVisit();
            if (this.visitController.DoesPatientVisitExist(this.visit.AppointmentID))
            {
                try
                {
                    
                    
                    newVisit.VisitID = this.visit.VisitID;
                    newVisit.AppointmentID = this.visit.AppointmentID;
                    newVisit.NurseID = this.visit.NurseID;
                    newVisit.DoctorID = this.visit.DoctorID;
                    newVisit.Date = this.visit.Date;

                    newVisit.Weight = Convert.ToDecimal(this.textBoxRoutineChecksWeight.Text);
                    newVisit.Systolic = Convert.ToInt32(this.textBoxRoutineChecksSystolic.Text);
                    newVisit.Diastolic = Convert.ToInt32(this.textBoxRoutineChecksDiastolic.Text);
                    newVisit.Temperature = Convert.ToDecimal(this.textBoxRoutineChecksTemp.Text);
                    newVisit.Pulse = Convert.ToInt32(this.textRoutineChecksPulse.Text);
                    newVisit.Symptoms = this.textBoxRoutineChecksSummary.Text;

                    if (this.visitController.UpdateRoutineCheck(newVisit, this.visit))
                    {
                        MessageBox.Show("Routine Check information updated!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("The information couldn't be updated.", "Error Updating Database");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue updating the database.", "Error Updating Database");
                }
            }
            else
            {
                try
                {
                    newVisit.VisitID = this.visit.VisitID;
                    newVisit.AppointmentID = this.visit.AppointmentID;
                    newVisit.NurseID = this.visit.NurseID;
                    newVisit.DoctorID = this.visit.DoctorID;
                    newVisit.Date = this.visit.Date;

                    newVisit.Weight = Convert.ToDecimal(this.textBoxRoutineChecksWeight.Text);
                    newVisit.Systolic = Convert.ToInt32(this.textBoxRoutineChecksSystolic.Text);
                    newVisit.Diastolic = Convert.ToInt32(this.textBoxRoutineChecksDiastolic.Text);
                    newVisit.Temperature = Convert.ToDecimal(this.textBoxRoutineChecksTemp.Text);
                    newVisit.Pulse = Convert.ToInt32(this.textRoutineChecksPulse.Text);
                    newVisit.Symptoms = this.textBoxRoutineChecksSummary.Text;

                    this.visitController.AddPatientVisit(newVisit);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                

            }
            
        }

        private void buttonAppointmentsUpdate_Click(object sender, EventArgs e)
        {
            // NOT YET NEEDED FOR ITERATION 1!
        }

        private void buttonRoutineChecksUpdate_Click(object sender, EventArgs e)
        {
            //If no PatientVisit exists, create one with the entered info and reload the page.
            SetCheckUpInfo();
        }

        private void buttonDiagnosisUpdate_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled, pass the updated PatientVist object to the 
            // PatientVist controller, passing the PatientVist object with it, which calls 
            // the PatientVisitDAL method to update the PatientVisit.
        }

        private void comboBoxPatientRecordsAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.appointmentID = (int)this.comboBoxPatientRecordsAppointment.SelectedValue;
            SetAppointment();
            SetPatientVisit();
            
        }
    }
}
