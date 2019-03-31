using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlPatientRecords : UserControl
    {
        public UserControlPatientRecords()
        {
            InitializeComponent();
        }

        // Updating a Patient Appointment isn't yet required.
        //
        // The patient dropdown should be bound to a list of patients with appointments from 
        // the PatientDAL, a new method that gets a list of patients with appointments. 

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelPatientInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void buttonAppointmentsUpdate_Click(object sender, EventArgs e)
        {
            // NOT YET NEEDED FOR ITERATION 1!
        }

        private void buttonRoutineChecksUpdate_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled, pass the new PatientVisit object to the 
            // PatientVisit Controller, passing the object with it, to call the method 
            // in the PatientDAL which creates the entry in the DB.
        }

        private void buttonDiagnosisUpdate_Click(object sender, EventArgs e)
        {
            // Ensure all fields are filled, pass the updated PatientVist object to the 
            // PatientVist controller, passing the PatientVist object with it, which calls 
            // the PatientVisitDAL method to update the PatientVisit.
        }
    }
}
