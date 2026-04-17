using System;
using System.Windows.Forms;
using WAM_Coursework.Forms;

namespace WAM_Coursework
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void PanelSpeaker_Click(object sender, EventArgs e)
        {
            var f = new SpeakerMainForm();
            f.Show();
            this.Hide();
        }
    }
}
