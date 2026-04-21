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
        private System.Windows.Forms.Button NewApplicationButton;
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
            this.components = new System.ComponentModel.Container();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.NewApplicationButton = new System.Windows.Forms.Button();
            this.CardContainerPanel = new System.Windows.Forms.Panel();
            this.ApplicationsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // SpeakerMainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.Name = "SpeakerMainForm";
            this.Text = "My applications";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(32, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(220, 51);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
            this.SubtitleLabel.Location = new System.Drawing.Point(34, 84);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(120, 19);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "My applications";
            // 
            // NewApplicationButton
            // 
            this.NewApplicationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewApplicationButton.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.NewApplicationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewApplicationButton.ForeColor = System.Drawing.Color.White;
            this.NewApplicationButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NewApplicationButton.Location = new System.Drawing.Point(660, 40);
            this.NewApplicationButton.Name = "NewApplicationButton";
            this.NewApplicationButton.Size = new System.Drawing.Size(200, 36);
            this.NewApplicationButton.TabIndex = 2;
            this.NewApplicationButton.Text = "+ New application";
            this.NewApplicationButton.UseVisualStyleBackColor = false;
            // 
            // CardContainerPanel
            // 
            this.CardContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.CardContainerPanel.Location = new System.Drawing.Point(32, 120);
            this.CardContainerPanel.Name = "CardContainerPanel";
            this.CardContainerPanel.Size = new System.Drawing.Size(828, 540);
            this.CardContainerPanel.TabIndex = 3;
            // 
            // ApplicationsFlowPanel
            // 
            this.ApplicationsFlowPanel.AutoScroll = true;
            this.ApplicationsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ApplicationsFlowPanel.Location = new System.Drawing.Point(8, 8);
            this.ApplicationsFlowPanel.Name = "ApplicationsFlowPanel";
            this.ApplicationsFlowPanel.Size = new System.Drawing.Size(812, 524);
            this.ApplicationsFlowPanel.TabIndex = 0;
            this.ApplicationsFlowPanel.WrapContents = false;

            // add controls
            this.CardContainerPanel.Controls.Add(this.ApplicationsFlowPanel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.NewApplicationButton);
            this.Controls.Add(this.CardContainerPanel);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}