
namespace ContactsApp.View
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.ContactsApp = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.GitHub = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.linkEmail = new System.Windows.Forms.LinkLabel();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ContactsApp
            // 
            this.ContactsApp.AutoSize = true;
            this.ContactsApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsApp.Location = new System.Drawing.Point(48, 29);
            this.ContactsApp.Name = "ContactsApp";
            this.ContactsApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactsApp.Size = new System.Drawing.Size(261, 46);
            this.ContactsApp.TabIndex = 0;
            this.ContactsApp.Text = "ContactsApp";
            this.ContactsApp.Click += new System.EventHandler(this.label1_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.version.Location = new System.Drawing.Point(55, 79);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(61, 20);
            this.version.TabIndex = 1;
            this.version.Text = "v. 1.0.0";
            this.version.Click += new System.EventHandler(this.label2_Click);
            // 
            // Author
            // 
            this.Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(55, 152);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(178, 20);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author: Michail Maikov";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(55, 221);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(157, 20);
            this.email.TabIndex = 3;
            this.email.Text = "e-mail for feedback:";
            this.email.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // GitHub
            // 
            this.GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GitHub.AutoSize = true;
            this.GitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHub.Location = new System.Drawing.Point(55, 257);
            this.GitHub.Name = "GitHub";
            this.GitHub.Size = new System.Drawing.Size(67, 20);
            this.GitHub.TabIndex = 4;
            this.GitHub.Text = "GitHub:";
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(61, 405);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(177, 20);
            this.Date.TabIndex = 5;
            this.Date.Text = "2022 Michail Maikov ©";
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // linkEmail
            // 
            this.linkEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEmail.AutoSize = true;
            this.linkEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkEmail.Location = new System.Drawing.Point(218, 221);
            this.linkEmail.Name = "linkEmail";
            this.linkEmail.Size = new System.Drawing.Size(198, 20);
            this.linkEmail.TabIndex = 6;
            this.linkEmail.TabStop = true;
            this.linkEmail.Text = "zaroggaming@gmail.com";
            // 
            // linkGitHub
            // 
            this.linkGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkGitHub.Location = new System.Drawing.Point(128, 257);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(215, 20);
            this.linkGitHub.TabIndex = 7;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "MichailMaikov/ContactsApp";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.linkEmail);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.GitHub);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.version);
            this.Controls.Add(this.ContactsApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsApp;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label GitHub;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.LinkLabel linkEmail;
        private System.Windows.Forms.LinkLabel linkGitHub;
    }
}