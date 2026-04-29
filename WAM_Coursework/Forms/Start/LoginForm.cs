using System.Windows.Forms;
using WAM_Coursework.Forms.Manager;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Login form where user enters and submits their credentials.
    /// </summary>
    public partial class LoginForm : Form
    {
        /// <summary>
        /// LoginForm constructor, sets login prompt text to match user account type selected.
        /// </summary>
        /// <param name="role"></param>
        public LoginForm(string role)
        {
            InitializeComponent();
            LogInLabel.Text = $"Log in to your {role} account";
        }

        /// <summary>
        /// Validates login details against database. 
        /// Displays respective user homepage if validation passes and closes this form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogInButton_Click(object sender, System.EventArgs e)
        {
            User.AttemptLogin(EmailTextBox.Text, PasswordTextBox.Text);
            if (CurrentUser.Instance.User == null)
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Close(); //successful login, welcome page handles redirecting.
        }
    }
}
