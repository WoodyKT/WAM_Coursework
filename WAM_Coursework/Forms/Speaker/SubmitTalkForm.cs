using System.Windows.Forms;
using WAM_Coursework.FileHandlers;
using WAM_Coursework.Conferences;
using WAM_Coursework.Users;

namespace WAM_Coursework.Forms
{
    public partial class SubmitTalkForm : Form
    {
        public SubmitTalkForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, System.EventArgs e)
        {
            string title = TalkTitleTextBox.Text;
            string description = TalkDescriptionTextBox.Text;

            string args = $"{title},{description}";
            CurrentUser.Instance.User.CreateAction(args);
        }
    }
}