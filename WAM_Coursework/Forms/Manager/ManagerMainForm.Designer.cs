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
            this.TitleLabel.Location = new System.Drawing.Point(32, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(323, 41);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "No Conference Active";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(32, 70);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(121, 19);
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
            this.StartNewButton.Location = new System.Drawing.Point(800, 34);
            this.StartNewButton.Name = "StartNewButton";
            this.StartNewButton.Size = new System.Drawing.Size(140, 36);
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
            this.CardPanel.Location = new System.Drawing.Point(32, 110);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(920, 600);
            this.CardPanel.TabIndex = 3;
            // 
            // OverviewPanel
            // 
            this.OverviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.OverviewPanel.Controls.Add(this.LocationPanel);
            this.OverviewPanel.Controls.Add(this.StatsPanel);
            this.OverviewPanel.Location = new System.Drawing.Point(16, 16);
            this.OverviewPanel.Name = "OverviewPanel";
            this.OverviewPanel.Size = new System.Drawing.Size(888, 180);
            this.OverviewPanel.TabIndex = 0;
            // 
            // LocationPanel
            // 
            this.LocationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LocationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationPanel.Controls.Add(this.LocationLabel);
            this.LocationPanel.Controls.Add(this.LocationValueLabel);
            this.LocationPanel.Location = new System.Drawing.Point(8, 8);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(868, 48);
            this.LocationPanel.TabIndex = 0;
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LocationLabel.Location = new System.Drawing.Point(8, 8);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(48, 13);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location";
            // 
            // LocationValueLabel
            // 
            this.LocationValueLabel.AutoSize = true;
            this.LocationValueLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LocationValueLabel.ForeColor = System.Drawing.Color.White;
            this.LocationValueLabel.Location = new System.Drawing.Point(8, 24);
            this.LocationValueLabel.Name = "LocationValueLabel";
            this.LocationValueLabel.Size = new System.Drawing.Size(0, 19);
            this.LocationValueLabel.TabIndex = 1;
            // 
            // StatsPanel
            // 
            this.StatsPanel.Controls.Add(this.StartDatePanel);
            this.StatsPanel.Controls.Add(this.EndDatePanel);
            this.StatsPanel.Controls.Add(this.DeadlinePanel);
            this.StatsPanel.Controls.Add(this.TotalSlotsPanel);
            this.StatsPanel.Location = new System.Drawing.Point(8, 64);
            this.StatsPanel.Name = "StatsPanel";
            this.StatsPanel.Size = new System.Drawing.Size(868, 100);
            this.StatsPanel.TabIndex = 1;
            // 
            // StartDatePanel
            // 
            this.StartDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDatePanel.Controls.Add(this.StartDateLabel);
            this.StartDatePanel.Controls.Add(this.StartDateValue);
            this.StartDatePanel.Location = new System.Drawing.Point(0, 0);
            this.StartDatePanel.Name = "StartDatePanel";
            this.StartDatePanel.Size = new System.Drawing.Size(420, 44);
            this.StartDatePanel.TabIndex = 0;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.StartDateLabel.Location = new System.Drawing.Point(8, 8);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(53, 13);
            this.StartDateLabel.TabIndex = 0;
            this.StartDateLabel.Text = "Start date";
            // 
            // StartDateValue
            // 
            this.StartDateValue.AutoSize = true;
            this.StartDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.StartDateValue.ForeColor = System.Drawing.Color.White;
            this.StartDateValue.Location = new System.Drawing.Point(8, 24);
            this.StartDateValue.Name = "StartDateValue";
            this.StartDateValue.Size = new System.Drawing.Size(87, 19);
            this.StartDateValue.TabIndex = 1;
            this.StartDateValue.Text = "12 Jun 2026";
            // 
            // EndDatePanel
            // 
            this.EndDatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EndDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndDatePanel.Controls.Add(this.EndDateLabel);
            this.EndDatePanel.Controls.Add(this.EndDateValue);
            this.EndDatePanel.Location = new System.Drawing.Point(448, 0);
            this.EndDatePanel.Name = "EndDatePanel";
            this.EndDatePanel.Size = new System.Drawing.Size(420, 44);
            this.EndDatePanel.TabIndex = 1;
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.EndDateLabel.Location = new System.Drawing.Point(8, 8);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(50, 13);
            this.EndDateLabel.TabIndex = 0;
            this.EndDateLabel.Text = "End date";
            // 
            // EndDateValue
            // 
            this.EndDateValue.AutoSize = true;
            this.EndDateValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.EndDateValue.ForeColor = System.Drawing.Color.White;
            this.EndDateValue.Location = new System.Drawing.Point(8, 24);
            this.EndDateValue.Name = "EndDateValue";
            this.EndDateValue.Size = new System.Drawing.Size(87, 19);
            this.EndDateValue.TabIndex = 1;
            this.EndDateValue.Text = "14 Jun 2026";
            // 
            // DeadlinePanel
            // 
            this.DeadlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DeadlinePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeadlinePanel.Controls.Add(this.DeadlineLabel);
            this.DeadlinePanel.Controls.Add(this.DeadlineValue);
            this.DeadlinePanel.Location = new System.Drawing.Point(0, 56);
            this.DeadlinePanel.Name = "DeadlinePanel";
            this.DeadlinePanel.Size = new System.Drawing.Size(420, 44);
            this.DeadlinePanel.TabIndex = 2;
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DeadlineLabel.Location = new System.Drawing.Point(8, 8);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(102, 13);
            this.DeadlineLabel.TabIndex = 0;
            this.DeadlineLabel.Text = "Application deadline";
            // 
            // DeadlineValue
            // 
            this.DeadlineValue.AutoSize = true;
            this.DeadlineValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.DeadlineValue.ForeColor = System.Drawing.Color.White;
            this.DeadlineValue.Location = new System.Drawing.Point(8, 24);
            this.DeadlineValue.Name = "DeadlineValue";
            this.DeadlineValue.Size = new System.Drawing.Size(94, 19);
            this.DeadlineValue.TabIndex = 1;
            this.DeadlineValue.Text = "30 May 2026";
            // 
            // TotalSlotsPanel
            // 
            this.TotalSlotsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TotalSlotsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalSlotsPanel.Controls.Add(this.TotalSlotsLabel);
            this.TotalSlotsPanel.Controls.Add(this.TotalSlotsValue);
            this.TotalSlotsPanel.Location = new System.Drawing.Point(448, 56);
            this.TotalSlotsPanel.Name = "TotalSlotsPanel";
            this.TotalSlotsPanel.Size = new System.Drawing.Size(420, 44);
            this.TotalSlotsPanel.TabIndex = 3;
            // 
            // TotalSlotsLabel
            // 
            this.TotalSlotsLabel.AutoSize = true;
            this.TotalSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TotalSlotsLabel.Location = new System.Drawing.Point(8, 8);
            this.TotalSlotsLabel.Name = "TotalSlotsLabel";
            this.TotalSlotsLabel.Size = new System.Drawing.Size(96, 13);
            this.TotalSlotsLabel.TabIndex = 0;
            this.TotalSlotsLabel.Text = "Total speaker slots";
            // 
            // TotalSlotsValue
            // 
            this.TotalSlotsValue.AutoSize = true;
            this.TotalSlotsValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.TotalSlotsValue.ForeColor = System.Drawing.Color.White;
            this.TotalSlotsValue.Location = new System.Drawing.Point(8, 24);
            this.TotalSlotsValue.Name = "TotalSlotsValue";
            this.TotalSlotsValue.Size = new System.Drawing.Size(17, 19);
            this.TotalSlotsValue.TabIndex = 1;
            this.TotalSlotsValue.Text = "5";
            // 
            // SpeakerSlotsLabel
            // 
            this.SpeakerSlotsLabel.AutoSize = true;
            this.SpeakerSlotsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SpeakerSlotsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SpeakerSlotsLabel.Location = new System.Drawing.Point(16, 212);
            this.SpeakerSlotsLabel.Name = "SpeakerSlotsLabel";
            this.SpeakerSlotsLabel.Size = new System.Drawing.Size(113, 19);
            this.SpeakerSlotsLabel.TabIndex = 4;
            this.SpeakerSlotsLabel.Text = "SPEAKER SLOTS";
            // 
            // SlotsFlowPanel
            // 
            this.SlotsFlowPanel.AutoScroll = true;
            this.SlotsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SlotsFlowPanel.Location = new System.Drawing.Point(16, 236);
            this.SlotsFlowPanel.Name = "SlotsFlowPanel";
            this.SlotsFlowPanel.Size = new System.Drawing.Size(888, 320);
            this.SlotsFlowPanel.TabIndex = 5;
            this.SlotsFlowPanel.WrapContents = false;
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1000, 760);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.StartNewButton);
            this.Controls.Add(this.CardPanel);
            this.Name = "ManagerMainForm";
            this.Text = "Conference";
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
    }
}