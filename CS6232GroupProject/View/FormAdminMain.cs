using System;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    /// <summary>
    /// This class creates a Form for the MainAdmin UserControl.
    /// </summary>
    public partial class FormAdminMain : Form
    {
        private FormLogin loginForm;
        /// <summary>
        /// This constructs the MainAdmin Form.
        /// </summary>
        /// <param name="loginForm"></param>
        public FormAdminMain(FormLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.FormClosed += (s, ev) => Application.Exit();
        }

        /// <summary>
        /// Set username display
        /// </summary>
        /// <param name="userName"></param>
        public void setUserNameDisplay(string userName)
        {
            this.labelName.Text = "Welcome " + userName + "!";
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loginForm.Show();
            this.Hide();
        }

        private void userControlAdminMain1_Load(object sender, EventArgs e)
        {

        }
    }
}
