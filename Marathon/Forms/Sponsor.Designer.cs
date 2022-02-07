
namespace Marathon
{
    partial class Sponsor
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
            this.btProfile = new System.Windows.Forms.Button();
            this.sponsorsTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter();
            this.usersTableAdapter = new Marathon.Marathon_SkillsDataSetTableAdapters.UsersTableAdapter();
            this.btSponsering = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btProfile
            // 
            this.btProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btProfile.Location = new System.Drawing.Point(12, 12);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(253, 41);
            this.btProfile.TabIndex = 1;
            this.btProfile.Text = "Профильэ";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // sponsorsTableAdapter
            // 
            this.sponsorsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btSponsering
            // 
            this.btSponsering.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSponsering.Location = new System.Drawing.Point(12, 59);
            this.btSponsering.Name = "btSponsering";
            this.btSponsering.Size = new System.Drawing.Size(253, 41);
            this.btSponsering.TabIndex = 2;
            this.btSponsering.Text = "Спонсировать бегуна";
            this.btSponsering.UseVisualStyleBackColor = true;
            this.btSponsering.Click += new System.EventHandler(this.btSponsering_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Результаты марафона";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(12, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Sponsor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSponsering);
            this.Controls.Add(this.btProfile);
            this.Name = "Sponsor";
            this.Text = "Спонсор";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btProfile;
        private Marathon_SkillsDataSetTableAdapters.SponsorsTableAdapter sponsorsTableAdapter;
        private Marathon_SkillsDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btSponsering;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}