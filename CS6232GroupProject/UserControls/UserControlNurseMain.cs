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
    }
}
