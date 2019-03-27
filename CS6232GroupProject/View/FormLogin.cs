using CS6232GroupProject.Controller;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormLogin : Form
    {
        private FormNurseMain nurseMain;
        private LoginController newLoginController;
        /// <summary>
        /// constructor of login form
        /// </summary>
        public FormLogin()
        {
            InitializeComponent();
            this.nurseMain = new FormNurseMain();
            this.newLoginController = new LoginController();
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
            if (this.newLoginController.DoCheckLogin(this.textBoxPassword.Text,this.textBoxUsername.Text))
            {
                this.Hide();
                ///this.nurseMain.setUserNameDisplay(this.userName.Text);
                this.nurseMain.ShowDialog();
                this.Show();
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
    }
}
