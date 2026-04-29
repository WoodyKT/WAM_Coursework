using System;
using System.Windows.Forms;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Form that allows user to create a new speaker or reviewer account.
    /// </summary>
    public partial class CreateAccountForm : Form
    {
        private string selectedRole = UserConstants.SpeakerRole;

        /// <summary>
        /// CreateAccountForm constructor. 
        /// Sets up user type buttons to highlight selected one.
        /// </summary>
        public CreateAccountForm()
        {
            InitializeComponent();
            UpdateRoleButtons();
        }

        /// <summary>
        /// Sets type of account to be created to speaker
        /// and highlights button when pressed.
        /// </summary>
        /// <param name="sender">speaker button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void BtnSpeaker_Click(object sender, EventArgs e)
        {
            selectedRole = UserConstants.SpeakerRole;
            UpdateRoleButtons();
        }

        /// <summary>
        /// Sets type of account to be created to reviewer
        /// and highlights button when pressed.
        /// </summary>
        /// <param name="sender">reviewer button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void BtnReviewer_Click(object sender, EventArgs e)
        {
            selectedRole = UserConstants.ReviewerRole;
            UpdateRoleButtons();
        }

        /// <summary>
        /// Updates user type buttons to highlight selected one.
        /// </summary>
        private void UpdateRoleButtons()
        {
            SpeakerButton.BackColor = selectedRole == UserConstants.SpeakerRole ? System.Drawing.Color.FromArgb(30, 120, 220) : System.Drawing.Color.FromArgb(68, 68, 68);
            ReviewerButton.BackColor = selectedRole == UserConstants.ReviewerRole ? System.Drawing.Color.FromArgb(30, 120, 220) : System.Drawing.Color.FromArgb(68, 68, 68);
        }

        /// <summary>
        /// Performs validation on inputs and creates new user if they pass when submit button pressed.
        /// </summary>
        /// <param name="sender">submit button that was pressed.</param>
        /// <param name="e">additional event info.</param>
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

            if (UserFactory.GetUser(EmailTextBox.Text) != null)
            {
                MessageBox.Show("Email is already in use.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserFactory.CreateUser(EmailTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, selectedRole);
            MessageBox.Show($"Account created for {FirstNameTextBox.Text} {LastNameTextBox.Text} as {selectedRole}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Closes the form when user selects link
        /// to cancel account creation and return to sign in page.
        /// </summary>
        /// <param name="sender">cancel link pressed.</param>
        /// <param name="e">additional event info.</param>
        private void LinkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}

