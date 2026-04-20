namespace WAM_Coursework
{
    partial class WelcomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelSpeaker;
        private System.Windows.Forms.PictureBox pbSpeaker;
        private System.Windows.Forms.Label lblSpeakerTitle;
        private System.Windows.Forms.Label lblSpeakerDesc;
        private System.Windows.Forms.Panel panelReviewer;
        private System.Windows.Forms.PictureBox pbReviewer;
        private System.Windows.Forms.Label lblReviewerTitle;
        private System.Windows.Forms.Label lblReviewerDesc;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.PictureBox pbManager;
        private System.Windows.Forms.Label lblManagerTitle;
        private System.Windows.Forms.Label lblManagerDesc;
        private System.Windows.Forms.LinkLabel SignUpLink;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelSpeaker = new System.Windows.Forms.Panel();
            this.pbSpeaker = new System.Windows.Forms.PictureBox();
            this.lblSpeakerTitle = new System.Windows.Forms.Label();
            this.lblSpeakerDesc = new System.Windows.Forms.Label();
            this.panelReviewer = new System.Windows.Forms.Panel();
            this.pbReviewer = new System.Windows.Forms.PictureBox();
            this.lblReviewerTitle = new System.Windows.Forms.Label();
            this.lblReviewerDesc = new System.Windows.Forms.Label();
            this.panelManager = new System.Windows.Forms.Panel();
            this.pbManager = new System.Windows.Forms.PictureBox();
            this.lblManagerTitle = new System.Windows.Forms.Label();
            this.lblManagerDesc = new System.Windows.Forms.Label();
            this.SignUpLink = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel.SuspendLayout();
            this.panelSpeaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeaker)).BeginInit();
            this.panelReviewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReviewer)).BeginInit();
            this.panelManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(312, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "F@irView";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSubtitle.Location = new System.Drawing.Point(330, 100);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(200, 21);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Select your role to continue";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.panelSpeaker, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panelReviewer, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelManager, 0, 2);
            this.tableLayoutPanel.Location = new System.Drawing.Point(140, 140);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(620, 432);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // panelSpeaker
            // 
            this.panelSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelSpeaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSpeaker.Controls.Add(this.pbSpeaker);
            this.panelSpeaker.Controls.Add(this.lblSpeakerTitle);
            this.panelSpeaker.Controls.Add(this.lblSpeakerDesc);
            this.panelSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelSpeaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSpeaker.Location = new System.Drawing.Point(3, 3);
            this.panelSpeaker.Name = "panelSpeaker";
            this.panelSpeaker.Size = new System.Drawing.Size(614, 94);
            this.panelSpeaker.TabIndex = 0;
            this.panelSpeaker.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // pbSpeaker
            // 
            this.pbSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pbSpeaker.Location = new System.Drawing.Point(18, 18);
            this.pbSpeaker.Name = "pbSpeaker";
            this.pbSpeaker.Size = new System.Drawing.Size(56, 56);
            this.pbSpeaker.TabIndex = 0;
            this.pbSpeaker.TabStop = false;
            this.pbSpeaker.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // lblSpeakerTitle
            // 
            this.lblSpeakerTitle.AutoSize = true;
            this.lblSpeakerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSpeakerTitle.ForeColor = System.Drawing.Color.White;
            this.lblSpeakerTitle.Location = new System.Drawing.Point(95, 20);
            this.lblSpeakerTitle.Name = "lblSpeakerTitle";
            this.lblSpeakerTitle.Size = new System.Drawing.Size(84, 25);
            this.lblSpeakerTitle.TabIndex = 1;
            this.lblSpeakerTitle.Text = "Speaker";
            this.lblSpeakerTitle.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // lblSpeakerDesc
            // 
            this.lblSpeakerDesc.AutoSize = true;
            this.lblSpeakerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSpeakerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSpeakerDesc.Location = new System.Drawing.Point(95, 48);
            this.lblSpeakerDesc.Name = "lblSpeakerDesc";
            this.lblSpeakerDesc.Size = new System.Drawing.Size(189, 19);
            this.lblSpeakerDesc.TabIndex = 2;
            this.lblSpeakerDesc.Text = "Submit and track applications";
            this.lblSpeakerDesc.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // panelReviewer
            // 
            this.panelReviewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelReviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReviewer.Controls.Add(this.pbReviewer);
            this.panelReviewer.Controls.Add(this.lblReviewerTitle);
            this.panelReviewer.Controls.Add(this.lblReviewerDesc);
            this.panelReviewer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelReviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReviewer.Location = new System.Drawing.Point(3, 103);
            this.panelReviewer.Name = "panelReviewer";
            this.panelReviewer.Size = new System.Drawing.Size(614, 94);
            this.panelReviewer.TabIndex = 1;
            // 
            // pbReviewer
            // 
            this.pbReviewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pbReviewer.Location = new System.Drawing.Point(18, 18);
            this.pbReviewer.Name = "pbReviewer";
            this.pbReviewer.Size = new System.Drawing.Size(56, 56);
            this.pbReviewer.TabIndex = 0;
            this.pbReviewer.TabStop = false;
            // 
            // lblReviewerTitle
            // 
            this.lblReviewerTitle.AutoSize = true;
            this.lblReviewerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReviewerTitle.ForeColor = System.Drawing.Color.White;
            this.lblReviewerTitle.Location = new System.Drawing.Point(95, 20);
            this.lblReviewerTitle.Name = "lblReviewerTitle";
            this.lblReviewerTitle.Size = new System.Drawing.Size(92, 25);
            this.lblReviewerTitle.TabIndex = 1;
            this.lblReviewerTitle.Text = "Reviewer";
            // 
            // lblReviewerDesc
            // 
            this.lblReviewerDesc.AutoSize = true;
            this.lblReviewerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReviewerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblReviewerDesc.Location = new System.Drawing.Point(95, 48);
            this.lblReviewerDesc.Name = "lblReviewerDesc";
            this.lblReviewerDesc.Size = new System.Drawing.Size(127, 19);
            this.lblReviewerDesc.TabIndex = 2;
            this.lblReviewerDesc.Text = "Review applications";
            // 
            // panelManager
            // 
            this.panelManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelManager.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManager.Controls.Add(this.pbManager);
            this.panelManager.Controls.Add(this.lblManagerTitle);
            this.panelManager.Controls.Add(this.lblManagerDesc);
            this.panelManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelManager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelManager.Location = new System.Drawing.Point(3, 295);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(614, 134);
            this.panelManager.TabIndex = 2;
            // 
            // pbManager
            // 
            this.pbManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.pbManager.Location = new System.Drawing.Point(18, 20);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(56, 56);
            this.pbManager.TabIndex = 0;
            this.pbManager.TabStop = false;
            // 
            // lblManagerTitle
            // 
            this.lblManagerTitle.AutoSize = true;
            this.lblManagerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblManagerTitle.ForeColor = System.Drawing.Color.White;
            this.lblManagerTitle.Location = new System.Drawing.Point(95, 22);
            this.lblManagerTitle.Name = "lblManagerTitle";
            this.lblManagerTitle.Size = new System.Drawing.Size(198, 25);
            this.lblManagerTitle.TabIndex = 1;
            this.lblManagerTitle.Text = "Conference manager";
            // 
            // lblManagerDesc
            // 
            this.lblManagerDesc.AutoSize = true;
            this.lblManagerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblManagerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblManagerDesc.Location = new System.Drawing.Point(95, 50);
            this.lblManagerDesc.Name = "lblManagerDesc";
            this.lblManagerDesc.Size = new System.Drawing.Size(99, 19);
            this.lblManagerDesc.TabIndex = 2;
            this.lblManagerDesc.Text = "Administration";
            // 
            // SignUpLink
            // 
            this.SignUpLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.SignUpLink.Location = new System.Drawing.Point(331, 588);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(161, 13);
            this.SignUpLink.TabIndex = 3;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Don\'t have an account? Sign up";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.SignUpLink);
            this.Name = "WelcomeForm";
            this.Text = "F@airView";
            this.tableLayoutPanel.ResumeLayout(false);
            this.panelSpeaker.ResumeLayout(false);
            this.panelSpeaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeaker)).EndInit();
            this.panelReviewer.ResumeLayout(false);
            this.panelReviewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReviewer)).EndInit();
            this.panelManager.ResumeLayout(false);
            this.panelManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

