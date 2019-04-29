using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    /// <summary>
    /// This class creates the UserControl Object for AdminMain.
    /// </summary>
    public partial class UserControlAdminMain : UserControl
    {
        private AddressController addressController;
        private NurseController nurseController;
        private LoginController loginContoller;
        private LabTestResultsController labContoller;
        private int addressID;
        public static int nurseID { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public UserControlAdminMain()
        {
            InitializeComponent();
            this.addressController = new AddressController();
            this.nurseController = new NurseController();
            this.loginContoller = new LoginController();
            this.labContoller = new LabTestResultsController();
            SetComboBox();
        }

        /// <summary>
        /// Populate state and gender combo boxes with options.
        /// </summary>
        private void SetComboBox()
        {
            try
            {
                foreach (string state in State.GetStates())
                {
                    this.comboBoxStateRegisterNurse.Items.Add(state);
                    this.comboBoxStateNurseInfoResults.Items.Add(state);
                }

                foreach (string gender in Gender.GetGender())
                {
                    this.comboBoxGenderRegisterNurse.Items.Add(gender);
                    this.comboBoxGenderNurseInfoResults.Items.Add(gender);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        /// <summary>
        /// Clear RegisterNurse fields.
        /// </summary>
        public void ClearText()
        {
            this.textBoxFirstNameRegisterNurse.Clear();
            this.textBoxLastNameRegisterNurse.Clear();
            this.textBoxPhoneRegisterNurse.Clear();
            this.textBoxSSNRegisterNurse.Clear();
            this.comboBoxGenderRegisterNurse.SelectedIndex = -1;
            this.textBoxStreetRegisterNurse.Clear();
            this.dateTimePickerDOBRegisterNurse.Value = DateTime.Now;
            this.comboBoxStateRegisterNurse.SelectedIndex = -1;
            this.textBoxZipRegisterNurse.Clear();
            this.textBoxUsernameRegisterNurse.Clear();
            this.textBoxPasswordRegisterNurse.Clear();
            this.labelAddMessage.Text = "";
            this.comboBoxRegisterNurseActive.SelectedIndex = -1;
            this.textBoxPasswordNurse.Clear();
        }

        /// <summary>
        /// Check Registration Fields
        /// </summary>
        /// <returns></returns>
        private bool CheckFieldsRegister()
        {
            labelAddMessage.ForeColor = Color.Red;

            int number;
            int.TryParse(this.textBoxSSNRegisterNurse.Text, out number);

            string ssnPattern = @"^\d{9}|\d{3}-\d{2}-\d{4}$";
            bool isSSNValid = Regex.IsMatch(this.textBoxSSNRegisterNurse.Text, ssnPattern);

            string phonePattern = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}$";
            bool isPhoneValid = Regex.IsMatch(this.textBoxPhoneRegisterNurse.Text, phonePattern);

            string zipPattern = @"^\d{5}(?:[-\s]\d{4})?$";
            bool isZipValid = Regex.IsMatch(this.textBoxZipRegisterNurse.Text, zipPattern);

            if (String.IsNullOrEmpty(this.textBoxFirstNameRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxLastNameRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerDOBRegisterNurse.Value >= DateTime.Now)
            {
                labelAddMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSNRegisterNurse.Text.Length < 9 || this.textBoxSSNRegisterNurse.Text.Length > 9 || String.IsNullOrEmpty(this.textBoxSSNRegisterNurse.Text) || !isSSNValid || this.nurseController.IsNurseSSNTaken(this.textBoxSSNRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a valid or non-taken 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderRegisterNurse.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a Gender";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxPhoneRegisterNurse.Text)|| !isPhoneValid)
            {
                labelAddMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxStreetRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxStateRegisterNurse.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a State";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxZipRegisterNurse.Text) || !int.TryParse(textBoxZipRegisterNurse.Text, out number) || !isZipValid)
            {
                labelAddMessage.Text = "Please enter a valid Zip Code";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxUsernameRegisterNurse.Text) || this.loginContoller.CheckIfUsernameExists(this.textBoxUsernameRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a valid, unique Username";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxPasswordRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a valid Password";
                return false;
            }
            else
            {
                labelAddMessage.Text = "";
                return true;
            }
        }

        /// <summary>
        /// Validate fields in update nurse
        /// </summary>
        /// <returns></returns>
        private bool CheckFieldsUpdate()
        {
            labelAddUpdateMessage.ForeColor = Color.Red;
            int number;
            int.TryParse(this.textBoxSSNNurseInfoResults.Text, out number);

            string ssnPattern = @"^\d{9}|\d{3}-\d{2}-\d{4}$";
            bool isSSNValid = Regex.IsMatch(this.textBoxSSNNurseInfoResults.Text, ssnPattern);

            string phonePattern = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}$";
            bool isPhoneValid = Regex.IsMatch(this.textBoxPhoneNurseInfoResults.Text, phonePattern);

            string zipPattern = @"^\d{5}(?:[-\s]\d{4})?$";
            bool isZipValid = Regex.IsMatch(this.textBoxZipNurseInfoResults.Text, zipPattern);

            if (String.IsNullOrEmpty(this.textBoxFirstNameNurseInfoResults.Text))
            {
                labelAddUpdateMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxLastNameNurseInfoResults.Text))
            {
                labelAddUpdateMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerDOBNurseInfoResults.Value >= DateTime.Now)
            {
                labelAddUpdateMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSNNurseInfoResults.Text.Length < 9 || this.textBoxSSNNurseInfoResults.Text.Length > 9 || String.IsNullOrEmpty(this.textBoxSSNNurseInfoResults.Text) || !isSSNValid || this.nurseController.IsNurseSSNTaken(this.textBoxSSNNurseInfoResults.Text, nurseID))
            {
                labelAddUpdateMessage.Text = "Please enter a valid 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderNurseInfoResults.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a Gender";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxPhoneNurseInfoResults.Text) || !isPhoneValid)
            {
                labelAddUpdateMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxStreetNurseInfoResults.Text))
            {
                labelAddUpdateMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxStateNurseInfoResults.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a State";
                return false;
            }
            else if (String.IsNullOrEmpty(this.textBoxZipNurseInfoResults.Text) || !int.TryParse(textBoxZipNurseInfoResults.Text, out number) || !isZipValid)
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
        /// Back button, back to search
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelNurseInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelNurseSearch.Visible = true;
            panelNurseInfoResults.Visible = false;
            labelNurseInformation.Text = "Search Nurse Information";
        }

        /// <summary>
        /// Search for and display nurse information in datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNurseInfoSearch_Click(object sender, EventArgs e)
        {
            this.dataGridViewNurseInfo.DataSource = null;
            this.dataGridViewNurseInfo.Rows.Clear();
            Nurse newNurse = new Nurse();

            newNurse.FName = this.textBoxFirstNameNurseInfo.Text;
            newNurse.LName = this.textBoxLastNameNurseInfo.Text;
            newNurse.DOB = this.dateTimePickerDOBNurseInfo.Value;

            this.dataGridViewNurseInfo.DataSource = this.nurseController.GetSearchNurseByNameDOB(newNurse);
        }

        /// <summary>
        /// Register new nurse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegisterNurse_Click(object sender, EventArgs e)
        {
            Nurse newNurse = new Nurse();
            Address newAddress = new Address();
            Login newLogin = new Login();

            if (this.CheckFieldsRegister())
            {
                try
                {
                    newNurse.FName = this.textBoxFirstNameRegisterNurse.Text;
                    newNurse.LName = this.textBoxLastNameRegisterNurse.Text;
                    newNurse.DOB = this.dateTimePickerDOBRegisterNurse.Value;
                    newNurse.SSN = this.textBoxSSNRegisterNurse.Text;
                    newNurse.Phone = this.textBoxPhoneRegisterNurse.Text;
                    newNurse.Gender = this.comboBoxGenderRegisterNurse.Text;
                    newNurse.Username = this.textBoxUsernameRegisterNurse.Text;
                    this.comboBoxRegisterNurseActive.Text = "Active";
                    newNurse.Active = true;

                    newAddress.Street = this.textBoxStreetRegisterNurse.Text;
                    newAddress.State = this.comboBoxStateRegisterNurse.Text;
                    newAddress.Zip = Convert.ToInt32(this.textBoxZipRegisterNurse.Text);

                    newLogin.Username = this.textBoxUsernameRegisterNurse.Text;
                    newLogin.Password = this.textBoxPasswordRegisterNurse.Text;

                    nurseController.registerNurse(newNurse, newAddress, newLogin);

                    MessageBox.Show("Nurse Registered", "Confirm");
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
        /// Populate DatGridView with search results, interact with datagridview buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewNurseInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11) { 
                panelNurseSearch.Visible = false;
                panelNurseInfoResults.Visible = true;

                labelNurseInformation.Text = "Nurse Information";

                textBoxFirstNameNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[1].Value.ToString();
                textBoxLastNameNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerDOBNurseInfoResults.Value = Convert.ToDateTime(this.dataGridViewNurseInfo.CurrentRow.Cells[4].Value);
                textBoxSSNNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[5].Value.ToString();
                comboBoxGenderNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[6].Value.ToString();
                textBoxPhoneNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[7].Value.ToString();

                addressID = (int)this.dataGridViewNurseInfo.CurrentRow.Cells[8].Value;
                textBoxStreetNurseInfoResults.Text = this.addressController.GetAddressByID(addressID).Street;
                comboBoxStateNurseInfoResults.Text = this.addressController.GetAddressByID(addressID).State;
                textBoxZipNurseInfoResults.Text = Convert.ToString(this.addressController.GetAddressByID(addressID).Zip);

                if (this.dataGridViewNurseInfo.CurrentRow.Cells[9].Value.Equals(true))
                {
                    comboBoxNurseInfoResultsActive.Text = "Active";
                }
                else
                {
                    comboBoxNurseInfoResultsActive.Text = "Inactive";
                }
                nurseID = (int)this.dataGridViewNurseInfo.CurrentRow.Cells[0].Value;
            }
            if (e.ColumnIndex == 12)
            {
                panelNurseSearch.Visible = false;
                panelLogin.Visible = true;

                labelNurseInformation.Text = "Nurse Login Information";

                textBoxUsernameNurse.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[10].Value.ToString();
                nurseID = (int)this.dataGridViewNurseInfo.CurrentRow.Cells[0].Value;
            }
        }

        /// <summary>
        /// Update nurse information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNurseInfoResultsUpdate_Click(object sender, EventArgs e)
        {
            Nurse newNurse= new Nurse();
            Address newAddress = new Address();
            Login newLogin = new Login();
            
            if (this.CheckFieldsUpdate())
            {
                newNurse.NurseID = nurseID;
                newNurse.FName = this.textBoxFirstNameNurseInfoResults.Text;
                newNurse.LName = this.textBoxLastNameNurseInfoResults.Text;

                newNurse.SSN = this.textBoxSSNNurseInfoResults.Text;
                newNurse.Gender = this.comboBoxGenderNurseInfoResults.Text;
                newNurse.Phone = this.textBoxPhoneNurseInfoResults.Text;
                newNurse.DOB = this.dateTimePickerDOBNurseInfoResults.Value;
                if (this.comboBoxNurseInfoResultsActive.Text == "Active")
                {
                    newNurse.Active = true;
                }
                else
                {
                    newNurse.Active = false;
                }

                newAddress.AddressID = this.addressID;
                newAddress.Street = this.textBoxStreetNurseInfoResults.Text;
                newAddress.Zip = Convert.ToInt32(this.textBoxZipNurseInfoResults.Text);
                newAddress.State = this.comboBoxStateNurseInfoResults.Text;

                try
                {
                    nurseController.updateNurse(newNurse, newAddress, newLogin);

                    MessageBox.Show("Nurse Updated", "Confirm");
                    this.ClearText();
                    this.dataGridViewNurseInfo.DataSource = null;
                    this.dataGridViewNurseInfo.DataSource = this.nurseController.GetSearchNurseByNameDOB(newNurse);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid. \n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void buttonNurseInfoClear_Click(object sender, EventArgs e)
        {
            this.ClearNurseSearch();
        }

        private void ClearNurseSearch()
        {
            this.textBoxFirstNameNurseInfo.Clear();
            this.textBoxLastNameNurseInfo.Clear();
            this.dateTimePickerDOBNurseInfo.Value = DateTime.Now;
            this.dataGridViewNurseInfo.DataSource = null;
            this.dataGridViewNurseInfo.Rows.Clear();
        }

        private void UserControlAdminMain_Leave(object sender, EventArgs e)
        {
            this.ClearNurseSearch();
            this.ClearText();
            panelNurseSearch.Visible = true;
            panelNurseInfoResults.Visible = false;
            panelLogin.Visible = false;
            this.tabControlAdminMain.SelectedTab = tabPageAdminNurseInfo;
        }

        private void buttonReportsSubmit_Click(object sender, EventArgs e)
        {
            this.reportViewer.Visible = true;
            this.reportViewer.LocalReport.DataSources.Clear();
            DataTable yourDataTable = this.labContoller.GetLabTestResultStatiscitsForReportController(this.dateTimePickerReportsStartDate.Value, this.dateTimePickerReportsEndDate.Value);
            Microsoft.Reporting.WinForms.ReportDataSource DataSet1 = new Microsoft.Reporting.WinForms.ReportDataSource( "DataSet1", yourDataTable);
            this.reportViewer.LocalReport.DataSources.Add(DataSet1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Namespace.ClinicReport.rdlc";
            this.reportViewer.RefreshReport();

        }


        private void linkLabelLoginBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelNurseSearch.Visible = true;
            panelLogin.Visible = false;
            labelNurseInformation.Text = "Search Nurse Information";
        }

        private void buttonNurseLoginInfo_Click(object sender, EventArgs e)
        {
            Nurse newNurse = new Nurse();
            Address newAddress = new Address();
            Login newLogin = new Login();

            newNurse.NurseID = nurseID;
            newNurse.Username = this.textBoxUsernameNurse.Text;
            newLogin.Username = this.textBoxUsernameNurse.Text;
            newLogin.Password = this.textBoxPasswordNurse.Text;
            if (String.IsNullOrEmpty(this.textBoxPasswordNurse.Text))
            {
                //Call the update username only.
                try
                {
                    this.nurseController.UpdateNurseUsername(newNurse, newLogin);

                    MessageBox.Show("Nurse Username Information Updated", "Confirm");
                    this.dataGridViewNurseInfo.DataSource = null;
                    this.dataGridViewNurseInfo.DataSource = this.nurseController.GetSearchNurseByNameDOB(newNurse);
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid. \n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //call update username and password
                try
                {
                    this.nurseController.UpdateNurseUsernameAndPassword(newNurse, newLogin);

                    MessageBox.Show("Nurse Username and Password Information Updated", "Confirm");
                    this.ClearText();
                    this.dataGridViewNurseInfo.DataSource = null;
                    this.dataGridViewNurseInfo.DataSource = this.nurseController.GetSearchNurseByNameDOB(newNurse);
                }

                catch (SqlException ex)
                {
                    MessageBox.Show("Invalid. \n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
