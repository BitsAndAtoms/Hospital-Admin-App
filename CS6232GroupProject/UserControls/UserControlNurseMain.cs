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
        /// <summary>
        /// This private method populates the States ComboBox.
        /// </summary>
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
