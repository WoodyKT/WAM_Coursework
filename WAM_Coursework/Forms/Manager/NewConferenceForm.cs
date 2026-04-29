using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

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

            Conference conference = new Conference(
            ConferenceTitleTextBox.Text,
            LocationTextBox.Text,
            StartDatePicker.Value,
            EndDatePicker.Value,
            ApplicationDeadlinePicker.Value);

            List<TalkRecord> eligibleTalks = GetTalksWithTwoReviews();

            List<SelectedTalksRecord> selectedTalks = new List<SelectedTalksRecord>();
            int maxTalks;
            if (slotTimes.Count<eligibleTalks.Count)
            {
                maxTalks = slotTimes.Count;
            }
            else
            {
                maxTalks=eligibleTalks.Count;
            }

            for (int i = 0; i < maxTalks; i++)
            {
                selectedTalks.Add(new SelectedTalksRecord
                {
                    talkId = eligibleTalks[i].Id,
                    startTime = slotTimes.ElementAt(i)
                });
            }

            foreach (var talk in eligibleTalks)
            {
                talk.ReviewPassed = true;
                FileManager.UpdateRecord(talk, FileManager.StorageFile.talks);
            }

            FileManager.WriteRecords(new List<ConferenceRecord>{ conference.record }, FileManager.StorageFile.conferences);
            FileManager.WriteRecords(selectedTalks, FileManager.StorageFile.selectedTalks);
            Close();
        }

        private void AddSlotButton_Click(object sender, EventArgs e)
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

    
        private List<TalkRecord> GetTalksWithTwoReviews()
        {
            var reviews = FileManager.ReadRecords<ReviewRecord>(FileManager.StorageFile.reviews);
            var talks = FileManager.ReadRecords<TalkRecord>(FileManager.StorageFile.talks);

            var talkAverages = reviews
            .GroupBy(r => r.attachedTalkId)
            .Where(g => g.Count() >= 2)
            .Select(g => new { TalkId = g.Key, AvgScore = g.Average(r => r.Score) })
            .OrderByDescending(g => g.AvgScore)
            .ToList();

            return talkAverages
                .Select(g => talks.Find(t => t.Id == g.TalkId))
                .Where(t => t != null)
                .ToList();
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
