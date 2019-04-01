using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormPatientRecords : Form
    {
        private List<Appointment> appointmentList;
        private AppointmentController appointmentController;
        public FormPatientRecords()
        {
            InitializeComponent();
            this.appointmentController = new AppointmentController();
            this.appointmentList = new List<Appointment>();
            SetComboBox();
        }

        private void SetComboBox()
        {
            try
            {
                //Get the patient
                this.appointmentList = this.appointmentController.GetAppointmentsForPatient(UserControlNurseMain.patientID);
                //Form patientRecordsForm = new FormPatientRecords();
                this.comboBoxPatientRecordsAppointment.DataSource = this.appointmentList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
