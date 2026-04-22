namespace WAM_Coursework.Forms
{
    partial class SubmitReviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Label AppTitleLabel;
        private System.Windows.Forms.Label AppDescriptionLabel;
        private System.Windows.Forms.TextBox AppDescriptionTextBox;
        private System.Windows.Forms.Panel ReviewPanel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.ComboBox ScoreComboBox;
        private System.Windows.Forms.Label ReasonLabel;
        private System.Windows.Forms.TextBox ReasonTextBox;
        private System.Windows.Forms.Button SubmitReviewButton;

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
            this.AppTitleLabel = new System.Windows.Forms.Label();
            this.AppDescriptionLabel = new System.Windows.Forms.Label();
            this.AppDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ReviewPanel = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreComboBox = new System.Windows.Forms.ComboBox();
            this.ReasonLabel = new System.Windows.Forms.Label();
            this.ReasonTextBox = new System.Windows.Forms.TextBox();
            this.SubmitReviewButton = new System.Windows.Forms.Button();
            this.CardPanel.SuspendLayout();
            this.ReviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(32, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 51);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "F@irView";
            // 
            // SubtitleLabel
            // 
            this.SubtitleLabel.AutoSize = true;
            this.SubtitleLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SubtitleLabel.Location = new System.Drawing.Point(34, 84);
            this.SubtitleLabel.Name = "SubtitleLabel";
            this.SubtitleLabel.Size = new System.Drawing.Size(121, 19);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Review application";
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.AppTitleLabel);
            this.CardPanel.Controls.Add(this.AppDescriptionLabel);
            this.CardPanel.Controls.Add(this.AppDescriptionTextBox);
            this.CardPanel.Location = new System.Drawing.Point(32, 120);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(828, 180);
            this.CardPanel.TabIndex = 2;
            // 
            // AppTitleLabel
            // 
            this.AppTitleLabel.AutoSize = true;
            this.AppTitleLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.AppTitleLabel.ForeColor = System.Drawing.Color.White;
            this.AppTitleLabel.Location = new System.Drawing.Point(16, 16);
            this.AppTitleLabel.Name = "AppTitleLabel";
            this.AppTitleLabel.Size = new System.Drawing.Size(145, 25);
            this.AppTitleLabel.TabIndex = 0;
            this.AppTitleLabel.Text = "Title of the talk";
            // 
            // AppDescriptionLabel
            // 
            this.AppDescriptionLabel.AutoSize = true;
            this.AppDescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AppDescriptionLabel.Location = new System.Drawing.Point(16, 48);
            this.AppDescriptionLabel.Name = "AppDescriptionLabel";
            this.AppDescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.AppDescriptionLabel.TabIndex = 1;
            this.AppDescriptionLabel.Text = "Description";
            // 
            // AppDescriptionTextBox
            // 
            this.AppDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.AppDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AppDescriptionTextBox.ForeColor = System.Drawing.Color.White;
            this.AppDescriptionTextBox.Location = new System.Drawing.Point(16, 70);
            this.AppDescriptionTextBox.Multiline = true;
            this.AppDescriptionTextBox.Name = "AppDescriptionTextBox";
            this.AppDescriptionTextBox.ReadOnly = true;
            this.AppDescriptionTextBox.Size = new System.Drawing.Size(788, 90);
            this.AppDescriptionTextBox.TabIndex = 2;
            // 
            // ReviewPanel
            // 
            this.ReviewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ReviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReviewPanel.Controls.Add(this.ScoreLabel);
            this.ReviewPanel.Controls.Add(this.ScoreComboBox);
            this.ReviewPanel.Controls.Add(this.ReasonLabel);
            this.ReviewPanel.Controls.Add(this.ReasonTextBox);
            this.ReviewPanel.Controls.Add(this.SubmitReviewButton);
            this.ReviewPanel.Location = new System.Drawing.Point(32, 320);
            this.ReviewPanel.Name = "ReviewPanel";
            this.ReviewPanel.Size = new System.Drawing.Size(828, 300);
            this.ReviewPanel.TabIndex = 3;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ScoreLabel.Location = new System.Drawing.Point(16, 16);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(65, 13);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score (1-10)";
            // 
            // ScoreComboBox
            // 
            this.ScoreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ScoreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScoreComboBox.ForeColor = System.Drawing.Color.White;
            this.ScoreComboBox.FormattingEnabled = true;
            this.ScoreComboBox.Location = new System.Drawing.Point(16, 36);
            this.ScoreComboBox.MaxDropDownItems = 11;
            this.ScoreComboBox.Name = "ScoreComboBox";
            this.ScoreComboBox.Size = new System.Drawing.Size(200, 21);
            this.ScoreComboBox.TabIndex = 1;
            // 
            // ReasonLabel
            // 
            this.ReasonLabel.AutoSize = true;
            this.ReasonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ReasonLabel.Location = new System.Drawing.Point(16, 72);
            this.ReasonLabel.Name = "ReasonLabel";
            this.ReasonLabel.Size = new System.Drawing.Size(58, 13);
            this.ReasonLabel.TabIndex = 2;
            this.ReasonLabel.Text = "Reasoning";
            // 
            // ReasonTextBox
            // 
            this.ReasonTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ReasonTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReasonTextBox.ForeColor = System.Drawing.Color.White;
            this.ReasonTextBox.Location = new System.Drawing.Point(16, 92);
            this.ReasonTextBox.Multiline = true;
            this.ReasonTextBox.Name = "ReasonTextBox";
            this.ReasonTextBox.Size = new System.Drawing.Size(788, 160);
            this.ReasonTextBox.TabIndex = 3;
            // 
            // SubmitReviewButton
            // 
            this.SubmitReviewButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SubmitReviewButton.FlatAppearance.BorderSize = 0;
            this.SubmitReviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitReviewButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SubmitReviewButton.ForeColor = System.Drawing.Color.White;
            this.SubmitReviewButton.Location = new System.Drawing.Point(16, 260);
            this.SubmitReviewButton.Name = "SubmitReviewButton";
            this.SubmitReviewButton.Size = new System.Drawing.Size(788, 36);
            this.SubmitReviewButton.TabIndex = 4;
            this.SubmitReviewButton.Text = "Submit review";
            this.SubmitReviewButton.UseVisualStyleBackColor = false;
            this.SubmitReviewButton.Click += new System.EventHandler(this.SubmitReviewButton_Click);
            // 
            // SubmitReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.ReviewPanel);
            this.Name = "SubmitReviewForm";
            this.Text = "Review application";
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ReviewPanel.ResumeLayout(false);
            this.ReviewPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}