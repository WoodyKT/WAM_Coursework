using System;
using System.Linq;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    public partial class SubmitReviewForm : Form
    {

        private string talkID;
        public SubmitReviewForm(string talkID)
        {
            InitializeComponent();
            this.talkID = talkID;
            SetTalkInfo();
            for (int i = 0; i < ScoreComboBox.MaxDropDownItems; i++)
            {
                ScoreComboBox.Items.Add(i);
            }
        }

        private void SubmitReviewButton_Click(object sender, System.EventArgs e)
        {
            Random rnd = new Random();
            CurrentUser.Instance.User.CreateAction($"{rnd.Next(0, int.MaxValue)},{ScoreComboBox.SelectedItem},{DescriptionTextBox.Text}");
            Close();
        }


        private void SetTalkInfo()
        {
            TalkRecord talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks).Where(t => t.Id == int.Parse(talkID)).FirstOrDefault();
            TalkTitleLabel.Text = talks?.Title;
            TalkDescriptionLabel.Text = talks?.Description;
        }
    }
}
