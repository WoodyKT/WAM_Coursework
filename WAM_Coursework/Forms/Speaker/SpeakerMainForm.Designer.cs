namespace WAM_Coursework.Forms
{
    partial class SpeakerMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Button NewTalkButton;
        private System.Windows.Forms.Panel CardContainerPanel;
        private System.Windows.Forms.FlowLayoutPanel ApplicationsFlowPanel;

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
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.NewTalkButton = new System.Windows.Forms.Button();
            this.CardContainerPanel = new System.Windows.Forms.Panel();
            this.ApplicationsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CardContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(43, 30);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(234, 62);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(45, 103);
            this.SubtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(129, 23);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "My applications";
            // 
            // NewTalkButton
            // 
            this.NewTalkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewTalkButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NewTalkButton.FlatAppearance.BorderSize = 0;
            this.NewTalkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.NewTalkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTalkButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NewTalkButton.ForeColor = System.Drawing.Color.White;
            this.NewTalkButton.Location = new System.Drawing.Point(880, 49);
            this.NewTalkButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewTalkButton.Name = "NewTalkButton";
            this.NewTalkButton.Size = new System.Drawing.Size(267, 44);
            this.NewTalkButton.TabIndex = 2;
            this.NewTalkButton.Text = "+ New Talk";
            this.NewTalkButton.UseVisualStyleBackColor = false;
            this.NewTalkButton.Click += new System.EventHandler(this.NewTalkButton_Click);
            // 
            // CardContainerPanel
            // 
            this.CardContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.CardContainerPanel.Controls.Add(this.ApplicationsFlowPanel);
            this.CardContainerPanel.Location = new System.Drawing.Point(43, 148);
            this.CardContainerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CardContainerPanel.Name = "CardContainerPanel";
            this.CardContainerPanel.Size = new System.Drawing.Size(1104, 665);
            this.CardContainerPanel.TabIndex = 3;
            // 
            // ApplicationsFlowPanel
            // 
            this.ApplicationsFlowPanel.AutoScroll = true;
            this.ApplicationsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ApplicationsFlowPanel.Location = new System.Drawing.Point(11, 10);
            this.ApplicationsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApplicationsFlowPanel.Name = "ApplicationsFlowPanel";
            this.ApplicationsFlowPanel.Size = new System.Drawing.Size(1083, 645);
            this.ApplicationsFlowPanel.TabIndex = 0;
            this.ApplicationsFlowPanel.WrapContents = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linkLabel1.Location = new System.Drawing.Point(1087, 106);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SpeakerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1200, 862);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.NewTalkButton);
            this.Controls.Add(this.CardContainerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SpeakerMainForm";
            this.Text = "My applications";
            this.CardContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}