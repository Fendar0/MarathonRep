namespace Marathon
{
    partial class RunnerProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWallet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPathPhoto = new System.Windows.Forms.TextBox();
            this.cbCountries = new System.Windows.Forms.ComboBox();
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.dtPickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbGenders = new System.Windows.Forms.ComboBox();
            this.maskedtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGoRunner = new System.Windows.Forms.Button();
            this.buttonAdditionProfile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.usersTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.UsersTableAdapter();
            this.runnersTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter();
            this.runnersGenderCountryTableAdapter1 = new Marathon.Marathon_SkillsDataSetTableAdapters.RunnersGenderCountryTableAdapter();
            this.countriesTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.CountriesTableAdapter();
            this.btEdit = new System.Windows.Forms.Button();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work with profile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.lbLogin);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxWallet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 290);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unavailable data";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPassword.Location = new System.Drawing.Point(7, 182);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(21, 26);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "*";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbLogin.Location = new System.Drawing.Point(6, 107);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(21, 26);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "$";
            // 
            // textBoxWallet
            // 
            this.textBoxWallet.Location = new System.Drawing.Point(86, 248);
            this.textBoxWallet.Multiline = true;
            this.textBoxWallet.Name = "textBoxWallet";
            this.textBoxWallet.Size = new System.Drawing.Size(142, 29);
            this.textBoxWallet.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Purse";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbID.Location = new System.Drawing.Point(6, 36);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 26);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "*";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPathPhoto);
            this.groupBox2.Controls.Add(this.cbCountries);
            this.groupBox2.Controls.Add(this.pbPhoto);
            this.groupBox2.Controls.Add(this.buttonPhoto);
            this.groupBox2.Controls.Add(this.dtPickerBirthday);
            this.groupBox2.Controls.Add(this.cbGenders);
            this.groupBox2.Controls.Add(this.maskedtbPhone);
            this.groupBox2.Controls.Add(this.tbLastname);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(302, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available data";
            // 
            // textBoxPathPhoto
            // 
            this.textBoxPathPhoto.Location = new System.Drawing.Point(360, 248);
            this.textBoxPathPhoto.Multiline = true;
            this.textBoxPathPhoto.Name = "textBoxPathPhoto";
            this.textBoxPathPhoto.Size = new System.Drawing.Size(181, 32);
            this.textBoxPathPhoto.TabIndex = 25;
            // 
            // cbCountries
            // 
            this.cbCountries.FormattingEnabled = true;
            this.cbCountries.Location = new System.Drawing.Point(167, 209);
            this.cbCountries.Name = "cbCountries";
            this.cbCountries.Size = new System.Drawing.Size(187, 32);
            this.cbCountries.TabIndex = 24;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPhoto.Location = new System.Drawing.Point(360, 205);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(181, 37);
            this.buttonPhoto.TabIndex = 23;
            this.buttonPhoto.Text = "Select photo";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // dtPickerBirthday
            // 
            this.dtPickerBirthday.Location = new System.Drawing.Point(167, 166);
            this.dtPickerBirthday.Name = "dtPickerBirthday";
            this.dtPickerBirthday.Size = new System.Drawing.Size(187, 29);
            this.dtPickerBirthday.TabIndex = 23;
            // 
            // cbGenders
            // 
            this.cbGenders.FormattingEnabled = true;
            this.cbGenders.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbGenders.Location = new System.Drawing.Point(167, 120);
            this.cbGenders.Name = "cbGenders";
            this.cbGenders.Size = new System.Drawing.Size(187, 32);
            this.cbGenders.TabIndex = 22;
            // 
            // maskedtbPhone
            // 
            this.maskedtbPhone.Location = new System.Drawing.Point(167, 251);
            this.maskedtbPhone.Name = "maskedtbPhone";
            this.maskedtbPhone.Size = new System.Drawing.Size(187, 29);
            this.maskedtbPhone.TabIndex = 21;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(167, 77);
            this.tbLastname.Multiline = true;
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(187, 31);
            this.tbLastname.TabIndex = 17;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(167, 34);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(187, 31);
            this.tbName.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 26);
            this.label12.TabIndex = 16;
            this.label12.Text = "Phone number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 26);
            this.label10.TabIndex = 14;
            this.label10.Text = "Date birthday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 26);
            this.label9.TabIndex = 13;
            this.label9.Text = "Sex";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 26);
            this.label8.TabIndex = 12;
            this.label8.Text = "lastname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Firstname";
            // 
            // buttonGoRunner
            // 
            this.buttonGoRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoRunner.Location = new System.Drawing.Point(12, 341);
            this.buttonGoRunner.Name = "buttonGoRunner";
            this.buttonGoRunner.Size = new System.Drawing.Size(180, 36);
            this.buttonGoRunner.TabIndex = 22;
            this.buttonGoRunner.Text = "Back";
            this.buttonGoRunner.UseVisualStyleBackColor = true;
            this.buttonGoRunner.Click += new System.EventHandler(this.buttonGoRunner_Click);
            // 
            // buttonAdditionProfile
            // 
            this.buttonAdditionProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdditionProfile.Location = new System.Drawing.Point(467, 341);
            this.buttonAdditionProfile.Name = "buttonAdditionProfile";
            this.buttonAdditionProfile.Size = new System.Drawing.Size(180, 36);
            this.buttonAdditionProfile.TabIndex = 24;
            this.buttonAdditionProfile.Text = "Add profile";
            this.buttonAdditionProfile.UseVisualStyleBackColor = true;
            this.buttonAdditionProfile.Click += new System.EventHandler(this.buttonAdditionProfile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // runnersTableAdapter
            // 
            this.runnersTableAdapter.ClearBeforeFill = true;
            // 
            // runnersCountryTableAdapter1
            // 
            this.runnersGenderCountryTableAdapter1.ClearBeforeFill = true;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEdit.Location = new System.Drawing.Point(674, 341);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(180, 36);
            this.btEdit.TabIndex = 25;
            this.btEdit.Text = "Update profile";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(360, 34);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(180, 165);
            this.pbPhoto.TabIndex = 25;
            this.pbPhoto.TabStop = false;
            // 
            // RunnerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 384);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.buttonAdditionProfile);
            this.Controls.Add(this.buttonGoRunner);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "RunnerProfile";
            this.Text = "RunnerProfil";
            this.Load += new System.EventHandler(this.RunnerProfil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWallet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.MaskedTextBox maskedtbPhone;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCountries;
        private System.Windows.Forms.DateTimePicker dtPickerBirthday;
        private System.Windows.Forms.ComboBox cbGenders;
        private System.Windows.Forms.Button buttonGoRunner;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Button buttonAdditionProfile;
        private System.Windows.Forms.PictureBox pbPhoto;
        private Marathon_SkillsDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private Marathon_SkillsDataSetTableAdapters.RunnersTableAdapter runnersTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxPathPhoto;
        private Marathon_SkillsDataSetTableAdapters.RunnersGenderCountryTableAdapter runnersGenderCountryTableAdapter;
        private Marathon_SkillsDataSetTableAdapters.RunnersGenderCountryTableAdapter runnersGenderCountryTableAdapter1;
        private Marathon_SkillsDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.Button btEdit;
    }
}