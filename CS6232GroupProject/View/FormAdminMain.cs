using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232GroupProject.View
{
    public partial class FormAdminMain : Form
    {
        private FormLogin loginForm;
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
    }
}
