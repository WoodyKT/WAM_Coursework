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
            if (!NameValidation(FirstNameTextBox.Text, LastNameTextBox.Text) || !EmailValidation(EmailTextBox.Text.ToLower()) ||
                !PasswordValidation(PasswordTextBox.Text, ConfirmTextBox.Text) || !AffiliationValidation(AffiliationTextBox.Text))
            {
                return;
            }

            //inputs valid, create user
            UserFactory.CreateUser(EmailTextBox.Text.ToLower(), FirstNameTextBox.Text, LastNameTextBox.Text, PasswordTextBox.Text, selectedRole, AffiliationTextBox.Text);
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

        /// <summary>
        /// Performs validation on entered first name and last name.
        /// </summary>
        /// <param name="firstname">Entered first name.</param>
        /// <param name="lastname">Entered last name.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool NameValidation(string firstname, string lastname)
        {
            //no empty names
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your first and last name.", "Empty Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //no longer than 35 chars, and only unicode letters, no symbols or number (except ' - and spaces)
            if (firstname.Length > 35 || !Regex.IsMatch(firstname, @"^[a-zA-Z\s'-]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)) ||
                lastname.Length > 35 || !Regex.IsMatch(lastname, @"^[a-zA-Z\s'-]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show("Entered name is invalid. Please ensure names are no longer than 35 characters and do not contain any numbers or symbols.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Performs validation on entered email address.
        /// </summary>
        /// <param name="email">Entered email address.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool EmailValidation(string email)
        {
            //no empty emails
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email address.", "Empty Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (email.Length > 320)
            {
                MessageBox.Show("Please enter an email address no longer than 320 characters.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //ensure email is in valid format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //check email is available
            if (UserFactory.GetUser(email) != null)
            {
                MessageBox.Show("Email is already in use.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Performs validation on entered affiliation.
        /// </summary>
        /// <param name="affiliation">Entered affiliation.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool AffiliationValidation(string affiliation)
        {
            if (string.IsNullOrEmpty(affiliation))
            {
                MessageBox.Show("Please enter your affiliation - the organisation you work/volunteer for.", "Empty Affiliation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (affiliation.Length > 160)
            {
                MessageBox.Show("Entered affiliation too long - please only enter up to 160 characters.", "Invalid Affiliation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Performs validation on input to password and confirm password fields.
        /// </summary>
        /// <param name="password">Entered password.</param>
        /// <param name="confirm">Password entered again - should be identical to password.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool PasswordValidation(string password, string confirm)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm))
            {
                MessageBox.Show("Please enter a password into both password fields.", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

