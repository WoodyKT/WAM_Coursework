using CsvHelper.Configuration.Attributes;
using System.Collections.Generic;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Main homepage for speakers.
    /// </summary>
    public partial class SpeakerMainForm : Form
    {
        /// <summary>
        /// Initialises the object and updates the list of applications submitted by the user.
        /// </summary>
        public SpeakerMainForm()
        {
            InitializeComponent();
            UpdateTalkList();
        }

        /// <summary>
        /// Submits the application and closes the form when submit button pressed.
        /// </summary>
        /// <param name="sender">submit button that was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void NewTalkButton_Click(object sender, System.EventArgs e)
        {
            SubmitTalkForm submitForm = new SubmitTalkForm();
            submitForm.ShowDialog();
            UpdateTalkList();
        }

        /// <summary>
        /// Fetches all applications previously submitted by the user from the database files
        /// and displays them as a list of buttons on the homepage including the status of each.
        /// </summary>
        private void UpdateTalkList()
        {
            ApplicationsFlowPanel.Controls.Clear();
            string userEmail = CurrentUser.Instance.User.record.Email;
            List<TalkRecord> talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);
            List<TalkRecord> speakerTalks = talks.FindAll(t => t.SpeakerEmail ==userEmail);

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
