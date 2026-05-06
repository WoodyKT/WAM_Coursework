using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Forms
{
    public partial class NewConferenceForm : Form
    {
        public HashSet<DateTime> slotTimes = new HashSet<DateTime>();

        /// <summary>
        /// NewConferenceForm constructor. 
        /// Overrides date input fields to allow user to input both date and time.
        /// </summary>
        public NewConferenceForm()
        {
            InitializeComponent();
            //Allows user to enter both date and time for all fields.
            StartDatePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            EndDatePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            SlotDatePicker.CustomFormat = "dd-MM-yyyy HH:mm";
            ApplicationDeadlinePicker.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        /// <summary>
        /// Triggers validation on all user inputs, if all are valid a conference is created using the inputs.
        /// </summary>
        /// <param name="sender">submit button pressed.</param>
        /// <param name="e">additional event info.</param>
        private void CreateConferenceButton_Click(object sender, System.EventArgs e)
        {
            if (!ValidateConText(ConferenceTitleTextBox.Text, LocationTextBox.Text) || !ValidateConTimes(StartDatePicker.Value, EndDatePicker.Value, ApplicationDeadlinePicker.Value))
            {
                return;
            }

            List<SelectedTalksRecord> selectedTalks = new List<SelectedTalksRecord>();

            Conference conference = new Conference(
            ConferenceTitleTextBox.Text,
            LocationTextBox.Text,
            StartDatePicker.Value,
            EndDatePicker.Value,
            ApplicationDeadlinePicker.Value);

            for (int i = 0; i < slotTimes.Count; i++)
            {
                selectedTalks.Add(new SelectedTalksRecord
                {
                    talkId = -1,
                    startTime = slotTimes.ElementAt(i)
                });
            }

            //clear all applications from previous conference
            FileManager.ClearFile(FileManager.StorageFile.talks);
            FileManager.ClearFile(FileManager.StorageFile.reviews);

            FileManager.ClearFile(FileManager.StorageFile.selectedTalks);
            FileManager.WriteRecords(selectedTalks, FileManager.StorageFile.selectedTalks);
            FileManager.WriteRecords(new List<ConferenceRecord> { conference.record }, FileManager.StorageFile.conferences);
            Close();
        }

        /// <summary>
        /// Validates and creates a time slot for the new conference.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSlotButton_Click(object sender, EventArgs e)
        {
            if (SlotDatePicker.Value < StartDatePicker.Value || SlotDatePicker.Value > EndDatePicker.Value)
            {
                MessageBox.Show("Slot time must be between the conference start and end dates.");
                return;
            }
            slotTimes.Add(SlotDatePicker.Value);
            SlotDatePicker.Value = StartDatePicker.Value;
            UpdateSlotList();
        }
   
        /// <summary>
        /// Updates the form with a list of created timeslots. Allows the user to click timeslots to remove them.
        /// </summary>
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

        /// <summary>
        /// Validates selected start date, and automatically changes it to be before the end date if needed.
        /// Also updates deadline picker to prevent selections after start date.
        /// </summary>
        /// <param name="sender">Date picker changed.</param>
        /// <param name="e">Additional event info.</param>
        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ApplicationDeadlinePicker.MaxDate = StartDatePicker.Value.AddDays(-1);

            if (StartDatePicker.Value > EndDatePicker.Value)
            {
                try
                {
                    EndDatePicker.Value = StartDatePicker.Value;

                }
                catch (ArgumentOutOfRangeException)
                {
                    EndDatePicker.Value = StartDatePicker.Value.AddDays(1);
                }

            }
        }

        /// <summary>
        /// Validates selected end date, and automatically changes it to be after the start date if needed.
        /// </summary>
        /// <param name="sender">Date picker changed.</param>
        /// <param name="e">Additional event info.</param>
        private void EndDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (EndDatePicker.Value < StartDatePicker.Value)
            {
                try
                {
                    StartDatePicker.Value = EndDatePicker.Value;
                }
                catch (ArgumentOutOfRangeException)
                {
                    EndDatePicker.Value = EndDatePicker.Value.AddDays(1);
                    StartDatePicker.Value = EndDatePicker.Value.AddDays(-1);
                }
            }
        }

        /// <summary>
        /// Validates selected end date, changing it to be before the start date if needed.
        /// </summary>
        /// <param name="sender">Date picker changed.</param>
        /// <param name="e">Additional event info.</param>
        private void ApplicationDeadlinePicker_ValueChanged(object sender, EventArgs e)
        {
            if (ApplicationDeadlinePicker.Value > StartDatePicker.Value)
            {
                StartDatePicker.Value = ApplicationDeadlinePicker.Value;
            }
        }

        //-------------------------------INPUT VALIDATION CHECKS---------------------------------

        /// <summary>
        /// Validation checks for entered conference title and location.
        /// </summary>
        /// <param name="conTitle">Conference title.</param>
        /// <param name="conLocation">Conference location.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool ValidateConText(string conTitle, string conLocation)
        {
            if (string.IsNullOrWhiteSpace(conTitle) || string.IsNullOrWhiteSpace(conLocation))
            {
                MessageBox.Show("Conference title and location cannot be empty.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (conTitle.Count() > 300)
            {
                MessageBox.Show("Conference title cannot exceed 300 characters.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (conLocation.Count() > 200)
            {
                MessageBox.Show("Conference location cannot exceed 200 characters.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        /// <summary>
        /// Validation checks for all entered conference dates and times.
        /// </summary>
        /// <param name="start">Conference start date and time.</param>
        /// <param name="end">Conference end date and time.</param>
        /// <param name="deadline">Conference deadline date and time.</param>
        /// <returns>True if validation passed, False if it failed.</returns>
        private bool ValidateConTimes(DateTime start, DateTime end, DateTime deadline)
        {
            if (start < DateTime.Now || end < DateTime.Now || deadline < DateTime.Now)
            {
                MessageBox.Show("Conference times cannot be in the past.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (slotTimes.Count() == 0)
            {
                MessageBox.Show("Please add at least one slot time for the conference.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (DateTime slot in slotTimes)
            {
                if (slot < start || slot > end)
                {
                    MessageBox.Show("All slot times must be between the conference start and end times. Please remove the invalid slots and try again.", "Invalid Conference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }
    }
}
