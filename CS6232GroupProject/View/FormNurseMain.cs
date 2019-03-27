using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormNurseMain : Form
    {

        public FormNurseMain()
        {
            InitializeComponent();
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
    }
}
