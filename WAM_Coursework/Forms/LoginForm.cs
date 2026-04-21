using System.Windows.Forms;
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

        }

        private void LogInLabel_Click(object sender, System.EventArgs e)
        {

        }
    }
}
