using CS6232GroupProject.UserControls;
using System;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    /// <summary>
    /// This class creates a FormNurseMain Form object.
    /// </summary>
    public partial class FormNurseMain : Form
    {
        private FormLogin loginForm;
        /// <summary>
        /// This constructs the NurseMain Form object.
        /// </summary>
        /// <param name="loginForm"></param>
        public FormNurseMain(FormLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.FormClosed += (s, ev) => Application.Exit();
        }

        ///// <summary>
        ///// gracefully exits the application in case of cancel from top of GUI
        ///// </summary>
        private void FormNurseMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                { Application.Exit(); } 
        }

        ///// <summary>
        ///// set user name display in loadIncident Tab
        ///// </summary>
        public void setUserNameDisplay(string userName)
        {
            this.labelName.Text = "Welcome " + userName + "!";
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loginForm.Show();
            this.Hide();
        }

    }
}
