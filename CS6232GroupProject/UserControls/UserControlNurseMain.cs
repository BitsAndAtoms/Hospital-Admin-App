using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlNurseMain : UserControl
    {
        private Patient patient;
        private List<Doctor> doctorList;
        private List<Patient> patientList;
        private DoctorController doctorController;
        private PatientController patientController;

        public UserControlNurseMain()
        {
            InitializeComponent();
            this.doctorController = new DoctorController();
            this.patientController = new PatientController();
            SetComboBox();
        }

        private void SetComboBox()
        {
            try
            {
                foreach (string state in State.GetStates())
                {
                    this.comboBoxState.Items.Add(state);
                    this.comboBoxStatePatientInfoResult.Items.Add(state);
                }

                
                
                patientList = this.patientController.GetPatients();
                List<String> patientNames = new List<String>();
                foreach (Patient patient in patientList)
                {
                    patientNames.Add(patient.FullName);
                }
               // comboBoxPatient.DataSource = patientNames;
                comboBoxPatient.DataSource = patientList;

                
         
                doctorList = this.doctorController.GetDoctors();
                
                comboBoxPhysician.DataSource = doctorList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        public void ClearText()
        {
            this.textBoxRegisterFirstName.Clear();
            this.textBoxRegisterLastName.Clear();
            this.textBoxRegisterPhone.Clear();
            this.textBoxRegisterStreet.Clear();
            this.textBoxRegisterCity.Clear();
            this.dateTimePickerRegisterDOB.Value = DateTimePicker.MinimumDateTime;
            this.comboBoxState.SelectedIndex = -1;
            this.textBoxRegisterZipcode.Clear();
            this.labelAddMessage.Text = "";
        }

        private bool CheckFields()
        {
            labelAddMessage.ForeColor = Color.Red;
            if (this.textBoxRegisterFirstName.Text.Length == 0 || this.textBoxRegisterFirstName.Text == null)
            {
                labelAddMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (this.textBoxRegisterLastName.Text.Length == 0 || this.textBoxRegisterLastName.Text == null)
            {
                labelAddMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerRegisterDOB.Value == DateTimePicker.MinimumDateTime)
            {
                labelAddMessage.Text = "Please enter a Date of Birth";
                return false;
            }
            else if (this.textBoxRegisterPhone.Text.Length == 0 || this.textBoxRegisterPhone.Text == null)
            {
                labelAddMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (this.textBoxRegisterStreet.Text.Length == 0 || this.textBoxRegisterStreet.Text == null)
            {
                labelAddMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.textBoxRegisterCity.Text.Length == 0 || this.textBoxRegisterCity.Text == null)
            {
                labelAddMessage.Text = "Please enter a City";
                return false;
            }
            else if (this.comboBoxState.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a State";
                return false;
            }
            else if (this.textBoxRegisterZipcode.Text.Length == 0 || this.textBoxRegisterZipcode.Text == null)
            {
                labelAddMessage.Text = "Please enter a Zip Code";
                return false;
            }
            else
            {
                labelAddMessage.Text = "";
                return true;
            }
        }

        private void buttonRegisterSubmit_Click(object sender, EventArgs e)
        {
            this.CheckFields();

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
