using System;
using System.Windows.Forms;
using WAM_Coursework.Forms;
using WAM_Coursework.Users;

namespace WAM_Coursework
{
    /// <summary>
    /// The main form of the application that displays upon startup. 
    /// Prompts user to select user type or create an account.
    /// </summary>
    public partial class WelcomeForm : Form
    {
        /// <summary>
        /// WelcomeForm constructor.
        /// </summary>
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows reviewer login page when reviewer button pressed.
        /// </summary>
        /// <param name="sender">reviwer button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void ReviewerClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm(UserConstants.ReviewerRole);
            login.ShowDialog();
            Show();
        }

        /// <summary>
        /// Shows speaker login page when speaker button pressed.
        /// </summary>
        /// <param name="sender">speaker button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void SpeakerClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm(UserConstants.SpeakerRole);
            login.ShowDialog();
            Show();
        }

        /// <summary>
        /// Shows conference manager login page when manager button pressed.
        /// </summary>
        /// <param name="sender">manager button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void ManagerClick(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm(UserConstants.ManagerRole);
            login.ShowDialog();
            Show();
        }

        /// <summary>
        /// Shows sign-up page when create account link clicked.
        /// </summary>
        /// <param name="sender">create account link that was clicked.</param>
        /// <param name="e">additional event info.</param>
        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.Show();
        }
    }
}
