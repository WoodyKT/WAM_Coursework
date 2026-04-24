using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    public partial class SpeakerMainForm : Form
    {
        public SpeakerMainForm()
        {
            InitializeComponent();
            UpdateTalkList();
        }

        private void NewTalkButton_Click(object sender, System.EventArgs e)
        {
            SubmitTalkForm submitForm = new SubmitTalkForm();
            submitForm.ShowDialog();
            UpdateTalkList();
        }

        private void UpdateTalkList()
        {
            ApplicationsFlowPanel.Controls.Clear();
            string userEmail = CurrentUser.Instance.User.record.Email;
            List<TalkRecord> talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);
            List<TalkRecord> speakerTalks = talks.FindAll(t => t.SpeakerEmail ==userEmail);

            foreach (var talk in speakerTalks)
            {
                Label talkLabel = new Label() { Text = talk.Title + "\t - " + talk.Description + "\t- " + (talk.ReviewPassed ? "Approved" : "Pending") };
                talkLabel.Font = new System.Drawing.Font(talkLabel.Font.FontFamily, 20);
                talkLabel.ForeColor = System.Drawing.Color.White;
                talkLabel.AutoSize = true;
                talkLabel.BorderStyle = BorderStyle.FixedSingle;
                ApplicationsFlowPanel.Controls.Add(talkLabel);
            }
        }
    }
}
