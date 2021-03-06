﻿using HospitalAdminApp.Controller;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalAdminApp.View
{
    /// <summary>
    /// This class creates a FormLogin object.
    /// </summary>
    public partial class FormLogin : Form
    {
        private FormNurseMain nurseMain;
        private FormAdminMain adminMain;
        private readonly LoginController newLoginController;
        public static int NurseID {get; set;}
        public static int AdminID { get; set; }

        /// <summary>
        /// constructor of login form
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            this.nurseMain = new FormNurseMain(this);
            this.adminMain = new FormAdminMain(this);
            this.newLoginController = new LoginController();
            this.FormClosed += (s, ev) => Application.Exit();
        }

        /// <summary>
        /// gracefully exits the application on clicking cancel button at top
        /// </summary>
        private void ExitForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///checks the user name password combination
        ///routes to main form if correct
        ///otherwise displays error message
        /// </summary>
        /// <param name="sender">is the event handler object</param>
        /// <param name="e">is the event arg</param>

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {

            List<string> newNameAndRole = this.newLoginController.GETUserNameAndRole(this.textBoxUsername.Text);
            if ((this.newLoginController.DoCheckLogin(this.textBoxPassword.Text,this.textBoxUsername.Text) && (newNameAndRole.Count>1)) && newNameAndRole[0].Equals("Nurse"))
            {
                this.Hide();

                this.nurseMain.setUserNameDisplay(newNameAndRole[0]+ " " + newNameAndRole[1]);
                NurseID = Convert.ToInt32(newNameAndRole[3]);
                this.nurseMain.Show();
                this.textBoxUsername.Text = "";
                this.textBoxPassword.Text = "";
                
            }
            else if ((this.newLoginController.DoCheckLogin(this.textBoxPassword.Text, this.textBoxUsername.Text) && (newNameAndRole.Count > 1)) && newNameAndRole[0].Equals("Admin"))
            {
                this.Hide();
                this.adminMain.setUserNameDisplay(newNameAndRole[0] + " " + newNameAndRole[1]);
                AdminID = Convert.ToInt32(newNameAndRole[3]);
                this.adminMain.Show();
                this.textBoxUsername.Text = "";
                this.textBoxPassword.Text = "";
            }
            else
            {
                this.labelErrorMessage.Text = "invalid username/password";
            }
        }

        /// <summary>
        /// resets error message if user changes input field
        /// </summary>
        private void userNameChanged(object sender, System.EventArgs e)
        {
            this.labelErrorMessage.Text = "";
        }

        /// <summary>
        /// error message is removed if user edits the password field
        /// </summary>
        /// <param name="sender"> is the event handler object</param>
        /// <param name="e">e is the event arg</param>
        private void passwordChanged(object sender, System.EventArgs e)
        {
            this.labelErrorMessage.Text = "";
        }

        /// <summary>
        /// activates submit upon pressing enter with password textbox on focus
        /// </summary>
        /// <param name="sender">is the event handler object</param>
        /// <param name="e">e is the event arg</param>
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonLogin_Click(this, new System.EventArgs());
            }
        }
    }
}
