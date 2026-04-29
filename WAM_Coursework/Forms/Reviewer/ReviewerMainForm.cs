using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Form for the reviewer homepage.
    /// </summary>
    public partial class ReviewerMainForm : Form
    {
        /// <summary>
        /// ReviewerMainForm constructor. Immediately updates list of applications to review.
        /// </summary>
        public ReviewerMainForm()
        {
            InitializeComponent();
            UpdateReadyToReviewList();

        }

        /// <summary>
        /// Fetches all unreviewed applications from the database file
        /// and displays them as a list of buttons on the reviwer's homepage including the status of each.
        /// </summary>
        private void UpdateReadyToReviewList()
        {
            ReviewsFlowPanel.Controls.Clear();
            string userEmail = CurrentUser.Instance.User.record.Email;
            List<TalkRecord> Talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);
            List<TalkRecord> Assigned = Talks.FindAll(t => t.Reviewer1Email == userEmail || t.Reviewer2Email == userEmail);

            foreach (var talk in Assigned)
            {
                //add application to reviewer homepage list as a button.
                Button talkbutton = new Button() { Text = talk.Title + "\t - " + talk.Description + "\t- " + (talk.ReviewPassed ? "Approved" : "Pending") };
                talkbutton.Font = new System.Drawing.Font(talkbutton.Font.FontFamily, 20);
                talkbutton.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
                talkbutton.ForeColor = System.Drawing.Color.White;
                talkbutton.AutoSize = true;
                talkbutton.Click += (sender, e) => OpenReview(sender, e, talk.Id);
                ReviewsFlowPanel.Controls.Add(talkbutton);
            }
            CountBadge.Text = Assigned.Count.ToString() + " remaining";
        }

        /// <summary>
        /// Opens a dialog window allowing the reviwer to review the selected application.
        /// </summary>
        /// <param name="sender">application list button which was pressed.</param>
        /// <param name="e">additional event info</param>
        /// <param name="talkId">ID of the talk to review.</param>
        private void OpenReview(object sender, EventArgs e, int talkId) 
        {
            SubmitReviewForm submitForm = new SubmitReviewForm(talkId.ToString());
            submitForm.ShowDialog();
        }

        /// <summary>
        /// Clears logged in user and returns to welcome page
        /// when logout link clicked.
        /// </summary>
        /// <param name="sender">logout link clicked.</param>
        /// <param name="e">additional event info.</param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Instance.User = null;
            Close();
        }
    }
}
