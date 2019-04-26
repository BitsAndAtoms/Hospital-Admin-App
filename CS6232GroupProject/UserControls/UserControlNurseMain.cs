using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using CS6232GroupProject.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    /// <summary>
    /// This class creates the NurseMain UserControl object.
    /// </summary>
    public partial class UserControlNurseMain : UserControl
    {
        public static string patientName;
        public static int patientID { get; set; }
        private List<Doctor> doctorList;
        private List<Patient> patientList;
        private DoctorController doctorController;
        private PatientController patientController;
        private AppointmentController appointmentController;
        private AddressController addressController;
        private int addressID;

        /// <summary>
        /// Constructor
        /// </summary>
        public UserControlNurseMain()
        {
            InitializeComponent();
            this.doctorController = new DoctorController();
            this.patientController = new PatientController();
            this.appointmentController = new AppointmentController();
            this.addressController = new AddressController();
            SetComboBox();
            UpdatePatientAndDoctors();
        }

        /// <summary>
        /// Add's the states and gender to combobox
        /// </summary>
        private void SetComboBox()
        {
            try
            {
                foreach (string state in State.GetStates())
                {
                    this.comboBoxState.Items.Add(state);
                    this.comboBoxStatePatientInfoResult.Items.Add(state);
                }

                foreach (string gender in Gender.GetGender())
                {
                    this.comboBoxRegisterGender.Items.Add(gender);
                    this.comboBoxGenderPatientInfoResult.Items.Add(gender);
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void UpdatePatientAndDoctors()
        {
            try
            {
                patientList = this.patientController.GetPatients();
                //comboBoxPatient.DataSource = patientList;

                doctorList = this.doctorController.GetDoctors();
                comboBoxPhysician.DataSource = doctorList;

                //patientBindingSource.Clear();
                //patientBindingSource.Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Clear fields.
        /// </summary>
        public void ClearText()
        {
            this.textBoxRegisterFirstName.Clear();
            this.textBoxRegisterLastName.Clear();
            this.textBoxRegisterPhone.Clear();
            this.textBoxSSN.Clear();
            this.comboBoxRegisterGender.SelectedIndex = -1;
            this.textBoxRegisterStreet.Clear();
            this.dateTimePickerRegisterDOB.Value = DateTime.Now;
            this.comboBoxState.SelectedIndex = -1;
            this.textBoxRegisterZipcode.Clear();
            this.labelAddMessage.Text = "";
        }

        /// <summary>
        /// Chekck fields prior to register 
        /// </summary>
        /// <returns></returns>
        private bool CheckFieldsRegister()
        {
            labelAddMessage.ForeColor = Color.Red;

            int number;
            int.TryParse(this.textBoxSSN.Text, out number);
            bool checkNumber = number.GetType().Equals(typeof(int));

            string ssnPattern = @"^\d{9}|\d{3}-\d{2}-\d{4}$";
            bool isSSNValid = Regex.IsMatch(this.textBoxSSN.Text, ssnPattern);

            string phonePattern = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}$";
            bool isPhoneValid = Regex.IsMatch(this.textBoxRegisterPhone.Text, phonePattern);

            string zipPattern = @"^\d{5}(?:[-\s]\d{4})?$";
            bool isZipValid = Regex.IsMatch(this.textBoxRegisterZipcode.Text, zipPattern);

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
            else if (this.dateTimePickerRegisterDOB.Value >= DateTime.Now)
            {
                labelAddMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSN.Text.Length < 9 || this.textBoxSSN.Text.Length > 9 || this.textBoxSSN.Text == null || !isSSNValid || this.patientController.CheckIfPatientSSNExists(this.textBoxSSN.Text))
            {
                labelAddMessage.Text = "Please enter a valid 9 digit SSN";
                return false;
            }
            else if (this.comboBoxRegisterGender.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a Gender";
                return false;
            }
            else if (this.textBoxRegisterPhone.Text.Length == 0 || this.textBoxRegisterPhone.Text == null || !isPhoneValid)
            {
                labelAddMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (this.textBoxRegisterStreet.Text.Length == 0 || this.textBoxRegisterStreet.Text == null)
            {
                labelAddMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxState.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a State";
                return false;
            }
            else if (this.textBoxRegisterZipcode.Text.Length == 0 || this.textBoxRegisterZipcode.Text == null || !int.TryParse(textBoxRegisterZipcode.Text, out number) || !isZipValid)
            {
                labelAddMessage.Text = "Please enter a valid Zip Code";
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
            Patient newPatient = new Patient();
            Address newAddress = new Address();
            if (this.CheckFieldsRegister())
            {
                try
                {
                    newPatient.FName = this.textBoxRegisterFirstName.Text;
                    newPatient.LName = this.textBoxRegisterLastName.Text;
                    newPatient.DOB = this.dateTimePickerRegisterDOB.Value;
                    newPatient.SSN = this.textBoxSSN.Text;
                    newPatient.Phone = this.textBoxRegisterPhone.Text;
                    newPatient.Gender = this.comboBoxRegisterGender.Text;

                    newAddress.Street = this.textBoxRegisterStreet.Text;
                    newAddress.State = this.comboBoxState.Text;
                    newAddress.Zip = Convert.ToInt32(this.textBoxRegisterZipcode.Text);
                    patientController.registerPatient(newPatient, newAddress);
                    MessageBox.Show("Patient Registered", "Confirm");
                    this.ClearText();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid. \n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Activates click via button search in data grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            this.dataGridViewPatientInfo.DataSource = null;
            this.dataGridViewPatientInfo.Rows.Clear();
            Patient newPatient = new Patient();
           
             newPatient.FName = this.textBoxFirstName.Text;
             newPatient.LName = this.textBoxLastName.Text;
             newPatient.DOB = this.dateTimePickerDOB.Value;
            
                this.dataGridViewPatientInfo.DataSource = this.patientController.getPatientInformation(newPatient);
        }

        /// <summary>
        /// Populate Patient search results from datagrideview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                panelPatientSearch.Visible = false;
                panelPatientInfoResults.Visible = true;

                textBoxFirstNamePatientInfoResult.Text = this.dataGridViewPatientInfo.CurrentRow.Cells[1].Value.ToString();
                textBoxLastNamePatientInfoResult.Text = this.dataGridViewPatientInfo.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerDOBPatientInfoResult.Value = Convert.ToDateTime(this.dataGridViewPatientInfo.CurrentRow.Cells[3].Value);
                textBoxSSNPatientInfoResult.Text = this.dataGridViewPatientInfo.CurrentRow.Cells[4].Value.ToString();
                comboBoxGenderPatientInfoResult.Text = this.dataGridViewPatientInfo.CurrentRow.Cells[5].Value.ToString();
                textBoxPhonePatientInfoResult.Text = this.dataGridViewPatientInfo.CurrentRow.Cells[6].Value.ToString();

                addressID = (int)this.dataGridViewPatientInfo.CurrentRow.Cells[7].Value;
                Address patientAddress = this.addressController.GetAddressByID(addressID);
                textBoxStreetPatientInfoResult.Text = patientAddress.Street;
                comboBoxStatePatientInfoResult.Text = patientAddress.State;
                textBoxZipPatientInfoResult.Text = Convert.ToString(patientAddress.Zip);
                patientID = (int)this.dataGridViewPatientInfo.CurrentRow.Cells[0].Value;
            }
            if (e.ColumnIndex == 9)
            {

                patientID = (int)this.dataGridViewPatientInfo.CurrentRow.Cells[0].Value;
                string fName = this.dataGridViewPatientInfo.CurrentRow.Cells[1].Value.ToString();
                string lName = this.dataGridViewPatientInfo.CurrentRow.Cells[2].Value.ToString();
                patientName = fName + " " + lName;

                if (appointmentController.CheckIfAppointmentExists(patientID))
                {
                    FormPatientRecords formPatientRecords = new FormPatientRecords();
                    formPatientRecords.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No appointments found for " + patientName + ". \nPlease book an appointment to continue.", "Error - No Appointment Found");
                }
            }
            if (e.ColumnIndex == 10)
            {
                panelPatientSearch.Visible = false;
                panelPatientBookAppointment.Visible = true;
                labelPatientInformation.Visible = false;
                patientID = (int)this.dataGridViewPatientInfo.CurrentRow.Cells[0].Value;
            }
            
        }

        /// <summary>
        /// Links to patients info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelPatientInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPatientSearch.Visible = true;
            panelPatientInfoResults.Visible = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "FormPatientRecords")
                {
                    form.Close();
                    break;
                }
            }
        }

        private void linkLabelBookBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPatientSearch.Visible = true;
            panelPatientBookAppointment.Visible = false;
            labelPatientInformation.Visible = true;
        }

        /// <summary>
        /// Gets doctor info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// check the field for booking approinments
        /// </summary>
        /// <returns></returns>
        private bool CheckBookApointmentFields()
        {
            if (textBoxSummary.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method to book appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBookSubmit_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
                newPatient.PatientID = patientID;
                if (CheckBookApointmentFields())
            {
                try
                {
                    var reason = textBoxSummary.Text;
                    Appointment appointment = new Appointment();
                    appointment.PatientID = patientID;
                    appointment.DoctorID = Convert.ToInt32(comboBoxPhysician.SelectedValue);
                    appointment.AppointmentDateTime = dateTimePickerBookAppointment.Value.Date + dateTimePickerBookAppointmentTime.Value.TimeOfDay;
                    appointment.Reasons = reason;

                    if (this.appointmentController.CheckAvailability(appointment))
                    {
                        this.appointmentController.CreateAppointment(appointment);
                        textBoxSummary.Text = "";
                        MessageBox.Show("Appointment Booked!");
                        UpdatePatientAndDoctors();
                    }
                    else
                    {
                        MessageBox.Show("That Date and Time isn't available", "Date or Time Not Available");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an issue creating the Appointment!" + ex.Message, "Appointment Creation Error!");
                }
            }
            else
            {
                MessageBox.Show("Please enter a Reason", "Missing Information!");
            }
        }

        private void doctorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks update fields are empty or null, correct SSN length.
        /// </summary>
        /// <returns></returns>
        private bool CheckFieldsUpdate()
        {
            labelAddUpdateMessage.ForeColor = Color.Red;

            int number;
            int.TryParse(this.textBoxSSN.Text, out number);

            string ssnPattern = @"^\d{9}|\d{3}-\d{2}-\d{4}$";
            bool isSSNValid = Regex.IsMatch(this.textBoxSSNPatientInfoResult.Text, ssnPattern);

            string phonePattern = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}$";
            bool isPhoneValid = Regex.IsMatch(this.textBoxPhonePatientInfoResult.Text, phonePattern);

            string zipPattern = @"^\d{5}(?:[-\s]\d{4})?$";
            bool isZipValid = Regex.IsMatch(this.textBoxZipPatientInfoResult.Text, zipPattern);

            if (this.textBoxFirstNamePatientInfoResult.Text.Length == 0 || this.textBoxFirstNamePatientInfoResult.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (this.textBoxLastNamePatientInfoResult.Text.Length == 0 || this.textBoxLastNamePatientInfoResult.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerDOBPatientInfoResult.Value >= DateTime.Now)
            {
                labelAddUpdateMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSNPatientInfoResult.Text.Length < 9 || this.textBoxSSNPatientInfoResult.Text.Length > 9 || this.textBoxSSNPatientInfoResult.Text == null || !isSSNValid || this.patientController.CheckIfPatientSSNExists(this.textBoxSSNPatientInfoResult.Text, patientID))
            {
                labelAddUpdateMessage.Text = "Please enter a valid 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderPatientInfoResult.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a Gender";
                return false;
            }
            else if (this.textBoxPhonePatientInfoResult.Text.Length == 0 || this.textBoxPhonePatientInfoResult.Text == null || !isPhoneValid)
            {
                labelAddUpdateMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (this.textBoxStreetPatientInfoResult.Text.Length == 0 || this.textBoxStreetPatientInfoResult.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxStatePatientInfoResult.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a State";
                return false;
            }
            else if (this.textBoxZipPatientInfoResult.Text.Length == 0 || this.textBoxZipPatientInfoResult.Text == null || !int.TryParse(textBoxZipPatientInfoResult.Text, out number) || !isZipValid)
            {
                labelAddUpdateMessage.Text = "Please enter a valid Zip Code";
                return false;
            }
            else
            {
                labelAddUpdateMessage.Text = "";
                return true;
            }
        }

        /// <summary>
        /// Updates the patient info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPatientInfoResultUpdate_Click(object sender, EventArgs e)
        {
            Patient newPatient = new Patient();
            Address newAddress = new Address();
            if (this.CheckFieldsUpdate())
            {
                newPatient.PatientID = patientID;
                newPatient.FName = this.textBoxFirstNamePatientInfoResult.Text;
                newPatient.LName = this.textBoxLastNamePatientInfoResult.Text;
                newPatient.SSN = this.textBoxSSNPatientInfoResult.Text;
                newPatient.Gender = this.comboBoxGenderPatientInfoResult.Text;
                newPatient.Phone = this.textBoxPhonePatientInfoResult.Text;
                newPatient.DOB = this.dateTimePickerDOBPatientInfoResult.Value;
                newAddress.AddressID = this.addressID;
                newAddress.Street = this.textBoxStreetPatientInfoResult.Text;
                newAddress.Zip = Convert.ToInt32(this.textBoxZipPatientInfoResult.Text);
                newAddress.State = this.comboBoxStatePatientInfoResult.Text;

                try
                {
                    patientController.updatePatient(newPatient, newAddress);

                    MessageBox.Show("Patient Updated", "Confirm");
                    this.ClearText();
                    this.dataGridViewPatientInfo.DataSource = null;
                    this.dataGridViewPatientInfo.DataSource = this.patientController.getPatientInformation(newPatient);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid. \n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Tab group selection changed function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlNurseMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientList = this.patientController.GetPatients();
            //comboBoxPatient.DataSource = patientList;

            doctorList = this.doctorController.GetDoctors();
            comboBoxPhysician.DataSource = doctorList;
        }

        private void linkLabelDeletePatient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Patient newPatient = new Patient();
            Address newAddress = new Address();
            if (this.CheckFieldsUpdate())
            {
                DialogResult confirmDelete = MessageBox.Show("Patient will be removed from database.\nContinue?", "Delete Patient Warning", MessageBoxButtons.YesNo);
                if(confirmDelete == DialogResult.Yes)
                {
                    newPatient.PatientID = patientID;
                    newPatient.FName = this.textBoxFirstNamePatientInfoResult.Text;
                    newPatient.LName = this.textBoxLastNamePatientInfoResult.Text;
                    newPatient.SSN = this.textBoxSSNPatientInfoResult.Text;
                    newPatient.Gender = this.comboBoxGenderPatientInfoResult.Text;
                    newPatient.Phone = this.textBoxPhonePatientInfoResult.Text;
                    newPatient.DOB = this.dateTimePickerDOBPatientInfoResult.Value;
                    newAddress.AddressID = this.addressID;
                    newAddress.Street = this.textBoxStreetPatientInfoResult.Text;
                    newAddress.Zip = Convert.ToInt32(this.textBoxZipPatientInfoResult.Text);
                    newAddress.State = this.comboBoxStatePatientInfoResult.Text;
                    try
                    {
                        patientController.deletePatient(newPatient, newAddress);

                        MessageBox.Show("Patient deleted", "Confirm");
                        panelPatientSearch.Visible = true;
                        panelPatientInfoResults.Visible = false;

                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.Name == "FormPatientRecords")
                            {
                                form.Close();
                                break;
                            }
                        }
                        this.ClearText();
                        this.dataGridViewPatientInfo.DataSource = null;
                        this.dataGridViewPatientInfo.DataSource = this.patientController.getPatientInformation(newPatient);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Patient with appointments cannot be deleted.\n",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (confirmDelete == DialogResult.No)
                {
                    return;
                }
            }
               
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.ClearSearch();
        }

        private void ClearSearch()
        {
            this.textBoxFirstName.Clear();
            this.textBoxLastName.Clear();
            this.dateTimePickerDOB.Value = DateTime.Now;
            this.dataGridViewPatientInfo.DataSource = null;
            this.dataGridViewPatientInfo.Rows.Clear();
        }

        private void UserControlNurseMain_Leave(object sender, EventArgs e)
        {
            this.ClearSearch();
            this.ClearText();
            panelPatientSearch.Visible = true;
            panelPatientInfoResults.Visible = false;
            this.tabControlNurseMain.SelectedTab = tabPageNursePatientInformation;
        }
    }
}
