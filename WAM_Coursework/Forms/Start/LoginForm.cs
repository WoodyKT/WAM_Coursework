using System.Windows.Forms;
using WAM_Coursework.Forms.Manager;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm(string role)
        {
            InitializeComponent();
            LogInLabel.Text = $"Log in to your {role} account";
        }

        private void LogInButton_Click(object sender, System.EventArgs e)
        {
            User.AttemptLogin(EmailTextBox.Text, PasswordTextBox.Text);
            if (CurrentUser.Instance.User == null)
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            switch (CurrentUser.Instance.User.record.Role)
            {
                case UserConstants.SpeakerRole:
                    SpeakerMainForm SpeakerForm = new SpeakerMainForm();
                    SpeakerForm.Show();
                    Close();
                    break;
                case UserConstants.ReviewerRole:
                    ReviewerMainForm ReviewerForm = new ReviewerMainForm();
                    ReviewerForm.Show();
                    Close();
                    break;
                case UserConstants.ManagerRole:
                    ManagerMainForm ManagerForm = new ManagerMainForm();
                    ManagerForm.Show();
                    Close();
                    break;
                default:
                    break;
            }
        }
    }
}
