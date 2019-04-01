using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
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
            SetComboBox();
        }

        private void SetComboBox()
        {
            try
            {
                appointmentList = this.appointmentController.GetAppointments();
                this.comboBoxPatientRecordsAppointment.DataSource = appointmentController;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
