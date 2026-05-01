using System;
using System.Collections.Generic;
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
            string[] reviewerEmails = AssignApplication(affiliation);

            //empty checks
            if (reviewerEmails == null)
            {
                MessageBox.Show("Your application cannot be submitted for review at this time, please try again later.", "Cannot Submit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
            else if (String.IsNullOrEmpty(reviewerEmails[0]) || String.IsNullOrEmpty(reviewerEmails[1]))
            {
                MessageBox.Show("Your application cannot be submitted for review at this time, please try again later.", "Cannot Submit Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            string args = $"{title},{description},{affiliation},{reviewerEmails[0]},{reviewerEmails[1]}";
            CurrentUser.Instance.User.CreateAction(args);
            
            Close();
        }

        private string[] AssignApplication(string spkrAffiliation)
        {
            //allocate the application to reviewers here!
            //use filemanager to read list of reviewers
            List<UserRecord> Users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            List<UserRecord> Reviewers = Users.FindAll(t => t.Role == "Reviewer");
            string reviewer1email = "";
            string reviewer2email = "";
            int index = -1;
            Random random = new Random();
            //TODO: infinite loop possible here with not enough reviewers! address this somehow
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