using System.Windows.Forms;
using WAM_Coursework.Conferences;

namespace WAM_Coursework.Forms
{
    public partial class NewConferenceForm : Form
    {
        public NewConferenceForm()
        {
            InitializeComponent();
        }

        private void CreateConferenceButton_Click(object sender, System.EventArgs e)
        {
            Conference conference = new Conference(ConferenceTitleTextBox.Text, LocationTextBox.Text, StartDatePicker.Value, EndDatePicker.Value, ApplicationDeadlinePicker.Value);
        }

        private void AddSlotButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
