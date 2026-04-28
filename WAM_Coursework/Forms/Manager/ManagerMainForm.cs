using System;
using System.Windows.Forms;
using WAM_Coursework.Conferences;

namespace WAM_Coursework.Forms.Manager
{
    public partial class ManagerMainForm : Form
    {
        public ManagerMainForm()
        {
            InitializeComponent();
            CheckForSavedConference();
        }

        private void StartNewButton_Click(object sender, EventArgs e)
        {
            NewConferenceForm newConferenceForm = new NewConferenceForm();
            newConferenceForm.ShowDialog();
        }

        private void CheckForSavedConference()
        {
            bool conferenceExists = false;
            Conference activeConference = new Conference();
            if (conferenceExists)
            {
                SetActiveConference(activeConference);
            }
            else
            {
                CardPanel.Visible = false;
            }
        }

        /// <summary>
        /// Set the active conference if there is one
        /// </summary>
        private void SetActiveConference(Conference conference)
        {

        }
    }
}
