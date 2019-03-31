using CS6232GroupProject.Controller;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormLogin : Form
    {
        private FormNurseMain nurseMain;
        private readonly LoginController newLoginController;
        /// <summary>
        /// constructor of login form
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            this.nurseMain = new FormNurseMain(this);
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
<<<<<<< HEAD
            List<string> newNameAndRole = this.newLoginController.GETUserNameAndRole(this.textBoxUsername.Text);
            if ((this.newLoginController.DoCheckLogin(this.textBoxPassword.Text,this.textBoxUsername.Text) && (newNameAndRole.Count>1)) && newNameAndRole[0].Equals("Nurse"))
            {
                this.Hide();
                this.nurseMain.setUserNameDisplay(newNameAndRole[0]+ " " + newNameAndRole[1]);
                //this.nurseMain.ShowDialog();
                this.nurseMain.Show();
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buttonLogin_Click(this, new System.EventArgs());
            }
        }
    }
}
