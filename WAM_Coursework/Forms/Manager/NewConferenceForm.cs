using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WAM_Coursework.Conferences;

namespace WAM_Coursework.Forms
{
    public partial class NewConferenceForm : Form
    {
        public HashSet<DateTime> slotTimes = new HashSet<DateTime>();
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
            if (SlotDatePicker.Value < StartDatePicker.Value || SlotDatePicker.Value > EndDatePicker.Value)
            {
                MessageBox.Show("Slot time must be between the conference start and end dates.");
                return;
            }
            slotTimes.Add(SlotDatePicker.Value);
            SlotDatePicker.Value = ApplicationDeadlinePicker.Value;
            UpdateSlotList();
        }

        private void UpdateSlotList()
        {
            SlotsFlowPanel.Controls.Clear();

            List<DateTime> sortedSlots = new List<DateTime>(slotTimes);
            sortedSlots.Sort();

            foreach (DateTime slot in sortedSlots)
            {
                Label slotLabel = new Label();
                slotLabel.Text = slot.ToString("dd/MM/yyyy HH:mm");
                slotLabel.ForeColor = Color.FromArgb(220, 220, 220);
                slotLabel.BackColor = Color.Transparent;
                slotLabel.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                slotLabel.AutoSize = true;
                slotLabel.Margin = new Padding(4, 2, 4, 2);
                slotLabel.Cursor = Cursors.Hand;
                slotLabel.Click += (s, e) =>
                {
                    slotTimes.Remove(slot);
                    UpdateSlotList();
                };
                SlotsFlowPanel.Controls.Add(slotLabel);
            }
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (StartDatePicker.Value > EndDatePicker.Value)
            {
                EndDatePicker.Value = StartDatePicker.Value;
            }
        }

        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < StartDatePicker.Value)
            {
                StartDatePicker.Value = EndDatePicker.Value;
            }
        }

        private void ApplicationDeadlinePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ApplicationDeadlinePicker.Value > StartDatePicker.Value)
            {
                StartDatePicker.Value = ApplicationDeadlinePicker.Value;
            }
        }
    }
}
