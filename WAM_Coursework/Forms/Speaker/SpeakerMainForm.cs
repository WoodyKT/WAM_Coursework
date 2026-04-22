using System.Windows.Forms;

namespace WAM_Coursework.Forms
{
    public partial class SpeakerMainForm : Form
    {
        public SpeakerMainForm()
        {
            InitializeComponent();
        }

        private void NewTalkButton_Click(object sender, System.EventArgs e)
        {
            SubmitTalkForm submitForm = new SubmitTalkForm();
            submitForm.ShowDialog();
        }
    }
}
