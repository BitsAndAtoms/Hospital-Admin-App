using CS6232GroupProject.Model;
using System.Windows.Forms;

namespace CS6232GroupProject.UserControls
{
    public partial class UserControlNurseMain : UserControl
    {
        public UserControlNurseMain()
        {
            InitializeComponent();
            SetComboBox();
        }

        private void SetComboBox()
        {
            foreach (string state in State.GetStates())
            {
                this.comboBoxState.Items.Add(state);
            }
            
        }

        private void buttonRegisterSubmit_Click(object sender, System.EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, System.EventArgs e)
        {
            panelPatientInfoResults.Visible = true;
            linkLabelPatientInfoBack.Visible = true;
            /// when selected and conditions approved, Patient Info results panel and back button should then be visible
        }

        private void linkLabelPatientInfoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPatientInfoResults.Visible = false;
            linkLabelPatientInfoBack.Visible = false;
            /// 
        }
    }
}
