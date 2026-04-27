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
            this.TitleLabel.Location = new System.Drawing.Point(360, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 51);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(380, 84);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(168, 21);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Create new conference";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.CardPanel.Location = new System.Drawing.Point(120, 140);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(660, 480);
            this.CardPanel.TabIndex = 2;
            // 
            // ConferenceTitleLabel
            // 
            this.ConferenceTitleLabel.AutoSize = true;
            this.ConferenceTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConferenceTitleLabel.Location = new System.Drawing.Point(20, 18);
            this.ConferenceTitleLabel.Name = "ConferenceTitleLabel";
            this.ConferenceTitleLabel.Size = new System.Drawing.Size(81, 13);
            this.ConferenceTitleLabel.TabIndex = 0;
            this.ConferenceTitleLabel.Text = "Conference title";
            // 
            // ConferenceTitleTextBox
            // 
            this.ConferenceTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ConferenceTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConferenceTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.ConferenceTitleTextBox.Location = new System.Drawing.Point(20, 38);
            this.ConferenceTitleTextBox.Name = "ConferenceTitleTextBox";
            this.ConferenceTitleTextBox.Size = new System.Drawing.Size(620, 20);
            this.ConferenceTitleTextBox.TabIndex = 1;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LocationLabel.Location = new System.Drawing.Point(20, 70);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 2;
            this.LocationLabel.Text = "Location";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LocationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTextBox.ForeColor = System.Drawing.Color.White;
            this.LocationTextBox.Location = new System.Drawing.Point(20, 90);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.Size = new System.Drawing.Size(620, 20);
            this.LocationTextBox.TabIndex = 3;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StartDateLabel.Location = new System.Drawing.Point(20, 122);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(20, 142);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(200, 20);
            this.StartDatePicker.TabIndex = 5;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EndDateLabel.Location = new System.Drawing.Point(240, 122);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.EndDateLabel.TabIndex = 6;
            this.EndDateLabel.Text = "End date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(240, 142);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(200, 20);
            this.EndDatePicker.TabIndex = 7;
            // 
            // ApplicationDeadlineLabel
            // 
            this.ApplicationDeadlineLabel.AutoSize = true;
            this.ApplicationDeadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ApplicationDeadlineLabel.Location = new System.Drawing.Point(20, 176);
            this.ApplicationDeadlineLabel.Name = "ApplicationDeadlineLabel";
            this.ApplicationDeadlineLabel.Size = new System.Drawing.Size(102, 13);
            this.ApplicationDeadlineLabel.TabIndex = 8;
            this.ApplicationDeadlineLabel.Text = "Application deadline";
            // 
            // ApplicationDeadlinePicker
            // 
            this.ApplicationDeadlinePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ApplicationDeadlinePicker.Location = new System.Drawing.Point(20, 196);
            this.ApplicationDeadlinePicker.Name = "ApplicationDeadlinePicker";
            this.ApplicationDeadlinePicker.Size = new System.Drawing.Size(200, 20);
            this.ApplicationDeadlinePicker.TabIndex = 9;
            // 
            // SpeakerSlotsLabel
            // 
            this.SpeakerSlotsLabel.AutoSize = true;
            this.SpeakerSlotsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SpeakerSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SpeakerSlotsLabel.Location = new System.Drawing.Point(19, 231);
            this.SpeakerSlotsLabel.Name = "SpeakerSlotsLabel";
            this.SpeakerSlotsLabel.Size = new System.Drawing.Size(68, 38);
            this.SpeakerSlotsLabel.TabIndex = 10;
            this.SpeakerSlotsLabel.Text = "SPEAKER\r\nSLOTS";
            // 
            // AddSlotButton
            // 
            this.AddSlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddSlotButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddSlotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSlotButton.ForeColor = System.Drawing.Color.White;
            this.AddSlotButton.Location = new System.Drawing.Point(520, 236);
            this.AddSlotButton.Name = "AddSlotButton";
            this.AddSlotButton.Size = new System.Drawing.Size(120, 28);
            this.AddSlotButton.TabIndex = 11;
            this.AddSlotButton.Text = "+ Add slot";
            this.AddSlotButton.UseVisualStyleBackColor = false;
            // 
            // SlotsFlowPanel
            // 
            this.SlotsFlowPanel.AutoScroll = true;
            this.SlotsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SlotsFlowPanel.Location = new System.Drawing.Point(20, 272);
            this.SlotsFlowPanel.Name = "SlotsFlowPanel";
            this.SlotsFlowPanel.Size = new System.Drawing.Size(620, 150);
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
            this.CreateConferenceButton.Location = new System.Drawing.Point(20, 436);
            this.CreateConferenceButton.Name = "CreateConferenceButton";
            this.CreateConferenceButton.Size = new System.Drawing.Size(620, 36);
            this.CreateConferenceButton.TabIndex = 13;
            this.CreateConferenceButton.Text = "Create conference";
            this.CreateConferenceButton.UseVisualStyleBackColor = false;
            // 
            // NewConferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
            this.Name = "NewConferenceForm";
            this.Text = "Create new conference";
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}