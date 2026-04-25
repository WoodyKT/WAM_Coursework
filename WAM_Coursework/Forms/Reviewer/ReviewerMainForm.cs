using System.Collections.Generic;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;
using System;

namespace WAM_Coursework.Forms
{
    public partial class ReviewerMainForm : Form
    {
        public ReviewerMainForm()
        {
            InitializeComponent();
            UpdateReadyToReviewList();

        }

        private void UpdateReadyToReviewList()
        {
            ReviewsFlowPanel.Controls.Clear();
            string userEmail = CurrentUser.Instance.User.record.Email;
            List<TalkRecord> Talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);
            List<TalkRecord> Unreviewed = Talks.FindAll(t => t.ReviewPassed == false);

            foreach (var talk in Unreviewed)
            {
                Button talkbutton = new Button() { Text = talk.Title + "\t - " + talk.Description + "\t- " + (talk.ReviewPassed ? "Approved" : "Pending") };
                talkbutton.Font = new System.Drawing.Font(talkbutton.Font.FontFamily, 20);
                talkbutton.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
                talkbutton.ForeColor = System.Drawing.Color.White;
                talkbutton.AutoSize = true;
                talkbutton.Click += (sender, e) => OpenReview(sender,e,talk.Id);
                ReviewsFlowPanel.Controls.Add(talkbutton);
            }
            CountBadge.Text = Unreviewed.Count.ToString() + " remaining";
        }

        private void OpenReview(object sender, EventArgs e, int talkId) 
        {
            SubmitReviewForm submitForm = new SubmitReviewForm(talkId.ToString());
            submitForm.ShowDialog();
        }

    }
}
