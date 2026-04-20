using System;
using System.Windows.Forms;
using WAM_Coursework.Forms;

namespace WAM_Coursework
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ReviewerClick(object sender, EventArgs e)
        {
            var f = new SpeakerMainForm();
            f.Show();
            this.Hide();
        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }
    }
}
