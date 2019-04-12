using CS6232GroupProject.Controller;
using CS6232GroupProject.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlAdminMain : UserControl
    {
        private AddressController addressController;
        private NurseController nurseController;
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
            int phoneNumber;
            int.TryParse(this.textBoxPhoneRegisterNurse.Text, out phoneNumber);
            bool checkPhone = phoneNumber.GetType().Equals(typeof(int));
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
            else if (this.textBoxPhoneRegisterNurse.Text.Length == 0 || this.textBoxPhoneRegisterNurse.Text == null || checkPhone)
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
            this.dataGridViewNurseInfo.DataSource = null;
            this.dataGridViewNurseInfo.Rows.Clear();
            Nurse newNurse = new Nurse();

            newNurse.FName = this.textBoxFirstNameNurseInfo.Text;
            newNurse.LName = this.textBoxLastNameNurseInfo.Text;
            newNurse.DOB = this.dateTimePickerDOBNurseInfo.Value;

           /// this.dataGridViewNurseInfo.DataSource = this.nurseController.GetSearchNurseByNameDOB(newNurse);
        }

        private void buttonRegisterNurse_Click(object sender, EventArgs e)
        {
            Nurse newNurse = new Nurse();
            Address newAddress = new Address();
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

                    newAddress.Street = this.textBoxStreetRegisterNurse.Text;
                    newAddress.State = this.comboBoxStateRegisterNurse.Text;
                    newAddress.Zip = Convert.ToInt32(this.textBoxZipRegisterNurse.Text);

                 ///   nurseController.registerNurse(newNurse, newAddress);

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
        /// Populate DatGridView with search results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewNurseInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 11) { 
                panelNurseSearch.Visible = false;
                panelNurseInfoResults.Visible = true;
                linkLabelNurseInfoBack.Visible = true;

                nurseID = (int)this.dataGridViewNurseInfo.CurrentRow.Cells[0].Value;
                textBoxFirstNameNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[1].Value.ToString();
                textBoxLastNameNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerDOBNurseInfoResults.Value = Convert.ToDateTime(this.dataGridViewNurseInfo.CurrentRow.Cells[4].Value);
                textBoxSSNNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[5].Value.ToString();
                comboBoxGenderNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[6].Value.ToString();
                //textBoxPhoneNurseInfoResults.Text = this.dataGridViewNurseInfo.CurrentRow.Cells[7].Value.ToString();

                //addressID = (int)this.dataGridViewNurseInfo.CurrentRow.Cells[9].Value;
                textBoxStreetNurseInfoResults.Text = this.addressController.GetAddressByID(addressID).Street;
                comboBoxStateNurseInfoResults.Text = this.addressController.GetAddressByID(addressID).State;
                textBoxZipNurseInfoResults.Text = Convert.ToString(this.addressController.GetAddressByID(addressID).Zip);


                //if (this.dataGridViewNurseInfo.CurrentRow.Cells[10].Value.Equals("Active"))
                //{
                //    radioButtonNurseInfoResultsActive.Checked = true;
                //}
                //else if (this.dataGridViewNurseInfo.CurrentRow.Cells[10].Value.Equals("Inactive"))
                //{
                //    radioButtonNurseInfoResultsInactive.Checked = true;
                //}
            }
        }
    }
}
