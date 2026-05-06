using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Form where user submits an application for a talk.
    /// </summary>
    public partial class SubmitTalkForm : Form
    {
        /// <summary>
        /// SubmitTalkForm constructor.
        /// </summary>
        public SubmitTalkForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Submits application and closes form when submit button pressed.
        /// </summary>
        /// <param name="sender">submit button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            string title = TalkTitleTextBox.Text;
            string description = TalkDescriptionTextBox.Text;
            string affiliation = CurrentUser.Instance.User.record.Affiliation;

            if (!ValidateApplication(title, description))
            {
                //validation failed, do not submit application
                return;
            }

            string[] reviewerEmails = AssignApplication(affiliation);

            //not enough reveiewers checks
            if (reviewerEmails == null)
            {
                MessageBox.Show("There are not enough reviewers available to review your application at this time, please try again later.", "Cannot Submit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            else if (String.IsNullOrEmpty(reviewerEmails[0]) || String.IsNullOrEmpty(reviewerEmails[1]))
            {
                MessageBox.Show("There are not enough reviewers available to review your application at this time, please try again later.", "Cannot Submit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            string args = $"{title},{description},{affiliation},{reviewerEmails[0]},{reviewerEmails[1]}";
            CurrentUser.Instance.User.CreateAction(args);
            
            Close();
        }

        /// <summary>
        /// Performs validation on entered application information.
        /// </summary>
        /// <param name="title">Talk title.</param>
        /// <param name="description">Talk description.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool ValidateApplication(string title, string description)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields before submitting your application.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (title.Count() > 100)
            {
                MessageBox.Show("The title cannot exceed 100 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (description.Count() > 3000)
            {
                MessageBox.Show("The description cannot exceed 3000 characters.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Assigns submitted application to two random reviewers that do not share an affiliation with the speaker.
        /// </summary>
        /// <param name="spkrAffiliation">Affiliation of the speaker.</param>
        /// <returns>Emails of the two assigned reviewers, or Null if not enough valid reviewers found.</returns>
        private string[] AssignApplication(string spkrAffiliation)
        {
            //allocate the application to reviewers
            //use filemanager to read list of reviewers
            List<UserRecord> Users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            //get list of reviewers with a different affiliation to the speaker
            List<UserRecord> validReviewers = Users.FindAll(t => t.Role == "Reviewer" && t.Affiliation != spkrAffiliation);
            string reviewer1email = "";
            string reviewer2email = "";
            int index = -1;
            Random random = new Random();

            if (validReviewers.Count < 2)
            {
                return null;
            }
            while (reviewer1email == "" || reviewer2email == "")
            {
                index = random.Next(validReviewers.Count);
                //randomly find a reviewer who hasn't already been picked.
                if (validReviewers[index].Email != reviewer1email)
                {
                    if (string.IsNullOrEmpty(reviewer1email))
                    {
                        reviewer1email = validReviewers[index].Email;
                    }
                    else if (string.IsNullOrEmpty(reviewer2email))
                    {
                        reviewer2email = validReviewers[index].Email;
                    }
                }
            }
            return new string[] { reviewer1email, reviewer2email };

        }
    }
}