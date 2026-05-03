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

        private string[] AssignApplication(string spkrAffiliation)
        {
            //allocate the application to reviewers
            //use filemanager to read list of reviewers
            List<UserRecord> Users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            List<UserRecord> Reviewers = Users.FindAll(t => t.Role == "Reviewer");
            string reviewer1email = "";
            string reviewer2email = "";
            int index = -1;
            Random random = new Random();

            if (Reviewers.Count < 2)
            {
                return null;
            }
            while (reviewer1email == "" || reviewer2email == "")
            {
                index = random.Next(Reviewers.Count);
                //find a reviewer with a different affiliation to the speaker who hasn't already been picked.
                if (Reviewers[index].Affiliation != spkrAffiliation && Reviewers[index].Email != reviewer1email)
                {
                    if (string.IsNullOrEmpty(reviewer1email))
                    {
                        reviewer1email = Reviewers[index].Email;
                    }
                    else if (string.IsNullOrEmpty(reviewer2email))
                    {
                        reviewer2email = Reviewers[index].Email;
                    }
                }
            }
            return new string[] { reviewer1email, reviewer2email };

        }
    }
}