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
            Hide();
            LoginForm login = new LoginForm(UserConstants.ReviewerRole);
            login.ShowDialog();
            Show();
        }

        private void SpeakerClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm(UserConstants.SpeakerRole);
            login.ShowDialog();
            Show();

        }

        private void ManagerClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm(UserConstants.ManagerRole);
            login.ShowDialog();
            Show();
        }
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }

      
    }
}
