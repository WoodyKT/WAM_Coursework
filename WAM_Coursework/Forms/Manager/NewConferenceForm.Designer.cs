namespace WAM_Coursework.Forms
{
    partial class NewConferenceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label ConferenceTitleLabel;
        private System.Windows.Forms.TextBox ConferenceTitleTextBox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.TextBox LocationTextBox;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label ApplicationDeadlineLabel;
        private System.Windows.Forms.DateTimePicker ApplicationDeadlinePicker;
        private System.Windows.Forms.Label SpeakerSlotsLabel;
        private System.Windows.Forms.Button AddSlotButton;
        private System.Windows.Forms.FlowLayoutPanel SlotsFlowPanel;
        private System.Windows.Forms.Button CreateConferenceButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.SlotDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ConferenceTitleLabel = new System.Windows.Forms.Label();
            this.ConferenceTitleTextBox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ApplicationDeadlineLabel = new System.Windows.Forms.Label();
            this.ApplicationDeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.SpeakerSlotsLabel = new System.Windows.Forms.Label();
            this.AddSlotButton = new System.Windows.Forms.Button();
            this.SlotsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CreateConferenceButton = new System.Windows.Forms.Button();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(660, 44);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(331, 88);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(697, 155);
            this.SubtitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(302, 38);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Create new conference";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.SlotDatePicker);
            this.CardPanel.Controls.Add(this.ConferenceTitleLabel);
            this.CardPanel.Controls.Add(this.ConferenceTitleTextBox);
            this.CardPanel.Controls.Add(this.LocationLabel);
            this.CardPanel.Controls.Add(this.LocationTextBox);
            this.CardPanel.Controls.Add(this.StartDateLabel);
            this.CardPanel.Controls.Add(this.StartDatePicker);
            this.CardPanel.Controls.Add(this.EndDateLabel);
            this.CardPanel.Controls.Add(this.EndDatePicker);
            this.CardPanel.Controls.Add(this.ApplicationDeadlineLabel);
            this.CardPanel.Controls.Add(this.ApplicationDeadlinePicker);
            this.CardPanel.Controls.Add(this.SpeakerSlotsLabel);
            this.CardPanel.Controls.Add(this.AddSlotButton);
            this.CardPanel.Controls.Add(this.SlotsFlowPanel);
            this.CardPanel.Controls.Add(this.CreateConferenceButton);
            this.CardPanel.Location = new System.Drawing.Point(220, 258);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(1208, 1232);
            this.CardPanel.TabIndex = 2;
            // 
            // SlotDatePicker
            // 
            this.SlotDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SlotDatePicker.Location = new System.Drawing.Point(664, 439);
            this.SlotDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.SlotDatePicker.Name = "SlotDatePicker";
            this.SlotDatePicker.Size = new System.Drawing.Size(253, 29);
            this.SlotDatePicker.TabIndex = 5;
            // 
            // ConferenceTitleLabel
            // 
            this.ConferenceTitleLabel.AutoSize = true;
            this.ConferenceTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConferenceTitleLabel.Location = new System.Drawing.Point(37, 33);
            this.ConferenceTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConferenceTitleLabel.Name = "ConferenceTitleLabel";
            this.ConferenceTitleLabel.Size = new System.Drawing.Size(148, 25);
            this.ConferenceTitleLabel.TabIndex = 0;
            this.ConferenceTitleLabel.Text = "Conference title";
            // 
            // ConferenceTitleTextBox
            // 
            this.ConferenceTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ConferenceTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConferenceTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.ConferenceTitleTextBox.Location = new System.Drawing.Point(37, 70);
            this.ConferenceTitleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ConferenceTitleTextBox.Name = "ConferenceTitleTextBox";
            this.ConferenceTitleTextBox.Size = new System.Drawing.Size(1135, 29);
            this.ConferenceTitleTextBox.TabIndex = 0;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LocationLabel.Location = new System.Drawing.Point(37, 129);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(86, 25);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTextBox.ForeColor = System.Drawing.Color.White;
            this.LocationTextBox.Location = new System.Drawing.Point(37, 166);
            this.LocationTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(1135, 29);
            this.LocationTextBox.TabIndex = 1;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StartDateLabel.Location = new System.Drawing.Point(37, 225);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(96, 25);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(37, 262);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(363, 29);
            this.StartDatePicker.TabIndex = 2;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePicker_ValueChanged);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EndDateLabel.Location = new System.Drawing.Point(440, 225);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(90, 25);
            this.EndDateLabel.TabIndex = 6;
            this.EndDateLabel.Text = "End date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(440, 262);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(6);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(363, 29);
            this.EndDatePicker.TabIndex = 3;
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePicker_ValueChanged);
            // 
            // ApplicationDeadlineLabel
            // 
            this.ApplicationDeadlineLabel.AutoSize = true;
            this.ApplicationDeadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ApplicationDeadlineLabel.Location = new System.Drawing.Point(37, 325);
            this.ApplicationDeadlineLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ApplicationDeadlineLabel.Name = "ApplicationDeadlineLabel";
            this.ApplicationDeadlineLabel.Size = new System.Drawing.Size(187, 25);
            this.ApplicationDeadlineLabel.TabIndex = 8;
            this.ApplicationDeadlineLabel.Text = "Application deadline";
            // 
            // ApplicationDeadlinePicker
            // 
            this.ApplicationDeadlinePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ApplicationDeadlinePicker.Location = new System.Drawing.Point(37, 362);
            this.ApplicationDeadlinePicker.Margin = new System.Windows.Forms.Padding(6);
            this.ApplicationDeadlinePicker.Name = "ApplicationDeadlinePicker";
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(363, 29);
            this.ApplicationDeadlinePicker.TabIndex = 4;
            this.ApplicationDeadlinePicker.ValueChanged += new System.EventHandler(this.ApplicationDeadlinePicker_ValueChanged);
            // 
            // SpeakerSlotsLabel
            // 
            this.SpeakerSlotsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SpeakerSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SpeakerSlotsLabel.Location = new System.Drawing.Point(35, 439);
            this.SpeakerSlotsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SpeakerSlotsLabel.Name = "SpeakerSlotsLabel";
            this.SpeakerSlotsLabel.Size = new System.Drawing.Size(473, 57);
            this.SpeakerSlotsLabel.TabIndex = 10;
            this.SpeakerSlotsLabel.Text = "SPEAKER SLOTS";
            // 
            // AddSlotButton
            // 
            this.AddSlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSlotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSlotButton.ForeColor = System.Drawing.Color.White;
            this.AddSlotButton.Location = new System.Drawing.Point(953, 436);
            this.AddSlotButton.Margin = new System.Windows.Forms.Padding(6);
            this.AddSlotButton.Name = "AddSlotButton";
            this.AddSlotButton.Size = new System.Drawing.Size(220, 52);
            this.AddSlotButton.TabIndex = 6;
            this.AddSlotButton.Text = "+ Add slot";
            this.AddSlotButton.UseVisualStyleBackColor = false;
            this.AddSlotButton.Click += new System.EventHandler(this.AddSlotButton_Click);
            // 
            // SlotsFlowPanel
            // 
            this.SlotsFlowPanel.AutoScroll = true;
            this.SlotsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SlotsFlowPanel.Location = new System.Drawing.Point(37, 502);
            this.SlotsFlowPanel.Margin = new System.Windows.Forms.Padding(6);
            this.SlotsFlowPanel.Name = "SlotsFlowPanel";
            this.SlotsFlowPanel.Size = new System.Drawing.Size(1137, 598);
            this.SlotsFlowPanel.TabIndex = 12;
            this.SlotsFlowPanel.WrapContents = false;
            // 
            // CreateConferenceButton
            // 
            this.CreateConferenceButton.BackColor = System.Drawing.Color.SteelBlue;
            this.CreateConferenceButton.FlatAppearance.BorderSize = 0;
            this.CreateConferenceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.CreateConferenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateConferenceButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CreateConferenceButton.ForeColor = System.Drawing.Color.White;
            this.CreateConferenceButton.Location = new System.Drawing.Point(36, 1130);
            this.CreateConferenceButton.Margin = new System.Windows.Forms.Padding(6);
            this.CreateConferenceButton.Name = "CreateConferenceButton";
            this.CreateConferenceButton.Size = new System.Drawing.Size(1137, 66);
            this.CreateConferenceButton.TabIndex = 7;
            this.CreateConferenceButton.Text = "Create conference";
            this.CreateConferenceButton.UseVisualStyleBackColor = false;
            this.CreateConferenceButton.Click += new System.EventHandler(this.CreateConferenceButton_Click);
            // 
            // NewConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1650, 1588);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "NewConferenceForm";
            this.Text = "Create new conference";
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SlotDatePicker;
    }
}