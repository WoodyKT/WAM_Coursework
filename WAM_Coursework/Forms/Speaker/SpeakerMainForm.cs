using System.Windows.Forms;

namespace WAM_Coursework.Forms
{
    public partial class SpeakerMainForm : Form
    {
        public SpeakerMainForm()
        {
            InitializeComponent();
        }

        private void NewApplicationButton_Click(object sender, System.EventArgs e)
        {
            SubmitApplicationForm submitForm = new SubmitApplicationForm();
            submitForm.ShowDialog();
        }
    }
}
