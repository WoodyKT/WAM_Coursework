using System;
using System.Windows.Forms;
using WAM_Coursework.Forms;
using WAM_Coursework.Users;

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
            LoginForm login = new LoginForm(UserConstants.ReviewerRole);
            login.ShowDialog();
        }

        private void SpeakerClick(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm(UserConstants.SpeakerRole);
            login.ShowDialog();
        }
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

        private void ManagerClick(object sender, EventArgs e)
        {

        }
    }
}
