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
            this.lblTitle.Location = new System.Drawing.Point(416, 43);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(301, 81);
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
            this.lblSubtitle.Location = new System.Drawing.Point(440, 123);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(253, 28);
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(187, 172);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(827, 532);
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
            this.panelSpeaker.Location = new System.Drawing.Point(4, 4);
            this.panelSpeaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSpeaker.Name = "panelSpeaker";
            this.panelSpeaker.Size = new System.Drawing.Size(819, 115);
            this.panelSpeaker.TabIndex = 0;
            this.panelSpeaker.Click += new System.EventHandler(this.SpeakerClick);
            // 
            // pbSpeaker
            // 
            this.pbSpeaker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.pbSpeaker.Location = new System.Drawing.Point(24, 22);
            this.pbSpeaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSpeaker.Name = "pbSpeaker";
            this.pbSpeaker.Size = new System.Drawing.Size(75, 69);
            this.pbSpeaker.TabIndex = 0;
            this.pbSpeaker.TabStop = false;
            this.pbSpeaker.Click += new System.EventHandler(this.SpeakerClick);
            // 
            // lblSpeakerTitle
            // 
            this.lblSpeakerTitle.AutoSize = true;
            this.lblSpeakerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSpeakerTitle.ForeColor = System.Drawing.Color.White;
            this.lblSpeakerTitle.Location = new System.Drawing.Point(127, 25);
            this.lblSpeakerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeakerTitle.Name = "lblSpeakerTitle";
            this.lblSpeakerTitle.Size = new System.Drawing.Size(104, 32);
            this.lblSpeakerTitle.TabIndex = 1;
            this.lblSpeakerTitle.Text = "Speaker";
            this.lblSpeakerTitle.Click += new System.EventHandler(this.SpeakerClick);
            // 
            // lblSpeakerDesc
            // 
            this.lblSpeakerDesc.AutoSize = true;
            this.lblSpeakerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSpeakerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblSpeakerDesc.Location = new System.Drawing.Point(127, 59);
            this.lblSpeakerDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpeakerDesc.Name = "lblSpeakerDesc";
            this.lblSpeakerDesc.Size = new System.Drawing.Size(236, 23);
            this.lblSpeakerDesc.TabIndex = 2;
            this.lblSpeakerDesc.Text = "Submit and track applications";
            this.lblSpeakerDesc.Click += new System.EventHandler(this.SpeakerClick);
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
            this.panelReviewer.Location = new System.Drawing.Point(4, 127);
            this.panelReviewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelReviewer.Name = "panelReviewer";
            this.panelReviewer.Size = new System.Drawing.Size(819, 115);
            this.panelReviewer.TabIndex = 1;
            this.panelReviewer.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // pbReviewer
            // 
            this.pbReviewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pbReviewer.Location = new System.Drawing.Point(24, 22);
            this.pbReviewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbReviewer.Name = "pbReviewer";
            this.pbReviewer.Size = new System.Drawing.Size(75, 69);
            this.pbReviewer.TabIndex = 0;
            this.pbReviewer.TabStop = false;
            this.pbReviewer.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // lblReviewerTitle
            // 
            this.lblReviewerTitle.AutoSize = true;
            this.lblReviewerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblReviewerTitle.ForeColor = System.Drawing.Color.White;
            this.lblReviewerTitle.Location = new System.Drawing.Point(127, 25);
            this.lblReviewerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReviewerTitle.Name = "lblReviewerTitle";
            this.lblReviewerTitle.Size = new System.Drawing.Size(117, 32);
            this.lblReviewerTitle.TabIndex = 1;
            this.lblReviewerTitle.Text = "Reviewer";
            this.lblReviewerTitle.Click += new System.EventHandler(this.ReviewerClick);
            // 
            // lblReviewerDesc
            // 
            this.lblReviewerDesc.AutoSize = true;
            this.lblReviewerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReviewerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblReviewerDesc.Location = new System.Drawing.Point(127, 59);
            this.lblReviewerDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReviewerDesc.Name = "lblReviewerDesc";
            this.lblReviewerDesc.Size = new System.Drawing.Size(158, 23);
            this.lblReviewerDesc.TabIndex = 2;
            this.lblReviewerDesc.Text = "Review applications";
            this.lblReviewerDesc.Click += new System.EventHandler(this.ReviewerClick);
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
            this.panelManager.Location = new System.Drawing.Point(4, 364);
            this.panelManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(819, 164);
            this.panelManager.TabIndex = 2;
            this.panelManager.Click += new System.EventHandler(this.ManagerClick);
            // 
            // pbManager
            // 
            this.pbManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.pbManager.Location = new System.Drawing.Point(24, 25);
            this.pbManager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbManager.Name = "pbManager";
            this.pbManager.Size = new System.Drawing.Size(75, 69);
            this.pbManager.TabIndex = 0;
            this.pbManager.TabStop = false;
            this.pbManager.Click += new System.EventHandler(this.ManagerClick);
            // 
            // lblManagerTitle
            // 
            this.lblManagerTitle.AutoSize = true;
            this.lblManagerTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblManagerTitle.ForeColor = System.Drawing.Color.White;
            this.lblManagerTitle.Location = new System.Drawing.Point(127, 27);
            this.lblManagerTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerTitle.Name = "lblManagerTitle";
            this.lblManagerTitle.Size = new System.Drawing.Size(252, 32);
            this.lblManagerTitle.TabIndex = 1;
            this.lblManagerTitle.Text = "Conference manager";
            this.lblManagerTitle.Click += new System.EventHandler(this.ManagerClick);
            // 
            // lblManagerDesc
            // 
            this.lblManagerDesc.AutoSize = true;
            this.lblManagerDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblManagerDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblManagerDesc.Location = new System.Drawing.Point(127, 62);
            this.lblManagerDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManagerDesc.Name = "lblManagerDesc";
            this.lblManagerDesc.Size = new System.Drawing.Size(122, 23);
            this.lblManagerDesc.TabIndex = 2;
            this.lblManagerDesc.Text = "Administration";
            this.lblManagerDesc.Click += new System.EventHandler(this.ManagerClick);
            // 
            // SignUpLink
            // 
            this.SignUpLink.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.SignUpLink.Location = new System.Drawing.Point(441, 724);
            this.SignUpLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(194, 16);
            this.SignUpLink.TabIndex = 3;
            this.SignUpLink.TabStop = true;
            this.SignUpLink.Text = "Don\'t have an account? Sign up";
            this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1200, 862);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.SignUpLink);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomeForm";
            this.Text = "F@irView";
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

