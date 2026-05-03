namespace WAM_Coursework.Forms
{
    partial class SubmitTalkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label TalkTitleLabel;
        private System.Windows.Forms.TextBox TalkTitleTextBox;
        private System.Windows.Forms.Label TalkDescriptionLabel;
        private System.Windows.Forms.TextBox TalkDescriptionTextBox;
        private System.Windows.Forms.Button SubmitButton;

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
            this.CardPanel = new System.Windows.Forms.Panel();
            this.TalkTitleLabel = new System.Windows.Forms.Label();
            this.TalkTitleTextBox = new System.Windows.Forms.TextBox();
            this.TalkDescriptionLabel = new System.Windows.Forms.Label();
            this.TalkDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(660, 44);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(420, 112);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(697, 185);
            this.SubtitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(259, 38);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Speaker application";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.TalkTitleLabel);
            this.CardPanel.Controls.Add(this.TalkTitleTextBox);
            this.CardPanel.Controls.Add(this.TalkDescriptionLabel);
            this.CardPanel.Controls.Add(this.TalkDescriptionTextBox);
            this.CardPanel.Controls.Add(this.SubmitButton);
            this.CardPanel.Location = new System.Drawing.Point(330, 258);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(988, 774);
            this.CardPanel.TabIndex = 2;
            // 
            // TalkTitleLabel
            // 
            this.TalkTitleLabel.AutoSize = true;
            this.TalkTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TalkTitleLabel.Location = new System.Drawing.Point(44, 44);
            this.TalkTitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TalkTitleLabel.Name = "TalkTitleLabel";
            this.TalkTitleLabel.Size = new System.Drawing.Size(137, 25);
            this.TalkTitleLabel.TabIndex = 0;
            this.TalkTitleLabel.Text = "Title of the talk";
            // 
            // TalkTitleTextBox
            // 
            this.TalkTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TalkTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TalkTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.TalkTitleTextBox.Location = new System.Drawing.Point(44, 81);
            this.TalkTitleTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TalkTitleTextBox.Name = "TalkTitleTextBox";
            this.TalkTitleTextBox.Size = new System.Drawing.Size(893, 29);
            this.TalkTitleTextBox.TabIndex = 1;
            // 
            // TalkDescriptionLabel
            // 
            this.TalkDescriptionLabel.AutoSize = true;
            this.TalkDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TalkDescriptionLabel.Location = new System.Drawing.Point(44, 155);
            this.TalkDescriptionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TalkDescriptionLabel.Name = "TalkDescriptionLabel";
            this.TalkDescriptionLabel.Size = new System.Drawing.Size(149, 25);
            this.TalkDescriptionLabel.TabIndex = 2;
            this.TalkDescriptionLabel.Text = "Talk description";
            // 
            // TalkDescriptionTextBox
            // 
            this.TalkDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TalkDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TalkDescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.TalkDescriptionTextBox.Location = new System.Drawing.Point(44, 192);
            this.TalkDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TalkDescriptionTextBox.Multiline = true;
            this.TalkDescriptionTextBox.Name = "TalkDescriptionTextBox";
            this.TalkDescriptionTextBox.Size = new System.Drawing.Size(893, 294);
            this.TalkDescriptionTextBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(44, 517);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(895, 66);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit application";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SubmitTalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1650, 1292);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SubmitTalkForm";
            this.Text = "Submit application";
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}