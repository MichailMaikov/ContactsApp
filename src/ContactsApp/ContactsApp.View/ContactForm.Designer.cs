
namespace ContactsApp.View
{
    partial class ContactForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLable = new System.Windows.Forms.Label();
            this.VKLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NumberPhoneBox = new System.Windows.Forms.TextBox();
            this.VKBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.DateOfBirthBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(8, 29);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(69, 17);
            this.SurnameLabel.TabIndex = 0;
            this.SurnameLabel.Text = "Surname:";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(28, 57);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Location = new System.Drawing.Point(-2, 84);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(86, 17);
            this.DateOfBirthLabel.TabIndex = 2;
            this.DateOfBirthLabel.Text = "DateOfBirth:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(24, 113);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(53, 17);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLable
            // 
            this.EmailLable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLable.AutoSize = true;
            this.EmailLable.Location = new System.Drawing.Point(26, 141);
            this.EmailLable.Name = "EmailLable";
            this.EmailLable.Size = new System.Drawing.Size(51, 17);
            this.EmailLable.TabIndex = 4;
            this.EmailLable.Text = "E-mail:";
            // 
            // VKLabel
            // 
            this.VKLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKLabel.AutoSize = true;
            this.VKLabel.Location = new System.Drawing.Point(21, 169);
            this.VKLabel.Name = "VKLabel";
            this.VKLabel.Size = new System.Drawing.Size(56, 17);
            this.VKLabel.TabIndex = 5;
            this.VKLabel.Text = "vk.com:";
            // 
            // NameBox
            // 
            this.NameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameBox.Location = new System.Drawing.Point(83, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(705, 22);
            this.NameBox.TabIndex = 6;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // SurNameBox
            // 
            this.SurNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurNameBox.Location = new System.Drawing.Point(83, 26);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(705, 22);
            this.SurNameBox.TabIndex = 7;
            this.SurNameBox.TextChanged += new System.EventHandler(this.SurNameBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailBox.Location = new System.Drawing.Point(83, 138);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(705, 22);
            this.EmailBox.TabIndex = 8;
            this.EmailBox.TextChanged += new System.EventHandler(this.Mail_TextChanged);
            // 
            // NumberPhoneBox
            // 
            this.NumberPhoneBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberPhoneBox.Location = new System.Drawing.Point(83, 110);
            this.NumberPhoneBox.Name = "NumberPhoneBox";
            this.NumberPhoneBox.Size = new System.Drawing.Size(705, 22);
            this.NumberPhoneBox.TabIndex = 9;
            this.NumberPhoneBox.TextChanged += new System.EventHandler(this.PhoneTextBox_TextChanged);
            // 
            // VKBox
            // 
            this.VKBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VKBox.Location = new System.Drawing.Point(83, 166);
            this.VKBox.Name = "VKBox";
            this.VKBox.Size = new System.Drawing.Size(705, 22);
            this.VKBox.TabIndex = 10;
            this.VKBox.TextChanged += new System.EventHandler(this.VKBox_TextChanged_1);
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(632, 415);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 12;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(713, 415);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DateOfBirthBox
            // 
            this.DateOfBirthBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfBirthBox.Location = new System.Drawing.Point(83, 82);
            this.DateOfBirthBox.Name = "DateOfBirthBox";
            this.DateOfBirthBox.Size = new System.Drawing.Size(705, 22);
            this.DateOfBirthBox.TabIndex = 11;
            this.DateOfBirthBox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.DateOfBirthBox);
            this.Controls.Add(this.VKBox);
            this.Controls.Add(this.NumberPhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.VKLabel);
            this.Controls.Add(this.EmailLable);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.DateOfBirthLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SurnameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactForm";
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLable;
        private System.Windows.Forms.Label VKLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NumberPhoneBox;
        private System.Windows.Forms.TextBox VKBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.DateTimePicker DateOfBirthBox;
    }
}