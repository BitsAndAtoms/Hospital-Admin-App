using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
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
        /// <summary>
        /// Checks if a patient visit exists
        /// </summary>
        /// <param name="AppointmentID"></param>
        /// <returns></returns>
        private bool CheckIfPatientVisitExists(int AppointmentID)
        {
            
            if (this.visitController.DoesPatientVisitExist(AppointmentID))
            {
                
                return false;

            }
            else
            {
                
                return true;
            }
        }

        /// <summary>
        /// sets appointment for a patient
        /// </summary>
        private void SetAppointment()
        {
            try
            {
                if (CheckIfPatientVisitExists(this.appointmentID))
                {
                    this.visit = this.visitController.GetPatientVisitInfoByAppointment(this.appointmentID);
                }
                else
                {
                    CreateVisit();
                }
                
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, ex.GetType().ToString());
                MessageBox.Show("This patient has no appointments.");
            }
        }

        /// <summary>
        /// creates a visit
        /// </summary>
        private void CreateVisit()
        {
            PatientVisit newVisit = new PatientVisit();
            newVisit.AppointmentID = this.appointmentID;
            newVisit.NurseID = FormLogin.NurseID;
            newVisit.DoctorID = this.appointment.DoctorID;
            newVisit.Date = (DateTime)this.appointment.AppointmentDateTime;

            
            newVisit.Weight = 0.0m;
            newVisit.Systolic = 0;
            newVisit.Diastolic = 0;
            newVisit.Temperature = 0.0m;
            newVisit.Pulse = 0;
            newVisit.Symptoms = "";

            try
            {
                this.visitController.AddPatientVisit(newVisit);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
            this.visit = this.visitController.GetPatientVisitInfoByAppointment(this.appointmentID);
        }

        /// <summary>
        /// sets the visit info for a patient
        /// </summary>
        private void SetVisitInfo()
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

        /// <summary>
        /// sets a combo box for the appointment list  and doctor
        /// </summary>
        private void SetComboBox()
        {
            try
            {
                this.appointmentList = this.appointmentController.GetAppointmentsForPatient(UserControlNurseMain.patientID);
                this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentList;

                this.doctorList = this.doctorController.GetDoctors();
                this.comboBoxAppointmentsPhysician.DataSource = this.doctorList;
                this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// sets up check up info
        /// </summary>
        private void SetCheckUpInfo()
        {
            
            PatientVisit newVisit = new PatientVisit();
            try
            {


                newVisit.VisitID = this.visit.VisitID;
                newVisit.AppointmentID = this.visit.AppointmentID;
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
            catch (Exception)
            {
                
                MessageBox.Show("There was an issue updating the database.", "Error Updating Database");
            }

        }

        /// <summary>
        /// disable textfield if meet criteria
        /// </summary>
        private void AppointmentTimeCheck()
        {

            var appointment_time = Convert.ToDateTime(this.comboBoxPatientRecordsAppointment.Text);
            var time_now = DateTime.Now;
            if (time_now <= appointment_time)
            {
                textBoxAppointmentsSummary.Enabled = true;
            }
            else
            {
                textBoxAppointmentsSummary.Enabled = false;
            }
        }

        /// <summary>
        /// Update appointments if datetime is now or earlier.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAppointmentsUpdate_Click(object sender, EventArgs e)
        {
            Appointment newAppointment = new Appointment();
            var appointment_time = Convert.ToDateTime(comboBoxPatientRecordsAppointment.Text);
            var time_now = DateTime.Now;

            if (time_now <= appointment_time)
            {
                newAppointment.DoctorID = Convert.ToInt32(this.comboBoxAppointmentsPhysician.SelectedValue);
                newAppointment.AppointmentDateTime = this.dateTimePickerAppointments.Value.Date + this.dateTimePickerAppointmentsTime.Value.TimeOfDay;
                newAppointment.Reasons = this.textBoxAppointmentsSummary.Text;

                if (this.appointmentController.UpdateAppointment(newAppointment, this.appointment))
                {
                    MessageBox.Show("Appointment Updated!", "Sucess");
                    this.comboBoxAppointmentsPhysician.SelectedValue = newAppointment.DoctorID;
                }
                else
                {
                    MessageBox.Show("There was an issue updating the Appointment!", "Error");
                }
            }
            else
            {
                MessageBox.Show("Appointment date has expired and can no longer be edited.", "Confirm");
            }
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
            this.appointment = this.appointmentController.GetAppointmentByID(this.appointmentID);
            SetAppointment();
            this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
            SetVisitInfo();
            AppointmentTimeCheck();
        }
        
    }
}
