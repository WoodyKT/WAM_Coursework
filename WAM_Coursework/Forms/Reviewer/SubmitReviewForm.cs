using System.Windows.Forms;

namespace WAM_Coursework.Forms
{
    public partial class SubmitReviewForm : Form
    {
        public SubmitReviewForm()
        {
            InitializeComponent();
            for (int i = 0; i < ScoreComboBox.MaxDropDownItems; i++)
            {
                ScoreComboBox.Items.Add(i);
            }
        }

        private void SubmitReviewButton_Click(object sender, System.EventArgs e)
        {

        }
    }
}
