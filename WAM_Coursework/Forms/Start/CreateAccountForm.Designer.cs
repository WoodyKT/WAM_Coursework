namespace WAM_Coursework.Forms
{
    partial class CreateAccountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Panel CardPanel;
        private System.Windows.Forms.Button SpeakerButton;
        private System.Windows.Forms.Button ReviewerButton;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ConfirmLabel;
        private System.Windows.Forms.TextBox ConfirmTextBox;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.LinkLabel SignInLinkLabel;

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
            this.AffiliationLabel = new System.Windows.Forms.Label();
            this.AffiliationTextBox = new System.Windows.Forms.TextBox();
            this.SpeakerButton = new System.Windows.Forms.Button();
            this.ReviewerButton = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmLabel = new System.Windows.Forms.Label();
            this.ConfirmTextBox = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(623, 43);
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
            this.SubtitleLabel.Size = new System.Drawing.Size(266, 38);
            this.SubtitleLabel.TabIndex = 1;
            this.SubtitleLabel.Text = "Create your account";
            this.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardPanel
            // 
            this.CardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CardPanel.Controls.Add(this.AffiliationLabel);
            this.CardPanel.Controls.Add(this.AffiliationTextBox);
            this.CardPanel.Controls.Add(this.SpeakerButton);
            this.CardPanel.Controls.Add(this.ReviewerButton);
            this.CardPanel.Controls.Add(this.FirstNameLabel);
            this.CardPanel.Controls.Add(this.LastNameLabel);
            this.CardPanel.Controls.Add(this.FirstNameTextBox);
            this.CardPanel.Controls.Add(this.LastNameTextBox);
            this.CardPanel.Controls.Add(this.EmailLabel);
            this.CardPanel.Controls.Add(this.EmailTextBox);
            this.CardPanel.Controls.Add(this.PasswordLabel);
            this.CardPanel.Controls.Add(this.PasswordTextBox);
            this.CardPanel.Controls.Add(this.ConfirmLabel);
            this.CardPanel.Controls.Add(this.ConfirmTextBox);
            this.CardPanel.Controls.Add(this.SignUpButton);
            this.CardPanel.Location = new System.Drawing.Point(330, 258);
            this.CardPanel.Margin = new System.Windows.Forms.Padding(6);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(988, 858);
            this.CardPanel.TabIndex = 2;
            // 
            // AffiliationLabel
            // 
            this.AffiliationLabel.AutoSize = true;
            this.AffiliationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AffiliationLabel.Location = new System.Drawing.Point(66, 604);
            this.AffiliationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AffiliationLabel.Name = "AffiliationLabel";
            this.AffiliationLabel.Size = new System.Drawing.Size(410, 25);
            this.AffiliationLabel.TabIndex = 9;
            this.AffiliationLabel.Text = "Affiliation (company, academic institution, etc.)";
            // 
            // AffiliationTextBox
            // 
            this.AffiliationTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.AffiliationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AffiliationTextBox.ForeColor = System.Drawing.Color.White;
            this.AffiliationTextBox.Location = new System.Drawing.Point(66, 641);
            this.AffiliationTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AffiliationTextBox.Name = "AffiliationTextBox";
            this.AffiliationTextBox.Size = new System.Drawing.Size(842, 29);
            this.AffiliationTextBox.TabIndex = 10;
            // 
            // SpeakerButton
            // 
            this.SpeakerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(220)))));
            this.SpeakerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SpeakerButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SpeakerButton.ForeColor = System.Drawing.Color.White;
            this.SpeakerButton.Location = new System.Drawing.Point(66, 52);
            this.SpeakerButton.Margin = new System.Windows.Forms.Padding(6);
            this.SpeakerButton.Name = "SpeakerButton";
            this.SpeakerButton.Size = new System.Drawing.Size(403, 74);
            this.SpeakerButton.TabIndex = 0;
            this.SpeakerButton.Text = "Speaker";
            this.SpeakerButton.UseVisualStyleBackColor = false;
            this.SpeakerButton.Click += new System.EventHandler(this.BtnSpeaker_Click);
            // 
            // ReviewerButton
            // 
            this.ReviewerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ReviewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewerButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ReviewerButton.ForeColor = System.Drawing.Color.White;
            this.ReviewerButton.Location = new System.Drawing.Point(506, 52);
            this.ReviewerButton.Margin = new System.Windows.Forms.Padding(6);
            this.ReviewerButton.Name = "ReviewerButton";
            this.ReviewerButton.Size = new System.Drawing.Size(403, 74);
            this.ReviewerButton.TabIndex = 1;
            this.ReviewerButton.Text = "Reviewer";
            this.ReviewerButton.UseVisualStyleBackColor = false;
            this.ReviewerButton.Click += new System.EventHandler(this.BtnReviewer_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(66, 166);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(103, 25);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LastNameLabel.Location = new System.Drawing.Point(506, 166);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(103, 25);
            this.LastNameLabel.TabIndex = 3;
            this.LastNameLabel.Text = "Last name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstNameTextBox.ForeColor = System.Drawing.Color.White;
            this.FirstNameTextBox.Location = new System.Drawing.Point(66, 203);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(402, 29);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LastNameTextBox.ForeColor = System.Drawing.Color.White;
            this.LastNameTextBox.Location = new System.Drawing.Point(506, 203);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(402, 29);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EmailLabel.Location = new System.Drawing.Point(66, 277);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(135, 25);
            this.EmailLabel.TabIndex = 4;
            this.EmailLabel.Text = "Email address";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.Color.White;
            this.EmailTextBox.Location = new System.Drawing.Point(66, 314);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(842, 29);
            this.EmailTextBox.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PasswordLabel.Location = new System.Drawing.Point(66, 388);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.PasswordTextBox.Location = new System.Drawing.Point(66, 425);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(842, 29);
            this.PasswordTextBox.TabIndex = 5;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConfirmLabel.Location = new System.Drawing.Point(66, 498);
            this.ConfirmLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(169, 25);
            this.ConfirmLabel.TabIndex = 8;
            this.ConfirmLabel.Text = "Confirm password";
            // 
            // ConfirmTextBox
            // 
            this.ConfirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ConfirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmTextBox.ForeColor = System.Drawing.Color.White;
            this.ConfirmTextBox.Location = new System.Drawing.Point(66, 535);
            this.ConfirmTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ConfirmTextBox.Name = "ConfirmTextBox";
            this.ConfirmTextBox.Size = new System.Drawing.Size(842, 29);
            this.ConfirmTextBox.TabIndex = 6;
            this.ConfirmTextBox.UseSystemPasswordChar = true;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SignUpButton.FlatAppearance.BorderSize = 0;
            this.SignUpButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(65, 742);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(6);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(843, 66);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // SignInLinkLabel
            // 
            this.SignInLinkLabel.AutoSize = true;
            this.SignInLinkLabel.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.SignInLinkLabel.Location = new System.Drawing.Point(674, 1166);
            this.SignInLinkLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SignInLinkLabel.Name = "SignInLinkLabel";
            this.SignInLinkLabel.Size = new System.Drawing.Size(304, 25);
            this.SignInLinkLabel.TabIndex = 8;
            this.SignInLinkLabel.TabStop = true;
            this.SignInLinkLabel.Text = "Already have an account? Sign in";
            this.SignInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSignIn_LinkClicked);
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1650, 1329);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.SignInLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateAccountForm";
            this.Text = "Create account";
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AffiliationLabel;
        private System.Windows.Forms.TextBox AffiliationTextBox;
    }
}
