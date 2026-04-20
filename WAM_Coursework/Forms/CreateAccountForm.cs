using System;
using System.Windows.Forms;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    public partial class CreateAccountForm : Form
    {
        private string selectedRole = UserConstants.SpeakerRole;

        public CreateAccountForm()
        {
            InitializeComponent();
            UpdateRoleButtons();
        }

        private void BtnSpeaker_Click(object sender, EventArgs e)
        {
            selectedRole = UserConstants.SpeakerRole;
            UpdateRoleButtons();
        }

        private void BtnReviewer_Click(object sender, EventArgs e)
        {
            selectedRole = UserConstants.ReviewerRole;
            UpdateRoleButtons();
        }

        private void UpdateRoleButtons()
        {
            SpeakerButton.BackColor = selectedRole == UserConstants.SpeakerRole ? System.Drawing.Color.FromArgb(30, 120, 220) : System.Drawing.Color.FromArgb(68, 68, 68);
            ReviewerButton.BackColor = selectedRole == UserConstants.ReviewerRole ? System.Drawing.Color.FromArgb(30, 120, 220) : System.Drawing.Color.FromArgb(68, 68, 68);
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text) || string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                MessageBox.Show("Please fill in your name and email.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PasswordTextBox.Text != ConfirmTextBox.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserFactory.CreateAccount(EmailTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, selectedRole);
            MessageBox.Show($"Account created for {FirstNameTextBox.Text} {LastNameTextBox.Text} as {selectedRole}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void LinkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {     
            this.Dispose();
        }
    }
}

