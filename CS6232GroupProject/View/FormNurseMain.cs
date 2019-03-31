using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormNurseMain : Form
    {
        private FormLogin loginForm;
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
            this.labelName.Text = "Welcome! " + userName;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.loginForm.Show();
            this.Hide();
        }

        private void userControlNurseMain1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
