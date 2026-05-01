namespace WAM_Coursework.Forms.Manager
{
    partial class ManagerMainForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button StartNewButton;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Panel OverviewPanel;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Label LocationValueLabel;
        private System.Windows.Forms.Panel StatsPanel;
        private System.Windows.Forms.Panel StartDatePanel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label StartDateValue;
        private System.Windows.Forms.Panel EndDatePanel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label EndDateValue;
        private System.Windows.Forms.Panel DeadlinePanel;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.Label DeadlineValue;
        private System.Windows.Forms.Panel TotalSlotsPanel;
        private System.Windows.Forms.Label TotalSlotsLabel;
        private System.Windows.Forms.Label TotalSlotsValue;
        private System.Windows.Forms.Label SpeakerSlotsLabel;
        private System.Windows.Forms.FlowLayoutPanel SlotsFlowPanel;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.StartNewButton = new System.Windows.Forms.Button();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.OverviewPanel = new System.Windows.Forms.Panel();
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationValueLabel = new System.Windows.Forms.Label();
            this.StatsPanel = new System.Windows.Forms.Panel();
            this.StartDatePanel = new System.Windows.Forms.Panel();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDateValue = new System.Windows.Forms.Label();
            this.EndDatePanel = new System.Windows.Forms.Panel();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.EndDateValue = new System.Windows.Forms.Label();
            this.DeadlinePanel = new System.Windows.Forms.Panel();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.DeadlineValue = new System.Windows.Forms.Label();
            this.TotalSlotsPanel = new System.Windows.Forms.Panel();
            this.TotalSlotsLabel = new System.Windows.Forms.Label();
            this.TotalSlotsValue = new System.Windows.Forms.Label();
            this.SpeakerSlotsLabel = new System.Windows.Forms.Label();
            this.SlotsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LogoutLabel = new System.Windows.Forms.LinkLabel();
            this.CardPanel.SuspendLayout();
            this.OverviewPanel.SuspendLayout();
            this.LocationPanel.SuspendLayout();
            this.StatsPanel.SuspendLayout();
            this.StartDatePanel.SuspendLayout();
            this.EndDatePanel.SuspendLayout();
            this.DeadlinePanel.SuspendLayout();
            this.TotalSlotsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(43, 30);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(400, 50);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "No Conference Active";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(43, 86);
            this.SubtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(151, 23);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Conference details";
            // 
            // StartNewButton
            // 
            this.StartNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartNewButton.BackColor = System.Drawing.Color.SteelBlue;
            this.StartNewButton.FlatAppearance.BorderSize = 0;
            this.StartNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.StartNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartNewButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StartNewButton.ForeColor = System.Drawing.Color.White;
            this.StartNewButton.Location = new System.Drawing.Point(1067, 42);
            this.StartNewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartNewButton.Name = "StartNewButton";
            this.StartNewButton.Size = new System.Drawing.Size(187, 44);
            this.StartNewButton.TabIndex = 2;
            this.StartNewButton.Text = "Start new";
            this.StartNewButton.UseVisualStyleBackColor = false;
            this.StartNewButton.Click += new System.EventHandler(this.StartNewButton_Click);
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.OverviewPanel);
            this.CardPanel.Controls.Add(this.SpeakerSlotsLabel);
            this.CardPanel.Controls.Add(this.SlotsFlowPanel);
            this.CardPanel.Location = new System.Drawing.Point(43, 135);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(1226, 738);
            this.CardPanel.TabIndex = 3;
            // 
            // OverviewPanel
            // 
            this.OverviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.OverviewPanel.Controls.Add(this.LocationPanel);
            this.OverviewPanel.Controls.Add(this.StatsPanel);
            this.OverviewPanel.Location = new System.Drawing.Point(21, 20);
            this.OverviewPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OverviewPanel.Name = "OverviewPanel";
            this.OverviewPanel.Size = new System.Drawing.Size(1184, 222);
            this.OverviewPanel.TabIndex = 0;
            // 
            // LocationPanel
            // 
            this.LocationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LocationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationPanel.Controls.Add(this.LocationLabel);
            this.LocationPanel.Controls.Add(this.LocationValueLabel);
            this.LocationPanel.Location = new System.Drawing.Point(11, 10);
            this.LocationPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(1157, 59);
            this.LocationPanel.TabIndex = 0;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LocationLabel.Location = new System.Drawing.Point(11, 10);
            this.LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(58, 16);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location";
            // 
            // LocationValueLabel
            // 
            this.LocationValueLabel.AutoSize = true;
            this.LocationValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LocationValueLabel.ForeColor = System.Drawing.Color.White;
            this.LocationValueLabel.Location = new System.Drawing.Point(11, 30);
            this.LocationValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LocationValueLabel.Name = "LocationValueLabel";
            this.LocationValueLabel.Size = new System.Drawing.Size(0, 23);
            this.LocationValueLabel.TabIndex = 1;
            // 
            // StatsPanel
            // 
            this.StatsPanel.Controls.Add(this.StartDatePanel);
            this.StatsPanel.Controls.Add(this.EndDatePanel);
            this.StatsPanel.Controls.Add(this.DeadlinePanel);
            this.StatsPanel.Controls.Add(this.TotalSlotsPanel);
            this.StatsPanel.Location = new System.Drawing.Point(11, 79);
            this.StatsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(1157, 123);
            this.StatsPanel.TabIndex = 1;
            // 
            // StartDatePanel
            // 
            this.StartDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDatePanel.Controls.Add(this.StartDateLabel);
            this.StartDatePanel.Controls.Add(this.StartDateValue);
            this.StartDatePanel.Location = new System.Drawing.Point(0, 0);
            this.StartDatePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartDatePanel.Name = "StartDatePanel";
            this.StartDatePanel.Size = new System.Drawing.Size(559, 54);
            this.StartDatePanel.TabIndex = 0;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.StartDateLabel.Location = new System.Drawing.Point(11, 10);
            this.StartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(64, 16);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDateValue
            // 
            this.StartDateValue.AutoSize = true;
            this.StartDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StartDateValue.ForeColor = System.Drawing.Color.White;
            this.StartDateValue.Location = new System.Drawing.Point(11, 30);
            this.StartDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDateValue.Name = "StartDateValue";
            this.StartDateValue.Size = new System.Drawing.Size(0, 23);
            this.StartDateValue.TabIndex = 1;
            // 
            // EndDatePanel
            // 
            this.EndDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EndDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndDatePanel.Controls.Add(this.EndDateLabel);
            this.EndDatePanel.Controls.Add(this.EndDateValue);
            this.EndDatePanel.Location = new System.Drawing.Point(597, 0);
            this.EndDatePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndDatePanel.Name = "EndDatePanel";
            this.EndDatePanel.Size = new System.Drawing.Size(559, 54);
            this.EndDatePanel.TabIndex = 1;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EndDateLabel.Location = new System.Drawing.Point(11, 10);
            this.EndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(61, 16);
            this.EndDateLabel.TabIndex = 0;
            this.EndDateLabel.Text = "End date";
            // 
            // EndDateValue
            // 
            this.EndDateValue.AutoSize = true;
            this.EndDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.EndDateValue.ForeColor = System.Drawing.Color.White;
            this.EndDateValue.Location = new System.Drawing.Point(11, 30);
            this.EndDateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDateValue.Name = "EndDateValue";
            this.EndDateValue.Size = new System.Drawing.Size(0, 23);
            this.EndDateValue.TabIndex = 1;
            // 
            // DeadlinePanel
            // 
            this.DeadlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeadlinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeadlinePanel.Controls.Add(this.DeadlineLabel);
            this.DeadlinePanel.Controls.Add(this.DeadlineValue);
            this.DeadlinePanel.Location = new System.Drawing.Point(0, 69);
            this.DeadlinePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeadlinePanel.Name = "DeadlinePanel";
            this.DeadlinePanel.Size = new System.Drawing.Size(559, 54);
            this.DeadlinePanel.TabIndex = 2;
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DeadlineLabel.Location = new System.Drawing.Point(11, 10);
            this.DeadlineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(130, 16);
            this.DeadlineLabel.TabIndex = 0;
            this.DeadlineLabel.Text = "Application deadline";
            // 
            // DeadlineValue
            // 
            this.DeadlineValue.AutoSize = true;
            this.DeadlineValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DeadlineValue.ForeColor = System.Drawing.Color.White;
            this.DeadlineValue.Location = new System.Drawing.Point(11, 30);
            this.DeadlineValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeadlineValue.Name = "DeadlineValue";
            this.DeadlineValue.Size = new System.Drawing.Size(0, 23);
            this.DeadlineValue.TabIndex = 1;
            // 
            // TotalSlotsPanel
            // 
            this.TotalSlotsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TotalSlotsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSlotsPanel.Controls.Add(this.TotalSlotsLabel);
            this.TotalSlotsPanel.Controls.Add(this.TotalSlotsValue);
            this.TotalSlotsPanel.Location = new System.Drawing.Point(597, 69);
            this.TotalSlotsPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TotalSlotsPanel.Name = "TotalSlotsPanel";
            this.TotalSlotsPanel.Size = new System.Drawing.Size(559, 54);
            this.TotalSlotsPanel.TabIndex = 3;
            // 
            // TotalSlotsLabel
            // 
            this.TotalSlotsLabel.AutoSize = true;
            this.TotalSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TotalSlotsLabel.Location = new System.Drawing.Point(11, 10);
            this.TotalSlotsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSlotsLabel.Name = "TotalSlotsLabel";
            this.TotalSlotsLabel.Size = new System.Drawing.Size(122, 16);
            this.TotalSlotsLabel.TabIndex = 0;
            this.TotalSlotsLabel.Text = "Total speaker slots";
            // 
            // TotalSlotsValue
            // 
            this.TotalSlotsValue.AutoSize = true;
            this.TotalSlotsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TotalSlotsValue.ForeColor = System.Drawing.Color.White;
            this.TotalSlotsValue.Location = new System.Drawing.Point(11, 30);
            this.TotalSlotsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalSlotsValue.Name = "TotalSlotsValue";
            this.TotalSlotsValue.Size = new System.Drawing.Size(0, 23);
            this.TotalSlotsValue.TabIndex = 1;
            // 
            // SpeakerSlotsLabel
            // 
            this.SpeakerSlotsLabel.AutoSize = true;
            this.SpeakerSlotsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SpeakerSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SpeakerSlotsLabel.Location = new System.Drawing.Point(21, 261);
            this.SpeakerSlotsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SpeakerSlotsLabel.Name = "SpeakerSlotsLabel";
            this.SpeakerSlotsLabel.Size = new System.Drawing.Size(138, 23);
            this.SpeakerSlotsLabel.TabIndex = 4;
            this.SpeakerSlotsLabel.Text = "SPEAKER SLOTS";
            // 
            // SlotsFlowPanel
            // 
            this.SlotsFlowPanel.AutoScroll = true;
            this.SlotsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SlotsFlowPanel.Location = new System.Drawing.Point(21, 290);
            this.SlotsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SlotsFlowPanel.Name = "SlotsFlowPanel";
            this.SlotsFlowPanel.Size = new System.Drawing.Size(1184, 394);
            this.SlotsFlowPanel.TabIndex = 5;
            this.SlotsFlowPanel.WrapContents = false;
            // 
            // LogoutLabel
            // 
            this.LogoutLabel.AutoSize = true;
            this.LogoutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LogoutLabel.Location = new System.Drawing.Point(1209, 886);
            this.LogoutLabel.Name = "LogoutLabel";
            this.LogoutLabel.Size = new System.Drawing.Size(60, 20);
            this.LogoutLabel.TabIndex = 5;
            this.LogoutLabel.TabStop = true;
            this.LogoutLabel.Text = "Logout";
            this.LogoutLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LogoutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabel_LinkClicked);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1333, 935);
            this.Controls.Add(this.LogoutLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.StartNewButton);
            this.Controls.Add(this.CardPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerMainForm";
            this.Text = "Conference";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagerMainForm_FormClosed);
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.OverviewPanel.ResumeLayout(false);
            this.LocationPanel.ResumeLayout(false);
            this.LocationPanel.PerformLayout();
            this.StatsPanel.ResumeLayout(false);
            this.StartDatePanel.ResumeLayout(false);
            this.StartDatePanel.PerformLayout();
            this.EndDatePanel.ResumeLayout(false);
            this.EndDatePanel.PerformLayout();
            this.DeadlinePanel.ResumeLayout(false);
            this.DeadlinePanel.PerformLayout();
            this.TotalSlotsPanel.ResumeLayout(false);
            this.TotalSlotsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogoutLabel;
    }
}