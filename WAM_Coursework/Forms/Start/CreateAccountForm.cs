using System;
using System.Text.RegularExpressions;
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
        /// <param name = "sender" > submit button that was pressed.</param>
        /// <param name = "e" > additional event info.</param>
        private void BtnSignUp_Click(object sender, EventArgs e)
        {

            //input validation
            if (!NameValidation(FirstNameTextBox.Text, LastNameTextBox.Text) || !EmailValidation(EmailTextBox.Text) ||
                !PasswordValidation(PasswordTextBox.Text, ConfirmTextBox.Text) || !AffiliationValidation(AffiliationTextBox.Text))
            {
                return;
            }

            //inputs valid, create user
            UserFactory.CreateUser(EmailTextBox.Text, FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, selectedRole, AffiliationTextBox.Text);
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

        //-------------------------------INPUT VALIDATION CHECKS---------------------------------

        private bool NameValidation(string firstname, string lastname)
        {
            //no empty names
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your first and last name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //no longer than 35 chars, and only unicode letters, no symbols or number (except ' - and spaces)
            if (firstname.Length > 35 || !Regex.IsMatch(firstname, @"^[a-zA-Z\s'-]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)) ||
                lastname.Length > 35 || !Regex.IsMatch(lastname, @"^[a-zA-Z\s'-]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show("Entered name is invalid. Please ensure names are no longer than 35 characters and do not contain any numbers or symbols.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool EmailValidation(string email)
        {
            //no empty emails
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //ensure email is in valid format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //check email is available
            if (UserFactory.GetUser(email) != null)
            {
                MessageBox.Show("Email is already in use.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool AffiliationValidation(string affiliation)
        {
            if (string.IsNullOrEmpty(affiliation))
            {
                MessageBox.Show("Please enter your affiliation - the organisation you work/volunteer for.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (affiliation.Length > 160)
            {
                MessageBox.Show("Entered affiliation too long - please only enter up to 160 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool PasswordValidation(string password, string confirm)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please enter a password into both password fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

