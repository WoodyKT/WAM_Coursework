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
            List<TalkRecord> speakerTalks = talks.FindAll(t => t.SpeakerEmail == userEmail);

            foreach (var talk in speakerTalks)
            {
                Button talkbutton = new Button() { Text = talk.Title + "\t - " + talk.Description + "\t- " + (talk.ReviewPassed ? "Approved" : "Pending") };
                talkbutton.Font = new System.Drawing.Font(talkbutton.Font.FontFamily, 20);
                talkbutton.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
                talkbutton.ForeColor = System.Drawing.Color.White;
                talkbutton.AutoSize = true;
                ApplicationsFlowPanel.Controls.Add(talkbutton);
            }
        }
    }
}
