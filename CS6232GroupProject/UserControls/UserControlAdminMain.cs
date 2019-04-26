﻿using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using System;
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
            SetComboBox();
            tabPageAdminReports.Enabled = false;
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
            this.textBoxPasswordNurseInfoResults.Clear();
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

            if (this.textBoxFirstNameRegisterNurse.Text.Length == 0 || this.textBoxFirstNameRegisterNurse.Text == null)
            {
                labelAddMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (this.textBoxLastNameRegisterNurse.Text.Length == 0 || this.textBoxLastNameRegisterNurse.Text == null)
            {
                labelAddMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerDOBRegisterNurse.Value >= DateTime.Now)
            {
                labelAddMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSNRegisterNurse.Text.Length < 9 || this.textBoxSSNRegisterNurse.Text.Length > 9 || this.textBoxSSNRegisterNurse.Text == null || !isSSNValid || this.nurseController.IsNurseSSNTaken(this.textBoxSSNRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a valid or non-taken 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderRegisterNurse.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a Gender";
                return false;
            }
            else if (this.textBoxPhoneRegisterNurse.Text.Length == 0 || this.textBoxPhoneRegisterNurse.Text == null || !isPhoneValid)
            {
                labelAddMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (this.textBoxStreetRegisterNurse.Text.Length == 0 || this.textBoxStreetRegisterNurse.Text == null)
            {
                labelAddMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxStateRegisterNurse.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a State";
                return false;
            }
            else if (this.textBoxZipRegisterNurse.Text.Length == 0 || this.textBoxZipRegisterNurse.Text == null || !int.TryParse(textBoxZipRegisterNurse.Text, out number) || !isZipValid)
            {
                labelAddMessage.Text = "Please enter a valid Zip Code";
                return false;
            }
            else if (this.textBoxUsernameRegisterNurse.Text.Length == 0 || this.textBoxUsernameRegisterNurse.Text == "" || this.loginContoller.CheckIfUsernameExists(this.textBoxUsernameRegisterNurse.Text))
            {
                labelAddMessage.Text = "Please enter a valid or non-taken Username";
                return false;
            }
            else if (this.textBoxPasswordRegisterNurse.Text.Length == 0 || this.textBoxPasswordRegisterNurse.Text == "")
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

            if (this.textBoxFirstNameNurseInfoResults.Text.Length == 0 || this.textBoxFirstNameNurseInfoResults.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a First Name";
                return false;
            }
            else if (this.textBoxLastNameNurseInfoResults.Text.Length == 0 || this.textBoxLastNameNurseInfoResults.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a Last Name";
                return false;
            }
            else if (this.dateTimePickerDOBNurseInfoResults.Value >= DateTime.Now)
            {
                labelAddUpdateMessage.Text = "Please enter a valid Date of Birth";
                return false;
            }
            else if (this.textBoxSSNNurseInfoResults.Text.Length < 9 || this.textBoxSSNNurseInfoResults.Text.Length > 9 || this.textBoxSSNNurseInfoResults.Text == null || !isSSNValid || this.nurseController.IsNurseSSNTaken(this.textBoxSSNNurseInfoResults.Text, nurseID))
            {
                labelAddUpdateMessage.Text = "Please enter a valid 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderNurseInfoResults.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a Gender";
                return false;
            }
            else if (this.textBoxPhoneNurseInfoResults.Text.Length == 0 || this.textBoxPhoneNurseInfoResults.Text == null || !isPhoneValid)
            {
                labelAddUpdateMessage.Text = "Please enter a Phone Number";
                return false;
            }
            else if (this.textBoxStreetNurseInfoResults.Text.Length == 0 || this.textBoxStreetNurseInfoResults.Text == null)
            {
                labelAddUpdateMessage.Text = "Please enter a Street Address";
                return false;
            }
            else if (this.comboBoxStateNurseInfoResults.SelectedIndex == -1)
            {
                labelAddUpdateMessage.Text = "Please select a State";
                return false;
            }
            else if (this.textBoxZipNurseInfoResults.Text.Length == 0 || this.textBoxZipNurseInfoResults.Text == null || !int.TryParse(textBoxZipNurseInfoResults.Text, out number) || !isZipValid)
            {
                labelAddUpdateMessage.Text = "Please enter a valid Zip Code";
                return false;
            }
            else if (this.textBoxUsernameNurseInfoResults.Text.Length == 0 || this.textBoxUsernameNurseInfoResults.Text == "" || this.loginContoller.CheckIfUsernameExists(this.textBoxUsernameNurseInfoResults.Text, nurseID))
            {
                labelAddUpdateMessage.Text = "Please enter a valid Username";
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
                    
                    if (this.comboBoxRegisterNurseActive.Text == "Active")
                    {
                        newNurse.Active = true;
                    }
                    else
                    {
                        newNurse.Active = false;
                    }
                    
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

                
                textBoxUsernameNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[10].Value.ToString();

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
                newNurse.Username = this.textBoxUsernameNurseInfoResults.Text;
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



                newLogin.Username = this.textBoxUsernameNurseInfoResults.Text;
                newLogin.Password = this.textBoxPasswordNurseInfoResults.Text;

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
            this.tabControlAdminMain.SelectedTab = tabPageAdminNurseInfo;
        }
    }
}
