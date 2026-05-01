using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms.Manager
{
    /// <summary>
    /// Form for the homepage of the conference manager.
    /// </summary>
    public partial class ManagerMainForm : Form
    {
        /// <summary>
        /// ManagerMainForm constructor.
        /// </summary>
        public ManagerMainForm()
        {
            InitializeComponent();
            CheckForSavedConference();
        }

        private void StartNewButton_Click(object sender, EventArgs e)
        {
            NewConferenceForm newConferenceForm = new NewConferenceForm();
            newConferenceForm.ShowDialog();
            CheckForSavedConference();
        }

        private void CheckForSavedConference()
        {
            List<ConferenceRecord> conferences = FileManager.ReadRecords<ConferenceRecord>(FileManager.StorageFile.conferences);
            if (conferences.Count > 0)
            {
                SetActiveConference(conferences[conferences.Count - 1]);
            }
            else
            {
                CardPanel.Visible = false;
            }
        }

        /// <summary>
        /// Set the active conference if there is one
        /// </summary>
        private void SetActiveConference(ConferenceRecord conference)
        {
            CardPanel.Visible = true;

            TitleLabel.Text = conference.Title;
            LocationValueLabel.Text = conference.Location;
            StartDateValue.Text = $"{conference.StartDate:dd/MM/yyyy}";
            EndDateValue.Text = $"{conference.EndDate:dd/MM/yyyy}";
            DeadlineValue.Text = $"{conference.ApplicationDeadline:dd/MM/yyyy}";

            List<SelectedTalksRecord> selectedTalks = FileManager.ReadRecords<SelectedTalksRecord>(FileManager.StorageFile.selectedTalks);
            List<TalkRecord> allTalks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);
            TotalSlotsValue.Text = $"Total Slots: {selectedTalks.Count}";

            SlotsFlowPanel.Controls.Clear();
            foreach (var selected in selectedTalks)
            {
                TalkRecord talk = allTalks.Find(t => t.Id == selected.talkId);
                if (talk == null) continue;

                Button talkButton = new Button();
                talkButton.Text = $"{talk.Title}  —  {talk.Description}  —  {selected.startTime:dd/MM/yyyy HH:mm}";
                talkButton.Font = new System.Drawing.Font(talkButton.Font.FontFamily, 11);
                talkButton.BackColor = System.Drawing.Color.FromArgb(54, 54, 54);
                talkButton.ForeColor = System.Drawing.Color.White;
                talkButton.AutoSize = true;
                talkButton.FlatStyle = FlatStyle.Flat;
                talkButton.FlatAppearance.BorderSize = 0;
                SlotsFlowPanel.Controls.Add(talkButton);
            }
        }

        /// <summary>
        /// Clears logged in user and returns to welcome page
        /// when logout link clicked.
        /// </summary>
        /// <param name="sender">logout link clicked.</param>
        /// <param name="e">additional event info.</param>
        private void LogoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CurrentUser.Instance.User = null;
            Close();
        }

        private void ManagerMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentUser.Instance.User = null;
            Close();
        }
    }
}
