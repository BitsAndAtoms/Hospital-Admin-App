using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlNurseMain : UserControl
    {
        private List<Doctor> doctorList;
        private List<Patient> patientList;
        private DoctorController doctorController;
        private PatientController patientController;

        public UserControlNurseMain()
        {
            InitializeComponent();
            this.doctorController = new DoctorController();
            SetComboBox();
        }

        private void SetComboBox()
        {
            try
            {
                foreach (string state in State.GetStates())
                {
                    this.comboBoxState.Items.Add(state);
                }

                // Should we start using Data Sources?

                //Just a set of test data to allow displaying of a Doctor and Patient.
                // If it isn't useful, feel free to get rid of it.

                // Below is the line that will bind it to the DB set of Doctors and Patients
                // once there are some in the DB.

                //patientList = this.patientController.GetPatients();
                List<Patient> patients = new List<Patient>();
                Patient patient = new Patient
                {
                    PatientID = 1,
                    FName = "Cotton Eye",
                    LName = "Joe",
                    DOB = DateTime.Today
                };

                patients.Add(patient);
                patientList = patients;
                comboBoxPatient.DataSource = patientList;

                
         
                //doctorList = this.doctorController.GetDoctors();
                List<Doctor> doctors = new List<Doctor>();
                Doctor doctor = new Doctor
                {
                    DoctorID = 1,
                    FName = "FirstName",
                    LName = "LastName",
                    DOB = DateTime.Today,
                    SSN = "123456789",
                    Gender = "M",
                    Phone = "6211122545",
                    AddressID = 1
                };

                doctors.Add(doctor);
                doctorList = doctors;
                comboBoxPhysician.DataSource = doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void buttonRegisterSubmit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            panelPatientInfoResults.Visible = true;
            linkLabelPatientInfoBack.Visible = true;
            /// when selected and conditions approved, Patient Info results panel and back button should then be visible
        }

        private void linkLabelPatientInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPatientInfoResults.Visible = false;
            linkLabelPatientInfoBack.Visible = false;
            /// 
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctorTableAdapter.FillBy(this.clinicDataSet.Doctor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkLabelRecordsPatientInfoVisitRecords_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool isOpen = false;
            FormPatientRecords formPatientRecords = new FormPatientRecords();
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormPatientRecords")
                {
                    isOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                formPatientRecords.Show();
            }

        }
    }
}
