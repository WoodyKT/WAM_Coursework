using System.Linq;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    /// <summary>
    /// Form that contains details of an application 
    /// and allows the reviewer to submit a review of it.
    /// </summary>
    public partial class SubmitReviewForm : Form
    {

        private string talkID;
        private int reviewID = FileManager.CreateNewId<ReviewRecord>(FileManager.StorageFile.reviews);

        /// <summary>
        /// SubmitReviewForm contructor. Initialises the score combobox with the values 1-10.
        /// </summary>
        /// <param name="talkID"></param>
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

        /// <summary>
        /// Submits review and closes form when submit button clicked.
        /// </summary>
        /// <param name="sender">the submit form button which was pressed.</param>
        /// <param name="e">additional event info.</param>
        private void SubmitReviewButton_Click(object sender, System.EventArgs e)
        {

            if (!ValidateReview(ScoreComboBox.SelectedItem, ReasonTextBox.Text))
            {
                //validation failed, do not submit review
                return;
            }

            CurrentUser.Instance.User.CreateAction($"{reviewID},{int.Parse(talkID)},{ScoreComboBox.SelectedItem},{ReasonTextBox.Text.Replace(",", "%")}");
            Close();
        }

        private bool ValidateReview(object score, string reason)
        {
            if (score == null)
            {
                MessageBox.Show("Please select a score for the talk.", "Invalid Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please provide feedback justifying your score.", "Invalid Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (reason.Length > 1000)
            {
                MessageBox.Show("The feedback cannot exceed 1000 characters.", "Invalid Review", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Fetches information about the selected talk from the database file and displays it on the form.
        /// </summary>
        private void SetTalkInfo()
        {
            TalkRecord talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks).Where(t => t.Id == int.Parse(talkID)).FirstOrDefault();
            TalkTitleLabel.Text = talks?.Title;
            TalkDescriptionLabel.Text = talks?.Description;
        }
    }
}
