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
        private List<Doctor> doctorList;
        private Appointment appointment;
        private int appointmentID;
        public UserControlPatientRecords()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.doctorController = new DoctorController();
            SetComboBox();
            SetAppointment();
            
        }

        private void SetAppointment()
        {
            this.appointmentID = (int)this.comboBoxPatientRecordsAppointment.SelectedValue;
            this.appointment = this.appointmentController.GetAppointmentByID((int)this.comboBoxPatientRecordsAppointment.SelectedValue);
            this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
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
            //this.textBoxAppointmentsSummary.Text = this.appointmentID.ToString();
            this.comboBoxAppointmentsPhysician.SelectedValue = this.appointment.DoctorID;
        }
    }
}
