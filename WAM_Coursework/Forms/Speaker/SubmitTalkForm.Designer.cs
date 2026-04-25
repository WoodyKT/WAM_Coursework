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
            this.TitleLabel.Location = new System.Drawing.Point(360, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(242, 65);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(380, 100);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(146, 21);
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
            this.CardPanel.Location = new System.Drawing.Point(180, 140);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(540, 420);
            this.CardPanel.TabIndex = 2;
            // 
            // TalkTitleLabel
            // 
            this.TalkTitleLabel.AutoSize = true;
            this.TalkTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TalkTitleLabel.Location = new System.Drawing.Point(24, 24);
            this.TalkTitleLabel.Name = "TalkTitleLabel";
            this.TalkTitleLabel.Size = new System.Drawing.Size(77, 13);
            this.TalkTitleLabel.TabIndex = 0;
            this.TalkTitleLabel.Text = "Title of the talk";
            // 
            // TalkTitleTextBox
            // 
            this.TalkTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TalkTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TalkTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.TalkTitleTextBox.Location = new System.Drawing.Point(24, 44);
            this.TalkTitleTextBox.Name = "TalkTitleTextBox";
            this.TalkTitleTextBox.Size = new System.Drawing.Size(488, 20);
            this.TalkTitleTextBox.TabIndex = 1;
            // 
            // TalkDescriptionLabel
            // 
            this.TalkDescriptionLabel.AutoSize = true;
            this.TalkDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.TalkDescriptionLabel.Location = new System.Drawing.Point(24, 84);
            this.TalkDescriptionLabel.Name = "TalkDescriptionLabel";
            this.TalkDescriptionLabel.Size = new System.Drawing.Size(82, 13);
            this.TalkDescriptionLabel.TabIndex = 2;
            this.TalkDescriptionLabel.Text = "Talk description";
            // 
            // TalkDescriptionTextBox
            // 
            this.TalkDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TalkDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TalkDescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.TalkDescriptionTextBox.Location = new System.Drawing.Point(24, 104);
            this.TalkDescriptionTextBox.Multiline = true;
            this.TalkDescriptionTextBox.Name = "TalkDescriptionTextBox";
            this.TalkDescriptionTextBox.Size = new System.Drawing.Size(488, 160);
            this.TalkDescriptionTextBox.TabIndex = 3;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(24, 280);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(488, 36);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit application";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SubmitTalkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
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