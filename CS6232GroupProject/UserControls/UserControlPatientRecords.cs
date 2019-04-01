using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
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
                //this.appointment = this.appointmentController.GetAppointmentByID((int)this.comboBoxPatientRecordsAppointment.SelectedValue);
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

        }
        private void SetComboBox()
        {
            try
            {
                //Get the patient
                this.appointmentList = this.appointmentController.GetAppointmentsForPatient(UserControlNurseMain.patientID);
                //labelPatientRecords.Text = UserControlNurseMain.patientID.ToString();
                //Form patientRecordsForm = new FormPatientRecords();
                this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentList;

                this.doctorList = this.doctorController.GetDoctors();
                this.comboBoxAppointmentsPhysician.DataSource = this.doctorList;
                

                //
                // When the appointment is changed, the doctor combo box value is matched to the appointment's doctorID

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        // Updating a Patient Appointment isn't yet required.
        //
        // The patient dropdown should be bound to a list of patients with appointments from 
        // the PatientDAL, a new method that gets a list of patients with appointments. 



        private void buttonAppointmentsUpdate_Click(object sender, EventArgs e)
        {
            // NOT YET NEEDED FOR ITERATION 1!
        }

        private void buttonRoutineChecksUpdate_Click(object sender, EventArgs e)
        {
            //Get the Patient visit from the Appointment class' AppointmentID, then get the PatientVisit object.
            // Update that PatientVisit object then pass it to the UpdatePatientVisit method via contoller, 
            // then to the PatientVisitDAL method.
            // PLACEHOLDER FOR A METHOD TO HOLD ALL OF THIS INFO
            //SetNewCheckUpInfo();
            try
            {
                PatientVisit newVisit = new PatientVisit();
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
    }
}
