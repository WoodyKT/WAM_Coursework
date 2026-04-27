using System.Windows.Forms;
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

            string args = $"{title},{description}";
            CurrentUser.Instance.User.CreateAction(args);
            Close();
        }
    }
}