namespace WAM_Coursework.Forms
{
    partial class LoginForm
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
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.LogInLabel = new System.Windows.Forms.Label();
            this.LoginLayoutTable = new System.Windows.Forms.TableLayoutPanel();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogInButton = new System.Windows.Forms.Button();
            this.LoginLayoutTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(198, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 65);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "F@irView";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogInLabel
            // 
            this.LogInLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogInLabel.AutoSize = true;
            this.LogInLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.LogInLabel.Location = new System.Drawing.Point(237, 93);
            this.LogInLabel.Name = "LogInLabel";
            this.LogInLabel.Size = new System.Drawing.Size(165, 21);
            this.LogInLabel.TabIndex = 3;
            this.LogInLabel.Text = "Log in to your account";
            this.LogInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginLayoutTable
            // 
            this.LoginLayoutTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginLayoutTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.LoginLayoutTable.ColumnCount = 1;
            this.LoginLayoutTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LoginLayoutTable.Controls.Add(this.PasswordLabel, 0, 2);
            this.LoginLayoutTable.Controls.Add(this.EmailLabel, 0, 0);
            this.LoginLayoutTable.Controls.Add(this.EmailTextBox, 0, 1);
            this.LoginLayoutTable.Controls.Add(this.PasswordTextBox, 0, 3);
            this.LoginLayoutTable.Controls.Add(this.LogInButton, 0, 5);
            this.LoginLayoutTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.LoginLayoutTable.Location = new System.Drawing.Point(152, 183);
            this.LoginLayoutTable.Name = "LoginLayoutTable";
            this.LoginLayoutTable.RowCount = 6;
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LoginLayoutTable.Size = new System.Drawing.Size(328, 214);
            this.LoginLayoutTable.TabIndex = 4;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PasswordLabel.Location = new System.Drawing.Point(10, 68);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(93, 28);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.EmailLabel.Location = new System.Drawing.Point(10, 5);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(59, 28);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.EmailTextBox.Location = new System.Drawing.Point(10, 38);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(277, 20);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.Text = "Enter your email";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTextBox.Location = new System.Drawing.Point(10, 101);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(277, 20);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInButton.BackColor = System.Drawing.Color.SteelBlue;
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LogInButton.FlatAppearance.BorderSize = 0;
            this.LogInButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.ForeColor = System.Drawing.Color.White;
            this.LogInButton.Location = new System.Drawing.Point(10, 136);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(10);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(308, 68);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Log in";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(678, 664);
            this.Controls.Add(this.LoginLayoutTable);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.LogInLabel);
            this.Name = "LoginForm";
            this.Text = "Log in";
            this.LoginLayoutTable.ResumeLayout(false);
            this.LoginLayoutTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label LogInLabel;
        private System.Windows.Forms.TableLayoutPanel LoginLayoutTable;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Button LogInButton;
    }
}