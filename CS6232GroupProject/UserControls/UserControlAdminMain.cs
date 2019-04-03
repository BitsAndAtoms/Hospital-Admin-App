using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlAdminMain : UserControl
    {
        public UserControlAdminMain()
        {
            InitializeComponent();
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
                    this.comboBoxNurseInfoResults.Items.Add(gender);
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
            this.labelAddMessage.Text = "";
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
            bool checkNumber = number.GetType().Equals(typeof(int));
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
            else if (this.textBoxSSNRegisterNurse.Text.Length < 9 || this.textBoxSSNRegisterNurse.Text == null || !checkNumber)
            {
                labelAddMessage.Text = "Please enter a valid 9 digit SSN";
                return false;
            }
            else if (this.comboBoxGenderRegisterNurse.SelectedIndex == -1)
            {
                labelAddMessage.Text = "Please select a Gender";
                return false;
            }
            else if (this.textBoxPhoneRegisterNurse.Text.Length == 0 || this.textBoxPhoneRegisterNurse.Text == null)
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
            else if (this.textBoxZipRegisterNurse.Text.Length == 0 || this.textBoxZipRegisterNurse.Text == null || !int.TryParse(textBoxZipRegisterNurse.Text, out number))
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

        private void linkLabelNurseInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelNurseSearch.Visible = true;
            panelNurseInfoResults.Visible = false;
            linkLabelNurseInfoBack.Visible = false;
        }

        private void buttonNurseInfoSearch_Click(object sender, EventArgs e)
        {
            panelNurseSearch.Visible = false;
            panelNurseInfoResults.Visible = true;
            linkLabelNurseInfoBack.Visible = true;
        }

        private void buttonRegisterNurse_Click(object sender, EventArgs e)
        {
            if (this.CheckFieldsRegister())
            {
                try
                {
                    this.ClearText();
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
